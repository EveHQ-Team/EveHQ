Namespace Controls.DBControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class DBCLastJournals
        Inherits Widget

        'UserControl overrides dispose to clean up the component list.
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
            Me.lblPilot = New System.Windows.Forms.Label()
            Me.lblTransactionsDisplayCount = New System.Windows.Forms.Label()
            Me.cboPilotList = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.btnRefresh = New DevComponents.DotNetBar.ButtonX()
            Me.nudEntries = New DevComponents.Editors.IntegerInput()
            Me.adtLastTransactions = New DevComponents.AdvTree.AdvTree()
            Me.colDate = New DevComponents.AdvTree.ColumnHeader()
            Me.colType = New DevComponents.AdvTree.ColumnHeader()
            Me.colAmount = New DevComponents.AdvTree.ColumnHeader()
            Me.colBalance = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me.AGPContent.SuspendLayout()
            CType(Me.pbConfig, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudEntries, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.adtLastTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblHeader
            '
            '
            '
            '
            Me.lblHeader.BackgroundStyle.Class = ""
            Me.lblHeader.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblHeader.Image = Global.EveHQ.My.Resources.Resources.Market32
            Me.lblHeader.Size = New System.Drawing.Size(391, 23)
            Me.lblHeader.Text = "Last Wallet Journal Entries"
            '
            'AGPContent
            '
            Me.AGPContent.Controls.Add(Me.adtLastTransactions)
            Me.AGPContent.Controls.Add(Me.nudEntries)
            Me.AGPContent.Controls.Add(Me.btnRefresh)
            Me.AGPContent.Controls.Add(Me.cboPilotList)
            Me.AGPContent.Controls.Add(Me.lblPilot)
            Me.AGPContent.Controls.Add(Me.lblTransactionsDisplayCount)
            Me.AGPContent.Size = New System.Drawing.Size(400, 250)
            Me.AGPContent.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.AGPContent.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.AGPContent.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.AGPContent.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.AGPContent.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AGPContent.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.AGPContent.Style.GradientAngle = 90
            Me.AGPContent.Controls.SetChildIndex(Me.lblHeader, 0)
            Me.AGPContent.Controls.SetChildIndex(Me.lblTransactionsDisplayCount, 0)
            Me.AGPContent.Controls.SetChildIndex(Me.pbConfig, 0)
            Me.AGPContent.Controls.SetChildIndex(Me.lblPilot, 0)
            Me.AGPContent.Controls.SetChildIndex(Me.cboPilotList, 0)
            Me.AGPContent.Controls.SetChildIndex(Me.btnRefresh, 0)
            Me.AGPContent.Controls.SetChildIndex(Me.nudEntries, 0)
            Me.AGPContent.Controls.SetChildIndex(Me.adtLastTransactions, 0)
            '
            'pbConfig
            '
            Me.pbConfig.Location = New System.Drawing.Point(374, 6)
            '
            'lblPilot
            '
            Me.lblPilot.AutoSize = True
            Me.lblPilot.BackColor = System.Drawing.Color.Transparent
            Me.lblPilot.Location = New System.Drawing.Point(8, 38)
            Me.lblPilot.Name = "lblPilot"
            Me.lblPilot.Size = New System.Drawing.Size(31, 13)
            Me.lblPilot.TabIndex = 19
            Me.lblPilot.Text = "Pilot:"
            '
            'lblTransactionsDisplayCount
            '
            Me.lblTransactionsDisplayCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblTransactionsDisplayCount.AutoSize = True
            Me.lblTransactionsDisplayCount.BackColor = System.Drawing.Color.Transparent
            Me.lblTransactionsDisplayCount.Location = New System.Drawing.Point(304, 38)
            Me.lblTransactionsDisplayCount.Name = "lblTransactionsDisplayCount"
            Me.lblTransactionsDisplayCount.Size = New System.Drawing.Size(44, 13)
            Me.lblTransactionsDisplayCount.TabIndex = 18
            Me.lblTransactionsDisplayCount.Text = "Entries:"
            '
            'cboPilotList
            '
            Me.cboPilotList.DisplayMember = "Text"
            Me.cboPilotList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboPilotList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboPilotList.FormattingEnabled = True
            Me.cboPilotList.ItemHeight = 15
            Me.cboPilotList.Location = New System.Drawing.Point(45, 35)
            Me.cboPilotList.Name = "cboPilotList"
            Me.cboPilotList.Size = New System.Drawing.Size(154, 21)
            Me.cboPilotList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboPilotList.TabIndex = 20
            '
            'btnRefresh
            '
            Me.btnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnRefresh.Location = New System.Drawing.Point(205, 35)
            Me.btnRefresh.Name = "btnRefresh"
            Me.btnRefresh.Size = New System.Drawing.Size(55, 21)
            Me.btnRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnRefresh.TabIndex = 21
            Me.btnRefresh.Text = "Refresh"
            '
            'nudEntries
            '
            Me.nudEntries.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.nudEntries.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.nudEntries.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.nudEntries.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.nudEntries.Location = New System.Drawing.Point(354, 35)
            Me.nudEntries.MaxValue = 100
            Me.nudEntries.MinValue = 1
            Me.nudEntries.Name = "nudEntries"
            Me.nudEntries.ShowUpDown = True
            Me.nudEntries.Size = New System.Drawing.Size(43, 21)
            Me.nudEntries.TabIndex = 22
            Me.nudEntries.Value = 1
            '
            'adtLastTransactions
            '
            Me.adtLastTransactions.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtLastTransactions.AllowDrop = False
            Me.adtLastTransactions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                                    Or System.Windows.Forms.AnchorStyles.Left) _
                                                   Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.adtLastTransactions.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtLastTransactions.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtLastTransactions.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtLastTransactions.Columns.Add(Me.colDate)
            Me.adtLastTransactions.Columns.Add(Me.colType)
            Me.adtLastTransactions.Columns.Add(Me.colAmount)
            Me.adtLastTransactions.Columns.Add(Me.colBalance)
            Me.adtLastTransactions.DragDropEnabled = False
            Me.adtLastTransactions.DragDropNodeCopyEnabled = False
            Me.adtLastTransactions.ExpandWidth = 0
            
            Me.adtLastTransactions.Location = New System.Drawing.Point(6, 62)
            Me.adtLastTransactions.Name = "adtLastTransactions"
            Me.adtLastTransactions.NodesConnector = Me.NodeConnector1
            Me.adtLastTransactions.NodeStyle = Me.ElementStyle1
            Me.adtLastTransactions.PathSeparator = ";"
            Me.adtLastTransactions.Size = New System.Drawing.Size(388, 182)
            Me.adtLastTransactions.Styles.Add(Me.ElementStyle1)
            Me.adtLastTransactions.TabIndex = 23
            Me.adtLastTransactions.Text = "AdvTree1"
            '
            'colDate
            '
            Me.colDate.Name = "colDate"
            Me.colDate.SortingEnabled = False
            Me.colDate.Text = "Date"
            Me.colDate.Width.Absolute = 100
            Me.colDate.Width.AutoSize = True
            Me.colDate.Width.AutoSizeMinHeader = True
            '
            'colType
            '
            Me.colType.Name = "colType"
            Me.colType.SortingEnabled = False
            Me.colType.Text = "Type"
            Me.colType.Width.Absolute = 100
            Me.colType.Width.AutoSize = True
            Me.colType.Width.AutoSizeMinHeader = True
            '
            'colAmount
            '
            Me.colAmount.Name = "colAmount"
            Me.colAmount.SortingEnabled = False
            Me.colAmount.Text = "Amount"
            Me.colAmount.Width.Absolute = 100
            Me.colAmount.Width.AutoSize = True
            Me.colAmount.Width.AutoSizeMinHeader = True
            '
            'colBalance
            '
            Me.colBalance.Name = "colBalance"
            Me.colBalance.SortingEnabled = False
            Me.colBalance.Text = "Balance"
            Me.colBalance.Width.Absolute = 100
            Me.colBalance.Width.AutoSize = True
            Me.colBalance.Width.AutoSizeMinHeader = True
            '
            'NodeConnector1
            '
            Me.NodeConnector1.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle1
            '
            Me.ElementStyle1.Class = ""
            Me.ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle1.Name = "ElementStyle1"
            Me.ElementStyle1.TextColor = System.Drawing.SystemColors.ControlText
            '
            'DBCLastJournals
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "DBCLastJournals"
            Me.Size = New System.Drawing.Size(400, 250)
            Me.AGPContent.ResumeLayout(False)
            Me.AGPContent.PerformLayout()
            CType(Me.pbConfig, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudEntries, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.adtLastTransactions, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblPilot As System.Windows.Forms.Label
        Friend WithEvents lblTransactionsDisplayCount As System.Windows.Forms.Label
        Friend WithEvents cboPilotList As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents nudEntries As DevComponents.Editors.IntegerInput
        Friend WithEvents btnRefresh As DevComponents.DotNetBar.ButtonX
        Friend WithEvents adtLastTransactions As DevComponents.AdvTree.AdvTree
        Friend WithEvents colDate As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colType As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colAmount As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colBalance As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle

    End Class
End NameSpace