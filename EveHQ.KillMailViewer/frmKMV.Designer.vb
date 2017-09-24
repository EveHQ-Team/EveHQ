<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKmv
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
        Me.cboAccount = New System.Windows.Forms.ComboBox()
        Me.radUseAPI = New System.Windows.Forms.RadioButton()
        Me.radUseAccount = New System.Windows.Forms.RadioButton()
        Me.lblAPIStatus = New System.Windows.Forms.Label()
        Me.btnGetCharacters = New System.Windows.Forms.Button()
        Me.txtAPIKey = New System.Windows.Forms.TextBox()
        Me.lblAPIKey = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lvwCharacters = New System.Windows.Forms.ListView()
        Me.colCharacterName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnFetchKillMails = New System.Windows.Forms.Button()
        Me.lblKMSummary = New System.Windows.Forms.Label()
        Me.lblKillmailDetails = New System.Windows.Forms.Label()
        Me.txtKillMailDetails = New System.Windows.Forms.TextBox()
        Me.btnUploadToBC = New System.Windows.Forms.Button()
        Me.gpAPI = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.gpCharacters = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.adtKillmails = New DevComponents.AdvTree.AdvTree()
        Me.colVictim = New DevComponents.AdvTree.ColumnHeader()
        Me.colShip = New DevComponents.AdvTree.ColumnHeader()
        Me.colDate = New DevComponents.AdvTree.ColumnHeader()
        Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
        Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
        Me.btnCopyKillmail = New DevComponents.DotNetBar.ButtonX()
        Me.btnExportToHQF = New DevComponents.DotNetBar.ButtonX()
        Me.gpAPI.SuspendLayout()
        Me.gpCharacters.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.adtKillmails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboAccount
        '
        Me.cboAccount.FormattingEnabled = True
        Me.cboAccount.Location = New System.Drawing.Point(138, 11)
        Me.cboAccount.Name = "cboAccount"
        Me.cboAccount.Size = New System.Drawing.Size(146, 21)
        Me.cboAccount.Sorted = True
        Me.cboAccount.TabIndex = 8
        '
        'radUseAPI
        '
        Me.radUseAPI.AutoSize = True
        Me.radUseAPI.BackColor = System.Drawing.Color.Transparent
        Me.radUseAPI.Location = New System.Drawing.Point(3, 35)
        Me.radUseAPI.Name = "radUseAPI"
        Me.radUseAPI.Size = New System.Drawing.Size(106, 17)
        Me.radUseAPI.TabIndex = 7
        Me.radUseAPI.Text = "Use Specific API:"
        Me.radUseAPI.UseVisualStyleBackColor = False
        '
        'radUseAccount
        '
        Me.radUseAccount.AutoSize = True
        Me.radUseAccount.BackColor = System.Drawing.Color.Transparent
        Me.radUseAccount.Checked = True
        Me.radUseAccount.Location = New System.Drawing.Point(3, 12)
        Me.radUseAccount.Name = "radUseAccount"
        Me.radUseAccount.Size = New System.Drawing.Size(129, 17)
        Me.radUseAccount.TabIndex = 6
        Me.radUseAccount.TabStop = True
        Me.radUseAccount.Text = "Use Existing Account:"
        Me.radUseAccount.UseVisualStyleBackColor = False
        '
        'lblAPIStatus
        '
        Me.lblAPIStatus.AutoSize = True
        Me.lblAPIStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblAPIStatus.Enabled = False
        Me.lblAPIStatus.Location = New System.Drawing.Point(88, 113)
        Me.lblAPIStatus.Name = "lblAPIStatus"
        Me.lblAPIStatus.Size = New System.Drawing.Size(154, 13)
        Me.lblAPIStatus.TabIndex = 5
        Me.lblAPIStatus.Text = "API Status: Not yet connected"
        '
        'btnGetCharacters
        '
        Me.btnGetCharacters.Enabled = False
        Me.btnGetCharacters.Location = New System.Drawing.Point(408, 108)
        Me.btnGetCharacters.Name = "btnGetCharacters"
        Me.btnGetCharacters.Size = New System.Drawing.Size(100, 23)
        Me.btnGetCharacters.TabIndex = 4
        Me.btnGetCharacters.Text = "Get Characters"
        Me.btnGetCharacters.UseVisualStyleBackColor = True
        '
        'txtAPIKey
        '
        Me.txtAPIKey.Enabled = False
        Me.txtAPIKey.Location = New System.Drawing.Point(88, 84)
        Me.txtAPIKey.Name = "txtAPIKey"
        Me.txtAPIKey.Size = New System.Drawing.Size(420, 21)
        Me.txtAPIKey.TabIndex = 3
        '
        'lblAPIKey
        '
        Me.lblAPIKey.AutoSize = True
        Me.lblAPIKey.BackColor = System.Drawing.Color.Transparent
        Me.lblAPIKey.Enabled = False
        Me.lblAPIKey.Location = New System.Drawing.Point(25, 87)
        Me.lblAPIKey.Name = "lblAPIKey"
        Me.lblAPIKey.Size = New System.Drawing.Size(49, 13)
        Me.lblAPIKey.TabIndex = 2
        Me.lblAPIKey.Text = "API Key:"
        '
        'txtUserID
        '
        Me.txtUserID.Enabled = False
        Me.txtUserID.Location = New System.Drawing.Point(88, 58)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(100, 21)
        Me.txtUserID.TabIndex = 1
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.BackColor = System.Drawing.Color.Transparent
        Me.lblUserID.Enabled = False
        Me.lblUserID.Location = New System.Drawing.Point(25, 61)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(44, 13)
        Me.lblUserID.TabIndex = 0
        Me.lblUserID.Text = "UserID:"
        '
        'lvwCharacters
        '
        Me.lvwCharacters.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colCharacterName})
        Me.lvwCharacters.FullRowSelect = True
        Me.lvwCharacters.GridLines = True
        Me.lvwCharacters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvwCharacters.HideSelection = False
        Me.lvwCharacters.Location = New System.Drawing.Point(3, 11)
        Me.lvwCharacters.Name = "lvwCharacters"
        Me.lvwCharacters.Size = New System.Drawing.Size(267, 94)
        Me.lvwCharacters.TabIndex = 6
        Me.lvwCharacters.UseCompatibleStateImageBehavior = False
        Me.lvwCharacters.View = System.Windows.Forms.View.Details
        '
        'colCharacterName
        '
        Me.colCharacterName.Width = 240
        '
        'btnFetchKillMails
        '
        Me.btnFetchKillMails.Enabled = False
        Me.btnFetchKillMails.Location = New System.Drawing.Point(170, 108)
        Me.btnFetchKillMails.Name = "btnFetchKillMails"
        Me.btnFetchKillMails.Size = New System.Drawing.Size(100, 23)
        Me.btnFetchKillMails.TabIndex = 5
        Me.btnFetchKillMails.Text = "Fetch Killmails"
        Me.btnFetchKillMails.UseVisualStyleBackColor = True
        '
        'lblKMSummary
        '
        Me.lblKMSummary.AutoSize = True
        Me.lblKMSummary.Location = New System.Drawing.Point(6, 187)
        Me.lblKMSummary.Name = "lblKMSummary"
        Me.lblKMSummary.Size = New System.Drawing.Size(84, 13)
        Me.lblKMSummary.TabIndex = 2
        Me.lblKMSummary.Text = "Killmail Summary"
        '
        'lblKillmailDetails
        '
        Me.lblKillmailDetails.AutoSize = True
        Me.lblKillmailDetails.Location = New System.Drawing.Point(550, 187)
        Me.lblKillmailDetails.Name = "lblKillmailDetails"
        Me.lblKillmailDetails.Size = New System.Drawing.Size(72, 13)
        Me.lblKillmailDetails.TabIndex = 5
        Me.lblKillmailDetails.Text = "Killmail Details"
        '
        'txtKillMailDetails
        '
        Me.txtKillMailDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKillMailDetails.Location = New System.Drawing.Point(547, 203)
        Me.txtKillMailDetails.Multiline = True
        Me.txtKillMailDetails.Name = "txtKillMailDetails"
        Me.txtKillMailDetails.ReadOnly = True
        Me.txtKillMailDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtKillMailDetails.Size = New System.Drawing.Size(282, 491)
        Me.txtKillMailDetails.TabIndex = 6
        '
        'gpAPI
        '
        Me.gpAPI.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpAPI.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpAPI.Controls.Add(Me.cboAccount)
        Me.gpAPI.Controls.Add(Me.radUseAccount)
        Me.gpAPI.Controls.Add(Me.radUseAPI)
        Me.gpAPI.Controls.Add(Me.lblUserID)
        Me.gpAPI.Controls.Add(Me.txtUserID)
        Me.gpAPI.Controls.Add(Me.lblAPIStatus)
        Me.gpAPI.Controls.Add(Me.lblAPIKey)
        Me.gpAPI.Controls.Add(Me.btnGetCharacters)
        Me.gpAPI.Controls.Add(Me.txtAPIKey)
        Me.gpAPI.Location = New System.Drawing.Point(9, 12)
        Me.gpAPI.Name = "gpAPI"
        Me.gpAPI.Size = New System.Drawing.Size(532, 163)
        '
        '
        '
        Me.gpAPI.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpAPI.Style.BackColorGradientAngle = 90
        Me.gpAPI.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpAPI.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpAPI.Style.BorderBottomWidth = 1
        Me.gpAPI.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpAPI.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpAPI.Style.BorderLeftWidth = 1
        Me.gpAPI.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpAPI.Style.BorderRightWidth = 1
        Me.gpAPI.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpAPI.Style.BorderTopWidth = 1
        Me.gpAPI.Style.Class = ""
        Me.gpAPI.Style.CornerDiameter = 4
        Me.gpAPI.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpAPI.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpAPI.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpAPI.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpAPI.StyleMouseDown.Class = ""
        Me.gpAPI.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpAPI.StyleMouseOver.Class = ""
        Me.gpAPI.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpAPI.TabIndex = 9
        Me.gpAPI.Text = "API Information"
        '
        'gpCharacters
        '
        Me.gpCharacters.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpCharacters.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpCharacters.Controls.Add(Me.lvwCharacters)
        Me.gpCharacters.Controls.Add(Me.btnFetchKillMails)
        Me.gpCharacters.Location = New System.Drawing.Point(547, 12)
        Me.gpCharacters.Name = "gpCharacters"
        Me.gpCharacters.Size = New System.Drawing.Size(279, 163)
        '
        '
        '
        Me.gpCharacters.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpCharacters.Style.BackColorGradientAngle = 90
        Me.gpCharacters.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpCharacters.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpCharacters.Style.BorderBottomWidth = 1
        Me.gpCharacters.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpCharacters.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpCharacters.Style.BorderLeftWidth = 1
        Me.gpCharacters.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpCharacters.Style.BorderRightWidth = 1
        Me.gpCharacters.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpCharacters.Style.BorderTopWidth = 1
        Me.gpCharacters.Style.Class = ""
        Me.gpCharacters.Style.CornerDiameter = 4
        Me.gpCharacters.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpCharacters.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpCharacters.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpCharacters.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpCharacters.StyleMouseDown.Class = ""
        Me.gpCharacters.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpCharacters.StyleMouseOver.Class = ""
        Me.gpCharacters.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpCharacters.TabIndex = 10
        Me.gpCharacters.Text = "Available Characters"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.adtKillmails)
        Me.PanelEx1.Controls.Add(Me.btnCopyKillmail)
        Me.PanelEx1.Controls.Add(Me.btnExportToHQF)
        Me.PanelEx1.Controls.Add(Me.gpAPI)
        Me.PanelEx1.Controls.Add(Me.gpCharacters)
        Me.PanelEx1.Controls.Add(Me.btnUploadToBC)
        Me.PanelEx1.Controls.Add(Me.lblKMSummary)
        Me.PanelEx1.Controls.Add(Me.txtKillMailDetails)
        Me.PanelEx1.Controls.Add(Me.lblKillmailDetails)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(841, 735)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 11
        '
        'adtKillmails
        '
        Me.adtKillmails.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.adtKillmails.AllowDrop = True
        Me.adtKillmails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.adtKillmails.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.adtKillmails.BackgroundStyle.Class = "TreeBorderKey"
        Me.adtKillmails.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.adtKillmails.Columns.Add(Me.colVictim)
        Me.adtKillmails.Columns.Add(Me.colShip)
        Me.adtKillmails.Columns.Add(Me.colDate)
        Me.adtKillmails.DragDropEnabled = False
        Me.adtKillmails.DragDropNodeCopyEnabled = False
        Me.adtKillmails.ExpandWidth = 0
        
        Me.adtKillmails.Location = New System.Drawing.Point(9, 203)
        Me.adtKillmails.Name = "adtKillmails"
        Me.adtKillmails.NodesConnector = Me.NodeConnector1
        Me.adtKillmails.NodeStyle = Me.ElementStyle1
        Me.adtKillmails.PathSeparator = ";"
        Me.adtKillmails.Size = New System.Drawing.Size(532, 520)
        Me.adtKillmails.Styles.Add(Me.ElementStyle1)
        Me.adtKillmails.TabIndex = 14
        Me.adtKillmails.Text = "AdvTree1"
        '
        'colVictim
        '
        Me.colVictim.DisplayIndex = 1
        Me.colVictim.Name = "colVictim"
        Me.colVictim.SortingEnabled = False
        Me.colVictim.Text = "Victim"
        Me.colVictim.Width.Absolute = 210
        '
        'colShip
        '
        Me.colShip.DisplayIndex = 2
        Me.colShip.Name = "colShip"
        Me.colShip.SortingEnabled = False
        Me.colShip.Text = "Kill Type"
        Me.colShip.Width.Absolute = 160
        '
        'colDate
        '
        Me.colDate.DisplayIndex = 3
        Me.colDate.Name = "colDate"
        Me.colDate.SortingEnabled = False
        Me.colDate.Text = "Kill Date"
        Me.colDate.Width.Absolute = 120
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
        'btnCopyKillmail
        '
        Me.btnCopyKillmail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCopyKillmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCopyKillmail.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCopyKillmail.Enabled = False
        Me.btnCopyKillmail.Location = New System.Drawing.Point(547, 700)
        Me.btnCopyKillmail.Name = "btnCopyKillmail"
        Me.btnCopyKillmail.Size = New System.Drawing.Size(90, 23)
        Me.btnCopyKillmail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCopyKillmail.TabIndex = 13
        Me.btnCopyKillmail.Text = "Copy Killmail"
        '
        'btnExportToHQF
        '
        Me.btnExportToHQF.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExportToHQF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExportToHQF.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExportToHQF.Enabled = False
        Me.btnExportToHQF.Location = New System.Drawing.Point(643, 700)
        Me.btnExportToHQF.Name = "btnExportToHQF"
        Me.btnExportToHQF.Size = New System.Drawing.Size(90, 23)
        Me.btnExportToHQF.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExportToHQF.TabIndex = 12
        Me.btnExportToHQF.Text = "Export to HQF"
        '
        'frmKMV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 735)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmKMV"
        Me.Text = "EveHQ Killmail Viewer"
        Me.gpAPI.ResumeLayout(False)
        Me.gpAPI.PerformLayout()
        Me.gpCharacters.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.adtKillmails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGetCharacters As System.Windows.Forms.Button
    Friend WithEvents txtAPIKey As System.Windows.Forms.TextBox
    Friend WithEvents lblAPIKey As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents lblAPIStatus As System.Windows.Forms.Label
    Friend WithEvents lvwCharacters As System.Windows.Forms.ListView
    Friend WithEvents btnFetchKillMails As System.Windows.Forms.Button
    Friend WithEvents colCharacterName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblKMSummary As System.Windows.Forms.Label
    Friend WithEvents lblKillmailDetails As System.Windows.Forms.Label
    Friend WithEvents txtKillMailDetails As System.Windows.Forms.TextBox
    Friend WithEvents radUseAPI As System.Windows.Forms.RadioButton
    Friend WithEvents radUseAccount As System.Windows.Forms.RadioButton
    Friend WithEvents cboAccount As System.Windows.Forms.ComboBox
    Friend WithEvents btnUploadToBC As System.Windows.Forms.Button
    Friend WithEvents gpAPI As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents gpCharacters As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnExportToHQF As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCopyKillmail As DevComponents.DotNetBar.ButtonX
    Friend WithEvents adtKillmails As DevComponents.AdvTree.AdvTree
    Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents colVictim As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents colShip As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents colDate As DevComponents.AdvTree.ColumnHeader
End Class
