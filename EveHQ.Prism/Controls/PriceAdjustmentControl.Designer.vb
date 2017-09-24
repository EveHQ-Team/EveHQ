Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PriceAdjustmentControl
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PriceAdjustmentControl))
            Me.STT = New DevComponents.DotNetBar.SuperTooltip
            Me.pbPAC = New System.Windows.Forms.PictureBox
            CType(Me.pbPAC, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'STT
            '
            Me.STT.HoverDelayMultiplier = 4
            
            Me.STT.TooltipDuration = 10
            '
            'pbPAC
            '
            Me.pbPAC.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pbPAC.Image = CType(resources.GetObject("pbPAC.Image"), System.Drawing.Image)
            Me.pbPAC.Location = New System.Drawing.Point(0, 0)
            Me.pbPAC.Name = "pbPAC"
            Me.pbPAC.Size = New System.Drawing.Size(20, 12)
            Me.STT.SetSuperTooltip(Me.pbPAC, New DevComponents.DotNetBar.SuperTooltipInfo("", "Modify Price", "Click here to modify the price for this item.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Yellow))
            Me.pbPAC.TabIndex = 0
            Me.pbPAC.TabStop = False
            '
            'PriceAdjustmentControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pbPAC)
            Me.Name = "PriceAdjustmentControl"
            Me.Size = New System.Drawing.Size(20, 12)
            CType(Me.pbPAC, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents STT As DevComponents.DotNetBar.SuperTooltip
        Friend WithEvents pbPAC As System.Windows.Forms.PictureBox

    End Class
End NameSpace