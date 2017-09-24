Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PrismAssetsControl
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim SuperTooltipInfo1 As DevComponents.DotNetBar.SuperTooltipInfo = New DevComponents.DotNetBar.SuperTooltipInfo()
            Me.panelPrismAssets = New DevComponents.DotNetBar.PanelEx()
            Me.btnExport = New DevComponents.DotNetBar.ButtonX()
            Me.chkExcludeContracts = New System.Windows.Forms.CheckBox()
            Me.btnExportGrouped = New DevComponents.DotNetBar.ButtonX()
            Me.btiItemNameG = New DevComponents.DotNetBar.ButtonItem()
            Me.btiQuantityG = New DevComponents.DotNetBar.ButtonItem()
            Me.btiPriceG = New DevComponents.DotNetBar.ButtonItem()
            Me.btiValueG = New DevComponents.DotNetBar.ButtonItem()
            Me.btiVolumeG = New DevComponents.DotNetBar.ButtonItem()
            Me.btnFilters = New DevComponents.DotNetBar.ButtonX()
            Me.btnRefreshAssets = New DevComponents.DotNetBar.ButtonX()
            Me.PSCAssetOwners = New PrismSelectionHostControl()
            Me.lblTotalSelectedAssetValue = New System.Windows.Forms.Label()
            Me.lblTotalAssetsLabel = New System.Windows.Forms.Label()
            Me.adtAssets = New DevComponents.AdvTree.AdvTree()
            Me.colAssetName = New DevComponents.AdvTree.ColumnHeader()
            Me.colAssetOwner = New DevComponents.AdvTree.ColumnHeader()
            Me.colAssetGroup = New DevComponents.AdvTree.ColumnHeader()
            Me.colAssetCategory = New DevComponents.AdvTree.ColumnHeader()
            Me.colAssetLocation = New DevComponents.AdvTree.ColumnHeader()
            Me.colAssetMeta = New DevComponents.AdvTree.ColumnHeader()
            Me.colAssetVolume = New DevComponents.AdvTree.ColumnHeader()
            Me.colAssetQty = New DevComponents.AdvTree.ColumnHeader()
            Me.colAssetPrice = New DevComponents.AdvTree.ColumnHeader()
            Me.colAssetValue = New DevComponents.AdvTree.ColumnHeader()
            Me.ctxAssets = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.mnuItemName = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuAddCustomName = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuRemoveCustomName = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuViewAssetID = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuViewInIB = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuViewInHQF = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuModifyPrice = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuToolSep = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuItemRecycling = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuRecycleItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuRecycleContained = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuRecycleAll = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuFilterSep = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuAddItemToFilter = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuAddGroupToFilter = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuAddCategoryToFilter = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuConfigureColumns = New System.Windows.Forms.ToolStripMenuItem()
            Me.NodeConnector6 = New DevComponents.AdvTree.NodeConnector()
            Me.Asset = New DevComponents.DotNetBar.ElementStyle()
            Me.SelAsset = New DevComponents.DotNetBar.ElementStyle()
            Me.AssetRight = New DevComponents.DotNetBar.ElementStyle()
            Me.AssetCentre = New DevComponents.DotNetBar.ElementStyle()
            Me.chkExcludeResearch = New System.Windows.Forms.CheckBox()
            Me.chkCorpHangarMode = New System.Windows.Forms.CheckBox()
            Me.chkExcludeOrders = New System.Windows.Forms.CheckBox()
            Me.chkExcludeBPs = New System.Windows.Forms.CheckBox()
            Me.lblSearchAssets = New System.Windows.Forms.Label()
            Me.txtMinSystemValue = New System.Windows.Forms.TextBox()
            Me.txtSearch = New System.Windows.Forms.TextBox()
            Me.chkMinSystemValue = New System.Windows.Forms.CheckBox()
            Me.chkExcludeItems = New System.Windows.Forms.CheckBox()
            Me.lblGroupFilters = New System.Windows.Forms.Label()
            Me.chkExcludeCash = New System.Windows.Forms.CheckBox()
            Me.panelAssetFilters = New DevComponents.DotNetBar.PanelEx()
            Me.tvwFilter = New System.Windows.Forms.TreeView()
            Me.ctxFilter = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.AddToFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.lblGroupFilter = New System.Windows.Forms.Label()
            Me.lblSelectedFilters = New System.Windows.Forms.Label()
            Me.btnClearGroupFilters = New System.Windows.Forms.Button()
            Me.lstFilters = New System.Windows.Forms.ListBox()
            Me.ctxFilterList = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.RemoveFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.splitterAssets = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.STT = New DevComponents.DotNetBar.SuperTooltip()
            Me._updateInProgress = New System.Windows.Forms.Panel()
            Me._updateProgressLabel = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.panelPrismAssets.SuspendLayout()
            CType(Me.adtAssets, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ctxAssets.SuspendLayout()
            Me.panelAssetFilters.SuspendLayout()
            Me.ctxFilter.SuspendLayout()
            Me.ctxFilterList.SuspendLayout()
            Me._updateInProgress.SuspendLayout()
            Me.SuspendLayout()
            '
            'panelPrismAssets
            '
            Me.panelPrismAssets.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelPrismAssets.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelPrismAssets.Controls.Add(Me.btnExport)
            Me.panelPrismAssets.Controls.Add(Me.chkExcludeContracts)
            Me.panelPrismAssets.Controls.Add(Me.btnExportGrouped)
            Me.panelPrismAssets.Controls.Add(Me.btnFilters)
            Me.panelPrismAssets.Controls.Add(Me.btnRefreshAssets)
            Me.panelPrismAssets.Controls.Add(Me.PSCAssetOwners)
            Me.panelPrismAssets.Controls.Add(Me.lblTotalSelectedAssetValue)
            Me.panelPrismAssets.Controls.Add(Me.lblTotalAssetsLabel)
            Me.panelPrismAssets.Controls.Add(Me.adtAssets)
            Me.panelPrismAssets.Controls.Add(Me.chkExcludeResearch)
            Me.panelPrismAssets.Controls.Add(Me.chkCorpHangarMode)
            Me.panelPrismAssets.Controls.Add(Me.chkExcludeOrders)
            Me.panelPrismAssets.Controls.Add(Me.chkExcludeBPs)
            Me.panelPrismAssets.Controls.Add(Me.lblSearchAssets)
            Me.panelPrismAssets.Controls.Add(Me.txtMinSystemValue)
            Me.panelPrismAssets.Controls.Add(Me.txtSearch)
            Me.panelPrismAssets.Controls.Add(Me.chkMinSystemValue)
            Me.panelPrismAssets.Controls.Add(Me.chkExcludeItems)
            Me.panelPrismAssets.Controls.Add(Me.lblGroupFilters)
            Me.panelPrismAssets.Controls.Add(Me.chkExcludeCash)
            Me.panelPrismAssets.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelPrismAssets.Location = New System.Drawing.Point(6, 0)
            Me.panelPrismAssets.Name = "panelPrismAssets"
            Me.panelPrismAssets.Size = New System.Drawing.Size(1252, 724)
            Me.panelPrismAssets.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelPrismAssets.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelPrismAssets.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelPrismAssets.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelPrismAssets.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelPrismAssets.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelPrismAssets.Style.GradientAngle = 90
            Me.panelPrismAssets.TabIndex = 0
            '
            'btnExport
            '
            Me.btnExport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnExport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnExport.Location = New System.Drawing.Point(1099, 35)
            Me.btnExport.Name = "btnExport"
            Me.btnExport.Size = New System.Drawing.Size(150, 23)
            Me.btnExport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnExport.TabIndex = 57
            Me.btnExport.Text = "Export Assets (Full)"
            '
            'chkExcludeContracts
            '
            Me.chkExcludeContracts.AutoSize = True
            Me.chkExcludeContracts.BackColor = System.Drawing.Color.Transparent
            Me.chkExcludeContracts.Location = New System.Drawing.Point(541, 59)
            Me.chkExcludeContracts.Name = "chkExcludeContracts"
            Me.chkExcludeContracts.Size = New System.Drawing.Size(113, 17)
            Me.chkExcludeContracts.TabIndex = 56
            Me.chkExcludeContracts.Text = "Exclude Contracts"
            Me.chkExcludeContracts.UseVisualStyleBackColor = False
            '
            'btnExportGrouped
            '
            Me.btnExportGrouped.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnExportGrouped.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnExportGrouped.AntiAlias = True
            Me.btnExportGrouped.AutoExpandOnClick = True
            Me.btnExportGrouped.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnExportGrouped.Location = New System.Drawing.Point(1099, 6)
            Me.btnExportGrouped.Name = "btnExportGrouped"
            Me.btnExportGrouped.Size = New System.Drawing.Size(150, 23)
            Me.btnExportGrouped.SplitButton = True
            Me.btnExportGrouped.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnExportGrouped.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btiItemNameG, Me.btiQuantityG, Me.btiPriceG, Me.btiValueG, Me.btiVolumeG})
            SuperTooltipInfo1.BodyText = "Exports the current asset view to a CSV or TSV file. "
            SuperTooltipInfo1.Color = DevComponents.DotNetBar.eTooltipColor.Yellow
            SuperTooltipInfo1.FooterImage = Global.EveHQ.Prism.My.Resources.Resources.Info32
            SuperTooltipInfo1.FooterText = "Export Assets"
            Me.STT.SetSuperTooltip(Me.btnExportGrouped, SuperTooltipInfo1)
            Me.btnExportGrouped.TabIndex = 55
            Me.btnExportGrouped.Text = "Export Assets (Grouped)"
            '
            'btiItemNameG
            '
            Me.btiItemNameG.Name = "btiItemNameG"
            Me.btiItemNameG.Text = "Order by Item Name"
            '
            'btiQuantityG
            '
            Me.btiQuantityG.Name = "btiQuantityG"
            Me.btiQuantityG.Text = "Order by Quantity"
            '
            'btiPriceG
            '
            Me.btiPriceG.Name = "btiPriceG"
            Me.btiPriceG.Text = "Order by Price"
            '
            'btiValueG
            '
            Me.btiValueG.Name = "btiValueG"
            Me.btiValueG.Text = "Order by Value"
            '
            'btiVolumeG
            '
            Me.btiVolumeG.Name = "btiVolumeG"
            Me.btiVolumeG.Text = "Order by Volume"
            '
            'btnFilters
            '
            Me.btnFilters.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnFilters.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnFilters.Location = New System.Drawing.Point(371, 6)
            Me.btnFilters.Name = "btnFilters"
            Me.btnFilters.Size = New System.Drawing.Size(116, 23)
            Me.btnFilters.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnFilters.TabIndex = 54
            Me.btnFilters.Text = "Toggle Group Filters"
            '
            'btnRefreshAssets
            '
            Me.btnRefreshAssets.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnRefreshAssets.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnRefreshAssets.Location = New System.Drawing.Point(290, 6)
            Me.btnRefreshAssets.Name = "btnRefreshAssets"
            Me.btnRefreshAssets.Size = New System.Drawing.Size(75, 23)
            Me.btnRefreshAssets.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnRefreshAssets.TabIndex = 53
            Me.btnRefreshAssets.Text = "Refresh"
            '
            'PSCAssetOwners
            '
            Me.PSCAssetOwners.AllowMultipleSelections = True
            Me.PSCAssetOwners.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PSCAssetOwners.ListType = PrismSelectionType.AllOwners
            Me.PSCAssetOwners.Location = New System.Drawing.Point(6, 6)
            Me.PSCAssetOwners.Name = "PSCAssetOwners"
            Me.PSCAssetOwners.Size = New System.Drawing.Size(278, 21)
            Me.PSCAssetOwners.TabIndex = 52
            '
            'lblTotalSelectedAssetValue
            '
            Me.lblTotalSelectedAssetValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblTotalSelectedAssetValue.AutoSize = True
            Me.lblTotalSelectedAssetValue.BackColor = System.Drawing.Color.Transparent
            Me.lblTotalSelectedAssetValue.Location = New System.Drawing.Point(6, 705)
            Me.lblTotalSelectedAssetValue.Name = "lblTotalSelectedAssetValue"
            Me.lblTotalSelectedAssetValue.Size = New System.Drawing.Size(138, 13)
            Me.lblTotalSelectedAssetValue.TabIndex = 51
            Me.lblTotalSelectedAssetValue.Text = "Total Selected Asset Value:"
            '
            'lblTotalAssetsLabel
            '
            Me.lblTotalAssetsLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblTotalAssetsLabel.AutoSize = True
            Me.lblTotalAssetsLabel.BackColor = System.Drawing.Color.Transparent
            Me.lblTotalAssetsLabel.Location = New System.Drawing.Point(6, 690)
            Me.lblTotalAssetsLabel.Name = "lblTotalAssetsLabel"
            Me.lblTotalAssetsLabel.Size = New System.Drawing.Size(143, 13)
            Me.lblTotalAssetsLabel.TabIndex = 50
            Me.lblTotalAssetsLabel.Text = "Total Displayed Asset Value:"
            '
            'adtAssets
            '
            Me.adtAssets.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtAssets.AllowDrop = True
            Me.adtAssets.AllowUserToReorderColumns = True
            Me.adtAssets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                          Or System.Windows.Forms.AnchorStyles.Left) _
                                         Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.adtAssets.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtAssets.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtAssets.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtAssets.Columns.Add(Me.colAssetName)
            Me.adtAssets.Columns.Add(Me.colAssetOwner)
            Me.adtAssets.Columns.Add(Me.colAssetGroup)
            Me.adtAssets.Columns.Add(Me.colAssetCategory)
            Me.adtAssets.Columns.Add(Me.colAssetLocation)
            Me.adtAssets.Columns.Add(Me.colAssetMeta)
            Me.adtAssets.Columns.Add(Me.colAssetVolume)
            Me.adtAssets.Columns.Add(Me.colAssetQty)
            Me.adtAssets.Columns.Add(Me.colAssetPrice)
            Me.adtAssets.Columns.Add(Me.colAssetValue)
            Me.adtAssets.ContextMenuStrip = Me.ctxAssets
            Me.adtAssets.DragDropEnabled = False
            Me.adtAssets.DragDropNodeCopyEnabled = False
            Me.adtAssets.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle
            
            Me.adtAssets.Location = New System.Drawing.Point(6, 82)
            Me.adtAssets.MultiSelect = True
            Me.adtAssets.MultiSelectRule = DevComponents.AdvTree.eMultiSelectRule.AnyNode
            Me.adtAssets.Name = "adtAssets"
            Me.adtAssets.NodesConnector = Me.NodeConnector6
            Me.adtAssets.NodeStyle = Me.Asset
            Me.adtAssets.NodeStyleMouseOver = Me.SelAsset
            Me.adtAssets.PathSeparator = ";"
            Me.adtAssets.Size = New System.Drawing.Size(1243, 605)
            Me.adtAssets.Styles.Add(Me.Asset)
            Me.adtAssets.Styles.Add(Me.SelAsset)
            Me.adtAssets.Styles.Add(Me.AssetRight)
            Me.adtAssets.Styles.Add(Me.AssetCentre)
            Me.adtAssets.TabIndex = 49
            Me.adtAssets.Text = "AdvTree1"
            '
            'colAssetName
            '
            Me.colAssetName.DisplayIndex = 1
            Me.colAssetName.Name = "colAssetName"
            Me.colAssetName.SortingEnabled = False
            Me.colAssetName.Text = "Location / Item Name"
            Me.colAssetName.Width.Absolute = 250
            '
            'colAssetOwner
            '
            Me.colAssetOwner.DisplayIndex = 2
            Me.colAssetOwner.Name = "colAssetOwner"
            Me.colAssetOwner.SortingEnabled = False
            Me.colAssetOwner.Text = "Owner"
            Me.colAssetOwner.Width.Absolute = 150
            '
            'colAssetGroup
            '
            Me.colAssetGroup.DisplayIndex = 3
            Me.colAssetGroup.Name = "colAssetGroup"
            Me.colAssetGroup.SortingEnabled = False
            Me.colAssetGroup.Text = "Group"
            Me.colAssetGroup.Width.Absolute = 100
            '
            'colAssetCategory
            '
            Me.colAssetCategory.DisplayIndex = 4
            Me.colAssetCategory.Name = "colAssetCategory"
            Me.colAssetCategory.SortingEnabled = False
            Me.colAssetCategory.Text = "Category"
            Me.colAssetCategory.Width.Absolute = 100
            '
            'colAssetLocation
            '
            Me.colAssetLocation.DisplayIndex = 5
            Me.colAssetLocation.Name = "colAssetLocation"
            Me.colAssetLocation.SortingEnabled = False
            Me.colAssetLocation.Text = "Specific Location"
            Me.colAssetLocation.Width.Absolute = 250
            '
            'colAssetMeta
            '
            Me.colAssetMeta.DisplayIndex = 6
            Me.colAssetMeta.Name = "colAssetMeta"
            Me.colAssetMeta.SortingEnabled = False
            Me.colAssetMeta.Text = "Meta"
            Me.colAssetMeta.Width.Absolute = 50
            '
            'colAssetVolume
            '
            Me.colAssetVolume.DisplayIndex = 7
            Me.colAssetVolume.Name = "colAssetVolume"
            Me.colAssetVolume.SortingEnabled = False
            Me.colAssetVolume.Text = "Volume"
            Me.colAssetVolume.Width.Absolute = 75
            '
            'colAssetQty
            '
            Me.colAssetQty.DisplayIndex = 8
            Me.colAssetQty.Name = "colAssetQty"
            Me.colAssetQty.SortingEnabled = False
            Me.colAssetQty.Text = "Quantity"
            Me.colAssetQty.Width.Absolute = 75
            '
            'colAssetPrice
            '
            Me.colAssetPrice.DisplayIndex = 9
            Me.colAssetPrice.Name = "colAssetPrice"
            Me.colAssetPrice.SortingEnabled = False
            Me.colAssetPrice.Text = "Price"
            Me.colAssetPrice.Width.Absolute = 75
            '
            'colAssetValue
            '
            Me.colAssetValue.DisplayIndex = 10
            Me.colAssetValue.Name = "colAssetValue"
            Me.colAssetValue.SortingEnabled = False
            Me.colAssetValue.Text = "Value"
            Me.colAssetValue.Width.Absolute = 75
            '
            'ctxAssets
            '
            Me.ctxAssets.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemName, Me.ToolStripMenuItem1, Me.mnuAddCustomName, Me.mnuRemoveCustomName, Me.ToolStripMenuItem3, Me.mnuViewAssetID, Me.mnuViewInIB, Me.mnuViewInHQF, Me.mnuModifyPrice, Me.mnuToolSep, Me.mnuItemRecycling, Me.mnuFilterSep, Me.mnuAddItemToFilter, Me.mnuAddGroupToFilter, Me.mnuAddCategoryToFilter, Me.ToolStripMenuItem2, Me.mnuConfigureColumns})
            Me.ctxAssets.Name = "ctxAssets"
            Me.ctxAssets.Size = New System.Drawing.Size(198, 298)
            '
            'mnuItemName
            '
            Me.mnuItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
            Me.mnuItemName.Name = "mnuItemName"
            Me.mnuItemName.Size = New System.Drawing.Size(197, 22)
            Me.mnuItemName.Text = "Item Name"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(194, 6)
            '
            'mnuAddCustomName
            '
            Me.mnuAddCustomName.Name = "mnuAddCustomName"
            Me.mnuAddCustomName.Size = New System.Drawing.Size(197, 22)
            Me.mnuAddCustomName.Text = "Add Custom Name"
            '
            'mnuRemoveCustomName
            '
            Me.mnuRemoveCustomName.Name = "mnuRemoveCustomName"
            Me.mnuRemoveCustomName.Size = New System.Drawing.Size(197, 22)
            Me.mnuRemoveCustomName.Text = "Remove Custom Name"
            '
            'ToolStripMenuItem3
            '
            Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
            Me.ToolStripMenuItem3.Size = New System.Drawing.Size(194, 6)
            '
            'mnuViewAssetID
            '
            Me.mnuViewAssetID.Name = "mnuViewAssetID"
            Me.mnuViewAssetID.Size = New System.Drawing.Size(197, 22)
            Me.mnuViewAssetID.Text = "View AssetID"
            '
            'mnuViewInIB
            '
            Me.mnuViewInIB.Name = "mnuViewInIB"
            Me.mnuViewInIB.Size = New System.Drawing.Size(197, 22)
            Me.mnuViewInIB.Text = "View In Item Browser"
            '
            'mnuViewInHQF
            '
            Me.mnuViewInHQF.Name = "mnuViewInHQF"
            Me.mnuViewInHQF.Size = New System.Drawing.Size(197, 22)
            Me.mnuViewInHQF.Text = "Copy Setup for HQF"
            '
            'mnuModifyPrice
            '
            Me.mnuModifyPrice.Name = "mnuModifyPrice"
            Me.mnuModifyPrice.Size = New System.Drawing.Size(197, 22)
            Me.mnuModifyPrice.Text = "Modify Custom Price"
            '
            'mnuToolSep
            '
            Me.mnuToolSep.Name = "mnuToolSep"
            Me.mnuToolSep.Size = New System.Drawing.Size(194, 6)
            '
            'mnuItemRecycling
            '
            Me.mnuItemRecycling.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRecycleItem, Me.mnuRecycleContained, Me.mnuRecycleAll})
            Me.mnuItemRecycling.Name = "mnuItemRecycling"
            Me.mnuItemRecycling.Size = New System.Drawing.Size(197, 22)
            Me.mnuItemRecycling.Text = "Recycling Profitability"
            '
            'mnuRecycleItem
            '
            Me.mnuRecycleItem.Name = "mnuRecycleItem"
            Me.mnuRecycleItem.Size = New System.Drawing.Size(169, 22)
            Me.mnuRecycleItem.Text = "Current Item"
            '
            'mnuRecycleContained
            '
            Me.mnuRecycleContained.Enabled = False
            Me.mnuRecycleContained.Name = "mnuRecycleContained"
            Me.mnuRecycleContained.Size = New System.Drawing.Size(169, 22)
            Me.mnuRecycleContained.Text = "Contained Items"
            '
            'mnuRecycleAll
            '
            Me.mnuRecycleAll.Enabled = False
            Me.mnuRecycleAll.Name = "mnuRecycleAll"
            Me.mnuRecycleAll.Size = New System.Drawing.Size(169, 22)
            Me.mnuRecycleAll.Text = "Container + Items"
            '
            'mnuFilterSep
            '
            Me.mnuFilterSep.Name = "mnuFilterSep"
            Me.mnuFilterSep.Size = New System.Drawing.Size(194, 6)
            '
            'mnuAddItemToFilter
            '
            Me.mnuAddItemToFilter.Name = "mnuAddItemToFilter"
            Me.mnuAddItemToFilter.Size = New System.Drawing.Size(197, 22)
            Me.mnuAddItemToFilter.Text = "Search for this Item"
            '
            'mnuAddGroupToFilter
            '
            Me.mnuAddGroupToFilter.Name = "mnuAddGroupToFilter"
            Me.mnuAddGroupToFilter.Size = New System.Drawing.Size(197, 22)
            Me.mnuAddGroupToFilter.Text = "Add Group to Filter"
            '
            'mnuAddCategoryToFilter
            '
            Me.mnuAddCategoryToFilter.Name = "mnuAddCategoryToFilter"
            Me.mnuAddCategoryToFilter.Size = New System.Drawing.Size(197, 22)
            Me.mnuAddCategoryToFilter.Text = "Add Category to Filter"
            '
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(194, 6)
            '
            'mnuConfigureColumns
            '
            Me.mnuConfigureColumns.Name = "mnuConfigureColumns"
            Me.mnuConfigureColumns.Size = New System.Drawing.Size(197, 22)
            Me.mnuConfigureColumns.Text = "Configure Columns"
            '
            'NodeConnector6
            '
            Me.NodeConnector6.LineColor = System.Drawing.SystemColors.ControlText
            '
            'Asset
            '
            Me.Asset.BackColorGradientAngle = 90
            Me.Asset.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
            Me.Asset.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.Asset.Name = "Asset"
            Me.Asset.TextColor = System.Drawing.SystemColors.ControlText
            '
            'SelAsset
            '
            Me.SelAsset.BackColor = System.Drawing.Color.LightGreen
            Me.SelAsset.BackColor2 = System.Drawing.Color.LightGreen
            Me.SelAsset.BackColorGradientAngle = 90
            Me.SelAsset.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
            Me.SelAsset.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.SelAsset.Name = "SelAsset"
            Me.SelAsset.WordWrap = True
            '
            'AssetRight
            '
            Me.AssetRight.BackColorGradientAngle = 90
            Me.AssetRight.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
            Me.AssetRight.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.AssetRight.Name = "AssetRight"
            Me.AssetRight.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Far
            Me.AssetRight.TextColor = System.Drawing.SystemColors.ControlText
            '
            'AssetCentre
            '
            Me.AssetCentre.BackColorGradientAngle = 90
            Me.AssetCentre.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
            Me.AssetCentre.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.AssetCentre.Name = "AssetCentre"
            Me.AssetCentre.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.AssetCentre.TextColor = System.Drawing.SystemColors.ControlText
            '
            'chkExcludeResearch
            '
            Me.chkExcludeResearch.AutoSize = True
            Me.chkExcludeResearch.BackColor = System.Drawing.Color.Transparent
            Me.chkExcludeResearch.Location = New System.Drawing.Point(424, 59)
            Me.chkExcludeResearch.Name = "chkExcludeResearch"
            Me.chkExcludeResearch.Size = New System.Drawing.Size(111, 17)
            Me.chkExcludeResearch.TabIndex = 48
            Me.chkExcludeResearch.Text = "Exclude Research"
            Me.chkExcludeResearch.UseVisualStyleBackColor = False
            '
            'chkCorpHangarMode
            '
            Me.chkCorpHangarMode.AutoSize = True
            Me.chkCorpHangarMode.BackColor = System.Drawing.Color.Transparent
            Me.chkCorpHangarMode.Checked = True
            Me.chkCorpHangarMode.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkCorpHangarMode.Location = New System.Drawing.Point(493, 9)
            Me.chkCorpHangarMode.Name = "chkCorpHangarMode"
            Me.chkCorpHangarMode.Size = New System.Drawing.Size(116, 17)
            Me.chkCorpHangarMode.TabIndex = 47
            Me.chkCorpHangarMode.Text = "Corp Hangar Mode"
            Me.chkCorpHangarMode.UseVisualStyleBackColor = False
            '
            'chkExcludeOrders
            '
            Me.chkExcludeOrders.AutoSize = True
            Me.chkExcludeOrders.BackColor = System.Drawing.Color.Transparent
            Me.chkExcludeOrders.Location = New System.Drawing.Point(319, 59)
            Me.chkExcludeOrders.Name = "chkExcludeOrders"
            Me.chkExcludeOrders.Size = New System.Drawing.Size(99, 17)
            Me.chkExcludeOrders.TabIndex = 46
            Me.chkExcludeOrders.Text = "Exclude Orders"
            Me.chkExcludeOrders.UseVisualStyleBackColor = False
            '
            'chkExcludeBPs
            '
            Me.chkExcludeBPs.AutoSize = True
            Me.chkExcludeBPs.BackColor = System.Drawing.Color.Transparent
            Me.chkExcludeBPs.Location = New System.Drawing.Point(104, 59)
            Me.chkExcludeBPs.Name = "chkExcludeBPs"
            Me.chkExcludeBPs.Size = New System.Drawing.Size(112, 17)
            Me.chkExcludeBPs.TabIndex = 35
            Me.chkExcludeBPs.Text = "Exclude BP Values"
            Me.chkExcludeBPs.UseVisualStyleBackColor = False
            '
            'lblSearchAssets
            '
            Me.lblSearchAssets.AutoSize = True
            Me.lblSearchAssets.BackColor = System.Drawing.Color.Transparent
            Me.lblSearchAssets.Location = New System.Drawing.Point(3, 36)
            Me.lblSearchAssets.Name = "lblSearchAssets"
            Me.lblSearchAssets.Size = New System.Drawing.Size(44, 13)
            Me.lblSearchAssets.TabIndex = 36
            Me.lblSearchAssets.Text = "Search:"
            '
            'txtMinSystemValue
            '
            Me.txtMinSystemValue.Location = New System.Drawing.Point(779, 56)
            Me.txtMinSystemValue.Name = "txtMinSystemValue"
            Me.txtMinSystemValue.Size = New System.Drawing.Size(135, 21)
            Me.txtMinSystemValue.TabIndex = 43
            Me.txtMinSystemValue.Text = "0.00"
            Me.txtMinSystemValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSearch
            '
            Me.txtSearch.Location = New System.Drawing.Point(53, 33)
            Me.txtSearch.Name = "txtSearch"
            Me.txtSearch.Size = New System.Drawing.Size(231, 21)
            Me.txtSearch.TabIndex = 37
            '
            'chkMinSystemValue
            '
            Me.chkMinSystemValue.AutoSize = True
            Me.chkMinSystemValue.BackColor = System.Drawing.Color.Transparent
            Me.chkMinSystemValue.Location = New System.Drawing.Point(660, 59)
            Me.chkMinSystemValue.Name = "chkMinSystemValue"
            Me.chkMinSystemValue.Size = New System.Drawing.Size(113, 17)
            Me.chkMinSystemValue.TabIndex = 42
            Me.chkMinSystemValue.Text = "Min. System Value"
            Me.chkMinSystemValue.UseVisualStyleBackColor = False
            '
            'chkExcludeItems
            '
            Me.chkExcludeItems.AutoSize = True
            Me.chkExcludeItems.BackColor = System.Drawing.Color.Transparent
            Me.chkExcludeItems.Location = New System.Drawing.Point(6, 59)
            Me.chkExcludeItems.Name = "chkExcludeItems"
            Me.chkExcludeItems.Size = New System.Drawing.Size(93, 17)
            Me.chkExcludeItems.TabIndex = 41
            Me.chkExcludeItems.Text = "Exclude Items"
            Me.chkExcludeItems.UseVisualStyleBackColor = False
            '
            'lblGroupFilters
            '
            Me.lblGroupFilters.AutoSize = True
            Me.lblGroupFilters.BackColor = System.Drawing.Color.Transparent
            Me.lblGroupFilters.Location = New System.Drawing.Point(290, 36)
            Me.lblGroupFilters.Name = "lblGroupFilters"
            Me.lblGroupFilters.Size = New System.Drawing.Size(95, 13)
            Me.lblGroupFilters.TabIndex = 39
            Me.lblGroupFilters.Text = "Group Filter: None"
            '
            'chkExcludeCash
            '
            Me.chkExcludeCash.AutoSize = True
            Me.chkExcludeCash.BackColor = System.Drawing.Color.Transparent
            Me.chkExcludeCash.Location = New System.Drawing.Point(223, 59)
            Me.chkExcludeCash.Name = "chkExcludeCash"
            Me.chkExcludeCash.Size = New System.Drawing.Size(90, 17)
            Me.chkExcludeCash.TabIndex = 40
            Me.chkExcludeCash.Text = "Exclude Cash"
            Me.chkExcludeCash.UseVisualStyleBackColor = False
            '
            'panelAssetFilters
            '
            Me.panelAssetFilters.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelAssetFilters.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelAssetFilters.Controls.Add(Me.tvwFilter)
            Me.panelAssetFilters.Controls.Add(Me.lblGroupFilter)
            Me.panelAssetFilters.Controls.Add(Me.lblSelectedFilters)
            Me.panelAssetFilters.Controls.Add(Me.btnClearGroupFilters)
            Me.panelAssetFilters.Controls.Add(Me.lstFilters)
            Me.panelAssetFilters.Dock = System.Windows.Forms.DockStyle.Left
            Me.panelAssetFilters.Location = New System.Drawing.Point(0, 0)
            Me.panelAssetFilters.Name = "panelAssetFilters"
            Me.panelAssetFilters.Size = New System.Drawing.Size(500, 724)
            Me.panelAssetFilters.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelAssetFilters.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelAssetFilters.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelAssetFilters.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelAssetFilters.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelAssetFilters.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelAssetFilters.Style.GradientAngle = 90
            Me.panelAssetFilters.TabIndex = 2
            Me.panelAssetFilters.Visible = False
            '
            'tvwFilter
            '
            Me.tvwFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                         Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.tvwFilter.ContextMenuStrip = Me.ctxFilter
            Me.tvwFilter.Location = New System.Drawing.Point(3, 18)
            Me.tvwFilter.Name = "tvwFilter"
            Me.tvwFilter.Size = New System.Drawing.Size(189, 700)
            Me.tvwFilter.TabIndex = 22
            '
            'ctxFilter
            '
            Me.ctxFilter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToFilterToolStripMenuItem})
            Me.ctxFilter.Name = "ctxFilter"
            Me.ctxFilter.Size = New System.Drawing.Size(143, 26)
            '
            'AddToFilterToolStripMenuItem
            '
            Me.AddToFilterToolStripMenuItem.Name = "AddToFilterToolStripMenuItem"
            Me.AddToFilterToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
            Me.AddToFilterToolStripMenuItem.Text = "Add To Filter"
            '
            'lblGroupFilter
            '
            Me.lblGroupFilter.AutoSize = True
            Me.lblGroupFilter.BackColor = System.Drawing.Color.Transparent
            Me.lblGroupFilter.Location = New System.Drawing.Point(0, 2)
            Me.lblGroupFilter.Name = "lblGroupFilter"
            Me.lblGroupFilter.Size = New System.Drawing.Size(67, 13)
            Me.lblGroupFilter.TabIndex = 23
            Me.lblGroupFilter.Text = "Group Filter:"
            '
            'lblSelectedFilters
            '
            Me.lblSelectedFilters.AutoSize = True
            Me.lblSelectedFilters.BackColor = System.Drawing.Color.Transparent
            Me.lblSelectedFilters.Location = New System.Drawing.Point(195, 2)
            Me.lblSelectedFilters.Name = "lblSelectedFilters"
            Me.lblSelectedFilters.Size = New System.Drawing.Size(116, 13)
            Me.lblSelectedFilters.TabIndex = 25
            Me.lblSelectedFilters.Text = "Selected Group Filters:"
            '
            'btnClearGroupFilters
            '
            Me.btnClearGroupFilters.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnClearGroupFilters.Location = New System.Drawing.Point(198, 695)
            Me.btnClearGroupFilters.Name = "btnClearGroupFilters"
            Me.btnClearGroupFilters.Size = New System.Drawing.Size(75, 23)
            Me.btnClearGroupFilters.TabIndex = 28
            Me.btnClearGroupFilters.Text = "Clear All"
            Me.btnClearGroupFilters.UseVisualStyleBackColor = True
            '
            'lstFilters
            '
            Me.lstFilters.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                           Or System.Windows.Forms.AnchorStyles.Left) _
                                          Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lstFilters.ContextMenuStrip = Me.ctxFilterList
            Me.lstFilters.FormattingEnabled = True
            Me.lstFilters.Location = New System.Drawing.Point(198, 18)
            Me.lstFilters.Name = "lstFilters"
            Me.lstFilters.Size = New System.Drawing.Size(296, 667)
            Me.lstFilters.Sorted = True
            Me.lstFilters.TabIndex = 24
            '
            'ctxFilterList
            '
            Me.ctxFilterList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveFilterToolStripMenuItem})
            Me.ctxFilterList.Name = "ctxFilterList"
            Me.ctxFilterList.Size = New System.Drawing.Size(147, 26)
            '
            'RemoveFilterToolStripMenuItem
            '
            Me.RemoveFilterToolStripMenuItem.Name = "RemoveFilterToolStripMenuItem"
            Me.RemoveFilterToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
            Me.RemoveFilterToolStripMenuItem.Text = "Remove Filter"
            '
            'splitterAssets
            '
            Me.splitterAssets.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.splitterAssets.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.splitterAssets.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.splitterAssets.ExpandableControl = Me.panelAssetFilters
            Me.splitterAssets.ExpandActionDoubleClick = True
            Me.splitterAssets.Expanded = False
            Me.splitterAssets.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.splitterAssets.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.splitterAssets.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.splitterAssets.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.splitterAssets.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.splitterAssets.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.splitterAssets.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.splitterAssets.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.splitterAssets.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer))
            Me.splitterAssets.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.splitterAssets.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.splitterAssets.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.splitterAssets.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.splitterAssets.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.splitterAssets.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.splitterAssets.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.splitterAssets.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.splitterAssets.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.splitterAssets.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.splitterAssets.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.splitterAssets.Location = New System.Drawing.Point(0, 0)
            Me.splitterAssets.Name = "splitterAssets"
            Me.splitterAssets.Size = New System.Drawing.Size(6, 724)
            Me.splitterAssets.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.splitterAssets.TabIndex = 3
            Me.splitterAssets.TabStop = False
            '
            'STT
            '
            
            '
            '_updateInProgress
            '
            Me._updateInProgress.Controls.Add(Me.Label1)
            Me._updateInProgress.Controls.Add(Me._updateProgressLabel)
            Me._updateInProgress.Location = New System.Drawing.Point(380, 242)
            Me._updateInProgress.Name = "_updateInProgress"
            Me._updateInProgress.Size = New System.Drawing.Size(517, 186)
            Me._updateInProgress.TabIndex = 4
            Me._updateInProgress.Visible = False
            '
            '_updateProgressLabel
            '
            Me._updateProgressLabel.AutoSize = True
            Me._updateProgressLabel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._updateProgressLabel.Location = New System.Drawing.Point(147, 50)
            Me._updateProgressLabel.Name = "_updateProgressLabel"
            Me._updateProgressLabel.Size = New System.Drawing.Size(223, 23)
            Me._updateProgressLabel.TabIndex = 0
            Me._updateProgressLabel.Text = "Asset update in progress."
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(39, 107)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(439, 23)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Please wait while price data and filtering is applied."
            '
            'PrismAssetsControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me._updateInProgress)
            Me.Controls.Add(Me.panelPrismAssets)
            Me.Controls.Add(Me.splitterAssets)
            Me.Controls.Add(Me.panelAssetFilters)
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "PrismAssetsControl"
            Me.Size = New System.Drawing.Size(1258, 724)
            Me.panelPrismAssets.ResumeLayout(False)
            Me.panelPrismAssets.PerformLayout()
            CType(Me.adtAssets, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ctxAssets.ResumeLayout(False)
            Me.panelAssetFilters.ResumeLayout(False)
            Me.panelAssetFilters.PerformLayout()
            Me.ctxFilter.ResumeLayout(False)
            Me.ctxFilterList.ResumeLayout(False)
            Me._updateInProgress.ResumeLayout(False)
            Me._updateInProgress.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblTotalSelectedAssetValue As System.Windows.Forms.Label
        Friend WithEvents lblTotalAssetsLabel As System.Windows.Forms.Label
        Friend WithEvents NodeConnector6 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents Asset As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents SelAsset As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents chkExcludeResearch As System.Windows.Forms.CheckBox
        Friend WithEvents chkCorpHangarMode As System.Windows.Forms.CheckBox
        Friend WithEvents chkExcludeOrders As System.Windows.Forms.CheckBox
        Friend WithEvents chkExcludeBPs As System.Windows.Forms.CheckBox
        Friend WithEvents lblSearchAssets As System.Windows.Forms.Label
        Friend WithEvents txtMinSystemValue As System.Windows.Forms.TextBox
        Friend WithEvents txtSearch As System.Windows.Forms.TextBox
        Friend WithEvents chkMinSystemValue As System.Windows.Forms.CheckBox
        Friend WithEvents chkExcludeItems As System.Windows.Forms.CheckBox
        Friend WithEvents lblGroupFilters As System.Windows.Forms.Label
        Friend WithEvents chkExcludeCash As System.Windows.Forms.CheckBox
        Friend WithEvents ctxAssets As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents mnuItemName As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuAddCustomName As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuRemoveCustomName As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuViewInIB As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuViewInHQF As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuModifyPrice As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuToolSep As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuItemRecycling As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuRecycleItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuRecycleContained As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuRecycleAll As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuFilterSep As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuAddItemToFilter As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuAddGroupToFilter As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuAddCategoryToFilter As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tvwFilter As System.Windows.Forms.TreeView
        Friend WithEvents lblGroupFilter As System.Windows.Forms.Label
        Friend WithEvents lblSelectedFilters As System.Windows.Forms.Label
        Friend WithEvents btnClearGroupFilters As System.Windows.Forms.Button
        Friend WithEvents lstFilters As System.Windows.Forms.ListBox
        Friend WithEvents ctxFilterList As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents RemoveFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ctxFilter As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents AddToFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents PSCAssetOwners As PrismSelectionHostControl
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuConfigureColumns As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuViewAssetID As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents chkExcludeContracts As System.Windows.Forms.CheckBox
        Friend WithEvents AssetRight As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents AssetCentre As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents _updateInProgress As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents _updateProgressLabel As System.Windows.Forms.Label
        Private WithEvents panelPrismAssets As DevComponents.DotNetBar.PanelEx
        Private WithEvents adtAssets As DevComponents.AdvTree.AdvTree
        Private WithEvents colAssetName As DevComponents.AdvTree.ColumnHeader
        Private WithEvents colAssetOwner As DevComponents.AdvTree.ColumnHeader
        Private WithEvents colAssetGroup As DevComponents.AdvTree.ColumnHeader
        Private WithEvents colAssetCategory As DevComponents.AdvTree.ColumnHeader
        Private WithEvents colAssetLocation As DevComponents.AdvTree.ColumnHeader
        Private WithEvents colAssetMeta As DevComponents.AdvTree.ColumnHeader
        Private WithEvents colAssetVolume As DevComponents.AdvTree.ColumnHeader
        Private WithEvents colAssetQty As DevComponents.AdvTree.ColumnHeader
        Private WithEvents colAssetPrice As DevComponents.AdvTree.ColumnHeader
        Private WithEvents colAssetValue As DevComponents.AdvTree.ColumnHeader
        Private WithEvents panelAssetFilters As DevComponents.DotNetBar.PanelEx
        Private WithEvents splitterAssets As DevComponents.DotNetBar.ExpandableSplitter
        Private WithEvents btnExportGrouped As DevComponents.DotNetBar.ButtonX
        Private WithEvents btiItemNameG As DevComponents.DotNetBar.ButtonItem
        Private WithEvents btiQuantityG As DevComponents.DotNetBar.ButtonItem
        Private WithEvents btiValueG As DevComponents.DotNetBar.ButtonItem
        Private WithEvents btiVolumeG As DevComponents.DotNetBar.ButtonItem
        Private WithEvents btnFilters As DevComponents.DotNetBar.ButtonX
        Private WithEvents btnRefreshAssets As DevComponents.DotNetBar.ButtonX
        Private WithEvents STT As DevComponents.DotNetBar.SuperTooltip
        Private WithEvents btiPriceG As DevComponents.DotNetBar.ButtonItem
        Private WithEvents btnExport As DevComponents.DotNetBar.ButtonX

    End Class
End NameSpace