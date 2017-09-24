Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class FrmPrismSettings
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
            Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Column Layout (Assets)")
            Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Corp Reps")
            Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Costs")
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrismSettings))
            Me.tvwSettings = New System.Windows.Forms.TreeView()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.btnClose = New DevComponents.DotNetBar.ButtonX()
            Me.pnlSettings = New DevComponents.DotNetBar.PanelEx()
            Me.gpGeneral = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.chkHideSaveJobDialog = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.chkHideAPIDialog = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.btnDeleteUndefinedJournals = New DevComponents.DotNetBar.ButtonX()
            Me.btnDeleteDuplicateTransactions = New DevComponents.DotNetBar.ButtonX()
            Me.btnDeleteDuplicateJournals = New DevComponents.DotNetBar.ButtonX()
            Me.lblDefaultBPCalcAssetOwner = New System.Windows.Forms.Label()
            Me.cboDefaultBPCalcAssetOwner = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblDefaultBPCalcManufacturer = New System.Windows.Forms.Label()
            Me.cboDefaultBPCalcManufacturer = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblDefaultBPCalcBPOwner = New System.Windows.Forms.Label()
            Me.cboDefaultBPCalcBPOwner = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblDefaultPrismCharacter = New System.Windows.Forms.Label()
            Me.cboDefaultPrismCharacter = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.gpCorpReps = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.btnNoRepContracts = New DevComponents.DotNetBar.ButtonX()
            Me.cboContractsRep = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblContractsRep = New System.Windows.Forms.Label()
            Me.btnNoRepAll = New DevComponents.DotNetBar.ButtonX()
            Me.btnNoRepJournal = New DevComponents.DotNetBar.ButtonX()
            Me.btnNoRepOrders = New DevComponents.DotNetBar.ButtonX()
            Me.btnNoRepTransactions = New DevComponents.DotNetBar.ButtonX()
            Me.btnNoRepCorpSheet = New DevComponents.DotNetBar.ButtonX()
            Me.btnNoRepBalances = New DevComponents.DotNetBar.ButtonX()
            Me.btnNoRepJobs = New DevComponents.DotNetBar.ButtonX()
            Me.btnNoRepAssets = New DevComponents.DotNetBar.ButtonX()
            Me.lblSelectedCorp = New System.Windows.Forms.Label()
            Me.chkUseSamePilot = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.cboCorpSheetRep = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblCorpSheetRep = New System.Windows.Forms.Label()
            Me.cboTransactionsRep = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblTransactionsRep = New System.Windows.Forms.Label()
            Me.cboOrdersRep = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblOrdersRep = New System.Windows.Forms.Label()
            Me.cboJournalRep = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblJournalRep = New System.Windows.Forms.Label()
            Me.cboJobsRep = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblJobsRep = New System.Windows.Forms.Label()
            Me.cboBalancesRep = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblBalancesRep = New System.Windows.Forms.Label()
            Me.cboAssetsRep = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblAssetsRep = New System.Windows.Forms.Label()
            Me.adtCorpReps = New DevComponents.AdvTree.AdvTree()
            Me.colCorpRepCorp = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me.gpAssetColumns = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.btnMoveDown = New System.Windows.Forms.Button()
            Me.lblSlotColumns = New System.Windows.Forms.Label()
            Me.btnMoveUp = New System.Windows.Forms.Button()
            Me.lvwColumns = New System.Windows.Forms.ListView()
            Me.colSlotColumns = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.gpCosts = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.lvwBPCCosts = New DevComponents.DotNetBar.Controls.ListViewEx()
            Me.colBPCName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colBPCMinRunPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colBPCMaxRunPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.lblFactoryRunningCost = New System.Windows.Forms.Label()
            Me.lblLabInstallCost = New System.Windows.Forms.Label()
            Me.lblLabRunningCost = New System.Windows.Forms.Label()
            Me.lblFactoryInstallCost = New System.Windows.Forms.Label()
            Me.nudFactoryRunningCost = New DevComponents.Editors.DoubleInput()
            Me.nudLabInstallCost = New DevComponents.Editors.DoubleInput()
            Me.nudLabRunningCost = New DevComponents.Editors.DoubleInput()
            Me.nudFactoryInstallCost = New DevComponents.Editors.DoubleInput()
            Me.pnlSettings.SuspendLayout()
            Me.gpGeneral.SuspendLayout()
            Me.gpCorpReps.SuspendLayout()
            CType(Me.adtCorpReps, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gpAssetColumns.SuspendLayout()
            Me.gpCosts.SuspendLayout()
            CType(Me.nudFactoryRunningCost, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudLabInstallCost, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudLabRunningCost, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudFactoryInstallCost, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'tvwSettings
            '
            Me.tvwSettings.Location = New System.Drawing.Point(12, 10)
            Me.tvwSettings.Name = "tvwSettings"
            TreeNode1.Name = "nodeGeneral"
            TreeNode1.Text = "General"
            TreeNode2.Name = "nodeAssetColumns"
            TreeNode2.Text = "Column Layout (Assets)"
            TreeNode3.Name = "nodeCorpReps"
            TreeNode3.Text = "Corp Reps"
            TreeNode4.Name = "nodeCosts"
            TreeNode4.Text = "Costs"
            Me.tvwSettings.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
            Me.tvwSettings.Size = New System.Drawing.Size(176, 473)
            Me.tvwSettings.TabIndex = 27
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
            Me.pnlSettings.Controls.Add(Me.gpGeneral)
            Me.pnlSettings.Controls.Add(Me.gpCorpReps)
            Me.pnlSettings.Controls.Add(Me.gpAssetColumns)
            Me.pnlSettings.Controls.Add(Me.gpCosts)
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
            'gpGeneral
            '
            Me.gpGeneral.CanvasColor = System.Drawing.SystemColors.Control
            Me.gpGeneral.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.gpGeneral.Controls.Add(Me.chkHideSaveJobDialog)
            Me.gpGeneral.Controls.Add(Me.chkHideAPIDialog)
            Me.gpGeneral.Controls.Add(Me.btnDeleteUndefinedJournals)
            Me.gpGeneral.Controls.Add(Me.btnDeleteDuplicateTransactions)
            Me.gpGeneral.Controls.Add(Me.btnDeleteDuplicateJournals)
            Me.gpGeneral.Controls.Add(Me.lblDefaultBPCalcAssetOwner)
            Me.gpGeneral.Controls.Add(Me.cboDefaultBPCalcAssetOwner)
            Me.gpGeneral.Controls.Add(Me.lblDefaultBPCalcManufacturer)
            Me.gpGeneral.Controls.Add(Me.cboDefaultBPCalcManufacturer)
            Me.gpGeneral.Controls.Add(Me.lblDefaultBPCalcBPOwner)
            Me.gpGeneral.Controls.Add(Me.cboDefaultBPCalcBPOwner)
            Me.gpGeneral.Controls.Add(Me.lblDefaultPrismCharacter)
            Me.gpGeneral.Controls.Add(Me.cboDefaultPrismCharacter)
            Me.gpGeneral.DisabledBackColor = System.Drawing.Color.Empty
            Me.gpGeneral.Location = New System.Drawing.Point(194, 12)
            Me.gpGeneral.Name = "gpGeneral"
            Me.gpGeneral.Size = New System.Drawing.Size(582, 497)
            '
            '
            '
            Me.gpGeneral.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.gpGeneral.Style.BackColorGradientAngle = 90
            Me.gpGeneral.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.gpGeneral.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpGeneral.Style.BorderBottomWidth = 1
            Me.gpGeneral.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.gpGeneral.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpGeneral.Style.BorderLeftWidth = 1
            Me.gpGeneral.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpGeneral.Style.BorderRightWidth = 1
            Me.gpGeneral.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpGeneral.Style.BorderTopWidth = 1
            Me.gpGeneral.Style.CornerDiameter = 4
            Me.gpGeneral.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.gpGeneral.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.gpGeneral.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.gpGeneral.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.gpGeneral.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.gpGeneral.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.gpGeneral.TabIndex = 32
            Me.gpGeneral.Text = "General Settings"
            '
            'chkHideSaveJobDialog
            '
            '
            '
            '
            Me.chkHideSaveJobDialog.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkHideSaveJobDialog.Location = New System.Drawing.Point(15, 173)
            Me.chkHideSaveJobDialog.Name = "chkHideSaveJobDialog"
            Me.chkHideSaveJobDialog.Size = New System.Drawing.Size(224, 23)
            Me.chkHideSaveJobDialog.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkHideSaveJobDialog.TabIndex = 10
            Me.chkHideSaveJobDialog.Text = "Hide Save Job Dialog"
            '
            'chkHideAPIDialog
            '
            '
            '
            '
            Me.chkHideAPIDialog.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkHideAPIDialog.Location = New System.Drawing.Point(15, 144)
            Me.chkHideAPIDialog.Name = "chkHideAPIDialog"
            Me.chkHideAPIDialog.Size = New System.Drawing.Size(224, 23)
            Me.chkHideAPIDialog.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkHideAPIDialog.TabIndex = 9
            Me.chkHideAPIDialog.Text = "Hide API Download Dialog"
            '
            'btnDeleteUndefinedJournals
            '
            Me.btnDeleteUndefinedJournals.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnDeleteUndefinedJournals.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnDeleteUndefinedJournals.Location = New System.Drawing.Point(262, 318)
            Me.btnDeleteUndefinedJournals.Name = "btnDeleteUndefinedJournals"
            Me.btnDeleteUndefinedJournals.Size = New System.Drawing.Size(200, 23)
            Me.btnDeleteUndefinedJournals.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnDeleteUndefinedJournals.TabIndex = 8
            Me.btnDeleteUndefinedJournals.Text = "Delete Undefined Journals"
            '
            'btnDeleteDuplicateTransactions
            '
            Me.btnDeleteDuplicateTransactions.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnDeleteDuplicateTransactions.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnDeleteDuplicateTransactions.Location = New System.Drawing.Point(39, 347)
            Me.btnDeleteDuplicateTransactions.Name = "btnDeleteDuplicateTransactions"
            Me.btnDeleteDuplicateTransactions.Size = New System.Drawing.Size(200, 23)
            Me.btnDeleteDuplicateTransactions.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnDeleteDuplicateTransactions.TabIndex = 7
            Me.btnDeleteDuplicateTransactions.Text = "Delete Duplicate Transactions"
            '
            'btnDeleteDuplicateJournals
            '
            Me.btnDeleteDuplicateJournals.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnDeleteDuplicateJournals.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnDeleteDuplicateJournals.Location = New System.Drawing.Point(39, 318)
            Me.btnDeleteDuplicateJournals.Name = "btnDeleteDuplicateJournals"
            Me.btnDeleteDuplicateJournals.Size = New System.Drawing.Size(200, 23)
            Me.btnDeleteDuplicateJournals.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnDeleteDuplicateJournals.TabIndex = 6
            Me.btnDeleteDuplicateJournals.Text = "Delete Duplicate Journals"
            '
            'lblDefaultBPCalcAssetOwner
            '
            Me.lblDefaultBPCalcAssetOwner.AutoSize = True
            Me.lblDefaultBPCalcAssetOwner.Location = New System.Drawing.Point(12, 73)
            Me.lblDefaultBPCalcAssetOwner.Name = "lblDefaultBPCalcAssetOwner"
            Me.lblDefaultBPCalcAssetOwner.Size = New System.Drawing.Size(146, 13)
            Me.lblDefaultBPCalcAssetOwner.TabIndex = 5
            Me.lblDefaultBPCalcAssetOwner.Text = "Default BPCalc Asset Owner:"
            '
            'cboDefaultBPCalcAssetOwner
            '
            Me.cboDefaultBPCalcAssetOwner.DisplayMember = "Text"
            Me.cboDefaultBPCalcAssetOwner.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboDefaultBPCalcAssetOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboDefaultBPCalcAssetOwner.FormattingEnabled = True
            Me.cboDefaultBPCalcAssetOwner.ItemHeight = 15
            Me.cboDefaultBPCalcAssetOwner.Location = New System.Drawing.Point(244, 69)
            Me.cboDefaultBPCalcAssetOwner.Name = "cboDefaultBPCalcAssetOwner"
            Me.cboDefaultBPCalcAssetOwner.Size = New System.Drawing.Size(170, 21)
            Me.cboDefaultBPCalcAssetOwner.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboDefaultBPCalcAssetOwner.TabIndex = 4
            '
            'lblDefaultBPCalcManufacturer
            '
            Me.lblDefaultBPCalcManufacturer.AutoSize = True
            Me.lblDefaultBPCalcManufacturer.Location = New System.Drawing.Point(12, 46)
            Me.lblDefaultBPCalcManufacturer.Name = "lblDefaultBPCalcManufacturer"
            Me.lblDefaultBPCalcManufacturer.Size = New System.Drawing.Size(149, 13)
            Me.lblDefaultBPCalcManufacturer.TabIndex = 3
            Me.lblDefaultBPCalcManufacturer.Text = "Default BPCalc Manufacturer:"
            '
            'cboDefaultBPCalcManufacturer
            '
            Me.cboDefaultBPCalcManufacturer.DisplayMember = "Text"
            Me.cboDefaultBPCalcManufacturer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboDefaultBPCalcManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboDefaultBPCalcManufacturer.FormattingEnabled = True
            Me.cboDefaultBPCalcManufacturer.ItemHeight = 15
            Me.cboDefaultBPCalcManufacturer.Location = New System.Drawing.Point(244, 42)
            Me.cboDefaultBPCalcManufacturer.Name = "cboDefaultBPCalcManufacturer"
            Me.cboDefaultBPCalcManufacturer.Size = New System.Drawing.Size(170, 21)
            Me.cboDefaultBPCalcManufacturer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboDefaultBPCalcManufacturer.TabIndex = 2
            '
            'lblDefaultBPCalcBPOwner
            '
            Me.lblDefaultBPCalcBPOwner.AutoSize = True
            Me.lblDefaultBPCalcBPOwner.Location = New System.Drawing.Point(12, 19)
            Me.lblDefaultBPCalcBPOwner.Name = "lblDefaultBPCalcBPOwner"
            Me.lblDefaultBPCalcBPOwner.Size = New System.Drawing.Size(161, 13)
            Me.lblDefaultBPCalcBPOwner.TabIndex = 1
            Me.lblDefaultBPCalcBPOwner.Text = "Default BPCalc Blueprint Owner:"
            '
            'cboDefaultBPCalcBPOwner
            '
            Me.cboDefaultBPCalcBPOwner.DisplayMember = "Text"
            Me.cboDefaultBPCalcBPOwner.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboDefaultBPCalcBPOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboDefaultBPCalcBPOwner.FormattingEnabled = True
            Me.cboDefaultBPCalcBPOwner.ItemHeight = 15
            Me.cboDefaultBPCalcBPOwner.Location = New System.Drawing.Point(244, 15)
            Me.cboDefaultBPCalcBPOwner.Name = "cboDefaultBPCalcBPOwner"
            Me.cboDefaultBPCalcBPOwner.Size = New System.Drawing.Size(170, 21)
            Me.cboDefaultBPCalcBPOwner.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboDefaultBPCalcBPOwner.TabIndex = 0
            '
            'lblDefaultPrismCharacter
            '
            Me.lblDefaultPrismCharacter.AutoSize = True
            Me.lblDefaultPrismCharacter.Location = New System.Drawing.Point(12, 100)
            Me.lblDefaultPrismCharacter.Name = "lblDefaultPrismCharacter"
            Me.lblDefaultPrismCharacter.Size = New System.Drawing.Size(125, 13)
            Me.lblDefaultPrismCharacter.TabIndex = 1
            Me.lblDefaultPrismCharacter.Text = "Default Prism Character:"
            '
            'cboDefaultPrismCharacter
            '
            Me.cboDefaultPrismCharacter.DisplayMember = "Text"
            Me.cboDefaultPrismCharacter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboDefaultPrismCharacter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboDefaultPrismCharacter.FormattingEnabled = True
            Me.cboDefaultPrismCharacter.ItemHeight = 15
            Me.cboDefaultPrismCharacter.Location = New System.Drawing.Point(244, 96)
            Me.cboDefaultPrismCharacter.Name = "cboDefaultPrismCharacter"
            Me.cboDefaultPrismCharacter.Size = New System.Drawing.Size(170, 21)
            Me.cboDefaultPrismCharacter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboDefaultPrismCharacter.TabIndex = 0
            '
            'gpCorpReps
            '
            Me.gpCorpReps.CanvasColor = System.Drawing.SystemColors.Control
            Me.gpCorpReps.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.gpCorpReps.Controls.Add(Me.btnNoRepContracts)
            Me.gpCorpReps.Controls.Add(Me.cboContractsRep)
            Me.gpCorpReps.Controls.Add(Me.lblContractsRep)
            Me.gpCorpReps.Controls.Add(Me.btnNoRepAll)
            Me.gpCorpReps.Controls.Add(Me.btnNoRepJournal)
            Me.gpCorpReps.Controls.Add(Me.btnNoRepOrders)
            Me.gpCorpReps.Controls.Add(Me.btnNoRepTransactions)
            Me.gpCorpReps.Controls.Add(Me.btnNoRepCorpSheet)
            Me.gpCorpReps.Controls.Add(Me.btnNoRepBalances)
            Me.gpCorpReps.Controls.Add(Me.btnNoRepJobs)
            Me.gpCorpReps.Controls.Add(Me.btnNoRepAssets)
            Me.gpCorpReps.Controls.Add(Me.lblSelectedCorp)
            Me.gpCorpReps.Controls.Add(Me.chkUseSamePilot)
            Me.gpCorpReps.Controls.Add(Me.cboCorpSheetRep)
            Me.gpCorpReps.Controls.Add(Me.lblCorpSheetRep)
            Me.gpCorpReps.Controls.Add(Me.cboTransactionsRep)
            Me.gpCorpReps.Controls.Add(Me.lblTransactionsRep)
            Me.gpCorpReps.Controls.Add(Me.cboOrdersRep)
            Me.gpCorpReps.Controls.Add(Me.lblOrdersRep)
            Me.gpCorpReps.Controls.Add(Me.cboJournalRep)
            Me.gpCorpReps.Controls.Add(Me.lblJournalRep)
            Me.gpCorpReps.Controls.Add(Me.cboJobsRep)
            Me.gpCorpReps.Controls.Add(Me.lblJobsRep)
            Me.gpCorpReps.Controls.Add(Me.cboBalancesRep)
            Me.gpCorpReps.Controls.Add(Me.lblBalancesRep)
            Me.gpCorpReps.Controls.Add(Me.cboAssetsRep)
            Me.gpCorpReps.Controls.Add(Me.lblAssetsRep)
            Me.gpCorpReps.Controls.Add(Me.adtCorpReps)
            Me.gpCorpReps.DisabledBackColor = System.Drawing.Color.Empty
            Me.gpCorpReps.Location = New System.Drawing.Point(477, 330)
            Me.gpCorpReps.Name = "gpCorpReps"
            Me.gpCorpReps.Size = New System.Drawing.Size(258, 65)
            '
            '
            '
            Me.gpCorpReps.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.gpCorpReps.Style.BackColorGradientAngle = 90
            Me.gpCorpReps.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.gpCorpReps.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpCorpReps.Style.BorderBottomWidth = 1
            Me.gpCorpReps.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.gpCorpReps.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpCorpReps.Style.BorderLeftWidth = 1
            Me.gpCorpReps.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpCorpReps.Style.BorderRightWidth = 1
            Me.gpCorpReps.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpCorpReps.Style.BorderTopWidth = 1
            Me.gpCorpReps.Style.CornerDiameter = 4
            Me.gpCorpReps.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.gpCorpReps.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.gpCorpReps.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.gpCorpReps.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.gpCorpReps.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.gpCorpReps.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.gpCorpReps.TabIndex = 36
            Me.gpCorpReps.Text = "Corporate Representatives"
            '
            'btnNoRepContracts
            '
            Me.btnNoRepContracts.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnNoRepContracts.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnNoRepContracts.FocusCuesEnabled = False
            Me.btnNoRepContracts.Image = Global.EveHQ.Prism.My.Resources.Resources.icon38_111
            Me.btnNoRepContracts.Location = New System.Drawing.Point(550, 270)
            Me.btnNoRepContracts.Name = "btnNoRepContracts"
            Me.btnNoRepContracts.Size = New System.Drawing.Size(21, 21)
            Me.btnNoRepContracts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnNoRepContracts.TabIndex = 29
            '
            'cboContractsRep
            '
            Me.cboContractsRep.DisplayMember = "Text"
            Me.cboContractsRep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboContractsRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboContractsRep.FormattingEnabled = True
            Me.cboContractsRep.ItemHeight = 15
            Me.cboContractsRep.Location = New System.Drawing.Point(370, 270)
            Me.cboContractsRep.Name = "cboContractsRep"
            Me.cboContractsRep.Size = New System.Drawing.Size(177, 21)
            Me.cboContractsRep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboContractsRep.TabIndex = 28
            '
            'lblContractsRep
            '
            Me.lblContractsRep.AutoSize = True
            Me.lblContractsRep.Location = New System.Drawing.Point(292, 270)
            Me.lblContractsRep.Name = "lblContractsRep"
            Me.lblContractsRep.Size = New System.Drawing.Size(58, 13)
            Me.lblContractsRep.TabIndex = 27
            Me.lblContractsRep.Text = "Contracts:"
            '
            'btnNoRepAll
            '
            Me.btnNoRepAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnNoRepAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnNoRepAll.FocusCuesEnabled = False
            Me.btnNoRepAll.Image = Global.EveHQ.Prism.My.Resources.Resources.icon38_111
            Me.btnNoRepAll.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
            Me.btnNoRepAll.Location = New System.Drawing.Point(481, 69)
            Me.btnNoRepAll.Name = "btnNoRepAll"
            Me.btnNoRepAll.Size = New System.Drawing.Size(90, 23)
            Me.btnNoRepAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnNoRepAll.TabIndex = 26
            Me.btnNoRepAll.Text = "Remove All"
            '
            'btnNoRepJournal
            '
            Me.btnNoRepJournal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnNoRepJournal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnNoRepJournal.FocusCuesEnabled = False
            Me.btnNoRepJournal.Image = Global.EveHQ.Prism.My.Resources.Resources.icon38_111
            Me.btnNoRepJournal.Location = New System.Drawing.Point(550, 189)
            Me.btnNoRepJournal.Name = "btnNoRepJournal"
            Me.btnNoRepJournal.Size = New System.Drawing.Size(21, 21)
            Me.btnNoRepJournal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnNoRepJournal.TabIndex = 25
            '
            'btnNoRepOrders
            '
            Me.btnNoRepOrders.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnNoRepOrders.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnNoRepOrders.FocusCuesEnabled = False
            Me.btnNoRepOrders.Image = Global.EveHQ.Prism.My.Resources.Resources.icon38_111
            Me.btnNoRepOrders.Location = New System.Drawing.Point(550, 216)
            Me.btnNoRepOrders.Name = "btnNoRepOrders"
            Me.btnNoRepOrders.Size = New System.Drawing.Size(21, 21)
            Me.btnNoRepOrders.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnNoRepOrders.TabIndex = 24
            '
            'btnNoRepTransactions
            '
            Me.btnNoRepTransactions.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnNoRepTransactions.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnNoRepTransactions.FocusCuesEnabled = False
            Me.btnNoRepTransactions.Image = Global.EveHQ.Prism.My.Resources.Resources.icon38_111
            Me.btnNoRepTransactions.Location = New System.Drawing.Point(550, 243)
            Me.btnNoRepTransactions.Name = "btnNoRepTransactions"
            Me.btnNoRepTransactions.Size = New System.Drawing.Size(21, 21)
            Me.btnNoRepTransactions.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnNoRepTransactions.TabIndex = 23
            '
            'btnNoRepCorpSheet
            '
            Me.btnNoRepCorpSheet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnNoRepCorpSheet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnNoRepCorpSheet.FocusCuesEnabled = False
            Me.btnNoRepCorpSheet.Image = Global.EveHQ.Prism.My.Resources.Resources.icon38_111
            Me.btnNoRepCorpSheet.Location = New System.Drawing.Point(550, 297)
            Me.btnNoRepCorpSheet.Name = "btnNoRepCorpSheet"
            Me.btnNoRepCorpSheet.Size = New System.Drawing.Size(21, 21)
            Me.btnNoRepCorpSheet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnNoRepCorpSheet.TabIndex = 22
            '
            'btnNoRepBalances
            '
            Me.btnNoRepBalances.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnNoRepBalances.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnNoRepBalances.FocusCuesEnabled = False
            Me.btnNoRepBalances.Image = Global.EveHQ.Prism.My.Resources.Resources.icon38_111
            Me.btnNoRepBalances.Location = New System.Drawing.Point(550, 135)
            Me.btnNoRepBalances.Name = "btnNoRepBalances"
            Me.btnNoRepBalances.Size = New System.Drawing.Size(21, 21)
            Me.btnNoRepBalances.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnNoRepBalances.TabIndex = 21
            '
            'btnNoRepJobs
            '
            Me.btnNoRepJobs.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnNoRepJobs.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnNoRepJobs.FocusCuesEnabled = False
            Me.btnNoRepJobs.Image = Global.EveHQ.Prism.My.Resources.Resources.icon38_111
            Me.btnNoRepJobs.Location = New System.Drawing.Point(550, 162)
            Me.btnNoRepJobs.Name = "btnNoRepJobs"
            Me.btnNoRepJobs.Size = New System.Drawing.Size(21, 21)
            Me.btnNoRepJobs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnNoRepJobs.TabIndex = 20
            '
            'btnNoRepAssets
            '
            Me.btnNoRepAssets.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnNoRepAssets.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnNoRepAssets.FocusCuesEnabled = False
            Me.btnNoRepAssets.Image = Global.EveHQ.Prism.My.Resources.Resources.icon38_111
            Me.btnNoRepAssets.Location = New System.Drawing.Point(550, 108)
            Me.btnNoRepAssets.Name = "btnNoRepAssets"
            Me.btnNoRepAssets.Size = New System.Drawing.Size(21, 21)
            Me.btnNoRepAssets.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnNoRepAssets.TabIndex = 19
            '
            'lblSelectedCorp
            '
            Me.lblSelectedCorp.AutoSize = True
            Me.lblSelectedCorp.Location = New System.Drawing.Point(295, 32)
            Me.lblSelectedCorp.Name = "lblSelectedCorp"
            Me.lblSelectedCorp.Size = New System.Drawing.Size(122, 13)
            Me.lblSelectedCorp.TabIndex = 18
            Me.lblSelectedCorp.Text = "Selected Corp: <None>"
            '
            'chkUseSamePilot
            '
            '
            '
            '
            Me.chkUseSamePilot.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkUseSamePilot.Location = New System.Drawing.Point(295, 69)
            Me.chkUseSamePilot.Name = "chkUseSamePilot"
            Me.chkUseSamePilot.Size = New System.Drawing.Size(173, 23)
            Me.chkUseSamePilot.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkUseSamePilot.TabIndex = 17
            Me.chkUseSamePilot.Text = "Use Same Pilot for all"
            '
            'cboCorpSheetRep
            '
            Me.cboCorpSheetRep.DisplayMember = "Text"
            Me.cboCorpSheetRep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboCorpSheetRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboCorpSheetRep.FormattingEnabled = True
            Me.cboCorpSheetRep.ItemHeight = 15
            Me.cboCorpSheetRep.Location = New System.Drawing.Point(370, 297)
            Me.cboCorpSheetRep.Name = "cboCorpSheetRep"
            Me.cboCorpSheetRep.Size = New System.Drawing.Size(177, 21)
            Me.cboCorpSheetRep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboCorpSheetRep.TabIndex = 14
            '
            'lblCorpSheetRep
            '
            Me.lblCorpSheetRep.AutoSize = True
            Me.lblCorpSheetRep.Location = New System.Drawing.Point(292, 297)
            Me.lblCorpSheetRep.Name = "lblCorpSheetRep"
            Me.lblCorpSheetRep.Size = New System.Drawing.Size(65, 13)
            Me.lblCorpSheetRep.TabIndex = 13
            Me.lblCorpSheetRep.Text = "Corp Sheet:"
            '
            'cboTransactionsRep
            '
            Me.cboTransactionsRep.DisplayMember = "Text"
            Me.cboTransactionsRep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboTransactionsRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboTransactionsRep.FormattingEnabled = True
            Me.cboTransactionsRep.ItemHeight = 15
            Me.cboTransactionsRep.Location = New System.Drawing.Point(370, 243)
            Me.cboTransactionsRep.Name = "cboTransactionsRep"
            Me.cboTransactionsRep.Size = New System.Drawing.Size(177, 21)
            Me.cboTransactionsRep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboTransactionsRep.TabIndex = 12
            '
            'lblTransactionsRep
            '
            Me.lblTransactionsRep.AutoSize = True
            Me.lblTransactionsRep.Location = New System.Drawing.Point(292, 243)
            Me.lblTransactionsRep.Name = "lblTransactionsRep"
            Me.lblTransactionsRep.Size = New System.Drawing.Size(72, 13)
            Me.lblTransactionsRep.TabIndex = 11
            Me.lblTransactionsRep.Text = "Transactions:"
            '
            'cboOrdersRep
            '
            Me.cboOrdersRep.DisplayMember = "Text"
            Me.cboOrdersRep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboOrdersRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboOrdersRep.FormattingEnabled = True
            Me.cboOrdersRep.ItemHeight = 15
            Me.cboOrdersRep.Location = New System.Drawing.Point(370, 216)
            Me.cboOrdersRep.Name = "cboOrdersRep"
            Me.cboOrdersRep.Size = New System.Drawing.Size(177, 21)
            Me.cboOrdersRep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboOrdersRep.TabIndex = 10
            '
            'lblOrdersRep
            '
            Me.lblOrdersRep.AutoSize = True
            Me.lblOrdersRep.Location = New System.Drawing.Point(292, 216)
            Me.lblOrdersRep.Name = "lblOrdersRep"
            Me.lblOrdersRep.Size = New System.Drawing.Size(44, 13)
            Me.lblOrdersRep.TabIndex = 9
            Me.lblOrdersRep.Text = "Orders:"
            '
            'cboJournalRep
            '
            Me.cboJournalRep.DisplayMember = "Text"
            Me.cboJournalRep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboJournalRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboJournalRep.FormattingEnabled = True
            Me.cboJournalRep.ItemHeight = 15
            Me.cboJournalRep.Location = New System.Drawing.Point(370, 189)
            Me.cboJournalRep.Name = "cboJournalRep"
            Me.cboJournalRep.Size = New System.Drawing.Size(177, 21)
            Me.cboJournalRep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboJournalRep.TabIndex = 8
            '
            'lblJournalRep
            '
            Me.lblJournalRep.AutoSize = True
            Me.lblJournalRep.Location = New System.Drawing.Point(292, 189)
            Me.lblJournalRep.Name = "lblJournalRep"
            Me.lblJournalRep.Size = New System.Drawing.Size(46, 13)
            Me.lblJournalRep.TabIndex = 7
            Me.lblJournalRep.Text = "Journal:"
            '
            'cboJobsRep
            '
            Me.cboJobsRep.DisplayMember = "Text"
            Me.cboJobsRep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboJobsRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboJobsRep.FormattingEnabled = True
            Me.cboJobsRep.ItemHeight = 15
            Me.cboJobsRep.Location = New System.Drawing.Point(370, 162)
            Me.cboJobsRep.Name = "cboJobsRep"
            Me.cboJobsRep.Size = New System.Drawing.Size(177, 21)
            Me.cboJobsRep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboJobsRep.TabIndex = 6
            '
            'lblJobsRep
            '
            Me.lblJobsRep.AutoSize = True
            Me.lblJobsRep.Location = New System.Drawing.Point(292, 162)
            Me.lblJobsRep.Name = "lblJobsRep"
            Me.lblJobsRep.Size = New System.Drawing.Size(33, 13)
            Me.lblJobsRep.TabIndex = 5
            Me.lblJobsRep.Text = "Jobs:"
            '
            'cboBalancesRep
            '
            Me.cboBalancesRep.DisplayMember = "Text"
            Me.cboBalancesRep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboBalancesRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboBalancesRep.FormattingEnabled = True
            Me.cboBalancesRep.ItemHeight = 15
            Me.cboBalancesRep.Location = New System.Drawing.Point(370, 135)
            Me.cboBalancesRep.Name = "cboBalancesRep"
            Me.cboBalancesRep.Size = New System.Drawing.Size(177, 21)
            Me.cboBalancesRep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboBalancesRep.TabIndex = 4
            '
            'lblBalancesRep
            '
            Me.lblBalancesRep.AutoSize = True
            Me.lblBalancesRep.Location = New System.Drawing.Point(292, 135)
            Me.lblBalancesRep.Name = "lblBalancesRep"
            Me.lblBalancesRep.Size = New System.Drawing.Size(53, 13)
            Me.lblBalancesRep.TabIndex = 3
            Me.lblBalancesRep.Text = "Balances:"
            '
            'cboAssetsRep
            '
            Me.cboAssetsRep.DisplayMember = "Text"
            Me.cboAssetsRep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboAssetsRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboAssetsRep.FormattingEnabled = True
            Me.cboAssetsRep.ItemHeight = 15
            Me.cboAssetsRep.Location = New System.Drawing.Point(370, 108)
            Me.cboAssetsRep.Name = "cboAssetsRep"
            Me.cboAssetsRep.Size = New System.Drawing.Size(177, 21)
            Me.cboAssetsRep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboAssetsRep.TabIndex = 2
            '
            'lblAssetsRep
            '
            Me.lblAssetsRep.AutoSize = True
            Me.lblAssetsRep.Location = New System.Drawing.Point(292, 108)
            Me.lblAssetsRep.Name = "lblAssetsRep"
            Me.lblAssetsRep.Size = New System.Drawing.Size(43, 13)
            Me.lblAssetsRep.TabIndex = 1
            Me.lblAssetsRep.Text = "Assets:"
            '
            'adtCorpReps
            '
            Me.adtCorpReps.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtCorpReps.AllowDrop = True
            Me.adtCorpReps.AllowUserToResizeColumns = False
            Me.adtCorpReps.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.adtCorpReps.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtCorpReps.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtCorpReps.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtCorpReps.Columns.Add(Me.colCorpRepCorp)
            Me.adtCorpReps.DragDropEnabled = False
            Me.adtCorpReps.DragDropNodeCopyEnabled = False
            Me.adtCorpReps.ExpandWidth = 0
            
            Me.adtCorpReps.Location = New System.Drawing.Point(3, 3)
            Me.adtCorpReps.Name = "adtCorpReps"
            Me.adtCorpReps.NodesConnector = Me.NodeConnector1
            Me.adtCorpReps.NodeStyle = Me.ElementStyle1
            Me.adtCorpReps.PathSeparator = ";"
            Me.adtCorpReps.Size = New System.Drawing.Size(281, 37)
            Me.adtCorpReps.Styles.Add(Me.ElementStyle1)
            Me.adtCorpReps.TabIndex = 0
            Me.adtCorpReps.Text = "AdvTree1"
            '
            'colCorpRepCorp
            '
            Me.colCorpRepCorp.Name = "colCorpRepCorp"
            Me.colCorpRepCorp.SortingEnabled = False
            Me.colCorpRepCorp.Text = "Corporation Name"
            Me.colCorpRepCorp.Width.Absolute = 250
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
            'gpAssetColumns
            '
            Me.gpAssetColumns.CanvasColor = System.Drawing.SystemColors.Control
            Me.gpAssetColumns.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.gpAssetColumns.Controls.Add(Me.btnMoveDown)
            Me.gpAssetColumns.Controls.Add(Me.lblSlotColumns)
            Me.gpAssetColumns.Controls.Add(Me.btnMoveUp)
            Me.gpAssetColumns.Controls.Add(Me.lvwColumns)
            Me.gpAssetColumns.DisabledBackColor = System.Drawing.Color.Empty
            Me.gpAssetColumns.Location = New System.Drawing.Point(218, 386)
            Me.gpAssetColumns.Name = "gpAssetColumns"
            Me.gpAssetColumns.Size = New System.Drawing.Size(143, 39)
            '
            '
            '
            Me.gpAssetColumns.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.gpAssetColumns.Style.BackColorGradientAngle = 90
            Me.gpAssetColumns.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.gpAssetColumns.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpAssetColumns.Style.BorderBottomWidth = 1
            Me.gpAssetColumns.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.gpAssetColumns.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpAssetColumns.Style.BorderLeftWidth = 1
            Me.gpAssetColumns.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpAssetColumns.Style.BorderRightWidth = 1
            Me.gpAssetColumns.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpAssetColumns.Style.BorderTopWidth = 1
            Me.gpAssetColumns.Style.CornerDiameter = 4
            Me.gpAssetColumns.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.gpAssetColumns.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.gpAssetColumns.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.gpAssetColumns.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.gpAssetColumns.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.gpAssetColumns.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.gpAssetColumns.TabIndex = 35
            Me.gpAssetColumns.Text = "Asset Column Layout"
            '
            'btnMoveDown
            '
            Me.btnMoveDown.Location = New System.Drawing.Point(95, 418)
            Me.btnMoveDown.Name = "btnMoveDown"
            Me.btnMoveDown.Size = New System.Drawing.Size(80, 23)
            Me.btnMoveDown.TabIndex = 31
            Me.btnMoveDown.Text = "Move Down"
            Me.btnMoveDown.UseVisualStyleBackColor = True
            '
            'lblSlotColumns
            '
            Me.lblSlotColumns.AutoSize = True
            Me.lblSlotColumns.Location = New System.Drawing.Point(6, 20)
            Me.lblSlotColumns.Name = "lblSlotColumns"
            Me.lblSlotColumns.Size = New System.Drawing.Size(113, 13)
            Me.lblSlotColumns.TabIndex = 28
            Me.lblSlotColumns.Text = "Slot Column Selection:"
            '
            'btnMoveUp
            '
            Me.btnMoveUp.Location = New System.Drawing.Point(9, 418)
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
            Me.lvwColumns.Location = New System.Drawing.Point(9, 36)
            Me.lvwColumns.Name = "lvwColumns"
            Me.lvwColumns.Size = New System.Drawing.Size(222, 376)
            Me.lvwColumns.TabIndex = 29
            Me.lvwColumns.UseCompatibleStateImageBehavior = False
            Me.lvwColumns.View = System.Windows.Forms.View.Details
            '
            'colSlotColumns
            '
            Me.colSlotColumns.Text = "Slot Columns"
            Me.colSlotColumns.Width = 200
            '
            'gpCosts
            '
            Me.gpCosts.CanvasColor = System.Drawing.SystemColors.Control
            Me.gpCosts.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.gpCosts.Controls.Add(Me.lvwBPCCosts)
            Me.gpCosts.Controls.Add(Me.lblFactoryRunningCost)
            Me.gpCosts.Controls.Add(Me.lblLabInstallCost)
            Me.gpCosts.Controls.Add(Me.lblLabRunningCost)
            Me.gpCosts.Controls.Add(Me.lblFactoryInstallCost)
            Me.gpCosts.Controls.Add(Me.nudFactoryRunningCost)
            Me.gpCosts.Controls.Add(Me.nudLabInstallCost)
            Me.gpCosts.Controls.Add(Me.nudLabRunningCost)
            Me.gpCosts.Controls.Add(Me.nudFactoryInstallCost)
            Me.gpCosts.DisabledBackColor = System.Drawing.Color.Empty
            Me.gpCosts.Location = New System.Drawing.Point(218, 311)
            Me.gpCosts.Name = "gpCosts"
            Me.gpCosts.Size = New System.Drawing.Size(143, 30)
            '
            '
            '
            Me.gpCosts.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.gpCosts.Style.BackColorGradientAngle = 90
            Me.gpCosts.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.gpCosts.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpCosts.Style.BorderBottomWidth = 1
            Me.gpCosts.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.gpCosts.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpCosts.Style.BorderLeftWidth = 1
            Me.gpCosts.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpCosts.Style.BorderRightWidth = 1
            Me.gpCosts.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpCosts.Style.BorderTopWidth = 1
            Me.gpCosts.Style.CornerDiameter = 4
            Me.gpCosts.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.gpCosts.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.gpCosts.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.gpCosts.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.gpCosts.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.gpCosts.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.gpCosts.TabIndex = 33
            Me.gpCosts.Text = "Costs"
            '
            'lvwBPCCosts
            '
            '
            '
            '
            Me.lvwBPCCosts.Border.Class = "ListViewBorder"
            Me.lvwBPCCosts.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lvwBPCCosts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colBPCName, Me.colBPCMinRunPrice, Me.colBPCMaxRunPrice})
            Me.lvwBPCCosts.DisabledBackColor = System.Drawing.Color.Empty
            Me.lvwBPCCosts.FullRowSelect = True
            Me.lvwBPCCosts.GridLines = True
            Me.lvwBPCCosts.Location = New System.Drawing.Point(3, 120)
            Me.lvwBPCCosts.Name = "lvwBPCCosts"
            Me.lvwBPCCosts.Size = New System.Drawing.Size(570, 355)
            Me.lvwBPCCosts.TabIndex = 8
            Me.lvwBPCCosts.UseCompatibleStateImageBehavior = False
            Me.lvwBPCCosts.View = System.Windows.Forms.View.Details
            '
            'colBPCName
            '
            Me.colBPCName.Text = "BPC Name"
            Me.colBPCName.Width = 300
            '
            'colBPCMinRunPrice
            '
            Me.colBPCMinRunPrice.Text = "1-run BPC Price"
            Me.colBPCMinRunPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.colBPCMinRunPrice.Width = 120
            '
            'colBPCMaxRunPrice
            '
            Me.colBPCMaxRunPrice.Text = "Max-run BPC Price"
            Me.colBPCMaxRunPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.colBPCMaxRunPrice.Width = 120
            '
            'lblFactoryRunningCost
            '
            Me.lblFactoryRunningCost.AutoSize = True
            Me.lblFactoryRunningCost.Location = New System.Drawing.Point(10, 68)
            Me.lblFactoryRunningCost.Name = "lblFactoryRunningCost"
            Me.lblFactoryRunningCost.Size = New System.Drawing.Size(115, 13)
            Me.lblFactoryRunningCost.TabIndex = 7
            Me.lblFactoryRunningCost.Text = "Factory Running Cost:"
            '
            'lblLabInstallCost
            '
            Me.lblLabInstallCost.AutoSize = True
            Me.lblLabInstallCost.Location = New System.Drawing.Point(282, 41)
            Me.lblLabInstallCost.Name = "lblLabInstallCost"
            Me.lblLabInstallCost.Size = New System.Drawing.Size(85, 13)
            Me.lblLabInstallCost.TabIndex = 6
            Me.lblLabInstallCost.Text = "Lab Install Cost:"
            '
            'lblLabRunningCost
            '
            Me.lblLabRunningCost.AutoSize = True
            Me.lblLabRunningCost.Location = New System.Drawing.Point(282, 68)
            Me.lblLabRunningCost.Name = "lblLabRunningCost"
            Me.lblLabRunningCost.Size = New System.Drawing.Size(95, 13)
            Me.lblLabRunningCost.TabIndex = 5
            Me.lblLabRunningCost.Text = "Lab Running Cost:"
            '
            'lblFactoryInstallCost
            '
            Me.lblFactoryInstallCost.AutoSize = True
            Me.lblFactoryInstallCost.Location = New System.Drawing.Point(10, 41)
            Me.lblFactoryInstallCost.Name = "lblFactoryInstallCost"
            Me.lblFactoryInstallCost.Size = New System.Drawing.Size(105, 13)
            Me.lblFactoryInstallCost.TabIndex = 4
            Me.lblFactoryInstallCost.Text = "Factory Install Cost:"
            '
            'nudFactoryRunningCost
            '
            '
            '
            '
            Me.nudFactoryRunningCost.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.nudFactoryRunningCost.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.nudFactoryRunningCost.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.nudFactoryRunningCost.Increment = 1.0R
            Me.nudFactoryRunningCost.Location = New System.Drawing.Point(131, 60)
            Me.nudFactoryRunningCost.MaxValue = 1000000000.0R
            Me.nudFactoryRunningCost.MinValue = 0.0R
            Me.nudFactoryRunningCost.Name = "nudFactoryRunningCost"
            Me.nudFactoryRunningCost.ShowUpDown = True
            Me.nudFactoryRunningCost.Size = New System.Drawing.Size(119, 21)
            Me.nudFactoryRunningCost.TabIndex = 3
            Me.nudFactoryRunningCost.Value = 333.0R
            '
            'nudLabInstallCost
            '
            '
            '
            '
            Me.nudLabInstallCost.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.nudLabInstallCost.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.nudLabInstallCost.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.nudLabInstallCost.Increment = 1.0R
            Me.nudLabInstallCost.Location = New System.Drawing.Point(383, 33)
            Me.nudLabInstallCost.MaxValue = 1000000000.0R
            Me.nudLabInstallCost.MinValue = 0.0R
            Me.nudLabInstallCost.Name = "nudLabInstallCost"
            Me.nudLabInstallCost.ShowUpDown = True
            Me.nudLabInstallCost.Size = New System.Drawing.Size(119, 21)
            Me.nudLabInstallCost.TabIndex = 2
            Me.nudLabInstallCost.Value = 1000.0R
            '
            'nudLabRunningCost
            '
            '
            '
            '
            Me.nudLabRunningCost.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.nudLabRunningCost.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.nudLabRunningCost.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.nudLabRunningCost.Increment = 1.0R
            Me.nudLabRunningCost.Location = New System.Drawing.Point(383, 60)
            Me.nudLabRunningCost.MaxValue = 1000000000.0R
            Me.nudLabRunningCost.MinValue = 0.0R
            Me.nudLabRunningCost.Name = "nudLabRunningCost"
            Me.nudLabRunningCost.ShowUpDown = True
            Me.nudLabRunningCost.Size = New System.Drawing.Size(119, 21)
            Me.nudLabRunningCost.TabIndex = 1
            Me.nudLabRunningCost.Value = 333.0R
            '
            'nudFactoryInstallCost
            '
            '
            '
            '
            Me.nudFactoryInstallCost.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.nudFactoryInstallCost.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.nudFactoryInstallCost.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.nudFactoryInstallCost.Increment = 1.0R
            Me.nudFactoryInstallCost.Location = New System.Drawing.Point(131, 33)
            Me.nudFactoryInstallCost.MaxValue = 1000000000.0R
            Me.nudFactoryInstallCost.MinValue = 0.0R
            Me.nudFactoryInstallCost.Name = "nudFactoryInstallCost"
            Me.nudFactoryInstallCost.ShowUpDown = True
            Me.nudFactoryInstallCost.Size = New System.Drawing.Size(119, 21)
            Me.nudFactoryInstallCost.TabIndex = 0
            Me.nudFactoryInstallCost.Value = 1000.0R
            '
            'FrmPrismSettings
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
            Me.Name = "FrmPrismSettings"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Prism Settings"
            Me.pnlSettings.ResumeLayout(False)
            Me.gpGeneral.ResumeLayout(False)
            Me.gpGeneral.PerformLayout()
            Me.gpCorpReps.ResumeLayout(False)
            Me.gpCorpReps.PerformLayout()
            CType(Me.adtCorpReps, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gpAssetColumns.ResumeLayout(False)
            Me.gpAssetColumns.PerformLayout()
            Me.gpCosts.ResumeLayout(False)
            Me.gpCosts.PerformLayout()
            CType(Me.nudFactoryRunningCost, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudLabInstallCost, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudLabRunningCost, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudFactoryInstallCost, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents tvwSettings As System.Windows.Forms.TreeView
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
        Friend WithEvents pnlSettings As DevComponents.DotNetBar.PanelEx
        Friend WithEvents gpGeneral As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents gpCosts As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents lblFactoryInstallCost As System.Windows.Forms.Label
        Friend WithEvents nudFactoryRunningCost As DevComponents.Editors.DoubleInput
        Friend WithEvents nudLabInstallCost As DevComponents.Editors.DoubleInput
        Friend WithEvents nudLabRunningCost As DevComponents.Editors.DoubleInput
        Friend WithEvents nudFactoryInstallCost As DevComponents.Editors.DoubleInput
        Friend WithEvents lblFactoryRunningCost As System.Windows.Forms.Label
        Friend WithEvents lblLabInstallCost As System.Windows.Forms.Label
        Friend WithEvents lblLabRunningCost As System.Windows.Forms.Label
        Friend WithEvents lvwBPCCosts As DevComponents.DotNetBar.Controls.ListViewEx
        Friend WithEvents colBPCName As System.Windows.Forms.ColumnHeader
        Friend WithEvents colBPCMinRunPrice As System.Windows.Forms.ColumnHeader
        Friend WithEvents colBPCMaxRunPrice As System.Windows.Forms.ColumnHeader
        Friend WithEvents lblDefaultPrismCharacter As System.Windows.Forms.Label
        Friend WithEvents cboDefaultPrismCharacter As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblDefaultBPCalcBPOwner As System.Windows.Forms.Label
        Friend WithEvents cboDefaultBPCalcBPOwner As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblDefaultBPCalcAssetOwner As System.Windows.Forms.Label
        Friend WithEvents cboDefaultBPCalcAssetOwner As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblDefaultBPCalcManufacturer As System.Windows.Forms.Label
        Friend WithEvents cboDefaultBPCalcManufacturer As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents btnDeleteDuplicateJournals As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnDeleteDuplicateTransactions As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnMoveDown As System.Windows.Forms.Button
        Friend WithEvents btnMoveUp As System.Windows.Forms.Button
        Friend WithEvents lvwColumns As System.Windows.Forms.ListView
        Friend WithEvents colSlotColumns As System.Windows.Forms.ColumnHeader
        Friend WithEvents lblSlotColumns As System.Windows.Forms.Label
        Friend WithEvents gpCorpReps As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents gpAssetColumns As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents cboCorpSheetRep As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblCorpSheetRep As System.Windows.Forms.Label
        Friend WithEvents cboTransactionsRep As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblTransactionsRep As System.Windows.Forms.Label
        Friend WithEvents cboOrdersRep As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblOrdersRep As System.Windows.Forms.Label
        Friend WithEvents cboJournalRep As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblJournalRep As System.Windows.Forms.Label
        Friend WithEvents cboJobsRep As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblJobsRep As System.Windows.Forms.Label
        Friend WithEvents cboBalancesRep As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblBalancesRep As System.Windows.Forms.Label
        Friend WithEvents cboAssetsRep As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblAssetsRep As System.Windows.Forms.Label
        Friend WithEvents adtCorpReps As DevComponents.AdvTree.AdvTree
        Friend WithEvents colCorpRepCorp As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents lblSelectedCorp As System.Windows.Forms.Label
        Friend WithEvents chkUseSamePilot As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents btnNoRepAssets As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnNoRepAll As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnNoRepJournal As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnNoRepOrders As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnNoRepTransactions As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnNoRepCorpSheet As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnNoRepBalances As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnNoRepJobs As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnNoRepContracts As DevComponents.DotNetBar.ButtonX
        Friend WithEvents cboContractsRep As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblContractsRep As System.Windows.Forms.Label
        Friend WithEvents btnDeleteUndefinedJournals As DevComponents.DotNetBar.ButtonX
        Friend WithEvents chkHideAPIDialog As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents chkHideSaveJobDialog As DevComponents.DotNetBar.Controls.CheckBoxX
    End Class
End NameSpace