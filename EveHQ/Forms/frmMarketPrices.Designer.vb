Imports EveHQ.Controls

Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmMarketPrices
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMarketPrices))
            Me.ofd1 = New System.Windows.Forms.OpenFileDialog()
            Me.ctxMarketExport = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.mnuViewOrders = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuDeleteLog = New System.Windows.Forms.ToolStripMenuItem()
            Me.chkShowOnlyCustom = New System.Windows.Forms.CheckBox()
            Me.lblCustomPrices = New System.Windows.Forms.Label()
            Me.btnResetGrid = New System.Windows.Forms.Button()
            Me.txtSearchPrices = New System.Windows.Forms.TextBox()
            Me.lblSearchPrices = New System.Windows.Forms.Label()
            Me.ctxPrices = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.mnuPriceItemName = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuPriceAdd = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuPriceEdit = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuPriceDelete = New System.Windows.Forms.ToolStripMenuItem()
            Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
            Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
            Me._buyOrderMetrics = New MarketItemMetrics()
            Me._sellOrderMetrics = New MarketItemMetrics()
            Me.TabControl2 = New DevComponents.DotNetBar.TabControl()
            Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
            Me._sellOrders = New DevComponents.AdvTree.AdvTree()
            Me.colSellLocation = New DevComponents.AdvTree.ColumnHeader()
            Me.colSellQty = New DevComponents.AdvTree.ColumnHeader()
            Me.colSellPrice = New DevComponents.AdvTree.ColumnHeader()
            Me.colSellExpiry = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me._sellOrderTab = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
            Me._buyOrders = New DevComponents.AdvTree.AdvTree()
            Me.colBuyLocation = New DevComponents.AdvTree.ColumnHeader()
            Me.colBuyQty = New DevComponents.AdvTree.ColumnHeader()
            Me.colBuyPrice = New DevComponents.AdvTree.ColumnHeader()
            Me.colBuyExpiry = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector2 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle2 = New DevComponents.DotNetBar.ElementStyle()
            Me._buyOrdersTab = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.Button2 = New System.Windows.Forms.Button()
            Me.ComboBox1 = New System.Windows.Forms.ComboBox()
            Me._getMarketOrders = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.tiPriceSettings = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel()
            Me.adtPrices = New DevComponents.AdvTree.AdvTree()
            Me.colCustomItem = New DevComponents.AdvTree.ColumnHeader()
            Me.colCustomBase = New DevComponents.AdvTree.ColumnHeader()
            Me.colCustomMarket = New DevComponents.AdvTree.ColumnHeader()
            Me.colCustomCustom = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector5 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle4 = New DevComponents.DotNetBar.ElementStyle()
            Me.tiCustomPrices = New DevComponents.DotNetBar.TabItem(Me.components)
            Me._sellExpires = New DevComponents.AdvTree.ColumnHeader()
            Me._sellPrice = New DevComponents.AdvTree.ColumnHeader()
            Me._sellQuantity = New DevComponents.AdvTree.ColumnHeader()
            Me._sellLocation = New DevComponents.AdvTree.ColumnHeader()
            Me.ElementStyle5 = New DevComponents.DotNetBar.ElementStyle()
            Me._buyExpires = New DevComponents.AdvTree.ColumnHeader()
            Me._buyPrice = New DevComponents.AdvTree.ColumnHeader()
            Me._buyQuantity = New DevComponents.AdvTree.ColumnHeader()
            Me._buyLocation = New DevComponents.AdvTree.ColumnHeader()
            Me.ElementStyle6 = New DevComponents.DotNetBar.ElementStyle()
            Me.ctxMarketExport.SuspendLayout()
            Me.ctxPrices.SuspendLayout()
            CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControl1.SuspendLayout()
            Me.TabControlPanel1.SuspendLayout()
            CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControl2.SuspendLayout()
            Me.TabControlPanel2.SuspendLayout()
            CType(Me._sellOrders, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControlPanel3.SuspendLayout()
            CType(Me._buyOrders, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControlPanel4.SuspendLayout()
            CType(Me.adtPrices, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ofd1
            '
            Me.ofd1.FileName = "OpenFileDialog1"
            '
            'ctxMarketExport
            '
            Me.ctxMarketExport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ctxMarketExport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewOrders, Me.mnuDeleteLog})
            Me.ctxMarketExport.Name = "ctxPrices"
            Me.ctxMarketExport.Size = New System.Drawing.Size(142, 48)
            '
            'mnuViewOrders
            '
            Me.mnuViewOrders.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mnuViewOrders.Name = "mnuViewOrders"
            Me.mnuViewOrders.Size = New System.Drawing.Size(141, 22)
            Me.mnuViewOrders.Text = "View Orders"
            '
            'mnuDeleteLog
            '
            Me.mnuDeleteLog.Name = "mnuDeleteLog"
            Me.mnuDeleteLog.Size = New System.Drawing.Size(141, 22)
            Me.mnuDeleteLog.Text = "Delete log"
            '
            'chkShowOnlyCustom
            '
            Me.chkShowOnlyCustom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.chkShowOnlyCustom.AutoSize = True
            Me.chkShowOnlyCustom.BackColor = System.Drawing.Color.Transparent
            Me.chkShowOnlyCustom.Location = New System.Drawing.Point(375, 652)
            Me.chkShowOnlyCustom.Name = "chkShowOnlyCustom"
            Me.chkShowOnlyCustom.Size = New System.Drawing.Size(147, 17)
            Me.chkShowOnlyCustom.TabIndex = 20
            Me.chkShowOnlyCustom.Text = "Show Only Custom Prices"
            Me.chkShowOnlyCustom.UseVisualStyleBackColor = False
            '
            'lblCustomPrices
            '
            Me.lblCustomPrices.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                               Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCustomPrices.BackColor = System.Drawing.Color.Transparent
            Me.lblCustomPrices.Location = New System.Drawing.Point(4, 5)
            Me.lblCustomPrices.Name = "lblCustomPrices"
            Me.lblCustomPrices.Size = New System.Drawing.Size(974, 31)
            Me.lblCustomPrices.TabIndex = 19
            Me.lblCustomPrices.Text = "Custom Prices enable you to override the Base and Market prices by allowing you t" & _
                                      "o enter your own individual figures. Right-click an item to edit or delete a Cus" & _
                                      "tom price." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            '
            'btnResetGrid
            '
            Me.btnResetGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnResetGrid.Location = New System.Drawing.Point(272, 649)
            Me.btnResetGrid.Name = "btnResetGrid"
            Me.btnResetGrid.Size = New System.Drawing.Size(85, 23)
            Me.btnResetGrid.TabIndex = 18
            Me.btnResetGrid.Text = "Reset Grid"
            Me.btnResetGrid.UseVisualStyleBackColor = True
            '
            'txtSearchPrices
            '
            Me.txtSearchPrices.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtSearchPrices.Location = New System.Drawing.Point(79, 650)
            Me.txtSearchPrices.Name = "txtSearchPrices"
            Me.txtSearchPrices.Size = New System.Drawing.Size(187, 21)
            Me.txtSearchPrices.TabIndex = 17
            '
            'lblSearchPrices
            '
            Me.lblSearchPrices.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblSearchPrices.AutoSize = True
            Me.lblSearchPrices.BackColor = System.Drawing.Color.Transparent
            Me.lblSearchPrices.Location = New System.Drawing.Point(4, 654)
            Me.lblSearchPrices.Name = "lblSearchPrices"
            Me.lblSearchPrices.Size = New System.Drawing.Size(74, 13)
            Me.lblSearchPrices.TabIndex = 16
            Me.lblSearchPrices.Text = "Search Items:"
            '
            'ctxPrices
            '
            Me.ctxPrices.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ctxPrices.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPriceItemName, Me.ToolStripMenuItem1, Me.mnuPriceAdd, Me.mnuPriceEdit, Me.mnuPriceDelete})
            Me.ctxPrices.Name = "ctxPrices"
            Me.ctxPrices.Size = New System.Drawing.Size(171, 98)
            '
            'mnuPriceItemName
            '
            Me.mnuPriceItemName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mnuPriceItemName.Name = "mnuPriceItemName"
            Me.mnuPriceItemName.Size = New System.Drawing.Size(170, 22)
            Me.mnuPriceItemName.Text = "Item Name"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(167, 6)
            '
            'mnuPriceAdd
            '
            Me.mnuPriceAdd.Name = "mnuPriceAdd"
            Me.mnuPriceAdd.Size = New System.Drawing.Size(170, 22)
            Me.mnuPriceAdd.Text = "Add Custom Price"
            '
            'mnuPriceEdit
            '
            Me.mnuPriceEdit.Name = "mnuPriceEdit"
            Me.mnuPriceEdit.Size = New System.Drawing.Size(170, 22)
            Me.mnuPriceEdit.Text = "Edit Custom Price"
            '
            'mnuPriceDelete
            '
            Me.mnuPriceDelete.Name = "mnuPriceDelete"
            Me.mnuPriceDelete.Size = New System.Drawing.Size(170, 22)
            Me.mnuPriceDelete.Text = "Delete Custom Price"
            '
            'TabControl1
            '
            Me.TabControl1.BackColor = System.Drawing.Color.Transparent
            Me.TabControl1.CanReorderTabs = True
            Me.TabControl1.ColorScheme.TabBackground = System.Drawing.Color.Transparent
            Me.TabControl1.ColorScheme.TabBackground2 = System.Drawing.Color.Transparent
            Me.TabControl1.ColorScheme.TabItemBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(226, Byte), Integer)), 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(199, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(223, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), 1.0!)})
            Me.TabControl1.ColorScheme.TabItemHotBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(235, Byte), Integer)), 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(168, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(89, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(141, Byte), Integer)), 1.0!)})
            Me.TabControl1.ColorScheme.TabItemSelectedBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.White, 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer)), 1.0!)})
            Me.TabControl1.Controls.Add(Me.TabControlPanel1)
            Me.TabControl1.Controls.Add(Me.TabControlPanel4)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 0)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.TabControl1.SelectedTabIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(982, 705)
            Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
            Me.TabControl1.TabIndex = 18
            Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
            Me.TabControl1.Tabs.Add(Me.tiPriceSettings)
            Me.TabControl1.Tabs.Add(Me.tiCustomPrices)
            Me.TabControl1.Text = "TabControl1"
            '
            'TabControlPanel1
            '
            Me.TabControlPanel1.Controls.Add(Me._buyOrderMetrics)
            Me.TabControlPanel1.Controls.Add(Me._sellOrderMetrics)
            Me.TabControlPanel1.Controls.Add(Me.TabControl2)
            Me.TabControlPanel1.Controls.Add(Me.Button2)
            Me.TabControlPanel1.Controls.Add(Me.ComboBox1)
            Me.TabControlPanel1.Controls.Add(Me._getMarketOrders)
            Me.TabControlPanel1.Controls.Add(Me.Label3)
            Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel1.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel1.Name = "TabControlPanel1"
            Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel1.Size = New System.Drawing.Size(982, 682)
            Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                                                          Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel1.Style.GradientAngle = 90
            Me.TabControlPanel1.TabIndex = 1
            Me.TabControlPanel1.TabItem = Me.tiPriceSettings
            '
            '_buyOrderMetrics
            '
            Me._buyOrderMetrics.Average = ""
            Me._buyOrderMetrics.BackColor = System.Drawing.Color.Transparent
            Me._buyOrderMetrics.Location = New System.Drawing.Point(502, 57)
            Me._buyOrderMetrics.Maximum = ""
            Me._buyOrderMetrics.Median = ""
            Me._buyOrderMetrics.Minimum = ""
            Me._buyOrderMetrics.Name = "_buyOrderMetrics"
            Me._buyOrderMetrics.Percentile = ""
            Me._buyOrderMetrics.Size = New System.Drawing.Size(358, 128)
            Me._buyOrderMetrics.StdDeviation = ""
            Me._buyOrderMetrics.TabIndex = 34
            Me._buyOrderMetrics.Title = "Buy Orders"
            Me._buyOrderMetrics.Volume = ""
            '
            '_sellOrderMetrics
            '
            Me._sellOrderMetrics.Average = ""
            Me._sellOrderMetrics.BackColor = System.Drawing.Color.Transparent
            Me._sellOrderMetrics.Location = New System.Drawing.Point(122, 57)
            Me._sellOrderMetrics.Maximum = ""
            Me._sellOrderMetrics.Median = ""
            Me._sellOrderMetrics.Minimum = ""
            Me._sellOrderMetrics.Name = "_sellOrderMetrics"
            Me._sellOrderMetrics.Percentile = ""
            Me._sellOrderMetrics.Size = New System.Drawing.Size(358, 128)
            Me._sellOrderMetrics.StdDeviation = ""
            Me._sellOrderMetrics.TabIndex = 33
            Me._sellOrderMetrics.Title = "Sell Orders"
            Me._sellOrderMetrics.Volume = ""
            '
            'TabControl2
            '
            Me.TabControl2.CanReorderTabs = True
            Me.TabControl2.Controls.Add(Me.TabControlPanel2)
            Me.TabControl2.Controls.Add(Me.TabControlPanel3)
            Me.TabControl2.Location = New System.Drawing.Point(7, 184)
            Me.TabControl2.Name = "TabControl2"
            Me.TabControl2.SelectedTabFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.TabControl2.SelectedTabIndex = 0
            Me.TabControl2.Size = New System.Drawing.Size(971, 494)
            Me.TabControl2.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
            Me.TabControl2.TabIndex = 32
            Me.TabControl2.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
            Me.TabControl2.Tabs.Add(Me._sellOrderTab)
            Me.TabControl2.Tabs.Add(Me._buyOrdersTab)
            Me.TabControl2.Text = "TabControl2"
            '
            'TabControlPanel2
            '
            Me.TabControlPanel2.Controls.Add(Me._sellOrders)
            Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel2.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel2.Name = "TabControlPanel2"
            Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel2.Size = New System.Drawing.Size(971, 471)
            Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                                                          Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel2.Style.GradientAngle = 90
            Me.TabControlPanel2.TabIndex = 1
            Me.TabControlPanel2.TabItem = Me._sellOrderTab
            '
            '_sellOrders
            '
            Me._sellOrders.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me._sellOrders.AllowDrop = True
            Me._sellOrders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                            Or System.Windows.Forms.AnchorStyles.Left) _
                                           Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me._sellOrders.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me._sellOrders.BackgroundStyle.Class = "TreeBorderKey"
            Me._sellOrders.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me._sellOrders.Columns.Add(Me.colSellLocation)
            Me._sellOrders.Columns.Add(Me.colSellQty)
            Me._sellOrders.Columns.Add(Me.colSellPrice)
            Me._sellOrders.Columns.Add(Me.colSellExpiry)
            Me._sellOrders.DragDropEnabled = False
            Me._sellOrders.DragDropNodeCopyEnabled = False
            Me._sellOrders.ExpandWidth = 0
            
            Me._sellOrders.Location = New System.Drawing.Point(4, 4)
            Me._sellOrders.Name = "_sellOrders"
            Me._sellOrders.NodesConnector = Me.NodeConnector1
            Me._sellOrders.NodeStyle = Me.ElementStyle1
            Me._sellOrders.PathSeparator = ";"
            Me._sellOrders.Size = New System.Drawing.Size(963, 463)
            Me._sellOrders.Styles.Add(Me.ElementStyle1)
            Me._sellOrders.TabIndex = 20
            Me._sellOrders.Text = "_sellOrders"
            '
            'colSellLocation
            '
            Me.colSellLocation.DisplayIndex = 1
            Me.colSellLocation.Editable = False
            Me.colSellLocation.Name = "colSellLocation"
            Me.colSellLocation.SortingEnabled = False
            Me.colSellLocation.StretchToFill = True
            Me.colSellLocation.Text = "Location"
            Me.colSellLocation.Width.Absolute = 300
            '
            'colSellQty
            '
            Me.colSellQty.DisplayIndex = 2
            Me.colSellQty.Editable = False
            Me.colSellQty.MinimumWidth = 100
            Me.colSellQty.Name = "colSellQty"
            Me.colSellQty.Text = "Quantity"
            Me.colSellQty.Width.Absolute = 120
            '
            'colSellPrice
            '
            Me.colSellPrice.DisplayIndex = 3
            Me.colSellPrice.Editable = False
            Me.colSellPrice.Name = "colSellPrice"
            Me.colSellPrice.Text = "Price"
            Me.colSellPrice.Width.Absolute = 120
            '
            'colSellExpiry
            '
            Me.colSellExpiry.DisplayIndex = 4
            Me.colSellExpiry.Editable = False
            Me.colSellExpiry.EditorType = DevComponents.AdvTree.eCellEditorType.Custom
            Me.colSellExpiry.MinimumWidth = 200
            Me.colSellExpiry.Name = "colSellExpiry"
            Me.colSellExpiry.SortingEnabled = False
            Me.colSellExpiry.Text = "Expires In"
            Me.colSellExpiry.Width.Absolute = 120
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
            '_sellOrderTab
            '
            Me._sellOrderTab.AttachedControl = Me.TabControlPanel2
            Me._sellOrderTab.Name = "_sellOrderTab"
            Me._sellOrderTab.Text = "Sell Orders"
            '
            'TabControlPanel3
            '
            Me.TabControlPanel3.Controls.Add(Me._buyOrders)
            Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel3.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel3.Name = "TabControlPanel3"
            Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel3.Size = New System.Drawing.Size(971, 471)
            Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                                                          Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel3.Style.GradientAngle = 90
            Me.TabControlPanel3.TabIndex = 2
            Me.TabControlPanel3.TabItem = Me._buyOrdersTab
            '
            '_buyOrders
            '
            Me._buyOrders.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me._buyOrders.AllowDrop = True
            Me._buyOrders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                           Or System.Windows.Forms.AnchorStyles.Left) _
                                          Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me._buyOrders.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me._buyOrders.BackgroundStyle.Class = "TreeBorderKey"
            Me._buyOrders.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me._buyOrders.Columns.Add(Me.colBuyLocation)
            Me._buyOrders.Columns.Add(Me.colBuyQty)
            Me._buyOrders.Columns.Add(Me.colBuyPrice)
            Me._buyOrders.Columns.Add(Me.colBuyExpiry)
            Me._buyOrders.DragDropEnabled = False
            Me._buyOrders.DragDropNodeCopyEnabled = False
            Me._buyOrders.ExpandWidth = 0
            
            Me._buyOrders.Location = New System.Drawing.Point(4, 4)
            Me._buyOrders.Name = "_buyOrders"
            Me._buyOrders.NodesConnector = Me.NodeConnector2
            Me._buyOrders.NodeStyle = Me.ElementStyle2
            Me._buyOrders.PathSeparator = ";"
            Me._buyOrders.Size = New System.Drawing.Size(963, 463)
            Me._buyOrders.Styles.Add(Me.ElementStyle2)
            Me._buyOrders.TabIndex = 20
            Me._buyOrders.Text = "_buyOrders"
            '
            'colBuyLocation
            '
            Me.colBuyLocation.DisplayIndex = 1
            Me.colBuyLocation.Editable = False
            Me.colBuyLocation.Name = "colBuyLocation"
            Me.colBuyLocation.SortingEnabled = False
            Me.colBuyLocation.StretchToFill = True
            Me.colBuyLocation.Text = "Location"
            Me.colBuyLocation.Width.Absolute = 300
            '
            'colBuyQty
            '
            Me.colBuyQty.DisplayIndex = 2
            Me.colBuyQty.Editable = False
            Me.colBuyQty.Name = "colBuyQty"
            Me.colBuyQty.Text = "Quantity"
            Me.colBuyQty.Width.Absolute = 120
            '
            'colBuyPrice
            '
            Me.colBuyPrice.DisplayIndex = 3
            Me.colBuyPrice.Editable = False
            Me.colBuyPrice.Name = "colBuyPrice"
            Me.colBuyPrice.Text = "Price"
            Me.colBuyPrice.Width.Absolute = 120
            '
            'colBuyExpiry
            '
            Me.colBuyExpiry.DisplayIndex = 4
            Me.colBuyExpiry.Editable = False
            Me.colBuyExpiry.EditorType = DevComponents.AdvTree.eCellEditorType.Custom
            Me.colBuyExpiry.Name = "colBuyExpiry"
            Me.colBuyExpiry.SortingEnabled = False
            Me.colBuyExpiry.Text = "Expires In"
            Me.colBuyExpiry.Width.Absolute = 120
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
            '_buyOrdersTab
            '
            Me._buyOrdersTab.AttachedControl = Me.TabControlPanel3
            Me._buyOrdersTab.Name = "_buyOrdersTab"
            Me._buyOrdersTab.Text = "Buy Orders"
            '
            'Button2
            '
            Me.Button2.Location = New System.Drawing.Point(832, 27)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(138, 24)
            Me.Button2.TabIndex = 31
            Me.Button2.Text = "Market Settings"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'ComboBox1
            '
            Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(375, 30)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(237, 21)
            Me.ComboBox1.TabIndex = 28
            '
            '_getMarketOrders
            '
            Me._getMarketOrders.Location = New System.Drawing.Point(633, 28)
            Me._getMarketOrders.Name = "_getMarketOrders"
            Me._getMarketOrders.Size = New System.Drawing.Size(120, 23)
            Me._getMarketOrders.TabIndex = 30
            Me._getMarketOrders.Text = "Get Market Orders"
            Me._getMarketOrders.UseVisualStyleBackColor = True
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Location = New System.Drawing.Point(294, 33)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(75, 13)
            Me.Label3.TabIndex = 29
            Me.Label3.Text = "Choose Item :"
            '
            'tiPriceSettings
            '
            Me.tiPriceSettings.AttachedControl = Me.TabControlPanel1
            Me.tiPriceSettings.Name = "tiPriceSettings"
            Me.tiPriceSettings.Text = "Market Prices"
            '
            'TabControlPanel4
            '
            Me.TabControlPanel4.Controls.Add(Me.adtPrices)
            Me.TabControlPanel4.Controls.Add(Me.chkShowOnlyCustom)
            Me.TabControlPanel4.Controls.Add(Me.lblCustomPrices)
            Me.TabControlPanel4.Controls.Add(Me.lblSearchPrices)
            Me.TabControlPanel4.Controls.Add(Me.txtSearchPrices)
            Me.TabControlPanel4.Controls.Add(Me.btnResetGrid)
            Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel4.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel4.Name = "TabControlPanel4"
            Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel4.Size = New System.Drawing.Size(982, 682)
            Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                                                          Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel4.Style.GradientAngle = 90
            Me.TabControlPanel4.TabIndex = 4
            Me.TabControlPanel4.TabItem = Me.tiCustomPrices
            '
            'adtPrices
            '
            Me.adtPrices.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtPrices.AllowDrop = True
            Me.adtPrices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                          Or System.Windows.Forms.AnchorStyles.Left) _
                                         Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.adtPrices.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtPrices.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtPrices.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtPrices.Columns.Add(Me.colCustomItem)
            Me.adtPrices.Columns.Add(Me.colCustomBase)
            Me.adtPrices.Columns.Add(Me.colCustomMarket)
            Me.adtPrices.Columns.Add(Me.colCustomCustom)
            Me.adtPrices.ContextMenuStrip = Me.ctxPrices
            Me.adtPrices.ExpandWidth = 0
            
            Me.adtPrices.Location = New System.Drawing.Point(4, 39)
            Me.adtPrices.MultiSelect = True
            Me.adtPrices.Name = "adtPrices"
            Me.adtPrices.NodesConnector = Me.NodeConnector5
            Me.adtPrices.NodeSpacing = 1
            Me.adtPrices.NodeStyle = Me.ElementStyle4
            Me.adtPrices.PathSeparator = ";"
            Me.adtPrices.Size = New System.Drawing.Size(974, 605)
            Me.adtPrices.Styles.Add(Me.ElementStyle4)
            Me.adtPrices.TabIndex = 21
            Me.adtPrices.Text = "AdvTree1"
            '
            'colCustomItem
            '
            Me.colCustomItem.DisplayIndex = 1
            Me.colCustomItem.Name = "colCustomItem"
            Me.colCustomItem.Text = "Item Name"
            Me.colCustomItem.Width.Absolute = 300
            '
            'colCustomBase
            '
            Me.colCustomBase.DisplayIndex = 2
            Me.colCustomBase.Name = "colCustomBase"
            Me.colCustomBase.SortingEnabled = False
            Me.colCustomBase.Text = "Base Price"
            Me.colCustomBase.Width.Absolute = 150
            '
            'colCustomMarket
            '
            Me.colCustomMarket.DisplayIndex = 3
            Me.colCustomMarket.Name = "colCustomMarket"
            Me.colCustomMarket.SortingEnabled = False
            Me.colCustomMarket.Text = "Market Price"
            Me.colCustomMarket.Width.Absolute = 150
            '
            'colCustomCustom
            '
            Me.colCustomCustom.DisplayIndex = 4
            Me.colCustomCustom.Name = "colCustomCustom"
            Me.colCustomCustom.SortingEnabled = False
            Me.colCustomCustom.Text = "Custom Price"
            Me.colCustomCustom.Width.Absolute = 150
            '
            'NodeConnector5
            '
            Me.NodeConnector5.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle4
            '
            Me.ElementStyle4.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle4.Name = "ElementStyle4"
            Me.ElementStyle4.TextColor = System.Drawing.SystemColors.ControlText
            '
            'tiCustomPrices
            '
            Me.tiCustomPrices.AttachedControl = Me.TabControlPanel4
            Me.tiCustomPrices.Name = "tiCustomPrices"
            Me.tiCustomPrices.Text = "Custom Prices"
            '
            '_sellExpires
            '
            Me._sellExpires.Editable = False
            Me._sellExpires.Name = "_sellExpires"
            Me._sellExpires.Text = "Expires"
            Me._sellExpires.Width.Absolute = 150
            '
            '_sellPrice
            '
            Me._sellPrice.Editable = False
            Me._sellPrice.Name = "_sellPrice"
            Me._sellPrice.SortDirection = DevComponents.AdvTree.eSortDirection.Ascending
            Me._sellPrice.Text = "Price"
            Me._sellPrice.Width.Absolute = 150
            '
            '_sellQuantity
            '
            Me._sellQuantity.Editable = False
            Me._sellQuantity.Name = "_sellQuantity"
            Me._sellQuantity.ShowToolTips = False
            Me._sellQuantity.Text = "Quantity"
            Me._sellQuantity.Width.Absolute = 150
            '
            '_sellLocation
            '
            Me._sellLocation.Editable = False
            Me._sellLocation.Name = "_sellLocation"
            Me._sellLocation.StretchToFill = True
            Me._sellLocation.Text = "Location"
            Me._sellLocation.Width.Absolute = 150
            '
            'ElementStyle5
            '
            Me.ElementStyle5.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle5.Name = "ElementStyle5"
            Me.ElementStyle5.TextColor = System.Drawing.SystemColors.ControlText
            '
            '_buyExpires
            '
            Me._buyExpires.Name = "_buyExpires"
            Me._buyExpires.Text = "Expires"
            Me._buyExpires.Width.Absolute = 150
            '
            '_buyPrice
            '
            Me._buyPrice.Name = "_buyPrice"
            Me._buyPrice.Text = "Price"
            Me._buyPrice.Width.Absolute = 150
            '
            '_buyQuantity
            '
            Me._buyQuantity.Name = "_buyQuantity"
            Me._buyQuantity.ShowToolTips = False
            Me._buyQuantity.Text = "Quantity"
            Me._buyQuantity.Width.Absolute = 150
            '
            '_buyLocation
            '
            Me._buyLocation.Name = "_buyLocation"
            Me._buyLocation.StretchToFill = True
            Me._buyLocation.Text = "Location"
            Me._buyLocation.Width.Absolute = 150
            '
            'ElementStyle6
            '
            Me.ElementStyle6.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle6.Name = "ElementStyle6"
            Me.ElementStyle6.TextColor = System.Drawing.SystemColors.ControlText
            '
            'frmMarketPrices
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(982, 705)
            Me.Controls.Add(Me.TabControl1)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "frmMarketPrices"
            Me.Text = "Market Prices"
            Me.ctxMarketExport.ResumeLayout(False)
            Me.ctxPrices.ResumeLayout(False)
            CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControl1.ResumeLayout(False)
            Me.TabControlPanel1.ResumeLayout(False)
            Me.TabControlPanel1.PerformLayout()
            CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControl2.ResumeLayout(False)
            Me.TabControlPanel2.ResumeLayout(False)
            CType(Me._sellOrders, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControlPanel3.ResumeLayout(False)
            CType(Me._buyOrders, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControlPanel4.ResumeLayout(False)
            Me.TabControlPanel4.PerformLayout()
            CType(Me.adtPrices, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents ofd1 As System.Windows.Forms.OpenFileDialog
        Friend WithEvents lblCustomPrices As System.Windows.Forms.Label
        Friend WithEvents btnResetGrid As System.Windows.Forms.Button
        Friend WithEvents txtSearchPrices As System.Windows.Forms.TextBox
        Friend WithEvents lblSearchPrices As System.Windows.Forms.Label
        Friend WithEvents ctxPrices As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents mnuPriceItemName As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuPriceEdit As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuPriceDelete As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuPriceAdd As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents chkShowOnlyCustom As System.Windows.Forms.CheckBox
        Friend WithEvents ctxMarketExport As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents mnuViewOrders As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuDeleteLog As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
        Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tiPriceSettings As DevComponents.DotNetBar.TabItem
        Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tiCustomPrices As DevComponents.DotNetBar.TabItem
        Friend WithEvents adtPrices As DevComponents.AdvTree.AdvTree
        Friend WithEvents colCustomItem As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colCustomBase As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colCustomMarket As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colCustomCustom As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector5 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle4 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents ElementStyle6 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents ElementStyle5 As DevComponents.DotNetBar.ElementStyle
        Private WithEvents _sellExpires As DevComponents.AdvTree.ColumnHeader
        Private WithEvents _sellPrice As DevComponents.AdvTree.ColumnHeader
        Private WithEvents _sellQuantity As DevComponents.AdvTree.ColumnHeader
        Private WithEvents _sellLocation As DevComponents.AdvTree.ColumnHeader
        Private WithEvents _buyExpires As DevComponents.AdvTree.ColumnHeader
        Private WithEvents _buyPrice As DevComponents.AdvTree.ColumnHeader
        Private WithEvents _buyQuantity As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents _buyLocation As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents TabControl2 As DevComponents.DotNetBar.TabControl
        Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents _sellOrders As DevComponents.AdvTree.AdvTree
        Friend WithEvents colSellLocation As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colSellQty As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colSellPrice As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colSellExpiry As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents _sellOrderTab As DevComponents.DotNetBar.TabItem
        Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents _buyOrders As DevComponents.AdvTree.AdvTree
        Friend WithEvents colBuyLocation As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colBuyQty As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colBuyPrice As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colBuyExpiry As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector2 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle2 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents _buyOrdersTab As DevComponents.DotNetBar.TabItem
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Private WithEvents ComboBox1 As System.Windows.Forms.ComboBox
        Private WithEvents _getMarketOrders As System.Windows.Forms.Button
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents _buyOrderMetrics As MarketItemMetrics
        Friend WithEvents _sellOrderMetrics As MarketItemMetrics
    End Class
End NameSpace