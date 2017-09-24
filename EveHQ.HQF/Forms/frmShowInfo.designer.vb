Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmShowInfo
        Inherits DevComponents.DotNetBar.Office2007Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmShowInfo))
            Me.lvwAttributes = New DevComponents.DotNetBar.Controls.ListViewEx()
            Me.colAttribute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colStandardValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colPilotValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.lblUsableTime = New System.Windows.Forms.LinkLabel()
            Me.lblUsable = New System.Windows.Forms.Label()
            Me.picItem = New System.Windows.Forms.PictureBox()
            Me.lblItemName = New System.Windows.Forms.Label()
            Me.pbPilot = New System.Windows.Forms.PictureBox()
            Me.tabShowInfo = New DevComponents.DotNetBar.TabControl()
            Me.TabControlPanel5 = New DevComponents.DotNetBar.TabControlPanel()
            Me.adtAudit = New DevComponents.AdvTree.AdvTree()
            Me.colDetails = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector2 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle2 = New DevComponents.DotNetBar.ElementStyle()
            Me.tabAudit = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel()
            Me.adtAffects = New DevComponents.AdvTree.AdvTree()
            Me.colAffectedBy = New DevComponents.AdvTree.ColumnHeader()
            Me.colAffectedType = New DevComponents.AdvTree.ColumnHeader()
            Me.colAffectedAttribute = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector3 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle3 = New DevComponents.DotNetBar.ElementStyle()
            Me.tabAffects = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
            Me.lblDescription = New DevComponents.DotNetBar.LabelX()
            Me.tabDescription = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel6 = New DevComponents.DotNetBar.TabControlPanel()
            Me.lblTraits = New DevComponents.DotNetBar.LabelX()
            Me.tabTraits = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
            Me.tvwReqs = New DevComponents.AdvTree.AdvTree()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me.tabSkills = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
            Me.tabAttributes = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
            Me.pnlInfo = New DevComponents.DotNetBar.PanelEx()
            CType(Me.picItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbPilot, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabShowInfo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabShowInfo.SuspendLayout()
            Me.TabControlPanel5.SuspendLayout()
            CType(Me.adtAudit, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControlPanel4.SuspendLayout()
            CType(Me.adtAffects, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControlPanel1.SuspendLayout()
            Me.TabControlPanel6.SuspendLayout()
            Me.TabControlPanel3.SuspendLayout()
            CType(Me.tvwReqs, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControlPanel2.SuspendLayout()
            Me.pnlInfo.SuspendLayout()
            Me.SuspendLayout()
            '
            'lvwAttributes
            '
            '
            '
            '
            Me.lvwAttributes.Border.Class = "ListViewBorder"
            Me.lvwAttributes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lvwAttributes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colAttribute, Me.colStandardValue, Me.colPilotValue})
            Me.lvwAttributes.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lvwAttributes.FullRowSelect = True
            Me.lvwAttributes.GridLines = True
            Me.lvwAttributes.Location = New System.Drawing.Point(1, 1)
            Me.lvwAttributes.Name = "lvwAttributes"
            Me.lvwAttributes.Size = New System.Drawing.Size(559, 439)
            Me.lvwAttributes.TabIndex = 1
            Me.lvwAttributes.UseCompatibleStateImageBehavior = False
            Me.lvwAttributes.View = System.Windows.Forms.View.Details
            '
            'colAttribute
            '
            Me.colAttribute.Text = "Attribute"
            Me.colAttribute.Width = 240
            '
            'colStandardValue
            '
            Me.colStandardValue.Text = "Base Value"
            Me.colStandardValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.colStandardValue.Width = 150
            '
            'colPilotValue
            '
            Me.colPilotValue.Text = "Actual Value"
            Me.colPilotValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.colPilotValue.Width = 150
            '
            'lblUsableTime
            '
            Me.lblUsableTime.AutoSize = True
            Me.lblUsableTime.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUsableTime.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lblUsableTime.Location = New System.Drawing.Point(120, 60)
            Me.lblUsableTime.Name = "lblUsableTime"
            Me.lblUsableTime.Size = New System.Drawing.Size(68, 13)
            Me.lblUsableTime.TabIndex = 15
            Me.lblUsableTime.TabStop = True
            Me.lblUsableTime.Text = "Usable Time:"
            '
            'lblUsable
            '
            Me.lblUsable.AutoSize = True
            Me.lblUsable.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUsable.Location = New System.Drawing.Point(120, 41)
            Me.lblUsable.Name = "lblUsable"
            Me.lblUsable.Size = New System.Drawing.Size(39, 13)
            Me.lblUsable.TabIndex = 14
            Me.lblUsable.Text = "Usable"
            '
            'picItem
            '
            Me.picItem.Location = New System.Drawing.Point(12, 32)
            Me.picItem.Name = "picItem"
            Me.picItem.Size = New System.Drawing.Size(48, 48)
            Me.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picItem.TabIndex = 13
            Me.picItem.TabStop = False
            '
            'lblItemName
            '
            Me.lblItemName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblItemName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblItemName.Location = New System.Drawing.Point(12, 9)
            Me.lblItemName.Name = "lblItemName"
            Me.lblItemName.Size = New System.Drawing.Size(559, 21)
            Me.lblItemName.TabIndex = 16
            Me.lblItemName.Text = "Item Label"
            '
            'pbPilot
            '
            Me.pbPilot.Image = Global.EveHQ.HQF.My.Resources.Resources.noitem
            Me.pbPilot.Location = New System.Drawing.Point(82, 41)
            Me.pbPilot.Name = "pbPilot"
            Me.pbPilot.Size = New System.Drawing.Size(32, 32)
            Me.pbPilot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pbPilot.TabIndex = 17
            Me.pbPilot.TabStop = False
            '
            'tabShowInfo
            '
            Me.tabShowInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tabShowInfo.BackColor = System.Drawing.Color.Transparent
            Me.tabShowInfo.CanReorderTabs = True
            Me.tabShowInfo.ColorScheme.TabBackground = System.Drawing.Color.Transparent
            Me.tabShowInfo.ColorScheme.TabBackground2 = System.Drawing.Color.Transparent
            Me.tabShowInfo.ColorScheme.TabItemBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(226, Byte), Integer)), 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(199, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(223, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), 1.0!)})
            Me.tabShowInfo.ColorScheme.TabItemHotBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(235, Byte), Integer)), 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(168, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(89, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(141, Byte), Integer)), 1.0!)})
            Me.tabShowInfo.ColorScheme.TabItemSelectedBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.White, 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer)), 1.0!)})
            Me.tabShowInfo.Controls.Add(Me.TabControlPanel4)
            Me.tabShowInfo.Controls.Add(Me.TabControlPanel5)
            Me.tabShowInfo.Controls.Add(Me.TabControlPanel6)
            Me.tabShowInfo.Controls.Add(Me.TabControlPanel1)
            Me.tabShowInfo.Controls.Add(Me.TabControlPanel3)
            Me.tabShowInfo.Controls.Add(Me.TabControlPanel2)
            Me.tabShowInfo.Location = New System.Drawing.Point(11, 86)
            Me.tabShowInfo.Name = "tabShowInfo"
            Me.tabShowInfo.SelectedTabFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.tabShowInfo.SelectedTabIndex = 6
            Me.tabShowInfo.Size = New System.Drawing.Size(561, 464)
            Me.tabShowInfo.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
            Me.tabShowInfo.TabIndex = 18
            Me.tabShowInfo.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
            Me.tabShowInfo.Tabs.Add(Me.tabTraits)
            Me.tabShowInfo.Tabs.Add(Me.tabDescription)
            Me.tabShowInfo.Tabs.Add(Me.tabAttributes)
            Me.tabShowInfo.Tabs.Add(Me.tabSkills)
            Me.tabShowInfo.Tabs.Add(Me.tabAffects)
            Me.tabShowInfo.Tabs.Add(Me.tabAudit)
            Me.tabShowInfo.Text = "TabControl1"
            '
            'TabControlPanel5
            '
            Me.TabControlPanel5.Controls.Add(Me.adtAudit)
            Me.TabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel5.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel5.Name = "TabControlPanel5"
            Me.TabControlPanel5.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel5.Size = New System.Drawing.Size(561, 441)
            Me.TabControlPanel5.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel5.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel5.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel5.Style.GradientAngle = 90
            Me.TabControlPanel5.TabIndex = 5
            Me.TabControlPanel5.TabItem = Me.tabAudit
            '
            'adtAudit
            '
            Me.adtAudit.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtAudit.AllowDrop = True
            Me.adtAudit.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtAudit.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtAudit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtAudit.Columns.Add(Me.colDetails)
            Me.adtAudit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.adtAudit.DragDropEnabled = False
            Me.adtAudit.DragDropNodeCopyEnabled = False
            Me.adtAudit.DropAsChildOffset = 0
            Me.adtAudit.ExpandWidth = 0
            Me.adtAudit.GridRowLines = True
            
            Me.adtAudit.Location = New System.Drawing.Point(1, 1)
            Me.adtAudit.Name = "adtAudit"
            Me.adtAudit.NodesConnector = Me.NodeConnector2
            Me.adtAudit.NodeStyle = Me.ElementStyle2
            Me.adtAudit.PathSeparator = ";"
            Me.adtAudit.Size = New System.Drawing.Size(559, 439)
            Me.adtAudit.Styles.Add(Me.ElementStyle2)
            Me.adtAudit.TabIndex = 4
            Me.adtAudit.Text = "AdvTree1"
            '
            'colDetails
            '
            Me.colDetails.Name = "colDetails"
            Me.colDetails.SortingEnabled = False
            Me.colDetails.Text = "Details"
            Me.colDetails.Width.Absolute = 530
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
            'tabAudit
            '
            Me.tabAudit.AttachedControl = Me.TabControlPanel5
            Me.tabAudit.Name = "tabAudit"
            Me.tabAudit.Text = "Audit"
            '
            'TabControlPanel4
            '
            Me.TabControlPanel4.Controls.Add(Me.adtAffects)
            Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel4.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel4.Name = "TabControlPanel4"
            Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel4.Size = New System.Drawing.Size(561, 441)
            Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel4.Style.GradientAngle = 90
            Me.TabControlPanel4.TabIndex = 4
            Me.TabControlPanel4.TabItem = Me.tabAffects
            '
            'adtAffects
            '
            Me.adtAffects.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtAffects.AllowDrop = True
            Me.adtAffects.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtAffects.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtAffects.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtAffects.Columns.Add(Me.colAffectedBy)
            Me.adtAffects.Columns.Add(Me.colAffectedType)
            Me.adtAffects.Columns.Add(Me.colAffectedAttribute)
            Me.adtAffects.Dock = System.Windows.Forms.DockStyle.Fill
            Me.adtAffects.DragDropEnabled = False
            Me.adtAffects.DragDropNodeCopyEnabled = False
            Me.adtAffects.DropAsChildOffset = 0
            Me.adtAffects.ExpandWidth = 0
            Me.adtAffects.GridRowLines = True
            
            Me.adtAffects.Location = New System.Drawing.Point(1, 1)
            Me.adtAffects.Name = "adtAffects"
            Me.adtAffects.NodesConnector = Me.NodeConnector3
            Me.adtAffects.NodeStyle = Me.ElementStyle3
            Me.adtAffects.PathSeparator = ";"
            Me.adtAffects.Size = New System.Drawing.Size(559, 439)
            Me.adtAffects.Styles.Add(Me.ElementStyle3)
            Me.adtAffects.TabIndex = 5
            Me.adtAffects.Text = "AdvTree1"
            '
            'colAffectedBy
            '
            Me.colAffectedBy.DisplayIndex = 1
            Me.colAffectedBy.Name = "colAffectedBy"
            Me.colAffectedBy.SortingEnabled = False
            Me.colAffectedBy.Text = "Affected By"
            Me.colAffectedBy.Width.Absolute = 250
            '
            'colAffectedType
            '
            Me.colAffectedType.DisplayIndex = 2
            Me.colAffectedType.Name = "colAffectedType"
            Me.colAffectedType.SortingEnabled = False
            Me.colAffectedType.Text = "Type"
            Me.colAffectedType.Width.Absolute = 100
            '
            'colAffectedAttribute
            '
            Me.colAffectedAttribute.DisplayIndex = 3
            Me.colAffectedAttribute.Name = "colAffectedAttribute"
            Me.colAffectedAttribute.SortingEnabled = False
            Me.colAffectedAttribute.Text = "Attribute"
            Me.colAffectedAttribute.Width.Absolute = 175
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
            'tabAffects
            '
            Me.tabAffects.AttachedControl = Me.TabControlPanel4
            Me.tabAffects.Name = "tabAffects"
            Me.tabAffects.Text = "Affected By"
            '
            'TabControlPanel6
            '
            Me.TabControlPanel6.Controls.Add(Me.lblTraits)
            Me.TabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel6.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel6.Name = "TabControlPanel6"
            Me.TabControlPanel6.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel6.Size = New System.Drawing.Size(561, 441)
            Me.TabControlPanel6.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel6.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel6.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel6.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel6.Style.GradientAngle = 90
            Me.TabControlPanel6.TabIndex = 6
            Me.TabControlPanel6.TabItem = Me.tabTraits
            '
            'lblTraits
            '
            Me.lblTraits.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblTraits.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblTraits.Location = New System.Drawing.Point(1, 1)
            Me.lblTraits.Name = "lblTraits"
            Me.lblTraits.PaddingBottom = 10
            Me.lblTraits.Size = New System.Drawing.Size(559, 439)
            Me.lblTraits.TabIndex = 0
            Me.lblTraits.TextLineAlignment = System.Drawing.StringAlignment.Near
            Me.lblTraits.WordWrap = True
            '
            'tabTraits
            '
            Me.tabTraits.AttachedControl = Me.TabControlPanel6
            Me.tabTraits.Name = "tabTraits"
            Me.tabTraits.Text = "Traits"
            '
            'TabControlPanel1
            '
            Me.TabControlPanel1.Controls.Add(Me.lblDescription)
            Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel1.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel1.Name = "TabControlPanel1"
            Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel1.Size = New System.Drawing.Size(561, 441)
            Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel1.Style.GradientAngle = 90
            Me.TabControlPanel1.TabIndex = 1
            Me.TabControlPanel1.TabItem = Me.tabDescription
            '
            'lblDescription
            '
            Me.lblDescription.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblDescription.Location = New System.Drawing.Point(1, 1)
            Me.lblDescription.Name = "lblDescription"
            Me.lblDescription.PaddingBottom = 10
            Me.lblDescription.Size = New System.Drawing.Size(559, 439)
            Me.lblDescription.TabIndex = 0
            Me.lblDescription.TextLineAlignment = System.Drawing.StringAlignment.Near
            Me.lblDescription.WordWrap = True
            '
            'tabDescription
            '
            Me.tabDescription.AttachedControl = Me.TabControlPanel1
            Me.tabDescription.Name = "tabDescription"
            Me.tabDescription.Text = "Description"
            '
            'TabControlPanel3
            '
            Me.TabControlPanel3.Controls.Add(Me.tvwReqs)
            Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel3.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel3.Name = "TabControlPanel3"
            Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel3.Size = New System.Drawing.Size(561, 441)
            Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel3.Style.GradientAngle = 90
            Me.TabControlPanel3.TabIndex = 3
            Me.TabControlPanel3.TabItem = Me.tabSkills
            '
            'tvwReqs
            '
            Me.tvwReqs.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.tvwReqs.AllowDrop = True
            Me.tvwReqs.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.tvwReqs.BackgroundStyle.Class = "TreeBorderKey"
            Me.tvwReqs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.tvwReqs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tvwReqs.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle
            
            Me.tvwReqs.Location = New System.Drawing.Point(1, 1)
            Me.tvwReqs.Name = "tvwReqs"
            Me.tvwReqs.NodesConnector = Me.NodeConnector1
            Me.tvwReqs.NodeSpacing = 5
            Me.tvwReqs.NodeStyle = Me.ElementStyle1
            Me.tvwReqs.PathSeparator = ";"
            Me.tvwReqs.Size = New System.Drawing.Size(559, 439)
            Me.tvwReqs.Styles.Add(Me.ElementStyle1)
            Me.tvwReqs.TabIndex = 1
            Me.tvwReqs.Text = "AdvTree1"
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
            'tabSkills
            '
            Me.tabSkills.AttachedControl = Me.TabControlPanel3
            Me.tabSkills.Name = "tabSkills"
            Me.tabSkills.Text = "Required Skills"
            '
            'TabControlPanel2
            '
            Me.TabControlPanel2.Controls.Add(Me.lvwAttributes)
            Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel2.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel2.Name = "TabControlPanel2"
            Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel2.Size = New System.Drawing.Size(561, 441)
            Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel2.Style.GradientAngle = 90
            Me.TabControlPanel2.TabIndex = 2
            Me.TabControlPanel2.TabItem = Me.tabAttributes
            '
            'tabAttributes
            '
            Me.tabAttributes.AttachedControl = Me.TabControlPanel2
            Me.tabAttributes.Name = "tabAttributes"
            Me.tabAttributes.Text = "Attributes"
            '
            'SuperTooltip1
            '
            
            Me.SuperTooltip1.PositionBelowControl = False
            '
            'pnlInfo
            '
            Me.pnlInfo.CanvasColor = System.Drawing.SystemColors.Control
            Me.pnlInfo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.pnlInfo.Controls.Add(Me.lblItemName)
            Me.pnlInfo.Controls.Add(Me.tabShowInfo)
            Me.pnlInfo.Controls.Add(Me.picItem)
            Me.pnlInfo.Controls.Add(Me.pbPilot)
            Me.pnlInfo.Controls.Add(Me.lblUsable)
            Me.pnlInfo.Controls.Add(Me.lblUsableTime)
            Me.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlInfo.Location = New System.Drawing.Point(0, 0)
            Me.pnlInfo.Name = "pnlInfo"
            Me.pnlInfo.Size = New System.Drawing.Size(584, 562)
            Me.pnlInfo.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.pnlInfo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.pnlInfo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.pnlInfo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.pnlInfo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.pnlInfo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.pnlInfo.Style.GradientAngle = 90
            Me.pnlInfo.TabIndex = 19
            '
            'FrmShowInfo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(584, 562)
            Me.Controls.Add(Me.pnlInfo)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FrmShowInfo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Show Info"
            CType(Me.picItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbPilot, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabShowInfo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabShowInfo.ResumeLayout(False)
            Me.TabControlPanel5.ResumeLayout(False)
            CType(Me.adtAudit, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControlPanel4.ResumeLayout(False)
            CType(Me.adtAffects, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControlPanel1.ResumeLayout(False)
            Me.TabControlPanel6.ResumeLayout(False)
            Me.TabControlPanel3.ResumeLayout(False)
            CType(Me.tvwReqs, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControlPanel2.ResumeLayout(False)
            Me.pnlInfo.ResumeLayout(False)
            Me.pnlInfo.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblUsableTime As System.Windows.Forms.LinkLabel
        Friend WithEvents lblUsable As System.Windows.Forms.Label
        Friend WithEvents picItem As System.Windows.Forms.PictureBox
        Friend WithEvents colAttribute As System.Windows.Forms.ColumnHeader
        Friend WithEvents colStandardValue As System.Windows.Forms.ColumnHeader
        Friend WithEvents lblItemName As System.Windows.Forms.Label
        Friend WithEvents pbPilot As System.Windows.Forms.PictureBox
        Friend WithEvents colPilotValue As System.Windows.Forms.ColumnHeader
        Friend WithEvents tabShowInfo As DevComponents.DotNetBar.TabControl
        Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tabDescription As DevComponents.DotNetBar.TabItem
        Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tabAttributes As DevComponents.DotNetBar.TabItem
        Friend WithEvents lblDescription As DevComponents.DotNetBar.LabelX
        Friend WithEvents TabControlPanel5 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tabAudit As DevComponents.DotNetBar.TabItem
        Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tabAffects As DevComponents.DotNetBar.TabItem
        Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tabSkills As DevComponents.DotNetBar.TabItem
        Friend WithEvents lvwAttributes As DevComponents.DotNetBar.Controls.ListViewEx
        Friend WithEvents tvwReqs As DevComponents.AdvTree.AdvTree
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents pnlInfo As DevComponents.DotNetBar.PanelEx
        Friend WithEvents adtAudit As DevComponents.AdvTree.AdvTree
        Friend WithEvents colDetails As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector2 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle2 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents adtAffects As DevComponents.AdvTree.AdvTree
        Friend WithEvents colAffectedBy As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colAffectedType As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colAffectedAttribute As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector3 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle3 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents TabControlPanel6 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tabTraits As DevComponents.DotNetBar.TabItem
        Friend WithEvents lblTraits As DevComponents.DotNetBar.LabelX
    End Class
End Namespace