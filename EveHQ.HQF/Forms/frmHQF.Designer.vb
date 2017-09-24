Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmHQF
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHQF))
            Me.ctxFittings = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.mnuFittingsFittingName = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuPreviewShip2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuFittingsShowFitting = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuFittingsRenameFitting = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuFittingsCopyFitting = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuFittingsDeleteFitting = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuFittingsCreateFitting = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuFittingsBCBrowser = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuCompareFittings = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuExportToEve = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuExportToRequisitions = New System.Windows.Forms.ToolStripMenuItem()
            Me.tvwShips = New DevComponents.AdvTree.AdvTree()
            Me.ctxShipBrowser = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.mnuShipBrowserShipName = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuPreviewShip = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuCreateNewFitting = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuAddToShipBay = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me.lblFlyable = New System.Windows.Forms.Label()
            Me.cboFlyable = New System.Windows.Forms.ComboBox()
            Me.pbSearchShips = New System.Windows.Forms.PictureBox()
            Me.txtShipSearch = New System.Windows.Forms.TextBox()
            Me.btnResetShips = New System.Windows.Forms.Button()
            Me.chkFilter8192 = New System.Windows.Forms.CheckBox()
            Me.chkOnlyShowFittable = New System.Windows.Forms.CheckBox()
            Me.chkOnlyShowUsable = New System.Windows.Forms.CheckBox()
            Me.chkApplySkills = New System.Windows.Forms.CheckBox()
            Me.chkFilter32 = New System.Windows.Forms.CheckBox()
            Me.chkFilter16 = New System.Windows.Forms.CheckBox()
            Me.chkFilter8 = New System.Windows.Forms.CheckBox()
            Me.chkFilter4 = New System.Windows.Forms.CheckBox()
            Me.chkFilter2 = New System.Windows.Forms.CheckBox()
            Me.chkFilter1 = New System.Windows.Forms.CheckBox()
            Me.lblModuleDisplayType = New System.Windows.Forms.Label()
            Me.txtSearchModules = New System.Windows.Forms.TextBox()
            Me.lblSearchModules = New System.Windows.Forms.Label()
            Me.ctxModuleList = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.mnuShowModuleInfo = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuSep1 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuAddToFavourites_List = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuRemoveFromFavourites = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuSep2 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuShowModuleMarketGroup = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuShowMetaVariations = New System.Windows.Forms.ToolStripMenuItem()
            Me.imgAttributes = New System.Windows.Forms.ImageList(Me.components)
            Me.tmrClipboard = New System.Windows.Forms.Timer(Me.components)
            Me.panelModules = New DevComponents.DotNetBar.PanelEx()
            Me.panelModuleList = New DevComponents.DotNetBar.PanelEx()
            Me.tvwModules = New DevComponents.AdvTree.AdvTree()
            Me.colModuleName = New DevComponents.AdvTree.ColumnHeader()
            Me.colModuleMeta = New DevComponents.AdvTree.ColumnHeader()
            Me.colModuleCPU = New DevComponents.AdvTree.ColumnHeader()
            Me.colModulePG = New DevComponents.AdvTree.ColumnHeader()
            Me.colModulePrice = New DevComponents.AdvTree.ColumnHeader()
            Me.Node3 = New DevComponents.AdvTree.Node()
            Me.NodeConnector4 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle4 = New DevComponents.DotNetBar.ElementStyle()
            Me.SplitterMods = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.panelModFilters = New DevComponents.DotNetBar.PanelEx()
            Me.tvwItems = New DevComponents.AdvTree.AdvTree()
            Me.NodeConnector3 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle3 = New DevComponents.DotNetBar.ElementStyle()
            Me.SplitterModules = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.panelShips = New DevComponents.DotNetBar.PanelEx()
            Me.SplitterFittings = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.panelFittings = New DevComponents.DotNetBar.PanelEx()
            Me.tvwFittings = New DevComponents.AdvTree.AdvTree()
            Me.NodeConnector2 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle2 = New DevComponents.DotNetBar.ElementStyle()
            Me.SplitterShips = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.tabHQF = New DevComponents.DotNetBar.TabControl()
            Me.rbmc1 = New DevComponents.DotNetBar.RibbonBarMergeContainer()
            Me.rbEditor = New DevComponents.DotNetBar.RibbonBar()
            Me.btnEditor = New DevComponents.DotNetBar.ButtonItem()
            Me.rbImport = New DevComponents.DotNetBar.RibbonBar()
            Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer()
            Me.btnImportEve = New DevComponents.DotNetBar.ButtonItem()
            Me.btnImportEFT = New DevComponents.DotNetBar.ButtonItem()
            Me.btnImport = New DevComponents.DotNetBar.ButtonItem()
            Me.rbExport = New DevComponents.DotNetBar.RibbonBar()
            Me.btnScreenGrab = New DevComponents.DotNetBar.ButtonItem()
            Me.btnExportEve = New DevComponents.DotNetBar.ButtonItem()
            Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
            Me.btnExportFitting = New DevComponents.DotNetBar.ButtonItem()
            Me.btnExportHQF = New DevComponents.DotNetBar.ButtonItem()
            Me.btnExportEFT = New DevComponents.DotNetBar.ButtonItem()
            Me.btnExportForums = New DevComponents.DotNetBar.ButtonItem()
            Me.btnExportDetails = New DevComponents.DotNetBar.ButtonItem()
            Me.btnExportStats = New DevComponents.DotNetBar.ButtonItem()
            Me.btnExportImplants = New DevComponents.DotNetBar.ButtonItem()
            Me.btnExportReq = New DevComponents.DotNetBar.ButtonItem()
            Me.rbTools = New DevComponents.DotNetBar.RibbonBar()
            Me.btnShipSelector = New DevComponents.DotNetBar.ButtonItem()
            Me.btnPilotManager = New DevComponents.DotNetBar.ButtonItem()
            Me.btnImplantManager = New DevComponents.DotNetBar.ButtonItem()
            Me.rbOptions = New DevComponents.DotNetBar.RibbonBar()
            Me.btnOptions = New DevComponents.DotNetBar.ButtonItem()
            Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
            Me.STTShips = New DevComponents.DotNetBar.SuperTooltip()
            Me.ctxFittings.SuspendLayout()
            CType(Me.tvwShips, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ctxShipBrowser.SuspendLayout()
            CType(Me.pbSearchShips, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ctxModuleList.SuspendLayout()
            Me.panelModules.SuspendLayout()
            Me.panelModuleList.SuspendLayout()
            CType(Me.tvwModules, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelModFilters.SuspendLayout()
            CType(Me.tvwItems, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelShips.SuspendLayout()
            Me.panelFittings.SuspendLayout()
            CType(Me.tvwFittings, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabHQF, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.rbmc1.SuspendLayout()
            Me.SuspendLayout()
            '
            'ctxFittings
            '
            Me.ctxFittings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFittingsFittingName, Me.ToolStripMenuItem4, Me.mnuPreviewShip2, Me.mnuFittingsShowFitting, Me.ToolStripMenuItem1, Me.mnuFittingsRenameFitting, Me.mnuFittingsCopyFitting, Me.mnuFittingsDeleteFitting, Me.ToolStripMenuItem3, Me.mnuFittingsCreateFitting, Me.ToolStripMenuItem5, Me.mnuCompareFittings, Me.ToolStripMenuItem7, Me.mnuExportToEve, Me.mnuExportToRequisitions})
            Me.ctxFittings.Name = "ctxFittings"
            Me.ctxFittings.Size = New System.Drawing.Size(192, 276)
            '
            'mnuFittingsFittingName
            '
            Me.mnuFittingsFittingName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mnuFittingsFittingName.Name = "mnuFittingsFittingName"
            Me.mnuFittingsFittingName.Size = New System.Drawing.Size(191, 22)
            Me.mnuFittingsFittingName.Text = "Fitting Name"
            '
            'ToolStripMenuItem4
            '
            Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
            Me.ToolStripMenuItem4.Size = New System.Drawing.Size(188, 6)
            '
            'mnuPreviewShip2
            '
            Me.mnuPreviewShip2.Name = "mnuPreviewShip2"
            Me.mnuPreviewShip2.Size = New System.Drawing.Size(191, 22)
            Me.mnuPreviewShip2.Text = "Preview Ship Details"
            '
            'mnuFittingsShowFitting
            '
            Me.mnuFittingsShowFitting.Name = "mnuFittingsShowFitting"
            Me.mnuFittingsShowFitting.Size = New System.Drawing.Size(191, 22)
            Me.mnuFittingsShowFitting.Text = "Show Fitting"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(188, 6)
            '
            'mnuFittingsRenameFitting
            '
            Me.mnuFittingsRenameFitting.Name = "mnuFittingsRenameFitting"
            Me.mnuFittingsRenameFitting.Size = New System.Drawing.Size(191, 22)
            Me.mnuFittingsRenameFitting.Text = "Rename Fitting"
            '
            'mnuFittingsCopyFitting
            '
            Me.mnuFittingsCopyFitting.Name = "mnuFittingsCopyFitting"
            Me.mnuFittingsCopyFitting.Size = New System.Drawing.Size(191, 22)
            Me.mnuFittingsCopyFitting.Text = "Copy Fitting"
            '
            'mnuFittingsDeleteFitting
            '
            Me.mnuFittingsDeleteFitting.Name = "mnuFittingsDeleteFitting"
            Me.mnuFittingsDeleteFitting.Size = New System.Drawing.Size(191, 22)
            Me.mnuFittingsDeleteFitting.Text = "Delete Fitting"
            '
            'ToolStripMenuItem3
            '
            Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
            Me.ToolStripMenuItem3.Size = New System.Drawing.Size(188, 6)
            '
            'mnuFittingsCreateFitting
            '
            Me.mnuFittingsCreateFitting.Name = "mnuFittingsCreateFitting"
            Me.mnuFittingsCreateFitting.Size = New System.Drawing.Size(191, 22)
            Me.mnuFittingsCreateFitting.Text = "Create New Fitting"
            '
            'ToolStripMenuItem5
            '
            Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
            Me.ToolStripMenuItem5.Size = New System.Drawing.Size(188, 6)
            '
            'mnuCompareFittings
            '
            Me.mnuCompareFittings.Name = "mnuCompareFittings"
            Me.mnuCompareFittings.Size = New System.Drawing.Size(191, 22)
            Me.mnuCompareFittings.Text = "Compare Fittings"
            '
            'ToolStripMenuItem7
            '
            Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
            Me.ToolStripMenuItem7.Size = New System.Drawing.Size(188, 6)
            '
            'mnuExportToEve
            '
            Me.mnuExportToEve.Name = "mnuExportToEve"
            Me.mnuExportToEve.Size = New System.Drawing.Size(191, 22)
            Me.mnuExportToEve.Text = "Export To Eve"
            '
            'mnuExportToRequisitions
            '
            Me.mnuExportToRequisitions.Name = "mnuExportToRequisitions"
            Me.mnuExportToRequisitions.Size = New System.Drawing.Size(191, 22)
            Me.mnuExportToRequisitions.Text = "Export To Requisitions"
            '
            'tvwShips
            '
            Me.tvwShips.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.tvwShips.AllowDrop = True
            Me.tvwShips.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.tvwShips.BackgroundStyle.Class = "TreeBorderKey"
            Me.tvwShips.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.tvwShips.ContextMenuStrip = Me.ctxShipBrowser
            Me.tvwShips.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tvwShips.DragDropEnabled = False
            Me.tvwShips.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle
            
            Me.tvwShips.Location = New System.Drawing.Point(0, 330)
            Me.tvwShips.Name = "tvwShips"
            Me.tvwShips.NodesConnector = Me.NodeConnector1
            Me.tvwShips.NodeSpacing = 1
            Me.tvwShips.NodeStyle = Me.ElementStyle1
            Me.tvwShips.PathSeparator = ";"
            Me.tvwShips.Size = New System.Drawing.Size(228, 391)
            Me.tvwShips.Styles.Add(Me.ElementStyle1)
            Me.tvwShips.TabIndex = 7
            Me.tvwShips.Text = "AdvTree1"
            '
            'ctxShipBrowser
            '
            Me.ctxShipBrowser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShipBrowserShipName, Me.ToolStripMenuItem2, Me.mnuPreviewShip, Me.mnuCreateNewFitting, Me.mnuAddToShipBay, Me.ToolStripMenuItem6})
            Me.ctxShipBrowser.Name = "ctxShipBrowser"
            Me.ctxShipBrowser.Size = New System.Drawing.Size(231, 126)
            '
            'mnuShipBrowserShipName
            '
            Me.mnuShipBrowserShipName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.mnuShipBrowserShipName.Name = "mnuShipBrowserShipName"
            Me.mnuShipBrowserShipName.Size = New System.Drawing.Size(230, 22)
            Me.mnuShipBrowserShipName.Text = "Ship Name"
            '
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(227, 6)
            '
            'mnuPreviewShip
            '
            Me.mnuPreviewShip.Name = "mnuPreviewShip"
            Me.mnuPreviewShip.Size = New System.Drawing.Size(230, 22)
            Me.mnuPreviewShip.Text = "Preview Ship Details"
            Me.mnuPreviewShip.ToolTipText = "View Ship Stats and Attributes"
            '
            'mnuCreateNewFitting
            '
            Me.mnuCreateNewFitting.Name = "mnuCreateNewFitting"
            Me.mnuCreateNewFitting.Size = New System.Drawing.Size(230, 22)
            Me.mnuCreateNewFitting.Text = "Create New Fitting"
            Me.mnuCreateNewFitting.ToolTipText = "Create a new fitting for this ship type"
            '
            'mnuAddToShipBay
            '
            Me.mnuAddToShipBay.Name = "mnuAddToShipBay"
            Me.mnuAddToShipBay.Size = New System.Drawing.Size(230, 22)
            Me.mnuAddToShipBay.Text = "Add to Ship Maintenance Bay"
            '
            'ToolStripMenuItem6
            '
            Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
            Me.ToolStripMenuItem6.Size = New System.Drawing.Size(227, 6)
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
            'lblFlyable
            '
            Me.lblFlyable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblFlyable.AutoSize = True
            Me.lblFlyable.Location = New System.Drawing.Point(5, 301)
            Me.lblFlyable.Name = "lblFlyable"
            Me.lblFlyable.Size = New System.Drawing.Size(45, 13)
            Me.lblFlyable.TabIndex = 6
            Me.lblFlyable.Text = "Flyable:"
            '
            'cboFlyable
            '
            Me.cboFlyable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboFlyable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboFlyable.FormattingEnabled = True
            Me.cboFlyable.Location = New System.Drawing.Point(53, 298)
            Me.cboFlyable.Name = "cboFlyable"
            Me.cboFlyable.Size = New System.Drawing.Size(169, 21)
            Me.cboFlyable.TabIndex = 5
            '
            'pbSearchShips
            '
            Me.pbSearchShips.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.pbSearchShips.Image = CType(resources.GetObject("pbSearchShips.Image"), System.Drawing.Image)
            Me.pbSearchShips.Location = New System.Drawing.Point(5, 273)
            Me.pbSearchShips.Name = "pbSearchShips"
            Me.pbSearchShips.Size = New System.Drawing.Size(20, 20)
            Me.pbSearchShips.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pbSearchShips.TabIndex = 4
            Me.pbSearchShips.TabStop = False
            '
            'txtShipSearch
            '
            Me.txtShipSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtShipSearch.Location = New System.Drawing.Point(31, 271)
            Me.txtShipSearch.Name = "txtShipSearch"
            Me.txtShipSearch.Size = New System.Drawing.Size(141, 21)
            Me.txtShipSearch.TabIndex = 1
            '
            'btnResetShips
            '
            Me.btnResetShips.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnResetShips.Location = New System.Drawing.Point(178, 269)
            Me.btnResetShips.Name = "btnResetShips"
            Me.btnResetShips.Size = New System.Drawing.Size(44, 23)
            Me.btnResetShips.TabIndex = 3
            Me.btnResetShips.Text = "Reset"
            Me.btnResetShips.UseVisualStyleBackColor = True
            '
            'chkFilter8192
            '
            Me.chkFilter8192.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.chkFilter8192.AutoSize = True
            Me.chkFilter8192.Checked = True
            Me.chkFilter8192.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkFilter8192.Location = New System.Drawing.Point(154, 259)
            Me.chkFilter8192.Name = "chkFilter8192"
            Me.chkFilter8192.Size = New System.Drawing.Size(58, 17)
            Me.chkFilter8192.TabIndex = 18
            Me.chkFilter8192.Tag = "8192"
            Me.chkFilter8192.Text = "Tech 3"
            Me.chkFilter8192.UseVisualStyleBackColor = True
            '
            'chkOnlyShowFittable
            '
            Me.chkOnlyShowFittable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.chkOnlyShowFittable.AutoSize = True
            Me.chkOnlyShowFittable.Location = New System.Drawing.Point(154, 307)
            Me.chkOnlyShowFittable.Name = "chkOnlyShowFittable"
            Me.chkOnlyShowFittable.Size = New System.Drawing.Size(62, 17)
            Me.chkOnlyShowFittable.TabIndex = 17
            Me.chkOnlyShowFittable.Tag = "1"
            Me.chkOnlyShowFittable.Text = "Fittable"
            Me.chkOnlyShowFittable.UseVisualStyleBackColor = True
            '
            'chkOnlyShowUsable
            '
            Me.chkOnlyShowUsable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.chkOnlyShowUsable.AutoSize = True
            Me.chkOnlyShowUsable.Location = New System.Drawing.Point(90, 307)
            Me.chkOnlyShowUsable.Name = "chkOnlyShowUsable"
            Me.chkOnlyShowUsable.Size = New System.Drawing.Size(58, 17)
            Me.chkOnlyShowUsable.TabIndex = 16
            Me.chkOnlyShowUsable.Tag = "1"
            Me.chkOnlyShowUsable.Text = "Usable"
            Me.chkOnlyShowUsable.UseVisualStyleBackColor = True
            '
            'chkApplySkills
            '
            Me.chkApplySkills.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.chkApplySkills.AutoSize = True
            Me.chkApplySkills.Location = New System.Drawing.Point(6, 307)
            Me.chkApplySkills.Name = "chkApplySkills"
            Me.chkApplySkills.Size = New System.Drawing.Size(78, 17)
            Me.chkApplySkills.TabIndex = 15
            Me.chkApplySkills.Tag = "1"
            Me.chkApplySkills.Text = "Apply Skills"
            Me.chkApplySkills.UseVisualStyleBackColor = True
            '
            'chkFilter32
            '
            Me.chkFilter32.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.chkFilter32.AutoSize = True
            Me.chkFilter32.BackColor = System.Drawing.Color.Transparent
            Me.chkFilter32.Checked = True
            Me.chkFilter32.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkFilter32.Location = New System.Drawing.Point(89, 291)
            Me.chkFilter32.Name = "chkFilter32"
            Me.chkFilter32.Size = New System.Drawing.Size(79, 17)
            Me.chkFilter32.TabIndex = 14
            Me.chkFilter32.Tag = "32"
            Me.chkFilter32.Text = "Deadspace"
            Me.chkFilter32.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.chkFilter32.UseVisualStyleBackColor = False
            '
            'chkFilter16
            '
            Me.chkFilter16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.chkFilter16.AutoSize = True
            Me.chkFilter16.Checked = True
            Me.chkFilter16.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkFilter16.Location = New System.Drawing.Point(89, 275)
            Me.chkFilter16.Name = "chkFilter16"
            Me.chkFilter16.Size = New System.Drawing.Size(59, 17)
            Me.chkFilter16.TabIndex = 13
            Me.chkFilter16.Tag = "16"
            Me.chkFilter16.Text = "Officer"
            Me.chkFilter16.UseVisualStyleBackColor = True
            '
            'chkFilter8
            '
            Me.chkFilter8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.chkFilter8.AutoSize = True
            Me.chkFilter8.Checked = True
            Me.chkFilter8.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkFilter8.Location = New System.Drawing.Point(6, 275)
            Me.chkFilter8.Name = "chkFilter8"
            Me.chkFilter8.Size = New System.Drawing.Size(61, 17)
            Me.chkFilter8.TabIndex = 12
            Me.chkFilter8.Tag = "8"
            Me.chkFilter8.Text = "Faction"
            Me.chkFilter8.UseVisualStyleBackColor = True
            '
            'chkFilter4
            '
            Me.chkFilter4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.chkFilter4.AutoSize = True
            Me.chkFilter4.Checked = True
            Me.chkFilter4.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkFilter4.Location = New System.Drawing.Point(6, 291)
            Me.chkFilter4.Name = "chkFilter4"
            Me.chkFilter4.Size = New System.Drawing.Size(68, 17)
            Me.chkFilter4.TabIndex = 11
            Me.chkFilter4.Tag = "4"
            Me.chkFilter4.Text = "Storyline"
            Me.chkFilter4.UseVisualStyleBackColor = True
            '
            'chkFilter2
            '
            Me.chkFilter2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.chkFilter2.AutoSize = True
            Me.chkFilter2.Checked = True
            Me.chkFilter2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkFilter2.Location = New System.Drawing.Point(90, 259)
            Me.chkFilter2.Name = "chkFilter2"
            Me.chkFilter2.Size = New System.Drawing.Size(58, 17)
            Me.chkFilter2.TabIndex = 10
            Me.chkFilter2.Tag = "2"
            Me.chkFilter2.Text = "Tech 2"
            Me.chkFilter2.UseVisualStyleBackColor = True
            '
            'chkFilter1
            '
            Me.chkFilter1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.chkFilter1.AutoSize = True
            Me.chkFilter1.Checked = True
            Me.chkFilter1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkFilter1.Location = New System.Drawing.Point(6, 259)
            Me.chkFilter1.Name = "chkFilter1"
            Me.chkFilter1.Size = New System.Drawing.Size(58, 17)
            Me.chkFilter1.TabIndex = 9
            Me.chkFilter1.Tag = "1"
            Me.chkFilter1.Text = "Tech 1"
            Me.chkFilter1.UseVisualStyleBackColor = True
            '
            'lblModuleDisplayType
            '
            Me.lblModuleDisplayType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblModuleDisplayType.AutoSize = True
            Me.lblModuleDisplayType.Location = New System.Drawing.Point(3, 342)
            Me.lblModuleDisplayType.Name = "lblModuleDisplayType"
            Me.lblModuleDisplayType.Size = New System.Drawing.Size(87, 13)
            Me.lblModuleDisplayType.TabIndex = 20
            Me.lblModuleDisplayType.Text = "Displaying: None"
            '
            'txtSearchModules
            '
            Me.txtSearchModules.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSearchModules.Location = New System.Drawing.Point(56, 328)
            Me.txtSearchModules.Name = "txtSearchModules"
            Me.txtSearchModules.Size = New System.Drawing.Size(171, 21)
            Me.txtSearchModules.TabIndex = 19
            '
            'lblSearchModules
            '
            Me.lblSearchModules.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblSearchModules.AutoSize = True
            Me.lblSearchModules.Location = New System.Drawing.Point(6, 331)
            Me.lblSearchModules.Name = "lblSearchModules"
            Me.lblSearchModules.Size = New System.Drawing.Size(44, 13)
            Me.lblSearchModules.TabIndex = 18
            Me.lblSearchModules.Text = "Search:"
            '
            'ctxModuleList
            '
            Me.ctxModuleList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShowModuleInfo, Me.mnuSep1, Me.mnuAddToFavourites_List, Me.mnuRemoveFromFavourites, Me.mnuSep2, Me.mnuShowModuleMarketGroup, Me.mnuShowMetaVariations})
            Me.ctxModuleList.Name = "ctxModuleList"
            Me.ctxModuleList.Size = New System.Drawing.Size(224, 126)
            '
            'mnuShowModuleInfo
            '
            Me.mnuShowModuleInfo.Name = "mnuShowModuleInfo"
            Me.mnuShowModuleInfo.Size = New System.Drawing.Size(223, 22)
            Me.mnuShowModuleInfo.Text = "Show Info"
            '
            'mnuSep1
            '
            Me.mnuSep1.Name = "mnuSep1"
            Me.mnuSep1.Size = New System.Drawing.Size(220, 6)
            '
            'mnuAddToFavourites_List
            '
            Me.mnuAddToFavourites_List.Name = "mnuAddToFavourites_List"
            Me.mnuAddToFavourites_List.Size = New System.Drawing.Size(223, 22)
            Me.mnuAddToFavourites_List.Text = "Add To Favourites"
            '
            'mnuRemoveFromFavourites
            '
            Me.mnuRemoveFromFavourites.Name = "mnuRemoveFromFavourites"
            Me.mnuRemoveFromFavourites.Size = New System.Drawing.Size(223, 22)
            Me.mnuRemoveFromFavourites.Text = "Remove From Favourites"
            '
            'mnuSep2
            '
            Me.mnuSep2.Name = "mnuSep2"
            Me.mnuSep2.Size = New System.Drawing.Size(220, 6)
            '
            'mnuShowModuleMarketGroup
            '
            Me.mnuShowModuleMarketGroup.Name = "mnuShowModuleMarketGroup"
            Me.mnuShowModuleMarketGroup.Size = New System.Drawing.Size(223, 22)
            Me.mnuShowModuleMarketGroup.Text = "Show Module Market Group"
            '
            'mnuShowMetaVariations
            '
            Me.mnuShowMetaVariations.Name = "mnuShowMetaVariations"
            Me.mnuShowMetaVariations.Size = New System.Drawing.Size(223, 22)
            Me.mnuShowMetaVariations.Text = "Show Meta Variations"
            '
            'imgAttributes
            '
            Me.imgAttributes.ImageStream = CType(resources.GetObject("imgAttributes.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imgAttributes.TransparentColor = System.Drawing.Color.Transparent
            Me.imgAttributes.Images.SetKeyName(0, "lowSlot")
            Me.imgAttributes.Images.SetKeyName(1, "midSlot")
            Me.imgAttributes.Images.SetKeyName(2, "hiSlot")
            Me.imgAttributes.Images.SetKeyName(3, "rigSlot")
            '
            'tmrClipboard
            '
            Me.tmrClipboard.Enabled = True
            Me.tmrClipboard.Interval = 1000
            '
            'panelModules
            '
            Me.panelModules.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelModules.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelModules.Controls.Add(Me.panelModuleList)
            Me.panelModules.Controls.Add(Me.SplitterMods)
            Me.panelModules.Controls.Add(Me.panelModFilters)
            Me.panelModules.DisabledBackColor = System.Drawing.Color.Empty
            Me.panelModules.Dock = System.Windows.Forms.DockStyle.Right
            Me.panelModules.Location = New System.Drawing.Point(1054, 0)
            Me.panelModules.Name = "panelModules"
            Me.panelModules.Size = New System.Drawing.Size(230, 721)
            Me.panelModules.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelModules.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelModules.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelModules.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelModules.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelModules.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelModules.Style.GradientAngle = 90
            Me.panelModules.TabIndex = 21
            '
            'panelModuleList
            '
            Me.panelModuleList.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelModuleList.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelModuleList.Controls.Add(Me.lblModuleDisplayType)
            Me.panelModuleList.Controls.Add(Me.tvwModules)
            Me.panelModuleList.DisabledBackColor = System.Drawing.Color.Empty
            Me.panelModuleList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelModuleList.Location = New System.Drawing.Point(0, 361)
            Me.panelModuleList.Name = "panelModuleList"
            Me.panelModuleList.Size = New System.Drawing.Size(230, 360)
            Me.panelModuleList.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelModuleList.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelModuleList.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelModuleList.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelModuleList.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelModuleList.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelModuleList.Style.GradientAngle = 90
            Me.panelModuleList.TabIndex = 21
            '
            'tvwModules
            '
            Me.tvwModules.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.tvwModules.AllowDrop = True
            Me.tvwModules.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tvwModules.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.tvwModules.BackgroundStyle.Class = "TreeBorderKey"
            Me.tvwModules.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.tvwModules.Columns.Add(Me.colModuleName)
            Me.tvwModules.Columns.Add(Me.colModuleMeta)
            Me.tvwModules.Columns.Add(Me.colModuleCPU)
            Me.tvwModules.Columns.Add(Me.colModulePG)
            Me.tvwModules.Columns.Add(Me.colModulePrice)
            Me.tvwModules.ContextMenuStrip = Me.ctxModuleList
            Me.tvwModules.DragDropEnabled = False
            Me.tvwModules.ExpandWidth = 0
            Me.tvwModules.Indent = 0
            
            Me.tvwModules.Location = New System.Drawing.Point(0, 0)
            Me.tvwModules.Name = "tvwModules"
            Me.tvwModules.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node3})
            Me.tvwModules.NodesConnector = Me.NodeConnector4
            Me.tvwModules.NodeSpacing = 0
            Me.tvwModules.NodeStyle = Me.ElementStyle4
            Me.tvwModules.PathSeparator = ";"
            Me.tvwModules.Size = New System.Drawing.Size(230, 339)
            Me.tvwModules.Styles.Add(Me.ElementStyle4)
            Me.tvwModules.TabIndex = 21
            Me.tvwModules.Text = "AdvTree1"
            '
            'colModuleName
            '
            Me.colModuleName.DisplayIndex = 1
            Me.colModuleName.Name = "colModuleName"
            Me.colModuleName.SortingEnabled = False
            Me.colModuleName.Text = "Module"
            Me.colModuleName.Width.Absolute = 150
            '
            'colModuleMeta
            '
            Me.colModuleMeta.DisplayIndex = 2
            Me.colModuleMeta.Name = "colModuleMeta"
            Me.colModuleMeta.SortingEnabled = False
            Me.colModuleMeta.Text = "Meta"
            Me.colModuleMeta.Width.Absolute = 35
            '
            'colModuleCPU
            '
            Me.colModuleCPU.DisplayIndex = 3
            Me.colModuleCPU.Name = "colModuleCPU"
            Me.colModuleCPU.SortingEnabled = False
            Me.colModuleCPU.Text = "CPU"
            Me.colModuleCPU.Width.Absolute = 40
            '
            'colModulePG
            '
            Me.colModulePG.DisplayIndex = 4
            Me.colModulePG.Name = "colModulePG"
            Me.colModulePG.SortingEnabled = False
            Me.colModulePG.Text = "PG"
            Me.colModulePG.Width.Absolute = 40
            '
            'colModulePrice
            '
            Me.colModulePrice.DisplayIndex = 5
            Me.colModulePrice.Name = "colModulePrice"
            Me.colModulePrice.SortingEnabled = False
            Me.colModulePrice.Text = "Price"
            Me.colModulePrice.Width.Absolute = 80
            '
            'Node3
            '
            Me.Node3.Name = "Node3"
            '
            'NodeConnector4
            '
            Me.NodeConnector4.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle4
            '
            Me.ElementStyle4.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle4.Name = "ElementStyle4"
            Me.ElementStyle4.TextColor = System.Drawing.SystemColors.ControlText
            '
            'SplitterMods
            '
            Me.SplitterMods.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.SplitterMods.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.SplitterMods.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.SplitterMods.Dock = System.Windows.Forms.DockStyle.Top
            Me.SplitterMods.Expandable = False
            Me.SplitterMods.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.SplitterMods.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.SplitterMods.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SplitterMods.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.SplitterMods.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SplitterMods.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.SplitterMods.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SplitterMods.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.SplitterMods.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer))
            Me.SplitterMods.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.SplitterMods.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.SplitterMods.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.SplitterMods.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.SplitterMods.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.SplitterMods.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SplitterMods.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.SplitterMods.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.SplitterMods.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.SplitterMods.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SplitterMods.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.SplitterMods.Location = New System.Drawing.Point(0, 355)
            Me.SplitterMods.Name = "SplitterMods"
            Me.SplitterMods.Size = New System.Drawing.Size(230, 6)
            Me.SplitterMods.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.SplitterMods.TabIndex = 1
            Me.SplitterMods.TabStop = False
            '
            'panelModFilters
            '
            Me.panelModFilters.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelModFilters.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelModFilters.Controls.Add(Me.tvwItems)
            Me.panelModFilters.Controls.Add(Me.txtSearchModules)
            Me.panelModFilters.Controls.Add(Me.lblSearchModules)
            Me.panelModFilters.Controls.Add(Me.chkFilter1)
            Me.panelModFilters.Controls.Add(Me.chkFilter8192)
            Me.panelModFilters.Controls.Add(Me.chkFilter2)
            Me.panelModFilters.Controls.Add(Me.chkOnlyShowFittable)
            Me.panelModFilters.Controls.Add(Me.chkFilter4)
            Me.panelModFilters.Controls.Add(Me.chkFilter8)
            Me.panelModFilters.Controls.Add(Me.chkOnlyShowUsable)
            Me.panelModFilters.Controls.Add(Me.chkFilter16)
            Me.panelModFilters.Controls.Add(Me.chkFilter32)
            Me.panelModFilters.Controls.Add(Me.chkApplySkills)
            Me.panelModFilters.DisabledBackColor = System.Drawing.Color.Empty
            Me.panelModFilters.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelModFilters.Location = New System.Drawing.Point(0, 0)
            Me.panelModFilters.Name = "panelModFilters"
            Me.panelModFilters.Size = New System.Drawing.Size(230, 355)
            Me.panelModFilters.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelModFilters.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelModFilters.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelModFilters.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelModFilters.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelModFilters.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelModFilters.Style.GradientAngle = 90
            Me.panelModFilters.TabIndex = 0
            '
            'tvwItems
            '
            Me.tvwItems.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.tvwItems.AllowDrop = True
            Me.tvwItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tvwItems.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.tvwItems.BackgroundStyle.Class = "TreeBorderKey"
            Me.tvwItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.tvwItems.DragDropEnabled = False
            Me.tvwItems.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle
            
            Me.tvwItems.Location = New System.Drawing.Point(0, 0)
            Me.tvwItems.Name = "tvwItems"
            Me.tvwItems.NodesConnector = Me.NodeConnector3
            Me.tvwItems.NodeSpacing = 1
            Me.tvwItems.NodeStyle = Me.ElementStyle3
            Me.tvwItems.PathSeparator = ";"
            Me.tvwItems.Size = New System.Drawing.Size(230, 253)
            Me.tvwItems.Styles.Add(Me.ElementStyle3)
            Me.tvwItems.TabIndex = 20
            Me.tvwItems.Text = "AdvTree1"
            '
            'NodeConnector3
            '
            Me.NodeConnector3.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle3
            '
            Me.ElementStyle3.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle3.Name = "ElementStyle3"
            Me.ElementStyle3.TextColor = System.Drawing.SystemColors.ControlText
            '
            'SplitterModules
            '
            Me.SplitterModules.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.SplitterModules.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.SplitterModules.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.SplitterModules.Dock = System.Windows.Forms.DockStyle.Right
            Me.SplitterModules.ExpandableControl = Me.panelModules
            Me.SplitterModules.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.SplitterModules.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.SplitterModules.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SplitterModules.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.SplitterModules.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SplitterModules.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.SplitterModules.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SplitterModules.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.SplitterModules.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer))
            Me.SplitterModules.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.SplitterModules.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.SplitterModules.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.SplitterModules.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.SplitterModules.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.SplitterModules.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SplitterModules.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.SplitterModules.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.SplitterModules.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.SplitterModules.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SplitterModules.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.SplitterModules.Location = New System.Drawing.Point(1048, 0)
            Me.SplitterModules.Name = "SplitterModules"
            Me.SplitterModules.Size = New System.Drawing.Size(6, 721)
            Me.SplitterModules.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.SplitterModules.TabIndex = 22
            Me.SplitterModules.TabStop = False
            '
            'panelShips
            '
            Me.panelShips.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelShips.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelShips.Controls.Add(Me.tvwShips)
            Me.panelShips.Controls.Add(Me.SplitterFittings)
            Me.panelShips.Controls.Add(Me.panelFittings)
            Me.panelShips.DisabledBackColor = System.Drawing.Color.Empty
            Me.panelShips.Dock = System.Windows.Forms.DockStyle.Left
            Me.panelShips.Location = New System.Drawing.Point(0, 0)
            Me.panelShips.Name = "panelShips"
            Me.panelShips.Size = New System.Drawing.Size(228, 721)
            Me.panelShips.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelShips.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelShips.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelShips.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelShips.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelShips.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelShips.Style.GradientAngle = 90
            Me.panelShips.TabIndex = 23
            '
            'SplitterFittings
            '
            Me.SplitterFittings.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.SplitterFittings.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.SplitterFittings.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.SplitterFittings.Dock = System.Windows.Forms.DockStyle.Top
            Me.SplitterFittings.Expandable = False
            Me.SplitterFittings.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.SplitterFittings.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.SplitterFittings.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SplitterFittings.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.SplitterFittings.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SplitterFittings.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.SplitterFittings.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SplitterFittings.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.SplitterFittings.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer))
            Me.SplitterFittings.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.SplitterFittings.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.SplitterFittings.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.SplitterFittings.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.SplitterFittings.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.SplitterFittings.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SplitterFittings.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.SplitterFittings.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.SplitterFittings.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.SplitterFittings.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SplitterFittings.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.SplitterFittings.Location = New System.Drawing.Point(0, 324)
            Me.SplitterFittings.Name = "SplitterFittings"
            Me.SplitterFittings.Size = New System.Drawing.Size(228, 6)
            Me.SplitterFittings.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.SplitterFittings.TabIndex = 1
            Me.SplitterFittings.TabStop = False
            '
            'panelFittings
            '
            Me.panelFittings.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelFittings.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelFittings.Controls.Add(Me.tvwFittings)
            Me.panelFittings.Controls.Add(Me.txtShipSearch)
            Me.panelFittings.Controls.Add(Me.cboFlyable)
            Me.panelFittings.Controls.Add(Me.lblFlyable)
            Me.panelFittings.Controls.Add(Me.pbSearchShips)
            Me.panelFittings.Controls.Add(Me.btnResetShips)
            Me.panelFittings.DisabledBackColor = System.Drawing.Color.Empty
            Me.panelFittings.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelFittings.Location = New System.Drawing.Point(0, 0)
            Me.panelFittings.Name = "panelFittings"
            Me.panelFittings.Size = New System.Drawing.Size(228, 324)
            Me.panelFittings.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelFittings.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelFittings.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelFittings.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelFittings.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelFittings.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelFittings.Style.GradientAngle = 90
            Me.panelFittings.TabIndex = 0
            '
            'tvwFittings
            '
            Me.tvwFittings.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.tvwFittings.AllowDrop = True
            Me.tvwFittings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tvwFittings.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.tvwFittings.BackgroundStyle.Class = "TreeBorderKey"
            Me.tvwFittings.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.tvwFittings.ContextMenuStrip = Me.ctxFittings
            Me.tvwFittings.DragDropEnabled = False
            Me.tvwFittings.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle
            
            Me.tvwFittings.Location = New System.Drawing.Point(0, 0)
            Me.tvwFittings.MultiSelect = True
            Me.tvwFittings.MultiSelectRule = DevComponents.AdvTree.eMultiSelectRule.AnyNode
            Me.tvwFittings.Name = "tvwFittings"
            Me.tvwFittings.NodesConnector = Me.NodeConnector2
            Me.tvwFittings.NodeSpacing = 1
            Me.tvwFittings.NodeStyle = Me.ElementStyle2
            Me.tvwFittings.PathSeparator = ";"
            Me.tvwFittings.Size = New System.Drawing.Size(228, 264)
            Me.tvwFittings.Styles.Add(Me.ElementStyle2)
            Me.tvwFittings.TabIndex = 7
            Me.tvwFittings.Text = "AdvTree1"
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
            'SplitterShips
            '
            Me.SplitterShips.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.SplitterShips.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.SplitterShips.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.SplitterShips.ExpandableControl = Me.panelShips
            Me.SplitterShips.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.SplitterShips.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.SplitterShips.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SplitterShips.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.SplitterShips.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SplitterShips.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.SplitterShips.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SplitterShips.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.SplitterShips.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer))
            Me.SplitterShips.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.SplitterShips.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.SplitterShips.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.SplitterShips.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.SplitterShips.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.SplitterShips.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SplitterShips.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.SplitterShips.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.SplitterShips.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.SplitterShips.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SplitterShips.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.SplitterShips.Location = New System.Drawing.Point(228, 0)
            Me.SplitterShips.Name = "SplitterShips"
            Me.SplitterShips.Size = New System.Drawing.Size(6, 721)
            Me.SplitterShips.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.SplitterShips.TabIndex = 24
            Me.SplitterShips.TabStop = False
            '
            'tabHQF
            '
            Me.tabHQF.AntiAlias = True
            Me.tabHQF.AutoCloseTabs = True
            Me.tabHQF.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(125, Byte), Integer))
            Me.tabHQF.CanReorderTabs = True
            Me.tabHQF.CloseButtonOnTabsVisible = True
            Me.tabHQF.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabHQF.Location = New System.Drawing.Point(234, 0)
            Me.tabHQF.Name = "tabHQF"
            Me.tabHQF.SelectedTabFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.tabHQF.SelectedTabIndex = -1
            Me.tabHQF.Size = New System.Drawing.Size(814, 721)
            Me.tabHQF.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
            Me.tabHQF.TabIndex = 25
            Me.tabHQF.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineNoNavigationBox
            Me.tabHQF.Text = "HQF!"
            '
            'rbmc1
            '
            Me.rbmc1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.rbmc1.Controls.Add(Me.rbEditor)
            Me.rbmc1.Controls.Add(Me.rbImport)
            Me.rbmc1.Controls.Add(Me.rbExport)
            Me.rbmc1.Controls.Add(Me.rbTools)
            Me.rbmc1.Controls.Add(Me.rbOptions)
            Me.rbmc1.Location = New System.Drawing.Point(240, 12)
            Me.rbmc1.Name = "rbmc1"
            Me.rbmc1.RibbonTabText = "HQF"
            Me.rbmc1.Size = New System.Drawing.Size(802, 100)
            '
            '
            '
            Me.rbmc1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.rbmc1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.rbmc1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.rbmc1.TabIndex = 1
            Me.rbmc1.Visible = False
            '
            'rbEditor
            '
            Me.rbEditor.AutoOverflowEnabled = True
            '
            '
            '
            Me.rbEditor.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.rbEditor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.rbEditor.ContainerControlProcessDialogKey = True
            Me.rbEditor.DragDropSupport = True
            Me.rbEditor.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnEditor})
            
            Me.rbEditor.Location = New System.Drawing.Point(719, 0)
            Me.rbEditor.Name = "rbEditor"
            Me.rbEditor.Size = New System.Drawing.Size(53, 100)
            Me.rbEditor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.rbEditor.TabIndex = 5
            Me.rbEditor.Text = "Editor"
            '
            '
            '
            Me.rbEditor.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.rbEditor.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            'btnEditor
            '
            Me.btnEditor.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.btnEditor.Image = CType(resources.GetObject("btnEditor.Image"), System.Drawing.Image)
            Me.btnEditor.ImageFixedSize = New System.Drawing.Size(36, 36)
            Me.btnEditor.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.btnEditor.Name = "btnEditor"
            Me.btnEditor.SubItemsExpandWidth = 14
            Me.btnEditor.Text = "HQF Editor"
            '
            'rbImport
            '
            Me.rbImport.AutoOverflowEnabled = True
            '
            '
            '
            Me.rbImport.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.rbImport.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.rbImport.ContainerControlProcessDialogKey = True
            Me.rbImport.DragDropSupport = True
            Me.rbImport.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer2, Me.btnImport})
            
            Me.rbImport.Location = New System.Drawing.Point(521, 0)
            Me.rbImport.Name = "rbImport"
            Me.rbImport.Size = New System.Drawing.Size(196, 100)
            Me.rbImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.rbImport.TabIndex = 3
            Me.rbImport.Text = "Import"
            '
            '
            '
            Me.rbImport.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.rbImport.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.rbImport.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
            '
            'ItemContainer2
            '
            '
            '
            '
            Me.ItemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ItemContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
            Me.ItemContainer2.Name = "ItemContainer2"
            Me.ItemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnImportEve, Me.btnImportEFT})
            '
            '
            '
            Me.ItemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            'btnImportEve
            '
            Me.btnImportEve.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.btnImportEve.Image = CType(resources.GetObject("btnImportEve.Image"), System.Drawing.Image)
            Me.btnImportEve.ImageFixedSize = New System.Drawing.Size(30, 30)
            Me.btnImportEve.Name = "btnImportEve"
            Me.btnImportEve.Text = "Import Eve Fittings"
            '
            'btnImportEFT
            '
            Me.btnImportEFT.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.btnImportEFT.Image = CType(resources.GetObject("btnImportEFT.Image"), System.Drawing.Image)
            Me.btnImportEFT.ImageFixedSize = New System.Drawing.Size(30, 30)
            Me.btnImportEFT.Name = "btnImportEFT"
            Me.btnImportEFT.Text = "Import From EFT"
            '
            'btnImport
            '
            Me.btnImport.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.btnImport.Enabled = False
            Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Image)
            Me.btnImport.ImageFixedSize = New System.Drawing.Size(36, 36)
            Me.btnImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.btnImport.Name = "btnImport"
            Me.btnImport.SubItemsExpandWidth = 14
            Me.btnImport.Text = "Clipboard Import"
            '
            'rbExport
            '
            Me.rbExport.AutoOverflowEnabled = True
            '
            '
            '
            Me.rbExport.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.rbExport.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.rbExport.ContainerControlProcessDialogKey = True
            Me.rbExport.DragDropSupport = True
            Me.rbExport.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnScreenGrab, Me.btnExportEve, Me.ItemContainer1, Me.btnExportReq})
            
            Me.rbExport.Location = New System.Drawing.Point(219, 0)
            Me.rbExport.Name = "rbExport"
            Me.rbExport.Size = New System.Drawing.Size(300, 100)
            Me.rbExport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.rbExport.TabIndex = 2
            Me.rbExport.Text = "Current Fitting Export"
            '
            '
            '
            Me.rbExport.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.rbExport.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.rbExport.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
            '
            'btnScreenGrab
            '
            Me.btnScreenGrab.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.btnScreenGrab.Enabled = False
            Me.btnScreenGrab.Image = CType(resources.GetObject("btnScreenGrab.Image"), System.Drawing.Image)
            Me.btnScreenGrab.ImageFixedSize = New System.Drawing.Size(40, 40)
            Me.btnScreenGrab.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.btnScreenGrab.Name = "btnScreenGrab"
            Me.btnScreenGrab.SubItemsExpandWidth = 14
            Me.btnScreenGrab.Text = "Screenshot"
            '
            'btnExportEve
            '
            Me.btnExportEve.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.btnExportEve.Enabled = False
            Me.btnExportEve.Image = CType(resources.GetObject("btnExportEve.Image"), System.Drawing.Image)
            Me.btnExportEve.ImageFixedSize = New System.Drawing.Size(36, 36)
            Me.btnExportEve.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.btnExportEve.Name = "btnExportEve"
            Me.btnExportEve.SubItemsExpandWidth = 14
            Me.btnExportEve.Text = "Export to Eve"
            '
            'ItemContainer1
            '
            '
            '
            '
            Me.ItemContainer1.BackgroundStyle.BorderLeftColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ItemContainer1.BackgroundStyle.BorderLeftWidth = 1
            Me.ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ItemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
            Me.ItemContainer1.Name = "ItemContainer1"
            Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnExportFitting, Me.btnExportDetails})
            '
            '
            '
            Me.ItemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            'btnExportFitting
            '
            Me.btnExportFitting.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.btnExportFitting.Enabled = False
            Me.btnExportFitting.Image = CType(resources.GetObject("btnExportFitting.Image"), System.Drawing.Image)
            Me.btnExportFitting.ImageFixedSize = New System.Drawing.Size(30, 30)
            Me.btnExportFitting.Name = "btnExportFitting"
            Me.btnExportFitting.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnExportHQF, Me.btnExportEFT, Me.btnExportForums})
            Me.SuperTooltip1.SetSuperTooltip(Me.btnExportFitting, New DevComponents.DotNetBar.SuperTooltipInfo("", "Export Fitting", "Exports the current fitting in a variety of formats." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the main button to " & _
                "export in EFT format (useful for importing directly in Eve) or click the drop dr" & _
                "own button for more export options." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10), Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Yellow))
            Me.btnExportFitting.Text = "Export Fitting"
            '
            'btnExportHQF
            '
            Me.btnExportHQF.Name = "btnExportHQF"
            Me.btnExportHQF.Text = "Copy For HQF"
            '
            'btnExportEFT
            '
            Me.btnExportEFT.Name = "btnExportEFT"
            Me.btnExportEFT.Text = "Export for EFT"
            '
            'btnExportForums
            '
            Me.btnExportForums.Name = "btnExportForums"
            Me.btnExportForums.Text = "Export for Forums"
            '
            'btnExportDetails
            '
            Me.btnExportDetails.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.btnExportDetails.Enabled = False
            Me.btnExportDetails.Image = CType(resources.GetObject("btnExportDetails.Image"), System.Drawing.Image)
            Me.btnExportDetails.ImageFixedSize = New System.Drawing.Size(30, 30)
            Me.btnExportDetails.Name = "btnExportDetails"
            Me.btnExportDetails.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnExportStats, Me.btnExportImplants})
            Me.btnExportDetails.Text = "Export Details"
            '
            'btnExportStats
            '
            Me.btnExportStats.Name = "btnExportStats"
            Me.btnExportStats.Text = "Copy Ship Statistics"
            '
            'btnExportImplants
            '
            Me.btnExportImplants.Name = "btnExportImplants"
            Me.btnExportImplants.Text = "Copy Implant Details"
            '
            'btnExportReq
            '
            Me.btnExportReq.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.btnExportReq.Enabled = False
            Me.btnExportReq.Image = CType(resources.GetObject("btnExportReq.Image"), System.Drawing.Image)
            Me.btnExportReq.ImageFixedSize = New System.Drawing.Size(36, 36)
            Me.btnExportReq.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.btnExportReq.Name = "btnExportReq"
            Me.btnExportReq.SubItemsExpandWidth = 14
            Me.btnExportReq.Text = "Export To Requisition"
            '
            'rbTools
            '
            Me.rbTools.AutoOverflowEnabled = True
            '
            '
            '
            Me.rbTools.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.rbTools.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.rbTools.ContainerControlProcessDialogKey = True
            Me.rbTools.DragDropSupport = True
            Me.rbTools.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnShipSelector, Me.btnPilotManager, Me.btnImplantManager})
            
            Me.rbTools.Location = New System.Drawing.Point(59, 0)
            Me.rbTools.Name = "rbTools"
            Me.rbTools.Size = New System.Drawing.Size(158, 100)
            Me.rbTools.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.rbTools.TabIndex = 1
            Me.rbTools.Text = "Tools"
            '
            '
            '
            Me.rbTools.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.rbTools.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.rbTools.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
            '
            'btnShipSelector
            '
            Me.btnShipSelector.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.btnShipSelector.Image = CType(resources.GetObject("btnShipSelector.Image"), System.Drawing.Image)
            Me.btnShipSelector.ImageFixedSize = New System.Drawing.Size(36, 36)
            Me.btnShipSelector.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.btnShipSelector.Name = "btnShipSelector"
            Me.btnShipSelector.SubItemsExpandWidth = 14
            Me.btnShipSelector.Text = "Ship Selector"
            '
            'btnPilotManager
            '
            Me.btnPilotManager.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.btnPilotManager.Enabled = False
            Me.btnPilotManager.Image = CType(resources.GetObject("btnPilotManager.Image"), System.Drawing.Image)
            Me.btnPilotManager.ImageFixedSize = New System.Drawing.Size(36, 36)
            Me.btnPilotManager.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.btnPilotManager.Name = "btnPilotManager"
            Me.btnPilotManager.Stretch = True
            Me.btnPilotManager.SubItemsExpandWidth = 14
            Me.btnPilotManager.Text = "Pilot Manager"
            '
            'btnImplantManager
            '
            Me.btnImplantManager.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.btnImplantManager.Enabled = False
            Me.btnImplantManager.Image = CType(resources.GetObject("btnImplantManager.Image"), System.Drawing.Image)
            Me.btnImplantManager.ImageFixedSize = New System.Drawing.Size(36, 36)
            Me.btnImplantManager.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.btnImplantManager.Name = "btnImplantManager"
            Me.btnImplantManager.Stretch = True
            Me.btnImplantManager.SubItemsExpandWidth = 14
            Me.btnImplantManager.Text = "Implant Manager"
            '
            'rbOptions
            '
            Me.rbOptions.AutoOverflowEnabled = True
            '
            '
            '
            Me.rbOptions.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.rbOptions.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.rbOptions.ContainerControlProcessDialogKey = True
            Me.rbOptions.DragDropSupport = True
            Me.rbOptions.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnOptions})
            
            Me.rbOptions.Location = New System.Drawing.Point(0, 0)
            Me.rbOptions.Name = "rbOptions"
            Me.rbOptions.Size = New System.Drawing.Size(57, 100)
            Me.rbOptions.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.rbOptions.TabIndex = 0
            Me.rbOptions.Text = "Options"
            '
            '
            '
            Me.rbOptions.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.rbOptions.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.rbOptions.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
            '
            'btnOptions
            '
            Me.btnOptions.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.btnOptions.Image = CType(resources.GetObject("btnOptions.Image"), System.Drawing.Image)
            Me.btnOptions.ImageFixedSize = New System.Drawing.Size(40, 40)
            Me.btnOptions.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.btnOptions.Name = "btnOptions"
            Me.btnOptions.SubItemsExpandWidth = 14
            Me.btnOptions.Text = "Options"
            '
            'SuperTooltip1
            '
            Me.SuperTooltip1.DefaultFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SuperTooltip1.DefaultTooltipSettings = New DevComponents.DotNetBar.SuperTooltipInfo("", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray)
            
            Me.SuperTooltip1.PositionBelowControl = False
            Me.SuperTooltip1.TooltipDuration = 0
            '
            'STTShips
            '
            Me.STTShips.DefaultTooltipSettings = New DevComponents.DotNetBar.SuperTooltipInfo("", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray)
            
            Me.STTShips.MinimumTooltipSize = New System.Drawing.Size(300, 100)
            Me.STTShips.PositionBelowControl = False
            Me.STTShips.TooltipDuration = 0
            '
            'FrmHQF
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1284, 721)
            Me.Controls.Add(Me.rbmc1)
            Me.Controls.Add(Me.tabHQF)
            Me.Controls.Add(Me.SplitterShips)
            Me.Controls.Add(Me.panelShips)
            Me.Controls.Add(Me.SplitterModules)
            Me.Controls.Add(Me.panelModules)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.KeyPreview = True
            Me.Name = "FrmHQF"
            Me.Text = "EveHQ Fitter"
            Me.ctxFittings.ResumeLayout(False)
            CType(Me.tvwShips, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ctxShipBrowser.ResumeLayout(False)
            CType(Me.pbSearchShips, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ctxModuleList.ResumeLayout(False)
            Me.panelModules.ResumeLayout(False)
            Me.panelModuleList.ResumeLayout(False)
            Me.panelModuleList.PerformLayout()
            CType(Me.tvwModules, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelModFilters.ResumeLayout(False)
            Me.panelModFilters.PerformLayout()
            CType(Me.tvwItems, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelShips.ResumeLayout(False)
            Me.panelFittings.ResumeLayout(False)
            Me.panelFittings.PerformLayout()
            CType(Me.tvwFittings, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabHQF, System.ComponentModel.ISupportInitialize).EndInit()
            Me.rbmc1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents chkFilter1 As System.Windows.Forms.CheckBox
        Friend WithEvents chkFilter32 As System.Windows.Forms.CheckBox
        Friend WithEvents chkFilter16 As System.Windows.Forms.CheckBox
        Friend WithEvents chkFilter8 As System.Windows.Forms.CheckBox
        Friend WithEvents chkFilter4 As System.Windows.Forms.CheckBox
        Friend WithEvents chkFilter2 As System.Windows.Forms.CheckBox
        Friend WithEvents lblSearchModules As System.Windows.Forms.Label
        Friend WithEvents txtSearchModules As System.Windows.Forms.TextBox
        Friend WithEvents ctxShipBrowser As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents mnuCreateNewFitting As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuShipBrowserShipName As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents imgAttributes As System.Windows.Forms.ImageList
        Friend WithEvents mnuPreviewShip As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ctxModuleList As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents mnuShowModuleInfo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tmrClipboard As System.Windows.Forms.Timer
        Friend WithEvents ctxFittings As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents mnuFittingsShowFitting As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuFittingsRenameFitting As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuFittingsCopyFitting As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuFittingsDeleteFitting As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuFittingsCreateFitting As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuFittingsFittingName As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuPreviewShip2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents chkOnlyShowUsable As System.Windows.Forms.CheckBox
        Friend WithEvents chkApplySkills As System.Windows.Forms.CheckBox
        Friend WithEvents mnuSep1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuAddToFavourites_List As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblModuleDisplayType As System.Windows.Forms.Label
        Friend WithEvents mnuRemoveFromFavourites As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuSep2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuShowModuleMarketGroup As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtShipSearch As System.Windows.Forms.TextBox
        Friend WithEvents btnResetShips As System.Windows.Forms.Button
        Friend WithEvents chkOnlyShowFittable As System.Windows.Forms.CheckBox
        Friend WithEvents pbSearchShips As System.Windows.Forms.PictureBox
        Friend WithEvents mnuCompareFittings As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuFittingsBCBrowser As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuExportToEve As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblFlyable As System.Windows.Forms.Label
        Friend WithEvents cboFlyable As System.Windows.Forms.ComboBox
        Friend WithEvents chkFilter8192 As System.Windows.Forms.CheckBox
        Friend WithEvents mnuAddToShipBay As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuShowMetaVariations As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tvwShips As DevComponents.AdvTree.AdvTree
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents panelModules As DevComponents.DotNetBar.PanelEx
        Friend WithEvents SplitterModules As DevComponents.DotNetBar.ExpandableSplitter
        Friend WithEvents SplitterMods As DevComponents.DotNetBar.ExpandableSplitter
        Friend WithEvents panelModFilters As DevComponents.DotNetBar.PanelEx
        Friend WithEvents panelShips As DevComponents.DotNetBar.PanelEx
        Friend WithEvents SplitterFittings As DevComponents.DotNetBar.ExpandableSplitter
        Friend WithEvents panelFittings As DevComponents.DotNetBar.PanelEx
        Friend WithEvents SplitterShips As DevComponents.DotNetBar.ExpandableSplitter
        Friend WithEvents tabHQF As DevComponents.DotNetBar.TabControl
        Friend WithEvents rbmc1 As DevComponents.DotNetBar.RibbonBarMergeContainer
        Friend WithEvents rbOptions As DevComponents.DotNetBar.RibbonBar
        Friend WithEvents btnOptions As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents rbTools As DevComponents.DotNetBar.RibbonBar
        Friend WithEvents btnPilotManager As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents btnImplantManager As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents rbExport As DevComponents.DotNetBar.RibbonBar
        Friend WithEvents btnScreenGrab As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
        Friend WithEvents btnExportFitting As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents btnExportHQF As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents btnExportEFT As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents btnExportForums As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents btnExportDetails As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents btnExportStats As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents btnExportImplants As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents btnExportEve As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents rbImport As DevComponents.DotNetBar.RibbonBar
        Friend WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer
        Friend WithEvents btnImportEve As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents btnImportEFT As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents btnImport As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents tvwFittings As DevComponents.AdvTree.AdvTree
        Friend WithEvents NodeConnector2 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle2 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents tvwItems As DevComponents.AdvTree.AdvTree
        Friend WithEvents NodeConnector3 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle3 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents panelModuleList As DevComponents.DotNetBar.PanelEx
        Friend WithEvents tvwModules As DevComponents.AdvTree.AdvTree
        Friend WithEvents NodeConnector4 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents colModuleName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colModuleMeta As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colModuleCPU As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colModulePG As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colModulePrice As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
        Friend WithEvents Node3 As DevComponents.AdvTree.Node
        Friend WithEvents ElementStyle4 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents rbEditor As DevComponents.DotNetBar.RibbonBar
        Friend WithEvents btnEditor As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents btnExportReq As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuExportToRequisitions As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents STTShips As DevComponents.DotNetBar.SuperTooltip
        Friend WithEvents btnShipSelector As DevComponents.DotNetBar.ButtonItem
    End Class
End NameSpace