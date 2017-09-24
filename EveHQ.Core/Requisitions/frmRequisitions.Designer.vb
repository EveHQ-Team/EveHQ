Namespace Requisitions
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmRequisitions
        Inherits DevComponents.DotNetBar.Office2007Form

        'Form overrides dispose to clean up the component list.
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRequisitions))
            Me.btnAddReq = New DevComponents.DotNetBar.ButtonX()
            Me.panelReqOrders = New DevComponents.DotNetBar.PanelEx()
            Me.adtOrders = New DevComponents.AdvTree.AdvTree()
            Me.colItemName = New DevComponents.AdvTree.ColumnHeader()
            Me.colItemQuantity = New DevComponents.AdvTree.ColumnHeader()
            Me.colItemMetaLevel = New DevComponents.AdvTree.ColumnHeader()
            Me.colItemVolume = New DevComponents.AdvTree.ColumnHeader()
            Me.colItemUnitCost = New DevComponents.AdvTree.ColumnHeader()
            Me.colItemTotalCost = New DevComponents.AdvTree.ColumnHeader()
            Me.colItemOwned = New DevComponents.AdvTree.ColumnHeader()
            Me.colItemSurplus = New DevComponents.AdvTree.ColumnHeader()
            Me.colSurplusCost = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector2 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle2 = New DevComponents.DotNetBar.ElementStyle()
            Me.panelReqOrderConfig = New DevComponents.DotNetBar.PanelEx()
            Me.chkDroneBay = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.chkCargoBay = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.chkFittedModules = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.chkAssembledShips = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.lblShipExclusions = New DevComponents.DotNetBar.LabelX()
            Me.lblAssetOwner = New DevComponents.DotNetBar.LabelX()
            Me.cboAssetSelection = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.panelLeft = New DevComponents.DotNetBar.PanelEx()
            Me.ExpandableSplitter2 = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.panelReqInfo = New DevComponents.DotNetBar.PanelEx()
            Me.grpSummary = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.lblUniqueItems = New DevComponents.DotNetBar.LabelX()
            Me.lblTotalItems = New DevComponents.DotNetBar.LabelX()
            Me.lblTotalCost = New DevComponents.DotNetBar.LabelX()
            Me.lblTotalVolume = New DevComponents.DotNetBar.LabelX()
            Me.lblTotalItemsLbl = New DevComponents.DotNetBar.LabelX()
            Me.lblTotalCostLbl = New DevComponents.DotNetBar.LabelX()
            Me.lblTotalVolumeLbl = New DevComponents.DotNetBar.LabelX()
            Me.lblUniqueItemsLbl = New DevComponents.DotNetBar.LabelX()
            Me.lblSummary = New DevComponents.DotNetBar.LabelX()
            Me.panelReqs = New DevComponents.DotNetBar.PanelEx()
            Me.adtReqs = New DevComponents.AdvTree.AdvTree()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me.panelReqFunctions = New DevComponents.DotNetBar.PanelEx()
            Me.btnMerge = New DevComponents.DotNetBar.ButtonX()
            Me.btnExportReq = New DevComponents.DotNetBar.ButtonX()
            Me.btnExportTSV = New DevComponents.DotNetBar.ButtonItem()
            Me.btnExportCSV = New DevComponents.DotNetBar.ButtonItem()
            Me.btnExportEveHQ = New DevComponents.DotNetBar.ButtonItem()
            Me.btnImportEveHQ = New DevComponents.DotNetBar.ButtonItem()
            Me.btnCopyReq = New DevComponents.DotNetBar.ButtonX()
            Me.btnDeleteReq = New DevComponents.DotNetBar.ButtonX()
            Me.btnEditReq = New DevComponents.DotNetBar.ButtonX()
            Me.epReqFilter = New DevComponents.DotNetBar.ExpandablePanel()
            Me.btnResetFilter = New DevComponents.DotNetBar.ButtonX()
            Me.btnApplyFilter = New DevComponents.DotNetBar.ButtonX()
            Me.txtSearch = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.lblItemSearch = New DevComponents.DotNetBar.LabelX()
            Me.cboSource = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblSource = New DevComponents.DotNetBar.LabelX()
            Me.cboRequestor = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblRequestor = New DevComponents.DotNetBar.LabelX()
            Me.cboRequisition = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblName = New DevComponents.DotNetBar.LabelX()
            Me.ExpandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.panelReqOrders.SuspendLayout()
            CType(Me.adtOrders, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelReqOrderConfig.SuspendLayout()
            Me.panelLeft.SuspendLayout()
            Me.panelReqInfo.SuspendLayout()
            Me.grpSummary.SuspendLayout()
            Me.panelReqs.SuspendLayout()
            CType(Me.adtReqs, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelReqFunctions.SuspendLayout()
            Me.epReqFilter.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnAddReq
            '
            Me.btnAddReq.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnAddReq.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnAddReq.Location = New System.Drawing.Point(3, 6)
            Me.btnAddReq.Name = "btnAddReq"
            Me.btnAddReq.Size = New System.Drawing.Size(40, 23)
            Me.btnAddReq.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnAddReq.TabIndex = 0
            Me.btnAddReq.Text = "New"
            Me.btnAddReq.Tooltip = "Adds a new requisition"
            '
            'panelReqOrders
            '
            Me.panelReqOrders.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelReqOrders.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelReqOrders.Controls.Add(Me.adtOrders)
            Me.panelReqOrders.Controls.Add(Me.panelReqOrderConfig)
            Me.panelReqOrders.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelReqOrders.Location = New System.Drawing.Point(324, 0)
            Me.panelReqOrders.Name = "panelReqOrders"
            Me.panelReqOrders.Size = New System.Drawing.Size(960, 714)
            Me.panelReqOrders.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelReqOrders.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelReqOrders.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelReqOrders.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelReqOrders.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelReqOrders.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelReqOrders.Style.GradientAngle = 90
            Me.panelReqOrders.TabIndex = 1
            '
            'adtOrders
            '
            Me.adtOrders.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtOrders.AllowDrop = True
            Me.adtOrders.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtOrders.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtOrders.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtOrders.Columns.Add(Me.colItemName)
            Me.adtOrders.Columns.Add(Me.colItemQuantity)
            Me.adtOrders.Columns.Add(Me.colItemMetaLevel)
            Me.adtOrders.Columns.Add(Me.colItemVolume)
            Me.adtOrders.Columns.Add(Me.colItemUnitCost)
            Me.adtOrders.Columns.Add(Me.colItemTotalCost)
            Me.adtOrders.Columns.Add(Me.colItemOwned)
            Me.adtOrders.Columns.Add(Me.colItemSurplus)
            Me.adtOrders.Columns.Add(Me.colSurplusCost)
            Me.adtOrders.Dock = System.Windows.Forms.DockStyle.Fill
            Me.adtOrders.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle
            
            Me.adtOrders.Location = New System.Drawing.Point(0, 68)
            Me.adtOrders.Name = "adtOrders"
            Me.adtOrders.NodesConnector = Me.NodeConnector2
            Me.adtOrders.NodeStyle = Me.ElementStyle2
            Me.adtOrders.PathSeparator = ";"
            Me.adtOrders.Size = New System.Drawing.Size(960, 646)
            Me.adtOrders.Styles.Add(Me.ElementStyle2)
            Me.adtOrders.TabIndex = 0
            Me.adtOrders.Text = "AdvTree1"
            '
            'colItemName
            '
            Me.colItemName.DisplayIndex = 1
            Me.colItemName.Name = "colItemName"
            Me.colItemName.SortingEnabled = False
            Me.colItemName.Text = "Item Name"
            Me.colItemName.Width.Absolute = 250
            '
            'colItemQuantity
            '
            Me.colItemQuantity.DisplayIndex = 2
            Me.colItemQuantity.Name = "colItemQuantity"
            Me.colItemQuantity.SortingEnabled = False
            Me.colItemQuantity.Text = "Quantity"
            Me.colItemQuantity.Width.Absolute = 75
            '
            'colItemMetaLevel
            '
            Me.colItemMetaLevel.DisplayIndex = 3
            Me.colItemMetaLevel.Name = "colItemMetaLevel"
            Me.colItemMetaLevel.SortingEnabled = False
            Me.colItemMetaLevel.Text = "Meta"
            Me.colItemMetaLevel.Width.Absolute = 50
            '
            'colItemVolume
            '
            Me.colItemVolume.DisplayIndex = 4
            Me.colItemVolume.Name = "colItemVolume"
            Me.colItemVolume.SortingEnabled = False
            Me.colItemVolume.Text = "Volume"
            Me.colItemVolume.Width.Absolute = 100
            '
            'colItemUnitCost
            '
            Me.colItemUnitCost.DisplayIndex = 5
            Me.colItemUnitCost.Name = "colItemUnitCost"
            Me.colItemUnitCost.SortingEnabled = False
            Me.colItemUnitCost.Text = "Unit Cost"
            Me.colItemUnitCost.Width.Absolute = 120
            '
            'colItemTotalCost
            '
            Me.colItemTotalCost.DisplayIndex = 6
            Me.colItemTotalCost.Name = "colItemTotalCost"
            Me.colItemTotalCost.SortingEnabled = False
            Me.colItemTotalCost.Text = "Total Cost"
            Me.colItemTotalCost.Width.Absolute = 120
            '
            'colItemOwned
            '
            Me.colItemOwned.DisplayIndex = 7
            Me.colItemOwned.Name = "colItemOwned"
            Me.colItemOwned.SortingEnabled = False
            Me.colItemOwned.Text = "Owned"
            Me.colItemOwned.Width.Absolute = 80
            '
            'colItemSurplus
            '
            Me.colItemSurplus.DisplayIndex = 8
            Me.colItemSurplus.Name = "colItemSurplus"
            Me.colItemSurplus.SortingEnabled = False
            Me.colItemSurplus.Text = "Surplus"
            Me.colItemSurplus.Width.Absolute = 80
            '
            'colSurplusCost
            '
            Me.colSurplusCost.DisplayIndex = 9
            Me.colSurplusCost.Name = "colSurplusCost"
            Me.colSurplusCost.SortingEnabled = False
            Me.colSurplusCost.Text = "Surplus Cost"
            Me.colSurplusCost.Width.Absolute = 120
            '
            'NodeConnector2
            '
            Me.NodeConnector2.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle2
            '
            Me.ElementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle2.Name = "ElementStyle2"
            Me.ElementStyle2.TextColor = System.Drawing.SystemColors.ControlText
            '
            'panelReqOrderConfig
            '
            Me.panelReqOrderConfig.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelReqOrderConfig.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelReqOrderConfig.Controls.Add(Me.chkDroneBay)
            Me.panelReqOrderConfig.Controls.Add(Me.chkCargoBay)
            Me.panelReqOrderConfig.Controls.Add(Me.chkFittedModules)
            Me.panelReqOrderConfig.Controls.Add(Me.chkAssembledShips)
            Me.panelReqOrderConfig.Controls.Add(Me.lblShipExclusions)
            Me.panelReqOrderConfig.Controls.Add(Me.lblAssetOwner)
            Me.panelReqOrderConfig.Controls.Add(Me.cboAssetSelection)
            Me.panelReqOrderConfig.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelReqOrderConfig.Location = New System.Drawing.Point(0, 0)
            Me.panelReqOrderConfig.Name = "panelReqOrderConfig"
            Me.panelReqOrderConfig.Size = New System.Drawing.Size(960, 68)
            Me.panelReqOrderConfig.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelReqOrderConfig.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelReqOrderConfig.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelReqOrderConfig.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelReqOrderConfig.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelReqOrderConfig.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelReqOrderConfig.Style.GradientAngle = 90
            Me.panelReqOrderConfig.TabIndex = 3
            '
            'chkDroneBay
            '
            Me.chkDroneBay.AutoSize = True
            '
            '
            '
            Me.chkDroneBay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkDroneBay.Location = New System.Drawing.Point(386, 41)
            Me.chkDroneBay.Name = "chkDroneBay"
            Me.chkDroneBay.Size = New System.Drawing.Size(73, 16)
            Me.chkDroneBay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkDroneBay.TabIndex = 8
            Me.chkDroneBay.Text = "Drone Bay"
            '
            'chkCargoBay
            '
            Me.chkCargoBay.AutoSize = True
            '
            '
            '
            Me.chkCargoBay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkCargoBay.Location = New System.Drawing.Point(308, 41)
            Me.chkCargoBay.Name = "chkCargoBay"
            Me.chkCargoBay.Size = New System.Drawing.Size(72, 16)
            Me.chkCargoBay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkCargoBay.TabIndex = 7
            Me.chkCargoBay.Text = "Cargo Bay"
            '
            'chkFittedModules
            '
            Me.chkFittedModules.AutoSize = True
            '
            '
            '
            Me.chkFittedModules.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkFittedModules.Location = New System.Drawing.Point(209, 41)
            Me.chkFittedModules.Name = "chkFittedModules"
            Me.chkFittedModules.Size = New System.Drawing.Size(93, 16)
            Me.chkFittedModules.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkFittedModules.TabIndex = 6
            Me.chkFittedModules.Text = "Fitted Modules"
            '
            'chkAssembledShips
            '
            Me.chkAssembledShips.AutoSize = True
            '
            '
            '
            Me.chkAssembledShips.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkAssembledShips.Location = New System.Drawing.Point(99, 41)
            Me.chkAssembledShips.Name = "chkAssembledShips"
            Me.chkAssembledShips.Size = New System.Drawing.Size(104, 16)
            Me.chkAssembledShips.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkAssembledShips.TabIndex = 5
            Me.chkAssembledShips.Text = "Assembled Ships"
            '
            'lblShipExclusions
            '
            Me.lblShipExclusions.AutoSize = True
            '
            '
            '
            Me.lblShipExclusions.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblShipExclusions.Location = New System.Drawing.Point(13, 41)
            Me.lblShipExclusions.Name = "lblShipExclusions"
            Me.lblShipExclusions.Size = New System.Drawing.Size(80, 16)
            Me.lblShipExclusions.TabIndex = 4
            Me.lblShipExclusions.Text = "Ship Exclusions:"
            '
            'lblAssetOwner
            '
            Me.lblAssetOwner.AutoSize = True
            '
            '
            '
            Me.lblAssetOwner.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblAssetOwner.Location = New System.Drawing.Point(13, 13)
            Me.lblAssetOwner.Name = "lblAssetOwner"
            Me.lblAssetOwner.Size = New System.Drawing.Size(79, 16)
            Me.lblAssetOwner.TabIndex = 1
            Me.lblAssetOwner.Text = "Asset Selection:"
            '
            'cboAssetSelection
            '
            Me.cboAssetSelection.DisplayMember = "Text"
            Me.cboAssetSelection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboAssetSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboAssetSelection.FormattingEnabled = True
            Me.cboAssetSelection.ItemHeight = 15
            Me.cboAssetSelection.Location = New System.Drawing.Point(98, 11)
            Me.cboAssetSelection.Name = "cboAssetSelection"
            Me.cboAssetSelection.Size = New System.Drawing.Size(246, 21)
            Me.cboAssetSelection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboAssetSelection.TabIndex = 2
            '
            'panelLeft
            '
            Me.panelLeft.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelLeft.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelLeft.Controls.Add(Me.ExpandableSplitter2)
            Me.panelLeft.Controls.Add(Me.panelReqs)
            Me.panelLeft.Controls.Add(Me.panelReqInfo)
            Me.panelLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.panelLeft.Location = New System.Drawing.Point(0, 0)
            Me.panelLeft.Name = "panelLeft"
            Me.panelLeft.Size = New System.Drawing.Size(318, 714)
            Me.panelLeft.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelLeft.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelLeft.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelLeft.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelLeft.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelLeft.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelLeft.Style.GradientAngle = 90
            Me.panelLeft.TabIndex = 2
            '
            'ExpandableSplitter2
            '
            Me.ExpandableSplitter2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(182, Byte), Integer))
            Me.ExpandableSplitter2.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter2.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandableSplitter2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.ExpandableSplitter2.ExpandableControl = Me.panelReqInfo
            Me.ExpandableSplitter2.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(182, Byte), Integer))
            Me.ExpandableSplitter2.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter2.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ExpandableSplitter2.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter2.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ExpandableSplitter2.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter2.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(213, Byte), Integer))
            Me.ExpandableSplitter2.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter2.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer))
            Me.ExpandableSplitter2.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.ExpandableSplitter2.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.ExpandableSplitter2.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.ExpandableSplitter2.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(182, Byte), Integer))
            Me.ExpandableSplitter2.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter2.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ExpandableSplitter2.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter2.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(182, Byte), Integer))
            Me.ExpandableSplitter2.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter2.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(213, Byte), Integer))
            Me.ExpandableSplitter2.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter2.Location = New System.Drawing.Point(0, 553)
            Me.ExpandableSplitter2.Name = "ExpandableSplitter2"
            Me.ExpandableSplitter2.Size = New System.Drawing.Size(318, 6)
            Me.ExpandableSplitter2.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.ExpandableSplitter2.TabIndex = 1
            Me.ExpandableSplitter2.TabStop = False
            '
            'panelReqInfo
            '
            Me.panelReqInfo.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelReqInfo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelReqInfo.Controls.Add(Me.grpSummary)
            Me.panelReqInfo.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelReqInfo.Location = New System.Drawing.Point(0, 559)
            Me.panelReqInfo.Name = "panelReqInfo"
            Me.panelReqInfo.Size = New System.Drawing.Size(318, 155)
            Me.panelReqInfo.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelReqInfo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelReqInfo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelReqInfo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelReqInfo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelReqInfo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelReqInfo.Style.GradientAngle = 90
            Me.panelReqInfo.TabIndex = 2
            '
            'grpSummary
            '
            Me.grpSummary.CanvasColor = System.Drawing.SystemColors.Control
            Me.grpSummary.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.grpSummary.Controls.Add(Me.lblUniqueItems)
            Me.grpSummary.Controls.Add(Me.lblTotalItems)
            Me.grpSummary.Controls.Add(Me.lblTotalCost)
            Me.grpSummary.Controls.Add(Me.lblTotalVolume)
            Me.grpSummary.Controls.Add(Me.lblTotalItemsLbl)
            Me.grpSummary.Controls.Add(Me.lblTotalCostLbl)
            Me.grpSummary.Controls.Add(Me.lblTotalVolumeLbl)
            Me.grpSummary.Controls.Add(Me.lblUniqueItemsLbl)
            Me.grpSummary.Controls.Add(Me.lblSummary)
            Me.grpSummary.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grpSummary.IsShadowEnabled = True
            Me.grpSummary.Location = New System.Drawing.Point(0, 0)
            Me.grpSummary.Name = "grpSummary"
            Me.grpSummary.Size = New System.Drawing.Size(318, 155)
            '
            '
            '
            Me.grpSummary.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.grpSummary.Style.BackColorGradientAngle = 90
            Me.grpSummary.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.grpSummary.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpSummary.Style.BorderBottomWidth = 1
            Me.grpSummary.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.grpSummary.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpSummary.Style.BorderLeftWidth = 1
            Me.grpSummary.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpSummary.Style.BorderRightWidth = 1
            Me.grpSummary.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpSummary.Style.BorderTopWidth = 1
            Me.grpSummary.Style.CornerDiameter = 4
            Me.grpSummary.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.grpSummary.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.grpSummary.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.grpSummary.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.grpSummary.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.grpSummary.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.grpSummary.TabIndex = 0
            '
            'lblUniqueItems
            '
            Me.lblUniqueItems.AutoSize = True
            '
            '
            '
            Me.lblUniqueItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblUniqueItems.Location = New System.Drawing.Point(106, 32)
            Me.lblUniqueItems.Name = "lblUniqueItems"
            Me.lblUniqueItems.Size = New System.Drawing.Size(19, 16)
            Me.lblUniqueItems.TabIndex = 8
            Me.lblUniqueItems.Text = "n/a"
            '
            'lblTotalItems
            '
            Me.lblTotalItems.AutoSize = True
            '
            '
            '
            Me.lblTotalItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblTotalItems.Location = New System.Drawing.Point(106, 54)
            Me.lblTotalItems.Name = "lblTotalItems"
            Me.lblTotalItems.Size = New System.Drawing.Size(19, 16)
            Me.lblTotalItems.TabIndex = 7
            Me.lblTotalItems.Text = "n/a"
            '
            'lblTotalCost
            '
            Me.lblTotalCost.AutoSize = True
            '
            '
            '
            Me.lblTotalCost.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblTotalCost.Location = New System.Drawing.Point(106, 76)
            Me.lblTotalCost.Name = "lblTotalCost"
            Me.lblTotalCost.Size = New System.Drawing.Size(51, 29)
            Me.lblTotalCost.TabIndex = 6
            Me.lblTotalCost.Text = "Total: n/a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reqd: n/a"
            '
            'lblTotalVolume
            '
            Me.lblTotalVolume.AutoSize = True
            '
            '
            '
            Me.lblTotalVolume.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblTotalVolume.Location = New System.Drawing.Point(106, 111)
            Me.lblTotalVolume.Name = "lblTotalVolume"
            Me.lblTotalVolume.Size = New System.Drawing.Size(51, 29)
            Me.lblTotalVolume.TabIndex = 5
            Me.lblTotalVolume.Text = "Total: n/a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reqd: n/a"
            '
            'lblTotalItemsLbl
            '
            Me.lblTotalItemsLbl.AutoSize = True
            '
            '
            '
            Me.lblTotalItemsLbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblTotalItemsLbl.Location = New System.Drawing.Point(20, 54)
            Me.lblTotalItemsLbl.Name = "lblTotalItemsLbl"
            Me.lblTotalItemsLbl.Size = New System.Drawing.Size(62, 16)
            Me.lblTotalItemsLbl.TabIndex = 4
            Me.lblTotalItemsLbl.Text = "Total Items:"
            '
            'lblTotalCostLbl
            '
            Me.lblTotalCostLbl.AutoSize = True
            '
            '
            '
            Me.lblTotalCostLbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblTotalCostLbl.Location = New System.Drawing.Point(20, 82)
            Me.lblTotalCostLbl.Name = "lblTotalCostLbl"
            Me.lblTotalCostLbl.Size = New System.Drawing.Size(55, 16)
            Me.lblTotalCostLbl.TabIndex = 3
            Me.lblTotalCostLbl.Text = "Total Cost:"
            '
            'lblTotalVolumeLbl
            '
            Me.lblTotalVolumeLbl.AutoSize = True
            '
            '
            '
            Me.lblTotalVolumeLbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblTotalVolumeLbl.Location = New System.Drawing.Point(20, 117)
            Me.lblTotalVolumeLbl.Name = "lblTotalVolumeLbl"
            Me.lblTotalVolumeLbl.Size = New System.Drawing.Size(70, 16)
            Me.lblTotalVolumeLbl.TabIndex = 2
            Me.lblTotalVolumeLbl.Text = "Total Volume:"
            '
            'lblUniqueItemsLbl
            '
            Me.lblUniqueItemsLbl.AutoSize = True
            '
            '
            '
            Me.lblUniqueItemsLbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblUniqueItemsLbl.Location = New System.Drawing.Point(20, 32)
            Me.lblUniqueItemsLbl.Name = "lblUniqueItemsLbl"
            Me.lblUniqueItemsLbl.Size = New System.Drawing.Size(71, 16)
            Me.lblUniqueItemsLbl.TabIndex = 1
            Me.lblUniqueItemsLbl.Text = "Unique Items:"
            '
            'lblSummary
            '
            Me.lblSummary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                          Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSummary.BackColor = System.Drawing.Color.DimGray
            '
            '
            '
            Me.lblSummary.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblSummary.ForeColor = System.Drawing.Color.White
            Me.lblSummary.Image = Global.EveHQ.Core.My.Resources.Resources.Orders32
            Me.lblSummary.Location = New System.Drawing.Point(9, 3)
            Me.lblSummary.Name = "lblSummary"
            Me.lblSummary.Size = New System.Drawing.Size(289, 23)
            Me.lblSummary.TabIndex = 0
            Me.lblSummary.Text = "Requisition Summary"
            '
            'panelReqs
            '
            Me.panelReqs.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelReqs.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelReqs.Controls.Add(Me.adtReqs)
            Me.panelReqs.Controls.Add(Me.panelReqFunctions)
            Me.panelReqs.Controls.Add(Me.epReqFilter)
            Me.panelReqs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelReqs.Location = New System.Drawing.Point(0, 0)
            Me.panelReqs.Name = "panelReqs"
            Me.panelReqs.Size = New System.Drawing.Size(318, 559)
            Me.panelReqs.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelReqs.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelReqs.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelReqs.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelReqs.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelReqs.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelReqs.Style.GradientAngle = 90
            Me.panelReqs.TabIndex = 0
            '
            'adtReqs
            '
            Me.adtReqs.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtReqs.AllowDrop = True
            Me.adtReqs.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtReqs.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtReqs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtReqs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.adtReqs.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle
            
            Me.adtReqs.Location = New System.Drawing.Point(0, 217)
            Me.adtReqs.MultiSelect = True
            Me.adtReqs.Name = "adtReqs"
            Me.adtReqs.NodesConnector = Me.NodeConnector1
            Me.adtReqs.NodeStyle = Me.ElementStyle1
            Me.adtReqs.PathSeparator = ";"
            Me.adtReqs.Size = New System.Drawing.Size(318, 342)
            Me.adtReqs.Styles.Add(Me.ElementStyle1)
            Me.adtReqs.TabIndex = 1
            Me.adtReqs.Text = "AdvTree1"
            '
            'NodeConnector1
            '
            Me.NodeConnector1.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle1
            '
            Me.ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle1.Name = "ElementStyle1"
            Me.ElementStyle1.TextColor = System.Drawing.SystemColors.ControlText
            '
            'panelReqFunctions
            '
            Me.panelReqFunctions.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelReqFunctions.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelReqFunctions.Controls.Add(Me.btnMerge)
            Me.panelReqFunctions.Controls.Add(Me.btnExportReq)
            Me.panelReqFunctions.Controls.Add(Me.btnCopyReq)
            Me.panelReqFunctions.Controls.Add(Me.btnDeleteReq)
            Me.panelReqFunctions.Controls.Add(Me.btnEditReq)
            Me.panelReqFunctions.Controls.Add(Me.btnAddReq)
            Me.panelReqFunctions.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelReqFunctions.Location = New System.Drawing.Point(0, 178)
            Me.panelReqFunctions.Name = "panelReqFunctions"
            Me.panelReqFunctions.Size = New System.Drawing.Size(318, 39)
            Me.panelReqFunctions.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelReqFunctions.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelReqFunctions.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelReqFunctions.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelReqFunctions.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelReqFunctions.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelReqFunctions.Style.GradientAngle = 90
            Me.panelReqFunctions.TabIndex = 2
            '
            'btnMerge
            '
            Me.btnMerge.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnMerge.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnMerge.Enabled = False
            Me.btnMerge.Location = New System.Drawing.Point(187, 6)
            Me.btnMerge.Name = "btnMerge"
            Me.btnMerge.Size = New System.Drawing.Size(40, 23)
            Me.btnMerge.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnMerge.TabIndex = 5
            Me.btnMerge.Text = "Merge"
            Me.btnMerge.Tooltip = "Merges the selected Requisitions"
            '
            'btnExportReq
            '
            Me.btnExportReq.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnExportReq.AutoExpandOnClick = True
            Me.btnExportReq.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnExportReq.Enabled = False
            Me.btnExportReq.Location = New System.Drawing.Point(233, 6)
            Me.btnExportReq.Name = "btnExportReq"
            Me.btnExportReq.Size = New System.Drawing.Size(70, 23)
            Me.btnExportReq.SplitButton = True
            Me.btnExportReq.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnExportReq.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnExportTSV, Me.btnExportCSV, Me.btnExportEveHQ, Me.btnImportEveHQ})
            Me.btnExportReq.TabIndex = 4
            Me.btnExportReq.Text = "Imp/Exp"
            Me.btnExportReq.Tooltip = "Copies a requisition"
            '
            'btnExportTSV
            '
            Me.btnExportTSV.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator
            Me.btnExportTSV.FontBold = True
            Me.btnExportTSV.HotFontBold = True
            Me.btnExportTSV.Name = "btnExportTSV"
            Me.btnExportTSV.Text = "Copy to Clipboard (TSV)"
            '
            'btnExportCSV
            '
            Me.btnExportCSV.Name = "btnExportCSV"
            Me.btnExportCSV.Text = "Copy to Clipboard (CSV)"
            '
            'btnExportEveHQ
            '
            Me.btnExportEveHQ.Name = "btnExportEveHQ"
            Me.btnExportEveHQ.Text = "Export for EveHQ"
            '
            'btnImportEveHQ
            '
            Me.btnImportEveHQ.BeginGroup = True
            Me.btnImportEveHQ.Name = "btnImportEveHQ"
            Me.btnImportEveHQ.Text = "Import from EveHQ"
            '
            'btnCopyReq
            '
            Me.btnCopyReq.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnCopyReq.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnCopyReq.Enabled = False
            Me.btnCopyReq.Location = New System.Drawing.Point(141, 6)
            Me.btnCopyReq.Name = "btnCopyReq"
            Me.btnCopyReq.Size = New System.Drawing.Size(40, 23)
            Me.btnCopyReq.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnCopyReq.TabIndex = 3
            Me.btnCopyReq.Text = "Copy"
            Me.btnCopyReq.Tooltip = "Copies a requisition"
            '
            'btnDeleteReq
            '
            Me.btnDeleteReq.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnDeleteReq.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnDeleteReq.Enabled = False
            Me.btnDeleteReq.Location = New System.Drawing.Point(95, 6)
            Me.btnDeleteReq.Name = "btnDeleteReq"
            Me.btnDeleteReq.Size = New System.Drawing.Size(40, 23)
            Me.btnDeleteReq.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnDeleteReq.TabIndex = 2
            Me.btnDeleteReq.Text = "Delete"
            Me.btnDeleteReq.Tooltip = "Deletes a requisition"
            '
            'btnEditReq
            '
            Me.btnEditReq.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnEditReq.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnEditReq.Enabled = False
            Me.btnEditReq.Location = New System.Drawing.Point(49, 6)
            Me.btnEditReq.Name = "btnEditReq"
            Me.btnEditReq.Size = New System.Drawing.Size(40, 23)
            Me.btnEditReq.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnEditReq.TabIndex = 1
            Me.btnEditReq.Text = "Edit"
            Me.btnEditReq.Tooltip = "Edits an existing requisition"
            '
            'epReqFilter
            '
            Me.epReqFilter.CanvasColor = System.Drawing.SystemColors.Control
            Me.epReqFilter.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.epReqFilter.Controls.Add(Me.btnResetFilter)
            Me.epReqFilter.Controls.Add(Me.btnApplyFilter)
            Me.epReqFilter.Controls.Add(Me.txtSearch)
            Me.epReqFilter.Controls.Add(Me.lblItemSearch)
            Me.epReqFilter.Controls.Add(Me.cboSource)
            Me.epReqFilter.Controls.Add(Me.lblSource)
            Me.epReqFilter.Controls.Add(Me.cboRequestor)
            Me.epReqFilter.Controls.Add(Me.lblRequestor)
            Me.epReqFilter.Controls.Add(Me.cboRequisition)
            Me.epReqFilter.Controls.Add(Me.lblName)
            Me.epReqFilter.Dock = System.Windows.Forms.DockStyle.Top
            Me.epReqFilter.Location = New System.Drawing.Point(0, 0)
            Me.epReqFilter.Name = "epReqFilter"
            Me.epReqFilter.Size = New System.Drawing.Size(318, 178)
            Me.epReqFilter.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.epReqFilter.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.epReqFilter.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.epReqFilter.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.epReqFilter.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
            Me.epReqFilter.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.epReqFilter.Style.GradientAngle = 90
            Me.epReqFilter.TabIndex = 0
            Me.epReqFilter.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
            Me.epReqFilter.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.epReqFilter.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.epReqFilter.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
            Me.epReqFilter.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.epReqFilter.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.epReqFilter.TitleStyle.GradientAngle = 90
            Me.epReqFilter.TitleText = "Requisitions"
            '
            'btnResetFilter
            '
            Me.btnResetFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnResetFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnResetFilter.Location = New System.Drawing.Point(222, 141)
            Me.btnResetFilter.Name = "btnResetFilter"
            Me.btnResetFilter.Size = New System.Drawing.Size(75, 23)
            Me.btnResetFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnResetFilter.TabIndex = 10
            Me.btnResetFilter.Text = "Reset Filter"
            '
            'btnApplyFilter
            '
            Me.btnApplyFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnApplyFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnApplyFilter.Location = New System.Drawing.Point(141, 141)
            Me.btnApplyFilter.Name = "btnApplyFilter"
            Me.btnApplyFilter.Size = New System.Drawing.Size(75, 23)
            Me.btnApplyFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnApplyFilter.TabIndex = 9
            Me.btnApplyFilter.Text = "Apply Filter"
            '
            'txtSearch
            '
            '
            '
            '
            Me.txtSearch.Border.Class = "TextBoxBorder"
            Me.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.txtSearch.Location = New System.Drawing.Point(93, 114)
            Me.txtSearch.Name = "txtSearch"
            Me.txtSearch.Size = New System.Drawing.Size(208, 21)
            Me.txtSearch.TabIndex = 8
            '
            'lblItemSearch
            '
            Me.lblItemSearch.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblItemSearch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblItemSearch.Location = New System.Drawing.Point(12, 111)
            Me.lblItemSearch.Name = "lblItemSearch"
            Me.lblItemSearch.Size = New System.Drawing.Size(75, 23)
            Me.lblItemSearch.TabIndex = 7
            Me.lblItemSearch.Text = "Item Search:"
            '
            'cboSource
            '
            Me.cboSource.DisplayMember = "Text"
            Me.cboSource.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboSource.FormattingEnabled = True
            Me.cboSource.ItemHeight = 15
            Me.cboSource.Location = New System.Drawing.Point(93, 88)
            Me.cboSource.Name = "cboSource"
            Me.cboSource.Size = New System.Drawing.Size(208, 21)
            Me.cboSource.Sorted = True
            Me.cboSource.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboSource.TabIndex = 6
            '
            'lblSource
            '
            Me.lblSource.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblSource.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblSource.Location = New System.Drawing.Point(12, 85)
            Me.lblSource.Name = "lblSource"
            Me.lblSource.Size = New System.Drawing.Size(75, 23)
            Me.lblSource.TabIndex = 5
            Me.lblSource.Text = "Source:"
            '
            'cboRequestor
            '
            Me.cboRequestor.DisplayMember = "Text"
            Me.cboRequestor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboRequestor.FormattingEnabled = True
            Me.cboRequestor.ItemHeight = 15
            Me.cboRequestor.Location = New System.Drawing.Point(93, 62)
            Me.cboRequestor.Name = "cboRequestor"
            Me.cboRequestor.Size = New System.Drawing.Size(208, 21)
            Me.cboRequestor.Sorted = True
            Me.cboRequestor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboRequestor.TabIndex = 4
            '
            'lblRequestor
            '
            Me.lblRequestor.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblRequestor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblRequestor.Location = New System.Drawing.Point(12, 59)
            Me.lblRequestor.Name = "lblRequestor"
            Me.lblRequestor.Size = New System.Drawing.Size(75, 23)
            Me.lblRequestor.TabIndex = 3
            Me.lblRequestor.Text = "Requestor:"
            '
            'cboRequisition
            '
            Me.cboRequisition.DisplayMember = "Text"
            Me.cboRequisition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboRequisition.FormattingEnabled = True
            Me.cboRequisition.ItemHeight = 15
            Me.cboRequisition.Location = New System.Drawing.Point(93, 36)
            Me.cboRequisition.Name = "cboRequisition"
            Me.cboRequisition.Size = New System.Drawing.Size(208, 21)
            Me.cboRequisition.Sorted = True
            Me.cboRequisition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboRequisition.TabIndex = 2
            '
            'lblName
            '
            Me.lblName.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblName.Location = New System.Drawing.Point(12, 33)
            Me.lblName.Name = "lblName"
            Me.lblName.Size = New System.Drawing.Size(75, 23)
            Me.lblName.TabIndex = 1
            Me.lblName.Text = "Req Name:"
            '
            'ExpandableSplitter1
            '
            Me.ExpandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(182, Byte), Integer))
            Me.ExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandableSplitter1.ExpandableControl = Me.panelLeft
            Me.ExpandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(182, Byte), Integer))
            Me.ExpandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ExpandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ExpandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(213, Byte), Integer))
            Me.ExpandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer))
            Me.ExpandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.ExpandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.ExpandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.ExpandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(182, Byte), Integer))
            Me.ExpandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ExpandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(182, Byte), Integer))
            Me.ExpandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(213, Byte), Integer))
            Me.ExpandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter1.Location = New System.Drawing.Point(318, 0)
            Me.ExpandableSplitter1.Name = "ExpandableSplitter1"
            Me.ExpandableSplitter1.Size = New System.Drawing.Size(6, 714)
            Me.ExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.ExpandableSplitter1.TabIndex = 3
            Me.ExpandableSplitter1.TabStop = False
            '
            'frmRequisitions
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1284, 714)
            Me.Controls.Add(Me.panelReqOrders)
            Me.Controls.Add(Me.ExpandableSplitter1)
            Me.Controls.Add(Me.panelLeft)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "frmRequisitions"
            Me.Text = "EveHQ Requisitions"
            Me.panelReqOrders.ResumeLayout(False)
            CType(Me.adtOrders, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelReqOrderConfig.ResumeLayout(False)
            Me.panelReqOrderConfig.PerformLayout()
            Me.panelLeft.ResumeLayout(False)
            Me.panelReqInfo.ResumeLayout(False)
            Me.grpSummary.ResumeLayout(False)
            Me.grpSummary.PerformLayout()
            Me.panelReqs.ResumeLayout(False)
            CType(Me.adtReqs, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelReqFunctions.ResumeLayout(False)
            Me.epReqFilter.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnAddReq As DevComponents.DotNetBar.ButtonX
        Friend WithEvents panelReqOrders As DevComponents.DotNetBar.PanelEx
        Friend WithEvents panelLeft As DevComponents.DotNetBar.PanelEx
        Friend WithEvents panelReqInfo As DevComponents.DotNetBar.PanelEx
        Friend WithEvents ExpandableSplitter2 As DevComponents.DotNetBar.ExpandableSplitter
        Friend WithEvents panelReqs As DevComponents.DotNetBar.PanelEx
        Friend WithEvents ExpandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
        Friend WithEvents epReqFilter As DevComponents.DotNetBar.ExpandablePanel
        Friend WithEvents adtReqs As DevComponents.AdvTree.AdvTree
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents lblName As DevComponents.DotNetBar.LabelX
        Friend WithEvents btnApplyFilter As DevComponents.DotNetBar.ButtonX
        Friend WithEvents txtSearch As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents lblItemSearch As DevComponents.DotNetBar.LabelX
        Friend WithEvents cboSource As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblSource As DevComponents.DotNetBar.LabelX
        Friend WithEvents cboRequestor As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblRequestor As DevComponents.DotNetBar.LabelX
        Friend WithEvents cboRequisition As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents panelReqFunctions As DevComponents.DotNetBar.PanelEx
        Friend WithEvents btnResetFilter As DevComponents.DotNetBar.ButtonX
        Friend WithEvents lblSummary As DevComponents.DotNetBar.LabelX
        Friend WithEvents grpSummary As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents lblTotalItemsLbl As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblTotalCostLbl As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblTotalVolumeLbl As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblUniqueItemsLbl As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblUniqueItems As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblTotalItems As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblTotalCost As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblTotalVolume As DevComponents.DotNetBar.LabelX
        Friend WithEvents adtOrders As DevComponents.AdvTree.AdvTree
        Friend WithEvents NodeConnector2 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle2 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents colItemName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colItemQuantity As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colItemMetaLevel As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colItemVolume As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colItemTotalCost As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents btnDeleteReq As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnEditReq As DevComponents.DotNetBar.ButtonX
        Friend WithEvents cboAssetSelection As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblAssetOwner As DevComponents.DotNetBar.LabelX
        Friend WithEvents panelReqOrderConfig As DevComponents.DotNetBar.PanelEx
        Friend WithEvents colItemOwned As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colItemUnitCost As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents btnCopyReq As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnExportReq As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnExportCSV As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents btnExportTSV As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents btnExportEveHQ As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents btnImportEveHQ As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents colItemSurplus As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colSurplusCost As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents btnMerge As DevComponents.DotNetBar.ButtonX
        Friend WithEvents chkDroneBay As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents chkCargoBay As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents chkFittedModules As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents chkAssembledShips As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents lblShipExclusions As DevComponents.DotNetBar.LabelX
    End Class
End Namespace