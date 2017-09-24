Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class EveHQTrainingQueue
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
                lblQueueTime.Dispose()
                lblTotalTrainingTimeLabel.Dispose()
                lblSkillCount.Dispose()
                lblNumberOfSkills.Dispose()
                panelInfo.Dispose()
                adtQueue.Dispose()
                NodeConnector1.Dispose()
                ElementStyle1.Dispose()
                SkillCompleted.Dispose()
                chkShowCompletedSkills.Dispose()
                ctxQueue.Dispose()
                mnuSkillName.Dispose()
                ToolStripSeparator1.Dispose()
                mnuChangeLevel.Dispose()
                mnuChangeLevel1.Dispose()
                mnuChangeLevel2.Dispose()
                mnuChangeLevel3.Dispose()
                mnuChangeLevel4.Dispose()
                mnuChangeLevel5.Dispose()
                mnuIncreaseLevel.Dispose()
                mnuDecreaseLevel.Dispose()
                ToolStripSeparator3.Dispose()
                mnuMoveUpQueue.Dispose()
                mnuMoveDownQueue.Dispose()
                ToolStripMenuItem3.Dispose()
                mnuSeparateLevels.Dispose()
                mnuSeparateAllLevels.Dispose()
                mnuSeparateTopLevel.Dispose()
                mnuSeparateBottomLevel.Dispose()
                ToolStripMenuItem8.Dispose()
                mnuSplitQueue.Dispose()
                mnuSeperateLevelSep.Dispose()
                mnuDeleteFromQueue.Dispose()
                mnuRemoveTrainedSkills.Dispose()
                mnuClearTrainingQueue.Dispose()
                ToolStripSeparator2.Dispose()
                mnuViewDetails.Dispose()
                mnuEditNote.Dispose()
                mnuChangePriority.Dispose()
                ToolStripMenuItem1.Dispose()
                btnStoreQueue.Dispose()
                mnuCopySkills.Dispose()
                mnuPasteSkills.Dispose()
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
            Me.lblSkillCount = New System.Windows.Forms.Label()
            Me.lblNumberOfSkills = New System.Windows.Forms.Label()
            Me.lblQueueTime = New System.Windows.Forms.Label()
            Me.lblTotalTrainingTimeLabel = New System.Windows.Forms.Label()
            Me.panelInfo = New DevComponents.DotNetBar.PanelEx()
            Me.btnStoreQueue = New DevComponents.DotNetBar.ButtonX()
            Me.chkShowCompletedSkills = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.adtQueue = New DevComponents.AdvTree.AdvTree()
            Me.ctxQueue = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.mnuSkillName = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuChangeLevel = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuChangeLevel1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuChangeLevel2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuChangeLevel3 = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuChangeLevel4 = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuChangeLevel5 = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuIncreaseLevel = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuDecreaseLevel = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuMoveUpQueue = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuMoveDownQueue = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuSeparateLevels = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuSeparateAllLevels = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuSeparateTopLevel = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuSeparateBottomLevel = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuSplitQueue = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuCopySkills = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuPasteSkills = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuSeperateLevelSep = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuDeleteFromQueue = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuRemoveTrainedSkills = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuClearTrainingQueue = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuChangePriority = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuEditNote = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuViewDetails = New System.Windows.Forms.ToolStripMenuItem()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me.SkillCompleted = New DevComponents.DotNetBar.ElementStyle()
            Me.panelInfo.SuspendLayout()
            CType(Me.adtQueue, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ctxQueue.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblSkillCount
            '
            Me.lblSkillCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblSkillCount.Location = New System.Drawing.Point(325, 13)
            Me.lblSkillCount.Name = "lblSkillCount"
            Me.lblSkillCount.Size = New System.Drawing.Size(43, 17)
            Me.lblSkillCount.TabIndex = 5
            '
            'lblNumberOfSkills
            '
            Me.lblNumberOfSkills.AutoSize = True
            Me.lblNumberOfSkills.Location = New System.Drawing.Point(233, 14)
            Me.lblNumberOfSkills.Name = "lblNumberOfSkills"
            Me.lblNumberOfSkills.Size = New System.Drawing.Size(86, 13)
            Me.lblNumberOfSkills.TabIndex = 4
            Me.lblNumberOfSkills.Text = "Number of Skills:"
            '
            'lblQueueTime
            '
            Me.lblQueueTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblQueueTime.Location = New System.Drawing.Point(113, 14)
            Me.lblQueueTime.Name = "lblQueueTime"
            Me.lblQueueTime.Size = New System.Drawing.Size(110, 15)
            Me.lblQueueTime.TabIndex = 2
            '
            'lblTotalTrainingTimeLabel
            '
            Me.lblTotalTrainingTimeLabel.AutoSize = True
            Me.lblTotalTrainingTimeLabel.Location = New System.Drawing.Point(3, 14)
            Me.lblTotalTrainingTimeLabel.Name = "lblTotalTrainingTimeLabel"
            Me.lblTotalTrainingTimeLabel.Size = New System.Drawing.Size(101, 13)
            Me.lblTotalTrainingTimeLabel.TabIndex = 0
            Me.lblTotalTrainingTimeLabel.Text = "Total Training Time:"
            '
            'panelInfo
            '
            Me.panelInfo.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelInfo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelInfo.Controls.Add(Me.btnStoreQueue)
            Me.panelInfo.Controls.Add(Me.chkShowCompletedSkills)
            Me.panelInfo.Controls.Add(Me.lblSkillCount)
            Me.panelInfo.Controls.Add(Me.lblTotalTrainingTimeLabel)
            Me.panelInfo.Controls.Add(Me.lblNumberOfSkills)
            Me.panelInfo.Controls.Add(Me.lblQueueTime)
            Me.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelInfo.Location = New System.Drawing.Point(0, 373)
            Me.panelInfo.Name = "panelInfo"
            Me.panelInfo.Size = New System.Drawing.Size(766, 41)
            Me.panelInfo.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelInfo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelInfo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelInfo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelInfo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelInfo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelInfo.Style.GradientAngle = 90
            Me.panelInfo.TabIndex = 2
            '
            'btnStoreQueue
            '
            Me.btnStoreQueue.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnStoreQueue.AutoCheckOnClick = True
            Me.btnStoreQueue.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnStoreQueue.FocusCuesEnabled = False
            Me.btnStoreQueue.Location = New System.Drawing.Point(387, 9)
            Me.btnStoreQueue.Name = "btnStoreQueue"
            Me.btnStoreQueue.Size = New System.Drawing.Size(100, 23)
            Me.btnStoreQueue.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnStoreQueue.TabIndex = 7
            Me.btnStoreQueue.Text = "Store Queue"
            '
            'chkShowCompletedSkills
            '
            Me.chkShowCompletedSkills.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chkShowCompletedSkills.AutoSize = True
            '
            '
            '
            Me.chkShowCompletedSkills.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkShowCompletedSkills.FocusCuesEnabled = False
            Me.chkShowCompletedSkills.Location = New System.Drawing.Point(627, 13)
            Me.chkShowCompletedSkills.Name = "chkShowCompletedSkills"
            Me.chkShowCompletedSkills.Size = New System.Drawing.Size(132, 16)
            Me.chkShowCompletedSkills.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkShowCompletedSkills.TabIndex = 6
            Me.chkShowCompletedSkills.Text = "Show Completed Skills"
            '
            'adtQueue
            '
            Me.adtQueue.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtQueue.AllowDrop = True
            Me.adtQueue.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtQueue.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtQueue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtQueue.ContextMenuStrip = Me.ctxQueue
            Me.adtQueue.Dock = System.Windows.Forms.DockStyle.Fill
            Me.adtQueue.DragDropNodeCopyEnabled = False
            Me.adtQueue.DropAsChildOffset = 10000
            Me.adtQueue.ExpandWidth = 0
            
            Me.adtQueue.Location = New System.Drawing.Point(0, 0)
            Me.adtQueue.MultiSelect = True
            Me.adtQueue.Name = "adtQueue"
            Me.adtQueue.NodesConnector = Me.NodeConnector1
            Me.adtQueue.NodeStyle = Me.ElementStyle1
            Me.adtQueue.PathSeparator = ";"
            Me.adtQueue.Size = New System.Drawing.Size(766, 373)
            Me.adtQueue.Styles.Add(Me.ElementStyle1)
            Me.adtQueue.Styles.Add(Me.SkillCompleted)
            Me.adtQueue.TabIndex = 3
            Me.adtQueue.Text = "AdvTree1"
            '
            'ctxQueue
            '
            Me.ctxQueue.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.ctxQueue.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSkillName, Me.ToolStripSeparator1, Me.mnuChangeLevel, Me.mnuIncreaseLevel, Me.mnuDecreaseLevel, Me.ToolStripSeparator3, Me.mnuMoveUpQueue, Me.mnuMoveDownQueue, Me.ToolStripMenuItem3, Me.mnuSeparateLevels, Me.ToolStripMenuItem8, Me.mnuSplitQueue, Me.mnuCopySkills, Me.mnuPasteSkills, Me.mnuSeperateLevelSep, Me.mnuDeleteFromQueue, Me.mnuRemoveTrainedSkills, Me.mnuClearTrainingQueue, Me.ToolStripSeparator2, Me.mnuChangePriority, Me.mnuEditNote, Me.ToolStripMenuItem1, Me.mnuViewDetails})
            Me.ctxQueue.Name = "ctxDepend"
            Me.ctxQueue.Size = New System.Drawing.Size(207, 398)
            '
            'mnuSkillName
            '
            Me.mnuSkillName.Name = "mnuSkillName"
            Me.mnuSkillName.Size = New System.Drawing.Size(206, 22)
            Me.mnuSkillName.Text = "Skill Name"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(203, 6)
            '
            'mnuChangeLevel
            '
            Me.mnuChangeLevel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuChangeLevel1, Me.mnuChangeLevel2, Me.mnuChangeLevel3, Me.mnuChangeLevel4, Me.mnuChangeLevel5})
            Me.mnuChangeLevel.Font = New System.Drawing.Font("Tahoma", 8.25!)
            Me.mnuChangeLevel.Name = "mnuChangeLevel"
            Me.mnuChangeLevel.Size = New System.Drawing.Size(206, 22)
            Me.mnuChangeLevel.Text = "Change To Level"
            '
            'mnuChangeLevel1
            '
            Me.mnuChangeLevel1.Name = "mnuChangeLevel1"
            Me.mnuChangeLevel1.Size = New System.Drawing.Size(108, 22)
            Me.mnuChangeLevel1.Text = "Level 1"
            '
            'mnuChangeLevel2
            '
            Me.mnuChangeLevel2.Name = "mnuChangeLevel2"
            Me.mnuChangeLevel2.Size = New System.Drawing.Size(108, 22)
            Me.mnuChangeLevel2.Text = "Level 2"
            '
            'mnuChangeLevel3
            '
            Me.mnuChangeLevel3.Name = "mnuChangeLevel3"
            Me.mnuChangeLevel3.Size = New System.Drawing.Size(108, 22)
            Me.mnuChangeLevel3.Text = "Level 3"
            '
            'mnuChangeLevel4
            '
            Me.mnuChangeLevel4.Name = "mnuChangeLevel4"
            Me.mnuChangeLevel4.Size = New System.Drawing.Size(108, 22)
            Me.mnuChangeLevel4.Text = "Level 4"
            '
            'mnuChangeLevel5
            '
            Me.mnuChangeLevel5.Name = "mnuChangeLevel5"
            Me.mnuChangeLevel5.Size = New System.Drawing.Size(108, 22)
            Me.mnuChangeLevel5.Text = "Level 5"
            '
            'mnuIncreaseLevel
            '
            Me.mnuIncreaseLevel.Font = New System.Drawing.Font("Tahoma", 8.25!)
            Me.mnuIncreaseLevel.Name = "mnuIncreaseLevel"
            Me.mnuIncreaseLevel.Size = New System.Drawing.Size(206, 22)
            Me.mnuIncreaseLevel.Text = "Increase Skill Level"
            '
            'mnuDecreaseLevel
            '
            Me.mnuDecreaseLevel.Font = New System.Drawing.Font("Tahoma", 8.25!)
            Me.mnuDecreaseLevel.Name = "mnuDecreaseLevel"
            Me.mnuDecreaseLevel.Size = New System.Drawing.Size(206, 22)
            Me.mnuDecreaseLevel.Text = "Decrease Skill Level"
            '
            'ToolStripSeparator3
            '
            Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
            Me.ToolStripSeparator3.Size = New System.Drawing.Size(203, 6)
            '
            'mnuMoveUpQueue
            '
            Me.mnuMoveUpQueue.Font = New System.Drawing.Font("Tahoma", 8.25!)
            Me.mnuMoveUpQueue.Name = "mnuMoveUpQueue"
            Me.mnuMoveUpQueue.Size = New System.Drawing.Size(206, 22)
            Me.mnuMoveUpQueue.Text = "Move Skill Up Queue"
            '
            'mnuMoveDownQueue
            '
            Me.mnuMoveDownQueue.Font = New System.Drawing.Font("Tahoma", 8.25!)
            Me.mnuMoveDownQueue.Name = "mnuMoveDownQueue"
            Me.mnuMoveDownQueue.Size = New System.Drawing.Size(206, 22)
            Me.mnuMoveDownQueue.Text = "Move Skill Down Queue"
            '
            'ToolStripMenuItem3
            '
            Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
            Me.ToolStripMenuItem3.Size = New System.Drawing.Size(203, 6)
            '
            'mnuSeparateLevels
            '
            Me.mnuSeparateLevels.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSeparateAllLevels, Me.mnuSeparateTopLevel, Me.mnuSeparateBottomLevel})
            Me.mnuSeparateLevels.Font = New System.Drawing.Font("Tahoma", 8.25!)
            Me.mnuSeparateLevels.Name = "mnuSeparateLevels"
            Me.mnuSeparateLevels.Size = New System.Drawing.Size(206, 22)
            Me.mnuSeparateLevels.Text = "Separate Levels"
            '
            'mnuSeparateAllLevels
            '
            Me.mnuSeparateAllLevels.Name = "mnuSeparateAllLevels"
            Me.mnuSeparateAllLevels.Size = New System.Drawing.Size(183, 22)
            Me.mnuSeparateAllLevels.Text = "Separate All Levels"
            '
            'mnuSeparateTopLevel
            '
            Me.mnuSeparateTopLevel.Name = "mnuSeparateTopLevel"
            Me.mnuSeparateTopLevel.Size = New System.Drawing.Size(183, 22)
            Me.mnuSeparateTopLevel.Text = "Separate Top Level"
            '
            'mnuSeparateBottomLevel
            '
            Me.mnuSeparateBottomLevel.Name = "mnuSeparateBottomLevel"
            Me.mnuSeparateBottomLevel.Size = New System.Drawing.Size(183, 22)
            Me.mnuSeparateBottomLevel.Text = "Separate Bottom Level"
            '
            'ToolStripMenuItem8
            '
            Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
            Me.ToolStripMenuItem8.Size = New System.Drawing.Size(203, 6)
            '
            'mnuSplitQueue
            '
            Me.mnuSplitQueue.Font = New System.Drawing.Font("Tahoma", 8.25!)
            Me.mnuSplitQueue.Name = "mnuSplitQueue"
            Me.mnuSplitQueue.Size = New System.Drawing.Size(206, 22)
            Me.mnuSplitQueue.Text = "Split Queue"
            '
            'mnuCopySkills
            '
            Me.mnuCopySkills.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mnuCopySkills.Name = "mnuCopySkills"
            Me.mnuCopySkills.Size = New System.Drawing.Size(206, 22)
            Me.mnuCopySkills.Text = "Copy Skills"
            '
            'mnuPasteSkills
            '
            Me.mnuPasteSkills.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mnuPasteSkills.Name = "mnuPasteSkills"
            Me.mnuPasteSkills.Size = New System.Drawing.Size(206, 22)
            Me.mnuPasteSkills.Text = "Paste Skills"
            '
            'mnuSeperateLevelSep
            '
            Me.mnuSeperateLevelSep.Name = "mnuSeperateLevelSep"
            Me.mnuSeperateLevelSep.Size = New System.Drawing.Size(203, 6)
            '
            'mnuDeleteFromQueue
            '
            Me.mnuDeleteFromQueue.Font = New System.Drawing.Font("Tahoma", 8.25!)
            Me.mnuDeleteFromQueue.Name = "mnuDeleteFromQueue"
            Me.mnuDeleteFromQueue.Size = New System.Drawing.Size(206, 22)
            Me.mnuDeleteFromQueue.Text = "Delete from Training Queue"
            '
            'mnuRemoveTrainedSkills
            '
            Me.mnuRemoveTrainedSkills.Font = New System.Drawing.Font("Tahoma", 8.25!)
            Me.mnuRemoveTrainedSkills.Name = "mnuRemoveTrainedSkills"
            Me.mnuRemoveTrainedSkills.Size = New System.Drawing.Size(206, 22)
            Me.mnuRemoveTrainedSkills.Text = "Remove Trained Skills"
            '
            'mnuClearTrainingQueue
            '
            Me.mnuClearTrainingQueue.Font = New System.Drawing.Font("Tahoma", 8.25!)
            Me.mnuClearTrainingQueue.Name = "mnuClearTrainingQueue"
            Me.mnuClearTrainingQueue.Size = New System.Drawing.Size(206, 22)
            Me.mnuClearTrainingQueue.Text = "Clear Training Queue"
            '
            'ToolStripSeparator2
            '
            Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
            Me.ToolStripSeparator2.Size = New System.Drawing.Size(203, 6)
            '
            'mnuChangePriority
            '
            Me.mnuChangePriority.Font = New System.Drawing.Font("Tahoma", 8.25!)
            Me.mnuChangePriority.Name = "mnuChangePriority"
            Me.mnuChangePriority.Size = New System.Drawing.Size(206, 22)
            Me.mnuChangePriority.Text = "Change Priority"
            '
            'mnuEditNote
            '
            Me.mnuEditNote.Font = New System.Drawing.Font("Tahoma", 8.25!)
            Me.mnuEditNote.Name = "mnuEditNote"
            Me.mnuEditNote.Size = New System.Drawing.Size(206, 22)
            Me.mnuEditNote.Text = "Edit Note"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(203, 6)
            '
            'mnuViewDetails
            '
            Me.mnuViewDetails.Font = New System.Drawing.Font("Tahoma", 8.25!)
            Me.mnuViewDetails.Name = "mnuViewDetails"
            Me.mnuViewDetails.Size = New System.Drawing.Size(206, 22)
            Me.mnuViewDetails.Text = "View Details"
            '
            'NodeConnector1
            '
            Me.NodeConnector1.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle1
            '
            Me.ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle1.Name = "ElementStyle1"
            Me.ElementStyle1.TextColor = System.Drawing.SystemColors.ControlText
            '
            'SkillCompleted
            '
            Me.SkillCompleted.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.SkillCompleted.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SkillCompleted.Name = "SkillCompleted"
            '
            'EveHQTrainingQueue
            '
            Me.AllowDrop = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.adtQueue)
            Me.Controls.Add(Me.panelInfo)
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "EveHQTrainingQueue"
            Me.Size = New System.Drawing.Size(766, 414)
            Me.panelInfo.ResumeLayout(False)
            Me.panelInfo.PerformLayout()
            CType(Me.adtQueue, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ctxQueue.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblQueueTime As System.Windows.Forms.Label
        Friend WithEvents lblTotalTrainingTimeLabel As System.Windows.Forms.Label
        Friend WithEvents lblSkillCount As System.Windows.Forms.Label
        Friend WithEvents lblNumberOfSkills As System.Windows.Forms.Label
        Friend WithEvents panelInfo As DevComponents.DotNetBar.PanelEx
        Friend WithEvents adtQueue As DevComponents.AdvTree.AdvTree
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents SkillCompleted As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents chkShowCompletedSkills As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents ctxQueue As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents mnuSkillName As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuChangeLevel As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuChangeLevel1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuChangeLevel2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuChangeLevel3 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuChangeLevel4 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuChangeLevel5 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuIncreaseLevel As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuDecreaseLevel As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuMoveUpQueue As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuMoveDownQueue As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuSeparateLevels As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuSeparateAllLevels As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuSeparateTopLevel As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuSeparateBottomLevel As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuSplitQueue As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuSeperateLevelSep As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuDeleteFromQueue As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuRemoveTrainedSkills As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuClearTrainingQueue As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuViewDetails As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuEditNote As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuChangePriority As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents btnStoreQueue As DevComponents.DotNetBar.ButtonX
        Friend WithEvents mnuCopySkills As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuPasteSkills As System.Windows.Forms.ToolStripMenuItem

    End Class
End NameSpace