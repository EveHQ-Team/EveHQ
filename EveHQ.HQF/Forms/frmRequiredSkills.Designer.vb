Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmRequiredSkills
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
            Me.lblQueueTime = New System.Windows.Forms.Label()
            Me.btnClose = New DevComponents.DotNetBar.ButtonX()
            Me.btnAddToQueue = New DevComponents.DotNetBar.ButtonX()
            Me.btnSetSkillsToRequirements = New DevComponents.DotNetBar.ButtonX()
            Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
            Me.adtSkills = New DevComponents.AdvTree.AdvTree()
            Me.colSkillName = New DevComponents.AdvTree.ColumnHeader()
            Me.colReqLevel = New DevComponents.AdvTree.ColumnHeader()
            Me.colActLevel = New DevComponents.AdvTree.ColumnHeader()
            Me.colHQFLevel = New DevComponents.AdvTree.ColumnHeader()
            Me.colReqdFor = New DevComponents.AdvTree.ColumnHeader()
            Me.Node1 = New DevComponents.AdvTree.Node()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.Skill = New DevComponents.DotNetBar.ElementStyle()
            Me.colTrainingTime = New DevComponents.AdvTree.ColumnHeader()
            CType(Me.adtSkills, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblQueueTime
            '
            Me.lblQueueTime.AutoSize = True
            Me.lblQueueTime.Location = New System.Drawing.Point(12, 540)
            Me.lblQueueTime.Name = "lblQueueTime"
            Me.lblQueueTime.Size = New System.Drawing.Size(118, 13)
            Me.SuperTooltip1.SetSuperTooltip(Me.lblQueueTime, New DevComponents.DotNetBar.SuperTooltipInfo("Estimated Queue Time", "", "Shows an estimate of the time needed to train all the required skills. Optimal ti" & _
                                                                                                                                       "me is the time that can be achieved if relevant learning skills are added to the" & _
                                                                                                                                       " queue.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Yellow))
            Me.lblQueueTime.TabIndex = 3
            Me.lblQueueTime.Text = "Estimated Queue Time:"
            '
            'btnClose
            '
            Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnClose.Location = New System.Drawing.Point(816, 535)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(100, 23)
            Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnClose.TabIndex = 5
            Me.btnClose.Text = "Close"
            '
            'btnAddToQueue
            '
            Me.btnAddToQueue.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnAddToQueue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnAddToQueue.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnAddToQueue.Location = New System.Drawing.Point(710, 535)
            Me.btnAddToQueue.Name = "btnAddToQueue"
            Me.btnAddToQueue.Size = New System.Drawing.Size(100, 23)
            Me.btnAddToQueue.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.SuperTooltip1.SetSuperTooltip(Me.btnAddToQueue, New DevComponents.DotNetBar.SuperTooltipInfo("Add To Queue", "", "This option adds all the required skills to a new or existing EveHQ skill queue.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Yellow))
            Me.btnAddToQueue.TabIndex = 6
            Me.btnAddToQueue.Text = "Add To Queue"
            '
            'btnSetSkillsToRequirements
            '
            Me.btnSetSkillsToRequirements.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnSetSkillsToRequirements.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSetSkillsToRequirements.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnSetSkillsToRequirements.Location = New System.Drawing.Point(604, 535)
            Me.btnSetSkillsToRequirements.Name = "btnSetSkillsToRequirements"
            Me.btnSetSkillsToRequirements.Size = New System.Drawing.Size(100, 23)
            Me.btnSetSkillsToRequirements.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.SuperTooltip1.SetSuperTooltip(Me.btnSetSkillsToRequirements, New DevComponents.DotNetBar.SuperTooltipInfo("Set HQF Skills", "", "This option sets the HQF skill set to the required skills. This will bring the se" & _
                                                                                                                                               "lected pilot's skill set up to the minimum required to pilot the ship.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Yellow))
            Me.btnSetSkillsToRequirements.TabIndex = 7
            Me.btnSetSkillsToRequirements.Text = "Set HQF Skills"
            '
            'SuperTooltip1
            '
            
            '
            'adtSkills
            '
            Me.adtSkills.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtSkills.AllowDrop = True
            Me.adtSkills.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                          Or System.Windows.Forms.AnchorStyles.Left) _
                                         Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.adtSkills.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtSkills.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtSkills.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtSkills.Columns.Add(Me.colSkillName)
            Me.adtSkills.Columns.Add(Me.colReqLevel)
            Me.adtSkills.Columns.Add(Me.colActLevel)
            Me.adtSkills.Columns.Add(Me.colHQFLevel)
            Me.adtSkills.Columns.Add(Me.colReqdFor)
            Me.adtSkills.Columns.Add(Me.colTrainingTime)
            Me.adtSkills.DragDropEnabled = False
            Me.adtSkills.DragDropNodeCopyEnabled = False
            Me.adtSkills.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle
            
            Me.adtSkills.Location = New System.Drawing.Point(12, 12)
            Me.adtSkills.Name = "adtSkills"
            Me.adtSkills.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node1})
            Me.adtSkills.NodesConnector = Me.NodeConnector1
            Me.adtSkills.NodeStyle = Me.Skill
            Me.adtSkills.PathSeparator = ";"
            Me.adtSkills.Size = New System.Drawing.Size(904, 517)
            Me.adtSkills.Styles.Add(Me.Skill)
            Me.adtSkills.TabIndex = 8
            Me.adtSkills.Text = "AdvTree1"
            '
            'colSkillName
            '
            Me.colSkillName.DisplayIndex = 1
            Me.colSkillName.Name = "colSkillName"
            Me.colSkillName.SortingEnabled = False
            Me.colSkillName.Text = "Skill Name"
            Me.colSkillName.Width.Absolute = 280
            '
            'colReqLevel
            '
            Me.colReqLevel.DisplayIndex = 2
            Me.colReqLevel.Name = "colReqLevel"
            Me.colReqLevel.SortingEnabled = False
            Me.colReqLevel.Text = "Req Lvl"
            Me.colReqLevel.Width.Absolute = 50
            '
            'colActLevel
            '
            Me.colActLevel.DisplayIndex = 3
            Me.colActLevel.Name = "colActLevel"
            Me.colActLevel.SortingEnabled = False
            Me.colActLevel.Text = "Act Lvl"
            Me.colActLevel.Width.Absolute = 50
            '
            'colHQFLevel
            '
            Me.colHQFLevel.DisplayIndex = 4
            Me.colHQFLevel.Name = "colHQFLevel"
            Me.colHQFLevel.SortingEnabled = False
            Me.colHQFLevel.Text = "HQF Lvl"
            Me.colHQFLevel.Width.Absolute = 50
            '
            'colReqdFor
            '
            Me.colReqdFor.DisplayIndex = 5
            Me.colReqdFor.Name = "colReqdFor"
            Me.colReqdFor.SortingEnabled = False
            Me.colReqdFor.Text = "Required For"
            Me.colReqdFor.Width.Absolute = 280
            '
            'Node1
            '
            Me.Node1.Expanded = True
            Me.Node1.Name = "Node1"
            Me.Node1.Text = "Node1"
            '
            'NodeConnector1
            '
            Me.NodeConnector1.LineColor = System.Drawing.SystemColors.ControlText
            '
            'Skill
            '
            Me.Skill.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.Skill.Name = "Skill"
            Me.Skill.TextColor = System.Drawing.SystemColors.ControlText
            '
            'colTrainingTime
            '
            Me.colTrainingTime.DisplayIndex = 6
            Me.colTrainingTime.Name = "colTrainingTime"
            Me.colTrainingTime.SortingEnabled = False
            Me.colTrainingTime.Text = "Training Time"
            Me.colTrainingTime.Width.Absolute = 150
            '
            'frmRequiredSkills
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnClose
            Me.ClientSize = New System.Drawing.Size(928, 564)
            Me.Controls.Add(Me.adtSkills)
            Me.Controls.Add(Me.btnSetSkillsToRequirements)
            Me.Controls.Add(Me.btnAddToQueue)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.lblQueueTime)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmRequiredSkills"
            Me.ShowIcon = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Required Skills"
            CType(Me.adtSkills, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblQueueTime As System.Windows.Forms.Label
        Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnAddToQueue As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnSetSkillsToRequirements As DevComponents.DotNetBar.ButtonX
        Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
        Friend WithEvents adtSkills As DevComponents.AdvTree.AdvTree
        Friend WithEvents Node1 As DevComponents.AdvTree.Node
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents Skill As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents colSkillName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colReqLevel As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colActLevel As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colHQFLevel As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colReqdFor As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colTrainingTime As DevComponents.AdvTree.ColumnHeader
    End Class
End NameSpace