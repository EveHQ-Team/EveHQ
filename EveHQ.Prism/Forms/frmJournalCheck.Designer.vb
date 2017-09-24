Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmJournalCheck
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
            Me.panelJournalCheck = New DevComponents.DotNetBar.PanelEx()
            Me.btnFixJournal = New DevComponents.DotNetBar.ButtonX()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.adtJournals = New DevComponents.AdvTree.AdvTree()
            Me.colOwner = New DevComponents.AdvTree.ColumnHeader()
            Me.colWallet = New DevComponents.AdvTree.ColumnHeader()
            Me.colDate1 = New DevComponents.AdvTree.ColumnHeader()
            Me.colDate2 = New DevComponents.AdvTree.ColumnHeader()
            Me.colKey1 = New DevComponents.AdvTree.ColumnHeader()
            Me.colKey2 = New DevComponents.AdvTree.ColumnHeader()
            Me.colBal1 = New DevComponents.AdvTree.ColumnHeader()
            Me.colAmount = New DevComponents.AdvTree.ColumnHeader()
            Me.colTax = New DevComponents.AdvTree.ColumnHeader()
            Me.colBal2 = New DevComponents.AdvTree.ColumnHeader()
            Me.colDifference = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me.pbProgress = New DevComponents.DotNetBar.Controls.ProgressBarX()
            Me.lblInfo = New System.Windows.Forms.Label()
            Me.picProgress = New System.Windows.Forms.PictureBox()
            Me.panelJournalCheck.SuspendLayout()
            CType(Me.adtJournals, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picProgress, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panelJournalCheck
            '
            Me.panelJournalCheck.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelJournalCheck.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelJournalCheck.Controls.Add(Me.btnFixJournal)
            Me.panelJournalCheck.Controls.Add(Me.Label1)
            Me.panelJournalCheck.Controls.Add(Me.adtJournals)
            Me.panelJournalCheck.Controls.Add(Me.pbProgress)
            Me.panelJournalCheck.Controls.Add(Me.lblInfo)
            Me.panelJournalCheck.Controls.Add(Me.picProgress)
            Me.panelJournalCheck.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelJournalCheck.Location = New System.Drawing.Point(0, 0)
            Me.panelJournalCheck.Name = "panelJournalCheck"
            Me.panelJournalCheck.Size = New System.Drawing.Size(1085, 536)
            Me.panelJournalCheck.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelJournalCheck.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelJournalCheck.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelJournalCheck.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelJournalCheck.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelJournalCheck.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelJournalCheck.Style.GradientAngle = 90
            Me.panelJournalCheck.TabIndex = 0
            '
            'btnFixJournal
            '
            Me.btnFixJournal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnFixJournal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnFixJournal.Enabled = False
            Me.btnFixJournal.Location = New System.Drawing.Point(12, 510)
            Me.btnFixJournal.Name = "btnFixJournal"
            Me.btnFixJournal.Size = New System.Drawing.Size(75, 21)
            Me.btnFixJournal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnFixJournal.TabIndex = 5
            Me.btnFixJournal.Text = "Fix Journal"
            '
            'Label1
            '
            Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(112, 514)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(405, 13)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Note: Rounding errors of +/- 0.01 isk are ignored for the purposes of this analys" & _
                             "is."
            '
            'adtJournals
            '
            Me.adtJournals.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtJournals.AllowDrop = True
            Me.adtJournals.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                            Or System.Windows.Forms.AnchorStyles.Left) _
                                           Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.adtJournals.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtJournals.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtJournals.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtJournals.Columns.Add(Me.colOwner)
            Me.adtJournals.Columns.Add(Me.colWallet)
            Me.adtJournals.Columns.Add(Me.colDate1)
            Me.adtJournals.Columns.Add(Me.colDate2)
            Me.adtJournals.Columns.Add(Me.colKey1)
            Me.adtJournals.Columns.Add(Me.colKey2)
            Me.adtJournals.Columns.Add(Me.colBal1)
            Me.adtJournals.Columns.Add(Me.colAmount)
            Me.adtJournals.Columns.Add(Me.colTax)
            Me.adtJournals.Columns.Add(Me.colBal2)
            Me.adtJournals.Columns.Add(Me.colDifference)
            Me.adtJournals.ExpandWidth = 0
            Me.adtJournals.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            
            Me.adtJournals.Location = New System.Drawing.Point(12, 41)
            Me.adtJournals.Name = "adtJournals"
            Me.adtJournals.NodesConnector = Me.NodeConnector1
            Me.adtJournals.NodeStyle = Me.ElementStyle1
            Me.adtJournals.PathSeparator = ";"
            Me.adtJournals.Size = New System.Drawing.Size(1061, 463)
            Me.adtJournals.Styles.Add(Me.ElementStyle1)
            Me.adtJournals.TabIndex = 3
            '
            'colOwner
            '
            Me.colOwner.Name = "colOwner"
            Me.colOwner.SortingEnabled = False
            Me.colOwner.Text = "Owner"
            Me.colOwner.Width.Absolute = 100
            '
            'colWallet
            '
            Me.colWallet.Name = "colWallet"
            Me.colWallet.SortingEnabled = False
            Me.colWallet.Text = "WalletID"
            Me.colWallet.Width.Absolute = 50
            '
            'colDate1
            '
            Me.colDate1.Name = "colDate1"
            Me.colDate1.SortingEnabled = False
            Me.colDate1.Text = "Prev Date"
            Me.colDate1.Width.Absolute = 90
            '
            'colDate2
            '
            Me.colDate2.Name = "colDate2"
            Me.colDate2.SortingEnabled = False
            Me.colDate2.Text = "Curr Date"
            Me.colDate2.Width.Absolute = 90
            '
            'colKey1
            '
            Me.colKey1.Name = "colKey1"
            Me.colKey1.SortingEnabled = False
            Me.colKey1.Text = "Prev Key"
            Me.colKey1.Width.Absolute = 100
            '
            'colKey2
            '
            Me.colKey2.Name = "colKey2"
            Me.colKey2.SortingEnabled = False
            Me.colKey2.Text = "Curr Key"
            Me.colKey2.Width.Absolute = 100
            '
            'colBal1
            '
            Me.colBal1.Name = "colBal1"
            Me.colBal1.SortingEnabled = False
            Me.colBal1.Text = "Prev Bal"
            Me.colBal1.Width.Absolute = 90
            '
            'colAmount
            '
            Me.colAmount.Name = "colAmount"
            Me.colAmount.SortingEnabled = False
            Me.colAmount.Text = "Amount"
            Me.colAmount.Width.Absolute = 90
            '
            'colTax
            '
            Me.colTax.Name = "colTax"
            Me.colTax.SortingEnabled = False
            Me.colTax.Text = "Tax Amount"
            Me.colTax.Width.Absolute = 90
            '
            'colBal2
            '
            Me.colBal2.Name = "colBal2"
            Me.colBal2.SortingEnabled = False
            Me.colBal2.Text = "Curr Bal"
            Me.colBal2.Width.Absolute = 90
            '
            'colDifference
            '
            Me.colDifference.Name = "colDifference"
            Me.colDifference.SortingEnabled = False
            Me.colDifference.Text = "Difference"
            Me.colDifference.Width.Absolute = 90
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
            'pbProgress
            '
            Me.pbProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                          Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.pbProgress.BackgroundStyle.Class = ""
            Me.pbProgress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.pbProgress.Location = New System.Drawing.Point(50, 25)
            Me.pbProgress.Maximum = 1000
            Me.pbProgress.Name = "pbProgress"
            Me.pbProgress.Size = New System.Drawing.Size(1023, 10)
            Me.pbProgress.TabIndex = 2
            Me.pbProgress.Text = "ProgressBarX1"
            '
            'lblInfo
            '
            Me.lblInfo.AutoSize = True
            Me.lblInfo.Location = New System.Drawing.Point(50, 9)
            Me.lblInfo.Name = "lblInfo"
            Me.lblInfo.Size = New System.Drawing.Size(323, 13)
            Me.lblInfo.TabIndex = 1
            Me.lblInfo.Text = "Please wait while the Wallet Journals are checked for continuity..."
            '
            'picProgress
            '
            Me.picProgress.Image = Global.EveHQ.Prism.My.Resources.Resources.Spinner
            Me.picProgress.Location = New System.Drawing.Point(12, 3)
            Me.picProgress.Name = "picProgress"
            Me.picProgress.Size = New System.Drawing.Size(32, 32)
            Me.picProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picProgress.TabIndex = 0
            Me.picProgress.TabStop = False
            '
            'frmJournalCheck
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1085, 536)
            Me.Controls.Add(Me.panelJournalCheck)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmJournalCheck"
            Me.ShowIcon = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Wallet Journal Check"
            Me.panelJournalCheck.ResumeLayout(False)
            Me.panelJournalCheck.PerformLayout()
            CType(Me.adtJournals, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picProgress, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents panelJournalCheck As DevComponents.DotNetBar.PanelEx
        Friend WithEvents picProgress As System.Windows.Forms.PictureBox
        Friend WithEvents lblInfo As System.Windows.Forms.Label
        Friend WithEvents pbProgress As DevComponents.DotNetBar.Controls.ProgressBarX
        Friend WithEvents adtJournals As DevComponents.AdvTree.AdvTree
        Friend WithEvents colDate1 As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colDate2 As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colKey1 As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colKey2 As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colAmount As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colBal1 As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colBal2 As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents colTax As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colDifference As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colOwner As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colWallet As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnFixJournal As DevComponents.DotNetBar.ButtonX
    End Class
End NameSpace