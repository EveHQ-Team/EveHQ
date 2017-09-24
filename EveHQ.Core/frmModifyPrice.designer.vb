<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModifyPrice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModifyPrice))
        Me.lblCurrentBasePrice = New System.Windows.Forms.Label()
        Me.lblCurrentMarketPrice = New System.Windows.Forms.Label()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtNewPrice = New System.Windows.Forms.TextBox()
        Me.lblNewPrice = New System.Windows.Forms.Label()
        Me.lblCurrentCustomPrice = New System.Windows.Forms.Label()
        Me.lblCustomPrice = New System.Windows.Forms.Label()
        Me.lblMarketPrice = New System.Windows.Forms.Label()
        Me.lblBasePrice = New System.Windows.Forms.Label()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.lblClearingCustomPrice = New System.Windows.Forms.Label()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCurrentBasePrice
        '
        Me.lblCurrentBasePrice.AutoSize = True
        Me.lblCurrentBasePrice.Location = New System.Drawing.Point(23, 11)
        Me.lblCurrentBasePrice.Name = "lblCurrentBasePrice"
        Me.lblCurrentBasePrice.Size = New System.Drawing.Size(100, 13)
        Me.lblCurrentBasePrice.TabIndex = 0
        Me.lblCurrentBasePrice.Text = "Current Base Price:"
        '
        'lblCurrentMarketPrice
        '
        Me.lblCurrentMarketPrice.AutoSize = True
        Me.lblCurrentMarketPrice.Location = New System.Drawing.Point(16, 37)
        Me.lblCurrentMarketPrice.Name = "lblCurrentMarketPrice"
        Me.lblCurrentMarketPrice.Size = New System.Drawing.Size(110, 13)
        Me.lblCurrentMarketPrice.TabIndex = 4
        Me.lblCurrentMarketPrice.Text = "Current Market Price:"
        '
        'btnAccept
        '
        Me.Highlighter1.SetHighlightOnFocus(Me.btnAccept, True)
        Me.btnAccept.Location = New System.Drawing.Point(202, 138)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 1
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Highlighter1.SetHighlightOnFocus(Me.btnCancel, True)
        Me.btnCancel.Location = New System.Drawing.Point(283, 138)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtNewPrice
        '
        Me.Highlighter1.SetHighlightOnFocus(Me.txtNewPrice, True)
        Me.txtNewPrice.Location = New System.Drawing.Point(141, 87)
        Me.txtNewPrice.Name = "txtNewPrice"
        Me.txtNewPrice.Size = New System.Drawing.Size(208, 21)
        Me.txtNewPrice.TabIndex = 0
        '
        'lblNewPrice
        '
        Me.lblNewPrice.AutoSize = True
        Me.lblNewPrice.Location = New System.Drawing.Point(26, 90)
        Me.lblNewPrice.Name = "lblNewPrice"
        Me.lblNewPrice.Size = New System.Drawing.Size(97, 13)
        Me.lblNewPrice.TabIndex = 16
        Me.lblNewPrice.Text = "New Custom Price:"
        '
        'lblCurrentCustomPrice
        '
        Me.lblCurrentCustomPrice.AutoSize = True
        Me.lblCurrentCustomPrice.Location = New System.Drawing.Point(13, 63)
        Me.lblCurrentCustomPrice.Name = "lblCurrentCustomPrice"
        Me.lblCurrentCustomPrice.Size = New System.Drawing.Size(113, 13)
        Me.lblCurrentCustomPrice.TabIndex = 19
        Me.lblCurrentCustomPrice.Text = "Current Custom Price:"
        '
        'lblCustomPrice
        '
        Me.lblCustomPrice.AutoSize = True
        Me.lblCustomPrice.Location = New System.Drawing.Point(138, 63)
        Me.lblCustomPrice.Name = "lblCustomPrice"
        Me.lblCustomPrice.Size = New System.Drawing.Size(29, 13)
        Me.lblCustomPrice.TabIndex = 22
        Me.lblCustomPrice.Text = "0.00"
        '
        'lblMarketPrice
        '
        Me.lblMarketPrice.AutoSize = True
        Me.lblMarketPrice.Location = New System.Drawing.Point(138, 37)
        Me.lblMarketPrice.Name = "lblMarketPrice"
        Me.lblMarketPrice.Size = New System.Drawing.Size(29, 13)
        Me.lblMarketPrice.TabIndex = 21
        Me.lblMarketPrice.Text = "0.00"
        '
        'lblBasePrice
        '
        Me.lblBasePrice.AutoSize = True
        Me.lblBasePrice.Location = New System.Drawing.Point(138, 11)
        Me.lblBasePrice.Name = "lblBasePrice"
        Me.lblBasePrice.Size = New System.Drawing.Size(29, 13)
        Me.lblBasePrice.TabIndex = 20
        Me.lblBasePrice.Text = "0.00"
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        Me.Highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Green
        
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.lblClearingCustomPrice)
        Me.PanelEx1.Controls.Add(Me.lblCurrentBasePrice)
        Me.PanelEx1.Controls.Add(Me.lblCustomPrice)
        Me.PanelEx1.Controls.Add(Me.lblCurrentMarketPrice)
        Me.PanelEx1.Controls.Add(Me.lblMarketPrice)
        Me.PanelEx1.Controls.Add(Me.btnAccept)
        Me.PanelEx1.Controls.Add(Me.lblBasePrice)
        Me.PanelEx1.Controls.Add(Me.btnCancel)
        Me.PanelEx1.Controls.Add(Me.lblCurrentCustomPrice)
        Me.PanelEx1.Controls.Add(Me.lblNewPrice)
        Me.PanelEx1.Controls.Add(Me.txtNewPrice)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(361, 164)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 23
        '
        'lblClearingCustomPrice
        '
        Me.lblClearingCustomPrice.AutoSize = True
        Me.lblClearingCustomPrice.ForeColor = System.Drawing.Color.DarkRed
        Me.lblClearingCustomPrice.Location = New System.Drawing.Point(7, 111)
        Me.lblClearingCustomPrice.Name = "lblClearingCustomPrice"
        Me.lblClearingCustomPrice.Size = New System.Drawing.Size(334, 13)
        Me.lblClearingCustomPrice.TabIndex = 23
        Me.lblClearingCustomPrice.Text = "Warning: Custom Price will be deleted when new price is set to zero."
        Me.lblClearingCustomPrice.Visible = False
        '
        'frmModifyPrice
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(361, 164)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmModifyPrice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modify Custom Price"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblCurrentBasePrice As System.Windows.Forms.Label
    Friend WithEvents lblCurrentMarketPrice As System.Windows.Forms.Label
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtNewPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblNewPrice As System.Windows.Forms.Label
    Friend WithEvents lblCurrentCustomPrice As System.Windows.Forms.Label
    Friend WithEvents lblCustomPrice As System.Windows.Forms.Label
    Friend WithEvents lblMarketPrice As System.Windows.Forms.Label
    Friend WithEvents lblBasePrice As System.Windows.Forms.Label
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblClearingCustomPrice As System.Windows.Forms.Label
End Class
