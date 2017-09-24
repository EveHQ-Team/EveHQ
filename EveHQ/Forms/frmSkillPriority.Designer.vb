Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmSkillPriority
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSkillPriority))
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnAccept = New System.Windows.Forms.Button()
            Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
            Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
            Me.nudPriority = New DevComponents.Editors.IntegerInput()
            Me.lblDescription = New System.Windows.Forms.Label()
            Me.PanelEx1.SuspendLayout()
            CType(Me.nudPriority, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Highlighter1.SetHighlightOnFocus(Me.btnCancel, True)
            Me.btnCancel.Location = New System.Drawing.Point(159, 91)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = True
            '
            'btnAccept
            '
            Me.btnAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Highlighter1.SetHighlightOnFocus(Me.btnAccept, True)
            Me.btnAccept.Location = New System.Drawing.Point(78, 91)
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
            Me.PanelEx1.Controls.Add(Me.nudPriority)
            Me.PanelEx1.Controls.Add(Me.btnAccept)
            Me.PanelEx1.Controls.Add(Me.btnCancel)
            Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
            Me.PanelEx1.Name = "PanelEx1"
            Me.PanelEx1.Size = New System.Drawing.Size(243, 126)
            Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.PanelEx1.Style.GradientAngle = 90
            Me.PanelEx1.TabIndex = 3
            '
            'nudPriority
            '
            '
            '
            '
            Me.nudPriority.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.nudPriority.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.nudPriority.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.nudPriority.Location = New System.Drawing.Point(53, 49)
            Me.nudPriority.MaxValue = 100
            Me.nudPriority.MinValue = 0
            Me.nudPriority.Name = "nudPriority"
            Me.nudPriority.ShowUpDown = True
            Me.nudPriority.Size = New System.Drawing.Size(136, 21)
            Me.nudPriority.TabIndex = 0
            '
            'lblDescription
            '
            Me.lblDescription.AutoSize = True
            Me.lblDescription.Location = New System.Drawing.Point(12, 18)
            Me.lblDescription.Name = "lblDescription"
            Me.lblDescription.Size = New System.Drawing.Size(216, 13)
            Me.lblDescription.TabIndex = 4
            Me.lblDescription.Text = "Enter a priority value between 0 and 100..."
            '
            'FrmSkillPriority
            '
            Me.AcceptButton = Me.btnAccept
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(243, 126)
            Me.Controls.Add(Me.PanelEx1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmSkillPriority"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Change Skill Priority"
            Me.PanelEx1.ResumeLayout(False)
            Me.PanelEx1.PerformLayout()
            CType(Me.nudPriority, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnAccept As System.Windows.Forms.Button
        Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
        Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
        Friend WithEvents nudPriority As DevComponents.Editors.IntegerInput
        Friend WithEvents lblDescription As System.Windows.Forms.Label
    End Class
End NameSpace