Imports EveHQ.Prism.Controls

Namespace Forms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmBPCalculator
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBPCalculator))
            Me.lblBPRuns = New System.Windows.Forms.Label()
            Me.lblBPRunsLbl = New System.Windows.Forms.Label()
            Me.lblBPME = New System.Windows.Forms.Label()
            Me.lblBPTE = New System.Windows.Forms.Label()
            Me.lblBPWF = New System.Windows.Forms.Label()
            Me.lblBPOMarketValue = New System.Windows.Forms.Label()
            Me.lblBPOMarketValueLbl = New System.Windows.Forms.Label()
            Me.lblBPMELbl = New System.Windows.Forms.Label()
            Me.lblBPWFLbl = New System.Windows.Forms.Label()
            Me.lblBPTELbl = New System.Windows.Forms.Label()
            Me.lblRuns = New System.Windows.Forms.Label()
            Me.lblProdQuantityLbl = New System.Windows.Forms.Label()
            Me.lblBatchSizeLbl = New System.Windows.Forms.Label()
            Me.lblRunsPerCopy = New System.Windows.Forms.Label()
            Me.lblCopyTime = New System.Windows.Forms.Label()
            Me.lblBPCopyTimeLbl = New System.Windows.Forms.Label()
            Me.lblTETime = New System.Windows.Forms.Label()
            Me.lblMETime = New System.Windows.Forms.Label()
            Me.lblTETimeLbl = New System.Windows.Forms.Label()
            Me.lblMETimeLbl = New System.Windows.Forms.Label()
            Me.lblNewMELbl = New System.Windows.Forms.Label()
            Me.LblNewWFLbl = New System.Windows.Forms.Label()
            Me.lblNewTELbl = New System.Windows.Forms.Label()
            Me.txtNewWasteFactor = New System.Windows.Forms.TextBox()
            Me.lblProfitRate = New System.Windows.Forms.Label()
            Me.lblProfitRateLbl = New System.Windows.Forms.Label()
            Me.lblUnitProfit = New System.Windows.Forms.Label()
            Me.lblUnitProfitlbl = New System.Windows.Forms.Label()
            Me.lblUnitValue = New System.Windows.Forms.Label()
            Me.lblUnitValuelbl = New System.Windows.Forms.Label()
            Me.lblUnitCost = New System.Windows.Forms.Label()
            Me.lblUnitCostLbl = New System.Windows.Forms.Label()
            Me.lblTotalCosts = New System.Windows.Forms.Label()
            Me.lblTotalCostsLbl = New System.Windows.Forms.Label()
            Me.lblFactoryCosts = New System.Windows.Forms.Label()
            Me.lblTotalBuildCost = New System.Windows.Forms.Label()
            Me.lblUnitBuildCost = New System.Windows.Forms.Label()
            Me.lblTotalBuildCostsLbl = New System.Windows.Forms.Label()
            Me.lblUnitBuildCostsLbl = New System.Windows.Forms.Label()
            Me.lblTotalBuildTime = New System.Windows.Forms.Label()
            Me.lblUnitBuildTime = New System.Windows.Forms.Label()
            Me.lblTotalBuildTimeLbl = New System.Windows.Forms.Label()
            Me.lblUnitBuildTimeLbl = New System.Windows.Forms.Label()
            Me.lblPESkill = New System.Windows.Forms.Label()
            Me.lblIndustrySkill = New System.Windows.Forms.Label()
            Me.lblScienceSkill = New System.Windows.Forms.Label()
            Me.lblMetallurgySkill = New System.Windows.Forms.Label()
            Me.lblResearchSkill = New System.Windows.Forms.Label()
            Me.lblPilot = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.cboIndustryImplant = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.ComboItem1 = New DevComponents.Editors.ComboItem()
            Me.ComboItem2 = New DevComponents.Editors.ComboItem()
            Me.ComboItem3 = New DevComponents.Editors.ComboItem()
            Me.ComboItem4 = New DevComponents.Editors.ComboItem()
            Me.cboResearchImplant = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.ComboItem5 = New DevComponents.Editors.ComboItem()
            Me.ComboItem6 = New DevComponents.Editors.ComboItem()
            Me.ComboItem7 = New DevComponents.Editors.ComboItem()
            Me.ComboItem8 = New DevComponents.Editors.ComboItem()
            Me.cboMetallurgyImplant = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.ComboItem9 = New DevComponents.Editors.ComboItem()
            Me.ComboItem10 = New DevComponents.Editors.ComboItem()
            Me.ComboItem11 = New DevComponents.Editors.ComboItem()
            Me.ComboItem12 = New DevComponents.Editors.ComboItem()
            Me.cboScienceImplant = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.ComboItem13 = New DevComponents.Editors.ComboItem()
            Me.ComboItem14 = New DevComponents.Editors.ComboItem()
            Me.ComboItem15 = New DevComponents.Editors.ComboItem()
            Me.ComboItem16 = New DevComponents.Editors.ComboItem()
            Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
            Me.gpPilotSkills = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.gpProductionSkills = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.cboIndustrySkill = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.cboAdvInvSkill = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.gpResearchSkills = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.cboScienceSkill = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.cboResearchSkill = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.cboMetallurgySkill = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.chkOverrideSkills = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.cboPilot = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.gpBPSelection = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.lblToggleInvention = New DevComponents.DotNetBar.LabelX()
            Me.btnToggleInvention = New DevComponents.DotNetBar.Controls.SwitchButton()
            Me.cboOwner = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblBPMaxRuns = New System.Windows.Forms.Label()
            Me.lblBPMaxRunsLbl = New System.Windows.Forms.Label()
            Me.cboBPs = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.chkOwnedBPOs = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.chkInventBPOs = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.pbBP = New System.Windows.Forms.PictureBox()
            Me.nudCopyRuns = New DevComponents.Editors.IntegerInput()
            Me.tabBPCalcFunctions = New DevComponents.DotNetBar.TabControl()
            Me.tcpInvention = New DevComponents.DotNetBar.TabControlPanel()
            Me.chkInventionFlag = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.lblBatchTotalCost = New System.Windows.Forms.Label()
            Me.lblBatchTotalCostLbl = New System.Windows.Forms.Label()
            Me.adtInventionProfits = New DevComponents.AdvTree.AdvTree()
            Me.colIPDecryptor = New DevComponents.AdvTree.ColumnHeader()
            Me.colIPProfit = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector2 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle2 = New DevComponents.DotNetBar.ElementStyle()
            Me.lblTotalInventionProfit = New System.Windows.Forms.Label()
            Me.lblTotalInventionProfitLbl = New System.Windows.Forms.Label()
            Me.lblUnitInventionProfit = New System.Windows.Forms.Label()
            Me.lblUnitInventionProfitLbl = New System.Windows.Forms.Label()
            Me.lblInventionSalesPrice = New System.Windows.Forms.Label()
            Me.lblInventionSalesPriceLbl = New System.Windows.Forms.Label()
            Me.lblAvgInventionCost = New System.Windows.Forms.Label()
            Me.lblAvgInventionCostLbl = New System.Windows.Forms.Label()
            Me.lblBatchProductionCost = New System.Windows.Forms.Label()
            Me.lblBatchProductionCostLbl = New System.Windows.Forms.Label()
            Me.nudInventionSkill2 = New DevComponents.Editors.IntegerInput()
            Me.nudInventionSkill3 = New DevComponents.Editors.IntegerInput()
            Me.nudInventionSkill1 = New DevComponents.Editors.IntegerInput()
            Me.lblSuccessCost = New System.Windows.Forms.Label()
            Me.lblSuccessCostLbl = New System.Windows.Forms.Label()
            Me.lblAvgAttempts = New System.Windows.Forms.Label()
            Me.lblInventionBPCCost = New System.Windows.Forms.LinkLabel()
            Me.lblInventionBPCCostLbl = New System.Windows.Forms.LinkLabel()
            Me.lblInventedBP = New System.Windows.Forms.Label()
            Me.lblInventionDecryptorCost = New System.Windows.Forms.Label()
            Me.lblInventionLabCosts = New System.Windows.Forms.Label()
            Me.lblInventionCost = New System.Windows.Forms.Label()
            Me.lblInventionBaseCost = New System.Windows.Forms.Label()
            Me.lblInventionLabCostsLbl = New System.Windows.Forms.LinkLabel()
            Me.lblOverrideBPCRuns = New System.Windows.Forms.Label()
            Me.lblBlueprintInventions = New System.Windows.Forms.Label()
            Me.lblDecryptor = New System.Windows.Forms.Label()
            Me.lblBaseChance = New System.Windows.Forms.Label()
            Me.lblInvSkill2 = New System.Windows.Forms.Label()
            Me.lblInvSkill3 = New System.Windows.Forms.Label()
            Me.lblInvSkill1 = New System.Windows.Forms.Label()
            Me.lblInventionCostLbl = New System.Windows.Forms.Label()
            Me.lblInventionDecryptorCostLbl = New System.Windows.Forms.Label()
            Me.lblInventionBaseCostLbl = New System.Windows.Forms.Label()
            Me.lblInventedBPLbl = New System.Windows.Forms.Label()
            Me.lblInventionChance = New System.Windows.Forms.Label()
            Me.lblInventionTime = New System.Windows.Forms.Label()
            Me.lblInventionTimeLbl = New System.Windows.Forms.Label()
            Me.nudInventionBPCRuns = New DevComponents.Editors.IntegerInput()
            Me.cboDecryptor = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.cboInventions = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.PPRInvention = New EveHQ.Prism.Controls.PrismResources()
            Me.PACDecryptor = New EveHQ.Prism.Controls.PriceAdjustmentControl()
            Me.PACSalesPrice = New EveHQ.Prism.Controls.PriceAdjustmentControl()
            Me.tiInvention = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.tcpResearch = New DevComponents.DotNetBar.TabControlPanel()
            Me.chkAdvancedLab = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.chkResearchAtPOS = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.tiResearch = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.tcpProduction = New DevComponents.DotNetBar.TabControlPanel()
            Me.lblProfitMarkup = New System.Windows.Forms.Label()
            Me.lblProfitMargin = New System.Windows.Forms.Label()
            Me.lblProfitMarkupLbl = New System.Windows.Forms.Label()
            Me.lblProfitMarginLbl = New System.Windows.Forms.Label()
            Me.lblProdQuantity = New System.Windows.Forms.Label()
            Me.lblBatchSize = New System.Windows.Forms.Label()
            Me.lblFactoryCostsLbl = New System.Windows.Forms.Label()
            Me.nudRuns = New DevComponents.Editors.IntegerInput()
            Me.chkPOSProduction = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.cboPOSArrays = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.cboFactoryLocation = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.PACUnitValue = New EveHQ.Prism.Controls.PriceAdjustmentControl()
            Me.PPRProduction = New EveHQ.Prism.Controls.PrismResources()
            Me.tiProduction = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.nudTELevel = New DevComponents.Editors.IntegerInput()
            Me.btnSaveProductionJobAs = New DevComponents.DotNetBar.ButtonX()
            Me.nudMELevel = New DevComponents.Editors.IntegerInput()
            Me.btnSaveProductionJob = New DevComponents.DotNetBar.ButtonX()
            Me.btnExportToCSV = New DevComponents.DotNetBar.ButtonItem()
            Me.btnExportToTSV = New DevComponents.DotNetBar.ButtonItem()
            Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
            Me.SaveJobDialogCheckBox = New DevComponents.DotNetBar.Command(Me.components)
            Me.stnMeBonus = New DevComponents.Editors.IntegerInput()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.PACUnitValue = New EveHQ.Prism.Controls.PriceAdjustmentControl()
            Me.PPRProduction = New EveHQ.Prism.Controls.PrismResources()
            Me.PPRInvention = New EveHQ.Prism.Controls.PrismResources()
            Me.PACDecryptor = New EveHQ.Prism.Controls.PriceAdjustmentControl()
            Me.PACSalesPrice = New EveHQ.Prism.Controls.PriceAdjustmentControl()
            Me.PanelEx1.SuspendLayout()
            Me.gpPilotSkills.SuspendLayout()
            Me.gpProductionSkills.SuspendLayout()
            Me.gpResearchSkills.SuspendLayout()
            Me.gpBPSelection.SuspendLayout()
            CType(Me.pbBP, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCopyRuns, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabBPCalcFunctions, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabBPCalcFunctions.SuspendLayout()
            Me.tcpInvention.SuspendLayout()
            CType(Me.adtInventionProfits, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudInventionSkill2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudInventionSkill3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudInventionSkill1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudInventionBPCRuns, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tcpResearch.SuspendLayout()
            Me.tcpProduction.SuspendLayout()
            CType(Me.nudRuns, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudTELevel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudMELevel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.stnMeBonus, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblBPRuns
            '
            Me.lblBPRuns.AutoSize = True
            Me.lblBPRuns.Location = New System.Drawing.Point(257, 83)
            Me.lblBPRuns.Name = "lblBPRuns"
            Me.lblBPRuns.Size = New System.Drawing.Size(13, 13)
            Me.lblBPRuns.TabIndex = 19
            Me.lblBPRuns.Text = "0"
            '
            'lblBPRunsLbl
            '
            Me.lblBPRunsLbl.AutoSize = True
            Me.lblBPRunsLbl.Location = New System.Drawing.Point(194, 83)
            Me.lblBPRunsLbl.Name = "lblBPRunsLbl"
            Me.lblBPRunsLbl.Size = New System.Drawing.Size(35, 13)
            Me.lblBPRunsLbl.TabIndex = 18
            Me.lblBPRunsLbl.Text = "Runs:"
            '
            'lblBPME
            '
            Me.lblBPME.AutoSize = True
            Me.lblBPME.Location = New System.Drawing.Point(143, 83)
            Me.lblBPME.Name = "lblBPME"
            Me.lblBPME.Size = New System.Drawing.Size(13, 13)
            Me.lblBPME.TabIndex = 17
            Me.lblBPME.Text = "0"
            '
            'lblBPTE
            '
            Me.lblBPTE.AutoSize = True
            Me.lblBPTE.Location = New System.Drawing.Point(143, 98)
            Me.lblBPTE.Name = "lblBPTE"
            Me.lblBPTE.Size = New System.Drawing.Size(13, 13)
            Me.lblBPTE.TabIndex = 16
            Me.lblBPTE.Text = "0"
            '
            'lblBPWF
            '
            Me.lblBPWF.AutoSize = True
            Me.lblBPWF.Location = New System.Drawing.Point(143, 113)
            Me.lblBPWF.Name = "lblBPWF"
            Me.lblBPWF.Size = New System.Drawing.Size(13, 13)
            Me.lblBPWF.TabIndex = 15
            Me.lblBPWF.Text = "0"
            '
            'lblBPOMarketValue
            '
            Me.lblBPOMarketValue.AutoSize = True
            Me.lblBPOMarketValue.Location = New System.Drawing.Point(257, 113)
            Me.lblBPOMarketValue.Name = "lblBPOMarketValue"
            Me.lblBPOMarketValue.Size = New System.Drawing.Size(28, 13)
            Me.lblBPOMarketValue.TabIndex = 12
            Me.lblBPOMarketValue.Text = "0 isk"
            '
            'lblBPOMarketValueLbl
            '
            Me.lblBPOMarketValueLbl.AutoSize = True
            Me.lblBPOMarketValueLbl.Location = New System.Drawing.Point(194, 113)
            Me.lblBPOMarketValueLbl.Name = "lblBPOMarketValueLbl"
            Me.lblBPOMarketValueLbl.Size = New System.Drawing.Size(57, 13)
            Me.lblBPOMarketValueLbl.TabIndex = 11
            Me.lblBPOMarketValueLbl.Text = "BPO Price:"
            '
            'lblBPMELbl
            '
            Me.lblBPMELbl.AutoSize = True
            Me.lblBPMELbl.Location = New System.Drawing.Point(63, 83)
            Me.lblBPMELbl.Name = "lblBPMELbl"
            Me.lblBPMELbl.Size = New System.Drawing.Size(53, 13)
            Me.lblBPMELbl.TabIndex = 4
            Me.lblBPMELbl.Text = "ME level :"
            '
            'lblBPWFLbl
            '
            Me.lblBPWFLbl.AutoSize = True
            Me.lblBPWFLbl.Location = New System.Drawing.Point(63, 113)
            Me.lblBPWFLbl.Name = "lblBPWFLbl"
            Me.lblBPWFLbl.Size = New System.Drawing.Size(76, 13)
            Me.lblBPWFLbl.TabIndex = 8
            Me.lblBPWFLbl.Text = "Waste Factor:"
            '
            'lblBPTELbl
            '
            Me.lblBPTELbl.AutoSize = True
            Me.lblBPTELbl.Location = New System.Drawing.Point(63, 98)
            Me.lblBPTELbl.Name = "lblBPTELbl"
            Me.lblBPTELbl.Size = New System.Drawing.Size(51, 13)
            Me.lblBPTELbl.TabIndex = 6
            Me.lblBPTELbl.Text = "TE Level:"
            '
            'lblRuns
            '
            Me.lblRuns.AutoSize = True
            Me.lblRuns.BackColor = System.Drawing.Color.Transparent
            Me.lblRuns.Location = New System.Drawing.Point(10, 92)
            Me.lblRuns.Name = "lblRuns"
            Me.lblRuns.Size = New System.Drawing.Size(89, 13)
            Me.lblRuns.TabIndex = 16
            Me.lblRuns.Text = "Production Runs:"
            '
            'lblProdQuantityLbl
            '
            Me.lblProdQuantityLbl.AutoSize = True
            Me.lblProdQuantityLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblProdQuantityLbl.Location = New System.Drawing.Point(10, 138)
            Me.lblProdQuantityLbl.Name = "lblProdQuantityLbl"
            Me.lblProdQuantityLbl.Size = New System.Drawing.Size(107, 13)
            Me.lblProdQuantityLbl.TabIndex = 20
            Me.lblProdQuantityLbl.Text = "Production Quantity:"
            '
            'lblBatchSizeLbl
            '
            Me.lblBatchSizeLbl.AutoSize = True
            Me.lblBatchSizeLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblBatchSizeLbl.Location = New System.Drawing.Point(10, 115)
            Me.lblBatchSizeLbl.Name = "lblBatchSizeLbl"
            Me.lblBatchSizeLbl.Size = New System.Drawing.Size(60, 13)
            Me.lblBatchSizeLbl.TabIndex = 18
            Me.lblBatchSizeLbl.Text = "Batch Size:"
            '
            'lblRunsPerCopy
            '
            Me.lblRunsPerCopy.AutoSize = True
            Me.lblRunsPerCopy.BackColor = System.Drawing.Color.Transparent
            Me.lblRunsPerCopy.Location = New System.Drawing.Point(368, 164)
            Me.lblRunsPerCopy.Name = "lblRunsPerCopy"
            Me.lblRunsPerCopy.Size = New System.Drawing.Size(82, 13)
            Me.lblRunsPerCopy.TabIndex = 29
            Me.lblRunsPerCopy.Text = "Runs Per Copy:"
            '
            'lblCopyTime
            '
            Me.lblCopyTime.AutoSize = True
            Me.lblCopyTime.BackColor = System.Drawing.Color.Transparent
            Me.lblCopyTime.Location = New System.Drawing.Point(141, 100)
            Me.lblCopyTime.Name = "lblCopyTime"
            Me.lblCopyTime.Size = New System.Drawing.Size(18, 13)
            Me.lblCopyTime.TabIndex = 28
            Me.lblCopyTime.Text = "0s"
            '
            'lblBPCopyTimeLbl
            '
            Me.lblBPCopyTimeLbl.AutoSize = True
            Me.lblBPCopyTimeLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblBPCopyTimeLbl.Location = New System.Drawing.Point(20, 100)
            Me.lblBPCopyTimeLbl.Name = "lblBPCopyTimeLbl"
            Me.lblBPCopyTimeLbl.Size = New System.Drawing.Size(106, 13)
            Me.lblBPCopyTimeLbl.TabIndex = 27
            Me.lblBPCopyTimeLbl.Text = "Blueprint Copy Time:"
            '
            'lblTETime
            '
            Me.lblTETime.AutoSize = True
            Me.lblTETime.BackColor = System.Drawing.Color.Transparent
            Me.lblTETime.Location = New System.Drawing.Point(141, 80)
            Me.lblTETime.Name = "lblTETime"
            Me.lblTETime.Size = New System.Drawing.Size(18, 13)
            Me.lblTETime.TabIndex = 26
            Me.lblTETime.Text = "0s"
            '
            'lblMETime
            '
            Me.lblMETime.AutoSize = True
            Me.lblMETime.BackColor = System.Drawing.Color.Transparent
            Me.lblMETime.Location = New System.Drawing.Point(141, 60)
            Me.lblMETime.Name = "lblMETime"
            Me.lblMETime.Size = New System.Drawing.Size(18, 13)
            Me.lblMETime.TabIndex = 25
            Me.lblMETime.Text = "0s"
            '
            'lblTETimeLbl
            '
            Me.lblTETimeLbl.AutoSize = True
            Me.lblTETimeLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblTETimeLbl.Location = New System.Drawing.Point(20, 80)
            Me.lblTETimeLbl.Name = "lblTETimeLbl"
            Me.lblTETimeLbl.Size = New System.Drawing.Size(96, 13)
            Me.lblTETimeLbl.TabIndex = 13
            Me.lblTETimeLbl.Text = "TE Research Time:"
            '
            'lblMETimeLbl
            '
            Me.lblMETimeLbl.AutoSize = True
            Me.lblMETimeLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblMETimeLbl.Location = New System.Drawing.Point(20, 60)
            Me.lblMETimeLbl.Name = "lblMETimeLbl"
            Me.lblMETimeLbl.Size = New System.Drawing.Size(98, 13)
            Me.lblMETimeLbl.TabIndex = 12
            Me.lblMETimeLbl.Text = "ME Research Time:"
            '
            'lblNewMELbl
            '
            Me.lblNewMELbl.AutoSize = True
            Me.lblNewMELbl.BackColor = System.Drawing.Color.Transparent
            Me.lblNewMELbl.Location = New System.Drawing.Point(4, 164)
            Me.lblNewMELbl.Name = "lblNewMELbl"
            Me.lblNewMELbl.Size = New System.Drawing.Size(80, 13)
            Me.lblNewMELbl.TabIndex = 4
            Me.lblNewMELbl.Text = "New ME Level :"
            '
            'LblNewWFLbl
            '
            Me.LblNewWFLbl.AutoSize = True
            Me.LblNewWFLbl.BackColor = System.Drawing.Color.Transparent
            Me.LblNewWFLbl.Location = New System.Drawing.Point(557, 164)
            Me.LblNewWFLbl.Name = "LblNewWFLbl"
            Me.LblNewWFLbl.Size = New System.Drawing.Size(103, 13)
            Me.LblNewWFLbl.TabIndex = 8
            Me.LblNewWFLbl.Text = "New Waste Factor :"
            '
            'lblNewTELbl
            '
            Me.lblNewTELbl.AutoSize = True
            Me.lblNewTELbl.BackColor = System.Drawing.Color.Transparent
            Me.lblNewTELbl.Location = New System.Drawing.Point(191, 163)
            Me.lblNewTELbl.Name = "lblNewTELbl"
            Me.lblNewTELbl.Size = New System.Drawing.Size(78, 13)
            Me.lblNewTELbl.TabIndex = 6
            Me.lblNewTELbl.Text = "New TE Level :"
            '
            'txtNewWasteFactor
            '
            Me.txtNewWasteFactor.BackColor = System.Drawing.Color.LightGray
            Me.txtNewWasteFactor.Location = New System.Drawing.Point(666, 160)
            Me.txtNewWasteFactor.Name = "txtNewWasteFactor"
            Me.txtNewWasteFactor.ReadOnly = True
            Me.txtNewWasteFactor.Size = New System.Drawing.Size(81, 21)
            Me.txtNewWasteFactor.TabIndex = 9
            Me.txtNewWasteFactor.TabStop = False
            Me.txtNewWasteFactor.Text = "0"
            Me.txtNewWasteFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblProfitRate
            '
            Me.lblProfitRate.AutoSize = True
            Me.lblProfitRate.BackColor = System.Drawing.Color.Transparent
            Me.lblProfitRate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProfitRate.Location = New System.Drawing.Point(407, 138)
            Me.lblProfitRate.Name = "lblProfitRate"
            Me.lblProfitRate.Size = New System.Drawing.Size(28, 13)
            Me.lblProfitRate.TabIndex = 175
            Me.lblProfitRate.Text = "0 isk"
            '
            'lblProfitRateLbl
            '
            Me.lblProfitRateLbl.AutoSize = True
            Me.lblProfitRateLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblProfitRateLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProfitRateLbl.Location = New System.Drawing.Point(272, 138)
            Me.lblProfitRateLbl.Name = "lblProfitRateLbl"
            Me.lblProfitRateLbl.Size = New System.Drawing.Size(93, 13)
            Me.lblProfitRateLbl.TabIndex = 174
            Me.lblProfitRateLbl.Text = "Profit/(Loss) p/hr:"
            '
            'lblUnitProfit
            '
            Me.lblUnitProfit.AutoSize = True
            Me.lblUnitProfit.BackColor = System.Drawing.Color.Transparent
            Me.lblUnitProfit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUnitProfit.Location = New System.Drawing.Point(407, 125)
            Me.lblUnitProfit.Name = "lblUnitProfit"
            Me.lblUnitProfit.Size = New System.Drawing.Size(28, 13)
            Me.lblUnitProfit.TabIndex = 173
            Me.lblUnitProfit.Text = "0 isk"
            '
            'lblUnitProfitlbl
            '
            Me.lblUnitProfitlbl.AutoSize = True
            Me.lblUnitProfitlbl.BackColor = System.Drawing.Color.Transparent
            Me.lblUnitProfitlbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUnitProfitlbl.Location = New System.Drawing.Point(272, 125)
            Me.lblUnitProfitlbl.Name = "lblUnitProfitlbl"
            Me.lblUnitProfitlbl.Size = New System.Drawing.Size(92, 13)
            Me.lblUnitProfitlbl.TabIndex = 172
            Me.lblUnitProfitlbl.Text = "Unit Profit/(Loss):"
            '
            'lblUnitValue
            '
            Me.lblUnitValue.AutoSize = True
            Me.lblUnitValue.BackColor = System.Drawing.Color.Transparent
            Me.lblUnitValue.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUnitValue.Location = New System.Drawing.Point(407, 112)
            Me.lblUnitValue.Name = "lblUnitValue"
            Me.lblUnitValue.Size = New System.Drawing.Size(28, 13)
            Me.lblUnitValue.TabIndex = 171
            Me.lblUnitValue.Text = "0 isk"
            '
            'lblUnitValuelbl
            '
            Me.lblUnitValuelbl.AutoSize = True
            Me.lblUnitValuelbl.BackColor = System.Drawing.Color.Transparent
            Me.lblUnitValuelbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUnitValuelbl.Location = New System.Drawing.Point(272, 112)
            Me.lblUnitValuelbl.Name = "lblUnitValuelbl"
            Me.lblUnitValuelbl.Size = New System.Drawing.Size(84, 13)
            Me.lblUnitValuelbl.TabIndex = 170
            Me.lblUnitValuelbl.Text = "Unit Sales Price:"
            '
            'lblUnitCost
            '
            Me.lblUnitCost.AutoSize = True
            Me.lblUnitCost.BackColor = System.Drawing.Color.Transparent
            Me.lblUnitCost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUnitCost.Location = New System.Drawing.Point(407, 99)
            Me.lblUnitCost.Name = "lblUnitCost"
            Me.lblUnitCost.Size = New System.Drawing.Size(28, 13)
            Me.lblUnitCost.TabIndex = 169
            Me.lblUnitCost.Text = "0 isk"
            '
            'lblUnitCostLbl
            '
            Me.lblUnitCostLbl.AutoSize = True
            Me.lblUnitCostLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblUnitCostLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUnitCostLbl.Location = New System.Drawing.Point(272, 99)
            Me.lblUnitCostLbl.Name = "lblUnitCostLbl"
            Me.lblUnitCostLbl.Size = New System.Drawing.Size(55, 13)
            Me.lblUnitCostLbl.TabIndex = 168
            Me.lblUnitCostLbl.Text = "Unit Cost:"
            '
            'lblTotalCosts
            '
            Me.lblTotalCosts.AutoSize = True
            Me.lblTotalCosts.BackColor = System.Drawing.Color.Transparent
            Me.lblTotalCosts.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalCosts.Location = New System.Drawing.Point(407, 82)
            Me.lblTotalCosts.Name = "lblTotalCosts"
            Me.lblTotalCosts.Size = New System.Drawing.Size(28, 13)
            Me.lblTotalCosts.TabIndex = 163
            Me.lblTotalCosts.Text = "0 isk"
            '
            'lblTotalCostsLbl
            '
            Me.lblTotalCostsLbl.AutoSize = True
            Me.lblTotalCostsLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblTotalCostsLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalCostsLbl.Location = New System.Drawing.Point(272, 82)
            Me.lblTotalCostsLbl.Name = "lblTotalCostsLbl"
            Me.lblTotalCostsLbl.Size = New System.Drawing.Size(65, 13)
            Me.lblTotalCostsLbl.TabIndex = 162
            Me.lblTotalCostsLbl.Text = "Total Costs:"
            '
            'lblFactoryCosts
            '
            Me.lblFactoryCosts.AutoSize = True
            Me.lblFactoryCosts.BackColor = System.Drawing.Color.Transparent
            Me.lblFactoryCosts.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFactoryCosts.Location = New System.Drawing.Point(407, 69)
            Me.lblFactoryCosts.Name = "lblFactoryCosts"
            Me.lblFactoryCosts.Size = New System.Drawing.Size(28, 13)
            Me.lblFactoryCosts.TabIndex = 161
            Me.lblFactoryCosts.Text = "0 isk"
            '
            'lblTotalBuildCost
            '
            Me.lblTotalBuildCost.AutoSize = True
            Me.lblTotalBuildCost.BackColor = System.Drawing.Color.Transparent
            Me.lblTotalBuildCost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalBuildCost.Location = New System.Drawing.Point(407, 56)
            Me.lblTotalBuildCost.Name = "lblTotalBuildCost"
            Me.lblTotalBuildCost.Size = New System.Drawing.Size(28, 13)
            Me.lblTotalBuildCost.TabIndex = 159
            Me.lblTotalBuildCost.Text = "0 isk"
            '
            'lblUnitBuildCost
            '
            Me.lblUnitBuildCost.AutoSize = True
            Me.lblUnitBuildCost.BackColor = System.Drawing.Color.Transparent
            Me.lblUnitBuildCost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUnitBuildCost.Location = New System.Drawing.Point(407, 44)
            Me.lblUnitBuildCost.Name = "lblUnitBuildCost"
            Me.lblUnitBuildCost.Size = New System.Drawing.Size(28, 13)
            Me.lblUnitBuildCost.TabIndex = 158
            Me.lblUnitBuildCost.Text = "0 isk"
            '
            'lblTotalBuildCostsLbl
            '
            Me.lblTotalBuildCostsLbl.AutoSize = True
            Me.lblTotalBuildCostsLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblTotalBuildCostsLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalBuildCostsLbl.Location = New System.Drawing.Point(272, 56)
            Me.lblTotalBuildCostsLbl.Name = "lblTotalBuildCostsLbl"
            Me.lblTotalBuildCostsLbl.Size = New System.Drawing.Size(101, 13)
            Me.lblTotalBuildCostsLbl.TabIndex = 157
            Me.lblTotalBuildCostsLbl.Text = "Total Material Cost:"
            '
            'lblUnitBuildCostsLbl
            '
            Me.lblUnitBuildCostsLbl.AutoSize = True
            Me.lblUnitBuildCostsLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblUnitBuildCostsLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUnitBuildCostsLbl.Location = New System.Drawing.Point(272, 43)
            Me.lblUnitBuildCostsLbl.Name = "lblUnitBuildCostsLbl"
            Me.lblUnitBuildCostsLbl.Size = New System.Drawing.Size(104, 13)
            Me.lblUnitBuildCostsLbl.TabIndex = 156
            Me.lblUnitBuildCostsLbl.Text = "Batch Material Cost:"
            '
            'lblTotalBuildTime
            '
            Me.lblTotalBuildTime.AutoSize = True
            Me.lblTotalBuildTime.BackColor = System.Drawing.Color.Transparent
            Me.lblTotalBuildTime.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalBuildTime.Location = New System.Drawing.Point(407, 26)
            Me.lblTotalBuildTime.Name = "lblTotalBuildTime"
            Me.lblTotalBuildTime.Size = New System.Drawing.Size(18, 13)
            Me.lblTotalBuildTime.TabIndex = 155
            Me.lblTotalBuildTime.Text = "0s"
            '
            'lblUnitBuildTime
            '
            Me.lblUnitBuildTime.AutoSize = True
            Me.lblUnitBuildTime.BackColor = System.Drawing.Color.Transparent
            Me.lblUnitBuildTime.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUnitBuildTime.Location = New System.Drawing.Point(407, 13)
            Me.lblUnitBuildTime.Name = "lblUnitBuildTime"
            Me.lblUnitBuildTime.Size = New System.Drawing.Size(18, 13)
            Me.lblUnitBuildTime.TabIndex = 154
            Me.lblUnitBuildTime.Text = "0s"
            '
            'lblTotalBuildTimeLbl
            '
            Me.lblTotalBuildTimeLbl.AutoSize = True
            Me.lblTotalBuildTimeLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblTotalBuildTimeLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalBuildTimeLbl.Location = New System.Drawing.Point(272, 26)
            Me.lblTotalBuildTimeLbl.Name = "lblTotalBuildTimeLbl"
            Me.lblTotalBuildTimeLbl.Size = New System.Drawing.Size(85, 13)
            Me.lblTotalBuildTimeLbl.TabIndex = 23
            Me.lblTotalBuildTimeLbl.Text = "Total Build Time:"
            '
            'lblUnitBuildTimeLbl
            '
            Me.lblUnitBuildTimeLbl.AutoSize = True
            Me.lblUnitBuildTimeLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblUnitBuildTimeLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUnitBuildTimeLbl.Location = New System.Drawing.Point(272, 13)
            Me.lblUnitBuildTimeLbl.Name = "lblUnitBuildTimeLbl"
            Me.lblUnitBuildTimeLbl.Size = New System.Drawing.Size(88, 13)
            Me.lblUnitBuildTimeLbl.TabIndex = 22
            Me.lblUnitBuildTimeLbl.Text = "Batch Build Time:"
            '
            'lblPESkill
            '
            Me.lblPESkill.AutoSize = True
            Me.lblPESkill.Location = New System.Drawing.Point(4, 27)
            Me.lblPESkill.Name = "lblPESkill"
            Me.lblPESkill.Size = New System.Drawing.Size(49, 13)
            Me.lblPESkill.TabIndex = 5
            Me.lblPESkill.Text = "Adv Ind:"
            Me.ToolTip1.SetToolTip(Me.lblPESkill, "Reduces manufacturing waste material")
            '
            'lblIndustrySkill
            '
            Me.lblIndustrySkill.AutoSize = True
            Me.lblIndustrySkill.Location = New System.Drawing.Point(4, 6)
            Me.lblIndustrySkill.Name = "lblIndustrySkill"
            Me.lblIndustrySkill.Size = New System.Drawing.Size(52, 13)
            Me.lblIndustrySkill.TabIndex = 4
            Me.lblIndustrySkill.Text = "Industry:"
            Me.ToolTip1.SetToolTip(Me.lblIndustrySkill, "Reduces manufacturing time.")
            '
            'lblScienceSkill
            '
            Me.lblScienceSkill.AutoSize = True
            Me.lblScienceSkill.Location = New System.Drawing.Point(3, 48)
            Me.lblScienceSkill.Name = "lblScienceSkill"
            Me.lblScienceSkill.Size = New System.Drawing.Size(47, 13)
            Me.lblScienceSkill.TabIndex = 5
            Me.lblScienceSkill.Text = "Science:"
            Me.ToolTip1.SetToolTip(Me.lblScienceSkill, "Reduces the time taken to make a blueprint copy.")
            '
            'lblMetallurgySkill
            '
            Me.lblMetallurgySkill.AutoSize = True
            Me.lblMetallurgySkill.Location = New System.Drawing.Point(3, 27)
            Me.lblMetallurgySkill.Name = "lblMetallurgySkill"
            Me.lblMetallurgySkill.Size = New System.Drawing.Size(61, 13)
            Me.lblMetallurgySkill.TabIndex = 1
            Me.lblMetallurgySkill.Text = "Metallurgy:"
            Me.ToolTip1.SetToolTip(Me.lblMetallurgySkill, "Reduces the time taken to research the ME Level.")
            '
            'lblResearchSkill
            '
            Me.lblResearchSkill.AutoSize = True
            Me.lblResearchSkill.Location = New System.Drawing.Point(3, 6)
            Me.lblResearchSkill.Name = "lblResearchSkill"
            Me.lblResearchSkill.Size = New System.Drawing.Size(56, 13)
            Me.lblResearchSkill.TabIndex = 0
            Me.lblResearchSkill.Text = "Research:"
            Me.ToolTip1.SetToolTip(Me.lblResearchSkill, "Reduces the time taken to research the PE Level.")
            '
            'lblPilot
            '
            Me.lblPilot.AutoSize = True
            Me.lblPilot.Location = New System.Drawing.Point(3, 6)
            Me.lblPilot.Name = "lblPilot"
            Me.lblPilot.Size = New System.Drawing.Size(31, 13)
            Me.lblPilot.TabIndex = 5
            Me.lblPilot.Text = "Pilot:"
            '
            'cboIndustryImplant
            '
            Me.cboIndustryImplant.DisplayMember = "Text"
            Me.cboIndustryImplant.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboIndustryImplant.Enabled = False
            Me.cboIndustryImplant.FormattingEnabled = True
            Me.cboIndustryImplant.ItemHeight = 15
            Me.cboIndustryImplant.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4})
            Me.cboIndustryImplant.Location = New System.Drawing.Point(102, 3)
            Me.cboIndustryImplant.Name = "cboIndustryImplant"
            Me.cboIndustryImplant.Size = New System.Drawing.Size(44, 21)
            Me.cboIndustryImplant.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboIndustryImplant.TabIndex = 13
            Me.cboIndustryImplant.Text = "0%"
            Me.ToolTip1.SetToolTip(Me.cboIndustryImplant, "'Beancounter' F Series: Reduces manufacturing time.")
            '
            'ComboItem1
            '
            Me.ComboItem1.Text = "0%"
            '
            'ComboItem2
            '
            Me.ComboItem2.Text = "1%"
            '
            'ComboItem3
            '
            Me.ComboItem3.Text = "2%"
            '
            'ComboItem4
            '
            Me.ComboItem4.Text = "4%"
            '
            'cboResearchImplant
            '
            Me.cboResearchImplant.DisplayMember = "Text"
            Me.cboResearchImplant.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboResearchImplant.Enabled = False
            Me.cboResearchImplant.FormattingEnabled = True
            Me.cboResearchImplant.ItemHeight = 15
            Me.cboResearchImplant.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem6, Me.ComboItem7, Me.ComboItem8})
            Me.cboResearchImplant.Location = New System.Drawing.Point(106, 3)
            Me.cboResearchImplant.Name = "cboResearchImplant"
            Me.cboResearchImplant.Size = New System.Drawing.Size(44, 21)
            Me.cboResearchImplant.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboResearchImplant.TabIndex = 14
            Me.cboResearchImplant.Text = "0%"
            Me.ToolTip1.SetToolTip(Me.cboResearchImplant, "'Beancounter' I Series: Reduces the time taken to research the PE Level.")
            '
            'ComboItem5
            '
            Me.ComboItem5.Text = "0%"
            '
            'ComboItem6
            '
            Me.ComboItem6.Text = "1%"
            '
            'ComboItem7
            '
            Me.ComboItem7.Text = "3%"
            '
            'ComboItem8
            '
            Me.ComboItem8.Text = "5%"
            '
            'cboMetallurgyImplant
            '
            Me.cboMetallurgyImplant.DisplayMember = "Text"
            Me.cboMetallurgyImplant.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboMetallurgyImplant.Enabled = False
            Me.cboMetallurgyImplant.FormattingEnabled = True
            Me.cboMetallurgyImplant.ItemHeight = 15
            Me.cboMetallurgyImplant.Items.AddRange(New Object() {Me.ComboItem9, Me.ComboItem10, Me.ComboItem11, Me.ComboItem12})
            Me.cboMetallurgyImplant.Location = New System.Drawing.Point(106, 24)
            Me.cboMetallurgyImplant.Name = "cboMetallurgyImplant"
            Me.cboMetallurgyImplant.Size = New System.Drawing.Size(44, 21)
            Me.cboMetallurgyImplant.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboMetallurgyImplant.TabIndex = 15
            Me.cboMetallurgyImplant.Text = "0%"
            Me.ToolTip1.SetToolTip(Me.cboMetallurgyImplant, "'Beancounter' J Series: Reduces the time taken to research the ME Level.")
            '
            'ComboItem9
            '
            Me.ComboItem9.Text = "0%"
            '
            'ComboItem10
            '
            Me.ComboItem10.Text = "1%"
            '
            'ComboItem11
            '
            Me.ComboItem11.Text = "3%"
            '
            'ComboItem12
            '
            Me.ComboItem12.Text = "5%"
            '
            'cboScienceImplant
            '
            Me.cboScienceImplant.DisplayMember = "Text"
            Me.cboScienceImplant.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboScienceImplant.Enabled = False
            Me.cboScienceImplant.FormattingEnabled = True
            Me.cboScienceImplant.ItemHeight = 15
            Me.cboScienceImplant.Items.AddRange(New Object() {Me.ComboItem13, Me.ComboItem14, Me.ComboItem15, Me.ComboItem16})
            Me.cboScienceImplant.Location = New System.Drawing.Point(106, 45)
            Me.cboScienceImplant.Name = "cboScienceImplant"
            Me.cboScienceImplant.Size = New System.Drawing.Size(44, 21)
            Me.cboScienceImplant.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboScienceImplant.TabIndex = 16
            Me.cboScienceImplant.Text = "0%"
            Me.ToolTip1.SetToolTip(Me.cboScienceImplant, "'Beancounter' K Series: Reduces the time taken to make a blueprint copy.")
            '
            'ComboItem13
            '
            Me.ComboItem13.Text = "0%"
            '
            'ComboItem14
            '
            Me.ComboItem14.Text = "1%"
            '
            'ComboItem15
            '
            Me.ComboItem15.Text = "3%"
            '
            'ComboItem16
            '
            Me.ComboItem16.Text = "5%"
            '
            'PanelEx1
            '
            Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
            Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.PanelEx1.Controls.Add(Me.gpPilotSkills)
            Me.PanelEx1.Controls.Add(Me.gpBPSelection)
            Me.PanelEx1.Controls.Add(Me.nudCopyRuns)
            Me.PanelEx1.Controls.Add(Me.tabBPCalcFunctions)
            Me.PanelEx1.Controls.Add(Me.nudTELevel)
            Me.PanelEx1.Controls.Add(Me.lblNewMELbl)
            Me.PanelEx1.Controls.Add(Me.btnSaveProductionJobAs)
            Me.PanelEx1.Controls.Add(Me.nudMELevel)
            Me.PanelEx1.Controls.Add(Me.btnSaveProductionJob)
            Me.PanelEx1.Controls.Add(Me.txtNewWasteFactor)
            Me.PanelEx1.Controls.Add(Me.LblNewWFLbl)
            Me.PanelEx1.Controls.Add(Me.lblNewTELbl)
            Me.PanelEx1.Controls.Add(Me.lblRunsPerCopy)
            Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
            Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
            Me.PanelEx1.Name = "PanelEx1"
            Me.PanelEx1.Size = New System.Drawing.Size(842, 738)
            Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.PanelEx1.Style.GradientAngle = 90
            Me.PanelEx1.TabIndex = 155
            '
            'gpPilotSkills
            '
            Me.gpPilotSkills.CanvasColor = System.Drawing.SystemColors.Control
            Me.gpPilotSkills.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.gpPilotSkills.Controls.Add(Me.gpProductionSkills)
            Me.gpPilotSkills.Controls.Add(Me.gpResearchSkills)
            Me.gpPilotSkills.Controls.Add(Me.chkOverrideSkills)
            Me.gpPilotSkills.Controls.Add(Me.cboPilot)
            Me.gpPilotSkills.Controls.Add(Me.lblPilot)
            Me.gpPilotSkills.DisabledBackColor = System.Drawing.Color.Empty
            Me.gpPilotSkills.IsShadowEnabled = True
            Me.gpPilotSkills.Location = New System.Drawing.Point(413, 3)
            Me.gpPilotSkills.Name = "gpPilotSkills"
            Me.gpPilotSkills.Size = New System.Drawing.Size(340, 151)
            '
            '
            '
            Me.gpPilotSkills.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.gpPilotSkills.Style.BackColorGradientAngle = 90
            Me.gpPilotSkills.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.gpPilotSkills.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpPilotSkills.Style.BorderBottomWidth = 1
            Me.gpPilotSkills.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.gpPilotSkills.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpPilotSkills.Style.BorderLeftWidth = 1
            Me.gpPilotSkills.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpPilotSkills.Style.BorderRightWidth = 1
            Me.gpPilotSkills.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpPilotSkills.Style.BorderTopWidth = 1
            Me.gpPilotSkills.Style.CornerDiameter = 4
            Me.gpPilotSkills.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.gpPilotSkills.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.gpPilotSkills.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.gpPilotSkills.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.gpPilotSkills.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.gpPilotSkills.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.gpPilotSkills.TabIndex = 1
            Me.gpPilotSkills.Text = "Pilot & Skill Selection"
            '
            'gpProductionSkills
            '
            Me.gpProductionSkills.CanvasColor = System.Drawing.SystemColors.Control
            Me.gpProductionSkills.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.gpProductionSkills.Controls.Add(Me.cboIndustryImplant)
            Me.gpProductionSkills.Controls.Add(Me.cboIndustrySkill)
            Me.gpProductionSkills.Controls.Add(Me.cboAdvInvSkill)
            Me.gpProductionSkills.Controls.Add(Me.lblIndustrySkill)
            Me.gpProductionSkills.Controls.Add(Me.lblPESkill)
            Me.gpProductionSkills.DisabledBackColor = System.Drawing.Color.Empty
            Me.gpProductionSkills.Location = New System.Drawing.Point(171, 32)
            Me.gpProductionSkills.Name = "gpProductionSkills"
            Me.gpProductionSkills.Size = New System.Drawing.Size(160, 95)
            '
            '
            '
            Me.gpProductionSkills.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.gpProductionSkills.Style.BackColorGradientAngle = 90
            Me.gpProductionSkills.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.gpProductionSkills.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpProductionSkills.Style.BorderBottomWidth = 1
            Me.gpProductionSkills.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.gpProductionSkills.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpProductionSkills.Style.BorderLeftWidth = 1
            Me.gpProductionSkills.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpProductionSkills.Style.BorderRightWidth = 1
            Me.gpProductionSkills.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpProductionSkills.Style.BorderTopWidth = 1
            Me.gpProductionSkills.Style.CornerDiameter = 4
            Me.gpProductionSkills.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.gpProductionSkills.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.gpProductionSkills.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.gpProductionSkills.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.gpProductionSkills.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.gpProductionSkills.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.gpProductionSkills.TabIndex = 10
            Me.gpProductionSkills.Text = "Production Skills / Implants"
            '
            'cboIndustrySkill
            '
            Me.cboIndustrySkill.DisplayMember = "Text"
            Me.cboIndustrySkill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboIndustrySkill.Enabled = False
            Me.cboIndustrySkill.FormattingEnabled = True
            Me.cboIndustrySkill.ItemHeight = 15
            Me.cboIndustrySkill.Location = New System.Drawing.Point(61, 3)
            Me.cboIndustrySkill.Name = "cboIndustrySkill"
            Me.cboIndustrySkill.Size = New System.Drawing.Size(35, 21)
            Me.cboIndustrySkill.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboIndustrySkill.TabIndex = 12
            Me.cboIndustrySkill.Text = "0"
            '
            'cboAdvInvSkill
            '
            Me.cboAdvInvSkill.DisplayMember = "Text"
            Me.cboAdvInvSkill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboAdvInvSkill.Enabled = False
            Me.cboAdvInvSkill.FormattingEnabled = True
            Me.cboAdvInvSkill.ItemHeight = 15
            Me.cboAdvInvSkill.Location = New System.Drawing.Point(61, 24)
            Me.cboAdvInvSkill.Name = "cboAdvInvSkill"
            Me.cboAdvInvSkill.Size = New System.Drawing.Size(35, 21)
            Me.cboAdvInvSkill.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboAdvInvSkill.TabIndex = 11
            Me.cboAdvInvSkill.Text = "0"
            '
            'gpResearchSkills
            '
            Me.gpResearchSkills.CanvasColor = System.Drawing.SystemColors.Control
            Me.gpResearchSkills.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.gpResearchSkills.Controls.Add(Me.cboScienceImplant)
            Me.gpResearchSkills.Controls.Add(Me.cboMetallurgyImplant)
            Me.gpResearchSkills.Controls.Add(Me.cboResearchImplant)
            Me.gpResearchSkills.Controls.Add(Me.cboScienceSkill)
            Me.gpResearchSkills.Controls.Add(Me.cboResearchSkill)
            Me.gpResearchSkills.Controls.Add(Me.cboMetallurgySkill)
            Me.gpResearchSkills.Controls.Add(Me.lblResearchSkill)
            Me.gpResearchSkills.Controls.Add(Me.lblMetallurgySkill)
            Me.gpResearchSkills.Controls.Add(Me.lblScienceSkill)
            Me.gpResearchSkills.DisabledBackColor = System.Drawing.Color.Empty
            Me.gpResearchSkills.Location = New System.Drawing.Point(6, 32)
            Me.gpResearchSkills.Name = "gpResearchSkills"
            Me.gpResearchSkills.Size = New System.Drawing.Size(160, 95)
            '
            '
            '
            Me.gpResearchSkills.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.gpResearchSkills.Style.BackColorGradientAngle = 90
            Me.gpResearchSkills.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.gpResearchSkills.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpResearchSkills.Style.BorderBottomWidth = 1
            Me.gpResearchSkills.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.gpResearchSkills.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpResearchSkills.Style.BorderLeftWidth = 1
            Me.gpResearchSkills.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpResearchSkills.Style.BorderRightWidth = 1
            Me.gpResearchSkills.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpResearchSkills.Style.BorderTopWidth = 1
            Me.gpResearchSkills.Style.CornerDiameter = 4
            Me.gpResearchSkills.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.gpResearchSkills.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.gpResearchSkills.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.gpResearchSkills.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.gpResearchSkills.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.gpResearchSkills.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.gpResearchSkills.TabIndex = 9
            Me.gpResearchSkills.Text = "Research Skills / Implants"
            '
            'cboScienceSkill
            '
            Me.cboScienceSkill.DisplayMember = "Text"
            Me.cboScienceSkill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboScienceSkill.Enabled = False
            Me.cboScienceSkill.FormattingEnabled = True
            Me.cboScienceSkill.ItemHeight = 15
            Me.cboScienceSkill.Location = New System.Drawing.Point(65, 45)
            Me.cboScienceSkill.Name = "cboScienceSkill"
            Me.cboScienceSkill.Size = New System.Drawing.Size(35, 21)
            Me.cboScienceSkill.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboScienceSkill.TabIndex = 14
            Me.cboScienceSkill.Text = "0"
            '
            'cboResearchSkill
            '
            Me.cboResearchSkill.DisplayMember = "Text"
            Me.cboResearchSkill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboResearchSkill.Enabled = False
            Me.cboResearchSkill.FormattingEnabled = True
            Me.cboResearchSkill.ItemHeight = 15
            Me.cboResearchSkill.Location = New System.Drawing.Point(65, 3)
            Me.cboResearchSkill.Name = "cboResearchSkill"
            Me.cboResearchSkill.Size = New System.Drawing.Size(35, 21)
            Me.cboResearchSkill.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboResearchSkill.TabIndex = 13
            Me.cboResearchSkill.Text = "0"
            '
            'cboMetallurgySkill
            '
            Me.cboMetallurgySkill.DisplayMember = "Text"
            Me.cboMetallurgySkill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboMetallurgySkill.Enabled = False
            Me.cboMetallurgySkill.FormattingEnabled = True
            Me.cboMetallurgySkill.ItemHeight = 15
            Me.cboMetallurgySkill.Location = New System.Drawing.Point(65, 24)
            Me.cboMetallurgySkill.Name = "cboMetallurgySkill"
            Me.cboMetallurgySkill.Size = New System.Drawing.Size(35, 21)
            Me.cboMetallurgySkill.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboMetallurgySkill.TabIndex = 13
            Me.cboMetallurgySkill.Text = "0"
            '
            'chkOverrideSkills
            '
            Me.chkOverrideSkills.AutoSize = True
            '
            '
            '
            Me.chkOverrideSkills.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkOverrideSkills.Location = New System.Drawing.Point(212, 6)
            Me.chkOverrideSkills.Name = "chkOverrideSkills"
            Me.chkOverrideSkills.Size = New System.Drawing.Size(91, 16)
            Me.chkOverrideSkills.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkOverrideSkills.TabIndex = 8
            Me.chkOverrideSkills.Text = "Override Skills"
            '
            'cboPilot
            '
            Me.cboPilot.DisplayMember = "Text"
            Me.cboPilot.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboPilot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboPilot.FormattingEnabled = True
            Me.cboPilot.ItemHeight = 15
            Me.cboPilot.Location = New System.Drawing.Point(37, 3)
            Me.cboPilot.Name = "cboPilot"
            Me.cboPilot.Size = New System.Drawing.Size(168, 21)
            Me.cboPilot.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboPilot.TabIndex = 7
            '
            'gpBPSelection
            '
            Me.gpBPSelection.CanvasColor = System.Drawing.SystemColors.Control
            Me.gpBPSelection.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.gpBPSelection.Controls.Add(Me.lblToggleInvention)
            Me.gpBPSelection.Controls.Add(Me.btnToggleInvention)
            Me.gpBPSelection.Controls.Add(Me.cboOwner)
            Me.gpBPSelection.Controls.Add(Me.lblBPMaxRuns)
            Me.gpBPSelection.Controls.Add(Me.lblBPMaxRunsLbl)
            Me.gpBPSelection.Controls.Add(Me.cboBPs)
            Me.gpBPSelection.Controls.Add(Me.chkOwnedBPOs)
            Me.gpBPSelection.Controls.Add(Me.chkInventBPOs)
            Me.gpBPSelection.Controls.Add(Me.lblBPRuns)
            Me.gpBPSelection.Controls.Add(Me.lblBPRunsLbl)
            Me.gpBPSelection.Controls.Add(Me.lblBPTELbl)
            Me.gpBPSelection.Controls.Add(Me.lblBPME)
            Me.gpBPSelection.Controls.Add(Me.lblBPWFLbl)
            Me.gpBPSelection.Controls.Add(Me.lblBPTE)
            Me.gpBPSelection.Controls.Add(Me.lblBPWF)
            Me.gpBPSelection.Controls.Add(Me.lblBPMELbl)
            Me.gpBPSelection.Controls.Add(Me.lblBPOMarketValue)
            Me.gpBPSelection.Controls.Add(Me.pbBP)
            Me.gpBPSelection.Controls.Add(Me.lblBPOMarketValueLbl)
            Me.gpBPSelection.DisabledBackColor = System.Drawing.Color.Empty
            Me.gpBPSelection.IsShadowEnabled = True
            Me.gpBPSelection.Location = New System.Drawing.Point(3, 3)
            Me.gpBPSelection.Name = "gpBPSelection"
            Me.gpBPSelection.Size = New System.Drawing.Size(404, 151)
            '
            '
            '
            Me.gpBPSelection.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.gpBPSelection.Style.BackColorGradientAngle = 90
            Me.gpBPSelection.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.gpBPSelection.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpBPSelection.Style.BorderBottomWidth = 1
            Me.gpBPSelection.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.gpBPSelection.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpBPSelection.Style.BorderLeftWidth = 1
            Me.gpBPSelection.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpBPSelection.Style.BorderRightWidth = 1
            Me.gpBPSelection.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpBPSelection.Style.BorderTopWidth = 1
            Me.gpBPSelection.Style.CornerDiameter = 4
            Me.gpBPSelection.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.gpBPSelection.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.gpBPSelection.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.gpBPSelection.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.gpBPSelection.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.gpBPSelection.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.gpBPSelection.TabIndex = 0
            Me.gpBPSelection.Text = "Blueprint Selection & Information"
            '
            'lblToggleInvention
            '
            Me.lblToggleInvention.AutoSize = True
            '
            '
            '
            Me.lblToggleInvention.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblToggleInvention.Location = New System.Drawing.Point(207, 32)
            Me.lblToggleInvention.Name = "lblToggleInvention"
            Me.lblToggleInvention.Size = New System.Drawing.Size(124, 16)
            Me.lblToggleInvention.TabIndex = 27
            Me.lblToggleInvention.Text = "Invention BP Tech Level:"
            '
            'btnToggleInvention
            '
            '
            '
            '
            Me.btnToggleInvention.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.btnToggleInvention.Enabled = False
            Me.btnToggleInvention.Location = New System.Drawing.Point(334, 30)
            Me.btnToggleInvention.Name = "btnToggleInvention"
            Me.btnToggleInvention.OffBackColor = System.Drawing.Color.Gold
            Me.btnToggleInvention.OffText = "T2"
            Me.btnToggleInvention.OnBackColor = System.Drawing.Color.LimeGreen
            Me.btnToggleInvention.OnText = "T1"
            Me.btnToggleInvention.Size = New System.Drawing.Size(60, 18)
            Me.btnToggleInvention.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.SuperTooltip1.SetSuperTooltip(Me.btnToggleInvention, New DevComponents.DotNetBar.SuperTooltipInfo("", "Invention BP Tech Level", "Toggles between displaying T2 Blueprints to invent (default) or T1 Blueprints to " &
            "invent from.", Nothing, Global.EveHQ.Prism.My.Resources.Resources.Info32, DevComponents.DotNetBar.eTooltipColor.Yellow))
            Me.btnToggleInvention.TabIndex = 26
            '
            'cboOwner
            '
            Me.cboOwner.DisplayMember = "Text"
            Me.cboOwner.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboOwner.Enabled = False
            Me.cboOwner.FormattingEnabled = True
            Me.cboOwner.ItemHeight = 15
            Me.cboOwner.Location = New System.Drawing.Point(146, 3)
            Me.cboOwner.Name = "cboOwner"
            Me.cboOwner.Size = New System.Drawing.Size(249, 21)
            Me.cboOwner.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboOwner.TabIndex = 25
            '
            'lblBPMaxRuns
            '
            Me.lblBPMaxRuns.AutoSize = True
            Me.lblBPMaxRuns.Location = New System.Drawing.Point(257, 98)
            Me.lblBPMaxRuns.Name = "lblBPMaxRuns"
            Me.lblBPMaxRuns.Size = New System.Drawing.Size(13, 13)
            Me.lblBPMaxRuns.TabIndex = 23
            Me.lblBPMaxRuns.Text = "0"
            '
            'lblBPMaxRunsLbl
            '
            Me.lblBPMaxRunsLbl.AutoSize = True
            Me.lblBPMaxRunsLbl.Location = New System.Drawing.Point(194, 98)
            Me.lblBPMaxRunsLbl.Name = "lblBPMaxRunsLbl"
            Me.lblBPMaxRunsLbl.Size = New System.Drawing.Size(58, 13)
            Me.lblBPMaxRunsLbl.TabIndex = 22
            Me.lblBPMaxRunsLbl.Text = "Max Runs:"
            '
            'cboBPs
            '
            Me.cboBPs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cboBPs.DisplayMember = "Text"
            Me.cboBPs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboBPs.FormattingEnabled = True
            Me.cboBPs.ItemHeight = 15
            Me.cboBPs.Location = New System.Drawing.Point(2, 52)
            Me.cboBPs.Name = "cboBPs"
            Me.cboBPs.Size = New System.Drawing.Size(392, 21)
            Me.cboBPs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboBPs.TabIndex = 21
            '
            'chkOwnedBPOs
            '
            Me.chkOwnedBPOs.AutoSize = True
            '
            '
            '
            Me.chkOwnedBPOs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkOwnedBPOs.Location = New System.Drawing.Point(1, 6)
            Me.chkOwnedBPOs.Name = "chkOwnedBPOs"
            Me.chkOwnedBPOs.Size = New System.Drawing.Size(133, 16)
            Me.chkOwnedBPOs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkOwnedBPOs.TabIndex = 20
            Me.chkOwnedBPOs.Text = "Owned Blueprints Only"
            '
            'chkInventBPOs
            '
            Me.chkInventBPOs.AutoSize = True
            '
            '
            '
            Me.chkInventBPOs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkInventBPOs.Location = New System.Drawing.Point(1, 30)
            Me.chkInventBPOs.Name = "chkInventBPOs"
            Me.chkInventBPOs.Size = New System.Drawing.Size(184, 16)
            Me.chkInventBPOs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkInventBPOs.TabIndex = 20
            Me.chkInventBPOs.Text = "Invention Related Blueprints only"
            '
            'pbBP
            '
            Me.pbBP.BackColor = System.Drawing.Color.Transparent
            Me.pbBP.Location = New System.Drawing.Point(3, 78)
            Me.pbBP.Name = "pbBP"
            Me.pbBP.Size = New System.Drawing.Size(48, 48)
            Me.pbBP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pbBP.TabIndex = 10
            Me.pbBP.TabStop = False
            '
            'nudCopyRuns
            '
            '
            '
            '
            Me.nudCopyRuns.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.nudCopyRuns.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.nudCopyRuns.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.nudCopyRuns.Location = New System.Drawing.Point(456, 160)
            Me.nudCopyRuns.MaxValue = 1500
            Me.nudCopyRuns.MinValue = 1
            Me.nudCopyRuns.Name = "nudCopyRuns"
            Me.nudCopyRuns.ShowUpDown = True
            Me.nudCopyRuns.Size = New System.Drawing.Size(80, 21)
            Me.nudCopyRuns.TabIndex = 36
            Me.nudCopyRuns.Value = 1
            '
            'tabBPCalcFunctions
            '
            Me.tabBPCalcFunctions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tabBPCalcFunctions.BackColor = System.Drawing.Color.Transparent
            Me.tabBPCalcFunctions.CanReorderTabs = True
            Me.tabBPCalcFunctions.ColorScheme.TabBackground = System.Drawing.Color.Transparent
            Me.tabBPCalcFunctions.ColorScheme.TabBackground2 = System.Drawing.Color.Transparent
            Me.tabBPCalcFunctions.ColorScheme.TabItemBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer)), 0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(248, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(245, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(247, Byte), Integer)), 1.0!)})
            Me.tabBPCalcFunctions.ColorScheme.TabItemHotBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(235, Byte), Integer)), 0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(168, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(89, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(141, Byte), Integer)), 1.0!)})
            Me.tabBPCalcFunctions.ColorScheme.TabItemSelectedBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.White, 0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer)), 1.0!)})
            Me.tabBPCalcFunctions.Controls.Add(Me.tcpInvention)
            Me.tabBPCalcFunctions.Controls.Add(Me.tcpResearch)
            Me.tabBPCalcFunctions.Controls.Add(Me.tcpProduction)
            Me.tabBPCalcFunctions.Location = New System.Drawing.Point(3, 187)
            Me.tabBPCalcFunctions.Name = "tabBPCalcFunctions"
            Me.tabBPCalcFunctions.SelectedTabFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.tabBPCalcFunctions.SelectedTabIndex = 0
            Me.tabBPCalcFunctions.Size = New System.Drawing.Size(836, 548)
            Me.tabBPCalcFunctions.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
            Me.tabBPCalcFunctions.TabIndex = 156
            Me.tabBPCalcFunctions.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
            Me.tabBPCalcFunctions.Tabs.Add(Me.tiResearch)
            Me.tabBPCalcFunctions.Tabs.Add(Me.tiProduction)
            Me.tabBPCalcFunctions.Tabs.Add(Me.tiInvention)
            Me.tabBPCalcFunctions.Text = "TabControl1"
            '
            'tcpInvention
            '
            Me.tcpInvention.Controls.Add(Me.chkInventionFlag)
            Me.tcpInvention.Controls.Add(Me.lblBatchTotalCost)
            Me.tcpInvention.Controls.Add(Me.lblBatchTotalCostLbl)
            Me.tcpInvention.Controls.Add(Me.adtInventionProfits)
            Me.tcpInvention.Controls.Add(Me.lblTotalInventionProfit)
            Me.tcpInvention.Controls.Add(Me.lblTotalInventionProfitLbl)
            Me.tcpInvention.Controls.Add(Me.lblUnitInventionProfit)
            Me.tcpInvention.Controls.Add(Me.lblUnitInventionProfitLbl)
            Me.tcpInvention.Controls.Add(Me.lblInventionSalesPrice)
            Me.tcpInvention.Controls.Add(Me.lblInventionSalesPriceLbl)
            Me.tcpInvention.Controls.Add(Me.lblAvgInventionCost)
            Me.tcpInvention.Controls.Add(Me.lblAvgInventionCostLbl)
            Me.tcpInvention.Controls.Add(Me.lblBatchProductionCost)
            Me.tcpInvention.Controls.Add(Me.lblBatchProductionCostLbl)
            Me.tcpInvention.Controls.Add(Me.nudInventionSkill2)
            Me.tcpInvention.Controls.Add(Me.nudInventionSkill3)
            Me.tcpInvention.Controls.Add(Me.nudInventionSkill1)
            Me.tcpInvention.Controls.Add(Me.lblSuccessCost)
            Me.tcpInvention.Controls.Add(Me.lblSuccessCostLbl)
            Me.tcpInvention.Controls.Add(Me.lblAvgAttempts)
            Me.tcpInvention.Controls.Add(Me.lblInventionBPCCost)
            Me.tcpInvention.Controls.Add(Me.lblInventionBPCCostLbl)
            Me.tcpInvention.Controls.Add(Me.lblInventedBP)
            Me.tcpInvention.Controls.Add(Me.lblInventionDecryptorCost)
            Me.tcpInvention.Controls.Add(Me.lblInventionLabCosts)
            Me.tcpInvention.Controls.Add(Me.lblInventionCost)
            Me.tcpInvention.Controls.Add(Me.lblInventionBaseCost)
            Me.tcpInvention.Controls.Add(Me.lblInventionLabCostsLbl)
            Me.tcpInvention.Controls.Add(Me.lblOverrideBPCRuns)
            Me.tcpInvention.Controls.Add(Me.lblBlueprintInventions)
            Me.tcpInvention.Controls.Add(Me.lblDecryptor)
            Me.tcpInvention.Controls.Add(Me.lblBaseChance)
            Me.tcpInvention.Controls.Add(Me.lblInvSkill2)
            Me.tcpInvention.Controls.Add(Me.lblInvSkill3)
            Me.tcpInvention.Controls.Add(Me.lblInvSkill1)
            Me.tcpInvention.Controls.Add(Me.lblInventionCostLbl)
            Me.tcpInvention.Controls.Add(Me.lblInventionDecryptorCostLbl)
            Me.tcpInvention.Controls.Add(Me.lblInventionBaseCostLbl)
            Me.tcpInvention.Controls.Add(Me.lblInventedBPLbl)
            Me.tcpInvention.Controls.Add(Me.lblInventionChance)
            Me.tcpInvention.Controls.Add(Me.lblInventionTime)
            Me.tcpInvention.Controls.Add(Me.lblInventionTimeLbl)
            Me.tcpInvention.Controls.Add(Me.nudInventionBPCRuns)
            Me.tcpInvention.Controls.Add(Me.cboDecryptor)
            Me.tcpInvention.Controls.Add(Me.cboInventions)
            Me.tcpInvention.Controls.Add(Me.PPRInvention)
            Me.tcpInvention.Controls.Add(Me.PACDecryptor)
            Me.tcpInvention.Controls.Add(Me.PACSalesPrice)
            Me.tcpInvention.DisabledBackColor = System.Drawing.Color.Empty
            Me.tcpInvention.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcpInvention.Location = New System.Drawing.Point(0, 23)
            Me.tcpInvention.Name = "tcpInvention"
            Me.tcpInvention.Padding = New System.Windows.Forms.Padding(1)
            Me.tcpInvention.Size = New System.Drawing.Size(836, 525)
            Me.tcpInvention.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.tcpInvention.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.tcpInvention.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.tcpInvention.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
            Me.tcpInvention.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.tcpInvention.Style.GradientAngle = 90
            Me.tcpInvention.TabIndex = 3
            Me.tcpInvention.TabItem = Me.tiInvention
            '
            'chkInventionFlag
            '
            Me.chkInventionFlag.AutoSize = True
            Me.chkInventionFlag.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.chkInventionFlag.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkInventionFlag.Location = New System.Drawing.Point(337, 199)
            Me.chkInventionFlag.Name = "chkInventionFlag"
            Me.chkInventionFlag.Size = New System.Drawing.Size(153, 16)
            Me.chkInventionFlag.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkInventionFlag.TabIndex = 213
            Me.chkInventionFlag.Text = "Save in Invention Manager"
            '
            'lblBatchTotalCost
            '
            Me.lblBatchTotalCost.AutoSize = True
            Me.lblBatchTotalCost.BackColor = System.Drawing.Color.Transparent
            Me.lblBatchTotalCost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBatchTotalCost.Location = New System.Drawing.Point(455, 114)
            Me.lblBatchTotalCost.Name = "lblBatchTotalCost"
            Me.lblBatchTotalCost.Size = New System.Drawing.Size(30, 13)
            Me.lblBatchTotalCost.TabIndex = 212
            Me.lblBatchTotalCost.Text = "0 Isk"
            '
            'lblBatchTotalCostLbl
            '
            Me.lblBatchTotalCostLbl.AutoSize = True
            Me.lblBatchTotalCostLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblBatchTotalCostLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBatchTotalCostLbl.Location = New System.Drawing.Point(339, 114)
            Me.lblBatchTotalCostLbl.Name = "lblBatchTotalCostLbl"
            Me.lblBatchTotalCostLbl.Size = New System.Drawing.Size(90, 13)
            Me.lblBatchTotalCostLbl.TabIndex = 211
            Me.lblBatchTotalCostLbl.Text = "Batch Total Cost:"
            '
            'adtInventionProfits
            '
            Me.adtInventionProfits.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtInventionProfits.AllowDrop = True
            Me.adtInventionProfits.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtInventionProfits.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtInventionProfits.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtInventionProfits.Columns.Add(Me.colIPDecryptor)
            Me.adtInventionProfits.Columns.Add(Me.colIPProfit)
            Me.adtInventionProfits.ExpandWidth = 0
            Me.adtInventionProfits.GridLinesColor = System.Drawing.Color.Gainsboro
            Me.adtInventionProfits.GridRowLines = True
            
            Me.adtInventionProfits.Location = New System.Drawing.Point(602, 4)
            Me.adtInventionProfits.Name = "adtInventionProfits"
            Me.adtInventionProfits.NodesConnector = Me.NodeConnector2
            Me.adtInventionProfits.NodeStyle = Me.ElementStyle2
            Me.adtInventionProfits.PathSeparator = ";"
            Me.adtInventionProfits.Size = New System.Drawing.Size(228, 222)
            Me.adtInventionProfits.Styles.Add(Me.ElementStyle2)
            Me.adtInventionProfits.TabIndex = 210
            Me.adtInventionProfits.Text = "AdvTree1"
            '
            'colIPDecryptor
            '
            Me.colIPDecryptor.Name = "colIPDecryptor"
            Me.colIPDecryptor.SortingEnabled = False
            Me.colIPDecryptor.Text = "Decryptor"
            Me.colIPDecryptor.Width.Absolute = 90
            '
            'colIPProfit
            '
            Me.colIPProfit.Name = "colIPProfit"
            Me.colIPProfit.SortingEnabled = False
            Me.colIPProfit.Text = "Unit/Total Profit"
            Me.colIPProfit.Width.Absolute = 125
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
            'lblTotalInventionProfit
            '
            Me.lblTotalInventionProfit.AutoSize = True
            Me.lblTotalInventionProfit.BackColor = System.Drawing.Color.Transparent
            Me.lblTotalInventionProfit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalInventionProfit.Location = New System.Drawing.Point(455, 166)
            Me.lblTotalInventionProfit.Name = "lblTotalInventionProfit"
            Me.lblTotalInventionProfit.Size = New System.Drawing.Size(30, 13)
            Me.lblTotalInventionProfit.TabIndex = 204
            Me.lblTotalInventionProfit.Text = "0 Isk"
            '
            'lblTotalInventionProfitLbl
            '
            Me.lblTotalInventionProfitLbl.AutoSize = True
            Me.lblTotalInventionProfitLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblTotalInventionProfitLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalInventionProfitLbl.Location = New System.Drawing.Point(339, 166)
            Me.lblTotalInventionProfitLbl.Name = "lblTotalInventionProfitLbl"
            Me.lblTotalInventionProfitLbl.Size = New System.Drawing.Size(64, 13)
            Me.lblTotalInventionProfitLbl.TabIndex = 203
            Me.lblTotalInventionProfitLbl.Text = "Total Profit:"
            '
            'lblUnitInventionProfit
            '
            Me.lblUnitInventionProfit.AutoSize = True
            Me.lblUnitInventionProfit.BackColor = System.Drawing.Color.Transparent
            Me.lblUnitInventionProfit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUnitInventionProfit.Location = New System.Drawing.Point(455, 153)
            Me.lblUnitInventionProfit.Name = "lblUnitInventionProfit"
            Me.lblUnitInventionProfit.Size = New System.Drawing.Size(30, 13)
            Me.lblUnitInventionProfit.TabIndex = 202
            Me.lblUnitInventionProfit.Text = "0 Isk"
            '
            'lblUnitInventionProfitLbl
            '
            Me.lblUnitInventionProfitLbl.AutoSize = True
            Me.lblUnitInventionProfitLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblUnitInventionProfitLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUnitInventionProfitLbl.Location = New System.Drawing.Point(339, 153)
            Me.lblUnitInventionProfitLbl.Name = "lblUnitInventionProfitLbl"
            Me.lblUnitInventionProfitLbl.Size = New System.Drawing.Size(78, 13)
            Me.lblUnitInventionProfitLbl.TabIndex = 201
            Me.lblUnitInventionProfitLbl.Text = "Profit per Unit:"
            '
            'lblInventionSalesPrice
            '
            Me.lblInventionSalesPrice.AutoSize = True
            Me.lblInventionSalesPrice.BackColor = System.Drawing.Color.Transparent
            Me.lblInventionSalesPrice.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInventionSalesPrice.Location = New System.Drawing.Point(455, 140)
            Me.lblInventionSalesPrice.Name = "lblInventionSalesPrice"
            Me.lblInventionSalesPrice.Size = New System.Drawing.Size(30, 13)
            Me.lblInventionSalesPrice.TabIndex = 200
            Me.lblInventionSalesPrice.Text = "0 Isk"
            '
            'lblInventionSalesPriceLbl
            '
            Me.lblInventionSalesPriceLbl.AutoSize = True
            Me.lblInventionSalesPriceLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblInventionSalesPriceLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInventionSalesPriceLbl.Location = New System.Drawing.Point(339, 140)
            Me.lblInventionSalesPriceLbl.Name = "lblInventionSalesPriceLbl"
            Me.lblInventionSalesPriceLbl.Size = New System.Drawing.Size(84, 13)
            Me.lblInventionSalesPriceLbl.TabIndex = 199
            Me.lblInventionSalesPriceLbl.Text = "Unit Sales Price:"
            '
            'lblAvgInventionCost
            '
            Me.lblAvgInventionCost.AutoSize = True
            Me.lblAvgInventionCost.BackColor = System.Drawing.Color.Transparent
            Me.lblAvgInventionCost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblAvgInventionCost.Location = New System.Drawing.Point(455, 127)
            Me.lblAvgInventionCost.Name = "lblAvgInventionCost"
            Me.lblAvgInventionCost.Size = New System.Drawing.Size(30, 13)
            Me.lblAvgInventionCost.TabIndex = 198
            Me.lblAvgInventionCost.Text = "0 Isk"
            '
            'lblAvgInventionCostLbl
            '
            Me.lblAvgInventionCostLbl.AutoSize = True
            Me.lblAvgInventionCostLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblAvgInventionCostLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblAvgInventionCostLbl.Location = New System.Drawing.Point(339, 127)
            Me.lblAvgInventionCostLbl.Name = "lblAvgInventionCostLbl"
            Me.lblAvgInventionCostLbl.Size = New System.Drawing.Size(82, 13)
            Me.lblAvgInventionCostLbl.TabIndex = 197
            Me.lblAvgInventionCostLbl.Text = "Unit Total Cost:"
            '
            'lblBatchProductionCost
            '
            Me.lblBatchProductionCost.AutoSize = True
            Me.lblBatchProductionCost.BackColor = System.Drawing.Color.Transparent
            Me.lblBatchProductionCost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBatchProductionCost.Location = New System.Drawing.Point(455, 101)
            Me.lblBatchProductionCost.Name = "lblBatchProductionCost"
            Me.lblBatchProductionCost.Size = New System.Drawing.Size(30, 13)
            Me.lblBatchProductionCost.TabIndex = 196
            Me.lblBatchProductionCost.Text = "0 Isk"
            '
            'lblBatchProductionCostLbl
            '
            Me.lblBatchProductionCostLbl.AutoSize = True
            Me.lblBatchProductionCostLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblBatchProductionCostLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBatchProductionCostLbl.Location = New System.Drawing.Point(339, 101)
            Me.lblBatchProductionCostLbl.Name = "lblBatchProductionCostLbl"
            Me.lblBatchProductionCostLbl.Size = New System.Drawing.Size(88, 13)
            Me.lblBatchProductionCostLbl.TabIndex = 195
            Me.lblBatchProductionCostLbl.Text = "Batch Prod Cost:"
            '
            'nudInventionSkill2
            '
            '
            '
            '
            Me.nudInventionSkill2.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.nudInventionSkill2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.nudInventionSkill2.ButtonCustom.Text = "Reset"
            Me.nudInventionSkill2.ButtonCustom.Visible = True
            Me.nudInventionSkill2.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.nudInventionSkill2.Location = New System.Drawing.Point(218, 97)
            Me.nudInventionSkill2.LockUpdateChecked = False
            Me.nudInventionSkill2.MaxValue = 5
            Me.nudInventionSkill2.MinValue = 0
            Me.nudInventionSkill2.Name = "nudInventionSkill2"
            Me.nudInventionSkill2.ShowCheckBox = True
            Me.nudInventionSkill2.ShowUpDown = True
            Me.nudInventionSkill2.Size = New System.Drawing.Size(104, 21)
            Me.nudInventionSkill2.TabIndex = 194
            Me.nudInventionSkill2.Value = 5
            Me.nudInventionSkill2.WatermarkEnabled = False
            '
            'nudInventionSkill3
            '
            '
            '
            '
            Me.nudInventionSkill3.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.nudInventionSkill3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.nudInventionSkill3.ButtonCustom.Text = "Reset"
            Me.nudInventionSkill3.ButtonCustom.Visible = True
            Me.nudInventionSkill3.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.nudInventionSkill3.Location = New System.Drawing.Point(218, 119)
            Me.nudInventionSkill3.LockUpdateChecked = False
            Me.nudInventionSkill3.MaxValue = 5
            Me.nudInventionSkill3.MinValue = 0
            Me.nudInventionSkill3.Name = "nudInventionSkill3"
            Me.nudInventionSkill3.ShowCheckBox = True
            Me.nudInventionSkill3.ShowUpDown = True
            Me.nudInventionSkill3.Size = New System.Drawing.Size(104, 21)
            Me.nudInventionSkill3.TabIndex = 193
            Me.nudInventionSkill3.Value = 5
            Me.nudInventionSkill3.WatermarkEnabled = False
            '
            'nudInventionSkill1
            '
            '
            '
            '
            Me.nudInventionSkill1.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.nudInventionSkill1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.nudInventionSkill1.ButtonCustom.Text = "Reset"
            Me.nudInventionSkill1.ButtonCustom.Visible = True
            Me.nudInventionSkill1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.nudInventionSkill1.Location = New System.Drawing.Point(218, 75)
            Me.nudInventionSkill1.LockUpdateChecked = False
            Me.nudInventionSkill1.MaxValue = 5
            Me.nudInventionSkill1.MinValue = 0
            Me.nudInventionSkill1.Name = "nudInventionSkill1"
            Me.nudInventionSkill1.ShowCheckBox = True
            Me.nudInventionSkill1.ShowUpDown = True
            Me.nudInventionSkill1.Size = New System.Drawing.Size(104, 21)
            Me.nudInventionSkill1.TabIndex = 192
            Me.nudInventionSkill1.Value = 5
            Me.nudInventionSkill1.WatermarkEnabled = False
            '
            'lblSuccessCost
            '
            Me.lblSuccessCost.AutoSize = True
            Me.lblSuccessCost.BackColor = System.Drawing.Color.Transparent
            Me.lblSuccessCost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSuccessCost.Location = New System.Drawing.Point(455, 79)
            Me.lblSuccessCost.Name = "lblSuccessCost"
            Me.lblSuccessCost.Size = New System.Drawing.Size(35, 13)
            Me.lblSuccessCost.TabIndex = 191
            Me.lblSuccessCost.Text = "0 Isk"
            '
            'lblSuccessCostLbl
            '
            Me.lblSuccessCostLbl.AutoSize = True
            Me.lblSuccessCostLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblSuccessCostLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSuccessCostLbl.Location = New System.Drawing.Point(339, 79)
            Me.lblSuccessCostLbl.Name = "lblSuccessCostLbl"
            Me.lblSuccessCostLbl.Size = New System.Drawing.Size(83, 13)
            Me.lblSuccessCostLbl.TabIndex = 190
            Me.lblSuccessCostLbl.Text = "Success Cost:"
            '
            'lblAvgAttempts
            '
            Me.lblAvgAttempts.AutoSize = True
            Me.lblAvgAttempts.BackColor = System.Drawing.Color.Transparent
            Me.lblAvgAttempts.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblAvgAttempts.Location = New System.Drawing.Point(4, 169)
            Me.lblAvgAttempts.Name = "lblAvgAttempts"
            Me.lblAvgAttempts.Size = New System.Drawing.Size(164, 13)
            Me.lblAvgAttempts.TabIndex = 189
            Me.lblAvgAttempts.Text = "Average Attempts Until Success:"
            '
            'lblInventionBPCCost
            '
            Me.lblInventionBPCCost.AutoSize = True
            Me.lblInventionBPCCost.BackColor = System.Drawing.Color.Transparent
            Me.lblInventionBPCCost.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lblInventionBPCCost.Location = New System.Drawing.Point(455, 43)
            Me.lblInventionBPCCost.Name = "lblInventionBPCCost"
            Me.lblInventionBPCCost.Size = New System.Drawing.Size(30, 13)
            Me.SuperTooltip1.SetSuperTooltip(Me.lblInventionBPCCost, New DevComponents.DotNetBar.SuperTooltipInfo("BPC Cost", "Click to edit this specific BPC Cost", "The BPC Cost is based on the minimum and maximum run prices set in the Prism Cost" &
            "s screen. The number of runs of the BPC used is taken into account when calculat" &
            "ing the final cost.", Global.EveHQ.Prism.My.Resources.Resources.Question32, Global.EveHQ.Prism.My.Resources.Resources.Info32, DevComponents.DotNetBar.eTooltipColor.Yellow))
            Me.lblInventionBPCCost.TabIndex = 188
            Me.lblInventionBPCCost.TabStop = True
            Me.lblInventionBPCCost.Text = "0 Isk"
            '
            'lblInventionBPCCostLbl
            '
            Me.lblInventionBPCCostLbl.AutoSize = True
            Me.lblInventionBPCCostLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblInventionBPCCostLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lblInventionBPCCostLbl.Location = New System.Drawing.Point(339, 43)
            Me.lblInventionBPCCostLbl.Name = "lblInventionBPCCostLbl"
            Me.lblInventionBPCCostLbl.Size = New System.Drawing.Size(55, 13)
            Me.SuperTooltip1.SetSuperTooltip(Me.lblInventionBPCCostLbl, New DevComponents.DotNetBar.SuperTooltipInfo("BPC Costs", "Click to edit BPC Costs", "The BPC Cost is based on the minimum and maximum run prices set in the Prism Cost" &
            "s screen. The number of runs of the BPC used is taken into account when calculat" &
            "ing the final cost.", Global.EveHQ.Prism.My.Resources.Resources.Question32, Global.EveHQ.Prism.My.Resources.Resources.Info32, DevComponents.DotNetBar.eTooltipColor.Yellow))
            Me.lblInventionBPCCostLbl.TabIndex = 187
            Me.lblInventionBPCCostLbl.TabStop = True
            Me.lblInventionBPCCostLbl.Text = "BPC Cost:"
            '
            'lblInventedBP
            '
            Me.lblInventedBP.AutoSize = True
            Me.lblInventedBP.BackColor = System.Drawing.Color.Transparent
            Me.lblInventedBP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInventedBP.Location = New System.Drawing.Point(119, 182)
            Me.lblInventedBP.Name = "lblInventedBP"
            Me.lblInventedBP.Size = New System.Drawing.Size(73, 13)
            Me.lblInventedBP.TabIndex = 186
            Me.lblInventedBP.Text = "<not known>"
            '
            'lblInventionDecryptorCost
            '
            Me.lblInventionDecryptorCost.AutoSize = True
            Me.lblInventionDecryptorCost.BackColor = System.Drawing.Color.Transparent
            Me.lblInventionDecryptorCost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInventionDecryptorCost.Location = New System.Drawing.Point(455, 17)
            Me.lblInventionDecryptorCost.Name = "lblInventionDecryptorCost"
            Me.lblInventionDecryptorCost.Size = New System.Drawing.Size(30, 13)
            Me.lblInventionDecryptorCost.TabIndex = 185
            Me.lblInventionDecryptorCost.Text = "0 Isk"
            '
            'lblInventionLabCosts
            '
            Me.lblInventionLabCosts.AutoSize = True
            Me.lblInventionLabCosts.BackColor = System.Drawing.Color.Transparent
            Me.lblInventionLabCosts.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInventionLabCosts.Location = New System.Drawing.Point(455, 30)
            Me.lblInventionLabCosts.Name = "lblInventionLabCosts"
            Me.lblInventionLabCosts.Size = New System.Drawing.Size(30, 13)
            Me.lblInventionLabCosts.TabIndex = 183
            Me.lblInventionLabCosts.Text = "0 Isk"
            '
            'lblInventionCost
            '
            Me.lblInventionCost.AutoSize = True
            Me.lblInventionCost.BackColor = System.Drawing.Color.Transparent
            Me.lblInventionCost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInventionCost.Location = New System.Drawing.Point(455, 56)
            Me.lblInventionCost.Name = "lblInventionCost"
            Me.lblInventionCost.Size = New System.Drawing.Size(30, 13)
            Me.lblInventionCost.TabIndex = 182
            Me.lblInventionCost.Text = "0 Isk"
            '
            'lblInventionBaseCost
            '
            Me.lblInventionBaseCost.AutoSize = True
            Me.lblInventionBaseCost.BackColor = System.Drawing.Color.Transparent
            Me.lblInventionBaseCost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInventionBaseCost.Location = New System.Drawing.Point(455, 4)
            Me.lblInventionBaseCost.Name = "lblInventionBaseCost"
            Me.lblInventionBaseCost.Size = New System.Drawing.Size(30, 13)
            Me.lblInventionBaseCost.TabIndex = 181
            Me.lblInventionBaseCost.Text = "0 Isk"
            '
            'lblInventionLabCostsLbl
            '
            Me.lblInventionLabCostsLbl.AutoSize = True
            Me.lblInventionLabCostsLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblInventionLabCostsLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lblInventionLabCostsLbl.Location = New System.Drawing.Point(339, 30)
            Me.lblInventionLabCostsLbl.Name = "lblInventionLabCostsLbl"
            Me.lblInventionLabCostsLbl.Size = New System.Drawing.Size(58, 13)
            Me.SuperTooltip1.SetSuperTooltip(Me.lblInventionLabCostsLbl, New DevComponents.DotNetBar.SuperTooltipInfo("Lab Costs", "Click to edit Lab Costs", "Lab Costs comprise of two components: an amount for the original installation and" &
            " a cost per hour running cost.", Global.EveHQ.Prism.My.Resources.Resources.Question32, Global.EveHQ.Prism.My.Resources.Resources.Info32, DevComponents.DotNetBar.eTooltipColor.Yellow))
            Me.lblInventionLabCostsLbl.TabIndex = 180
            Me.lblInventionLabCostsLbl.TabStop = True
            Me.lblInventionLabCostsLbl.Text = "Lab Costs:"
            '
            'lblOverrideBPCRuns
            '
            Me.lblOverrideBPCRuns.AutoSize = True
            Me.lblOverrideBPCRuns.BackColor = System.Drawing.Color.Transparent
            Me.lblOverrideBPCRuns.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOverrideBPCRuns.Location = New System.Drawing.Point(3, 61)
            Me.lblOverrideBPCRuns.Name = "lblOverrideBPCRuns"
            Me.lblOverrideBPCRuns.Size = New System.Drawing.Size(102, 13)
            Me.lblOverrideBPCRuns.TabIndex = 179
            Me.lblOverrideBPCRuns.Text = "Override BPC Runs:"
            '
            'lblBlueprintInventions
            '
            Me.lblBlueprintInventions.AutoSize = True
            Me.lblBlueprintInventions.BackColor = System.Drawing.Color.Transparent
            Me.lblBlueprintInventions.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBlueprintInventions.Location = New System.Drawing.Point(3, 12)
            Me.lblBlueprintInventions.Name = "lblBlueprintInventions"
            Me.lblBlueprintInventions.Size = New System.Drawing.Size(62, 13)
            Me.lblBlueprintInventions.TabIndex = 178
            Me.lblBlueprintInventions.Text = "Inventions:"
            '
            'lblDecryptor
            '
            Me.lblDecryptor.AutoSize = True
            Me.lblDecryptor.BackColor = System.Drawing.Color.Transparent
            Me.lblDecryptor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDecryptor.Location = New System.Drawing.Point(3, 34)
            Me.lblDecryptor.Name = "lblDecryptor"
            Me.lblDecryptor.Size = New System.Drawing.Size(59, 13)
            Me.lblDecryptor.TabIndex = 176
            Me.lblDecryptor.Text = "Decryptor:"
            '
            'lblBaseChance
            '
            Me.lblBaseChance.AutoSize = True
            Me.lblBaseChance.BackColor = System.Drawing.Color.Transparent
            Me.lblBaseChance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBaseChance.Location = New System.Drawing.Point(4, 143)
            Me.lblBaseChance.Name = "lblBaseChance"
            Me.lblBaseChance.Size = New System.Drawing.Size(122, 13)
            Me.lblBaseChance.TabIndex = 175
            Me.lblBaseChance.Text = "Base Invention Chance:"
            '
            'lblInvSkill2
            '
            Me.lblInvSkill2.AutoSize = True
            Me.lblInvSkill2.BackColor = System.Drawing.Color.Transparent
            Me.lblInvSkill2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInvSkill2.Location = New System.Drawing.Point(3, 105)
            Me.lblInvSkill2.Name = "lblInvSkill2"
            Me.lblInvSkill2.Size = New System.Drawing.Size(86, 13)
            Me.lblInvSkill2.TabIndex = 174
            Me.lblInvSkill2.Text = "Invention Skill 2:"
            '
            'lblInvSkill3
            '
            Me.lblInvSkill3.AutoSize = True
            Me.lblInvSkill3.BackColor = System.Drawing.Color.Transparent
            Me.lblInvSkill3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInvSkill3.Location = New System.Drawing.Point(3, 127)
            Me.lblInvSkill3.Name = "lblInvSkill3"
            Me.lblInvSkill3.Size = New System.Drawing.Size(86, 13)
            Me.lblInvSkill3.TabIndex = 173
            Me.lblInvSkill3.Text = "Invention Skill 3:"
            '
            'lblInvSkill1
            '
            Me.lblInvSkill1.AutoSize = True
            Me.lblInvSkill1.BackColor = System.Drawing.Color.Transparent
            Me.lblInvSkill1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInvSkill1.Location = New System.Drawing.Point(3, 83)
            Me.lblInvSkill1.Name = "lblInvSkill1"
            Me.lblInvSkill1.Size = New System.Drawing.Size(86, 13)
            Me.lblInvSkill1.TabIndex = 172
            Me.lblInvSkill1.Text = "Invention Skill 1:"
            '
            'lblInventionCostLbl
            '
            Me.lblInventionCostLbl.AutoSize = True
            Me.lblInventionCostLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblInventionCostLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInventionCostLbl.Location = New System.Drawing.Point(339, 56)
            Me.lblInventionCostLbl.Name = "lblInventionCostLbl"
            Me.lblInventionCostLbl.Size = New System.Drawing.Size(60, 13)
            Me.lblInventionCostLbl.TabIndex = 171
            Me.lblInventionCostLbl.Text = "Total Cost:"
            '
            'lblInventionDecryptorCostLbl
            '
            Me.lblInventionDecryptorCostLbl.AutoSize = True
            Me.lblInventionDecryptorCostLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblInventionDecryptorCostLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInventionDecryptorCostLbl.Location = New System.Drawing.Point(339, 17)
            Me.lblInventionDecryptorCostLbl.Name = "lblInventionDecryptorCostLbl"
            Me.lblInventionDecryptorCostLbl.Size = New System.Drawing.Size(84, 13)
            Me.lblInventionDecryptorCostLbl.TabIndex = 169
            Me.lblInventionDecryptorCostLbl.Text = "Decryptor Cost:"
            '
            'lblInventionBaseCostLbl
            '
            Me.lblInventionBaseCostLbl.AutoSize = True
            Me.lblInventionBaseCostLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblInventionBaseCostLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInventionBaseCostLbl.Location = New System.Drawing.Point(339, 4)
            Me.lblInventionBaseCostLbl.Name = "lblInventionBaseCostLbl"
            Me.lblInventionBaseCostLbl.Size = New System.Drawing.Size(59, 13)
            Me.lblInventionBaseCostLbl.TabIndex = 168
            Me.lblInventionBaseCostLbl.Text = "Base Cost:"
            '
            'lblInventedBPLbl
            '
            Me.lblInventedBPLbl.AutoSize = True
            Me.lblInventedBPLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblInventedBPLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInventedBPLbl.Location = New System.Drawing.Point(4, 182)
            Me.lblInventedBPLbl.Name = "lblInventedBPLbl"
            Me.lblInventedBPLbl.Size = New System.Drawing.Size(105, 13)
            Me.lblInventedBPLbl.TabIndex = 167
            Me.lblInventedBPLbl.Text = "Invented BP Details:"
            '
            'lblInventionChance
            '
            Me.lblInventionChance.AutoSize = True
            Me.lblInventionChance.BackColor = System.Drawing.Color.Transparent
            Me.lblInventionChance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInventionChance.Location = New System.Drawing.Point(4, 156)
            Me.lblInventionChance.Name = "lblInventionChance"
            Me.lblInventionChance.Size = New System.Drawing.Size(123, 13)
            Me.lblInventionChance.TabIndex = 166
            Me.lblInventionChance.Text = "Chance of Invention:"
            '
            'lblInventionTime
            '
            Me.lblInventionTime.AutoSize = True
            Me.lblInventionTime.BackColor = System.Drawing.Color.Transparent
            Me.lblInventionTime.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInventionTime.Location = New System.Drawing.Point(119, 195)
            Me.lblInventionTime.Name = "lblInventionTime"
            Me.lblInventionTime.Size = New System.Drawing.Size(18, 13)
            Me.lblInventionTime.TabIndex = 165
            Me.lblInventionTime.Text = "0s"
            '
            'lblInventionTimeLbl
            '
            Me.lblInventionTimeLbl.AutoSize = True
            Me.lblInventionTimeLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblInventionTimeLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInventionTimeLbl.Location = New System.Drawing.Point(4, 196)
            Me.lblInventionTimeLbl.Name = "lblInventionTimeLbl"
            Me.lblInventionTimeLbl.Size = New System.Drawing.Size(82, 13)
            Me.lblInventionTimeLbl.TabIndex = 164
            Me.lblInventionTimeLbl.Text = "Invention Time:"
            '
            'nudInventionBPCRuns
            '
            '
            '
            '
            Me.nudInventionBPCRuns.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.nudInventionBPCRuns.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.nudInventionBPCRuns.ButtonCustom.Text = "Set Max"
            Me.nudInventionBPCRuns.ButtonCustom.Visible = True
            Me.nudInventionBPCRuns.ButtonCustom2.Text = "Set Min"
            Me.nudInventionBPCRuns.ButtonCustom2.Visible = True
            Me.nudInventionBPCRuns.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.nudInventionBPCRuns.Location = New System.Drawing.Point(151, 53)
            Me.nudInventionBPCRuns.LockUpdateChecked = False
            Me.nudInventionBPCRuns.MaxValue = 1500
            Me.nudInventionBPCRuns.MinValue = 1
            Me.nudInventionBPCRuns.Name = "nudInventionBPCRuns"
            Me.nudInventionBPCRuns.ShowCheckBox = True
            Me.nudInventionBPCRuns.ShowUpDown = True
            Me.nudInventionBPCRuns.Size = New System.Drawing.Size(171, 21)
            Me.nudInventionBPCRuns.TabIndex = 162
            Me.nudInventionBPCRuns.Value = 1
            Me.nudInventionBPCRuns.WatermarkEnabled = False
            '
            'cboDecryptor
            '
            Me.cboDecryptor.DisplayMember = "Text"
            Me.cboDecryptor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboDecryptor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboDecryptor.FormattingEnabled = True
            Me.cboDecryptor.ItemHeight = 15
            Me.cboDecryptor.Location = New System.Drawing.Point(69, 26)
            Me.cboDecryptor.Name = "cboDecryptor"
            Me.cboDecryptor.Size = New System.Drawing.Size(253, 21)
            Me.cboDecryptor.Sorted = True
            Me.cboDecryptor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboDecryptor.TabIndex = 2
            Me.cboDecryptor.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
            Me.cboDecryptor.WatermarkColor = System.Drawing.Color.Silver
            Me.cboDecryptor.WatermarkText = "Select a Decryptor to use..."
            '
            'cboInventions
            '
            Me.cboInventions.DisplayMember = "Text"
            Me.cboInventions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboInventions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboInventions.FormattingEnabled = True
            Me.cboInventions.ItemHeight = 15
            Me.cboInventions.Location = New System.Drawing.Point(69, 4)
            Me.cboInventions.Name = "cboInventions"
            Me.cboInventions.Size = New System.Drawing.Size(253, 21)
            Me.cboInventions.Sorted = True
            Me.cboInventions.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboInventions.TabIndex = 1
            Me.cboInventions.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
            Me.cboInventions.WatermarkColor = System.Drawing.Color.Silver
            Me.cboInventions.WatermarkText = "Select Blueprint to invent..."
            '
            'PPRInvention
            '
            Me.PPRInvention.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PPRInvention.BatchJob = Nothing
            Me.PPRInvention.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PPRInvention.InventionBP = Nothing
            Me.PPRInvention.Location = New System.Drawing.Point(0, 229)
            Me.PPRInvention.Name = "PPRInvention"
            Me.PPRInvention.ProductionJob = Nothing
            Me.PPRInvention.Size = New System.Drawing.Size(833, 296)
            Me.PPRInvention.TabIndex = 0
            '
            'PACDecryptor
            '
            Me.PACDecryptor.Location = New System.Drawing.Point(429, 18)
            Me.PACDecryptor.Name = "PACDecryptor"
            Me.PACDecryptor.Price = 0R
            Me.PACDecryptor.Size = New System.Drawing.Size(20, 12)
            Me.PACDecryptor.TabIndex = 209
            Me.PACDecryptor.TypeID = 0
            '
            'PACSalesPrice
            '
            Me.PACSalesPrice.Location = New System.Drawing.Point(429, 141)
            Me.PACSalesPrice.Name = "PACSalesPrice"
            Me.PACSalesPrice.Price = 0R
            Me.PACSalesPrice.Size = New System.Drawing.Size(20, 12)
            Me.PACSalesPrice.TabIndex = 208
            Me.PACSalesPrice.TypeID = 0
            '
            'tiInvention
            '
            Me.tiInvention.AttachedControl = Me.tcpInvention
            Me.tiInvention.Name = "tiInvention"
            Me.tiInvention.Text = "Invention"
            Me.tiInvention.Visible = False
            '
            'tcpResearch
            '
            Me.tcpResearch.Controls.Add(Me.lblMETime)
            Me.tcpResearch.Controls.Add(Me.lblTETimeLbl)
            Me.tcpResearch.Controls.Add(Me.chkAdvancedLab)
            Me.tcpResearch.Controls.Add(Me.lblTETime)
            Me.tcpResearch.Controls.Add(Me.chkResearchAtPOS)
            Me.tcpResearch.Controls.Add(Me.lblMETimeLbl)
            Me.tcpResearch.Controls.Add(Me.lblBPCopyTimeLbl)
            Me.tcpResearch.Controls.Add(Me.lblCopyTime)
            Me.tcpResearch.DisabledBackColor = System.Drawing.Color.Empty
            Me.tcpResearch.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcpResearch.Location = New System.Drawing.Point(0, 23)
            Me.tcpResearch.Name = "tcpResearch"
            Me.tcpResearch.Padding = New System.Windows.Forms.Padding(1)
            Me.tcpResearch.Size = New System.Drawing.Size(836, 525)
            Me.tcpResearch.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.tcpResearch.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.tcpResearch.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.tcpResearch.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
            Me.tcpResearch.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.tcpResearch.Style.GradientAngle = 90
            Me.tcpResearch.TabIndex = 1
            Me.tcpResearch.TabItem = Me.tiResearch
            '
            'chkAdvancedLab
            '
            Me.chkAdvancedLab.AutoSize = True
            Me.chkAdvancedLab.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.chkAdvancedLab.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkAdvancedLab.Enabled = False
            Me.chkAdvancedLab.Location = New System.Drawing.Point(160, 13)
            Me.chkAdvancedLab.Name = "chkAdvancedLab"
            Me.chkAdvancedLab.Size = New System.Drawing.Size(126, 16)
            Me.chkAdvancedLab.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkAdvancedLab.TabIndex = 33
            Me.chkAdvancedLab.Text = "Advanced Lab (Copy)"
            '
            'chkResearchAtPOS
            '
            Me.chkResearchAtPOS.AutoSize = True
            Me.chkResearchAtPOS.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.chkResearchAtPOS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkResearchAtPOS.Location = New System.Drawing.Point(20, 13)
            Me.chkResearchAtPOS.Name = "chkResearchAtPOS"
            Me.chkResearchAtPOS.Size = New System.Drawing.Size(108, 16)
            Me.chkResearchAtPOS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkResearchAtPOS.TabIndex = 32
            Me.chkResearchAtPOS.Text = "Research at POS?"
            '
            'tiResearch
            '
            Me.tiResearch.AttachedControl = Me.tcpResearch
            Me.tiResearch.Name = "tiResearch"
            Me.tiResearch.Text = "Research"
            '
            'tcpProduction
            '
            Me.tcpProduction.Controls.Add(Me.stnMeBonus)
            Me.tcpProduction.Controls.Add(Me.Label1)
            Me.tcpProduction.Controls.Add(Me.lblProfitMarkup)
            Me.tcpProduction.Controls.Add(Me.lblProfitMargin)
            Me.tcpProduction.Controls.Add(Me.lblProfitMarkupLbl)
            Me.tcpProduction.Controls.Add(Me.lblProfitMarginLbl)
            Me.tcpProduction.Controls.Add(Me.lblProdQuantity)
            Me.tcpProduction.Controls.Add(Me.lblBatchSize)
            Me.tcpProduction.Controls.Add(Me.lblFactoryCostsLbl)
            Me.tcpProduction.Controls.Add(Me.nudRuns)
            Me.tcpProduction.Controls.Add(Me.chkPOSProduction)
            Me.tcpProduction.Controls.Add(Me.lblUnitBuildCostsLbl)
            Me.tcpProduction.Controls.Add(Me.lblTotalBuildCostsLbl)
            Me.tcpProduction.Controls.Add(Me.cboPOSArrays)
            Me.tcpProduction.Controls.Add(Me.cboFactoryLocation)
            Me.tcpProduction.Controls.Add(Me.lblTotalBuildTime)
            Me.tcpProduction.Controls.Add(Me.lblUnitBuildCost)
            Me.tcpProduction.Controls.Add(Me.lblProfitRate)
            Me.tcpProduction.Controls.Add(Me.lblUnitBuildTime)
            Me.tcpProduction.Controls.Add(Me.lblTotalBuildCost)
            Me.tcpProduction.Controls.Add(Me.lblProfitRateLbl)
            Me.tcpProduction.Controls.Add(Me.lblTotalBuildTimeLbl)
            Me.tcpProduction.Controls.Add(Me.lblUnitProfit)
            Me.tcpProduction.Controls.Add(Me.lblUnitProfitlbl)
            Me.tcpProduction.Controls.Add(Me.lblBatchSizeLbl)
            Me.tcpProduction.Controls.Add(Me.lblFactoryCosts)
            Me.tcpProduction.Controls.Add(Me.lblUnitValue)
            Me.tcpProduction.Controls.Add(Me.lblUnitValuelbl)
            Me.tcpProduction.Controls.Add(Me.lblTotalCostsLbl)
            Me.tcpProduction.Controls.Add(Me.lblUnitBuildTimeLbl)
            Me.tcpProduction.Controls.Add(Me.lblUnitCost)
            Me.tcpProduction.Controls.Add(Me.lblTotalCosts)
            Me.tcpProduction.Controls.Add(Me.lblRuns)
            Me.tcpProduction.Controls.Add(Me.lblUnitCostLbl)
            Me.tcpProduction.Controls.Add(Me.lblProdQuantityLbl)
            Me.tcpProduction.Controls.Add(Me.PACUnitValue)
            Me.tcpProduction.Controls.Add(Me.PPRProduction)
            Me.tcpProduction.DisabledBackColor = System.Drawing.Color.Empty
            Me.tcpProduction.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcpProduction.Location = New System.Drawing.Point(0, 23)
            Me.tcpProduction.Name = "tcpProduction"
            Me.tcpProduction.Padding = New System.Windows.Forms.Padding(1)
            Me.tcpProduction.Size = New System.Drawing.Size(836, 525)
            Me.tcpProduction.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.tcpProduction.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.tcpProduction.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.tcpProduction.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
            Me.tcpProduction.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.tcpProduction.Style.GradientAngle = 90
            Me.tcpProduction.TabIndex = 2
            Me.tcpProduction.TabItem = Me.tiProduction
            '
            'lblProfitMarkup
            '
            Me.lblProfitMarkup.AutoSize = True
            Me.lblProfitMarkup.BackColor = System.Drawing.Color.Transparent
            Me.lblProfitMarkup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProfitMarkup.Location = New System.Drawing.Point(709, 138)
            Me.lblProfitMarkup.Name = "lblProfitMarkup"
            Me.lblProfitMarkup.Size = New System.Drawing.Size(27, 13)
            Me.lblProfitMarkup.TabIndex = 213
            Me.lblProfitMarkup.Text = "0 %"
            '
            'lblProfitMargin
            '
            Me.lblProfitMargin.AutoSize = True
            Me.lblProfitMargin.BackColor = System.Drawing.Color.Transparent
            Me.lblProfitMargin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProfitMargin.Location = New System.Drawing.Point(709, 125)
            Me.lblProfitMargin.Name = "lblProfitMargin"
            Me.lblProfitMargin.Size = New System.Drawing.Size(27, 13)
            Me.lblProfitMargin.TabIndex = 212
            Me.lblProfitMargin.Text = "0 %"
            '
            'lblProfitMarkupLbl
            '
            Me.lblProfitMarkupLbl.AutoSize = True
            Me.lblProfitMarkupLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblProfitMarkupLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProfitMarkupLbl.Location = New System.Drawing.Point(618, 138)
            Me.lblProfitMarkupLbl.Name = "lblProfitMarkupLbl"
            Me.lblProfitMarkupLbl.Size = New System.Drawing.Size(75, 13)
            Me.lblProfitMarkupLbl.TabIndex = 211
            Me.lblProfitMarkupLbl.Text = "Profit Markup:"
            '
            'lblProfitMarginLbl
            '
            Me.lblProfitMarginLbl.AutoSize = True
            Me.lblProfitMarginLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblProfitMarginLbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProfitMarginLbl.Location = New System.Drawing.Point(618, 125)
            Me.lblProfitMarginLbl.Name = "lblProfitMarginLbl"
            Me.lblProfitMarginLbl.Size = New System.Drawing.Size(72, 13)
            Me.lblProfitMarginLbl.TabIndex = 210
            Me.lblProfitMarginLbl.Text = "Profit Margin:"
            '
            'lblProdQuantity
            '
            Me.lblProdQuantity.AutoSize = True
            Me.lblProdQuantity.BackColor = System.Drawing.Color.Transparent
            Me.lblProdQuantity.Location = New System.Drawing.Point(123, 138)
            Me.lblProdQuantity.Name = "lblProdQuantity"
            Me.lblProdQuantity.Size = New System.Drawing.Size(13, 13)
            Me.lblProdQuantity.TabIndex = 183
            Me.lblProdQuantity.Text = "1"
            '
            'lblBatchSize
            '
            Me.lblBatchSize.AutoSize = True
            Me.lblBatchSize.BackColor = System.Drawing.Color.Transparent
            Me.lblBatchSize.Location = New System.Drawing.Point(123, 115)
            Me.lblBatchSize.Name = "lblBatchSize"
            Me.lblBatchSize.Size = New System.Drawing.Size(13, 13)
            Me.lblBatchSize.TabIndex = 182
            Me.lblBatchSize.Text = "1"
            '
            'lblFactoryCostsLbl
            '
            Me.lblFactoryCostsLbl.AutoSize = True
            Me.lblFactoryCostsLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblFactoryCostsLbl.Location = New System.Drawing.Point(272, 69)
            Me.lblFactoryCostsLbl.Name = "lblFactoryCostsLbl"
            Me.lblFactoryCostsLbl.Size = New System.Drawing.Size(78, 13)
            Me.lblFactoryCostsLbl.TabIndex = 181
            Me.lblFactoryCostsLbl.TabStop = True
            Me.lblFactoryCostsLbl.Text = "Factory Costs:"
            '
            'nudRuns
            '
            '
            '
            '
            Me.nudRuns.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.nudRuns.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.nudRuns.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.nudRuns.Location = New System.Drawing.Point(119, 89)
            Me.nudRuns.MaxValue = 1500
            Me.nudRuns.MinValue = 1
            Me.nudRuns.Name = "nudRuns"
            Me.nudRuns.ShowUpDown = True
            Me.nudRuns.Size = New System.Drawing.Size(93, 21)
            Me.nudRuns.TabIndex = 180
            Me.nudRuns.Value = 1
            '
            'chkPOSProduction
            '
            Me.chkPOSProduction.AutoSize = True
            Me.chkPOSProduction.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.chkPOSProduction.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkPOSProduction.Location = New System.Drawing.Point(9, 13)
            Me.chkPOSProduction.Name = "chkPOSProduction"
            Me.chkPOSProduction.Size = New System.Drawing.Size(165, 16)
            Me.chkPOSProduction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkPOSProduction.TabIndex = 176
            Me.chkPOSProduction.Text = "Use POS Array for production"
            '
            'cboPOSArrays
            '
            Me.cboPOSArrays.DisplayMember = "Text"
            Me.cboPOSArrays.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboPOSArrays.Enabled = False
            Me.cboPOSArrays.FormattingEnabled = True
            Me.cboPOSArrays.ItemHeight = 15
            Me.cboPOSArrays.Location = New System.Drawing.Point(9, 35)
            Me.cboPOSArrays.Name = "cboPOSArrays"
            Me.cboPOSArrays.Size = New System.Drawing.Size(224, 21)
            Me.cboPOSArrays.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboPOSArrays.TabIndex = 177
            Me.cboPOSArrays.WatermarkFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboPOSArrays.WatermarkText = "Select your POS array..."
            '
            'cboFactoryLocation
            '
            Me.cboFactoryLocation.DisplayMember = "Text"
            Me.cboFactoryLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboFactoryLocation.Enabled = True
            Me.cboFactoryLocation.FormattingEnabled = True
            Me.cboFactoryLocation.ItemHeight = 15
            Me.cboFactoryLocation.Location = New System.Drawing.Point(9, 61)
            Me.cboFactoryLocation.Name = "cboFactoryLocation"
            Me.cboFactoryLocation.Size = New System.Drawing.Size(224, 21)
            Me.cboFactoryLocation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboFactoryLocation.TabIndex = 50100
            Me.cboFactoryLocation.WatermarkFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboFactoryLocation.WatermarkText = "Select your factory location..."
            '
            'PACUnitValue
            '
            Me.PACUnitValue.Location = New System.Drawing.Point(381, 113)
            Me.PACUnitValue.Name = "PACUnitValue"
            Me.PACUnitValue.Price = 0R
            Me.PACUnitValue.Size = New System.Drawing.Size(20, 12)
            Me.PACUnitValue.TabIndex = 209
            Me.PACUnitValue.TypeID = 0
            '
            'PPRProduction
            '
            Me.PPRProduction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PPRProduction.BatchJob = Nothing
            Me.PPRProduction.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PPRProduction.InventionBP = Nothing
            Me.PPRProduction.Location = New System.Drawing.Point(0, 163)
            Me.PPRProduction.Name = "PPRProduction"
            Me.PPRProduction.ProductionJob = Nothing
            Me.PPRProduction.Size = New System.Drawing.Size(836, 362)
            Me.PPRProduction.TabIndex = 0
            '
            'tiProduction
            '
            Me.tiProduction.AttachedControl = Me.tcpProduction
            Me.tiProduction.Name = "tiProduction"
            Me.tiProduction.Text = "Production"
            '
            'nudTELevel
            '
            '
            '
            '
            Me.nudTELevel.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.nudTELevel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.nudTELevel.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.nudTELevel.Increment = 2
            Me.nudTELevel.Location = New System.Drawing.Point(275, 160)
            Me.nudTELevel.MaxValue = 20
            Me.nudTELevel.MinValue = 0
            Me.nudTELevel.Name = "nudTELevel"
            Me.nudTELevel.ShowUpDown = True
            Me.nudTELevel.Size = New System.Drawing.Size(80, 21)
            Me.nudTELevel.TabIndex = 35
            '
            'btnSaveProductionJobAs
            '
            Me.btnSaveProductionJobAs.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnSaveProductionJobAs.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnSaveProductionJobAs.Location = New System.Drawing.Point(759, 12)
            Me.btnSaveProductionJobAs.Name = "btnSaveProductionJobAs"
            Me.btnSaveProductionJobAs.Size = New System.Drawing.Size(56, 56)
            Me.btnSaveProductionJobAs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnSaveProductionJobAs.TabIndex = 185
            Me.btnSaveProductionJobAs.Text = "Save Job As..."
            '
            'nudMELevel
            '
            '
            '
            '
            Me.nudMELevel.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.nudMELevel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.nudMELevel.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.nudMELevel.Location = New System.Drawing.Point(90, 160)
            Me.nudMELevel.MaxValue = 10
            Me.nudMELevel.MinValue = 0
            Me.nudMELevel.Name = "nudMELevel"
            Me.nudMELevel.ShowUpDown = True
            Me.nudMELevel.Size = New System.Drawing.Size(80, 21)
            Me.nudMELevel.TabIndex = 34
            '
            'btnSaveProductionJob
            '
            Me.btnSaveProductionJob.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnSaveProductionJob.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnSaveProductionJob.Enabled = False
            Me.btnSaveProductionJob.Location = New System.Drawing.Point(759, 74)
            Me.btnSaveProductionJob.Name = "btnSaveProductionJob"
            Me.btnSaveProductionJob.Size = New System.Drawing.Size(56, 56)
            Me.btnSaveProductionJob.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnSaveProductionJob.TabIndex = 184
            Me.btnSaveProductionJob.Text = "Save Job"
            '
            'btnExportToCSV
            '
            Me.btnExportToCSV.Name = "btnExportToCSV"
            Me.btnExportToCSV.Text = "New Item"
            '
            'btnExportToTSV
            '
            Me.btnExportToTSV.Name = "btnExportToTSV"
            Me.btnExportToTSV.Text = "New Item"
            '
            'SuperTooltip1
            '
            Me.SuperTooltip1.DefaultTooltipSettings = New DevComponents.DotNetBar.SuperTooltipInfo("", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray)
            
            '
            'SaveJobDialogCheckBox
            '
            Me.SaveJobDialogCheckBox.Name = "SaveJobDialogCheckBox"
            Me.SaveJobDialogCheckBox.Text = "Do not show this again"
            '
            'stnMeBonus
            '
            '
            '
            '
            Me.stnMeBonus.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.stnMeBonus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.stnMeBonus.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.stnMeBonus.Location = New System.Drawing.Point(119, 112)
            Me.stnMeBonus.MaxValue = 20
            Me.stnMeBonus.MinValue = 0
            Me.stnMeBonus.Name = "stnMeBonus"
            Me.stnMeBonus.ShowUpDown = True
            Me.stnMeBonus.Size = New System.Drawing.Size(93, 21)
            Me.stnMeBonus.TabIndex = 215
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Location = New System.Drawing.Point(10, 115)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(94, 13)
            Me.Label1.TabIndex = 214
            Me.Label1.Text = "Station ME Bonus:"
            '
            'PACUnitValue
            '
            Me.PACUnitValue.Location = New System.Drawing.Point(381, 113)
            Me.PACUnitValue.Name = "PACUnitValue"
            Me.PACUnitValue.Price = 0.0R
            Me.PACUnitValue.Size = New System.Drawing.Size(20, 12)
            Me.PACUnitValue.TabIndex = 209
            Me.PACUnitValue.TypeID = 0
            '
            'PPRProduction
            '
            Me.PPRProduction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PPRProduction.BatchJob = Nothing
            Me.PPRProduction.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PPRProduction.InventionBP = Nothing
            Me.PPRProduction.Location = New System.Drawing.Point(0, 163)
            Me.PPRProduction.Name = "PPRProduction"
            Me.PPRProduction.ProductionJob = Nothing
            Me.PPRProduction.Size = New System.Drawing.Size(836, 362)
            Me.PPRProduction.TabIndex = 0
            '
            'PPRInvention
            '
            Me.PPRInvention.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PPRInvention.BatchJob = Nothing
            Me.PPRInvention.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PPRInvention.InventionBP = Nothing
            Me.PPRInvention.Location = New System.Drawing.Point(0, 229)
            Me.PPRInvention.Name = "PPRInvention"
            Me.PPRInvention.ProductionJob = Nothing
            Me.PPRInvention.Size = New System.Drawing.Size(833, 296)
            Me.PPRInvention.TabIndex = 0
            '
            'PACDecryptor
            '
            Me.PACDecryptor.Location = New System.Drawing.Point(429, 18)
            Me.PACDecryptor.Name = "PACDecryptor"
            Me.PACDecryptor.Price = 0.0R
            Me.PACDecryptor.Size = New System.Drawing.Size(20, 12)
            Me.PACDecryptor.TabIndex = 209
            Me.PACDecryptor.TypeID = 0
            '
            'PACSalesPrice
            '
            Me.PACSalesPrice.Location = New System.Drawing.Point(429, 141)
            Me.PACSalesPrice.Name = "PACSalesPrice"
            Me.PACSalesPrice.Price = 0.0R
            Me.PACSalesPrice.Size = New System.Drawing.Size(20, 12)
            Me.PACSalesPrice.TabIndex = 208
            Me.PACSalesPrice.TypeID = 0
            '
            'FrmBPCalculator
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(125, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(842, 738)
            Me.Controls.Add(Me.PanelEx1)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MinimumSize = New System.Drawing.Size(850, 715)
            Me.Name = "FrmBPCalculator"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Blueprint Calculator"
            Me.TransparencyKey = System.Drawing.Color.LavenderBlush
            Me.PanelEx1.ResumeLayout(False)
            Me.PanelEx1.PerformLayout()
            Me.gpPilotSkills.ResumeLayout(False)
            Me.gpPilotSkills.PerformLayout()
            Me.gpProductionSkills.ResumeLayout(False)
            Me.gpProductionSkills.PerformLayout()
            Me.gpResearchSkills.ResumeLayout(False)
            Me.gpResearchSkills.PerformLayout()
            Me.gpBPSelection.ResumeLayout(False)
            Me.gpBPSelection.PerformLayout()
            CType(Me.pbBP, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCopyRuns, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabBPCalcFunctions, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabBPCalcFunctions.ResumeLayout(False)
            Me.tcpInvention.ResumeLayout(False)
            Me.tcpInvention.PerformLayout()
            CType(Me.adtInventionProfits, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudInventionSkill2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudInventionSkill3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudInventionSkill1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudInventionBPCRuns, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tcpResearch.ResumeLayout(False)
            Me.tcpResearch.PerformLayout()
            Me.tcpProduction.ResumeLayout(False)
            Me.tcpProduction.PerformLayout()
            CType(Me.nudRuns, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudTELevel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudMELevel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.stnMeBonus, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblBPMELbl As System.Windows.Forms.Label
        Friend WithEvents lblBPTELbl As System.Windows.Forms.Label
        Friend WithEvents lblBPWFLbl As System.Windows.Forms.Label
        Friend WithEvents pbBP As System.Windows.Forms.PictureBox
        Friend WithEvents lblTETimeLbl As System.Windows.Forms.Label
        Friend WithEvents lblMETimeLbl As System.Windows.Forms.Label
        Friend WithEvents lblNewMELbl As System.Windows.Forms.Label
        Friend WithEvents LblNewWFLbl As System.Windows.Forms.Label
        Friend WithEvents lblNewTELbl As System.Windows.Forms.Label
        Friend WithEvents txtNewWasteFactor As System.Windows.Forms.TextBox
        Friend WithEvents lblProdQuantityLbl As System.Windows.Forms.Label
        Friend WithEvents lblBatchSizeLbl As System.Windows.Forms.Label
        Friend WithEvents lblRuns As System.Windows.Forms.Label
        Friend WithEvents lblUnitBuildTimeLbl As System.Windows.Forms.Label
        Friend WithEvents lblTotalBuildTimeLbl As System.Windows.Forms.Label
        Friend WithEvents lblBPOMarketValueLbl As System.Windows.Forms.Label
        Friend WithEvents lblBPOMarketValue As System.Windows.Forms.Label
        Friend WithEvents lblMetallurgySkill As System.Windows.Forms.Label
        Friend WithEvents lblResearchSkill As System.Windows.Forms.Label
        Friend WithEvents lblPESkill As System.Windows.Forms.Label
        Friend WithEvents lblIndustrySkill As System.Windows.Forms.Label
        Friend WithEvents lblBPTE As System.Windows.Forms.Label
        Friend WithEvents lblBPWF As System.Windows.Forms.Label
        Friend WithEvents lblBPME As System.Windows.Forms.Label
        Friend WithEvents lblPilot As System.Windows.Forms.Label
        Friend WithEvents lblTETime As System.Windows.Forms.Label
        Friend WithEvents lblMETime As System.Windows.Forms.Label
        Friend WithEvents lblCopyTime As System.Windows.Forms.Label
        Friend WithEvents lblBPCopyTimeLbl As System.Windows.Forms.Label
        Friend WithEvents lblScienceSkill As System.Windows.Forms.Label
        Friend WithEvents lblRunsPerCopy As System.Windows.Forms.Label
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents lblUnitBuildTime As System.Windows.Forms.Label
        Friend WithEvents lblTotalBuildTime As System.Windows.Forms.Label
        Friend WithEvents lblBPRuns As System.Windows.Forms.Label
        Friend WithEvents lblBPRunsLbl As System.Windows.Forms.Label
        Friend WithEvents lblTotalBuildCost As System.Windows.Forms.Label
        Friend WithEvents lblUnitBuildCost As System.Windows.Forms.Label
        Friend WithEvents lblTotalBuildCostsLbl As System.Windows.Forms.Label
        Friend WithEvents lblUnitBuildCostsLbl As System.Windows.Forms.Label
        Friend WithEvents lblFactoryCosts As System.Windows.Forms.Label
        Friend WithEvents lblTotalCosts As System.Windows.Forms.Label
        Friend WithEvents lblTotalCostsLbl As System.Windows.Forms.Label
        Friend WithEvents lblUnitCost As System.Windows.Forms.Label
        Friend WithEvents lblUnitCostLbl As System.Windows.Forms.Label
        Friend WithEvents lblUnitValue As System.Windows.Forms.Label
        Friend WithEvents lblUnitValuelbl As System.Windows.Forms.Label
        Friend WithEvents lblUnitProfit As System.Windows.Forms.Label
        Friend WithEvents lblUnitProfitlbl As System.Windows.Forms.Label
        Friend WithEvents lblProfitRate As System.Windows.Forms.Label
        Friend WithEvents lblProfitRateLbl As System.Windows.Forms.Label
        Friend WithEvents gpBPSelection As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents cboBPs As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents chkOwnedBPOs As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents chkInventBPOs As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents gpPilotSkills As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents cboPilot As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents chkOverrideSkills As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents gpProductionSkills As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents gpResearchSkills As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents cboIndustrySkill As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents cboAdvInvSkill As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents cboScienceSkill As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents cboResearchSkill As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents cboMetallurgySkill As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents cboMetallurgyImplant As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem11 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem12 As DevComponents.Editors.ComboItem
        Friend WithEvents cboIndustryImplant As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
        Friend WithEvents cboResearchImplant As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
        Friend WithEvents cboScienceImplant As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents ComboItem13 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem14 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem15 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem16 As DevComponents.Editors.ComboItem
        Friend WithEvents chkAdvancedLab As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents chkResearchAtPOS As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents nudCopyRuns As DevComponents.Editors.IntegerInput
        Friend WithEvents nudTELevel As DevComponents.Editors.IntegerInput
        Friend WithEvents nudMELevel As DevComponents.Editors.IntegerInput
        Friend WithEvents nudRuns As DevComponents.Editors.IntegerInput
        Friend WithEvents cboPOSArrays As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents cboFactoryLocation As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents chkPOSProduction As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents btnExportToCSV As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents btnExportToTSV As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents tabBPCalcFunctions As DevComponents.DotNetBar.TabControl
        Friend WithEvents tcpResearch As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tiResearch As DevComponents.DotNetBar.TabItem
        Friend WithEvents tcpProduction As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tiProduction As DevComponents.DotNetBar.TabItem
        Friend WithEvents tcpInvention As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tiInvention As DevComponents.DotNetBar.TabItem
        Friend WithEvents cboInventions As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents cboDecryptor As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents nudInventionBPCRuns As DevComponents.Editors.IntegerInput
        Friend WithEvents lblBPMaxRuns As System.Windows.Forms.Label
        Friend WithEvents lblBPMaxRunsLbl As System.Windows.Forms.Label
        Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
        Friend WithEvents lblFactoryCostsLbl As System.Windows.Forms.Label
        Friend WithEvents lblInventionTime As System.Windows.Forms.Label
        Friend WithEvents lblInventionTimeLbl As System.Windows.Forms.Label
        Friend WithEvents lblInvSkill1 As System.Windows.Forms.Label
        Friend WithEvents lblInventionCostLbl As System.Windows.Forms.Label
        Friend WithEvents lblInventionDecryptorCostLbl As System.Windows.Forms.Label
        Friend WithEvents lblInventionBaseCostLbl As System.Windows.Forms.Label
        Friend WithEvents lblInventedBPLbl As System.Windows.Forms.Label
        Friend WithEvents lblInventionChance As System.Windows.Forms.Label
        Friend WithEvents lblOverrideBPCRuns As System.Windows.Forms.Label
        Friend WithEvents lblBlueprintInventions As System.Windows.Forms.Label
        Friend WithEvents lblDecryptor As System.Windows.Forms.Label
        Friend WithEvents lblBaseChance As System.Windows.Forms.Label
        Friend WithEvents lblInvSkill2 As System.Windows.Forms.Label
        Friend WithEvents lblInvSkill3 As System.Windows.Forms.Label
        Friend WithEvents lblInventionLabCostsLbl As System.Windows.Forms.LinkLabel
        Friend WithEvents lblInventionDecryptorCost As System.Windows.Forms.Label
        Friend WithEvents lblInventionLabCosts As System.Windows.Forms.Label
        Friend WithEvents lblInventionCost As System.Windows.Forms.Label
        Friend WithEvents lblInventionBaseCost As System.Windows.Forms.Label
        Friend WithEvents lblInventedBP As System.Windows.Forms.Label
        Friend WithEvents lblInventionBPCCostLbl As System.Windows.Forms.LinkLabel
        Friend WithEvents lblInventionBPCCost As System.Windows.Forms.LinkLabel
        Friend WithEvents lblAvgAttempts As System.Windows.Forms.Label
        Friend WithEvents lblSuccessCost As System.Windows.Forms.Label
        Friend WithEvents lblSuccessCostLbl As System.Windows.Forms.Label
        Friend WithEvents nudInventionSkill2 As DevComponents.Editors.IntegerInput
        Friend WithEvents nudInventionSkill3 As DevComponents.Editors.IntegerInput
        Friend WithEvents nudInventionSkill1 As DevComponents.Editors.IntegerInput
        Friend WithEvents PPRInvention As PrismResources
        Friend WithEvents lblBatchProductionCost As System.Windows.Forms.Label
        Friend WithEvents lblBatchProductionCostLbl As System.Windows.Forms.Label
        Friend WithEvents lblUnitInventionProfit As System.Windows.Forms.Label
        Friend WithEvents lblUnitInventionProfitLbl As System.Windows.Forms.Label
        Friend WithEvents lblInventionSalesPrice As System.Windows.Forms.Label
        Friend WithEvents lblInventionSalesPriceLbl As System.Windows.Forms.Label
        Friend WithEvents lblAvgInventionCost As System.Windows.Forms.Label
        Friend WithEvents lblAvgInventionCostLbl As System.Windows.Forms.Label
        Friend WithEvents PPRProduction As PrismResources
        Friend WithEvents lblTotalInventionProfit As System.Windows.Forms.Label
        Friend WithEvents lblTotalInventionProfitLbl As System.Windows.Forms.Label
        Friend WithEvents PACDecryptor As PriceAdjustmentControl
        Friend WithEvents PACSalesPrice As PriceAdjustmentControl
        Friend WithEvents adtInventionProfits As DevComponents.AdvTree.AdvTree
        Friend WithEvents colIPDecryptor As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colIPProfit As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector2 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle2 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents cboOwner As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblProdQuantity As System.Windows.Forms.Label
        Friend WithEvents lblBatchSize As System.Windows.Forms.Label
        Friend WithEvents btnSaveProductionJob As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnSaveProductionJobAs As DevComponents.DotNetBar.ButtonX
        Friend WithEvents PACUnitValue As PriceAdjustmentControl
        Friend WithEvents lblToggleInvention As DevComponents.DotNetBar.LabelX
        Friend WithEvents btnToggleInvention As DevComponents.DotNetBar.Controls.SwitchButton
        Friend WithEvents lblBatchTotalCost As System.Windows.Forms.Label
        Friend WithEvents lblBatchTotalCostLbl As System.Windows.Forms.Label
        Friend WithEvents lblProfitMarkup As System.Windows.Forms.Label
        Friend WithEvents lblProfitMargin As System.Windows.Forms.Label
        Friend WithEvents lblProfitMarkupLbl As System.Windows.Forms.Label
        Friend WithEvents lblProfitMarginLbl As System.Windows.Forms.Label
        Friend WithEvents chkInventionFlag As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
        Friend WithEvents SaveJobDialogCheckBox As DevComponents.DotNetBar.Command
        Friend WithEvents stnMeBonus As DevComponents.Editors.IntegerInput
        Friend WithEvents Label1 As System.Windows.Forms.Label

    End Class
End NameSpace