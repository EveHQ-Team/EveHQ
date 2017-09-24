Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmEditImplants
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditImplants))
            Me.lblDescription = New System.Windows.Forms.Label
            Me.lblC = New System.Windows.Forms.Label
            Me.nudC = New System.Windows.Forms.NumericUpDown
            Me.nudI = New System.Windows.Forms.NumericUpDown
            Me.lblI = New System.Windows.Forms.Label
            Me.nudM = New System.Windows.Forms.NumericUpDown
            Me.lblM = New System.Windows.Forms.Label
            Me.nudP = New System.Windows.Forms.NumericUpDown
            Me.lblP = New System.Windows.Forms.Label
            Me.nudW = New System.Windows.Forms.NumericUpDown
            Me.lblW = New System.Windows.Forms.Label
            Me.btnClose = New System.Windows.Forms.Button
            Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter
            CType(Me.nudC, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudI, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudM, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudP, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudW, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblDescription
            '
            Me.lblDescription.Location = New System.Drawing.Point(13, 13)
            Me.lblDescription.Name = "lblDescription"
            Me.lblDescription.Size = New System.Drawing.Size(204, 56)
            Me.lblDescription.TabIndex = 0
            Me.lblDescription.Text = "Please enter the value of your implants in the boxes below. They will be saved au" & _
                                     "tomatically when you exit this screen."
            '
            'lblC
            '
            Me.lblC.AutoSize = True
            Me.lblC.Location = New System.Drawing.Point(26, 73)
            Me.lblC.Name = "lblC"
            Me.lblC.Size = New System.Drawing.Size(55, 13)
            Me.lblC.TabIndex = 1
            Me.lblC.Text = "Charisma:"
            '
            'nudC
            '
            Me.Highlighter1.SetHighlightOnFocus(Me.nudC, True)
            Me.nudC.Location = New System.Drawing.Point(113, 71)
            Me.nudC.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
            Me.nudC.Name = "nudC"
            Me.nudC.Size = New System.Drawing.Size(67, 21)
            Me.nudC.TabIndex = 0
            Me.nudC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudI
            '
            Me.Highlighter1.SetHighlightOnFocus(Me.nudI, True)
            Me.nudI.Location = New System.Drawing.Point(113, 97)
            Me.nudI.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
            Me.nudI.Name = "nudI"
            Me.nudI.Size = New System.Drawing.Size(67, 21)
            Me.nudI.TabIndex = 1
            Me.nudI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblI
            '
            Me.lblI.AutoSize = True
            Me.lblI.Location = New System.Drawing.Point(26, 99)
            Me.lblI.Name = "lblI"
            Me.lblI.Size = New System.Drawing.Size(66, 13)
            Me.lblI.TabIndex = 3
            Me.lblI.Text = "Intelligence:"
            '
            'nudM
            '
            Me.Highlighter1.SetHighlightOnFocus(Me.nudM, True)
            Me.nudM.Location = New System.Drawing.Point(113, 123)
            Me.nudM.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
            Me.nudM.Name = "nudM"
            Me.nudM.Size = New System.Drawing.Size(67, 21)
            Me.nudM.TabIndex = 2
            Me.nudM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblM
            '
            Me.lblM.AutoSize = True
            Me.lblM.Location = New System.Drawing.Point(26, 125)
            Me.lblM.Name = "lblM"
            Me.lblM.Size = New System.Drawing.Size(49, 13)
            Me.lblM.TabIndex = 5
            Me.lblM.Text = "Memory:"
            '
            'nudP
            '
            Me.Highlighter1.SetHighlightOnFocus(Me.nudP, True)
            Me.nudP.Location = New System.Drawing.Point(113, 149)
            Me.nudP.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
            Me.nudP.Name = "nudP"
            Me.nudP.Size = New System.Drawing.Size(67, 21)
            Me.nudP.TabIndex = 3
            Me.nudP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblP
            '
            Me.lblP.AutoSize = True
            Me.lblP.Location = New System.Drawing.Point(26, 151)
            Me.lblP.Name = "lblP"
            Me.lblP.Size = New System.Drawing.Size(62, 13)
            Me.lblP.TabIndex = 7
            Me.lblP.Text = "Perception:"
            '
            'nudW
            '
            Me.Highlighter1.SetHighlightOnFocus(Me.nudW, True)
            Me.nudW.Location = New System.Drawing.Point(113, 175)
            Me.nudW.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
            Me.nudW.Name = "nudW"
            Me.nudW.Size = New System.Drawing.Size(67, 21)
            Me.nudW.TabIndex = 4
            Me.nudW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblW
            '
            Me.lblW.AutoSize = True
            Me.lblW.Location = New System.Drawing.Point(26, 177)
            Me.lblW.Name = "lblW"
            Me.lblW.Size = New System.Drawing.Size(57, 13)
            Me.lblW.TabIndex = 9
            Me.lblW.Text = "Willpower:"
            '
            'btnClose
            '
            Me.Highlighter1.SetHighlightOnFocus(Me.btnClose, True)
            Me.btnClose.Location = New System.Drawing.Point(146, 211)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(75, 23)
            Me.btnClose.TabIndex = 5
            Me.btnClose.Text = "&Close"
            Me.btnClose.UseVisualStyleBackColor = True
            '
            'Highlighter1
            '
            Me.Highlighter1.ContainerControl = Me
            Me.Highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Green
            
            '
            'frmEditImplants
            '
            Me.AcceptButton = Me.btnClose
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(233, 246)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.nudW)
            Me.Controls.Add(Me.lblW)
            Me.Controls.Add(Me.nudP)
            Me.Controls.Add(Me.lblP)
            Me.Controls.Add(Me.nudM)
            Me.Controls.Add(Me.lblM)
            Me.Controls.Add(Me.nudI)
            Me.Controls.Add(Me.lblI)
            Me.Controls.Add(Me.nudC)
            Me.Controls.Add(Me.lblC)
            Me.Controls.Add(Me.lblDescription)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmEditImplants"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Edit Manual Implants"
            CType(Me.nudC, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudI, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudM, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudP, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudW, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblDescription As System.Windows.Forms.Label
        Friend WithEvents lblC As System.Windows.Forms.Label
        Friend WithEvents nudC As System.Windows.Forms.NumericUpDown
        Friend WithEvents nudI As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblI As System.Windows.Forms.Label
        Friend WithEvents nudM As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblM As System.Windows.Forms.Label
        Friend WithEvents nudP As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblP As System.Windows.Forms.Label
        Friend WithEvents nudW As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblW As System.Windows.Forms.Label
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    End Class
End NameSpace