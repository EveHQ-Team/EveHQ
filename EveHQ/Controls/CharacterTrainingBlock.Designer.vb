Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class CharacterTrainingBlock
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
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
            Me.components = New System.ComponentModel.Container()
            Me.pbPilot = New System.Windows.Forms.PictureBox()
            Me.ctxPic = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.mnuCtxPicGetPortraitFromServer = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuCtxPicGetPortraitFromLocal = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuSavePortrait = New System.Windows.Forms.ToolStripMenuItem()
            Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.lblSkill = New System.Windows.Forms.LinkLabel()
            Me.lblTime = New System.Windows.Forms.LinkLabel()
            Me.lblQueue = New System.Windows.Forms.LinkLabel()
            Me.STT = New DevComponents.DotNetBar.SuperTooltip()
            Me.tmrUpdateOverlays = New System.Windows.Forms.Timer(Me.components)
            CType(Me.pbPilot, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ctxPic.SuspendLayout()
            Me.SuspendLayout()
            '
            'pbPilot
            '
            Me.pbPilot.ContextMenuStrip = Me.ctxPic
            Me.pbPilot.ErrorImage = Global.EveHQ.My.Resources.Resources.noitem
            Me.pbPilot.InitialImage = Global.EveHQ.My.Resources.Resources.nochar
            Me.pbPilot.Location = New System.Drawing.Point(3, 3)
            Me.pbPilot.Name = "pbPilot"
            Me.pbPilot.Size = New System.Drawing.Size(40, 40)
            Me.pbPilot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pbPilot.TabIndex = 0
            Me.pbPilot.TabStop = False
            '
            'ctxPic
            '
            Me.ctxPic.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCtxPicGetPortraitFromServer, Me.mnuCtxPicGetPortraitFromLocal, Me.mnuSavePortrait})
            Me.ctxPic.Name = "ctxPic"
            Me.ctxPic.Size = New System.Drawing.Size(246, 70)
            '
            'mnuCtxPicGetPortraitFromServer
            '
            Me.mnuCtxPicGetPortraitFromServer.Name = "mnuCtxPicGetPortraitFromServer"
            Me.mnuCtxPicGetPortraitFromServer.Size = New System.Drawing.Size(245, 22)
            Me.mnuCtxPicGetPortraitFromServer.Text = "Get Portrait from Eve Server"
            '
            'mnuCtxPicGetPortraitFromLocal
            '
            Me.mnuCtxPicGetPortraitFromLocal.Name = "mnuCtxPicGetPortraitFromLocal"
            Me.mnuCtxPicGetPortraitFromLocal.Size = New System.Drawing.Size(245, 22)
            Me.mnuCtxPicGetPortraitFromLocal.Text = "Get Portrait from Eve Installation"
            '
            'mnuSavePortrait
            '
            Me.mnuSavePortrait.Name = "mnuSavePortrait"
            Me.mnuSavePortrait.Size = New System.Drawing.Size(245, 22)
            Me.mnuSavePortrait.Text = "Save Portrait into Image Cache"
            '
            'tmrUpdate
            '
            Me.tmrUpdate.Interval = 2500
            '
            'lblSkill
            '
            Me.lblSkill.AutoSize = True
            Me.lblSkill.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lblSkill.LinkColor = System.Drawing.SystemColors.ControlText
            Me.lblSkill.Location = New System.Drawing.Point(45, 2)
            Me.lblSkill.Name = "lblSkill"
            Me.lblSkill.Size = New System.Drawing.Size(54, 13)
            Me.lblSkill.TabIndex = 5
            Me.lblSkill.TabStop = True
            Me.lblSkill.Text = "Pilot - Skill"
            '
            'lblTime
            '
            Me.lblTime.AutoSize = True
            Me.lblTime.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lblTime.LinkColor = System.Drawing.SystemColors.ControlText
            Me.lblTime.Location = New System.Drawing.Point(45, 15)
            Me.lblTime.Name = "lblTime"
            Me.lblTime.Size = New System.Drawing.Size(29, 13)
            Me.lblTime.TabIndex = 6
            Me.lblTime.TabStop = True
            Me.lblTime.Text = "Time"
            '
            'lblQueue
            '
            Me.lblQueue.AutoSize = True
            Me.lblQueue.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lblQueue.LinkColor = System.Drawing.SystemColors.ControlText
            Me.lblQueue.Location = New System.Drawing.Point(45, 28)
            Me.lblQueue.Name = "lblQueue"
            Me.lblQueue.Size = New System.Drawing.Size(39, 13)
            Me.lblQueue.TabIndex = 7
            Me.lblQueue.TabStop = True
            Me.lblQueue.Text = "Queue"
            '
            'STT
            '
            Me.STT.DefaultFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            
            Me.STT.PositionBelowControl = False
            '
            'tmrUpdateOverlays
            '
            Me.tmrUpdateOverlays.Interval = 120000
            '
            'CharacterTrainingBlock
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.lblQueue)
            Me.Controls.Add(Me.lblTime)
            Me.Controls.Add(Me.lblSkill)
            Me.Controls.Add(Me.pbPilot)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "CharacterTrainingBlock"
            Me.Size = New System.Drawing.Size(140, 46)
            CType(Me.pbPilot, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ctxPic.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents pbPilot As System.Windows.Forms.PictureBox
        Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents lblSkill As System.Windows.Forms.LinkLabel
        Friend WithEvents lblTime As System.Windows.Forms.LinkLabel
        Friend WithEvents lblQueue As System.Windows.Forms.LinkLabel
        Friend WithEvents ctxPic As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents mnuCtxPicGetPortraitFromServer As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuCtxPicGetPortraitFromLocal As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuSavePortrait As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents STT As DevComponents.DotNetBar.SuperTooltip
        Friend WithEvents tmrUpdateOverlays As System.Windows.Forms.Timer

    End Class
End Namespace