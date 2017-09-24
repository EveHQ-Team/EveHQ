Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class FrmSettings
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
            Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Colours & Styles")
            Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Dashboard")
            Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("E-Mail")
            Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Eve Accounts")
            Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Eve Folders")
            Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Eve API & Server")
            Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G15 Display")
            Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Notifications")
            Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pilots")
            Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Plug Ins")
            Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Proxy Server")
            Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Taskbar Icon")
            Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Training Queue")
            Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Item Overrides")
            Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Market & Price Data", New System.Windows.Forms.TreeNode() {TreeNode15})
            Dim SuperTooltipInfo1 As DevComponents.DotNetBar.SuperTooltipInfo = New DevComponents.DotNetBar.SuperTooltipInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettings))
            Me.gbGeneral = New System.Windows.Forms.GroupBox()
            Me.chkViewSkillTraining = New System.Windows.Forms.CheckBox()
            Me.chkViewMarketPrices = New System.Windows.Forms.CheckBox()
            Me.chkViewDashboard = New System.Windows.Forms.CheckBox()
            Me.chkViewRequisitions = New System.Windows.Forms.CheckBox()
            Me.chkViewPilotSummary = New System.Windows.Forms.CheckBox()
            Me.chkViewPilotInfo = New System.Windows.Forms.CheckBox()
            Me.lblAutomaticSaveTime = New System.Windows.Forms.Label()
            Me.nudAutomaticSaveTime = New System.Windows.Forms.NumericUpDown()
            Me.chkEnableAutomaticSave = New System.Windows.Forms.CheckBox()
            Me.chkDisableTrainingBar = New System.Windows.Forms.CheckBox()
            Me.chkDisableAutoConnections = New System.Windows.Forms.CheckBox()
            Me.lblMDITabPosition = New System.Windows.Forms.Label()
            Me.cboMDITabPosition = New System.Windows.Forms.ComboBox()
            Me.txtErrorRepEmail = New System.Windows.Forms.TextBox()
            Me.lblErrorRepEmail = New System.Windows.Forms.Label()
            Me.txtErrorRepName = New System.Windows.Forms.TextBox()
            Me.lblErrorRepName = New System.Windows.Forms.Label()
            Me.chkErrorReporting = New System.Windows.Forms.CheckBox()
            Me.txtUpdateLocation = New System.Windows.Forms.TextBox()
            Me.lblUpdateLocation = New System.Windows.Forms.Label()
            Me.chkMinimiseOnExit = New System.Windows.Forms.CheckBox()
            Me.cboStartupPilot = New System.Windows.Forms.ComboBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.chkAutoMinimise = New System.Windows.Forms.CheckBox()
            Me.chkAutoRun = New System.Windows.Forms.CheckBox()
            Me.chkAutoHide = New System.Windows.Forms.CheckBox()
            Me.gbPilotScreenColours = New System.Windows.Forms.GroupBox()
            Me.pbPilotSkillHighlight = New System.Windows.Forms.PictureBox()
            Me.lblPilotSkillHighlight = New System.Windows.Forms.Label()
            Me.pbPilotSkillText = New System.Windows.Forms.PictureBox()
            Me.lblPilotSkillText = New System.Windows.Forms.Label()
            Me.pbPilotGroupText = New System.Windows.Forms.PictureBox()
            Me.lblPilotGroupText = New System.Windows.Forms.Label()
            Me.pbPilotGroupBG = New System.Windows.Forms.PictureBox()
            Me.lblPilotGroupBG = New System.Windows.Forms.Label()
            Me.btnResetPilotColours = New System.Windows.Forms.Button()
            Me.pbPilotLevel5 = New System.Windows.Forms.PictureBox()
            Me.lblLevel5Colour = New System.Windows.Forms.Label()
            Me.pbPilotPartial = New System.Windows.Forms.PictureBox()
            Me.lblPilotPartiallyTrainedColour = New System.Windows.Forms.Label()
            Me.pbPilotCurrent = New System.Windows.Forms.PictureBox()
            Me.lblPilotCurrentColour = New System.Windows.Forms.Label()
            Me.pbPilotStandard = New System.Windows.Forms.PictureBox()
            Me.lblPilotStandardColour = New System.Windows.Forms.Label()
            Me.gbEveAccounts = New System.Windows.Forms.GroupBox()
            Me.adtAccounts = New DevComponents.AdvTree.AdvTree()
            Me.colAccountName = New DevComponents.AdvTree.ColumnHeader()
            Me.colAccountVersion = New DevComponents.AdvTree.ColumnHeader()
            Me.colAccountUserID = New DevComponents.AdvTree.ColumnHeader()
            Me.colAccountAccessType = New DevComponents.AdvTree.ColumnHeader()
            Me.colAccountStatus = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me.btnDisableAccount = New System.Windows.Forms.Button()
            Me.btnCheckAPIKeys = New System.Windows.Forms.Button()
            Me.btnGetData = New System.Windows.Forms.Button()
            Me.btnDeleteAccount = New System.Windows.Forms.Button()
            Me.btnEditAccount = New System.Windows.Forms.Button()
            Me.btnAddAccount = New System.Windows.Forms.Button()
            Me.gbPilots = New System.Windows.Forms.GroupBox()
            Me.btnCreateBlankPilot = New System.Windows.Forms.Button()
            Me.btnAddPilotFromXML = New System.Windows.Forms.Button()
            Me.btnDeletePilot = New System.Windows.Forms.Button()
            Me.btnAddPilot = New System.Windows.Forms.Button()
            Me.lvwPilots = New DevComponents.DotNetBar.Controls.ListViewEx()
            Me.colPilot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colAccount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.gbEveFolders = New System.Windows.Forms.GroupBox()
            Me.gbLocation4 = New System.Windows.Forms.GroupBox()
            Me.lblFriendlyName4 = New System.Windows.Forms.Label()
            Me.txtFriendlyName4 = New System.Windows.Forms.TextBox()
            Me.lblCacheSize4 = New System.Windows.Forms.Label()
            Me.chkLUA4 = New System.Windows.Forms.CheckBox()
            Me.lblEveDir4 = New System.Windows.Forms.Label()
            Me.btnEveDir4 = New System.Windows.Forms.Button()
            Me.btnClear4 = New System.Windows.Forms.Button()
            Me.gbLocation3 = New System.Windows.Forms.GroupBox()
            Me.lblFriendlyName3 = New System.Windows.Forms.Label()
            Me.txtFriendlyName3 = New System.Windows.Forms.TextBox()
            Me.lblCacheSize3 = New System.Windows.Forms.Label()
            Me.chkLUA3 = New System.Windows.Forms.CheckBox()
            Me.lblEveDir3 = New System.Windows.Forms.Label()
            Me.btnEveDir3 = New System.Windows.Forms.Button()
            Me.btnClear3 = New System.Windows.Forms.Button()
            Me.gbLocation2 = New System.Windows.Forms.GroupBox()
            Me.lblFriendlyName2 = New System.Windows.Forms.Label()
            Me.txtFriendlyName2 = New System.Windows.Forms.TextBox()
            Me.lblCacheSize2 = New System.Windows.Forms.Label()
            Me.chkLUA2 = New System.Windows.Forms.CheckBox()
            Me.lblEveDir2 = New System.Windows.Forms.Label()
            Me.btnEveDir2 = New System.Windows.Forms.Button()
            Me.btnClear2 = New System.Windows.Forms.Button()
            Me.gbLocation1 = New System.Windows.Forms.GroupBox()
            Me.lblFriendlyName1 = New System.Windows.Forms.Label()
            Me.txtFriendlyName1 = New System.Windows.Forms.TextBox()
            Me.lblCacheSize1 = New System.Windows.Forms.Label()
            Me.chkLUA1 = New System.Windows.Forms.CheckBox()
            Me.lblEveDir1 = New System.Windows.Forms.Label()
            Me.btnEveDir1 = New System.Windows.Forms.Button()
            Me.btnClear1 = New System.Windows.Forms.Button()
            Me.gbTrainingQueue = New System.Windows.Forms.GroupBox()
            Me.lblEveQueueDisplayLength = New System.Windows.Forms.Label()
            Me.nudEveQueueDisplayLength = New System.Windows.Forms.NumericUpDown()
            Me.chkStartWithPrimaryQueue = New System.Windows.Forms.CheckBox()
            Me.btnMoveDown = New System.Windows.Forms.Button()
            Me.btnMoveUp = New System.Windows.Forms.Button()
            Me.lvwColumns = New DevComponents.DotNetBar.Controls.ListViewEx()
            Me.colQueueColumns = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.pbPartiallyTrainedColour = New System.Windows.Forms.PictureBox()
            Me.lblPartiallyTrainedColour = New System.Windows.Forms.Label()
            Me.chkDeleteCompletedSkills = New System.Windows.Forms.CheckBox()
            Me.pbReadySkillColour = New System.Windows.Forms.PictureBox()
            Me.lblReadySkillColour = New System.Windows.Forms.Label()
            Me.pbDowntimeClashColour = New System.Windows.Forms.PictureBox()
            Me.lblDowntimeClashColour = New System.Windows.Forms.Label()
            Me.pbBothPreReqColour = New System.Windows.Forms.PictureBox()
            Me.lblBothPreReqColour = New System.Windows.Forms.Label()
            Me.pbHasPreReqColour = New System.Windows.Forms.PictureBox()
            Me.pbIsPreReqColour = New System.Windows.Forms.PictureBox()
            Me.lblHasPreReqColour = New System.Windows.Forms.Label()
            Me.lblIsPreReqColour = New System.Windows.Forms.Label()
            Me.lblSkillQueueColours = New System.Windows.Forms.Label()
            Me.lblQueueColumns = New System.Windows.Forms.Label()
            Me.gbProxyServer = New System.Windows.Forms.GroupBox()
            Me.gbProxyServerInfo = New System.Windows.Forms.GroupBox()
            Me.chkProxyUseBasic = New System.Windows.Forms.CheckBox()
            Me.lblProxyPassword = New System.Windows.Forms.Label()
            Me.lblProxyUsername = New System.Windows.Forms.Label()
            Me.txtProxyPassword = New System.Windows.Forms.TextBox()
            Me.txtProxyUsername = New System.Windows.Forms.TextBox()
            Me.radUseSpecifiedCreds = New System.Windows.Forms.RadioButton()
            Me.lblProxyServer = New System.Windows.Forms.Label()
            Me.txtProxyServer = New System.Windows.Forms.TextBox()
            Me.radUseDefaultCreds = New System.Windows.Forms.RadioButton()
            Me.chkUseProxy = New System.Windows.Forms.CheckBox()
            Me.gbEveServer = New System.Windows.Forms.GroupBox()
            Me.trackServerOffset = New DevComponents.DotNetBar.Controls.Slider()
            Me.chkAutoMailAPI = New System.Windows.Forms.CheckBox()
            Me.gbAPIServer = New System.Windows.Forms.GroupBox()
            Me.txtAPIFileExtension = New System.Windows.Forms.TextBox()
            Me.lblAPIFileExtension = New System.Windows.Forms.Label()
            Me.chkUseCCPBackup = New System.Windows.Forms.CheckBox()
            Me.chkUseAPIRSServer = New System.Windows.Forms.CheckBox()
            Me.txtAPIRSServer = New System.Windows.Forms.TextBox()
            Me.lblAPIRSServer = New System.Windows.Forms.Label()
            Me.txtCCPAPIServer = New System.Windows.Forms.TextBox()
            Me.lblCCPAPIServer = New System.Windows.Forms.Label()
            Me.chkEnableEveStatus = New System.Windows.Forms.CheckBox()
            Me.lblCurrentOffset = New System.Windows.Forms.Label()
            Me.lblServerOffset = New System.Windows.Forms.Label()
            Me.chkAutoAPI = New System.Windows.Forms.CheckBox()
            Me.gbPlugIns = New System.Windows.Forms.GroupBox()
            Me.btnTidyPlugins = New System.Windows.Forms.Button()
            Me.btnRefreshPlugins = New System.Windows.Forms.Button()
            Me.lblPlugInInfo = New System.Windows.Forms.Label()
            Me.lblDetectedPlugIns = New System.Windows.Forms.Label()
            Me.lvwPlugins = New DevComponents.DotNetBar.Controls.ListViewEx()
            Me.colPlugInName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.gbNotifications = New System.Windows.Forms.GroupBox()
            Me.nudAccountTimeLimit = New System.Windows.Forms.NumericUpDown()
            Me.lblAccountTimeLimit = New System.Windows.Forms.Label()
            Me.chkNotifyAccountTime = New System.Windows.Forms.CheckBox()
            Me.chkNotifyInsuffClone = New System.Windows.Forms.CheckBox()
            Me.sldNotifyOffset = New DevComponents.DotNetBar.Controls.Slider()
            Me.chkIgnoreLastMessage = New System.Windows.Forms.CheckBox()
            Me.chkNotifyNotification = New System.Windows.Forms.CheckBox()
            Me.chkNotifyEveMail = New System.Windows.Forms.CheckBox()
            Me.chkNotifyEarly = New System.Windows.Forms.CheckBox()
            Me.chkNotifyNow = New System.Windows.Forms.CheckBox()
            Me.lblNotifyMe = New System.Windows.Forms.Label()
            Me.btnSoundTest = New System.Windows.Forms.Button()
            Me.btnSelectSoundFile = New System.Windows.Forms.Button()
            Me.lblSoundFile = New System.Windows.Forms.Label()
            Me.chkNotifySound = New System.Windows.Forms.CheckBox()
            Me.lblNotifyOffset = New System.Windows.Forms.Label()
            Me.chkNotifyEmail = New System.Windows.Forms.CheckBox()
            Me.chkNotifyDialog = New System.Windows.Forms.CheckBox()
            Me.chkNotifyToolTip = New System.Windows.Forms.CheckBox()
            Me.nudShutdownNotifyPeriod = New System.Windows.Forms.NumericUpDown()
            Me.lblShutdownNotifyPeriod = New System.Windows.Forms.Label()
            Me.chkShutdownNotify = New System.Windows.Forms.CheckBox()
            Me.gbEmail = New System.Windows.Forms.GroupBox()
            Me.chkUseSSL = New System.Windows.Forms.CheckBox()
            Me.lblSenderAddress = New System.Windows.Forms.Label()
            Me.txtSenderAddress = New System.Windows.Forms.TextBox()
            Me.txtSMTPPort = New System.Windows.Forms.TextBox()
            Me.lblSMTPPort = New System.Windows.Forms.Label()
            Me.btnTestEmail = New System.Windows.Forms.Button()
            Me.lblEmailPassword = New System.Windows.Forms.Label()
            Me.txtEmailPassword = New System.Windows.Forms.TextBox()
            Me.txtEmailUsername = New System.Windows.Forms.TextBox()
            Me.lblEmailUsername = New System.Windows.Forms.Label()
            Me.chkSMTPAuthentication = New System.Windows.Forms.CheckBox()
            Me.lblEMailAddress = New System.Windows.Forms.Label()
            Me.txtEmailAddress = New System.Windows.Forms.TextBox()
            Me.txtSMTPServer = New System.Windows.Forms.TextBox()
            Me.lblSMTPServer = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.fbd1 = New System.Windows.Forms.FolderBrowserDialog()
            Me.ofd1 = New System.Windows.Forms.OpenFileDialog()
            Me.tvwSettings = New System.Windows.Forms.TreeView()
            Me.gbColours = New System.Windows.Forms.GroupBox()
            Me.txtCSVSeparator = New System.Windows.Forms.TextBox()
            Me.lblCSVSeparatorChar = New System.Windows.Forms.Label()
            Me.chkDisableVisualStyles = New System.Windows.Forms.CheckBox()
            Me.cd1 = New System.Windows.Forms.ColorDialog()
            Me.gbG15 = New System.Windows.Forms.GroupBox()
            Me.nudCycleTime = New System.Windows.Forms.NumericUpDown()
            Me.lblCycleTime = New System.Windows.Forms.Label()
            Me.chkCyclePilots = New System.Windows.Forms.CheckBox()
            Me.chkActivateG15 = New System.Windows.Forms.CheckBox()
            Me.ctxPrices = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.mnuPriceItemName = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuPriceAdd = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuPriceEdit = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuPriceDelete = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbTaskbarIcon = New System.Windows.Forms.GroupBox()
            Me.cboTaskbarIconMode = New System.Windows.Forms.ComboBox()
            Me.lblTaskbarIconMode = New System.Windows.Forms.Label()
            Me.gbDashboard = New System.Windows.Forms.GroupBox()
            Me.cboTickerLocation = New System.Windows.Forms.ComboBox()
            Me.lblTickerLocation = New System.Windows.Forms.Label()
            Me.dbDashboardConfig = New System.Windows.Forms.GroupBox()
            Me.lblWidgetTypes = New System.Windows.Forms.Label()
            Me.cboWidgets = New System.Windows.Forms.ComboBox()
            Me.btnAddWidget = New System.Windows.Forms.Button()
            Me.btnRemoveWidget = New System.Windows.Forms.Button()
            Me.lvWidgets = New DevComponents.DotNetBar.Controls.ListViewEx()
            Me.colWidgetType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colWidgetInfo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.lblCurrentWidgets = New System.Windows.Forms.Label()
            Me.chkShowPriceTicker = New System.Windows.Forms.CheckBox()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.panelSettings = New DevComponents.DotNetBar.PanelEx()
            Me.gbItemOverrides = New System.Windows.Forms.GroupBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me._itemOverrideSellOrders = New System.Windows.Forms.RadioButton()
            Me._itemOverrideBuyOrders = New System.Windows.Forms.RadioButton()
            Me._itemOverrideAllOrders = New System.Windows.Forms.RadioButton()
            Me.Label10 = New System.Windows.Forms.Label()
            Me._itemOverridesActiveGrid = New DevComponents.AdvTree.AdvTree()
            Me._itemOverridesActiveGridNameColumn = New DevComponents.AdvTree.ColumnHeader()
            Me._itemOverridesActiveGridItemIdColumn = New DevComponents.AdvTree.ColumnHeader()
            Me._itemOverridesActiveGridOrderTypeColumn = New DevComponents.AdvTree.ColumnHeader()
            Me._itemOverridesActiveGridMetricColumn = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector2 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle2 = New DevComponents.DotNetBar.ElementStyle()
            Me._itemOverrideRemoveOverride = New System.Windows.Forms.Button()
            Me._itemOverrideAddOverride = New System.Windows.Forms.Button()
            Me._itemOverrideItemList = New System.Windows.Forms.ComboBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me._itemOverridePercentPrice = New System.Windows.Forms.RadioButton()
            Me.Label7 = New System.Windows.Forms.Label()
            Me._itemOverrideMedianPrice = New System.Windows.Forms.RadioButton()
            Me._itemOverrideMinPrice = New System.Windows.Forms.RadioButton()
            Me._itemOverrideAvgPrice = New System.Windows.Forms.RadioButton()
            Me._itemOverrideMaxPrice = New System.Windows.Forms.RadioButton()
            Me.gbMarket = New System.Windows.Forms.GroupBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me._defaultAll = New System.Windows.Forms.RadioButton()
            Me._defaultBuy = New System.Windows.Forms.RadioButton()
            Me._defaultSell = New System.Windows.Forms.RadioButton()
            Me.enableMarketDataUpload = New System.Windows.Forms.CheckBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me._systemList = New System.Windows.Forms.ListBox()
            Me._regionList = New System.Windows.Forms.ListBox()
            Me._useSystemPrice = New System.Windows.Forms.RadioButton()
            Me._useRegionData = New System.Windows.Forms.RadioButton()
            Me._usePercentile = New System.Windows.Forms.RadioButton()
            Me._useMedianPrice = New System.Windows.Forms.RadioButton()
            Me._useAveragePrice = New System.Windows.Forms.RadioButton()
            Me._useMaximumPrice = New System.Windows.Forms.RadioButton()
            Me._useMiniumPrice = New System.Windows.Forms.RadioButton()
            Me.Label5 = New System.Windows.Forms.Label()
            Me._marketDataProvider = New System.Windows.Forms.ComboBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.gpNav = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.STT = New DevComponents.DotNetBar.SuperTooltip()
            Me.gbGeneral.SuspendLayout()
            CType(Me.nudAutomaticSaveTime, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbPilotScreenColours.SuspendLayout()
            CType(Me.pbPilotSkillHighlight, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbPilotSkillText, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbPilotGroupText, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbPilotGroupBG, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbPilotLevel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbPilotPartial, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbPilotCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbPilotStandard, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbEveAccounts.SuspendLayout()
            CType(Me.adtAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbPilots.SuspendLayout()
            Me.gbEveFolders.SuspendLayout()
            Me.gbLocation4.SuspendLayout()
            Me.gbLocation3.SuspendLayout()
            Me.gbLocation2.SuspendLayout()
            Me.gbLocation1.SuspendLayout()
            Me.gbTrainingQueue.SuspendLayout()
            CType(Me.nudEveQueueDisplayLength, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbPartiallyTrainedColour, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbReadySkillColour, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbDowntimeClashColour, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbBothPreReqColour, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbHasPreReqColour, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbIsPreReqColour, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbProxyServer.SuspendLayout()
            Me.gbProxyServerInfo.SuspendLayout()
            Me.gbEveServer.SuspendLayout()
            Me.gbAPIServer.SuspendLayout()
            Me.gbPlugIns.SuspendLayout()
            Me.gbNotifications.SuspendLayout()
            CType(Me.nudAccountTimeLimit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudShutdownNotifyPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbEmail.SuspendLayout()
            Me.gbColours.SuspendLayout()
            Me.gbG15.SuspendLayout()
            CType(Me.nudCycleTime, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ctxPrices.SuspendLayout()
            Me.gbTaskbarIcon.SuspendLayout()
            Me.gbDashboard.SuspendLayout()
            Me.dbDashboardConfig.SuspendLayout()
            Me.panelSettings.SuspendLayout()
            Me.gbItemOverrides.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me._itemOverridesActiveGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbMarket.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.gpNav.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbGeneral
            '
            Me.gbGeneral.Controls.Add(Me.chkViewSkillTraining)
            Me.gbGeneral.Controls.Add(Me.chkViewMarketPrices)
            Me.gbGeneral.Controls.Add(Me.chkViewDashboard)
            Me.gbGeneral.Controls.Add(Me.chkViewRequisitions)
            Me.gbGeneral.Controls.Add(Me.chkViewPilotSummary)
            Me.gbGeneral.Controls.Add(Me.chkViewPilotInfo)
            Me.gbGeneral.Controls.Add(Me.lblAutomaticSaveTime)
            Me.gbGeneral.Controls.Add(Me.nudAutomaticSaveTime)
            Me.gbGeneral.Controls.Add(Me.chkEnableAutomaticSave)
            Me.gbGeneral.Controls.Add(Me.chkDisableTrainingBar)
            Me.gbGeneral.Controls.Add(Me.chkDisableAutoConnections)
            Me.gbGeneral.Controls.Add(Me.lblMDITabPosition)
            Me.gbGeneral.Controls.Add(Me.cboMDITabPosition)
            Me.gbGeneral.Controls.Add(Me.txtErrorRepEmail)
            Me.gbGeneral.Controls.Add(Me.lblErrorRepEmail)
            Me.gbGeneral.Controls.Add(Me.txtErrorRepName)
            Me.gbGeneral.Controls.Add(Me.lblErrorRepName)
            Me.gbGeneral.Controls.Add(Me.chkErrorReporting)
            Me.gbGeneral.Controls.Add(Me.txtUpdateLocation)
            Me.gbGeneral.Controls.Add(Me.lblUpdateLocation)
            Me.gbGeneral.Controls.Add(Me.chkMinimiseOnExit)
            Me.gbGeneral.Controls.Add(Me.cboStartupPilot)
            Me.gbGeneral.Controls.Add(Me.Label3)
            Me.gbGeneral.Controls.Add(Me.Label2)
            Me.gbGeneral.Controls.Add(Me.chkAutoMinimise)
            Me.gbGeneral.Controls.Add(Me.chkAutoRun)
            Me.gbGeneral.Controls.Add(Me.chkAutoHide)
            Me.gbGeneral.Location = New System.Drawing.Point(557, 187)
            Me.gbGeneral.Name = "gbGeneral"
            Me.gbGeneral.Size = New System.Drawing.Size(125, 29)
            Me.gbGeneral.TabIndex = 1
            Me.gbGeneral.TabStop = False
            Me.gbGeneral.Text = "General Settings"
            Me.gbGeneral.Visible = False
            '
            'chkViewSkillTraining
            '
            Me.chkViewSkillTraining.AutoSize = True
            Me.chkViewSkillTraining.Location = New System.Drawing.Point(349, 82)
            Me.chkViewSkillTraining.Name = "chkViewSkillTraining"
            Me.chkViewSkillTraining.Size = New System.Drawing.Size(84, 17)
            Me.chkViewSkillTraining.TabIndex = 61
            Me.chkViewSkillTraining.Tag = "2"
            Me.chkViewSkillTraining.Text = "Skill Training"
            Me.chkViewSkillTraining.UseVisualStyleBackColor = True
            '
            'chkViewMarketPrices
            '
            Me.chkViewMarketPrices.AutoSize = True
            Me.chkViewMarketPrices.Location = New System.Drawing.Point(349, 105)
            Me.chkViewMarketPrices.Name = "chkViewMarketPrices"
            Me.chkViewMarketPrices.Size = New System.Drawing.Size(90, 17)
            Me.chkViewMarketPrices.TabIndex = 60
            Me.chkViewMarketPrices.Tag = "4"
            Me.chkViewMarketPrices.Text = "Market Prices"
            Me.chkViewMarketPrices.UseVisualStyleBackColor = True
            '
            'chkViewDashboard
            '
            Me.chkViewDashboard.AutoSize = True
            Me.chkViewDashboard.Location = New System.Drawing.Point(349, 128)
            Me.chkViewDashboard.Name = "chkViewDashboard"
            Me.chkViewDashboard.Size = New System.Drawing.Size(78, 17)
            Me.chkViewDashboard.TabIndex = 59
            Me.chkViewDashboard.Tag = "8"
            Me.chkViewDashboard.Text = "Dashboard"
            Me.chkViewDashboard.UseVisualStyleBackColor = True
            '
            'chkViewRequisitions
            '
            Me.chkViewRequisitions.AutoSize = True
            Me.chkViewRequisitions.Location = New System.Drawing.Point(349, 151)
            Me.chkViewRequisitions.Name = "chkViewRequisitions"
            Me.chkViewRequisitions.Size = New System.Drawing.Size(83, 17)
            Me.chkViewRequisitions.TabIndex = 58
            Me.chkViewRequisitions.Tag = "16"
            Me.chkViewRequisitions.Text = "Requisitions"
            Me.chkViewRequisitions.UseVisualStyleBackColor = True
            '
            'chkViewPilotSummary
            '
            Me.chkViewPilotSummary.AutoSize = True
            Me.chkViewPilotSummary.Location = New System.Drawing.Point(349, 174)
            Me.chkViewPilotSummary.Name = "chkViewPilotSummary"
            Me.chkViewPilotSummary.Size = New System.Drawing.Size(129, 17)
            Me.chkViewPilotSummary.TabIndex = 57
            Me.chkViewPilotSummary.Tag = "32"
            Me.chkViewPilotSummary.Text = "Pilot Summary Report"
            Me.chkViewPilotSummary.UseVisualStyleBackColor = True
            '
            'chkViewPilotInfo
            '
            Me.chkViewPilotInfo.AutoSize = True
            Me.chkViewPilotInfo.Location = New System.Drawing.Point(349, 59)
            Me.chkViewPilotInfo.Name = "chkViewPilotInfo"
            Me.chkViewPilotInfo.Size = New System.Drawing.Size(105, 17)
            Me.chkViewPilotInfo.TabIndex = 56
            Me.chkViewPilotInfo.Tag = "1"
            Me.chkViewPilotInfo.Text = "Pilot Information"
            Me.chkViewPilotInfo.UseVisualStyleBackColor = True
            '
            'lblAutomaticSaveTime
            '
            Me.lblAutomaticSaveTime.AutoSize = True
            Me.lblAutomaticSaveTime.Location = New System.Drawing.Point(265, 174)
            Me.lblAutomaticSaveTime.Name = "lblAutomaticSaveTime"
            Me.lblAutomaticSaveTime.Size = New System.Drawing.Size(44, 13)
            Me.lblAutomaticSaveTime.TabIndex = 55
            Me.lblAutomaticSaveTime.Text = "minutes"
            '
            'nudAutomaticSaveTime
            '
            Me.nudAutomaticSaveTime.Location = New System.Drawing.Point(200, 170)
            Me.nudAutomaticSaveTime.Maximum = New Decimal(New Integer() {10080, 0, 0, 0})
            Me.nudAutomaticSaveTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudAutomaticSaveTime.Name = "nudAutomaticSaveTime"
            Me.nudAutomaticSaveTime.Size = New System.Drawing.Size(63, 21)
            Me.nudAutomaticSaveTime.TabIndex = 54
            Me.nudAutomaticSaveTime.Value = New Decimal(New Integer() {60, 0, 0, 0})
            '
            'chkEnableAutomaticSave
            '
            Me.chkEnableAutomaticSave.AutoSize = True
            Me.chkEnableAutomaticSave.Location = New System.Drawing.Point(24, 172)
            Me.chkEnableAutomaticSave.Name = "chkEnableAutomaticSave"
            Me.chkEnableAutomaticSave.Size = New System.Drawing.Size(175, 17)
            Me.chkEnableAutomaticSave.TabIndex = 53
            Me.chkEnableAutomaticSave.Text = "Enable Automatic Saving every"
            Me.chkEnableAutomaticSave.UseVisualStyleBackColor = True
            '
            'chkDisableTrainingBar
            '
            Me.chkDisableTrainingBar.AutoSize = True
            Me.chkDisableTrainingBar.Location = New System.Drawing.Point(24, 149)
            Me.chkDisableTrainingBar.Name = "chkDisableTrainingBar"
            Me.chkDisableTrainingBar.Size = New System.Drawing.Size(120, 17)
            Me.chkDisableTrainingBar.TabIndex = 52
            Me.chkDisableTrainingBar.Text = "Disable Training Bar"
            Me.chkDisableTrainingBar.UseVisualStyleBackColor = True
            '
            'chkDisableAutoConnections
            '
            Me.chkDisableAutoConnections.AutoSize = True
            Me.chkDisableAutoConnections.Location = New System.Drawing.Point(24, 126)
            Me.chkDisableAutoConnections.Name = "chkDisableAutoConnections"
            Me.chkDisableAutoConnections.Size = New System.Drawing.Size(198, 17)
            Me.chkDisableAutoConnections.TabIndex = 51
            Me.chkDisableAutoConnections.Text = "Disable Automatic Web Connections"
            Me.chkDisableAutoConnections.UseVisualStyleBackColor = True
            '
            'lblMDITabPosition
            '
            Me.lblMDITabPosition.AutoSize = True
            Me.lblMDITabPosition.Location = New System.Drawing.Point(21, 230)
            Me.lblMDITabPosition.Name = "lblMDITabPosition"
            Me.lblMDITabPosition.Size = New System.Drawing.Size(91, 13)
            Me.lblMDITabPosition.TabIndex = 46
            Me.lblMDITabPosition.Text = "MDI Tab Position:"
            '
            'cboMDITabPosition
            '
            Me.cboMDITabPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboMDITabPosition.FormattingEnabled = True
            Me.cboMDITabPosition.Items.AddRange(New Object() {"Bottom", "Top"})
            Me.cboMDITabPosition.Location = New System.Drawing.Point(119, 227)
            Me.cboMDITabPosition.Name = "cboMDITabPosition"
            Me.cboMDITabPosition.Size = New System.Drawing.Size(161, 21)
            Me.cboMDITabPosition.Sorted = True
            Me.cboMDITabPosition.TabIndex = 45
            '
            'txtErrorRepEmail
            '
            Me.txtErrorRepEmail.Enabled = False
            Me.txtErrorRepEmail.Location = New System.Drawing.Point(119, 352)
            Me.txtErrorRepEmail.Name = "txtErrorRepEmail"
            Me.txtErrorRepEmail.Size = New System.Drawing.Size(247, 21)
            Me.txtErrorRepEmail.TabIndex = 44
            '
            'lblErrorRepEmail
            '
            Me.lblErrorRepEmail.AutoSize = True
            Me.lblErrorRepEmail.Enabled = False
            Me.lblErrorRepEmail.Location = New System.Drawing.Point(24, 355)
            Me.lblErrorRepEmail.Name = "lblErrorRepEmail"
            Me.lblErrorRepEmail.Size = New System.Drawing.Size(86, 13)
            Me.lblErrorRepEmail.TabIndex = 43
            Me.lblErrorRepEmail.Text = "Email (Optional):"
            '
            'txtErrorRepName
            '
            Me.txtErrorRepName.Enabled = False
            Me.txtErrorRepName.Location = New System.Drawing.Point(119, 325)
            Me.txtErrorRepName.Name = "txtErrorRepName"
            Me.txtErrorRepName.Size = New System.Drawing.Size(247, 21)
            Me.txtErrorRepName.TabIndex = 42
            '
            'lblErrorRepName
            '
            Me.lblErrorRepName.AutoSize = True
            Me.lblErrorRepName.Enabled = False
            Me.lblErrorRepName.Location = New System.Drawing.Point(24, 328)
            Me.lblErrorRepName.Name = "lblErrorRepName"
            Me.lblErrorRepName.Size = New System.Drawing.Size(89, 13)
            Me.lblErrorRepName.TabIndex = 41
            Me.lblErrorRepName.Text = "Name (Optional):"
            '
            'chkErrorReporting
            '
            Me.chkErrorReporting.AutoSize = True
            Me.chkErrorReporting.Location = New System.Drawing.Point(21, 302)
            Me.chkErrorReporting.Name = "chkErrorReporting"
            Me.chkErrorReporting.Size = New System.Drawing.Size(190, 17)
            Me.chkErrorReporting.TabIndex = 40
            Me.chkErrorReporting.Text = "Enable Integrated Error Reporting"
            Me.chkErrorReporting.UseVisualStyleBackColor = True
            '
            'txtUpdateLocation
            '
            Me.txtUpdateLocation.Location = New System.Drawing.Point(119, 258)
            Me.txtUpdateLocation.Name = "txtUpdateLocation"
            Me.txtUpdateLocation.Size = New System.Drawing.Size(449, 21)
            Me.txtUpdateLocation.TabIndex = 39
            '
            'lblUpdateLocation
            '
            Me.lblUpdateLocation.AutoSize = True
            Me.lblUpdateLocation.Location = New System.Drawing.Point(20, 261)
            Me.lblUpdateLocation.Name = "lblUpdateLocation"
            Me.lblUpdateLocation.Size = New System.Drawing.Size(89, 13)
            Me.lblUpdateLocation.TabIndex = 38
            Me.lblUpdateLocation.Text = "Update Location:"
            '
            'chkMinimiseOnExit
            '
            Me.chkMinimiseOnExit.AutoSize = True
            Me.chkMinimiseOnExit.Location = New System.Drawing.Point(24, 80)
            Me.chkMinimiseOnExit.Name = "chkMinimiseOnExit"
            Me.chkMinimiseOnExit.Size = New System.Drawing.Size(101, 17)
            Me.chkMinimiseOnExit.TabIndex = 11
            Me.chkMinimiseOnExit.Text = "Minimise on Exit"
            Me.chkMinimiseOnExit.UseVisualStyleBackColor = True
            '
            'cboStartupPilot
            '
            Me.cboStartupPilot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboStartupPilot.FormattingEnabled = True
            Me.cboStartupPilot.Location = New System.Drawing.Point(119, 200)
            Me.cboStartupPilot.Name = "cboStartupPilot"
            Me.cboStartupPilot.Size = New System.Drawing.Size(161, 21)
            Me.cboStartupPilot.Sorted = True
            Me.cboStartupPilot.TabIndex = 7
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(21, 203)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(69, 13)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "Default Pilot:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(313, 35)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(87, 13)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "View on Startup:"
            '
            'chkAutoMinimise
            '
            Me.chkAutoMinimise.AutoSize = True
            Me.chkAutoMinimise.Location = New System.Drawing.Point(24, 57)
            Me.chkAutoMinimise.Name = "chkAutoMinimise"
            Me.chkAutoMinimise.Size = New System.Drawing.Size(164, 17)
            Me.chkAutoMinimise.TabIndex = 1
            Me.chkAutoMinimise.Text = "Minimise When EveHQ Starts"
            Me.chkAutoMinimise.UseVisualStyleBackColor = True
            '
            'chkAutoRun
            '
            Me.chkAutoRun.AutoSize = True
            Me.chkAutoRun.Location = New System.Drawing.Point(24, 103)
            Me.chkAutoRun.Name = "chkAutoRun"
            Me.chkAutoRun.Size = New System.Drawing.Size(181, 17)
            Me.chkAutoRun.TabIndex = 2
            Me.chkAutoRun.Text = "Run EveHQ on Windows Startup"
            Me.chkAutoRun.UseVisualStyleBackColor = True
            '
            'chkAutoHide
            '
            Me.chkAutoHide.AutoSize = True
            Me.chkAutoHide.Location = New System.Drawing.Point(24, 34)
            Me.chkAutoHide.Name = "chkAutoHide"
            Me.chkAutoHide.Size = New System.Drawing.Size(247, 17)
            Me.chkAutoHide.TabIndex = 0
            Me.chkAutoHide.Text = "Hide EveHQ from the Taskbar when Minimising"
            Me.chkAutoHide.UseVisualStyleBackColor = True
            '
            'gbPilotScreenColours
            '
            Me.gbPilotScreenColours.Controls.Add(Me.pbPilotSkillHighlight)
            Me.gbPilotScreenColours.Controls.Add(Me.lblPilotSkillHighlight)
            Me.gbPilotScreenColours.Controls.Add(Me.pbPilotSkillText)
            Me.gbPilotScreenColours.Controls.Add(Me.lblPilotSkillText)
            Me.gbPilotScreenColours.Controls.Add(Me.pbPilotGroupText)
            Me.gbPilotScreenColours.Controls.Add(Me.lblPilotGroupText)
            Me.gbPilotScreenColours.Controls.Add(Me.pbPilotGroupBG)
            Me.gbPilotScreenColours.Controls.Add(Me.lblPilotGroupBG)
            Me.gbPilotScreenColours.Controls.Add(Me.btnResetPilotColours)
            Me.gbPilotScreenColours.Controls.Add(Me.pbPilotLevel5)
            Me.gbPilotScreenColours.Controls.Add(Me.lblLevel5Colour)
            Me.gbPilotScreenColours.Controls.Add(Me.pbPilotPartial)
            Me.gbPilotScreenColours.Controls.Add(Me.lblPilotPartiallyTrainedColour)
            Me.gbPilotScreenColours.Controls.Add(Me.pbPilotCurrent)
            Me.gbPilotScreenColours.Controls.Add(Me.lblPilotCurrentColour)
            Me.gbPilotScreenColours.Controls.Add(Me.pbPilotStandard)
            Me.gbPilotScreenColours.Controls.Add(Me.lblPilotStandardColour)
            Me.gbPilotScreenColours.Location = New System.Drawing.Point(17, 26)
            Me.gbPilotScreenColours.Name = "gbPilotScreenColours"
            Me.gbPilotScreenColours.Size = New System.Drawing.Size(215, 257)
            Me.gbPilotScreenColours.TabIndex = 37
            Me.gbPilotScreenColours.TabStop = False
            Me.gbPilotScreenColours.Text = "Pilot Screen Skill Colours"
            '
            'pbPilotSkillHighlight
            '
            Me.pbPilotSkillHighlight.BackColor = System.Drawing.Color.DodgerBlue
            Me.pbPilotSkillHighlight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pbPilotSkillHighlight.Location = New System.Drawing.Point(159, 96)
            Me.pbPilotSkillHighlight.Name = "pbPilotSkillHighlight"
            Me.pbPilotSkillHighlight.Size = New System.Drawing.Size(24, 24)
            Me.pbPilotSkillHighlight.TabIndex = 60
            Me.pbPilotSkillHighlight.TabStop = False
            '
            'lblPilotSkillHighlight
            '
            Me.lblPilotSkillHighlight.AutoSize = True
            Me.lblPilotSkillHighlight.Location = New System.Drawing.Point(13, 99)
            Me.lblPilotSkillHighlight.Name = "lblPilotSkillHighlight"
            Me.lblPilotSkillHighlight.Size = New System.Drawing.Size(68, 13)
            Me.lblPilotSkillHighlight.TabIndex = 59
            Me.lblPilotSkillHighlight.Text = "Skill Highlight"
            '
            'pbPilotSkillText
            '
            Me.pbPilotSkillText.BackColor = System.Drawing.Color.Black
            Me.pbPilotSkillText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pbPilotSkillText.Location = New System.Drawing.Point(159, 72)
            Me.pbPilotSkillText.Name = "pbPilotSkillText"
            Me.pbPilotSkillText.Size = New System.Drawing.Size(24, 24)
            Me.pbPilotSkillText.TabIndex = 58
            Me.pbPilotSkillText.TabStop = False
            '
            'lblPilotSkillText
            '
            Me.lblPilotSkillText.AutoSize = True
            Me.lblPilotSkillText.Location = New System.Drawing.Point(13, 75)
            Me.lblPilotSkillText.Name = "lblPilotSkillText"
            Me.lblPilotSkillText.Size = New System.Drawing.Size(49, 13)
            Me.lblPilotSkillText.TabIndex = 57
            Me.lblPilotSkillText.Text = "Skill Text"
            '
            'pbPilotGroupText
            '
            Me.pbPilotGroupText.BackColor = System.Drawing.Color.White
            Me.pbPilotGroupText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pbPilotGroupText.Location = New System.Drawing.Point(159, 48)
            Me.pbPilotGroupText.Name = "pbPilotGroupText"
            Me.pbPilotGroupText.Size = New System.Drawing.Size(24, 24)
            Me.pbPilotGroupText.TabIndex = 56
            Me.pbPilotGroupText.TabStop = False
            '
            'lblPilotGroupText
            '
            Me.lblPilotGroupText.AutoSize = True
            Me.lblPilotGroupText.Location = New System.Drawing.Point(13, 51)
            Me.lblPilotGroupText.Name = "lblPilotGroupText"
            Me.lblPilotGroupText.Size = New System.Drawing.Size(61, 13)
            Me.lblPilotGroupText.TabIndex = 55
            Me.lblPilotGroupText.Text = "Group Text"
            '
            'pbPilotGroupBG
            '
            Me.pbPilotGroupBG.BackColor = System.Drawing.Color.DimGray
            Me.pbPilotGroupBG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pbPilotGroupBG.Location = New System.Drawing.Point(159, 24)
            Me.pbPilotGroupBG.Name = "pbPilotGroupBG"
            Me.pbPilotGroupBG.Size = New System.Drawing.Size(24, 24)
            Me.pbPilotGroupBG.TabIndex = 54
            Me.pbPilotGroupBG.TabStop = False
            '
            'lblPilotGroupBG
            '
            Me.lblPilotGroupBG.AutoSize = True
            Me.lblPilotGroupBG.Location = New System.Drawing.Point(13, 27)
            Me.lblPilotGroupBG.Name = "lblPilotGroupBG"
            Me.lblPilotGroupBG.Size = New System.Drawing.Size(95, 13)
            Me.lblPilotGroupBG.TabIndex = 53
            Me.lblPilotGroupBG.Text = "Group Background"
            '
            'btnResetPilotColours
            '
            Me.btnResetPilotColours.Location = New System.Drawing.Point(39, 222)
            Me.btnResetPilotColours.Name = "btnResetPilotColours"
            Me.btnResetPilotColours.Size = New System.Drawing.Size(145, 23)
            Me.btnResetPilotColours.TabIndex = 52
            Me.btnResetPilotColours.Text = "Reset To Defaults"
            Me.btnResetPilotColours.UseVisualStyleBackColor = True
            '
            'pbPilotLevel5
            '
            Me.pbPilotLevel5.BackColor = System.Drawing.Color.Thistle
            Me.pbPilotLevel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pbPilotLevel5.Location = New System.Drawing.Point(159, 192)
            Me.pbPilotLevel5.Name = "pbPilotLevel5"
            Me.pbPilotLevel5.Size = New System.Drawing.Size(24, 24)
            Me.pbPilotLevel5.TabIndex = 43
            Me.pbPilotLevel5.TabStop = False
            '
            'lblLevel5Colour
            '
            Me.lblLevel5Colour.AutoSize = True
            Me.lblLevel5Colour.Location = New System.Drawing.Point(13, 195)
            Me.lblLevel5Colour.Name = "lblLevel5Colour"
            Me.lblLevel5Colour.Size = New System.Drawing.Size(61, 13)
            Me.lblLevel5Colour.TabIndex = 42
            Me.lblLevel5Colour.Text = "Level 5 Skill"
            '
            'pbPilotPartial
            '
            Me.pbPilotPartial.BackColor = System.Drawing.Color.Gold
            Me.pbPilotPartial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pbPilotPartial.Location = New System.Drawing.Point(159, 168)
            Me.pbPilotPartial.Name = "pbPilotPartial"
            Me.pbPilotPartial.Size = New System.Drawing.Size(24, 24)
            Me.pbPilotPartial.TabIndex = 41
            Me.pbPilotPartial.TabStop = False
            '
            'lblPilotPartiallyTrainedColour
            '
            Me.lblPilotPartiallyTrainedColour.AutoSize = True
            Me.lblPilotPartiallyTrainedColour.Location = New System.Drawing.Point(13, 171)
            Me.lblPilotPartiallyTrainedColour.Name = "lblPilotPartiallyTrainedColour"
            Me.lblPilotPartiallyTrainedColour.Size = New System.Drawing.Size(104, 13)
            Me.lblPilotPartiallyTrainedColour.TabIndex = 40
            Me.lblPilotPartiallyTrainedColour.Text = "Partially Trained Skill"
            '
            'pbPilotCurrent
            '
            Me.pbPilotCurrent.BackColor = System.Drawing.Color.LimeGreen
            Me.pbPilotCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pbPilotCurrent.Location = New System.Drawing.Point(159, 144)
            Me.pbPilotCurrent.Name = "pbPilotCurrent"
            Me.pbPilotCurrent.Size = New System.Drawing.Size(24, 24)
            Me.pbPilotCurrent.TabIndex = 39
            Me.pbPilotCurrent.TabStop = False
            '
            'lblPilotCurrentColour
            '
            Me.lblPilotCurrentColour.AutoSize = True
            Me.lblPilotCurrentColour.Location = New System.Drawing.Point(13, 147)
            Me.lblPilotCurrentColour.Name = "lblPilotCurrentColour"
            Me.lblPilotCurrentColour.Size = New System.Drawing.Size(105, 13)
            Me.lblPilotCurrentColour.TabIndex = 38
            Me.lblPilotCurrentColour.Text = "Current Training Skill"
            '
            'pbPilotStandard
            '
            Me.pbPilotStandard.BackColor = System.Drawing.Color.White
            Me.pbPilotStandard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pbPilotStandard.Location = New System.Drawing.Point(159, 120)
            Me.pbPilotStandard.Name = "pbPilotStandard"
            Me.pbPilotStandard.Size = New System.Drawing.Size(24, 24)
            Me.pbPilotStandard.TabIndex = 37
            Me.pbPilotStandard.TabStop = False
            '
            'lblPilotStandardColour
            '
            Me.lblPilotStandardColour.AutoSize = True
            Me.lblPilotStandardColour.Location = New System.Drawing.Point(13, 123)
            Me.lblPilotStandardColour.Name = "lblPilotStandardColour"
            Me.lblPilotStandardColour.Size = New System.Drawing.Size(71, 13)
            Me.lblPilotStandardColour.TabIndex = 36
            Me.lblPilotStandardColour.Text = "Standard Skill"
            '
            'gbEveAccounts
            '
            Me.gbEveAccounts.BackColor = System.Drawing.Color.Transparent
            Me.gbEveAccounts.Controls.Add(Me.adtAccounts)
            Me.gbEveAccounts.Controls.Add(Me.btnDisableAccount)
            Me.gbEveAccounts.Controls.Add(Me.btnCheckAPIKeys)
            Me.gbEveAccounts.Controls.Add(Me.btnGetData)
            Me.gbEveAccounts.Controls.Add(Me.btnDeleteAccount)
            Me.gbEveAccounts.Controls.Add(Me.btnEditAccount)
            Me.gbEveAccounts.Controls.Add(Me.btnAddAccount)
            Me.gbEveAccounts.Location = New System.Drawing.Point(419, 294)
            Me.gbEveAccounts.Name = "gbEveAccounts"
            Me.gbEveAccounts.Size = New System.Drawing.Size(185, 76)
            Me.gbEveAccounts.TabIndex = 16
            Me.gbEveAccounts.TabStop = False
            Me.gbEveAccounts.Text = "API Account Management"
            Me.gbEveAccounts.Visible = False
            '
            'adtAccounts
            '
            Me.adtAccounts.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtAccounts.AllowDrop = True
            Me.adtAccounts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.adtAccounts.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtAccounts.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtAccounts.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtAccounts.Columns.Add(Me.colAccountName)
            Me.adtAccounts.Columns.Add(Me.colAccountVersion)
            Me.adtAccounts.Columns.Add(Me.colAccountUserID)
            Me.adtAccounts.Columns.Add(Me.colAccountAccessType)
            Me.adtAccounts.Columns.Add(Me.colAccountStatus)
            Me.adtAccounts.ExpandWidth = 0
            
            Me.adtAccounts.Location = New System.Drawing.Point(12, 20)
            Me.adtAccounts.Name = "adtAccounts"
            Me.adtAccounts.NodesConnector = Me.NodeConnector1
            Me.adtAccounts.NodeStyle = Me.ElementStyle1
            Me.adtAccounts.PathSeparator = ";"
            Me.adtAccounts.Size = New System.Drawing.Size(164, 9)
            Me.adtAccounts.Styles.Add(Me.ElementStyle1)
            Me.adtAccounts.TabIndex = 26
            Me.adtAccounts.Text = "AdvTree1"
            '
            'colAccountName
            '
            Me.colAccountName.Name = "colAccountName"
            Me.colAccountName.SortingEnabled = False
            Me.colAccountName.Text = "Account Name"
            Me.colAccountName.Width.Absolute = 200
            '
            'colAccountVersion
            '
            Me.colAccountVersion.Name = "colAccountVersion"
            Me.colAccountVersion.SortingEnabled = False
            Me.colAccountVersion.Text = "Key Version"
            Me.colAccountVersion.Width.Absolute = 90
            '
            'colAccountUserID
            '
            Me.colAccountUserID.Name = "colAccountUserID"
            Me.colAccountUserID.SortingEnabled = False
            Me.colAccountUserID.Text = "User / Key ID"
            Me.colAccountUserID.Width.Absolute = 90
            '
            'colAccountAccessType
            '
            Me.colAccountAccessType.Name = "colAccountAccessType"
            Me.colAccountAccessType.SortingEnabled = False
            Me.colAccountAccessType.Text = "Access Type"
            Me.colAccountAccessType.Width.Absolute = 90
            '
            'colAccountStatus
            '
            Me.colAccountStatus.Name = "colAccountStatus"
            Me.colAccountStatus.SortingEnabled = False
            Me.colAccountStatus.Text = "Account Status"
            Me.colAccountStatus.Width.Absolute = 90
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
            'btnDisableAccount
            '
            Me.btnDisableAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnDisableAccount.Enabled = False
            Me.btnDisableAccount.Location = New System.Drawing.Point(240, 35)
            Me.btnDisableAccount.Name = "btnDisableAccount"
            Me.btnDisableAccount.Size = New System.Drawing.Size(70, 35)
            Me.btnDisableAccount.TabIndex = 25
            Me.btnDisableAccount.Text = "Disable Account"
            Me.ToolTip1.SetToolTip(Me.btnDisableAccount, "Removes an API account from EveHQ")
            '
            'btnCheckAPIKeys
            '
            Me.btnCheckAPIKeys.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnCheckAPIKeys.Location = New System.Drawing.Point(356, 35)
            Me.btnCheckAPIKeys.Name = "btnCheckAPIKeys"
            Me.btnCheckAPIKeys.Size = New System.Drawing.Size(70, 35)
            Me.btnCheckAPIKeys.TabIndex = 23
            Me.btnCheckAPIKeys.Text = "Check API Keys"
            Me.ToolTip1.SetToolTip(Me.btnCheckAPIKeys, "Checks the API Key types for ""Unknown"" keys")
            '
            'btnGetData
            '
            Me.btnGetData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnGetData.Location = New System.Drawing.Point(106, 35)
            Me.btnGetData.Name = "btnGetData"
            Me.btnGetData.Size = New System.Drawing.Size(70, 35)
            Me.btnGetData.TabIndex = 22
            Me.btnGetData.Text = "Retrieve API Data"
            Me.ToolTip1.SetToolTip(Me.btnGetData, "Retrieves API data for all listed accounts")
            '
            'btnDeleteAccount
            '
            Me.btnDeleteAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnDeleteAccount.Location = New System.Drawing.Point(164, 35)
            Me.btnDeleteAccount.Name = "btnDeleteAccount"
            Me.btnDeleteAccount.Size = New System.Drawing.Size(70, 35)
            Me.btnDeleteAccount.TabIndex = 21
            Me.btnDeleteAccount.Text = "Delete Account"
            Me.ToolTip1.SetToolTip(Me.btnDeleteAccount, "Removes an API account from EveHQ")
            '
            'btnEditAccount
            '
            Me.btnEditAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnEditAccount.Location = New System.Drawing.Point(88, 35)
            Me.btnEditAccount.Name = "btnEditAccount"
            Me.btnEditAccount.Size = New System.Drawing.Size(70, 35)
            Me.btnEditAccount.TabIndex = 20
            Me.btnEditAccount.Text = "Edit Account"
            Me.ToolTip1.SetToolTip(Me.btnEditAccount, "Allows the API Key or friendly name of an account to be modified")
            '
            'btnAddAccount
            '
            Me.btnAddAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnAddAccount.Location = New System.Drawing.Point(12, 35)
            Me.btnAddAccount.Name = "btnAddAccount"
            Me.btnAddAccount.Size = New System.Drawing.Size(70, 35)
            Me.btnAddAccount.TabIndex = 19
            Me.btnAddAccount.Text = "Add Account"
            Me.ToolTip1.SetToolTip(Me.btnAddAccount, "Adds a new API account to EveHQ")
            '
            'gbPilots
            '
            Me.gbPilots.BackColor = System.Drawing.Color.Transparent
            Me.gbPilots.Controls.Add(Me.btnCreateBlankPilot)
            Me.gbPilots.Controls.Add(Me.btnAddPilotFromXML)
            Me.gbPilots.Controls.Add(Me.btnDeletePilot)
            Me.gbPilots.Controls.Add(Me.btnAddPilot)
            Me.gbPilots.Controls.Add(Me.lvwPilots)
            Me.gbPilots.Location = New System.Drawing.Point(213, 417)
            Me.gbPilots.Name = "gbPilots"
            Me.gbPilots.Size = New System.Drawing.Size(144, 56)
            Me.gbPilots.TabIndex = 17
            Me.gbPilots.TabStop = False
            Me.gbPilots.Text = "Pilot Management"
            Me.gbPilots.Visible = False
            '
            'btnCreateBlankPilot
            '
            Me.btnCreateBlankPilot.Location = New System.Drawing.Point(421, 81)
            Me.btnCreateBlankPilot.Name = "btnCreateBlankPilot"
            Me.btnCreateBlankPilot.Size = New System.Drawing.Size(120, 25)
            Me.btnCreateBlankPilot.TabIndex = 23
            Me.btnCreateBlankPilot.Text = "Create Blank Pilot"
            '
            'btnAddPilotFromXML
            '
            Me.btnAddPilotFromXML.Location = New System.Drawing.Point(421, 50)
            Me.btnAddPilotFromXML.Name = "btnAddPilotFromXML"
            Me.btnAddPilotFromXML.Size = New System.Drawing.Size(120, 25)
            Me.btnAddPilotFromXML.TabIndex = 22
            Me.btnAddPilotFromXML.Text = "Add Pilot from XML"
            '
            'btnDeletePilot
            '
            Me.btnDeletePilot.Location = New System.Drawing.Point(421, 112)
            Me.btnDeletePilot.Name = "btnDeletePilot"
            Me.btnDeletePilot.Size = New System.Drawing.Size(120, 25)
            Me.btnDeletePilot.TabIndex = 21
            Me.btnDeletePilot.Text = "Delete Pilot"
            '
            'btnAddPilot
            '
            Me.btnAddPilot.Location = New System.Drawing.Point(421, 19)
            Me.btnAddPilot.Name = "btnAddPilot"
            Me.btnAddPilot.Size = New System.Drawing.Size(120, 25)
            Me.btnAddPilot.TabIndex = 19
            Me.btnAddPilot.Text = "Add Pilot"
            '
            'lvwPilots
            '
            Me.lvwPilots.AllowColumnReorder = True
            Me.lvwPilots.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.lvwPilots.Border.Class = "ListViewBorder"
            Me.lvwPilots.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lvwPilots.CheckBoxes = True
            Me.lvwPilots.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colPilot, Me.colID, Me.colAccount})
            Me.lvwPilots.DisabledBackColor = System.Drawing.Color.Empty
            Me.lvwPilots.FullRowSelect = True
            Me.lvwPilots.GridLines = True
            Me.lvwPilots.Location = New System.Drawing.Point(12, 19)
            Me.lvwPilots.Name = "lvwPilots"
            Me.lvwPilots.Size = New System.Drawing.Size(398, 31)
            Me.lvwPilots.Sorting = System.Windows.Forms.SortOrder.Ascending
            Me.lvwPilots.TabIndex = 18
            Me.lvwPilots.UseCompatibleStateImageBehavior = False
            Me.lvwPilots.View = System.Windows.Forms.View.Details
            '
            'colPilot
            '
            Me.colPilot.Text = "Pilot Name"
            Me.colPilot.Width = 150
            '
            'colID
            '
            Me.colID.Text = "Pilot ID"
            Me.colID.Width = 90
            '
            'colAccount
            '
            Me.colAccount.Text = "Linked to Account"
            Me.colAccount.Width = 130
            '
            'Label4
            '
            Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label4.Location = New System.Drawing.Point(26, 85)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(395, 41)
            Me.Label4.TabIndex = 7
            Me.Label4.Text = "The settings below are used while in Public Mode. If an item is checked, the data" &
    " will be available on the In-Game Browser. If it is not checked, then the item w" &
    "ill not be displayed."
            '
            'gbEveFolders
            '
            Me.gbEveFolders.Controls.Add(Me.gbLocation4)
            Me.gbEveFolders.Controls.Add(Me.gbLocation3)
            Me.gbEveFolders.Controls.Add(Me.gbLocation2)
            Me.gbEveFolders.Controls.Add(Me.gbLocation1)
            Me.gbEveFolders.Location = New System.Drawing.Point(335, 115)
            Me.gbEveFolders.Name = "gbEveFolders"
            Me.gbEveFolders.Size = New System.Drawing.Size(147, 36)
            Me.gbEveFolders.TabIndex = 3
            Me.gbEveFolders.TabStop = False
            Me.gbEveFolders.Text = "Eve Folders"
            Me.gbEveFolders.Visible = False
            '
            'gbLocation4
            '
            Me.gbLocation4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gbLocation4.Controls.Add(Me.lblFriendlyName4)
            Me.gbLocation4.Controls.Add(Me.txtFriendlyName4)
            Me.gbLocation4.Controls.Add(Me.lblCacheSize4)
            Me.gbLocation4.Controls.Add(Me.chkLUA4)
            Me.gbLocation4.Controls.Add(Me.lblEveDir4)
            Me.gbLocation4.Controls.Add(Me.btnEveDir4)
            Me.gbLocation4.Controls.Add(Me.btnClear4)
            Me.gbLocation4.Location = New System.Drawing.Point(6, 353)
            Me.gbLocation4.Name = "gbLocation4"
            Me.gbLocation4.Size = New System.Drawing.Size(134, 100)
            Me.gbLocation4.TabIndex = 15
            Me.gbLocation4.TabStop = False
            Me.gbLocation4.Text = "Eve Location 4"
            '
            'lblFriendlyName4
            '
            Me.lblFriendlyName4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblFriendlyName4.AutoSize = True
            Me.lblFriendlyName4.Location = New System.Drawing.Point(-178, 72)
            Me.lblFriendlyName4.Name = "lblFriendlyName4"
            Me.lblFriendlyName4.Size = New System.Drawing.Size(79, 13)
            Me.lblFriendlyName4.TabIndex = 15
            Me.lblFriendlyName4.Text = "Friendly Name:"
            '
            'txtFriendlyName4
            '
            Me.txtFriendlyName4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtFriendlyName4.Location = New System.Drawing.Point(-95, 69)
            Me.txtFriendlyName4.Name = "txtFriendlyName4"
            Me.txtFriendlyName4.Size = New System.Drawing.Size(150, 21)
            Me.txtFriendlyName4.TabIndex = 14
            '
            'lblCacheSize4
            '
            Me.lblCacheSize4.AutoSize = True
            Me.lblCacheSize4.Location = New System.Drawing.Point(87, 70)
            Me.lblCacheSize4.Name = "lblCacheSize4"
            Me.lblCacheSize4.Size = New System.Drawing.Size(63, 13)
            Me.lblCacheSize4.TabIndex = 13
            Me.lblCacheSize4.Text = "Cache Size:"
            Me.lblCacheSize4.Visible = False
            '
            'chkLUA4
            '
            Me.chkLUA4.AutoSize = True
            Me.chkLUA4.Location = New System.Drawing.Point(6, 69)
            Me.chkLUA4.Name = "chkLUA4"
            Me.chkLUA4.Size = New System.Drawing.Size(73, 17)
            Me.chkLUA4.TabIndex = 12
            Me.chkLUA4.Text = "/LUA Off?"
            Me.chkLUA4.UseVisualStyleBackColor = True
            '
            'lblEveDir4
            '
            Me.lblEveDir4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblEveDir4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblEveDir4.Location = New System.Drawing.Point(6, 16)
            Me.lblEveDir4.Name = "lblEveDir4"
            Me.lblEveDir4.Padding = New System.Windows.Forms.Padding(2)
            Me.lblEveDir4.Size = New System.Drawing.Size(49, 50)
            Me.lblEveDir4.TabIndex = 9
            Me.lblEveDir4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEveDir4
            '
            Me.btnEveDir4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnEveDir4.Location = New System.Drawing.Point(64, 16)
            Me.btnEveDir4.Name = "btnEveDir4"
            Me.btnEveDir4.Size = New System.Drawing.Size(64, 22)
            Me.btnEveDir4.TabIndex = 10
            Me.btnEveDir4.Text = "Change..."
            Me.btnEveDir4.UseVisualStyleBackColor = True
            '
            'btnClear4
            '
            Me.btnClear4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClear4.Location = New System.Drawing.Point(64, 44)
            Me.btnClear4.Name = "btnClear4"
            Me.btnClear4.Size = New System.Drawing.Size(64, 22)
            Me.btnClear4.TabIndex = 11
            Me.btnClear4.Text = "Clear"
            Me.btnClear4.UseVisualStyleBackColor = True
            '
            'gbLocation3
            '
            Me.gbLocation3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gbLocation3.Controls.Add(Me.lblFriendlyName3)
            Me.gbLocation3.Controls.Add(Me.txtFriendlyName3)
            Me.gbLocation3.Controls.Add(Me.lblCacheSize3)
            Me.gbLocation3.Controls.Add(Me.chkLUA3)
            Me.gbLocation3.Controls.Add(Me.lblEveDir3)
            Me.gbLocation3.Controls.Add(Me.btnEveDir3)
            Me.gbLocation3.Controls.Add(Me.btnClear3)
            Me.gbLocation3.Location = New System.Drawing.Point(6, 247)
            Me.gbLocation3.Name = "gbLocation3"
            Me.gbLocation3.Size = New System.Drawing.Size(134, 100)
            Me.gbLocation3.TabIndex = 14
            Me.gbLocation3.TabStop = False
            Me.gbLocation3.Text = "Eve Location 3"
            '
            'lblFriendlyName3
            '
            Me.lblFriendlyName3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblFriendlyName3.AutoSize = True
            Me.lblFriendlyName3.Location = New System.Drawing.Point(-178, 72)
            Me.lblFriendlyName3.Name = "lblFriendlyName3"
            Me.lblFriendlyName3.Size = New System.Drawing.Size(79, 13)
            Me.lblFriendlyName3.TabIndex = 13
            Me.lblFriendlyName3.Text = "Friendly Name:"
            '
            'txtFriendlyName3
            '
            Me.txtFriendlyName3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtFriendlyName3.Location = New System.Drawing.Point(-95, 69)
            Me.txtFriendlyName3.Name = "txtFriendlyName3"
            Me.txtFriendlyName3.Size = New System.Drawing.Size(150, 21)
            Me.txtFriendlyName3.TabIndex = 12
            '
            'lblCacheSize3
            '
            Me.lblCacheSize3.AutoSize = True
            Me.lblCacheSize3.Location = New System.Drawing.Point(87, 70)
            Me.lblCacheSize3.Name = "lblCacheSize3"
            Me.lblCacheSize3.Size = New System.Drawing.Size(63, 13)
            Me.lblCacheSize3.TabIndex = 11
            Me.lblCacheSize3.Text = "Cache Size:"
            Me.lblCacheSize3.Visible = False
            '
            'chkLUA3
            '
            Me.chkLUA3.AutoSize = True
            Me.chkLUA3.Location = New System.Drawing.Point(6, 69)
            Me.chkLUA3.Name = "chkLUA3"
            Me.chkLUA3.Size = New System.Drawing.Size(73, 17)
            Me.chkLUA3.TabIndex = 10
            Me.chkLUA3.Text = "/LUA Off?"
            Me.chkLUA3.UseVisualStyleBackColor = True
            '
            'lblEveDir3
            '
            Me.lblEveDir3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblEveDir3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblEveDir3.Location = New System.Drawing.Point(6, 16)
            Me.lblEveDir3.Name = "lblEveDir3"
            Me.lblEveDir3.Padding = New System.Windows.Forms.Padding(2)
            Me.lblEveDir3.Size = New System.Drawing.Size(49, 50)
            Me.lblEveDir3.TabIndex = 6
            Me.lblEveDir3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEveDir3
            '
            Me.btnEveDir3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnEveDir3.Location = New System.Drawing.Point(64, 16)
            Me.btnEveDir3.Name = "btnEveDir3"
            Me.btnEveDir3.Size = New System.Drawing.Size(64, 22)
            Me.btnEveDir3.TabIndex = 8
            Me.btnEveDir3.Text = "Change..."
            Me.btnEveDir3.UseVisualStyleBackColor = True
            '
            'btnClear3
            '
            Me.btnClear3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClear3.Location = New System.Drawing.Point(64, 44)
            Me.btnClear3.Name = "btnClear3"
            Me.btnClear3.Size = New System.Drawing.Size(64, 22)
            Me.btnClear3.TabIndex = 9
            Me.btnClear3.Text = "Clear"
            Me.btnClear3.UseVisualStyleBackColor = True
            '
            'gbLocation2
            '
            Me.gbLocation2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gbLocation2.Controls.Add(Me.lblFriendlyName2)
            Me.gbLocation2.Controls.Add(Me.txtFriendlyName2)
            Me.gbLocation2.Controls.Add(Me.lblCacheSize2)
            Me.gbLocation2.Controls.Add(Me.chkLUA2)
            Me.gbLocation2.Controls.Add(Me.lblEveDir2)
            Me.gbLocation2.Controls.Add(Me.btnEveDir2)
            Me.gbLocation2.Controls.Add(Me.btnClear2)
            Me.gbLocation2.Location = New System.Drawing.Point(6, 141)
            Me.gbLocation2.Name = "gbLocation2"
            Me.gbLocation2.Size = New System.Drawing.Size(134, 100)
            Me.gbLocation2.TabIndex = 13
            Me.gbLocation2.TabStop = False
            Me.gbLocation2.Text = "Eve Location 2"
            '
            'lblFriendlyName2
            '
            Me.lblFriendlyName2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblFriendlyName2.AutoSize = True
            Me.lblFriendlyName2.Location = New System.Drawing.Point(-178, 72)
            Me.lblFriendlyName2.Name = "lblFriendlyName2"
            Me.lblFriendlyName2.Size = New System.Drawing.Size(79, 13)
            Me.lblFriendlyName2.TabIndex = 11
            Me.lblFriendlyName2.Text = "Friendly Name:"
            '
            'txtFriendlyName2
            '
            Me.txtFriendlyName2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtFriendlyName2.Location = New System.Drawing.Point(-95, 69)
            Me.txtFriendlyName2.Name = "txtFriendlyName2"
            Me.txtFriendlyName2.Size = New System.Drawing.Size(150, 21)
            Me.txtFriendlyName2.TabIndex = 10
            '
            'lblCacheSize2
            '
            Me.lblCacheSize2.AutoSize = True
            Me.lblCacheSize2.Location = New System.Drawing.Point(87, 70)
            Me.lblCacheSize2.Name = "lblCacheSize2"
            Me.lblCacheSize2.Size = New System.Drawing.Size(63, 13)
            Me.lblCacheSize2.TabIndex = 9
            Me.lblCacheSize2.Text = "Cache Size:"
            Me.lblCacheSize2.Visible = False
            '
            'chkLUA2
            '
            Me.chkLUA2.AutoSize = True
            Me.chkLUA2.Location = New System.Drawing.Point(6, 69)
            Me.chkLUA2.Name = "chkLUA2"
            Me.chkLUA2.Size = New System.Drawing.Size(73, 17)
            Me.chkLUA2.TabIndex = 8
            Me.chkLUA2.Text = "/LUA Off?"
            Me.chkLUA2.UseVisualStyleBackColor = True
            '
            'lblEveDir2
            '
            Me.lblEveDir2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblEveDir2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblEveDir2.Location = New System.Drawing.Point(6, 16)
            Me.lblEveDir2.Name = "lblEveDir2"
            Me.lblEveDir2.Padding = New System.Windows.Forms.Padding(2)
            Me.lblEveDir2.Size = New System.Drawing.Size(49, 50)
            Me.lblEveDir2.TabIndex = 3
            Me.lblEveDir2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEveDir2
            '
            Me.btnEveDir2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnEveDir2.Location = New System.Drawing.Point(64, 16)
            Me.btnEveDir2.Name = "btnEveDir2"
            Me.btnEveDir2.Size = New System.Drawing.Size(64, 22)
            Me.btnEveDir2.TabIndex = 6
            Me.btnEveDir2.Text = "Change..."
            Me.btnEveDir2.UseVisualStyleBackColor = True
            '
            'btnClear2
            '
            Me.btnClear2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClear2.Location = New System.Drawing.Point(64, 44)
            Me.btnClear2.Name = "btnClear2"
            Me.btnClear2.Size = New System.Drawing.Size(64, 22)
            Me.btnClear2.TabIndex = 7
            Me.btnClear2.Text = "Clear"
            Me.btnClear2.UseVisualStyleBackColor = True
            '
            'gbLocation1
            '
            Me.gbLocation1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gbLocation1.Controls.Add(Me.lblFriendlyName1)
            Me.gbLocation1.Controls.Add(Me.txtFriendlyName1)
            Me.gbLocation1.Controls.Add(Me.lblCacheSize1)
            Me.gbLocation1.Controls.Add(Me.chkLUA1)
            Me.gbLocation1.Controls.Add(Me.lblEveDir1)
            Me.gbLocation1.Controls.Add(Me.btnEveDir1)
            Me.gbLocation1.Controls.Add(Me.btnClear1)
            Me.gbLocation1.Location = New System.Drawing.Point(6, 35)
            Me.gbLocation1.Name = "gbLocation1"
            Me.gbLocation1.Size = New System.Drawing.Size(134, 100)
            Me.gbLocation1.TabIndex = 12
            Me.gbLocation1.TabStop = False
            Me.gbLocation1.Text = "Eve Location 1"
            '
            'lblFriendlyName1
            '
            Me.lblFriendlyName1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblFriendlyName1.AutoSize = True
            Me.lblFriendlyName1.Location = New System.Drawing.Point(-178, 72)
            Me.lblFriendlyName1.Name = "lblFriendlyName1"
            Me.lblFriendlyName1.Size = New System.Drawing.Size(79, 13)
            Me.lblFriendlyName1.TabIndex = 9
            Me.lblFriendlyName1.Text = "Friendly Name:"
            '
            'txtFriendlyName1
            '
            Me.txtFriendlyName1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtFriendlyName1.Location = New System.Drawing.Point(-95, 69)
            Me.txtFriendlyName1.Name = "txtFriendlyName1"
            Me.txtFriendlyName1.Size = New System.Drawing.Size(150, 21)
            Me.txtFriendlyName1.TabIndex = 8
            '
            'lblCacheSize1
            '
            Me.lblCacheSize1.AutoSize = True
            Me.lblCacheSize1.Location = New System.Drawing.Point(87, 70)
            Me.lblCacheSize1.Name = "lblCacheSize1"
            Me.lblCacheSize1.Size = New System.Drawing.Size(63, 13)
            Me.lblCacheSize1.TabIndex = 7
            Me.lblCacheSize1.Text = "Cache Size:"
            Me.lblCacheSize1.Visible = False
            '
            'chkLUA1
            '
            Me.chkLUA1.AutoSize = True
            Me.chkLUA1.Location = New System.Drawing.Point(6, 69)
            Me.chkLUA1.Name = "chkLUA1"
            Me.chkLUA1.Size = New System.Drawing.Size(73, 17)
            Me.chkLUA1.TabIndex = 6
            Me.chkLUA1.Text = "/LUA Off?"
            Me.chkLUA1.UseVisualStyleBackColor = True
            '
            'lblEveDir1
            '
            Me.lblEveDir1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblEveDir1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblEveDir1.Location = New System.Drawing.Point(6, 16)
            Me.lblEveDir1.Name = "lblEveDir1"
            Me.lblEveDir1.Padding = New System.Windows.Forms.Padding(2)
            Me.lblEveDir1.Size = New System.Drawing.Size(49, 50)
            Me.lblEveDir1.TabIndex = 0
            Me.lblEveDir1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEveDir1
            '
            Me.btnEveDir1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnEveDir1.Location = New System.Drawing.Point(64, 16)
            Me.btnEveDir1.Name = "btnEveDir1"
            Me.btnEveDir1.Size = New System.Drawing.Size(64, 22)
            Me.btnEveDir1.TabIndex = 4
            Me.btnEveDir1.Text = "Change..."
            Me.btnEveDir1.UseVisualStyleBackColor = True
            '
            'btnClear1
            '
            Me.btnClear1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClear1.Location = New System.Drawing.Point(64, 44)
            Me.btnClear1.Name = "btnClear1"
            Me.btnClear1.Size = New System.Drawing.Size(64, 22)
            Me.btnClear1.TabIndex = 5
            Me.btnClear1.Text = "Clear"
            Me.btnClear1.UseVisualStyleBackColor = True
            '
            'gbTrainingQueue
            '
            Me.gbTrainingQueue.Controls.Add(Me.lblEveQueueDisplayLength)
            Me.gbTrainingQueue.Controls.Add(Me.nudEveQueueDisplayLength)
            Me.gbTrainingQueue.Controls.Add(Me.chkStartWithPrimaryQueue)
            Me.gbTrainingQueue.Controls.Add(Me.btnMoveDown)
            Me.gbTrainingQueue.Controls.Add(Me.btnMoveUp)
            Me.gbTrainingQueue.Controls.Add(Me.lvwColumns)
            Me.gbTrainingQueue.Controls.Add(Me.pbPartiallyTrainedColour)
            Me.gbTrainingQueue.Controls.Add(Me.lblPartiallyTrainedColour)
            Me.gbTrainingQueue.Controls.Add(Me.chkDeleteCompletedSkills)
            Me.gbTrainingQueue.Controls.Add(Me.pbReadySkillColour)
            Me.gbTrainingQueue.Controls.Add(Me.lblReadySkillColour)
            Me.gbTrainingQueue.Controls.Add(Me.pbDowntimeClashColour)
            Me.gbTrainingQueue.Controls.Add(Me.lblDowntimeClashColour)
            Me.gbTrainingQueue.Controls.Add(Me.pbBothPreReqColour)
            Me.gbTrainingQueue.Controls.Add(Me.lblBothPreReqColour)
            Me.gbTrainingQueue.Controls.Add(Me.pbHasPreReqColour)
            Me.gbTrainingQueue.Controls.Add(Me.pbIsPreReqColour)
            Me.gbTrainingQueue.Controls.Add(Me.lblHasPreReqColour)
            Me.gbTrainingQueue.Controls.Add(Me.lblIsPreReqColour)
            Me.gbTrainingQueue.Controls.Add(Me.lblSkillQueueColours)
            Me.gbTrainingQueue.Controls.Add(Me.lblQueueColumns)
            Me.gbTrainingQueue.Location = New System.Drawing.Point(195, 12)
            Me.gbTrainingQueue.Name = "gbTrainingQueue"
            Me.gbTrainingQueue.Size = New System.Drawing.Size(697, 507)
            Me.gbTrainingQueue.TabIndex = 3
            Me.gbTrainingQueue.TabStop = False
            Me.gbTrainingQueue.Text = "Training Queue"
            Me.gbTrainingQueue.Visible = False
            '
            'lblEveQueueDisplayLength
            '
            Me.lblEveQueueDisplayLength.AutoSize = True
            Me.lblEveQueueDisplayLength.Location = New System.Drawing.Point(284, 335)
            Me.lblEveQueueDisplayLength.Name = "lblEveQueueDisplayLength"
            Me.lblEveQueueDisplayLength.Size = New System.Drawing.Size(168, 13)
            Me.lblEveQueueDisplayLength.TabIndex = 39
            Me.lblEveQueueDisplayLength.Text = "Eve Queue Display Length (Days)"
            '
            'nudEveQueueDisplayLength
            '
            Me.nudEveQueueDisplayLength.Location = New System.Drawing.Point(464, 333)
            Me.nudEveQueueDisplayLength.Maximum = New Decimal(New Integer() {14, 0, 0, 0})
            Me.nudEveQueueDisplayLength.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudEveQueueDisplayLength.Name = "nudEveQueueDisplayLength"
            Me.nudEveQueueDisplayLength.Size = New System.Drawing.Size(68, 21)
            Me.nudEveQueueDisplayLength.TabIndex = 38
            Me.nudEveQueueDisplayLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudEveQueueDisplayLength.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'chkStartWithPrimaryQueue
            '
            Me.chkStartWithPrimaryQueue.AutoSize = True
            Me.chkStartWithPrimaryQueue.Location = New System.Drawing.Point(287, 310)
            Me.chkStartWithPrimaryQueue.Name = "chkStartWithPrimaryQueue"
            Me.chkStartWithPrimaryQueue.Size = New System.Drawing.Size(290, 17)
            Me.chkStartWithPrimaryQueue.TabIndex = 37
            Me.chkStartWithPrimaryQueue.Text = "Always show Primary Queue when opening skill training"
            Me.chkStartWithPrimaryQueue.UseVisualStyleBackColor = True
            '
            'btnMoveDown
            '
            Me.btnMoveDown.Location = New System.Drawing.Point(92, 429)
            Me.btnMoveDown.Name = "btnMoveDown"
            Me.btnMoveDown.Size = New System.Drawing.Size(80, 23)
            Me.btnMoveDown.TabIndex = 36
            Me.btnMoveDown.Text = "Move Down"
            Me.btnMoveDown.UseVisualStyleBackColor = True
            '
            'btnMoveUp
            '
            Me.btnMoveUp.Location = New System.Drawing.Point(6, 429)
            Me.btnMoveUp.Name = "btnMoveUp"
            Me.btnMoveUp.Size = New System.Drawing.Size(80, 23)
            Me.btnMoveUp.TabIndex = 35
            Me.btnMoveUp.Text = "Move Up"
            Me.btnMoveUp.UseVisualStyleBackColor = True
            '
            'lvwColumns
            '
            '
            '
            '
            Me.lvwColumns.Border.Class = "ListViewBorder"
            Me.lvwColumns.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lvwColumns.CheckBoxes = True
            Me.lvwColumns.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colQueueColumns})
            Me.lvwColumns.DisabledBackColor = System.Drawing.Color.Empty
            Me.lvwColumns.FullRowSelect = True
            Me.lvwColumns.Location = New System.Drawing.Point(6, 41)
            Me.lvwColumns.Name = "lvwColumns"
            Me.lvwColumns.Size = New System.Drawing.Size(222, 382)
            Me.lvwColumns.TabIndex = 34
            Me.lvwColumns.UseCompatibleStateImageBehavior = False
            Me.lvwColumns.View = System.Windows.Forms.View.Details
            '
            'colQueueColumns
            '
            Me.colQueueColumns.Text = "Queue Columns"
            Me.colQueueColumns.Width = 200
            '
            'pbPartiallyTrainedColour
            '
            Me.pbPartiallyTrainedColour.BackColor = System.Drawing.Color.White
            Me.pbPartiallyTrainedColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pbPartiallyTrainedColour.Location = New System.Drawing.Point(426, 205)
            Me.pbPartiallyTrainedColour.Name = "pbPartiallyTrainedColour"
            Me.pbPartiallyTrainedColour.Size = New System.Drawing.Size(24, 24)
            Me.pbPartiallyTrainedColour.TabIndex = 32
            Me.pbPartiallyTrainedColour.TabStop = False
            '
            'lblPartiallyTrainedColour
            '
            Me.lblPartiallyTrainedColour.AutoSize = True
            Me.lblPartiallyTrainedColour.Location = New System.Drawing.Point(299, 212)
            Me.lblPartiallyTrainedColour.Name = "lblPartiallyTrainedColour"
            Me.lblPartiallyTrainedColour.Size = New System.Drawing.Size(84, 13)
            Me.lblPartiallyTrainedColour.TabIndex = 31
            Me.lblPartiallyTrainedColour.Text = "Partially Trained"
            '
            'chkDeleteCompletedSkills
            '
            Me.chkDeleteCompletedSkills.AutoSize = True
            Me.chkDeleteCompletedSkills.Location = New System.Drawing.Point(287, 289)
            Me.chkDeleteCompletedSkills.Name = "chkDeleteCompletedSkills"
            Me.chkDeleteCompletedSkills.Size = New System.Drawing.Size(262, 17)
            Me.chkDeleteCompletedSkills.TabIndex = 30
            Me.chkDeleteCompletedSkills.Text = "Automatically delete completed skills from queues"
            Me.chkDeleteCompletedSkills.UseVisualStyleBackColor = True
            '
            'pbReadySkillColour
            '
            Me.pbReadySkillColour.BackColor = System.Drawing.Color.White
            Me.pbReadySkillColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pbReadySkillColour.Location = New System.Drawing.Point(426, 55)
            Me.pbReadySkillColour.Name = "pbReadySkillColour"
            Me.pbReadySkillColour.Size = New System.Drawing.Size(24, 24)
            Me.pbReadySkillColour.TabIndex = 29
            Me.pbReadySkillColour.TabStop = False
            '
            'lblReadySkillColour
            '
            Me.lblReadySkillColour.AutoSize = True
            Me.lblReadySkillColour.Location = New System.Drawing.Point(299, 62)
            Me.lblReadySkillColour.Name = "lblReadySkillColour"
            Me.lblReadySkillColour.Size = New System.Drawing.Size(89, 13)
            Me.lblReadySkillColour.TabIndex = 28
            Me.lblReadySkillColour.Text = "Independent Skill"
            '
            'pbDowntimeClashColour
            '
            Me.pbDowntimeClashColour.BackColor = System.Drawing.Color.Red
            Me.pbDowntimeClashColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pbDowntimeClashColour.Location = New System.Drawing.Point(426, 175)
            Me.pbDowntimeClashColour.Name = "pbDowntimeClashColour"
            Me.pbDowntimeClashColour.Size = New System.Drawing.Size(24, 24)
            Me.pbDowntimeClashColour.TabIndex = 27
            Me.pbDowntimeClashColour.TabStop = False
            '
            'lblDowntimeClashColour
            '
            Me.lblDowntimeClashColour.AutoSize = True
            Me.lblDowntimeClashColour.Location = New System.Drawing.Point(299, 182)
            Me.lblDowntimeClashColour.Name = "lblDowntimeClashColour"
            Me.lblDowntimeClashColour.Size = New System.Drawing.Size(108, 13)
            Me.lblDowntimeClashColour.TabIndex = 26
            Me.lblDowntimeClashColour.Text = "Downtime Clash Text"
            '
            'pbBothPreReqColour
            '
            Me.pbBothPreReqColour.BackColor = System.Drawing.Color.Gold
            Me.pbBothPreReqColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pbBothPreReqColour.Location = New System.Drawing.Point(426, 145)
            Me.pbBothPreReqColour.Name = "pbBothPreReqColour"
            Me.pbBothPreReqColour.Size = New System.Drawing.Size(24, 24)
            Me.pbBothPreReqColour.TabIndex = 25
            Me.pbBothPreReqColour.TabStop = False
            '
            'lblBothPreReqColour
            '
            Me.lblBothPreReqColour.AutoSize = True
            Me.lblBothPreReqColour.Location = New System.Drawing.Point(299, 152)
            Me.lblBothPreReqColour.Name = "lblBothPreReqColour"
            Me.lblBothPreReqColour.Size = New System.Drawing.Size(61, 13)
            Me.lblBothPreReqColour.TabIndex = 24
            Me.lblBothPreReqColour.Text = "Skill Is Both"
            '
            'pbHasPreReqColour
            '
            Me.pbHasPreReqColour.BackColor = System.Drawing.Color.Plum
            Me.pbHasPreReqColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pbHasPreReqColour.Location = New System.Drawing.Point(426, 115)
            Me.pbHasPreReqColour.Name = "pbHasPreReqColour"
            Me.pbHasPreReqColour.Size = New System.Drawing.Size(24, 24)
            Me.pbHasPreReqColour.TabIndex = 23
            Me.pbHasPreReqColour.TabStop = False
            '
            'pbIsPreReqColour
            '
            Me.pbIsPreReqColour.BackColor = System.Drawing.Color.LightSteelBlue
            Me.pbIsPreReqColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pbIsPreReqColour.Location = New System.Drawing.Point(426, 85)
            Me.pbIsPreReqColour.Name = "pbIsPreReqColour"
            Me.pbIsPreReqColour.Size = New System.Drawing.Size(24, 24)
            Me.pbIsPreReqColour.TabIndex = 22
            Me.pbIsPreReqColour.TabStop = False
            '
            'lblHasPreReqColour
            '
            Me.lblHasPreReqColour.AutoSize = True
            Me.lblHasPreReqColour.Location = New System.Drawing.Point(299, 122)
            Me.lblHasPreReqColour.Name = "lblHasPreReqColour"
            Me.lblHasPreReqColour.Size = New System.Drawing.Size(85, 13)
            Me.lblHasPreReqColour.TabIndex = 21
            Me.lblHasPreReqColour.Text = "Skill HAS PreReq"
            '
            'lblIsPreReqColour
            '
            Me.lblIsPreReqColour.AutoSize = True
            Me.lblIsPreReqColour.Location = New System.Drawing.Point(299, 92)
            Me.lblIsPreReqColour.Name = "lblIsPreReqColour"
            Me.lblIsPreReqColour.Size = New System.Drawing.Size(75, 13)
            Me.lblIsPreReqColour.TabIndex = 20
            Me.lblIsPreReqColour.Text = "Skill IS PreReq"
            '
            'lblSkillQueueColours
            '
            Me.lblSkillQueueColours.AutoSize = True
            Me.lblSkillQueueColours.Location = New System.Drawing.Point(284, 25)
            Me.lblSkillQueueColours.Name = "lblSkillQueueColours"
            Me.lblSkillQueueColours.Size = New System.Drawing.Size(102, 13)
            Me.lblSkillQueueColours.TabIndex = 4
            Me.lblSkillQueueColours.Text = "Skill Queue Colours:"
            '
            'lblQueueColumns
            '
            Me.lblQueueColumns.AutoSize = True
            Me.lblQueueColumns.Location = New System.Drawing.Point(6, 25)
            Me.lblQueueColumns.Name = "lblQueueColumns"
            Me.lblQueueColumns.Size = New System.Drawing.Size(127, 13)
            Me.lblQueueColumns.TabIndex = 1
            Me.lblQueueColumns.Text = "Queue Column Selection:"
            '
            'gbProxyServer
            '
            Me.gbProxyServer.Controls.Add(Me.gbProxyServerInfo)
            Me.gbProxyServer.Controls.Add(Me.chkUseProxy)
            Me.gbProxyServer.Location = New System.Drawing.Point(253, 262)
            Me.gbProxyServer.Name = "gbProxyServer"
            Me.gbProxyServer.Size = New System.Drawing.Size(160, 45)
            Me.gbProxyServer.TabIndex = 2
            Me.gbProxyServer.TabStop = False
            Me.gbProxyServer.Text = "Proxy Server"
            Me.gbProxyServer.Visible = False
            '
            'gbProxyServerInfo
            '
            Me.gbProxyServerInfo.Controls.Add(Me.chkProxyUseBasic)
            Me.gbProxyServerInfo.Controls.Add(Me.lblProxyPassword)
            Me.gbProxyServerInfo.Controls.Add(Me.lblProxyUsername)
            Me.gbProxyServerInfo.Controls.Add(Me.txtProxyPassword)
            Me.gbProxyServerInfo.Controls.Add(Me.txtProxyUsername)
            Me.gbProxyServerInfo.Controls.Add(Me.radUseSpecifiedCreds)
            Me.gbProxyServerInfo.Controls.Add(Me.lblProxyServer)
            Me.gbProxyServerInfo.Controls.Add(Me.txtProxyServer)
            Me.gbProxyServerInfo.Controls.Add(Me.radUseDefaultCreds)
            Me.gbProxyServerInfo.Location = New System.Drawing.Point(29, 68)
            Me.gbProxyServerInfo.Name = "gbProxyServerInfo"
            Me.gbProxyServerInfo.Size = New System.Drawing.Size(349, 217)
            Me.gbProxyServerInfo.TabIndex = 1
            Me.gbProxyServerInfo.TabStop = False
            Me.gbProxyServerInfo.Text = "Proxy Server Information"
            Me.gbProxyServerInfo.Visible = False
            '
            'chkProxyUseBasic
            '
            Me.chkProxyUseBasic.AutoSize = True
            Me.chkProxyUseBasic.Location = New System.Drawing.Point(27, 176)
            Me.chkProxyUseBasic.Name = "chkProxyUseBasic"
            Me.chkProxyUseBasic.Size = New System.Drawing.Size(144, 17)
            Me.chkProxyUseBasic.TabIndex = 10
            Me.chkProxyUseBasic.Text = "Use Basic Authentication"
            Me.chkProxyUseBasic.UseVisualStyleBackColor = True
            '
            'lblProxyPassword
            '
            Me.lblProxyPassword.AutoSize = True
            Me.lblProxyPassword.Enabled = False
            Me.lblProxyPassword.Location = New System.Drawing.Point(38, 145)
            Me.lblProxyPassword.Name = "lblProxyPassword"
            Me.lblProxyPassword.Size = New System.Drawing.Size(57, 13)
            Me.lblProxyPassword.TabIndex = 9
            Me.lblProxyPassword.Text = "Password:"
            '
            'lblProxyUsername
            '
            Me.lblProxyUsername.AutoSize = True
            Me.lblProxyUsername.Enabled = False
            Me.lblProxyUsername.Location = New System.Drawing.Point(36, 119)
            Me.lblProxyUsername.Name = "lblProxyUsername"
            Me.lblProxyUsername.Size = New System.Drawing.Size(59, 13)
            Me.lblProxyUsername.TabIndex = 8
            Me.lblProxyUsername.Text = "Username:"
            '
            'txtProxyPassword
            '
            Me.txtProxyPassword.Enabled = False
            Me.txtProxyPassword.Location = New System.Drawing.Point(100, 142)
            Me.txtProxyPassword.Name = "txtProxyPassword"
            Me.txtProxyPassword.Size = New System.Drawing.Size(234, 21)
            Me.txtProxyPassword.TabIndex = 7
            '
            'txtProxyUsername
            '
            Me.txtProxyUsername.Enabled = False
            Me.txtProxyUsername.Location = New System.Drawing.Point(100, 116)
            Me.txtProxyUsername.Name = "txtProxyUsername"
            Me.txtProxyUsername.Size = New System.Drawing.Size(234, 21)
            Me.txtProxyUsername.TabIndex = 6
            '
            'radUseSpecifiedCreds
            '
            Me.radUseSpecifiedCreds.AutoSize = True
            Me.radUseSpecifiedCreds.Location = New System.Drawing.Point(27, 93)
            Me.radUseSpecifiedCreds.Name = "radUseSpecifiedCreds"
            Me.radUseSpecifiedCreds.Size = New System.Drawing.Size(170, 17)
            Me.radUseSpecifiedCreds.TabIndex = 5
            Me.radUseSpecifiedCreds.Text = "Use the Following Credentials:"
            Me.radUseSpecifiedCreds.UseVisualStyleBackColor = True
            '
            'lblProxyServer
            '
            Me.lblProxyServer.AutoSize = True
            Me.lblProxyServer.Location = New System.Drawing.Point(24, 33)
            Me.lblProxyServer.Name = "lblProxyServer"
            Me.lblProxyServer.Size = New System.Drawing.Size(74, 13)
            Me.lblProxyServer.TabIndex = 3
            Me.lblProxyServer.Text = "Proxy Server:"
            '
            'txtProxyServer
            '
            Me.txtProxyServer.Location = New System.Drawing.Point(100, 30)
            Me.txtProxyServer.Name = "txtProxyServer"
            Me.txtProxyServer.Size = New System.Drawing.Size(234, 21)
            Me.txtProxyServer.TabIndex = 1
            '
            'radUseDefaultCreds
            '
            Me.radUseDefaultCreds.AutoSize = True
            Me.radUseDefaultCreds.Checked = True
            Me.radUseDefaultCreds.Location = New System.Drawing.Point(27, 70)
            Me.radUseDefaultCreds.Name = "radUseDefaultCreds"
            Me.radUseDefaultCreds.Size = New System.Drawing.Size(183, 17)
            Me.radUseDefaultCreds.TabIndex = 0
            Me.radUseDefaultCreds.TabStop = True
            Me.radUseDefaultCreds.Text = "Use Existing Network Credentials"
            Me.radUseDefaultCreds.UseVisualStyleBackColor = True
            '
            'chkUseProxy
            '
            Me.chkUseProxy.AutoSize = True
            Me.chkUseProxy.Location = New System.Drawing.Point(29, 31)
            Me.chkUseProxy.Name = "chkUseProxy"
            Me.chkUseProxy.Size = New System.Drawing.Size(110, 17)
            Me.chkUseProxy.TabIndex = 0
            Me.chkUseProxy.Text = "Use Proxy Server"
            Me.chkUseProxy.UseVisualStyleBackColor = True
            '
            'gbEveServer
            '
            Me.gbEveServer.Controls.Add(Me.trackServerOffset)
            Me.gbEveServer.Controls.Add(Me.chkAutoMailAPI)
            Me.gbEveServer.Controls.Add(Me.gbAPIServer)
            Me.gbEveServer.Controls.Add(Me.chkEnableEveStatus)
            Me.gbEveServer.Controls.Add(Me.lblCurrentOffset)
            Me.gbEveServer.Controls.Add(Me.lblServerOffset)
            Me.gbEveServer.Controls.Add(Me.chkAutoAPI)
            Me.gbEveServer.Location = New System.Drawing.Point(429, 429)
            Me.gbEveServer.Name = "gbEveServer"
            Me.gbEveServer.Size = New System.Drawing.Size(196, 33)
            Me.gbEveServer.TabIndex = 2
            Me.gbEveServer.TabStop = False
            Me.gbEveServer.Text = "Eve API && Server Options"
            Me.gbEveServer.Visible = False
            '
            'trackServerOffset
            '
            '
            '
            '
            Me.trackServerOffset.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.trackServerOffset.LabelVisible = False
            Me.trackServerOffset.Location = New System.Drawing.Point(15, 81)
            Me.trackServerOffset.Maximum = 600
            Me.trackServerOffset.Minimum = -600
            Me.trackServerOffset.Name = "trackServerOffset"
            Me.trackServerOffset.Size = New System.Drawing.Size(659, 23)
            Me.trackServerOffset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.trackServerOffset.TabIndex = 22
            Me.trackServerOffset.Value = 0
            '
            'chkAutoMailAPI
            '
            Me.chkAutoMailAPI.AutoSize = True
            Me.chkAutoMailAPI.Location = New System.Drawing.Point(18, 420)
            Me.chkAutoMailAPI.Name = "chkAutoMailAPI"
            Me.chkAutoMailAPI.Size = New System.Drawing.Size(303, 17)
            Me.chkAutoMailAPI.TabIndex = 21
            Me.chkAutoMailAPI.Text = "Automatically Check for Mail and Notification XML Updates"
            Me.chkAutoMailAPI.UseVisualStyleBackColor = True
            '
            'gbAPIServer
            '
            Me.gbAPIServer.Controls.Add(Me.txtAPIFileExtension)
            Me.gbAPIServer.Controls.Add(Me.lblAPIFileExtension)
            Me.gbAPIServer.Controls.Add(Me.chkUseCCPBackup)
            Me.gbAPIServer.Controls.Add(Me.chkUseAPIRSServer)
            Me.gbAPIServer.Controls.Add(Me.txtAPIRSServer)
            Me.gbAPIServer.Controls.Add(Me.lblAPIRSServer)
            Me.gbAPIServer.Controls.Add(Me.txtCCPAPIServer)
            Me.gbAPIServer.Controls.Add(Me.lblCCPAPIServer)
            Me.gbAPIServer.Location = New System.Drawing.Point(6, 152)
            Me.gbAPIServer.Name = "gbAPIServer"
            Me.gbAPIServer.Size = New System.Drawing.Size(668, 133)
            Me.gbAPIServer.TabIndex = 20
            Me.gbAPIServer.TabStop = False
            Me.gbAPIServer.Text = "API Server"
            '
            'txtAPIFileExtension
            '
            Me.txtAPIFileExtension.Location = New System.Drawing.Point(152, 101)
            Me.txtAPIFileExtension.Name = "txtAPIFileExtension"
            Me.txtAPIFileExtension.Size = New System.Drawing.Size(98, 21)
            Me.txtAPIFileExtension.TabIndex = 28
            '
            'lblAPIFileExtension
            '
            Me.lblAPIFileExtension.AutoSize = True
            Me.lblAPIFileExtension.Location = New System.Drawing.Point(9, 104)
            Me.lblAPIFileExtension.Name = "lblAPIFileExtension"
            Me.lblAPIFileExtension.Size = New System.Drawing.Size(96, 13)
            Me.lblAPIFileExtension.TabIndex = 27
            Me.lblAPIFileExtension.Text = "API File Extention:"
            '
            'chkUseCCPBackup
            '
            Me.chkUseCCPBackup.AutoSize = True
            Me.chkUseCCPBackup.Location = New System.Drawing.Point(152, 52)
            Me.chkUseCCPBackup.Name = "chkUseCCPBackup"
            Me.chkUseCCPBackup.Size = New System.Drawing.Size(173, 17)
            Me.chkUseCCPBackup.TabIndex = 26
            Me.chkUseCCPBackup.Text = "Use CCP API Server as Backup"
            Me.chkUseCCPBackup.UseVisualStyleBackColor = True
            '
            'chkUseAPIRSServer
            '
            Me.chkUseAPIRSServer.AutoSize = True
            Me.chkUseAPIRSServer.Location = New System.Drawing.Point(12, 52)
            Me.chkUseAPIRSServer.Name = "chkUseAPIRSServer"
            Me.chkUseAPIRSServer.Size = New System.Drawing.Size(130, 17)
            Me.chkUseAPIRSServer.TabIndex = 25
            Me.chkUseAPIRSServer.Text = "Use API Proxy Server"
            Me.chkUseAPIRSServer.UseVisualStyleBackColor = True
            '
            'txtAPIRSServer
            '
            Me.txtAPIRSServer.Location = New System.Drawing.Point(152, 75)
            Me.txtAPIRSServer.Name = "txtAPIRSServer"
            Me.txtAPIRSServer.Size = New System.Drawing.Size(332, 21)
            Me.txtAPIRSServer.TabIndex = 24
            '
            'lblAPIRSServer
            '
            Me.lblAPIRSServer.AutoSize = True
            Me.lblAPIRSServer.Location = New System.Drawing.Point(9, 78)
            Me.lblAPIRSServer.Name = "lblAPIRSServer"
            Me.lblAPIRSServer.Size = New System.Drawing.Size(136, 13)
            Me.lblAPIRSServer.TabIndex = 23
            Me.lblAPIRSServer.Text = "API Proxy Server Address:"
            '
            'txtCCPAPIServer
            '
            Me.txtCCPAPIServer.Location = New System.Drawing.Point(152, 26)
            Me.txtCCPAPIServer.Name = "txtCCPAPIServer"
            Me.txtCCPAPIServer.Size = New System.Drawing.Size(332, 21)
            Me.txtCCPAPIServer.TabIndex = 22
            '
            'lblCCPAPIServer
            '
            Me.lblCCPAPIServer.AutoSize = True
            Me.lblCCPAPIServer.Location = New System.Drawing.Point(9, 29)
            Me.lblCCPAPIServer.Name = "lblCCPAPIServer"
            Me.lblCCPAPIServer.Size = New System.Drawing.Size(128, 13)
            Me.lblCCPAPIServer.TabIndex = 21
            Me.lblCCPAPIServer.Text = "CCP API Server Address:"
            '
            'chkEnableEveStatus
            '
            Me.chkEnableEveStatus.AutoSize = True
            Me.chkEnableEveStatus.Location = New System.Drawing.Point(19, 31)
            Me.chkEnableEveStatus.Name = "chkEnableEveStatus"
            Me.chkEnableEveStatus.Size = New System.Drawing.Size(127, 17)
            Me.chkEnableEveStatus.TabIndex = 13
            Me.chkEnableEveStatus.Text = "Enable Server Status"
            Me.chkEnableEveStatus.UseVisualStyleBackColor = True
            '
            'lblCurrentOffset
            '
            Me.lblCurrentOffset.AutoSize = True
            Me.lblCurrentOffset.Location = New System.Drawing.Point(16, 107)
            Me.lblCurrentOffset.Name = "lblCurrentOffset"
            Me.lblCurrentOffset.Size = New System.Drawing.Size(82, 13)
            Me.lblCurrentOffset.TabIndex = 12
            Me.lblCurrentOffset.Text = "Current Offset:"
            '
            'lblServerOffset
            '
            Me.lblServerOffset.AutoSize = True
            Me.lblServerOffset.Location = New System.Drawing.Point(16, 65)
            Me.lblServerOffset.Name = "lblServerOffset"
            Me.lblServerOffset.Size = New System.Drawing.Size(153, 13)
            Me.lblServerOffset.TabIndex = 11
            Me.lblServerOffset.Text = "Tranquiity Server Time Offset:"
            '
            'chkAutoAPI
            '
            Me.chkAutoAPI.AutoSize = True
            Me.chkAutoAPI.Location = New System.Drawing.Point(18, 397)
            Me.chkAutoAPI.Name = "chkAutoAPI"
            Me.chkAutoAPI.Size = New System.Drawing.Size(255, 17)
            Me.chkAutoAPI.TabIndex = 20
            Me.chkAutoAPI.Text = "Automatically Check for Character XML Updates"
            Me.chkAutoAPI.UseVisualStyleBackColor = True
            '
            'gbPlugIns
            '
            Me.gbPlugIns.Controls.Add(Me.btnTidyPlugins)
            Me.gbPlugIns.Controls.Add(Me.btnRefreshPlugins)
            Me.gbPlugIns.Controls.Add(Me.lblPlugInInfo)
            Me.gbPlugIns.Controls.Add(Me.lblDetectedPlugIns)
            Me.gbPlugIns.Controls.Add(Me.lvwPlugins)
            Me.gbPlugIns.Location = New System.Drawing.Point(732, 252)
            Me.gbPlugIns.Name = "gbPlugIns"
            Me.gbPlugIns.Size = New System.Drawing.Size(125, 33)
            Me.gbPlugIns.TabIndex = 18
            Me.gbPlugIns.TabStop = False
            Me.gbPlugIns.Text = "EveHQ Plug-Ins"
            Me.gbPlugIns.Visible = False
            '
            'btnTidyPlugins
            '
            Me.btnTidyPlugins.Location = New System.Drawing.Point(257, 291)
            Me.btnTidyPlugins.Name = "btnTidyPlugins"
            Me.btnTidyPlugins.Size = New System.Drawing.Size(75, 23)
            Me.btnTidyPlugins.TabIndex = 4
            Me.btnTidyPlugins.Text = "Tidy"
            Me.btnTidyPlugins.UseVisualStyleBackColor = True
            '
            'btnRefreshPlugins
            '
            Me.btnRefreshPlugins.Location = New System.Drawing.Point(338, 291)
            Me.btnRefreshPlugins.Name = "btnRefreshPlugins"
            Me.btnRefreshPlugins.Size = New System.Drawing.Size(75, 23)
            Me.btnRefreshPlugins.TabIndex = 3
            Me.btnRefreshPlugins.Text = "Refresh"
            Me.btnRefreshPlugins.UseVisualStyleBackColor = True
            '
            'lblPlugInInfo
            '
            Me.lblPlugInInfo.AutoSize = True
            Me.lblPlugInInfo.Location = New System.Drawing.Point(6, 339)
            Me.lblPlugInInfo.Name = "lblPlugInInfo"
            Me.lblPlugInInfo.Size = New System.Drawing.Size(332, 13)
            Me.lblPlugInInfo.TabIndex = 2
            Me.lblPlugInInfo.Text = "Changes to the PlugIns will not take effect until EveHQ is restarted."
            '
            'lblDetectedPlugIns
            '
            Me.lblDetectedPlugIns.AutoSize = True
            Me.lblDetectedPlugIns.Location = New System.Drawing.Point(6, 24)
            Me.lblDetectedPlugIns.Name = "lblDetectedPlugIns"
            Me.lblDetectedPlugIns.Size = New System.Drawing.Size(79, 13)
            Me.lblDetectedPlugIns.TabIndex = 1
            Me.lblDetectedPlugIns.Text = "Active PlugIns:"
            '
            'lvwPlugins
            '
            '
            '
            '
            Me.lvwPlugins.Border.Class = "ListViewBorder"
            Me.lvwPlugins.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lvwPlugins.CheckBoxes = True
            Me.lvwPlugins.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colPlugInName, Me.colStatus})
            Me.lvwPlugins.DisabledBackColor = System.Drawing.Color.Empty
            Me.lvwPlugins.GridLines = True
            Me.lvwPlugins.Location = New System.Drawing.Point(6, 43)
            Me.lvwPlugins.Name = "lvwPlugins"
            Me.lvwPlugins.Size = New System.Drawing.Size(407, 242)
            Me.lvwPlugins.TabIndex = 0
            Me.lvwPlugins.UseCompatibleStateImageBehavior = False
            Me.lvwPlugins.View = System.Windows.Forms.View.Details
            '
            'colPlugInName
            '
            Me.colPlugInName.Text = "Plug-In"
            Me.colPlugInName.Width = 230
            '
            'colStatus
            '
            Me.colStatus.Text = "Status"
            Me.colStatus.Width = 150
            '
            'gbNotifications
            '
            Me.gbNotifications.Controls.Add(Me.nudAccountTimeLimit)
            Me.gbNotifications.Controls.Add(Me.lblAccountTimeLimit)
            Me.gbNotifications.Controls.Add(Me.chkNotifyAccountTime)
            Me.gbNotifications.Controls.Add(Me.chkNotifyInsuffClone)
            Me.gbNotifications.Controls.Add(Me.sldNotifyOffset)
            Me.gbNotifications.Controls.Add(Me.chkIgnoreLastMessage)
            Me.gbNotifications.Controls.Add(Me.chkNotifyNotification)
            Me.gbNotifications.Controls.Add(Me.chkNotifyEveMail)
            Me.gbNotifications.Controls.Add(Me.chkNotifyEarly)
            Me.gbNotifications.Controls.Add(Me.chkNotifyNow)
            Me.gbNotifications.Controls.Add(Me.lblNotifyMe)
            Me.gbNotifications.Controls.Add(Me.btnSoundTest)
            Me.gbNotifications.Controls.Add(Me.btnSelectSoundFile)
            Me.gbNotifications.Controls.Add(Me.lblSoundFile)
            Me.gbNotifications.Controls.Add(Me.chkNotifySound)
            Me.gbNotifications.Controls.Add(Me.lblNotifyOffset)
            Me.gbNotifications.Controls.Add(Me.chkNotifyEmail)
            Me.gbNotifications.Controls.Add(Me.chkNotifyDialog)
            Me.gbNotifications.Controls.Add(Me.chkNotifyToolTip)
            Me.gbNotifications.Controls.Add(Me.nudShutdownNotifyPeriod)
            Me.gbNotifications.Controls.Add(Me.lblShutdownNotifyPeriod)
            Me.gbNotifications.Controls.Add(Me.chkShutdownNotify)
            Me.gbNotifications.Location = New System.Drawing.Point(218, 206)
            Me.gbNotifications.Name = "gbNotifications"
            Me.gbNotifications.Size = New System.Drawing.Size(162, 34)
            Me.gbNotifications.TabIndex = 20
            Me.gbNotifications.TabStop = False
            Me.gbNotifications.Text = "Notifications"
            Me.gbNotifications.Visible = False
            '
            'nudAccountTimeLimit
            '
            Me.nudAccountTimeLimit.Location = New System.Drawing.Point(219, 360)
            Me.nudAccountTimeLimit.Maximum = New Decimal(New Integer() {32940, 0, 0, 0})
            Me.nudAccountTimeLimit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudAccountTimeLimit.Name = "nudAccountTimeLimit"
            Me.nudAccountTimeLimit.Size = New System.Drawing.Size(68, 21)
            Me.nudAccountTimeLimit.TabIndex = 27
            Me.nudAccountTimeLimit.Value = New Decimal(New Integer() {168, 0, 0, 0})
            '
            'lblAccountTimeLimit
            '
            Me.lblAccountTimeLimit.AutoSize = True
            Me.lblAccountTimeLimit.Location = New System.Drawing.Point(71, 362)
            Me.lblAccountTimeLimit.Name = "lblAccountTimeLimit"
            Me.lblAccountTimeLimit.Size = New System.Drawing.Size(136, 13)
            Me.lblAccountTimeLimit.TabIndex = 26
            Me.lblAccountTimeLimit.Text = "Notification Period (hours):"
            '
            'chkNotifyAccountTime
            '
            Me.chkNotifyAccountTime.AutoSize = True
            Me.chkNotifyAccountTime.Location = New System.Drawing.Point(21, 336)
            Me.chkNotifyAccountTime.Name = "chkNotifyAccountTime"
            Me.chkNotifyAccountTime.Size = New System.Drawing.Size(236, 17)
            Me.chkNotifyAccountTime.TabIndex = 25
            Me.chkNotifyAccountTime.Text = "Show account time remaining in Training Bar"
            Me.chkNotifyAccountTime.UseVisualStyleBackColor = True
            '
            'chkNotifyInsuffClone
            '
            Me.chkNotifyInsuffClone.AutoSize = True
            Me.chkNotifyInsuffClone.Location = New System.Drawing.Point(21, 311)
            Me.chkNotifyInsuffClone.Name = "chkNotifyInsuffClone"
            Me.chkNotifyInsuffClone.Size = New System.Drawing.Size(247, 17)
            Me.chkNotifyInsuffClone.TabIndex = 25
            Me.chkNotifyInsuffClone.Text = "Show insufficient clone warning in Training Bar"
            Me.chkNotifyInsuffClone.UseVisualStyleBackColor = True
            '
            'sldNotifyOffset
            '
            '
            '
            '
            Me.sldNotifyOffset.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.sldNotifyOffset.LabelVisible = False
            Me.sldNotifyOffset.Location = New System.Drawing.Point(21, 200)
            Me.sldNotifyOffset.Maximum = 1800
            Me.sldNotifyOffset.Name = "sldNotifyOffset"
            Me.sldNotifyOffset.Size = New System.Drawing.Size(450, 23)
            Me.sldNotifyOffset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.sldNotifyOffset.TabIndex = 24
            Me.sldNotifyOffset.Value = 0
            '
            'chkIgnoreLastMessage
            '
            Me.chkIgnoreLastMessage.AutoSize = True
            Me.chkIgnoreLastMessage.Location = New System.Drawing.Point(21, 443)
            Me.chkIgnoreLastMessage.Name = "chkIgnoreLastMessage"
            Me.chkIgnoreLastMessage.Size = New System.Drawing.Size(161, 17)
            Me.chkIgnoreLastMessage.TabIndex = 23
            Me.chkIgnoreLastMessage.Text = "Ignore Last Server Message"
            Me.chkIgnoreLastMessage.UseVisualStyleBackColor = True
            '
            'chkNotifyNotification
            '
            Me.chkNotifyNotification.AutoSize = True
            Me.chkNotifyNotification.Location = New System.Drawing.Point(243, 270)
            Me.chkNotifyNotification.Name = "chkNotifyNotification"
            Me.chkNotifyNotification.Size = New System.Drawing.Size(255, 17)
            Me.chkNotifyNotification.TabIndex = 22
            Me.chkNotifyNotification.Text = "Send E-Mail when new Eve Notification received"
            Me.chkNotifyNotification.UseVisualStyleBackColor = True
            '
            'chkNotifyEveMail
            '
            Me.chkNotifyEveMail.AutoSize = True
            Me.chkNotifyEveMail.Location = New System.Drawing.Point(21, 270)
            Me.chkNotifyEveMail.Name = "chkNotifyEveMail"
            Me.chkNotifyEveMail.Size = New System.Drawing.Size(216, 17)
            Me.chkNotifyEveMail.TabIndex = 21
            Me.chkNotifyEveMail.Text = "Send E-mail when new EveMail received"
            Me.chkNotifyEveMail.UseVisualStyleBackColor = True
            '
            'chkNotifyEarly
            '
            Me.chkNotifyEarly.AutoSize = True
            Me.chkNotifyEarly.Location = New System.Drawing.Point(236, 153)
            Me.chkNotifyEarly.Name = "chkNotifyEarly"
            Me.chkNotifyEarly.Size = New System.Drawing.Size(116, 17)
            Me.chkNotifyEarly.TabIndex = 20
            Me.chkNotifyEarly.Text = "Before skill finishes"
            Me.chkNotifyEarly.UseVisualStyleBackColor = True
            '
            'chkNotifyNow
            '
            Me.chkNotifyNow.AutoSize = True
            Me.chkNotifyNow.Location = New System.Drawing.Point(98, 153)
            Me.chkNotifyNow.Name = "chkNotifyNow"
            Me.chkNotifyNow.Size = New System.Drawing.Size(112, 17)
            Me.chkNotifyNow.TabIndex = 19
            Me.chkNotifyNow.Text = "When skill finishes"
            Me.chkNotifyNow.UseVisualStyleBackColor = True
            '
            'lblNotifyMe
            '
            Me.lblNotifyMe.AutoSize = True
            Me.lblNotifyMe.Location = New System.Drawing.Point(18, 154)
            Me.lblNotifyMe.Name = "lblNotifyMe"
            Me.lblNotifyMe.Size = New System.Drawing.Size(57, 13)
            Me.lblNotifyMe.TabIndex = 18
            Me.lblNotifyMe.Text = "Notify Me:"
            '
            'btnSoundTest
            '
            Me.btnSoundTest.Location = New System.Drawing.Point(547, 117)
            Me.btnSoundTest.Name = "btnSoundTest"
            Me.btnSoundTest.Size = New System.Drawing.Size(36, 20)
            Me.btnSoundTest.TabIndex = 17
            Me.btnSoundTest.Text = "Test"
            Me.btnSoundTest.UseVisualStyleBackColor = True
            '
            'btnSelectSoundFile
            '
            Me.btnSelectSoundFile.Location = New System.Drawing.Point(492, 117)
            Me.btnSelectSoundFile.Name = "btnSelectSoundFile"
            Me.btnSelectSoundFile.Size = New System.Drawing.Size(49, 20)
            Me.btnSelectSoundFile.TabIndex = 16
            Me.btnSelectSoundFile.Text = "Select"
            Me.btnSelectSoundFile.UseVisualStyleBackColor = True
            '
            'lblSoundFile
            '
            Me.lblSoundFile.AutoEllipsis = True
            Me.lblSoundFile.BackColor = System.Drawing.SystemColors.Window
            Me.lblSoundFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblSoundFile.Location = New System.Drawing.Point(163, 117)
            Me.lblSoundFile.Name = "lblSoundFile"
            Me.lblSoundFile.Size = New System.Drawing.Size(323, 20)
            Me.lblSoundFile.TabIndex = 15
            '
            'chkNotifySound
            '
            Me.chkNotifySound.AutoSize = True
            Me.chkNotifySound.Location = New System.Drawing.Point(21, 117)
            Me.chkNotifySound.Name = "chkNotifySound"
            Me.chkNotifySound.Size = New System.Drawing.Size(136, 17)
            Me.chkNotifySound.TabIndex = 14
            Me.chkNotifySound.Text = "Play Sound Notification"
            Me.chkNotifySound.UseVisualStyleBackColor = True
            '
            'lblNotifyOffset
            '
            Me.lblNotifyOffset.AutoSize = True
            Me.lblNotifyOffset.Location = New System.Drawing.Point(18, 184)
            Me.lblNotifyOffset.Name = "lblNotifyOffset"
            Me.lblNotifyOffset.Size = New System.Drawing.Size(126, 13)
            Me.lblNotifyOffset.TabIndex = 13
            Me.lblNotifyOffset.Text = "Early Notification Offset:"
            '
            'chkNotifyEmail
            '
            Me.chkNotifyEmail.AutoSize = True
            Me.chkNotifyEmail.Location = New System.Drawing.Point(400, 89)
            Me.chkNotifyEmail.Name = "chkNotifyEmail"
            Me.chkNotifyEmail.Size = New System.Drawing.Size(136, 17)
            Me.chkNotifyEmail.TabIndex = 5
            Me.chkNotifyEmail.Text = "Send E-Mail Notifcation"
            Me.chkNotifyEmail.UseVisualStyleBackColor = True
            '
            'chkNotifyDialog
            '
            Me.chkNotifyDialog.AutoSize = True
            Me.chkNotifyDialog.Location = New System.Drawing.Point(231, 89)
            Me.chkNotifyDialog.Name = "chkNotifyDialog"
            Me.chkNotifyDialog.Size = New System.Drawing.Size(162, 17)
            Me.chkNotifyDialog.TabIndex = 4
            Me.chkNotifyDialog.Text = "Show Dialog Box Notification"
            Me.chkNotifyDialog.UseVisualStyleBackColor = True
            '
            'chkNotifyToolTip
            '
            Me.chkNotifyToolTip.AutoSize = True
            Me.chkNotifyToolTip.Location = New System.Drawing.Point(21, 89)
            Me.chkNotifyToolTip.Name = "chkNotifyToolTip"
            Me.chkNotifyToolTip.Size = New System.Drawing.Size(205, 17)
            Me.chkNotifyToolTip.TabIndex = 3
            Me.chkNotifyToolTip.Text = "Show System Tray Popup Notification"
            Me.chkNotifyToolTip.UseVisualStyleBackColor = True
            '
            'nudShutdownNotifyPeriod
            '
            Me.nudShutdownNotifyPeriod.Location = New System.Drawing.Point(219, 53)
            Me.nudShutdownNotifyPeriod.Maximum = New Decimal(New Integer() {72, 0, 0, 0})
            Me.nudShutdownNotifyPeriod.Name = "nudShutdownNotifyPeriod"
            Me.nudShutdownNotifyPeriod.Size = New System.Drawing.Size(68, 21)
            Me.nudShutdownNotifyPeriod.TabIndex = 2
            Me.nudShutdownNotifyPeriod.Value = New Decimal(New Integer() {8, 0, 0, 0})
            '
            'lblShutdownNotifyPeriod
            '
            Me.lblShutdownNotifyPeriod.AutoSize = True
            Me.lblShutdownNotifyPeriod.Location = New System.Drawing.Point(71, 55)
            Me.lblShutdownNotifyPeriod.Name = "lblShutdownNotifyPeriod"
            Me.lblShutdownNotifyPeriod.Size = New System.Drawing.Size(136, 13)
            Me.lblShutdownNotifyPeriod.TabIndex = 1
            Me.lblShutdownNotifyPeriod.Text = "Notification Period (hours):"
            '
            'chkShutdownNotify
            '
            Me.chkShutdownNotify.AutoSize = True
            Me.chkShutdownNotify.Location = New System.Drawing.Point(21, 30)
            Me.chkShutdownNotify.Name = "chkShutdownNotify"
            Me.chkShutdownNotify.Size = New System.Drawing.Size(339, 17)
            Me.chkShutdownNotify.TabIndex = 0
            Me.chkShutdownNotify.Text = "Notify of imminent completion of skill training on EveHQ shutdown"
            Me.chkShutdownNotify.UseVisualStyleBackColor = True
            '
            'gbEmail
            '
            Me.gbEmail.Controls.Add(Me.chkUseSSL)
            Me.gbEmail.Controls.Add(Me.lblSenderAddress)
            Me.gbEmail.Controls.Add(Me.txtSenderAddress)
            Me.gbEmail.Controls.Add(Me.txtSMTPPort)
            Me.gbEmail.Controls.Add(Me.lblSMTPPort)
            Me.gbEmail.Controls.Add(Me.btnTestEmail)
            Me.gbEmail.Controls.Add(Me.lblEmailPassword)
            Me.gbEmail.Controls.Add(Me.txtEmailPassword)
            Me.gbEmail.Controls.Add(Me.txtEmailUsername)
            Me.gbEmail.Controls.Add(Me.lblEmailUsername)
            Me.gbEmail.Controls.Add(Me.chkSMTPAuthentication)
            Me.gbEmail.Controls.Add(Me.lblEMailAddress)
            Me.gbEmail.Controls.Add(Me.txtEmailAddress)
            Me.gbEmail.Controls.Add(Me.txtSMTPServer)
            Me.gbEmail.Controls.Add(Me.lblSMTPServer)
            Me.gbEmail.Location = New System.Drawing.Point(716, 367)
            Me.gbEmail.Name = "gbEmail"
            Me.gbEmail.Size = New System.Drawing.Size(129, 35)
            Me.gbEmail.TabIndex = 6
            Me.gbEmail.TabStop = False
            Me.gbEmail.Text = "E-Mail Options"
            Me.gbEmail.Visible = False
            '
            'chkUseSSL
            '
            Me.chkUseSSL.AutoSize = True
            Me.chkUseSSL.Location = New System.Drawing.Point(219, 54)
            Me.chkUseSSL.Name = "chkUseSSL"
            Me.chkUseSSL.Size = New System.Drawing.Size(64, 17)
            Me.chkUseSSL.TabIndex = 14
            Me.chkUseSSL.Text = "Use SSL"
            Me.chkUseSSL.UseVisualStyleBackColor = True
            '
            'lblSenderAddress
            '
            Me.lblSenderAddress.AutoSize = True
            Me.lblSenderAddress.Location = New System.Drawing.Point(18, 82)
            Me.lblSenderAddress.Name = "lblSenderAddress"
            Me.lblSenderAddress.Size = New System.Drawing.Size(87, 13)
            Me.lblSenderAddress.TabIndex = 13
            Me.lblSenderAddress.Text = "Sender Address:"
            '
            'txtSenderAddress
            '
            Me.txtSenderAddress.Location = New System.Drawing.Point(117, 79)
            Me.txtSenderAddress.Name = "txtSenderAddress"
            Me.txtSenderAddress.Size = New System.Drawing.Size(331, 21)
            Me.txtSenderAddress.TabIndex = 12
            '
            'txtSMTPPort
            '
            Me.txtSMTPPort.Location = New System.Drawing.Point(117, 52)
            Me.txtSMTPPort.Name = "txtSMTPPort"
            Me.txtSMTPPort.Size = New System.Drawing.Size(86, 21)
            Me.txtSMTPPort.TabIndex = 11
            '
            'lblSMTPPort
            '
            Me.lblSMTPPort.AutoSize = True
            Me.lblSMTPPort.Location = New System.Drawing.Point(18, 55)
            Me.lblSMTPPort.Name = "lblSMTPPort"
            Me.lblSMTPPort.Size = New System.Drawing.Size(60, 13)
            Me.lblSMTPPort.TabIndex = 10
            Me.lblSMTPPort.Text = "SMTP Port:"
            '
            'btnTestEmail
            '
            Me.btnTestEmail.Location = New System.Drawing.Point(19, 438)
            Me.btnTestEmail.Name = "btnTestEmail"
            Me.btnTestEmail.Size = New System.Drawing.Size(75, 23)
            Me.btnTestEmail.TabIndex = 9
            Me.btnTestEmail.Text = "Test E-Mail"
            Me.btnTestEmail.UseVisualStyleBackColor = True
            '
            'lblEmailPassword
            '
            Me.lblEmailPassword.AutoSize = True
            Me.lblEmailPassword.Enabled = False
            Me.lblEmailPassword.Location = New System.Drawing.Point(52, 327)
            Me.lblEmailPassword.Name = "lblEmailPassword"
            Me.lblEmailPassword.Size = New System.Drawing.Size(57, 13)
            Me.lblEmailPassword.TabIndex = 8
            Me.lblEmailPassword.Text = "Password:"
            '
            'txtEmailPassword
            '
            Me.txtEmailPassword.Enabled = False
            Me.txtEmailPassword.Location = New System.Drawing.Point(117, 323)
            Me.txtEmailPassword.Name = "txtEmailPassword"
            Me.txtEmailPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtEmailPassword.Size = New System.Drawing.Size(250, 21)
            Me.txtEmailPassword.TabIndex = 7
            '
            'txtEmailUsername
            '
            Me.txtEmailUsername.Enabled = False
            Me.txtEmailUsername.Location = New System.Drawing.Point(117, 297)
            Me.txtEmailUsername.Name = "txtEmailUsername"
            Me.txtEmailUsername.Size = New System.Drawing.Size(250, 21)
            Me.txtEmailUsername.TabIndex = 6
            '
            'lblEmailUsername
            '
            Me.lblEmailUsername.AutoSize = True
            Me.lblEmailUsername.Enabled = False
            Me.lblEmailUsername.Location = New System.Drawing.Point(52, 301)
            Me.lblEmailUsername.Name = "lblEmailUsername"
            Me.lblEmailUsername.Size = New System.Drawing.Size(59, 13)
            Me.lblEmailUsername.TabIndex = 5
            Me.lblEmailUsername.Text = "Username:"
            '
            'chkSMTPAuthentication
            '
            Me.chkSMTPAuthentication.AutoSize = True
            Me.chkSMTPAuthentication.Location = New System.Drawing.Point(21, 274)
            Me.chkSMTPAuthentication.Name = "chkSMTPAuthentication"
            Me.chkSMTPAuthentication.Size = New System.Drawing.Size(146, 17)
            Me.chkSMTPAuthentication.TabIndex = 4
            Me.chkSMTPAuthentication.Text = "Use SMTP Authentication"
            Me.chkSMTPAuthentication.UseVisualStyleBackColor = True
            '
            'lblEMailAddress
            '
            Me.lblEMailAddress.Location = New System.Drawing.Point(18, 109)
            Me.lblEMailAddress.Name = "lblEMailAddress"
            Me.lblEMailAddress.Size = New System.Drawing.Size(93, 82)
            Me.lblEMailAddress.TabIndex = 3
            Me.lblEMailAddress.Text = "E-Mail Addresses:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Separate with ;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            '
            'txtEmailAddress
            '
            Me.txtEmailAddress.Location = New System.Drawing.Point(117, 106)
            Me.txtEmailAddress.Multiline = True
            Me.txtEmailAddress.Name = "txtEmailAddress"
            Me.txtEmailAddress.Size = New System.Drawing.Size(331, 158)
            Me.txtEmailAddress.TabIndex = 2
            '
            'txtSMTPServer
            '
            Me.txtSMTPServer.Location = New System.Drawing.Point(117, 26)
            Me.txtSMTPServer.Name = "txtSMTPServer"
            Me.txtSMTPServer.Size = New System.Drawing.Size(331, 21)
            Me.txtSMTPServer.TabIndex = 1
            '
            'lblSMTPServer
            '
            Me.lblSMTPServer.AutoSize = True
            Me.lblSMTPServer.Location = New System.Drawing.Point(18, 29)
            Me.lblSMTPServer.Name = "lblSMTPServer"
            Me.lblSMTPServer.Size = New System.Drawing.Size(72, 13)
            Me.lblSMTPServer.TabIndex = 0
            Me.lblSMTPServer.Text = "SMTP Server:"
            '
            'btnClose
            '
            Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnClose.Location = New System.Drawing.Point(3, 491)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(75, 25)
            Me.btnClose.TabIndex = 26
            Me.btnClose.Text = "&OK"
            '
            'ofd1
            '
            Me.ofd1.FileName = "OpenFileDialog1"
            '
            'tvwSettings
            '
            Me.tvwSettings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tvwSettings.Location = New System.Drawing.Point(0, 0)
            Me.tvwSettings.Name = "tvwSettings"
            TreeNode1.Name = "nodeGeneral"
            TreeNode1.Text = "General"
            TreeNode2.Name = "nodeColours"
            TreeNode2.Text = "Colours & Styles"
            TreeNode3.Name = "nodeDashboard"
            TreeNode3.Text = "Dashboard"
            TreeNode4.Name = "nodeEmail"
            TreeNode4.Text = "E-Mail"
            TreeNode5.Name = "nodeEveAccounts"
            TreeNode5.Text = "Eve Accounts"
            TreeNode6.Name = "nodeEveFolders"
            TreeNode6.Text = "Eve Folders"
            TreeNode7.Name = "nodeEveServer"
            TreeNode7.Text = "Eve API & Server"
            TreeNode8.Name = "nodeG15"
            TreeNode8.Text = "G15 Display"
            TreeNode9.Name = "nodeNotifications"
            TreeNode9.Text = "Notifications"
            TreeNode10.Name = "nodePilots"
            TreeNode10.Text = "Pilots"
            TreeNode11.Name = "nodePlugins"
            TreeNode11.Text = "Plug Ins"
            TreeNode12.Name = "nodeProxyServer"
            TreeNode12.Text = "Proxy Server"
            TreeNode13.Name = "nodeTaskBarIcon"
            TreeNode13.Text = "Taskbar Icon"
            TreeNode14.Name = "nodeTrainingQueue"
            TreeNode14.Text = "Training Queue"
            TreeNode15.Name = "nodeItemOverrides"
            TreeNode15.Text = "Item Overrides"
            TreeNode16.Name = "nodeMarket"
            TreeNode16.Text = "Market & Price Data"
            Me.tvwSettings.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode16})
            Me.tvwSettings.Size = New System.Drawing.Size(180, 463)
            Me.tvwSettings.TabIndex = 27
            '
            'gbColours
            '
            Me.gbColours.Controls.Add(Me.txtCSVSeparator)
            Me.gbColours.Controls.Add(Me.lblCSVSeparatorChar)
            Me.gbColours.Controls.Add(Me.chkDisableVisualStyles)
            Me.gbColours.Controls.Add(Me.gbPilotScreenColours)
            Me.gbColours.Location = New System.Drawing.Point(381, 379)
            Me.gbColours.Name = "gbColours"
            Me.gbColours.Size = New System.Drawing.Size(131, 41)
            Me.gbColours.TabIndex = 28
            Me.gbColours.TabStop = False
            Me.gbColours.Text = "Colours"
            Me.gbColours.Visible = False
            '
            'txtCSVSeparator
            '
            Me.txtCSVSeparator.Location = New System.Drawing.Point(99, 329)
            Me.txtCSVSeparator.MaxLength = 1
            Me.txtCSVSeparator.Name = "txtCSVSeparator"
            Me.txtCSVSeparator.ShortcutsEnabled = False
            Me.txtCSVSeparator.Size = New System.Drawing.Size(46, 21)
            Me.txtCSVSeparator.TabIndex = 40
            '
            'lblCSVSeparatorChar
            '
            Me.lblCSVSeparatorChar.AutoSize = True
            Me.lblCSVSeparatorChar.Location = New System.Drawing.Point(16, 332)
            Me.lblCSVSeparatorChar.Name = "lblCSVSeparatorChar"
            Me.lblCSVSeparatorChar.Size = New System.Drawing.Size(77, 13)
            Me.lblCSVSeparatorChar.TabIndex = 39
            Me.lblCSVSeparatorChar.Text = "CSV Separator"
            '
            'chkDisableVisualStyles
            '
            Me.chkDisableVisualStyles.AutoSize = True
            Me.chkDisableVisualStyles.Location = New System.Drawing.Point(19, 305)
            Me.chkDisableVisualStyles.Name = "chkDisableVisualStyles"
            Me.chkDisableVisualStyles.Size = New System.Drawing.Size(122, 17)
            Me.chkDisableVisualStyles.TabIndex = 38
            Me.chkDisableVisualStyles.Text = "Disable Visual Styles"
            Me.chkDisableVisualStyles.UseVisualStyleBackColor = True
            '
            'gbG15
            '
            Me.gbG15.Controls.Add(Me.nudCycleTime)
            Me.gbG15.Controls.Add(Me.lblCycleTime)
            Me.gbG15.Controls.Add(Me.chkCyclePilots)
            Me.gbG15.Controls.Add(Me.chkActivateG15)
            Me.gbG15.Location = New System.Drawing.Point(456, 227)
            Me.gbG15.Name = "gbG15"
            Me.gbG15.Size = New System.Drawing.Size(95, 37)
            Me.gbG15.TabIndex = 30
            Me.gbG15.TabStop = False
            Me.gbG15.Text = "G15 Display"
            Me.gbG15.Visible = False
            '
            'nudCycleTime
            '
            Me.nudCycleTime.Location = New System.Drawing.Point(301, 71)
            Me.nudCycleTime.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
            Me.nudCycleTime.Name = "nudCycleTime"
            Me.nudCycleTime.Size = New System.Drawing.Size(73, 21)
            Me.nudCycleTime.TabIndex = 5
            '
            'lblCycleTime
            '
            Me.lblCycleTime.AutoSize = True
            Me.lblCycleTime.Location = New System.Drawing.Point(213, 73)
            Me.lblCycleTime.Name = "lblCycleTime"
            Me.lblCycleTime.Size = New System.Drawing.Size(78, 13)
            Me.lblCycleTime.TabIndex = 4
            Me.lblCycleTime.Text = "Cycle Time (s):"
            '
            'chkCyclePilots
            '
            Me.chkCyclePilots.AutoSize = True
            Me.chkCyclePilots.Location = New System.Drawing.Point(47, 72)
            Me.chkCyclePilots.Name = "chkCyclePilots"
            Me.chkCyclePilots.Size = New System.Drawing.Size(121, 17)
            Me.chkCyclePilots.TabIndex = 3
            Me.chkCyclePilots.Text = "Cycle Training Pilots"
            Me.chkCyclePilots.UseVisualStyleBackColor = True
            '
            'chkActivateG15
            '
            Me.chkActivateG15.AutoSize = True
            Me.chkActivateG15.Location = New System.Drawing.Point(19, 35)
            Me.chkActivateG15.Name = "chkActivateG15"
            Me.chkActivateG15.Size = New System.Drawing.Size(125, 17)
            Me.chkActivateG15.TabIndex = 2
            Me.chkActivateG15.Text = "Activate G15 Display"
            Me.chkActivateG15.UseVisualStyleBackColor = True
            '
            'ctxPrices
            '
            Me.ctxPrices.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPriceItemName, Me.ToolStripMenuItem1, Me.mnuPriceAdd, Me.mnuPriceEdit, Me.mnuPriceDelete})
            Me.ctxPrices.Name = "ctxPrices"
            Me.ctxPrices.Size = New System.Drawing.Size(182, 98)
            '
            'mnuPriceItemName
            '
            Me.mnuPriceItemName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.mnuPriceItemName.Name = "mnuPriceItemName"
            Me.mnuPriceItemName.Size = New System.Drawing.Size(181, 22)
            Me.mnuPriceItemName.Text = "Item Name"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(178, 6)
            '
            'mnuPriceAdd
            '
            Me.mnuPriceAdd.Name = "mnuPriceAdd"
            Me.mnuPriceAdd.Size = New System.Drawing.Size(181, 22)
            Me.mnuPriceAdd.Text = "Add Custom Price"
            '
            'mnuPriceEdit
            '
            Me.mnuPriceEdit.Name = "mnuPriceEdit"
            Me.mnuPriceEdit.Size = New System.Drawing.Size(181, 22)
            Me.mnuPriceEdit.Text = "Edit Custom Price"
            '
            'mnuPriceDelete
            '
            Me.mnuPriceDelete.Name = "mnuPriceDelete"
            Me.mnuPriceDelete.Size = New System.Drawing.Size(181, 22)
            Me.mnuPriceDelete.Text = "Delete Custom Price"
            '
            'gbTaskbarIcon
            '
            Me.gbTaskbarIcon.Controls.Add(Me.cboTaskbarIconMode)
            Me.gbTaskbarIcon.Controls.Add(Me.lblTaskbarIconMode)
            Me.gbTaskbarIcon.Location = New System.Drawing.Point(631, 256)
            Me.gbTaskbarIcon.Name = "gbTaskbarIcon"
            Me.gbTaskbarIcon.Size = New System.Drawing.Size(100, 39)
            Me.gbTaskbarIcon.TabIndex = 32
            Me.gbTaskbarIcon.TabStop = False
            Me.gbTaskbarIcon.Text = "Taskbar Icon Settings"
            Me.gbTaskbarIcon.Visible = False
            '
            'cboTaskbarIconMode
            '
            Me.cboTaskbarIconMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboTaskbarIconMode.FormattingEnabled = True
            Me.cboTaskbarIconMode.Items.AddRange(New Object() {"Simple (Tooltip)", "Enhanced (Form)"})
            Me.cboTaskbarIconMode.Location = New System.Drawing.Point(125, 35)
            Me.cboTaskbarIconMode.Name = "cboTaskbarIconMode"
            Me.cboTaskbarIconMode.Size = New System.Drawing.Size(175, 21)
            Me.cboTaskbarIconMode.TabIndex = 1
            '
            'lblTaskbarIconMode
            '
            Me.lblTaskbarIconMode.AutoSize = True
            Me.lblTaskbarIconMode.Location = New System.Drawing.Point(16, 38)
            Me.lblTaskbarIconMode.Name = "lblTaskbarIconMode"
            Me.lblTaskbarIconMode.Size = New System.Drawing.Size(102, 13)
            Me.lblTaskbarIconMode.TabIndex = 0
            Me.lblTaskbarIconMode.Text = "Taskbar Icon Mode:"
            '
            'gbDashboard
            '
            Me.gbDashboard.Controls.Add(Me.cboTickerLocation)
            Me.gbDashboard.Controls.Add(Me.lblTickerLocation)
            Me.gbDashboard.Controls.Add(Me.dbDashboardConfig)
            Me.gbDashboard.Controls.Add(Me.chkShowPriceTicker)
            Me.gbDashboard.Location = New System.Drawing.Point(520, 90)
            Me.gbDashboard.Name = "gbDashboard"
            Me.gbDashboard.Size = New System.Drawing.Size(131, 45)
            Me.gbDashboard.TabIndex = 33
            Me.gbDashboard.TabStop = False
            Me.gbDashboard.Text = "Dashboard"
            Me.gbDashboard.Visible = False
            '
            'cboTickerLocation
            '
            Me.cboTickerLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboTickerLocation.FormattingEnabled = True
            Me.cboTickerLocation.Items.AddRange(New Object() {"Top", "Bottom"})
            Me.cboTickerLocation.Location = New System.Drawing.Point(242, 469)
            Me.cboTickerLocation.Name = "cboTickerLocation"
            Me.cboTickerLocation.Size = New System.Drawing.Size(83, 21)
            Me.cboTickerLocation.TabIndex = 2
            '
            'lblTickerLocation
            '
            Me.lblTickerLocation.AutoSize = True
            Me.lblTickerLocation.Location = New System.Drawing.Point(154, 472)
            Me.lblTickerLocation.Name = "lblTickerLocation"
            Me.lblTickerLocation.Size = New System.Drawing.Size(82, 13)
            Me.lblTickerLocation.TabIndex = 1
            Me.lblTickerLocation.Text = "Ticker Location:"
            '
            'dbDashboardConfig
            '
            Me.dbDashboardConfig.Controls.Add(Me.lblWidgetTypes)
            Me.dbDashboardConfig.Controls.Add(Me.cboWidgets)
            Me.dbDashboardConfig.Controls.Add(Me.btnAddWidget)
            Me.dbDashboardConfig.Controls.Add(Me.btnRemoveWidget)
            Me.dbDashboardConfig.Controls.Add(Me.lvWidgets)
            Me.dbDashboardConfig.Controls.Add(Me.lblCurrentWidgets)
            Me.dbDashboardConfig.Location = New System.Drawing.Point(13, 24)
            Me.dbDashboardConfig.Name = "dbDashboardConfig"
            Me.dbDashboardConfig.Size = New System.Drawing.Size(673, 428)
            Me.dbDashboardConfig.TabIndex = 39
            Me.dbDashboardConfig.TabStop = False
            Me.dbDashboardConfig.Text = "Dashboard Configuration"
            '
            'lblWidgetTypes
            '
            Me.lblWidgetTypes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblWidgetTypes.AutoSize = True
            Me.lblWidgetTypes.Location = New System.Drawing.Point(14, 402)
            Me.lblWidgetTypes.Name = "lblWidgetTypes"
            Me.lblWidgetTypes.Size = New System.Drawing.Size(77, 13)
            Me.lblWidgetTypes.TabIndex = 5
            Me.lblWidgetTypes.Text = "Widget Types:"
            '
            'cboWidgets
            '
            Me.cboWidgets.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cboWidgets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboWidgets.FormattingEnabled = True
            Me.cboWidgets.Location = New System.Drawing.Point(93, 399)
            Me.cboWidgets.Name = "cboWidgets"
            Me.cboWidgets.Size = New System.Drawing.Size(184, 21)
            Me.cboWidgets.Sorted = True
            Me.cboWidgets.TabIndex = 4
            '
            'btnAddWidget
            '
            Me.btnAddWidget.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnAddWidget.Location = New System.Drawing.Point(283, 397)
            Me.btnAddWidget.Name = "btnAddWidget"
            Me.btnAddWidget.Size = New System.Drawing.Size(75, 23)
            Me.btnAddWidget.TabIndex = 3
            Me.btnAddWidget.Text = "Add Widget"
            Me.btnAddWidget.UseVisualStyleBackColor = True
            '
            'btnRemoveWidget
            '
            Me.btnRemoveWidget.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnRemoveWidget.Location = New System.Drawing.Point(364, 397)
            Me.btnRemoveWidget.Name = "btnRemoveWidget"
            Me.btnRemoveWidget.Size = New System.Drawing.Size(75, 23)
            Me.btnRemoveWidget.TabIndex = 2
            Me.btnRemoveWidget.Text = "Remove"
            Me.btnRemoveWidget.UseVisualStyleBackColor = True
            '
            'lvWidgets
            '
            Me.lvWidgets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.lvWidgets.Border.Class = "ListViewBorder"
            Me.lvWidgets.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lvWidgets.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colWidgetType, Me.colWidgetInfo})
            Me.lvWidgets.DisabledBackColor = System.Drawing.Color.Empty
            Me.lvWidgets.FullRowSelect = True
            Me.lvWidgets.GridLines = True
            Me.lvWidgets.Location = New System.Drawing.Point(11, 40)
            Me.lvWidgets.Name = "lvWidgets"
            Me.lvWidgets.Size = New System.Drawing.Size(652, 353)
            Me.lvWidgets.TabIndex = 1
            Me.lvWidgets.UseCompatibleStateImageBehavior = False
            Me.lvWidgets.View = System.Windows.Forms.View.Details
            '
            'colWidgetType
            '
            Me.colWidgetType.Text = "Widget Type"
            Me.colWidgetType.Width = 100
            '
            'colWidgetInfo
            '
            Me.colWidgetInfo.Text = "Widget information"
            Me.colWidgetInfo.Width = 500
            '
            'lblCurrentWidgets
            '
            Me.lblCurrentWidgets.AutoSize = True
            Me.lblCurrentWidgets.Location = New System.Drawing.Point(8, 24)
            Me.lblCurrentWidgets.Name = "lblCurrentWidgets"
            Me.lblCurrentWidgets.Size = New System.Drawing.Size(90, 13)
            Me.lblCurrentWidgets.TabIndex = 0
            Me.lblCurrentWidgets.Text = "Current Widgets:"
            '
            'chkShowPriceTicker
            '
            Me.chkShowPriceTicker.AutoSize = True
            Me.chkShowPriceTicker.Location = New System.Drawing.Point(13, 471)
            Me.chkShowPriceTicker.Name = "chkShowPriceTicker"
            Me.chkShowPriceTicker.Size = New System.Drawing.Size(109, 17)
            Me.chkShowPriceTicker.TabIndex = 0
            Me.chkShowPriceTicker.Text = "Show Price Ticker"
            Me.chkShowPriceTicker.UseVisualStyleBackColor = True
            '
            'panelSettings
            '
            Me.panelSettings.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelSettings.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelSettings.Controls.Add(Me.gbTrainingQueue)
            Me.panelSettings.Controls.Add(Me.gbGeneral)
            Me.panelSettings.Controls.Add(Me.gbPlugIns)
            Me.panelSettings.Controls.Add(Me.gbPilots)
            Me.panelSettings.Controls.Add(Me.gbItemOverrides)
            Me.panelSettings.Controls.Add(Me.gbEveAccounts)
            Me.panelSettings.Controls.Add(Me.gbMarket)
            Me.panelSettings.Controls.Add(Me.gbEveServer)
            Me.panelSettings.Controls.Add(Me.gbNotifications)
            Me.panelSettings.Controls.Add(Me.gbDashboard)
            Me.panelSettings.Controls.Add(Me.gbEveFolders)
            Me.panelSettings.Controls.Add(Me.gbProxyServer)
            Me.panelSettings.Controls.Add(Me.gbEmail)
            Me.panelSettings.Controls.Add(Me.gbTaskbarIcon)
            Me.panelSettings.Controls.Add(Me.gpNav)
            Me.panelSettings.Controls.Add(Me.btnClose)
            Me.panelSettings.Controls.Add(Me.gbG15)
            Me.panelSettings.Controls.Add(Me.gbColours)
            Me.panelSettings.DisabledBackColor = System.Drawing.Color.Empty
            Me.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelSettings.Location = New System.Drawing.Point(0, 0)
            Me.panelSettings.Name = "panelSettings"
            Me.panelSettings.Size = New System.Drawing.Size(904, 522)
            Me.panelSettings.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelSettings.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelSettings.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelSettings.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelSettings.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelSettings.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelSettings.Style.GradientAngle = 90
            Me.panelSettings.TabIndex = 34
            '
            'gbItemOverrides
            '
            Me.gbItemOverrides.Controls.Add(Me.Panel1)
            Me.gbItemOverrides.Controls.Add(Me.Label10)
            Me.gbItemOverrides.Controls.Add(Me._itemOverridesActiveGrid)
            Me.gbItemOverrides.Controls.Add(Me._itemOverrideRemoveOverride)
            Me.gbItemOverrides.Controls.Add(Me._itemOverrideAddOverride)
            Me.gbItemOverrides.Controls.Add(Me._itemOverrideItemList)
            Me.gbItemOverrides.Controls.Add(Me.Label9)
            Me.gbItemOverrides.Controls.Add(Me.Label8)
            Me.gbItemOverrides.Controls.Add(Me._itemOverridePercentPrice)
            Me.gbItemOverrides.Controls.Add(Me.Label7)
            Me.gbItemOverrides.Controls.Add(Me._itemOverrideMedianPrice)
            Me.gbItemOverrides.Controls.Add(Me._itemOverrideMinPrice)
            Me.gbItemOverrides.Controls.Add(Me._itemOverrideAvgPrice)
            Me.gbItemOverrides.Controls.Add(Me._itemOverrideMaxPrice)
            Me.gbItemOverrides.Location = New System.Drawing.Point(710, 446)
            Me.gbItemOverrides.Name = "gbItemOverrides"
            Me.gbItemOverrides.Size = New System.Drawing.Size(125, 27)
            Me.gbItemOverrides.TabIndex = 36
            Me.gbItemOverrides.TabStop = False
            Me.gbItemOverrides.Text = "Item Market Data Overrides"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me._itemOverrideSellOrders)
            Me.Panel1.Controls.Add(Me._itemOverrideBuyOrders)
            Me.Panel1.Controls.Add(Me._itemOverrideAllOrders)
            Me.Panel1.Location = New System.Drawing.Point(208, 66)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(230, 28)
            Me.Panel1.TabIndex = 30
            '
            '_itemOverrideSellOrders
            '
            Me._itemOverrideSellOrders.AutoSize = True
            Me._itemOverrideSellOrders.Location = New System.Drawing.Point(4, 8)
            Me._itemOverrideSellOrders.Name = "_itemOverrideSellOrders"
            Me._itemOverrideSellOrders.Size = New System.Drawing.Size(41, 17)
            Me._itemOverrideSellOrders.TabIndex = 21
            Me._itemOverrideSellOrders.TabStop = True
            Me._itemOverrideSellOrders.Text = "Sell"
            Me._itemOverrideSellOrders.UseVisualStyleBackColor = True
            '
            '_itemOverrideBuyOrders
            '
            Me._itemOverrideBuyOrders.AutoSize = True
            Me._itemOverrideBuyOrders.Location = New System.Drawing.Point(74, 8)
            Me._itemOverrideBuyOrders.Name = "_itemOverrideBuyOrders"
            Me._itemOverrideBuyOrders.Size = New System.Drawing.Size(43, 17)
            Me._itemOverrideBuyOrders.TabIndex = 22
            Me._itemOverrideBuyOrders.TabStop = True
            Me._itemOverrideBuyOrders.Text = "Buy"
            Me._itemOverrideBuyOrders.UseVisualStyleBackColor = True
            '
            '_itemOverrideAllOrders
            '
            Me._itemOverrideAllOrders.AutoSize = True
            Me._itemOverrideAllOrders.Location = New System.Drawing.Point(142, 8)
            Me._itemOverrideAllOrders.Name = "_itemOverrideAllOrders"
            Me._itemOverrideAllOrders.Size = New System.Drawing.Size(36, 17)
            Me._itemOverrideAllOrders.TabIndex = 23
            Me._itemOverrideAllOrders.TabStop = True
            Me._itemOverrideAllOrders.Text = "All"
            Me._itemOverrideAllOrders.UseVisualStyleBackColor = True
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.0!)
            Me.Label10.Location = New System.Drawing.Point(286, 197)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(139, 17)
            Me.Label10.TabIndex = 29
            Me.Label10.Text = "Active Item Overrides"
            '
            '_itemOverridesActiveGrid
            '
            Me._itemOverridesActiveGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me._itemOverridesActiveGrid.AllowDrop = True
            Me._itemOverridesActiveGrid.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me._itemOverridesActiveGrid.BackgroundStyle.Class = "TreeBorderKey"
            Me._itemOverridesActiveGrid.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me._itemOverridesActiveGrid.Columns.Add(Me._itemOverridesActiveGridNameColumn)
            Me._itemOverridesActiveGrid.Columns.Add(Me._itemOverridesActiveGridItemIdColumn)
            Me._itemOverridesActiveGrid.Columns.Add(Me._itemOverridesActiveGridOrderTypeColumn)
            Me._itemOverridesActiveGrid.Columns.Add(Me._itemOverridesActiveGridMetricColumn)
            
            Me._itemOverridesActiveGrid.Location = New System.Drawing.Point(24, 220)
            Me._itemOverridesActiveGrid.Name = "_itemOverridesActiveGrid"
            Me._itemOverridesActiveGrid.NodesConnector = Me.NodeConnector2
            Me._itemOverridesActiveGrid.NodeStyle = Me.ElementStyle2
            Me._itemOverridesActiveGrid.PathSeparator = ";"
            Me._itemOverridesActiveGrid.Size = New System.Drawing.Size(660, 253)
            Me._itemOverridesActiveGrid.Styles.Add(Me.ElementStyle2)
            Me._itemOverridesActiveGrid.TabIndex = 28
            Me._itemOverridesActiveGrid.Text = "AdvTree1"
            '
            '_itemOverridesActiveGridNameColumn
            '
            Me._itemOverridesActiveGridNameColumn.Name = "_itemOverridesActiveGridNameColumn"
            Me._itemOverridesActiveGridNameColumn.StretchToFill = True
            Me._itemOverridesActiveGridNameColumn.Text = "Item Name"
            Me._itemOverridesActiveGridNameColumn.Width.Absolute = 150
            '
            '_itemOverridesActiveGridItemIdColumn
            '
            Me._itemOverridesActiveGridItemIdColumn.Name = "_itemOverridesActiveGridItemIdColumn"
            Me._itemOverridesActiveGridItemIdColumn.Text = "ItemId"
            Me._itemOverridesActiveGridItemIdColumn.Visible = False
            Me._itemOverridesActiveGridItemIdColumn.Width.Absolute = 150
            '
            '_itemOverridesActiveGridOrderTypeColumn
            '
            Me._itemOverridesActiveGridOrderTypeColumn.Name = "_itemOverridesActiveGridOrderTypeColumn"
            Me._itemOverridesActiveGridOrderTypeColumn.Text = "Source Order Type"
            Me._itemOverridesActiveGridOrderTypeColumn.Width.Absolute = 150
            '
            '_itemOverridesActiveGridMetricColumn
            '
            Me._itemOverridesActiveGridMetricColumn.Name = "_itemOverridesActiveGridMetricColumn"
            Me._itemOverridesActiveGridMetricColumn.Text = "Price Metric"
            Me._itemOverridesActiveGridMetricColumn.Width.Absolute = 150
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
            '_itemOverrideRemoveOverride
            '
            Me._itemOverrideRemoveOverride.Location = New System.Drawing.Point(362, 150)
            Me._itemOverrideRemoveOverride.Name = "_itemOverrideRemoveOverride"
            Me._itemOverrideRemoveOverride.Size = New System.Drawing.Size(87, 26)
            Me._itemOverrideRemoveOverride.TabIndex = 27
            Me._itemOverrideRemoveOverride.Text = "Remove"
            Me._itemOverrideRemoveOverride.UseVisualStyleBackColor = True
            '
            '_itemOverrideAddOverride
            '
            Me._itemOverrideAddOverride.Location = New System.Drawing.Point(259, 150)
            Me._itemOverrideAddOverride.Name = "_itemOverrideAddOverride"
            Me._itemOverrideAddOverride.Size = New System.Drawing.Size(87, 26)
            Me._itemOverrideAddOverride.TabIndex = 26
            Me._itemOverrideAddOverride.Text = "Add / Update"
            Me._itemOverrideAddOverride.UseVisualStyleBackColor = True
            '
            '_itemOverrideItemList
            '
            Me._itemOverrideItemList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me._itemOverrideItemList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me._itemOverrideItemList.FormattingEnabled = True
            Me._itemOverrideItemList.Location = New System.Drawing.Point(275, 31)
            Me._itemOverrideItemList.Name = "_itemOverrideItemList"
            Me._itemOverrideItemList.Size = New System.Drawing.Size(203, 21)
            Me._itemOverrideItemList.TabIndex = 25
            Me._itemOverrideItemList.Text = "Select/Search an Item"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(231, 34)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(33, 13)
            Me.Label9.TabIndex = 24
            Me.Label9.Text = "Item:"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(127, 75)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(66, 13)
            Me.Label8.TabIndex = 20
            Me.Label8.Text = "Order Type:"
            '
            '_itemOverridePercentPrice
            '
            Me._itemOverridePercentPrice.AutoSize = True
            Me._itemOverridePercentPrice.Location = New System.Drawing.Point(495, 101)
            Me._itemOverridePercentPrice.Name = "_itemOverridePercentPrice"
            Me._itemOverridePercentPrice.Size = New System.Drawing.Size(100, 17)
            Me._itemOverridePercentPrice.TabIndex = 19
            Me._itemOverridePercentPrice.TabStop = True
            Me._itemOverridePercentPrice.Text = "Percentile (5%)"
            Me._itemOverridePercentPrice.UseVisualStyleBackColor = True
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(127, 103)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(69, 13)
            Me.Label7.TabIndex = 14
            Me.Label7.Text = "Price Metric: "
            '
            '_itemOverrideMedianPrice
            '
            Me._itemOverrideMedianPrice.AutoSize = True
            Me._itemOverrideMedianPrice.Location = New System.Drawing.Point(430, 101)
            Me._itemOverrideMedianPrice.Name = "_itemOverrideMedianPrice"
            Me._itemOverrideMedianPrice.Size = New System.Drawing.Size(59, 17)
            Me._itemOverrideMedianPrice.TabIndex = 18
            Me._itemOverrideMedianPrice.TabStop = True
            Me._itemOverrideMedianPrice.Text = "Median"
            Me._itemOverrideMedianPrice.UseVisualStyleBackColor = True
            '
            '_itemOverrideMinPrice
            '
            Me._itemOverrideMinPrice.AutoSize = True
            Me._itemOverrideMinPrice.Location = New System.Drawing.Point(212, 101)
            Me._itemOverrideMinPrice.Name = "_itemOverrideMinPrice"
            Me._itemOverrideMinPrice.Size = New System.Drawing.Size(65, 17)
            Me._itemOverrideMinPrice.TabIndex = 15
            Me._itemOverrideMinPrice.TabStop = True
            Me._itemOverrideMinPrice.Text = "Minimum"
            Me._itemOverrideMinPrice.UseVisualStyleBackColor = True
            '
            '_itemOverrideAvgPrice
            '
            Me._itemOverrideAvgPrice.AutoSize = True
            Me._itemOverrideAvgPrice.Location = New System.Drawing.Point(358, 101)
            Me._itemOverrideAvgPrice.Name = "_itemOverrideAvgPrice"
            Me._itemOverrideAvgPrice.Size = New System.Drawing.Size(66, 17)
            Me._itemOverrideAvgPrice.TabIndex = 17
            Me._itemOverrideAvgPrice.TabStop = True
            Me._itemOverrideAvgPrice.Text = "Average"
            Me._itemOverrideAvgPrice.UseVisualStyleBackColor = True
            '
            '_itemOverrideMaxPrice
            '
            Me._itemOverrideMaxPrice.AutoSize = True
            Me._itemOverrideMaxPrice.Location = New System.Drawing.Point(283, 101)
            Me._itemOverrideMaxPrice.Name = "_itemOverrideMaxPrice"
            Me._itemOverrideMaxPrice.Size = New System.Drawing.Size(69, 17)
            Me._itemOverrideMaxPrice.TabIndex = 16
            Me._itemOverrideMaxPrice.TabStop = True
            Me._itemOverrideMaxPrice.Text = "Maximum"
            Me._itemOverrideMaxPrice.UseVisualStyleBackColor = True
            '
            'gbMarket
            '
            Me.gbMarket.Controls.Add(Me.Label11)
            Me.gbMarket.Controls.Add(Me.Panel2)
            Me.gbMarket.Controls.Add(Me.enableMarketDataUpload)
            Me.gbMarket.Controls.Add(Me.GroupBox1)
            Me.gbMarket.Controls.Add(Me._usePercentile)
            Me.gbMarket.Controls.Add(Me._useMedianPrice)
            Me.gbMarket.Controls.Add(Me._useAveragePrice)
            Me.gbMarket.Controls.Add(Me._useMaximumPrice)
            Me.gbMarket.Controls.Add(Me._useMiniumPrice)
            Me.gbMarket.Controls.Add(Me.Label5)
            Me.gbMarket.Controls.Add(Me._marketDataProvider)
            Me.gbMarket.Controls.Add(Me.Label1)
            Me.gbMarket.Location = New System.Drawing.Point(713, 172)
            Me.gbMarket.Name = "gbMarket"
            Me.gbMarket.Size = New System.Drawing.Size(148, 32)
            Me.gbMarket.TabIndex = 35
            Me.gbMarket.TabStop = False
            Me.gbMarket.Text = "Market and Price Data"
            Me.gbMarket.Visible = False
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(16, 68)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(135, 13)
            Me.Label11.TabIndex = 15
            Me.Label11.Text = "Default Transaction Type: "
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me._defaultAll)
            Me.Panel2.Controls.Add(Me._defaultBuy)
            Me.Panel2.Controls.Add(Me._defaultSell)
            Me.Panel2.Location = New System.Drawing.Point(163, 62)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(328, 25)
            Me.Panel2.TabIndex = 14
            '
            '_defaultAll
            '
            Me._defaultAll.AutoSize = True
            Me._defaultAll.Location = New System.Drawing.Point(141, 4)
            Me._defaultAll.Name = "_defaultAll"
            Me._defaultAll.Size = New System.Drawing.Size(36, 17)
            Me._defaultAll.TabIndex = 18
            Me._defaultAll.TabStop = True
            Me._defaultAll.Text = "All"
            Me._defaultAll.UseVisualStyleBackColor = True
            '
            '_defaultBuy
            '
            Me._defaultBuy.AutoSize = True
            Me._defaultBuy.Location = New System.Drawing.Point(73, 4)
            Me._defaultBuy.Name = "_defaultBuy"
            Me._defaultBuy.Size = New System.Drawing.Size(43, 17)
            Me._defaultBuy.TabIndex = 17
            Me._defaultBuy.TabStop = True
            Me._defaultBuy.Text = "Buy"
            Me._defaultBuy.UseVisualStyleBackColor = True
            '
            '_defaultSell
            '
            Me._defaultSell.AutoSize = True
            Me._defaultSell.Location = New System.Drawing.Point(3, 4)
            Me._defaultSell.Name = "_defaultSell"
            Me._defaultSell.Size = New System.Drawing.Size(41, 17)
            Me._defaultSell.TabIndex = 16
            Me._defaultSell.TabStop = True
            Me._defaultSell.Text = "Sell"
            Me._defaultSell.UseVisualStyleBackColor = True
            '
            'enableMarketDataUpload
            '
            Me.enableMarketDataUpload.AutoSize = True
            Me.enableMarketDataUpload.Location = New System.Drawing.Point(313, 37)
            Me.enableMarketDataUpload.Name = "enableMarketDataUpload"
            Me.enableMarketDataUpload.Size = New System.Drawing.Size(166, 17)
            Me.enableMarketDataUpload.TabIndex = 13
            Me.enableMarketDataUpload.Text = "Enable Market Data Uploader"
            Me.enableMarketDataUpload.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me._systemList)
            Me.GroupBox1.Controls.Add(Me._regionList)
            Me.GroupBox1.Controls.Add(Me._useSystemPrice)
            Me.GroupBox1.Controls.Add(Me._useRegionData)
            Me.GroupBox1.Location = New System.Drawing.Point(23, 111)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(558, 369)
            Me.GroupBox1.TabIndex = 11
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Data Sample Source"
            '
            '_systemList
            '
            Me._systemList.FormattingEnabled = True
            Me._systemList.Location = New System.Drawing.Point(292, 67)
            Me._systemList.Name = "_systemList"
            Me._systemList.Size = New System.Drawing.Size(207, 290)
            Me._systemList.TabIndex = 3
            '
            '_regionList
            '
            Me._regionList.FormattingEnabled = True
            Me._regionList.Location = New System.Drawing.Point(36, 66)
            Me._regionList.Name = "_regionList"
            Me._regionList.Size = New System.Drawing.Size(207, 290)
            Me._regionList.TabIndex = 1
            '
            '_useSystemPrice
            '
            Me._useSystemPrice.AutoSize = True
            Me._useSystemPrice.Checked = True
            Me._useSystemPrice.Location = New System.Drawing.Point(331, 18)
            Me._useSystemPrice.Name = "_useSystemPrice"
            Me._useSystemPrice.Size = New System.Drawing.Size(120, 17)
            Me._useSystemPrice.TabIndex = 9
            Me._useSystemPrice.TabStop = True
            Me._useSystemPrice.Text = "Use Specific System"
            Me._useSystemPrice.UseVisualStyleBackColor = True
            '
            '_useRegionData
            '
            Me._useRegionData.AutoSize = True
            Me._useRegionData.Location = New System.Drawing.Point(66, 18)
            Me._useRegionData.Name = "_useRegionData"
            Me._useRegionData.Size = New System.Drawing.Size(128, 17)
            Me._useRegionData.TabIndex = 8
            Me._useRegionData.Text = "Use Selected Regions"
            Me._useRegionData.UseVisualStyleBackColor = True
            '
            '_usePercentile
            '
            Me._usePercentile.AutoSize = True
            Me._usePercentile.Location = New System.Drawing.Point(435, 87)
            Me._usePercentile.Name = "_usePercentile"
            Me._usePercentile.Size = New System.Drawing.Size(100, 17)
            Me._usePercentile.TabIndex = 7
            Me._usePercentile.TabStop = True
            Me._usePercentile.Text = "Percentile (5%)"
            Me._usePercentile.UseVisualStyleBackColor = True
            '
            '_useMedianPrice
            '
            Me._useMedianPrice.AutoSize = True
            Me._useMedianPrice.Location = New System.Drawing.Point(370, 87)
            Me._useMedianPrice.Name = "_useMedianPrice"
            Me._useMedianPrice.Size = New System.Drawing.Size(59, 17)
            Me._useMedianPrice.TabIndex = 6
            Me._useMedianPrice.TabStop = True
            Me._useMedianPrice.Text = "Median"
            Me._useMedianPrice.UseVisualStyleBackColor = True
            '
            '_useAveragePrice
            '
            Me._useAveragePrice.AutoSize = True
            Me._useAveragePrice.Location = New System.Drawing.Point(304, 87)
            Me._useAveragePrice.Name = "_useAveragePrice"
            Me._useAveragePrice.Size = New System.Drawing.Size(60, 17)
            Me._useAveragePrice.TabIndex = 5
            Me._useAveragePrice.TabStop = True
            Me._useAveragePrice.Text = "Averge"
            Me._useAveragePrice.UseVisualStyleBackColor = True
            '
            '_useMaximumPrice
            '
            Me._useMaximumPrice.AutoSize = True
            Me._useMaximumPrice.Location = New System.Drawing.Point(237, 87)
            Me._useMaximumPrice.Name = "_useMaximumPrice"
            Me._useMaximumPrice.Size = New System.Drawing.Size(61, 17)
            Me._useMaximumPrice.TabIndex = 4
            Me._useMaximumPrice.TabStop = True
            Me._useMaximumPrice.Text = "Maxium"
            Me._useMaximumPrice.UseVisualStyleBackColor = True
            '
            '_useMiniumPrice
            '
            Me._useMiniumPrice.AutoSize = True
            Me._useMiniumPrice.Location = New System.Drawing.Point(166, 87)
            Me._useMiniumPrice.Name = "_useMiniumPrice"
            Me._useMiniumPrice.Size = New System.Drawing.Size(65, 17)
            Me._useMiniumPrice.TabIndex = 3
            Me._useMiniumPrice.TabStop = True
            Me._useMiniumPrice.Text = "Minimum"
            Me._useMiniumPrice.UseVisualStyleBackColor = True
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(44, 89)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(107, 13)
            Me.Label5.TabIndex = 2
            Me.Label5.Text = "Default Price Metric: "
            '
            '_marketDataProvider
            '
            Me._marketDataProvider.FormattingEnabled = True
            Me._marketDataProvider.Location = New System.Drawing.Point(105, 35)
            Me._marketDataProvider.Name = "_marketDataProvider"
            Me._marketDataProvider.Size = New System.Drawing.Size(165, 21)
            Me._marketDataProvider.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(22, 38)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(77, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Data Provider:"
            '
            'gpNav
            '
            Me.gpNav.CanvasColor = System.Drawing.SystemColors.Control
            Me.gpNav.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.gpNav.Controls.Add(Me.tvwSettings)
            Me.gpNav.DisabledBackColor = System.Drawing.Color.Empty
            Me.gpNav.Location = New System.Drawing.Point(3, 3)
            Me.gpNav.Name = "gpNav"
            Me.gpNav.Size = New System.Drawing.Size(186, 485)
            '
            '
            '
            Me.gpNav.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.gpNav.Style.BackColorGradientAngle = 90
            Me.gpNav.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.gpNav.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpNav.Style.BorderBottomWidth = 1
            Me.gpNav.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.gpNav.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpNav.Style.BorderLeftWidth = 1
            Me.gpNav.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpNav.Style.BorderRightWidth = 1
            Me.gpNav.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpNav.Style.BorderTopWidth = 1
            Me.gpNav.Style.CornerDiameter = 4
            Me.gpNav.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.gpNav.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.gpNav.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.gpNav.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.gpNav.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.gpNav.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.gpNav.TabIndex = 34
            Me.gpNav.Text = "Settings Navigation"
            '
            'STT
            '
            Me.STT.DefaultFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.STT.DefaultTooltipSettings = SuperTooltipInfo1
            
            Me.STT.MinimumTooltipSize = New System.Drawing.Size(300, 24)
            Me.STT.PositionBelowControl = False
            '
            'FrmSettings
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(904, 522)
            Me.Controls.Add(Me.panelSettings)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmSettings"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "EveHQ Settings"
            Me.gbGeneral.ResumeLayout(False)
            Me.gbGeneral.PerformLayout()
            CType(Me.nudAutomaticSaveTime, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbPilotScreenColours.ResumeLayout(False)
            Me.gbPilotScreenColours.PerformLayout()
            CType(Me.pbPilotSkillHighlight, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbPilotSkillText, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbPilotGroupText, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbPilotGroupBG, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbPilotLevel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbPilotPartial, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbPilotCurrent, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbPilotStandard, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbEveAccounts.ResumeLayout(False)
            CType(Me.adtAccounts, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbPilots.ResumeLayout(False)
            Me.gbEveFolders.ResumeLayout(False)
            Me.gbLocation4.ResumeLayout(False)
            Me.gbLocation4.PerformLayout()
            Me.gbLocation3.ResumeLayout(False)
            Me.gbLocation3.PerformLayout()
            Me.gbLocation2.ResumeLayout(False)
            Me.gbLocation2.PerformLayout()
            Me.gbLocation1.ResumeLayout(False)
            Me.gbLocation1.PerformLayout()
            Me.gbTrainingQueue.ResumeLayout(False)
            Me.gbTrainingQueue.PerformLayout()
            CType(Me.nudEveQueueDisplayLength, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbPartiallyTrainedColour, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbReadySkillColour, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbDowntimeClashColour, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbBothPreReqColour, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbHasPreReqColour, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbIsPreReqColour, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbProxyServer.ResumeLayout(False)
            Me.gbProxyServer.PerformLayout()
            Me.gbProxyServerInfo.ResumeLayout(False)
            Me.gbProxyServerInfo.PerformLayout()
            Me.gbEveServer.ResumeLayout(False)
            Me.gbEveServer.PerformLayout()
            Me.gbAPIServer.ResumeLayout(False)
            Me.gbAPIServer.PerformLayout()
            Me.gbPlugIns.ResumeLayout(False)
            Me.gbPlugIns.PerformLayout()
            Me.gbNotifications.ResumeLayout(False)
            Me.gbNotifications.PerformLayout()
            CType(Me.nudAccountTimeLimit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudShutdownNotifyPeriod, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbEmail.ResumeLayout(False)
            Me.gbEmail.PerformLayout()
            Me.gbColours.ResumeLayout(False)
            Me.gbColours.PerformLayout()
            Me.gbG15.ResumeLayout(False)
            Me.gbG15.PerformLayout()
            CType(Me.nudCycleTime, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ctxPrices.ResumeLayout(False)
            Me.gbTaskbarIcon.ResumeLayout(False)
            Me.gbTaskbarIcon.PerformLayout()
            Me.gbDashboard.ResumeLayout(False)
            Me.gbDashboard.PerformLayout()
            Me.dbDashboardConfig.ResumeLayout(False)
            Me.dbDashboardConfig.PerformLayout()
            Me.panelSettings.ResumeLayout(False)
            Me.gbItemOverrides.ResumeLayout(False)
            Me.gbItemOverrides.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            CType(Me._itemOverridesActiveGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbMarket.ResumeLayout(False)
            Me.gbMarket.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.gpNav.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents gbEveAccounts As System.Windows.Forms.GroupBox
        Friend WithEvents btnDeleteAccount As System.Windows.Forms.Button
        Friend WithEvents btnEditAccount As System.Windows.Forms.Button
        Friend WithEvents btnAddAccount As System.Windows.Forms.Button
        Friend WithEvents gbPilots As System.Windows.Forms.GroupBox
        Friend WithEvents btnDeletePilot As System.Windows.Forms.Button
        Friend WithEvents btnAddPilot As System.Windows.Forms.Button
        Friend WithEvents lvwPilots As DevComponents.DotNetBar.Controls.ListViewEx
        Friend WithEvents colPilot As System.Windows.Forms.ColumnHeader
        Friend WithEvents colAccount As System.Windows.Forms.ColumnHeader
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents colID As System.Windows.Forms.ColumnHeader
        Friend WithEvents gbGeneral As System.Windows.Forms.GroupBox
        Friend WithEvents chkAutoRun As System.Windows.Forms.CheckBox
        Friend WithEvents chkAutoHide As System.Windows.Forms.CheckBox
        Friend WithEvents chkAutoMinimise As System.Windows.Forms.CheckBox
        Friend WithEvents fbd1 As System.Windows.Forms.FolderBrowserDialog
        Friend WithEvents gbEveFolders As System.Windows.Forms.GroupBox
        Friend WithEvents btnClear4 As System.Windows.Forms.Button
        Friend WithEvents btnClear3 As System.Windows.Forms.Button
        Friend WithEvents btnClear2 As System.Windows.Forms.Button
        Friend WithEvents btnClear1 As System.Windows.Forms.Button
        Friend WithEvents btnEveDir4 As System.Windows.Forms.Button
        Friend WithEvents lblEveDir4 As System.Windows.Forms.Label
        Friend WithEvents btnEveDir3 As System.Windows.Forms.Button
        Friend WithEvents lblEveDir3 As System.Windows.Forms.Label
        Friend WithEvents btnEveDir2 As System.Windows.Forms.Button
        Friend WithEvents lblEveDir2 As System.Windows.Forms.Label
        Friend WithEvents btnEveDir1 As System.Windows.Forms.Button
        Friend WithEvents lblEveDir1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents cboStartupPilot As System.Windows.Forms.ComboBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents btnGetData As System.Windows.Forms.Button
        Friend WithEvents lblQueueColumns As System.Windows.Forms.Label
        Friend WithEvents ofd1 As System.Windows.Forms.OpenFileDialog
        Friend WithEvents btnAddPilotFromXML As System.Windows.Forms.Button
        Friend WithEvents gbProxyServer As System.Windows.Forms.GroupBox
        Friend WithEvents chkUseProxy As System.Windows.Forms.CheckBox
        Friend WithEvents gbProxyServerInfo As System.Windows.Forms.GroupBox
        Friend WithEvents lblProxyServer As System.Windows.Forms.Label
        Friend WithEvents txtProxyServer As System.Windows.Forms.TextBox
        Friend WithEvents radUseDefaultCreds As System.Windows.Forms.RadioButton
        Friend WithEvents radUseSpecifiedCreds As System.Windows.Forms.RadioButton
        Friend WithEvents lblProxyPassword As System.Windows.Forms.Label
        Friend WithEvents lblProxyUsername As System.Windows.Forms.Label
        Friend WithEvents txtProxyPassword As System.Windows.Forms.TextBox
        Friend WithEvents txtProxyUsername As System.Windows.Forms.TextBox
        Friend WithEvents gbEveServer As System.Windows.Forms.GroupBox
        Friend WithEvents lblCurrentOffset As System.Windows.Forms.Label
        Friend WithEvents lblServerOffset As System.Windows.Forms.Label
        Friend WithEvents chkEnableEveStatus As System.Windows.Forms.CheckBox
        Friend WithEvents gbPlugIns As System.Windows.Forms.GroupBox
        Friend WithEvents lblDetectedPlugIns As System.Windows.Forms.Label
        Friend WithEvents lvwPlugins As DevComponents.DotNetBar.Controls.ListViewEx
        Friend WithEvents colPlugInName As System.Windows.Forms.ColumnHeader
        Friend WithEvents colStatus As System.Windows.Forms.ColumnHeader
        Friend WithEvents lblPlugInInfo As System.Windows.Forms.Label
        Friend WithEvents gbTrainingQueue As System.Windows.Forms.GroupBox
        Friend WithEvents gbNotifications As System.Windows.Forms.GroupBox
        Friend WithEvents lblShutdownNotifyPeriod As System.Windows.Forms.Label
        Friend WithEvents chkShutdownNotify As System.Windows.Forms.CheckBox
        Friend WithEvents nudShutdownNotifyPeriod As System.Windows.Forms.NumericUpDown
        Friend WithEvents chkNotifyEmail As System.Windows.Forms.CheckBox
        Friend WithEvents chkNotifyDialog As System.Windows.Forms.CheckBox
        Friend WithEvents chkNotifyToolTip As System.Windows.Forms.CheckBox
        Friend WithEvents gbEmail As System.Windows.Forms.GroupBox
        Friend WithEvents lblEMailAddress As System.Windows.Forms.Label
        Friend WithEvents txtEmailAddress As System.Windows.Forms.TextBox
        Friend WithEvents txtSMTPServer As System.Windows.Forms.TextBox
        Friend WithEvents lblSMTPServer As System.Windows.Forms.Label
        Friend WithEvents lblEmailPassword As System.Windows.Forms.Label
        Friend WithEvents txtEmailPassword As System.Windows.Forms.TextBox
        Friend WithEvents txtEmailUsername As System.Windows.Forms.TextBox
        Friend WithEvents lblEmailUsername As System.Windows.Forms.Label
        Friend WithEvents chkSMTPAuthentication As System.Windows.Forms.CheckBox
        Friend WithEvents lblNotifyOffset As System.Windows.Forms.Label
        Friend WithEvents btnTestEmail As System.Windows.Forms.Button
        Friend WithEvents tvwSettings As System.Windows.Forms.TreeView
        Friend WithEvents gbColours As System.Windows.Forms.GroupBox
        Friend WithEvents cd1 As System.Windows.Forms.ColorDialog
        Friend WithEvents btnRefreshPlugins As System.Windows.Forms.Button
        Friend WithEvents chkMinimiseOnExit As System.Windows.Forms.CheckBox
        Friend WithEvents pbBothPreReqColour As System.Windows.Forms.PictureBox
        Friend WithEvents lblBothPreReqColour As System.Windows.Forms.Label
        Friend WithEvents pbHasPreReqColour As System.Windows.Forms.PictureBox
        Friend WithEvents pbIsPreReqColour As System.Windows.Forms.PictureBox
        Friend WithEvents lblHasPreReqColour As System.Windows.Forms.Label
        Friend WithEvents lblIsPreReqColour As System.Windows.Forms.Label
        Friend WithEvents lblSkillQueueColours As System.Windows.Forms.Label
        Friend WithEvents pbDowntimeClashColour As System.Windows.Forms.PictureBox
        Friend WithEvents lblDowntimeClashColour As System.Windows.Forms.Label
        Friend WithEvents pbReadySkillColour As System.Windows.Forms.PictureBox
        Friend WithEvents lblReadySkillColour As System.Windows.Forms.Label
        Friend WithEvents chkNotifySound As System.Windows.Forms.CheckBox
        Friend WithEvents lblSoundFile As System.Windows.Forms.Label
        Friend WithEvents btnSelectSoundFile As System.Windows.Forms.Button
        Friend WithEvents lblNotifyMe As System.Windows.Forms.Label
        Friend WithEvents btnSoundTest As System.Windows.Forms.Button
        Friend WithEvents chkNotifyEarly As System.Windows.Forms.CheckBox
        Friend WithEvents chkNotifyNow As System.Windows.Forms.CheckBox
        Friend WithEvents chkDeleteCompletedSkills As System.Windows.Forms.CheckBox
        Friend WithEvents pbPartiallyTrainedColour As System.Windows.Forms.PictureBox
        Friend WithEvents lblPartiallyTrainedColour As System.Windows.Forms.Label
        Friend WithEvents gbG15 As System.Windows.Forms.GroupBox
        Friend WithEvents chkActivateG15 As System.Windows.Forms.CheckBox
        Friend WithEvents nudCycleTime As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblCycleTime As System.Windows.Forms.Label
        Friend WithEvents chkCyclePilots As System.Windows.Forms.CheckBox
        Friend WithEvents gbLocation4 As System.Windows.Forms.GroupBox
        Friend WithEvents gbLocation3 As System.Windows.Forms.GroupBox
        Friend WithEvents gbLocation2 As System.Windows.Forms.GroupBox
        Friend WithEvents gbLocation1 As System.Windows.Forms.GroupBox
        Friend WithEvents chkLUA4 As System.Windows.Forms.CheckBox
        Friend WithEvents chkLUA3 As System.Windows.Forms.CheckBox
        Friend WithEvents chkLUA2 As System.Windows.Forms.CheckBox
        Friend WithEvents chkLUA1 As System.Windows.Forms.CheckBox
        Friend WithEvents lblCacheSize4 As System.Windows.Forms.Label
        Friend WithEvents lblCacheSize3 As System.Windows.Forms.Label
        Friend WithEvents lblCacheSize2 As System.Windows.Forms.Label
        Friend WithEvents lblCacheSize1 As System.Windows.Forms.Label
        Friend WithEvents btnTidyPlugins As System.Windows.Forms.Button
        Friend WithEvents ctxPrices As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents mnuPriceItemName As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuPriceAdd As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuPriceEdit As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuPriceDelete As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents gbPilotScreenColours As System.Windows.Forms.GroupBox
        Friend WithEvents btnResetPilotColours As System.Windows.Forms.Button
        Friend WithEvents pbPilotLevel5 As System.Windows.Forms.PictureBox
        Friend WithEvents lblLevel5Colour As System.Windows.Forms.Label
        Friend WithEvents pbPilotPartial As System.Windows.Forms.PictureBox
        Friend WithEvents lblPilotPartiallyTrainedColour As System.Windows.Forms.Label
        Friend WithEvents pbPilotCurrent As System.Windows.Forms.PictureBox
        Friend WithEvents lblPilotCurrentColour As System.Windows.Forms.Label
        Friend WithEvents pbPilotStandard As System.Windows.Forms.PictureBox
        Friend WithEvents lblPilotStandardColour As System.Windows.Forms.Label
        Friend WithEvents lblFriendlyName1 As System.Windows.Forms.Label
        Friend WithEvents txtFriendlyName1 As System.Windows.Forms.TextBox
        Friend WithEvents lblFriendlyName4 As System.Windows.Forms.Label
        Friend WithEvents txtFriendlyName4 As System.Windows.Forms.TextBox
        Friend WithEvents lblFriendlyName3 As System.Windows.Forms.Label
        Friend WithEvents txtFriendlyName3 As System.Windows.Forms.TextBox
        Friend WithEvents lblFriendlyName2 As System.Windows.Forms.Label
        Friend WithEvents txtFriendlyName2 As System.Windows.Forms.TextBox
        Friend WithEvents gbAPIServer As System.Windows.Forms.GroupBox
        Friend WithEvents txtAPIRSServer As System.Windows.Forms.TextBox
        Friend WithEvents lblAPIRSServer As System.Windows.Forms.Label
        Friend WithEvents txtCCPAPIServer As System.Windows.Forms.TextBox
        Friend WithEvents lblCCPAPIServer As System.Windows.Forms.Label
        Friend WithEvents chkAutoAPI As System.Windows.Forms.CheckBox
        Friend WithEvents chkUseCCPBackup As System.Windows.Forms.CheckBox
        Friend WithEvents chkUseAPIRSServer As System.Windows.Forms.CheckBox
        Friend WithEvents lblUpdateLocation As System.Windows.Forms.Label
        Friend WithEvents txtUpdateLocation As System.Windows.Forms.TextBox
        Friend WithEvents txtAPIFileExtension As System.Windows.Forms.TextBox
        Friend WithEvents lblAPIFileExtension As System.Windows.Forms.Label
        Friend WithEvents txtSMTPPort As System.Windows.Forms.TextBox
        Friend WithEvents lblSMTPPort As System.Windows.Forms.Label
        Friend WithEvents gbTaskbarIcon As System.Windows.Forms.GroupBox
        Friend WithEvents cboTaskbarIconMode As System.Windows.Forms.ComboBox
        Friend WithEvents lblTaskbarIconMode As System.Windows.Forms.Label
        Friend WithEvents chkErrorReporting As System.Windows.Forms.CheckBox
        Friend WithEvents txtErrorRepEmail As System.Windows.Forms.TextBox
        Friend WithEvents lblErrorRepEmail As System.Windows.Forms.Label
        Friend WithEvents txtErrorRepName As System.Windows.Forms.TextBox
        Friend WithEvents lblErrorRepName As System.Windows.Forms.Label
        Friend WithEvents pbPilotSkillHighlight As System.Windows.Forms.PictureBox
        Friend WithEvents lblPilotSkillHighlight As System.Windows.Forms.Label
        Friend WithEvents pbPilotSkillText As System.Windows.Forms.PictureBox
        Friend WithEvents lblPilotSkillText As System.Windows.Forms.Label
        Friend WithEvents pbPilotGroupText As System.Windows.Forms.PictureBox
        Friend WithEvents lblPilotGroupText As System.Windows.Forms.Label
        Friend WithEvents pbPilotGroupBG As System.Windows.Forms.PictureBox
        Friend WithEvents lblPilotGroupBG As System.Windows.Forms.Label
        Friend WithEvents lblMDITabPosition As System.Windows.Forms.Label
        Friend WithEvents cboMDITabPosition As System.Windows.Forms.ComboBox
        Friend WithEvents chkDisableAutoConnections As System.Windows.Forms.CheckBox
        Friend WithEvents chkDisableVisualStyles As System.Windows.Forms.CheckBox
        Friend WithEvents lblCSVSeparatorChar As System.Windows.Forms.Label
        Friend WithEvents txtCSVSeparator As System.Windows.Forms.TextBox
        Friend WithEvents gbDashboard As System.Windows.Forms.GroupBox
        Friend WithEvents dbDashboardConfig As System.Windows.Forms.GroupBox
        Friend WithEvents btnRemoveWidget As System.Windows.Forms.Button
        Friend WithEvents lvWidgets As DevComponents.DotNetBar.Controls.ListViewEx
        Friend WithEvents colWidgetType As System.Windows.Forms.ColumnHeader
        Friend WithEvents colWidgetInfo As System.Windows.Forms.ColumnHeader
        Friend WithEvents lblCurrentWidgets As System.Windows.Forms.Label
        Friend WithEvents lblWidgetTypes As System.Windows.Forms.Label
        Friend WithEvents cboWidgets As System.Windows.Forms.ComboBox
        Friend WithEvents btnAddWidget As System.Windows.Forms.Button
        Friend WithEvents cboTickerLocation As System.Windows.Forms.ComboBox
        Friend WithEvents lblTickerLocation As System.Windows.Forms.Label
        Friend WithEvents chkShowPriceTicker As System.Windows.Forms.CheckBox
        Friend WithEvents btnMoveDown As System.Windows.Forms.Button
        Friend WithEvents btnMoveUp As System.Windows.Forms.Button
        Friend WithEvents lvwColumns As DevComponents.DotNetBar.Controls.ListViewEx
        Friend WithEvents colQueueColumns As System.Windows.Forms.ColumnHeader
        Friend WithEvents lblSenderAddress As System.Windows.Forms.Label
        Friend WithEvents txtSenderAddress As System.Windows.Forms.TextBox
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents chkAutoMailAPI As System.Windows.Forms.CheckBox
        Friend WithEvents chkNotifyNotification As System.Windows.Forms.CheckBox
        Friend WithEvents chkNotifyEveMail As System.Windows.Forms.CheckBox
        Friend WithEvents btnCreateBlankPilot As System.Windows.Forms.Button
        Friend WithEvents chkUseSSL As System.Windows.Forms.CheckBox
        Friend WithEvents chkProxyUseBasic As System.Windows.Forms.CheckBox
        Friend WithEvents chkDisableTrainingBar As System.Windows.Forms.CheckBox
        Friend WithEvents chkEnableAutomaticSave As System.Windows.Forms.CheckBox
        Friend WithEvents nudAutomaticSaveTime As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblAutomaticSaveTime As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents chkIgnoreLastMessage As System.Windows.Forms.CheckBox
        Friend WithEvents btnCheckAPIKeys As System.Windows.Forms.Button
        Friend WithEvents chkStartWithPrimaryQueue As System.Windows.Forms.CheckBox
        Friend WithEvents nudAccountTimeLimit As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblAccountTimeLimit As System.Windows.Forms.Label
        Friend WithEvents chkNotifyAccountTime As System.Windows.Forms.CheckBox
        Friend WithEvents chkNotifyInsuffClone As System.Windows.Forms.CheckBox
        Friend WithEvents btnDisableAccount As System.Windows.Forms.Button
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents gbMarket As System.Windows.Forms.GroupBox
        Private WithEvents _systemList As System.Windows.Forms.ListBox
        Friend WithEvents _useSystemPrice As System.Windows.Forms.RadioButton
        Friend WithEvents _regionList As System.Windows.Forms.ListBox
        Friend WithEvents _useRegionData As System.Windows.Forms.RadioButton
        Friend WithEvents _usePercentile As System.Windows.Forms.RadioButton
        Friend WithEvents _useMedianPrice As System.Windows.Forms.RadioButton
        Friend WithEvents _useAveragePrice As System.Windows.Forms.RadioButton
        Friend WithEvents _useMaximumPrice As System.Windows.Forms.RadioButton
        Friend WithEvents _useMiniumPrice As System.Windows.Forms.RadioButton
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Private WithEvents _marketDataProvider As System.Windows.Forms.ComboBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents enableMarketDataUpload As System.Windows.Forms.CheckBox
        Friend WithEvents gbItemOverrides As System.Windows.Forms.GroupBox
        Friend WithEvents _itemOverridePercentPrice As System.Windows.Forms.RadioButton
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents _itemOverrideMedianPrice As System.Windows.Forms.RadioButton
        Friend WithEvents _itemOverrideMinPrice As System.Windows.Forms.RadioButton
        Friend WithEvents _itemOverrideAvgPrice As System.Windows.Forms.RadioButton
        Friend WithEvents _itemOverrideMaxPrice As System.Windows.Forms.RadioButton
        Friend WithEvents _itemOverrideBuyOrders As System.Windows.Forms.RadioButton
        Friend WithEvents _itemOverrideSellOrders As System.Windows.Forms.RadioButton
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents _itemOverrideAllOrders As System.Windows.Forms.RadioButton
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Private WithEvents _itemOverridesActiveGridNameColumn As DevComponents.AdvTree.ColumnHeader
        Private WithEvents _itemOverridesActiveGridItemIdColumn As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector2 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle2 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents _itemOverrideRemoveOverride As System.Windows.Forms.Button
        Friend WithEvents _itemOverrideAddOverride As System.Windows.Forms.Button
        Friend WithEvents _itemOverrideItemList As System.Windows.Forms.ComboBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents _defaultAll As System.Windows.Forms.RadioButton
        Friend WithEvents _defaultBuy As System.Windows.Forms.RadioButton
        Friend WithEvents _defaultSell As System.Windows.Forms.RadioButton
        Friend WithEvents chkViewSkillTraining As System.Windows.Forms.CheckBox
        Friend WithEvents chkViewMarketPrices As System.Windows.Forms.CheckBox
        Friend WithEvents chkViewDashboard As System.Windows.Forms.CheckBox
        Friend WithEvents chkViewRequisitions As System.Windows.Forms.CheckBox
        Friend WithEvents chkViewPilotSummary As System.Windows.Forms.CheckBox
        Friend WithEvents chkViewPilotInfo As System.Windows.Forms.CheckBox
        Friend WithEvents lblEveQueueDisplayLength As System.Windows.Forms.Label
        Friend WithEvents nudEveQueueDisplayLength As System.Windows.Forms.NumericUpDown
        Private WithEvents panelSettings As DevComponents.DotNetBar.PanelEx
        Private WithEvents gpNav As DevComponents.DotNetBar.Controls.GroupPanel
        Private WithEvents trackServerOffset As DevComponents.DotNetBar.Controls.Slider
        Private WithEvents sldNotifyOffset As DevComponents.DotNetBar.Controls.Slider
        Private WithEvents STT As DevComponents.DotNetBar.SuperTooltip
        Private WithEvents adtAccounts As DevComponents.AdvTree.AdvTree
        Private WithEvents colAccountName As DevComponents.AdvTree.ColumnHeader
        Private WithEvents colAccountVersion As DevComponents.AdvTree.ColumnHeader
        Private WithEvents colAccountUserID As DevComponents.AdvTree.ColumnHeader
        Private WithEvents colAccountAccessType As DevComponents.AdvTree.ColumnHeader
        Private WithEvents colAccountStatus As DevComponents.AdvTree.ColumnHeader
        Private WithEvents _itemOverridesActiveGrid As DevComponents.AdvTree.AdvTree
        Private WithEvents _itemOverridesActiveGridOrderTypeColumn As DevComponents.AdvTree.ColumnHeader
        Private WithEvents _itemOverridesActiveGridMetricColumn As DevComponents.AdvTree.ColumnHeader
    End Class
End NameSpace