Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmSkillNote
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSkillNote))
            Me.lblDescription = New System.Windows.Forms.Label
            Me.txtNotes = New System.Windows.Forms.TextBox
            Me.btnCancel = New System.Windows.Forms.Button
            Me.btnAccept = New System.Windows.Forms.Button
            Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter
            Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
            Me.PanelEx1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblDescription
            '
            Me.lblDescription.AutoSize = True
            Me.lblDescription.Location = New System.Drawing.Point(14, 12)
            Me.lblDescription.Name = "lblDescription"
            Me.lblDescription.Size = New System.Drawing.Size(91, 13)
            Me.lblDescription.TabIndex = 0
            Me.lblDescription.Text = "Edit notes for skill"
            '
            'txtNotes
            '
            Me.Highlighter1.SetHighlightOnFocus(Me.txtNotes, True)
            Me.txtNotes.Location = New System.Drawing.Point(14, 37)
            Me.txtNotes.Multiline = True
            Me.txtNotes.Name = "txtNotes"
            Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtNotes.Size = New System.Drawing.Size(484, 189)
            Me.txtNotes.TabIndex = 0
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Highlighter1.SetHighlightOnFocus(Me.btnCancel, True)
            Me.btnCancel.Location = New System.Drawing.Point(423, 232)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = True
            '
            'btnAccept
            '
            Me.Highlighter1.SetHighlightOnFocus(Me.btnAccept, True)
            Me.btnAccept.Location = New System.Drawing.Point(342, 232)
            Me.btnAccept.Name = "btnAccept"
            Me.btnAccept.Size = New System.Drawing.Size(75, 23)
            Me.btnAccept.TabIndex = 1
            Me.btnAccept.Text = "Accept"
            Me.btnAccept.UseVisualStyleBackColor = True
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
            Me.PanelEx1.Controls.Add(Me.lblDescription)
            Me.PanelEx1.Controls.Add(Me.btnAccept)
            Me.PanelEx1.Controls.Add(Me.txtNotes)
            Me.PanelEx1.Controls.Add(Me.btnCancel)
            Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
            Me.PanelEx1.Name = "PanelEx1"
            Me.PanelEx1.Size = New System.Drawing.Size(507, 267)
            Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.PanelEx1.Style.GradientAngle = 90
            Me.PanelEx1.TabIndex = 3
            '
            'frmSkillNote
            '
            Me.AcceptButton = Me.btnAccept
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(507, 267)
            Me.Controls.Add(Me.PanelEx1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmSkillNote"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Skill Note"
            Me.PanelEx1.ResumeLayout(False)
            Me.PanelEx1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblDescription As System.Windows.Forms.Label
        Friend WithEvents txtNotes As System.Windows.Forms.TextBox
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnAccept As System.Windows.Forms.Button
        Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
        Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    End Class
End NameSpace