'==============================================================================
'
' EveHQ - An Eve-Online™ character assistance application
' Copyright © 2005-2015  EveHQ Development Team
'
' This file is part of EveHQ.
'
' The source code for EveHQ is free and you may redistribute 
' it and/or modify it under the terms of the MIT License. 
'
' Refer to the NOTICES file in the root folder of EVEHQ source
' project for details of 3rd party components that are covered
' under their own, separate licenses.
'
' EveHQ is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the MIT 
' license below for details.
'
' ------------------------------------------------------------------------------
'
' The MIT License (MIT)
'
' Copyright © 2005-2015  EveHQ Development Team
'
' Permission is hereby granted, free of charge, to any person obtaining a copy
' of this software and associated documentation files (the "Software"), to deal
' in the Software without restriction, including without limitation the rights
' to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
' copies of the Software, and to permit persons to whom the Software is
' furnished to do so, subject to the following conditions:
'
' The above copyright notice and this permission notice shall be included in
' all copies or substantial portions of the Software.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
' IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
' FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
' AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
' LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
' OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
' THE SOFTWARE.
'
' ==============================================================================

Imports EveHQ.Prism.Classes
Imports DevComponents.DotNetBar
Imports EveHQ.EveAPI
Imports EveHQ.Core
Imports DevComponents.AdvTree
Imports EveHQ.EveData
Imports EveHQ.Prism.BPCalc
Imports System.Windows.Forms
Imports System.Xml
Imports System.Threading.Tasks
Imports System.Text
Imports EveHQ.Core.Requisitions
Imports EveHQ.Common.Extensions

Namespace Controls

    Public Class PrismResources

        Dim _currentJob As Job
        Dim _currentBP As OwnedBlueprint
        Dim _currentBatch As BatchJob
        Dim _ownedResources As New SortedList(Of Integer, SortedList(Of String, Long)) ' ItemID, (Location, Long)
        ReadOnly _groupResources As New SortedList(Of Integer, Long)
        ReadOnly _swapResources As New SortedList(Of Integer, SwapResource)
        ReadOnly _productionList As New SortedList(Of String, ProductionItem)

        Public Property ProductionJob() As Job
            Get
                Return _currentJob
            End Get
            Set(ByVal value As Job)
                _currentJob = Nothing
                ' Reset the "build all resources" check box, since we are switching jobs
                ' Setting the current job to nothing should prevent any side effect processing of the checked/unchecked event.
                chkUseStandardCosting.Checked = False
                _currentJob = value
                If _currentJob IsNot Nothing Then
                    If _currentJob.CurrentBlueprint IsNot Nothing Then
                        _currentJob.RecalculateResourceRequirements()
                        DisplayRequiredResources()
                        RaiseEvent ProductionResourcesChanged()
                    End If
                Else
                    DisplayRequiredResources()
                    RaiseEvent ProductionResourcesChanged()
                End If

            End Set
        End Property

        Public Property InventionBP() As OwnedBlueprint
            Get
                Return _currentBP
            End Get
            Set(ByVal value As OwnedBlueprint)
                If value IsNot Nothing Then
                    _currentBP = value
                    DisplayInventionResources()
                    tiInvention.Visible = True
                Else
                    tiInvention.Visible = False
                End If
            End Set
        End Property

        Public Property BatchJob() As BatchJob
            Get
                Return _currentBatch
            End Get
            Set(ByVal value As BatchJob)
                _currentBatch = value
                Call DisplayOwnedResources()
            End Set
        End Property

        Public ReadOnly Property BuildResources() As Boolean
            Get
                Return chkUseStandardCosting.Checked
            End Get
        End Property

        Public Event ProductionResourcesChanged()

        Public Sub New()

            ' This call is required by the Windows Form Designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            cboAssetSelection.DropDownControl = New PrismSelectionControl(PrismSelectionType.AllOwners, True, cboAssetSelection)

        End Sub

        Private Sub PrismResources_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            CType(cboAssetSelection.DropDownControl, PrismSelectionControl).UpdateOwnerList()
        End Sub

#Region "Invention Routines"

        Public Sub DisplayInventionResources()
            adtInventionResources.BeginUpdate()
            adtInventionResources.Nodes.Clear()
            Dim priceData As Task(Of Dictionary(Of Integer, Double)) = DataFunctions.GetMarketPrices(From r As EveData.BlueprintResource In _currentBP.Resources(BlueprintActivity.Invention).Values Select r.TypeId)
            priceData.Wait()
            Dim prices As Dictionary(Of Integer, Double) = priceData.Result

            For Each resource As EveData.BlueprintResource In _currentBP.Resources(BlueprintActivity.Invention).Values
                ' Add the resource to the list
                Dim newIr As New Node
                newIr.Text = StaticData.Types(resource.TypeId).Name
                newIr.Name = resource.TypeId.ToString
                newIr.Cells.Add(New Cell(resource.Quantity.ToString))
                Dim irPrice As Double = prices(resource.TypeId)
                newIr.Cells.
                    Add(New Cell(irPrice.ToString))
                newIr.Cells.Add(New Cell((irPrice * resource.Quantity).ToString))
                adtInventionResources.Nodes.Add(newIr)
                For c As Integer = 1 To 3
                    newIr.Cells(c).TextDisplayFormat = "N0"
                Next
            Next
            AdvTreeSorter.Sort(adtInventionResources, 1, True, True)
            adtInventionResources.EndUpdate()
            ' Hide the invention tab if we don't have invention resources
            If adtInventionResources.Nodes.Count = 0 Then
                tiInvention.Visible = False
            Else
                tiInvention.Visible = True
            End If
        End Sub

        Private Sub adtInventionResources_ColumnHeaderMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles adtInventionResources.ColumnHeaderMouseDown
            Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
            AdvTreeSorter.Sort(ch, True, False)
        End Sub

#End Region

#Region "Production Routines"

        Private Sub chkShowSkills_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkShowSkills.CheckedChanged
            Call DisplayRequiredResources()
        End Sub

        Private Sub chkUseStandardCosting_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkUseStandardCosting.CheckedChanged
            If _currentJob IsNot Nothing Then
                If (_currentJob.CurrentBlueprint IsNot Nothing) Then
                    _currentJob.CalculateResourceRequirements(chkUseStandardCosting.Checked, _currentJob.BlueprintOwner)
                    Call DisplayRequiredResources()
                    RaiseEvent ProductionResourcesChanged()
                End If
            End If
        End Sub

        Private Sub DisplayRequiredResources()

            adtResources.BeginUpdate()
            adtResources.Nodes.Clear()

            If _currentJob IsNot Nothing Then
                Dim priceData As Task(Of Dictionary(Of Integer, Double)) = DataFunctions.GetMarketPrices(From r In _currentJob.Resources.Values Where typeof(r) Is JobResource Let res = r Select res.TypeID)
                Dim jobCostTask As Task(Of Dictionary(Of Integer, Double)) = DataFunctions.GetMarketPrices(From r In _currentJob.SubJobs.Values Where typeof(r) Is Job Let res = r Select res.TypeID)
                Task.WaitAll(priceData, jobCostTask)
                ' resource costs
                Dim resourceCosts As Dictionary(Of Integer, Double) = priceData.Result
                ' production job costs
                Dim jobCosts As Dictionary(Of Integer, Double) = jobCostTask.Result
                For Each resource As JobResource In _currentJob.Resources.Values
                    ' This is a resource so add it
                    If resource.TypeCategory <> 16 Or (resource.TypeCategory = 16 And chkShowSkills.Checked = True) Then
                        Dim perfectRaw As Long = CInt(resource.PerfectUnits) * _currentJob.Runs
                        Dim waste As Integer = CInt(resource.WasteUnits)
                        Dim total As Long = perfectRaw + waste
                        Dim price As Double = resourceCosts(resource.TypeID)
                        Dim value As Double = total * price
                        ' Add a new list view item
                        If total > 0 Then
                            Dim newRes As New Node(resource.TypeName)
                            newRes.TextDisplayFormat = "N0"
                            ' Calculate costs
                            If resource.TypeCategory <> 16 Then
                                ' Not a skill
                            Else
                                ' A skill
                                newRes.Text &= " (Lvl " & SkillFunctions.Roman(perfectRaw) & ")"
                                ' Check for skill of recycler
                                If SkillFunctions.IsSkillTrained(HQ.Settings.Pilots(_currentJob.Manufacturer), resource.TypeName, perfectRaw) = True Then
                                    ' TODO - add colour and alignment styles
                                    'newRes.BackColor = Drawing.Color.LightGreen
                                Else
                                    'newRes.BackColor = Drawing.Color.LightCoral
                                End If
                                perfectRaw = 0 : waste = 0 : total = 0 : value = 0
                            End If
                            If PlugInData.Products.ContainsKey(resource.TypeID.ToString) = True Then
                                newRes.Cells.Add(New Cell("0"))
                                Dim bpme As New BlueprintMEControl
                                bpme.nudME.Value = 0

                                bpme.AssignedTypeID = resource.TypeID.ToString
                                bpme.ParentJob = _currentJob
                                AddHandler bpme.ResourcesChanged, AddressOf UpdateResources
                                newRes.Cells(1).HostedControl = bpme
                            Else
                                newRes.Cells.Add(New Cell(""))
                            End If

                            Dim perfectTotal As Long = CLng(perfectRaw)
                            Dim wasteTotal As Long = CLng(waste)
                            Dim totalTotal As Long = CLng(total)

                            newRes.Cells.Add(New Cell(perfectTotal.ToString))
                            newRes.Cells.Add(New Cell(wasteTotal.ToString))
                            newRes.Cells.Add(New Cell(totalTotal.ToString))
                            newRes.Cells.Add(New Cell(price.ToString))
                            newRes.Cells.Add(New Cell(value.ToString))
                            For c As Integer = 1 To 6
                                Select Case c
                                    Case 2, 3, 4
                                        newRes.Cells(c).TextDisplayFormat = "N0"
                                    Case Else
                                        newRes.Cells(c).TextDisplayFormat = "N2"
                                End Select
                            Next

                            adtResources.Nodes.Add(newRes)
                            ' Add tooltip if appropriate
                            Dim msg As String = "Total Base Material: " & perfectTotal.ToString("N0") & ControlChars.CrLf
                            msg &= "Material Saved: " & wasteTotal.ToString("N0") & ControlChars.CrLf
                            msg &= "Total Required: " & totalTotal.ToString("N0")
                            Dim sti As New SuperTooltipInfo("Resource Split", resource.TypeName, msg, Nothing, ImageHandler.GetImage(resource.TypeID, 32), eTooltipColor.Yellow)
                            STT.SetSuperTooltip(newRes, sti)
                        End If
                    End If
                Next
                For Each subJob As Job In _currentJob.SubJobs.Values
                    ' This is another production job
                    Dim perfectRaw As Long = CInt(subJob.PerfectUnits) * _currentJob.Runs
                    Dim waste As Integer = CInt(subJob.WasteUnits)
                    Dim total As Long = perfectRaw + waste
                    Dim price As Double = jobCosts(subJob.TypeID)
                    Dim value As Double = total * price
                    Dim newRes As New Node(subJob.TypeName)
                    newRes.TextDisplayFormat = "N0"
                    If PlugInData.Products.ContainsKey(subJob.TypeID.ToString) = True Then
                        newRes.Cells.Add(New Cell(subJob.CurrentBlueprint.MELevel.ToString))
                        Dim bpme As New BlueprintMEControl
                        bpme.nudME.Value = subJob.CurrentBlueprint.MELevel
                        bpme.nudME.LockUpdateChecked = True
                        bpme.nudME.ButtonCustom.Enabled = True
                        bpme.nudME.ButtonCustom.Enabled = False
                        bpme.AssignedTypeID = subJob.TypeID.ToString
                        bpme.ParentJob = _currentJob
                        bpme.AssignedJob = subJob
                        AddHandler bpme.ResourcesChanged, AddressOf UpdateResources
                        newRes.Cells(1).HostedControl = bpme
                    Else
                        newRes.Cells.Add(New Cell(""))
                    End If
                    newRes.Cells.Add(New Cell(perfectRaw.ToString))
                    newRes.Cells.Add(New Cell(waste.ToString))
                    newRes.Cells.Add(New Cell(total.ToString))
                    newRes.Cells.Add(New Cell(price.ToString))
                    newRes.Cells.Add(New Cell((value * _currentJob.Runs).ToString))
                    Dim bpDetails As New StringBuilder
                    bpDetails.AppendLine("The blueprint used for this job is as follows:")
                    bpDetails.AppendLine("")
                    bpDetails.AppendLine("ME Level: " & subJob.CurrentBlueprint.MELevel.ToString)
                    bpDetails.AppendLine("PE Level: " & subJob.CurrentBlueprint.PELevel.ToString)
                    bpDetails.AppendLine("Runs: " & subJob.CurrentBlueprint.Runs.ToString)
                    Dim tti As New SuperTooltipInfo("Blueprint Details", subJob.TypeName, bpDetails.ToString, Nothing, Nothing, eTooltipColor.Yellow)
                    STT.SetSuperTooltip(newRes, tti)
                    Call DisplayJob(subJob, newRes)
                    ' Recalculate sub prices
                    Dim subprice As Double = 0
                    For Each subRes As Node In newRes.Nodes
                        subprice += CDbl(subRes.Cells(6).Text)
                    Next
                    newRes.Cells(6).Text = subprice.ToString
                    newRes.Cells(5).Text = (subprice / subJob.Runs).ToString
                    For c As Integer = 1 To 6
                        Select Case c
                            Case 2, 3, 4
                                newRes.Cells(c).TextDisplayFormat = "N0"
                            Case Else
                                newRes.Cells(c).TextDisplayFormat = "N2"
                        End Select
                    Next
                    adtResources.Nodes.Add(newRes)
                Next
                For c As Integer = 0 To 6
                    adtResources.Columns(c).Image = Nothing
                Next
            End If
            AdvTreeSorter.Sort(adtResources, 5, True, True)
            adtResources.EndUpdate()

            ' Display owned resources
            Call DisplayOwnedResources()

        End Sub

        Private Sub DisplayJob(ByVal parentJob As Job, ByVal parentRes As Node)
            Dim resourceTask As Task(Of Dictionary(Of Integer, Double)) = DataFunctions.GetMarketPrices(From r In parentJob.Resources.Values Where typeof(r) Is JobResource Let res = r Select res.TypeID)
            Dim jobTask As Task(Of Dictionary(Of Integer, Double)) = DataFunctions.GetMarketPrices(From r In parentJob.SubJobs.Values Where typeof(r) Is Job Let res = r Select res.TypeID)
            Task.WaitAll(resourceTask, jobTask)
            ' resource costs
            Dim resourceCosts As Dictionary(Of Integer, Double) = resourceTask.Result
            ' production job costs
            Dim jobCosts As Dictionary(Of Integer, Double) = jobTask.Result
            For Each resource As JobResource In parentJob.Resources.Values
                ' This is a resource so add it
                If resource.TypeCategory <> 16 Or (resource.TypeCategory = 16 And chkShowSkills.Checked = True) Then
                    Dim perfectRaw As Long = CLng(resource.PerfectUnits) * parentJob.Runs
                    Dim waste As Long = CLng(resource.WasteUnits)
                    Dim total As Long = perfectRaw + waste
                    Dim price As Double = resourceCosts(resource.TypeID)
                    Dim value As Double = total * price
                    ' Add a new list view item
                    Dim newRes As New Node(resource.TypeName)
                    newRes.TextDisplayFormat = "N0"
                    ' Calculate costs
                    If resource.TypeCategory <> 16 Then
                        ' Not a skill
                    Else
                        ' A skill
                        newRes.Text &= " (Lvl " & SkillFunctions.Roman(CInt(resource.PerfectUnits)) & ")"
                        ' Check for skill of recycler
                        If SkillFunctions.IsSkillTrained(HQ.Settings.Pilots(parentJob.Manufacturer), resource.TypeName, CInt(resource.PerfectUnits)) = True Then
                            ' TODO - add colour and alignment styles
                            'newRes.BackColor = Drawing.Color.LightGreen
                        Else
                            'newRes.BackColor = Drawing.Color.LightCoral
                        End If
                        perfectRaw = 0 : waste = 0 : total = 0 : value = 0
                    End If
                    If PlugInData.Products.ContainsKey(resource.TypeID.ToString) = True Then
                        newRes.Cells.Add(New Cell("0"))
                        Dim bpme As New BlueprintMEControl
                        bpme.nudME.Value = 0
                        bpme.AssignedTypeID = resource.TypeID.ToString
                        bpme.ParentJob = parentJob
                        AddHandler bpme.ResourcesChanged, AddressOf UpdateResources
                        newRes.Cells(1).HostedControl = bpme
                    Else
                        newRes.Cells.Add(New Cell(""))
                    End If
                    newRes.Cells.Add(New Cell(perfectRaw.ToString))
                    newRes.Cells.Add(New Cell(waste.ToString))
                    newRes.Cells.Add(New Cell(total.ToString))
                    newRes.Cells.Add(New Cell(price.ToString))
                    newRes.Cells.Add(New Cell(value.ToString))
                    newRes.Cells.Add(New Cell((Int(resource.BaseUnits / parentJob.CurrentBlueprint.MaterialModifier)).ToString))
                    For c As Integer = 1 To 6
                        Select Case c
                            Case 2, 3, 4
                                newRes.Cells(c).TextDisplayFormat = "N0"
                            Case Else
                                newRes.Cells(c).TextDisplayFormat = "N2"
                        End Select
                    Next
                    parentRes.Nodes.Add(newRes)
                    ' Add tooltip if appropriate
                    Dim msg As String = "Total Base Material: " & perfectRaw.ToString("N0") & ControlChars.CrLf
                    msg &= "Material Saved: " & waste.ToString("N0") & ControlChars.CrLf
                    msg &= "Total Required: " & total.ToString("N0")
                    Dim sti As New SuperTooltipInfo("Resource Split", resource.TypeName, msg, Nothing, ImageHandler.GetImage(resource.TypeID, 32), eTooltipColor.Yellow)
                    STT.SetSuperTooltip(newRes, sti)
                End If
            Next
            For Each subJob As Job In parentJob.SubJobs.Values
                ' This is another production job
                Dim perfectRaw As Integer = CInt(subJob.PerfectUnits)
                Dim waste As Integer = CInt(subJob.WasteUnits)
                Dim runs As Long = parentJob.Runs
                Dim total As Integer = perfectRaw + waste
                Dim price As Double = jobCosts(subJob.TypeID)
                Dim value As Double = total * price
                Dim newRes As New Node(subJob.TypeName)
                newRes.TextDisplayFormat = "N0"
                If PlugInData.Products.ContainsKey(subJob.TypeID.ToString) = True Then
                    newRes.Cells.Add(New Cell(subJob.CurrentBlueprint.MELevel.ToString))
                    Dim bpme As New BlueprintMEControl
                    bpme.nudME.Value = subJob.CurrentBlueprint.MELevel
                    bpme.nudME.LockUpdateChecked = True
                    bpme.nudME.ButtonCustom.Enabled = True
                    bpme.nudME.ButtonCustom.Enabled = False
                    bpme.AssignedTypeID = subJob.TypeID.ToString
                    bpme.ParentJob = parentJob
                    bpme.AssignedJob = subJob
                    AddHandler bpme.ResourcesChanged, AddressOf UpdateResources
                    newRes.Cells(1).HostedControl = bpme
                Else
                    newRes.Cells.Add(New Cell(""))
                End If
                newRes.Cells.Add(New Cell((perfectRaw * runs).ToString))
                newRes.Cells.Add(New Cell((waste * runs).ToString))
                newRes.Cells.Add(New Cell((total * runs).ToString))
                newRes.Cells.Add(New Cell(price.ToString))
                newRes.Cells.Add(New Cell((value * runs).ToString))
                newRes.Cells.Add(New Cell((Int(perfectRaw / parentJob.CurrentBlueprint.MaterialModifier)).ToString))
                Dim bpDetails As New StringBuilder
                bpDetails.AppendLine("The blueprint used for this job is as follows:")
                bpDetails.AppendLine("")
                bpDetails.AppendLine("ME Level: " & subJob.CurrentBlueprint.MELevel.ToString)
                bpDetails.AppendLine("PE Level: " & subJob.CurrentBlueprint.PELevel.ToString)
                bpDetails.AppendLine("Runs: " & subJob.CurrentBlueprint.Runs.ToString)
                Dim tti As New SuperTooltipInfo("Blueprint Details", subJob.TypeName, bpDetails.ToString, Nothing, Nothing, eTooltipColor.Yellow)
                STT.SetSuperTooltip(newRes, tti)
                Call DisplayJob(subJob, newRes)
                ' Recalculate sub prices
                Dim subprice As Double = 0
                For Each subRes As Node In newRes.Nodes
                    subprice += CDbl(subRes.Cells(6).Text)
                Next
                newRes.Cells(6).Text = subprice.ToString
                newRes.Cells(5).Text = (subprice / subJob.Runs).ToString
                For c As Integer = 1 To 7
                    Select Case c
                        Case 2, 3, 4, 7
                            newRes.Cells(c).TextDisplayFormat = "N0"
                        Case Else
                            newRes.Cells(c).TextDisplayFormat = "N2"
                    End Select
                Next
                parentRes.Nodes.Add(newRes)
            Next
        End Sub

        Private Sub adtResources_ColumnHeaderMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles adtResources.ColumnHeaderMouseDown
            Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
            AdvTreeSorter.Sort(ch, True, False)
        End Sub

#End Region

#Region "Owned Resources Routines"

        Private Sub DisplayOwnedResources()
            _ownedResources.Clear()
            _groupResources.Clear()
            _swapResources.Clear()

            ' Get the relevant details
            Call GetBatchResources()

            Call GetOwnedResources()

            If chkAdvancedResourceAllocation.Checked = True Then
                Call CheckSwapResources()
            End If

            ' Display the resources owned
            Dim itemData As EveType
            Dim reqd, owned, surplus As Long
            Dim maxProducableUnits As Long = -1
            adtOwnedResources.BeginUpdate()
            adtOwnedResources.Nodes.Clear()
            For Each itemID As Integer In _groupResources.Keys
                reqd = _groupResources(itemID)
                If reqd > 0 Then
                    itemData = StaticData.Types(itemID)
                    If _ownedResources.ContainsKey(itemID) = True Then
                        owned = _ownedResources(itemID).Item("TotalOwned")
                        If maxProducableUnits = -1 Then
                            maxProducableUnits = CLng(Int(owned / reqd))
                        Else
                            maxProducableUnits = Math.Min(maxProducableUnits, CLng(Int(owned / reqd)))
                        End If
                    Else
                        owned = 0
                        maxProducableUnits = 0
                    End If
                    surplus = owned - reqd
                    Dim newORes As New Node(itemData.Name)

                    newORes.Cells.Add(New Cell(reqd.ToString("N0")))
                    newORes.Cells.Add(New Cell(owned.ToString("N0")))
                    newORes.Cells.Add(New Cell(surplus.ToString("N0")))
                    newORes.Cells(3).Tag = surplus
                    ' Add locations
                    If _ownedResources.ContainsKey(itemID) = True Then
                        If _ownedResources(itemID).Count > 1 Then
                            For Each resourceLocation As String In _ownedResources(itemID).Keys
                                If resourceLocation <> "TotalOwned" Then
                                    Dim newLoc As New Node(Locations.GetLocationFromID(CLng(resourceLocation)).ContainerName)
                                    newLoc.Cells.Add(New Cell(""))
                                    newLoc.Cells.Add(New Cell(_ownedResources(itemID).Item(resourceLocation).ToString("N0")))
                                    newLoc.Cells.Add(New Cell(""))
                                    newORes.Nodes.Add(newLoc)
                                End If
                            Next
                        End If
                    End If
                    adtOwnedResources.Nodes.Add(newORes)
                    ' TODO: Fix styles
                    'If surplus < 0 Then
                    '    newORes.SubItems(3).ForeColor = Drawing.Color.Red
                    'Else
                    '    newORes.SubItems(3).ForeColor = Drawing.Color.Green
                    'End If
                    For c As Integer = 1 To 3
                        newORes.Cells(c).TextDisplayFormat = "N0"
                    Next
                End If
            Next
            AdvTreeSorter.Sort(adtOwnedResources, 1, True, True)
            adtOwnedResources.EndUpdate()

            If maxProducableUnits = -1 Then
                lblMaxUnits.Text = "Maximum Producable Units: n/a"
            Else
                lblMaxUnits.Text = "Maximum Producable Units: " & maxProducableUnits.ToString("N0")
            End If

        End Sub

        Private Sub GetResourcesFromJob(ByVal pJob As Job)

            ' Set Production List
            Dim pi As New ProductionItem(pJob.TypeID.ToString, True, pJob.Runs)
            If _productionList.ContainsKey(pi.Key) = False Then
                _productionList.Add(pi.Key, pi)
            Else
                _productionList(pi.Key).Quantity += pi.Quantity
            End If

            Dim sr As New SwapResource
            If pJob.TypeID <> pJob.CurrentBlueprint.Id Then
                If _swapResources.ContainsKey(pJob.TypeID) = True Then
                    sr = _swapResources(pJob.TypeID)
                    sr.Quantity += pJob.Runs
                Else
                    sr.Quantity = pJob.Runs
                    _swapResources.Add(pJob.TypeID, sr)
                End If
            End If

            For Each resource As JobResource In pJob.Resources.Values
                If resource.TypeCategory <> 16 Then
                    ' Add as a "swap" resource - something we can later substitute for lower resources if we have them
                    ' Check this is not a blueprint swap!
                    If pJob.TypeID <> pJob.CurrentBlueprint.Id Then
                        If sr.Resources.ContainsKey(resource.TypeID) = False Then
                            sr.Resources.Add(resource.TypeID, CLng(resource.PerfectUnits * pJob.Runs) + CLng(resource.WasteUnits))
                        Else
                            'SR.Resources(rResource.TypeID.ToString) += CLng(rResource.PerfectUnits + rResource.WasteUnits)
                        End If
                    End If
                    ' This is a resource so add it
                    If _groupResources.ContainsKey(resource.TypeID) = False Then
                        _groupResources.Add(resource.TypeID, CLng(resource.PerfectUnits * pJob.Runs) + CLng(resource.WasteUnits))
                    Else
                        _groupResources(resource.TypeID) += CLng(resource.PerfectUnits * pJob.Runs) + CLng(resource.WasteUnits)
                    End If
                    ' Set Production List
                    Dim pi2 As New ProductionItem(resource.TypeID.ToString, False, CLng(resource.PerfectUnits * pJob.Runs) + CLng(resource.WasteUnits))
                    If _productionList.ContainsKey(pi2.Key) = False Then
                        _productionList.Add(pi2.Key, pi2)
                    Else
                        _productionList(pi2.Key).Quantity += pi2.Quantity
                    End If
                End If
            Next
            For Each subJob As Job In pJob.SubJobs.Values
                ' This is another production job
                ' Add as a "swap" resource - something we can later substitute for lower resources if we have them
                If pJob.TypeID <> pJob.CurrentBlueprint.Id Then
                    If sr.Resources.ContainsKey(subJob.TypeID) = False Then
                        sr.Resources.Add(subJob.TypeID, subJob.Runs)
                    Else
                        sr.Resources(subJob.TypeID) += subJob.Runs
                    End If
                End If
                Call GetResourcesFromJob(subJob)
            Next

        End Sub

        Private Sub CheckSwapResources()
            ' Loop through swap resources to see what we could potentially save (ignore the main job though!)
            For Each swapID As Integer In _swapResources.Keys
                If swapID <> _currentJob.TypeID Then
                    Dim sr As SwapResource = _swapResources(swapID)
                    ' Check if we have a partial or full match
                    If _ownedResources.ContainsKey(swapID) Then
                        ' We own something for the swap, let's see how much
                        Dim owned As Long = _ownedResources(swapID).Item("TotalOwned")
                        ' How many do we need?
                        Dim reqs As Long = sr.Quantity
                        ' Can we make at least some saving of production?
                        Dim saving As Long = Math.Min(reqs, owned)
                        ' Substitute some of the resources
                        If saving > 0 Then
                            For Each savedResource As Integer In sr.Resources.Keys
                                If _groupResources.ContainsKey(savedResource) = True Then
                                    _groupResources(savedResource) -= sr.Resources(savedResource) * saving
                                Else
                                    Dim msg As String = StaticData.Types(savedResource).Name & " (ID:" & savedResource & ") is not present in the group resources for " & _currentJob.JobName
                                    msg &= ControlChars.CrLf & ControlChars.CrLf
                                    MessageBox.Show(msg, "Resource Allocation Error", MessageBoxButtons.OK)
                                End If
                            Next
                        End If
                        ' Add the current saving to the group resources
                        If _groupResources.ContainsKey(swapID) = True Then
                            _groupResources(swapID) += saving
                        Else
                            _groupResources.Add(swapID, saving)
                        End If
                    End If
                End If
            Next
        End Sub

        Private Sub GetOwnedResources()

            Dim owner As PrismOwner

            For Each cOwner As ListViewItem In CType(cboAssetSelection.DropDownControl, PrismSelectionControl).lvwItems.CheckedItems

                If PlugInData.PrismOwners.ContainsKey(cOwner.Text) = True Then
                    owner = PlugInData.PrismOwners(cOwner.Text)
                    Dim ownerAccount As EveHQAccount = PlugInData.GetAccountForCorpOwner(owner, CorpRepType.Assets)
                    Dim ownerID As String = PlugInData.GetAccountOwnerIDForCorpOwner(owner, CorpRepType.Assets)

                    If ownerAccount IsNot Nothing Then

                        Dim assetData As NewEveApi.EveServiceResponse(Of IEnumerable(Of NewEveApi.Entities.AssetItem))
                        If owner.IsCorp = True Then
                            assetData = HQ.ApiProvider.Corporation.AssetList(ownerAccount.UserID, ownerAccount.APIKey, ownerID.ToInt32())
                        Else
                            assetData = HQ.ApiProvider.Character.AssetList(ownerAccount.UserID, ownerAccount.APIKey, ownerID.ToInt32())
                        End If

                        If assetData IsNot Nothing Then

                            If assetData.IsSuccess Then
                                ' Define what we want to obtain
                                Dim categories, groups As New ArrayList
                                For Each item In assetData.ResultData
                                    Call GetAssetQuantitesFromNode(item, item, categories, groups, _ownedResources)
                                Next
                            End If
                        End If
                    End If
                End If
            Next

        End Sub

        Private Sub GetAssetQuantitesFromNode(ByVal root As NewEveApi.Entities.AssetItem, ByVal item As NewEveApi.Entities.AssetItem, ByVal categories As ArrayList, ByVal groups As ArrayList, ByRef assets As SortedList(Of Integer, SortedList(Of String, Long)))
            Dim itemData As EveType
            Dim itemID As Integer = item.TypeId
            Dim locationKey = root.LocationId.ToInvariantString()
            If StaticData.Types.ContainsKey(itemID) Then
                itemData = StaticData.Types(itemID)
                If categories.Contains(itemData.Category) Or groups.Contains(itemData.Group) Or _groupResources.ContainsKey(itemData.Id) Or _swapResources.ContainsKey(itemData.Id) Then
                    ' Check if the item is in the list
                    If assets.ContainsKey(itemData.Id) = False Then
                        Dim locations As New SortedList(Of String, Long)
                        locations.Add(locationKey, item.Quantity)
                        locations.Add("TotalOwned", item.Quantity)
                        assets.Add(itemData.Id, locations)
                    Else
                        Dim locations As SortedList(Of String, Long) = assets(itemData.Id)
                        If locations.ContainsKey(locationKey) = False Then
                            locations.Add(locationKey, item.Quantity)
                            locations("TotalOwned") += item.Quantity
                        Else
                            locations(locationKey) += item.Quantity
                            locations("TotalOwned") += item.Quantity
                        End If
                    End If
                End If
            End If
            ' Check child items if they exist
            If item.Contents IsNot Nothing Then
                For Each subitem In item.Contents
                    Call GetAssetQuantitesFromNode(root, subitem, categories, groups, assets)
                Next
            End If
        End Sub

        Private Sub adtOwnedResources_ColumnHeaderMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles adtOwnedResources.ColumnHeaderMouseDown
            Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
            AdvTreeSorter.Sort(ch, True, False)
        End Sub

        Private Sub cboAssetSelection_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboAssetSelection.TextChanged
            Call DisplayOwnedResources()
        End Sub

        Private Sub btnExportToCSV_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportToCSV.Click
            Call ExportToClipboard("Resource Availability for " & _currentJob.TypeName & " (" & _currentJob.Runs & " runs)", adtOwnedResources, HQ.Settings.CsvSeparatorChar)
        End Sub

        Private Sub btnExportToTSV_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportToTSV.Click
            Call ExportToClipboard("Resource Availability for " & _currentJob.TypeName & " (" & _currentJob.Runs & " runs)", adtOwnedResources, ControlChars.Tab)
        End Sub

        Private Sub ExportToClipboard(ByVal title As String, ByVal sourceList As AdvTree, ByVal sepChar As String)
            Dim str As New StringBuilder
            ' Add a line for the current build job
            str.AppendLine(title)
            str.AppendLine("")
            ' Add some headings
            For c As Integer = 0 To sourceList.Columns.Count - 2
                str.Append(sourceList.Columns(c).Text & sepChar)
            Next
            str.AppendLine(sourceList.Columns(sourceList.Columns.Count - 1).Text)
            ' Add the details
            For Each req As Node In sourceList.Nodes
                For c As Integer = 0 To sourceList.Columns.Count - 2
                    str.Append(req.Cells(c).Text & sepChar)
                Next
                str.AppendLine(req.Cells(sourceList.Columns.Count - 1).Text)
            Next
            ' Copy to the clipboard
            Try
                Clipboard.SetText(str.ToString)
            Catch ex As Exception
                MessageBox.Show("Unable to copy Resource Data to the clipboard.", "Clipboard Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        Private Sub btnAddShortfallToReq_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddShortfallToReq.Click
            ' Set up a new Sortedlist to store the required items
            Dim orders As SortedList(Of String, Integer) = GetAmountsForRequisition(True)
            ' Setup the Requisition form for HQF and open it
            Using newReq As New FrmAddRequisition("Prism", orders)
                newReq.ShowDialog()
            End Using
        End Sub

        Private Sub btnAddAllToReq_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddAllToReq.Click
            ' Set up a new Sortedlist to store the required items
            Dim orders As SortedList(Of String, Integer) = GetAmountsForRequisition(False)
            ' Setup the Requisition form for HQF and open it
            Using newReq As New FrmAddRequisition("Prism", orders)
                newReq.ShowDialog()
            End Using
        End Sub

        Private Function GetAmountsForRequisition(ByVal surplusOnly As Boolean) As SortedList(Of String, Integer)
            Dim reqOrders As New SortedList(Of String, Integer)
            ' Display the resources owned
            Dim itemData As EveType
            Dim reqd, owned, surplus As Long
            For Each itemID As Integer In _groupResources.Keys
                reqd = _groupResources(itemID)
                If reqd > 0 Then
                    If _ownedResources.ContainsKey(itemID) = True Then
                        owned = _ownedResources(itemID).Item("TotalOwned")
                    Else
                        owned = 0
                    End If
                    surplus = reqd - owned
                    itemData = StaticData.Types(itemID)
                    If surplusOnly = False Then
                        reqOrders.Add(itemData.Name, CInt(reqd))
                    Else
                        If surplus > 0 Then
                            reqOrders.Add(itemData.Name, CInt(surplus))
                        End If
                    End If
                End If
            Next
            Return reqOrders
        End Function

        Private Sub chkAdvancedResourceAllocation_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAdvancedResourceAllocation.CheckedChanged
            Call DisplayOwnedResources()
        End Sub

#End Region

#Region "Batch Routines"

        Private Sub GetBatchResources()
            _productionList.Clear()
            If BatchJob IsNot Nothing Then
                _groupResources.Clear()
                For Each jobName As String In BatchJob.ProductionJobs
                    ' Bug 69 : if there is a mismatch between these two collections then an error will occur
                    If (Jobs.JobList.ContainsKey((jobName))) Then
                        Call GetResourcesFromJob(Jobs.JobList(jobName))
                    End If
                Next
                lblBatchName.Text = "Batch: " & BatchJob.BatchName
            Else
                If _currentJob IsNot Nothing Then
                    If _currentJob.TypeID <> 0 Then
                        Call GetResourcesFromJob(_currentJob)
                        lblBatchName.Text = "Batch: From Production Job - " & _currentJob.JobName
                    Else
                        lblBatchName.Text = "Batch: <None>"
                    End If
                Else
                    lblBatchName.Text = "Batch: <None>"
                End If
            End If
            ' Display the batch resources
            Call DisplayBatchResources()
        End Sub

        Private Sub DisplayBatchResources()
            Dim itemData As EveType
            Dim reqd As Long
            Dim batchValue As Double = 0
            Dim batchVolume As Double = 0
            adtBatchResources.BeginUpdate()
            adtBatchResources.Nodes.Clear()
            ' batch price request ... yes it goes through the collection more than once, but 1 possible web request is better than dozens.
            Dim costTask As Task(Of Dictionary(Of Integer, Double)) = DataFunctions.GetMarketPrices(From items In _groupResources.Keys)
            costTask.Wait()
            Dim costs As Dictionary(Of Integer, Double) = costTask.Result
            For Each itemID As Integer In _groupResources.Keys
                reqd = _groupResources(itemID)
                If reqd > 0 Then
                    itemData = StaticData.Types(itemID)
                    Dim newORes As New Node(itemData.Name)
                    Dim price As Double = costs(itemID)
                    newORes.Cells.Add(New Cell(reqd.ToString("N0")))
                    newORes.Cells.Add(New Cell(price.ToString("N2")))
                    newORes.Cells.Add(New Cell((price * reqd).ToString("N2")))
                    newORes.Cells.Add(New Cell((itemData.Volume * reqd).ToString("N2")))
                    batchValue += (price * reqd)
                    batchVolume += (itemData.Volume * reqd)
                    adtBatchResources.Nodes.Add(newORes)
                    ' TODO: Fix styles
                    'If surplus < 0 Then
                    '    newORes.SubItems(3).ForeColor = Drawing.Color.Red
                    'Else
                    '    newORes.SubItems(3).ForeColor = Drawing.Color.Green
                    'End If
                End If
            Next
            AdvTreeSorter.Sort(adtBatchResources, 1, True, True)
            adtBatchResources.EndUpdate()
            lblBatchTotals.Text = "Batch Value: " & batchValue.ToString("N2") & " isk  ,  Batch Volume: " & batchVolume.ToString("N2") & " m³"
            Call DisplayProductionList()
        End Sub

        Private Sub DisplayProductionList()
            Dim itemData As EveType
            adtProductionList.BeginUpdate()
            adtProductionList.Nodes.Clear()
            Dim priceTask As Task(Of Dictionary(Of Integer, Double)) = DataFunctions.GetMarketPrices(From pi In _productionList.Values Select CInt(pi.ItemID))
            priceTask.Wait()
            Dim prices As Dictionary(Of Integer, Double) = priceTask.Result
            For Each pi As ProductionItem In _productionList.Values
                If pi.IsBuild = True Then
                    itemData = StaticData.Types(CInt(pi.ItemID))
                    If itemData.Category <> 9 Then
                        Dim newPI As New Node(itemData.Name)
                        Dim price As Double = prices(CInt(pi.ItemID))
                        newPI.Cells.Add(New Cell(pi.Quantity.ToString("N0")))
                        newPI.Cells.Add(New Cell(price.ToString("N2")))
                        newPI.Cells.Add(New Cell((price * pi.Quantity).ToString("N2")))
                        adtProductionList.Nodes.Add(newPI)
                    End If
                End If
            Next
            AdvTreeSorter.Sort(adtProductionList, 1, True, True)
            adtProductionList.EndUpdate()
        End Sub

        Private Sub adtProductionList_ColumnHeaderMouseDown(sender As Object, e As MouseEventArgs) Handles adtProductionList.ColumnHeaderMouseDown
            Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
            AdvTreeSorter.Sort(ch, True, False)
        End Sub

#End Region

#Region "BPMEControl Functions"

        Private Sub UpdateResources()
            Call DisplayRequiredResources()
            RaiseEvent ProductionResourcesChanged()
        End Sub

#End Region

#Region "Pricing Update Routines"

        Private Sub btnAlterResourcePrices_Click(sender As Object, e As EventArgs) Handles btnAlterResourcePrices.Click

            Call ModifyPrices()

        End Sub

        Private Sub btnUpdateBatchPrices_Click(sender As Object, e As EventArgs) Handles btnUpdateBatchPrices.Click

            Call ModifyPrices()

        End Sub

        Private Sub ModifyPrices()

            ' Collect a list of resources from the Production Panel
            Dim itemIDs As New List(Of Integer)

            Call AddPricingResources(_currentJob, itemIDs)

            ' Create a new price form instance
            Using modifyPrices As New FrmModifyPrices(itemIDs)

                ' Show the form
                modifyPrices.ShowDialog()

                ' Check if we need to update prices
                If modifyPrices.DialogResult = DialogResult.OK Then
                    _currentJob.RecalculateResourceRequirements()
                    Call DisplayRequiredResources()
                    RaiseEvent ProductionResourcesChanged()
                End If

                ' Dispose of the form
            End Using

        End Sub

        Private Sub AddPricingResources(ByVal parentJob As Job, ByRef itemIDs As List(Of Integer))

            For Each resource As JobResource In parentJob.Resources.Values
                If resource.TypeCategory <> 16 Then
                    If itemIDs.Contains(resource.TypeID) = False Then
                        itemIDs.Add(resource.TypeID)
                    End If
                End If
            Next
            For Each subJob As Job In parentJob.SubJobs.Values
                ' This is another production job
                Call AddPricingResources(subJob, itemIDs)
            Next

        End Sub

#End Region

    End Class

    Public Class ProductionItem

        ReadOnly _cKey As String
        Public ReadOnly Property Key As String
            Get
                Return _cKey
            End Get
        End Property

        Public Property ItemID As String

        Public Property IsBuild As Boolean

        Public Property Quantity As Long

        Public Sub New(id As String, build As Boolean, qty As Long)
            _cKey = id & "_" & build.ToString
            ItemID = id
            IsBuild = build
            Quantity = qty
        End Sub

    End Class
End Namespace