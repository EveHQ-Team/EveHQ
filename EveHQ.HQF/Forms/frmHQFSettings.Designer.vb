Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class FrmHQFSettings
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
            Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("General")
            Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Attribute Columns")
            Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Calculation Variables")
            Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Damage Profiles")
            Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Defence Profiles")
            Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Slot Layout")
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHQFSettings))
            Me.gbGeneral = New System.Windows.Forms.GroupBox()
            Me.chkUseLastPilot = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.chkAutoUpdateHQFSkills = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.chkRestoreLastSession = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.chkShowPerformance = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.cboStartupPilot = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblDefaultPilot = New System.Windows.Forms.Label()
            Me.fbd1 = New System.Windows.Forms.FolderBrowserDialog()
            Me.ofd1 = New System.Windows.Forms.OpenFileDialog()
            Me.tvwSettings = New System.Windows.Forms.TreeView()
            Me.cd1 = New System.Windows.Forms.ColorDialog()
            Me.lblHiSlotColour = New System.Windows.Forms.Label()
            Me.lblMidSlotColour = New System.Windows.Forms.Label()
            Me.pbHiSlotColour = New System.Windows.Forms.PictureBox()
            Me.pbMidSlotColour = New System.Windows.Forms.PictureBox()
            Me.lblLowSlotColour = New System.Windows.Forms.Label()
            Me.pbLowSlotColour = New System.Windows.Forms.PictureBox()
            Me.lblRigSlotColour = New System.Windows.Forms.Label()
            Me.pbRigSlotColour = New System.Windows.Forms.PictureBox()
            Me.gbSlotFormat = New System.Windows.Forms.GroupBox()
            Me.chkAutoResizeColumns = New System.Windows.Forms.CheckBox()
            Me.lblSubSlotColour = New System.Windows.Forms.Label()
            Me.pbSubSlotColour = New System.Windows.Forms.PictureBox()
            Me.lblServiceModSlotColour = New System.Windows.Forms.Label()
            Me.pbServiceModSlotColour = New System.Windows.Forms.PictureBox()
            Me.btnMoveDown = New System.Windows.Forms.Button()
            Me.btnMoveUp = New System.Windows.Forms.Button()
            Me.lvwColumns = New System.Windows.Forms.ListView()
            Me.colSlotColumns = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.lblSlotColumns = New System.Windows.Forms.Label()
            Me.gbConstants = New System.Windows.Forms.GroupBox()
            Me.chkAmmoLoadTime = New System.Windows.Forms.CheckBox()
            Me.chkCapBoosterReloadTime = New System.Windows.Forms.CheckBox()
            Me.lblCapRechargeUnit = New System.Windows.Forms.Label()
            Me.lblShieldRechargeUnit = New System.Windows.Forms.Label()
            Me.lblMissileRangeUnit = New System.Windows.Forms.Label()
            Me.nudMissileRange = New System.Windows.Forms.NumericUpDown()
            Me.lblMissileRange = New System.Windows.Forms.Label()
            Me.nudShieldRecharge = New System.Windows.Forms.NumericUpDown()
            Me.lblShieldRecharge = New System.Windows.Forms.Label()
            Me.nudCapRecharge = New System.Windows.Forms.NumericUpDown()
            Me.lblCapRecharge = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.btnClose = New DevComponents.DotNetBar.ButtonX()
            Me.pnlSettings = New DevComponents.DotNetBar.PanelEx()
            Me.gbDefenceProfiles = New System.Windows.Forms.GroupBox()
            Me.gpDefenceProfile = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.pbHullDefence = New System.Windows.Forms.PictureBox()
            Me.pbArmorDefence = New System.Windows.Forms.PictureBox()
            Me.pbShieldDefence = New System.Windows.Forms.PictureBox()
            Me.lblDefHEM = New System.Windows.Forms.Label()
            Me.lblDefHEx = New System.Windows.Forms.Label()
            Me.lblDefHKi = New System.Windows.Forms.Label()
            Me.lblDefHTh = New System.Windows.Forms.Label()
            Me.lblDefAEM = New System.Windows.Forms.Label()
            Me.lblDefAEx = New System.Windows.Forms.Label()
            Me.lblDefAKi = New System.Windows.Forms.Label()
            Me.lblDefATh = New System.Windows.Forms.Label()
            Me.lblDefProfileNameLbl = New System.Windows.Forms.Label()
            Me.lblDefProfiletypeLbl = New System.Windows.Forms.Label()
            Me.lblDefTypes = New System.Windows.Forms.Label()
            Me.lblDefEM = New System.Windows.Forms.Label()
            Me.lblDefSEM = New System.Windows.Forms.Label()
            Me.lblDefEx = New System.Windows.Forms.Label()
            Me.lblDefSEx = New System.Windows.Forms.Label()
            Me.lblDefProfileType = New System.Windows.Forms.Label()
            Me.lblDefProfileName = New System.Windows.Forms.Label()
            Me.lblDefKi = New System.Windows.Forms.Label()
            Me.lblDefSKi = New System.Windows.Forms.Label()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.lblDefTh = New System.Windows.Forms.Label()
            Me.lblDefSTh = New System.Windows.Forms.Label()
            Me.btnEditDefenceProfile = New DevComponents.DotNetBar.ButtonX()
            Me.btnDeleteDefenceProfile = New DevComponents.DotNetBar.ButtonX()
            Me.btnResetDefenceProfiles = New DevComponents.DotNetBar.ButtonX()
            Me.btnAddDefenceProfile = New DevComponents.DotNetBar.ButtonX()
            Me.lvwDefenceProfiles = New DevComponents.DotNetBar.Controls.ListViewEx()
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.gbAttributeColumns = New System.Windows.Forms.GroupBox()
            Me.btnClearAttributes = New DevComponents.DotNetBar.ButtonX()
            Me.btnRemoveAttribute = New DevComponents.DotNetBar.ButtonX()
            Me.adtAttributeColumns = New DevComponents.AdvTree.AdvTree()
            Me.colAttributeID = New DevComponents.AdvTree.ColumnHeader()
            Me.colAttributeName = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me.gbDamageProfiles = New System.Windows.Forms.GroupBox()
            Me.gpProfile = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.lblNPCName = New System.Windows.Forms.Label()
            Me.lblProfileNameLbl = New System.Windows.Forms.Label()
            Me.lblNPCNameLbl = New System.Windows.Forms.Label()
            Me.lblProfileTypeLbl = New System.Windows.Forms.Label()
            Me.lblPilotName = New System.Windows.Forms.Label()
            Me.lblDamageTypes = New System.Windows.Forms.Label()
            Me.lblPilotNameLbl = New System.Windows.Forms.Label()
            Me.lblEMDamage = New System.Windows.Forms.Label()
            Me.lblFittingName = New System.Windows.Forms.Label()
            Me.lblEMDamageAmount = New System.Windows.Forms.Label()
            Me.lblFittingNameLbl = New System.Windows.Forms.Label()
            Me.lblEMDamagePercentage = New System.Windows.Forms.Label()
            Me.lblDPS = New System.Windows.Forms.Label()
            Me.lblEXDamage = New System.Windows.Forms.Label()
            Me.lblDPSLbl = New System.Windows.Forms.Label()
            Me.lblEXDamageAmount = New System.Windows.Forms.Label()
            Me.lblProfileType = New System.Windows.Forms.Label()
            Me.lblEXDamagePercentage = New System.Windows.Forms.Label()
            Me.lblProfileName = New System.Windows.Forms.Label()
            Me.lblKIDamage = New System.Windows.Forms.Label()
            Me.lblTotalDamagePercentage = New System.Windows.Forms.Label()
            Me.lblKIDamageAmount = New System.Windows.Forms.Label()
            Me.lblTotalDamageAmount = New System.Windows.Forms.Label()
            Me.lblKIDamagePercentage = New System.Windows.Forms.Label()
            Me.line2 = New System.Windows.Forms.Label()
            Me.lblTHDamage = New System.Windows.Forms.Label()
            Me.lblTHDamagePercentage = New System.Windows.Forms.Label()
            Me.lblTHDamageAmount = New System.Windows.Forms.Label()
            Me.btnEditProfile = New DevComponents.DotNetBar.ButtonX()
            Me.btnDeleteProfile = New DevComponents.DotNetBar.ButtonX()
            Me.btnResetProfiles = New DevComponents.DotNetBar.ButtonX()
            Me.btnAddProfile = New DevComponents.DotNetBar.ButtonX()
            Me.lvwProfiles = New DevComponents.DotNetBar.Controls.ListViewEx()
            Me.colProfileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colProfileType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.gbGeneral.SuspendLayout()
            CType(Me.pbHiSlotColour, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbMidSlotColour, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbLowSlotColour, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbRigSlotColour, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbSlotFormat.SuspendLayout()
            CType(Me.pbSubSlotColour, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbServiceModSlotColour, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbConstants.SuspendLayout()
            CType(Me.nudMissileRange, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudShieldRecharge, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCapRecharge, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlSettings.SuspendLayout()
            Me.gbDefenceProfiles.SuspendLayout()
            Me.gpDefenceProfile.SuspendLayout()
            CType(Me.pbHullDefence, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbArmorDefence, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbShieldDefence, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbAttributeColumns.SuspendLayout()
            CType(Me.adtAttributeColumns, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbDamageProfiles.SuspendLayout()
            Me.gpProfile.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbGeneral
            '
            Me.gbGeneral.Controls.Add(Me.chkUseLastPilot)
            Me.gbGeneral.Controls.Add(Me.chkAutoUpdateHQFSkills)
            Me.gbGeneral.Controls.Add(Me.chkRestoreLastSession)
            Me.gbGeneral.Controls.Add(Me.chkShowPerformance)
            Me.gbGeneral.Controls.Add(Me.cboStartupPilot)
            Me.gbGeneral.Controls.Add(Me.lblDefaultPilot)
            Me.gbGeneral.Location = New System.Drawing.Point(228, 352)
            Me.gbGeneral.Name = "gbGeneral"
            Me.gbGeneral.Size = New System.Drawing.Size(214, 50)
            Me.gbGeneral.TabIndex = 1
            Me.gbGeneral.TabStop = False
            Me.gbGeneral.Text = "General Settings"
            Me.gbGeneral.Visible = False
            '
            'chkUseLastPilot
            '
            Me.chkUseLastPilot.AutoSize = True
            '
            '
            '
            Me.chkUseLastPilot.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkUseLastPilot.Location = New System.Drawing.Point(25, 131)
            Me.chkUseLastPilot.Name = "chkUseLastPilot"
            Me.chkUseLastPilot.Size = New System.Drawing.Size(204, 16)
            Me.chkUseLastPilot.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkUseLastPilot.TabIndex = 17
            Me.chkUseLastPilot.Text = "Start With Last Used Pilot For Fittings"
            '
            'chkAutoUpdateHQFSkills
            '
            Me.chkAutoUpdateHQFSkills.AutoSize = True
            '
            '
            '
            Me.chkAutoUpdateHQFSkills.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkAutoUpdateHQFSkills.Location = New System.Drawing.Point(25, 109)
            Me.chkAutoUpdateHQFSkills.Name = "chkAutoUpdateHQFSkills"
            Me.chkAutoUpdateHQFSkills.Size = New System.Drawing.Size(252, 16)
            Me.chkAutoUpdateHQFSkills.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkAutoUpdateHQFSkills.TabIndex = 16
            Me.chkAutoUpdateHQFSkills.Text = "Update HQF Skills to Actual When Starting HQF"
            '
            'chkRestoreLastSession
            '
            Me.chkRestoreLastSession.AutoSize = True
            '
            '
            '
            Me.chkRestoreLastSession.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkRestoreLastSession.Location = New System.Drawing.Point(25, 87)
            Me.chkRestoreLastSession.Name = "chkRestoreLastSession"
            Me.chkRestoreLastSession.Size = New System.Drawing.Size(269, 16)
            Me.chkRestoreLastSession.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkRestoreLastSession.TabIndex = 15
            Me.chkRestoreLastSession.Text = "Restore Previous Open Fittings When Starting HQF"
            '
            'chkShowPerformance
            '
            Me.chkShowPerformance.AutoSize = True
            '
            '
            '
            Me.chkShowPerformance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkShowPerformance.Location = New System.Drawing.Point(25, 446)
            Me.chkShowPerformance.Name = "chkShowPerformance"
            Me.chkShowPerformance.Size = New System.Drawing.Size(248, 16)
            Me.chkShowPerformance.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkShowPerformance.TabIndex = 14
            Me.chkShowPerformance.Text = "Show Performance Data (current session only)"
            '
            'cboStartupPilot
            '
            Me.cboStartupPilot.DisplayMember = "Text"
            Me.cboStartupPilot.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboStartupPilot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cboStartupPilot.FormattingEnabled = True
            Me.cboStartupPilot.ItemHeight = 15
            Me.cboStartupPilot.Location = New System.Drawing.Point(152, 48)
            Me.cboStartupPilot.Name = "cboStartupPilot"
            Me.cboStartupPilot.Size = New System.Drawing.Size(168, 21)
            Me.cboStartupPilot.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboStartupPilot.TabIndex = 13
            '
            'lblDefaultPilot
            '
            Me.lblDefaultPilot.AutoSize = True
            Me.lblDefaultPilot.Location = New System.Drawing.Point(22, 52)
            Me.lblDefaultPilot.Name = "lblDefaultPilot"
            Me.lblDefaultPilot.Size = New System.Drawing.Size(124, 13)
            Me.lblDefaultPilot.TabIndex = 6
            Me.lblDefaultPilot.Text = "Default Pilot for Fittings:"
            '
            'ofd1
            '
            Me.ofd1.FileName = "OpenFileDialog1"
            '
            'tvwSettings
            '
            Me.tvwSettings.Location = New System.Drawing.Point(12, 10)
            Me.tvwSettings.Name = "tvwSettings"
            TreeNode1.Name = "nodeGeneral"
            TreeNode1.Text = "General"
            TreeNode2.Name = "nodeAttributeColumns"
            TreeNode2.Text = "Attribute Columns"
            TreeNode3.Name = "nodeConstants"
            TreeNode3.Text = "Calculation Variables"
            TreeNode4.Name = "nodeDamageProfiles"
            TreeNode4.Text = "Damage Profiles"
            TreeNode5.Name = "nodeDefenceProfiles"
            TreeNode5.Text = "Defence Profiles"
            TreeNode6.Name = "nodeSlotFormat"
            TreeNode6.Text = "Slot Layout"
            Me.tvwSettings.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6})
            Me.tvwSettings.Size = New System.Drawing.Size(176, 473)
            Me.tvwSettings.TabIndex = 27
            '
            'lblHiSlotColour
            '
            Me.lblHiSlotColour.AutoSize = True
            Me.lblHiSlotColour.Location = New System.Drawing.Point(284, 101)
            Me.lblHiSlotColour.Name = "lblHiSlotColour"
            Me.lblHiSlotColour.Size = New System.Drawing.Size(71, 13)
            Me.lblHiSlotColour.TabIndex = 20
            Me.lblHiSlotColour.Text = "Hi Slot Colour"
            '
            'lblMidSlotColour
            '
            Me.lblMidSlotColour.AutoSize = True
            Me.lblMidSlotColour.Location = New System.Drawing.Point(284, 131)
            Me.lblMidSlotColour.Name = "lblMidSlotColour"
            Me.lblMidSlotColour.Size = New System.Drawing.Size(78, 13)
            Me.lblMidSlotColour.TabIndex = 21
            Me.lblMidSlotColour.Text = "Mid Slot Colour"
            '
            'pbHiSlotColour
            '
            Me.pbHiSlotColour.BackColor = System.Drawing.Color.LightSteelBlue
            Me.pbHiSlotColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pbHiSlotColour.Location = New System.Drawing.Point(411, 94)
            Me.pbHiSlotColour.Name = "pbHiSlotColour"
            Me.pbHiSlotColour.Size = New System.Drawing.Size(24, 24)
            Me.pbHiSlotColour.TabIndex = 22
            Me.pbHiSlotColour.TabStop = False
            '
            'pbMidSlotColour
            '
            Me.pbMidSlotColour.BackColor = System.Drawing.Color.Plum
            Me.pbMidSlotColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pbMidSlotColour.Location = New System.Drawing.Point(411, 124)
            Me.pbMidSlotColour.Name = "pbMidSlotColour"
            Me.pbMidSlotColour.Size = New System.Drawing.Size(24, 24)
            Me.pbMidSlotColour.TabIndex = 23
            Me.pbMidSlotColour.TabStop = False
            '
            'lblLowSlotColour
            '
            Me.lblLowSlotColour.AutoSize = True
            Me.lblLowSlotColour.Location = New System.Drawing.Point(284, 161)
            Me.lblLowSlotColour.Name = "lblLowSlotColour"
            Me.lblLowSlotColour.Size = New System.Drawing.Size(81, 13)
            Me.lblLowSlotColour.TabIndex = 24
            Me.lblLowSlotColour.Text = "Low Slot Colour"
            '
            'pbLowSlotColour
            '
            Me.pbLowSlotColour.BackColor = System.Drawing.Color.Gold
            Me.pbLowSlotColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pbLowSlotColour.Location = New System.Drawing.Point(411, 154)
            Me.pbLowSlotColour.Name = "pbLowSlotColour"
            Me.pbLowSlotColour.Size = New System.Drawing.Size(24, 24)
            Me.pbLowSlotColour.TabIndex = 25
            Me.pbLowSlotColour.TabStop = False
            '
            'lblRigSlotColour
            '
            Me.lblRigSlotColour.AutoSize = True
            Me.lblRigSlotColour.Location = New System.Drawing.Point(284, 191)
            Me.lblRigSlotColour.Name = "lblRigSlotColour"
            Me.lblRigSlotColour.Size = New System.Drawing.Size(77, 13)
            Me.lblRigSlotColour.TabIndex = 26
            Me.lblRigSlotColour.Text = "Rig Slot Colour"
            '
            'pbRigSlotColour
            '
            Me.pbRigSlotColour.BackColor = System.Drawing.Color.Red
            Me.pbRigSlotColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pbRigSlotColour.Location = New System.Drawing.Point(411, 184)
            Me.pbRigSlotColour.Name = "pbRigSlotColour"
            Me.pbRigSlotColour.Size = New System.Drawing.Size(24, 24)
            Me.pbRigSlotColour.TabIndex = 27
            Me.pbRigSlotColour.TabStop = False
            '
            'gbSlotFormat
            '
            Me.gbSlotFormat.Controls.Add(Me.chkAutoResizeColumns)
            Me.gbSlotFormat.Controls.Add(Me.lblSubSlotColour)
            Me.gbSlotFormat.Controls.Add(Me.pbSubSlotColour)
            Me.gbSlotFormat.Controls.Add(Me.lblServiceModSlotColour)
            Me.gbSlotFormat.Controls.Add(Me.pbServiceModSlotColour)
            Me.gbSlotFormat.Controls.Add(Me.btnMoveDown)
            Me.gbSlotFormat.Controls.Add(Me.btnMoveUp)
            Me.gbSlotFormat.Controls.Add(Me.lvwColumns)
            Me.gbSlotFormat.Controls.Add(Me.lblSlotColumns)
            Me.gbSlotFormat.Controls.Add(Me.pbRigSlotColour)
            Me.gbSlotFormat.Controls.Add(Me.lblRigSlotColour)
            Me.gbSlotFormat.Controls.Add(Me.pbLowSlotColour)
            Me.gbSlotFormat.Controls.Add(Me.lblLowSlotColour)
            Me.gbSlotFormat.Controls.Add(Me.pbMidSlotColour)
            Me.gbSlotFormat.Controls.Add(Me.pbHiSlotColour)
            Me.gbSlotFormat.Controls.Add(Me.lblMidSlotColour)
            Me.gbSlotFormat.Controls.Add(Me.lblHiSlotColour)
            Me.gbSlotFormat.Location = New System.Drawing.Point(194, 10)
            Me.gbSlotFormat.Name = "gbSlotFormat"
            Me.gbSlotFormat.Size = New System.Drawing.Size(214, 68)
            Me.gbSlotFormat.TabIndex = 3
            Me.gbSlotFormat.TabStop = False
            Me.gbSlotFormat.Text = "Slot Layout"
            Me.gbSlotFormat.Visible = False
            '
            'chkAutoResizeColumns
            '
            Me.chkAutoResizeColumns.AutoSize = True
            Me.chkAutoResizeColumns.Location = New System.Drawing.Point(287, 269)
            Me.chkAutoResizeColumns.Name = "chkAutoResizeColumns"
            Me.chkAutoResizeColumns.Size = New System.Drawing.Size(167, 17)
            Me.chkAutoResizeColumns.TabIndex = 34
            Me.chkAutoResizeColumns.Text = "Automatically Resize Columns"
            Me.chkAutoResizeColumns.UseVisualStyleBackColor = True
            '
            'lblSubSlotColour
            '
            Me.lblSubSlotColour.AutoSize = True
            Me.lblSubSlotColour.Location = New System.Drawing.Point(284, 221)
            Me.lblSubSlotColour.Name = "lblSubSlotColour"
            Me.lblSubSlotColour.Size = New System.Drawing.Size(114, 13)
            Me.lblSubSlotColour.TabIndex = 33
            Me.lblSubSlotColour.Text = "Subsystem Slot Colour"
            '
            'pbSubSlotColour
            '
            Me.pbSubSlotColour.BackColor = System.Drawing.Color.DarkSeaGreen
            Me.pbSubSlotColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pbSubSlotColour.Location = New System.Drawing.Point(411, 214)
            Me.pbSubSlotColour.Name = "pbSubSlotColour"
            Me.pbSubSlotColour.Size = New System.Drawing.Size(24, 24)
            Me.pbSubSlotColour.TabIndex = 32
            Me.pbSubSlotColour.TabStop = False
            '
            'lblServiceModSlotColour
            '
            Me.lblServiceModSlotColour.AutoSize = True
            Me.lblServiceModSlotColour.Location = New System.Drawing.Point(284, 221)
            Me.lblServiceModSlotColour.Name = "lblServiceModSlotColour"
            Me.lblServiceModSlotColour.Size = New System.Drawing.Size(114, 13)
            Me.lblServiceModSlotColour.TabIndex = 33
            Me.lblServiceModSlotColour.Text = "Service Module Slot Colour"
            '
            'pbServiceModSlotColour
            '
            Me.pbServiceModSlotColour.BackColor = System.Drawing.Color.MediumAquamarine
            Me.pbServiceModSlotColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pbServiceModSlotColour.Location = New System.Drawing.Point(411, 214)
            Me.pbServiceModSlotColour.Name = "pbServiceModSlotColour"
            Me.pbServiceModSlotColour.Size = New System.Drawing.Size(24, 24)
            Me.pbServiceModSlotColour.TabIndex = 32
            Me.pbServiceModSlotColour.TabStop = False
            '
            'btnMoveDown
            '
            Me.btnMoveDown.Location = New System.Drawing.Point(104, 384)
            Me.btnMoveDown.Name = "btnMoveDown"
            Me.btnMoveDown.Size = New System.Drawing.Size(80, 23)
            Me.btnMoveDown.TabIndex = 31
            Me.btnMoveDown.Text = "Move Down"
            Me.btnMoveDown.UseVisualStyleBackColor = True
            '
            'btnMoveUp
            '
            Me.btnMoveUp.Location = New System.Drawing.Point(18, 384)
            Me.btnMoveUp.Name = "btnMoveUp"
            Me.btnMoveUp.Size = New System.Drawing.Size(80, 23)
            Me.btnMoveUp.TabIndex = 30
            Me.btnMoveUp.Text = "Move Up"
            Me.btnMoveUp.UseVisualStyleBackColor = True
            '
            'lvwColumns
            '
            Me.lvwColumns.CheckBoxes = True
            Me.lvwColumns.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colSlotColumns})
            Me.lvwColumns.FullRowSelect = True
            Me.lvwColumns.HideSelection = False
            Me.lvwColumns.Location = New System.Drawing.Point(18, 54)
            Me.lvwColumns.Name = "lvwColumns"
            Me.lvwColumns.Size = New System.Drawing.Size(222, 324)
            Me.lvwColumns.TabIndex = 29
            Me.lvwColumns.UseCompatibleStateImageBehavior = False
            Me.lvwColumns.View = System.Windows.Forms.View.Details
            '
            'colSlotColumns
            '
            Me.colSlotColumns.Text = "Slot Columns"
            Me.colSlotColumns.Width = 200
            '
            'lblSlotColumns
            '
            Me.lblSlotColumns.AutoSize = True
            Me.lblSlotColumns.Location = New System.Drawing.Point(15, 38)
            Me.lblSlotColumns.Name = "lblSlotColumns"
            Me.lblSlotColumns.Size = New System.Drawing.Size(113, 13)
            Me.lblSlotColumns.TabIndex = 28
            Me.lblSlotColumns.Text = "Slot Column Selection:"
            '
            'gbConstants
            '
            Me.gbConstants.Controls.Add(Me.chkAmmoLoadTime)
            Me.gbConstants.Controls.Add(Me.chkCapBoosterReloadTime)
            Me.gbConstants.Controls.Add(Me.lblCapRechargeUnit)
            Me.gbConstants.Controls.Add(Me.lblShieldRechargeUnit)
            Me.gbConstants.Controls.Add(Me.lblMissileRangeUnit)
            Me.gbConstants.Controls.Add(Me.nudMissileRange)
            Me.gbConstants.Controls.Add(Me.lblMissileRange)
            Me.gbConstants.Controls.Add(Me.nudShieldRecharge)
            Me.gbConstants.Controls.Add(Me.lblShieldRecharge)
            Me.gbConstants.Controls.Add(Me.nudCapRecharge)
            Me.gbConstants.Controls.Add(Me.lblCapRecharge)
            Me.gbConstants.Location = New System.Drawing.Point(313, 131)
            Me.gbConstants.Name = "gbConstants"
            Me.gbConstants.Size = New System.Drawing.Size(166, 50)
            Me.gbConstants.TabIndex = 30
            Me.gbConstants.TabStop = False
            Me.gbConstants.Text = "Calculation Variables"
            Me.gbConstants.Visible = False
            '
            'chkAmmoLoadTime
            '
            Me.chkAmmoLoadTime.AutoSize = True
            Me.chkAmmoLoadTime.Location = New System.Drawing.Point(18, 178)
            Me.chkAmmoLoadTime.Name = "chkAmmoLoadTime"
            Me.chkAmmoLoadTime.Size = New System.Drawing.Size(247, 17)
            Me.chkAmmoLoadTime.TabIndex = 10
            Me.chkAmmoLoadTime.Text = "Include Ammo Reload Time in DPS Calculations"
            Me.chkAmmoLoadTime.UseVisualStyleBackColor = True
            '
            'chkCapBoosterReloadTime
            '
            Me.chkCapBoosterReloadTime.AutoSize = True
            Me.chkCapBoosterReloadTime.Location = New System.Drawing.Point(18, 155)
            Me.chkCapBoosterReloadTime.Name = "chkCapBoosterReloadTime"
            Me.chkCapBoosterReloadTime.Size = New System.Drawing.Size(304, 17)
            Me.chkCapBoosterReloadTime.TabIndex = 9
            Me.chkCapBoosterReloadTime.Text = "Include Cap Booster Reload Time in Capacitor Calculations"
            Me.chkCapBoosterReloadTime.UseVisualStyleBackColor = True
            '
            'lblCapRechargeUnit
            '
            Me.lblCapRechargeUnit.AutoSize = True
            Me.lblCapRechargeUnit.Location = New System.Drawing.Point(258, 47)
            Me.lblCapRechargeUnit.Name = "lblCapRechargeUnit"
            Me.lblCapRechargeUnit.Size = New System.Drawing.Size(13, 13)
            Me.lblCapRechargeUnit.TabIndex = 8
            Me.lblCapRechargeUnit.Text = "x"
            '
            'lblShieldRechargeUnit
            '
            Me.lblShieldRechargeUnit.AutoSize = True
            Me.lblShieldRechargeUnit.Location = New System.Drawing.Point(258, 75)
            Me.lblShieldRechargeUnit.Name = "lblShieldRechargeUnit"
            Me.lblShieldRechargeUnit.Size = New System.Drawing.Size(13, 13)
            Me.lblShieldRechargeUnit.TabIndex = 7
            Me.lblShieldRechargeUnit.Text = "x"
            '
            'lblMissileRangeUnit
            '
            Me.lblMissileRangeUnit.AutoSize = True
            Me.lblMissileRangeUnit.Location = New System.Drawing.Point(258, 102)
            Me.lblMissileRangeUnit.Name = "lblMissileRangeUnit"
            Me.lblMissileRangeUnit.Size = New System.Drawing.Size(13, 13)
            Me.lblMissileRangeUnit.TabIndex = 6
            Me.lblMissileRangeUnit.Text = "x"
            '
            'nudMissileRange
            '
            Me.nudMissileRange.DecimalPlaces = 2
            Me.nudMissileRange.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudMissileRange.Location = New System.Drawing.Point(180, 100)
            Me.nudMissileRange.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudMissileRange.Minimum = New Decimal(New Integer() {50, 0, 0, 131072})
            Me.nudMissileRange.Name = "nudMissileRange"
            Me.nudMissileRange.Size = New System.Drawing.Size(72, 21)
            Me.nudMissileRange.TabIndex = 5
            Me.nudMissileRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.ToolTip1.SetToolTip(Me.nudMissileRange, "Defines the proportion of the theoretical maximum range of missiles (velocity x f" &
        "light time) to be used for optimal missile optimal range calculations")
            Me.nudMissileRange.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'lblMissileRange
            '
            Me.lblMissileRange.AutoSize = True
            Me.lblMissileRange.Location = New System.Drawing.Point(15, 102)
            Me.lblMissileRange.Name = "lblMissileRange"
            Me.lblMissileRange.Size = New System.Drawing.Size(122, 13)
            Me.lblMissileRange.TabIndex = 4
            Me.lblMissileRange.Text = "Missile Range Constant:"
            Me.ToolTip1.SetToolTip(Me.lblMissileRange, "Defines the proportion of the theoretical maximum range of missiles (velocity x f" &
        "light time) to be used for optimal missile optimal range calculations")
            '
            'nudShieldRecharge
            '
            Me.nudShieldRecharge.DecimalPlaces = 2
            Me.nudShieldRecharge.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudShieldRecharge.Location = New System.Drawing.Point(180, 73)
            Me.nudShieldRecharge.Maximum = New Decimal(New Integer() {25, 0, 0, 65536})
            Me.nudShieldRecharge.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
            Me.nudShieldRecharge.Name = "nudShieldRecharge"
            Me.nudShieldRecharge.Size = New System.Drawing.Size(72, 21)
            Me.nudShieldRecharge.TabIndex = 3
            Me.nudShieldRecharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.ToolTip1.SetToolTip(Me.nudShieldRecharge, "Defines the peak recharge rate of the shields (max = 2.50 x average)")
            Me.nudShieldRecharge.Value = New Decimal(New Integer() {25, 0, 0, 65536})
            '
            'lblShieldRecharge
            '
            Me.lblShieldRecharge.AutoSize = True
            Me.lblShieldRecharge.Location = New System.Drawing.Point(15, 75)
            Me.lblShieldRecharge.Name = "lblShieldRecharge"
            Me.lblShieldRecharge.Size = New System.Drawing.Size(135, 13)
            Me.lblShieldRecharge.TabIndex = 2
            Me.lblShieldRecharge.Text = "Shield Recharge Constant:"
            Me.ToolTip1.SetToolTip(Me.lblShieldRecharge, "Defines the peak recharge rate of the shields (max = 2.50 x average)")
            '
            'nudCapRecharge
            '
            Me.nudCapRecharge.DecimalPlaces = 2
            Me.nudCapRecharge.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudCapRecharge.Location = New System.Drawing.Point(180, 45)
            Me.nudCapRecharge.Maximum = New Decimal(New Integer() {25, 0, 0, 65536})
            Me.nudCapRecharge.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
            Me.nudCapRecharge.Name = "nudCapRecharge"
            Me.nudCapRecharge.Size = New System.Drawing.Size(72, 21)
            Me.nudCapRecharge.TabIndex = 1
            Me.nudCapRecharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.ToolTip1.SetToolTip(Me.nudCapRecharge, "Defines the peak recharge rate of the capacitor (max = 2.50 x average)")
            Me.nudCapRecharge.Value = New Decimal(New Integer() {25, 0, 0, 65536})
            '
            'lblCapRecharge
            '
            Me.lblCapRecharge.AutoSize = True
            Me.lblCapRecharge.Location = New System.Drawing.Point(15, 47)
            Me.lblCapRecharge.Name = "lblCapRecharge"
            Me.lblCapRecharge.Size = New System.Drawing.Size(153, 13)
            Me.lblCapRecharge.TabIndex = 0
            Me.lblCapRecharge.Text = "Capacitor Recharge Constant:"
            Me.ToolTip1.SetToolTip(Me.lblCapRecharge, "Defines the peak recharge rate of the capacitor (max = 2.50 x average)")
            '
            'btnClose
            '
            Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnClose.Location = New System.Drawing.Point(12, 489)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(75, 23)
            Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnClose.TabIndex = 31
            Me.btnClose.Text = "Close"
            '
            'pnlSettings
            '
            Me.pnlSettings.CanvasColor = System.Drawing.SystemColors.Control
            Me.pnlSettings.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.pnlSettings.Controls.Add(Me.gbSlotFormat)
            Me.pnlSettings.Controls.Add(Me.gbDefenceProfiles)
            Me.pnlSettings.Controls.Add(Me.gbGeneral)
            Me.pnlSettings.Controls.Add(Me.gbAttributeColumns)
            Me.pnlSettings.Controls.Add(Me.gbDamageProfiles)
            Me.pnlSettings.Controls.Add(Me.gbConstants)
            Me.pnlSettings.Controls.Add(Me.btnClose)
            Me.pnlSettings.Controls.Add(Me.tvwSettings)
            Me.pnlSettings.DisabledBackColor = System.Drawing.Color.Empty
            Me.pnlSettings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlSettings.Location = New System.Drawing.Point(0, 0)
            Me.pnlSettings.Name = "pnlSettings"
            Me.pnlSettings.Size = New System.Drawing.Size(788, 521)
            Me.pnlSettings.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.pnlSettings.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.pnlSettings.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.pnlSettings.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.pnlSettings.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.pnlSettings.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.pnlSettings.Style.GradientAngle = 90
            Me.pnlSettings.TabIndex = 32
            '
            'gbDefenceProfiles
            '
            Me.gbDefenceProfiles.Controls.Add(Me.gpDefenceProfile)
            Me.gbDefenceProfiles.Controls.Add(Me.btnEditDefenceProfile)
            Me.gbDefenceProfiles.Controls.Add(Me.btnDeleteDefenceProfile)
            Me.gbDefenceProfiles.Controls.Add(Me.btnResetDefenceProfiles)
            Me.gbDefenceProfiles.Controls.Add(Me.btnAddDefenceProfile)
            Me.gbDefenceProfiles.Controls.Add(Me.lvwDefenceProfiles)
            Me.gbDefenceProfiles.Location = New System.Drawing.Point(228, 204)
            Me.gbDefenceProfiles.Name = "gbDefenceProfiles"
            Me.gbDefenceProfiles.Size = New System.Drawing.Size(180, 69)
            Me.gbDefenceProfiles.TabIndex = 33
            Me.gbDefenceProfiles.TabStop = False
            Me.gbDefenceProfiles.Text = "Defence Profiles"
            '
            'gpDefenceProfile
            '
            Me.gpDefenceProfile.CanvasColor = System.Drawing.SystemColors.Control
            Me.gpDefenceProfile.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.gpDefenceProfile.Controls.Add(Me.pbHullDefence)
            Me.gpDefenceProfile.Controls.Add(Me.pbArmorDefence)
            Me.gpDefenceProfile.Controls.Add(Me.pbShieldDefence)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefHEM)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefHEx)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefHKi)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefHTh)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefAEM)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefAEx)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefAKi)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefATh)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefProfileNameLbl)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefProfiletypeLbl)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefTypes)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefEM)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefSEM)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefEx)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefSEx)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefProfileType)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefProfileName)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefKi)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefSKi)
            Me.gpDefenceProfile.Controls.Add(Me.Label25)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefTh)
            Me.gpDefenceProfile.Controls.Add(Me.lblDefSTh)
            Me.gpDefenceProfile.DisabledBackColor = System.Drawing.Color.Empty
            Me.gpDefenceProfile.Location = New System.Drawing.Point(347, 77)
            Me.gpDefenceProfile.Name = "gpDefenceProfile"
            Me.gpDefenceProfile.Size = New System.Drawing.Size(223, 416)
            '
            '
            '
            Me.gpDefenceProfile.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.gpDefenceProfile.Style.BackColorGradientAngle = 90
            Me.gpDefenceProfile.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.gpDefenceProfile.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpDefenceProfile.Style.BorderBottomWidth = 1
            Me.gpDefenceProfile.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.gpDefenceProfile.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpDefenceProfile.Style.BorderLeftWidth = 1
            Me.gpDefenceProfile.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpDefenceProfile.Style.BorderRightWidth = 1
            Me.gpDefenceProfile.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpDefenceProfile.Style.BorderTopWidth = 1
            Me.gpDefenceProfile.Style.CornerDiameter = 4
            Me.gpDefenceProfile.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.gpDefenceProfile.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.gpDefenceProfile.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.gpDefenceProfile.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.gpDefenceProfile.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.gpDefenceProfile.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.gpDefenceProfile.TabIndex = 16
            Me.gpDefenceProfile.Text = "Selected Profile Information"
            Me.gpDefenceProfile.Visible = False
            '
            'pbHullDefence
            '
            Me.pbHullDefence.Image = Global.EveHQ.HQF.My.Resources.Resources.imgStructure
            Me.pbHullDefence.Location = New System.Drawing.Point(172, 69)
            Me.pbHullDefence.Name = "pbHullDefence"
            Me.pbHullDefence.Size = New System.Drawing.Size(32, 32)
            Me.pbHullDefence.TabIndex = 53
            Me.pbHullDefence.TabStop = False
            '
            'pbArmorDefence
            '
            Me.pbArmorDefence.Image = Global.EveHQ.HQF.My.Resources.Resources.imgArmor
            Me.pbArmorDefence.Location = New System.Drawing.Point(127, 69)
            Me.pbArmorDefence.Name = "pbArmorDefence"
            Me.pbArmorDefence.Size = New System.Drawing.Size(32, 32)
            Me.pbArmorDefence.TabIndex = 52
            Me.pbArmorDefence.TabStop = False
            '
            'pbShieldDefence
            '
            Me.pbShieldDefence.Image = Global.EveHQ.HQF.My.Resources.Resources.imgShield
            Me.pbShieldDefence.Location = New System.Drawing.Point(82, 69)
            Me.pbShieldDefence.Name = "pbShieldDefence"
            Me.pbShieldDefence.Size = New System.Drawing.Size(32, 32)
            Me.pbShieldDefence.TabIndex = 51
            Me.pbShieldDefence.TabStop = False
            '
            'lblDefHEM
            '
            Me.lblDefHEM.BackColor = System.Drawing.Color.Transparent
            Me.lblDefHEM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblDefHEM.Location = New System.Drawing.Point(167, 104)
            Me.lblDefHEM.Name = "lblDefHEM"
            Me.lblDefHEM.Size = New System.Drawing.Size(43, 20)
            Me.lblDefHEM.TabIndex = 47
            Me.lblDefHEM.Text = "25.00"
            Me.lblDefHEM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblDefHEx
            '
            Me.lblDefHEx.BackColor = System.Drawing.Color.Transparent
            Me.lblDefHEx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblDefHEx.Location = New System.Drawing.Point(167, 124)
            Me.lblDefHEx.Name = "lblDefHEx"
            Me.lblDefHEx.Size = New System.Drawing.Size(43, 20)
            Me.lblDefHEx.TabIndex = 48
            Me.lblDefHEx.Text = "25.00"
            Me.lblDefHEx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblDefHKi
            '
            Me.lblDefHKi.BackColor = System.Drawing.Color.Transparent
            Me.lblDefHKi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblDefHKi.Location = New System.Drawing.Point(167, 144)
            Me.lblDefHKi.Name = "lblDefHKi"
            Me.lblDefHKi.Size = New System.Drawing.Size(43, 20)
            Me.lblDefHKi.TabIndex = 49
            Me.lblDefHKi.Text = "25.00"
            Me.lblDefHKi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblDefHTh
            '
            Me.lblDefHTh.BackColor = System.Drawing.Color.Transparent
            Me.lblDefHTh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblDefHTh.Location = New System.Drawing.Point(167, 164)
            Me.lblDefHTh.Name = "lblDefHTh"
            Me.lblDefHTh.Size = New System.Drawing.Size(43, 20)
            Me.lblDefHTh.TabIndex = 50
            Me.lblDefHTh.Text = "25.00"
            Me.lblDefHTh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblDefAEM
            '
            Me.lblDefAEM.BackColor = System.Drawing.Color.Transparent
            Me.lblDefAEM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblDefAEM.Location = New System.Drawing.Point(122, 104)
            Me.lblDefAEM.Name = "lblDefAEM"
            Me.lblDefAEM.Size = New System.Drawing.Size(43, 20)
            Me.lblDefAEM.TabIndex = 43
            Me.lblDefAEM.Text = "25.00"
            Me.lblDefAEM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblDefAEx
            '
            Me.lblDefAEx.BackColor = System.Drawing.Color.Transparent
            Me.lblDefAEx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblDefAEx.Location = New System.Drawing.Point(122, 124)
            Me.lblDefAEx.Name = "lblDefAEx"
            Me.lblDefAEx.Size = New System.Drawing.Size(43, 20)
            Me.lblDefAEx.TabIndex = 44
            Me.lblDefAEx.Text = "25.00"
            Me.lblDefAEx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblDefAKi
            '
            Me.lblDefAKi.BackColor = System.Drawing.Color.Transparent
            Me.lblDefAKi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblDefAKi.Location = New System.Drawing.Point(122, 144)
            Me.lblDefAKi.Name = "lblDefAKi"
            Me.lblDefAKi.Size = New System.Drawing.Size(43, 20)
            Me.lblDefAKi.TabIndex = 45
            Me.lblDefAKi.Text = "25.00"
            Me.lblDefAKi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblDefATh
            '
            Me.lblDefATh.BackColor = System.Drawing.Color.Transparent
            Me.lblDefATh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblDefATh.Location = New System.Drawing.Point(122, 164)
            Me.lblDefATh.Name = "lblDefATh"
            Me.lblDefATh.Size = New System.Drawing.Size(43, 20)
            Me.lblDefATh.TabIndex = 46
            Me.lblDefATh.Text = "25.00"
            Me.lblDefATh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblDefProfileNameLbl
            '
            Me.lblDefProfileNameLbl.AutoSize = True
            Me.lblDefProfileNameLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblDefProfileNameLbl.Location = New System.Drawing.Point(3, 12)
            Me.lblDefProfileNameLbl.Name = "lblDefProfileNameLbl"
            Me.lblDefProfileNameLbl.Size = New System.Drawing.Size(71, 13)
            Me.lblDefProfileNameLbl.TabIndex = 0
            Me.lblDefProfileNameLbl.Text = "Profile Name:"
            '
            'lblDefProfiletypeLbl
            '
            Me.lblDefProfiletypeLbl.AutoSize = True
            Me.lblDefProfiletypeLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblDefProfiletypeLbl.Location = New System.Drawing.Point(3, 32)
            Me.lblDefProfiletypeLbl.Name = "lblDefProfiletypeLbl"
            Me.lblDefProfiletypeLbl.Size = New System.Drawing.Size(68, 13)
            Me.lblDefProfiletypeLbl.TabIndex = 1
            Me.lblDefProfiletypeLbl.Text = "Profile Type:"
            '
            'lblDefTypes
            '
            Me.lblDefTypes.AutoSize = True
            Me.lblDefTypes.BackColor = System.Drawing.Color.Transparent
            Me.lblDefTypes.Location = New System.Drawing.Point(3, 52)
            Me.lblDefTypes.Name = "lblDefTypes"
            Me.lblDefTypes.Size = New System.Drawing.Size(88, 13)
            Me.lblDefTypes.TabIndex = 2
            Me.lblDefTypes.Text = "Defence Resists:"
            '
            'lblDefEM
            '
            Me.lblDefEM.BackColor = System.Drawing.Color.Transparent
            Me.lblDefEM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblDefEM.Location = New System.Drawing.Point(6, 104)
            Me.lblDefEM.Name = "lblDefEM"
            Me.lblDefEM.Size = New System.Drawing.Size(65, 20)
            Me.lblDefEM.TabIndex = 3
            Me.lblDefEM.Text = "EM"
            Me.lblDefEM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblDefSEM
            '
            Me.lblDefSEM.BackColor = System.Drawing.Color.Transparent
            Me.lblDefSEM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblDefSEM.Location = New System.Drawing.Point(77, 104)
            Me.lblDefSEM.Name = "lblDefSEM"
            Me.lblDefSEM.Size = New System.Drawing.Size(43, 20)
            Me.lblDefSEM.TabIndex = 4
            Me.lblDefSEM.Text = "25.00"
            Me.lblDefSEM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblDefEx
            '
            Me.lblDefEx.BackColor = System.Drawing.Color.Transparent
            Me.lblDefEx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblDefEx.Location = New System.Drawing.Point(6, 124)
            Me.lblDefEx.Name = "lblDefEx"
            Me.lblDefEx.Size = New System.Drawing.Size(65, 20)
            Me.lblDefEx.TabIndex = 6
            Me.lblDefEx.Text = "Explosive"
            Me.lblDefEx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblDefSEx
            '
            Me.lblDefSEx.BackColor = System.Drawing.Color.Transparent
            Me.lblDefSEx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblDefSEx.Location = New System.Drawing.Point(77, 124)
            Me.lblDefSEx.Name = "lblDefSEx"
            Me.lblDefSEx.Size = New System.Drawing.Size(43, 20)
            Me.lblDefSEx.TabIndex = 7
            Me.lblDefSEx.Text = "25.00"
            Me.lblDefSEx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblDefProfileType
            '
            Me.lblDefProfileType.AutoSize = True
            Me.lblDefProfileType.BackColor = System.Drawing.Color.Transparent
            Me.lblDefProfileType.Location = New System.Drawing.Point(79, 32)
            Me.lblDefProfileType.Name = "lblDefProfileType"
            Me.lblDefProfileType.Size = New System.Drawing.Size(41, 13)
            Me.lblDefProfileType.TabIndex = 34
            Me.lblDefProfileType.Text = "Manual"
            '
            'lblDefProfileName
            '
            Me.lblDefProfileName.AutoSize = True
            Me.lblDefProfileName.BackColor = System.Drawing.Color.Transparent
            Me.lblDefProfileName.Location = New System.Drawing.Point(79, 12)
            Me.lblDefProfileName.Name = "lblDefProfileName"
            Me.lblDefProfileName.Size = New System.Drawing.Size(85, 13)
            Me.lblDefProfileName.TabIndex = 33
            Me.lblDefProfileName.Text = "<Omni-Resists>"
            '
            'lblDefKi
            '
            Me.lblDefKi.BackColor = System.Drawing.Color.Transparent
            Me.lblDefKi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblDefKi.Location = New System.Drawing.Point(6, 144)
            Me.lblDefKi.Name = "lblDefKi"
            Me.lblDefKi.Size = New System.Drawing.Size(65, 20)
            Me.lblDefKi.TabIndex = 9
            Me.lblDefKi.Text = "Kinetic"
            Me.lblDefKi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblDefSKi
            '
            Me.lblDefSKi.BackColor = System.Drawing.Color.Transparent
            Me.lblDefSKi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblDefSKi.Location = New System.Drawing.Point(77, 144)
            Me.lblDefSKi.Name = "lblDefSKi"
            Me.lblDefSKi.Size = New System.Drawing.Size(43, 20)
            Me.lblDefSKi.TabIndex = 10
            Me.lblDefSKi.Text = "25.00"
            Me.lblDefSKi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label25
            '
            Me.Label25.BackColor = System.Drawing.Color.Transparent
            Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label25.Location = New System.Drawing.Point(77, 193)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(135, 2)
            Me.Label25.TabIndex = 30
            '
            'lblDefTh
            '
            Me.lblDefTh.BackColor = System.Drawing.Color.Transparent
            Me.lblDefTh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblDefTh.Location = New System.Drawing.Point(6, 164)
            Me.lblDefTh.Name = "lblDefTh"
            Me.lblDefTh.Size = New System.Drawing.Size(65, 20)
            Me.lblDefTh.TabIndex = 12
            Me.lblDefTh.Text = "Thermal"
            Me.lblDefTh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblDefSTh
            '
            Me.lblDefSTh.BackColor = System.Drawing.Color.Transparent
            Me.lblDefSTh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblDefSTh.Location = New System.Drawing.Point(77, 164)
            Me.lblDefSTh.Name = "lblDefSTh"
            Me.lblDefSTh.Size = New System.Drawing.Size(43, 20)
            Me.lblDefSTh.TabIndex = 13
            Me.lblDefSTh.Text = "25.00"
            Me.lblDefSTh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnEditDefenceProfile
            '
            Me.btnEditDefenceProfile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnEditDefenceProfile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnEditDefenceProfile.Location = New System.Drawing.Point(460, 19)
            Me.btnEditDefenceProfile.Name = "btnEditDefenceProfile"
            Me.btnEditDefenceProfile.Size = New System.Drawing.Size(95, 23)
            Me.btnEditDefenceProfile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnEditDefenceProfile.TabIndex = 15
            Me.btnEditDefenceProfile.Text = "Edit Profile"
            '
            'btnDeleteDefenceProfile
            '
            Me.btnDeleteDefenceProfile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnDeleteDefenceProfile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnDeleteDefenceProfile.Location = New System.Drawing.Point(358, 48)
            Me.btnDeleteDefenceProfile.Name = "btnDeleteDefenceProfile"
            Me.btnDeleteDefenceProfile.Size = New System.Drawing.Size(95, 23)
            Me.btnDeleteDefenceProfile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnDeleteDefenceProfile.TabIndex = 14
            Me.btnDeleteDefenceProfile.Text = "Delete Profile"
            '
            'btnResetDefenceProfiles
            '
            Me.btnResetDefenceProfiles.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnResetDefenceProfiles.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnResetDefenceProfiles.Location = New System.Drawing.Point(460, 48)
            Me.btnResetDefenceProfiles.Name = "btnResetDefenceProfiles"
            Me.btnResetDefenceProfiles.Size = New System.Drawing.Size(95, 23)
            Me.btnResetDefenceProfiles.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnResetDefenceProfiles.TabIndex = 13
            Me.btnResetDefenceProfiles.Text = "Reset Profiles"
            '
            'btnAddDefenceProfile
            '
            Me.btnAddDefenceProfile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnAddDefenceProfile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnAddDefenceProfile.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnAddDefenceProfile.Location = New System.Drawing.Point(358, 19)
            Me.btnAddDefenceProfile.Name = "btnAddDefenceProfile"
            Me.btnAddDefenceProfile.Size = New System.Drawing.Size(95, 23)
            Me.btnAddDefenceProfile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnAddDefenceProfile.TabIndex = 12
            Me.btnAddDefenceProfile.Text = "Add Profile"
            '
            'lvwDefenceProfiles
            '
            '
            '
            '
            Me.lvwDefenceProfiles.Border.Class = "ListViewBorder"
            Me.lvwDefenceProfiles.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lvwDefenceProfiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
            Me.lvwDefenceProfiles.DisabledBackColor = System.Drawing.Color.Empty
            Me.lvwDefenceProfiles.FullRowSelect = True
            Me.lvwDefenceProfiles.GridLines = True
            Me.lvwDefenceProfiles.Location = New System.Drawing.Point(6, 19)
            Me.lvwDefenceProfiles.Name = "lvwDefenceProfiles"
            Me.lvwDefenceProfiles.Size = New System.Drawing.Size(335, 474)
            Me.lvwDefenceProfiles.TabIndex = 11
            Me.lvwDefenceProfiles.UseCompatibleStateImageBehavior = False
            Me.lvwDefenceProfiles.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "Profile Name"
            Me.ColumnHeader1.Width = 200
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "Profile Type"
            Me.ColumnHeader2.Width = 100
            '
            'gbAttributeColumns
            '
            Me.gbAttributeColumns.Controls.Add(Me.btnClearAttributes)
            Me.gbAttributeColumns.Controls.Add(Me.btnRemoveAttribute)
            Me.gbAttributeColumns.Controls.Add(Me.adtAttributeColumns)
            Me.gbAttributeColumns.Location = New System.Drawing.Point(586, 265)
            Me.gbAttributeColumns.Name = "gbAttributeColumns"
            Me.gbAttributeColumns.Size = New System.Drawing.Size(132, 38)
            Me.gbAttributeColumns.TabIndex = 34
            Me.gbAttributeColumns.TabStop = False
            Me.gbAttributeColumns.Text = "Attribute Columns"
            Me.gbAttributeColumns.Visible = False
            '
            'btnClearAttributes
            '
            Me.btnClearAttributes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnClearAttributes.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnClearAttributes.Location = New System.Drawing.Point(137, 471)
            Me.btnClearAttributes.Name = "btnClearAttributes"
            Me.btnClearAttributes.Size = New System.Drawing.Size(125, 23)
            Me.btnClearAttributes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnClearAttributes.TabIndex = 2
            Me.btnClearAttributes.Text = "Clear All Attributes"
            '
            'btnRemoveAttribute
            '
            Me.btnRemoveAttribute.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnRemoveAttribute.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnRemoveAttribute.Location = New System.Drawing.Point(6, 471)
            Me.btnRemoveAttribute.Name = "btnRemoveAttribute"
            Me.btnRemoveAttribute.Size = New System.Drawing.Size(125, 23)
            Me.btnRemoveAttribute.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnRemoveAttribute.TabIndex = 1
            Me.btnRemoveAttribute.Text = "Remove Attribute"
            '
            'adtAttributeColumns
            '
            Me.adtAttributeColumns.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtAttributeColumns.AllowDrop = True
            Me.adtAttributeColumns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.adtAttributeColumns.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtAttributeColumns.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtAttributeColumns.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtAttributeColumns.Columns.Add(Me.colAttributeID)
            Me.adtAttributeColumns.Columns.Add(Me.colAttributeName)
            Me.adtAttributeColumns.DragDropEnabled = False
            Me.adtAttributeColumns.DragDropNodeCopyEnabled = False
            Me.adtAttributeColumns.ExpandWidth = 0
            
            Me.adtAttributeColumns.Location = New System.Drawing.Point(6, 20)
            Me.adtAttributeColumns.Name = "adtAttributeColumns"
            Me.adtAttributeColumns.NodesConnector = Me.NodeConnector1
            Me.adtAttributeColumns.NodeStyle = Me.ElementStyle1
            Me.adtAttributeColumns.PathSeparator = ";"
            Me.adtAttributeColumns.Size = New System.Drawing.Size(111, 0)
            Me.adtAttributeColumns.Styles.Add(Me.ElementStyle1)
            Me.adtAttributeColumns.TabIndex = 0
            '
            'colAttributeID
            '
            Me.colAttributeID.DisplayIndex = 1
            Me.colAttributeID.Name = "colAttributeID"
            Me.colAttributeID.SortingEnabled = False
            Me.colAttributeID.Text = "Attribute ID"
            Me.colAttributeID.Width.Absolute = 100
            '
            'colAttributeName
            '
            Me.colAttributeName.DisplayIndex = 2
            Me.colAttributeName.Name = "colAttributeName"
            Me.colAttributeName.SortingEnabled = False
            Me.colAttributeName.Text = "Attribute Name"
            Me.colAttributeName.Width.Absolute = 400
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
            'gbDamageProfiles
            '
            Me.gbDamageProfiles.Controls.Add(Me.gpProfile)
            Me.gbDamageProfiles.Controls.Add(Me.btnEditProfile)
            Me.gbDamageProfiles.Controls.Add(Me.btnDeleteProfile)
            Me.gbDamageProfiles.Controls.Add(Me.btnResetProfiles)
            Me.gbDamageProfiles.Controls.Add(Me.btnAddProfile)
            Me.gbDamageProfiles.Controls.Add(Me.lvwProfiles)
            Me.gbDamageProfiles.Location = New System.Drawing.Point(541, 378)
            Me.gbDamageProfiles.Name = "gbDamageProfiles"
            Me.gbDamageProfiles.Size = New System.Drawing.Size(98, 43)
            Me.gbDamageProfiles.TabIndex = 32
            Me.gbDamageProfiles.TabStop = False
            Me.gbDamageProfiles.Text = "Damage Profiles"
            '
            'gpProfile
            '
            Me.gpProfile.CanvasColor = System.Drawing.SystemColors.Control
            Me.gpProfile.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.gpProfile.Controls.Add(Me.lblNPCName)
            Me.gpProfile.Controls.Add(Me.lblProfileNameLbl)
            Me.gpProfile.Controls.Add(Me.lblNPCNameLbl)
            Me.gpProfile.Controls.Add(Me.lblProfileTypeLbl)
            Me.gpProfile.Controls.Add(Me.lblPilotName)
            Me.gpProfile.Controls.Add(Me.lblDamageTypes)
            Me.gpProfile.Controls.Add(Me.lblPilotNameLbl)
            Me.gpProfile.Controls.Add(Me.lblEMDamage)
            Me.gpProfile.Controls.Add(Me.lblFittingName)
            Me.gpProfile.Controls.Add(Me.lblEMDamageAmount)
            Me.gpProfile.Controls.Add(Me.lblFittingNameLbl)
            Me.gpProfile.Controls.Add(Me.lblEMDamagePercentage)
            Me.gpProfile.Controls.Add(Me.lblDPS)
            Me.gpProfile.Controls.Add(Me.lblEXDamage)
            Me.gpProfile.Controls.Add(Me.lblDPSLbl)
            Me.gpProfile.Controls.Add(Me.lblEXDamageAmount)
            Me.gpProfile.Controls.Add(Me.lblProfileType)
            Me.gpProfile.Controls.Add(Me.lblEXDamagePercentage)
            Me.gpProfile.Controls.Add(Me.lblProfileName)
            Me.gpProfile.Controls.Add(Me.lblKIDamage)
            Me.gpProfile.Controls.Add(Me.lblTotalDamagePercentage)
            Me.gpProfile.Controls.Add(Me.lblKIDamageAmount)
            Me.gpProfile.Controls.Add(Me.lblTotalDamageAmount)
            Me.gpProfile.Controls.Add(Me.lblKIDamagePercentage)
            Me.gpProfile.Controls.Add(Me.line2)
            Me.gpProfile.Controls.Add(Me.lblTHDamage)
            Me.gpProfile.Controls.Add(Me.lblTHDamagePercentage)
            Me.gpProfile.Controls.Add(Me.lblTHDamageAmount)
            Me.gpProfile.DisabledBackColor = System.Drawing.Color.Empty
            Me.gpProfile.Location = New System.Drawing.Point(347, 77)
            Me.gpProfile.Name = "gpProfile"
            Me.gpProfile.Size = New System.Drawing.Size(223, 416)
            '
            '
            '
            Me.gpProfile.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.gpProfile.Style.BackColorGradientAngle = 90
            Me.gpProfile.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.gpProfile.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpProfile.Style.BorderBottomWidth = 1
            Me.gpProfile.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.gpProfile.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpProfile.Style.BorderLeftWidth = 1
            Me.gpProfile.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpProfile.Style.BorderRightWidth = 1
            Me.gpProfile.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpProfile.Style.BorderTopWidth = 1
            Me.gpProfile.Style.CornerDiameter = 4
            Me.gpProfile.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.gpProfile.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.gpProfile.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.gpProfile.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.gpProfile.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.gpProfile.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.gpProfile.TabIndex = 16
            Me.gpProfile.Text = "Selected Profile Information"
            Me.gpProfile.Visible = False
            '
            'lblNPCName
            '
            Me.lblNPCName.AutoSize = True
            Me.lblNPCName.BackColor = System.Drawing.Color.Transparent
            Me.lblNPCName.Location = New System.Drawing.Point(79, 276)
            Me.lblNPCName.Name = "lblNPCName"
            Me.lblNPCName.Size = New System.Drawing.Size(23, 13)
            Me.lblNPCName.TabIndex = 42
            Me.lblNPCName.Text = "n/a"
            '
            'lblProfileNameLbl
            '
            Me.lblProfileNameLbl.AutoSize = True
            Me.lblProfileNameLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblProfileNameLbl.Location = New System.Drawing.Point(3, 12)
            Me.lblProfileNameLbl.Name = "lblProfileNameLbl"
            Me.lblProfileNameLbl.Size = New System.Drawing.Size(71, 13)
            Me.lblProfileNameLbl.TabIndex = 0
            Me.lblProfileNameLbl.Text = "Profile Name:"
            '
            'lblNPCNameLbl
            '
            Me.lblNPCNameLbl.AutoSize = True
            Me.lblNPCNameLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblNPCNameLbl.Location = New System.Drawing.Point(3, 276)
            Me.lblNPCNameLbl.Name = "lblNPCNameLbl"
            Me.lblNPCNameLbl.Size = New System.Drawing.Size(74, 13)
            Me.lblNPCNameLbl.TabIndex = 41
            Me.lblNPCNameLbl.Text = "NPC Name(s):"
            '
            'lblProfileTypeLbl
            '
            Me.lblProfileTypeLbl.AutoSize = True
            Me.lblProfileTypeLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblProfileTypeLbl.Location = New System.Drawing.Point(3, 32)
            Me.lblProfileTypeLbl.Name = "lblProfileTypeLbl"
            Me.lblProfileTypeLbl.Size = New System.Drawing.Size(68, 13)
            Me.lblProfileTypeLbl.TabIndex = 1
            Me.lblProfileTypeLbl.Text = "Profile Type:"
            '
            'lblPilotName
            '
            Me.lblPilotName.AutoSize = True
            Me.lblPilotName.BackColor = System.Drawing.Color.Transparent
            Me.lblPilotName.Location = New System.Drawing.Point(79, 256)
            Me.lblPilotName.Name = "lblPilotName"
            Me.lblPilotName.Size = New System.Drawing.Size(23, 13)
            Me.lblPilotName.TabIndex = 40
            Me.lblPilotName.Text = "n/a"
            '
            'lblDamageTypes
            '
            Me.lblDamageTypes.AutoSize = True
            Me.lblDamageTypes.BackColor = System.Drawing.Color.Transparent
            Me.lblDamageTypes.Location = New System.Drawing.Point(3, 52)
            Me.lblDamageTypes.Name = "lblDamageTypes"
            Me.lblDamageTypes.Size = New System.Drawing.Size(82, 13)
            Me.lblDamageTypes.TabIndex = 2
            Me.lblDamageTypes.Text = "Damage Types:"
            '
            'lblPilotNameLbl
            '
            Me.lblPilotNameLbl.AutoSize = True
            Me.lblPilotNameLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblPilotNameLbl.Location = New System.Drawing.Point(3, 256)
            Me.lblPilotNameLbl.Name = "lblPilotNameLbl"
            Me.lblPilotNameLbl.Size = New System.Drawing.Size(61, 13)
            Me.lblPilotNameLbl.TabIndex = 39
            Me.lblPilotNameLbl.Text = "Pilot Name:"
            '
            'lblEMDamage
            '
            Me.lblEMDamage.BackColor = System.Drawing.Color.Transparent
            Me.lblEMDamage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblEMDamage.Location = New System.Drawing.Point(6, 70)
            Me.lblEMDamage.Name = "lblEMDamage"
            Me.lblEMDamage.Size = New System.Drawing.Size(65, 20)
            Me.lblEMDamage.TabIndex = 3
            Me.lblEMDamage.Text = "EM"
            Me.lblEMDamage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblFittingName
            '
            Me.lblFittingName.AutoSize = True
            Me.lblFittingName.BackColor = System.Drawing.Color.Transparent
            Me.lblFittingName.Location = New System.Drawing.Point(79, 236)
            Me.lblFittingName.Name = "lblFittingName"
            Me.lblFittingName.Size = New System.Drawing.Size(23, 13)
            Me.lblFittingName.TabIndex = 38
            Me.lblFittingName.Text = "n/a"
            '
            'lblEMDamageAmount
            '
            Me.lblEMDamageAmount.BackColor = System.Drawing.Color.Transparent
            Me.lblEMDamageAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblEMDamageAmount.Location = New System.Drawing.Point(77, 70)
            Me.lblEMDamageAmount.Name = "lblEMDamageAmount"
            Me.lblEMDamageAmount.Size = New System.Drawing.Size(59, 20)
            Me.lblEMDamageAmount.TabIndex = 4
            Me.lblEMDamageAmount.Text = "25.00"
            Me.lblEMDamageAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblFittingNameLbl
            '
            Me.lblFittingNameLbl.AutoSize = True
            Me.lblFittingNameLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblFittingNameLbl.Location = New System.Drawing.Point(3, 236)
            Me.lblFittingNameLbl.Name = "lblFittingNameLbl"
            Me.lblFittingNameLbl.Size = New System.Drawing.Size(71, 13)
            Me.lblFittingNameLbl.TabIndex = 37
            Me.lblFittingNameLbl.Text = "Fitting Name:"
            '
            'lblEMDamagePercentage
            '
            Me.lblEMDamagePercentage.BackColor = System.Drawing.Color.Transparent
            Me.lblEMDamagePercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblEMDamagePercentage.Location = New System.Drawing.Point(142, 70)
            Me.lblEMDamagePercentage.Name = "lblEMDamagePercentage"
            Me.lblEMDamagePercentage.Size = New System.Drawing.Size(67, 20)
            Me.lblEMDamagePercentage.TabIndex = 5
            Me.lblEMDamagePercentage.Text = "= 25.00%"
            Me.lblEMDamagePercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblDPS
            '
            Me.lblDPS.AutoSize = True
            Me.lblDPS.BackColor = System.Drawing.Color.Transparent
            Me.lblDPS.Location = New System.Drawing.Point(79, 216)
            Me.lblDPS.Name = "lblDPS"
            Me.lblDPS.Size = New System.Drawing.Size(47, 13)
            Me.lblDPS.TabIndex = 36
            Me.lblDPS.Text = "1000.00"
            '
            'lblEXDamage
            '
            Me.lblEXDamage.BackColor = System.Drawing.Color.Transparent
            Me.lblEXDamage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblEXDamage.Location = New System.Drawing.Point(6, 90)
            Me.lblEXDamage.Name = "lblEXDamage"
            Me.lblEXDamage.Size = New System.Drawing.Size(65, 20)
            Me.lblEXDamage.TabIndex = 6
            Me.lblEXDamage.Text = "Explosive"
            Me.lblEXDamage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblDPSLbl
            '
            Me.lblDPSLbl.AutoSize = True
            Me.lblDPSLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblDPSLbl.Location = New System.Drawing.Point(3, 216)
            Me.lblDPSLbl.Name = "lblDPSLbl"
            Me.lblDPSLbl.Size = New System.Drawing.Size(30, 13)
            Me.lblDPSLbl.TabIndex = 35
            Me.lblDPSLbl.Text = "DPS:"
            '
            'lblEXDamageAmount
            '
            Me.lblEXDamageAmount.BackColor = System.Drawing.Color.Transparent
            Me.lblEXDamageAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblEXDamageAmount.Location = New System.Drawing.Point(77, 90)
            Me.lblEXDamageAmount.Name = "lblEXDamageAmount"
            Me.lblEXDamageAmount.Size = New System.Drawing.Size(59, 20)
            Me.lblEXDamageAmount.TabIndex = 7
            Me.lblEXDamageAmount.Text = "25.00"
            Me.lblEXDamageAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblProfileType
            '
            Me.lblProfileType.AutoSize = True
            Me.lblProfileType.BackColor = System.Drawing.Color.Transparent
            Me.lblProfileType.Location = New System.Drawing.Point(79, 32)
            Me.lblProfileType.Name = "lblProfileType"
            Me.lblProfileType.Size = New System.Drawing.Size(41, 13)
            Me.lblProfileType.TabIndex = 34
            Me.lblProfileType.Text = "Manual"
            '
            'lblEXDamagePercentage
            '
            Me.lblEXDamagePercentage.BackColor = System.Drawing.Color.Transparent
            Me.lblEXDamagePercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblEXDamagePercentage.Location = New System.Drawing.Point(142, 90)
            Me.lblEXDamagePercentage.Name = "lblEXDamagePercentage"
            Me.lblEXDamagePercentage.Size = New System.Drawing.Size(67, 20)
            Me.lblEXDamagePercentage.TabIndex = 8
            Me.lblEXDamagePercentage.Text = "= 25.00%"
            Me.lblEXDamagePercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblProfileName
            '
            Me.lblProfileName.AutoSize = True
            Me.lblProfileName.BackColor = System.Drawing.Color.Transparent
            Me.lblProfileName.Location = New System.Drawing.Point(79, 12)
            Me.lblProfileName.Name = "lblProfileName"
            Me.lblProfileName.Size = New System.Drawing.Size(90, 13)
            Me.lblProfileName.TabIndex = 33
            Me.lblProfileName.Text = "<Omni-Damage>"
            '
            'lblKIDamage
            '
            Me.lblKIDamage.BackColor = System.Drawing.Color.Transparent
            Me.lblKIDamage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblKIDamage.Location = New System.Drawing.Point(6, 110)
            Me.lblKIDamage.Name = "lblKIDamage"
            Me.lblKIDamage.Size = New System.Drawing.Size(65, 20)
            Me.lblKIDamage.TabIndex = 9
            Me.lblKIDamage.Text = "Kinetic"
            Me.lblKIDamage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTotalDamagePercentage
            '
            Me.lblTotalDamagePercentage.BackColor = System.Drawing.Color.Transparent
            Me.lblTotalDamagePercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblTotalDamagePercentage.Location = New System.Drawing.Point(142, 170)
            Me.lblTotalDamagePercentage.Name = "lblTotalDamagePercentage"
            Me.lblTotalDamagePercentage.Size = New System.Drawing.Size(67, 20)
            Me.lblTotalDamagePercentage.TabIndex = 32
            Me.lblTotalDamagePercentage.Text = "= 100.00%"
            Me.lblTotalDamagePercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblKIDamageAmount
            '
            Me.lblKIDamageAmount.BackColor = System.Drawing.Color.Transparent
            Me.lblKIDamageAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblKIDamageAmount.Location = New System.Drawing.Point(77, 110)
            Me.lblKIDamageAmount.Name = "lblKIDamageAmount"
            Me.lblKIDamageAmount.Size = New System.Drawing.Size(59, 20)
            Me.lblKIDamageAmount.TabIndex = 10
            Me.lblKIDamageAmount.Text = "25.00"
            Me.lblKIDamageAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblTotalDamageAmount
            '
            Me.lblTotalDamageAmount.BackColor = System.Drawing.Color.Transparent
            Me.lblTotalDamageAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblTotalDamageAmount.Location = New System.Drawing.Point(77, 170)
            Me.lblTotalDamageAmount.Name = "lblTotalDamageAmount"
            Me.lblTotalDamageAmount.Size = New System.Drawing.Size(59, 20)
            Me.lblTotalDamageAmount.TabIndex = 31
            Me.lblTotalDamageAmount.Text = "100.00"
            Me.lblTotalDamageAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblKIDamagePercentage
            '
            Me.lblKIDamagePercentage.BackColor = System.Drawing.Color.Transparent
            Me.lblKIDamagePercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblKIDamagePercentage.Location = New System.Drawing.Point(142, 110)
            Me.lblKIDamagePercentage.Name = "lblKIDamagePercentage"
            Me.lblKIDamagePercentage.Size = New System.Drawing.Size(67, 20)
            Me.lblKIDamagePercentage.TabIndex = 11
            Me.lblKIDamagePercentage.Text = "= 25.00%"
            Me.lblKIDamagePercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'line2
            '
            Me.line2.BackColor = System.Drawing.Color.Transparent
            Me.line2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.line2.Location = New System.Drawing.Point(77, 159)
            Me.line2.Name = "line2"
            Me.line2.Size = New System.Drawing.Size(135, 2)
            Me.line2.TabIndex = 30
            '
            'lblTHDamage
            '
            Me.lblTHDamage.BackColor = System.Drawing.Color.Transparent
            Me.lblTHDamage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblTHDamage.Location = New System.Drawing.Point(6, 130)
            Me.lblTHDamage.Name = "lblTHDamage"
            Me.lblTHDamage.Size = New System.Drawing.Size(65, 20)
            Me.lblTHDamage.TabIndex = 12
            Me.lblTHDamage.Text = "Thermal"
            Me.lblTHDamage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTHDamagePercentage
            '
            Me.lblTHDamagePercentage.BackColor = System.Drawing.Color.Transparent
            Me.lblTHDamagePercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblTHDamagePercentage.Location = New System.Drawing.Point(142, 130)
            Me.lblTHDamagePercentage.Name = "lblTHDamagePercentage"
            Me.lblTHDamagePercentage.Size = New System.Drawing.Size(67, 20)
            Me.lblTHDamagePercentage.TabIndex = 14
            Me.lblTHDamagePercentage.Text = "= 25.00%"
            Me.lblTHDamagePercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblTHDamageAmount
            '
            Me.lblTHDamageAmount.BackColor = System.Drawing.Color.Transparent
            Me.lblTHDamageAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblTHDamageAmount.Location = New System.Drawing.Point(77, 130)
            Me.lblTHDamageAmount.Name = "lblTHDamageAmount"
            Me.lblTHDamageAmount.Size = New System.Drawing.Size(59, 20)
            Me.lblTHDamageAmount.TabIndex = 13
            Me.lblTHDamageAmount.Text = "25.00"
            Me.lblTHDamageAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnEditProfile
            '
            Me.btnEditProfile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnEditProfile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnEditProfile.Location = New System.Drawing.Point(460, 19)
            Me.btnEditProfile.Name = "btnEditProfile"
            Me.btnEditProfile.Size = New System.Drawing.Size(95, 23)
            Me.btnEditProfile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnEditProfile.TabIndex = 15
            Me.btnEditProfile.Text = "Edit Profile"
            '
            'btnDeleteProfile
            '
            Me.btnDeleteProfile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnDeleteProfile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnDeleteProfile.Location = New System.Drawing.Point(358, 48)
            Me.btnDeleteProfile.Name = "btnDeleteProfile"
            Me.btnDeleteProfile.Size = New System.Drawing.Size(95, 23)
            Me.btnDeleteProfile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnDeleteProfile.TabIndex = 14
            Me.btnDeleteProfile.Text = "Delete Profile"
            '
            'btnResetProfiles
            '
            Me.btnResetProfiles.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnResetProfiles.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnResetProfiles.Location = New System.Drawing.Point(460, 48)
            Me.btnResetProfiles.Name = "btnResetProfiles"
            Me.btnResetProfiles.Size = New System.Drawing.Size(95, 23)
            Me.btnResetProfiles.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnResetProfiles.TabIndex = 13
            Me.btnResetProfiles.Text = "Reset Profiles"
            '
            'btnAddProfile
            '
            Me.btnAddProfile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnAddProfile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnAddProfile.Location = New System.Drawing.Point(358, 19)
            Me.btnAddProfile.Name = "btnAddProfile"
            Me.btnAddProfile.Size = New System.Drawing.Size(95, 23)
            Me.btnAddProfile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnAddProfile.TabIndex = 12
            Me.btnAddProfile.Text = "Add Profile"
            '
            'lvwProfiles
            '
            '
            '
            '
            Me.lvwProfiles.Border.Class = "ListViewBorder"
            Me.lvwProfiles.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lvwProfiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colProfileName, Me.colProfileType})
            Me.lvwProfiles.DisabledBackColor = System.Drawing.Color.Empty
            Me.lvwProfiles.FullRowSelect = True
            Me.lvwProfiles.GridLines = True
            Me.lvwProfiles.Location = New System.Drawing.Point(6, 19)
            Me.lvwProfiles.Name = "lvwProfiles"
            Me.lvwProfiles.Size = New System.Drawing.Size(335, 474)
            Me.lvwProfiles.TabIndex = 11
            Me.lvwProfiles.UseCompatibleStateImageBehavior = False
            Me.lvwProfiles.View = System.Windows.Forms.View.Details
            '
            'colProfileName
            '
            Me.colProfileName.Text = "Profile Name"
            Me.colProfileName.Width = 200
            '
            'colProfileType
            '
            Me.colProfileType.Text = "Profile Type"
            Me.colProfileType.Width = 100
            '
            'FrmHQFSettings
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnClose
            Me.ClientSize = New System.Drawing.Size(788, 521)
            Me.Controls.Add(Me.pnlSettings)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmHQFSettings"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "HQF Settings"
            Me.gbGeneral.ResumeLayout(False)
            Me.gbGeneral.PerformLayout()
            CType(Me.pbHiSlotColour, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbMidSlotColour, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbLowSlotColour, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbRigSlotColour, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbSlotFormat.ResumeLayout(False)
            Me.gbSlotFormat.PerformLayout()
            CType(Me.pbSubSlotColour, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbServiceModSlotColour, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbConstants.ResumeLayout(False)
            Me.gbConstants.PerformLayout()
            CType(Me.nudMissileRange, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudShieldRecharge, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCapRecharge, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlSettings.ResumeLayout(False)
            Me.gbDefenceProfiles.ResumeLayout(False)
            Me.gpDefenceProfile.ResumeLayout(False)
            Me.gpDefenceProfile.PerformLayout()
            CType(Me.pbHullDefence, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbArmorDefence, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbShieldDefence, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbAttributeColumns.ResumeLayout(False)
            CType(Me.adtAttributeColumns, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbDamageProfiles.ResumeLayout(False)
            Me.gpProfile.ResumeLayout(False)
            Me.gpProfile.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents gbGeneral As System.Windows.Forms.GroupBox
        Friend WithEvents fbd1 As System.Windows.Forms.FolderBrowserDialog
        Friend WithEvents lblDefaultPilot As System.Windows.Forms.Label
        Friend WithEvents ofd1 As System.Windows.Forms.OpenFileDialog
        Friend WithEvents tvwSettings As System.Windows.Forms.TreeView
        Friend WithEvents cd1 As System.Windows.Forms.ColorDialog
        Friend WithEvents lblHiSlotColour As System.Windows.Forms.Label
        Friend WithEvents lblMidSlotColour As System.Windows.Forms.Label
        Friend WithEvents pbHiSlotColour As System.Windows.Forms.PictureBox
        Friend WithEvents pbMidSlotColour As System.Windows.Forms.PictureBox
        Friend WithEvents lblLowSlotColour As System.Windows.Forms.Label
        Friend WithEvents pbLowSlotColour As System.Windows.Forms.PictureBox
        Friend WithEvents lblRigSlotColour As System.Windows.Forms.Label
        Friend WithEvents pbRigSlotColour As System.Windows.Forms.PictureBox
        Friend WithEvents gbSlotFormat As System.Windows.Forms.GroupBox
        Friend WithEvents gbConstants As System.Windows.Forms.GroupBox
        Friend WithEvents nudShieldRecharge As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblShieldRecharge As System.Windows.Forms.Label
        Friend WithEvents nudCapRecharge As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblCapRecharge As System.Windows.Forms.Label
        Friend WithEvents lblSlotColumns As System.Windows.Forms.Label
        Friend WithEvents lvwColumns As System.Windows.Forms.ListView
        Friend WithEvents colSlotColumns As System.Windows.Forms.ColumnHeader
        Friend WithEvents btnMoveDown As System.Windows.Forms.Button
        Friend WithEvents btnMoveUp As System.Windows.Forms.Button
        Friend WithEvents nudMissileRange As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblMissileRange As System.Windows.Forms.Label
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents lblMissileRangeUnit As System.Windows.Forms.Label
        Friend WithEvents lblCapRechargeUnit As System.Windows.Forms.Label
        Friend WithEvents lblShieldRechargeUnit As System.Windows.Forms.Label
        Friend WithEvents lblSubSlotColour As System.Windows.Forms.Label
        Friend WithEvents pbSubSlotColour As System.Windows.Forms.PictureBox
        Friend WithEvents lblServiceModSlotColour As System.Windows.Forms.Label
        Friend WithEvents pbServiceModSlotColour As System.Windows.Forms.PictureBox
        Friend WithEvents chkAmmoLoadTime As System.Windows.Forms.CheckBox
        Friend WithEvents chkCapBoosterReloadTime As System.Windows.Forms.CheckBox
        Friend WithEvents gbDamageProfiles As System.Windows.Forms.GroupBox
        Friend WithEvents lblNPCName As System.Windows.Forms.Label
        Friend WithEvents lblProfileNameLbl As System.Windows.Forms.Label
        Friend WithEvents lblNPCNameLbl As System.Windows.Forms.Label
        Friend WithEvents lblProfileTypeLbl As System.Windows.Forms.Label
        Friend WithEvents lblPilotName As System.Windows.Forms.Label
        Friend WithEvents lblDamageTypes As System.Windows.Forms.Label
        Friend WithEvents lblPilotNameLbl As System.Windows.Forms.Label
        Friend WithEvents lblEMDamage As System.Windows.Forms.Label
        Friend WithEvents lblFittingName As System.Windows.Forms.Label
        Friend WithEvents lblEMDamageAmount As System.Windows.Forms.Label
        Friend WithEvents lblFittingNameLbl As System.Windows.Forms.Label
        Friend WithEvents lblEMDamagePercentage As System.Windows.Forms.Label
        Friend WithEvents lblDPS As System.Windows.Forms.Label
        Friend WithEvents lblEXDamage As System.Windows.Forms.Label
        Friend WithEvents lblDPSLbl As System.Windows.Forms.Label
        Friend WithEvents lblEXDamageAmount As System.Windows.Forms.Label
        Friend WithEvents lblProfileType As System.Windows.Forms.Label
        Friend WithEvents lblEXDamagePercentage As System.Windows.Forms.Label
        Friend WithEvents lblProfileName As System.Windows.Forms.Label
        Friend WithEvents lblKIDamage As System.Windows.Forms.Label
        Friend WithEvents lblTotalDamagePercentage As System.Windows.Forms.Label
        Friend WithEvents lblKIDamageAmount As System.Windows.Forms.Label
        Friend WithEvents lblTotalDamageAmount As System.Windows.Forms.Label
        Friend WithEvents lblKIDamagePercentage As System.Windows.Forms.Label
        Friend WithEvents line2 As System.Windows.Forms.Label
        Friend WithEvents lblTHDamage As System.Windows.Forms.Label
        Friend WithEvents lblTHDamagePercentage As System.Windows.Forms.Label
        Friend WithEvents lblTHDamageAmount As System.Windows.Forms.Label
        Friend WithEvents lvwProfiles As DevComponents.DotNetBar.Controls.ListViewEx
        Friend WithEvents colProfileName As System.Windows.Forms.ColumnHeader
        Friend WithEvents colProfileType As System.Windows.Forms.ColumnHeader
        Friend WithEvents gbDefenceProfiles As System.Windows.Forms.GroupBox
        Friend WithEvents lblDefProfileNameLbl As System.Windows.Forms.Label
        Friend WithEvents lblDefProfiletypeLbl As System.Windows.Forms.Label
        Friend WithEvents lblDefTypes As System.Windows.Forms.Label
        Friend WithEvents lblDefEM As System.Windows.Forms.Label
        Friend WithEvents lblDefSEM As System.Windows.Forms.Label
        Friend WithEvents lblDefEx As System.Windows.Forms.Label
        Friend WithEvents lblDefSEx As System.Windows.Forms.Label
        Friend WithEvents lblDefProfileType As System.Windows.Forms.Label
        Friend WithEvents lblDefProfileName As System.Windows.Forms.Label
        Friend WithEvents lblDefKi As System.Windows.Forms.Label
        Friend WithEvents lblDefSKi As System.Windows.Forms.Label
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents lblDefTh As System.Windows.Forms.Label
        Friend WithEvents lblDefSTh As System.Windows.Forms.Label
        Friend WithEvents lvwDefenceProfiles As DevComponents.DotNetBar.Controls.ListViewEx
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Friend WithEvents lblDefAEM As System.Windows.Forms.Label
        Friend WithEvents lblDefAEx As System.Windows.Forms.Label
        Friend WithEvents lblDefAKi As System.Windows.Forms.Label
        Friend WithEvents lblDefATh As System.Windows.Forms.Label
        Friend WithEvents pbHullDefence As System.Windows.Forms.PictureBox
        Friend WithEvents pbArmorDefence As System.Windows.Forms.PictureBox
        Friend WithEvents pbShieldDefence As System.Windows.Forms.PictureBox
        Friend WithEvents lblDefHEM As System.Windows.Forms.Label
        Friend WithEvents lblDefHEx As System.Windows.Forms.Label
        Friend WithEvents lblDefHKi As System.Windows.Forms.Label
        Friend WithEvents lblDefHTh As System.Windows.Forms.Label
        Friend WithEvents gbAttributeColumns As System.Windows.Forms.GroupBox
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents chkAutoResizeColumns As System.Windows.Forms.CheckBox
        Private WithEvents btnClose As DevComponents.DotNetBar.ButtonX
        Private WithEvents chkUseLastPilot As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents chkAutoUpdateHQFSkills As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents chkRestoreLastSession As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents chkShowPerformance As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents cboStartupPilot As DevComponents.DotNetBar.Controls.ComboBoxEx
        Private WithEvents pnlSettings As DevComponents.DotNetBar.PanelEx
        Private WithEvents gpProfile As DevComponents.DotNetBar.Controls.GroupPanel
        Private WithEvents btnEditProfile As DevComponents.DotNetBar.ButtonX
        Private WithEvents btnDeleteProfile As DevComponents.DotNetBar.ButtonX
        Private WithEvents btnResetProfiles As DevComponents.DotNetBar.ButtonX
        Private WithEvents btnAddProfile As DevComponents.DotNetBar.ButtonX
        Private WithEvents gpDefenceProfile As DevComponents.DotNetBar.Controls.GroupPanel
        Private WithEvents btnEditDefenceProfile As DevComponents.DotNetBar.ButtonX
        Private WithEvents btnDeleteDefenceProfile As DevComponents.DotNetBar.ButtonX
        Private WithEvents btnResetDefenceProfiles As DevComponents.DotNetBar.ButtonX
        Private WithEvents btnAddDefenceProfile As DevComponents.DotNetBar.ButtonX
        Private WithEvents adtAttributeColumns As DevComponents.AdvTree.AdvTree
        Private WithEvents colAttributeID As DevComponents.AdvTree.ColumnHeader
        Private WithEvents colAttributeName As DevComponents.AdvTree.ColumnHeader
        Private WithEvents btnClearAttributes As DevComponents.DotNetBar.ButtonX
        Private WithEvents btnRemoveAttribute As DevComponents.DotNetBar.ButtonX
    End Class
End NameSpace