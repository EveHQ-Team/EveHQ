Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmShipClassEditor
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
            Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
            Me.btnAccept = New DevComponents.DotNetBar.ButtonX
            Me.btnCancel = New DevComponents.DotNetBar.ButtonX
            Me.txtDescription = New DevComponents.DotNetBar.Controls.TextBoxX
            Me.lblDescription = New DevComponents.DotNetBar.LabelX
            Me.txtClassName = New DevComponents.DotNetBar.Controls.TextBoxX
            Me.lblClassName = New DevComponents.DotNetBar.LabelX
            Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter
            Me.PanelEx1.SuspendLayout()
            Me.SuspendLayout()
            '
            'PanelEx1
            '
            Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
            Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.PanelEx1.Controls.Add(Me.btnAccept)
            Me.PanelEx1.Controls.Add(Me.btnCancel)
            Me.PanelEx1.Controls.Add(Me.txtDescription)
            Me.PanelEx1.Controls.Add(Me.lblDescription)
            Me.PanelEx1.Controls.Add(Me.txtClassName)
            Me.PanelEx1.Controls.Add(Me.lblClassName)
            Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
            Me.PanelEx1.Name = "PanelEx1"
            Me.PanelEx1.Size = New System.Drawing.Size(394, 276)
            Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.PanelEx1.Style.GradientAngle = 90
            Me.PanelEx1.TabIndex = 0
            '
            'btnAccept
            '
            Me.btnAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.Highlighter1.SetHighlightOnFocus(Me.btnAccept, True)
            Me.btnAccept.Location = New System.Drawing.Point(230, 248)
            Me.btnAccept.Name = "btnAccept"
            Me.btnAccept.Size = New System.Drawing.Size(75, 23)
            Me.btnAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnAccept.TabIndex = 2
            Me.btnAccept.Text = "Accept"
            '
            'btnCancel
            '
            Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Highlighter1.SetHighlightOnFocus(Me.btnCancel, True)
            Me.btnCancel.Location = New System.Drawing.Point(311, 248)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnCancel.TabIndex = 3
            Me.btnCancel.Text = "Cancel"
            '
            'txtDescription
            '
            '
            '
            '
            Me.txtDescription.Border.Class = "TextBoxBorder"
            Me.txtDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.Highlighter1.SetHighlightOnFocus(Me.txtDescription, True)
            Me.txtDescription.Location = New System.Drawing.Point(148, 41)
            Me.txtDescription.MaxLength = 1000
            Me.txtDescription.Multiline = True
            Me.txtDescription.Name = "txtDescription"
            Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtDescription.Size = New System.Drawing.Size(238, 203)
            Me.txtDescription.TabIndex = 1
            Me.txtDescription.WatermarkColor = System.Drawing.Color.Silver
            Me.txtDescription.WatermarkText = "You can write an optional short description of the new ship class here. This will" & _
                                              " be used for informational purposes only."
            '
            'lblDescription
            '
            '
            '
            '
            Me.lblDescription.BackgroundStyle.Class = ""
            Me.lblDescription.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblDescription.Location = New System.Drawing.Point(12, 38)
            Me.lblDescription.Name = "lblDescription"
            Me.lblDescription.Size = New System.Drawing.Size(130, 23)
            Me.lblDescription.TabIndex = 2
            Me.lblDescription.Text = "Ship Class Description:"
            '
            'txtClassName
            '
            '
            '
            '
            Me.txtClassName.Border.Class = "TextBoxBorder"
            Me.txtClassName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.Highlighter1.SetHighlightOnFocus(Me.txtClassName, True)
            Me.txtClassName.Location = New System.Drawing.Point(148, 15)
            Me.txtClassName.Name = "txtClassName"
            Me.txtClassName.Size = New System.Drawing.Size(238, 21)
            Me.txtClassName.TabIndex = 0
            '
            'lblClassName
            '
            '
            '
            '
            Me.lblClassName.BackgroundStyle.Class = ""
            Me.lblClassName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblClassName.Location = New System.Drawing.Point(12, 12)
            Me.lblClassName.Name = "lblClassName"
            Me.lblClassName.Size = New System.Drawing.Size(114, 23)
            Me.lblClassName.TabIndex = 0
            Me.lblClassName.Text = "Ship Class Name:"
            '
            'Highlighter1
            '
            Me.Highlighter1.ContainerControl = Me
            Me.Highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Green
            
            '
            'frmShipClassEditor
            '
            Me.AcceptButton = Me.btnAccept
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(394, 276)
            Me.Controls.Add(Me.PanelEx1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmShipClassEditor"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "HQF Ship Class Editor"
            Me.PanelEx1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
        Friend WithEvents txtDescription As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents lblDescription As DevComponents.DotNetBar.LabelX
        Friend WithEvents txtClassName As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents lblClassName As DevComponents.DotNetBar.LabelX
        Friend WithEvents btnAccept As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
        Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    End Class
End NameSpace