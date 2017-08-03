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

Imports System.ComponentModel
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Web
Imports System.Windows.Forms
Imports System.Xml
Imports DevComponents.AdvTree
Imports DevComponents.DotNetBar
Imports EveHQ.Core
Imports EveHQ.Core.Requisitions
Imports EveHQ.EveData
Imports EveHQ.Prism.BPCalc
Imports EveHQ.Prism.Classes
Imports EveHQ.Prism.Controls
Imports EveHQ.Common.Extensions
Imports EveHQ.NewEveApi

Namespace Forms

    Public Class FrmPrism

#Region "Class Wide Variables"

        Private Const PrismTimeFormat As String = "yyyy-MM-dd HH:mm:ss"
        ReadOnly _culture As CultureInfo = New CultureInfo("en-GB")

        Dim _startup As Boolean = True
        Dim _jobsUpdated As Boolean = False
        Dim _selectedTab As TabItem
        ReadOnly _divisions As New SortedList
        Dim _prismThreadMax As Integer = 16
        Dim _prismThreadCurrent As Integer = 0
        Private Const MaxApiRetries As Integer = 3
        Private Const MaxApiJournals As Integer = 2000
        Dim _csvFile As String = ""

        Dim _bpManagerUpdate As Boolean = False
        ReadOnly _bpManagerGroups As New SortedList(Of String, Integer)
        ReadOnly _bpLocations As List(Of String) = New List(Of String)()

        ' Rig Builder Variables
        Dim _rigBpData As New SortedList(Of String, SortedList(Of Integer, Long))
        Dim _rigBuildData As New SortedList(Of Integer, Long)
        ReadOnly _salvageList As New SortedList(Of Integer, Long)

        ' Recycling Variables
        Dim _recyclerAssetList As New SortedList(Of Integer, Long)
        Dim _recyclerAssetOwner As String = ""
        Dim _recyclerAssetLocation As Integer
        ReadOnly _matList As New Dictionary(Of Integer, Long)
        Dim _baseYield As Double = 0.5
        Dim _stationYield As Double = 0
        Dim _stationTake As Double = 0
        Dim _stationStanding As Double = 0
        Dim _rBrokerFee As Double = 0
        Dim _rTransTax As Double = 0
        Dim _rTotalFees As Double = 0

        ' Node Element Styles
        Dim _styleRed As New ElementStyle
        Dim _styleRedRight As New ElementStyle
        Dim _styleGreen As New ElementStyle
        Dim _styleGreenRight As New ElementStyle
        Dim _styleRight As New ElementStyle

        ' BPManager Styles
        Dim _bpmStyleUnknown As ElementStyle
        Dim _bpmStyleBpo As ElementStyle
        Dim _bpmStyleBpc As ElementStyle
        Dim _bpmStyleUser As ElementStyle
        Dim _bpmStyleMissing As ElementStyle
        Dim _bpmStyleExhausted As ElementStyle

        Friend Shared LockObj As New Object()

#End Region

#Region "Form Initialisation Routines"

        Private Sub frmPrism_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load


            ' Add events
            AddHandler PrismEvents.UpdateProductionJobs, AddressOf UpdateProductionJobList
            AddHandler PrismEvents.UpdateInventionJobs, AddressOf UpdateInventionJobList
            AddHandler PrismEvents.UpdateBatchJobs, AddressOf UpdateBatchList
            AddHandler PrismEvents.RecyclingInfoAvailable, AddressOf RecycleInfoFromAssets

            ' Load the settings!
            Call PrismSettings.UserSettings.LoadPrismSettings()

            ' Load the Production Jobs
            _jobsUpdated = Jobs.Load()

            ' Load the Batch Jobs
            Call BatchJobs.LoadBatchJobs()

            tabPrism.Dock = DockStyle.Fill

            _startup = True

            ' Create the styles
            _styleRed = adtJournal.Styles("ElementStyle1").Copy
            _styleRed.TextColor = Color.Red
            _styleRedRight = adtJournal.Styles("ElementStyle1").Copy
            _styleRedRight.TextColor = Color.Red
            _styleRedRight.TextAlignment = eStyleTextAlignment.Far
            _styleGreen = adtJournal.Styles("ElementStyle1").Copy
            _styleGreen.TextColor = Color.LimeGreen
            _styleGreenRight = adtJournal.Styles("ElementStyle1").Copy
            _styleGreenRight.TextColor = Color.LimeGreen
            _styleGreenRight.TextAlignment = eStyleTextAlignment.Far
            _styleRight = adtJournal.Styles("ElementStyle1").Copy
            _styleRight.TextAlignment = eStyleTextAlignment.Far

            ' Create BPM Styles
            _bpmStyleBpc = adtBlueprints.Styles("BP").Copy
            _bpmStyleBpo = adtBlueprints.Styles("BP").Copy
            _bpmStyleExhausted = adtBlueprints.Styles("BP").Copy
            _bpmStyleMissing = adtBlueprints.Styles("BP").Copy
            _bpmStyleUnknown = adtBlueprints.Styles("BP").Copy
            _bpmStyleUser = adtBlueprints.Styles("BP").Copy
            _bpmStyleBpc.BackColor2 = Color.LightSteelBlue
            _bpmStyleBpc.BackColor = Color.FromArgb(128, _bpmStyleBpc.BackColor2)
            _bpmStyleBpo.BackColor2 = Color.LightGreen
            _bpmStyleBpo.BackColor = Color.FromArgb(128, _bpmStyleBpo.BackColor2)
            _bpmStyleExhausted.BackColor2 = Color.Orange
            _bpmStyleExhausted.BackColor = Color.FromArgb(128, _bpmStyleExhausted.BackColor2)
            _bpmStyleMissing.BackColor2 = Color.LightCoral
            _bpmStyleMissing.BackColor = Color.FromArgb(128, _bpmStyleMissing.BackColor2)
            _bpmStyleUnknown.BackColor2 = Color.LightGray
            _bpmStyleUnknown.BackColor = Color.FromArgb(128, _bpmStyleUnknown.BackColor2)
            _bpmStyleUser.BackColor2 = Color.Yellow
            _bpmStyleUser.BackColor = Color.FromArgb(128, _bpmStyleUser.BackColor2)

            ' Build a corp list
            Call BuildOwnerList()

            ' Hide excess tabs
            For tabNo As Integer = 1 To tabPrism.Tabs.Count - 1
                tabPrism.Tabs(tabNo).Visible = False
            Next

            ' Initialise the Report data
            Call InitialiseReports()

            ' Initialise the Journal and Transaction Data
            Call InitialiseJournal()
            Call InitialiseTransactions()
            Call InitialiseInventionResults()

            ' Build the BP Manager category lists
            cboCategoryFilter.BeginUpdate()
            cboCategoryFilter.Items.Clear()
            cboCategoryFilter.Items.Add("All")
            For Each cat As String In PlugInData.CategoryNames.Keys
                cboCategoryFilter.Items.Add(cat)
            Next
            cboCategoryFilter.EndUpdate()

            ' Set the BP Manager filter indexes
            cboTechFilter.SelectedIndex = 0
            cboTypeFilter.SelectedIndex = 0
            cboCategoryFilter.SelectedIndex = 0
            cboGroupFilter.SelectedIndex = 0

            ' Build the Blueprint Activity List
            cboActivityFilter.BeginUpdate()
            cboActivityFilter.Items.Clear()
            cboActivityFilter.Items.Add("<All>")
            For Each activity As String In [Enum].GetNames(GetType(BlueprintActivity))
                cboActivityFilter.Items.Add(activity)
            Next
            cboActivityFilter.EndUpdate()
            cboActivityFilter.SelectedIndex = 0

            ' Build the Job Status List
            cboStatusFilter.BeginUpdate()
            cboStatusFilter.Items.Clear()
            cboStatusFilter.Items.Add("<All>")
            For Each status As String In PlugInData.Statuses.Values
                cboStatusFilter.Items.Add(status)
            Next
            cboStatusFilter.EndUpdate()
            cboStatusFilter.SelectedIndex = 0

            Call ScanForExistingXmlFiles()

            ' Initialise default Prism character
            If PrismSettings.UserSettings.DefaultCharacter <> "" And PlugInData.PrismOwners.ContainsKey(PrismSettings.UserSettings.DefaultCharacter) Then
                ' Wallet Journal
                CType(cboJournalOwners.DropDownControl, PrismSelectionControl).UpdateList()
                ' Wallet Transactions
                CType(cboTransactionOwner.DropDownControl, PrismSelectionControl).UpdateList()
                ' Assets
                CType(PAC.PSCAssetOwners.cboHost.DropDownControl, PrismSelectionControl).UpdateList()
                ' Market Orders
                cboOrdersOwner.SelectedItem = PrismSettings.UserSettings.DefaultCharacter
                ' Research Jobs
                cboJobOwner.SelectedItem = PrismSettings.UserSettings.DefaultCharacter
                ' BP Manager
                cboBPOwner.SelectedItem = PrismSettings.UserSettings.DefaultCharacter
                ' Contracts
                cboContractOwner.SelectedItem = PrismSettings.UserSettings.DefaultCharacter
            End If

            ' Set the refining info
            ' Set the pilot to the recycling one
            If _recyclerAssetOwner = "" Then
                If PrismSettings.UserSettings.DefaultCharacter <> "" Then
                    _recyclerAssetOwner = PrismSettings.UserSettings.DefaultCharacter
                End If
            End If
            If cboRecyclePilots.Items.Contains(_recyclerAssetOwner) Then
                cboRecyclePilots.SelectedItem = _recyclerAssetOwner
            Else
                If cboRecyclePilots.Items.Count > 0 Then
                    cboRecyclePilots.SelectedIndex = 0
                End If
            End If

            ' Set the recycling mode
            cboRefineMode.SelectedIndex = 0
            _startup = False

            ' Start the update timer
            tmrUpdateInfo.Enabled = True
            tmrUpdateInfo.Start()

        End Sub

        Private Sub FrmPrism_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            If _jobsUpdated = True Then
                TaskDialog.AntiAlias = True
                TaskDialog.EnableGlass = False
                Dim tdi As New TaskDialogInfo
                tdi.TaskDialogIcon = eTaskDialogIcon.Information2
                tdi.DialogButtons = eTaskDialogButton.Ok
                tdi.DefaultButton = eTaskDialogButton.Ok
                tdi.Title = "Production Jobs Updated"
                tdi.Header = "Production Jobs Updated"
                Dim msg As New StringBuilder
                msg.Append("Prism has detected that materials required for certain Eve blueprints no longer match the production jobs. ")
                msg.AppendLine("As a result, Prism has now updated these production jobs to reflect the new blueprint requirements.")
                msg.AppendLine()
                msg.AppendLine("Please ensure all your production jobs are updated for any known changes to blueprint requirements.")
                tdi.Text = msg.ToString
                tdi.DialogColor = eTaskDialogBackgroundColor.DarkBlue
                TaskDialog.Show(Me, tdi)
                _jobsUpdated = False
            End If
        End Sub

        ''' <summary>
        ''' Builds a list of all owners to be used by Prism, and also builds the corp list
        ''' Could replace the LoadedOwners list
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub BuildOwnerList()

            ' Clear the lists
            PlugInData.PrismOwners.Clear()
            PlugInData.CorpList.Clear()

            For Each selAccount As EveHQAccount In HQ.Settings.Accounts.Values
                Select Case selAccount.ApiKeySystem
                    Case APIKeySystems.Version2
                        ' Check the type of the key
                        Select Case selAccount.APIKeyType
                            Case APIKeyTypes.Corporation
                                ' A corporate API key
                                For Each xmlOwner As String In selAccount.Characters
                                    If HQ.Settings.Corporations.ContainsKey(xmlOwner) Then
                                        Dim selCorp As Corporation = HQ.Settings.Corporations(xmlOwner)
                                        If StaticData.NpcCorps.ContainsKey(CInt(selCorp.ID)) = False Then
                                            If PlugInData.PrismOwners.ContainsKey(xmlOwner) = False Then
                                                Dim newOwner As New PrismOwner
                                                newOwner.Account = selAccount
                                                newOwner.Name = selCorp.Name
                                                newOwner.ID = CStr(selCorp.ID)
                                                newOwner.IsCorp = True
                                                newOwner.APIVersion = APIKeySystems.Version2
                                                PlugInData.PrismOwners.Add(newOwner.Name, newOwner)
                                            End If
                                            ' Add the corp to the CorpList
                                            PlugInData.CorpList.Add(selCorp.Name, CInt(selCorp.ID))
                                        End If
                                    End If
                                Next
                            Case APIKeyTypes.Account, APIKeyTypes.Character
                                ' A character related API key
                                For Each xmlOwner As String In selAccount.Characters
                                    If HQ.Settings.Pilots.ContainsKey(xmlOwner) Then
                                        Dim selPilot As EveHQPilot = HQ.Settings.Pilots(xmlOwner)
                                        If PlugInData.PrismOwners.ContainsKey(xmlOwner) = False Then
                                            Dim newOwner As New PrismOwner
                                            newOwner.Account = selAccount
                                            newOwner.Name = selPilot.Name
                                            newOwner.ID = selPilot.ID
                                            newOwner.IsCorp = False
                                            newOwner.APIVersion = APIKeySystems.Version2
                                            PlugInData.PrismOwners.Add(newOwner.Name, newOwner)
                                        End If
                                    End If
                                Next
                        End Select
                End Select
            Next
        End Sub

        ''' <summary>
        ''' Looks at existing XML files to determine the cache status
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub ScanForExistingXmlFiles()

            lvwCurrentAPIs.BeginUpdate()
            lvwCurrentAPIs.Items.Clear()

            ' Cycle through our list of Prism owners and set up the API status matrix
            ' We have already checked the account active status and the pilot active status so no need to do this again
            For Each xmlOwner As PrismOwner In PlugInData.PrismOwners.Values
                If lvwCurrentAPIs.Items.ContainsKey(xmlOwner.ID) = False Then
                    Dim newOwner As New ListViewItem
                    newOwner.UseItemStyleForSubItems = False
                    newOwner.Name = xmlOwner.ID
                    newOwner.Text = xmlOwner.Name
                    newOwner.ToolTipText = ""
                    ' ReSharper disable once RedundantAssignment - Incorrect warning by R#
                    For si As Integer = 1 To 9
                        newOwner.SubItems.Add("")
                    Next
                    Select Case xmlOwner.IsCorp
                        Case True
                            newOwner.SubItems(1).Text = "Corporation"
                        Case False
                            newOwner.SubItems(1).Text = "Character"
                            newOwner.SubItems(9).Text = "n/a"
                            cboRecyclePilots.Items.Add(xmlOwner.Name)
                    End Select
                    lvwCurrentAPIs.Items.Add(newOwner)
                End If
            Next

            For Each xmlOwner As PrismOwner In PlugInData.PrismOwners.Values
                Call CheckXmlFiles(xmlOwner)
            Next

            lvwCurrentAPIs.EndUpdate()
            Invoke(Sub() CompleteApiUpdate())
        End Sub

        ''' <summary>
        ''' Checks existing XML files for display on Prism startup
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub CheckXmlFiles(ByVal pOwner As PrismOwner)
            Select Case pOwner.IsCorp
                Case True
                    Call CheckCorpXmlFiles(pOwner)
                Case False
                    Call CheckCharXmlFiles(pOwner)
            End Select
        End Sub

        Private Sub CheckCharXmlFiles(ByVal pOwner As PrismOwner)

            If pOwner.IsCorp = False Then
                Const ResponseMode As ResponseMode = ResponseMode.BypassCache
                If HQ.Settings.Pilots.ContainsKey(pOwner.Name) = True Then
                    Dim selPilot As EveHQPilot = HQ.Settings.Pilots(pOwner.Name)
                    Dim pilotAccount As EveHQAccount = pOwner.Account

                    ' Check for char assets
                    Dim assetResponse = HQ.ApiProvider.Character.AssetList(pilotAccount.UserID, pilotAccount.APIKey, CLng(selPilot.ID), ResponseMode)
                    Call CheckApiResult(assetResponse, pOwner, CorpRepType.Assets)

                    ' Check for char balances
                    Dim balanceResponse = HQ.ApiProvider.Character.AccountBalance(pilotAccount.UserID, pilotAccount.APIKey, CLng(selPilot.ID), ResponseMode)
                    Call CheckApiResult(balanceResponse, pOwner, CorpRepType.Balances)

                    ' Check for char jobs
                    Dim jobsResponse = HQ.ApiProvider.Character.IndustryJobs(pilotAccount.UserID, pilotAccount.APIKey, CLng(selPilot.ID), ResponseMode)
                    Call CheckApiResult(jobsResponse, pOwner, CorpRepType.Jobs)

                    ' Check for char journal
                    Dim walletResponse = HQ.ApiProvider.Character.WalletJournal(pilotAccount.UserID, pilotAccount.APIKey, CLng(selPilot.ID), 1000, Nothing, Nothing, ResponseMode)
                    Call CheckApiResult(walletResponse, pOwner, CorpRepType.WalletJournal)

                    ' Check for char orders
                    Dim ordersResponse = HQ.ApiProvider.Character.MarketOrders(pilotAccount.UserID, pilotAccount.APIKey, CLng(selPilot.ID), ResponseMode)
                    Call CheckApiResult(ordersResponse, pOwner, CorpRepType.Orders)

                    ' Check for char transactions
                    Dim transactionsResponse = HQ.ApiProvider.Character.WalletTransactions(pilotAccount.UserID, pilotAccount.APIKey, CLng(selPilot.ID), 1000, Nothing, Nothing, ResponseMode)

                    Call CheckApiResult(transactionsResponse, pOwner, CorpRepType.WalletTransactions)

                    ' Check for char contracts
                    Dim contractsResponse = HQ.ApiProvider.Character.Contracts(pilotAccount.UserID, pilotAccount.APIKey, CLng(selPilot.ID), 0, ResponseMode)
                    Call CheckApiResult(contractsResponse, pOwner, CorpRepType.Contracts)

                    ' Check for corp sheets
                    If PrismSettings.UserSettings.CorpReps.ContainsKey(selPilot.Corp) Then
                        If PrismSettings.UserSettings.CorpReps(selPilot.Corp).ContainsKey(CorpRepType.CorpSheet) Then
                            If PrismSettings.UserSettings.CorpReps(selPilot.Corp).Item(CorpRepType.CorpSheet) = selPilot.Name Then
                                Dim corpSheetRepsonse = HQ.ApiProvider.Corporation.CorporationSheet(pilotAccount.UserID, pilotAccount.APIKey, CLng(selPilot.ID), ResponseMode)

                                Call CheckApiResult(corpSheetRepsonse, pOwner, CorpRepType.CorpSheet)
                            Else

                            End If
                        Else

                        End If
                    Else

                    End If

                End If
            End If
        End Sub

        Private Sub CheckCorpXmlFiles(ByVal pOwner As PrismOwner)

            If pOwner.IsCorp = True Then

                Dim corpAccount As EveHQAccount = pOwner.Account


                Const ResponseMode As ResponseMode = ResponseMode.CacheOnly

                Dim ownerId As String

                ' Check for corp assets
                ownerId = PlugInData.GetAccountOwnerIDForCorpOwner(pOwner, CorpRepType.Assets)
                Dim assetResponse = HQ.ApiProvider.Corporation.AssetList(corpAccount.UserID, corpAccount.APIKey, ownerId.ToInt32(), ResponseMode)
                Call CheckApiResult(assetResponse, pOwner, CorpRepType.Assets)

                ' Check for corp balances
                ownerId = PlugInData.GetAccountOwnerIDForCorpOwner(pOwner, CorpRepType.Balances)
                Dim balances = HQ.ApiProvider.Corporation.AssetList(corpAccount.UserID, corpAccount.APIKey, ownerId.ToInt32(), ResponseMode)
                Call CheckApiResult(balances, pOwner, CorpRepType.Balances)

                ' Check for corp jobs
                ownerId = PlugInData.GetAccountOwnerIDForCorpOwner(pOwner, CorpRepType.Jobs)
                Dim jobs = HQ.ApiProvider.Corporation.IndustryJobs(corpAccount.UserID, corpAccount.APIKey, ownerId.ToInt32(), ResponseMode)
                Call CheckApiResult(jobs, pOwner, CorpRepType.Jobs)

                ' Check for corp journal
                ownerId = PlugInData.GetAccountOwnerIDForCorpOwner(pOwner, CorpRepType.WalletJournal)

                Dim journal = HQ.ApiProvider.Corporation.WalletJournal(corpAccount.UserID, corpAccount.APIKey, ownerId.ToInt32(), 1000, Nothing, Nothing, ResponseMode)
                Call CheckApiResult(journal, pOwner, CorpRepType.WalletJournal)

                ' Check for corp orders
                ownerId = PlugInData.GetAccountOwnerIDForCorpOwner(pOwner, CorpRepType.Orders)
                Dim orders = HQ.ApiProvider.Corporation.MarketOrders(corpAccount.UserID, corpAccount.APIKey, ownerId.ToInt32(), ResponseMode)
                Call CheckApiResult(orders, pOwner, CorpRepType.Orders)

                ' Check for corp transactions
                ownerId = PlugInData.GetAccountOwnerIDForCorpOwner(pOwner, CorpRepType.WalletTransactions)
                Dim transactions = HQ.ApiProvider.Corporation.WalletTransactions(corpAccount.UserID, corpAccount.APIKey, ownerId.ToInt32(), 1000, Nothing, Nothing, ResponseMode)
                Call CheckApiResult(transactions, pOwner, CorpRepType.WalletTransactions)

                ' Check for corp contracts
                ownerId = PlugInData.GetAccountOwnerIDForCorpOwner(pOwner, CorpRepType.Contracts)
                Dim contracts = HQ.ApiProvider.Corporation.Contracts(corpAccount.UserID, corpAccount.APIKey, ownerId.ToInt32(), 0, ResponseMode)
                Call CheckApiResult(contracts, pOwner, CorpRepType.Contracts)

                ' Check for corp sheets
                ownerId = PlugInData.GetAccountOwnerIDForCorpOwner(pOwner, CorpRepType.CorpSheet)
                Dim sheet = HQ.ApiProvider.Corporation.CorporationSheet(corpAccount.UserID, corpAccount.APIKey, ownerId.ToInt32(), ResponseMode)
                Call CheckApiResult(sheet, pOwner, CorpRepType.CorpSheet)

            End If

        End Sub

        Private Sub btnRefreshAPI_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefreshAPI.Click
            _startup = True
            Call ScanForExistingXmlFiles()
            _startup = False
        End Sub

#End Region

#Region "Form Closing Routines"

        Private Sub frmPrism_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            ' Save data and settings
            Call SaveAll()

            ' Remove events
            RemoveHandler PrismEvents.UpdateProductionJobs, AddressOf UpdateProductionJobList
            RemoveHandler PrismEvents.UpdateBatchJobs, AddressOf UpdateBatchList
        End Sub

        Public Sub SaveAll()

            ' Save the Owner Blueprints
            Call PlugInData.SaveOwnerBlueprints()

            ' Save the Production Jobs
            Call Jobs.Save()

            ' Save the Batch Jobs
            Call BatchJobs.SaveBatchJobs()

            ' Save the settings
            Call PrismSettings.UserSettings.SavePrismSettings()

        End Sub

#End Region

#Region "XML Retrieval and Parsing"

        Private Sub StartGetXmlDataThread()
            ' Perform this so that the API download process doesn't block the main UI thread
            GetXmlData()
        End Sub

        Private Sub GetXmlData()

            _prismThreadMax = 16
            _prismThreadCurrent = 0

            ' Setup separate threads for getting each type of API
            ThreadPool.QueueUserWorkItem(AddressOf GetCharAssets2)
            ThreadPool.QueueUserWorkItem(AddressOf GetCorpAssets2)
            ThreadPool.QueueUserWorkItem(AddressOf GetCharBalances2)
            ThreadPool.QueueUserWorkItem(AddressOf GetCorpBalances2)
            ThreadPool.QueueUserWorkItem(AddressOf GetCharJobs2)
            ThreadPool.QueueUserWorkItem(AddressOf GetCorpJobs2)
            ThreadPool.QueueUserWorkItem(AddressOf GetCharJournal2)
            ThreadPool.QueueUserWorkItem(AddressOf GetCorpJournal2)
            ThreadPool.QueueUserWorkItem(AddressOf GetCharOrders2)
            ThreadPool.QueueUserWorkItem(AddressOf GetCorpOrders2)
            ThreadPool.QueueUserWorkItem(AddressOf GetCharTransactions2)
            ThreadPool.QueueUserWorkItem(AddressOf GetCorpTransactions2)
            ThreadPool.QueueUserWorkItem(AddressOf GetCharContracts2)
            ThreadPool.QueueUserWorkItem(AddressOf GetCorpContracts2)
            ThreadPool.QueueUserWorkItem(AddressOf GetCorpSheet2)
            ThreadPool.QueueUserWorkItem(AddressOf UpdateNullCorpSheet2)

        End Sub
        Private Sub CheckApiResult(Of T As Class)(ByRef apiResult As EveServiceResponse(Of T), ByVal pOwner As PrismOwner, ByVal apiType As CorpRepType)

            ' Get the listviewitem of the relevant Owner
            Dim apiOwner As ListViewItem = lvwCurrentAPIs.Items(pOwner.ID)
            ' Get the position of the cell in the listviewitem
            Dim pos As Integer = apiType + 2

            Try

                Select Case pOwner.APIVersion

                    Case APIKeySystems.Version2

                        ' Checking XML of APIv2 keys
                        If apiResult IsNot Nothing Then
                            If CanUseApiV2(pOwner, apiType) Then
                                Call DisplayAPIDetails(apiResult, apiOwner, pos)
                            Else
                                apiOwner.SubItems(pos).ForeColor = Color.Red
                                apiOwner.SubItems(pos).Text = "No Access"
                            End If
                        Else
                            If pOwner.IsCorp = False And apiType = CorpRepType.CorpSheet Then
                                apiOwner.SubItems(pos).ForeColor = Color.Black
                                apiOwner.SubItems(pos).Text = "n/a"
                            Else
                                If CanUseApiV2(pOwner, apiType) Then
                                    ' ...but we can use it (it's just missing for now)
                                    apiOwner.SubItems(pos).ForeColor = Color.Red
                                    apiOwner.SubItems(pos).Text = "Missing"
                                Else
                                    ' Put generic "No Access" notice here, but we could expand on this later
                                    apiOwner.SubItems(pos).ForeColor = Color.Red
                                    apiOwner.SubItems(pos).Text = "No Access"
                                End If
                            End If
                        End If

                End Select

            Catch ex As Exception
                Dim msg As String = "An error occured while processing the XML data." & ControlChars.CrLf
                msg &= "The specific error was: " & ex.Message & ControlChars.CrLf
                msg &= "The stacktrace was: " & ex.StackTrace & ControlChars.CrLf
                MessageBox.Show(msg, "CheckXML Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub DisplayAPIDetails(Of T As Class)(ByVal result As EveServiceResponse(Of T), ByVal apiOwner As ListViewItem, ByVal pos As Integer)
            ' Check response string for any error codes?
            If result.EveErrorCode <> 0 Then
                ' Get error code
                Dim errCode As String = result.EveErrorCode.ToInvariantString()
                apiOwner.SubItems(pos).ForeColor = Color.Red
                apiOwner.SubItems(pos).Text = errCode
            Else
                Dim cache As Date = result.CacheUntil.LocalDateTime
                If cache <= Now Then
                    apiOwner.SubItems(pos).ForeColor = Color.Blue
                    apiOwner.SubItems(pos).Text = "Cache Expired!"
                Else
                    apiOwner.SubItems(pos).ForeColor = Color.Green
                    apiOwner.SubItems(pos).Text = Format(cache, "dd MMM HH:mm")
                End If
            End If
        End Sub

        Private Function CanUseApi(ByVal pOwner As PrismOwner, ByVal apiType As CorpRepType) As Boolean
            Select Case pOwner.APIVersion
                Case APIKeySystems.Version2
                    Return CanUseApiV2(pOwner, apiType)
                Case Else
                    Return False
            End Select
        End Function

        Private Function CanUseApiV2(ByVal pOwner As PrismOwner, ByVal apiType As CorpRepType) As Boolean
            Dim account As EveHQAccount = pOwner.Account
            If (account.APIAccountStatus = APIAccountStatuses.Active Or account.APIAccountStatus = APIAccountStatuses.Alpha) And account.ApiKeySystem = APIKeySystems.Version2 Then
                Select Case account.APIKeyType
                    Case APIKeyTypes.Corporation
                        Select Case apiType
                            Case CorpRepType.Assets
                                Return account.CanUseCorporateAPI(CorporateAccessMasks.AssetList)
                            Case CorpRepType.Balances
                                Return account.CanUseCorporateAPI(CorporateAccessMasks.AccountBalances)
                            Case CorpRepType.Contracts
                                Return account.CanUseCorporateAPI(CorporateAccessMasks.Contracts)
                            Case CorpRepType.CorpSheet
                                Return account.CanUseCorporateAPI(CorporateAccessMasks.CorporationSheet)
                            Case CorpRepType.Jobs
                                Return account.CanUseCorporateAPI(CorporateAccessMasks.IndustryJobs)
                            Case CorpRepType.Orders
                                Return account.CanUseCorporateAPI(CorporateAccessMasks.MarketOrders)
                            Case CorpRepType.WalletJournal
                                Return account.CanUseCorporateAPI(CorporateAccessMasks.WalletJournal)
                            Case CorpRepType.WalletTransactions
                                Return account.CanUseCorporateAPI(CorporateAccessMasks.WalletTransactions)
                        End Select
                    Case Else
                        Select Case apiType
                            Case CorpRepType.Assets
                                Return account.CanUseCharacterAPI(CharacterAccessMasks.AssetList)
                            Case CorpRepType.Balances
                                Return account.CanUseCharacterAPI(CharacterAccessMasks.AccountBalances)
                            Case CorpRepType.Contracts
                                Return account.CanUseCharacterAPI(CharacterAccessMasks.Contracts)
                            Case CorpRepType.CorpSheet
                                Return False
                            Case CorpRepType.Jobs
                                Return account.CanUseCharacterAPI(CharacterAccessMasks.IndustryJobs)
                            Case CorpRepType.Orders
                                Return account.CanUseCharacterAPI(CharacterAccessMasks.MarketOrders)
                            Case CorpRepType.WalletJournal
                                Return account.CanUseCharacterAPI(CharacterAccessMasks.WalletJournal)
                            Case CorpRepType.WalletTransactions
                                Return account.CanUseCharacterAPI(CharacterAccessMasks.WalletTransactions)
                        End Select
                End Select
            Else
                Return False
            End If
        End Function

        Private Sub CompleteApiUpdate()
            ' Populate the various Owner boxes
            Invoke(Sub() UpdatePrismOwners())
            ' Set the label, enable the button and inform the user
            lblCurrentAPI.Text = "Cached APIs Loaded:"
            btnDownloadAPIData.Enabled = True
            If _startup = False And PrismSettings.UserSettings.HideAPIDownloadDialog = False Then
                DisplayApiCompleteDialog()
            End If
        End Sub

        Private Sub DisplayApiCompleteDialog()
            TaskDialog.AntiAlias = True
            TaskDialog.EnableGlass = False
            Dim tdi As New TaskDialogInfo
            tdi.TaskDialogIcon = eTaskDialogIcon.CheckMark2
            tdi.DialogButtons = eTaskDialogButton.Ok
            tdi.DefaultButton = eTaskDialogButton.Ok
            tdi.Title = "API Download complete!"
            tdi.Header = "API Download complete!"
            tdi.Text = "Prism has completed the download of the API data. You may need to refresh your views to get updated information."
            tdi.DialogColor = eTaskDialogBackgroundColor.DarkBlue
            tdi.CheckBoxCommand = APIDownloadDialogCheckBox
            TaskDialog.Show(Me, tdi)
        End Sub

        Private Sub APIDownloadDialogCheckBox_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles APIDownloadDialogCheckBox.Executed
            PrismSettings.UserSettings.HideAPIDownloadDialog = APIDownloadDialogCheckBox.Checked
        End Sub

        Private Sub UpdatePrismOwners()

            ' Check for old items
            Dim oldBpOwner As String = ""
            Dim oldJobOwner As String = ""
            Dim oldOrdersOwner As String = ""
            Dim oldContractOwner As String = ""

            If cboBPOwner.SelectedItem IsNot Nothing Then
                oldBpOwner = cboBPOwner.SelectedItem.ToString
            End If
            If cboJobOwner.SelectedItem IsNot Nothing Then
                oldJobOwner = cboJobOwner.SelectedItem.ToString
            End If
            If cboOrdersOwner.SelectedItem IsNot Nothing Then
                oldOrdersOwner = cboOrdersOwner.SelectedItem.ToString
            End If
            If cboContractOwner.SelectedItem IsNot Nothing Then
                oldContractOwner = cboContractOwner.SelectedItem.ToString
            End If

            ' Prepare each of the owner lists for loading
            cboBPOwner.BeginUpdate() : cboBPOwner.Items.Clear()
            cboJobOwner.BeginUpdate() : cboJobOwner.Items.Clear()
            cboOrdersOwner.BeginUpdate() : cboOrdersOwner.Items.Clear()
            cboContractOwner.BeginUpdate() : cboContractOwner.Items.Clear()

            ' Populate the lists
            For Each pOwner As String In PlugInData.PrismOwners.Keys
                cboBPOwner.Items.Add(pOwner)
                cboJobOwner.Items.Add(pOwner)
                cboOrdersOwner.Items.Add(pOwner)
                cboContractOwner.Items.Add(pOwner)
            Next

            ' Finalise the loading
            cboBPOwner.Sorted = True : cboBPOwner.EndUpdate()
            cboJobOwner.Sorted = True : cboJobOwner.EndUpdate()
            cboOrdersOwner.Sorted = True : cboOrdersOwner.EndUpdate()
            cboContractOwner.Sorted = True : cboContractOwner.EndUpdate()

            ' Set the old values if applicable
            If oldBpOwner <> "" And cboBPOwner.Items.Contains(oldBpOwner) Then
                cboBPOwner.SelectedItem = oldBpOwner
            End If
            If oldJobOwner <> "" And cboJobOwner.Items.Contains(oldJobOwner) Then
                cboJobOwner.SelectedItem = oldJobOwner
            End If
            If oldOrdersOwner <> "" And cboOrdersOwner.Items.Contains(oldOrdersOwner) Then
                cboOrdersOwner.SelectedItem = oldOrdersOwner
            End If
            If oldContractOwner <> "" And cboContractOwner.Items.Contains(oldContractOwner) Then
                cboContractOwner.SelectedItem = oldContractOwner
            End If

        End Sub

#Region "APIv2"

        Private Sub GetCharAssets2(ByVal state As Object)

            For Each pOwner As PrismOwner In PlugInData.PrismOwners.Values
                Try
                    If pOwner.IsCorp = False Then

                        Dim charAssets As EveServiceResponse(Of IEnumerable(Of NewEveApi.Entities.AssetItem))
                        Dim pilotAccount As EveHQAccount = pOwner.Account

                        ' Check for valid API Usage
                        If CanUseApi(pOwner, CorpRepType.Assets) = True Then

                            ' Make a call to the EveHQ.Core.API to fetch the relevant API
                            Dim retries As Integer = 0
                            Do
                                retries += 1
                                charAssets = HQ.ApiProvider.Character.AssetList(pilotAccount.UserID, pilotAccount.APIKey, CInt(pOwner.ID), ResponseMode.WaitOnRefresh)
                            Loop Until retries >= MaxApiRetries Or charAssets.IsSuccess

                        End If

                        ' Update the display
                        If IsHandleCreated = True Then
                            Dim cOwner = pOwner 'copy ref to local to prevent foreach closure violation.
                            Invoke(Sub() CheckApiResult(charAssets, cOwner, CorpRepType.Assets))
                        End If

                    End If
                Catch e As Exception
                    Trace.TraceError(e.FormatException())
                    Dim msg As String = "An error occured while processing the Character Assets data for " & pOwner.Name & ControlChars.CrLf
                    msg &= "The specific error was: " & e.Message & ControlChars.CrLf
                    msg &= "The stacktrace was: " & e.StackTrace & ControlChars.CrLf
                    MessageBox.Show(msg, "GetCharAssets Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            _prismThreadCurrent += 1
            If _prismThreadCurrent = _prismThreadMax Then
                Invoke(Sub() CompleteApiUpdate())
            End If

        End Sub
        Private Sub GetCharBalances2(ByVal state As Object)

            For Each pOwner As PrismOwner In PlugInData.PrismOwners.Values
                Try
                    If pOwner.IsCorp = False Then

                        Dim accountBalance As EveServiceResponse(Of IEnumerable(Of Entities.AccountBalance))
                        Dim pilotAccount As EveHQAccount = pOwner.Account

                        ' Check for valid API Usage
                        If CanUseApi(pOwner, CorpRepType.Balances) = True Then

                            ' Make a call to the EveHQ.Core.API to fetch the relevant API
                            Dim retries As Integer = 0
                            Do
                                retries += 1
                                accountBalance = HQ.ApiProvider.Character.AccountBalance(pilotAccount.UserID, pilotAccount.APIKey, CInt(pOwner.ID), ResponseMode.WaitOnRefresh)

                            Loop Until retries >= MaxApiRetries Or accountBalance.IsSuccess

                        End If

                        ' Update the display
                        If IsHandleCreated = True Then
                            Invoke(Sub() CheckApiResult(accountBalance, pOwner, CorpRepType.Balances))
                        End If

                    End If
                Catch e As Exception
                    Trace.TraceError(e.FormatException())
                    Dim msg As String = "An error occured while processing the Character Balances data for " & pOwner.Name & ControlChars.CrLf
                    msg &= "The specific error was: " & e.Message & ControlChars.CrLf
                    msg &= "The stacktrace was: " & e.StackTrace & ControlChars.CrLf
                    MessageBox.Show(msg, "GetCharAssets Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            _prismThreadCurrent += 1
            If _prismThreadCurrent = _prismThreadMax Then
                Invoke(Sub() CompleteApiUpdate())
            End If

        End Sub
        Private Sub GetCharJobs2(ByVal state As Object)

            For Each pOwner As PrismOwner In PlugInData.PrismOwners.Values
                Try
                    If pOwner.IsCorp = False Then

                        Dim charIndustry As EveServiceResponse(Of IEnumerable(Of NewEveApi.Entities.IndustryJob))
                        Dim pilotAccount As EveHQAccount = pOwner.Account


                        ' Check for valid API Usage
                        If CanUseApi(pOwner, CorpRepType.Jobs) = True Then

                            ' Make a call to the EveHQ.Core.API to fetch the relevant API
                            Dim retries As Integer = 0
                            Do
                                retries += 1
                                charIndustry = HQ.ApiProvider.Character.IndustryJobs(pilotAccount.UserID, pilotAccount.APIKey, CInt(pOwner.ID), ResponseMode.WaitOnRefresh)
                            Loop Until retries >= MaxApiRetries Or charIndustry.IsSuccess

                            ' Write the installerIDs to the database
                            If charIndustry.IsSuccess Then
                                Call PrismDataFunctions.WriteInstallerIdsToDB(charIndustry.ResultData)
                                Call PrismDataFunctions.WriteInventionResultsToDB(charIndustry.ResultData)
                            End If

                        End If

                        ' Update the display
                        If IsHandleCreated = True Then
                            Invoke(Sub() CheckApiResult(charIndustry, pOwner, CorpRepType.Jobs))
                        End If

                    End If
                Catch e As Exception
                    Trace.TraceError(e.FormatException())
                    Dim msg As String = "An error occured while processing the Character Jobs data for " & pOwner.Name & ControlChars.CrLf
                    msg &= "The specific error was: " & e.Message & ControlChars.CrLf
                    msg &= "The stacktrace was: " & e.StackTrace & ControlChars.CrLf
                    MessageBox.Show(msg, "GetCharAssets Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            _prismThreadCurrent += 1
            If _prismThreadCurrent = _prismThreadMax Then
                Invoke(Sub() CompleteApiUpdate())
            End If

        End Sub
        Private Sub GetCharJournal2(ByVal state As Object)

            For Each pOwner As PrismOwner In PlugInData.PrismOwners.Values
                Try
                    If pOwner.IsCorp = False Then

                        Dim journalResponse As EveServiceResponse(Of IEnumerable(Of Entities.WalletJournalEntry))

                        Dim pilotAccount As EveHQAccount = pOwner.Account


                        ' Check for valid API Usage
                        If CanUseApi(pOwner, CorpRepType.WalletJournal) = True Then

                            ' Get the last referenceID for the wallet
                            Dim lastTrans As Long = PrismDataFunctions.GetLastWalletID(WalletTypes.Journal, CInt(pOwner.ID), 1000)

                            ' Start a loop to collect multiple APIs
                            Dim walletJournals As New SortedList(Of String, WalletJournalItem)
                            Dim lastRefId As Long = 0
                            Dim walletExhausted As Boolean

                            Do
                                ' Make a call to the EveHQ.Core.API to fetch the journal
                                Dim retries As Integer = 0
                                Do
                                    retries += 1
                                    journalResponse = HQ.ApiProvider.Character.WalletJournal(pilotAccount.UserID, pilotAccount.APIKey, CInt(pOwner.ID), 1000, lastRefId, Nothing, ResponseMode.BypassCache)

                                    'apixml = apireq.GetAPIXML(APITypes.WalletJournalChar, pilotAccount.ToAPIAccount, pOwner.ID, 1000, lastRefID, MaxAPIJournals, APIReturnMethods.ReturnStandard)
                                Loop Until retries >= MaxApiRetries Or journalResponse.IsSuccess

                                ' Parse the Journal XML to get the data
                                If journalResponse.IsSuccess Then
                                    walletExhausted = PrismDataFunctions.ParseWalletJournal(journalResponse.ResultData, walletJournals, pOwner.ID)
                                Else
                                    walletExhausted = True
                                End If

                                If walletJournals.Count <> 0 Then
                                    lastRefId = walletJournals(walletJournals.Keys(0)).RefID
                                Else
                                    walletExhausted = True
                                End If

                            Loop Until walletExhausted = True Or lastTrans > lastRefId

                            ' Write the journal to the database!
                            If walletJournals.Count > 0 Then
                                Call PrismDataFunctions.WriteWalletJournalsToDB(walletJournals, CInt(pOwner.ID), pOwner.Name, 1000, lastTrans)
                            End If

                        End If

                        ' Update the display
                        journalResponse = HQ.ApiProvider.Character.WalletJournal(pilotAccount.UserID, pilotAccount.APIKey, CInt(pOwner.ID), 0, 1000)

                        If IsHandleCreated = True Then
                            Invoke(Sub() CheckApiResult(journalResponse, pOwner, CorpRepType.WalletJournal))
                        End If

                    End If
                Catch e As Exception
                    Trace.TraceError(e.FormatException())
                    Dim msg As String = "An error occured while processing the Character Journal data for " & pOwner.Name & ControlChars.CrLf
                    msg &= "The specific error was: " & e.Message & ControlChars.CrLf
                    msg &= "The stacktrace was: " & e.StackTrace & ControlChars.CrLf
                    MessageBox.Show(msg, "GetCharAssets Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            _prismThreadCurrent += 1
            If _prismThreadCurrent = _prismThreadMax Then
                Invoke(Sub() CompleteApiUpdate())
            End If

        End Sub
        Private Sub GetCharOrders2(ByVal state As Object)

            For Each pOwner As PrismOwner In PlugInData.PrismOwners.Values
                Try
                    If pOwner.IsCorp = False Then

                        Dim pilotAccount As EveHQAccount = pOwner.Account

                        Dim orders As EveServiceResponse(Of IEnumerable(Of NewEveApi.Entities.MarketOrder))
                        ' Check for valid API Usage
                        If CanUseApi(pOwner, CorpRepType.Orders) = True Then

                            ' Make a call to the EveHQ.Core.API to fetch the relevant API
                            Dim retries As Integer = 0
                            Do
                                retries += 1
                                orders = HQ.ApiProvider.Character.MarketOrders(pilotAccount.UserID, pilotAccount.APIKey, CInt(pOwner.ID), ResponseMode.WaitOnRefresh)

                            Loop Until retries >= MaxApiRetries Or orders.IsSuccess

                        End If

                        ' Update the display
                        If IsHandleCreated = True Then
                            Invoke(Sub() CheckApiResult(orders, pOwner, CorpRepType.Orders))
                        End If

                    End If
                Catch e As Exception
                    Trace.TraceError(e.FormatException())
                    Dim msg As String = "An error occured while processing the Character Orders data for " & pOwner.Name & ControlChars.CrLf
                    msg &= "The specific error was: " & e.Message & ControlChars.CrLf
                    msg &= "The stacktrace was: " & e.StackTrace & ControlChars.CrLf
                    MessageBox.Show(msg, "GetCharAssets Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            _prismThreadCurrent += 1
            If _prismThreadCurrent = _prismThreadMax Then
                Invoke(Sub() CompleteApiUpdate())
            End If

        End Sub
        Private Sub GetCharTransactions2(ByVal state As Object)

            For Each pOwner As PrismOwner In PlugInData.PrismOwners.Values
                Try
                    If pOwner.IsCorp = False Then

                        Dim transactions As EveServiceResponse(Of IEnumerable(Of Entities.WalletTransaction))

                        Dim pilotAccount As EveHQAccount = pOwner.Account

                        Dim lastTransId As Long? = 0
                        Dim exhausted As Boolean
                        ' Check for valid API Usage
                        If CanUseApi(pOwner, CorpRepType.WalletTransactions) = True Then
                            Do
                                ' Make a call to the EveHQ.Core.API to fetch the transactions
                                Dim retries As Integer = 0
                                Do
                                    retries += 1
                                    transactions = HQ.ApiProvider.Character.WalletTransactions(pilotAccount.UserID, pilotAccount.APIKey, CInt(pOwner.ID), 1000, lastTransId, MaxApiJournals, ResponseMode.BypassCache)

                                Loop Until retries >= MaxApiRetries Or transactions.IsSuccess

                                ' Write the journal to the database!
                                If transactions.IsSuccess Then
                                    Dim affected = PrismDataFunctions.WriteWalletTransactionsToDB(transactions.ResultData, False, CInt(pOwner.ID), pOwner.Name, 1000)
                                    If affected > 0 Then
                                        lastTransId = transactions.ResultData.First().TransactionId
                                        exhausted = False
                                    Else
                                        exhausted = True
                                    End If
                                Else
                                    exhausted = True
                                End If
                            Loop Until exhausted = True
                        End If

                        ' Update the display
                        If IsHandleCreated = True Then
                            Invoke(Sub() CheckApiResult(transactions, pOwner, CorpRepType.WalletTransactions))
                        End If

                    End If
                Catch e As Exception
                    Trace.TraceError(e.FormatException())
                    Dim msg As String = "An error occured while processing the Character Transactions data for " & pOwner.Name & ControlChars.CrLf
                    msg &= "The specific error was: " & e.Message & ControlChars.CrLf
                    msg &= "The stacktrace was: " & e.StackTrace & ControlChars.CrLf
                    MessageBox.Show(msg, "GetCharAssets Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            _prismThreadCurrent += 1
            If _prismThreadCurrent = _prismThreadMax Then
                Invoke(Sub() CompleteApiUpdate())
            End If

        End Sub
        Private Sub GetCharContracts2(ByVal state As Object)

            For Each pOwner As PrismOwner In PlugInData.PrismOwners.Values
                Try
                    If pOwner.IsCorp = False Then

                        Dim contracts As EveServiceResponse(Of IEnumerable(Of NewEveApi.Entities.Contract))


                        Dim pilotAccount As EveHQAccount = pOwner.Account


                        ' Check for valid API Usage
                        If CanUseApi(pOwner, CorpRepType.Contracts) = True Then

                            ' Make a call to the EveHQ.Core.API to fetch the contracts
                            Dim retries As Integer = 0
                            Do
                                retries += 1
                                contracts = HQ.ApiProvider.Character.Contracts(pilotAccount.UserID, pilotAccount.APIKey, CInt(pOwner.ID), 0, ResponseMode.WaitOnRefresh)

                            Loop Until retries >= MaxApiRetries Or contracts.IsSuccess

                            ' Write the contractIDs to the database
                            If contracts.IsSuccess Then
                                Call PrismDataFunctions.WriteContractIdsToDB(contracts.ResultData)


                                ' Parse the Node List
                                For Each contractItem In contracts.ResultData
                                    HQ.ApiProvider.Character.ContractItemsAsync(pilotAccount.UserID, pilotAccount.APIKey, CInt(pOwner.ID), contractItem.ContractId)
                                Next
                            End If

                        End If

                        ' Update the display
                        If IsHandleCreated = True Then
                            Invoke(Sub() CheckApiResult(contracts, pOwner, CorpRepType.Contracts))
                        End If

                    End If
                Catch e As Exception
                    Trace.TraceError(e.FormatException())
                    Dim msg As String = "An error occured while processing the Character Contracts data for " & pOwner.Name & ControlChars.CrLf
                    msg &= "The specific error was: " & e.Message & ControlChars.CrLf
                    msg &= "The stacktrace was: " & e.StackTrace & ControlChars.CrLf
                    MessageBox.Show(msg, "GetCharAssets Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            _prismThreadCurrent += 1
            If _prismThreadCurrent = _prismThreadMax Then
                Invoke(Sub() CompleteApiUpdate())
            End If

        End Sub
        Private Sub UpdateNullCorpSheet2(ByVal state As Object)

            For Each pOwner As PrismOwner In PlugInData.PrismOwners.Values
                Try
                    If pOwner.IsCorp = False Then

                        ' Update the display
                        If IsHandleCreated = True Then
                            Invoke(Sub() CheckApiResult(Of Entities.CharacterData)(Nothing, pOwner, CorpRepType.CorpSheet))
                        End If

                    End If
                Catch e As Exception
                    Trace.TraceError(e.FormatException())
                    Dim msg As String = "An error occured while processing the Null Corp Sheet data for " & pOwner.Name & ControlChars.CrLf
                    msg &= "The specific error was: " & e.Message & ControlChars.CrLf
                    msg &= "The stacktrace was: " & e.StackTrace & ControlChars.CrLf
                    MessageBox.Show(msg, "GetCharAssets Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            _prismThreadCurrent += 1
            If _prismThreadCurrent = _prismThreadMax Then
                Invoke(Sub() CompleteApiUpdate())
            End If
        End Sub

        Private Sub GetCorpAssets2(ByVal state As Object)

            For Each pOwner As PrismOwner In PlugInData.PrismOwners.Values
                Try
                    If pOwner.IsCorp = True Then

                        Dim corpAssets As EveServiceResponse(Of IEnumerable(Of NewEveApi.Entities.AssetItem))
                        Dim pilotAccount As EveHQAccount = PlugInData.GetAccountForCorpOwner(pOwner, CorpRepType.Assets)
                        Dim ownerId As String = PlugInData.GetAccountOwnerIDForCorpOwner(pOwner, CorpRepType.Assets)
                        ' Check for valid API Usage
                        If CanUseApi(pOwner, CorpRepType.Assets) = True Then

                            ' Make a call to the EveHQ.Core.API to fetch the relevant API
                            Dim retries As Integer = 0
                            Do
                                retries += 1
                                corpAssets = HQ.ApiProvider.Corporation.AssetList(pilotAccount.UserID, pilotAccount.APIKey, CInt(ownerId), ResponseMode.WaitOnRefresh)
                            Loop Until retries >= MaxApiRetries Or corpAssets.IsSuccess

                        End If

                        ' Update the display
                        If IsHandleCreated = True Then
                            Dim cOwner = pOwner 'copy ref to local to prevent foreach closure violation.
                            Invoke(Sub() CheckApiResult(corpAssets, cOwner, CorpRepType.Assets))
                        End If



                        ' Update the display
                        If IsHandleCreated = True Then
                            Invoke(Sub() CheckApiResult(corpAssets, pOwner, CorpRepType.Assets))
                        End If

                    End If
                Catch e As Exception
                    Trace.TraceError(e.FormatException())
                    Dim msg As String = "An error occured while processing the Corporate Assets data for " & pOwner.Name & ControlChars.CrLf
                    msg &= "The specific error was: " & e.Message & ControlChars.CrLf
                    msg &= "The stacktrace was: " & e.StackTrace & ControlChars.CrLf
                    MessageBox.Show(msg, "GetCharAssets Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            _prismThreadCurrent += 1
            If _prismThreadCurrent = _prismThreadMax Then
                Invoke(Sub() CompleteApiUpdate())
            End If

        End Sub
        Private Sub GetCorpBalances2(ByVal state As Object)

            For Each pOwner As PrismOwner In PlugInData.PrismOwners.Values
                Try
                    If pOwner.IsCorp = True Then
                        Dim corpBalance As EveServiceResponse(Of IEnumerable(Of Entities.AccountBalance))

                        Dim pilotAccount As EveHQAccount = PlugInData.GetAccountForCorpOwner(pOwner, CorpRepType.Balances)
                        Dim ownerId As String = PlugInData.GetAccountOwnerIDForCorpOwner(pOwner, CorpRepType.Balances)
                        If pilotAccount IsNot Nothing And ownerId <> "" Then
                            ' Check for valid API Usage
                            If CanUseApi(pOwner, CorpRepType.Balances) = True Then

                                ' Make a call to the EveHQ.Core.API to fetch the relevant API
                                Dim retries As Integer = 0
                                Do
                                    retries += 1
                                    corpBalance = HQ.ApiProvider.Corporation.AccountBalance(pilotAccount.UserID, pilotAccount.APIKey, CInt(ownerId), ResponseMode.WaitOnRefresh)

                                Loop Until retries >= MaxApiRetries Or corpBalance.IsSuccess

                            End If
                        End If

                        ' Update the display
                        If IsHandleCreated = True Then
                            Invoke(Sub() CheckApiResult(corpBalance, pOwner, CorpRepType.Balances))
                        End If

                    End If
                Catch e As Exception
                    Trace.TraceError(e.FormatException())
                    Dim msg As String = "An error occured while processing the Corporate Balances data for " & pOwner.Name & ControlChars.CrLf
                    msg &= "The specific error was: " & e.Message & ControlChars.CrLf
                    msg &= "The stacktrace was: " & e.StackTrace & ControlChars.CrLf
                    MessageBox.Show(msg, "GetCharAssets Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            _prismThreadCurrent += 1
            If _prismThreadCurrent = _prismThreadMax Then
                Invoke(Sub() CompleteApiUpdate())
            End If

        End Sub
        Private Sub GetCorpJobs2(ByVal state As Object)

            For Each pOwner As PrismOwner In PlugInData.PrismOwners.Values
                Try
                    If pOwner.IsCorp = True Then
                        Dim corpJobs As EveServiceResponse(Of IEnumerable(Of NewEveApi.Entities.IndustryJob))

                        Dim pilotAccount As EveHQAccount = PlugInData.GetAccountForCorpOwner(pOwner, CorpRepType.Jobs)
                        Dim ownerId As String = PlugInData.GetAccountOwnerIDForCorpOwner(pOwner, CorpRepType.Jobs)
                        If pilotAccount IsNot Nothing And ownerId <> "" Then

                            ' Check for valid API Usage
                            If CanUseApi(pOwner, CorpRepType.Jobs) = True Then

                                ' Make a call to the EveHQ.Core.API to fetch the relevant API
                                Dim retries As Integer = 0
                                Do
                                    retries += 1
                                    corpJobs = HQ.ApiProvider.Corporation.IndustryJobs(pilotAccount.UserID, pilotAccount.APIKey, CInt(ownerId), ResponseMode.WaitOnRefresh)

                                Loop Until retries >= MaxApiRetries Or corpJobs.IsSuccess

                                ' Write the installerIDs to the database
                                If corpJobs IsNot Nothing Then
                                    If corpJobs.IsSuccess Then
                                        Call PrismDataFunctions.WriteInstallerIdsToDB(corpJobs.ResultData)
                                        Call PrismDataFunctions.WriteInventionResultsToDB(corpJobs.ResultData)
                                    End If
                                End If
                            End If

                        End If

                        ' Update the display
                        If IsHandleCreated = True Then
                            Invoke(Sub() CheckApiResult(corpJobs, pOwner, CorpRepType.Jobs))
                        End If

                    End If
                Catch e As Exception
                    Trace.TraceError(e.FormatException())
                    Dim msg As String = "An error occured while processing the Corporate Jobs data for " & pOwner.Name & ControlChars.CrLf
                    msg &= "The specific error was: " & e.Message & ControlChars.CrLf
                    msg &= "The stacktrace was: " & e.StackTrace & ControlChars.CrLf
                    MessageBox.Show(msg, "GetCharAssets Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            _prismThreadCurrent += 1
            If _prismThreadCurrent = _prismThreadMax Then
                Invoke(Sub() CompleteApiUpdate())
            End If

        End Sub
        Private Sub GetCorpJournal2(ByVal state As Object)

            For Each pOwner As PrismOwner In PlugInData.PrismOwners.Values
                Try
                    If pOwner.IsCorp = True Then
                        Dim corpJournal As EveServiceResponse(Of IEnumerable(Of Entities.WalletJournalEntry))

                        Dim pilotAccount As EveHQAccount = PlugInData.GetAccountForCorpOwner(pOwner, CorpRepType.WalletJournal)

                        Dim ownerId As String = PlugInData.GetAccountOwnerIDForCorpOwner(pOwner, CorpRepType.WalletJournal)
                        If pilotAccount IsNot Nothing And ownerId <> "" Then

                            ' Check for valid API Usage
                            If CanUseApi(pOwner, CorpRepType.WalletJournal) = True Then

                                For divId As Integer = 1006 To 1000 Step -1

                                    ' Get the last referenceID for the wallet
                                    Dim lastTrans As Long = PrismDataFunctions.GetLastWalletID(WalletTypes.Journal, CInt(pOwner.ID), divId)

                                    ' Start a loop to collect multiple APIs
                                    Dim walletJournals As New SortedList(Of String, WalletJournalItem)
                                    Dim lastRefId As Long = 0
                                    Dim walletExhausted As Boolean


                                    Do
                                        ' Make a call to the EveHQ.Core.API to fetch the journal
                                        Dim retries As Integer = 0
                                        Do
                                            retries += 1
                                            corpJournal = HQ.ApiProvider.Corporation.WalletJournal(pilotAccount.UserID, pilotAccount.APIKey, CInt(ownerId), divId, lastRefId, MaxApiJournals, ResponseMode.BypassCache)
                                            ' apixml = apireq.GetAPIXML(APITypes.WalletJournalCorp, pilotAccount.ToAPIAccount, ownerID, divID, lastRefID, MaxAPIJournals, APIReturnMethods.ReturnStandard)
                                        Loop Until retries >= MaxApiRetries Or corpJournal.IsSuccess

                                        ' Parse the Journal XML to get the data
                                        If corpJournal.IsSuccess Then
                                            walletExhausted = PrismDataFunctions.ParseWalletJournal(corpJournal.ResultData, walletJournals, pOwner.ID)
                                        Else
                                            walletExhausted = True
                                        End If

                                        If walletJournals.Count <> 0 Then
                                            lastRefId = walletJournals(walletJournals.Keys(0)).RefID
                                        Else
                                            walletExhausted = True
                                        End If

                                    Loop Until walletExhausted = True Or lastTrans > lastRefId

                                    ' Write the journal to the database!
                                    If walletJournals.Count > 0 Then
                                        Call PrismDataFunctions.WriteWalletJournalsToDB(walletJournals, CInt(pOwner.ID), pOwner.Name, divId, lastTrans)
                                    End If

                                Next


                            End If

                        End If

                        ' Update the display
                        If IsHandleCreated = True Then
                            Invoke(Sub() CheckApiResult(corpJournal, pOwner, CorpRepType.WalletJournal))
                        End If

                    End If
                Catch e As Exception
                    Trace.TraceError(e.FormatException())
                    Dim msg As String = "An error occured while processing the Corporate Journal data for " & pOwner.Name & ControlChars.CrLf
                    msg &= "The specific error was: " & e.Message & ControlChars.CrLf
                    msg &= "The stacktrace was: " & e.StackTrace & ControlChars.CrLf
                    MessageBox.Show(msg, "GetCharAssets Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            _prismThreadCurrent += 1
            If _prismThreadCurrent = _prismThreadMax Then
                Invoke(Sub() CompleteApiUpdate())
            End If

        End Sub
        Private Sub GetCorpOrders2(ByVal state As Object)

            For Each pOwner As PrismOwner In PlugInData.PrismOwners.Values
                Try
                    If pOwner.IsCorp = True Then

                        Dim corpOrders As New EveServiceResponse(Of IEnumerable(Of NewEveApi.Entities.MarketOrder))
                        Dim pilotAccount As EveHQAccount = PlugInData.GetAccountForCorpOwner(pOwner, CorpRepType.Orders)
                        Dim ownerId As String = PlugInData.GetAccountOwnerIDForCorpOwner(pOwner, CorpRepType.Orders)
                        If pilotAccount IsNot Nothing And ownerId <> "" Then

                            ' Check for valid API Usage
                            If CanUseApi(pOwner, CorpRepType.Orders) = True Then

                                ' Make a call to the EveHQ.Core.API to fetch the relevant API
                                Dim retries As Integer = 0
                                Do
                                    retries += 1
                                    corpOrders = HQ.ApiProvider.Corporation.MarketOrders(pilotAccount.UserID, pilotAccount.APIKey, CInt(ownerId), ResponseMode.WaitOnRefresh)
                                Loop Until retries >= MaxApiRetries Or corpOrders.IsSuccess

                            End If

                        End If

                        ' Update the display
                        If IsHandleCreated = True Then
                            Invoke(Sub() CheckApiResult(corpOrders, pOwner, CorpRepType.Orders))
                        End If

                    End If
                Catch e As Exception
                    Trace.TraceError(e.FormatException())
                    Dim msg As String = "An error occured while processing the Corporate Orders data for " & pOwner.Name & ControlChars.CrLf
                    msg &= "The specific error was: " & e.Message & ControlChars.CrLf
                    msg &= "The stacktrace was: " & e.StackTrace & ControlChars.CrLf
                    MessageBox.Show(msg, "GetCharAssets Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            _prismThreadCurrent += 1
            If _prismThreadCurrent = _prismThreadMax Then
                Invoke(Sub() CompleteApiUpdate())
            End If

        End Sub
        Private Sub GetCorpTransactions2(ByVal state As Object)

            For Each pOwner As PrismOwner In PlugInData.PrismOwners.Values
                Try
                    If pOwner.IsCorp = True Then

                        Dim corpTransactions As EveServiceResponse(Of IEnumerable(Of Entities.WalletTransaction))
                        Dim pilotAccount As EveHQAccount = PlugInData.GetAccountForCorpOwner(pOwner, CorpRepType.WalletTransactions)
                        Dim ownerId As String = PlugInData.GetAccountOwnerIDForCorpOwner(pOwner, CorpRepType.WalletTransactions)
                        If pilotAccount IsNot Nothing And ownerId <> "" Then
                            Dim walletExhausted As Boolean
                            Dim lastId As Long? = Nothing
                            ' Check for valid API Usage
                            If CanUseApi(pOwner, CorpRepType.WalletTransactions) = True Then

                                For divId As Integer = 1006 To 1000 Step -1

                                    Do
                                        ' Make a call to the EveHQ.Core.API to fetch the transactions
                                        Dim retries As Integer = 0
                                        Do
                                            retries += 1
                                            corpTransactions = HQ.ApiProvider.Corporation.WalletTransactions(pilotAccount.UserID, pilotAccount.APIKey, CInt(ownerId), divId, lastId, MaxApiJournals, ResponseMode.BypassCache)
                                        Loop Until retries >= MaxApiRetries Or corpTransactions.IsSuccess

                                        If corpTransactions.IsSuccess Then

                                            ' Write the journal to the database!
                                            Dim affected = PrismDataFunctions.WriteWalletTransactionsToDB(corpTransactions.ResultData, False, CInt(pOwner.ID), pOwner.Name, divId)
                                            If affected > 0 Then
                                                lastId = corpTransactions.ResultData.First().TransactionId
                                                walletExhausted = False
                                            Else
                                                walletExhausted = True
                                            End If
                                        Else
                                            walletExhausted = True
                                        End If
                                    Loop Until walletExhausted = True
                                Next
                            End If

                        End If

                        ' Update the display
                        If IsHandleCreated = True Then
                            Invoke(Sub() CheckApiResult(corpTransactions, pOwner, CorpRepType.WalletTransactions))
                        End If

                    End If
                Catch e As Exception
                    Trace.TraceError(e.FormatException())
                    Dim msg As String = "An error occured while processing the Corporate Transactions data for " & pOwner.Name & ControlChars.CrLf
                    msg &= "The specific error was: " & e.Message & ControlChars.CrLf
                    msg &= "The stacktrace was: " & e.StackTrace & ControlChars.CrLf
                    MessageBox.Show(msg, "GetCharAssets Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            _prismThreadCurrent += 1
            If _prismThreadCurrent = _prismThreadMax Then
                Invoke(Sub() CompleteApiUpdate())
            End If

        End Sub
        Private Sub GetCorpContracts2(ByVal state As Object)

            For Each pOwner As PrismOwner In PlugInData.PrismOwners.Values
                Try
                    If pOwner.IsCorp = True Then

                        Dim corpContacts As EveServiceResponse(Of IEnumerable(Of NewEveApi.Entities.Contract))

                        Dim contractItems As EveServiceResponse(Of IEnumerable(Of Entities.ContractItem))
                        Dim pilotAccount As EveHQAccount = PlugInData.GetAccountForCorpOwner(pOwner, CorpRepType.Contracts)
                        Dim ownerId As String = PlugInData.GetAccountOwnerIDForCorpOwner(pOwner, CorpRepType.Contracts)
                        If pilotAccount IsNot Nothing And ownerId <> "" Then

                            ' Check for valid API Usage
                            If CanUseApi(pOwner, CorpRepType.Contracts) = True Then

                                ' Make a call to the EveHQ.Core.API to fetch the contracts
                                Dim retries As Integer = 0
                                Do
                                    retries += 1
                                    corpContacts = HQ.ApiProvider.Corporation.Contracts(pilotAccount.UserID, pilotAccount.APIKey, CInt(ownerId), 0, ResponseMode.WaitOnRefresh)
                                Loop Until retries >= MaxApiRetries Or corpContacts.IsSuccess

                                ' Write the contractIDs to the database
                                If corpContacts.IsSuccess Then
                                    Call PrismDataFunctions.WriteContractIdsToDB(corpContacts.ResultData)

                                    For Each contractItem In corpContacts.ResultData
                                        Dim contractId As Long = contractItem.ContractId
                                        retries = 0
                                        Do
                                            retries += 1
                                            contractItems = HQ.ApiProvider.Corporation.ContractItems(pilotAccount.UserID, pilotAccount.APIKey, CInt(ownerId), contractId)
                                        Loop Until retries >= MaxApiRetries Or contractItems.IsSuccess
                                    Next
                                End If
                            End If
                        End If

                        ' Update the display
                        If IsHandleCreated = True Then
                            Invoke(Sub() CheckApiResult(corpContacts, pOwner, CorpRepType.Contracts))
                        End If

                    End If
                Catch e As Exception
                    Trace.TraceError(e.FormatException())
                    Dim msg As String = "An error occured while processing the Corporate Contracts data for " & pOwner.Name & ControlChars.CrLf
                    msg &= "The specific error was: " & e.Message & ControlChars.CrLf
                    msg &= "The stacktrace was: " & e.StackTrace & ControlChars.CrLf
                    MessageBox.Show(msg, "GetCharAssets Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            _prismThreadCurrent += 1
            If _prismThreadCurrent = _prismThreadMax Then
                Invoke(Sub() CompleteApiUpdate())
            End If

        End Sub
        Private Sub GetCorpSheet2(ByVal state As Object)

            For Each pOwner As PrismOwner In PlugInData.PrismOwners.Values
                Try
                    If pOwner.IsCorp = True Then

                        Dim info As EveServiceResponse(Of Entities.CorporateData)

                        Dim pilotAccount As EveHQAccount = PlugInData.GetAccountForCorpOwner(pOwner, CorpRepType.CorpSheet)

                        Dim ownerId As String = PlugInData.GetAccountOwnerIDForCorpOwner(pOwner, CorpRepType.CorpSheet)
                        If pilotAccount IsNot Nothing And ownerId <> "" Then


                            ' Check for valid API Usage
                            If CanUseApi(pOwner, CorpRepType.CorpSheet) = True Then

                                ' Make a call to the EveHQ.Core.API to fetch the relevant API
                                Dim retries As Integer = 0
                                Do
                                    retries += 1
                                    info = HQ.ApiProvider.Corporation.CorporationSheet(pilotAccount.UserID, pilotAccount.APIKey, 0, ResponseMode.WaitOnRefresh)
                                Loop Until retries >= MaxApiRetries Or info.IsSuccess

                            End If
                        End If

                        ' Update the display
                        If IsHandleCreated = True Then
                            Invoke(Sub() CheckApiResult(info, pOwner, CorpRepType.CorpSheet))
                        End If

                    End If
                Catch e As Exception
                    Trace.TraceError(e.FormatException())
                    Dim msg As String = "An error occured while processing the Corporation Sheet data for " & pOwner.Name & ControlChars.CrLf
                    msg &= "The specific error was: " & e.Message & ControlChars.CrLf
                    msg &= "The stacktrace was: " & e.StackTrace & ControlChars.CrLf
                    MessageBox.Show(msg, "GetCharAssets Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            _prismThreadCurrent += 1
            If _prismThreadCurrent = _prismThreadMax Then
                Invoke(Sub() CompleteApiUpdate())
            End If

        End Sub

#End Region

#End Region

#Region "Market Orders Routines"

        Private Sub cboOrdersOwner_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboOrdersOwner.SelectedIndexChanged
            Call ParseOrders()
        End Sub

        Private Sub ParseOrders()
            ' Get the owner we will use
            Dim pOwner As PrismOwner
            If cboOrdersOwner.SelectedItem IsNot Nothing Then
                If PlugInData.PrismOwners.ContainsKey(cboOrdersOwner.SelectedItem.ToString) Then
                    pOwner = PlugInData.PrismOwners(cboOrdersOwner.SelectedItem.ToString)
                    Dim ownerAccount As EveHQAccount = PlugInData.GetAccountForCorpOwner(pOwner, CorpRepType.Orders)
                    Dim ownerId As String = PlugInData.GetAccountOwnerIDForCorpOwner(pOwner, CorpRepType.Orders)
                    Dim marketOrders As EveServiceResponse(Of IEnumerable(Of NewEveApi.Entities.MarketOrder))

                    If ownerAccount IsNot Nothing Then

                        If pOwner.IsCorp = True Then
                            marketOrders = HQ.ApiProvider.Corporation.MarketOrders(ownerAccount.UserID, ownerAccount.APIKey, CInt(ownerId))
                        Else
                            marketOrders = HQ.ApiProvider.Character.MarketOrders(ownerAccount.UserID, ownerAccount.APIKey, CInt(ownerId))
                        End If
                        Dim sellTotal, buyTotal, totalEscrow As Double
                        Dim totalOrders As Integer = 0
                        If marketOrders.IsSuccess Then

                            adtBuyOrders.BeginUpdate()
                            adtSellOrders.BeginUpdate()
                            adtBuyOrders.Nodes.Clear()
                            adtSellOrders.Nodes.Clear()
                            For Each order In marketOrders.ResultData
                                If order.IsBuyOrder = False Then
                                    If order.OrderState = NewEveApi.Entities.MarketOrderState.Active Then
                                        Dim sOrder As New Node
                                        adtSellOrders.Nodes.Add(sOrder)
                                        sOrder.CreateCells()
                                        Dim itemId As Integer = order.TypeId
                                        Dim itemName As String
                                        If StaticData.Types.ContainsKey(itemId) = True Then
                                            itemName = StaticData.Types(itemId).Name
                                        Else
                                            itemName = "Unknown Item ID:" & itemId
                                        End If
                                        sOrder.Text = itemName
                                        Dim quantity As Double = order.QuantityRemaining
                                        sOrder.Cells(1).Text = quantity.ToInvariantString("N0") & " / " & order.QuantityEntered.ToInvariantString("N0")
                                        Dim price As Double = order.Price
                                        sOrder.Cells(2).Text = price.ToInvariantString("N2")
                                        Dim loc As String
                                        Dim temp As Station
                                        If StaticData.Stations.TryGetValue(order.StationId, temp) = True Then
                                            loc = temp.StationName
                                        Else
                                            loc = "StationID: " & order.StationId
                                        End If
                                        sOrder.Cells(3).Text = loc
                                        Dim issueDate As Date = order.DateIssued.ToLocalTime().DateTime
                                        Dim orderExpires As TimeSpan = issueDate - Now
                                        orderExpires = orderExpires.Add(order.Duration)
                                        sOrder.Cells(4).Tag = orderExpires
                                        If orderExpires.TotalSeconds <= 0 Then
                                            sOrder.Cells(4).Text = "Expired!"
                                        Else
                                            sOrder.Cells(4).Text = SkillFunctions.TimeToString(orderExpires.TotalSeconds, False)
                                        End If
                                        sellTotal = sellTotal + quantity * price
                                        totalOrders = totalOrders + 1
                                    End If
                                Else
                                    If order.OrderState = NewEveApi.Entities.MarketOrderState.Active Then
                                        Dim bOrder As New Node
                                        adtBuyOrders.Nodes.Add(bOrder)
                                        bOrder.CreateCells()
                                        Dim itemId As Integer = order.TypeId
                                        Dim itemName As String
                                        If StaticData.Types.ContainsKey(itemId) = True Then
                                            itemName = StaticData.Types(itemId).Name
                                        Else
                                            itemName = "Unknown Item ID:" & itemId
                                        End If
                                        bOrder.Text = itemName
                                        Dim quantity As Double = order.QuantityRemaining
                                        bOrder.Cells(1).Text = quantity.ToInvariantString("N0") & " / " & order.QuantityEntered.ToInvariantString("N0")
                                        Dim price As Double = order.Price
                                        bOrder.Cells(2).Text = price.ToInvariantString("N2")
                                        Dim loc As String
                                        Dim temp As Station
                                        If StaticData.Stations.TryGetValue(order.StationId, temp) = True Then
                                            loc = temp.StationName
                                        Else
                                            loc = "StationID: " & order.StationId.ToInvariantString()
                                        End If
                                        bOrder.Cells(3).Text = loc
                                        bOrder.Cells(4).Tag = order.Range
                                        Select Case order.Range
                                            Case -1
                                                bOrder.Cells(4).Text = "Station"
                                            Case 0
                                                bOrder.Cells(4).Text = "System"
                                            Case 32767
                                                bOrder.Cells(4).Text = "EveGalaticRegion"
                                            Case Is > 0, Is < 32767
                                                bOrder.Cells(4).Text = order.Range & " Jumps"
                                        End Select
                                        bOrder.Cells(5).Text = order.MinQuantity.ToInvariantString("N0")
                                        Dim issueDate As Date = order.DateIssued.ToLocalTime().DateTime
                                        Dim orderExpires As TimeSpan = issueDate - Now
                                        orderExpires = orderExpires.Add(order.Duration)
                                        bOrder.Cells(6).Tag = orderExpires
                                        If orderExpires.TotalSeconds <= 0 Then
                                            bOrder.Cells(6).Text = "Expired!"
                                        Else
                                            bOrder.Cells(6).Text = SkillFunctions.TimeToString(orderExpires.TotalSeconds, False)
                                        End If
                                        buyTotal = buyTotal + quantity * price
                                        totalEscrow = totalEscrow + order.Escrow
                                        totalOrders = totalOrders + 1
                                    End If
                                End If
                            Next
                            If adtBuyOrders.Nodes.Count = 0 Then
                                adtBuyOrders.Nodes.Add(New Node("No Data Available..."))
                                adtBuyOrders.Enabled = False
                            Else
                                adtBuyOrders.Enabled = True
                            End If
                            If adtSellOrders.Nodes.Count = 0 Then
                                adtSellOrders.Nodes.Add(New Node("No Data Available..."))
                                adtSellOrders.Enabled = False
                            Else
                                adtSellOrders.Enabled = True
                            End If
                            AdvTreeSorter.Sort(adtBuyOrders, 1, True, False)
                            adtBuyOrders.EndUpdate()
                            AdvTreeSorter.Sort(adtSellOrders, 1, True, False)
                            adtSellOrders.EndUpdate()
                        End If

                        If pOwner.IsCorp = False Then
                            If HQ.Settings.Pilots.ContainsKey(pOwner.Name) = True Then
                                Dim selPilot As EveHQPilot = HQ.Settings.Pilots(pOwner.Name)
                                Dim maxorders As Integer = 5 + (CInt(selPilot.KeySkills(KeySkill.Trade)) * 4) + (CInt(selPilot.KeySkills(KeySkill.Tycoon)) * 32) + (CInt(selPilot.KeySkills(KeySkill.Retail)) * 8) + (CInt(selPilot.KeySkills(KeySkill.Wholesale)) * 16)
                                Dim transTax As Double = 1 * (1.5 - 0.15 * (CInt(selPilot.KeySkills(KeySkill.Accounting))))
                                Dim brokerFee As Double = 1 * (1 - 0.05 * (CInt(selPilot.KeySkills(KeySkill.BrokerRelations))))
                                lblAskRange.Text = GetOrderRange(CInt(selPilot.KeySkills(KeySkill.Procurement)))
                                lblBidRange.Text = GetOrderRange(CInt(selPilot.KeySkills(KeySkill.Marketing)))
                                lblModRange.Text = GetOrderRange(CInt(selPilot.KeySkills(KeySkill.Daytrading)))
                                lblRemoteRange.Text = GetOrderRange(CInt(selPilot.KeySkills(KeySkill.Visibility)))
                                lblOrders.Text = (maxorders - totalOrders).ToString + " / " + maxorders.ToString
                                lblBrokerFee.Text = brokerFee.ToString("N2") & "%"
                                lblTransTax.Text = transTax.ToString("N2") & "%"
                            Else
                                lblAskRange.Text = "n/a"
                                lblBidRange.Text = "n/a"
                                lblModRange.Text = "n/a"
                                lblRemoteRange.Text = "n/a"
                                lblOrders.Text = "n/a"
                                lblBrokerFee.Text = "n/a"
                                lblTransTax.Text = "n/a"
                            End If
                        Else
                            lblAskRange.Text = "n/a"
                            lblBidRange.Text = "n/a"
                            lblModRange.Text = "n/a"
                            lblRemoteRange.Text = "n/a"
                            lblOrders.Text = "n/a"
                            lblBrokerFee.Text = "n/a"
                            lblTransTax.Text = "n/a"
                        End If
                        Dim cover As Double = buyTotal - totalEscrow
                        lblSellTotal.Text = sellTotal.ToString("N2") & " isk"
                        lblBuyTotal.Text = buyTotal.ToString("N2") & " isk"
                        lblEscrow.Text = totalEscrow.ToString("N2") & " isk (additional " & cover.ToString("N2") & " isk to cover)"
                    Else
                        adtBuyOrders.BeginUpdate()
                        adtBuyOrders.Nodes.Clear()
                        adtBuyOrders.Nodes.Add(New Node("Access Denied - check API Status"))
                        adtBuyOrders.EndUpdate()
                        adtBuyOrders.Enabled = False
                        adtSellOrders.BeginUpdate()
                        adtSellOrders.Nodes.Clear()
                        adtSellOrders.Nodes.Add(New Node("Access Denied - check API Status"))
                        adtSellOrders.EndUpdate()
                        adtSellOrders.Enabled = False
                        lblOrders.Text = "n/a"
                        lblSellTotal.Text = "n/a"
                        lblBuyTotal.Text = "n/a"
                        lblEscrow.Text = "n/a"
                        lblAskRange.Text = "n/a"
                        lblBidRange.Text = "n/a"
                        lblModRange.Text = "n/a"
                        lblRemoteRange.Text = "n/a"
                        lblBrokerFee.Text = "n/a"
                        lblTransTax.Text = "n/a"
                    End If
                Else
                    adtBuyOrders.BeginUpdate()
                    adtBuyOrders.Nodes.Clear()
                    adtBuyOrders.Nodes.Add(New Node("Access Denied - check API Status"))
                    adtBuyOrders.EndUpdate()
                    adtBuyOrders.Enabled = False
                    adtSellOrders.BeginUpdate()
                    adtSellOrders.Nodes.Clear()
                    adtSellOrders.Nodes.Add(New Node("Access Denied - check API Status"))
                    adtSellOrders.EndUpdate()
                    adtSellOrders.Enabled = False
                    lblOrders.Text = "n/a"
                    lblSellTotal.Text = "n/a"
                    lblBuyTotal.Text = "n/a"
                    lblEscrow.Text = "n/a"
                    lblAskRange.Text = "n/a"
                    lblBidRange.Text = "n/a"
                    lblModRange.Text = "n/a"
                    lblRemoteRange.Text = "n/a"
                    lblBrokerFee.Text = "n/a"
                    lblTransTax.Text = "n/a"
                End If
            Else
                adtBuyOrders.BeginUpdate()
                adtBuyOrders.Nodes.Clear()
                adtBuyOrders.Nodes.Add(New Node("Access Denied - No valid pilot selected"))
                adtBuyOrders.EndUpdate()
                adtBuyOrders.Enabled = False
                adtSellOrders.BeginUpdate()
                adtSellOrders.Nodes.Clear()
                adtSellOrders.Nodes.Add(New Node("Access Denied - No valid pilot selected"))
                adtSellOrders.EndUpdate()
                adtSellOrders.Enabled = False
                lblOrders.Text = "n/a"
                lblSellTotal.Text = "n/a"
                lblBuyTotal.Text = "n/a"
                lblEscrow.Text = "n/a"
                lblAskRange.Text = "n/a"
                lblBidRange.Text = "n/a"
                lblModRange.Text = "n/a"
                lblRemoteRange.Text = "n/a"
                lblBrokerFee.Text = "n/a"
                lblTransTax.Text = "n/a"
            End If
        End Sub

        Private Function GetOrderRange(ByVal lvl As Integer) As String
            Select Case lvl
                Case 0
                    Return "limited to stations"
                Case 1
                    Return "limited to system"
                Case 2
                    Return "limited to 5 Jumps"
                Case 3
                    Return "limited to 10 Jumps"
                Case 4
                    Return "limited to 20 Jumps"
                Case Else
                    Return "limited to EveGalaticRegion"
            End Select
        End Function

        Private Sub adtBuyOrders_ColumnHeaderMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles adtBuyOrders.ColumnHeaderMouseDown
            Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
            AdvTreeSorter.Sort(ch, False, False)
        End Sub

        Private Sub adtSellOrders_ColumnHeaderMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles adtSellOrders.ColumnHeaderMouseDown
            Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
            AdvTreeSorter.Sort(ch, False, False)
        End Sub

#End Region

#Region "Wallet Journal Routines"

        Private Sub InitialiseJournal()
            ' Prepare info
            dtiJournalEndDate.Value = SkillFunctions.ConvertLocalTimeToEve(Now)
            dtiJournalStartDate.Value = SkillFunctions.ConvertLocalTimeToEve(Now.AddMonths(-1))
            cboJournalOwners.DropDownControl = New PrismSelectionControl(PrismSelectionType.JournalOwnersAll, False, cboJournalOwners)
            AddHandler CType(cboJournalOwners.DropDownControl, PrismSelectionControl).SelectionChanged, AddressOf JournalOwnersChanged
            cboJournalRefTypes.DropDownControl = New PrismSelectionControl(PrismSelectionType.JournalRefTypes, True, cboJournalRefTypes)
        End Sub

        Private Sub JournalOwnersChanged()
            ' Update the wallet based on the owner (should be single owner!)
            Call UpdateWalletJournalDivisions()
        End Sub

        Function BuildJournalDescription(ByVal refType As Integer, ByVal owner1 As String, ByVal owner2 As String, ByVal argId1 As String, ByVal argName1 As String) As String
            Dim misc As String = ", refType=" & CStr(refType) & ", arg1=" & argName1 & ", own1 =" & owner1 & ", own2=" & owner2
            Dim desc As String = PlugInData.RefTypes(refType.ToString)
            Select Case refType ' Only use items which require a change

                Case 0 'undefined
                    desc = "Undefined" & misc
                Case 1 'Player Trading
                    desc = "Direct trade between " & owner1 & " and " & owner2
                Case 2 'Market Transaction
                    desc = "Market: " & owner1 & " bought stuff from " & owner2
                Case 3 'GM cash transfer
                    desc = "GM Cash Transfer"
                Case 4 ' ATM Withdraw
                    desc = "ATM Withdraw" & misc
                Case 5 ' ATM Deposit
                    desc = "ATM Deposit" & misc
                Case 6 ' backward compatible
                    desc = "Backward Compatible" & misc
                Case 7 ' Mission reward
                    desc = "Mission Reward" & misc
                Case 8 ' Clone Activation
                    desc = "Clone Activation"
                Case 9 ' Inheritance
                    desc = "Inheritance paid to " & owner2 & " following the death of " & owner1
                Case 10 'Player Donation 
                    desc = owner1 & " deposited cash in " & owner2 & "'s account"
                Case 11 'Corporation Payment
                    desc = "Corporation Payment" & misc
                Case 12 'Docking Fee'
                    desc = "Docking Fee" & misc
                Case 13 'Office Rental Fee
                    desc = "Office Rental Fee paid to" & owner2 & " by " & owner1
                Case 14 'Factory Slot Rental Fee
                    desc = "Factory Slot Rental Fee" & misc
                Case 15 'Repair Bill
                    desc = "Repair Bill between " & owner1 & " and " & owner2
                Case 16 'Bounty
                    desc = "Bounty" & misc
                Case 17 ' Bounty
                    desc = owner1 & " recieved bounty prizes for killing pirates in" & argName1
                Case 18 ' Agents Temp
                    desc = "Agents Temporary" & misc
                Case 19 ' Insurance
                    Dim itemName As String = "ship"
                    ' Check if the argName1 is numeric first
                    If IsNumeric(argName1) Then
                        ' See if we can convert to an integer
                        Dim typeId As Integer
                        If Integer.TryParse(argName1, typeId) Then
                            If StaticData.Types.ContainsKey(typeId) = True Then
                                itemName = StaticData.Types(typeId).Name
                            Else
                                itemName = "Unknown Item: ID=" & typeId.ToString
                            End If
                        Else
                            ' TODO: Work out what this negative 64-bit number represents
                            ' Possibly an assetID, leave it as a ship for now!
                        End If
                    End If
                    desc = "Insurance paid by EVE Central Bank to " & owner2 & " covering loss of a " & itemName
                Case 20 'Mission Expiration
                    desc = "Mission Expiration" & misc
                Case 21 'Mission Completion
                    desc = "Mission Completion" & misc
                Case 22 'Shares
                    desc = "Shares" & misc
                Case 23 'Courier Mission Escrow
                    desc = "Courier Mission Escrow " & misc
                Case 24 'Mission Cost
                    desc = "Mission Cost " & misc
                Case 25 'Agent Miscellaneous
                    desc = "Agent Miscellaneous" & misc
                Case 26 'Miscellaneous Payment To Agent
                    desc = "Loyalty Store Payment to " & owner2
                Case 27 'Agent Location Services
                    desc = "Agent Location Service Fee paid to " & owner2
                Case 28 'Agent Donation
                    desc = "Agent Donation " & misc
                Case 29 'Agent Security Services
                    desc = "Agent Security Services " & misc
                Case 30 'Agent Mission Collateral Paid
                    desc = "Agent Mission Collateral Paid " & misc
                Case 31 'Agent Mission Collateral Refunded
                    desc = "Agent Mission Collateral Refunded " & misc
                Case 32 'Agents_preward
                    desc = "Agents Preward " & misc
                Case 33 'Agent Mission Reward
                    'desc = "Agent Mission Reward" & misc
                    desc = owner2 & " recieved mission reward from agent " & owner1
                Case 34 'Agent Mission Time Bonus Reward
                    desc = owner2 & " received mission time bonus reward from agent " & owner1
                Case 35 ' CSPA Charges
                    desc = "CSPA for communication with " & argName1
                Case 36 'CSPAOfflineRefund
                    desc = "CSPA Offline Refund " & misc
                Case 37 'Corp Account Withdraw
                    desc = argName1 & " transferred cash from " & owner1 & "'s corporate account to " & owner2 & "'s account"
                Case 38 'Corporation Dividend Payment
                    If owner1 = "" Then
                        ' Receiving Dividend
                        desc = "Dividend received from " & argName1
                    Else
                        ' Paying Dividend
                        desc = "Dividend payment made by " & owner1
                    End If
                Case 39 'Corporation Registration Fee
                    If owner1 = "CONCORD" Then
                        desc = owner1 & " refunded corporation registration fee"
                    Else
                        desc = owner1 & " paid corporation registration fee"
                    End If
                Case 40 'Corporation Logo Change Cost
                    desc = misc
                Case 41 'Release Of Impounded Property
                    desc = misc
                Case 42 'market escrow
                    desc = "Market escrow authorized by " & owner1
                Case 43 'Agent Services Rendered
                    desc = misc
                Case 44 'Market Fine Paid
                    desc = misc
                Case 45 'Corporation Liquidation
                    desc = misc
                Case 46 'Broker fee
                    desc = "Brokers fee authorized by " & owner1
                Case 47 'Corporation Bulk Payment
                    desc = misc
                Case 48 'Alliance Registration Fee
                    desc = "Alliance registration fee paid to " & owner2
                Case 49 'War Fee
                    desc = misc
                Case 50 'Alliance Maintainance Fee
                    desc = "Alliance maintenance fee paid for membership in " & argName1
                Case 51 'Contraband Fine 
                    desc = misc
                Case 52 'Clone Transfer
                    desc = owner1 & " transfered clone to " & argName1
                Case 53 'Acceleration Gate Fee
                    desc = misc
                Case 54 ' Transaction tax
                    desc = "Sales tax paid to the SCC"
                Case 55 'Jump Clone Installation Fee
                    desc = "Jump Clone Installation Fee"
                Case 56 ' Manufacturing
                    desc = "Manufacturing job fee between " & owner1 & " and " & owner2 & " (Job ID:" & argName1 & ")"
                Case 57 'Researching Technology
                    desc = misc
                Case 58 'Researching Time Productivity
                    desc = "Time productivity research job fee between " & owner1 & " and " & owner2 & " (Job ID:" & argName1 & ")"
                Case 59 'Researching Material Productivity
                    desc = "Material productivity research job fee between " & owner1 & " and " & owner2 & " (Job ID:" & argName1 & ")"
                Case 60 'Copying
                    desc = "Blueprint copying job fee between " & owner1 & " and " & owner2 & " (Job ID:" & argName1 & ")"
                Case 61 'Duplicating
                    desc = misc
                Case 62 'Reverse Engineering
                    desc = misc
                Case 63 'Contract
                    desc = owner1 & " bid on an auction (Contract ID:" & argName1 & ")"
                Case 64 'Contract Auction Bid Refund
                    desc = owner2 & " received a refund on a contract aution bid (Contract ID:" & argName1 & ")"
                Case 65 'Contract Collateral
                    desc = misc
                Case 66 'Contract Reward Refund
                    desc = misc
                Case 67 'Contract Auction Sold
                    desc = "Price for Contract auction sold"
                Case 68 'Contract Reward
                    desc = "Contract Reward (Contract ID: " & argName1 & ")"
                Case 69 'Contract Collateral Refund
                    desc = misc
                Case 70 'Contract Collateral Payout
                    desc = misc
                Case 71 'Contract Price
                    desc = owner1 & " accepted a contract from " & owner2 & " (Contract ID: " & argName1 & ")"
                Case 72 'Contract Brokers Fee
                    desc = "Contract Brokers Fee (Contract ID: " & argName1 & ")"
                Case 73 'Contract Sales Tax
                    desc = "Contract Sales Tax (Contract ID: " & argName1 & ")"
                Case 74 'Contract Deposit
                    desc = "Contract Deposit (Contract ID: " & argName1 & ")"
                Case 75 'Contract Deposit Sales Tax
                    desc = misc
                Case 76 'Secure EVE Time Code Exchange
                    desc = misc
                Case 77 'Contract Auction Bid (corp)
                    desc = owner1 & " bid on a contract auction for the corp (Contract ID:" & argName1 & ")"
                Case 78 'Contract Collateral Deposited (corp)
                    desc = misc
                Case 79 'Contract Price Payment (corp)
                    desc = owner1 & " accepted a contract from " & owner2 & " (Contract ID: " & argName1 & ")"
                Case 80 'Contract Brokers Fee (corp)
                    desc = "Corporation Contract Brokers Fee (Contract ID: " & argName1 & ")"
                Case 81 'Contract Deposit (corp)
                    desc = "Corporation Contract Deposit (Contract ID: " & argName1 & ")"
                Case 82 'Contract Deposit Refund
                    desc = "Contract Deposit Refund (Contract ID: " & argName1 & ")"
                Case 83 'Contract Reward Deposited
                    desc = "Contract Reward Deposited (Contract ID: " & argName1 & ")"
                Case 84 'Contract Reward Deposited (corp)
                    desc = "Contract Reward Deposited (Contract ID: " & argName1 & ")"
                Case 85 ' Bounty owner1=concord
                    desc = owner2 & " Got bounty prizes for killing pirates in " & argName1
                Case 86 'Advertisement Listing Fee
                    desc = "Corporate Advert Fee (authorised by " & argName1 & ")"
                Case 87 ' Medal Creation Fee
                    desc = "Medal Creation Fee (authorised by " & argName1 & ")"
                Case 88 ' Medal Issue Fee
                    desc = "Medal Issue Fee (authorised by " & argName1 & ")"
                Case 89 ' Betting Fee
                    desc = misc
                Case 90 ' DNA Modification Fee
                    desc = misc
                Case 91 ' Sovereignty Bill
                    desc = misc
                Case 92 ' Bounty Prize Corporation Tax
                    desc = "Bounty Prize Corporation Tax"
                Case 93 ' Agent Mission Reward Corporation Tax
                    desc = "Agent Mission Reward Corporation Tax"
                Case 94 ' Agent Mission Time Bonus Reward Corporation Tax
                    desc = "Agent Mission Time Bonus Reward Corporation Tax"
                Case 95 ' Upkeep Adjustment Fee
                    desc = misc
                Case 96 ' Planetary Import Tax
                    desc = "Planetary Import Tax at " & argName1
                Case 97 ' Planetray Export Tax
                    desc = "Planetary Export Tax at " & argName1
                Case 98 ' Planetary Construction Fee
                    desc = "Planetary Construction Fee at " & argName1
                Case 99 ' Corporate Reward Payout
                    desc = misc
                Case 100 ' Minigame Betting Fee
                    desc = misc
                Case 101 ' Bounty Surcharge
                    desc = misc
                Case 102 ' Contract Reversal
                    desc = misc
                Case 103 ' Corporate Reward Tax
                    desc = misc
                Case 104 ' Minigame Buy-in Fee
                    desc = misc
                Case 105 ' Office Upgrade Fee
                    desc = misc
                Case 106 ' Store Purchase
                    desc = misc
                Case 107 ' Store Purchase Refund
                    desc = misc
                Case 108 ' PLEX sold for Aurum
                    desc = misc
            End Select
            Return desc
        End Function

        Private Sub UpdateWalletJournalDivisions()

            If cboJournalOwners.Text <> "" Then
                Dim pOwner As PrismOwner

                If PlugInData.PrismOwners.ContainsKey(cboJournalOwners.Text) = True Then

                    cboWalletJournalDivision.BeginUpdate()
                    cboWalletJournalDivision.Items.Clear()

                    pOwner = PlugInData.PrismOwners(cboJournalOwners.Text)
                    Dim ownerAccount As EveHQAccount = PlugInData.GetAccountForCorpOwner(pOwner, CorpRepType.CorpSheet)

                    If ownerAccount IsNot Nothing Then
                        If pOwner.IsCorp = True Then
                            Dim corpSheet = HQ.ApiProvider.Corporation.CorporationSheet(ownerAccount.UserID, ownerAccount.APIKey)

                            If corpSheet.IsSuccess Then
                                ' No errors so parse the files
                                For Each div In corpSheet.ResultData.WalletDivisions
                                    cboWalletJournalDivision.Items.Add(div.Description)
                                Next
                            Else
                                For div As Integer = 1000 To 1006
                                    cboWalletJournalDivision.Items.Add(div.ToString.Trim)
                                Next
                            End If
                        Else
                            cboWalletJournalDivision.Items.Add("1000")
                        End If
                    Else
                        If pOwner.IsCorp Then
                            For div As Integer = 1000 To 1006
                                cboWalletJournalDivision.Items.Add(div.ToString.Trim)
                            Next
                        Else
                            cboWalletJournalDivision.Items.Add("1000")
                        End If
                    End If
                    cboWalletJournalDivision.Enabled = True
                    cboWalletJournalDivision.EndUpdate()
                    cboWalletJournalDivision.SelectedIndex = 0
                Else
                    cboWalletJournalDivision.Items.Add("1000")
                    cboWalletJournalDivision.EndUpdate()
                    cboWalletJournalDivision.SelectedIndex = 0
                    cboWalletJournalDivision.Enabled = False
                End If

            End If

        End Sub

        Private Sub DisplayWalletJournalEntries()

            ' Fetch the appropriate data
            Dim walletData As DataSet = FetchWalletJournalData()

            adtJournal.BeginUpdate()
            adtJournal.Nodes.Clear()
            If walletData IsNot Nothing Then
                If walletData.Tables(0).Rows.Count > 0 Then
                    Dim transItem As Node
                    Dim transDate As Date
                    Dim transA, transB As Double
                    Dim refType As String
                    Dim runningBalance As Double = 0
                    For Each je As DataRow In walletData.Tables(0).Rows
                        transItem = New Node
                        transDate = DateTime.Parse(je.Item("transDate").ToString)
                        transItem.Text = transDate.ToString
                        refType = je.Item("refTypeID").ToString
                        transItem.Cells.Add(New Cell(PlugInData.RefTypes(refType)))
                        transA = Double.Parse(je.Item("amount").ToString)
                        transB = Double.Parse(je.Item("balance").ToString)
                        runningBalance += transA

                        If transA < 0 Then
                            transItem.Cells.Add(New Cell(transA.ToString("N2"), _styleRedRight))
                        Else
                            transItem.Cells.Add(New Cell(transA.ToString("N2"), _styleGreenRight))

                        End If

                        If sbShowEveBalance.Value = True Then
                            transItem.Cells.Add(New Cell(transB.ToString("N2"), _styleRight))
                        Else
                            transItem.Cells.Add(New Cell(runningBalance.ToString("N2"), _styleRight))
                        End If

                        If je.Item("reason").ToString <> "" Then
                            transItem.Cells.Add(New Cell("[r] " & BuildJournalDescription(CInt(refType), je.Item("ownerName1").ToString, je.Item("ownerName2").ToString, je.Item("argID1").ToString, je.Item("argName1").ToString)))
                            Dim transReason As New Node
                            transReason.Cells.Add(New Cell) : transReason.Cells.Add(New Cell) : transReason.Cells.Add(New Cell)
                            transReason.Cells.Add(New Cell(je.Item("reason").ToString))
                            transItem.Nodes.Add(transReason)
                        Else
                            If IsDBNull(je.Item("typeID")) = False Then
                                ' Put some market data here
                                Dim typeId As Integer = CInt(je.Item("typeID"))
                                If (StaticData.Types.ContainsKey(typeId)) Then
                                    Dim item As EveType = StaticData.Types(typeId)
                                    transItem.Cells.Add(New Cell("[t] " & BuildJournalDescription(CInt(refType), je.Item("ownerName1").ToString, je.Item("ownerName2").ToString, je.Item("argID1").ToString, je.Item("argName1").ToString)))
                                    Dim transReason As New Node
                                    transReason.Cells.Add(New Cell) : transReason.Cells.Add(New Cell) : transReason.Cells.Add(New Cell)
                                    transReason.Cells.Add(New Cell(item.Name & " (" & CDbl(je.Item("quantity")).ToString("N0") & " @ " & CDbl(je.Item("price")).ToString("N2") & " isk p/u)"))
                                    transItem.Nodes.Add(transReason)
                                Else
                                    Trace.TraceWarning("Display Wallet Journal tried to find information on an unknown item type id: " & typeId)
                                End If

                            Else
                                transItem.Cells.Add(New Cell(BuildJournalDescription(CInt(refType), je.Item("ownerName1").ToString, je.Item("ownerName2").ToString, je.Item("argID1").ToString, je.Item("argName1").ToString)))
                            End If
                        End If

                        adtJournal.Nodes.Add(transItem)
                    Next
                    adtJournal.Enabled = True
                Else
                    adtJournal.Nodes.Add(New Node("No Data Available..."))
                    adtJournal.Enabled = False
                End If
            Else
                adtJournal.Nodes.Add(New Node("No Data Available..."))
                adtJournal.Enabled = False
            End If
            'EveHQ.Core.AdvTreeSorter.Sort(adtJournal, New EveHQ.Core.AdvTreeSortResult(1, Core.AdvTreeSortOrder.Descending), False)
            adtJournal.EndUpdate()
        End Sub

        Private Function FetchWalletJournalData() As DataSet
            Dim walletId As String = (1000 + cboWalletJournalDivision.SelectedIndex).ToString
            Dim strSql As String = "SELECT * FROM walletJournal"
            strSql &= " LEFT JOIN walletTransactions ON walletJournal.argName1 = walletTransactions.transRef"
            strSql &= " WHERE (walletJournal.walletID = " & walletId & ")"
            strSql &= " AND walletJournal.transDate >= '" & dtiJournalStartDate.Value.ToString(PrismTimeFormat, _culture) & "' AND walletJournal.transDate <= '" & dtiJournalEndDate.Value.ToString(PrismTimeFormat, _culture) & "'"

            ' Build the Owners List
            If cboJournalOwners.Text <> "<All>" Then
                Dim ownerList As New StringBuilder
                For Each lvi As ListViewItem In CType(cboJournalOwners.DropDownControl, PrismSelectionControl).lvwItems.CheckedItems
                    ownerList.Append(", '" & lvi.Name.Replace("'", "''") & "'")
                Next
                If ownerList.Length > 2 Then
                    ownerList.Remove(0, 2)
                End If
                ' Default to None
                strSql &= " AND walletJournal.charName IN (" & ownerList.ToString & ")"
            End If

            ' Build the refTypes List
            If cboJournalRefTypes.Text <> "All" Then
                ' Build a ref type list
                Dim refTypeList As New StringBuilder
                For Each lvi As ListViewItem In CType(cboJournalRefTypes.DropDownControl, PrismSelectionControl).lvwItems.CheckedItems
                    refTypeList.Append(", " & lvi.Name)
                Next
                If refTypeList.Length > 2 Then
                    refTypeList.Remove(0, 2)
                    ' Default to All
                    strSql &= " AND walletJournal.refTypeID IN (" & refTypeList.ToString & ")"
                End If
            End If

            ' Order the data
            strSql &= " ORDER BY walletJournal.transKey DESC;"

            ' Fetch the data
            Dim walletData As DataSet = CustomDataFunctions.GetCustomData(strSql)

            Return walletData

        End Function

        Private Function FetchWalletJournalDataForExport() As DataSet
            Dim walletId As String = (1000 + cboWalletJournalDivision.SelectedIndex).ToString
            Dim strSql As String = "SELECT * FROM walletJournal"
            strSql &= " WHERE (walletJournal.walletID = " & walletId & ")"
            strSql &= " AND walletJournal.transDate >= '" & dtiJournalStartDate.Value.ToString(PrismTimeFormat, _culture) & "' AND walletJournal.transDate <= '" & dtiJournalEndDate.Value.ToString(PrismTimeFormat, _culture) & "'"

            ' Build the Owners List
            If cboJournalOwners.Text <> "<All>" Then
                Dim ownerList As New StringBuilder
                For Each lvi As ListViewItem In CType(cboJournalOwners.DropDownControl, PrismSelectionControl).lvwItems.CheckedItems
                    ownerList.Append(", '" & lvi.Name.Replace("'", "''") & "'")
                Next
                If ownerList.Length > 2 Then
                    ownerList.Remove(0, 2)
                End If
                ' Default to None
                strSql &= " AND walletJournal.charName IN (" & ownerList.ToString & ")"
            End If

            '' Build the refTypes List
            'If cboJournalRefTypes.Text <> "All" Then
            '    ' Build a ref type list
            '    Dim RefTypeList As New StringBuilder
            '    For Each LVI As ListViewItem In CType(cboJournalRefTypes.DropDownControl, PrismSelectionControl).lvwItems.CheckedItems
            '        RefTypeList.Append(", " & LVI.Name)
            '    Next
            '    If RefTypeList.Length > 2 Then
            '        RefTypeList.Remove(0, 2)
            '        ' Default to All
            '        strSQL &= " AND walletJournal.refTypeID IN (" & RefTypeList.ToString & ")"
            '    End If
            'End If

            ' Order the data
            strSql &= " ORDER BY walletJournal.transKey DESC;"

            ' Fetch the data
            Dim walletData As DataSet = CustomDataFunctions.GetCustomData(strSql)

            Return walletData

        End Function

        Private Sub btnJournalQuery_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnJournalQuery.Click
            Call DisplayWalletJournalEntries()
        End Sub

        Private Sub sbShowEveBalance_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles sbShowEveBalance.ValueChanged
            If cboWalletJournalDivision.SelectedItem IsNot Nothing Then
                Call DisplayWalletJournalEntries()
            End If
        End Sub

        Private Sub dtiJournalStartDate_ButtonCustom2Click(ByVal sender As Object, ByVal e As EventArgs) Handles dtiJournalStartDate.ButtonCustom2Click
            dtiJournalStartDate.Value = New Date(dtiJournalStartDate.Value.Year, dtiJournalStartDate.Value.Month, dtiJournalStartDate.Value.Day)
        End Sub

        Private Sub dtiJournalStartDate_ButtonCustomClick(ByVal sender As Object, ByVal e As EventArgs) Handles dtiJournalStartDate.ButtonCustomClick
            dtiJournalStartDate.Value = SkillFunctions.ConvertLocalTimeToEve(Now)
        End Sub

        Private Sub dtiJournalEndDate_ButtonCustom2Click(ByVal sender As Object, ByVal e As EventArgs) Handles dtiJournalEndDate.ButtonCustom2Click
            dtiJournalEndDate.Value = New Date(dtiJournalEndDate.Value.Year, dtiJournalEndDate.Value.Month, dtiJournalEndDate.Value.Day)
        End Sub

        Private Sub dtiJournalEndDate_ButtonCustomClick(ByVal sender As Object, ByVal e As EventArgs) Handles dtiJournalEndDate.ButtonCustomClick
            dtiJournalEndDate.Value = SkillFunctions.ConvertLocalTimeToEve(Now)
        End Sub

        Private Sub btnResetJournal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnResetJournal.Click
            Dim reply As DialogResult = MessageBox.Show("Are you really sure you want to delete all the journal entries from the database?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If reply = DialogResult.Yes Then
                Dim strSql As String = "DELETE * FROM walletJournal;"
                If CustomDataFunctions.SetCustomData(strSql) <> -2 Then
                    MessageBox.Show("Reset Complete")
                End If
                strSql = "DROP TABLE walletJournal;"
                If CustomDataFunctions.SetCustomData(strSql) <> -2 Then
                    MessageBox.Show("Table Deletion Complete")
                End If
                Call PrismDataFunctions.CheckDatabaseTables()
            End If
        End Sub

        Private Sub btnCheckJournalOmissions_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCheckJournalOmissions.Click
            Using checkJournals As New FrmJournalCheck
                checkJournals.ShowDialog()
            End Using
        End Sub

        Private Sub btnExportEntries_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportEntries.Click

            ' Check for multiple owners - can't do this!

            If CType(cboJournalOwners.DropDownControl, PrismSelectionControl).lvwItems.CheckedItems.Count <> 1 Then
                MessageBox.Show("You can only export data for a single owner at a time. Please adjust the Journal Owners accordingly.", "Wallet Journal Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                Dim sfd As New SaveFileDialog
                sfd.Title = "Export Wallet Journal Entries"
                sfd.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                Const FilterText As String = "XML files (*.xml)|*.xml"
                sfd.Filter = FilterText
                sfd.FilterIndex = 0
                sfd.AddExtension = True
                sfd.ShowDialog()
                sfd.CheckPathExists = True
                If sfd.FileName <> "" Then

                    ' Fetch the appropriate data
                    Dim walletData As DataSet = FetchWalletJournalDataForExport()

                    Dim xmlDoc As New XmlDocument
                    Dim dec As XmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", Nothing, Nothing)
                    xmlDoc.AppendChild(dec)

                    ' Create XML root
                    Dim xmlRoot As XmlElement = xmlDoc.CreateElement("EveHQWalletJournalExport")
                    xmlDoc.AppendChild(xmlRoot)

                    ' Create heading for future reference & import
                    Dim headerRow As XmlElement = xmlDoc.CreateElement("exportedData")
                    Dim headerAtt As XmlAttribute = xmlDoc.CreateAttribute("ownerName")
                    headerAtt.Value = HttpUtility.HtmlEncode(cboJournalOwners.Text)
                    headerRow.Attributes.Append(headerAtt)
                    headerAtt = xmlDoc.CreateAttribute("walletID")
                    headerAtt.Value = HttpUtility.HtmlEncode((1000 + cboWalletJournalDivision.SelectedIndex).ToString)
                    headerRow.Attributes.Append(headerAtt)
                    headerAtt = xmlDoc.CreateAttribute("startDate")
                    headerAtt.Value = HttpUtility.HtmlEncode(dtiJournalStartDate.Value.ToString(PrismTimeFormat, _culture))
                    headerRow.Attributes.Append(headerAtt)
                    headerAtt = xmlDoc.CreateAttribute("endDate")
                    headerAtt.Value = HttpUtility.HtmlEncode(dtiJournalEndDate.Value.ToString(PrismTimeFormat, _culture))
                    headerRow.Attributes.Append(headerAtt)
                    ' Add the header row
                    xmlRoot.AppendChild(headerRow)

                    ' Create main XML data
                    For Each row As DataRow In walletData.Tables(0).Rows
                        Dim xmlRow As XmlElement = xmlDoc.CreateElement("row")
                        For Each col As DataColumn In walletData.Tables(0).Columns
                            Dim xmlAtt As XmlAttribute = xmlDoc.CreateAttribute(col.ColumnName)
                            If col.DataType() Is GetType(Double) Then
                                xmlAtt.Value = HttpUtility.HtmlEncode(CDbl(row.Item(col)).ToString(_culture))
                            Else
                                If col.DataType() Is GetType(DateTime) Then
                                    xmlAtt.Value = HttpUtility.HtmlEncode(CDate(row.Item(col)).ToString(PrismTimeFormat, _culture))
                                Else
                                    xmlAtt.Value = HttpUtility.HtmlEncode(row.Item(col).ToString)
                                End If
                            End If
                            xmlRow.Attributes.Append(xmlAtt)
                        Next
                        xmlRoot.AppendChild(xmlRow)
                    Next

                    ' Save the XML file
                    xmlDoc.Save(sfd.FileName)

                End If

                sfd.Dispose()

                MessageBox.Show("Export of Wallet Journal Data completed!", "Wallet Journal Export", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End Sub

        Private Sub btnImportEntries_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportEntries.Click

            ' Step 1: Ask for a filename
            Dim ofd As New OpenFileDialog
            ofd.Title = "Import Wallet Journal Entries"
            ofd.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            Const FilterText As String = "XML files (*.xml)|*.xml"
            ofd.Filter = FilterText
            ofd.FilterIndex = 0
            ofd.AddExtension = True
            ofd.CheckPathExists = True
            ofd.ShowDialog()

            ' Step 2: Check the file exists and is of the right format
            Dim xmlDoc As New XmlDocument
            Dim ownerId As String
            Dim ownerName As String
            Dim walletId As Integer
            Dim startDate As Date
            Dim endDate As Date

            If ofd.FileName <> "" Then
                ' Check existence
                If My.Computer.FileSystem.FileExists(ofd.FileName) = True Then
                    ' Load the file into an XML document
                    Try
                        xmlDoc.Load(ofd.FileName)
                        ' Assume in XML format so check for some key information, starting with the root node
                        Dim rootNodes As XmlNodeList = xmlDoc.GetElementsByTagName("EveHQWalletJournalExport")
                        If rootNodes.Count = 1 Then
                            ' Check for the exportedData node
                            Dim configNodes As XmlNodeList = xmlDoc.GetElementsByTagName("exportedData")
                            If configNodes.Count = 1 Then
                                ' Check the node attributes
                                Dim configNode As XmlNode = configNodes(0)
                                If configNode.Attributes.Count = 5 Then
                                    Try
                                        ownerId = configNode.Attributes.GetNamedItem("ownerID").Value
                                        ownerName = configNode.Attributes.GetNamedItem("ownerName").Value
                                        walletId = CInt(configNode.Attributes.GetNamedItem("walletID").Value)
                                        startDate = DateTime.ParseExact(configNode.Attributes.GetNamedItem("startDate").Value, PrismTimeFormat, _culture)
                                        endDate = DateTime.ParseExact(configNode.Attributes.GetNamedItem("endDate").Value, PrismTimeFormat, _culture)
                                        If ownerId = "" Then
                                            MessageBox.Show("The import configuration data for OwnerID cannot be blank. Please check the file is in the correct XML format.", "Import Wallet Journal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            Exit Sub
                                        End If
                                        If ownerName = "" Then
                                            MessageBox.Show("The import configuration data for OwnerName cannot be blank. Please check the file is in the correct XML format.", "Import Wallet Journal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            Exit Sub
                                        End If
                                        If walletId < 1000 Or walletId > 1006 Then
                                            MessageBox.Show("The import configuration data for WalletID must be between 1000 and 1006 inclusive. Please check the file is in the correct XML format.", "Import Wallet Journal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            Exit Sub
                                        End If
                                        ' Seems to be right at this point!
                                    Catch ex As Exception
                                        MessageBox.Show("The import configuration data could not be imported correctly. Please check the file is in the correct XML format.", "Import Wallet Journal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        Exit Sub
                                    End Try
                                Else
                                    MessageBox.Show("The configuration node contains the incorrect number of attributes. Please check the file is in the correct XML format.", "Import Wallet Journal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Exit Sub
                                End If
                            Else
                                MessageBox.Show("The XML file contains invalid configuration nodes. Please check the file is in the correct XML format.", "Import Wallet Journal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("The XML file contains invalid root nodes. Please check the file is in the correct XML format.", "Import Wallet Journal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show("There was an error loading the XML file. Please check the file is in XML format.", "Import Wallet Journal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End Try
                Else
                    MessageBox.Show("Cannot find the selected file. Please try again.", "Import Wallet Journal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Else
                MessageBox.Show("Import cancelled by user.", "Import Wallet Journal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ' Step 3: Ask for confirmation (because it potentially involves deleting stuff)
            Dim msg As New StringBuilder
            msg.AppendLine("This procedure will first delete all wallet transactions in WalletID " & walletId.ToString & " for " & ownerName & " between the dates of " & startDate.ToString(PrismTimeFormat) & " and " & endDate.ToString(PrismTimeFormat) & ".")
            msg.AppendLine("")
            msg.AppendLine("Are you sure you wish to proceed?")
            Dim reply As DialogResult = MessageBox.Show(msg.ToString, "Confirm Wallet Import", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If reply = DialogResult.No Then
                Exit Sub
            End If

            ' Step 4: Delete existing transactions
            Dim strSql As String = "DELETE FROM walletJournal"
            strSql &= " WHERE (walletJournal.walletID = " & walletId & ")"
            strSql &= " AND walletJournal.transDate >= '" & startDate.ToString(PrismTimeFormat, _culture) & "' AND walletJournal.transDate < '" & endDate.ToString(PrismTimeFormat, _culture) & "'"
            strSql &= " AND walletJournal.charName IN ('" & ownerName.Replace("'", "''") & "')"
            Try
                CustomDataFunctions.SetCustomData(strSql)
            Catch ex As Exception
                MessageBox.Show("There was an error removing existing transactions. The error was: " & ex.Message, "Import Wallet Journal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End Try

            ' Step 5: Import new transactions
            Dim walletJournals As New SortedList(Of String, WalletJournalItem)
            PrismDataFunctions.ParseWalletJournalExportXML(xmlDoc, walletJournals, ownerId)
            PrismDataFunctions.WriteWalletJournalsToDB(walletJournals, CInt(ownerId), ownerName, walletId, 0)

            ' Step 6: Tidy up
            ofd.Dispose()

            MessageBox.Show("Import of Wallet Journal Data completed!", "Import Wallet Journal", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Sub

        Private Sub adtJournal_ColumnHeaderMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles adtJournal.ColumnHeaderMouseDown
            Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
            AdvTreeSorter.Sort(ch, False, False)
        End Sub

#End Region

#Region "Wallet Transaction Routines"

        Private Sub InitialiseTransactions()
            ' Prepare info
            dtiTransEndDate.Value = SkillFunctions.ConvertLocalTimeToEve(Now)
            dtiTransStartDate.Value = SkillFunctions.ConvertLocalTimeToEve(Now.AddMonths(-1))
            cboTransactionOwner.DropDownControl = New PrismSelectionControl(PrismSelectionType.TransactionOwnersAll, False, cboTransactionOwner)
            AddHandler CType(cboTransactionOwner.DropDownControl, PrismSelectionControl).SelectionChanged, AddressOf TransactionOwnersChanged
            cboWalletTransItem.DropDownControl = New PrismSelectionControl(PrismSelectionType.TransactionItems, True, cboWalletTransItem)
        End Sub

        Private Sub TransactionOwnersChanged()
            ' Update the wallet based on the owner (should be single owner!)
            Call UpdateWalletTransactionDivisions()
            cboWalletTransItem.DropDownControl = New PrismSelectionControl(PrismSelectionType.TransactionItems, True, cboWalletTransItem, cboTransactionOwner.Text)
        End Sub

        Private Sub DisplayWalletTransactions()

            If cboWalletTransType.SelectedIndex = -1 Then cboWalletTransType.SelectedIndex = 0

            Dim walletId As String = (1000 + cboWalletTransDivision.SelectedIndex).ToString
            Dim strSql As String = "SELECT * FROM walletTransactions"
            strSql &= " WHERE (walletTransactions.walletID = " & walletId & ")"
            strSql &= " AND walletTransactions.transDate >= '" & dtiTransStartDate.Value.ToString(PrismTimeFormat, _culture) & "' AND walletTransactions.transDate <= '" & dtiTransEndDate.Value.ToString(PrismTimeFormat, _culture) & "'"

            ' Build the Owners List
            If cboJournalOwners.Text <> "<All>" Then
                Dim ownerList As New StringBuilder
                For Each lvi As ListViewItem In CType(cboTransactionOwner.DropDownControl, PrismSelectionControl).lvwItems.CheckedItems
                    ownerList.Append(", '" & lvi.Name.Replace("'", "''") & "'")
                Next
                If ownerList.Length > 2 Then
                    ownerList.Remove(0, 2)
                End If
                ' Default to None
                strSql &= " AND walletTransactions.charName IN (" & ownerList.ToString & ")"
            End If

            ' Filter transaction type
            Select Case cboWalletTransType.SelectedIndex
                Case 0
                    ' Don't do anything as we'll pick up all transactions
                Case 1
                    ' Buy transactions only
                    strSql &= " AND walletTransactions.transType = 'buy' "
                Case 2
                    ' See transactions only
                    strSql &= " AND walletTransactions.transType = 'sell' "
            End Select

            ' Filter item type
            If cboWalletTransItem.Text <> "All" Then
                ' Build a ref type list
                Dim itemTypeList As New StringBuilder
                For Each lvi As ListViewItem In CType(cboWalletTransItem.DropDownControl, PrismSelectionControl).lvwItems.CheckedItems
                    itemTypeList.Append(", '" & lvi.Name.Replace("'", "''") & "'")
                Next
                If itemTypeList.Length > 2 Then
                    itemTypeList.Remove(0, 2)
                    strSql &= " AND walletTransactions.typeName IN (" & itemTypeList.ToString & ")"
                End If
            End If

            ' Order the data
            strSql &= " ORDER BY walletTransactions.transKey DESC;"

            ' Fetch the data
            Dim walletData As DataSet = CustomDataFunctions.GetCustomData(strSql)

            ' Determine if this is personal, or corp, or unknown if an old owner
            Dim isPersonal As Boolean = False
            Dim isCorp As Boolean = False
            ' Check for personal
            If HQ.Settings.Pilots.ContainsKey(cboTransactionOwner.Text) = True Then
                isPersonal = True
            Else
                ' Check for corp
                If PlugInData.CorpList.ContainsKey(cboTransactionOwner.Text) = True Then
                    isCorp = True
                End If
            End If

            Dim buyValue As Double = 0
            Dim sellValue As Double = 0

            adtTransactions.BeginUpdate()
            adtTransactions.Nodes.Clear()
            If walletData IsNot Nothing Then
                If walletData.Tables(0).Rows.Count > 0 Then

                    Dim transItem As Node
                    Dim transDate As Date
                    Dim price, qty, value As Double
                    For Each je As DataRow In walletData.Tables(0).Rows
                        If (je.Item("transFor").ToString = "personal" And isPersonal = True) Or isCorp = True Or (isPersonal = False And isCorp = False) Then
                            transItem = New Node
                            transDate = DateTime.Parse(je.Item("transDate").ToString)
                            transItem.Text = transDate.ToString
                            transItem.Cells.Add(New Cell(je.Item("typeName").ToString))

                            price = Double.Parse(je.Item("price").ToString)
                            qty = Double.Parse(je.Item("quantity").ToString)

                            transItem.Cells.Add(New Cell(qty.ToString("N0"), _styleRight))
                            transItem.Cells.Add(New Cell(price.ToString("N2"), _styleRight))
                            If je.Item("transType").ToString = "sell" Then
                                value = price * qty
                                transItem.Cells.Add(New Cell(value.ToString("N2"), _styleGreenRight))
                                sellValue += value
                            Else
                                value = -price * qty
                                transItem.Cells.Add(New Cell(value.ToString("N2"), _styleRedRight))
                                buyValue += -value
                            End If

                            transItem.Cells.Add(New Cell(je.Item("stationName").ToString))
                            transItem.Cells.Add(New Cell(je.Item("clientName").ToString))

                            adtTransactions.Nodes.Add(transItem)
                        End If
                    Next
                    adtTransactions.Enabled = True
                Else
                    adtTransactions.Nodes.Add(New Node("No Data Available..."))
                    adtTransactions.Enabled = False
                End If
            Else
                adtTransactions.Nodes.Add(New Node("No Data Available..."))
                adtTransactions.Enabled = False
            End If
            'EveHQ.Core.AdvTreeSorter.Sort(adtTransactions, New EveHQ.Core.AdvTreeSortResult(1, Core.AdvTreeSortOrder.Descending), False)
            adtTransactions.EndUpdate()

            ' Display Figures:
            lblTransBuyValue.Text = "Buy Value: " & buyValue.ToString("N2")
            lblTransSellValue.Text = "Sell Value: " & sellValue.ToString("N2")
            lblTransProfitValue.Text = "Profit Value: " & (sellValue - buyValue).ToString("N2")
            Dim gp As Double = 0
            Dim mu As Double = 0
            If sellValue <> 0 Then
                gp = (sellValue - buyValue) / sellValue * 100
            End If
            If buyValue <> 0 Then
                mu = (sellValue - buyValue) / buyValue * 100
            End If
            lblTransProfitRatio.Text = "Profit Ratios: GP%: " & gp.ToString("N2") & "%, MU: " & mu.ToString("N2") & "%"

        End Sub

        Private Sub UpdateWalletTransactionDivisions()

            If cboTransactionOwner.Text <> "" Then
                Dim pOwner As PrismOwner

                If PlugInData.PrismOwners.ContainsKey(cboTransactionOwner.Text) = True Then

                    cboWalletTransDivision.BeginUpdate()
                    cboWalletTransDivision.Items.Clear()

                    pOwner = PlugInData.PrismOwners(cboTransactionOwner.Text)
                    Dim ownerAccount As EveHQAccount = PlugInData.GetAccountForCorpOwner(pOwner, CorpRepType.CorpSheet)

                    If ownerAccount IsNot Nothing Then

                        If pOwner.IsCorp = True Then
                            Dim corpsheet = HQ.ApiProvider.Corporation.CorporationSheet(ownerAccount.UserID, ownerAccount.APIKey)
                            If corpsheet.IsSuccess Then
                                For Each div In corpsheet.ResultData.WalletDivisions
                                    cboWalletTransDivision.Items.Add(div.Description)
                                Next
                            Else
                                For div As Integer = 1000 To 1006
                                    cboWalletTransDivision.Items.Add(div.ToString.Trim)
                                Next
                            End If
                        Else
                            For div As Integer = 1000 To 1006
                                cboWalletTransDivision.Items.Add(div.ToString.Trim)
                            Next
                        End If
                    Else
                        If pOwner.IsCorp Then
                            For div As Integer = 1000 To 1006
                                cboWalletTransDivision.Items.Add(div.ToString.Trim)
                            Next
                        Else
                            cboWalletTransDivision.Items.Add("1000")
                        End If
                    End If
                    cboWalletTransDivision.Enabled = True
                    cboWalletTransDivision.EndUpdate()
                    If cboWalletTransDivision.Items.Count > 0 Then
                        cboWalletTransDivision.SelectedIndex = 0
                    End If
                Else
                    cboWalletTransDivision.Enabled = False
                End If

            End If
        End Sub

        Private Sub btnGetTransactions_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGetTransactions.Click
            Call DisplayWalletTransactions()
        End Sub

        Private Sub dtiTransStartDate_ButtonCustom2Click(ByVal sender As Object, ByVal e As EventArgs) Handles dtiTransStartDate.ButtonCustom2Click
            dtiTransStartDate.Value = New Date(dtiTransStartDate.Value.Year, dtiTransStartDate.Value.Month, dtiTransStartDate.Value.Day)
        End Sub

        Private Sub dtiTransStartDate_ButtonCustomClick(ByVal sender As Object, ByVal e As EventArgs) Handles dtiTransStartDate.ButtonCustomClick
            dtiTransStartDate.Value = SkillFunctions.ConvertLocalTimeToEve(Now)
        End Sub

        Private Sub dtiTransEndDate_ButtonCustom2Click(ByVal sender As Object, ByVal e As EventArgs) Handles dtiTransEndDate.ButtonCustom2Click
            dtiTransEndDate.Value = New Date(dtiTransEndDate.Value.Year, dtiTransEndDate.Value.Month, dtiTransEndDate.Value.Day)
        End Sub

        Private Sub dtiTransEndDate_ButtonCustomClick(ByVal sender As Object, ByVal e As EventArgs) Handles dtiTransEndDate.ButtonCustomClick
            dtiTransEndDate.Value = SkillFunctions.ConvertLocalTimeToEve(Now)
        End Sub

        Private Sub adtTransactions_ColumnHeaderMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles adtTransactions.ColumnHeaderMouseDown
            Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
            AdvTreeSorter.Sort(ch, False, False)
        End Sub

#End Region

#Region "Industry Jobs Routines"

        Private Sub cboJobOwner_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboJobOwner.SelectedIndexChanged
            Call DisplayIndustryJobs()
        End Sub

        Private Sub DisplayIndustryJobs()

            ' Get the owner we will use
            If cboJobOwner.SelectedItem IsNot Nothing Then
                Dim pOwner As String = cboJobOwner.SelectedItem.ToString

                adtJobs.BeginUpdate()
                adtJobs.Nodes.Clear()

                Dim jobList As List(Of Classes.IndustryJob) = Classes.IndustryJob.ParseIndustryJobs(pOwner)

                If jobList IsNot Nothing Then

                    ' Get InstallerIDs from the database and return list
                    Dim installerList As SortedList(Of Long, String) = Classes.IndustryJob.GetInstallerList(jobList)

                    ' Initialise the installer filter
                    cboInstallerFilter.Tag = True
                    Dim oldFilter As String = ""
                    If cboInstallerFilter.SelectedItem IsNot Nothing Then
                        oldFilter = cboInstallerFilter.SelectedItem.ToString
                    End If
                    cboInstallerFilter.Items.Clear()
                    cboInstallerFilter.BeginUpdate()
                    cboInstallerFilter.Items.Add("<All Installers>")
                    For Each installerName As String In installerList.Values
                        cboInstallerFilter.Items.Add(installerName)
                    Next
                    If oldFilter = "" Then
                        cboInstallerFilter.SelectedIndex = 0
                    Else
                        If cboInstallerFilter.Items.Contains(oldFilter) = True Then
                            cboInstallerFilter.SelectedItem = oldFilter
                        Else
                            cboInstallerFilter.SelectedIndex = 0
                        End If
                    End If
                    cboInstallerFilter.EndUpdate()
                    cboInstallerFilter.Tag = False

                    ' Parse the XML
                    Dim transItem As Node
                    Dim transTypeId As Integer
                    Dim displayJob As Boolean

                    For Each job As Classes.IndustryJob In jobList

                        ' Check filters to see if the job is allowed
                        displayJob = False
                        ' Check installer filter
                        If cboInstallerFilter.SelectedIndex = 0 Or (cboInstallerFilter.SelectedIndex > 0 And installerList(job.InstallerId) = cboInstallerFilter.SelectedItem.ToString) Then
                            ' Check activity filter
                            If cboActivityFilter.SelectedIndex = 0 Or job.ActivityId.ToString = cboActivityFilter.SelectedItem.ToString Then
                                ' Check status filter
                                If cboStatusFilter.SelectedIndex = 0 Then
                                    displayJob = True
                                Else
                                    Select Case job.Status
                                        Case Entities.IndustryJobStatus.Ready
                                            If job.EndDate.ToLocalTime < DateTime.Now Then
                                                ' Job finished but not delivered
                                                If cboStatusFilter.SelectedItem.ToString = PlugInData.Statuses("B") Then
                                                    displayJob = True
                                                End If
                                            Else
                                                ' Job in progress
                                                If cboStatusFilter.SelectedItem.ToString = PlugInData.Statuses("A") Then
                                                    displayJob = True
                                                End If
                                            End If
                                        Case Else
                                            If cboStatusFilter.SelectedItem.ToString = PlugInData.Statuses(job.Status.ToString) Then
                                                displayJob = True
                                            End If
                                    End Select
                                End If
                            End If
                        End If

                        ' Display the job if applicable
                        If displayJob = True Then
                            transItem = New Node
                            adtJobs.Nodes.Add(transItem)
                            transItem.CreateCells()
                            transTypeId = job.BlueprintTypeId
                            If StaticData.Types.ContainsKey(transTypeId) = True Then
                                transItem.Text = StaticData.Types(transTypeId).Name
                            Else
                                transItem.Text = "Unknown Item ID:" & transTypeId
                            End If

                            transItem.Cells(1).Text = job.ActivityId.ToString
                            transItem.Cells(2).Text = job.Runs.ToString
                            transItem.Cells(3).Text = installerList(job.InstallerId)
                            If job.FacilityId <= Integer.MaxValue AndAlso StaticData.Stations.ContainsKey(CInt(job.FacilityId)) = True Then
                                transItem.Cells(4).Text = StaticData.Stations(CInt(job.FacilityId)).StationName
                            Else
                                transItem.Cells(4).Text = "POS in " & StaticData.SolarSystems(job.SolarSystemId).Name
                            End If
                            transItem.Cells(5).Text = job.EndDate.ToLocalTime.ToString
                            transItem.Cells(5).Tag = job.EndDate.ToLocalTime
                            transItem.Cells(6).Tag = (job.EndDate.ToLocalTime - Now).TotalSeconds
                            transItem.Cells(6).Text = SkillFunctions.TimeToString(CDbl(transItem.Cells(6).Tag), False, "Complete")
                            transItem.Cells(7).Text = job.Status.ToString
                            'If job.Status = IndustryJobStatus.Ready Then
                            '    If job.EndDate.ToLocalTime < DateTime.Now Then
                            '        transItem.Cells(7).Text = PlugInData.Statuses("B")
                            '    Else
                            '        transItem.Cells(7).Text = PlugInData.Statuses("A")
                            '    End If
                            'Else
                            '    transItem.Cells(7).Text = job.Status.ToString
                            'End If
                        End If
                    Next
                End If
                If adtJobs.Nodes.Count = 0 Then
                    adtJobs.Nodes.Add(New Node("No Data Available..."))
                    adtJobs.Enabled = False
                Else
                    adtJobs.Enabled = True
                End If
                adtJobs.EndUpdate()
            Else
                If adtJobs.Nodes.Count = 0 Then
                    adtJobs.Nodes.Add(New Node("No Data Available..."))
                    adtJobs.Enabled = False
                Else
                    adtJobs.Enabled = True
                End If
                adtJobs.EndUpdate()
            End If
        End Sub

        Private Sub UpdateIndustryJobTimes()
            For Each transItem As Node In adtJobs.Nodes
                transItem.Cells(6).Tag = Int((CType(transItem.Cells(5).Tag, DateTimeOffset) - Now).TotalMinutes) * 60
                transItem.Cells(6).Text = SkillFunctions.TimeToString(CDbl(transItem.Cells(6).Tag), False, "Complete")
            Next
        End Sub

        Private Sub cboInstallerFilter_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboInstallerFilter.SelectedIndexChanged
            If CBool(cboInstallerFilter.Tag) = False Then
                ' We are not triggering a change in the selected item from the main drawing routine
                Call DisplayIndustryJobs()
            End If
        End Sub

        Private Sub cboActivityFilter_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboActivityFilter.SelectedIndexChanged
            If _startup = False Then
                ' We are not triggering a change in the selected item from the main drawing routine
                Call DisplayIndustryJobs()
            End If
        End Sub

        Private Sub cboStatusFilter_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboStatusFilter.SelectedIndexChanged
            If _startup = False Then
                ' We are not triggering a change in the selected item from the main drawing routine
                Call DisplayIndustryJobs()
            End If
        End Sub

        Private Sub adtJobs_ColumnHeaderMouseDown(sender As Object, e As MouseEventArgs) Handles adtJobs.ColumnHeaderMouseDown
            Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
            AdvTreeSorter.Sort(ch, False, False)
        End Sub

#End Region

#Region "Contracts Routines"

        Private Sub cboContractOwner_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboContractOwner.SelectedIndexChanged
            Call DisplayContracts()
        End Sub

        Private Sub DisplayContracts()

            adtContracts.BeginUpdate()
            adtContracts.Nodes.Clear()

            ' Get the owner we will use
            If cboContractOwner.SelectedItem IsNot Nothing Then
                Dim pOwner As String = cboContractOwner.SelectedItem.ToString
                Dim contractList As SortedList(Of Long, Classes.Contract) = Contracts.ParseContracts(pOwner)

                If contractList IsNot Nothing Then

                    ' Get InstallerIDs from the database and return list
                    Dim idList As SortedList(Of Long, String) = Contracts.GetContractIDList(contractList)

                    For Each c As Classes.Contract In contractList.Values
                        ' Setup filter result
                        Const DisplayContract As Boolean = True
                        ' Apply filtering...

                        ' Display the result if allowed by filters
                        If DisplayContract = True Then
                            Dim newContract As New Node
                            adtContracts.Nodes.Add(newContract)
                            newContract.CreateCells()
                            newContract.Name = c.ContractID.ToString
                            If c.Title <> "" Then
                                newContract.Text = c.Title
                            Else
                                If c.Items.Count = 1 Then
                                    newContract.Text = StaticData.Types(c.Items.Keys(0)).Name
                                Else
                                    newContract.Text = "Contract ID: " & c.ContractID.ToString
                                End If
                            End If
                            If StaticData.Stations.ContainsKey(c.StartStationID) Then
                                newContract.Cells(1).Text = StaticData.Stations(c.StartStationID).StationName
                            Else
                                newContract.Cells(1).Text = "Station ID: " & c.StartStationID.ToString
                            End If
                            If c.IsIssuer = True Then
                                newContract.Cells(2).Text = "Issued"
                            Else
                                newContract.Cells(2).Text = "Accepted"
                            End If
                            newContract.Cells(3).Text = c.Type.ToString
                            newContract.Cells(4).Text = c.Status.ToString
                            If idList.ContainsKey(c.IssuerID) Then
                                newContract.Cells(5).Text = idList(c.IssuerID)
                            Else
                                newContract.Cells(5).Text = c.IssuerID.ToString
                            End If
                            If idList.ContainsKey(c.AcceptorID) Then
                                newContract.Cells(6).Text = idList(c.AcceptorID)
                            Else
                                newContract.Cells(6).Text = c.AcceptorID.ToString
                            End If
                            newContract.Cells(7).Text = c.DateIssued.ToString
                            newContract.Cells(8).Text = c.DateExpired.ToString
                            newContract.Cells(9).Text = c.Price.ToString("N2")
                            newContract.Cells(10).Text = c.Volume.ToString("N2")

                            ' Add items
                            If c.Items.Count > 0 Then
                                Dim itemCh As New DevComponents.AdvTree.ColumnHeader("Item Name")
                                itemCh.SortingEnabled = False
                                itemCh.Width.Absolute = 300
                                itemCh.DisplayIndex = 1
                                newContract.NodesColumns.Add(itemCh)
                                Dim qtyCh As New DevComponents.AdvTree.ColumnHeader("Quantity")
                                qtyCh.SortingEnabled = False
                                qtyCh.Width.Absolute = 100
                                qtyCh.DisplayIndex = 2
                                newContract.NodesColumns.Add(qtyCh)
                                For Each typeId As Integer In c.Items.Keys
                                    Dim itemNode As New Node
                                    itemNode.Name = CStr(typeId)
                                    If StaticData.Types.ContainsKey(typeId) Then
                                        itemNode.Text = StaticData.Types(typeId).Name
                                    Else
                                        itemNode.Text = "Unknown Item: ID=" & typeId.ToString()
                                    End If
                                    itemNode.Cells.Add(New Cell(c.Items(typeId).ToString))
                                    newContract.Nodes.Add(itemNode)
                                Next
                            End If
                        End If

                    Next
                End If

                ' Check if there are any nodes
                If adtContracts.Nodes.Count = 0 Then
                    adtContracts.Nodes.Add(New Node("No Contract Data Available..."))
                    adtContracts.Enabled = False
                Else
                    adtContracts.Enabled = True
                End If

            Else

                If adtContracts.Nodes.Count = 0 Then
                    adtContracts.Nodes.Add(New Node("No Contract Data Available..."))
                    adtContracts.Enabled = False
                Else
                    adtContracts.Enabled = True
                End If

            End If

            AdvTreeSorter.Sort(adtContracts, 1, True, False)
            adtContracts.EndUpdate()

        End Sub

        Private Sub adtContracts_ColumnHeaderMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles adtContracts.ColumnHeaderMouseDown
            Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
            AdvTreeSorter.Sort(ch, False, False)
        End Sub

#End Region

#Region "Recycler Routines"

        Public Sub RecycleInfoFromAssets()
            ' Fetch the recycling info from the assets control
            _recyclerAssetList = PAC.RecyclingAssetList
            _recyclerAssetOwner = cboRecyclePilots.SelectedItem.ToString
            _recyclerAssetLocation = GetLocationID(PAC.RecyclingAssetLocation)
            Call LoadRecyclingInfo()
            tabPrism.SelectedTab = tiRecycler
            tiRecycler.Visible = True
        End Sub
        Private Function GetLocationID(ByVal item As Node) As Integer
            Do While item.Level > 0
                item = item.Parent
            Loop
            If item.Tag IsNot Nothing Then
                Return CInt(item.Tag)
            Else
                Return 0
            End If
        End Function
        Private Sub LoadRecyclingInfo()

            ' Load the characters into the combobox
            cboRecyclePilots.Items.Clear()
            For Each cPilot As EveHQPilot In HQ.Settings.Pilots.Values
                If cPilot.Active = True Then
                    cboRecyclePilots.Items.Add(cPilot.Name)
                End If
            Next

            ' Get the location details
            If StaticData.Stations.ContainsKey(_recyclerAssetLocation) = True Then
                If CDbl(_recyclerAssetLocation) >= 60000000 Then ' Is a station
                    Dim aLocation As Station = StaticData.Stations(_recyclerAssetLocation)
                    lblStation.Text = aLocation.StationName
                    lblCorp.Text = aLocation.CorpId.ToString
                    If StaticData.NpcCorps.ContainsKey(aLocation.CorpId) = True Then
                        lblCorp.Text = CStr(StaticData.NpcCorps(aLocation.CorpId))
                        lblCorp.Tag = aLocation.CorpId.ToString
                        _stationYield = aLocation.RefiningEfficiency
                        lblBaseYield.Text = (_stationYield * 100).ToString("N2")
                    Else
                        If PlugInData.Corps.ContainsKey(aLocation.CorpId.ToString) = True Then
                            lblCorp.Text = CStr(PlugInData.Corps(aLocation.CorpId.ToString))
                            lblBaseYield.Text = (aLocation.RefiningEfficiency * 100).ToString("N2")
                        Else
                            lblCorp.Text = "Unknown"
                            lblCorp.Tag = Nothing
                            lblBaseYield.Text = CDbl(50).ToString("N2")
                        End If
                    End If
                Else ' Is a system
                    lblStation.Text = "n/a"
                    lblCorp.Text = "n/a"
                    lblCorp.Tag = Nothing
                    lblBaseYield.Text = CDbl(50).ToString("N2")
                End If
            Else
                lblStation.Text = "n/a"
                lblCorp.Text = "n/a"
                lblCorp.Tag = Nothing
                lblBaseYield.Text = CDbl(50).ToString("N2")
            End If

            ' Set the pilot to the recycling one
            If cboRecyclePilots.Items.Contains(_recyclerAssetOwner) Then
                cboRecyclePilots.SelectedItem = _recyclerAssetOwner
            Else

                If cboRecyclePilots.Items.Count > 0 Then
                    cboRecyclePilots.SelectedIndex = 0
                End If
            End If

            ' Set the recycling mode
            cboRefineMode.SelectedIndex = 0
        End Sub
        Private Sub RecalcRecycling()
            ' Create the main list
            adtRecycle.BeginUpdate()
            adtRecycle.Nodes.Clear()
            Dim price As Double
            Dim perfect As Long
            Dim quantity As Long
            Dim quant As Long
            Dim wastage As Long
            Dim taken As Long
            Dim value As Double
            Dim fees As Double
            Dim sale As Double
            Dim recycleTotal As Double
            Dim newClvItem As Node
            Dim newClvSubItem As Node
            Dim itemInfo As EveType
            Dim batches As Integer
            Dim items As Long = 0
            Dim volume As Double = 0
            Dim benefit As Double
            Dim itemYield As Double
            Dim bestPriceTotal As Double = 0
            Dim salePriceTotal As Double = 0
            Dim refinePriceTotal As Double = 0
            Dim recycleResults As New SortedList(Of Integer, Long)
            Dim recycleWaste As New SortedList
            Dim recycleTake As New SortedList
            Dim rPilot As EveHQPilot = HQ.Settings.Pilots(cboRecyclePilots.SelectedItem.ToString)
            Dim priceTask As Task(Of Dictionary(Of Integer, Double)) = DataFunctions.GetMarketPrices(From a In _recyclerAssetList.Keys Select a)
            priceTask.Wait()
            Dim prices As Dictionary(Of Integer, Double) = priceTask.Result
            For Each asset As Integer In _recyclerAssetList.Keys
                itemInfo = StaticData.Types(asset)
                If itemInfo.Category = 25 Then
                    itemYield = _baseYield * (1 + (CDbl(rPilot.KeySkills(KeySkill.Refining)) * 0.03)) * (1 + (CDbl(rPilot.KeySkills(KeySkill.RefiningEfficiency)) * 0.02))
                    Select Case itemInfo.Group
                        Case 465 ' Ice
                            itemYield *= (1 + (0.02 * CDbl(rPilot.KeySkills(KeySkill.IceProc))))
                        Case 450 ' Arkonor
                            itemYield *= (1 + (0.02 * CDbl(rPilot.KeySkills(KeySkill.ArkonorProc))))
                        Case 451 ' Bistot
                            itemYield *= (1 + (0.02 * CDbl(rPilot.KeySkills(KeySkill.BistotProc))))
                        Case 452 ' Crokite
                            itemYield *= (1 + (0.02 * CDbl(rPilot.KeySkills(KeySkill.CrokiteProc))))
                        Case 453 ' Dark Ochre
                            itemYield *= (1 + (0.02 * CDbl(rPilot.KeySkills(KeySkill.DarkOchreProc))))
                        Case 467 ' Gneiss
                            itemYield *= (1 + (0.02 * CDbl(rPilot.KeySkills(KeySkill.GneissProc))))
                        Case 454 ' Hedbergite
                            itemYield *= (1 + (0.02 * CDbl(rPilot.KeySkills(KeySkill.HedbergiteProc))))
                        Case 455 ' Hemorphite
                            itemYield *= (1 + (0.02 * CDbl(rPilot.KeySkills(KeySkill.HemorphiteProc))))
                        Case 456 ' Jaspet
                            itemYield *= (1 + (0.02 * CDbl(rPilot.KeySkills(KeySkill.JaspetProc))))
                        Case 457 ' Kernite
                            itemYield *= (1 + (0.02 * CDbl(rPilot.KeySkills(KeySkill.KerniteProc))))
                        Case 468 ' Mercoxit
                            itemYield *= (1 + (0.02 * CDbl(rPilot.KeySkills(KeySkill.MercoxitProc))))
                        Case 469 ' Omber
                            itemYield *= (1 + (0.02 * CDbl(rPilot.KeySkills(KeySkill.OmberProc))))
                        Case 458 ' Plagioclase
                            itemYield *= (1 + (0.02 * CDbl(rPilot.KeySkills(KeySkill.PlagioclaseProc))))
                        Case 459 ' Pyroxeres
                            itemYield *= (1 + (0.02 * CDbl(rPilot.KeySkills(KeySkill.PyroxeresProc))))
                        Case 460 ' Scordite
                            itemYield *= (1 + (0.02 * CDbl(rPilot.KeySkills(KeySkill.ScorditeProc))))
                        Case 461 ' Spodumain
                            itemYield *= (1 + (0.02 * CDbl(rPilot.KeySkills(KeySkill.SpodumainProc))))
                        Case 462 ' Veldspar
                            itemYield *= (1 + (0.02 * CDbl(rPilot.KeySkills(KeySkill.VeldsparProc))))
                    End Select
                Else
                    itemYield = _baseYield * (1 + (0.02 * CDbl(rPilot.KeySkills(KeySkill.ScrapMetalProc))))
                End If
                itemYield = Math.Min(itemYield, 1)
                _matList.Clear()
                If StaticData.TypeMaterials.ContainsKey(asset) Then
                    For Each mat As Integer In StaticData.TypeMaterials(asset).Materials.Keys
                        _matList.Add(mat, StaticData.TypeMaterials(asset).Materials(mat))
                    Next
                End If
                newClvItem = New Node
                adtRecycle.Nodes.Add(newClvItem)
                newClvItem.CreateCells()
                newClvItem.Text = itemInfo.Name
                newClvItem.Tag = itemInfo.Id
                price = Math.Round(prices(asset), 2, MidpointRounding.AwayFromZero)
                batches = CInt(Int(CLng(_recyclerAssetList(itemInfo.Id)) / itemInfo.PortionSize))
                quantity = CLng(_recyclerAssetList(asset))
                volume += itemInfo.Volume * quantity
                items += CLng(quantity)
                value = price * quantity
                fees = Math.Round(value * (_rTotalFees / 100), 2, MidpointRounding.AwayFromZero)
                sale = value - fees
                newClvItem.Cells(1).Text = itemInfo.MetaLevel.ToString("N0")
                newClvItem.Cells(2).Text = quantity.ToString("N0")
                newClvItem.Cells(3).Text = batches.ToString("N0")
                newClvItem.Cells(4).Text = price.ToString("N2")
                newClvItem.Cells(5).Text = value.ToString("N2")
                If chkFeesOnItems.Checked = True Then
                    newClvItem.Cells(6).Text = fees.ToString("N2")
                    newClvItem.Cells(7).Text = sale.ToString("N2")
                Else
                    newClvItem.Cells(7).Text = value.ToString("N2")
                End If
                recycleTotal = 0
                If _matList.Count > 0 Then ' i.e. it can be refined
                    Dim matPriceTask As Task(Of Dictionary(Of Integer, Double)) = DataFunctions.GetMarketPrices(_matList.Keys)
                    matPriceTask.Wait()
                    Dim matPrices As Dictionary(Of Integer, Double) = matPriceTask.Result
                    For Each mat As Integer In _matList.Keys
                        price = Math.Round(matPrices(mat), 2, MidpointRounding.AwayFromZero)
                        perfect = CLng(_matList(mat)) * batches
                        wastage = CLng(perfect * (1 - itemYield))
                        quant = CLng(perfect * itemYield)
                        taken = CLng(quant * (_stationTake / 100))
                        quant = quant - taken
                        value = price * quant
                        fees = Math.Round(value * (_rTotalFees / 100), 2, MidpointRounding.AwayFromZero)
                        sale = value - fees
                        newClvSubItem = New Node
                        newClvItem.Nodes.Add(newClvSubItem)
                        newClvSubItem.CreateCells()
                        newClvSubItem.Text = StaticData.Types(mat).Name
                        newClvSubItem.Cells(2).Text = quant.ToString("N0")
                        newClvSubItem.Cells(3).Text = quant.ToString("N0")
                        newClvSubItem.Cells(4).Text = price.ToString("N2")
                        newClvSubItem.Cells(5).Text = value.ToString("N2")
                        If chkFeesOnRefine.Checked = True Then
                            newClvSubItem.Cells(6).Text = fees.ToString("N2")
                            newClvSubItem.Cells(8).Text = sale.ToString("N2")
                            recycleTotal += sale
                        Else
                            newClvSubItem.Cells(8).Text = newClvSubItem.Cells(5).Text
                            recycleTotal += value
                        End If
                        ' Save the perfect refining quantity
                        If recycleResults.ContainsKey(mat) = False Then
                            recycleResults.Add(mat, quant)
                        Else
                            recycleResults(mat) += quant
                        End If
                        ' Save the wasted amounts
                        If recycleWaste.Contains(mat) = False Then
                            recycleWaste.Add(mat, wastage)
                        Else
                            recycleWaste(mat) = CDbl(recycleWaste(mat)) + wastage
                        End If
                        ' Save the take amounts
                        If recycleTake.Contains(mat) = False Then
                            recycleTake.Add(mat, taken)
                        Else
                            recycleTake(mat) = CDbl(recycleTake(mat)) + taken
                        End If
                    Next
                End If
                newClvItem.Cells(8).Text = recycleTotal.ToString("N2")
                If CDbl(newClvItem.Cells(8).Text) > CDbl(newClvItem.Cells(7).Text) Then
                    newClvItem.Style = adtRecycle.Styles("ItemGood")
                    newClvItem.Cells(9).Text = newClvItem.Cells(8).Text
                Else
                    newClvItem.Cells(9).Text = newClvItem.Cells(7).Text
                End If
                benefit = CDbl(newClvItem.Cells(8).Text) - CDbl(newClvItem.Cells(7).Text)
                newClvItem.Cells(10).Tag = benefit
                newClvItem.Cells(10).Text = benefit.ToString("N2")
                newClvItem.Cells(11).Tag = (benefit / quantity)
                newClvItem.Cells(11).Text = (benefit / quantity).ToString("N2")
                salePriceTotal += CDbl(newClvItem.Cells(7).Text)
                refinePriceTotal += CDbl(newClvItem.Cells(8).Text)
                bestPriceTotal += CDbl(newClvItem.Cells(9).Text)
            Next
            lblPriceTotals.Text = "Sale / Refine / Best Totals: " & salePriceTotal.ToString("N2") & " / " & refinePriceTotal.ToString("N2") & " / " & bestPriceTotal.ToString("N2")
            AdvTreeSorter.Sort(adtRecycle, 1, True, True)
            adtRecycle.EndUpdate()
            lblVolume.Text = volume.ToString("N2") & " m³"
            lblItems.Text = adtRecycle.Nodes.Count.ToString("N0")
            lblItems.Text &= " (" & items.ToString("N0") & ")"
            ' Create the totals list
            adtTotals.BeginUpdate()
            adtTotals.Nodes.Clear()
            If recycleResults IsNot Nothing Then
                Dim matPriceTask As Task(Of Dictionary(Of Integer, Double)) = DataFunctions.GetMarketPrices(recycleResults.Keys)
                matPriceTask.Wait()
                Dim matPrices As Dictionary(Of Integer, Double) = matPriceTask.Result
                For Each mat As Integer In recycleResults.Keys
                    price = Math.Round(matPrices(mat), 2, MidpointRounding.AwayFromZero)
                    wastage = CLng(recycleWaste(mat))
                    taken = CLng(recycleTake(mat))
                    quant = CLng(recycleResults(mat))
                    newClvItem = New Node
                    adtTotals.Nodes.Add(newClvItem)
                    newClvItem.CreateCells()
                    newClvItem.Text = StaticData.Types(mat).Name
                    newClvItem.Cells(1).Text = taken.ToString("N0")
                    newClvItem.Cells(2).Text = wastage.ToString("N0")
                    newClvItem.Cells(3).Text = quant.ToString("N0")
                    newClvItem.Cells(4).Text = price.ToString("N2")
                    newClvItem.Cells(5).Text = (price * quant).ToString("N2")
                Next
            End If
            AdvTreeSorter.Sort(adtTotals, 1, True, True)
            adtTotals.EndUpdate()
        End Sub

        Private Sub cboRecyclePilots_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboRecyclePilots.SelectedIndexChanged
            Dim rPilot As EveHQPilot = HQ.Settings.Pilots(cboRecyclePilots.SelectedItem.ToString)
            lblBaseYield.Text = (_baseYield * 100).ToString("N2") & "%"
            If lblCorp.Tag IsNot Nothing Then
                _stationStanding = Standings.GetStanding(rPilot.Name, lblCorp.Tag.ToString, True)
            Else
                _stationStanding = 0
            End If
            ' Update Standings
            If chkOverrideStandings.Checked = True Then
                lblStandings.Text = nudStandings.Value.ToString("N2")
            Else
                If lblCorp.Tag Is Nothing Then
                    lblStandings.Text = CDbl(0).ToString("N2")
                Else
                    lblStandings.Text = _stationStanding.ToString("N2")
                End If
            End If
            ' Update Broker Fee
            If chkOverrideBrokerFee.Checked = False Then
                _rBrokerFee = 1 * (1 - 0.05 * (CInt(rPilot.KeySkills(KeySkill.BrokerRelations))))
            Else
                _rBrokerFee = nudBrokerFee.Value
            End If
            ' Update Trans Tax
            If chkOverrideTax.Checked = False Then
                _rTransTax = 1 * (1.5 - 0.15 * (CInt(rPilot.KeySkills(KeySkill.Accounting))))
            Else
                _rTransTax = nudTax.Value
            End If
            _rTotalFees = _rBrokerFee + _rTransTax
            lblTotalFees.Text = _rTotalFees.ToString("N2") & "%"
            Call RecalcRecycling()
        End Sub

        Private Sub chkFeesOnRefine_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkFeesOnRefine.CheckedChanged
            Call RecalcRecycling()
        End Sub

        Private Sub chkFeesOnItems_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkFeesOnItems.CheckedChanged
            Call RecalcRecycling()
        End Sub

        Private Sub adtRecycle_ColumnHeaderMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles adtRecycle.ColumnHeaderMouseDown
            Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
            AdvTreeSorter.Sort(ch, True, False)
        End Sub

        Private Sub adtRecycle_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles adtRecycle.KeyDown
            If e.Control = True And e.KeyCode = Keys.A Then
                adtRecycle.SelectedNodes.Clear()
                For Each rNode As Node In adtRecycle.Nodes
                    adtRecycle.SelectedNodes.Add(rNode)
                Next
            End If
        End Sub

        Private Sub adtTotals_ColumnHeaderMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles adtTotals.ColumnHeaderMouseDown
            Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
            AdvTreeSorter.Sort(ch, True, False)
        End Sub

#Region "Override Base Yield functions"
        Private Sub chkOverrideBaseYield_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkOverrideBaseYield.CheckedChanged
            If chkOverrideBaseYield.Checked = True Then
                _baseYield = CDbl(nudBaseYield.Value) / 100
            Else
                _baseYield = _stationYield
            End If
            If cboRecyclePilots.SelectedItem IsNot Nothing Then
                lblBaseYield.Text = (_baseYield * 100).ToString("N2") & "%"
                Call RecalcRecycling()
            End If
        End Sub

        Private Sub nudBaseYield_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nudBaseYield.ValueChanged
            If chkOverrideBaseYield.Checked = True Then
                _baseYield = CDbl(nudBaseYield.Value) / 100
                lblBaseYield.Text = (_baseYield * 100).ToString("N2") & "%"
                Call RecalcRecycling()
            End If
        End Sub
#End Region

#Region "Override Standings functions"
        Private Sub chkOverrideStandings_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkOverrideStandings.CheckedChanged
            If chkOverrideStandings.Checked = True Then
                lblStandings.Text = nudStandings.Value.ToString("N2")
            Else
                If lblCorp.Tag Is Nothing Then
                    lblStandings.Text = CDbl(0).ToString("N2")
                Else
                    lblStandings.Text = _stationStanding.ToString("N2")
                End If
            End If
            Call RecalcRecycling()
        End Sub

        Private Sub lblStandings_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lblStandings.TextChanged
            _stationTake = Math.Max(5 - (0.75 * CDbl(lblStandings.Text)), 0)
            lblStationTake.Text = _stationTake.ToString("N2") & "%"
        End Sub

        Private Sub nudStandings_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nudStandings.ValueChanged
            If chkOverrideStandings.Checked = True Then
                lblStandings.Text = nudStandings.Value.ToString("N2")
                Call RecalcRecycling()
            End If
        End Sub

#End Region

#Region "Override Fees functions"
        Private Sub chkOverrideBrokerFee_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkOverrideBrokerFee.CheckedChanged
            Dim rPilot As EveHQPilot = HQ.Settings.Pilots(cboRecyclePilots.SelectedItem.ToString)
            If chkOverrideBrokerFee.Checked = False Then
                _rBrokerFee = 1 * (1 - 0.05 * (CInt(rPilot.KeySkills(KeySkill.BrokerRelations))))
            Else
                _rBrokerFee = nudBrokerFee.Value
            End If
            _rTotalFees = _rBrokerFee + _rTransTax
            lblTotalFees.Text = _rTotalFees.ToString("N2") & "%"
            Call RecalcRecycling()
        End Sub
        Private Sub chkOverrideTax_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkOverrideTax.CheckedChanged
            Dim rPilot As EveHQPilot = HQ.Settings.Pilots(cboRecyclePilots.SelectedItem.ToString)
            If chkOverrideTax.Checked = False Then
                _rTransTax = 1 * (1.5 - 0.15 * (CInt(rPilot.KeySkills(KeySkill.Accounting))))
            Else
                _rTransTax = nudTax.Value
            End If
            _rTotalFees = _rBrokerFee + _rTransTax
            lblTotalFees.Text = _rTotalFees.ToString("N2") & "%"
            Call RecalcRecycling()
        End Sub
        Private Sub nudBrokerFee_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nudBrokerFee.ValueChanged
            If chkOverrideBrokerFee.Checked = True Then
                _rBrokerFee = nudBrokerFee.Value
                _rTotalFees = _rBrokerFee + _rTransTax
                lblTotalFees.Text = _rTotalFees.ToString("N2") & "%"
                Call RecalcRecycling()
            End If
        End Sub
        Private Sub nudTax_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nudTax.ValueChanged
            If chkOverrideTax.Checked = True Then
                _rTransTax = nudTax.Value
                _rTotalFees = _rBrokerFee + _rTransTax
                lblTotalFees.Text = _rTotalFees.ToString("N2") & "%"
                Call RecalcRecycling()
            End If
        End Sub
#End Region

#Region "Refining Mode functions"
        Private Sub cboRefineMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboRefineMode.SelectedIndexChanged

            If cboRefineMode.SelectedIndex >= 0 Then
                _baseYield = 0.5 + (0.02 * cboRefineMode.SelectedIndex)
                lblBaseYield.Text = (_baseYield * 100).ToString("N2") & "%"
                If chkOverrideStandings.Checked = True Then
                    lblStandings.Text = nudStandings.Value.ToString("N2")
                Else
                    If lblCorp.Tag Is Nothing Then
                        lblStandings.Text = CDbl(0).ToString("N2")
                    Else
                        lblStandings.Text = _stationStanding.ToString("N2")
                    End If
                End If
                chkOverrideBaseYield.Enabled = True
                chkOverrideStandings.Enabled = True
                nudBaseYield.Enabled = True
                nudStandings.Enabled = True
                cboRecyclePilots.Enabled = True
            End If

            'Select Case cboRefineMode.SelectedIndex
            '    Case 0 ' Standard
            '        If chkOverrideBaseYield.Checked = True Then
            '            _baseYield = CDbl(nudBaseYield.Value) / 100
            '        Else
            '            _baseYield = _stationYield
            '        End If
            '        lblBaseYield.Text = (_baseYield * 100).ToString("N2") & "%"
            '        lblNetYield.Text = (_netYield * 100).ToString("N2") & "%"
            '        If chkOverrideStandings.Checked = True Then
            '            lblStandings.Text = nudStandings.Value.ToString("N2")
            '        Else
            '            If lblCorp.Tag Is Nothing Then
            '                lblStandings.Text = CDbl(0).ToString("N2")
            '            Else
            '                lblStandings.Text = _stationStanding.ToString("N2")
            '            End If
            '        End If
            '        chkOverrideBaseYield.Enabled = True
            '        chkOverrideStandings.Enabled = True
            '        chkPerfectRefine.Enabled = True
            '        nudBaseYield.Enabled = True
            '        nudStandings.Enabled = True
            '        cboRecyclePilots.Enabled = True
            '    Case 1 ' Refining Array
            '        _baseYield = 0.35
            '        _netYield = 0.35
            '        lblBaseYield.Text = (_baseYield * 100).ToString("N2") & "%"
            '        lblNetYield.Text = (_netYield * 100).ToString("N2") & "%"
            '        lblStandings.Text = CDbl(10).ToString("N2")
            '        chkOverrideBaseYield.Enabled = False
            '        chkOverrideStandings.Enabled = False
            '        chkPerfectRefine.Enabled = False
            '        nudBaseYield.Enabled = False
            '        nudStandings.Enabled = False
            '        cboRecyclePilots.Enabled = False
            '    Case 2 ' Intensive Refining Array
            '        _baseYield = 0.75
            '        _netYield = 0.75
            '        lblBaseYield.Text = (_baseYield * 100).ToString("N2") & "%"
            '        lblNetYield.Text = (_netYield * 100).ToString("N2") & "%"
            '        lblStandings.Text = CDbl(10).ToString("N2")
            '        chkOverrideBaseYield.Enabled = False
            '        chkOverrideStandings.Enabled = False
            '        chkPerfectRefine.Enabled = False
            '        nudBaseYield.Enabled = False
            '        nudStandings.Enabled = False
            '        cboRecyclePilots.Enabled = False
            'End Select

            ' Set the base yield if no station
            If lblStation.Text = "n/a" Then
                chkOverrideBaseYield.Checked = True
            Else
                Call RecalcRecycling()
            End If
        End Sub
#End Region

        Private Sub mnuAlterRecycleQuantity_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuAlterRecycleQuantity.Click
            If adtRecycle.SelectedNodes.Count > 0 Then
                Using newQ As New FrmSelectQuantity(CInt(_recyclerAssetList(CInt(adtRecycle.SelectedNodes(0).Tag))))
                    newQ.ShowDialog()
                    For Each rNode As Node In adtRecycle.SelectedNodes
                        _recyclerAssetList(CInt(rNode.Tag)) = newQ.Quantity
                    Next
                End Using
                Call RecalcRecycling()
            End If
        End Sub

        Private Sub mnuRemoveRecycleItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuRemoveRecycleItem.Click
            If adtRecycle.SelectedNodes.Count > 0 Then
                For Each rNode As Node In adtRecycle.SelectedNodes
                    _recyclerAssetList.Remove(CInt(rNode.Tag))
                Next
                Call RecalcRecycling()
            End If
        End Sub

        Private Sub mnuExportToCSV_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuExportToCSV.Click
            Call ExportToClipboard("PRISM Item Recycling Analysis", adtRecycle, HQ.Settings.CsvSeparatorChar)
        End Sub

        Private Sub mnuExportToTSV_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuExportToTSV.Click
            Call ExportToClipboard("PRISM Item Recycling Analysis", adtRecycle, ControlChars.Tab)
        End Sub

        Private Sub mnuExportTotalsToCSV_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuExportTotalsToCSV.Click
            Call ExportToClipboard("PRISM Item Recycling Totals", adtTotals, HQ.Settings.CsvSeparatorChar)
        End Sub

        Private Sub mnuExportTotalsToTSV_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuExportTotalsToTSV.Click
            Call ExportToClipboard("PRISM Item Recycling Totals", adtTotals, ControlChars.Tab)
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

        Private Sub ctxRecycleItem_Opening(ByVal sender As Object, ByVal e As CancelEventArgs) Handles ctxRecycleItem.Opening
            If adtRecycle.SelectedNodes.Count > 0 Then
                If adtRecycle.SelectedNodes(0).Level = 0 Then
                    mnuAlterRecycleQuantity.Enabled = True
                    mnuRemoveRecycleItem.Enabled = True
                Else
                    e.Cancel = True
                End If
            Else
                mnuAlterRecycleQuantity.Enabled = False
                mnuRemoveRecycleItem.Enabled = False
            End If
        End Sub

        Private Sub mnuAddRecycleItem_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles mnuAddRecycleItem.Click
            Using newI As New FrmSelectItem
                newI.ShowDialog()
                Dim itemName As String = newI.Item
                If itemName IsNot Nothing Then
                    Dim itemId As Integer = StaticData.TypeNames(itemName)
                    If _recyclerAssetList.ContainsKey(itemId) = False Then
                        _recyclerAssetList.Add(itemId, 1)
                    End If
                    Call LoadRecyclingInfo()
                End If
            End Using
        End Sub

#End Region

#Region "CSV Export Routines"

        Private Sub btnExportTransactions_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportTransactions.Click
            Call GenerateCsvFileFromClv(cboTransactionOwner.Text, "Wallet Transactions", adtTransactions)
        End Sub

        Private Sub btnExportJournal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportJournal.Click
            Call GenerateCsvFileFromClv(cboJournalOwners.Text, "Wallet Journal", adtJournal)
        End Sub

        Private Sub btnExportJobs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportJobs.Click
            Call GenerateCsvFileFromClv(cboJobOwner.SelectedItem.ToString, "Industry Jobs", adtJobs)
        End Sub

        Private Sub btnExportOrders_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportOrders.Click
            Call GenerateCsvFileFromClv(cboOrdersOwner.SelectedItem.ToString, "Sell Orders", adtSellOrders)
            Call GenerateCsvFileFromClv(cboOrdersOwner.SelectedItem.ToString, "Buy Orders", adtBuyOrders)
        End Sub

        Private Sub GenerateCsvFileFromClv(ByVal ownerName As String, ByVal description As String, ByVal cAdvTree As AdvTree)

            Try
                _csvFile = Path.Combine(HQ.ReportFolder, description.Replace(" ", "") & " - " & ownerName & " (" & Format(Now, "yyyy-MM-dd HH-mm-ss") & ").csv")
                Dim csvText As New StringBuilder
                With cAdvTree
                    ' Write the columns
                    For col As Integer = 0 To .Columns.Count - 1
                        csvText.Append(.Columns(col).Text)
                        If col <> .Columns.Count - 1 Then
                            csvText.Append(HQ.Settings.CsvSeparatorChar)
                        End If
                    Next
                    csvText.AppendLine("")
                    ' Write the data
                    For Each row As Node In .Nodes
                        For col As Integer = 0 To .Columns.Count - 1
                            If IsNumeric(row.Cells(col).Text) = True Then
                                csvText.Append(CDbl(row.Cells(col).Text).ToString)
                            Else
                                csvText.Append("""" & row.Cells(col).Text & """")
                            End If
                            If col <> .Columns.Count - 1 Then
                                csvText.Append(HQ.Settings.CsvSeparatorChar)
                            End If
                        Next
                        csvText.AppendLine("")
                    Next
                End With
                Dim sw As New StreamWriter(_csvFile)
                sw.Write(csvText.ToString)
                sw.Flush()
                sw.Close()
                DisplayCsvExportDialog()
                'MessageBox.Show(description & " successfully exported to " & csvFile, "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("There was an error writing the " & description & " File. The error was: " & ControlChars.CrLf & ControlChars.CrLf & ex.Message, "Error Writing File", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Sub

        Private Sub DisplayCsvExportDialog()
            TaskDialog.AntiAlias = True
            TaskDialog.EnableGlass = False
            Dim tdi As New TaskDialogInfo
            tdi.TaskDialogIcon = eTaskDialogIcon.CheckMark2
            tdi.DialogButtons = eTaskDialogButton.Ok
            tdi.DefaultButton = eTaskDialogButton.Ok
            tdi.Buttons = New Command() {CSVExportOpenFolderButton, CSVExportOpenFileButton}
            tdi.Title = "CSV Export Complete"
            tdi.Header = "CSV Export Complete"
            tdi.Text = "Prism has completed the export of the CSV data." & ControlChars.CrLf & ControlChars.CrLf
            tdi.Text &= "You can close this screen or optionally select one of the following additional tasks below."
            tdi.DialogColor = eTaskDialogBackgroundColor.DarkBlue
            'tdi.CheckBoxCommand = CSVExportDialogCheckBox
            TaskDialog.Show(Me, tdi)
        End Sub

        Private Sub CSVExportOpenFolderButton_Executed(sender As System.Object, e As EventArgs) Handles CSVExportOpenFolderButton.Executed
            Try
                Process.Start(HQ.ReportFolder)
            Catch ex As Exception
                MessageBox.Show("Unable to start Windows Explorer: " & ex.Message, "Error Starting External Process", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            TaskDialog.Close()
        End Sub

        Private Sub CSVExportOpenFileButton_Executed(sender As System.Object, e As EventArgs) Handles CSVExportOpenFileButton.Executed
            Try
                Process.Start(_csvFile)
            Catch ex As Exception
                MessageBox.Show("Unable to open CSV File in the defaul application: " & ex.Message, "Error Starting External Process", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            TaskDialog.Close()
        End Sub

#End Region

#Region "BPManager Routines"

        Private Sub btnBPCalc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBPCalc.Click
            If adtBlueprints.SelectedNodes.Count = 1 Then
                Dim bpName As String = adtBlueprints.SelectedNodes(0).Text
                If chkShowOwnedBPs.Checked = True Then
                    ' Start an owned BPCalc
                    If adtBlueprints.SelectedNodes(0).Tag IsNot Nothing Then
                        Dim bpid As Long = CLng(adtBlueprints.SelectedNodes(0).Tag)
                        Dim bpCalc As New FrmBPCalculator(PrismSettings.UserSettings.DefaultBPOwner, bpid)
                        Call OpenBpCalculator(bpCalc)
                    End If
                Else
                    ' Start a standard BPCalc
                    Dim bpCalc As New FrmBPCalculator(bpName)
                    Call OpenBpCalculator(bpCalc)
                End If
            ElseIf adtBlueprints.SelectedNodes.Count = 0 Then
                ' Start a blank BP Calc
                Dim bpCalc As New FrmBPCalculator(chkShowOwnedBPs.Checked)
                Call OpenBpCalculator(bpCalc)
            End If
        End Sub

        Private Sub cboBPOwner_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboBPOwner.SelectedIndexChanged

            ' Check for filter changes, but set the flag to avoid invoking other changes at this point
            _bpManagerUpdate = True

            If cboTechFilter.SelectedIndex = -1 Then cboTechFilter.SelectedIndex = 0
            If cboTypeFilter.SelectedIndex = -1 Then cboTypeFilter.SelectedIndex = 0
            If cboCategoryFilter.SelectedIndex = -1 Then cboCategoryFilter.SelectedIndex = 0

            _bpManagerUpdate = False

            Call UpdateBpList()
        End Sub

        Private Sub chkShowOwnedBPs_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkShowOwnedBPs.CheckedChanged
            Call UpdateBpList()
        End Sub

        Private Sub UpdateBpList()
            ' Check if we are showing the full list or the owners list
            If chkShowOwnedBPs.Checked = False Then
                ' Check the filters
                If cboTechFilter.SelectedIndex = -1 Then
                    cboTechFilter.SelectedIndex = 0
                End If
                If cboTypeFilter.SelectedIndex = -1 Then
                    cboTypeFilter.SelectedIndex = 0
                End If
                If cboCategoryFilter.SelectedIndex = -1 Then
                    cboCategoryFilter.SelectedIndex = 0
                End If
                Dim search As String = txtBPSearch.Text
                ' Show the full BP list
                adtBlueprints.BeginUpdate()
                adtBlueprints.Nodes.Clear()
                Dim matchCat As Boolean
                For Each blueprint As EveData.Blueprint In StaticData.Blueprints.Values
                    If StaticData.Types.ContainsKey(blueprint.Id) Then
                        Dim bpName As String = StaticData.Types(blueprint.Id).Name
                        If cboTechFilter.SelectedIndex = 0 Or (cboTechFilter.SelectedIndex = blueprint.TechLevel) Then
                            matchCat = False
                            If cboCategoryFilter.SelectedIndex = 0 Then
                                matchCat = True
                            Else
                                If PlugInData.CategoryNames.ContainsKey(cboCategoryFilter.SelectedItem.ToString) Then
                                    If StaticData.Types.ContainsKey(blueprint.ProductId) Then
                                        If CInt(PlugInData.CategoryNames(cboCategoryFilter.SelectedItem.ToString)) = StaticData.Types(blueprint.ProductId).Category Then
                                            matchCat = True
                                        End If
                                    End If
                                End If
                                ' Refine for groups
                                If cboGroupFilter.SelectedIndex > 0 Then
                                    If _bpManagerGroups.ContainsKey(cboGroupFilter.SelectedItem.ToString) Then
                                        If StaticData.Types.ContainsKey(blueprint.ProductId) Then
                                            If CInt(_bpManagerGroups(cboGroupFilter.SelectedItem.ToString)) = StaticData.Types(blueprint.ProductId).Group Then
                                                matchCat = True
                                            Else
                                                matchCat = False
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                            If matchCat = True Then
                                If search = "" Or bpName.ToLower.Contains(search.ToLower) Then
                                    Dim newBpItem As New Node
                                    newBpItem.Text = bpName
                                    adtBlueprints.Nodes.Add(newBpItem)
                                    newBpItem.CreateCells()
                                    If StaticData.Types.ContainsKey(blueprint.ProductId) Then
                                        newBpItem.Cells(1).Text = StaticData.TypeCats(StaticData.Types(blueprint.ProductId).Category)
                                        newBpItem.Cells(2).Text = StaticData.TypeGroups(StaticData.Types(blueprint.ProductId).Group)
                                    Else
                                        newBpItem.Cells(1).Text = "<Unknown>"
                                        newBpItem.Cells(2).Text = "<Unknown>"
                                    End If
                                    newBpItem.Cells(3).Text = "n/a"
                                    newBpItem.Cells(4).Text = "n/a"
                                    newBpItem.Cells(5).Text = blueprint.TechLevel.ToString
                                    newBpItem.Cells(6).Text = "0"
                                    newBpItem.Cells(7).Text = "0"
                                    newBpItem.Cells(8).Text = "Infinite"
                                    newBpItem.Cells(9).Text = "n/a"
                                End If
                            End If
                        End If
                    End If
                Next
                AdvTreeSorter.Sort(adtBlueprints, 1, True, True)
                adtBlueprints.EndUpdate()
            Else
                ' Show the owned BP list
                Call UpdateOwnerBpList()
            End If
        End Sub

        Private Sub UpdateOwnerBpList()
            Dim search As String = txtBPSearch.Text
            ' Establish the owner
            If cboBPOwner.SelectedItem IsNot Nothing Then
                Dim prismOwner As String = cboBPOwner.SelectedItem.ToString()

                adtBlueprints.BeginUpdate()
                adtBlueprints.Nodes.Clear()
                If prismOwner <> "" Then
                    ' Fetch the ownerBPs if it exists
                    Dim ownerBPs As New SortedList(Of Long, BlueprintAsset)
                    If PlugInData.BlueprintAssets.ContainsKey(prismOwner) = True Then
                        ownerBPs = PlugInData.BlueprintAssets(prismOwner)
                    End If
                    Dim bpData As EveData.Blueprint
                    Dim locationName As String
                    Dim matchCat As Boolean
                    _bpLocations.Clear()
                    For Each blueprint As BlueprintAsset In ownerBPs.Values
                        If blueprint.LocationDetails Is Nothing Then blueprint.LocationDetails = "" ' Resets details
                        If blueprint.LocationID Is Nothing Then blueprint.LocationID = "0" ' Resets details
                        If StaticData.Blueprints.ContainsKey(CInt(blueprint.TypeID)) Then
                            bpData = StaticData.Blueprints(CInt(blueprint.TypeID))
                            locationName = Locations.GetLocationNameFromID(CLng(blueprint.LocationID))
                            If locationName <> "" AndAlso _bpLocations.Contains(locationName) = False Then
                                _bpLocations.Add(locationName)
                            End If
                            If cboTechFilter.SelectedIndex = 0 Or (cboTechFilter.SelectedIndex = bpData.TechLevel) Then
                                If cboTypeFilter.SelectedIndex = 0 Or (cboTypeFilter.SelectedIndex = blueprint.BPType + 1) Then
                                    matchCat = False
                                    If cboCategoryFilter.SelectedIndex = 0 Then
                                        matchCat = True
                                    Else
                                        If PlugInData.CategoryNames.ContainsKey(cboCategoryFilter.SelectedItem.ToString) Then
                                            If CInt(PlugInData.CategoryNames(cboCategoryFilter.SelectedItem.ToString)) = StaticData.Types(bpData.ProductId).Category Then
                                                matchCat = True
                                            End If
                                        End If
                                        ' Refine for groups
                                        If cboGroupFilter.SelectedIndex > 0 Then
                                            If _bpManagerGroups.ContainsKey(cboGroupFilter.SelectedItem.ToString) Then
                                                If StaticData.Types.ContainsKey(bpData.ProductId) Then
                                                    If CInt(_bpManagerGroups(cboGroupFilter.SelectedItem.ToString)) = StaticData.Types(bpData.ProductId).Group Then
                                                        matchCat = True
                                                    Else
                                                        matchCat = False
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                    If matchCat = True Then
                                        Dim bpName As String = StaticData.Types(CInt(blueprint.TypeID)).Name
                                        If search = "" Or bpName.ToLower.Contains(search.ToLower) Or blueprint.LocationDetails.ToLower.Contains(search.ToLower) Or locationName.ToLower.Contains(search.ToLower) Then
                                            Dim newBpItem As New Node
                                            adtBlueprints.Nodes.Add(newBpItem)
                                            newBpItem.CreateCells()
                                            newBpItem.Text = bpName
                                            newBpItem.Tag = blueprint.AssetID
                                            newBpItem.Cells(5).Text = bpData.TechLevel.ToString
                                            Call UpdateOwnerBpItem(prismOwner, locationName, blueprint, newBpItem)
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    Next
                End If
                AdvTreeSorter.Sort(adtBlueprints, 1, True, True)
                adtBlueprints.EndUpdate()
            End If
        End Sub
        Private Sub UpdateOwnerBpItem(ByVal pOwner As String, ByVal locationName As String, ByVal bpAsset As BlueprintAsset, ByVal newBpItem As Node)
            If StaticData.Blueprints.ContainsKey(CInt(bpAsset.TypeID)) Then
                Dim bpData As EveData.Blueprint = StaticData.Blueprints(CInt(bpAsset.TypeID))
                If StaticData.Types.ContainsKey(bpData.ProductId) Then
                    newBpItem.Cells(1).Text = StaticData.TypeCats(StaticData.Types(bpData.ProductId).Category)
                    newBpItem.Cells(2).Text = StaticData.TypeGroups(StaticData.Types(bpData.ProductId).Group)
                Else
                    newBpItem.Cells(1).Text = "<Unknown>"
                    newBpItem.Cells(2).Text = "<Unknown>"
                End If
            End If
            newBpItem.Cells(6).Text = bpAsset.MELevel.ToString("N0")
            newBpItem.Cells(7).Text = bpAsset.PELevel.ToString("N0")
            Select Case bpAsset.BPType
                Case BPType.Unknown  ' Undetermined
                    newBpItem.Cells(3).Text = locationName
                    newBpItem.Cells(4).Text = bpAsset.LocationDetails
                    newBpItem.Cells(8).Text = "Unknown"
                    newBpItem.Cells(8).Tag = bpAsset.Runs
                    newBpItem.Style = _bpmStyleUnknown
                Case BPType.Original  ' BPO
                    newBpItem.Cells(3).Text = locationName
                    newBpItem.Cells(4).Text = bpAsset.LocationDetails
                    newBpItem.Cells(8).Text = "BPO"
                    newBpItem.Cells(8).Tag = 1000000
                    newBpItem.Style = _bpmStyleBpo
                Case BPType.Copy ' BPC
                    newBpItem.Cells(3).Text = locationName
                    newBpItem.Cells(4).Text = bpAsset.LocationDetails
                    newBpItem.Cells(8).Text = bpAsset.Runs.ToString("N0")
                    newBpItem.Cells(8).Tag = bpAsset.Runs
                    newBpItem.Style = _bpmStyleBpc
                Case BPType.User
                    newBpItem.Cells(3).Text = pOwner & "'s Secret BP Stash"
                    newBpItem.Cells(4).Text = pOwner & "'s Secret BP Stash"
                    newBpItem.Cells(8).Text = "BPO"
                    newBpItem.Cells(8).Tag = 1000000
                    newBpItem.Style = _bpmStyleUser
            End Select
            newBpItem.Cells(9).Text = [Enum].GetName(GetType(BPStatus), bpAsset.Status)
            newBpItem.Cells(9).Tag = bpAsset.Status
            Select Case bpAsset.Status
                Case BPStatus.Missing
                    newBpItem.Style = _bpmStyleMissing
                Case BPStatus.Exhausted
                    newBpItem.Style = _bpmStyleExhausted
            End Select
        End Sub

        Private Sub btnUpdateBPsFromAssets_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdateBPsFromAssets.Click

            ' Get the owner we will use
            Dim pOwner As PrismOwner
            If cboBPOwner.SelectedItem IsNot Nothing Then
                If PlugInData.PrismOwners.ContainsKey(cboBPOwner.SelectedItem.ToString) Then
                    pOwner = PlugInData.PrismOwners(cboBPOwner.SelectedItem.ToString)

                    ' Fetch the ownerBPs if it exists
                    Dim ownerBPs As New SortedList(Of Long, BlueprintAsset)
                    If PlugInData.BlueprintAssets.ContainsKey(pOwner.Name) = True Then
                        ownerBPs = PlugInData.BlueprintAssets(pOwner.Name)
                    Else
                        PlugInData.BlueprintAssets.Add(pOwner.Name, ownerBPs)
                    End If

                    Dim ownerAccount As EveHQAccount = PlugInData.GetAccountForCorpOwner(pOwner, CorpRepType.Assets)
                    Dim ownerId As String = PlugInData.GetAccountOwnerIDForCorpOwner(pOwner, CorpRepType.Assets)
                    Dim assetData As EveServiceResponse(Of IEnumerable(Of NewEveApi.Entities.AssetItem))
                    If pOwner.IsCorp = True Then
                        assetData = HQ.ApiProvider.Corporation.AssetList(ownerAccount.UserID, ownerAccount.APIKey, ownerId.ToInt32())
                    Else
                        assetData = HQ.ApiProvider.Character.AssetList(ownerAccount.UserID, ownerAccount.APIKey, ownerId.ToInt32())
                    End If

                    If assetData.IsSuccess Then
                        Dim assets As New SortedList(Of Long, BlueprintAsset)
                        Dim itemList = assetData.ResultData
                        If itemList.Count > 0 Then
                            ' Define what we want to obtain
                            Dim categories, groups, types As New ArrayList
                            categories.Add(9) ' Blueprints
                            For Each item In itemList
                                Dim locationId As String = item.LocationId.ToInvariantString()
                                Dim flagId As Integer = item.Flag
                                Dim locationDetails As String = StaticData.ItemMarkers(flagId)
                                Dim bpcFlag As Boolean = False
                                ' Check the asset
                                Dim itemData As EveType
                                Dim assetId As Long
                                Dim itemId As Integer
                                assetId = item.ItemId
                                itemId = item.TypeId
                                If StaticData.Types.ContainsKey(itemId) Then
                                    itemData = StaticData.Types(itemId)
                                    ' Check for BPO/BPC
                                    If itemData.Category = 9 Then
                                        If item.Singleton Then
                                            If item.RawQuantity = -2 Then
                                                bpcFlag = True
                                            End If
                                        End If
                                    End If
                                    If flagId = 0 Then
                                        If PlugInData.AssetItemNames.ContainsKey(assetId) = True Then
                                            locationDetails = PlugInData.AssetItemNames(assetId)
                                        Else
                                            locationDetails = itemData.Name
                                        End If
                                    End If
                                    If categories.Contains(itemData.Category) Or groups.Contains(itemData.Group) Or types.Contains(itemData.Id) Then
                                        Dim newBp As New BlueprintAsset
                                        newBp.AssetID = CStr(assetId)
                                        newBp.LocationID = locationId
                                        If pOwner.IsCorp = True Then
                                            Dim accountId As Integer = flagId + 885
                                            If accountId = 889 Then accountId = 1000
                                            If _divisions.ContainsKey(pOwner.ID & "_" & accountId.ToString) = True Then
                                                locationDetails = CStr(_divisions.Item(pOwner.ID & "_" & accountId.ToString))
                                            End If
                                        End If
                                        If newBp.BPType = BPType.Unknown Then
                                            If bpcFlag = True Then
                                                newBp.BPType = BPType.Copy
                                                newBp.Runs = 1
                                            Else
                                                newBp.BPType = BPType.Original
                                                newBp.Runs = -1
                                            End If
                                        End If
                                        newBp.LocationDetails = locationDetails
                                        newBp.TypeID = CStr(itemId)
                                        newBp.Status = BPStatus.Present
                                        newBp.MELevel = 0
                                        newBp.PELevel = 0
                                        newBp.Notes = ""
                                        assets.Add(assetId, newBp)
                                    End If
                                End If

                                ' Get the location name
                                If item.Contents IsNot Nothing Then
                                    If item.Contents.Any() Then
                                        Call GetAssetFromNode(item, categories, groups, types, assets, locationId, locationDetails, pOwner)
                                    End If
                                End If
                            Next
                        End If
                        If assets.Count > 0 Then
                            ' Mark all of our existing blueprints as missing
                            For Each ownerBp As BlueprintAsset In ownerBPs.Values
                                If ownerBp.BPType <> BPType.User Then
                                    ownerBp.Status = BPStatus.Missing
                                Else
                                    ownerBp.Status = BPStatus.Present
                                End If
                            Next
                            ' Should have our list of assets now so let's compare them
                            For Each assetId As Long In assets.Keys
                                ' See if the assetID already exists for the owner
                                If ownerBPs.ContainsKey(assetId) = True Then
                                    ' We have it so set the status to present
                                    ownerBPs(assetId).Status = BPStatus.Present
                                    ' Update the location
                                    ownerBPs(assetId).LocationID = assets(assetId).LocationID
                                    ownerBPs(assetId).LocationDetails = assets(assetId).LocationDetails
                                    ' Update the type
                                    ownerBPs(assetId).BPType = assets(assetId).BPType
                                    ' Update the runs if we have found the asset is a BPC and the runs are still -1
                                    If ownerBPs(assetId).BPType = BPType.Copy And ownerBPs(assetId).Runs = -1 Then
                                        ownerBPs(assetId).Runs = 0
                                    End If
                                Else
                                    ' Not present in the existing list so let's add it in
                                    ownerBPs.Add(assetId, assets(assetId))
                                End If
                            Next
                        Else
                            ' Mark all of our existing blueprints as missing
                            For Each ownerBp As BlueprintAsset In ownerBPs.Values
                                If ownerBp.BPType <> BPType.User Then
                                    ownerBp.Status = BPStatus.Missing
                                Else
                                    ownerBp.Status = BPStatus.Present
                                End If
                            Next
                        End If
                    End If

                    ' Get BP Data
                    Call GetBpInfoFromApi()

                    ' Update the owner list if the option requires it
                    If chkShowOwnedBPs.Checked = True Then
                        Call UpdateOwnerBpList()
                    End If

                End If
            Else
                MessageBox.Show("Make sure you have entered your API details and selected the correct owner before proceeding.", "Owner Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End Sub
        Private Sub GetAssetFromNode(ByVal parentItem As NewEveApi.Entities.AssetItem, ByVal categories As ArrayList, ByVal groups As ArrayList, ByVal types As ArrayList, ByRef assets As SortedList(Of Long, BlueprintAsset), ByVal locationId As String, ByVal locationDetails As String, ByVal prismOwner As PrismOwner)
            Dim itemList = parentItem.Contents
            Dim itemData As EveType
            Dim assetId As Long
            Dim itemId As Integer
            Dim flagId As Integer
            Dim flagName As String = ""
            Dim containerId As Long = parentItem.ItemId
            Dim containerType As Integer = parentItem.TypeId
            For Each item In itemList
                assetId = item.ItemId
                itemId = item.TypeId
                flagId = item.Flag
                Dim bpcFlag As Boolean = False
                If StaticData.Types.ContainsKey(itemId) Then
                    itemData = StaticData.Types(itemId)
                    ' Check for BPO/BPC
                    If itemData.Category = 9 Then
                        If item.Singleton Then
                            If item.RawQuantity = -2 Then
                                bpcFlag = True
                            End If
                        End If
                    End If
                    If PlugInData.AssetItemNames.ContainsKey(containerId) = True Then
                        flagName = locationDetails & "/" & PlugInData.AssetItemNames(containerId)
                    Else
                        flagName = locationDetails & "/" & StaticData.Types(containerType).Name
                    End If
                    If categories.Contains(itemData.Category) Or groups.Contains(itemData.Group) Or types.Contains(itemData.Id) Then
                        Dim newBp As New BlueprintAsset
                        newBp.AssetID = CStr(assetId)
                        newBp.LocationID = locationId
                        If prismOwner.IsCorp = True And StaticData.Types(itemId).Group <> 16 Then
                            Dim accountId As Integer = flagId + 885
                            If accountId = 889 Then accountId = 1000
                            If _divisions.ContainsKey(prismOwner.ID & "_" & accountId.ToString) = True Then
                                flagName = locationDetails & "/" & CStr(_divisions.Item(prismOwner.ID & "_" & accountId.ToString))
                            End If
                        End If
                        If newBp.BPType = BPType.Unknown Then
                            If bpcFlag = True Then
                                newBp.BPType = BPType.Copy
                                newBp.Runs = 1
                            Else
                                newBp.BPType = BPType.Original
                                newBp.Runs = -1
                            End If
                        End If
                        newBp.LocationDetails = flagName
                        newBp.TypeID = CStr(itemId)
                        newBp.Status = BPStatus.Present
                        newBp.MELevel = 0
                        newBp.PELevel = 0
                        newBp.Notes = ""
                        assets.Add(assetId, newBp)
                    End If
                End If
                ' Check child items if they exist
                If item.Contents IsNot Nothing Then
                    If item.Contents.Any() Then
                        Call GetAssetFromNode(item, categories, groups, types, assets, locationId, flagName, prismOwner)
                    End If
                End If
            Next
        End Sub

        Private Sub GetBpInfoFromApi()

            Dim pOwner As PrismOwner
            If cboBPOwner.SelectedItem IsNot Nothing Then
                If PlugInData.PrismOwners.ContainsKey(cboBPOwner.SelectedItem.ToString) Then
                    pOwner = PlugInData.PrismOwners(cboBPOwner.SelectedItem.ToString)

                    ' Fetch the ownerBPs if it exists
                    Dim ownerBPs As New SortedList(Of Long, BlueprintAsset)
                    If PlugInData.BlueprintAssets.ContainsKey(pOwner.Name) = True Then
                        ownerBPs = PlugInData.BlueprintAssets(pOwner.Name)
                    Else
                        PlugInData.BlueprintAssets.Add(pOwner.Name, ownerBPs)
                    End If

                    Dim ownerAccount As EveHQAccount = PlugInData.GetAccountForCorpOwner(pOwner, CorpRepType.Assets)
                    Dim ownerId As String = PlugInData.GetAccountOwnerIDForCorpOwner(pOwner, CorpRepType.Assets)
                    Dim bpList As NewEveApi.EveServiceResponse(Of IEnumerable(Of Entities.Blueprint))
                    Dim bpData As NewEveApi.Entities.Blueprint
                    Dim updateBp As BlueprintAsset

                    If pOwner.IsCorp Then
                        bpList = HQ.ApiProvider.Corporation.Blueprints(ownerAccount.UserID, ownerAccount.APIKey, ownerId.ToInt32())
                    Else
                        bpList = HQ.ApiProvider.Character.Blueprints(ownerAccount.UserID, ownerAccount.APIKey, ownerId.ToInt32())
                    End If

                    If bpList.ResultData IsNot Nothing Then
                        If bpList.ResultData.Count() > 0 Then
                            For Each bpData In bpList.ResultData
                                If ownerBPs.ContainsKey(bpData.ItemID) Then
                                    updateBp = ownerBPs(bpData.ItemID)
                                    updateBp.MELevel = bpData.MaterialEfficiency.ToInt32()
                                    updateBp.PELevel = bpData.TimeEfficiency.ToInt32()
                                    updateBp.Runs = bpData.Runs.ToInt32()
                                    If bpData.Quantity = -2 Then
                                        updateBp.BPType = BPType.Copy
                                    Else
                                        updateBp.BPType = BPType.Original
                                    End If
                                End If
                            Next
                        End If
                    End If

                End If
            End If

        End Sub

        Private Sub ctxBPManager_Opening(ByVal sender As Object, ByVal e As CancelEventArgs) Handles ctxBPManager.Opening
            If adtBlueprints.SelectedNodes.Count = 1 Then
                mnuSendToBPCalc.Enabled = True
                ' Get the blueprint info
                If chkShowOwnedBPs.Checked = True Then
                    Dim assetId As Long = CLng(adtBlueprints.SelectedNodes(0).Tag)
                    Dim bpOwner As String = cboBPOwner.SelectedItem.ToString
                    Dim asset As BlueprintAsset = PlugInData.BlueprintAssets(bpOwner).Item(assetId)
                    If asset.AssetID = asset.TypeID Then
                        ' Custom BP
                        mnuRemoveCustomBP.Text = "Remove Custom Blueprint"
                        mnuRemoveCustomBP.Enabled = True
                    Else
                        ' Standard BP
                        mnuRemoveCustomBP.Text = "Remove Blueprint"
                        mnuRemoveCustomBP.Enabled = True
                    End If
                Else
                    mnuRemoveCustomBP.Text = "Remove Blueprint"
                    mnuRemoveCustomBP.Enabled = False
                End If
            Else
                mnuSendToBPCalc.Enabled = False
                mnuRemoveCustomBP.Text = "Remove Blueprints (" & adtBlueprints.SelectedNodes.Count.ToString & ")"
                mnuRemoveCustomBP.Enabled = True
            End If
            mnuAmendBPDetails.Enabled = chkShowOwnedBPs.Checked
        End Sub

        Private Sub mnuSendToBPCalc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuSendToBPCalc.Click
            If adtBlueprints.SelectedNodes.Count = 1 Then
                Dim bpName As String = adtBlueprints.SelectedNodes(0).Text
                If chkShowOwnedBPs.Checked = True Then
                    ' Start an owned BPCalc
                    If adtBlueprints.SelectedNodes(0).Tag IsNot Nothing Then
                        Dim bpid As Long = CLng(adtBlueprints.SelectedNodes(0).Tag)
                        Dim bpCalc As New FrmBPCalculator(cboBPOwner.SelectedItem.ToString, bpid)
                        Call OpenBpCalculator(bpCalc)
                    End If
                Else
                    ' Start a standard BPCalc
                    Dim bpCalc As New FrmBPCalculator(bpName)
                    Call OpenBpCalculator(bpCalc)
                End If
            ElseIf adtBlueprints.SelectedNodes.Count = 0 Then
                ' Start a blank BP Calc
                Dim bpCalc As New FrmBPCalculator(chkShowOwnedBPs.Checked)
                Call OpenBpCalculator(bpCalc)
            End If
        End Sub

        Private Sub OpenBpCalculator(ByVal bpCalc As FrmBPCalculator)
            bpCalc.Location = New Point(CInt(ParentForm.Left + ((ParentForm.Width - bpCalc.Width) / 2)), CInt(ParentForm.Top + ((ParentForm.Height - bpCalc.Height) / 2)))
            bpCalc.Show()
        End Sub

        Private Sub mnuAmendBPDetails_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuAmendBPDetails.Click
            Call EditBlueprintDetails()
        End Sub

        Private Sub EditBlueprintDetails()
            Using bpForm As New FrmEditBPDetails
                bpForm.OwnerName = cboBPOwner.SelectedItem.ToString
                Dim bps As New List(Of Long)
                For Each selItem As Node In adtBlueprints.SelectedNodes
                    bps.Add(CLng(selItem.Tag))
                Next
                If bps.Count > 0 Then
                    bpForm.AssetIDs = bps
                    bpForm.ShowDialog()
                    ' Update the list using the details
                    Dim bpAsset As BlueprintAsset
                    Dim locationName As String
                    For Each selitem As Node In adtBlueprints.SelectedNodes
                        bpAsset = PlugInData.BlueprintAssets(bpForm.OwnerName).Item(CLng(selitem.Tag))
                        locationName = Locations.GetLocationNameFromID(CLng(bpAsset.LocationID))
                        Call UpdateOwnerBpItem(bpForm.OwnerName, locationName, bpAsset, selitem)
                    Next
                Else
                    Dim msg As New StringBuilder
                    msg.AppendLine("An attempt to start the BP Editor was made but it appears as if there is nothing to edit! Please take a screenshot of this message together with the Blueprint Manager list and submit it to the developers for investigation.")
                    msg.AppendLine("")
                    msg.AppendLine("ArrayList Count: " & bps.Count.ToString)
                    msg.AppendLine("Selected Node Count: " & adtBlueprints.SelectedNodes.Count.ToString)
                    MessageBox.Show(msg.ToString, "No Blueprints Selected??", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        End Sub

        Private Sub txtBPSearch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtBPSearch.TextChanged
            Call UpdateBpList()
        End Sub

        Private Sub btnResetBPSearch_Click(sender As Object, e As EventArgs) Handles btnResetBPSearch.Click
            txtBPSearch.Clear()
			txtBPSearch.Focus()
        End Sub

        Private Sub btnAddCustomBP_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddCustomBP.Click
            Using bpForm As New FrmAddCustomBP
                If cboBPOwner.SelectedItem IsNot Nothing Then
                    bpForm.BPOwner = cboBPOwner.SelectedItem.ToString
                    bpForm.ShowDialog()
                    If bpForm.DialogResult = DialogResult.OK Then
                        Call UpdateBpList()
                    End If
                Else
                    MessageBox.Show("Please select an BP Owner before adding a custom blueprint.", "BP Owner Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        End Sub

        Private Sub mnuRemoveCustomBP_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuRemoveCustomBP.Click
            ' Remove the custom BP from the assets
            If adtBlueprints.SelectedNodes.Count > 0 Then
                ' Establish list for removal
                Dim removalList As New List(Of Node)
                For Each rn As Node In adtBlueprints.SelectedNodes
                    removalList.Add(rn)
                Next
                ' Remove the nodes
                Dim bpOwner As String = cboBPOwner.SelectedItem.ToString
                For Each rn As Node In removalList
                    Dim assetId As Long = CLng(rn.Tag)
                    If PlugInData.BlueprintAssets(bpOwner).ContainsKey(assetId) = True Then
                        PlugInData.BlueprintAssets(bpOwner).Remove(assetId)
                        adtBlueprints.Nodes.Remove(rn)
                    End If
                Next
                removalList.Clear()
            End If
        End Sub

        Private Sub cboTechFilter_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboTechFilter.SelectedIndexChanged
            If _startup = False And _bpManagerUpdate = False Then
                Call UpdateBpList()
            End If
        End Sub

        Private Sub cboTypeFilter_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboTypeFilter.SelectedIndexChanged
            If _startup = False And _bpManagerUpdate = False Then
                Call UpdateBpList()
            End If
        End Sub

        Private Sub cboCategoryFilter_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboCategoryFilter.SelectedIndexChanged
            If _startup = False And _bpManagerUpdate = False Then
                ' Update the group filter list
                cboGroupFilter.BeginUpdate()
                cboGroupFilter.Items.Clear()
                cboGroupFilter.Items.Add("All")
                _bpManagerGroups.Clear()
                Dim catId As Integer = PlugInData.CategoryNames(cboCategoryFilter.SelectedItem.ToString)
                For Each bpi As EveData.Blueprint In StaticData.Blueprints.Values
                    If StaticData.Types.ContainsKey(bpi.ProductId) Then
                        If catId = StaticData.Types(bpi.ProductId).Category Then
                            If _bpManagerGroups.ContainsKey(StaticData.TypeGroups(StaticData.Types(bpi.ProductId).Group)) = False Then
                                _bpManagerGroups.Add(StaticData.TypeGroups(StaticData.Types(bpi.ProductId).Group), StaticData.Types(bpi.ProductId).Group)
                            End If
                        End If
                    End If
                Next
                For Each group As String In _bpManagerGroups.Keys
                    cboGroupFilter.Items.Add(group)
                Next
                cboGroupFilter.EndUpdate()
                cboGroupFilter.SelectedIndex = 0
                Call UpdateBpList()
            End If
        End Sub

        Private Sub cboGroupFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGroupFilter.SelectedIndexChanged
            If _startup = False And _bpManagerUpdate = False Then
                Call UpdateBpList()
            End If
        End Sub

        Private Sub adtBlueprints_ColumnHeaderMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles adtBlueprints.ColumnHeaderMouseDown
            Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
            AdvTreeSorter.Sort(ch, False, False)
        End Sub

        Private Sub adtBlueprints_NodeDoubleClick(ByVal sender As Object, ByVal e As TreeNodeMouseEventArgs) Handles adtBlueprints.NodeDoubleClick
            If adtBlueprints.SelectedNodes.Count = 1 Then
                Dim bpName As String = adtBlueprints.SelectedNodes(0).Text
                If chkShowOwnedBPs.Checked = True Then
                    ' Start an owned BPCalc
                    If adtBlueprints.SelectedNodes(0).Tag IsNot Nothing Then
                        Dim bpid As Long = CLng(adtBlueprints.SelectedNodes(0).Tag)
                        Dim bpCalc As New FrmBPCalculator(cboBPOwner.SelectedItem.ToString, bpid)
                        Call OpenBpCalculator(bpCalc)
                    End If
                Else
                    ' Start a standard BPCalc
                    Dim bpCalc As New FrmBPCalculator(bpName)
                    Call OpenBpCalculator(bpCalc)
                End If
            ElseIf adtBlueprints.SelectedNodes.Count = 0 Then
                ' Start a blank BP Calc
                Dim bpCalc As New FrmBPCalculator(chkShowOwnedBPs.Checked)
                Call OpenBpCalculator(bpCalc)
            End If
        End Sub

        Private Sub btnCopyListToClipboard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCopyListToClipboard.Click
            ' Exports the list to Clipboard in TSV format for pasting to Excel etc
            If cboBPOwner.SelectedItem IsNot Nothing Then
                Call ExportToClipboard("Blueprint List for " & cboBPOwner.SelectedItem.ToString, adtBlueprints, ControlChars.Tab)
            Else
                MessageBox.Show("A BP Owner is required before copying the data to the clipboard", "BP Owner Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Sub

#End Region

#Region "Transaction List Menu Options"

        Private Sub ctxTransactions_Opening(ByVal sender As Object, ByVal e As CancelEventArgs) Handles ctxTransactions.Opening
            If adtTransactions.SelectedNodes.Count > 0 Then
                Dim transItem As Node = adtTransactions.SelectedNodes(0)
                Dim itemName As String = transItem.Cells(1).Text
                mnuTransactionModifyPrice.Text = "Modify Custom Price of " & itemName
                If StaticData.TypeNames.ContainsKey(itemName) Then
                    mnuTransactionModifyPrice.Tag = StaticData.TypeNames(itemName)
                Else
                    MessageBox.Show("There was a mismatch of expected data. '" & itemName & "' was not found in the collection of items.", "Data Retrieval Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Sub

        Private Sub mnuTransactionModifyPrice_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuTransactionModifyPrice.Click
            If mnuTransactionModifyPrice.Tag IsNot Nothing Then
                Dim itemId As Integer = CInt(mnuTransactionModifyPrice.Tag)
                Dim price As Double = Double.Parse(adtTransactions.SelectedNodes(0).Cells(3).Text, NumberStyles.Any, _culture)
                Using newPrice As New FrmModifyPrice(itemId, price)
                    newPrice.ShowDialog()
                End Using
            End If
        End Sub

#End Region

#Region "Ribbon and Tab UI Functions"

        Private Sub tabPrism_SelectedTabChanging(ByVal sender As Object, ByVal e As TabStripTabChangingEventArgs) Handles tabPrism.SelectedTabChanging
            _selectedTab = e.NewTab
        End Sub

        Private Sub tabPrism_TabItemClose(ByVal sender As Object, ByVal e As TabStripActionEventArgs) Handles tabPrism.TabItemClose
            e.Cancel = True
            If _selectedTab IsNot Nothing Then
                If _selectedTab.Name <> "tiPrismHome" Then
                    _selectedTab.Visible = False
                End If
            End If
        End Sub

        Private Sub btnOptions_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOptions.Click
            Using newSettings As New FrmPrismSettings
                newSettings.ShowDialog()
            End Using
        End Sub

        Private Sub btnDownloadAPIData_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDownloadAPIData.Click

            ' Set the label and disable the button
            lblCurrentAPI.Text = "Downloading API Data..."
            btnDownloadAPIData.Enabled = False

            ' Flick to the API Status tab
            tabPrism.SelectedTab = tiPrismHome
            ' Delete the current API Status data
            For Each pOwner As ListViewItem In lvwCurrentAPIs.Items
                pOwner.ToolTipText = ""
                'Dim OwnerName As String = pOwner.Text
                For si As Integer = 0 To 7
                    'If Owner.SubItems(1).Text = "Corporation" = True Then
                    '    If PrismSettings.UserSettings.CorpReps.ContainsKey(OwnerName) = True Then
                    '        If PrismSettings.UserSettings.CorpReps(OwnerName).ContainsKey(CType(si, CorpRepType)) = True Then
                    '            Owner.SubItems(si + 2).Text = ""
                    '        Else
                    '            Owner.SubItems(si + 2).Text = "No Corp Rep"
                    '            Owner.SubItems(si + 2).ForeColor = Color.Red
                    '        End If
                    '    Else
                    '        Owner.SubItems(si + 2).Text = "No Corp Rep"
                    '        Owner.SubItems(si + 2).ForeColor = Color.Red
                    '    End If
                    'Else
                    '    Owner.SubItems(si + 2).Text = ""
                    'End If
                    pOwner.SubItems(si + 2).Text = ""
                Next
            Next

            ' Get XMLs
            Call StartGetXmlDataThread()

        End Sub

        Private Sub btnWalletJournal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnWalletJournal.Click
            tabPrism.SelectedTab = tiJournal
            tiJournal.Visible = True
        End Sub

        Private Sub btnWalletTransactions_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnWalletTransactions.Click
            tabPrism.SelectedTab = tiTransactions
            tiTransactions.Visible = True
        End Sub

        Private Sub btnAssets_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAssets.Click
            tabPrism.SelectedTab = tiAssets
            tiAssets.Visible = True
        End Sub

        Private Sub btnBPManager_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBPManager.Click
            tabPrism.SelectedTab = tiBPManager
            tiBPManager.Visible = True
        End Sub

        Private Sub btnRecycler_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRecycler.Click
            tabPrism.SelectedTab = tiRecycler
            tiRecycler.Visible = True
        End Sub

        Private Sub btnOrders_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOrders.Click
            tabPrism.SelectedTab = tiMarketOrders
            tiMarketOrders.Visible = True
        End Sub

        Private Sub btnJobs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnJobs.Click
            tiJobs.Visible = True
            tabPrism.SelectedTab = tiJobs
        End Sub

        Private Sub btnContracts_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnContracts.Click
            tiContracts.Visible = True
            tabPrism.SelectedTab = tiContracts
        End Sub

        Private Sub btnReports_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReports.Click
            tabPrism.SelectedTab = tiReports
            tiReports.Visible = True
        End Sub

        Private Sub btnInventionChance_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInventionChance.Click
            Using invCalc As New FrmQuickInventionChance
                invCalc.ShowDialog()
            End Using
        End Sub

        Private Sub btnBlueprintCalc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBlueprintCalc.Click
            ' Start a blank BP Calc
            Dim bpCalc As New FrmBPCalculator(chkShowOwnedBPs.Checked)
            Call OpenBpCalculator(bpCalc)
        End Sub

        Private Sub btnProductionManager_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnProductionManager.Click
            tabPrism.SelectedTab = tiProductionManager
            tiProductionManager.Visible = True
        End Sub

        Private Sub btnInventionManager_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInventionManager.Click
            tabPrism.SelectedTab = tiInventionManager
            tiInventionManager.Visible = True
        End Sub

        Private Sub btnQuickProduction_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQuickProduction.Click
            Using qp As New FrmQuickProduction
                qp.ShowDialog()
            End Using
        End Sub

        Private Sub btnRigBuilder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRigBuilder.Click
            tabPrism.SelectedTab = tiRigBuilder
            tiRigBuilder.Visible = True
        End Sub

        Private Sub btnInventionResults_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInventionResults.Click
            tabPrism.SelectedTab = tiInventionResults
            tiInventionResults.Visible = True
        End Sub

#End Region

#Region "Search and Search UI Functions"

        Private Sub txtItemSearch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtItemSearch.TextChanged
            If Len(txtItemSearch.Text) > 2 Then
                Dim strSearch As String = txtItemSearch.Text.Trim.ToLower
                adtSearch.BeginUpdate()
                adtSearch.Nodes.Clear()
                ' Check items
                For Each item As String In StaticData.TypeNames.Keys
                    If item.ToLower.Contains(strSearch) Then
                        Dim newNode As New Node(item)
                        newNode.Name = item
                        newNode.TagString = "Item"
                        adtSearch.Nodes.Add(newNode)
                    End If
                Next
                ' Check Batch Jobs
                For Each bJob As BatchJob In BatchJobs.Jobs.Values
                    ' Check the Job Name
                    If bJob.BatchName.ToLower.Contains(strSearch) Then
                        Dim newNode As New Node(bJob.BatchName & " [Batch Job]")
                        newNode.Name = bJob.BatchName
                        newNode.TagString = "Batch"
                        adtSearch.Nodes.Add(newNode)
                    End If
                Next
                ' Check Production Jobs
                For Each pJob As Job In Jobs.JobList.Values
                    ' Check the Job Name
                    If pJob.JobName.ToLower.Contains(strSearch) Then
                        Dim newNode As New Node(pJob.JobName & " [Production Job]")
                        newNode.Name = pJob.JobName
                        newNode.TagString = "Production"
                        adtSearch.Nodes.Add(newNode)
                    End If
                    ' Check the Job Type
                    If pJob.TypeName.ToLower.Contains(strSearch) Then
                        Dim newNode As New Node(pJob.TypeName & " [in Production Job '" & pJob.JobName & "']")
                        newNode.Name = pJob.TypeName
                        newNode.TagString = "Item"
                        adtSearch.Nodes.Add(newNode)
                    End If
                Next
                adtSearch.EndUpdate()
            End If
        End Sub

        Private Sub btnLinkBPCalc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLinkBPCalc.Click
            Dim keyName As String = adtSearch.SelectedNodes(0).Name
            Select Case adtSearch.SelectedNodes(0).TagString
                Case "Item"
                    Dim bpName As String = lblSelectedBP.Tag.ToString
                    ' Start a standard BP Calc
                    Dim bpCalc As New FrmBPCalculator(bpName)
                    Call OpenBpCalculator(bpCalc)
                Case "Production"
                    If Jobs.JobList.ContainsKey(keyName) Then
                        Dim pJob As Job = Jobs.JobList(keyName)
                        Dim bpCalc As New FrmBPCalculator(pJob, False)
                        Call OpenBpCalculator(bpCalc)
                    End If
            End Select
        End Sub

        Private Sub btnLinkRequisition_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLinkRequisition.Click
            Dim keyName As String = adtSearch.SelectedNodes(0).Name
            Select Case adtSearch.SelectedNodes(0).TagString
                Case "Item"
                    ' Set up a new Sortedlist to store the required items
                    Dim orders As New SortedList(Of String, Integer)
                    ' Add the current item
                    orders.Add(keyName, 1)
                    ' Setup the Requisition form for Prism and open it
                    Using newReq As New FrmAddRequisition("Prism", orders)
                        newReq.ShowDialog()
                    End Using
                Case "Production"
                    ' Set up a new Sortedlist to store the required items
                    Dim orders As New SortedList(Of String, Integer)
                    If Jobs.JobList.ContainsKey(keyName) Then
                        Dim pJob As Job = Jobs.JobList(keyName)
                        Call CreateRequisitionFromJob(orders, pJob)
                    End If
                    ' Setup the Requisition form for Prism and open it
                    Using newReq As New FrmAddRequisition("Prism", orders)
                        newReq.ShowDialog()
                    End Using
                Case "Batch"
                    ' Set up a new Sortedlist to store the required items
                    Dim orders As New SortedList(Of String, Integer)
                    If BatchJobs.Jobs.ContainsKey(keyName) Then
                        For Each pJobName As String In BatchJobs.Jobs(keyName).ProductionJobs
                            If Jobs.JobList.ContainsKey(pJobName) Then
                                Dim pJob As Job = Jobs.JobList(pJobName)
                                Call CreateRequisitionFromJob(orders, pJob)
                            End If
                        Next
                    End If
                    ' Setup the Requisition form for Prism and open it
                    Using newReq As New FrmAddRequisition("Prism", orders)
                        newReq.ShowDialog()
                    End Using
            End Select
        End Sub

        Private Sub btnLinkProduction_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLinkProduction.Click
            Using qp As New FrmQuickProduction(lblSelectedBP.Tag.ToString)
                qp.ShowDialog()
            End Using
        End Sub

        Private Sub CreateRequisitionFromJob(ByVal orders As SortedList(Of String, Integer), ByVal currentJob As Job)
            If currentJob IsNot Nothing Then
                Dim priceTask As Task(Of Dictionary(Of Integer, Double)) = DataFunctions.GetMarketPrices(From r In currentJob.Resources.Values Where TypeOf (r) Is JobResource Select r.TypeID)
                priceTask.Wait()
                For Each resource As JobResource In currentJob.Resources.Values
                    ' This is a resource so add it
                    If resource.TypeCategory <> 16 Then
                        Dim perfectRaw As Integer = CInt(resource.PerfectUnits)
                        Dim waste As Integer = CInt(resource.WasteUnits)
                        Dim total As Integer = perfectRaw + waste
                        If total > 0 Then
                            Dim totalTotal As Long = CLng(total) * CLng(currentJob.Runs)
                            If orders.ContainsKey(resource.TypeName) = False Then
                                orders.Add(resource.TypeName, CInt(totalTotal))
                            Else
                                orders(resource.TypeName) += CInt(totalTotal)
                            End If
                        End If
                    End If
                Next
                For Each subJob As Job In currentJob.SubJobs.Values
                    Call CreateRequisitionFromJob(orders, subJob)
                Next
            End If
        End Sub

        Private Sub adtSearch_NodeClick(ByVal sender As Object, ByVal e As TreeNodeMouseEventArgs) Handles adtSearch.NodeClick

            Select Case adtSearch.SelectedNodes(0).TagString
                Case "Item"
                    ' Get the name and ID
                    Dim itemName As String = adtSearch.SelectedNodes(0).Name
                    If StaticData.TypeNames.ContainsKey(itemName) = True Then
                        Dim itemId As Integer = StaticData.TypeNames(itemName)

                        ' See if we have a blueprint
                        Dim bpName As String = ""
                        Dim bpid As Integer
                        If itemName.EndsWith("Blueprint", StringComparison.Ordinal) = False Then
                            If StaticData.TypeNames.ContainsKey(itemName.Trim & " Blueprint") = True Then
                                bpName = itemName.Trim & " Blueprint"
                                bpid = StaticData.TypeNames(bpName)
                            End If
                        Else
                            bpid = itemId
                            bpName = itemName
                            itemId = StaticData.Blueprints(CInt(bpid)).ProductId
                            itemName = StaticData.Types(itemId).Name
                        End If

                        lblSelectedItem.Text = "Item: " & itemName
                        lblSelectedItem.Tag = itemName
                        If bpName <> "" Then
                            lblSelectedBP.Text = "Blueprint: " & bpName
                            lblSelectedBP.Tag = bpName
                        Else
                            lblSelectedBP.Text = "Blueprint: <none available>"
                        End If

                        ' Check we can activate buttons
                        If bpid <> 0 Then
                            btnLinkBPCalc.Enabled = True
                            btnLinkProduction.Enabled = True
                        Else
                            btnLinkBPCalc.Enabled = False
                            btnLinkProduction.Enabled = False
                        End If
                        btnLinkRequisition.Enabled = True
                    End If
                Case "Production"
                    Dim jobName As String = adtSearch.SelectedNodes(0).Name
                    If Jobs.JobList.ContainsKey(jobName) = True Then
                        lblSelectedItem.Text = "Job: " & jobName
                        lblSelectedBP.Text = "Blueprint: <per job>"
                        btnLinkBPCalc.Enabled = True
                        btnLinkProduction.Enabled = False
                        btnLinkRequisition.Enabled = True
                    End If
                Case "Batch"
                    Dim batchName As String = adtSearch.SelectedNodes(0).Name
                    If BatchJobs.Jobs.ContainsKey(batchName) = True Then
                        lblSelectedItem.Text = "Batch: " & batchName
                        lblSelectedBP.Text = "Blueprint: <multiple>"
                        btnLinkBPCalc.Enabled = False
                        btnLinkProduction.Enabled = False
                        btnLinkRequisition.Enabled = True
                    End If
            End Select

        End Sub

        Private Sub adtSearch_NodeDoubleClick(ByVal sender As Object, ByVal e As TreeNodeMouseEventArgs) Handles adtSearch.NodeDoubleClick
            Dim keyName As String = e.Node.Name
            Select Case e.Node.TagString
                Case "Item"
                    Dim itemName As String = keyName
                    Dim itemId As Integer
                    ' See if we have a blueprint
                    Dim bpName As String = ""
                    Dim bpid As Integer
                    If itemName.EndsWith("Blueprint", StringComparison.Ordinal) = False Then
                        If StaticData.TypeNames.ContainsKey(itemName.Trim & " Blueprint") = True Then
                            bpName = itemName.Trim & " Blueprint"
                            bpid = StaticData.TypeNames(bpName)
                        End If
                    Else
                        itemId = StaticData.Blueprints(CInt(bpid)).ProductId
                        itemName = StaticData.Types(itemId).Name
                        bpid = itemId
                        bpName = itemName
                    End If
                    If bpid <> 0 Then
                        ' Start a standard BP Calc
                        Dim bpCalc As New FrmBPCalculator(bpName)
                        Call OpenBpCalculator(bpCalc)
                    End If
                Case "Production"
                    If Jobs.JobList.ContainsKey(keyName) Then
                        Dim pJob As Job = Jobs.JobList(keyName)
                        Dim bpCalc As New FrmBPCalculator(pJob, False)
                        Call OpenBpCalculator(bpCalc)
                    End If
            End Select
        End Sub

#End Region

#Region "Production Manager Routines"

        Private Sub UpdateProductionJobList()
            adtProdJobs.BeginUpdate()
            adtProdJobs.Nodes.Clear()
            Dim priceTask As Task(Of Dictionary(Of Integer, Double)) = DataFunctions.GetMarketPrices(From r In Jobs.JobList.Values Where r.CurrentBlueprint IsNot Nothing Select r.CurrentBlueprint.ProductId)
            priceTask.Wait()
            Dim prices As Dictionary(Of Integer, Double) = priceTask.Result
            For Each cJob As Job In Jobs.JobList.Values
                Dim newJob As New Node
                newJob.Name = cJob.JobName
                newJob.Text = cJob.JobName
                newJob.Cells.Add(New Cell(cJob.TypeName))

                If cJob.CurrentBlueprint IsNot Nothing Then
                    cJob.Cost = cJob.CalculateCost()
                    Dim product As EveType = StaticData.Types(cJob.CurrentBlueprint.ProductId)
                    Dim totalcosts As Double = cJob.Cost + Math.Round((PrismSettings.UserSettings.FactoryRunningCost / 3600 * cJob.RunTime) + PrismSettings.UserSettings.FactoryInstallCost, 2, MidpointRounding.AwayFromZero)
                    Dim unitcosts As Double = Math.Round(totalcosts / (cJob.Runs * product.PortionSize), 2, MidpointRounding.AwayFromZero)
                    Dim value As Double = prices(cJob.CurrentBlueprint.ProductId)
                    Dim profit As Double = value - unitcosts
                    Dim rate As Double = (profit * product.PortionSize) / ((cJob.RunTime / cJob.Runs) / 3600)
                    Dim profitMargin As Double = (profit / value * 100)
                    newJob.Cells.Add(New Cell(profit.ToString("N2")))
                    newJob.Cells.Add(New Cell(rate.ToString("N2")))
                    newJob.Cells.Add(New Cell(profitMargin.ToString("N2")))
                Else
                    newJob.Cells.Add(New Cell(0.ToString("N2")))
                    newJob.Cells.Add(New Cell(0.ToString("N2")))
                    newJob.Cells.Add(New Cell(0.ToString("N2")))
                End If
                adtProdJobs.Nodes.Add(newJob)
            Next
            AdvTreeSorter.Sort(adtProdJobs, 1, True, True)
            adtProdJobs.EndUpdate()
        End Sub

        Private Sub UpdateBatchList()
            adtBatches.BeginUpdate()
            adtBatches.Nodes.Clear()
            Dim obsoleteBatches As List(Of String) = New List(Of String)()
            For Each cBatch As BatchJob In BatchJobs.Jobs.Values
                Dim newBatch As New Node
                newBatch.Name = cBatch.BatchName
                newBatch.Text = cBatch.BatchName
				newBatch.Tag = cBatch
                Dim obsoleteJobs As List(Of String) = New List(Of String)()
                For Each jobName As String In cBatch.ProductionJobs
                    If Jobs.JobList.ContainsKey(jobName) Then
                        Dim newJob As New Node
                        newJob.Name = jobName
                        newJob.Text = jobName
                        newBatch.Nodes.Add(newJob)
                    Else
                        obsoleteJobs.Add(jobName)
                    End If
                Next
                For Each jobName As String In obsoleteJobs
                    cBatch.ProductionJobs.Remove(jobName)
                Next
                If newBatch.Nodes.Count > 0 Then
                    adtBatches.Nodes.Add(newBatch)
                Else
                    obsoleteBatches.Add(cBatch.BatchName)
                End If
            Next
            For Each batchName As String In obsoleteBatches
                BatchJobs.Jobs.Remove(batchName)
            Next
            adtBatches.EndUpdate()
        End Sub

        Private Sub adtProdJobs_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles adtProdJobs.SelectionChanged
            Select Case adtProdJobs.SelectedNodes.Count
                Case 0
	                miDeleteProductionJobs.Text = "Delete Job..."
	                miDeleteProductionJobs.Enabled = False
					miAddToBatch.Enabled = False
                    PRPM.BatchJob = Nothing
                    PRPM.ProductionJob = Nothing
                Case 1
	                miDeleteProductionJobs.Text = "Delete Job..."
	                miDeleteProductionJobs.Enabled = True
	                miAddToBatch.Enabled = True
                    ' Create a null batch job to pass to the PR control to negate batch display
                    PRPM.BatchJob = Nothing
                    Dim jobName As String = adtProdJobs.SelectedNodes(0).Name
                    Dim existingJob As Job = Jobs.JobList(jobName)
                    PRPM.ProductionJob = existingJob
                Case Else
	                miDeleteProductionJobs.Text = "Delete Jobs..."
	                miDeleteProductionJobs.Enabled = True
	                miAddToBatch.Enabled = True
                    ' Create a temporary batch job to pass to the PR control
                    Dim tempBatch As New BatchJob
                    tempBatch.BatchName = "Temporary Batch from Production Manager"
                    For Each jobNode As Node In adtProdJobs.SelectedNodes
                        tempBatch.ProductionJobs.Add(jobNode.Name)
                    Next
                    PRPM.BatchJob = tempBatch
            End Select
        End Sub

        Private Sub adtProdJobs_NodeDoubleClick(ByVal sender As Object, ByVal e As TreeNodeMouseEventArgs) Handles adtProdJobs.NodeDoubleClick
            Dim jobName As String = e.Node.Name
            Dim existingJob As Job = Jobs.JobList(jobName)
            Dim bpCalc As New FrmBPCalculator(existingJob, False)
            bpCalc.Location = New Point(CInt(ParentForm.Left + ((ParentForm.Width - bpCalc.Width) / 2)), CInt(ParentForm.Top + ((ParentForm.Height - bpCalc.Height) / 2)))
            bpCalc.Show()
        End Sub

        Private Sub adtProdJobs_ColumnHeaderMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles adtProdJobs.ColumnHeaderMouseDown
            Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
            AdvTreeSorter.Sort(ch, True, False)
        End Sub

        Private Sub btnDeleteJob_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miDeleteProductionJobs.Click
            Dim reply As DialogResult = MessageBox.Show("Are you sure you want to delete the selected jobs?", "Confirm Job Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If reply = DialogResult.No Then
                Exit Sub
            Else
                For Each delNode As Node In adtProdJobs.SelectedNodes
                    Jobs.JobList.Remove(delNode.Name)
                Next
                Call UpdateProductionJobList()
                Call UpdateBatchList()
            End If
        End Sub

        Private Sub btnClearAllJobs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClearAllJobs.Click
            Dim reply As DialogResult = MessageBox.Show("This will remove all your jobs. Are you sure you want to delete all jobs?", "Confirm Job Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If reply = DialogResult.No Then
                Exit Sub
            Else
                Jobs.JobList.Clear()
                Call UpdateProductionJobList()
                Call UpdateBatchList()
            End If
        End Sub

        Private Sub btnRefreshJobs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefreshJobs.Click
            ' Cycle through all the jobs and update the job names
            For Each jobName As String In Jobs.JobList.Keys
                Jobs.JobList(jobName).JobName = jobName
            Next
            Call UpdateProductionJobList()
        End Sub

        Private Sub miAddToNewBatch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miAddToNewBatch.Click
            Using newBatchName As New FrmAddBatchJob
                newBatchName.ShowDialog()
                If newBatchName.DialogResult = DialogResult.OK Then
                    Dim newBatch As New BatchJob
                    newBatch.BatchName = newBatchName.JobName
                    For Each jobNode As Node In adtProdJobs.SelectedNodes
                        newBatch.ProductionJobs.Add(jobNode.Name)
                    Next
                    BatchJobs.Jobs.Add(newBatch.BatchName, newBatch)
                End If
            End Using
            PrismEvents.StartUpdateBatchJobs()
        End Sub

		Private Sub miAddToBatch_DropDownOpening(sender As Object, e As EventArgs) Handles miAddToBatch.DropDownOpening
			ClearBatchListOnAddToBatchMenu()
			For Each batchJob As KeyValuePair(Of String,BatchJob) In BatchJobs.Jobs
				Dim menuItem As ToolStripDropDownItem = new ToolStripMenuItem(batchJob.Key)
				AddHandler menuItem.Click, AddressOf AddSelectedJobsToBatch
				menuItem.Tag = batchJob.Value
				miAddToBatch.DropDownItems.Add(menuItem)
			Next
		End Sub

		Private Sub ClearBatchListOnAddToBatchMenu()
			miAddToBatch.DropDownItems.Clear()
			miAddToBatch.DropDownItems.Add(miAddToNewBatch)
		End Sub

		Private Sub AddSelectedJobsToBatch(sender As Object, e As EventArgs)
			Dim menuItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
			Dim batchJob As BatchJob = CType(menuItem.Tag, BatchJob)

			For Each jobNode As Node In adtProdJobs.SelectedNodes
				batchJob.ProductionJobs.Add(jobNode.Name)
			Next

			PrismEvents.StartUpdateBatchJobs()
		End Sub

#End Region

#Region "Batch Manager Routines"

        Private Sub adtBatches_NodeClick(ByVal sender As Object, ByVal e As TreeNodeMouseEventArgs) Handles adtBatches.NodeClick
            If e.Node.Nodes.Count > 0 Then
                ' This is a batch name
                Dim batchName As String = e.Node.Name
                Dim existingBatch As BatchJob = BatchJobs.Jobs(batchName)
                PRPM.BatchJob = existingBatch
                PRPM.tcResources.SelectedTab = PRPM.tiBatchResources
            Else
                ' This is a job name
                Dim jobName As String = e.Node.Name
                Dim existingJob As Job = Jobs.JobList(jobName)
                PRPM.ProductionJob = existingJob
                PRPM.tcResources.SelectedTab = PRPM.tiProductionResources
            End If
        End Sub

        Private Sub adtBatches_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles adtBatches.SelectionChanged
            Select Case adtProdJobs.SelectedNodes.Count
                Case 0
                    ' Do nothing
                Case 1
                    If PRPM.BatchJob IsNot Nothing Then
                        PRPM.BatchJob = Nothing
                    End If
                Case Is > 1
                    ' Create a temporary batch job to pass to the PR control
                    Dim tempBatch As New BatchJob
                    tempBatch.BatchName = "Temporary Batch from Batch Manager"
                    For Each jobNode As Node In adtProdJobs.SelectedNodes
                        tempBatch.ProductionJobs.Add(jobNode.Name)
                    Next
                    PRPM.BatchJob = tempBatch
            End Select

	        Dim selectedBatchesCount = GetSelectedBatches().Count
	        miDeleteBatches.Enabled = selectedBatchesCount > 0
			miDeleteBatches.Text = If (selectedBatchesCount > 1, "Delete Batches...", "Delete Batch...")

	        Dim selectedBatchJobsCount = GetSelectedBatchJobs().Count
			miDeleteBatchJobs.Enabled = selectedBatchJobsCount > 0
	        miDeleteBatchJobs.Text = If (selectedBatchJobsCount > 1, "Delete Jobs...", "Delete Job...")
		End Sub

        Private Sub btnClearBatches_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClearBatches.Click
            Dim reply As DialogResult = MessageBox.Show("This will remove all your batches. Are you sure you want to delete all batches?", "Confirm Batch Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If reply = DialogResult.No Then
                Exit Sub
            Else
                BatchJobs.Jobs.Clear()
                Call UpdateBatchList()
            End If
        End Sub
        Private Sub miDeleteBatches_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miDeleteBatches.Click
            Dim reply As DialogResult = MessageBox.Show("This will remove selected batches. Are you sure you want to delete them?", "Confirm Batch Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If reply = DialogResult.No Then
                Exit Sub
            End If

	        For Each selectedBatch As Node In GetSelectedBatches()
				BatchJobs.Jobs.Remove(selectedBatch.Name)
	        Next

            Call UpdateBatchList()
        End Sub

		Private Sub miDeleteBatchJobs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miDeleteBatchJobs.Click
			Dim reply As DialogResult = MessageBox.Show("This will remove selected batch jobs. Are you sure you want to delete them?", "Confirm Batch Jobs Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
			If reply = DialogResult.No Then
				Exit Sub
			End If

			For Each selectedBatchJob As Node In GetSelectedBatchJobs()
				Dim parentBatch = CType(selectedBatchJob.Parent.Tag, BatchJob)
				parentBatch.ProductionJobs.Remove(selectedBatchJob.Name)
			Next

			Call UpdateBatchList()
		End Sub

		Private Function GetSelectedBatchJobs() As List(Of Node)

			Dim selectedBatchJobs = New List(Of Node)
			For Each node As Node In adtBatches.SelectedNodes
				If node.Parent IsNot Nothing Then
					selectedBatchJobs.Add(node)
				End If
			Next
			Return selectedBatchJobs
		End Function

		Private Function GetSelectedBatches() As List(Of Node)

			Dim selectedBatches = New List(Of Node)
			For Each node As Node In adtBatches.SelectedNodes
				If node.Parent Is Nothing Then
					selectedBatches.Add(node)
				End If
			Next
			Return selectedBatches
		End Function

#End Region

#Region "Invention Manager Routines"

        Private Sub UpdateInventionJobList()
            adtInventionJobs.BeginUpdate()
            adtInventionJobs.Nodes.Clear()
            Dim priceTask As Task(Of Dictionary(Of Integer, Double)) = DataFunctions.GetMarketPrices(From r In Jobs.JobList.Values Where r.HasInventionJob = True Where r.InventionJob.InventedBpid <> 0 Select r.InventionJob.CalculateInventedBPC.ProductId)
            priceTask.Wait()
            Dim prices As Dictionary(Of Integer, Double) = priceTask.Result
            For Each cJob As Job In Jobs.JobList.Values
                ' Check for the Invention Manager Flag
                If cJob.HasInventionJob = True Then
                    Dim newJob As New Node
                    newJob.Name = cJob.JobName
                    newJob.Text = cJob.JobName
                    If cJob.InventionJob.InventedBpid <> 0 Then

                        ' Calculate costs
                        Dim invCost As InventionCost = cJob.InventionJob.CalculateInventionCost
                        Dim ibp As OwnedBlueprint = cJob.InventionJob.CalculateInventedBPC
                        Dim batchQty As Integer = StaticData.Types(ibp.ProductId).PortionSize
                        Dim inventionChance As Double = cJob.InventionJob.CalculateInventionChance
                        Dim inventionAttempts As Double = Math.Max(Math.Round(100 / inventionChance, 4, MidpointRounding.AwayFromZero), 1)
                        Dim inventionSuccessCost As Double = inventionAttempts * invCost.TotalCost

                        ' Calculate Production Cost of invented item
                        Dim factoryCost As Double = Math.Round((PrismSettings.UserSettings.FactoryRunningCost / 3600 * cJob.InventionJob.ProductionJob.RunTime) + PrismSettings.UserSettings.FactoryInstallCost, 2, MidpointRounding.AwayFromZero)
                        Dim avgCost As Double = (Math.Round(inventionSuccessCost / ibp.Runs, 2, MidpointRounding.AwayFromZero) + cJob.InventionJob.ProductionJob.Cost + factoryCost) / batchQty
                        Dim salesPrice As Double = prices(ibp.ProductId)
                        Dim unitProfit As Double = salesPrice - avgCost
                        Dim profitMargin As Double = unitProfit / salesPrice * 100

                        newJob.Cells.Add(New Cell(StaticData.Types(cJob.InventionJob.InventedBpid).Name))
                        newJob.Cells.Add(New Cell(inventionChance.ToString("N2")))
                        newJob.Cells.Add(New Cell(inventionSuccessCost.ToString("N2")))
                        newJob.Cells.Add(New Cell(avgCost.ToString("N2")))
                        newJob.Cells.Add(New Cell(salesPrice.ToString("N2")))
                        newJob.Cells.Add(New Cell(unitProfit.ToString("N2")))
                        newJob.Cells.Add(New Cell(profitMargin.ToString("N2")))
                    Else
                        newJob.Cells.Add(New Cell("n/a"))
                        newJob.Cells.Add(New Cell(0.ToString("N2")))
                        newJob.Cells.Add(New Cell(0.ToString("N2")))
                        newJob.Cells.Add(New Cell(0.ToString("N2")))
                        newJob.Cells.Add(New Cell(0.ToString("N2")))
                        newJob.Cells.Add(New Cell(0.ToString("N2")))
                        newJob.Cells.Add(New Cell(0.ToString("N2")))
                    End If
                    adtInventionJobs.Nodes.Add(newJob)
                End If
            Next
            AdvTreeSorter.Sort(adtInventionJobs, 1, True, True)
            adtInventionJobs.EndUpdate()
        End Sub

        Private Sub adtInventionJobs_NodeDoubleClick(ByVal sender As Object, ByVal e As TreeNodeMouseEventArgs) Handles adtInventionJobs.NodeDoubleClick
            Dim jobName As String = e.Node.Name
            If Jobs.JobList.ContainsKey(jobName) Then
                Dim existingJob As Job = Jobs.JobList(jobName)
                Dim bpCalc As New FrmBPCalculator(existingJob, True)
                bpCalc.Location = New Point(CInt(ParentForm.Left + ((ParentForm.Width - bpCalc.Width) / 2)), CInt(ParentForm.Top + ((ParentForm.Height - bpCalc.Height) / 2)))
                bpCalc.Show()
            End If
        End Sub

        Private Sub adtInventionJobs_ColumnHeaderMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles adtInventionJobs.ColumnHeaderMouseDown
            Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
            AdvTreeSorter.Sort(ch, True, False)
        End Sub

#End Region

#Region "Report Routines"

        Private Sub InitialiseReports()

            ' Update the report combobox with the reports

            cboReport.BeginUpdate()
            cboReport.Items.Clear()

            ' Add the report types here in 
            cboReport.Items.Add("Income Report")
            cboReport.Items.Add("Expenditure Report")
            cboReport.Items.Add("Income & Expenditure Report")
            cboReport.Items.Add("Corporation Tax Report")
            cboReport.Items.Add("Transaction Sales Report")
            cboReport.Items.Add("Transaction Purchases Report")
            cboReport.Items.Add("Transaction Trading Report")
            cboReport.Items.Add("Journal Income Type Analysis")
            cboReport.Items.Add("Journal Expenditure Type Analysis")

            ' Finalise the report combobox update
            cboReport.EndUpdate()

            ' Set the dates
            dtiReportEndDate.Value = Now
            dtiReportStartDate.Value = Now.AddMonths(-1)

            cboReportOwners.DropDownControl = New PrismSelectionControl(PrismSelectionType.JournalOwnersAll, True, cboReportOwners)

            ' Update the ref types box
            cboReportJournalType.DropDownControl = New PrismSelectionControl(PrismSelectionType.JournalRefTypes, False, cboReportJournalType)

        End Sub

        Private Sub cboReport_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboReport.SelectedIndexChanged

            ' Set the report name
            Dim reportName As String = cboReport.SelectedItem.ToString

            Select Case reportName

                Case "Income Report"
                    If CType(cboReportOwners.DropDownControl, PrismSelectionControl).ListType <> PrismSelectionType.JournalOwnersAll Then
                        cboReportOwners.DropDownControl = New PrismSelectionControl(PrismSelectionType.JournalOwnersAll, True, cboReportOwners)
                        cboReportOwners.Text = ""
                    End If

                Case "Expenditure Report"
                    If CType(cboReportOwners.DropDownControl, PrismSelectionControl).ListType <> PrismSelectionType.JournalOwnersAll Then
                        cboReportOwners.DropDownControl = New PrismSelectionControl(PrismSelectionType.JournalOwnersAll, True, cboReportOwners)
                        cboReportOwners.Text = ""
                    End If

                Case "Income & Expenditure Report"
                    If CType(cboReportOwners.DropDownControl, PrismSelectionControl).ListType <> PrismSelectionType.JournalOwnersAll Then
                        cboReportOwners.DropDownControl = New PrismSelectionControl(PrismSelectionType.JournalOwnersAll, True, cboReportOwners)
                        cboReportOwners.Text = ""
                    End If

                Case "Corporation Tax Report"
                    If CType(cboReportOwners.DropDownControl, PrismSelectionControl).ListType <> PrismSelectionType.JournalOwnersCorps Then
                        cboReportOwners.DropDownControl = New PrismSelectionControl(PrismSelectionType.JournalOwnersCorps, True, cboReportOwners)
                        cboReportOwners.Text = ""
                    End If

                Case "Transaction Sales Report"
                    If CType(cboReportOwners.DropDownControl, PrismSelectionControl).ListType <> PrismSelectionType.TransactionOwnersAll Then
                        cboReportOwners.DropDownControl = New PrismSelectionControl(PrismSelectionType.TransactionOwnersAll, True, cboReportOwners)
                        cboReportOwners.Text = ""
                    End If

                Case "Transaction Purchases Report"
                    If CType(cboReportOwners.DropDownControl, PrismSelectionControl).ListType <> PrismSelectionType.TransactionOwnersAll Then
                        cboReportOwners.DropDownControl = New PrismSelectionControl(PrismSelectionType.TransactionOwnersAll, True, cboReportOwners)
                        cboReportOwners.Text = ""
                    End If

                Case "Transaction Trading Report"
                    If CType(cboReportOwners.DropDownControl, PrismSelectionControl).ListType <> PrismSelectionType.TransactionOwnersAll Then
                        cboReportOwners.DropDownControl = New PrismSelectionControl(PrismSelectionType.TransactionOwnersAll, True, cboReportOwners)
                        cboReportOwners.Text = ""
                    End If

                Case "Journal Income Type Analysis"
                    If CType(cboReportOwners.DropDownControl, PrismSelectionControl).ListType <> PrismSelectionType.JournalOwnersAll Then
                        cboReportOwners.DropDownControl = New PrismSelectionControl(PrismSelectionType.JournalOwnersAll, True, cboReportOwners)
                        cboReportOwners.Text = ""
                    End If

                Case "Journal Expenditure Type Analysis"
                    If CType(cboReportOwners.DropDownControl, PrismSelectionControl).ListType <> PrismSelectionType.JournalOwnersAll Then
                        cboReportOwners.DropDownControl = New PrismSelectionControl(PrismSelectionType.JournalOwnersAll, True, cboReportOwners)
                        cboReportOwners.Text = ""
                    End If

            End Select

        End Sub

        Private Sub btnGenerateReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerateReport.Click

            ' Check for selected items
            If CType(cboReportOwners.DropDownControl, PrismSelectionControl).lvwItems.CheckedItems.Count = 0 Then
                MessageBox.Show("You must select at least one owner before generating a report!", "Report Owner Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ' Check for selected journal type
            ' Set the report name
            Dim reportName As String = cboReport.SelectedItem.ToString
            Select Case reportName
                Case "Journal Income Type Analysis", "Journal Expenditure Type Analysis"
                    If CType(cboReportJournalType.DropDownControl, PrismSelectionControl).lvwItems.CheckedItems.Count = 0 Then
                        MessageBox.Show("You must select a journal type before generating this type of report!", "Report Journal Type Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
            End Select

            Call GenerateReport()

        End Sub

        Private Sub GenerateReport()

            If cboReport.SelectedItem IsNot Nothing Then

                ' Set the start and end date
                Dim startDate As Date = New Date(dtiReportStartDate.Value.Year, dtiReportStartDate.Value.Month, dtiReportStartDate.Value.Day, 0, 0, 0)
                Dim endDate As Date = New Date(dtiReportEndDate.Value.Year, dtiReportEndDate.Value.Month, dtiReportEndDate.Value.Day, 0, 0, 0)
                endDate = endDate.AddDays(1) ' Add 1 to the date so we can check everything less than it

                ' Set the report name
                Dim reportName As String = cboReport.SelectedItem.ToString

                ' Set the report title
                Dim reportTitle As String = reportName & "<br />from " & startDate.ToLongDateString & " to " & endDate.AddDays(-1).ToLongDateString

                ' Create the report title
                Dim strHtml As String = PrismReports.HTMLHeader("Prism Report - " & reportName, reportTitle)

                ' Build the Owners List
                Dim ownerNames As New List(Of String)
                For Each lvi As ListViewItem In CType(cboReportOwners.DropDownControl, PrismSelectionControl).lvwItems.CheckedItems
                    ownerNames.Add(lvi.Name)
                Next

                ' Choose what report is selected and get the information
                Select Case reportName

                    Case "Income Report"
                        Dim reportData As DataSet = PrismReports.GetJournalReportData(startDate, endDate, ownerNames)
                        Dim result As ReportResult = PrismReports.GenerateIncomeReportBodyHTML(PrismReports.GenerateIncomeAnalysis(reportData))
                        strHtml &= result.HTML

                    Case "Expenditure Report"
                        Dim reportData As DataSet = PrismReports.GetJournalReportData(startDate, endDate, ownerNames)
                        Dim result As ReportResult = PrismReports.GenerateExpenseReportBodyHTML(PrismReports.GenerateExpenseAnalysis(reportData))
                        strHtml &= result.HTML

                    Case "Income & Expenditure Report"
                        Dim reportData As DataSet = PrismReports.GetJournalReportData(startDate, endDate, ownerNames)
                        Dim result As ReportResult = PrismReports.GenerateIncomeReportBodyHTML(PrismReports.GenerateIncomeAnalysis(reportData))
                        strHtml &= result.HTML
                        Dim incomeTotal As Double = CDbl(result.Values("Total Income"))
                        Dim eResult As ReportResult = PrismReports.GenerateExpenseReportBodyHTML(PrismReports.GenerateExpenseAnalysis(reportData))
                        strHtml &= eResult.HTML
                        Dim expenditureTotal As Double = CDbl(eResult.Values("Total Expenditure"))
                        Dim cResult As ReportResult = PrismReports.GenerateCashFlowReportBodyHTML(incomeTotal, expenditureTotal)
                        strHtml &= cResult.HTML
                        Dim mResult As ReportResult = PrismReports.GenerateMovementReportBodyHTML(PrismReports.GenerateOwnerMovements(reportData))
                        strHtml &= mResult.HTML

                    Case "Corporation Tax Report"
                        Dim reportData As DataSet = PrismReports.GetJournalReportData(startDate, endDate, ownerNames)
                        Dim result As ReportResult = PrismReports.GenerateCorpTaxReportBodyHTML(PrismReports.GenerateCorpTaxAnalysis(reportData))
                        strHtml &= result.HTML

                    Case "Transaction Sales Report"
                        Dim reportData As DataSet = PrismReports.GetTransactionReportData(startDate, endDate, ownerNames)
                        Dim result As ReportResult = PrismReports.GenerateSalesReportBodyHTML(PrismReports.GenerateTransactionSalesAnalysis(reportData))
                        strHtml &= result.HTML

                    Case "Transaction Purchases Report"
                        Dim reportData As DataSet = PrismReports.GetTransactionReportData(startDate, endDate, ownerNames)
                        Dim result As ReportResult = PrismReports.GeneratePurchasesReportBodyHTML(PrismReports.GenerateTransactionPurchasesAnalysis(reportData))
                        strHtml &= result.HTML

                    Case "Transaction Trading Report"
                        Dim reportData As DataSet = PrismReports.GetTransactionReportData(startDate, endDate, ownerNames)
                        Dim result As ReportResult = PrismReports.GenerateTradingProfitReportBodyHTML(PrismReports.GenerateTransactionProfitAnalysis(reportData))
                        strHtml &= result.HTML

                    Case "Journal Income Type Analysis"
                        ' Get the RefTypeID
                        Dim refTypeId As String = CType(cboReportJournalType.DropDownControl, PrismSelectionControl).lvwItems.CheckedItems(0).Name
                        Dim reportData As DataSet = PrismReports.GetJournalReportData(startDate, endDate, ownerNames)
                        Dim result As ReportResult
                        Select Case refTypeId
                            Case "37"
                                result = PrismReports.GenerateJournalTypeIncomeReportBodyHTML(refTypeId, PrismReports.GenerateJournalTypeIncomeAnalysis(reportData, refTypeId, JournalKeyTypes.OwnerName2))
                            Case Else
                                result = PrismReports.GenerateJournalTypeIncomeReportBodyHTML(refTypeId, PrismReports.GenerateJournalTypeIncomeAnalysis(reportData, refTypeId, JournalKeyTypes.OwnerName1))
                        End Select
                        strHtml &= result.HTML

                    Case "Journal Expenditure Type Analysis"
                        ' Get the RefTypeID
                        Dim refTypeId As String = CType(cboReportJournalType.DropDownControl, PrismSelectionControl).lvwItems.CheckedItems(0).Name
                        Dim reportData As DataSet = PrismReports.GetJournalReportData(startDate, endDate, ownerNames)
                        Dim result As ReportResult
                        Select Case refTypeId
                            Case "37", "13"
                                result = PrismReports.GenerateJournalTypeExpenditureReportBodyHTML(refTypeId, PrismReports.GenerateJournalTypeExpenditureAnalysis(reportData, refTypeId, JournalKeyTypes.OwnerName2))
                            Case Else
                                result = PrismReports.GenerateJournalTypeExpenditureReportBodyHTML(refTypeId, PrismReports.GenerateJournalTypeExpenditureAnalysis(reportData, refTypeId, JournalKeyTypes.OwnerName1))
                        End Select
                        strHtml &= result.HTML

                End Select

                ' Save and navigate to the report
                Dim reportFileName As String = Path.Combine(HQ.ReportFolder, reportName.Replace(" ", "") & ".html")
                Dim sw As StreamWriter = New StreamWriter(reportFileName)
                sw.Write(strHtml)
                sw.Flush()
                sw.Close()
                wbReport.Navigate(reportFileName)

            Else
                MessageBox.Show("You must select a report type before generating a report!", "Report Type Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Sub


#End Region

#Region "Rig Builder Routines"
        Private Sub GetSalvage()

            Dim pOwner As PrismOwner
            _salvageList.Clear()

            For Each cOwner As ListViewItem In PSCRigOwners.ItemList.CheckedItems

                If PlugInData.PrismOwners.ContainsKey(cOwner.Text) = True Then
                    pOwner = PlugInData.PrismOwners(cOwner.Text)
                    Dim ownerAccount As EveHQAccount = PlugInData.GetAccountForCorpOwner(pOwner, CorpRepType.Assets)
                    Dim ownerId As String = PlugInData.GetAccountOwnerIDForCorpOwner(pOwner, CorpRepType.Assets)

                    If ownerAccount IsNot Nothing Then
                        Dim assetData As EveServiceResponse(Of IEnumerable(Of NewEveApi.Entities.AssetItem))
                        If pOwner.IsCorp = True Then
                            assetData = HQ.ApiProvider.Corporation.AssetList(ownerAccount.UserID, ownerAccount.APIKey, ownerId.ToInt32())
                        Else
                            assetData = HQ.ApiProvider.Character.AssetList(ownerAccount.UserID, ownerAccount.APIKey, ownerId.ToInt32())
                        End If

                        If assetData.IsSuccess Then
                            Dim locList = assetData.ResultData
                            If locList.Count > 0 Then
                                For Each item In locList
                                    Dim typeId As Integer = item.TypeId
                                    If StaticData.Types.ContainsKey(typeId) = True Then
                                        Dim groupId As String = StaticData.Types(typeId).Group.ToString
                                        If CLng(groupId) = 754 Then

                                            Dim quantity As Long = item.Quantity
                                            If _salvageList.ContainsKey(typeId) = False Then
                                                _salvageList.Add(typeId, quantity)
                                            Else
                                                _salvageList.Item(typeId) = CLng(_salvageList.Item(typeId)) + quantity
                                            End If
                                        End If
                                    End If

                                    ' Check if this row has child nodes and repeat
                                    If item.Contents IsNot Nothing Then
                                        If item.Contents.Any() Then
                                            Call GetSalvageNode(_salvageList, item)
                                        End If
                                    End If
                                Next
                            End If
                        End If
                    End If
                End If
            Next
        End Sub
        Private Sub GetSalvageNode(ByVal salvageList As SortedList(Of Integer, Long), ByVal parentItem As NewEveApi.Entities.AssetItem)
            Dim subLocList = parentItem.Contents
            For Each item In subLocList
                Try
                    Dim itemId As Integer = item.TypeId
                    If StaticData.Types.ContainsKey(itemId) = True Then
                        Dim groupId As String = StaticData.Types(itemId).Group.ToString
                        If CLng(groupId) = 754 Then
                            Dim quantity As Long = item.Quantity
                            If salvageList.ContainsKey(itemId) = False Then
                                salvageList.Add(itemId, quantity)
                            Else
                                salvageList.Item(itemId) = CLng(salvageList.Item(itemId)) + quantity
                            End If
                        End If
                    End If

                    If item.Contents IsNot Nothing Then
                        If item.Contents.Any() Then
                            Call GetSalvageNode(salvageList, item)
                        End If
                    End If

                Catch ex As Exception

                End Try
            Next
        End Sub
        Private Sub PrepareRigData()
            ' Clear the build list
            adtRigBuildList.Nodes.Clear()

            ' Build a Salvage List
            Call GetSalvage()

            Dim bpName As String
            _rigBpData = New SortedList(Of String, SortedList(Of Integer, Long))

            ' Get the items in the group and build the materials
            Dim items As IEnumerable(Of EveType) = StaticData.GetItemsInGroup(787)
            For Each item As EveType In items
                bpName = item.Name.TrimEnd(" Blueprint".ToCharArray)
                _rigBpData.Add(bpName, New SortedList(Of Integer, Long))
                Dim rigBp As EveData.Blueprint = StaticData.Blueprints(item.Id)
                For Each br As EveData.BlueprintResource In rigBp.Resources(1).Values
                    ' Check if the resource is salvage
                    If br.TypeGroup = 754 Then
                        _rigBpData(bpName).Add(br.TypeId, br.Quantity)
                    End If
                Next
            Next

        End Sub
        Private Sub GetBuildList()
            Dim buildableBp As Boolean
            Dim material As Integer
            Dim minQuantity As Double
            Dim buildCost As Double
            Dim rigCost As Double
            adtRigs.BeginUpdate()
            adtRigs.Nodes.Clear()
            Dim bpCostsTask As Task(Of Dictionary(Of Integer, Double)) = DataFunctions.GetMarketPrices(From blueprint In _rigBpData.Keys Select StaticData.TypeNames(CStr(blueprint)))
            bpCostsTask.Wait()
            Dim bpCosts As Dictionary(Of Integer, Double) = bpCostsTask.Result
            For Each blueprint As String In _rigBpData.Keys
                If StaticData.TypeNames.ContainsKey(blueprint) = True Then
                    buildableBp = True
                    minQuantity = 1.0E+99
                    buildCost = 0
                    ' Fetch the build requirements
                    _rigBuildData = _rigBpData(blueprint)
                    ' Go through the requirements and see if have sufficient materials
                    For Each material In _rigBuildData.Keys
                        If _salvageList.ContainsKey(material) = True Then
                            ' Check quantity
                            If CDbl(_salvageList(material)) > CDbl(_rigBuildData(material)) Then
                                ' We have enough so let's calculate the quantity we can use
                                minQuantity = Math.Min(minQuantity, (CDbl(_salvageList(material)) / CDbl(_rigBuildData(material))))
                            Else
                                ' We are lacking
                                buildableBp = False
                                Exit For
                            End If
                        Else
                            buildableBp = False
                            Exit For
                        End If
                    Next
                    ' Find the results
                    If buildableBp = True Then
                        ' Caluclate the build cost
                        Dim costTask As Task(Of Dictionary(Of Integer, Double)) = DataFunctions.GetMarketPrices(_rigBuildData.Keys)
                        costTask.Wait()
                        Dim costs As Dictionary(Of Integer, Double) = costTask.Result
                        For Each material In _rigBuildData.Keys
                            ' Get price
                            buildCost += CInt(_rigBuildData(material)) * costs(material)
                        Next
                        rigCost = bpCosts(StaticData.TypeNames(blueprint))
                        Dim lviBp2 As New Node
                        lviBp2.Text = blueprint
                        Dim qty As Integer = CInt(Int(minQuantity))
                        lviBp2.Cells.Add(New Cell(qty.ToString("N0")))
                        lviBp2.Cells.Add(New Cell(rigCost.ToString("N2")))
                        lviBp2.Cells.Add(New Cell(buildCost.ToString("N2")))
                        lviBp2.Cells.Add(New Cell((rigCost - buildCost).ToString("N2")))
                        lviBp2.Cells.Add(New Cell((qty * rigCost).ToString("N2")))
                        lviBp2.Cells.Add(New Cell((qty * buildCost).ToString("N2")))
                        lviBp2.Cells.Add(New Cell((qty * (rigCost - buildCost)).ToString("N2")))
                        If qty = 0 Or rigCost = 0 Then
                            lviBp2.Cells.Add(New Cell(CInt(0).ToString("N2")))
                        Else
                            lviBp2.Cells.Add(New Cell((qty * (rigCost - buildCost) / (qty * rigCost) * 100).ToString("N2")))
                        End If
                        adtRigs.Nodes.Add(lviBp2)
                    End If
                End If
            Next
            AdvTreeSorter.Sort(adtRigs, 1, True, True)
            adtRigs.EndUpdate()
        End Sub
        Private Sub adtRigs_NodeDoubleClick(ByVal sender As Object, ByVal e As TreeNodeMouseEventArgs) Handles adtRigs.NodeDoubleClick
            Call AddRigToBuildList(e.Node)
            Call GetBuildList()
            Call CalculateRigBuildInfo()
        End Sub
        Private Sub adtRigBuildList_NodeDoubleClick(ByVal sender As Object, ByVal e As TreeNodeMouseEventArgs) Handles adtRigBuildList.NodeDoubleClick
            Call RemoveRigFromBuildList(e.Node)
            Call GetBuildList()
            Call CalculateRigBuildInfo()
        End Sub
        Private Sub AddRigToBuildList(ByVal currentRig As Node)
            Dim newRig As New Node(currentRig.Text)
            ' Add the selected rig to the build list
            adtRigBuildList.Nodes.Add(newRig)
            ' Copy details
            For subI As Integer = 1 To currentRig.Cells.Count - 1
                newRig.Cells.Add(New Cell(currentRig.Cells(subI).Text))
            Next
            'Get the salvage used by the rig and reduce the main list
            Dim rigSalvageList As SortedList(Of Integer, Long) = _rigBpData(currentRig.Text)
            For Each salvage As Integer In rigSalvageList.Keys
                _salvageList(salvage) = CInt(_salvageList(salvage)) - (CInt(rigSalvageList(salvage)) * CInt(currentRig.Cells(1).Text))
            Next
        End Sub
        Private Sub RemoveRigFromBuildList(ByVal currentRig As Node)
            ' Remove the selected rig to the build list
            adtRigBuildList.Nodes.Remove(currentRig)
            ' Get the salvage used by the rig and reduce the main list
            Dim rigSalvageList As SortedList(Of Integer, Long) = _rigBpData(currentRig.Text)
            For Each salvage As Integer In rigSalvageList.Keys
                _salvageList(salvage) = CInt(_salvageList(salvage)) + (CInt(rigSalvageList(salvage)) * CInt(currentRig.Cells(1).Text))
            Next
        End Sub
        Private Sub chkRigSaleprice_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkRigSalePrice.CheckedChanged
            If chkRigSalePrice.Checked = True Then
                btnAutoRig.Tag = 3
            End If
        End Sub
        Private Sub chkRigProfit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkRigProfit.CheckedChanged
            If chkRigProfit.Checked = True Then
                btnAutoRig.Tag = 5
            End If
        End Sub
        Private Sub chkRigMargin_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkRigMargin.CheckedChanged
            If chkRigMargin.Checked = True Then
                btnAutoRig.Tag = 9
            End If
        End Sub
        Private Sub chkTotalSalePrice_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkTotalSalePrice.CheckedChanged
            If chkTotalSalePrice.Checked = True Then
                btnAutoRig.Tag = 6
            End If
        End Sub
        Private Sub chkTotalProfit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkTotalProfit.CheckedChanged
            If chkTotalProfit.Checked = True Then
                btnAutoRig.Tag = 8
            End If
        End Sub
        Private Sub CalculateRigBuildInfo()
            Dim totalRsp, totalRp As Double
            For Each rigItem As Node In adtRigBuildList.Nodes
                totalRsp += CDbl(rigItem.Cells(5).Text)
                totalRp += CDbl(rigItem.Cells(7).Text)
            Next
            lblTotalRigSalePrice.Text = "Total Rig Sale Price: " & totalRsp.ToString("N2")
            lblTotalRigProfit.Text = "Total Rig Profit: " & totalRp.ToString("N2")
            lblTotalRigMargin.Text = "Margin: " & (totalRp / totalRsp * 100).ToString("N2") & "%"
        End Sub
        Private Sub btnAutoRig_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAutoRig.Click
            ' Get the rig and salvage info
            Call PrepareRigData()
            ' Get the list of available rigs
            Call GetBuildList()
            Do While adtRigs.Nodes.Count > 0
                AdvTreeSorter.Sort(adtRigs, New AdvTreeSortResult(CInt(btnAutoRig.Tag), AdvTreeSortOrder.Descending), False)
                AddRigToBuildList(adtRigs.Nodes(0))
                Call GetBuildList()
            Loop
            AdvTreeSorter.Sort(adtRigBuildList, New AdvTreeSortResult(CInt(btnAutoRig.Tag), AdvTreeSortOrder.Descending), False)
            Call CalculateRigBuildInfo()
        End Sub
        Private Sub btnBuildRigs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuildRigs.Click

            ' Get the rig and salvage info
            Call PrepareRigData()

            ' Get the list of available rigs
            Call GetBuildList()
        End Sub
        Private Sub btnExportRigList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportRigList.Click
            Call GenerateCsvFileFromClv(PSCRigOwners.cboHost.Text, "Rig List", adtRigs)
        End Sub
        Private Sub btnExportRigBuildList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportRigBuildList.Click
            Call GenerateCsvFileFromClv(PSCRigOwners.cboHost.Text, "Rig Build List", adtRigBuildList)
        End Sub
        Private Sub adtRigs_ColumnHeaderMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles adtRigs.ColumnHeaderMouseDown
            Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
            AdvTreeSorter.Sort(ch, True, False)
        End Sub
        Private Sub adtRigBuildList_ColumnHeaderMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles adtRigBuildList.ColumnHeaderMouseDown
            Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
            AdvTreeSorter.Sort(ch, True, False)
        End Sub
#End Region

#Region "Invention Results Routines"

        Private Sub InitialiseInventionResults()
            ' Prepare info
            dtiInventionEndDate.Value = Now
            dtiInventionStartDate.Value = Now.AddMonths(-1)
            cboInventionInstallers.DropDownControl = New PrismSelectionControl(PrismSelectionType.InventionInstallers, True, cboInventionInstallers)
            cboInventionItems.DropDownControl = New PrismSelectionControl(PrismSelectionType.InventionItems, True, cboInventionItems)
        End Sub

        Private Sub DisplayInventionResults()
            Dim strSql As String = "SELECT * FROM inventionResults"
            strSql &= " WHERE inventionResults.resultDate >= '" & dtiInventionStartDate.Value.ToString(PrismTimeFormat, _culture) & "' AND inventionResults.resultDate <= '" & dtiInventionEndDate.Value.ToString(PrismTimeFormat, _culture) & "'"

            ' Build the Owners List
            If cboInventionInstallers.Text <> "<All>" Then
                Dim ownerList As New StringBuilder
                For Each lvi As ListViewItem In CType(cboInventionInstallers.DropDownControl, PrismSelectionControl).lvwItems.CheckedItems
                    ownerList.Append(", '" & lvi.Name.Replace("'", "''") & "'")
                Next
                If ownerList.Length > 2 Then
                    ownerList.Remove(0, 2)
                End If
                ' Default to None
                strSql &= " AND inventionResults.installerName IN (" & ownerList.ToString & ")"
            End If

            ' Filter item type
            If cboInventionItems.Text <> "All" Then
                ' Build a ref type list
                Dim itemTypeList As New StringBuilder
                For Each lvi As ListViewItem In CType(cboInventionItems.DropDownControl, PrismSelectionControl).lvwItems.CheckedItems
                    itemTypeList.Append(", '" & lvi.Name.Replace("'", "''") & "'")
                Next
                If itemTypeList.Length > 2 Then
                    itemTypeList.Remove(0, 2)
                    strSql &= " AND inventionResults.typeName IN (" & itemTypeList.ToString & ")"
                End If
            End If

            ' Order the data
            strSql &= " ORDER BY inventionResults.resultDate ASC;"

            ' Get the data
            Dim jobList As SortedList(Of Long, InventionAPIJob) = InventionAPIJob.ParseInventionJobsFromDB(strSql)

            ' Populate the list
            adtInventionResults.BeginUpdate()
            adtInventionResults.Nodes.Clear()

            If jobList.Count > 0 Then

                For Each job As InventionAPIJob In jobList.Values
                    Dim jobItem As New Node
                    jobItem.Name = job.JobID.ToString
                    jobItem.Text = job.ResultDate.ToString
                    jobItem.Cells.Add(New Cell(job.TypeName))
                    jobItem.Cells.Add(New Cell(job.InstallerName))
                    Select Case job.Result
                        Case 1
                            jobItem.Cells.Add(New Cell("Successful"))
                        Case Else
                            jobItem.Cells.Add(New Cell("Failed"))
                    End Select
                    adtInventionResults.Nodes.Add(jobItem)
                Next
                adtInventionResults.Enabled = True
            Else
                adtInventionResults.Nodes.Add(New Node("No Data Available..."))
                adtInventionResults.Enabled = False
            End If

            adtInventionResults.EndUpdate()

            ' Update the Stats
            Call DisplayInventionStats(jobList)

        End Sub

        Private Sub DisplayInventionStats(ByVal jobList As SortedList(Of Long, InventionAPIJob))

            adtInventionStats.BeginUpdate()
            adtInventionStats.Nodes.Clear()

            ' Clear and add default column
            adtInventionStats.Columns.Clear()
            Dim typeNameCol As New DevComponents.AdvTree.ColumnHeader
            typeNameCol.SortingEnabled = False
            typeNameCol.Name = "TypeName"
            typeNameCol.Text = "Item Type"
            typeNameCol.Width.Absolute = 250
            typeNameCol.DisplayIndex = 1
            adtInventionStats.Columns.Add(typeNameCol)

            ' Get the Invention Stats
            Dim stats As SortedList(Of String, SortedList(Of String, InventionResults)) = InventionAPIJob.CalculateInventionStats(jobList)

            If stats.Count > 0 Then

                ' Add columns and rows based
                Dim colIdx As Integer = 0
                For Each installerName As String In stats.Keys
                    Dim col As New DevComponents.AdvTree.ColumnHeader
                    col.SortingEnabled = False
                    colIdx += 1
                    col.Name = installerName
                    col.Text = installerName
                    col.Width.Absolute = 150
                    col.DisplayIndex = colIdx + 1
                    col.EditorType = eCellEditorType.Custom
                    adtInventionStats.Columns.Add(col)

                    ' Check for modules
                    For Each typeName As String In stats(installerName).Keys
                        ' Check it doesn't already exist
                        Dim typeNode As Node = adtInventionStats.FindNodeByName(typeName)
                        If typeNode Is Nothing Then
                            ' Node doesn't exist, so add it
                            typeNode = New Node
                            typeNode.Name = typeName
                            typeNode.Text = typeName
                            adtInventionStats.Nodes.Add(typeNode)
                        End If
                    Next
                Next

                ' Add the "Average Column"
                Dim avgCol As New DevComponents.AdvTree.ColumnHeader
                avgCol.SortingEnabled = False
                colIdx += 1
                avgCol.Name = "Item Average"
                avgCol.Text = "Item Average"
                avgCol.Width.Absolute = 150
                avgCol.DisplayIndex = colIdx + 1
                avgCol.EditorType = eCellEditorType.Custom
                adtInventionStats.Columns.Add(avgCol)

                ' Populate the grid with blank cells
                For n As Integer = 0 To adtInventionStats.Nodes.Count - 1
                    For c As Integer = 1 To adtInventionStats.Columns.Count - 1
                        adtInventionStats.Nodes(n).Cells.Add(New Cell("n/a"))
                        adtInventionStats.Nodes(n).Cells(c).Tag = -1
                    Next
                Next

                ' Populate the grid with proper data
                Dim typeAvgs As New SortedList(Of String, InventionResults)
                colIdx = 0
                For Each installerName As String In stats.Keys
                    colIdx += 1

                    ' Check for modules
                    For Each typeName As String In stats(installerName).Keys
                        ' Check it doesn't already exist
                        Dim typeNode As Node = adtInventionStats.FindNodeByName(typeName)
                        If typeNode IsNot Nothing Then
                            ' Get the results
                            Dim results As InventionResults = stats(installerName).Item(typeName)
                            Dim percent As Double = results.Successes / (results.Successes + results.Failures) * 100
                            typeNode.Cells(colIdx).Text = results.Successes.ToString & " / " & (results.Successes + results.Failures).ToString & " (" & percent.ToString("N2") & "%)"
                            typeNode.Cells(colIdx).Tag = percent
                            ' Add results to the averages
                            Dim typeAvg As New InventionResults
                            If typeAvgs.ContainsKey(typeName) = True Then
                                typeAvg = typeAvgs(typeName)
                            Else
                                typeAvgs.Add(typeName, typeAvg)
                            End If
                            typeAvg.Successes += results.Successes
                            typeAvg.Failures += results.Failures
                        End If
                    Next
                Next

                ' Display Averages
                colIdx = adtInventionStats.Columns.Count - 1
                For Each typeNode As Node In adtInventionStats.Nodes
                    If typeAvgs.ContainsKey(typeNode.Name) = True Then
                        Dim results As InventionResults = typeAvgs(typeNode.Name)
                        Dim percent As Double = results.Successes / (results.Successes + results.Failures) * 100
                        typeNode.Cells(colIdx).Text = results.Successes.ToString & " / " & (results.Successes + results.Failures).ToString & " (" & percent.ToString("N2") & "%)"
                        typeNode.Cells(colIdx).Tag = percent
                    End If
                Next

                AdvTreeSorter.Sort(adtInventionStats, 1, False, True)

                adtInventionStats.Enabled = True
            Else
                adtInventionStats.Nodes.Add(New Node("No Data Available..."))
                adtInventionStats.Enabled = False
            End If

            adtInventionStats.EndUpdate()

        End Sub

        Private Sub btnGetResults_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGetResults.Click
            Call DisplayInventionResults()
        End Sub

        Private Sub dtiInventionStartDate_ButtonCustom2Click(ByVal sender As Object, ByVal e As EventArgs) Handles dtiInventionStartDate.ButtonCustom2Click
            dtiInventionStartDate.Value = New Date(dtiInventionStartDate.Value.Year, dtiInventionStartDate.Value.Month, dtiInventionStartDate.Value.Day)
        End Sub

        Private Sub dtiInventionStartDate_ButtonCustomClick(ByVal sender As Object, ByVal e As EventArgs) Handles dtiInventionStartDate.ButtonCustomClick
            dtiInventionStartDate.Value = Now
        End Sub

        Private Sub dtiInventionEndDate_ButtonCustom2Click(ByVal sender As Object, ByVal e As EventArgs) Handles dtiInventionEndDate.ButtonCustom2Click
            dtiInventionEndDate.Value = New Date(dtiInventionEndDate.Value.Year, dtiInventionEndDate.Value.Month, dtiInventionEndDate.Value.Day)
        End Sub

        Private Sub dtiInventionEndDate_ButtonCustomClick(ByVal sender As Object, ByVal e As EventArgs) Handles dtiInventionEndDate.ButtonCustomClick
            dtiInventionEndDate.Value = Now
        End Sub

        Private Sub adtInventionResults_ColumnHeaderMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles adtInventionResults.ColumnHeaderMouseDown
            Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
            AdvTreeSorter.Sort(ch, False, False)
        End Sub

        Private Sub adtInventionStats_ColumnHeaderMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles adtInventionStats.ColumnHeaderMouseDown
            Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
            AdvTreeSorter.Sort(ch, False, False)
        End Sub

#End Region

#Region "Timer Update Methods"

        Private Sub tmrUpdateInfo_Tick(sender As Object, e As EventArgs) Handles tmrUpdateInfo.Tick
            ' Use this to update any information on the form with reasonable frequency

            ' Check if the jobs tab is visible
            If tiJobs.Visible = True Then
                ' Update the jobs screen as appropriate
                Call UpdateIndustryJobTimes()
            End If
        End Sub

		Private Sub miAddToBatch_Click(sender As Object, e As EventArgs) Handles miAddToBatch.Click

		End Sub

#End Region

	End Class
End Namespace