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

Imports System.Globalization
Imports System.ComponentModel
Imports EveHQ.EveApi
Imports EveHQ.Prism.Classes

Imports EveHQ.Core
Imports DevComponents.AdvTree
Imports System.Windows.Forms
Imports System.Xml
Imports EveHQ.EveData
Imports EveHQ.Common.Extensions
Imports System.Threading.Tasks
Imports EveHQ.Core.ItemBrowser
Imports System.Text
Imports System.IO
Imports EveHQ.NewEveApi
Imports EveHQ.Prism.Forms

Namespace Controls

	Public Class PrismAssetsControl

		Dim _hqfShip As New ArrayList
		Private ReadOnly _assetList As New SortedList(Of Long, Classes.AssetItem)
		Private ReadOnly _exportAssetTable As New Dictionary(Of Long, Classes.AssetItem)
		ReadOnly _tempAssetList As New ArrayList
		Dim _totalAssetValue As Double = 0
		Dim _totalAssetCount As Long = 0
		ReadOnly _filters As New ArrayList
		ReadOnly _catFilters As New ArrayList
		ReadOnly _groupFilters As New ArrayList
		Dim _searchText As String = ""
		ReadOnly _divisions As New SortedList
		ReadOnly _walletDivisions As New SortedList
		ReadOnly _charWallets As New SortedList(Of String, Double)
		ReadOnly _corpWallets As New SortedList
		ReadOnly _corpWalletDivisions As New SortedList(Of String, Double)
		Dim _assetCorpMode As Boolean = False
		Private Const IndustryTimeFormat As String = "yyyy-MM-dd HH:mm:ss"
		ReadOnly _culture As CultureInfo = New CultureInfo("en-GB")
		Dim _recyclingAssetList As New SortedList(Of Integer, Long)
		Dim _recyclingAssetLocation As New Node
		Dim _numberOfActiveColumns As Integer = 0
		ReadOnly _assetColumn As New SortedList(Of String, Integer)
		Private ReadOnly _assetNodes As New Dictionary(Of Long, List(Of Node))
		Private Const TotalValueText As String = "Total Displayed Asset Value: {0} ISK  ({1} total quantity)"
		Public ReadOnly Property RecyclingAssetList As SortedList(Of Integer, Long)
			Get
				Return _recyclingAssetList
			End Get
		End Property

		Public ReadOnly Property RecyclingAssetLocation As Node
			Get
				Return _recyclingAssetLocation
			End Get
		End Property

		Public Sub New()

			' This call is required by the designer.
			InitializeComponent()

			' Add any initialization after the InitializeComponent() call.
			Call LoadFilterGroups()

			' Set the value of the min system value text box
			txtMinSystemValue.Text = CDbl(0).ToInvariantString("N2")

		End Sub

		Private Sub btnRefreshAssets_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefreshAssets.Click
			Dim minValue As Double = 0
			If chkMinSystemValue.Checked = True Then
				' Check for null value and reset
				If txtMinSystemValue.Text = "" Then
					txtMinSystemValue.Text = minValue.ToString("F2")
				End If
				If Double.TryParse(txtMinSystemValue.Text, minValue) = True Then
					Call RefreshAssets()
				Else
					MessageBox.Show("Minimum System Value is not a valid number. Please try again!", "Error in Minimum Value", MessageBoxButtons.OK, MessageBoxIcon.Information)
				End If
			Else
				Call RefreshAssets()
			End If
		End Sub

		Private Sub RefreshAssets()
			If PSCAssetOwners.ItemList.CheckedItems.Count > 0 Then
				' Set search variables
				_searchText = txtSearch.Text
				' Populate the assets list
				Call PopulateAssets()
			Else
				MessageBox.Show("Please select an Asset Owner before continuing!", "Please Select Asset Owner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			End If
		End Sub

		Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtSearch.KeyDown
			If e.KeyCode = Keys.Enter Then
				Call RefreshAssets()
			End If
		End Sub
		Private Sub txtMinSystemValue_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtMinSystemValue.KeyDown
			If e.KeyCode = Keys.Enter Then
				Dim minValue As Double
				If Double.TryParse(txtMinSystemValue.Text, minValue) = True Then
					Call RefreshAssets()
				Else
					MessageBox.Show("Minimum System Value is not a valid number. Please try again!", "Error in Minimum Value", MessageBoxButtons.OK, MessageBoxIcon.Information)
				End If
			End If
		End Sub

#Region "Asset Column Routines"

		''' <summary>
		''' Updates the column headers of the main Assets view
		''' </summary>
		''' <remarks></remarks>
		Private Sub UpdateAssetSlotColumns()
			' Clear the column position list
			_assetColumn.Clear()
			' Clear the columns
			adtAssets.Columns.Clear()
			' Add the module name column
			Dim mainCol As New DevComponents.AdvTree.ColumnHeader("Asset Name/Location")
			mainCol.SortingEnabled = False
			mainCol.Name = "AssetName"
			mainCol.DisplayIndex = 1
			mainCol.Width.Absolute = PrismSettings.UserSettings.SlotNameWidth
			mainCol.Width.AutoSizeMinHeader = True
			adtAssets.Columns.Add(mainCol)
			_assetColumn.Add(mainCol.Name, 0)
			' Iterate through the user selected columns and add them in
			Dim columnDisplayIDX As Integer = 1
			For Each userCol As UserSlotColumn In PrismSettings.UserSettings.UserSlotColumns
				columnDisplayIDX += 1
				Dim subCol As New DevComponents.AdvTree.ColumnHeader(userCol.Description)
				subCol.SortingEnabled = False
				subCol.Name = userCol.Name
				subCol.DisplayIndex = columnDisplayIDX
				subCol.Width.Absolute = userCol.Width
				subCol.Width.AutoSizeMinHeader = True
				subCol.Visible = userCol.Active
				Select Case userCol.Name
					Case "AssetMeta", "AssetVolume", "AssetQuantity", "AssetPrice", "AssetValue"
						subCol.StyleNormal = "AssetCentre"
					Case Else
						subCol.StyleNormal = "Asset"
				End Select
				adtAssets.Columns.Add(subCol)
				_assetColumn.Add(subCol.Name, columnDisplayIDX - 1)
			Next
			_numberOfActiveColumns = columnDisplayIDX - 1
		End Sub

		''' <summary>
		''' Creates the individual cells of a node based on the user columns required
		''' </summary>
		''' <param name="assetNode"></param>
		''' <remarks></remarks>
		Private Sub CreateNodeCells(assetNode As Node)
			' ReSharper disable once RedundantAssignment - Incorrect warning by R#
			For newCell As Integer = 1 To _numberOfActiveColumns
				assetNode.Cells.Add(New Cell)
			Next
			assetNode.Cells(_assetColumn("AssetMeta")).StyleNormal = adtAssets.Styles("AssetRight")
			assetNode.Cells(_assetColumn("AssetVolume")).StyleNormal = adtAssets.Styles("AssetRight")
			assetNode.Cells(_assetColumn("AssetQuantity")).StyleNormal = adtAssets.Styles("AssetRight")
			assetNode.Cells(_assetColumn("AssetPrice")).StyleNormal = adtAssets.Styles("AssetRight")
			assetNode.Cells(_assetColumn("AssetValue")).StyleNormal = adtAssets.Styles("AssetRight")

		End Sub

		''' <summary>
		''' Sets the data in the individual cells of a node based on the Asset data and user columns required
		''' </summary>
		''' <param name="assetData">The data to populate the cell information from</param>
		''' <param name="assetNode">The particular node to update</param>
		''' <remarks></remarks>
		Private Sub UpdateAssetColumnData(ByVal assetData As Classes.AssetItem, ByVal assetNode As Node)

			' Check for custom name
			assetNode.Cells(_assetColumn("AssetOwner")).Tag = assetData.TypeName

			' Add subitems based on the user selected columns
			If PlugInData.AssetItemNames.ContainsKey(assetData.ItemID) = True Then
				assetNode.Text = PlugInData.AssetItemNames(assetData.ItemID)
			Else
				assetNode.Text = assetData.TypeName
			End If


			' Establish price & fix references to Blueprint if applicable
			If assetData.Category = "Blueprint" Then
				If assetNode.Text.Contains("Blueprint") = True And chkExcludeBPs.Checked = True Then
					assetData.Price = 0
				Else
					' Check with BP Manager if this is a BPO
					Dim isBpo As Boolean = True
					If PlugInData.BlueprintAssets.ContainsKey(assetData.Owner) = True Then
						If PlugInData.BlueprintAssets(assetData.Owner).ContainsKey(assetData.ItemID) = True Then
							Dim chkBpo As BlueprintAsset = PlugInData.BlueprintAssets(assetData.Owner).Item(assetData.ItemID)
							If chkBpo.Runs > -1 Or chkBpo.BPType = BPType.Unknown Then
								isBpo = False
								If chkBpo.BPType <> BPType.Unknown Then
									assetNode.Text = assetNode.Text.Replace("Blueprint", "Blueprint (Copy)")
								End If
							Else
								assetNode.Text = assetNode.Text.Replace("Blueprint", "Blueprint (Original)")
							End If
						Else
							If assetData.RawQuantity = -2 Then
								isBpo = False
							Else
								isBpo = True
							End If
						End If
					Else
						If assetData.RawQuantity = -2 Then
							isBpo = False
						Else
							isBpo = True
						End If
					End If
					If isBpo = True Then
						assetNode.Text = assetNode.Text.Replace("Blueprint", "Blueprint (Original)")
					Else
						assetNode.Text = assetNode.Text.Replace("Blueprint", "Blueprint (Copy)")

					End If

					If isBpo = False Then
						assetData.Price = 0
					End If
				End If
			End If

			' Add the additional columns
			For Each userCol As UserSlotColumn In PrismSettings.UserSettings.UserSlotColumns
				Select Case userCol.Name
					Case "AssetOwner"
						assetNode.Cells(_assetColumn(userCol.Name)).Text = assetData.Owner
					Case "AssetGroup"
						assetNode.Cells(_assetColumn(userCol.Name)).Text = assetData.Group
					Case "AssetCategory"
						assetNode.Cells(_assetColumn(userCol.Name)).Text = assetData.Category
					Case "AssetSystem"
						assetNode.Cells(_assetColumn(userCol.Name)).Text = assetData.System
					Case "AssetConstellation"
						assetNode.Cells(_assetColumn(userCol.Name)).Text = assetData.Constellation
					Case "AssetRegion"
						assetNode.Cells(_assetColumn(userCol.Name)).Text = assetData.Region
					Case "AssetSystemSec"
						assetNode.Cells(_assetColumn(userCol.Name)).Text = assetData.SystemSec
					Case "AssetLocation"
						assetNode.Cells(_assetColumn(userCol.Name)).Text = assetData.Location
					Case "AssetMeta"
						assetNode.Cells(_assetColumn(userCol.Name)).Text = assetData.Meta
					Case "AssetVolume"
						assetNode.Cells(_assetColumn(userCol.Name)).Text = assetData.Volume
					Case "AssetQuantity"
						assetNode.Cells(_assetColumn(userCol.Name)).Text = assetData.Quantity.ToInvariantString("N0")
					Case "AssetPrice"
						assetNode.Cells(_assetColumn(userCol.Name)).Text = assetData.Price.ToInvariantString("N2")
					Case "AssetValue"
						assetNode.Cells(_assetColumn(userCol.Name)).Text = (assetData.Price * assetData.Quantity).ToInvariantString("N2")
				End Select
			Next
		End Sub

#End Region

#Region "Asset Column UI Routines"

		Private Sub adtAssets_ColumnMoved(ByVal sender As Object, ByVal ea As ColumnMovedEventArgs) Handles adtAssets.ColumnMoved

			If ea.NewColumnDisplayIndex = 0 Then
				ea.Column.DisplayIndex = 2
			End If
			' Get true locations
			Dim startColName As String = ea.Column.Name
			Dim endColName As String = adtAssets.Columns(ea.NewColumnDisplayIndex).Name
			Dim startIdx As Integer = 0
			Dim endIdx As Integer = 0
			For idx As Integer = 1 To PrismSettings.UserSettings.UserSlotColumns.Count - 1
				If PrismSettings.UserSettings.UserSlotColumns(idx).Name = startColName Then
					startIdx = idx
				End If
				If PrismSettings.UserSettings.UserSlotColumns(idx).Name = endColName Then
					endIdx = idx
				End If
			Next

			If ea.OldColumnDisplayIndex = 0 Then
				' Ignore stuff
			Else
				' We shouldn't overwrite the main column!
				Dim sCol As UserSlotColumn = PrismSettings.UserSettings.UserSlotColumns(startIdx)
				Dim startUserCol As New UserSlotColumn(sCol.Name, sCol.Description, sCol.Width, sCol.Active)
				If endIdx > startIdx Then
					For idx As Integer = startIdx To endIdx - 1
						Dim mCol As UserSlotColumn = PrismSettings.UserSettings.UserSlotColumns(idx + 1)
						PrismSettings.UserSettings.UserSlotColumns(idx) = New UserSlotColumn(mCol.Name, mCol.Description, mCol.Width, mCol.Active)
					Next
					PrismSettings.UserSettings.UserSlotColumns(endIdx) = startUserCol
				Else
					For idx As Integer = startIdx - 1 To endIdx Step -1
						Dim mCol As UserSlotColumn = PrismSettings.UserSettings.UserSlotColumns(idx)
						PrismSettings.UserSettings.UserSlotColumns(idx + 1) = New UserSlotColumn(mCol.Name, mCol.Description, mCol.Width, mCol.Active)
					Next
					PrismSettings.UserSettings.UserSlotColumns(endIdx) = startUserCol
				End If
			End If
			RefreshAssets()
		End Sub

		Private Sub adtAssets_ColumnResized(ByVal sender As Object, ByVal e As EventArgs) Handles adtAssets.ColumnResized
			Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
			If ch.Name <> "AssetName" Then
				For Each userCol As UserSlotColumn In PrismSettings.UserSettings.UserSlotColumns
					If userCol.Name = ch.Name Then
						userCol.Width = ch.Width.Absolute
						Exit Sub
					End If
				Next
			Else
				PrismSettings.UserSettings.SlotNameWidth = ch.Width.Absolute
			End If
		End Sub


#End Region

#Region "Assets XML Parsing"
		Private Sub PopulateAssets()
			_updateInProgress.Visible = True
			Enabled = False
			_assetList.Clear()
			_assetNodes.Clear()
			_exportAssetTable.Clear()
			adtAssets.BeginUpdate()
			adtAssets.Nodes.Clear()
			_totalAssetValue = 0
			_totalAssetCount = 0
			' Initialise the user defined slot columns
			Call UpdateAssetSlotColumns()
			' Get the details of corp accounts
			Call ParseCorpSheets()
			If chkExcludeItems.Checked = False Then
				Call PopulateAssetTree()
				If _filters.Count > 0 Or _searchText <> "" Then
					Call FilterTree()
				End If
				' Check for minimum system value
				'If chkMinSystemValue.Checked = True Then
				'    Call FilterSystemValue()
				'End If
			End If
			If chkExcludeCash.Checked = False And txtSearch.Text = "" Then
				Call DisplayIskAssets()
			End If
			If chkExcludeOrders.Checked = False Then
				Call DisplayOrders()
			End If
			If chkExcludeResearch.Checked = False Then
				Call DisplayResearch()
			End If
			If chkExcludeContracts.Checked = False Then
				Call DisplayContracts()
			End If

			lblTotalAssetsLabel.Text = TotalValueText.FormatInvariant("Calculating...", "Calculating...")

			' tree structure updated... start processing pricing data in background
			Task.Factory.TryRun(Sub() FetchPricingData())

			If adtAssets.Nodes.Count = 0 Then
				adtAssets.Nodes.Add(New Node("No assets to display - check API and filters."))
				adtAssets.Enabled = False
			Else
				adtAssets.Enabled = True
			End If

			AdvTreeSorter.Sort(adtAssets, 1, True, True)
			adtAssets.EndUpdate()
		End Sub

		Private Sub FetchPricingData()
			Dim distinctItemTypes As List(Of Integer) = (From ownedAssets As Classes.AssetItem In _assetList.Values Select ownedAssets.TypeID Distinct).ToList()
			' limit request batches to 50
			Dim requestBatches As New List(Of IEnumerable(Of Integer))
			If distinctItemTypes.Count > 50 Then
				Dim x As Integer = 0
				While x + 50 < distinctItemTypes.Count
					requestBatches.Add(distinctItemTypes.Skip(x).Take(50))
					x = x + 50
				End While
				requestBatches.Add(distinctItemTypes.Skip(x).Take(distinctItemTypes.Count - x))

			Else
				requestBatches.Add(distinctItemTypes)
			End If

			For Each batch As IEnumerable(Of Integer) In requestBatches

				Dim batchTask As Task(Of Dictionary(Of Integer, Double)) = DataFunctions.GetMarketPrices(batch)
				batchTask.Wait() ' purposely serializing these requests to be a good citizen with eve-central.
				If batchTask.IsCompleted And batchTask.IsFaulted = False And batchTask.Exception Is Nothing And batchTask.Result IsNot Nothing Then
					UpdateAssetPricing(batchTask.Result)
					' else record an error somewhere.
				ElseIf batchTask.Exception IsNot Nothing Then
					Throw batchTask.Exception
				End If
			Next

			If (IsHandleCreated) Then
				Invoke(Sub()
					_updateInProgress.Visible = False
					Enabled = True
						End Sub)
			End If

		End Sub

		Private Sub UpdateAssetPricing(prices As Dictionary(Of Integer, Double))

			' find the assests that need updating in this batch
			Dim assetsUpdated As New List(Of Classes.AssetItem)
			Dim testItem As Integer
			For Each itemTypeID As Integer In prices.Keys
				testItem = itemTypeID
				Dim updatedAssets As IEnumerable(Of Classes.AssetItem) = (From ownedAsset In _assetList Where ownedAsset.Value.TypeID = testItem Select ownedAsset.Value).Select(Function(a As Classes.AssetItem)
					a.Price = prices(testItem)
					Return a
																																													End Function)
				assetsUpdated.AddRange(updatedAssets)

				' Update prices of BPCs
				For Each ownedAsset As Classes.AssetItem In assetsUpdated
					If ownedAsset.TypeID = itemTypeID Then
						If ownedAsset.RawQuantity = -2 Then
							ownedAsset.Price = CalculateBPCPrice(ownedAsset.Owner, ownedAsset.ItemID, ownedAsset.TypeID)
						End If
					End If
				Next

			Next

			Dim assetNodesToUpdate As New List(Of Tuple(Of Node, Classes.AssetItem))
			' next get a list of the nodes to update
			Dim testAsset As Classes.AssetItem
			For Each updatedAsset As Classes.AssetItem In assetsUpdated
				testAsset = updatedAsset
				Dim updateTarget As IEnumerable(Of Tuple(Of Node, Classes.AssetItem)) = (From assetNode In _assetNodes Where (CLng(assetNode.Key) = testAsset.TypeID Or CLng(assetNode.Key) = testAsset.ItemID) And testAsset.RawQuantity > -2 Select assetNode).SelectMany(Function(a) a.Value).Select(Function(n) New Tuple(Of Node, Classes.AssetItem)(n, testAsset)).ToList()


				assetNodesToUpdate.AddRange(updateTarget)

			Next

			'Bug EVEHQ-169 : this is called even after the window is destroyed but not GC'd. check the handle boolean first.
			If IsHandleCreated Then
				'cut to the ui thread for update
				Invoke(Sub()
					'Check to see if system value filtering is enabled

					For Each updateSet As Tuple(Of Node, Classes.AssetItem) In assetNodesToUpdate.Where(Function(tuple) As Boolean
						Return tuple.Item1.Text.Contains("Blueprint (Copy)") = False
																											End Function)

						' Update the price and value of each item
						updateSet.Item1.Cells(_assetColumn("AssetPrice")).Text = updateSet.Item2.Price.ToInvariantString("N2")
						updateSet.Item1.Cells(_assetColumn("AssetValue")).Text = (updateSet.Item2.Price * updateSet.Item2.Quantity).ToInvariantString("N2")

					Next

					' Update totals
					RecalcAllPrices()

						End Sub)
			End If
		End Sub

		Private Function CalculateBPCPrice(ownerName As String, assetID As Long, typeID As Integer) As Double
			' Check the blueprint costs for a matching type
			If PrismSettings.UserSettings.BPCCosts.ContainsKey(typeID) Then
				If PlugInData.BlueprintAssets.ContainsKey(ownerName) = True Then
					If PlugInData.BlueprintAssets(ownerName).ContainsKey(assetID) Then
						Dim runs As Integer = PlugInData.BlueprintAssets(ownerName)(assetID).Runs
						Dim bpc As BlueprintCopyCostInfo = PrismSettings.UserSettings.BPCCosts(typeID)
						Dim maxRun As Integer = StaticData.Blueprints(typeID).MaxProductionLimit
						Dim perRunCost As Double = (bpc.MaxRunCost - bpc.MinRunCost) / (maxRun - 1)
						Dim basePrice As Double = bpc.MinRunCost - perRunCost
						Return Math.Round(basePrice + (perRunCost * runs), 2)
					Else
						Return 0
					End If
				Else
					Return 0
				End If
			Else
				Return 0
			End If
		End Function

		Private Sub ParseCorpSheets()
			' Reset the lists of divisions and wallets
			_divisions.Clear()
			_walletDivisions.Clear()
			Dim owner As PrismOwner

			For Each cOwner As ListViewItem In PSCAssetOwners.ItemList.CheckedItems

				If PlugInData.PrismOwners.ContainsKey(cOwner.Text) = True Then

					owner = PlugInData.PrismOwners(cOwner.Text)
					Dim ownerAccount As EveHQAccount = PlugInData.GetAccountForCorpOwner(owner, CorpRepType.CorpSheet)
					Dim ownerID As String = PlugInData.GetAccountOwnerIDForCorpOwner(owner, CorpRepType.CorpSheet)

					If ownerAccount IsNot Nothing Then

						If owner.IsCorp = True Then
							Dim corpResponse As NewEveApi.EveServiceResponse(Of NewEveApi.Entities.CorporateData) = HQ.ApiProvider.Corporation.CorporationSheet(ownerAccount.UserID, ownerAccount.APIKey)
							If corpResponse IsNot Nothing Then

								If corpResponse.IsSuccess Then
									' No errors so parse the files
									Dim divList As XmlNodeList

									For Each div As NewEveApi.Entities.CorporateDivision In corpResponse.ResultData.Divisions
										If _divisions.ContainsKey(ownerID & "_" & div.AccountKey) = False Then
											_divisions.Add(owner.ID & "_" & div.AccountKey, StrConv(div.Description, VbStrConv.ProperCase))
										End If
									Next

									For Each wallDiv As NewEveApi.Entities.CorporateDivision In corpResponse.ResultData.WalletDivisions
										If _walletDivisions.ContainsKey(ownerID & "_" & wallDiv.AccountKey) = False Then
											_walletDivisions.Add(owner.ID & "_" & wallDiv.AccountKey, wallDiv.Description)
										End If
									Next
								End If
							Else
								For divID As Integer = 1000 To 1006
									_divisions.Add(ownerID & "_" & divID.ToString, "Division " & divID.ToString)
									_walletDivisions.Add(ownerID & "_" & divID.ToString, "Wallet Division " & divID.ToString)
								Next
							End If
						End If
					End If

				End If

			Next
		End Sub
		Private Sub PopulateAssetTree()

			Dim owner As PrismOwner
			_totalAssetCount = 0
			_totalAssetValue = 0

			For Each cOwner As ListViewItem In PSCAssetOwners.ItemList.CheckedItems

				If PlugInData.PrismOwners.ContainsKey(cOwner.Text) = True Then
					owner = PlugInData.PrismOwners(cOwner.Text)
					Dim ownerAccount As EveHQAccount = PlugInData.GetAccountForCorpOwner(owner, CorpRepType.Assets)
					Dim ownerID As String = PlugInData.GetAccountOwnerIDForCorpOwner(owner, CorpRepType.Assets)
					Dim assetResponse As NewEveApi.EveServiceResponse(Of IEnumerable(Of NewEveApi.Entities.AssetItem))
					If ownerAccount IsNot Nothing Then

						If owner.IsCorp = True Then
							_assetCorpMode = chkCorpHangarMode.Checked
							assetResponse = HQ.ApiProvider.Corporation.AssetList(ownerAccount.UserID, ownerAccount.APIKey, ownerID.ToInt32())
						Else
							_assetCorpMode = False
							assetResponse = HQ.ApiProvider.Character.AssetList(ownerAccount.UserID, ownerAccount.APIKey, ownerID.ToInt32())
						End If

						If assetResponse IsNot Nothing Then

							Dim assetItem As Entities.AssetItem
							'Dim eveLocation As SolarSystem

							If assetResponse.IsSuccess Then
								Dim assetIsInHanger As Boolean
								Dim hangarPrice As Double
								For Each assetItem In assetResponse.ResultData
									' Check if the location is already listed
									Dim locNode As New Node
									CreateNodeCells(locNode)
									Dim addLocation = True
									Dim stationLocation As String
									Const CorpHangarName = "n/a"
									For Each testNode As Node In adtAssets.Nodes
										If testNode.Tag.ToString() = assetItem.LocationId.ToInvariantString() Then
											locNode = testNode
											addLocation = False
											Exit For
										End If
									Next

									Dim assetLocation = Locations.GetLocationFromID(assetItem.LocationId)
									If addLocation = True Then
										locNode.Text = assetLocation.ContainerName
										locNode.Tag = assetLocation.ContainerId
										locNode.Cells(_assetColumn("AssetOwner")).Tag = assetLocation.ContainerName
										If assetLocation.SolarSystem IsNot Nothing Then
											locNode.Cells(_assetColumn("AssetSystem")).Text = assetLocation.SolarSystem.Name
											locNode.Cells(_assetColumn("AssetConstellation")).Text = 
												StaticData.Constellations(assetLocation.SolarSystem.ConstellationId)
											locNode.Cells(_assetColumn("AssetRegion")).Text = StaticData.Regions(assetLocation.SolarSystem.RegionId)
											locNode.Cells(_assetColumn("AssetSystemSec")).Text = assetLocation.SolarSystem.Security.ToString("N2")
										Else
											locNode.Cells(_assetColumn("AssetSystem")).Text = "Unknown"
											locNode.Cells(_assetColumn("AssetConstellation")).Text = "Unknown"
											locNode.Cells(_assetColumn("AssetRegion")).Text = "Unknown"
											locNode.Cells(_assetColumn("AssetSystemSec")).Text = "Unknown"
										End If
										adtAssets.Nodes.Add(locNode)
									Else
										stationLocation = assetLocation.ContainerName
									End If

									Dim typeId As Integer = assetItem.TypeId
									Dim itemData As EveType
									Dim itemName As String
									Dim groupID As Integer
									Dim groupName As String
									Dim catName As String
									Dim metaLevel As String
									Dim volume As String
									If StaticData.Types.ContainsKey(typeId) Then
										itemData = StaticData.Types(typeId)
										itemName = itemData.Name
										groupName = StaticData.TypeGroups(itemData.Group)
										groupID = itemData.Group
										catName = StaticData.TypeCats(itemData.Category)
										metaLevel = StaticData.Types(typeId).MetaLevel.ToString
										If PlugInData.PackedVolumes.ContainsKey(groupID) = True Then
											If assetItem.Singleton = False Then
												volume = (PlugInData.PackedVolumes(groupID) * assetItem.Quantity).ToInvariantString("N2")
											Else
												volume = (StaticData.Types(typeId).Volume * assetItem.Quantity).ToInvariantString("N2")
											End If
										Else
											volume = (StaticData.Types(typeId).Volume * assetItem.Quantity).ToInvariantString("N2")
										End If
									Else
										' Can't find the item in the database
										itemName = "ItemID: " & typeId.ToString
										groupName = "Unknown"
										catName = "Unknown"
										metaLevel = "0"
										volume = "0"
									End If

									Dim newAsset As New Node
									CreateNodeCells(newAsset)
									newAsset.Tag = assetItem.ItemId
									Dim flagID As Integer = assetItem.Flag
									Dim flagName As String = StaticData.ItemMarkers(flagID)
									Dim accountID As Integer = flagID + 885
									If accountID = 889 Then accountID = 1000
									If owner.IsCorp = True And itemName <> "Office" Then
										If _divisions.ContainsKey(owner.ID & "_" & accountID.ToString) = True Then
											flagName = CStr(_divisions.Item(owner.ID & "_" & accountID.ToString))
											If _assetCorpMode = True And locNode.Nodes.Count < 7 And itemName <> "Office" Then
												' Build the corp division nodes
												For div As Integer = 0 To 6
													Dim hangar As New Node
													CreateNodeCells(hangar)
													hangar.Text = CStr(_divisions.Item(owner.ID & "_" & (1000 + div).ToString))
													locNode.Nodes.Add(hangar)
													hangar.Cells(_assetColumn("AssetValue")).Text = CDbl(0).ToInvariantString("N2")
												Next
											End If
										End If
									End If

									' Add the asset to the treelistview
									If _assetCorpMode = True And itemName <> "Office" And (flagID = 4 Or (flagID >= 116 And flagID <= 121)) Then
										If (accountID - 1000) >= 0 And (accountID - 1000) < locNode.Nodes.Count Then
											locNode.Nodes(accountID - 1000).Nodes.Add(newAsset)
											assetIsInHanger = True
										Else
											' Catch case where errors were occuring
											Dim msg As String = "Unable to add corp asset into hangar:" & ControlChars.CrLf
											msg &= "AssetID: " & newAsset.Tag.ToString & ControlChars.CrLf
											msg &= "Item: " & itemName & ControlChars.CrLf
											msg &= "FlagID: " & flagID.ToString & " (" & flagName & ")" & ControlChars.CrLf
											msg &= "AccountID: " & accountID.ToString & ControlChars.CrLf
											msg &= "Parent: " & locNode.Text & ControlChars.CrLf & ControlChars.CrLf
											msg &= "Please post this as a bug report - the text of this message has been copied to the clipboard to assist you." & ControlChars.CrLf & ControlChars.CrLf
											msg &= "Corp Assets will be incomplete while this error appears. Corp Hangar Mode will be disabled."
											chkCorpHangarMode.Checked = False
											Try
												Clipboard.SetText(msg)
											Catch e As Exception
											End Try
											MessageBox.Show(msg, "Corp Hangar Mode Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
											Exit For
										End If
									Else
										locNode.Nodes.Add(newAsset)
										assetIsInHanger = False
									End If

									' Add the asset to the list of assets
									Dim newAssetList As New Classes.AssetItem
									newAssetList.ItemID = CLng(newAsset.Tag)
									newAssetList.CorpHangar = CorpHangarName
									newAssetList.Station = stationLocation
									newAssetList.System = locNode.Text
									newAssetList.TypeID = typeId
									newAssetList.TypeName = itemName
									newAssetList.IsInHanger = assetIsInHanger
									newAssetList.Owner = owner.Name
									newAssetList.Group = groupName
									newAssetList.Category = catName
									newAssetList.IsInHanger = assetIsInHanger
									' newAssetList.Price = Math.Round(prices(newAssetList.TypeID), 2, MidpointRounding.AwayFromZero)
									If assetLocation.SolarSystem IsNot Nothing Then
										newAssetList.System = assetLocation.SolarSystem.Name
										newAssetList.Constellation = StaticData.Constellations(assetLocation.SolarSystem.ConstellationId)
										newAssetList.Region = StaticData.Regions(assetLocation.SolarSystem.RegionId)
										newAssetList.SystemSec = assetLocation.SolarSystem.Security.ToString("N2")
									Else
										newAssetList.System = "Unknown"
										newAssetList.Constellation = "Unknown"
										newAssetList.Region = "Unknown"
										newAssetList.SystemSec = "Unknown"
									End If
									newAssetList.Location = flagName
									newAssetList.Meta = metaLevel
									newAssetList.Volume = volume
									newAssetList.Quantity = assetItem.Quantity
									If assetItem.RawQuantity <> 0 Then
										newAssetList.RawQuantity = assetItem.RawQuantity
									Else
										newAssetList.RawQuantity = 0
									End If
									_totalAssetCount += newAssetList.Quantity
									If _assetList.ContainsKey(newAssetList.ItemID) = False Then
										_assetList.Add(newAssetList.ItemID, newAssetList)
									End If

									Call UpdateAssetColumnData(newAssetList, newAsset)

									' add a reference to the asset and the node for async price update later on.
									If _assetList.ContainsKey(newAssetList.ItemID) = False Then
										_assetList.Add(newAssetList.ItemID, newAssetList)
									End If

									Dim assetLocationHash = (newAssetList.Location + newAssetList.TypeID.ToInvariantString()).GetHashCode()
									If _exportAssetTable.ContainsKey(assetLocationHash) = False Then
										_exportAssetTable.Add(assetLocationHash, newAssetList)
									Else
										Dim item = _exportAssetTable(assetLocationHash)
										item.Quantity += newAssetList.Quantity
										If (item.RawQuantity >= 0) Then
											item.RawQuantity += newAssetList.RawQuantity
										End If
									End If

									If _assetNodes.ContainsKey(newAssetList.ItemID) = False Then
										_assetNodes.Add(newAssetList.ItemID, New List(Of Node))
									End If
									_assetNodes(newAssetList.ItemID).Add(newAsset)

									' Check if this row has child nodes and repeat
									If assetItem.Contents IsNot Nothing Then
										Call PopulateAssetNode(
											newAsset, assetItem, owner.Name, locNode.Text, owner, assetLocation.SolarSystem, stationLocation, CorpHangarName)
									End If

									' Update hangar price if applicable
									If assetIsInHanger = True Then
										hangarPrice = CDbl(newAsset.Parent.Cells(_assetColumn("AssetValue")).Text)
										newAsset.Parent.Cells(_assetColumn("AssetValue")).Text = (hangarPrice + CDbl(newAsset.Cells(_assetColumn("AssetValue")).Text)).ToInvariantString(2)
									End If

								Next


							End If
						End If

					End If
				End If
			Next

			' Establish container prices
			For Each pNode As Node In adtAssets.Nodes
				Call SetNodeValue(pNode)
				Call SetNodeVolume(pNode)
			Next

			' Get the locations and total prices
			Dim locationPrice As Double
			Dim locationVolume As Double
			Dim cLoc As Node
			Dim cL As Integer = 0
			If adtAssets.Nodes.Count > 0 Then
				Do
					cLoc = adtAssets.Nodes(cL)
					locationPrice = 0
					locationVolume = 0
					For Each cLine As Node In cLoc.Nodes
						locationPrice += CDbl(cLine.Cells(_assetColumn("AssetValue")).Text)
						If cLine.Cells(_assetColumn("AssetVolume")).Text <> "" Then
							locationVolume += CDbl(cLine.Cells(_assetColumn("AssetVolume")).Text)
						End If
					Next
					_totalAssetValue += locationPrice
					cLoc.Cells(_assetColumn("AssetValue")).Text = locationPrice.ToInvariantString("N2")
					cLoc.Cells(_assetColumn("AssetVolume")).Text = locationVolume.ToInvariantString("N2")
					' Delete if no child nodes at the locations
					If cLoc.Nodes.Count = 0 Then
						adtAssets.Nodes.Remove(cLoc)
						cL -= 1
					End If
					cL += 1
				Loop Until cL = adtAssets.Nodes.Count
			End If

		End Sub
		Private Function PopulateAssetNode(ByVal parentAsset As Node, ByVal assetItem As NewEveApi.Entities.AssetItem, ByVal assetOwner As String, ByVal assetLocation As String, owner As PrismOwner, ByVal eveLocation As SolarSystem, ByVal stationLocation As String, corpHangarName As String) As Double
			Dim subAssets As IEnumerable(Of NewEveApi.Entities.AssetItem)
			Dim subAssetItem As NewEveApi.Entities.AssetItem
			Dim containerPrice As Double
			Dim assetIsInHanger As Boolean
			Dim hangarPrice As Double
			Const LinePrice As Double = 0
			subAssets = assetItem.Contents
			If IsNumeric(parentAsset.Cells(_assetColumn("AssetPrice")).Text) = True Then
				containerPrice = CDbl(parentAsset.Cells(_assetColumn("AssetPrice")).Text)
			Else
				containerPrice = 0
				parentAsset.Cells(_assetColumn("AssetPrice")).Text = CDbl(0).ToInvariantString("N2")
			End If
			' batch query the contents of the location for their prices
			'  Dim priceData As Task(Of Dictionary(Of String, Double)) = Core.DataFunctions.GetMarketPrices(From node In subLocList Let n = CType(node, XmlNode) Select n.Attributes.GetNamedItem("typeID").Value)
			'  priceData.Wait()
			' Dim prices As Dictionary(Of String, Double) = priceData.Result

			For Each subAssetItem In subAssets
				Try
					Dim itemID As Integer = subAssetItem.TypeId
					Dim itemData As EveType
					Dim itemName As String
					Dim groupID As Integer
					Dim groupName As String
					Dim catName As String
					Dim metaLevel As String
					Dim volume As String
					If StaticData.Types.ContainsKey(itemID) Then
						itemData = StaticData.Types(itemID)
						itemName = itemData.Name
						groupID = itemData.Group
						groupName = StaticData.TypeGroups(itemData.Group)
						catName = StaticData.TypeCats(itemData.Category)
						metaLevel = StaticData.Types(itemID).MetaLevel.ToString
						If PlugInData.PackedVolumes.ContainsKey(groupID) = True Then
							If subAssetItem.Singleton = False Then
								volume = (PlugInData.PackedVolumes(groupID) * subAssetItem.Quantity).ToInvariantString("N2")
							Else
								volume = (StaticData.Types(itemID).Volume * subAssetItem.Quantity).ToInvariantString("N2")
							End If
						Else
							volume = (StaticData.Types(itemID).Volume * subAssetItem.Quantity).ToInvariantString("N2")
						End If
					Else
						' Can't find the item in the database
						itemName = "ItemID: " & itemID.ToString
						groupName = "Unknown"
						catName = "Unknown"
						metaLevel = "0"
						volume = "0"
					End If

					Dim subAsset As New Node
					CreateNodeCells(subAsset)
					subAsset.Tag = subAssetItem.ItemId
					Dim subFlagID As Integer = subAssetItem.Flag
					Dim subFlagName As String = StaticData.ItemMarkers(subFlagID)
					Dim accountID As Integer = subFlagID + 885
					If accountID = 889 Then accountID = 1000
					If owner.IsCorp And itemName <> "Office" And accountID >= 1000 And accountID <= 1006 Then
						If _divisions.ContainsKey(owner.ID & "_" & accountID.ToString) = True Then
							subFlagName = CStr(_divisions.Item(owner.ID & "_" & accountID.ToString))
							If _assetCorpMode = True And parentAsset.Nodes.Count < 7 And itemName <> "Office" Then
								' Build the corp division nodes
								For div As Integer = 0 To 6
									Dim hangar As New Node
									CreateNodeCells(hangar)
									hangar.Text = CStr(_divisions.Item(owner.ID & "_" & (1000 + div).ToString))
									parentAsset.Nodes.Add(hangar)
									hangar.Cells(_assetColumn("AssetValue")).Text = CDbl(0).ToInvariantString("N2")
								Next
							End If
							corpHangarName = subFlagName
						Else
							' Don't have a proper division
							subFlagName = "Corp Division " & accountID.ToString
							If _assetCorpMode = True And parentAsset.Nodes.Count < 7 And itemName <> "Office" Then
								' Build the corp division nodes
								For div As Integer = 0 To 6
									Dim hangar As New Node
									CreateNodeCells(hangar)
									hangar.Text = "Corp Division " & div.ToString
									parentAsset.Nodes.Add(hangar)
									hangar.Cells(_assetColumn("AssetValue")).Text = CDbl(0).ToInvariantString("N2")
								Next
							End If
							corpHangarName = subFlagName
						End If
					End If

					' Add the asset to the list of assets
					Dim newAssetList As New Classes.AssetItem
					newAssetList.ItemID = subAssetItem.ItemId
					newAssetList.CorpHangar = corpHangarName
					newAssetList.Station = stationLocation
					newAssetList.System = assetLocation
					newAssetList.TypeID = itemID
					newAssetList.TypeName = itemName
					newAssetList.Owner = assetOwner
					newAssetList.Group = groupName
					newAssetList.Category = catName
					' newAssetList.Price = Math.Round(prices(newAssetList.TypeID), 2, MidpointRounding.AwayFromZero)
					If eveLocation IsNot Nothing Then
						newAssetList.System = eveLocation.Name
						newAssetList.Constellation = StaticData.Constellations(eveLocation.ConstellationId)
						newAssetList.Region = StaticData.Regions(eveLocation.RegionId)
						newAssetList.SystemSec = eveLocation.Security.ToString("N2")
					Else
						newAssetList.System = "Unknown"
						newAssetList.Constellation = "Unknown"
						newAssetList.Region = "Unknown"
						newAssetList.SystemSec = "Unknown"
					End If
					newAssetList.Location = parentAsset.Text & ": " & subFlagName
					newAssetList.Meta = metaLevel
					newAssetList.Volume = volume
					newAssetList.Quantity = subAssetItem.Quantity
					newAssetList.RawQuantity = subAssetItem.RawQuantity

					_totalAssetCount += newAssetList.Quantity

					If _assetCorpMode = True And itemName <> "Office" And (subFlagID = 4 Or (subFlagID >= 116 And subFlagID <= 121)) Then
						parentAsset.Nodes(accountID - 1000).Nodes.Add(subAsset)
						assetIsInHanger = True
					Else
						parentAsset.Nodes.Add(subAsset)
						assetIsInHanger = False
					End If

					Call UpdateAssetColumnData(newAssetList, subAsset)

					newAssetList.IsInHanger = assetIsInHanger
					' add a reference to the asset and the node for async price update later on.
					If _assetList.ContainsKey(newAssetList.TypeID) = False Then
						_assetList.Add(newAssetList.TypeID, newAssetList)
					End If

					Dim assetLocationHash = (newAssetList.Location + newAssetList.TypeID.ToInvariantString()).GetHashCode()
					If _exportAssetTable.ContainsKey(assetLocationHash) = False Then
						_exportAssetTable.Add(assetLocationHash, newAssetList)
					Else
						Dim item = _exportAssetTable(assetLocationHash)
						item.Quantity += newAssetList.Quantity
						If (item.RawQuantity >= 0) Then
							item.RawQuantity += newAssetList.RawQuantity
						End If


					End If

					If _assetNodes.ContainsKey(newAssetList.TypeID) = False Then
						_assetNodes.Add(newAssetList.TypeID, New List(Of Node))
					End If
					_assetNodes(newAssetList.TypeID).Add(subAsset)

					' Update hangar price if applicable
					containerPrice += (newAssetList.Price * newAssetList.Quantity)
					If assetIsInHanger = True Then
						hangarPrice = CDbl(subAsset.Parent.Cells(_assetColumn("AssetValue")).Text)
						subAsset.Parent.Cells(_assetColumn("AssetValue")).Text = (hangarPrice + LinePrice).ToInvariantString("N2")
					End If

					If subAssetItem.Contents IsNot Nothing Then
						If subAssetItem.Contents.Any() Then
							containerPrice += PopulateAssetNode(subAsset, subAssetItem, assetOwner, assetLocation, owner, eveLocation, stationLocation, corpHangarName)
						End If

					End If



				Catch ex As Exception
					Dim msg As String = "Unable to parse Asset:" & ControlChars.CrLf
					msg &= "TypeID: " & subAssetItem.TypeId
					msg &= ex.FormatException()
					Trace.TraceError(msg)
					MessageBox.Show(msg, "Error Parsing Assets File For " & assetOwner, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				End Try
			Next
			parentAsset.Cells(_assetColumn("AssetValue")).Text = containerPrice.ToInvariantString("N2")
			Return containerPrice
		End Function
		Private Function SetNodeValue(ByVal pNode As Node) As Double
			Dim nodeValue As Double = 0
			' Add current Node value
			If pNode.Cells(_assetColumn("AssetQuantity")).Text <> "" Then
				nodeValue += CDbl(pNode.Cells(_assetColumn("AssetQuantity")).Text) * CDbl(pNode.Cells(_assetColumn("AssetPrice")).Text)
			End If
			' Add value of child nodes
			If pNode.Nodes.Count > 0 Then
				For Each cNode As Node In pNode.Nodes
					nodeValue += SetNodeValue(cNode)
				Next
			End If
			pNode.Cells(_assetColumn("AssetValue")).Text = nodeValue.ToInvariantString("N2")
			Return nodeValue
		End Function
		Private Function SetNodeVolume(ByVal pNode As Node) As Double
			Dim nodeVolume As Double = 0
			' Add current Node volume
			If pNode.Cells(_assetColumn("AssetVolume")).Text <> "" Then
				nodeVolume += CDbl(pNode.Cells(_assetColumn("AssetVolume")).Text)
			End If
			' Add value of child nodes
			If pNode.Nodes.Count > 0 Then
				For Each cNode As Node In pNode.Nodes
					nodeVolume += SetNodeVolume(cNode)
				Next
			End If
			pNode.Cells(_assetColumn("AssetVolume")).Text = nodeVolume.ToInvariantString("N2")
			Return nodeVolume
		End Function
		Private Sub DisplayIskAssets()
			Dim owner As PrismOwner

			' Reset and parse the character wallets
			_charWallets.Clear()
			_corpWallets.Clear()
			_corpWalletDivisions.Clear()
			For Each cOwner As ListViewItem In PSCAssetOwners.ItemList.CheckedItems

				If PlugInData.PrismOwners.ContainsKey(cOwner.Text) = True Then

					owner = PlugInData.PrismOwners(cOwner.Text)
					Dim ownerAccount As EveHQAccount = PlugInData.GetAccountForCorpOwner(owner, CorpRepType.Balances)
					Dim ownerID As String = PlugInData.GetAccountOwnerIDForCorpOwner(owner, CorpRepType.Balances)
					Dim accountBalances As NewEveApi.EveServiceResponse(Of IEnumerable(Of NewEveApi.Entities.AccountBalance))
					If ownerAccount IsNot Nothing Then

						If owner.IsCorp = True Then
							' Check for corp wallets
							accountBalances = HQ.ApiProvider.Corporation.AccountBalance(ownerAccount.UserID, ownerAccount.APIKey, ownerID.ToInt32())
							If accountBalances IsNot Nothing Then
								If accountBalances.IsSuccess Then
									' No errors so parse the files

									If _corpWallets.Contains(owner.Name) = False Then
										_corpWallets.Add(owner.Name, owner.ID)

										For Each account As NewEveApi.Entities.AccountBalance In accountBalances.ResultData
											Dim isk As Double = account.Balance
											Dim accountKey As String = account.AccountKey.ToInvariantString()
											If _corpWalletDivisions.ContainsKey(owner.ID & "_" & accountKey) = False Then
												_corpWalletDivisions.Add(owner.ID & "_" & accountKey, isk)
											End If
										Next
										' Check for missing account keys
										For key As Integer = 1000 To 1006
											If _corpWalletDivisions.ContainsKey(ownerID & "_" & key.ToString) = False Then
												_corpWalletDivisions.Add(ownerID & "_" & key.ToString, 0)
											End If
										Next
									End If
								End If
							End If
						Else
							' Check for character wallets
							accountBalances = HQ.ApiProvider.Character.AccountBalance(ownerAccount.UserID, ownerAccount.APIKey, ownerID.ToInt32())
							If accountBalances IsNot Nothing Then
								If accountBalances.IsSuccess Then
									' No errors so parse the files

									For Each account As NewEveApi.Entities.AccountBalance In accountBalances.ResultData
										Dim isk As Double = account.Balance
										If _charWallets.ContainsKey(owner.Name) = False Then
											_charWallets.Add(owner.Name, isk)
										End If
									Next
								End If
							End If
						End If
					End If
				End If
			Next

			' Add the balances to the assets schedule
			Dim node As New Node
			CreateNodeCells(node)
			Dim totalCash As Double = 0
			node.Tag = "ISK"
			node.Text = "Cash Balances"
			' Add the personal balances
			If _charWallets.Count > 0 Then
				Dim personalNode As New Node
				CreateNodeCells(personalNode)
				personalNode.Tag = "Personal"
				personalNode.Text = "Personal"
				node.Nodes.Add(personalNode)
				Dim personalCash As Double = 0
				For Each pilot As String In _charWallets.Keys
					Dim iskNode As New Node
					CreateNodeCells(iskNode)
					iskNode.Tag = pilot
					iskNode.Text = pilot
					personalNode.Nodes.Add(iskNode)
					iskNode.Cells(_assetColumn("AssetValue")).Text = _charWallets(pilot).ToInvariantString("N2")
					personalCash += CDbl(_charWallets(pilot))
				Next
				personalNode.Cells(_assetColumn("AssetValue")).Text = personalCash.ToInvariantString("N2")
				totalCash += personalCash
			End If
			' Add the corporate balances
			If _corpWallets.Count > 0 Then
				Dim corporateNode As New Node
				CreateNodeCells(corporateNode)
				corporateNode.Tag = "Corporate"
				corporateNode.Text = "Corporate"
				node.Nodes.Add(corporateNode)
				Dim corporateCash As Double = 0
				For Each corpName As String In _corpWallets.Keys
					Dim corpID As String = CStr(_corpWallets(corpName))
					Dim corpNode As New Node
					CreateNodeCells(corpNode)
					corpNode.Tag = corpName
					corpNode.Text = corpName
					corporateNode.Nodes.Add(corpNode)
					Dim divisionCash As Double = 0
					For key As Integer = 1000 To 1006
						Dim iskNode As New Node
						CreateNodeCells(iskNode)
						Dim idx As String = corpID & "_" & key.ToString
						If _walletDivisions.ContainsKey(idx) Then
							iskNode.Tag = _walletDivisions(idx).ToString
							iskNode.Text = CStr(_walletDivisions(idx))
						Else
							iskNode.Tag = "Wallet Division " & key.ToString
							iskNode.Text = "Wallet Division " & key.ToString
						End If
						corpNode.Nodes.Add(iskNode)
						iskNode.Cells(_assetColumn("AssetValue")).Text = _corpWalletDivisions(idx).ToInvariantString("N2")
						divisionCash += CDbl(_corpWalletDivisions(idx))
					Next
					corporateCash += divisionCash
					corpNode.Cells(_assetColumn("AssetValue")).Text = divisionCash.ToInvariantString("N2")
				Next
				corporateNode.Cells(_assetColumn("AssetValue")).Text = corporateCash.ToInvariantString("N2")
				totalCash += corporateCash
			End If
			node.Cells(_assetColumn("AssetValue")).Text = totalCash.ToInvariantString("N2")
			_totalAssetValue += totalCash
			If totalCash > 0 Then
				adtAssets.Nodes.Add(node)
			End If
		End Sub
		Private Sub DisplayOrders()

			' Add the balances to the assets schedule
			Dim ordersNode As New Node
			Dim buyOrders As New Node
			Dim sellOrders As New Node
			Dim buyValue, sellValue As Double
			Dim buyVolume, sellVolume As Double
			ordersNode.Tag = "Orders"
			ordersNode.Text = "Market Orders"
			CreateNodeCells(ordersNode)
			' Add the Buy Orders node
			buyOrders.Text = "Buy Orders"
			buyOrders.Tag = "Buy Orders"
			CreateNodeCells(buyOrders)
			' Add the Sell Orders node
			sellOrders.Text = "Sell Orders"
			sellOrders.Tag = "Sell Orders"
			CreateNodeCells(sellOrders)

			For Each cPilot As ListViewItem In PSCAssetOwners.ItemList.CheckedItems
				' Get the owner we will use
				Dim owner As String = cPilot.Text
				' Get the orders
				Dim orderCollection As MarketOrdersCollection = ParseMarketOrders(owner)
				' Add the orders (outstanding ones only)
				Dim itemName As String
				Dim category, group, meta As Integer
				Dim vol As Double
				Dim eveLocation As SolarSystem
				For Each ownerOrder As Classes.MarketOrder In orderCollection.MarketOrders
					If ownerOrder.OrderState = Classes.MarketOrderState.Open Then
						Dim orderNode As New Node
						CreateNodeCells(orderNode)
						orderNode.Tag = ownerOrder.TypeID
						If StaticData.Types.ContainsKey(ownerOrder.TypeID) = True Then
							Dim orderItem As EveType = StaticData.Types(ownerOrder.TypeID)
							itemName = orderItem.Name
							category = orderItem.Category
							group = orderItem.Group
							meta = orderItem.MetaLevel
							' Check for packaged ship volumes
							If category = 6 Then
								If PlugInData.PackedVolumes.ContainsKey(group) Then
									vol = PlugInData.PackedVolumes(group)
								Else
									vol = orderItem.Volume
								End If
							Else
								vol = orderItem.Volume
							End If
						Else
							itemName = "ItemID: " & ownerOrder.TypeID.ToString
							category = -1
							group = -1
							meta = 0
							vol = 1
						End If
						' Check for search criteria
						If Not ((_filters.Count > 0 And _catFilters.Contains(category) = False And _groupFilters.Contains(group) = False) Or (_searchText <> "" And itemName.ToLower.Contains(_searchText.ToLower) = False)) Then
							orderNode.Text = itemName
							If ownerOrder.Bid = 0 Then
								sellOrders.Nodes.Add(orderNode)
								sellValue += ownerOrder.Price * ownerOrder.VolRemaining
								sellVolume += vol * ownerOrder.VolRemaining
							Else
								buyOrders.Nodes.Add(orderNode)
								buyValue += ownerOrder.Escrow * ownerOrder.VolRemaining
								buyVolume += vol * ownerOrder.VolRemaining
							End If
							orderNode.Cells(_assetColumn("AssetOwner")).Text = owner
							If group = -1 Then
								orderNode.Cells(_assetColumn("AssetGroup")).Text = "<Unknown>"
							Else
								orderNode.Cells(_assetColumn("AssetGroup")).Text = StaticData.TypeGroups(group)
							End If
							If category = -1 Then
								orderNode.Cells(_assetColumn("AssetCategory")).Text = "<Unknown>"
							Else
								orderNode.Cells(_assetColumn("AssetCategory")).Text = StaticData.TypeCats(category)
							End If
							If StaticData.Stations.ContainsKey(ownerOrder.StationID) = True Then
								orderNode.Cells(_assetColumn("AssetLocation")).Text = StaticData.Stations(ownerOrder.StationID).StationName
								eveLocation = StaticData.SolarSystems(StaticData.Stations(ownerOrder.StationID).SystemId)
							Else

								orderNode.Cells(_assetColumn("AssetLocation")).Text = "StationID: " & ownerOrder.StationID
								eveLocation = Nothing
							End If
							If eveLocation IsNot Nothing Then
								orderNode.Cells(_assetColumn("AssetSystem")).Text = eveLocation.Name
								orderNode.Cells(_assetColumn("AssetConstellation")).Text = StaticData.Constellations(eveLocation.ConstellationId)
								orderNode.Cells(_assetColumn("AssetRegion")).Text = StaticData.Regions(eveLocation.RegionId)
								orderNode.Cells(_assetColumn("AssetSystemSec")).Text = eveLocation.Security.ToString("N2")
							Else
								orderNode.Cells(_assetColumn("AssetSystem")).Text = "Unknown"
								orderNode.Cells(_assetColumn("AssetConstellation")).Text = "Unknown"
								orderNode.Cells(_assetColumn("AssetRegion")).Text = "Unknown"
								orderNode.Cells(_assetColumn("AssetSystemSec")).Text = "Unknown"
							End If
							orderNode.Cells(_assetColumn("AssetMeta")).Text = meta.ToInvariantString("N0")
							orderNode.Cells(_assetColumn("AssetVolume")).Text = CDbl(vol * ownerOrder.VolRemaining).ToInvariantString("N2")
							orderNode.Cells(_assetColumn("AssetQuantity")).Text = ownerOrder.VolRemaining.ToInvariantString("N0")
							If ownerOrder.Bid = 0 Then
								orderNode.Cells(_assetColumn("AssetPrice")).Text = ownerOrder.Price.ToInvariantString("N2")
								orderNode.Cells(_assetColumn("AssetValue")).Text = (ownerOrder.Price * ownerOrder.VolRemaining).ToInvariantString("N2")
							Else
								orderNode.Cells(_assetColumn("AssetPrice")).Text = ownerOrder.Escrow.ToInvariantString("N2")
								orderNode.Cells(_assetColumn("AssetValue")).Text = (ownerOrder.Escrow * ownerOrder.VolRemaining).ToInvariantString("N2")
							End If
						End If
					End If
				Next
			Next
			' Update order volumes
			buyOrders.Cells(_assetColumn("AssetVolume")).Text = buyVolume.ToInvariantString("N2")
			sellOrders.Cells(_assetColumn("AssetVolume")).Text = sellVolume.ToInvariantString("N2")
			ordersNode.Cells(_assetColumn("AssetVolume")).Text = (buyVolume + sellVolume).ToInvariantString("N2")
			' Update order values
			buyOrders.Cells(_assetColumn("AssetValue")).Text = buyValue.ToInvariantString("N2")
			sellOrders.Cells(_assetColumn("AssetValue")).Text = sellValue.ToInvariantString("N2")
			ordersNode.Cells(_assetColumn("AssetValue")).Text = (buyValue + sellValue).ToInvariantString("N2")
			_totalAssetValue += buyValue + sellValue
			If buyOrders.Nodes.Count > 0 Then
				ordersNode.Nodes.Add(buyOrders)
			End If
			If sellOrders.Nodes.Count > 0 Then
				ordersNode.Nodes.Add(sellOrders)
			End If
			If ordersNode.Nodes.Count > 0 Then
				adtAssets.Nodes.Add(ordersNode)
			End If
		End Sub
		Private Function ParseMarketOrders(ByVal orderOwner As String) As MarketOrdersCollection

			Dim owner As PrismOwner
			Dim newOrderCollection As New MarketOrdersCollection

			If PlugInData.PrismOwners.ContainsKey(orderOwner) = True Then

				owner = PlugInData.PrismOwners(orderOwner)
				Dim ownerAccount As EveHQAccount = PlugInData.GetAccountForCorpOwner(owner, CorpRepType.Orders)
				Dim ownerID As String = PlugInData.GetAccountOwnerIDForCorpOwner(owner, CorpRepType.Orders)
				Dim ordersResponse As NewEveApi.EveServiceResponse(Of IEnumerable(Of NewEveApi.Entities.MarketOrder))
				If ownerAccount IsNot Nothing Then

					If owner.IsCorp = True Then
						ordersResponse = HQ.ApiProvider.Corporation.MarketOrders(ownerAccount.UserID, ownerAccount.APIKey, ownerID.ToInt32())
					Else
						ordersResponse = HQ.ApiProvider.Character.MarketOrders(ownerAccount.UserID, ownerAccount.APIKey, ownerID.ToInt32())
					End If
					If ordersResponse.IsSuccess Then

						For Each order As NewEveApi.Entities.MarketOrder In ordersResponse.ResultData
							Dim newOrder As New Classes.MarketOrder
							newOrder.OrderID = order.OrderId
							newOrder.CharID = order.CharId
							newOrder.StationID = order.StationId
							newOrder.VolEntered = order.QuantityEntered
							newOrder.VolRemaining = order.QuantityRemaining
							newOrder.MinVolume = order.MinQuantity
							newOrder.OrderState = CInt(order.OrderState)
							newOrder.TypeID = order.TypeId
							newOrder.Range = order.Range
							newOrder.AccountKey = order.AccountKey
							newOrder.Duration = CInt(order.Duration.TotalDays)
							newOrder.Escrow = order.Escrow / newOrder.VolRemaining
							newOrder.Price = order.Price
							If order.IsBuyOrder Then
								newOrder.Bid = 1
							Else
								newOrder.Bid = 0
							End If
							newOrder.Issued = order.DateIssued.UtcDateTime
							newOrderCollection.MarketOrders.Add(newOrder)
							If newOrder.Bid = 0 Then ' Sell Order
								newOrderCollection.SellOrders += 1
								newOrderCollection.SellOrderValue += (newOrder.VolRemaining * newOrder.Price)
							Else ' Buy Order (=1)
								newOrderCollection.BuyOrders += 1
								newOrderCollection.BuyOrderValue += (newOrder.VolRemaining * newOrder.Price)
								newOrderCollection.EscrowValue += (newOrder.Escrow * newOrder.VolRemaining)
							End If
						Next
						newOrderCollection.TotalOrders = newOrderCollection.BuyOrders + newOrderCollection.SellOrders
					End If
				End If
			End If

			Return newOrderCollection

		End Function
		Private Sub DisplayResearch()
			Dim researchNode As New Node
			researchNode.Tag = "Research"
			researchNode.Text = "Assets in Research"
			CreateNodeCells(researchNode)
			Dim researchValue As Double = 0

			For Each cPilot As ListViewItem In PSCAssetOwners.ItemList.CheckedItems

				' Get the owner we will use
				Dim owner As String = cPilot.Text

				' Get the JobList
				Dim jobList As List(Of Classes.IndustryJob) = Classes.IndustryJob.ParseIndustryJobs(owner)
				If jobList IsNot Nothing Then
					Dim category, group As String
					Dim eveLocation As SolarSystem

					' get the job prices as a batch 
					'  Dim priceData As Task(Of Dictionary(Of String, Double)) = Core.DataFunctions.GetMarketPrices(From j As IndustryJob In JobList Where j.ActivityID <> 8 Select CStr(j.InstalledItemTypeID))
					' priceData.Wait()
					' Dim prices As Dictionary(Of String, Double) = priceData.Result

					For Each job As Classes.IndustryJob In jobList
						If job.Status <> NewEveApi.Entities.IndustryJobStatus.Delivered Then
							Dim rNode As New Node
							CreateNodeCells(rNode)
							rNode.Tag = job.BlueprintTypeId.ToString

							Dim researchItem As EveType = StaticData.Types(job.BlueprintTypeId)
							category = StaticData.TypeCats(researchItem.Category)
							group = StaticData.TypeGroups(researchItem.Group)
							' Check for search criteria
							If Not ((_filters.Count > 0 And _catFilters.Contains(category) = False And _groupFilters.Contains(group) = False) Or (_searchText <> "" And researchItem.Name.ToLower.Contains(_searchText.ToLower) = False)) Then
								researchNode.Nodes.Add(rNode)
								rNode.Text = researchItem.Name
								rNode.Cells(_assetColumn("AssetOwner")).Text = owner
								rNode.Cells(_assetColumn("AssetGroup")).Text = group
								rNode.Cells(_assetColumn("AssetCategory")).Text = category
								If job.FacilityId <= Integer.MaxValue AndAlso StaticData.Stations.ContainsKey(CInt(job.FacilityId)) Then
									rNode.Cells(_assetColumn("AssetLocation")).Text = StaticData.Stations(CInt(job.FacilityId)).StationName
									eveLocation = StaticData.SolarSystems(StaticData.Stations(CInt(job.FacilityId)).SystemId)
								Else
									rNode.Cells(_assetColumn("AssetLocation")).Text = "POS in " & StaticData.SolarSystems(job.SolarSystemId).Name
									eveLocation = StaticData.SolarSystems(job.SolarSystemId)
								End If
								If eveLocation IsNot Nothing Then
									rNode.Cells(_assetColumn("AssetSystem")).Text = eveLocation.Name
									rNode.Cells(_assetColumn("AssetConstellation")).Text = StaticData.Constellations(eveLocation.ConstellationId)
									rNode.Cells(_assetColumn("AssetRegion")).Text = StaticData.Regions(eveLocation.RegionId)
									rNode.Cells(_assetColumn("AssetSystemSec")).Text = eveLocation.Security.ToString("N2")
								Else
									rNode.Cells(_assetColumn("AssetSystem")).Text = "Unknown"
									rNode.Cells(_assetColumn("AssetConstellation")).Text = "Unknown"
									rNode.Cells(_assetColumn("AssetRegion")).Text = "Unknown"
									rNode.Cells(_assetColumn("AssetSystemSec")).Text = "Unknown"
								End If
								rNode.Cells(_assetColumn("AssetMeta")).Text = researchItem.MetaLevel.ToInvariantString("N0")
								rNode.Cells(_assetColumn("AssetVolume")).Text = researchItem.Volume.ToInvariantString("N2")
								rNode.Cells(_assetColumn("AssetQuantity")).Text = "1"
								Dim price As Double = 0
								If job.ActivityId = 8 Then
									' Calculate BPC cost
									If PrismSettings.UserSettings.BPCCosts.ContainsKey(job.BlueprintTypeId) Then
										Dim pricerange As Double = PrismSettings.UserSettings.BPCCosts(job.BlueprintTypeId).MaxRunCost - PrismSettings.UserSettings.BPCCosts(job.BlueprintTypeId).MinRunCost
										Dim runrange As Integer = StaticData.Blueprints(job.BlueprintTypeId).MaxProductionLimit - 1
										If runrange = 0 Then
											price = PrismSettings.UserSettings.BPCCosts(job.BlueprintTypeId).MinRunCost
										Else
											price = PrismSettings.UserSettings.BPCCosts(job.BlueprintTypeId).MinRunCost + Math.Round((pricerange / runrange) * (job.Runs - 1), 2, MidpointRounding.AwayFromZero)
										End If
									End If
								Else
									' price = prices(Job.InstalledItemTypeID.ToString)
								End If
								researchValue += price
								rNode.Cells(_assetColumn("AssetPrice")).Text = price.ToInvariantString("N2")
								rNode.Cells(_assetColumn("AssetValue")).Text = price.ToInvariantString("N2")
							End If
							' Check for manufacturing job and store the output items
							If job.ActivityId = 1 Then
								researchValue += DisplayResearchOutput(researchNode, job, owner)
							End If
						End If
					Next
				End If
			Next
			researchNode.Cells(_assetColumn("AssetValue")).Text = researchValue.ToInvariantString("N2")
			If researchNode.Nodes.Count > 0 Then
				adtAssets.Nodes.Add(researchNode)
			End If
			_totalAssetValue += researchValue
		End Sub
		Private Function DisplayResearchOutput(ByVal researchNode As Node, ByVal job As Classes.IndustryJob, ByVal owner As String) As Double
			Dim rNode As New Node
			CreateNodeCells(rNode)
			rNode.Tag = job.ProductTypeId.ToString

			Dim researchItem As EveType = StaticData.Types(job.ProductTypeId)
			Dim category, group As String
			Dim eveLocation As SolarSystem
			category = StaticData.TypeCats(researchItem.Category)
			group = StaticData.TypeGroups(researchItem.Group)
			' Check for search criteria
			If Not ((_filters.Count > 0 And _catFilters.Contains(category) = False And _groupFilters.Contains(group) = False) Or (_searchText <> "" And researchItem.Name.ToLower.Contains(_searchText.ToLower) = False)) Then
				researchNode.Nodes.Add(rNode)
				rNode.Text = researchItem.Name
				rNode.Cells(_assetColumn("AssetOwner")).Text = owner
				rNode.Cells(_assetColumn("AssetGroup")).Text = group
				rNode.Cells(_assetColumn("AssetCategory")).Text = category
				If job.FacilityId <= Integer.MaxValue AndAlso StaticData.Stations.ContainsKey(CInt(job.FacilityId)) Then
					rNode.Cells(_assetColumn("AssetLocation")).Text = StaticData.Stations(CInt(job.FacilityId)).StationName
					eveLocation = StaticData.SolarSystems(StaticData.Stations(CInt(job.FacilityId)).SystemId)
				Else
					rNode.Cells(_assetColumn("AssetLocation")).Text = "POS in " & StaticData.SolarSystems(job.SolarSystemId).Name
					eveLocation = StaticData.SolarSystems(job.SolarSystemId)
				End If
				If eveLocation IsNot Nothing Then
					rNode.Cells(_assetColumn("AssetSystem")).Text = eveLocation.Name
					rNode.Cells(_assetColumn("AssetConstellation")).Text = StaticData.Constellations(eveLocation.ConstellationId)
					rNode.Cells(_assetColumn("AssetRegion")).Text = StaticData.Regions(eveLocation.RegionId)
					rNode.Cells(_assetColumn("AssetSystemSec")).Text = eveLocation.Security.ToString("N2")
				Else
					rNode.Cells(_assetColumn("AssetSystem")).Text = "Unknown"
					rNode.Cells(_assetColumn("AssetConstellation")).Text = "Unknown"
					rNode.Cells(_assetColumn("AssetRegion")).Text = "Unknown"
					rNode.Cells(_assetColumn("AssetSystemSec")).Text = "Unknown"
				End If
				rNode.Cells(_assetColumn("AssetMeta")).Text = researchItem.MetaLevel.ToInvariantString("N0")
				rNode.Cells(_assetColumn("AssetVolume")).Text = researchItem.Volume.ToInvariantString("N2")
				rNode.Cells(_assetColumn("AssetQuantity")).Text = (job.Runs * researchItem.PortionSize).ToInvariantString("N0")
				Dim price As Double = DataFunctions.GetPrice(job.ProductTypeId)
				Dim value As Double = job.Runs * researchItem.PortionSize * price
				rNode.Cells(_assetColumn("AssetPrice")).Text = price.ToInvariantString("N2")
				rNode.Cells(_assetColumn("AssetValue")).Text = value.ToInvariantString("N2")
				Return value
			End If
		End Function
		Private Sub DisplayContracts()
			' Add the balances to the assets schedule
			Dim contractsNode As New Node
			Dim contractsValue As Double
			contractsNode.Tag = "Contracts"
			contractsNode.Text = "Contracts"
			CreateNodeCells(contractsNode)

			For Each cPilot As ListViewItem In PSCAssetOwners.ItemList.CheckedItems
				' Get the owner we will use
				Dim owner As String = cPilot.Text
				' Get the orders
				Dim contractsCollection As SortedList(Of Long, Classes.Contract) = Contracts.ParseContracts(owner)
				If contractsCollection IsNot Nothing Then
					' Add the orders (outstanding ones only)
					Dim itemName, category, group, meta, vol As String
					Dim eveLocation As SolarSystem
					For Each ownerContract As Classes.Contract In contractsCollection.Values
						If ownerContract.Status = ContractStatuses.Outstanding Then
							Dim contractNode As New Node
							CreateNodeCells(contractNode)
							contractsNode.Nodes.Add(contractNode)
							contractNode.Tag = ownerContract.ContractID
							If ownerContract.Title <> "" Then
								contractNode.Text = ownerContract.Title
							Else
								contractNode.Text = "Contract ID: " & ownerContract.ContractID
							End If
							contractNode.Text &= " (" & ownerContract.Type.ToString & ")"
							contractNode.Cells(_assetColumn("AssetOwner")).Text = owner
							If StaticData.Stations.ContainsKey(ownerContract.StartStationID) = True Then
								contractNode.Cells(_assetColumn("AssetLocation")).Text = StaticData.Stations(ownerContract.StartStationID).StationName
								eveLocation = StaticData.SolarSystems(StaticData.Stations(ownerContract.StartStationID).SystemId)
							Else
								contractNode.Cells(_assetColumn("AssetLocation")).Text = "StationID: " & ownerContract.StartStationID.ToString
								eveLocation = Nothing
							End If
							If eveLocation IsNot Nothing Then
								contractNode.Cells(_assetColumn("AssetSystem")).Text = eveLocation.Name
								contractNode.Cells(_assetColumn("AssetConstellation")).Text = StaticData.Constellations(eveLocation.ConstellationId)
								contractNode.Cells(_assetColumn("AssetRegion")).Text = StaticData.Regions(eveLocation.RegionId)
								contractNode.Cells(_assetColumn("AssetSystemSec")).Text = eveLocation.Security.ToString("N2")
							Else
								contractNode.Cells(_assetColumn("AssetSystem")).Text = "Unknown"
								contractNode.Cells(_assetColumn("AssetConstellation")).Text = "Unknown"
								contractNode.Cells(_assetColumn("AssetRegion")).Text = "Unknown"
								contractNode.Cells(_assetColumn("AssetSystemSec")).Text = "Unknown"
							End If

							Dim contractValue As Double = 0

							' batch request price data for the collection
							Dim priceTask As Task(Of Dictionary(Of Integer, Double)) = DataFunctions.GetMarketPrices(From item In ownerContract.Items.Keys Select item)
							priceTask.Wait()
							Dim prices As Dictionary(Of Integer, Double) = priceTask.Result
							For Each typeID As Integer In ownerContract.Items.Keys
								If StaticData.Types.ContainsKey(typeID) = True Then
									Dim orderItem As EveType = StaticData.Types(typeID)
									itemName = orderItem.Name
									category = StaticData.TypeCats(orderItem.Category)
									group = StaticData.TypeGroups(orderItem.Group)
									meta = orderItem.MetaLevel.ToString
									vol = orderItem.Volume.ToString
								Else
									itemName = "ItemID: " & typeID
									category = "<Unknown>"
									group = "<Unknown>"
									meta = "0"
									vol = "1"
								End If

								' Check for search criteria
								If Not ((_filters.Count > 0 And _catFilters.Contains(category) = False And _groupFilters.Contains(group) = False) Or (_searchText <> "" And itemName.ToLower.Contains(_searchText.ToLower) = False)) Then
									Dim itemNode As New Node
									CreateNodeCells(itemNode)
									itemNode.Text = itemName
									itemNode.Tag = typeID
									contractNode.Nodes.Add(itemNode)
									itemNode.Cells(_assetColumn("AssetOwner")).Text = owner
									itemNode.Cells(_assetColumn("AssetGroup")).Text = group
									itemNode.Cells(_assetColumn("AssetCategory")).Text = category
									If StaticData.Stations.ContainsKey(ownerContract.StartStationID) = True Then
										itemNode.Cells(_assetColumn("AssetLocation")).Text = StaticData.Stations(ownerContract.StartStationID).StationName
										eveLocation = StaticData.SolarSystems(StaticData.Stations(ownerContract.StartStationID).SystemId)
									Else
										itemNode.Cells(_assetColumn("AssetLocation")).Text = "StationID: " & ownerContract.StartStationID.ToString
										eveLocation = Nothing
									End If
									If eveLocation IsNot Nothing Then
										itemNode.Cells(_assetColumn("AssetSystem")).Text = eveLocation.Name
										itemNode.Cells(_assetColumn("AssetConstellation")).Text = StaticData.Constellations(eveLocation.ConstellationId)
										itemNode.Cells(_assetColumn("AssetRegion")).Text = StaticData.Regions(eveLocation.RegionId)
										itemNode.Cells(_assetColumn("AssetSystemSec")).Text = eveLocation.Security.ToString("N2")
									Else
										itemNode.Cells(_assetColumn("AssetSystem")).Text = "Unknown"
										itemNode.Cells(_assetColumn("AssetConstellation")).Text = "Unknown"
										itemNode.Cells(_assetColumn("AssetRegion")).Text = "Unknown"
										itemNode.Cells(_assetColumn("AssetSystemSec")).Text = "Unknown"
									End If
									itemNode.Cells(_assetColumn("AssetMeta")).Text = meta
									itemNode.Cells(_assetColumn("AssetVolume")).Text = CDbl(vol).ToInvariantString("N2")
									itemNode.Cells(_assetColumn("AssetQuantity")).Text = ownerContract.Items(typeID).ToInvariantString("N0")
									Dim price As Double = prices(typeID)
									itemNode.Cells(_assetColumn("AssetPrice")).Text = price.ToInvariantString("N2")
									itemNode.Cells(_assetColumn("AssetValue")).Text = (ownerContract.Items(typeID) * price).ToInvariantString("N2")
									contractValue += ownerContract.Items(typeID) * price
								End If

							Next
							contractNode.Cells(_assetColumn("AssetValue")).Text = contractValue.ToInvariantString("N2")
						End If
					Next
				End If
			Next
			contractsNode.Cells(_assetColumn("AssetValue")).Text = contractsValue.ToInvariantString("N2")
			_totalAssetValue += contractsValue
			If contractsNode.Nodes.Count > 0 Then
				adtAssets.Nodes.Add(contractsNode)
			End If
		End Sub

#End Region

#Region "Asset Context Menu & UI Routines"
		Private Sub ctxAssets_Opening(ByVal sender As Object, ByVal e As CancelEventArgs) Handles ctxAssets.Opening
			If adtAssets.SelectedNodes.Count > 0 Then
				If adtAssets.SelectedNodes.Count = 1 Then
					If adtAssets.SelectedNodes(0).Cells(_assetColumn("AssetOwner")).Tag IsNot Nothing Then
						Dim itemName As String = adtAssets.SelectedNodes(0).Cells(_assetColumn("AssetOwner")).Tag.ToString
						Dim itemID As Long = CLng(adtAssets.SelectedNodes(0).Tag)
						If itemName <> "Cash Balances" And itemName <> "Investments" Then
							If StaticData.TypeNames.ContainsKey(itemName) = True And itemName <> "Office" And adtAssets.SelectedNodes(0).Cells(_assetColumn("AssetQuantity")).Text <> "" Then
								mnuItemName.Text = itemName
								mnuItemName.Tag = StaticData.TypeNames(itemName)
								mnuAddCustomName.Visible = True
								mnuViewAssetID.Visible = True
								mnuViewInIB.Visible = True
								mnuModifyPrice.Visible = True
								mnuToolSep.Visible = True
								mnuRecycleItem.Enabled = True
								If adtAssets.SelectedNodes(0).Cells(_assetColumn("AssetCategory")).Text = "Ship" Then
									mnuViewInHQF.Visible = True
								Else
									mnuViewInHQF.Visible = False
								End If
								If adtAssets.SelectedNodes(0).Nodes.Count > 0 Then
									mnuRecycleContained.Enabled = True
									mnuRecycleAll.Enabled = True
								Else
									mnuRecycleContained.Enabled = False
									mnuRecycleAll.Enabled = False
								End If
								If PlugInData.AssetItemNames.ContainsKey(itemID) = True Then
									mnuAddCustomName.Text = "Edit Custom Name"
									mnuRemoveCustomName.Visible = True
								Else
									mnuAddCustomName.Text = "Add Custom Name"
									mnuRemoveCustomName.Visible = False
								End If
								mnuAddCustomName.Tag = itemID
								mnuFilterSep.Visible = True
								mnuAddItemToFilter.Visible = True
								mnuAddGroupToFilter.Visible = True
								mnuAddCategoryToFilter.Visible = True
							Else
								mnuItemName.Text = itemName
								mnuAddCustomName.Visible = False
								mnuRemoveCustomName.Visible = False
								mnuViewAssetID.Visible = False
								mnuViewInIB.Visible = False
								mnuViewInHQF.Visible = False
								mnuModifyPrice.Visible = False
								mnuToolSep.Visible = False
								mnuFilterSep.Visible = False
								mnuAddItemToFilter.Visible = False
								mnuAddGroupToFilter.Visible = False
								mnuAddCategoryToFilter.Visible = False
								If adtAssets.SelectedNodes(0).Nodes.Count > 0 Then
									mnuRecycleItem.Enabled = False
									mnuRecycleContained.Enabled = True
									mnuRecycleAll.Enabled = False
								Else
									e.Cancel = True
								End If
							End If
						Else
							e.Cancel = True
						End If
					Else
						e.Cancel = True
					End If
				Else
					mnuItemName.Text = "Multiple Items"
					mnuItemName.Tag = ""
					mnuAddCustomName.Visible = False
					mnuViewAssetID.Visible = False
					mnuViewInIB.Visible = False
					mnuViewInHQF.Visible = False
					mnuModifyPrice.Visible = False
					mnuToolSep.Visible = False
					Dim containerItems As Boolean = False
					For Each item As Node In adtAssets.SelectedNodes
						If item.Nodes.Count > 0 Then
							containerItems = True
							Exit For
						End If
					Next
					If containerItems = True Then
						mnuRecycleContained.Enabled = True
						mnuRecycleAll.Enabled = True
					Else
						mnuRecycleContained.Enabled = False
						mnuRecycleAll.Enabled = False
					End If
					mnuRecycleItem.Enabled = True
					mnuFilterSep.Visible = False
					mnuAddItemToFilter.Visible = False
					mnuAddGroupToFilter.Visible = False
					mnuAddCategoryToFilter.Visible = False
				End If
			Else
				e.Cancel = True
			End If
		End Sub
		Private Sub mnuViewInIB_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuViewInIB.Click

			Dim typeID As Integer = CInt(mnuItemName.Tag)
			Using myIB As New FrmIB(typeID)
				myIB.ShowDialog()
			End Using

		End Sub
		Private Sub mnuModifyPrice_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuModifyPrice.Click
			Using newPrice As New FrmModifyPrice(CInt(mnuItemName.Tag), 0)
				newPrice.ShowDialog()
			End Using
		End Sub
		Private Sub mnuViewInHQF_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuViewInHQF.Click
			If adtAssets.SelectedNodes.Count > 0 Then
				Dim assetID As String = adtAssets.SelectedNodes(0).Tag.ToString
				Dim shipName As String = adtAssets.SelectedNodes(0).Text
				Dim owner As String = adtAssets.SelectedNodes(0).Cells(_assetColumn("AssetOwner")).Text
				_hqfShip = New ArrayList
				Call SearchForShip(assetID, owner)
				' Should have got the ship by now
				_hqfShip.Sort()
				Dim fittedMods As New SortedList
				Dim drones As New SortedList
				Dim chargedMod(1) As String
				For Each fittedMod As String In _hqfShip
					Dim modData() As String = fittedMod.Split(",".ToCharArray)
					If fittedMods.Contains(modData(0)) = False Then
						ReDim chargedMod(1)
						If modData(3) = "8" Then ' Is Charge
							chargedMod(1) = modData(1)
						Else
							chargedMod(0) = modData(1)
						End If
						fittedMods.Add(modData(0), chargedMod)
					Else
						chargedMod = CType(fittedMods(modData(0)), String())
						If modData(3) = "8" Then ' Is Charge
							chargedMod(1) = modData(1)
						Else
							chargedMod(0) = modData(1)
						End If
						fittedMods(modData(0)) = chargedMod
					End If
					If modData(3) = "18" Then ' Is Drone
						If drones.Contains(modData(1)) = True Then
							Dim cdq As Integer = CInt(modData(2))
							Dim tdq As Integer = CInt(drones(modData(1)))
							drones(modData(1)) = (tdq + cdq).ToString
						Else
							drones.Add(modData(1), modData(2))
						End If
					End If
				Next
				Dim list As New StringBuilder
				list.AppendLine("[" & shipName & "," & owner & "'s " & shipName & "]")
				For Each fittedMod As String In _hqfShip
					Dim modData() As String = fittedMod.Split(",".ToCharArray)
					Select Case modData(0)
						Case "Drone Bay"
							' Ignore as we will be adding them later
							'    list.AppendLine(modData(1) & ", " & modData(2) & "i")
						Case "Cargo"
							If modData(3) = "8" Then
								list.AppendLine(modData(1) & ", " & modData(2))
							End If
						Case Else
							If fittedMods.Contains(modData(0)) = True Then
								chargedMod = CType(fittedMods(modData(0)), String())
								If chargedMod(1) = "" Then
									list.AppendLine(chargedMod(0))
								Else
									list.AppendLine(chargedMod(0) & ", " & chargedMod(1))
								End If
								fittedMods.Remove(modData(0))
							End If
					End Select
				Next
				' Add Drones
				For Each drone As String In drones.Keys
					list.AppendLine(drone & ", " & drones(drone).ToString & "i")
				Next
				Clipboard.SetText(list.ToString)
				MessageBox.Show(list.ToString, "Copy To Clipboard Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		End Sub
		Private Sub SearchForShip(ByVal assetID As String, ByVal shipOwner As String)

			Dim owner As PrismOwner

			For Each cOwner As ListViewItem In PSCAssetOwners.ItemList.CheckedItems
				If cOwner.Text = shipOwner Then
					If PlugInData.PrismOwners.ContainsKey(cOwner.Text) = True Then
						owner = PlugInData.PrismOwners(cOwner.Text)
						Dim ownerAccount As EveHQAccount = PlugInData.GetAccountForCorpOwner(owner, CorpRepType.Assets)
						Dim ownerID As String = PlugInData.GetAccountOwnerIDForCorpOwner(owner, CorpRepType.Assets)
						Dim assetResponse As NewEveApi.EveServiceResponse(Of IEnumerable(Of NewEveApi.Entities.AssetItem))
						If ownerAccount IsNot Nothing Then


							If owner.IsCorp = True Then
								assetResponse = HQ.ApiProvider.Corporation.AssetList(ownerAccount.UserID, ownerAccount.APIKey, ownerID.ToInt32())
							Else
								assetResponse = HQ.ApiProvider.Character.AssetList(ownerAccount.UserID, ownerAccount.APIKey, ownerID.ToInt32())
							End If

							If assetResponse IsNot Nothing Then


								If assetResponse.IsSuccess Then
									For Each assetItem As NewEveApi.Entities.AssetItem In assetResponse.ResultData
										' Let's search for our asset!
										If assetItem.TypeId.ToInvariantString() = assetID Then
											' We found our ship so extract the subitem data
											Dim catID As String
											Dim modList As IEnumerable(Of NewEveApi.Entities.AssetItem)
											Dim mods As NewEveApi.Entities.AssetItem
											If assetItem.Contents.Any() Then
												modList = assetItem.Contents
												For Each mods In modList
													Dim itemID As Integer = mods.TypeId
													Dim itemName As String
													If StaticData.Types.ContainsKey(itemID) = True Then
														Dim itemData As EveType = StaticData.Types(itemID)
														itemName = itemData.Name
														catID = itemData.Category.ToString
														Dim flagID As Integer = mods.Flag
														Dim flagName As String = StaticData.ItemMarkers(flagID)
														Dim quantity As String = mods.Quantity.ToInvariantString()
														_hqfShip.Add(flagName & "," & itemName & "," & quantity & "," & catID)
													End If
												Next
											End If
											Exit Sub
										ElseIf assetItem.Contents IsNot Nothing Then
											' Check if this row has child nodes and repeat
											If assetItem.Contents.Any() Then
												Call SearchForShipNode(assetItem, assetID)
												If _hqfShip.Count > 0 Then Exit Sub
											End If
										End If
									Next
								End If


							End If

						End If
					End If
				End If
			Next

		End Sub
		Private Sub SearchForShipNode(ByVal loc As NewEveApi.Entities.AssetItem, ByVal assetID As String)
			Dim subLocList As IEnumerable(Of NewEveApi.Entities.AssetItem)
			Dim subLoc As NewEveApi.Entities.AssetItem
			subLocList = loc.Contents
			For Each subLoc In subLocList
				' Let's search for our asset!
				Try
					If subLoc.ItemId.ToInvariantString() = assetID Then
						' We found our ship so extract the subitem data
						Dim catID As String
						Dim modList As IEnumerable(Of NewEveApi.Entities.AssetItem)
						Dim mods As NewEveApi.Entities.AssetItem
						If subLoc.Contents.Any() Then
							modList = subLoc.Contents
							For Each mods In modList
								Dim typeId As Integer = mods.TypeId
								Dim itemName As String
								If StaticData.Types.ContainsKey(typeId) = True Then
									Dim itemData As EveType = StaticData.Types(typeId)
									itemName = itemData.Name
									catID = itemData.Category.ToString
									Dim flagID As Integer = mods.Flag
									Dim flagName As String = StaticData.ItemMarkers(flagID)
									Dim quantity As String = mods.Quantity.ToInvariantString()
									_hqfShip.Add(flagName & "," & itemName & "," & quantity & "," & catID)
								End If
							Next
						End If
						Exit Sub
					ElseIf subLoc.Contents IsNot Nothing Then
						' Check if this row has child nodes and repeat
						If subLoc.Contents.Any() Then
							Call SearchForShipNode(subLoc, assetID)
						End If
					End If
				Catch ex As Exception
					Dim msg As String = "Unable to parse Asset:" & ControlChars.CrLf
					msg &= "TypeID: " & subLoc.TypeId
					msg &= ex.FormatException()
					Trace.TraceError(msg)
					MessageBox.Show(msg, "Error Getting Ship Information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				End Try
			Next
		End Sub
		Private Sub adtAssets_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles adtAssets.SelectionChanged
			If adtAssets.SelectedNodes.Count > 0 Then
				Dim volume, lineValue, value As Double
				Dim chkParent As Node
				Dim parentFlag As Boolean
				For Each assetNode As Node In adtAssets.SelectedNodes
					parentFlag = False
					chkParent = assetNode.Parent
					Do While chkParent IsNot Nothing
						If chkParent.IsSelected = True Then
							parentFlag = True
							Exit Do
						End If
						chkParent = chkParent.Parent
					Loop
					If parentFlag = False Then
						If assetNode.Cells(_assetColumn("AssetQuantity")).Text <> "" Then
							If assetNode.Cells(_assetColumn("AssetVolume")).Text <> "" Then
								volume += CDbl(assetNode.Cells(_assetColumn("AssetVolume")).Text)
							End If
							lineValue = CDbl(assetNode.Cells(_assetColumn("AssetValue")).Text)
							value += lineValue
						Else
							If assetNode.Cells(_assetColumn("AssetValue")).Text <> "" Then
								If assetNode.Cells(_assetColumn("AssetVolume")).Text <> "" Then
									volume += CDbl(assetNode.Cells(_assetColumn("AssetVolume")).Text)
								End If
								lineValue = CDbl(assetNode.Cells(_assetColumn("AssetValue")).Text)
								value += lineValue
							End If
						End If
					End If
				Next
				lblTotalSelectedAssetValue.Text = "Total Selected Assets: Volume = " & volume.ToInvariantString("N2") & " m³ : Value = " & value.ToInvariantString("N2") & " ISK"
			Else
				lblTotalSelectedAssetValue.Text = "Total Selected Assets: n/a"
			End If
		End Sub
		Private Sub mnuAddCustomName_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuAddCustomName.Click
			Dim assetId As Long = CLng(mnuAddCustomName.Tag)
			Dim assetName As String = mnuItemName.Text
			Using newCustomName As New FrmAssetItemName
				If PlugInData.AssetItemNames.ContainsKey(assetId) = True Then
					newCustomName.Text = "Edit Custom Asset Name"
					newCustomName.EditMode = True
				Else
					newCustomName.Text = "Add Custom Asset Name"
					newCustomName.EditMode = False
				End If
				newCustomName.AssetID = assetId
				newCustomName.AssetName = assetName
				newCustomName.ShowDialog()
				If newCustomName.AssetItemName <> "" Then
					adtAssets.SelectedNodes(0).Text = newCustomName.AssetItemName
				End If
			End Using
		End Sub
		Private Sub mnuRemoveCustomName_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuRemoveCustomName.Click
			Dim assetId As Long = CLng(mnuAddCustomName.Tag)
			Dim itemName As String = mnuItemName.Text
			Dim assetSql As String = "DELETE FROM assetItemNames WHERE itemID=" & assetId & ";"
			If CustomDataFunctions.SetCustomData(assetSql) = -2 Then
				MessageBox.Show("There was an error deleting the record from the Asset Item Names database table. The error was: " & ControlChars.CrLf & ControlChars.CrLf & HQ.DataError & ControlChars.CrLf & ControlChars.CrLf & "Data: " & assetSql, "Error Writing Asset Name Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Else
				PlugInData.AssetItemNames.Remove(assetId)
				adtAssets.SelectedNodes(0).Text = itemName
			End If
		End Sub
		Private Sub adtAssets_ColumnHeaderMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles adtAssets.ColumnHeaderMouseDown
			Dim ch As DevComponents.AdvTree.ColumnHeader = CType(sender, DevComponents.AdvTree.ColumnHeader)
			AdvTreeSorter.Sort(ch, True, False)
		End Sub
		Private Sub mnuViewAssetID_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuViewAssetID.Click
			Dim itemName As String = adtAssets.SelectedNodes(0).Cells(_assetColumn("AssetOwner")).Tag.ToString
			Dim itemText As String = adtAssets.SelectedNodes(0).Text
			Dim itemID As String = adtAssets.SelectedNodes(0).Tag.ToString
			Dim msg As String = "Item Type: " & itemName & ControlChars.CrLf
			If itemText <> itemName Then
				msg &= "Specific Name: " & itemText & ControlChars.CrLf
			End If
			msg &= "Asset ID: " & itemID.ToString & ControlChars.CrLf
			MessageBox.Show(msg, "AssetID Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub
#End Region

#Region "Filter, Owner and Search Routines"
		Private Sub LoadFilterGroups()
			Dim newNode As TreeNode
			tvwFilter.BeginUpdate()
			tvwFilter.Nodes.Clear()
			' Load up the filter with categories
			For Each cat As Integer In StaticData.TypeCats.Keys
				newNode = New TreeNode
				newNode.Name = CStr(cat)
				newNode.Text = StaticData.TypeCats(cat)
				tvwFilter.Nodes.Add(newNode)
			Next
			' Load up the filter with groups
			For Each group As Integer In StaticData.TypeGroups.Keys
				newNode = New TreeNode
				newNode.Name = CStr(group)
				newNode.Text = CStr(StaticData.TypeGroups(group))
				tvwFilter.Nodes(CStr(StaticData.GroupCats(CInt(newNode.Name)))).Nodes.Add(newNode)
			Next
			' Update the filter
			tvwFilter.Sorted = True
			tvwFilter.EndUpdate()
		End Sub
		Private Sub FilterTree()
			Dim cL As Integer = 0
			Dim cLoc As Node
			If adtAssets.Nodes.Count > 0 Then
				Do
					cLoc = adtAssets.Nodes(cL)
					If cLoc.Nodes.Count = 0 Then
						If (_filters.Count > 0 And _catFilters.Contains(cLoc.Cells(_assetColumn("AssetCategory")).Text) = False And _groupFilters.Contains(cLoc.Cells(_assetColumn("AssetGroup")).Text) = False) Or (_searchText <> "" And cLoc.Text.ToLower.Contains(_searchText.ToLower) = False) Then
							adtAssets.Nodes.Remove(cLoc)
							_assetList.Remove(CLng(cLoc.Tag))
							_totalAssetCount -= CLng(cLoc.Cells(_assetColumn("AssetQuantity")).Text)
							cL -= 1
						End If
					Else
						Call FilterNode(cLoc)
						If cLoc.Nodes.Count = 0 Then
							If (_filters.Count > 0 And _catFilters.Contains(cLoc.Cells(_assetColumn("AssetCategory")).Text) = False And _groupFilters.Contains(cLoc.Cells(_assetColumn("AssetGroup")).Text) = False) Or (_searchText <> "" And cLoc.Text.ToLower.Contains(_searchText.ToLower) = False) Then
								adtAssets.Nodes.Remove(cLoc)
								If IsNumeric(cLoc.Cells(_assetColumn("AssetQuantity")).Text) = True Then
									_totalAssetCount -= CLng(cLoc.Cells(_assetColumn("AssetQuantity")).Text)
								End If
								'assetList.Remove(cLoc.Tag)
								cL -= 1
							End If
						Else
							If (_filters.Count > 0 And _catFilters.Contains(cLoc.Cells(_assetColumn("AssetCategory")).Text) = False And _groupFilters.Contains(cLoc.Cells(_assetColumn("AssetGroup")).Text) = False) Or (_searchText <> "" And cLoc.Text.ToLower.Contains(_searchText.ToLower) = False) Then
								If IsNumeric(cLoc.Cells(_assetColumn("AssetQuantity")).Text) = True Then
									_totalAssetCount -= CLng(cLoc.Cells(_assetColumn("AssetQuantity")).Text)
								End If
								' Remove quantity and price information
								cLoc.Cells(_assetColumn("AssetQuantity")).Text = ""
								cLoc.Cells(_assetColumn("AssetPrice")).Text = ""
								'assetList.Remove(cLoc.Tag)
							End If
						End If
					End If
					cL += 1
				Loop Until (cL = adtAssets.Nodes.Count)
			End If
			Call CalcFilteredPrices()
		End Sub
		Private Sub FilterNode(ByVal pLoc As Node)
			Dim cL As Integer = 0
			Dim cLoc As Node
			Do
				cLoc = pLoc.Nodes(cL)
				If cLoc.Nodes.Count = 0 Then
					If (_filters.Count > 0 And _catFilters.Contains(cLoc.Cells(_assetColumn("AssetCategory")).Text) = False And _groupFilters.Contains(cLoc.Cells(_assetColumn("AssetGroup")).Text) = False) Or (_searchText <> "" And cLoc.Text.ToLower.Contains(_searchText.ToLower) = False) Then
						pLoc.Nodes.Remove(cLoc)
						If cLoc.Tag IsNot Nothing Then
							_assetList.Remove(CLng(cLoc.Tag))
						End If
						If IsNumeric(cLoc.Cells(_assetColumn("AssetQuantity")).Text) = True Then
							_totalAssetCount -= CLng(cLoc.Cells(_assetColumn("AssetQuantity")).Text)
						End If
						cL -= 1
					End If
				Else
					Call FilterNode(cLoc)
					If cLoc.Nodes.Count = 0 Then
						If (_filters.Count > 0 And _catFilters.Contains(cLoc.Cells(_assetColumn("AssetCategory")).Text) = False And _groupFilters.Contains(cLoc.Cells(_assetColumn("AssetGroup")).Text) = False) Or (_searchText <> "" And cLoc.Text.ToLower.Contains(_searchText.ToLower) = False) Then
							pLoc.Nodes.Remove(cLoc)
							If cLoc.Tag IsNot Nothing Then
								_assetList.Remove(CLng(cLoc.Tag))
							End If
							If IsNumeric(cLoc.Cells(_assetColumn("AssetQuantity")).Text) = True Then
								_totalAssetCount -= CLng(cLoc.Cells(_assetColumn("AssetQuantity")).Text)
							End If
							cL -= 1
						End If
					Else
						If (_filters.Count > 0 And _catFilters.Contains(cLoc.Cells(_assetColumn("AssetCategory")).Text) = False And _groupFilters.Contains(cLoc.Cells(_assetColumn("AssetGroup")).Text) = False) Or (_searchText <> "" And cLoc.Text.ToLower.Contains(_searchText.ToLower) = False) Then
							If IsNumeric(cLoc.Cells(_assetColumn("AssetQuantity")).Text) = True Then
								_totalAssetCount -= CLng(cLoc.Cells(_assetColumn("AssetQuantity")).Text)
							End If
							' Remove quantity and price information
							cLoc.Cells(_assetColumn("AssetQuantity")).Text = ""
							cLoc.Cells(_assetColumn("AssetPrice")).Text = ""
							If cLoc.Tag IsNot Nothing Then
								_assetList.Remove(CLng(cLoc.Tag))
							End If
						End If
					End If
				End If
				cL += 1
			Loop Until (cL = pLoc.Nodes.Count)
		End Sub
		Private Sub CalcFilteredPrices()
			_totalAssetValue = 0
			Dim locPrice As Double
			For Each cLoc As Node In adtAssets.Nodes
				' Calculate cost of all the sub nodes
				If cLoc.Nodes.Count > 0 Then
					locPrice = CalcNodePrice(cLoc)
					cLoc.Cells(_assetColumn("AssetValue")).Text = locPrice.ToInvariantString("N2")
					_totalAssetValue += locPrice
				End If
			Next
		End Sub
		Private Function CalcNodePrice(ByVal pLoc As Node) As Double
			Dim lineValue As Double
			Dim contValue As Double = 0
			For Each cLoc As Node In pLoc.Nodes
				If cLoc.Nodes.Count > 0 Then
					Call CalcNodePrice(cLoc)
					lineValue = CDbl(cLoc.Cells(_assetColumn("AssetValue")).Text)
					contValue += lineValue
				Else
					If IsNumeric(cLoc.Cells(_assetColumn("AssetPrice")).Text) = True Then
						lineValue = CDbl(cLoc.Cells(_assetColumn("AssetQuantity")).Text) * CDbl(cLoc.Cells(_assetColumn("AssetPrice")).Text)
					Else
						lineValue = 0
					End If
					cLoc.Cells(_assetColumn("AssetValue")).Text = lineValue.ToInvariantString("N2")
					contValue += lineValue
				End If
			Next
			pLoc.Cells(_assetColumn("AssetValue")).Text = contValue.ToInvariantString("N2")
			Return contValue
		End Function
		Private Sub AddFilter()
			Dim cNode As TreeNode = tvwFilter.SelectedNode
			If _filters.Contains(cNode.FullPath) = False Then
				' Add the filter to the list and display it
				_filters.Add(cNode.FullPath)
				lstFilters.Items.Add(cNode.FullPath)
				' Add to the category filter if a category
				If cNode.Nodes.Count > 0 Then
					_catFilters.Add(cNode.Text)
				Else
					_groupFilters.Add(cNode.Text)
				End If
			End If
			Call SetGroupFilterLabel()
		End Sub
		Private Sub RemoveFilter()
			' Check which we are removing
			If lstFilters.SelectedItems.Count = 1 Then
				If lstFilters.SelectedItem.ToString.Contains("\") = True Then
					' Remove the group
					Dim sID As Integer = InStr(lstFilters.SelectedItem.ToString, "\")
					Dim groupName As String = lstFilters.SelectedItem.ToString.Substring(sID)
					_groupFilters.Remove(groupName)
				Else
					' Remove the category
					_catFilters.Remove(lstFilters.SelectedItem.ToString)
				End If
				_filters.Remove(lstFilters.SelectedItem.ToString)
				lstFilters.Items.Remove(lstFilters.SelectedItem.ToString)
				Call SetGroupFilterLabel()
			End If
		End Sub
		Private Sub tvwFilter_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles tvwFilter.NodeMouseClick
			tvwFilter.SelectedNode = e.Node
		End Sub
		Private Sub AddToFilterToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddToFilterToolStripMenuItem.Click
			Call AddFilter()
		End Sub
		Private Sub RemoveFilterToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RemoveFilterToolStripMenuItem.Click
			Call RemoveFilter()
		End Sub
		Private Sub lstFilters_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lstFilters.MouseDoubleClick
			Call RemoveFilter()
		End Sub
		Private Sub tvwFilter_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles tvwFilter.NodeMouseDoubleClick
			Call AddFilter()
		End Sub
		Private Sub SetGroupFilterLabel()
			Dim filter As String = "Group Filter: "
			If lstFilters.Items.Count > 0 Then
				For Each group As String In lstFilters.Items
					filter &= group & ", "
				Next
				filter = filter.TrimEnd(", ".ToCharArray)
			Else
				filter &= "None"
			End If
			lblGroupFilters.Text = filter
		End Sub
		Private Sub btnClearGroupFilters_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClearGroupFilters.Click
			' Remove all items from the list of filters
			lstFilters.Items.Clear()
			' Remove all items from the group and cat filters
			_catFilters.Clear()
			_groupFilters.Clear()
			_filters.Clear()
			Call SetGroupFilterLabel()
		End Sub
		Private Sub ctxFilterList_Opening(ByVal sender As Object, ByVal e As CancelEventArgs) Handles ctxFilterList.Opening
			If lstFilters.SelectedItems.Count = 0 Then
				e.Cancel = True
			End If
		End Sub

		Private Sub RecalcAllPrices()
			_totalAssetValue = 0
			_totalAssetCount = 0
			Dim minSysValue As Double
			Dim filteringEnabled As Boolean = chkMinSystemValue.Checked And Double.TryParse(txtMinSystemValue.Text, minSysValue)
			Dim locPrice As Double

			For Each cLoc As Node In adtAssets.Nodes

				' Calculate cost of all the sub nodes
				If IsNumeric(cLoc.Tag) Then
					If cLoc.Nodes.Count > 0 Then
						locPrice = RecalcNodePrice(cLoc)
						cLoc.Cells(_assetColumn("AssetValue")).Text = locPrice.ToInvariantString("N2")

						If filteringEnabled = True Then
							If locPrice >= minSysValue Then
								cLoc.Visible = True
								_totalAssetValue += locPrice
							Else
								cLoc.Visible = False
								_totalAssetCount -= GetLocationQuantity(cLoc)
							End If
						Else
							_totalAssetValue += locPrice
						End If

					End If
				Else
					If _assetColumn("AssetValue") < cLoc.Cells.Count Then
						If Double.TryParse(cLoc.Cells(_assetColumn("AssetValue")).Text, locPrice) = True Then
							_totalAssetValue += locPrice
						End If
					End If
				End If
			Next

			lblTotalAssetsLabel.Text = TotalValueText.FormatInvariant(_totalAssetValue.ToInvariantString("N2"), _totalAssetCount.ToInvariantString("N0"))

		End Sub
		Private Function RecalcNodePrice(ByVal pLoc As Node) As Double
			Dim lineValue As Double
			Dim contValue As Double = 0
			For Each cLoc As Node In pLoc.Nodes
				If cLoc.Nodes.Count > 0 Then
					If IsNumeric(cLoc.Cells(_assetColumn("AssetQuantity")).Text) = True Then
						_totalAssetCount += CLng(cLoc.Cells(_assetColumn("AssetQuantity")).Text)
					End If
					Call RecalcNodePrice(cLoc)
					lineValue = CDbl(cLoc.Cells(_assetColumn("AssetValue")).Text)
					contValue += lineValue
				Else
					If IsNumeric(cLoc.Cells(_assetColumn("AssetPrice")).Text) = True Then
						lineValue = CDbl(cLoc.Cells(_assetColumn("AssetQuantity")).Text) * CDbl(cLoc.Cells(_assetColumn("AssetPrice")).Text)
						_totalAssetCount += CLng(cLoc.Cells(_assetColumn("AssetQuantity")).Text)
					Else
						lineValue = 0
					End If
					cLoc.Cells(_assetColumn("AssetValue")).Text = lineValue.ToInvariantString("N2")
					contValue += lineValue
				End If
			Next
			If IsNumeric(pLoc.Cells(_assetColumn("AssetPrice")).Text) = True Then
				contValue += CDbl(pLoc.Cells(_assetColumn("AssetPrice")).Text)
			End If
			pLoc.Cells(_assetColumn("AssetValue")).Text = contValue.ToInvariantString("N2")
			Return contValue
		End Function
		Private Function GetLocationQuantity(pNode As Node) As Long
			Dim locQ As Long = 0
			If IsNumeric(pNode.Cells(_assetColumn("AssetQuantity")).Text) = True Then
				locQ += CLng(pNode.Cells(_assetColumn("AssetQuantity")).Text)
			End If
			For Each cNode As Node In pNode.Nodes
				locQ += GetLocationQuantity(cNode)
			Next
			Return locQ
		End Function
		Private Sub mnuAddItemToFilter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuAddItemToFilter.Click
			Dim itemID As Integer = CInt(mnuItemName.Tag)
			Dim itemData As EveType = StaticData.Types(itemID)
			txtSearch.Text = itemData.Name
			Dim minValue As Double
			If Double.TryParse(txtMinSystemValue.Text, minValue) = True Then
				Call RefreshAssets()
			Else
				MessageBox.Show("Minimum System Value is not a valid number. Please try again!", "Error in Minimum Value", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		End Sub
		Private Sub mnuAddGroupToFilter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuAddGroupToFilter.Click
			Dim itemID As Integer = CInt(mnuItemName.Tag)
			Dim itemData As EveType = StaticData.Types(itemID)
			Dim groupName As String = StaticData.TypeGroups(itemData.Group)
			Dim catName As String = StaticData.TypeCats(itemData.Category)
			Dim fullPath As String = catName & "\" & groupName
			Call SetFilterFromMenu(fullPath, True, groupName)
		End Sub
		Private Sub mnuAddCategoryToFilter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuAddCategoryToFilter.Click
			Dim itemID As Integer = CInt(mnuItemName.Tag)
			Dim itemData As EveType = StaticData.Types(itemID)
			Dim fullPath As String = StaticData.TypeCats(itemData.Category)
			Call SetFilterFromMenu(fullPath, False, fullPath)
		End Sub
		Private Sub SetFilterFromMenu(ByVal fullPath As String, ByVal addGroup As Boolean, ByVal filterName As String)
			If _filters.Contains(fullPath) = False Then
				' Add the filter to the list and display it
				_filters.Add(fullPath)
				lstFilters.Items.Add(fullPath)
				' Add to the category filter if a category
				If addGroup = False Then
					_catFilters.Add(filterName)
				Else
					_groupFilters.Add(filterName)
				End If
			End If
			Call SetGroupFilterLabel()
		End Sub
#End Region

#Region "Item Recycler Routines"

		Private Sub mnuRecycleItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuRecycleItem.Click
			Dim recycleList As New SortedList(Of Integer, Long)
			Dim assetName As String
			_tempAssetList.Clear()
			For Each assetNode As Node In adtAssets.SelectedNodes
				assetName = assetNode.Cells(_assetColumn("AssetOwner")).Tag.ToString
				If recycleList.ContainsKey(StaticData.TypeNames(assetName)) = True Then
					If assetNode.Cells(_assetColumn("AssetQuantity")).Text <> "" Then
						If _tempAssetList.Contains(assetNode.Tag.ToString) = False Then
							recycleList(StaticData.TypeNames(assetName)) = CLng(recycleList(StaticData.TypeNames(assetName))) + CLng(assetNode.Cells(_assetColumn("AssetQuantity")).Text)
							_tempAssetList.Add(assetNode.Tag.ToString)
						End If
					End If
				Else
					If assetNode.Cells(_assetColumn("AssetQuantity")).Text <> "" Then
						If _tempAssetList.Contains(assetNode.Tag.ToString) = False Then
							recycleList.Add(StaticData.TypeNames(assetName), CLng(assetNode.Cells(_assetColumn("AssetQuantity")).Text))
							_tempAssetList.Add(assetNode.Tag.ToString)
						End If
					End If
				End If
			Next
			_tempAssetList.Clear()
			' Set properties before triggering the event
			_recyclingAssetList = recycleList
			_recyclingAssetLocation = adtAssets.SelectedNodes(0)
			PrismEvents.StartRecyclingInfoAvailable()
		End Sub

		Private Sub mnuRecycleContained_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuRecycleContained.Click
			Dim recycleList As New SortedList(Of Integer, Long)
			_tempAssetList.Clear()
			For Each assetNode As Node In adtAssets.SelectedNodes
				Call AddItemsToRecycleList(assetNode, recycleList)
			Next
			_tempAssetList.Clear()
			' Set properties before triggering the event
			_recyclingAssetList = recycleList
			_recyclingAssetLocation = adtAssets.SelectedNodes(0)
			PrismEvents.StartRecyclingInfoAvailable()
		End Sub

		Private Sub mnuRecycleAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuRecycleAll.Click
			Dim recycleList As New SortedList(Of Integer, Long)
			Dim assetName As String
			_tempAssetList.Clear()
			For Each assetNode As Node In adtAssets.SelectedNodes
				If assetNode.Cells(_assetColumn("AssetOwner")).Tag IsNot Nothing Then
					assetName = assetNode.Cells(_assetColumn("AssetOwner")).Tag.ToString
					If StaticData.TypeNames.ContainsKey(assetName) = True Then
						If recycleList.ContainsKey(StaticData.TypeNames(assetName)) = True Then
							If assetNode.Cells(_assetColumn("AssetQuantity")).Text <> "" Then
								If _tempAssetList.Contains(assetNode.Tag.ToString) = False Then
									recycleList(StaticData.TypeNames(assetName)) = CLng(recycleList(StaticData.TypeNames(assetName))) + CLng(assetNode.Cells(_assetColumn("AssetQuantity")).Text)
									_tempAssetList.Add(assetNode.Tag.ToString)
								End If
							End If
						Else
							If assetNode.Cells(_assetColumn("AssetQuantity")).Text <> "" Then
								If _tempAssetList.Contains(assetNode.Tag.ToString) = False Then
									recycleList.Add(StaticData.TypeNames(assetName), CLng(assetNode.Cells(_assetColumn("AssetQuantity")).Text))
									_tempAssetList.Add(assetNode.Tag.ToString)
								End If
							End If
						End If
					End If
					Call AddItemsToRecycleList(assetNode, recycleList)
				End If
			Next
			_tempAssetList.Clear()
			' Set properties before triggering the event
			_recyclingAssetList = recycleList
			_recyclingAssetLocation = adtAssets.SelectedNodes(0)
			PrismEvents.StartRecyclingInfoAvailable()
		End Sub

		Private Sub AddItemsToRecycleList(ByVal item As Node, ByRef assetList As SortedList(Of Integer, Long))
			For Each childItem As Node In item.Nodes
				If StaticData.TypeNames.ContainsKey(childItem.Text) = True Then
					If assetList.ContainsKey(StaticData.TypeNames(childItem.Text)) = True Then
						If childItem.Cells(_assetColumn("AssetQuantity")).Text <> "" Then
							If _tempAssetList.Contains(childItem.Tag.ToString) = False Then
								assetList(StaticData.TypeNames(childItem.Text)) = CLng(assetList(StaticData.TypeNames(childItem.Text))) + CLng(childItem.Cells(_assetColumn("AssetQuantity")).Text)
								_tempAssetList.Add(childItem.Tag.ToString)
							End If
						End If
					Else
						If childItem.Cells(_assetColumn("AssetQuantity")).Text <> "" Then
							If _tempAssetList.Contains(childItem.Tag.ToString) = False Then
								assetList.Add(StaticData.TypeNames(childItem.Text), CLng(childItem.Cells(_assetColumn("AssetQuantity")).Text))
								_tempAssetList.Add(childItem.Tag.ToString)
							End If
						End If
					End If
				End If
				If childItem.Nodes.Count > 0 Then
					Call AddItemsToRecycleList(childItem, assetList)
				End If
			Next
		End Sub

#End Region

		Private Sub btnFilters_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFilters.Click
			splitterAssets.Expanded = Not splitterAssets.Expanded
		End Sub

		Private Sub PrismAssetsControl_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' Initialise the user defined slot columns
			Call UpdateAssetSlotColumns()
		End Sub

		Private Sub mnuConfigureColumns_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuConfigureColumns.Click
			' Open options form
			Using mySettings As New FrmPrismSettings
				mySettings.Tag = "nodeAssetColumns"
				mySettings.ShowDialog()
			End Using
			Call RefreshAssets()
		End Sub



#Region "Asset Export Routines"

#Region "Grouped Export"

		Private Sub btiItemName_Click(sender As Object, e As EventArgs) Handles btiItemNameG.Click
			Call ExportGroupedAssets(ExportTypes.TypeName)
		End Sub

		Private Sub btiQuantity_Click(sender As Object, e As EventArgs) Handles btiQuantityG.Click
			Call ExportGroupedAssets(ExportTypes.Quantity)
		End Sub

		Private Sub btiPrice_Click(sender As Object, e As EventArgs) Handles btiPriceG.Click
			Call ExportGroupedAssets(ExportTypes.Price)
		End Sub

		Private Sub btiValue_Click(sender As Object, e As EventArgs) Handles btiValueG.Click
			Call ExportGroupedAssets(ExportTypes.Value)
		End Sub

		Private Sub btiVolume_Click(sender As Object, e As EventArgs) Handles btiVolumeG.Click
			Call ExportGroupedAssets(ExportTypes.Volume)
		End Sub

		Private Sub ExportGroupedAssets(exportType As ExportTypes)

			' Collect all the information
			Dim assetExport As New SortedList(Of String, AssetExportGroupedResult)
			Dim aer As AssetExportGroupedResult
			For Each assetItem As Classes.AssetItem In _exportAssetTable.Values
				If assetExport.ContainsKey(assetItem.TypeName) = False Then
					aer = New AssetExportGroupedResult
					aer.TypeName = assetItem.TypeName
					aer.Price = assetItem.Price
					assetExport.Add(assetItem.TypeName, aer)
				Else
					aer = assetExport(assetItem.TypeName)
				End If
				aer.Locations += 1
				aer.Quantity += assetItem.Quantity
				aer.Volume += CDbl(assetItem.Volume)
				aer.Value += (assetItem.Price * assetItem.Quantity)
			Next

			' Transfer results to something that we can sort
			Dim assets As New ArrayList
			For Each aegr As AssetExportGroupedResult In assetExport.Values
				assets.Add(aegr)
			Next

			' Sort our result depending on the ExportType
			Dim resultsSorter As New ClassSorter
			Select Case exportType
				Case ExportTypes.TypeName
					resultsSorter.SortClasses.Add(New SortClass("TypeName", SortDirection.Ascending))
				Case ExportTypes.Quantity
					resultsSorter.SortClasses.Add(New SortClass("Quantity", SortDirection.Ascending))
				Case ExportTypes.Price
					resultsSorter.SortClasses.Add(New SortClass("Price", SortDirection.Ascending))
				Case ExportTypes.Value
					resultsSorter.SortClasses.Add(New SortClass("Value", SortDirection.Ascending))
				Case ExportTypes.Volume
					resultsSorter.SortClasses.Add(New SortClass("Volume", SortDirection.Ascending))
			End Select
			resultsSorter.SortClasses.Add(New SortClass("TypeName", SortDirection.Ascending))
			assets.Sort(resultsSorter)

			' Select a location for the export
			Dim sfd As New SaveFileDialog
			sfd.Title = "Export Assets"
			sfd.InitialDirectory = HQ.ReportFolder
			Dim filterText As String = "Comma Separated Variable files (*.csv)|*.csv"
			filterText &= "|Tab Separated Variable files (*.txt)|*.txt"
			sfd.Filter = filterText
			sfd.FilterIndex = 0
			sfd.AddExtension = True
			sfd.ShowDialog()
			sfd.CheckPathExists = True
			If sfd.FileName <> "" Then
				Select Case sfd.FilterIndex
					Case 1
						Call ExportGroupedAssets(assets, HQ.Settings.CsvSeparatorChar, sfd.FileName)
					Case 2
						Call ExportGroupedAssets(assets, ControlChars.Tab, sfd.FileName)
				End Select
			End If
			sfd.Dispose()
			MessageBox.Show("Export of Prism Asset data completed!", "Prism Asset Export", MessageBoxButtons.OK, MessageBoxIcon.Information)

		End Sub

		Private Sub ExportGroupedAssets(assets As ArrayList, sepChar As String, fileName As String)

			Try

				Dim sw As New StreamWriter(fileName)
				Dim sb As New StringBuilder

				' Write Header
				sb.Append("TypeName" & sepChar)
				sb.Append("Locations" & sepChar)
				sb.Append("Quantity" & sepChar)
				sb.Append("Price" & sepChar)
				sb.Append("Value" & sepChar)
				sb.Append("Volume" & sepChar)
				sw.WriteLine(sb.ToString)

				' Write assets
				For Each aegr As AssetExportGroupedResult In assets
					sb = New StringBuilder
					sb.Append(aegr.TypeName & sepChar)
					sb.Append(aegr.Locations.ToString & sepChar)
					sb.Append(aegr.Quantity.ToString & sepChar)
					sb.Append(aegr.Price.ToString & sepChar)
					sb.Append(aegr.Value.ToString & sepChar)
					sb.Append(aegr.Volume.ToString & sepChar)
					sw.WriteLine(sb.ToString)
				Next

				' Close file
				sw.Flush()
				sw.Close()
				sw.Dispose()

			Catch ex As Exception
				MessageBox.Show("Error exporting Prism Asset details: " & ex.Message, "Error Exporting Assets", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try

		End Sub

#End Region

#Region "Full Export"

		Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
			Call ExportAssets()
		End Sub

		Private Sub ExportAssets()

			' Collect all the information
			Dim assets As New List(Of AssetExportResult)
			For Each assetItem As Classes.AssetItem In _exportAssetTable.Values
				Dim aer As New AssetExportResult
				aer.Category = assetItem.Category
				aer.Constellation = assetItem.Constellation
				aer.CorpHangar = assetItem.CorpHangar
				aer.Group = assetItem.Group
				aer.Location = assetItem.Location
				aer.MetaLevel = assetItem.Meta
				aer.Price = assetItem.Price
				aer.Quantity = assetItem.Quantity
				aer.Region = assetItem.Region
				aer.Station = assetItem.Station
				aer.System = assetItem.System
				aer.SystemSec = assetItem.SystemSec
				aer.TypeName = assetItem.TypeName
				aer.Value = (assetItem.Price * assetItem.Quantity)
				aer.Volume = CDbl(assetItem.Volume)
				assets.Add(aer)
			Next

			' Sort our result depending on the ExportType

			'Select Case ExportType
			'    Case ExportTypes.TypeName
			'        ResultsSorter.SortClasses.Add(New Core.SortClass("TypeName", Core.SortDirection.Ascending))
			'    Case ExportTypes.Quantity
			'        ResultsSorter.SortClasses.Add(New Core.SortClass("Quantity", Core.SortDirection.Ascending))
			'    Case ExportTypes.Price
			'        ResultsSorter.SortClasses.Add(New Core.SortClass("Price", Core.SortDirection.Ascending))
			'    Case ExportTypes.Value
			'        ResultsSorter.SortClasses.Add(New Core.SortClass("Value", Core.SortDirection.Ascending))
			'    Case ExportTypes.Volume
			'        ResultsSorter.SortClasses.Add(New Core.SortClass("Volume", Core.SortDirection.Ascending))
			'End Select

			assets = assets.OrderBy(Function(asset As AssetExportResult) As String
				Return asset.TypeName
										End Function).ToList()

			' Select a location for the export
			Dim sfd As New SaveFileDialog
			sfd.Title = "Export Assets"
			sfd.InitialDirectory = HQ.ReportFolder
			Dim filterText As String = "Comma Separated Variable files (*.csv)|*.csv"
			filterText &= "|Tab Separated Variable files (*.txt)|*.txt"
			sfd.Filter = filterText
			sfd.FilterIndex = 0
			sfd.AddExtension = True
			sfd.ShowDialog()
			sfd.CheckPathExists = True
			If sfd.FileName <> "" Then
				Select Case sfd.FilterIndex
					Case 1
						Call ExportAssets(assets, HQ.Settings.CsvSeparatorChar, sfd.FileName)
					Case 2
						Call ExportAssets(assets, ControlChars.Tab, sfd.FileName)
				End Select
			End If
			sfd.Dispose()
			MessageBox.Show("Export of Prism Asset data completed!", "Prism Asset Export", MessageBoxButtons.OK, MessageBoxIcon.Information)

		End Sub

		Private Sub ExportAssets(assets As List(Of AssetExportResult), sepChar As String, fileName As String)

			Try

				Dim sw As New StreamWriter(fileName)
				Dim sb As New StringBuilder

				' Write Header
				sb.Append("TypeName" & sepChar)
				sb.Append("Category" & sepChar)
				sb.Append("Group" & sepChar)
				sb.Append("MetaLevel" & sepChar)
				sb.Append("Location" & sepChar)
				sb.Append("CorpHangar" & sepChar)
				sb.Append("Station" & sepChar)
				sb.Append("System" & sepChar)
				sb.Append("Constellation" & sepChar)
				sb.Append("EveGalaticRegion" & sepChar)
				sb.Append("SystemSec" & sepChar)
				sb.Append("Quantity" & sepChar)
				sb.Append("Price" & sepChar)
				sb.Append("Value" & sepChar)
				sb.Append("Volume" & sepChar)
				sw.WriteLine(sb.ToString)

				' Write assets
				For Each aer As AssetExportResult In assets
					sb = New StringBuilder
					sb.Append(aer.TypeName & sepChar)
					sb.Append(aer.Category.ToString & sepChar)
					sb.Append(aer.Group.ToString & sepChar)
					sb.Append(aer.MetaLevel.ToString & sepChar)
					sb.Append(ControlChars.Quote & aer.Location.ToString & ControlChars.Quote & sepChar)
					sb.Append(ControlChars.Quote & aer.CorpHangar.ToString & ControlChars.Quote & sepChar)
					sb.Append(ControlChars.Quote & aer.Station.ToString & ControlChars.Quote & sepChar)
					sb.Append(aer.System.ToString & sepChar)
					sb.Append(aer.Constellation.ToString & sepChar)
					sb.Append(aer.Region.ToString & sepChar)
					sb.Append(aer.SystemSec.ToString & sepChar)
					sb.Append(aer.Quantity.ToString & sepChar)
					sb.Append(aer.Price.ToString & sepChar)
					sb.Append(aer.Value.ToString & sepChar)
					sb.Append(aer.Volume.ToString & sepChar)
					sw.WriteLine(sb.ToString)
				Next

				' Close file
				sw.Flush()
				sw.Close()
				sw.Dispose()

			Catch ex As Exception
				MessageBox.Show("Error exporting Prism Asset details: " & ex.Message, "Error Exporting Assets", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try

		End Sub

#End Region


#End Region

	End Class

	Public Class AssetExportResult
		Public Property TypeName As String
		Public Property Quantity As Long
		Public Property Price As Double
		Public Property Value As Double
		Public Property Volume As Double
		Public Property Location As String
		Public Property CorpHangar As String
		Public Property Station As String
		Public Property System As String
		Public Property Constellation As String
		Public Property Region As String
		Public Property SystemSec As String
		Public Property Group As String
		Public Property Category As String
		Public Property MetaLevel As String
	End Class

	Public Class AssetExportGroupedResult
		' Needs properties to work correctly with sorting
		Public Property TypeName As String
		Public Property Locations As Integer
		Public Property Quantity As Long
		Public Property Price As Double
		Public Property Value As Double
		Public Property Volume As Double
	End Class

	Public Enum ExportTypes As Integer
		TypeName = 0
		Quantity = 1
		Price = 2
		Value = 3
		Volume = 4
		System = 5
		Constellation = 6
		Region = 7
		SecStatus = 8
		Group = 9
		Category = 10
		MetaLevel = 11
		Location = 12
	End Enum

End Namespace