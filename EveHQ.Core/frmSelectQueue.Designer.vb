<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelectQueue
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
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblQueueName = New System.Windows.Forms.Label()
        Me.radNewQueue = New System.Windows.Forms.RadioButton()
        Me.radExistingQueue = New System.Windows.Forms.RadioButton()
        Me.txtQueueName = New System.Windows.Forms.TextBox()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.cboQueueName = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnAccept = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(12, 9)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(259, 36)
        Me.lblDescription.TabIndex = 13
        Me.lblDescription.Text = "Please choose a method of entering the skills onto a skill queue..."
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQueueName
        '
        Me.lblQueueName.AutoSize = True
        Me.lblQueueName.Location = New System.Drawing.Point(10, 125)
        Me.lblQueueName.Name = "lblQueueName"
        Me.lblQueueName.Size = New System.Drawing.Size(73, 13)
        Me.lblQueueName.TabIndex = 9
        Me.lblQueueName.Text = "Queue Name:"
        '
        'radNewQueue
        '
        Me.radNewQueue.AutoSize = True
        Me.radNewQueue.Location = New System.Drawing.Point(15, 86)
        Me.radNewQueue.Name = "radNewQueue"
        Me.radNewQueue.Size = New System.Drawing.Size(101, 17)
        Me.radNewQueue.TabIndex = 14
        Me.radNewQueue.Text = "New Skill Queue"
        Me.radNewQueue.UseVisualStyleBackColor = True
        '
        'radExistingQueue
        '
        Me.radExistingQueue.AutoSize = True
        Me.radExistingQueue.Checked = True
        Me.radExistingQueue.Location = New System.Drawing.Point(15, 63)
        Me.radExistingQueue.Name = "radExistingQueue"
        Me.radExistingQueue.Size = New System.Drawing.Size(117, 17)
        Me.radExistingQueue.TabIndex = 15
        Me.radExistingQueue.TabStop = True
        Me.radExistingQueue.Text = "Existing Skill Queue"
        Me.radExistingQueue.UseVisualStyleBackColor = True
        '
        'txtQueueName
        '
        Me.Highlighter1.SetHighlightOnFocus(Me.txtQueueName, True)
        Me.txtQueueName.Location = New System.Drawing.Point(89, 122)
        Me.txtQueueName.Name = "txtQueueName"
        Me.txtQueueName.Size = New System.Drawing.Size(188, 21)
        Me.txtQueueName.TabIndex = 3
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
        Me.PanelEx1.Controls.Add(Me.cboQueueName)
        Me.PanelEx1.Controls.Add(Me.btnCancel)
        Me.PanelEx1.Controls.Add(Me.btnAccept)
        Me.PanelEx1.Controls.Add(Me.lblDescription)
        Me.PanelEx1.Controls.Add(Me.lblQueueName)
        Me.PanelEx1.Controls.Add(Me.radExistingQueue)
        Me.PanelEx1.Controls.Add(Me.txtQueueName)
        Me.PanelEx1.Controls.Add(Me.radNewQueue)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(292, 194)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 16
        '
        'cboQueueName
        '
        Me.cboQueueName.DisplayMember = "Text"
        Me.cboQueueName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboQueueName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQueueName.FormattingEnabled = True
        Me.cboQueueName.ItemHeight = 15
        Me.cboQueueName.Location = New System.Drawing.Point(89, 122)
        Me.cboQueueName.Name = "cboQueueName"
        Me.cboQueueName.Size = New System.Drawing.Size(188, 21)
        Me.cboQueueName.Sorted = True
        Me.cboQueueName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboQueueName.TabIndex = 18
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(202, 159)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        '
        'btnAccept
        '
        Me.btnAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAccept.Location = New System.Drawing.Point(121, 159)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAccept.TabIndex = 16
        Me.btnAccept.Text = "Add"
        '
        'frmSelectQueue
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(292, 194)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectQueue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add to Skill Queue"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblQueueName As System.Windows.Forms.Label
    Friend WithEvents radNewQueue As System.Windows.Forms.RadioButton
    Friend WithEvents radExistingQueue As System.Windows.Forms.RadioButton
    Friend WithEvents txtQueueName As System.Windows.Forms.TextBox
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnAccept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboQueueName As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
