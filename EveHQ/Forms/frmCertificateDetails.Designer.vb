Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmCertificateDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCertificateDetails))
        Me.tvwBasicReqs = New System.Windows.Forms.TreeView()
        Me.ctxSkills = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuSkillName = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuViewSkillDetails = New System.Windows.Forms.ToolStripMenuItem()
            Me.ctxShips = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.mnuShipName = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuShowInfo = New System.Windows.Forms.ToolStripMenuItem()
            Me.lblDescription = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.tcCerts = New DevComponents.DotNetBar.TabControl()
            Me.TabControlPanel6 = New DevComponents.DotNetBar.TabControlPanel()
            Me.adtShips = New DevComponents.AdvTree.AdvTree()
            Me.colShip = New DevComponents.AdvTree.ColumnHeader()
            Me.Skill = New DevComponents.DotNetBar.ElementStyle()
            Me.SkillGroup = New DevComponents.DotNetBar.ElementStyle()
            Me.recommendedTab = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
            Me.basicSkillsTab = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel5 = New DevComponents.DotNetBar.TabControlPanel()
            Me.tvwEliteReqs = New System.Windows.Forms.TreeView()
            Me.eliteSkillsTab = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel()
            Me.tvwAdvancedReqs = New System.Windows.Forms.TreeView()
            Me.advancedSkillsTab = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
            Me.tvwImprovedReqs = New System.Windows.Forms.TreeView()
            Me.improvedSkillsTab = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
            Me.tvwStandardReqs = New System.Windows.Forms.TreeView()
            Me.standardSkillsTab = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.riCert = New DevComponents.DotNetBar.Controls.ReflectionImage()
            Me.ctxSkills.SuspendLayout()
            Me.ctxShips.SuspendLayout()
            CType(Me.tcCerts, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tcCerts.SuspendLayout()
            Me.TabControlPanel6.SuspendLayout()
            CType(Me.adtShips, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControlPanel1.SuspendLayout()
            Me.TabControlPanel5.SuspendLayout()
            Me.TabControlPanel4.SuspendLayout()
            Me.TabControlPanel3.SuspendLayout()
            Me.TabControlPanel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'tvwBasicReqs
            '
            Me.tvwBasicReqs.ContextMenuStrip = Me.ctxSkills
            Me.tvwBasicReqs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tvwBasicReqs.Indent = 25
            Me.tvwBasicReqs.ItemHeight = 20
            Me.tvwBasicReqs.Location = New System.Drawing.Point(1, 1)
            Me.tvwBasicReqs.Name = "tvwBasicReqs"
            Me.tvwBasicReqs.Size = New System.Drawing.Size(464, 330)
            Me.tvwBasicReqs.TabIndex = 0
            '
            'ctxSkills
            '
            Me.ctxSkills.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.ctxSkills.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSkillName, Me.ToolStripSeparator2, Me.mnuViewSkillDetails})
            Me.ctxSkills.Name = "ctxDepend"
            Me.ctxSkills.Size = New System.Drawing.Size(133, 54)
            '
            'mnuSkillName
            '
            Me.mnuSkillName.Name = "mnuSkillName"
            Me.mnuSkillName.Size = New System.Drawing.Size(132, 22)
            Me.mnuSkillName.Text = "Skill Name"
            '
            'ToolStripSeparator2
            '
            Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
            Me.ToolStripSeparator2.Size = New System.Drawing.Size(129, 6)
            '
            'mnuViewSkillDetails
            '
            Me.mnuViewSkillDetails.Font = New System.Drawing.Font("Tahoma", 8.25!)
            Me.mnuViewSkillDetails.Name = "mnuViewSkillDetails"
            Me.mnuViewSkillDetails.Size = New System.Drawing.Size(132, 22)
            Me.mnuViewSkillDetails.Text = "View Details"
            '
            'ctxShips
            '
            Me.ctxShips.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.ctxShips.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShipName, Me.ToolStripSeparator1, Me.mnuShowInfo})
            Me.ctxShips.Name = "ctxDepend"
            Me.ctxShips.Size = New System.Drawing.Size(134, 54)
            '
            'mnuShipName
            '
            Me.mnuShipName.Name = "mnuShipName"
            Me.mnuShipName.Size = New System.Drawing.Size(133, 22)
            Me.mnuShipName.Text = "Ship Name"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(130, 6)
            '
            'mnuShowInfo
            '
            Me.mnuShowInfo.Font = New System.Drawing.Font("Tahoma", 8.25!)
            Me.mnuShowInfo.Name = "mnuShowInfo"
            Me.mnuShowInfo.Size = New System.Drawing.Size(133, 22)
            Me.mnuShowInfo.Text = "Show Info"
            '
            'lblDescription
            '
            Me.lblDescription.BackColor = System.Drawing.Color.White
            Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescription.Location = New System.Drawing.Point(85, 14)
            Me.lblDescription.Margin = New System.Windows.Forms.Padding(5)
            Me.lblDescription.Name = "lblDescription"
            Me.lblDescription.Padding = New System.Windows.Forms.Padding(5)
            Me.lblDescription.Size = New System.Drawing.Size(393, 231)
            Me.lblDescription.TabIndex = 0
            '
            'tcCerts
            '
            Me.tcCerts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tcCerts.BackColor = System.Drawing.Color.Transparent
            Me.tcCerts.CanReorderTabs = True
            Me.tcCerts.ColorScheme.TabBackground = System.Drawing.Color.Transparent
            Me.tcCerts.ColorScheme.TabBackground2 = System.Drawing.Color.Transparent
            Me.tcCerts.ColorScheme.TabItemBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer)), 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(248, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(245, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(247, Byte), Integer)), 1.0!)})
            Me.tcCerts.ColorScheme.TabItemHotBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(235, Byte), Integer)), 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(168, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(89, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(141, Byte), Integer)), 1.0!)})
            Me.tcCerts.ColorScheme.TabItemSelectedBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.White, 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer)), 1.0!)})
            Me.tcCerts.Controls.Add(Me.TabControlPanel1)
            Me.tcCerts.Controls.Add(Me.TabControlPanel6)
            Me.tcCerts.Controls.Add(Me.TabControlPanel5)
            Me.tcCerts.Controls.Add(Me.TabControlPanel4)
            Me.tcCerts.Controls.Add(Me.TabControlPanel3)
            Me.tcCerts.Controls.Add(Me.TabControlPanel2)
            Me.tcCerts.Location = New System.Drawing.Point(12, 253)
            Me.tcCerts.Name = "tcCerts"
            Me.tcCerts.SelectedTabFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.tcCerts.SelectedTabIndex = 0
            Me.tcCerts.Size = New System.Drawing.Size(466, 355)
            Me.tcCerts.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
            Me.tcCerts.TabIndex = 4
            Me.tcCerts.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
            Me.tcCerts.Tabs.Add(Me.basicSkillsTab)
            Me.tcCerts.Tabs.Add(Me.standardSkillsTab)
            Me.tcCerts.Tabs.Add(Me.improvedSkillsTab)
            Me.tcCerts.Tabs.Add(Me.advancedSkillsTab)
            Me.tcCerts.Tabs.Add(Me.eliteSkillsTab)
            Me.tcCerts.Tabs.Add(Me.recommendedTab)
            Me.tcCerts.Text = "TabControl2"
            '
            'TabControlPanel6
            '
            Me.TabControlPanel6.Controls.Add(Me.adtShips)
            Me.TabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel6.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel6.Name = "TabControlPanel6"
            Me.TabControlPanel6.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel6.Size = New System.Drawing.Size(466, 332)
            Me.TabControlPanel6.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.TabControlPanel6.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.TabControlPanel6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel6.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
            Me.TabControlPanel6.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel6.Style.GradientAngle = 90
            Me.TabControlPanel6.TabIndex = 6
            Me.TabControlPanel6.TabItem = Me.recommendedTab
            '
            'adtShips
            '
            Me.adtShips.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtShips.AllowDrop = True
            Me.adtShips.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtShips.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtShips.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtShips.Columns.Add(Me.colShip)
            Me.adtShips.Dock = System.Windows.Forms.DockStyle.Fill
            Me.adtShips.DragDropEnabled = False
            Me.adtShips.DragDropNodeCopyEnabled = False
            Me.adtShips.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle
            Me.adtShips.KeyboardSearchEnabled = False
            
            Me.adtShips.Location = New System.Drawing.Point(1, 1)
            Me.adtShips.Name = "adtShips"
            Me.adtShips.NodeSpacing = 1
            Me.adtShips.NodeStyle = Me.Skill
            Me.adtShips.PathSeparator = ";"
            Me.adtShips.SelectionBox = False
            Me.adtShips.Size = New System.Drawing.Size(464, 330)
            Me.adtShips.Styles.Add(Me.Skill)
            Me.adtShips.Styles.Add(Me.SkillGroup)
            Me.adtShips.TabIndex = 39
            '
            'colShip
            '
            Me.colShip.DisplayIndex = 1
            Me.colShip.Name = "colShip"
            Me.colShip.SortingEnabled = False
            Me.colShip.Text = "Ship"
            Me.colShip.Width.Absolute = 440
            '
            'Skill
            '
            Me.Skill.BackColorGradientAngle = 45
            Me.Skill.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
            Me.Skill.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.Skill.Name = "Skill"
            Me.Skill.TextColor = System.Drawing.Color.Black
            '
            'SkillGroup
            '
            Me.SkillGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
            Me.SkillGroup.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.SkillGroup.BackColorGradientAngle = 90
            Me.SkillGroup.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
            Me.SkillGroup.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.SkillGroup.BorderBottomWidth = 1
            Me.SkillGroup.BorderColor = System.Drawing.Color.DarkGray
            Me.SkillGroup.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.SkillGroup.BorderLeftWidth = 1
            Me.SkillGroup.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.SkillGroup.BorderRightWidth = 1
            Me.SkillGroup.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.SkillGroup.BorderTopWidth = 1
            Me.SkillGroup.CornerDiameter = 4
            Me.SkillGroup.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.SkillGroup.Description = "Gray"
            Me.SkillGroup.Name = "SkillGroup"
            Me.SkillGroup.PaddingBottom = 1
            Me.SkillGroup.PaddingLeft = 1
            Me.SkillGroup.PaddingRight = 1
            Me.SkillGroup.PaddingTop = 1
            Me.SkillGroup.TextColor = System.Drawing.Color.White
            '
            'recommendedTab
            '
            Me.recommendedTab.AttachedControl = Me.TabControlPanel6
            Me.recommendedTab.Name = "recommendedTab"
            Me.recommendedTab.Text = "Recommended For"
            '
            'TabControlPanel1
            '
            Me.TabControlPanel1.Controls.Add(Me.tvwBasicReqs)
            Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel1.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel1.Name = "TabControlPanel1"
            Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel1.Size = New System.Drawing.Size(466, 332)
            Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
            Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel1.Style.GradientAngle = 90
            Me.TabControlPanel1.TabIndex = 1
            Me.TabControlPanel1.TabItem = Me.basicSkillsTab
            '
            'basicSkillsTab
            '
            Me.basicSkillsTab.AttachedControl = Me.TabControlPanel1
            Me.basicSkillsTab.Name = "basicSkillsTab"
            Me.basicSkillsTab.Text = "Basic"
            '
            'TabControlPanel5
            '
            Me.TabControlPanel5.Controls.Add(Me.tvwEliteReqs)
            Me.TabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel5.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel5.Name = "TabControlPanel5"
            Me.TabControlPanel5.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel5.Size = New System.Drawing.Size(466, 332)
            Me.TabControlPanel5.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.TabControlPanel5.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.TabControlPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
            Me.TabControlPanel5.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel5.Style.GradientAngle = 90
            Me.TabControlPanel5.TabIndex = 5
            Me.TabControlPanel5.TabItem = Me.eliteSkillsTab
            '
            'tvwEliteReqs
            '
            Me.tvwEliteReqs.ContextMenuStrip = Me.ctxSkills
            Me.tvwEliteReqs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tvwEliteReqs.Indent = 25
            Me.tvwEliteReqs.ItemHeight = 20
            Me.tvwEliteReqs.Location = New System.Drawing.Point(1, 1)
            Me.tvwEliteReqs.Name = "tvwEliteReqs"
            Me.tvwEliteReqs.Size = New System.Drawing.Size(464, 330)
            Me.tvwEliteReqs.TabIndex = 1
            '
            'eliteSkillsTab
            '
            Me.eliteSkillsTab.AttachedControl = Me.TabControlPanel5
            Me.eliteSkillsTab.Name = "eliteSkillsTab"
            Me.eliteSkillsTab.Text = "Elite"
            '
            'TabControlPanel4
            '
            Me.TabControlPanel4.Controls.Add(Me.tvwAdvancedReqs)
            Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel4.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel4.Name = "TabControlPanel4"
            Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel4.Size = New System.Drawing.Size(466, 332)
            Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
            Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel4.Style.GradientAngle = 90
            Me.TabControlPanel4.TabIndex = 4
            Me.TabControlPanel4.TabItem = Me.advancedSkillsTab
            '
            'tvwAdvancedReqs
            '
            Me.tvwAdvancedReqs.ContextMenuStrip = Me.ctxSkills
            Me.tvwAdvancedReqs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tvwAdvancedReqs.Indent = 25
            Me.tvwAdvancedReqs.ItemHeight = 20
            Me.tvwAdvancedReqs.Location = New System.Drawing.Point(1, 1)
            Me.tvwAdvancedReqs.Name = "tvwAdvancedReqs"
            Me.tvwAdvancedReqs.Size = New System.Drawing.Size(464, 330)
            Me.tvwAdvancedReqs.TabIndex = 1
            '
            'advancedSkillsTab
            '
            Me.advancedSkillsTab.AttachedControl = Me.TabControlPanel4
            Me.advancedSkillsTab.Name = "advancedSkillsTab"
            Me.advancedSkillsTab.Text = "Advanced"
            '
            'TabControlPanel3
            '
            Me.TabControlPanel3.Controls.Add(Me.tvwImprovedReqs)
            Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel3.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel3.Name = "TabControlPanel3"
            Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel3.Size = New System.Drawing.Size(466, 332)
            Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
            Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel3.Style.GradientAngle = 90
            Me.TabControlPanel3.TabIndex = 3
            Me.TabControlPanel3.TabItem = Me.improvedSkillsTab
            '
            'tvwImprovedReqs
            '
            Me.tvwImprovedReqs.ContextMenuStrip = Me.ctxSkills
            Me.tvwImprovedReqs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tvwImprovedReqs.Indent = 25
            Me.tvwImprovedReqs.ItemHeight = 20
            Me.tvwImprovedReqs.Location = New System.Drawing.Point(1, 1)
            Me.tvwImprovedReqs.Name = "tvwImprovedReqs"
            Me.tvwImprovedReqs.Size = New System.Drawing.Size(464, 330)
            Me.tvwImprovedReqs.TabIndex = 1
            '
            'improvedSkillsTab
            '
            Me.improvedSkillsTab.AttachedControl = Me.TabControlPanel3
            Me.improvedSkillsTab.Name = "improvedSkillsTab"
            Me.improvedSkillsTab.Text = "Improved"
            '
            'TabControlPanel2
            '
            Me.TabControlPanel2.Controls.Add(Me.tvwStandardReqs)
            Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel2.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel2.Name = "TabControlPanel2"
            Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel2.Size = New System.Drawing.Size(466, 332)
            Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
            Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel2.Style.GradientAngle = 90
            Me.TabControlPanel2.TabIndex = 2
            Me.TabControlPanel2.TabItem = Me.standardSkillsTab
            '
            'tvwStandardReqs
            '
            Me.tvwStandardReqs.ContextMenuStrip = Me.ctxSkills
            Me.tvwStandardReqs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tvwStandardReqs.Indent = 25
            Me.tvwStandardReqs.ItemHeight = 20
            Me.tvwStandardReqs.Location = New System.Drawing.Point(1, 1)
            Me.tvwStandardReqs.Name = "tvwStandardReqs"
            Me.tvwStandardReqs.Size = New System.Drawing.Size(464, 330)
            Me.tvwStandardReqs.TabIndex = 0
            '
            'standardSkillsTab
            '
            Me.standardSkillsTab.AttachedControl = Me.TabControlPanel2
            Me.standardSkillsTab.Name = "standardSkillsTab"
            Me.standardSkillsTab.Text = "Standard"
            '
            'riCert
            '
            '
            '
            '
            Me.riCert.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.riCert.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.riCert.Image = CType(resources.GetObject("riCert.Image"), System.Drawing.Image)
            Me.riCert.Location = New System.Drawing.Point(13, 14)
            Me.riCert.Name = "riCert"
            Me.riCert.Size = New System.Drawing.Size(64, 96)
            Me.riCert.TabIndex = 5
            '
            'FrmCertificateDetails
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(490, 614)
            Me.Controls.Add(Me.riCert)
            Me.Controls.Add(Me.tcCerts)
            Me.Controls.Add(Me.lblDescription)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmCertificateDetails"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Certificate Details"
            Me.ctxSkills.ResumeLayout(False)
            Me.ctxShips.ResumeLayout(False)
            CType(Me.tcCerts, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tcCerts.ResumeLayout(False)
            Me.TabControlPanel6.ResumeLayout(False)
            CType(Me.adtShips, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControlPanel1.ResumeLayout(False)
            Me.TabControlPanel5.ResumeLayout(False)
            Me.TabControlPanel4.ResumeLayout(False)
            Me.TabControlPanel3.ResumeLayout(False)
            Me.TabControlPanel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblDescription As System.Windows.Forms.Label
        Friend WithEvents tvwBasicReqs As System.Windows.Forms.TreeView
        Friend WithEvents ctxSkills As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents mnuSkillName As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuViewSkillDetails As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents ctxShips As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents mnuShipName As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuShowInfo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tvwStandardReqs As System.Windows.Forms.TreeView
        Friend WithEvents tvwEliteReqs As System.Windows.Forms.TreeView
        Friend WithEvents tvwAdvancedReqs As System.Windows.Forms.TreeView
        Friend WithEvents tvwImprovedReqs As System.Windows.Forms.TreeView
        Private WithEvents tcCerts As DevComponents.DotNetBar.TabControl
        Private WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
        Private WithEvents basicSkillsTab As DevComponents.DotNetBar.TabItem
        Private WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
        Private WithEvents improvedSkillsTab As DevComponents.DotNetBar.TabItem
        Private WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
        Private WithEvents standardSkillsTab As DevComponents.DotNetBar.TabItem
        Private WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
        Private WithEvents advancedSkillsTab As DevComponents.DotNetBar.TabItem
        Private WithEvents TabControlPanel5 As DevComponents.DotNetBar.TabControlPanel
        Private WithEvents eliteSkillsTab As DevComponents.DotNetBar.TabItem
        Friend WithEvents TabControlPanel6 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents recommendedTab As DevComponents.DotNetBar.TabItem
        Friend WithEvents adtShips As DevComponents.AdvTree.AdvTree
        Friend WithEvents colShip As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents Skill As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents SkillGroup As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents riCert As DevComponents.DotNetBar.Controls.ReflectionImage
    End Class
End NameSpace