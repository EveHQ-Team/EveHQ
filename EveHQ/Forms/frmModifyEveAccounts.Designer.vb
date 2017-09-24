Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmModifyEveAccounts
        Inherits DevComponents.DotNetBar.Office2007Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModifyEveAccounts))
            Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
            Me.txtUserIDV2 = New System.Windows.Forms.TextBox()
            Me.btnCancelV2 = New System.Windows.Forms.Button()
            Me.btnAcceptV2 = New System.Windows.Forms.Button()
            Me.txtAPIKeyV2 = New System.Windows.Forms.TextBox()
            Me.txtAccountNameV2 = New System.Windows.Forms.TextBox()
            Me.btnCheckV2 = New System.Windows.Forms.Button()
            Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
            Me.lblAPIHelpLbl = New System.Windows.Forms.Label()
            Me.lblAPIAccessMask = New System.Windows.Forms.Label()
            Me.lblAPIAccessMaskLbl = New System.Windows.Forms.Label()
            Me.lblGetAPIKeyV2 = New System.Windows.Forms.LinkLabel()
            Me.lblV2Info = New System.Windows.Forms.Label()
            Me.lblFindAPIKeyV2 = New System.Windows.Forms.Label()
            Me.lblAPIKeyTypeV2 = New System.Windows.Forms.Label()
            Me.lblAPIKeyTypeLblV2 = New System.Windows.Forms.Label()
            Me.lblAccountNameV2 = New System.Windows.Forms.Label()
            Me.lblUserIDV2 = New System.Windows.Forms.Label()
            Me.lblAPIKeyV2 = New System.Windows.Forms.Label()
            Me.PanelEx1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Highlighter1
            '
            Me.Highlighter1.ContainerControl = Me
            Me.Highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Green
            
            '
            'txtUserIDV2
            '
            Me.Highlighter1.SetHighlightOnFocus(Me.txtUserIDV2, True)
            Me.txtUserIDV2.Location = New System.Drawing.Point(99, 122)
            Me.txtUserIDV2.Name = "txtUserIDV2"
            Me.txtUserIDV2.Size = New System.Drawing.Size(107, 21)
            Me.txtUserIDV2.TabIndex = 14
            '
            'btnCancelV2
            '
            Me.btnCancelV2.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Highlighter1.SetHighlightOnFocus(Me.btnCancelV2, True)
            Me.btnCancelV2.Location = New System.Drawing.Point(440, 253)
            Me.btnCancelV2.Name = "btnCancelV2"
            Me.btnCancelV2.Size = New System.Drawing.Size(75, 23)
            Me.btnCancelV2.TabIndex = 19
            Me.btnCancelV2.Text = "Cancel"
            Me.btnCancelV2.UseVisualStyleBackColor = True
            '
            'btnAcceptV2
            '
            Me.Highlighter1.SetHighlightOnFocus(Me.btnAcceptV2, True)
            Me.btnAcceptV2.Location = New System.Drawing.Point(359, 253)
            Me.btnAcceptV2.Name = "btnAcceptV2"
            Me.btnAcceptV2.Size = New System.Drawing.Size(75, 23)
            Me.btnAcceptV2.TabIndex = 18
            Me.btnAcceptV2.Text = "Add"
            Me.btnAcceptV2.UseVisualStyleBackColor = True
            '
            'txtAPIKeyV2
            '
            Me.Highlighter1.SetHighlightOnFocus(Me.txtAPIKeyV2, True)
            Me.txtAPIKeyV2.Location = New System.Drawing.Point(99, 148)
            Me.txtAPIKeyV2.Name = "txtAPIKeyV2"
            Me.txtAPIKeyV2.Size = New System.Drawing.Size(416, 21)
            Me.txtAPIKeyV2.TabIndex = 16
            '
            'txtAccountNameV2
            '
            Me.Highlighter1.SetHighlightOnFocus(Me.txtAccountNameV2, True)
            Me.txtAccountNameV2.Location = New System.Drawing.Point(99, 174)
            Me.txtAccountNameV2.Name = "txtAccountNameV2"
            Me.txtAccountNameV2.Size = New System.Drawing.Size(107, 21)
            Me.txtAccountNameV2.TabIndex = 17
            '
            'btnCheckV2
            '
            Me.Highlighter1.SetHighlightOnFocus(Me.btnCheckV2, True)
            Me.btnCheckV2.Location = New System.Drawing.Point(278, 253)
            Me.btnCheckV2.Name = "btnCheckV2"
            Me.btnCheckV2.Size = New System.Drawing.Size(75, 23)
            Me.btnCheckV2.TabIndex = 27
            Me.btnCheckV2.Text = "Check API"
            Me.btnCheckV2.UseVisualStyleBackColor = True
            '
            'PanelEx1
            '
            Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
            Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.PanelEx1.Controls.Add(Me.lblAPIHelpLbl)
            Me.PanelEx1.Controls.Add(Me.lblAPIAccessMask)
            Me.PanelEx1.Controls.Add(Me.lblAPIAccessMaskLbl)
            Me.PanelEx1.Controls.Add(Me.btnCheckV2)
            Me.PanelEx1.Controls.Add(Me.lblGetAPIKeyV2)
            Me.PanelEx1.Controls.Add(Me.lblV2Info)
            Me.PanelEx1.Controls.Add(Me.txtUserIDV2)
            Me.PanelEx1.Controls.Add(Me.lblAPIKeyV2)
            Me.PanelEx1.Controls.Add(Me.txtAccountNameV2)
            Me.PanelEx1.Controls.Add(Me.lblFindAPIKeyV2)
            Me.PanelEx1.Controls.Add(Me.lblUserIDV2)
            Me.PanelEx1.Controls.Add(Me.lblAPIKeyTypeV2)
            Me.PanelEx1.Controls.Add(Me.lblAccountNameV2)
            Me.PanelEx1.Controls.Add(Me.btnCancelV2)
            Me.PanelEx1.Controls.Add(Me.txtAPIKeyV2)
            Me.PanelEx1.Controls.Add(Me.lblAPIKeyTypeLblV2)
            Me.PanelEx1.Controls.Add(Me.btnAcceptV2)
            Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
            Me.PanelEx1.Name = "PanelEx1"
            Me.PanelEx1.Size = New System.Drawing.Size(529, 288)
            Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.PanelEx1.Style.GradientAngle = 90
            Me.PanelEx1.TabIndex = 11
            '
            'lblAPIHelpLbl
            '
            Me.lblAPIHelpLbl.AutoSize = True
            Me.lblAPIHelpLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblAPIHelpLbl.Location = New System.Drawing.Point(12, 113)
            Me.lblAPIHelpLbl.Name = "lblAPIHelpLbl"
            Me.lblAPIHelpLbl.Size = New System.Drawing.Size(0, 13)
            Me.lblAPIHelpLbl.TabIndex = 30
            '
            'lblAPIAccessMask
            '
            Me.lblAPIAccessMask.AutoSize = True
            Me.lblAPIAccessMask.BackColor = System.Drawing.Color.Transparent
            Me.lblAPIAccessMask.Location = New System.Drawing.Point(101, 222)
            Me.lblAPIAccessMask.Name = "lblAPIAccessMask"
            Me.lblAPIAccessMask.Size = New System.Drawing.Size(51, 13)
            Me.lblAPIAccessMask.TabIndex = 29
            Me.lblAPIAccessMask.Text = "Unknown"
            '
            'lblAPIAccessMaskLbl
            '
            Me.lblAPIAccessMaskLbl.AutoSize = True
            Me.lblAPIAccessMaskLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblAPIAccessMaskLbl.Location = New System.Drawing.Point(13, 222)
            Me.lblAPIAccessMaskLbl.Name = "lblAPIAccessMaskLbl"
            Me.lblAPIAccessMaskLbl.Size = New System.Drawing.Size(71, 13)
            Me.lblAPIAccessMaskLbl.TabIndex = 28
            Me.lblAPIAccessMaskLbl.Text = "Access Mask:"
            '
            'lblGetAPIKeyV2
            '
            Me.lblGetAPIKeyV2.AutoSize = True
            Me.lblGetAPIKeyV2.BackColor = System.Drawing.Color.Transparent
            Me.lblGetAPIKeyV2.Location = New System.Drawing.Point(216, 91)
            Me.lblGetAPIKeyV2.Name = "lblGetAPIKeyV2"
            Me.lblGetAPIKeyV2.Size = New System.Drawing.Size(172, 13)
            Me.lblGetAPIKeyV2.TabIndex = 20
            Me.lblGetAPIKeyV2.TabStop = True
            Me.lblGetAPIKeyV2.Text = "https://community.eveonline.com/support/api-key/"
            '
            'lblV2Info
            '
            Me.lblV2Info.BackColor = System.Drawing.Color.Transparent
            Me.lblV2Info.Location = New System.Drawing.Point(12, 9)
            Me.lblV2Info.Name = "lblV2Info"
            Me.lblV2Info.Size = New System.Drawing.Size(503, 66)
            Me.lblV2Info.TabIndex = 21
            Me.lblV2Info.Text = resources.GetString("lblV2Info.Text")
            Me.lblV2Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblFindAPIKeyV2
            '
            Me.lblFindAPIKeyV2.AutoSize = True
            Me.lblFindAPIKeyV2.BackColor = System.Drawing.Color.Transparent
            Me.lblFindAPIKeyV2.Location = New System.Drawing.Point(12, 91)
            Me.lblFindAPIKeyV2.Name = "lblFindAPIKeyV2"
            Me.lblFindAPIKeyV2.Size = New System.Drawing.Size(208, 13)
            Me.lblFindAPIKeyV2.TabIndex = 23
            Me.lblFindAPIKeyV2.Text = "You can create your KeyID and vCode at:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            '
            'lblAPIKeyTypeV2
            '
            Me.lblAPIKeyTypeV2.AutoSize = True
            Me.lblAPIKeyTypeV2.BackColor = System.Drawing.Color.Transparent
            Me.lblAPIKeyTypeV2.Location = New System.Drawing.Point(101, 200)
            Me.lblAPIKeyTypeV2.Name = "lblAPIKeyTypeV2"
            Me.lblAPIKeyTypeV2.Size = New System.Drawing.Size(51, 13)
            Me.lblAPIKeyTypeV2.TabIndex = 25
            Me.lblAPIKeyTypeV2.Text = "Unknown"
            '
            'lblAPIKeyTypeLblV2
            '
            Me.lblAPIKeyTypeLblV2.AutoSize = True
            Me.lblAPIKeyTypeLblV2.BackColor = System.Drawing.Color.Transparent
            Me.lblAPIKeyTypeLblV2.Location = New System.Drawing.Point(12, 200)
            Me.lblAPIKeyTypeLblV2.Name = "lblAPIKeyTypeLblV2"
            Me.lblAPIKeyTypeLblV2.Size = New System.Drawing.Size(76, 13)
            Me.lblAPIKeyTypeLblV2.TabIndex = 24
            Me.lblAPIKeyTypeLblV2.Text = "API Key Type:"
            '
            'lblAccountNameV2
            '
            Me.lblAccountNameV2.AutoSize = True
            Me.lblAccountNameV2.BackColor = System.Drawing.Color.Transparent
            Me.lblAccountNameV2.Location = New System.Drawing.Point(12, 177)
            Me.lblAccountNameV2.Name = "lblAccountNameV2"
            Me.lblAccountNameV2.Size = New System.Drawing.Size(80, 13)
            Me.lblAccountNameV2.TabIndex = 22
            Me.lblAccountNameV2.Text = "Account Name:"
            '
            'lblUserIDV2
            '
            Me.lblUserIDV2.AutoSize = True
            Me.lblUserIDV2.BackColor = System.Drawing.Color.Transparent
            Me.lblUserIDV2.Location = New System.Drawing.Point(12, 125)
            Me.lblUserIDV2.Name = "lblUserIDV2"
            Me.lblUserIDV2.Size = New System.Drawing.Size(43, 13)
            Me.lblUserIDV2.TabIndex = 13
            Me.lblUserIDV2.Text = "Key ID:"
            '
            'lblAPIKeyV2
            '
            Me.lblAPIKeyV2.AutoSize = True
            Me.lblAPIKeyV2.BackColor = System.Drawing.Color.Transparent
            Me.lblAPIKeyV2.Location = New System.Drawing.Point(12, 151)
            Me.lblAPIKeyV2.Name = "lblAPIKeyV2"
            Me.lblAPIKeyV2.Size = New System.Drawing.Size(42, 13)
            Me.lblAPIKeyV2.TabIndex = 15
            Me.lblAPIKeyV2.Text = "vCode:"
            '
            'frmModifyEveAccounts
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(529, 288)
            Me.Controls.Add(Me.PanelEx1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmModifyEveAccounts"
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Modify Eve Account"
            Me.PanelEx1.ResumeLayout(False)
            Me.PanelEx1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
        Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
        Friend WithEvents txtUserIDV2 As System.Windows.Forms.TextBox
        Friend WithEvents lblV2Info As System.Windows.Forms.Label
        Friend WithEvents lblFindAPIKeyV2 As System.Windows.Forms.Label
        Friend WithEvents lblAPIKeyTypeV2 As System.Windows.Forms.Label
        Friend WithEvents lblGetAPIKeyV2 As System.Windows.Forms.LinkLabel
        Friend WithEvents btnCancelV2 As System.Windows.Forms.Button
        Friend WithEvents lblAPIKeyTypeLblV2 As System.Windows.Forms.Label
        Friend WithEvents btnAcceptV2 As System.Windows.Forms.Button
        Friend WithEvents txtAPIKeyV2 As System.Windows.Forms.TextBox
        Friend WithEvents lblAccountNameV2 As System.Windows.Forms.Label
        Friend WithEvents lblUserIDV2 As System.Windows.Forms.Label
        Friend WithEvents txtAccountNameV2 As System.Windows.Forms.TextBox
        Friend WithEvents lblAPIKeyV2 As System.Windows.Forms.Label
        Friend WithEvents btnCheckV2 As System.Windows.Forms.Button
        Friend WithEvents lblAPIAccessMask As System.Windows.Forms.Label
        Friend WithEvents lblAPIAccessMaskLbl As System.Windows.Forms.Label
        Friend WithEvents lblAPIHelpLbl As System.Windows.Forms.Label
    End Class
End NameSpace