Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmModifyEvePilots
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
            Me.lblPilotName = New System.Windows.Forms.Label
            Me.txtPilotName = New System.Windows.Forms.TextBox
            Me.btnAccept = New System.Windows.Forms.Button
            Me.btnCancel = New System.Windows.Forms.Button
            Me.Label1 = New System.Windows.Forms.Label
            Me.txtPilotID = New System.Windows.Forms.TextBox
            Me.Label2 = New System.Windows.Forms.Label
            Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter
            Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
            Me.PanelEx1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblPilotName
            '
            Me.lblPilotName.AutoSize = True
            Me.lblPilotName.Location = New System.Drawing.Point(13, 40)
            Me.lblPilotName.Name = "lblPilotName"
            Me.lblPilotName.Size = New System.Drawing.Size(61, 13)
            Me.lblPilotName.TabIndex = 0
            Me.lblPilotName.Text = "Pilot Name:"
            '
            'txtPilotName
            '
            Me.Highlighter1.SetHighlightOnFocus(Me.txtPilotName, True)
            Me.txtPilotName.Location = New System.Drawing.Point(85, 37)
            Me.txtPilotName.Name = "txtPilotName"
            Me.txtPilotName.Size = New System.Drawing.Size(188, 21)
            Me.txtPilotName.TabIndex = 0
            '
            'btnAccept
            '
            Me.Highlighter1.SetHighlightOnFocus(Me.btnAccept, True)
            Me.btnAccept.Location = New System.Drawing.Point(117, 100)
            Me.btnAccept.Name = "btnAccept"
            Me.btnAccept.Size = New System.Drawing.Size(75, 23)
            Me.btnAccept.TabIndex = 2
            Me.btnAccept.Text = "Add"
            Me.btnAccept.UseVisualStyleBackColor = True
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Highlighter1.SetHighlightOnFocus(Me.btnCancel, True)
            Me.btnCancel.Location = New System.Drawing.Point(198, 100)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.TabIndex = 3
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.Location = New System.Drawing.Point(13, 11)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(259, 23)
            Me.Label1.TabIndex = 6
            Me.Label1.Text = "Please enter the name and ID of your pilot." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'txtPilotID
            '
            Me.Highlighter1.SetHighlightOnFocus(Me.txtPilotID, True)
            Me.txtPilotID.Location = New System.Drawing.Point(85, 63)
            Me.txtPilotID.Name = "txtPilotID"
            Me.txtPilotID.Size = New System.Drawing.Size(188, 21)
            Me.txtPilotID.TabIndex = 1
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(13, 66)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(45, 13)
            Me.Label2.TabIndex = 7
            Me.Label2.Text = "Pilot ID:"
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
            Me.PanelEx1.Controls.Add(Me.Label1)
            Me.PanelEx1.Controls.Add(Me.txtPilotID)
            Me.PanelEx1.Controls.Add(Me.lblPilotName)
            Me.PanelEx1.Controls.Add(Me.Label2)
            Me.PanelEx1.Controls.Add(Me.txtPilotName)
            Me.PanelEx1.Controls.Add(Me.btnAccept)
            Me.PanelEx1.Controls.Add(Me.btnCancel)
            Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
            Me.PanelEx1.Name = "PanelEx1"
            Me.PanelEx1.Size = New System.Drawing.Size(283, 131)
            Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.PanelEx1.Style.GradientAngle = 90
            Me.PanelEx1.TabIndex = 8
            '
            'frmModifyEvePilots
            '
            Me.AcceptButton = Me.btnAccept
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(283, 131)
            Me.Controls.Add(Me.PanelEx1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmModifyEvePilots"
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Modify Eve Pilot"
            Me.PanelEx1.ResumeLayout(False)
            Me.PanelEx1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblPilotName As System.Windows.Forms.Label
        Friend WithEvents txtPilotName As System.Windows.Forms.TextBox
        Friend WithEvents btnAccept As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtPilotID As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
        Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    End Class
End NameSpace