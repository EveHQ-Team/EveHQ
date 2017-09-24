Namespace ItemBrowser
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class IBSkillTree
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
            Me.adtSkills = New DevComponents.AdvTree.AdvTree()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.BasicStyle = New DevComponents.DotNetBar.ElementStyle()
            Me.STTSkill = New DevComponents.DotNetBar.SuperTooltip()
            CType(Me.adtSkills, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'adtSkills
            '
            Me.adtSkills.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtSkills.AllowDrop = True
            Me.adtSkills.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtSkills.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtSkills.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtSkills.Dock = System.Windows.Forms.DockStyle.Fill
            Me.adtSkills.DragDropEnabled = False
            Me.adtSkills.DragDropNodeCopyEnabled = False
            Me.adtSkills.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle
            
            Me.adtSkills.Location = New System.Drawing.Point(0, 0)
            Me.adtSkills.Name = "adtSkills"
            Me.adtSkills.NodesConnector = Me.NodeConnector1
            Me.adtSkills.NodeSpacing = 5
            Me.adtSkills.NodeStyle = Me.BasicStyle
            Me.adtSkills.PathSeparator = ";"
            Me.adtSkills.Size = New System.Drawing.Size(268, 250)
            Me.adtSkills.Styles.Add(Me.BasicStyle)
            Me.adtSkills.TabIndex = 0
            Me.adtSkills.Text = "AdvTree1"
            '
            'NodeConnector1
            '
            Me.NodeConnector1.LineColor = System.Drawing.SystemColors.ControlText
            '
            'BasicStyle
            '
            Me.BasicStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.BasicStyle.Name = "BasicStyle"
            Me.BasicStyle.TextColor = System.Drawing.SystemColors.ControlText
            '
            'STTSkill
            '
            Me.STTSkill.HoverDelayMultiplier = 1
            
            Me.STTSkill.PositionBelowControl = False
            '
            'IBSkillTree
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.adtSkills)
            Me.Name = "IBSkillTree"
            Me.Size = New System.Drawing.Size(268, 250)
            CType(Me.adtSkills, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents adtSkills As DevComponents.AdvTree.AdvTree
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents BasicStyle As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents STTSkill As DevComponents.DotNetBar.SuperTooltip

    End Class
End NameSpace