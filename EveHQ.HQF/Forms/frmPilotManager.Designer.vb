Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmPilotManager
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPilotManager))
            Me.blbPilots = New System.Windows.Forms.Label()
            Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.ctxHQFLevel = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.mnuSetSkillName = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuSetLevel0 = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuSetLevel1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuSetLevel2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuSetLevel3 = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuSetLevel4 = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuSetLevel5 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuSetDefault = New System.Windows.Forms.ToolStripMenuItem()
            Me.lblSkillsModified = New System.Windows.Forms.Label()
            Me.lblSkillQueue = New System.Windows.Forms.Label()
            Me.lblImplantDescription = New System.Windows.Forms.TextBox()
            Me.lblUseImplantGroup = New System.Windows.Forms.Label()
            Me.lblImplantFilter = New System.Windows.Forms.Label()
            Me.tvwImplants = New System.Windows.Forms.TreeView()
            Me.lblImplantDescriptionM = New System.Windows.Forms.TextBox()
            Me.lblCurrentGroup = New System.Windows.Forms.Label()
            Me.lblImplantFilterM = New System.Windows.Forms.Label()
            Me.tvwImplantsM = New System.Windows.Forms.TreeView()
            Me.lstImplantGroups = New System.Windows.Forms.ListBox()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.pnlPM = New DevComponents.DotNetBar.PanelEx()
            Me.cboPilots = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.tabControlPM = New DevComponents.DotNetBar.TabControl()
            Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
            Me.adtSkills = New DevComponents.AdvTree.AdvTree()
            Me.colName = New DevComponents.AdvTree.ColumnHeader()
            Me.colActLvl = New DevComponents.AdvTree.ColumnHeader()
            Me.colHQFLvl = New DevComponents.AdvTree.ColumnHeader()
            Me.Node1 = New DevComponents.AdvTree.Node()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.Skill = New DevComponents.DotNetBar.ElementStyle()
            Me.btnImportSkillsFromEFT = New DevComponents.DotNetBar.ButtonX()
            Me.chkShowModifiedSkills = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.cboSkillQueue = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.btnSetToSkillQueue = New DevComponents.DotNetBar.ButtonX()
            Me.btnAddHQFSkillsToQueue = New DevComponents.DotNetBar.ButtonX()
            Me.btnUpdateSkills = New DevComponents.DotNetBar.ButtonX()
            Me.btnResetAll = New DevComponents.DotNetBar.ButtonX()
            Me.btnSetAllToLevel5 = New DevComponents.DotNetBar.ButtonX()
            Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
            Me.cboImplantFilterM = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.btnCollapseAllM = New DevComponents.DotNetBar.ButtonX()
            Me.btnRemoveImplantGroup = New DevComponents.DotNetBar.ButtonX()
            Me.btnEditImplantGroup = New DevComponents.DotNetBar.ButtonX()
            Me.btnAddImplantGroup = New DevComponents.DotNetBar.ButtonX()
            Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
            Me.btnCollapseAll = New DevComponents.DotNetBar.ButtonX()
            Me.btnSaveGroup = New DevComponents.DotNetBar.ButtonX()
            Me.cboImplantFilter = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.cboImplantGroup = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.STT = New DevComponents.DotNetBar.SuperTooltip()
            Me.ctxHQFLevel.SuspendLayout()
            Me.pnlPM.SuspendLayout()
            CType(Me.tabControlPM, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControlPM.SuspendLayout()
            Me.TabControlPanel1.SuspendLayout()
            CType(Me.adtSkills, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControlPanel3.SuspendLayout()
            Me.TabControlPanel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'blbPilots
            '
            Me.blbPilots.AutoSize = True
            Me.blbPilots.Location = New System.Drawing.Point(12, 12)
            Me.blbPilots.Name = "blbPilots"
            Me.blbPilots.Size = New System.Drawing.Size(36, 13)
            Me.blbPilots.TabIndex = 0
            Me.blbPilots.Text = "Pilots:"
            '
            'ImageList1
            '
            Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.ImageList1.Images.SetKeyName(0, "Level0.jpg")
            Me.ImageList1.Images.SetKeyName(1, "Level1.jpg")
            Me.ImageList1.Images.SetKeyName(2, "Level2.jpg")
            Me.ImageList1.Images.SetKeyName(3, "Level3.jpg")
            Me.ImageList1.Images.SetKeyName(4, "Level4.jpg")
            Me.ImageList1.Images.SetKeyName(5, "Level5.jpg")
            Me.ImageList1.Images.SetKeyName(6, "Blank.jpg")
            Me.ImageList1.Images.SetKeyName(7, "Skillbook_16x16.jpg")
            Me.ImageList1.Images.SetKeyName(8, "Skillbook_24x24.jpg")
            Me.ImageList1.Images.SetKeyName(9, "NoSkillbook_16x16.jpg")
            Me.ImageList1.Images.SetKeyName(10, "NoSkillbook_24x24.jpg")
            '
            'ctxHQFLevel
            '
            Me.ctxHQFLevel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ctxHQFLevel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSetSkillName, Me.ToolStripMenuItem1, Me.mnuSetLevel0, Me.mnuSetLevel1, Me.mnuSetLevel2, Me.mnuSetLevel3, Me.mnuSetLevel4, Me.mnuSetLevel5, Me.ToolStripMenuItem2, Me.mnuSetDefault})
            Me.ctxHQFLevel.Name = "ctxHQFLevel"
            Me.ctxHQFLevel.Size = New System.Drawing.Size(153, 214)
            '
            'mnuSetSkillName
            '
            Me.mnuSetSkillName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.mnuSetSkillName.Name = "mnuSetSkillName"
            Me.mnuSetSkillName.Size = New System.Drawing.Size(152, 22)
            Me.mnuSetSkillName.Text = "Skill Name"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
            '
            'mnuSetLevel0
            '
            Me.mnuSetLevel0.Name = "mnuSetLevel0"
            Me.mnuSetLevel0.Size = New System.Drawing.Size(152, 22)
            Me.mnuSetLevel0.Text = "Set To Level 0"
            '
            'mnuSetLevel1
            '
            Me.mnuSetLevel1.Name = "mnuSetLevel1"
            Me.mnuSetLevel1.Size = New System.Drawing.Size(152, 22)
            Me.mnuSetLevel1.Text = "Set To Level 1"
            '
            'mnuSetLevel2
            '
            Me.mnuSetLevel2.Name = "mnuSetLevel2"
            Me.mnuSetLevel2.Size = New System.Drawing.Size(152, 22)
            Me.mnuSetLevel2.Text = "Set To Level 2"
            '
            'mnuSetLevel3
            '
            Me.mnuSetLevel3.Name = "mnuSetLevel3"
            Me.mnuSetLevel3.Size = New System.Drawing.Size(152, 22)
            Me.mnuSetLevel3.Text = "Set To Level 3"
            '
            'mnuSetLevel4
            '
            Me.mnuSetLevel4.Name = "mnuSetLevel4"
            Me.mnuSetLevel4.Size = New System.Drawing.Size(152, 22)
            Me.mnuSetLevel4.Text = "Set To Level 4"
            '
            'mnuSetLevel5
            '
            Me.mnuSetLevel5.Name = "mnuSetLevel5"
            Me.mnuSetLevel5.Size = New System.Drawing.Size(152, 22)
            Me.mnuSetLevel5.Text = "Set To Level 5"
            '
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(149, 6)
            '
            'mnuSetDefault
            '
            Me.mnuSetDefault.Name = "mnuSetDefault"
            Me.mnuSetDefault.Size = New System.Drawing.Size(152, 22)
            Me.mnuSetDefault.Text = "Set To Default"
            '
            'lblSkillsModified
            '
            Me.lblSkillsModified.AutoSize = True
            Me.lblSkillsModified.Location = New System.Drawing.Point(233, 12)
            Me.lblSkillsModified.Name = "lblSkillsModified"
            Me.lblSkillsModified.Size = New System.Drawing.Size(80, 13)
            Me.lblSkillsModified.TabIndex = 5
            Me.lblSkillsModified.Text = "(Skills Modified)"
            '
            'lblSkillQueue
            '
            Me.lblSkillQueue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblSkillQueue.AutoSize = True
            Me.lblSkillQueue.BackColor = System.Drawing.Color.Transparent
            Me.lblSkillQueue.Location = New System.Drawing.Point(11, 498)
            Me.lblSkillQueue.Name = "lblSkillQueue"
            Me.lblSkillQueue.Size = New System.Drawing.Size(63, 13)
            Me.lblSkillQueue.TabIndex = 10
            Me.lblSkillQueue.Text = "Skill Queue:"
            '
            'lblImplantDescription
            '
            Me.lblImplantDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                                                     Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblImplantDescription.Location = New System.Drawing.Point(16, 451)
            Me.lblImplantDescription.Multiline = True
            Me.lblImplantDescription.Name = "lblImplantDescription"
            Me.lblImplantDescription.ReadOnly = True
            Me.lblImplantDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.lblImplantDescription.Size = New System.Drawing.Size(638, 84)
            Me.lblImplantDescription.TabIndex = 20
            '
            'lblUseImplantGroup
            '
            Me.lblUseImplantGroup.AutoSize = True
            Me.lblUseImplantGroup.BackColor = System.Drawing.Color.Transparent
            Me.lblUseImplantGroup.Location = New System.Drawing.Point(13, 20)
            Me.lblUseImplantGroup.Name = "lblUseImplantGroup"
            Me.lblUseImplantGroup.Size = New System.Drawing.Size(96, 13)
            Me.lblUseImplantGroup.TabIndex = 14
            Me.lblUseImplantGroup.Text = "Use Implant Group"
            '
            'lblImplantFilter
            '
            Me.lblImplantFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblImplantFilter.AutoSize = True
            Me.lblImplantFilter.BackColor = System.Drawing.Color.Transparent
            Me.lblImplantFilter.Location = New System.Drawing.Point(13, 427)
            Me.lblImplantFilter.Name = "lblImplantFilter"
            Me.lblImplantFilter.Size = New System.Drawing.Size(102, 13)
            Me.lblImplantFilter.TabIndex = 12
            Me.lblImplantFilter.Text = "Implant Group Filter"
            '
            'tvwImplants
            '
            Me.tvwImplants.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                            Or System.Windows.Forms.AnchorStyles.Left) _
                                           Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tvwImplants.Location = New System.Drawing.Point(16, 44)
            Me.tvwImplants.Name = "tvwImplants"
            Me.tvwImplants.Size = New System.Drawing.Size(638, 374)
            Me.tvwImplants.TabIndex = 9
            '
            'lblImplantDescriptionM
            '
            Me.lblImplantDescriptionM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                                                      Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblImplantDescriptionM.Location = New System.Drawing.Point(225, 464)
            Me.lblImplantDescriptionM.Multiline = True
            Me.lblImplantDescriptionM.Name = "lblImplantDescriptionM"
            Me.lblImplantDescriptionM.ReadOnly = True
            Me.lblImplantDescriptionM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.lblImplantDescriptionM.Size = New System.Drawing.Size(428, 73)
            Me.lblImplantDescriptionM.TabIndex = 19
            '
            'lblCurrentGroup
            '
            Me.lblCurrentGroup.AutoSize = True
            Me.lblCurrentGroup.BackColor = System.Drawing.Color.Transparent
            Me.lblCurrentGroup.Location = New System.Drawing.Point(222, 13)
            Me.lblCurrentGroup.Name = "lblCurrentGroup"
            Me.lblCurrentGroup.Size = New System.Drawing.Size(80, 13)
            Me.lblCurrentGroup.TabIndex = 18
            Me.lblCurrentGroup.Text = "Current Group:"
            '
            'lblImplantFilterM
            '
            Me.lblImplantFilterM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblImplantFilterM.AutoSize = True
            Me.lblImplantFilterM.BackColor = System.Drawing.Color.Transparent
            Me.lblImplantFilterM.Location = New System.Drawing.Point(222, 435)
            Me.lblImplantFilterM.Name = "lblImplantFilterM"
            Me.lblImplantFilterM.Size = New System.Drawing.Size(102, 13)
            Me.lblImplantFilterM.TabIndex = 16
            Me.lblImplantFilterM.Text = "Implant Group Filter"
            '
            'tvwImplantsM
            '
            Me.tvwImplantsM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                             Or System.Windows.Forms.AnchorStyles.Left) _
                                            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tvwImplantsM.Location = New System.Drawing.Point(225, 29)
            Me.tvwImplantsM.Name = "tvwImplantsM"
            Me.tvwImplantsM.Size = New System.Drawing.Size(428, 395)
            Me.tvwImplantsM.TabIndex = 13
            '
            'lstImplantGroups
            '
            Me.lstImplantGroups.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lstImplantGroups.FormattingEnabled = True
            Me.lstImplantGroups.Location = New System.Drawing.Point(15, 13)
            Me.lstImplantGroups.Name = "lstImplantGroups"
            Me.lstImplantGroups.Size = New System.Drawing.Size(192, 472)
            Me.lstImplantGroups.TabIndex = 9
            '
            'pnlPM
            '
            Me.pnlPM.CanvasColor = System.Drawing.SystemColors.Control
            Me.pnlPM.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.pnlPM.Controls.Add(Me.cboPilots)
            Me.pnlPM.Controls.Add(Me.tabControlPM)
            Me.pnlPM.Controls.Add(Me.blbPilots)
            Me.pnlPM.Controls.Add(Me.lblSkillsModified)
            Me.pnlPM.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlPM.Location = New System.Drawing.Point(0, 0)
            Me.pnlPM.Name = "pnlPM"
            Me.pnlPM.Size = New System.Drawing.Size(684, 618)
            Me.pnlPM.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.pnlPM.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.pnlPM.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.pnlPM.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.pnlPM.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.pnlPM.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.pnlPM.Style.GradientAngle = 90
            Me.pnlPM.TabIndex = 8
            '
            'cboPilots
            '
            Me.cboPilots.DisplayMember = "Text"
            Me.cboPilots.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboPilots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboPilots.FormattingEnabled = True
            Me.cboPilots.ItemHeight = 15
            Me.cboPilots.Location = New System.Drawing.Point(54, 9)
            Me.cboPilots.Name = "cboPilots"
            Me.cboPilots.Size = New System.Drawing.Size(174, 21)
            Me.cboPilots.Sorted = True
            Me.cboPilots.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboPilots.TabIndex = 18
            '
            'tabControlPM
            '
            Me.tabControlPM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                             Or System.Windows.Forms.AnchorStyles.Left) _
                                            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tabControlPM.BackColor = System.Drawing.Color.Transparent
            Me.tabControlPM.CanReorderTabs = True
            Me.tabControlPM.ColorScheme.TabBackground = System.Drawing.Color.Transparent
            Me.tabControlPM.ColorScheme.TabBackground2 = System.Drawing.Color.Transparent
            Me.tabControlPM.ColorScheme.TabItemBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(226, Byte), Integer)), 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(199, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(223, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), 1.0!)})
            Me.tabControlPM.ColorScheme.TabItemHotBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(235, Byte), Integer)), 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(168, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(89, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(141, Byte), Integer)), 1.0!)})
            Me.tabControlPM.ColorScheme.TabItemSelectedBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.White, 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer)), 1.0!)})
            Me.tabControlPM.Controls.Add(Me.TabControlPanel1)
            Me.tabControlPM.Controls.Add(Me.TabControlPanel2)
            Me.tabControlPM.Controls.Add(Me.TabControlPanel3)
            Me.tabControlPM.Location = New System.Drawing.Point(3, 36)
            Me.tabControlPM.Name = "tabControlPM"
            Me.tabControlPM.SelectedTabFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.tabControlPM.SelectedTabIndex = 0
            Me.tabControlPM.Size = New System.Drawing.Size(675, 575)
            Me.tabControlPM.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
            Me.tabControlPM.TabIndex = 8
            Me.tabControlPM.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
            Me.tabControlPM.Tabs.Add(Me.TabItem1)
            Me.tabControlPM.Tabs.Add(Me.TabItem2)
            Me.tabControlPM.Tabs.Add(Me.TabItem3)
            Me.tabControlPM.Text = "Implant Manager"
            '
            'TabControlPanel1
            '
            Me.TabControlPanel1.Controls.Add(Me.adtSkills)
            Me.TabControlPanel1.Controls.Add(Me.btnImportSkillsFromEFT)
            Me.TabControlPanel1.Controls.Add(Me.chkShowModifiedSkills)
            Me.TabControlPanel1.Controls.Add(Me.cboSkillQueue)
            Me.TabControlPanel1.Controls.Add(Me.btnSetToSkillQueue)
            Me.TabControlPanel1.Controls.Add(Me.btnAddHQFSkillsToQueue)
            Me.TabControlPanel1.Controls.Add(Me.btnUpdateSkills)
            Me.TabControlPanel1.Controls.Add(Me.btnResetAll)
            Me.TabControlPanel1.Controls.Add(Me.btnSetAllToLevel5)
            Me.TabControlPanel1.Controls.Add(Me.lblSkillQueue)
            Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel1.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel1.Name = "TabControlPanel1"
            Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel1.Size = New System.Drawing.Size(675, 552)
            Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                                                          Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel1.Style.GradientAngle = 90
            Me.TabControlPanel1.TabIndex = 1
            Me.TabControlPanel1.TabItem = Me.TabItem1
            '
            'adtSkills
            '
            Me.adtSkills.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtSkills.AllowDrop = True
            Me.adtSkills.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                          Or System.Windows.Forms.AnchorStyles.Left) _
                                         Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.adtSkills.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtSkills.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtSkills.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtSkills.Columns.Add(Me.colName)
            Me.adtSkills.Columns.Add(Me.colActLvl)
            Me.adtSkills.Columns.Add(Me.colHQFLvl)
            Me.adtSkills.ContextMenuStrip = Me.ctxHQFLevel
            Me.adtSkills.DragDropEnabled = False
            Me.adtSkills.DragDropNodeCopyEnabled = False
            Me.adtSkills.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle
            Me.adtSkills.ImageList = Me.ImageList1
            
            Me.adtSkills.Location = New System.Drawing.Point(9, 44)
            Me.adtSkills.Name = "adtSkills"
            Me.adtSkills.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node1})
            Me.adtSkills.NodesConnector = Me.NodeConnector1
            Me.adtSkills.NodeStyle = Me.Skill
            Me.adtSkills.PathSeparator = ";"
            Me.adtSkills.Size = New System.Drawing.Size(660, 441)
            Me.adtSkills.Styles.Add(Me.Skill)
            Me.adtSkills.TabIndex = 20
            Me.adtSkills.Text = "AdvTree1"
            '
            'colName
            '
            Me.colName.DisplayIndex = 1
            Me.colName.Name = "colName"
            Me.colName.SortingEnabled = False
            Me.colName.Text = "Group/Skill Name"
            Me.colName.Width.Absolute = 350
            '
            'colActLvl
            '
            Me.colActLvl.DisplayIndex = 2
            Me.colActLvl.Name = "colActLvl"
            Me.colActLvl.SortingEnabled = False
            Me.colActLvl.Text = "Actual Level"
            Me.colActLvl.Width.Absolute = 100
            '
            'colHQFLvl
            '
            Me.colHQFLvl.DisplayIndex = 3
            Me.colHQFLvl.Name = "colHQFLvl"
            Me.colHQFLvl.SortingEnabled = False
            Me.colHQFLvl.Text = "HQF Level"
            Me.colHQFLvl.Width.Absolute = 100
            '
            'Node1
            '
            Me.Node1.Expanded = True
            Me.Node1.Name = "Node1"
            Me.Node1.Text = "Node1"
            '
            'NodeConnector1
            '
            Me.NodeConnector1.LineColor = System.Drawing.SystemColors.ControlText
            '
            'Skill
            '
            Me.Skill.Class = ""
            Me.Skill.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.Skill.Name = "Skill"
            Me.Skill.TextColor = System.Drawing.SystemColors.ControlText
            '
            'btnImportSkillsFromEFT
            '
            Me.btnImportSkillsFromEFT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnImportSkillsFromEFT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnImportSkillsFromEFT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnImportSkillsFromEFT.Location = New System.Drawing.Point(519, 15)
            Me.btnImportSkillsFromEFT.Name = "btnImportSkillsFromEFT"
            Me.btnImportSkillsFromEFT.Size = New System.Drawing.Size(150, 23)
            Me.btnImportSkillsFromEFT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnImportSkillsFromEFT.TabIndex = 19
            Me.btnImportSkillsFromEFT.Text = "Import Skills From EFT Char"
            '
            'chkShowModifiedSkills
            '
            Me.chkShowModifiedSkills.AutoSize = True
            Me.chkShowModifiedSkills.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.chkShowModifiedSkills.BackgroundStyle.Class = ""
            Me.chkShowModifiedSkills.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkShowModifiedSkills.Location = New System.Drawing.Point(14, 19)
            Me.chkShowModifiedSkills.Name = "chkShowModifiedSkills"
            Me.chkShowModifiedSkills.Size = New System.Drawing.Size(146, 16)
            Me.chkShowModifiedSkills.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkShowModifiedSkills.TabIndex = 18
            Me.chkShowModifiedSkills.Text = "Only Show Modified Skills"
            '
            'cboSkillQueue
            '
            Me.cboSkillQueue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cboSkillQueue.DisplayMember = "Text"
            Me.cboSkillQueue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboSkillQueue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboSkillQueue.FormattingEnabled = True
            Me.cboSkillQueue.ItemHeight = 15
            Me.cboSkillQueue.Location = New System.Drawing.Point(14, 513)
            Me.cboSkillQueue.Name = "cboSkillQueue"
            Me.cboSkillQueue.Size = New System.Drawing.Size(183, 21)
            Me.cboSkillQueue.Sorted = True
            Me.cboSkillQueue.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboSkillQueue.TabIndex = 17
            '
            'btnSetToSkillQueue
            '
            Me.btnSetToSkillQueue.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnSetToSkillQueue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnSetToSkillQueue.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnSetToSkillQueue.Location = New System.Drawing.Point(203, 498)
            Me.btnSetToSkillQueue.Name = "btnSetToSkillQueue"
            Me.btnSetToSkillQueue.Size = New System.Drawing.Size(85, 36)
            Me.btnSetToSkillQueue.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnSetToSkillQueue.TabIndex = 16
            Me.btnSetToSkillQueue.Text = "Set Skills to Skill Queue"
            '
            'btnAddHQFSkillsToQueue
            '
            Me.btnAddHQFSkillsToQueue.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnAddHQFSkillsToQueue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnAddHQFSkillsToQueue.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnAddHQFSkillsToQueue.Location = New System.Drawing.Point(296, 498)
            Me.btnAddHQFSkillsToQueue.Name = "btnAddHQFSkillsToQueue"
            Me.btnAddHQFSkillsToQueue.Size = New System.Drawing.Size(85, 36)
            Me.btnAddHQFSkillsToQueue.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnAddHQFSkillsToQueue.TabIndex = 15
            Me.btnAddHQFSkillsToQueue.Text = "Add HQF Skills to Queue"
            '
            'btnUpdateSkills
            '
            Me.btnUpdateSkills.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnUpdateSkills.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnUpdateSkills.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnUpdateSkills.Location = New System.Drawing.Point(387, 499)
            Me.btnUpdateSkills.Name = "btnUpdateSkills"
            Me.btnUpdateSkills.Size = New System.Drawing.Size(85, 36)
            Me.btnUpdateSkills.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnUpdateSkills.TabIndex = 14
            Me.btnUpdateSkills.Text = "Update HQF Skills"
            '
            'btnResetAll
            '
            Me.btnResetAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnResetAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnResetAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnResetAll.Location = New System.Drawing.Point(478, 499)
            Me.btnResetAll.Name = "btnResetAll"
            Me.btnResetAll.Size = New System.Drawing.Size(85, 36)
            Me.btnResetAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnResetAll.TabIndex = 13
            Me.btnResetAll.Text = "Reset All To Actual"
            '
            'btnSetAllToLevel5
            '
            Me.btnSetAllToLevel5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnSetAllToLevel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnSetAllToLevel5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnSetAllToLevel5.Location = New System.Drawing.Point(569, 499)
            Me.btnSetAllToLevel5.Name = "btnSetAllToLevel5"
            Me.btnSetAllToLevel5.Size = New System.Drawing.Size(85, 36)
            Me.btnSetAllToLevel5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnSetAllToLevel5.TabIndex = 12
            Me.btnSetAllToLevel5.Text = "Set All Skills To Level 5"
            '
            'TabItem1
            '
            Me.TabItem1.AttachedControl = Me.TabControlPanel1
            Me.TabItem1.Name = "TabItem1"
            Me.TabItem1.Text = "Skills"
            '
            'TabControlPanel3
            '
            Me.TabControlPanel3.Controls.Add(Me.cboImplantFilterM)
            Me.TabControlPanel3.Controls.Add(Me.btnCollapseAllM)
            Me.TabControlPanel3.Controls.Add(Me.btnRemoveImplantGroup)
            Me.TabControlPanel3.Controls.Add(Me.btnEditImplantGroup)
            Me.TabControlPanel3.Controls.Add(Me.btnAddImplantGroup)
            Me.TabControlPanel3.Controls.Add(Me.lblImplantDescriptionM)
            Me.TabControlPanel3.Controls.Add(Me.lstImplantGroups)
            Me.TabControlPanel3.Controls.Add(Me.lblCurrentGroup)
            Me.TabControlPanel3.Controls.Add(Me.lblImplantFilterM)
            Me.TabControlPanel3.Controls.Add(Me.tvwImplantsM)
            Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel3.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel3.Name = "TabControlPanel3"
            Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel3.Size = New System.Drawing.Size(675, 552)
            Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                                                          Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel3.Style.GradientAngle = 90
            Me.TabControlPanel3.TabIndex = 3
            Me.TabControlPanel3.TabItem = Me.TabItem3
            '
            'cboImplantFilterM
            '
            Me.cboImplantFilterM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cboImplantFilterM.DisplayMember = "Text"
            Me.cboImplantFilterM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboImplantFilterM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboImplantFilterM.FormattingEnabled = True
            Me.cboImplantFilterM.ItemHeight = 15
            Me.cboImplantFilterM.Location = New System.Drawing.Point(330, 432)
            Me.cboImplantFilterM.Name = "cboImplantFilterM"
            Me.cboImplantFilterM.Size = New System.Drawing.Size(131, 21)
            Me.cboImplantFilterM.Sorted = True
            Me.cboImplantFilterM.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboImplantFilterM.TabIndex = 24
            '
            'btnCollapseAllM
            '
            Me.btnCollapseAllM.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnCollapseAllM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCollapseAllM.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnCollapseAllM.Location = New System.Drawing.Point(578, 430)
            Me.btnCollapseAllM.Name = "btnCollapseAllM"
            Me.btnCollapseAllM.Size = New System.Drawing.Size(75, 23)
            Me.btnCollapseAllM.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnCollapseAllM.TabIndex = 23
            Me.btnCollapseAllM.Text = "Collapse All"
            '
            'btnRemoveImplantGroup
            '
            Me.btnRemoveImplantGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnRemoveImplantGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnRemoveImplantGroup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnRemoveImplantGroup.Location = New System.Drawing.Point(147, 497)
            Me.btnRemoveImplantGroup.Name = "btnRemoveImplantGroup"
            Me.btnRemoveImplantGroup.Size = New System.Drawing.Size(60, 40)
            Me.btnRemoveImplantGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnRemoveImplantGroup.TabIndex = 22
            Me.btnRemoveImplantGroup.Text = "Remove Group"
            '
            'btnEditImplantGroup
            '
            Me.btnEditImplantGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnEditImplantGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnEditImplantGroup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnEditImplantGroup.Location = New System.Drawing.Point(81, 497)
            Me.btnEditImplantGroup.Name = "btnEditImplantGroup"
            Me.btnEditImplantGroup.Size = New System.Drawing.Size(60, 40)
            Me.btnEditImplantGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnEditImplantGroup.TabIndex = 21
            Me.btnEditImplantGroup.Text = "Edit Group"
            '
            'btnAddImplantGroup
            '
            Me.btnAddImplantGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnAddImplantGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnAddImplantGroup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnAddImplantGroup.Location = New System.Drawing.Point(15, 497)
            Me.btnAddImplantGroup.Name = "btnAddImplantGroup"
            Me.btnAddImplantGroup.Size = New System.Drawing.Size(60, 40)
            Me.btnAddImplantGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnAddImplantGroup.TabIndex = 20
            Me.btnAddImplantGroup.Text = "Add Group"
            '
            'TabItem3
            '
            Me.TabItem3.AttachedControl = Me.TabControlPanel3
            Me.TabItem3.Name = "TabItem3"
            Me.TabItem3.Text = "Implant Manager"
            '
            'TabControlPanel2
            '
            Me.TabControlPanel2.Controls.Add(Me.btnCollapseAll)
            Me.TabControlPanel2.Controls.Add(Me.btnSaveGroup)
            Me.TabControlPanel2.Controls.Add(Me.cboImplantFilter)
            Me.TabControlPanel2.Controls.Add(Me.cboImplantGroup)
            Me.TabControlPanel2.Controls.Add(Me.lblImplantDescription)
            Me.TabControlPanel2.Controls.Add(Me.lblUseImplantGroup)
            Me.TabControlPanel2.Controls.Add(Me.tvwImplants)
            Me.TabControlPanel2.Controls.Add(Me.lblImplantFilter)
            Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel2.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel2.Name = "TabControlPanel2"
            Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel2.Size = New System.Drawing.Size(675, 552)
            Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                                                          Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel2.Style.GradientAngle = 90
            Me.TabControlPanel2.TabIndex = 2
            Me.TabControlPanel2.TabItem = Me.TabItem2
            '
            'btnCollapseAll
            '
            Me.btnCollapseAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnCollapseAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCollapseAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnCollapseAll.Location = New System.Drawing.Point(579, 424)
            Me.btnCollapseAll.Name = "btnCollapseAll"
            Me.btnCollapseAll.Size = New System.Drawing.Size(75, 23)
            Me.btnCollapseAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnCollapseAll.TabIndex = 24
            Me.btnCollapseAll.Text = "Collapse All"
            '
            'btnSaveGroup
            '
            Me.btnSaveGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnSaveGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSaveGroup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnSaveGroup.Location = New System.Drawing.Point(497, 424)
            Me.btnSaveGroup.Name = "btnSaveGroup"
            Me.btnSaveGroup.Size = New System.Drawing.Size(75, 23)
            Me.btnSaveGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnSaveGroup.TabIndex = 23
            Me.btnSaveGroup.Text = "Save Group"
            '
            'cboImplantFilter
            '
            Me.cboImplantFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cboImplantFilter.DisplayMember = "Text"
            Me.cboImplantFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboImplantFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboImplantFilter.FormattingEnabled = True
            Me.cboImplantFilter.ItemHeight = 15
            Me.cboImplantFilter.Location = New System.Drawing.Point(121, 424)
            Me.cboImplantFilter.Name = "cboImplantFilter"
            Me.cboImplantFilter.Size = New System.Drawing.Size(150, 21)
            Me.cboImplantFilter.Sorted = True
            Me.cboImplantFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboImplantFilter.TabIndex = 22
            '
            'cboImplantGroup
            '
            Me.cboImplantGroup.DisplayMember = "Text"
            Me.cboImplantGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboImplantGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboImplantGroup.FormattingEnabled = True
            Me.cboImplantGroup.ItemHeight = 15
            Me.cboImplantGroup.Items.AddRange(New Object() {"<custom>"})
            Me.cboImplantGroup.Location = New System.Drawing.Point(115, 17)
            Me.cboImplantGroup.Name = "cboImplantGroup"
            Me.cboImplantGroup.Size = New System.Drawing.Size(235, 21)
            Me.cboImplantGroup.Sorted = True
            Me.cboImplantGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboImplantGroup.TabIndex = 21
            '
            'TabItem2
            '
            Me.TabItem2.AttachedControl = Me.TabControlPanel2
            Me.TabItem2.Name = "TabItem2"
            Me.TabItem2.Text = "Implants"
            '
            'STT
            '
            
            Me.STT.MinimumTooltipSize = New System.Drawing.Size(300, 24)
            Me.STT.PositionBelowControl = False
            Me.STT.TooltipDuration = 30
            '
            'frmPilotManager
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(684, 618)
            Me.Controls.Add(Me.pnlPM)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "frmPilotManager"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "HQF Pilot Manager"
            Me.ctxHQFLevel.ResumeLayout(False)
            Me.pnlPM.ResumeLayout(False)
            Me.pnlPM.PerformLayout()
            CType(Me.tabControlPM, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControlPM.ResumeLayout(False)
            Me.TabControlPanel1.ResumeLayout(False)
            Me.TabControlPanel1.PerformLayout()
            CType(Me.adtSkills, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControlPanel3.ResumeLayout(False)
            Me.TabControlPanel3.PerformLayout()
            Me.TabControlPanel2.ResumeLayout(False)
            Me.TabControlPanel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents blbPilots As System.Windows.Forms.Label
        Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
        Friend WithEvents ctxHQFLevel As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents mnuSetSkillName As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuSetLevel0 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuSetLevel1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuSetLevel2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuSetLevel3 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuSetLevel4 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuSetLevel5 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuSetDefault As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblSkillsModified As System.Windows.Forms.Label
        Friend WithEvents lblImplantFilter As System.Windows.Forms.Label
        Friend WithEvents tvwImplants As System.Windows.Forms.TreeView
        Friend WithEvents lblUseImplantGroup As System.Windows.Forms.Label
        Friend WithEvents lblImplantFilterM As System.Windows.Forms.Label
        Friend WithEvents tvwImplantsM As System.Windows.Forms.TreeView
        Friend WithEvents lstImplantGroups As System.Windows.Forms.ListBox
        Friend WithEvents lblCurrentGroup As System.Windows.Forms.Label
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents lblSkillQueue As System.Windows.Forms.Label
        Friend WithEvents lblImplantDescriptionM As System.Windows.Forms.TextBox
        Friend WithEvents lblImplantDescription As System.Windows.Forms.TextBox
        Friend WithEvents pnlPM As DevComponents.DotNetBar.PanelEx
        Friend WithEvents tabControlPM As DevComponents.DotNetBar.TabControl
        Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
        Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents TabItem3 As DevComponents.DotNetBar.TabItem
        Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
        Friend WithEvents btnSetToSkillQueue As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnAddHQFSkillsToQueue As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnUpdateSkills As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnResetAll As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnSetAllToLevel5 As DevComponents.DotNetBar.ButtonX
        Friend WithEvents cboSkillQueue As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents cboPilots As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents chkShowModifiedSkills As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents cboImplantGroup As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents cboImplantFilter As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents btnCollapseAll As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnSaveGroup As DevComponents.DotNetBar.ButtonX
        Friend WithEvents cboImplantFilterM As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents btnCollapseAllM As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnRemoveImplantGroup As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnEditImplantGroup As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnAddImplantGroup As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnImportSkillsFromEFT As DevComponents.DotNetBar.ButtonX
        Friend WithEvents adtSkills As DevComponents.AdvTree.AdvTree
        Friend WithEvents Node1 As DevComponents.AdvTree.Node
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents Skill As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents colName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colActLvl As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colHQFLvl As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents STT As DevComponents.DotNetBar.SuperTooltip
    End Class
End NameSpace