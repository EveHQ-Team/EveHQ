Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmCapSim
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
            Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
            Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
            Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
            Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
            Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
            Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
            Me.btnExport = New DevComponents.DotNetBar.ButtonX()
            Me.btnReset = New DevComponents.DotNetBar.ButtonX()
            Me.btnUpdateEvents = New DevComponents.DotNetBar.ButtonX()
            Me.iiEndTime = New DevComponents.Editors.IntegerInput()
            Me.iiStartTime = New DevComponents.Editors.IntegerInput()
            Me.lblEndTimeOffset = New DevComponents.DotNetBar.LabelX()
            Me.lblStartTimeOffset = New DevComponents.DotNetBar.LabelX()
            Me.gpResults = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.adtResults = New DevComponents.AdvTree.AdvTree()
            Me.colTimeOffset = New DevComponents.AdvTree.ColumnHeader()
            Me.colEventType = New DevComponents.AdvTree.ColumnHeader()
            Me.colStartCap = New DevComponents.AdvTree.ColumnHeader()
            Me.colCapAmount = New DevComponents.AdvTree.ColumnHeader()
            Me.colEndCap = New DevComponents.AdvTree.ColumnHeader()
            Me.colCapPercent = New DevComponents.AdvTree.ColumnHeader()
            Me.colCapRechg = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me.gpModuleList = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.adtModules = New DevComponents.AdvTree.AdvTree()
            Me.colModName = New DevComponents.AdvTree.ColumnHeader()
            Me.colCycleTime = New DevComponents.AdvTree.ColumnHeader()
            Me.colActCost = New DevComponents.AdvTree.ColumnHeader()
            Me.colRate = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector2 = New DevComponents.AdvTree.NodeConnector()
            Me.SlotStyle = New DevComponents.DotNetBar.ElementStyle()
            Me.gpCapStats = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.lblStability = New DevComponents.DotNetBar.LabelX()
            Me.lblPeakDelta = New DevComponents.DotNetBar.LabelX()
            Me.lblPeakRate = New DevComponents.DotNetBar.LabelX()
            Me.lblPeakIn = New DevComponents.DotNetBar.LabelX()
            Me.lblPeakOut = New DevComponents.DotNetBar.LabelX()
            Me.lblRecharge = New DevComponents.DotNetBar.LabelX()
            Me.lblCapacity = New DevComponents.DotNetBar.LabelX()
            Me.chartCap = New System.Windows.Forms.DataVisualization.Charting.Chart()
            Me.PanelEx1.SuspendLayout()
            CType(Me.iiEndTime, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.iiStartTime, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gpResults.SuspendLayout()
            CType(Me.adtResults, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gpModuleList.SuspendLayout()
            CType(Me.adtModules, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gpCapStats.SuspendLayout()
            CType(Me.chartCap, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'PanelEx1
            '
            Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
            Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.PanelEx1.Controls.Add(Me.chartCap)
            Me.PanelEx1.Controls.Add(Me.btnExport)
            Me.PanelEx1.Controls.Add(Me.btnReset)
            Me.PanelEx1.Controls.Add(Me.btnUpdateEvents)
            Me.PanelEx1.Controls.Add(Me.iiEndTime)
            Me.PanelEx1.Controls.Add(Me.iiStartTime)
            Me.PanelEx1.Controls.Add(Me.lblEndTimeOffset)
            Me.PanelEx1.Controls.Add(Me.lblStartTimeOffset)
            Me.PanelEx1.Controls.Add(Me.gpResults)
            Me.PanelEx1.Controls.Add(Me.gpModuleList)
            Me.PanelEx1.Controls.Add(Me.gpCapStats)
            Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
            Me.PanelEx1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.PanelEx1.Name = "PanelEx1"
            Me.PanelEx1.Size = New System.Drawing.Size(794, 576)
            Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.PanelEx1.Style.GradientAngle = 90
            Me.PanelEx1.TabIndex = 0
            '
            'btnExport
            '
            Me.btnExport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnExport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnExport.Location = New System.Drawing.Point(681, 318)
            Me.btnExport.Name = "btnExport"
            Me.btnExport.Size = New System.Drawing.Size(101, 21)
            Me.btnExport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnExport.TabIndex = 10
            Me.btnExport.Text = "Export to Clipboard"
            '
            'btnReset
            '
            Me.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnReset.Location = New System.Drawing.Point(734, 291)
            Me.btnReset.Name = "btnReset"
            Me.btnReset.Size = New System.Drawing.Size(48, 21)
            Me.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnReset.TabIndex = 9
            Me.btnReset.Text = "Reset"
            '
            'btnUpdateEvents
            '
            Me.btnUpdateEvents.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnUpdateEvents.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnUpdateEvents.Location = New System.Drawing.Point(681, 291)
            Me.btnUpdateEvents.Name = "btnUpdateEvents"
            Me.btnUpdateEvents.Size = New System.Drawing.Size(48, 21)
            Me.btnUpdateEvents.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnUpdateEvents.TabIndex = 7
            Me.btnUpdateEvents.Text = "Update"
            '
            'iiEndTime
            '
            '
            '
            '
            Me.iiEndTime.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.iiEndTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.iiEndTime.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.iiEndTime.Location = New System.Drawing.Point(681, 264)
            Me.iiEndTime.Name = "iiEndTime"
            Me.iiEndTime.ShowUpDown = True
            Me.iiEndTime.Size = New System.Drawing.Size(101, 21)
            Me.iiEndTime.TabIndex = 6
            '
            'iiStartTime
            '
            '
            '
            '
            Me.iiStartTime.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.iiStartTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.iiStartTime.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.iiStartTime.Location = New System.Drawing.Point(681, 220)
            Me.iiStartTime.Name = "iiStartTime"
            Me.iiStartTime.ShowUpDown = True
            Me.iiStartTime.Size = New System.Drawing.Size(101, 21)
            Me.iiStartTime.TabIndex = 5
            '
            'lblEndTimeOffset
            '
            Me.lblEndTimeOffset.AutoSize = True
            '
            '
            '
            Me.lblEndTimeOffset.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblEndTimeOffset.Location = New System.Drawing.Point(681, 247)
            Me.lblEndTimeOffset.Name = "lblEndTimeOffset"
            Me.lblEndTimeOffset.Size = New System.Drawing.Size(85, 16)
            Me.lblEndTimeOffset.TabIndex = 4
            Me.lblEndTimeOffset.Text = "End Time Offset:"
            '
            'lblStartTimeOffset
            '
            Me.lblStartTimeOffset.AutoSize = True
            '
            '
            '
            Me.lblStartTimeOffset.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblStartTimeOffset.Location = New System.Drawing.Point(681, 203)
            Me.lblStartTimeOffset.Name = "lblStartTimeOffset"
            Me.lblStartTimeOffset.Size = New System.Drawing.Size(90, 16)
            Me.lblStartTimeOffset.TabIndex = 3
            Me.lblStartTimeOffset.Text = "Start Time Offset:"
            '
            'gpResults
            '
            Me.gpResults.CanvasColor = System.Drawing.SystemColors.Control
            Me.gpResults.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.gpResults.Controls.Add(Me.adtResults)
            Me.gpResults.IsShadowEnabled = True
            Me.gpResults.Location = New System.Drawing.Point(12, 193)
            Me.gpResults.Name = "gpResults"
            Me.gpResults.Size = New System.Drawing.Size(663, 153)
            '
            '
            '
            Me.gpResults.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.gpResults.Style.BackColorGradientAngle = 90
            Me.gpResults.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.gpResults.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpResults.Style.BorderBottomWidth = 1
            Me.gpResults.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.gpResults.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpResults.Style.BorderLeftWidth = 1
            Me.gpResults.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpResults.Style.BorderRightWidth = 1
            Me.gpResults.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpResults.Style.BorderTopWidth = 1
            Me.gpResults.Style.CornerDiameter = 4
            Me.gpResults.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.gpResults.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.gpResults.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.gpResults.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.gpResults.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.gpResults.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.gpResults.TabIndex = 2
            Me.gpResults.Text = "Simulation Results"
            '
            'adtResults
            '
            Me.adtResults.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtResults.AllowDrop = True
            Me.adtResults.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtResults.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtResults.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtResults.Columns.Add(Me.colTimeOffset)
            Me.adtResults.Columns.Add(Me.colEventType)
            Me.adtResults.Columns.Add(Me.colStartCap)
            Me.adtResults.Columns.Add(Me.colCapAmount)
            Me.adtResults.Columns.Add(Me.colEndCap)
            Me.adtResults.Columns.Add(Me.colCapPercent)
            Me.adtResults.Columns.Add(Me.colCapRechg)
            Me.adtResults.DragDropEnabled = False
            Me.adtResults.DragDropNodeCopyEnabled = False
            Me.adtResults.ExpandWidth = 0
            Me.adtResults.GridLinesColor = System.Drawing.Color.Silver
            Me.adtResults.GridRowLines = True
            
            Me.adtResults.Location = New System.Drawing.Point(3, 0)
            Me.adtResults.Name = "adtResults"
            Me.adtResults.NodesConnector = Me.NodeConnector1
            Me.adtResults.NodeStyle = Me.ElementStyle1
            Me.adtResults.PathSeparator = ";"
            Me.adtResults.Size = New System.Drawing.Size(651, 127)
            Me.adtResults.Styles.Add(Me.ElementStyle1)
            Me.adtResults.TabIndex = 0
            Me.adtResults.Text = "AdvTree1"
            '
            'colTimeOffset
            '
            Me.colTimeOffset.Name = "colTimeOffset"
            Me.colTimeOffset.SortingEnabled = False
            Me.colTimeOffset.Text = "Time Offset"
            Me.colTimeOffset.Width.Absolute = 75
            '
            'colEventType
            '
            Me.colEventType.Name = "colEventType"
            Me.colEventType.SortingEnabled = False
            Me.colEventType.Text = "Event Type"
            Me.colEventType.Width.Absolute = 180
            '
            'colStartCap
            '
            Me.colStartCap.Name = "colStartCap"
            Me.colStartCap.Text = "Start Cap"
            Me.colStartCap.Width.Absolute = 75
            '
            'colCapAmount
            '
            Me.colCapAmount.Name = "colCapAmount"
            Me.colCapAmount.SortingEnabled = False
            Me.colCapAmount.Text = "Cap Amount"
            Me.colCapAmount.Width.Absolute = 75
            '
            'colEndCap
            '
            Me.colEndCap.Name = "colEndCap"
            Me.colEndCap.SortingEnabled = False
            Me.colEndCap.Text = "End Cap"
            Me.colEndCap.Width.Absolute = 75
            '
            'colCapPercent
            '
            Me.colCapPercent.Name = "colCapPercent"
            Me.colCapPercent.SortingEnabled = False
            Me.colCapPercent.Text = "Cap %"
            Me.colCapPercent.Width.Absolute = 50
            '
            'colCapRechg
            '
            Me.colCapRechg.Name = "colCapRechg"
            Me.colCapRechg.SortingEnabled = False
            Me.colCapRechg.Text = "Rechg"
            Me.colCapRechg.Width.Absolute = 60
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
            'gpModuleList
            '
            Me.gpModuleList.CanvasColor = System.Drawing.SystemColors.Control
            Me.gpModuleList.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.gpModuleList.Controls.Add(Me.adtModules)
            Me.gpModuleList.IsShadowEnabled = True
            Me.gpModuleList.Location = New System.Drawing.Point(240, 12)
            Me.gpModuleList.Name = "gpModuleList"
            Me.gpModuleList.Size = New System.Drawing.Size(542, 176)
            '
            '
            '
            Me.gpModuleList.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.gpModuleList.Style.BackColorGradientAngle = 90
            Me.gpModuleList.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.gpModuleList.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpModuleList.Style.BorderBottomWidth = 1
            Me.gpModuleList.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.gpModuleList.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpModuleList.Style.BorderLeftWidth = 1
            Me.gpModuleList.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpModuleList.Style.BorderRightWidth = 1
            Me.gpModuleList.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpModuleList.Style.BorderTopWidth = 1
            Me.gpModuleList.Style.CornerDiameter = 4
            Me.gpModuleList.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.gpModuleList.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.gpModuleList.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.gpModuleList.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.gpModuleList.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.gpModuleList.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.gpModuleList.TabIndex = 1
            Me.gpModuleList.Text = "Modules Affecting Capacitor"
            '
            'adtModules
            '
            Me.adtModules.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtModules.AllowDrop = True
            Me.adtModules.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtModules.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtModules.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtModules.Columns.Add(Me.colModName)
            Me.adtModules.Columns.Add(Me.colCycleTime)
            Me.adtModules.Columns.Add(Me.colActCost)
            Me.adtModules.Columns.Add(Me.colRate)
            Me.adtModules.DragDropEnabled = False
            Me.adtModules.DragDropNodeCopyEnabled = False
            Me.adtModules.ExpandWidth = 0
            Me.adtModules.GridLinesColor = System.Drawing.Color.Silver
            Me.adtModules.GridRowLines = True
            
            Me.adtModules.Location = New System.Drawing.Point(3, 0)
            Me.adtModules.Name = "adtModules"
            Me.adtModules.NodesConnector = Me.NodeConnector2
            Me.adtModules.NodeStyle = Me.SlotStyle
            Me.adtModules.PathSeparator = ";"
            Me.adtModules.SelectionBoxStyle = DevComponents.AdvTree.eSelectionStyle.NodeMarker
            Me.adtModules.Size = New System.Drawing.Size(530, 151)
            Me.adtModules.Styles.Add(Me.SlotStyle)
            Me.adtModules.TabIndex = 0
            Me.adtModules.Text = "AdvTree1"
            '
            'colModName
            '
            Me.colModName.Name = "colModName"
            Me.colModName.SortingEnabled = False
            Me.colModName.Text = "Module Name"
            Me.colModName.Width.Absolute = 250
            '
            'colCycleTime
            '
            Me.colCycleTime.Name = "colCycleTime"
            Me.colCycleTime.SortingEnabled = False
            Me.colCycleTime.Text = "Cycle Time"
            Me.colCycleTime.Width.Absolute = 80
            '
            'colActCost
            '
            Me.colActCost.Name = "colActCost"
            Me.colActCost.SortingEnabled = False
            Me.colActCost.Text = "Act Cost"
            Me.colActCost.Width.Absolute = 80
            '
            'colRate
            '
            Me.colRate.Name = "colRate"
            Me.colRate.SortingEnabled = False
            Me.colRate.Text = "Rate (GJ/s)"
            Me.colRate.Width.Absolute = 80
            '
            'NodeConnector2
            '
            Me.NodeConnector2.LineColor = System.Drawing.SystemColors.ControlText
            '
            'SlotStyle
            '
            Me.SlotStyle.BackColorGradientAngle = 90
            Me.SlotStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
            Me.SlotStyle.CornerDiameter = 4
            Me.SlotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.SlotStyle.Name = "SlotStyle"
            Me.SlotStyle.TextColor = System.Drawing.SystemColors.ControlText
            '
            'gpCapStats
            '
            Me.gpCapStats.CanvasColor = System.Drawing.SystemColors.Control
            Me.gpCapStats.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.gpCapStats.Controls.Add(Me.lblStability)
            Me.gpCapStats.Controls.Add(Me.lblPeakDelta)
            Me.gpCapStats.Controls.Add(Me.lblPeakRate)
            Me.gpCapStats.Controls.Add(Me.lblPeakIn)
            Me.gpCapStats.Controls.Add(Me.lblPeakOut)
            Me.gpCapStats.Controls.Add(Me.lblRecharge)
            Me.gpCapStats.Controls.Add(Me.lblCapacity)
            Me.gpCapStats.IsShadowEnabled = True
            Me.gpCapStats.Location = New System.Drawing.Point(12, 11)
            Me.gpCapStats.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.gpCapStats.Name = "gpCapStats"
            Me.gpCapStats.Size = New System.Drawing.Size(222, 177)
            '
            '
            '
            Me.gpCapStats.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.gpCapStats.Style.BackColorGradientAngle = 90
            Me.gpCapStats.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.gpCapStats.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpCapStats.Style.BorderBottomWidth = 1
            Me.gpCapStats.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.gpCapStats.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpCapStats.Style.BorderLeftWidth = 1
            Me.gpCapStats.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpCapStats.Style.BorderRightWidth = 1
            Me.gpCapStats.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpCapStats.Style.BorderTopWidth = 1
            Me.gpCapStats.Style.CornerDiameter = 4
            Me.gpCapStats.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.gpCapStats.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.gpCapStats.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.gpCapStats.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.gpCapStats.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.gpCapStats.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.gpCapStats.TabIndex = 0
            Me.gpCapStats.Text = "Capacitor Summary Statistics"
            '
            'lblStability
            '
            Me.lblStability.AutoSize = True
            '
            '
            '
            Me.lblStability.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblStability.Location = New System.Drawing.Point(3, 132)
            Me.lblStability.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.lblStability.Name = "lblStability"
            Me.lblStability.Size = New System.Drawing.Size(45, 16)
            Me.lblStability.TabIndex = 6
            Me.lblStability.Text = "Stability:"
            '
            'lblPeakDelta
            '
            Me.lblPeakDelta.AutoSize = True
            '
            '
            '
            Me.lblPeakDelta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblPeakDelta.Location = New System.Drawing.Point(3, 112)
            Me.lblPeakDelta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.lblPeakDelta.Name = "lblPeakDelta"
            Me.lblPeakDelta.Size = New System.Drawing.Size(58, 16)
            Me.lblPeakDelta.TabIndex = 5
            Me.lblPeakDelta.Text = "Peak Delta:"
            '
            'lblPeakRate
            '
            Me.lblPeakRate.AutoSize = True
            '
            '
            '
            Me.lblPeakRate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblPeakRate.Location = New System.Drawing.Point(3, 52)
            Me.lblPeakRate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.lblPeakRate.Name = "lblPeakRate"
            Me.lblPeakRate.Size = New System.Drawing.Size(104, 16)
            Me.lblPeakRate.TabIndex = 4
            Me.lblPeakRate.Text = "Peak Recharge Rate:"
            '
            'lblPeakIn
            '
            Me.lblPeakIn.AutoSize = True
            '
            '
            '
            Me.lblPeakIn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblPeakIn.Location = New System.Drawing.Point(3, 72)
            Me.lblPeakIn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.lblPeakIn.Name = "lblPeakIn"
            Me.lblPeakIn.Size = New System.Drawing.Size(43, 16)
            Me.lblPeakIn.TabIndex = 3
            Me.lblPeakIn.Text = "Peak In:"
            '
            'lblPeakOut
            '
            Me.lblPeakOut.AutoSize = True
            '
            '
            '
            Me.lblPeakOut.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblPeakOut.Location = New System.Drawing.Point(3, 92)
            Me.lblPeakOut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.lblPeakOut.Name = "lblPeakOut"
            Me.lblPeakOut.Size = New System.Drawing.Size(51, 16)
            Me.lblPeakOut.TabIndex = 2
            Me.lblPeakOut.Text = "Peak Out:"
            '
            'lblRecharge
            '
            Me.lblRecharge.AutoSize = True
            '
            '
            '
            Me.lblRecharge.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblRecharge.Location = New System.Drawing.Point(3, 32)
            Me.lblRecharge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.lblRecharge.Name = "lblRecharge"
            Me.lblRecharge.Size = New System.Drawing.Size(79, 16)
            Me.lblRecharge.TabIndex = 1
            Me.lblRecharge.Text = "Recharge Time:"
            '
            'lblCapacity
            '
            Me.lblCapacity.AutoSize = True
            '
            '
            '
            Me.lblCapacity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblCapacity.Location = New System.Drawing.Point(3, 12)
            Me.lblCapacity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.lblCapacity.Name = "lblCapacity"
            Me.lblCapacity.Size = New System.Drawing.Size(47, 16)
            Me.lblCapacity.TabIndex = 0
            Me.lblCapacity.Text = "Capacity:"
            '
            'chartCap
            '
            Me.chartCap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                         Or System.Windows.Forms.AnchorStyles.Left) _
                                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chartCap.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chartCap.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
            Me.chartCap.BackSecondaryColor = System.Drawing.Color.White
            Me.chartCap.BorderlineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.chartCap.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
            Me.chartCap.BorderlineWidth = 2
            ChartArea1.Area3DStyle.Inclination = 15
            ChartArea1.Area3DStyle.IsClustered = True
            ChartArea1.Area3DStyle.IsRightAngleAxes = False
            ChartArea1.Area3DStyle.Perspective = 10
            ChartArea1.Area3DStyle.Rotation = 10
            ChartArea1.Area3DStyle.WallWidth = 0
            ChartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
            ChartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
            ChartArea1.AxisX.IsLabelAutoFit = False
            ChartArea1.AxisX.IsStartedFromZero = False
            ChartArea1.AxisX.LabelAutoFitMaxFontSize = 7
            ChartArea1.AxisX.LabelAutoFitStyle = CType(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) _
                                                        Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap), System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)
            ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
            ChartArea1.AxisX.LabelStyle.Format = "N0"
            ChartArea1.AxisX.LabelStyle.Interval = 0.0R
            ChartArea1.AxisX.LabelStyle.IntervalOffset = 0.0R
            ChartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
            ChartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
            ChartArea1.AxisX.LabelStyle.TruncatedLabels = True
            ChartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            ChartArea1.AxisX.MajorTickMark.Interval = 0.0R
            ChartArea1.AxisX.MajorTickMark.IntervalOffset = 0.0R
            ChartArea1.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
            ChartArea1.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
            ChartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black
            ChartArea1.AxisX.ScrollBar.Size = 10.0R
            ChartArea1.AxisX.Title = "Time (s)"
            ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ChartArea1.AxisY.IsLabelAutoFit = False
            ChartArea1.AxisY.LabelStyle.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ChartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            ChartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.Black
            ChartArea1.AxisY.ScrollBar.Size = 10.0R
            ChartArea1.AxisY.Title = "Cap (%)"
            ChartArea1.BackColor = System.Drawing.Color.Gainsboro
            ChartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
            ChartArea1.BackSecondaryColor = System.Drawing.Color.White
            ChartArea1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            ChartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
            ChartArea1.CursorX.IsUserEnabled = True
            ChartArea1.CursorX.IsUserSelectionEnabled = True
            ChartArea1.CursorY.IsUserEnabled = True
            ChartArea1.CursorY.IsUserSelectionEnabled = True
            ChartArea1.Name = "Default"
            ChartArea1.ShadowColor = System.Drawing.Color.Transparent
            Me.chartCap.ChartAreas.Add(ChartArea1)
            Legend1.Alignment = System.Drawing.StringAlignment.Center
            Legend1.BackColor = System.Drawing.Color.Transparent
            Legend1.DockedToChartArea = "Default"
            Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
            Legend1.Enabled = False
            Legend1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Legend1.IsTextAutoFit = False
            Legend1.Name = "Default"
            Legend1.TitleFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartCap.Legends.Add(Legend1)
            Me.chartCap.Location = New System.Drawing.Point(12, 352)
            Me.chartCap.Name = "chartCap"
            Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
            Series1.ChartArea = "Default"
            Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
            Series1.Legend = "Default"
            Series1.Name = "Series1"
            Series1.ShadowColor = System.Drawing.Color.Black
            Series2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
            Series2.ChartArea = "Default"
            Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
            Series2.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(10, Byte), Integer))
            Series2.Legend = "Default"
            Series2.Name = "Series2"
            Series2.ShadowColor = System.Drawing.Color.Black
            Me.chartCap.Series.Add(Series1)
            Me.chartCap.Series.Add(Series2)
            Me.chartCap.Size = New System.Drawing.Size(770, 221)
            Me.chartCap.TabIndex = 20
            Title1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Title1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
            Title1.Name = "Title1"
            Title1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Title1.ShadowOffset = 3
            Title1.Text = "Capacitor Simulation"
            Me.chartCap.Titles.Add(Title1)
            '
            'frmCapSim
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(794, 576)
            Me.Controls.Add(Me.PanelEx1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
            Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Name = "frmCapSim"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Capacitor Simulation Results"
            Me.PanelEx1.ResumeLayout(False)
            Me.PanelEx1.PerformLayout()
            CType(Me.iiEndTime, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.iiStartTime, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gpResults.ResumeLayout(False)
            CType(Me.adtResults, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gpModuleList.ResumeLayout(False)
            CType(Me.adtModules, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gpCapStats.ResumeLayout(False)
            Me.gpCapStats.PerformLayout()
            CType(Me.chartCap, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
        Friend WithEvents gpCapStats As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents lblPeakDelta As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblPeakRate As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblPeakIn As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblPeakOut As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblRecharge As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblCapacity As DevComponents.DotNetBar.LabelX
        Friend WithEvents gpModuleList As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents gpResults As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents iiEndTime As DevComponents.Editors.IntegerInput
        Friend WithEvents iiStartTime As DevComponents.Editors.IntegerInput
        Friend WithEvents lblEndTimeOffset As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblStartTimeOffset As DevComponents.DotNetBar.LabelX
        Friend WithEvents btnUpdateEvents As DevComponents.DotNetBar.ButtonX
        Friend WithEvents lblStability As DevComponents.DotNetBar.LabelX
        Friend WithEvents btnReset As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnExport As DevComponents.DotNetBar.ButtonX
        Friend WithEvents adtResults As DevComponents.AdvTree.AdvTree
        Friend WithEvents colTimeOffset As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colEventType As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colStartCap As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colCapAmount As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colEndCap As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colCapPercent As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colCapRechg As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents adtModules As DevComponents.AdvTree.AdvTree
        Friend WithEvents colModName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colCycleTime As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colActCost As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colRate As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector2 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents SlotStyle As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents chartCap As System.Windows.Forms.DataVisualization.Charting.Chart
    End Class
End NameSpace