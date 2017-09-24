Imports EveHQ.Core.SkillQueueControl

Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class FrmPilot
        Inherits DevComponents.DotNetBar.Office2007Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPilot))
            Me.ctxSkills = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.mnuSkillName = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuViewDetails = New System.Windows.Forms.ToolStripMenuItem()
            Me.ctxPic = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.mnuCtxPicGetPortraitFromServer = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuCtxPicGetPortraitFromLocal = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuSavePortrait = New System.Windows.Forms.ToolStripMenuItem()
            Me.chkGroupSkills = New System.Windows.Forms.CheckBox()
            Me.ctxCerts = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.mnuCertName = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuViewCertDetails = New System.Windows.Forms.ToolStripMenuItem()
            Me.ctxStandings = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.mnuExtrapolateStandings = New System.Windows.Forms.ToolStripMenuItem()
            Me.lblTypeFilter = New System.Windows.Forms.Label()
            Me.cboFilter = New System.Windows.Forms.ComboBox()
            Me.btExportStandings = New System.Windows.Forms.Button()
            Me.btnGetStandings = New System.Windows.Forms.Button()
            Me.lblPilot = New System.Windows.Forms.Label()
            Me.cboPilots = New System.Windows.Forms.ComboBox()
            Me.picRace = New DevComponents.DotNetBar.Controls.ReflectionImage()
            Me.picBlood = New DevComponents.DotNetBar.Controls.ReflectionImage()
            Me.grpAttributes = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.btnEditManualImplants = New DevComponents.DotNetBar.ButtonX()
            Me.chkManImplants = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.lblWillpowerTotal = New DevComponents.DotNetBar.LabelX()
            Me.lblWillpowerDetail = New DevComponents.DotNetBar.LabelX()
            Me.lblWillpower = New DevComponents.DotNetBar.LabelX()
            Me.lblPerceptionTotal = New DevComponents.DotNetBar.LabelX()
            Me.lblPerceptionDetail = New DevComponents.DotNetBar.LabelX()
            Me.lblPerception = New DevComponents.DotNetBar.LabelX()
            Me.lblMemoryTotal = New DevComponents.DotNetBar.LabelX()
            Me.lblMemoryDetail = New DevComponents.DotNetBar.LabelX()
            Me.lblMemory = New DevComponents.DotNetBar.LabelX()
            Me.lblIntelligenceTotal = New DevComponents.DotNetBar.LabelX()
            Me.lblIntelligenceDetail = New DevComponents.DotNetBar.LabelX()
            Me.lblIntelligence = New DevComponents.DotNetBar.LabelX()
            Me.lblCharismaTotal = New DevComponents.DotNetBar.LabelX()
            Me.lblCharismaDetail = New DevComponents.DotNetBar.LabelX()
            Me.lblCharisma = New DevComponents.DotNetBar.LabelX()
            Me.lblAttributes = New DevComponents.DotNetBar.LabelX()
            Me.grpTraining = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.lblTrainingRate = New DevComponents.DotNetBar.LabelX()
            Me.lblTrainingEnds = New DevComponents.DotNetBar.LabelX()
            Me.lblTrainingTime = New DevComponents.DotNetBar.LabelX()
            Me.lblTrainingSkill = New DevComponents.DotNetBar.LabelX()
            Me.lblSkillTraining = New DevComponents.DotNetBar.LabelX()
            Me.grpPilotInfo = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.lblPilotSP = New DevComponents.DotNetBar.LabelX()
            Me.lblPilotIsk = New DevComponents.DotNetBar.LabelX()
            Me.lblPilotCorp = New DevComponents.DotNetBar.LabelX()
            Me.lblPilotAccount = New DevComponents.DotNetBar.LabelX()
            Me.lblPilotID = New DevComponents.DotNetBar.LabelX()
            Me.lblPilotSPLbl = New DevComponents.DotNetBar.LabelX()
            Me.lblPilotIskLbl = New DevComponents.DotNetBar.LabelX()
            Me.lblPilotCorpLbl = New DevComponents.DotNetBar.LabelX()
            Me.lblPilotAccountLbl = New DevComponents.DotNetBar.LabelX()
            Me.lblPilotIDLbl = New DevComponents.DotNetBar.LabelX()
            Me.lblPilotName = New DevComponents.DotNetBar.LabelX()
            Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
            Me.grpAPI = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.btnUpdateAPI = New DevComponents.DotNetBar.ButtonX()
            Me.lblCharacterXML = New DevComponents.DotNetBar.LabelX()
            Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
            Me.picPilot = New System.Windows.Forms.PictureBox()
            Me.tabPilotInfo = New DevComponents.DotNetBar.TabControl()
            Me.tcpCerts = New DevComponents.DotNetBar.TabControlPanel()
            Me.adtCerts = New DevComponents.AdvTree.AdvTree()
            Me.colCertName = New DevComponents.AdvTree.ColumnHeader()
            Me.colCertGrd = New DevComponents.AdvTree.ColumnHeader()
            Me.ElementStyle2 = New DevComponents.DotNetBar.ElementStyle()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me.tsCerts = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.tcpSkills = New DevComponents.DotNetBar.TabControlPanel()
            Me.adtSkills = New DevComponents.AdvTree.AdvTree()
            Me.colSkill = New DevComponents.AdvTree.ColumnHeader()
            Me.colRank = New DevComponents.AdvTree.ColumnHeader()
            Me.colLevel = New DevComponents.AdvTree.ColumnHeader()
            Me.colDone = New DevComponents.AdvTree.ColumnHeader()
            Me.colSP = New DevComponents.AdvTree.ColumnHeader()
            Me.colTime = New DevComponents.AdvTree.ColumnHeader()
            Me.Skill = New DevComponents.DotNetBar.ElementStyle()
            Me.SkillGroup = New DevComponents.DotNetBar.ElementStyle()
            Me.tiSkills = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.tcpStandings = New DevComponents.DotNetBar.TabControlPanel()
            Me.adtStandings = New DevComponents.AdvTree.AdvTree()
            Me.colEntity = New DevComponents.AdvTree.ColumnHeader()
            Me.colEntityID = New DevComponents.AdvTree.ColumnHeader()
            Me.colEntityType = New DevComponents.AdvTree.ColumnHeader()
            Me.colStandingRaw = New DevComponents.AdvTree.ColumnHeader()
            Me.colStandingActual = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle3 = New DevComponents.DotNetBar.ElementStyle()
            Me.tiStandings = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.tcpSkillQueue = New DevComponents.DotNetBar.TabControlPanel()
            Me.sqcEveQueue = New EveHQ.Core.SkillQueueControl.SkillQueueControl()
            Me.tiSkillQueue = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.pnlInfo = New System.Windows.Forms.FlowLayoutPanel()
            Me.grpAccount = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.lblAccountLogins = New DevComponents.DotNetBar.LabelX()
            Me.lblAccountExpiry = New DevComponents.DotNetBar.LabelX()
            Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
            Me.pnlMain = New DevComponents.DotNetBar.PanelEx()
            Me.ctxSkills.SuspendLayout()
            Me.ctxPic.SuspendLayout()
            Me.ctxCerts.SuspendLayout()
            Me.ctxStandings.SuspendLayout()
            Me.grpAttributes.SuspendLayout()
            Me.grpTraining.SuspendLayout()
            Me.grpPilotInfo.SuspendLayout()
            Me.grpAPI.SuspendLayout()
            CType(Me.picPilot, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabPilotInfo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPilotInfo.SuspendLayout()
            Me.tcpCerts.SuspendLayout()
            CType(Me.adtCerts, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tcpSkills.SuspendLayout()
            CType(Me.adtSkills, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tcpStandings.SuspendLayout()
            CType(Me.adtStandings, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tcpSkillQueue.SuspendLayout()
            Me.pnlInfo.SuspendLayout()
            Me.grpAccount.SuspendLayout()
            Me.pnlMain.SuspendLayout()
            Me.SuspendLayout()
            '
            'ctxSkills
            '
            Me.ctxSkills.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSkillName, Me.ToolStripSeparator1, Me.mnuViewDetails})
            Me.ctxSkills.Name = "ctxSkills"
            Me.ctxSkills.Size = New System.Drawing.Size(138, 54)
            '
            'mnuSkillName
            '
            Me.mnuSkillName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.mnuSkillName.Name = "mnuSkillName"
            Me.mnuSkillName.Size = New System.Drawing.Size(137, 22)
            Me.mnuSkillName.Text = "Skill Name"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(134, 6)
            '
            'mnuViewDetails
            '
            Me.mnuViewDetails.Name = "mnuViewDetails"
            Me.mnuViewDetails.Size = New System.Drawing.Size(137, 22)
            Me.mnuViewDetails.Text = "View Details"
            '
            'ctxPic
            '
            Me.ctxPic.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCtxPicGetPortraitFromServer, Me.mnuCtxPicGetPortraitFromLocal, Me.mnuSavePortrait})
            Me.ctxPic.Name = "ctxPic"
            Me.ctxPic.Size = New System.Drawing.Size(246, 70)
            '
            'mnuCtxPicGetPortraitFromServer
            '
            Me.mnuCtxPicGetPortraitFromServer.Name = "mnuCtxPicGetPortraitFromServer"
            Me.mnuCtxPicGetPortraitFromServer.Size = New System.Drawing.Size(245, 22)
            Me.mnuCtxPicGetPortraitFromServer.Text = "Get Portrait from Eve Server"
            '
            'mnuCtxPicGetPortraitFromLocal
            '
            Me.mnuCtxPicGetPortraitFromLocal.Name = "mnuCtxPicGetPortraitFromLocal"
            Me.mnuCtxPicGetPortraitFromLocal.Size = New System.Drawing.Size(245, 22)
            Me.mnuCtxPicGetPortraitFromLocal.Text = "Get Portrait from Eve Installation"
            '
            'mnuSavePortrait
            '
            Me.mnuSavePortrait.Name = "mnuSavePortrait"
            Me.mnuSavePortrait.Size = New System.Drawing.Size(245, 22)
            Me.mnuSavePortrait.Text = "Save Portrait into Image Cache"
            '
            'chkGroupSkills
            '
            Me.chkGroupSkills.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chkGroupSkills.AutoSize = True
            Me.chkGroupSkills.Checked = True
            Me.chkGroupSkills.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkGroupSkills.Location = New System.Drawing.Point(1133, 142)
            Me.chkGroupSkills.Name = "chkGroupSkills"
            Me.chkGroupSkills.Size = New System.Drawing.Size(139, 17)
            Me.chkGroupSkills.TabIndex = 38
            Me.chkGroupSkills.Text = "Group Skills/Certificates"
            Me.chkGroupSkills.UseVisualStyleBackColor = True
            '
            'ctxCerts
            '
            Me.ctxCerts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCertName, Me.ToolStripSeparator2, Me.mnuViewCertDetails})
            Me.ctxCerts.Name = "ctxSkills"
            Me.ctxCerts.Size = New System.Drawing.Size(138, 54)
            '
            'mnuCertName
            '
            Me.mnuCertName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.mnuCertName.Name = "mnuCertName"
            Me.mnuCertName.Size = New System.Drawing.Size(137, 22)
            Me.mnuCertName.Text = "Skill Name"
            '
            'ToolStripSeparator2
            '
            Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
            Me.ToolStripSeparator2.Size = New System.Drawing.Size(134, 6)
            '
            'mnuViewCertDetails
            '
            Me.mnuViewCertDetails.Name = "mnuViewCertDetails"
            Me.mnuViewCertDetails.Size = New System.Drawing.Size(137, 22)
            Me.mnuViewCertDetails.Text = "View Details"
            '
            'ctxStandings
            '
            Me.ctxStandings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExtrapolateStandings})
            Me.ctxStandings.Name = "ctxStandings"
            Me.ctxStandings.Size = New System.Drawing.Size(188, 26)
            '
            'mnuExtrapolateStandings
            '
            Me.mnuExtrapolateStandings.Name = "mnuExtrapolateStandings"
            Me.mnuExtrapolateStandings.Size = New System.Drawing.Size(187, 22)
            Me.mnuExtrapolateStandings.Text = "Extrapolate Standings"
            '
            'lblTypeFilter
            '
            Me.lblTypeFilter.AutoSize = True
            Me.lblTypeFilter.BackColor = System.Drawing.Color.Transparent
            Me.lblTypeFilter.Enabled = False
            Me.lblTypeFilter.Location = New System.Drawing.Point(154, 9)
            Me.lblTypeFilter.Name = "lblTypeFilter"
            Me.lblTypeFilter.Size = New System.Drawing.Size(67, 13)
            Me.lblTypeFilter.TabIndex = 16
            Me.lblTypeFilter.Text = "Select Filter:"
            '
            'cboFilter
            '
            Me.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboFilter.FormattingEnabled = True
            Me.cboFilter.Items.AddRange(New Object() {"<All>", "Agent", "Corporation", "Faction", "Player/Corp"})
            Me.cboFilter.Location = New System.Drawing.Point(234, 6)
            Me.cboFilter.Name = "cboFilter"
            Me.cboFilter.Size = New System.Drawing.Size(103, 21)
            Me.cboFilter.Sorted = True
            Me.cboFilter.TabIndex = 15
            Me.cboFilter.Tag = "0"
            '
            'btExportStandings
            '
            Me.btExportStandings.Location = New System.Drawing.Point(370, 4)
            Me.btExportStandings.Name = "btExportStandings"
            Me.btExportStandings.Size = New System.Drawing.Size(119, 23)
            Me.btExportStandings.TabIndex = 13
            Me.btExportStandings.Text = "Export Standings"
            Me.btExportStandings.UseVisualStyleBackColor = True
            '
            'btnGetStandings
            '
            Me.btnGetStandings.Location = New System.Drawing.Point(4, 4)
            Me.btnGetStandings.Name = "btnGetStandings"
            Me.btnGetStandings.Size = New System.Drawing.Size(124, 23)
            Me.btnGetStandings.TabIndex = 10
            Me.btnGetStandings.Text = "Update Standings"
            Me.btnGetStandings.UseVisualStyleBackColor = True
            '
            'lblPilot
            '
            Me.lblPilot.AutoSize = True
            Me.lblPilot.Location = New System.Drawing.Point(16, 10)
            Me.lblPilot.Name = "lblPilot"
            Me.lblPilot.Size = New System.Drawing.Size(31, 13)
            Me.lblPilot.TabIndex = 40
            Me.lblPilot.Text = "Pilot:"
            '
            'cboPilots
            '
            Me.cboPilots.DropDownHeight = 250
            Me.cboPilots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboPilots.FormattingEnabled = True
            Me.cboPilots.IntegralHeight = False
            Me.cboPilots.Location = New System.Drawing.Point(52, 7)
            Me.cboPilots.Name = "cboPilots"
            Me.cboPilots.Size = New System.Drawing.Size(175, 21)
            Me.cboPilots.Sorted = True
            Me.cboPilots.TabIndex = 41
            '
            'picRace
            '
            Me.picRace.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.picRace.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.picRace.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.picRace.Image = CType(resources.GetObject("picRace.Image"), System.Drawing.Image)
            Me.picRace.Location = New System.Drawing.Point(505, 31)
            Me.picRace.Name = "picRace"
            Me.picRace.Size = New System.Drawing.Size(64, 96)
            Me.picRace.TabIndex = 44
            '
            'picBlood
            '
            Me.picBlood.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.picBlood.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.picBlood.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.picBlood.Image = CType(resources.GetObject("picBlood.Image"), System.Drawing.Image)
            Me.picBlood.Location = New System.Drawing.Point(575, 31)
            Me.picBlood.Name = "picBlood"
            Me.picBlood.Size = New System.Drawing.Size(64, 96)
            Me.picBlood.TabIndex = 45
            '
            'grpAttributes
            '
            Me.grpAttributes.CanvasColor = System.Drawing.SystemColors.Control
            Me.grpAttributes.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.grpAttributes.Controls.Add(Me.btnEditManualImplants)
            Me.grpAttributes.Controls.Add(Me.chkManImplants)
            Me.grpAttributes.Controls.Add(Me.lblWillpowerTotal)
            Me.grpAttributes.Controls.Add(Me.lblWillpowerDetail)
            Me.grpAttributes.Controls.Add(Me.lblWillpower)
            Me.grpAttributes.Controls.Add(Me.lblPerceptionTotal)
            Me.grpAttributes.Controls.Add(Me.lblPerceptionDetail)
            Me.grpAttributes.Controls.Add(Me.lblPerception)
            Me.grpAttributes.Controls.Add(Me.lblMemoryTotal)
            Me.grpAttributes.Controls.Add(Me.lblMemoryDetail)
            Me.grpAttributes.Controls.Add(Me.lblMemory)
            Me.grpAttributes.Controls.Add(Me.lblIntelligenceTotal)
            Me.grpAttributes.Controls.Add(Me.lblIntelligenceDetail)
            Me.grpAttributes.Controls.Add(Me.lblIntelligence)
            Me.grpAttributes.Controls.Add(Me.lblCharismaTotal)
            Me.grpAttributes.Controls.Add(Me.lblCharismaDetail)
            Me.grpAttributes.Controls.Add(Me.lblCharisma)
            Me.grpAttributes.Controls.Add(Me.lblAttributes)
            Me.grpAttributes.DisabledBackColor = System.Drawing.Color.Empty
            Me.grpAttributes.IsShadowEnabled = True
            Me.grpAttributes.Location = New System.Drawing.Point(3, 282)
            Me.grpAttributes.Name = "grpAttributes"
            Me.grpAttributes.Size = New System.Drawing.Size(304, 193)
            '
            '
            '
            Me.grpAttributes.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.grpAttributes.Style.BackColorGradientAngle = 90
            Me.grpAttributes.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.grpAttributes.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpAttributes.Style.BorderBottomWidth = 1
            Me.grpAttributes.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.grpAttributes.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpAttributes.Style.BorderLeftWidth = 1
            Me.grpAttributes.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpAttributes.Style.BorderRightWidth = 1
            Me.grpAttributes.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpAttributes.Style.BorderTopWidth = 1
            Me.grpAttributes.Style.CornerDiameter = 4
            Me.grpAttributes.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.grpAttributes.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.grpAttributes.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.grpAttributes.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.grpAttributes.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.grpAttributes.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.grpAttributes.TabIndex = 46
            '
            'btnEditManualImplants
            '
            Me.btnEditManualImplants.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnEditManualImplants.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnEditManualImplants.Enabled = False
            Me.btnEditManualImplants.Location = New System.Drawing.Point(134, 157)
            Me.btnEditManualImplants.Name = "btnEditManualImplants"
            Me.btnEditManualImplants.Size = New System.Drawing.Size(141, 23)
            Me.btnEditManualImplants.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnEditManualImplants.TabIndex = 17
            Me.btnEditManualImplants.Text = "Edit Manual Implants"
            '
            'chkManImplants
            '
            Me.chkManImplants.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.chkManImplants.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkManImplants.Location = New System.Drawing.Point(13, 157)
            Me.chkManImplants.Name = "chkManImplants"
            Me.chkManImplants.Size = New System.Drawing.Size(115, 23)
            Me.chkManImplants.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkManImplants.TabIndex = 16
            Me.chkManImplants.Text = "Manual Implants"
            '
            'lblWillpowerTotal
            '
            Me.lblWillpowerTotal.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblWillpowerTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblWillpowerTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblWillpowerTotal.Location = New System.Drawing.Point(242, 128)
            Me.lblWillpowerTotal.Name = "lblWillpowerTotal"
            Me.lblWillpowerTotal.Size = New System.Drawing.Size(33, 23)
            Me.lblWillpowerTotal.TabIndex = 15
            Me.lblWillpowerTotal.Text = "20.0"
            Me.lblWillpowerTotal.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'lblWillpowerDetail
            '
            Me.lblWillpowerDetail.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblWillpowerDetail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblWillpowerDetail.Location = New System.Drawing.Point(110, 128)
            Me.lblWillpowerDetail.Name = "lblWillpowerDetail"
            Me.lblWillpowerDetail.Size = New System.Drawing.Size(126, 23)
            Me.lblWillpowerDetail.TabIndex = 14
            Me.lblWillpowerDetail.Text = "(5  +  5  +  10)"
            '
            'lblWillpower
            '
            Me.lblWillpower.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblWillpower.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblWillpower.Image = Global.EveHQ.My.Resources.Resources.Willpower32
            Me.lblWillpower.Location = New System.Drawing.Point(7, 128)
            Me.lblWillpower.Name = "lblWillpower"
            Me.lblWillpower.Size = New System.Drawing.Size(115, 23)
            Me.lblWillpower.TabIndex = 13
            Me.lblWillpower.Text = "Willpower"
            '
            'lblPerceptionTotal
            '
            Me.lblPerceptionTotal.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblPerceptionTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblPerceptionTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPerceptionTotal.Location = New System.Drawing.Point(242, 104)
            Me.lblPerceptionTotal.Name = "lblPerceptionTotal"
            Me.lblPerceptionTotal.Size = New System.Drawing.Size(33, 23)
            Me.lblPerceptionTotal.TabIndex = 12
            Me.lblPerceptionTotal.Text = "20.0"
            Me.lblPerceptionTotal.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'lblPerceptionDetail
            '
            Me.lblPerceptionDetail.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblPerceptionDetail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblPerceptionDetail.Location = New System.Drawing.Point(110, 104)
            Me.lblPerceptionDetail.Name = "lblPerceptionDetail"
            Me.lblPerceptionDetail.Size = New System.Drawing.Size(126, 23)
            Me.lblPerceptionDetail.TabIndex = 11
            Me.lblPerceptionDetail.Text = "(5  +  5  +  10)"
            '
            'lblPerception
            '
            Me.lblPerception.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblPerception.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblPerception.Image = Global.EveHQ.My.Resources.Resources.Perception32
            Me.lblPerception.Location = New System.Drawing.Point(7, 104)
            Me.lblPerception.Name = "lblPerception"
            Me.lblPerception.Size = New System.Drawing.Size(115, 23)
            Me.lblPerception.TabIndex = 10
            Me.lblPerception.Text = "Perception"
            '
            'lblMemoryTotal
            '
            Me.lblMemoryTotal.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblMemoryTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblMemoryTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMemoryTotal.Location = New System.Drawing.Point(242, 80)
            Me.lblMemoryTotal.Name = "lblMemoryTotal"
            Me.lblMemoryTotal.Size = New System.Drawing.Size(33, 23)
            Me.lblMemoryTotal.TabIndex = 9
            Me.lblMemoryTotal.Text = "20.0"
            Me.lblMemoryTotal.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'lblMemoryDetail
            '
            Me.lblMemoryDetail.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblMemoryDetail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblMemoryDetail.Location = New System.Drawing.Point(110, 80)
            Me.lblMemoryDetail.Name = "lblMemoryDetail"
            Me.lblMemoryDetail.Size = New System.Drawing.Size(126, 23)
            Me.lblMemoryDetail.TabIndex = 8
            Me.lblMemoryDetail.Text = "(5  +  5  +  10)"
            '
            'lblMemory
            '
            Me.lblMemory.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblMemory.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblMemory.Image = Global.EveHQ.My.Resources.Resources.Memory32
            Me.lblMemory.Location = New System.Drawing.Point(7, 80)
            Me.lblMemory.Name = "lblMemory"
            Me.lblMemory.Size = New System.Drawing.Size(115, 23)
            Me.lblMemory.TabIndex = 7
            Me.lblMemory.Text = "Memory"
            '
            'lblIntelligenceTotal
            '
            Me.lblIntelligenceTotal.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblIntelligenceTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblIntelligenceTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIntelligenceTotal.Location = New System.Drawing.Point(242, 56)
            Me.lblIntelligenceTotal.Name = "lblIntelligenceTotal"
            Me.lblIntelligenceTotal.Size = New System.Drawing.Size(33, 23)
            Me.lblIntelligenceTotal.TabIndex = 6
            Me.lblIntelligenceTotal.Text = "20.0"
            Me.lblIntelligenceTotal.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'lblIntelligenceDetail
            '
            Me.lblIntelligenceDetail.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblIntelligenceDetail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblIntelligenceDetail.Location = New System.Drawing.Point(110, 56)
            Me.lblIntelligenceDetail.Name = "lblIntelligenceDetail"
            Me.lblIntelligenceDetail.Size = New System.Drawing.Size(126, 23)
            Me.lblIntelligenceDetail.TabIndex = 5
            Me.lblIntelligenceDetail.Text = "(5  +  5  +  10)"
            '
            'lblIntelligence
            '
            Me.lblIntelligence.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblIntelligence.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblIntelligence.Image = Global.EveHQ.My.Resources.Resources.Intelligence32
            Me.lblIntelligence.Location = New System.Drawing.Point(7, 56)
            Me.lblIntelligence.Name = "lblIntelligence"
            Me.lblIntelligence.Size = New System.Drawing.Size(115, 23)
            Me.lblIntelligence.TabIndex = 4
            Me.lblIntelligence.Text = "Intelligence"
            '
            'lblCharismaTotal
            '
            Me.lblCharismaTotal.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblCharismaTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblCharismaTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCharismaTotal.Location = New System.Drawing.Point(242, 32)
            Me.lblCharismaTotal.Name = "lblCharismaTotal"
            Me.lblCharismaTotal.Size = New System.Drawing.Size(33, 23)
            Me.lblCharismaTotal.TabIndex = 3
            Me.lblCharismaTotal.Text = "20.0"
            Me.lblCharismaTotal.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'lblCharismaDetail
            '
            Me.lblCharismaDetail.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblCharismaDetail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblCharismaDetail.Location = New System.Drawing.Point(110, 32)
            Me.lblCharismaDetail.Name = "lblCharismaDetail"
            Me.lblCharismaDetail.Size = New System.Drawing.Size(126, 23)
            Me.lblCharismaDetail.TabIndex = 2
            Me.lblCharismaDetail.Text = "(5  +  5  +  10)"
            '
            'lblCharisma
            '
            Me.lblCharisma.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblCharisma.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblCharisma.Image = Global.EveHQ.My.Resources.Resources.Charisma32
            Me.lblCharisma.Location = New System.Drawing.Point(7, 32)
            Me.lblCharisma.Name = "lblCharisma"
            Me.lblCharisma.Size = New System.Drawing.Size(115, 23)
            Me.lblCharisma.TabIndex = 1
            Me.lblCharisma.Text = "Charisma"
            '
            'lblAttributes
            '
            Me.lblAttributes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblAttributes.BackColor = System.Drawing.Color.DimGray
            '
            '
            '
            Me.lblAttributes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblAttributes.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.lblAttributes.Image = Global.EveHQ.My.Resources.Resources.Attributes32
            Me.lblAttributes.Location = New System.Drawing.Point(3, 3)
            Me.lblAttributes.Name = "lblAttributes"
            Me.lblAttributes.Size = New System.Drawing.Size(292, 23)
            Me.lblAttributes.TabIndex = 0
            Me.lblAttributes.Text = "Attributes && Implants"
            '
            'grpTraining
            '
            Me.grpTraining.CanvasColor = System.Drawing.SystemColors.Control
            Me.grpTraining.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.grpTraining.Controls.Add(Me.lblTrainingRate)
            Me.grpTraining.Controls.Add(Me.lblTrainingEnds)
            Me.grpTraining.Controls.Add(Me.lblTrainingTime)
            Me.grpTraining.Controls.Add(Me.lblTrainingSkill)
            Me.grpTraining.Controls.Add(Me.lblSkillTraining)
            Me.grpTraining.DisabledBackColor = System.Drawing.Color.Empty
            Me.grpTraining.IsShadowEnabled = True
            Me.grpTraining.Location = New System.Drawing.Point(3, 151)
            Me.grpTraining.Name = "grpTraining"
            Me.grpTraining.Size = New System.Drawing.Size(304, 125)
            '
            '
            '
            Me.grpTraining.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.grpTraining.Style.BackColorGradientAngle = 90
            Me.grpTraining.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.grpTraining.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpTraining.Style.BorderBottomWidth = 1
            Me.grpTraining.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.grpTraining.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpTraining.Style.BorderLeftWidth = 1
            Me.grpTraining.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpTraining.Style.BorderRightWidth = 1
            Me.grpTraining.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpTraining.Style.BorderTopWidth = 1
            Me.grpTraining.Style.CornerDiameter = 4
            Me.grpTraining.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.grpTraining.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.grpTraining.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.grpTraining.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.grpTraining.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.grpTraining.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.grpTraining.TabIndex = 47
            '
            'lblTrainingRate
            '
            Me.lblTrainingRate.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblTrainingRate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblTrainingRate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTrainingRate.Location = New System.Drawing.Point(11, 92)
            Me.lblTrainingRate.Name = "lblTrainingRate"
            Me.lblTrainingRate.Size = New System.Drawing.Size(276, 23)
            Me.lblTrainingRate.TabIndex = 5
            Me.lblTrainingRate.Text = "Training Rate"
            '
            'lblTrainingEnds
            '
            Me.lblTrainingEnds.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblTrainingEnds.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblTrainingEnds.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTrainingEnds.Location = New System.Drawing.Point(11, 72)
            Me.lblTrainingEnds.Name = "lblTrainingEnds"
            Me.lblTrainingEnds.Size = New System.Drawing.Size(276, 23)
            Me.lblTrainingEnds.TabIndex = 4
            Me.lblTrainingEnds.Text = "Training Ends"
            '
            'lblTrainingTime
            '
            Me.lblTrainingTime.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblTrainingTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblTrainingTime.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTrainingTime.Location = New System.Drawing.Point(11, 52)
            Me.lblTrainingTime.Name = "lblTrainingTime"
            Me.lblTrainingTime.Size = New System.Drawing.Size(276, 23)
            Me.lblTrainingTime.TabIndex = 3
            Me.lblTrainingTime.Text = "Training Time"
            '
            'lblTrainingSkill
            '
            Me.lblTrainingSkill.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblTrainingSkill.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblTrainingSkill.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTrainingSkill.Location = New System.Drawing.Point(11, 32)
            Me.lblTrainingSkill.Name = "lblTrainingSkill"
            Me.lblTrainingSkill.Size = New System.Drawing.Size(276, 23)
            Me.lblTrainingSkill.TabIndex = 2
            Me.lblTrainingSkill.Text = "Training Skill"
            '
            'lblSkillTraining
            '
            Me.lblSkillTraining.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSkillTraining.BackColor = System.Drawing.Color.DimGray
            '
            '
            '
            Me.lblSkillTraining.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblSkillTraining.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.lblSkillTraining.Image = CType(resources.GetObject("lblSkillTraining.Image"), System.Drawing.Image)
            Me.lblSkillTraining.Location = New System.Drawing.Point(3, 3)
            Me.lblSkillTraining.Name = "lblSkillTraining"
            Me.lblSkillTraining.Size = New System.Drawing.Size(292, 23)
            Me.lblSkillTraining.TabIndex = 0
            Me.lblSkillTraining.Text = "Skill Training"
            '
            'grpPilotInfo
            '
            Me.grpPilotInfo.CanvasColor = System.Drawing.SystemColors.Control
            Me.grpPilotInfo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.grpPilotInfo.Controls.Add(Me.lblPilotSP)
            Me.grpPilotInfo.Controls.Add(Me.lblPilotIsk)
            Me.grpPilotInfo.Controls.Add(Me.lblPilotCorp)
            Me.grpPilotInfo.Controls.Add(Me.lblPilotAccount)
            Me.grpPilotInfo.Controls.Add(Me.lblPilotID)
            Me.grpPilotInfo.Controls.Add(Me.lblPilotSPLbl)
            Me.grpPilotInfo.Controls.Add(Me.lblPilotIskLbl)
            Me.grpPilotInfo.Controls.Add(Me.lblPilotCorpLbl)
            Me.grpPilotInfo.Controls.Add(Me.lblPilotAccountLbl)
            Me.grpPilotInfo.Controls.Add(Me.lblPilotIDLbl)
            Me.grpPilotInfo.Controls.Add(Me.lblPilotName)
            Me.grpPilotInfo.Controls.Add(Me.LabelX6)
            Me.grpPilotInfo.DisabledBackColor = System.Drawing.Color.Empty
            Me.grpPilotInfo.IsShadowEnabled = True
            Me.grpPilotInfo.Location = New System.Drawing.Point(3, 3)
            Me.grpPilotInfo.Name = "grpPilotInfo"
            Me.grpPilotInfo.Size = New System.Drawing.Size(304, 162)
            '
            '
            '
            Me.grpPilotInfo.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.grpPilotInfo.Style.BackColorGradientAngle = 90
            Me.grpPilotInfo.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.grpPilotInfo.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpPilotInfo.Style.BorderBottomWidth = 1
            Me.grpPilotInfo.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.grpPilotInfo.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpPilotInfo.Style.BorderLeftWidth = 1
            Me.grpPilotInfo.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpPilotInfo.Style.BorderRightWidth = 1
            Me.grpPilotInfo.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpPilotInfo.Style.BorderTopWidth = 1
            Me.grpPilotInfo.Style.CornerDiameter = 4
            Me.grpPilotInfo.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.grpPilotInfo.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.grpPilotInfo.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.grpPilotInfo.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.grpPilotInfo.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.grpPilotInfo.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.grpPilotInfo.TabIndex = 48
            '
            'lblPilotSP
            '
            Me.lblPilotSP.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblPilotSP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblPilotSP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPilotSP.Location = New System.Drawing.Point(84, 112)
            Me.lblPilotSP.Name = "lblPilotSP"
            Me.lblPilotSP.Size = New System.Drawing.Size(198, 23)
            Me.lblPilotSP.TabIndex = 10
            Me.lblPilotSP.Text = "Pilot SP"
            '
            'lblPilotIsk
            '
            Me.lblPilotIsk.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblPilotIsk.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblPilotIsk.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPilotIsk.Location = New System.Drawing.Point(84, 92)
            Me.lblPilotIsk.Name = "lblPilotIsk"
            Me.lblPilotIsk.Size = New System.Drawing.Size(198, 23)
            Me.lblPilotIsk.TabIndex = 9
            Me.lblPilotIsk.Text = "Pilot Isk"
            '
            'lblPilotCorp
            '
            Me.lblPilotCorp.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblPilotCorp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblPilotCorp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPilotCorp.Location = New System.Drawing.Point(84, 72)
            Me.lblPilotCorp.Name = "lblPilotCorp"
            Me.lblPilotCorp.Size = New System.Drawing.Size(198, 23)
            Me.lblPilotCorp.TabIndex = 8
            Me.lblPilotCorp.Text = "Pilot Corp"
            '
            'lblPilotAccount
            '
            Me.lblPilotAccount.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblPilotAccount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblPilotAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPilotAccount.Location = New System.Drawing.Point(84, 132)
            Me.lblPilotAccount.Name = "lblPilotAccount"
            Me.lblPilotAccount.Size = New System.Drawing.Size(198, 23)
            Me.lblPilotAccount.TabIndex = 8
            Me.lblPilotAccount.Text = "Pilot Account"
            '
            'lblPilotID
            '
            Me.lblPilotID.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblPilotID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblPilotID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPilotID.Location = New System.Drawing.Point(84, 52)
            Me.lblPilotID.Name = "lblPilotID"
            Me.lblPilotID.Size = New System.Drawing.Size(198, 23)
            Me.lblPilotID.TabIndex = 7
            Me.lblPilotID.Text = "Pilot ID"
            '
            'lblPilotSPLbl
            '
            Me.lblPilotSPLbl.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblPilotSPLbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblPilotSPLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPilotSPLbl.Location = New System.Drawing.Point(13, 112)
            Me.lblPilotSPLbl.Name = "lblPilotSPLbl"
            Me.lblPilotSPLbl.Size = New System.Drawing.Size(65, 23)
            Me.lblPilotSPLbl.TabIndex = 5
            Me.lblPilotSPLbl.Text = "Pilot SP"
            '
            'lblPilotIskLbl
            '
            Me.lblPilotIskLbl.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblPilotIskLbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblPilotIskLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPilotIskLbl.Location = New System.Drawing.Point(13, 92)
            Me.lblPilotIskLbl.Name = "lblPilotIskLbl"
            Me.lblPilotIskLbl.Size = New System.Drawing.Size(65, 23)
            Me.lblPilotIskLbl.TabIndex = 4
            Me.lblPilotIskLbl.Text = "Pilot Isk"
            '
            'lblPilotCorpLbl
            '
            Me.lblPilotCorpLbl.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblPilotCorpLbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblPilotCorpLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPilotCorpLbl.Location = New System.Drawing.Point(13, 72)
            Me.lblPilotCorpLbl.Name = "lblPilotCorpLbl"
            Me.lblPilotCorpLbl.Size = New System.Drawing.Size(65, 23)
            Me.lblPilotCorpLbl.TabIndex = 3
            Me.lblPilotCorpLbl.Text = "Pilot Corp"
            '
            'lblPilotAccountLbl
            '
            Me.lblPilotAccountLbl.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblPilotAccountLbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblPilotAccountLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPilotAccountLbl.Location = New System.Drawing.Point(13, 132)
            Me.lblPilotAccountLbl.Name = "lblPilotAccountLbl"
            Me.lblPilotAccountLbl.Size = New System.Drawing.Size(65, 23)
            Me.lblPilotAccountLbl.TabIndex = 3
            Me.lblPilotAccountLbl.Text = "Pilot Account"
            '
            'lblPilotIDLbl
            '
            Me.lblPilotIDLbl.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblPilotIDLbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblPilotIDLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPilotIDLbl.Location = New System.Drawing.Point(13, 52)
            Me.lblPilotIDLbl.Name = "lblPilotIDLbl"
            Me.lblPilotIDLbl.Size = New System.Drawing.Size(65, 23)
            Me.lblPilotIDLbl.TabIndex = 2
            Me.lblPilotIDLbl.Text = "Pilot ID"
            '
            'lblPilotName
            '
            Me.lblPilotName.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblPilotName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblPilotName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPilotName.Location = New System.Drawing.Point(13, 32)
            Me.lblPilotName.Name = "lblPilotName"
            Me.lblPilotName.Size = New System.Drawing.Size(269, 23)
            Me.lblPilotName.TabIndex = 1
            Me.lblPilotName.Text = "Pilot Name"
            '
            'LabelX6
            '
            Me.LabelX6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LabelX6.BackColor = System.Drawing.Color.DimGray
            '
            '
            '
            Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX6.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.LabelX6.Image = CType(resources.GetObject("LabelX6.Image"), System.Drawing.Image)
            Me.LabelX6.Location = New System.Drawing.Point(3, 3)
            Me.LabelX6.Name = "LabelX6"
            Me.LabelX6.Size = New System.Drawing.Size(292, 23)
            Me.LabelX6.TabIndex = 0
            Me.LabelX6.Text = "Pilot Information"
            '
            'grpAPI
            '
            Me.grpAPI.CanvasColor = System.Drawing.SystemColors.Control
            Me.grpAPI.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.grpAPI.Controls.Add(Me.btnUpdateAPI)
            Me.grpAPI.Controls.Add(Me.lblCharacterXML)
            Me.grpAPI.Controls.Add(Me.LabelX17)
            Me.grpAPI.DisabledBackColor = System.Drawing.Color.Empty
            Me.grpAPI.IsShadowEnabled = True
            Me.grpAPI.Location = New System.Drawing.Point(3, 481)
            Me.grpAPI.Name = "grpAPI"
            Me.grpAPI.Size = New System.Drawing.Size(304, 76)
            '
            '
            '
            Me.grpAPI.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.grpAPI.Style.BackColorGradientAngle = 90
            Me.grpAPI.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.grpAPI.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpAPI.Style.BorderBottomWidth = 1
            Me.grpAPI.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.grpAPI.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpAPI.Style.BorderLeftWidth = 1
            Me.grpAPI.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpAPI.Style.BorderRightWidth = 1
            Me.grpAPI.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpAPI.Style.BorderTopWidth = 1
            Me.grpAPI.Style.CornerDiameter = 4
            Me.grpAPI.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.grpAPI.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.grpAPI.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.grpAPI.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.grpAPI.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.grpAPI.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.grpAPI.TabIndex = 49
            '
            'btnUpdateAPI
            '
            Me.btnUpdateAPI.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnUpdateAPI.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnUpdateAPI.Enabled = False
            Me.btnUpdateAPI.Location = New System.Drawing.Point(215, 42)
            Me.btnUpdateAPI.Name = "btnUpdateAPI"
            Me.btnUpdateAPI.Size = New System.Drawing.Size(80, 23)
            Me.btnUpdateAPI.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnUpdateAPI.TabIndex = 3
            Me.btnUpdateAPI.Text = "Update API"
            '
            'lblCharacterXML
            '
            Me.lblCharacterXML.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblCharacterXML.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblCharacterXML.Location = New System.Drawing.Point(11, 32)
            Me.lblCharacterXML.Name = "lblCharacterXML"
            Me.lblCharacterXML.Size = New System.Drawing.Size(198, 33)
            Me.lblCharacterXML.TabIndex = 2
            Me.lblCharacterXML.Text = "Expiry Date" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Time Remaining"
            '
            'LabelX17
            '
            Me.LabelX17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LabelX17.BackColor = System.Drawing.Color.DimGray
            '
            '
            '
            Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX17.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.LabelX17.Image = CType(resources.GetObject("LabelX17.Image"), System.Drawing.Image)
            Me.LabelX17.Location = New System.Drawing.Point(3, 3)
            Me.LabelX17.Name = "LabelX17"
            Me.LabelX17.Size = New System.Drawing.Size(292, 23)
            Me.LabelX17.TabIndex = 0
            Me.LabelX17.Text = "Character API Information"
            '
            'picPilot
            '
            Me.picPilot.ContextMenuStrip = Me.ctxPic
            Me.picPilot.ErrorImage = Global.EveHQ.My.Resources.Resources.nochar
            Me.picPilot.Location = New System.Drawing.Point(348, 31)
            Me.picPilot.Name = "picPilot"
            Me.picPilot.Size = New System.Drawing.Size(128, 128)
            Me.picPilot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picPilot.TabIndex = 50
            Me.picPilot.TabStop = False
            '
            'tabPilotInfo
            '
            Me.tabPilotInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tabPilotInfo.BackColor = System.Drawing.Color.Transparent
            Me.tabPilotInfo.CanReorderTabs = False
            Me.tabPilotInfo.ColorScheme.TabBackground = System.Drawing.Color.Transparent
            Me.tabPilotInfo.ColorScheme.TabBackground2 = System.Drawing.Color.Transparent
            Me.tabPilotInfo.ColorScheme.TabItemBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(226, Byte), Integer)), 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(199, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(223, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), 1.0!)})
            Me.tabPilotInfo.ColorScheme.TabItemHotBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(235, Byte), Integer)), 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(168, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(89, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(141, Byte), Integer)), 1.0!)})
            Me.tabPilotInfo.ColorScheme.TabItemSelectedBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.White, 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer)), 1.0!)})
            Me.tabPilotInfo.Controls.Add(Me.tcpSkills)
            Me.tabPilotInfo.Controls.Add(Me.tcpCerts)
            Me.tabPilotInfo.Controls.Add(Me.tcpStandings)
            Me.tabPilotInfo.Controls.Add(Me.tcpSkillQueue)
            Me.tabPilotInfo.Location = New System.Drawing.Point(348, 165)
            Me.tabPilotInfo.Name = "tabPilotInfo"
            Me.tabPilotInfo.SelectedTabFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.tabPilotInfo.SelectedTabIndex = 0
            Me.tabPilotInfo.Size = New System.Drawing.Size(933, 707)
            Me.tabPilotInfo.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
            Me.tabPilotInfo.TabIndex = 52
            Me.tabPilotInfo.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
            Me.tabPilotInfo.Tabs.Add(Me.tiSkills)
            Me.tabPilotInfo.Tabs.Add(Me.tsCerts)
            Me.tabPilotInfo.Tabs.Add(Me.tiSkillQueue)
            Me.tabPilotInfo.Tabs.Add(Me.tiStandings)
            Me.tabPilotInfo.Text = "TabControl1"
            '
            'tcpCerts
            '
            Me.tcpCerts.Controls.Add(Me.adtCerts)
            Me.tcpCerts.DisabledBackColor = System.Drawing.Color.Empty
            Me.tcpCerts.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcpCerts.Location = New System.Drawing.Point(0, 23)
            Me.tcpCerts.Name = "tcpCerts"
            Me.tcpCerts.Padding = New System.Windows.Forms.Padding(1)
            Me.tcpCerts.Size = New System.Drawing.Size(933, 684)
            Me.tcpCerts.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.tcpCerts.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.tcpCerts.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.tcpCerts.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.tcpCerts.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.tcpCerts.Style.GradientAngle = 90
            Me.tcpCerts.TabIndex = 2
            Me.tcpCerts.TabItem = Me.tsCerts
            '
            'adtCerts
            '
            Me.adtCerts.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtCerts.AllowDrop = True
            Me.adtCerts.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtCerts.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtCerts.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtCerts.Columns.Add(Me.colCertName)
            Me.adtCerts.Columns.Add(Me.colCertGrd)
            Me.adtCerts.ContextMenuStrip = Me.ctxCerts
            Me.adtCerts.Dock = System.Windows.Forms.DockStyle.Fill
            Me.adtCerts.DragDropEnabled = False
            Me.adtCerts.DragDropNodeCopyEnabled = False
            Me.adtCerts.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle
            Me.adtCerts.KeyboardSearchEnabled = False
            
            Me.adtCerts.Location = New System.Drawing.Point(1, 1)
            Me.adtCerts.Name = "adtCerts"
            Me.adtCerts.NodeSpacing = 1
            Me.adtCerts.NodeStyle = Me.ElementStyle2
            Me.adtCerts.PathSeparator = ";"
            Me.adtCerts.SelectionBox = False
            Me.adtCerts.Size = New System.Drawing.Size(931, 682)
            Me.adtCerts.Styles.Add(Me.ElementStyle2)
            Me.adtCerts.Styles.Add(Me.ElementStyle1)
            Me.adtCerts.TabIndex = 39
            '
            'colCertName
            '
            Me.colCertName.DisplayIndex = 1
            Me.colCertName.Name = "colCertName"
            Me.colCertName.SortingEnabled = False
            Me.colCertName.Text = "Certificate Name"
            Me.colCertName.Width.Absolute = 400
            '
            'colCertGrd
            '
            Me.colCertGrd.DisplayIndex = 2
            Me.colCertGrd.EditorType = DevComponents.AdvTree.eCellEditorType.Custom
            Me.colCertGrd.Name = "colCertGrd"
            Me.colCertGrd.SortingEnabled = False
            Me.colCertGrd.Text = "Grade"
            Me.colCertGrd.Width.Absolute = 120
            '
            'ElementStyle2
            '
            Me.ElementStyle2.BackColorGradientAngle = 45
            Me.ElementStyle2.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
            Me.ElementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle2.Name = "ElementStyle2"
            Me.ElementStyle2.TextColor = System.Drawing.Color.Black
            '
            'ElementStyle1
            '
            Me.ElementStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
            Me.ElementStyle1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.ElementStyle1.BackColorGradientAngle = 90
            Me.ElementStyle1.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
            Me.ElementStyle1.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.ElementStyle1.BorderBottomWidth = 1
            Me.ElementStyle1.BorderColor = System.Drawing.Color.DarkGray
            Me.ElementStyle1.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.ElementStyle1.BorderLeftWidth = 1
            Me.ElementStyle1.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.ElementStyle1.BorderRightWidth = 1
            Me.ElementStyle1.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.ElementStyle1.BorderTopWidth = 1
            Me.ElementStyle1.CornerDiameter = 4
            Me.ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle1.Description = "Gray"
            Me.ElementStyle1.Name = "ElementStyle1"
            Me.ElementStyle1.PaddingBottom = 1
            Me.ElementStyle1.PaddingLeft = 1
            Me.ElementStyle1.PaddingRight = 1
            Me.ElementStyle1.PaddingTop = 1
            Me.ElementStyle1.TextColor = System.Drawing.Color.White
            '
            'tsCerts
            '
            Me.tsCerts.AttachedControl = Me.tcpCerts
            Me.tsCerts.Name = "tsCerts"
            Me.tsCerts.Text = "Certificates"
            '
            'tcpSkills
            '
            Me.tcpSkills.Controls.Add(Me.adtSkills)
            Me.tcpSkills.DisabledBackColor = System.Drawing.Color.Empty
            Me.tcpSkills.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcpSkills.Location = New System.Drawing.Point(0, 23)
            Me.tcpSkills.Name = "tcpSkills"
            Me.tcpSkills.Padding = New System.Windows.Forms.Padding(1)
            Me.tcpSkills.Size = New System.Drawing.Size(933, 684)
            Me.tcpSkills.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.tcpSkills.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.tcpSkills.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.tcpSkills.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.tcpSkills.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.tcpSkills.Style.GradientAngle = 90
            Me.tcpSkills.TabIndex = 1
            Me.tcpSkills.TabItem = Me.tiSkills
            '
            'adtSkills
            '
            Me.adtSkills.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtSkills.AllowDrop = True
            Me.adtSkills.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtSkills.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtSkills.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtSkills.Columns.Add(Me.colSkill)
            Me.adtSkills.Columns.Add(Me.colRank)
            Me.adtSkills.Columns.Add(Me.colLevel)
            Me.adtSkills.Columns.Add(Me.colDone)
            Me.adtSkills.Columns.Add(Me.colSP)
            Me.adtSkills.Columns.Add(Me.colTime)
            Me.adtSkills.ContextMenuStrip = Me.ctxSkills
            Me.adtSkills.Dock = System.Windows.Forms.DockStyle.Fill
            Me.adtSkills.DragDropEnabled = False
            Me.adtSkills.DragDropNodeCopyEnabled = False
            Me.adtSkills.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle
            Me.adtSkills.KeyboardSearchEnabled = False
            
            Me.adtSkills.Location = New System.Drawing.Point(1, 1)
            Me.adtSkills.Name = "adtSkills"
            Me.adtSkills.NodeSpacing = 1
            Me.adtSkills.NodeStyle = Me.Skill
            Me.adtSkills.PathSeparator = ";"
            Me.adtSkills.SelectionBox = False
            Me.adtSkills.Size = New System.Drawing.Size(931, 682)
            Me.adtSkills.Styles.Add(Me.Skill)
            Me.adtSkills.Styles.Add(Me.SkillGroup)
            Me.adtSkills.TabIndex = 38
            '
            'colSkill
            '
            Me.colSkill.DisplayIndex = 1
            Me.colSkill.Name = "colSkill"
            Me.colSkill.SortingEnabled = False
            Me.colSkill.Text = "Skill"
            Me.colSkill.Width.Absolute = 300
            '
            'colRank
            '
            Me.colRank.DisplayIndex = 2
            Me.colRank.Name = "colRank"
            Me.colRank.SortingEnabled = False
            Me.colRank.Text = "Rank"
            Me.colRank.Width.Absolute = 60
            '
            'colLevel
            '
            Me.colLevel.DisplayIndex = 3
            Me.colLevel.EditorType = DevComponents.AdvTree.eCellEditorType.Custom
            Me.colLevel.Name = "colLevel"
            Me.colLevel.SortingEnabled = False
            Me.colLevel.Text = "Level"
            Me.colLevel.Width.Absolute = 60
            '
            'colDone
            '
            Me.colDone.DisplayIndex = 4
            Me.colDone.Name = "colDone"
            Me.colDone.SortingEnabled = False
            Me.colDone.Text = "% Done"
            Me.colDone.Width.Absolute = 60
            '
            'colSP
            '
            Me.colSP.DisplayIndex = 5
            Me.colSP.EditorType = DevComponents.AdvTree.eCellEditorType.Custom
            Me.colSP.Name = "colSP"
            Me.colSP.SortingEnabled = False
            Me.colSP.Text = "Skillpoints"
            Me.colSP.Width.Absolute = 120
            '
            'colTime
            '
            Me.colTime.DisplayIndex = 6
            Me.colTime.EditorType = DevComponents.AdvTree.eCellEditorType.Custom
            Me.colTime.Name = "colTime"
            Me.colTime.SortingEnabled = False
            Me.colTime.Text = "Time to Level Up"
            Me.colTime.Width.Absolute = 120
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
            'tiSkills
            '
            Me.tiSkills.AttachedControl = Me.tcpSkills
            Me.tiSkills.Name = "tiSkills"
            Me.tiSkills.Text = "Skills"
            '
            'tcpStandings
            '
            Me.tcpStandings.Controls.Add(Me.adtStandings)
            Me.tcpStandings.Controls.Add(Me.btnGetStandings)
            Me.tcpStandings.Controls.Add(Me.lblTypeFilter)
            Me.tcpStandings.Controls.Add(Me.btExportStandings)
            Me.tcpStandings.Controls.Add(Me.cboFilter)
            Me.tcpStandings.DisabledBackColor = System.Drawing.Color.Empty
            Me.tcpStandings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcpStandings.Location = New System.Drawing.Point(0, 23)
            Me.tcpStandings.Name = "tcpStandings"
            Me.tcpStandings.Padding = New System.Windows.Forms.Padding(1)
            Me.tcpStandings.Size = New System.Drawing.Size(933, 684)
            Me.tcpStandings.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.tcpStandings.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.tcpStandings.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.tcpStandings.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.tcpStandings.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.tcpStandings.Style.GradientAngle = 90
            Me.tcpStandings.TabIndex = 4
            Me.tcpStandings.TabItem = Me.tiStandings
            '
            'adtStandings
            '
            Me.adtStandings.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtStandings.AllowDrop = True
            Me.adtStandings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.adtStandings.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtStandings.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtStandings.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtStandings.Columns.Add(Me.colEntity)
            Me.adtStandings.Columns.Add(Me.colEntityID)
            Me.adtStandings.Columns.Add(Me.colEntityType)
            Me.adtStandings.Columns.Add(Me.colStandingRaw)
            Me.adtStandings.Columns.Add(Me.colStandingActual)
            Me.adtStandings.ContextMenuStrip = Me.ctxStandings
            Me.adtStandings.DragDropEnabled = False
            Me.adtStandings.DragDropNodeCopyEnabled = False
            Me.adtStandings.ExpandWidth = 0
            
            Me.adtStandings.Location = New System.Drawing.Point(4, 33)
            Me.adtStandings.Name = "adtStandings"
            Me.adtStandings.NodesConnector = Me.NodeConnector1
            Me.adtStandings.NodeStyle = Me.ElementStyle3
            Me.adtStandings.PathSeparator = ";"
            Me.adtStandings.Size = New System.Drawing.Size(925, 645)
            Me.adtStandings.Styles.Add(Me.ElementStyle3)
            Me.adtStandings.TabIndex = 17
            Me.adtStandings.Text = "AdvTree1"
            '
            'colEntity
            '
            Me.colEntity.DisplayIndex = 1
            Me.colEntity.Name = "colEntity"
            Me.colEntity.SortingEnabled = False
            Me.colEntity.Text = "Entity Name"
            Me.colEntity.Width.Absolute = 300
            '
            'colEntityID
            '
            Me.colEntityID.DisplayIndex = 2
            Me.colEntityID.Name = "colEntityID"
            Me.colEntityID.SortingEnabled = False
            Me.colEntityID.Text = "Entity ID"
            Me.colEntityID.Width.Absolute = 100
            '
            'colEntityType
            '
            Me.colEntityType.DisplayIndex = 3
            Me.colEntityType.Name = "colEntityType"
            Me.colEntityType.SortingEnabled = False
            Me.colEntityType.Text = "Entity Type"
            Me.colEntityType.Width.Absolute = 100
            '
            'colStandingRaw
            '
            Me.colStandingRaw.DisplayIndex = 4
            Me.colStandingRaw.Name = "colStandingRaw"
            Me.colStandingRaw.SortingEnabled = False
            Me.colStandingRaw.Text = "Raw Standing"
            Me.colStandingRaw.Width.Absolute = 100
            '
            'colStandingActual
            '
            Me.colStandingActual.DisplayIndex = 5
            Me.colStandingActual.Name = "colStandingActual"
            Me.colStandingActual.SortingEnabled = False
            Me.colStandingActual.Text = "Actual Standing"
            Me.colStandingActual.Width.Absolute = 100
            '
            'NodeConnector1
            '
            Me.NodeConnector1.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle3
            '
            Me.ElementStyle3.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle3.Name = "ElementStyle3"
            Me.ElementStyle3.TextColor = System.Drawing.SystemColors.ControlText
            '
            'tiStandings
            '
            Me.tiStandings.AttachedControl = Me.tcpStandings
            Me.tiStandings.Name = "tiStandings"
            Me.tiStandings.Text = "Standings"
            '
            'tcpSkillQueue
            '
            Me.tcpSkillQueue.Controls.Add(Me.sqcEveQueue)
            Me.tcpSkillQueue.DisabledBackColor = System.Drawing.Color.Empty
            Me.tcpSkillQueue.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcpSkillQueue.Location = New System.Drawing.Point(0, 23)
            Me.tcpSkillQueue.Name = "tcpSkillQueue"
            Me.tcpSkillQueue.Padding = New System.Windows.Forms.Padding(1)
            Me.tcpSkillQueue.Size = New System.Drawing.Size(933, 684)
            Me.tcpSkillQueue.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.tcpSkillQueue.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.tcpSkillQueue.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.tcpSkillQueue.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.tcpSkillQueue.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.tcpSkillQueue.Style.GradientAngle = 90
            Me.tcpSkillQueue.TabIndex = 3
            Me.tcpSkillQueue.TabItem = Me.tiSkillQueue
            '
            'sqcEveQueue
            '
            Me.sqcEveQueue.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sqcEveQueue.Location = New System.Drawing.Point(1, 1)
            Me.sqcEveQueue.Name = "sqcEveQueue"
            Me.sqcEveQueue.PilotName = ""
            Me.sqcEveQueue.Size = New System.Drawing.Size(931, 682)
            Me.sqcEveQueue.TabIndex = 0
            '
            'tiSkillQueue
            '
            Me.tiSkillQueue.AttachedControl = Me.tcpSkillQueue
            Me.tiSkillQueue.Name = "tiSkillQueue"
            Me.tiSkillQueue.Text = "Eve Skill Queue"
            '
            'pnlInfo
            '
            Me.pnlInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.pnlInfo.AutoScroll = True
            Me.pnlInfo.Controls.Add(Me.grpPilotInfo)
            Me.pnlInfo.Controls.Add(Me.grpTraining)
            Me.pnlInfo.Controls.Add(Me.grpAttributes)
            Me.pnlInfo.Controls.Add(Me.grpAPI)
            Me.pnlInfo.Controls.Add(Me.grpAccount)
            Me.pnlInfo.Location = New System.Drawing.Point(12, 31)
            Me.pnlInfo.Name = "pnlInfo"
            Me.pnlInfo.Size = New System.Drawing.Size(330, 841)
            Me.pnlInfo.TabIndex = 53
            '
            'grpAccount
            '
            Me.grpAccount.CanvasColor = System.Drawing.SystemColors.Control
            Me.grpAccount.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.grpAccount.Controls.Add(Me.lblAccountLogins)
            Me.grpAccount.Controls.Add(Me.lblAccountExpiry)
            Me.grpAccount.Controls.Add(Me.LabelX2)
            Me.grpAccount.DisabledBackColor = System.Drawing.Color.Empty
            Me.grpAccount.IsShadowEnabled = True
            Me.grpAccount.Location = New System.Drawing.Point(3, 563)
            Me.grpAccount.Name = "grpAccount"
            Me.grpAccount.Size = New System.Drawing.Size(304, 80)
            '
            '
            '
            Me.grpAccount.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.grpAccount.Style.BackColorGradientAngle = 90
            Me.grpAccount.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.grpAccount.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpAccount.Style.BorderBottomWidth = 1
            Me.grpAccount.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.grpAccount.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpAccount.Style.BorderLeftWidth = 1
            Me.grpAccount.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpAccount.Style.BorderRightWidth = 1
            Me.grpAccount.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.grpAccount.Style.BorderTopWidth = 1
            Me.grpAccount.Style.CornerDiameter = 4
            Me.grpAccount.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.grpAccount.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.grpAccount.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.grpAccount.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.grpAccount.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.grpAccount.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.grpAccount.TabIndex = 50
            '
            'lblAccountLogins
            '
            Me.lblAccountLogins.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblAccountLogins.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblAccountLogins.Location = New System.Drawing.Point(11, 52)
            Me.lblAccountLogins.Name = "lblAccountLogins"
            Me.lblAccountLogins.Size = New System.Drawing.Size(278, 19)
            Me.lblAccountLogins.TabIndex = 4
            Me.lblAccountLogins.Text = "Login Count:"
            '
            'lblAccountExpiry
            '
            Me.lblAccountExpiry.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblAccountExpiry.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblAccountExpiry.Location = New System.Drawing.Point(11, 32)
            Me.lblAccountExpiry.Name = "lblAccountExpiry"
            Me.lblAccountExpiry.Size = New System.Drawing.Size(278, 19)
            Me.lblAccountExpiry.TabIndex = 3
            Me.lblAccountExpiry.Text = "Expiry:"
            '
            'LabelX2
            '
            Me.LabelX2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LabelX2.BackColor = System.Drawing.Color.DimGray
            '
            '
            '
            Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX2.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.LabelX2.Image = Global.EveHQ.My.Resources.Resources.QueryAPI32
            Me.LabelX2.Location = New System.Drawing.Point(3, 3)
            Me.LabelX2.Name = "LabelX2"
            Me.LabelX2.Size = New System.Drawing.Size(292, 23)
            Me.LabelX2.TabIndex = 0
            Me.LabelX2.Text = "Account Information"
            '
            'pnlMain
            '
            Me.pnlMain.CanvasColor = System.Drawing.SystemColors.Control
            Me.pnlMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.pnlMain.Controls.Add(Me.lblPilot)
            Me.pnlMain.Controls.Add(Me.chkGroupSkills)
            Me.pnlMain.Controls.Add(Me.picRace)
            Me.pnlMain.Controls.Add(Me.picBlood)
            Me.pnlMain.Controls.Add(Me.pnlInfo)
            Me.pnlMain.Controls.Add(Me.cboPilots)
            Me.pnlMain.Controls.Add(Me.tabPilotInfo)
            Me.pnlMain.Controls.Add(Me.picPilot)
            Me.pnlMain.DisabledBackColor = System.Drawing.Color.Empty
            Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlMain.Location = New System.Drawing.Point(0, 0)
            Me.pnlMain.Name = "pnlMain"
            Me.pnlMain.Size = New System.Drawing.Size(1284, 878)
            Me.pnlMain.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.pnlMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.pnlMain.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.pnlMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.pnlMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.pnlMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.pnlMain.Style.GradientAngle = 90
            Me.pnlMain.TabIndex = 54
            '
            'FrmPilot
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1284, 878)
            Me.Controls.Add(Me.pnlMain)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmPilot"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "EveHQ Pilot Data"
            Me.ctxSkills.ResumeLayout(False)
            Me.ctxPic.ResumeLayout(False)
            Me.ctxCerts.ResumeLayout(False)
            Me.ctxStandings.ResumeLayout(False)
            Me.grpAttributes.ResumeLayout(False)
            Me.grpTraining.ResumeLayout(False)
            Me.grpPilotInfo.ResumeLayout(False)
            Me.grpAPI.ResumeLayout(False)
            CType(Me.picPilot, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabPilotInfo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPilotInfo.ResumeLayout(False)
            Me.tcpCerts.ResumeLayout(False)
            CType(Me.adtCerts, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tcpSkills.ResumeLayout(False)
            CType(Me.adtSkills, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tcpStandings.ResumeLayout(False)
            Me.tcpStandings.PerformLayout()
            CType(Me.adtStandings, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tcpSkillQueue.ResumeLayout(False)
            Me.pnlInfo.ResumeLayout(False)
            Me.grpAccount.ResumeLayout(False)
            Me.pnlMain.ResumeLayout(False)
            Me.pnlMain.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents ctxSkills As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents mnuSkillName As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuViewDetails As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ctxPic As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents mnuCtxPicGetPortraitFromServer As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuCtxPicGetPortraitFromLocal As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuSavePortrait As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents chkGroupSkills As System.Windows.Forms.CheckBox
        Friend WithEvents ctxCerts As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents mnuCertName As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuViewCertDetails As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblPilot As System.Windows.Forms.Label
        Friend WithEvents cboPilots As System.Windows.Forms.ComboBox
        Friend WithEvents lblTypeFilter As System.Windows.Forms.Label
        Friend WithEvents cboFilter As System.Windows.Forms.ComboBox
        Friend WithEvents btExportStandings As System.Windows.Forms.Button
        Friend WithEvents btnGetStandings As System.Windows.Forms.Button
        Friend WithEvents ctxStandings As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents mnuExtrapolateStandings As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents picRace As DevComponents.DotNetBar.Controls.ReflectionImage
        Friend WithEvents picBlood As DevComponents.DotNetBar.Controls.ReflectionImage
        Friend WithEvents grpAttributes As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents lblAttributes As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblCharisma As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblCharismaTotal As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblCharismaDetail As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblWillpowerTotal As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblWillpowerDetail As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblWillpower As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblPerceptionTotal As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblPerceptionDetail As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblPerception As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblMemoryTotal As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblMemoryDetail As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblMemory As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblIntelligenceTotal As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblIntelligenceDetail As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblIntelligence As DevComponents.DotNetBar.LabelX
        Friend WithEvents btnEditManualImplants As DevComponents.DotNetBar.ButtonX
        Friend WithEvents chkManImplants As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents grpTraining As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents lblSkillTraining As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblTrainingSkill As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblTrainingRate As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblTrainingEnds As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblTrainingTime As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblPilotName As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblPilotIDLbl As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblPilotCorpLbl As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblPilotIskLbl As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblPilotSPLbl As DevComponents.DotNetBar.LabelX
        Friend WithEvents grpPilotInfo As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents lblPilotSP As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblPilotIsk As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblPilotCorp As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblPilotID As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
        Friend WithEvents grpAPI As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents lblCharacterXML As DevComponents.DotNetBar.LabelX
        Friend WithEvents btnUpdateAPI As DevComponents.DotNetBar.ButtonX
        Friend WithEvents picPilot As System.Windows.Forms.PictureBox
        Friend WithEvents tabPilotInfo As DevComponents.DotNetBar.TabControl
        Friend WithEvents tcpSkills As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tiSkills As DevComponents.DotNetBar.TabItem
        Friend WithEvents tcpCerts As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tsCerts As DevComponents.DotNetBar.TabItem
        Friend WithEvents tcpSkillQueue As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tiSkillQueue As DevComponents.DotNetBar.TabItem
        Friend WithEvents tcpStandings As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tiStandings As DevComponents.DotNetBar.TabItem
        Friend WithEvents sqcEveQueue As SkillQueueControl
        Friend WithEvents pnlInfo As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents grpAccount As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblAccountExpiry As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblAccountLogins As DevComponents.DotNetBar.LabelX
        Friend WithEvents pnlMain As DevComponents.DotNetBar.PanelEx
        Friend WithEvents adtSkills As DevComponents.AdvTree.AdvTree
        Friend WithEvents colSkill As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colRank As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colLevel As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colDone As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colSP As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colTime As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents Skill As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents SkillGroup As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents adtCerts As DevComponents.AdvTree.AdvTree
        Friend WithEvents colCertName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colCertGrd As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents ElementStyle2 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents adtStandings As DevComponents.AdvTree.AdvTree
        Friend WithEvents colEntity As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colEntityID As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colEntityType As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colStandingRaw As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colStandingActual As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle3 As DevComponents.DotNetBar.ElementStyle

        Private WithEvents lblPilotAccountLbl As DevComponents.DotNetBar.LabelX
        Private WithEvents lblPilotAccount As DevComponents.DotNetBar.LabelX
    End Class
End Namespace