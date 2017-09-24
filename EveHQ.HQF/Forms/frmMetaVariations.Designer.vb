Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmMetaVariations
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMetaVariations))
            Me.ctxItems = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.mnuModuleName = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuAddToExistingFitting = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuReplaceModule = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuRemoveColumn = New System.Windows.Forms.ToolStripMenuItem()
            Me.chkShowAllColumns = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.chkApplySkills = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
            Me.adtComparisons = New DevComponents.AdvTree.AdvTree()
            Me.colItem = New DevComponents.AdvTree.ColumnHeader()
            Me.colMeta = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me.RightAlign = New DevComponents.DotNetBar.ElementStyle()
            Me.btnReplaceModules = New DevComponents.DotNetBar.ButtonX()
            Me.btnAddToFitting = New DevComponents.DotNetBar.ButtonX()
            Me.ctxItems.SuspendLayout()
            Me.PanelEx1.SuspendLayout()
            CType(Me.adtComparisons, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ctxItems
            '
            Me.ctxItems.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModuleName, Me.ToolStripMenuItem1, Me.mnuAddToExistingFitting, Me.mnuReplaceModule, Me.ToolStripMenuItem2, Me.mnuRemoveColumn})
            Me.ctxItems.Name = "ctxItems"
            Me.ctxItems.Size = New System.Drawing.Size(191, 104)
            '
            'mnuModuleName
            '
            Me.mnuModuleName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.mnuModuleName.Name = "mnuModuleName"
            Me.mnuModuleName.Size = New System.Drawing.Size(190, 22)
            Me.mnuModuleName.Text = "Module Name"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(187, 6)
            '
            'mnuAddToExistingFitting
            '
            Me.mnuAddToExistingFitting.Name = "mnuAddToExistingFitting"
            Me.mnuAddToExistingFitting.Size = New System.Drawing.Size(190, 22)
            Me.mnuAddToExistingFitting.Text = "Add to Existing Fitting"
            '
            'mnuReplaceModule
            '
            Me.mnuReplaceModule.Name = "mnuReplaceModule"
            Me.mnuReplaceModule.Size = New System.Drawing.Size(190, 22)
            Me.mnuReplaceModule.Text = "Replace Module"
            '
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(187, 6)
            '
            'mnuRemoveColumn
            '
            Me.mnuRemoveColumn.Name = "mnuRemoveColumn"
            Me.mnuRemoveColumn.Size = New System.Drawing.Size(190, 22)
            Me.mnuRemoveColumn.Text = "Remove Column"
            '
            'chkShowAllColumns
            '
            Me.chkShowAllColumns.AutoSize = True
            '
            '
            '
            Me.chkShowAllColumns.BackgroundStyle.Class = ""
            Me.chkShowAllColumns.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkShowAllColumns.Location = New System.Drawing.Point(12, 12)
            Me.chkShowAllColumns.Name = "chkShowAllColumns"
            Me.chkShowAllColumns.Size = New System.Drawing.Size(109, 16)
            Me.chkShowAllColumns.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkShowAllColumns.TabIndex = 6
            Me.chkShowAllColumns.Text = "Show All Columns"
            '
            'chkApplySkills
            '
            Me.chkApplySkills.AutoSize = True
            '
            '
            '
            Me.chkApplySkills.BackgroundStyle.Class = ""
            Me.chkApplySkills.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkApplySkills.Location = New System.Drawing.Point(127, 13)
            Me.chkApplySkills.Name = "chkApplySkills"
            Me.chkApplySkills.Size = New System.Drawing.Size(173, 16)
            Me.chkApplySkills.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkApplySkills.TabIndex = 7
            Me.chkApplySkills.Text = "Apply Current Ship/Skill Effects"
            '
            'PanelEx1
            '
            Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
            Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.PanelEx1.Controls.Add(Me.adtComparisons)
            Me.PanelEx1.Controls.Add(Me.btnReplaceModules)
            Me.PanelEx1.Controls.Add(Me.btnAddToFitting)
            Me.PanelEx1.Controls.Add(Me.chkShowAllColumns)
            Me.PanelEx1.Controls.Add(Me.chkApplySkills)
            Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
            Me.PanelEx1.Name = "PanelEx1"
            Me.PanelEx1.Size = New System.Drawing.Size(884, 512)
            Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.PanelEx1.Style.GradientAngle = 90
            Me.PanelEx1.TabIndex = 9
            '
            'adtComparisons
            '
            Me.adtComparisons.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtComparisons.AllowDrop = True
            Me.adtComparisons.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                               Or System.Windows.Forms.AnchorStyles.Left) _
                                              Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.adtComparisons.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtComparisons.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtComparisons.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtComparisons.Columns.Add(Me.colItem)
            Me.adtComparisons.Columns.Add(Me.colMeta)
            Me.adtComparisons.ContextMenuStrip = Me.ctxItems
            Me.adtComparisons.DragDropEnabled = False
            Me.adtComparisons.DragDropNodeCopyEnabled = False
            Me.adtComparisons.ExpandWidth = 0
            Me.adtComparisons.KeyboardSearchEnabled = False
            
            Me.adtComparisons.Location = New System.Drawing.Point(3, 34)
            Me.adtComparisons.Name = "adtComparisons"
            Me.adtComparisons.NodesConnector = Me.NodeConnector1
            Me.adtComparisons.NodeStyle = Me.ElementStyle1
            Me.adtComparisons.PathSeparator = ";"
            Me.adtComparisons.Size = New System.Drawing.Size(878, 446)
            Me.adtComparisons.Styles.Add(Me.ElementStyle1)
            Me.adtComparisons.Styles.Add(Me.RightAlign)
            Me.adtComparisons.TabIndex = 10
            '
            'colItem
            '
            Me.colItem.DisplayIndex = 1
            Me.colItem.Name = "colItem"
            Me.colItem.SortingEnabled = False
            Me.colItem.Text = "Column"
            Me.colItem.Width.Absolute = 150
            '
            'colMeta
            '
            Me.colMeta.DisplayIndex = 2
            Me.colMeta.Name = "colMeta"
            Me.colMeta.SortingEnabled = False
            Me.colMeta.Text = "Column"
            Me.colMeta.Width.Absolute = 150
            '
            'NodeConnector1
            '
            Me.NodeConnector1.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle1
            '
            Me.ElementStyle1.Class = ""
            Me.ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle1.Name = "ElementStyle1"
            Me.ElementStyle1.TextColor = System.Drawing.SystemColors.ControlText
            '
            'RightAlign
            '
            Me.RightAlign.Class = ""
            Me.RightAlign.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.RightAlign.Name = "RightAlign"
            Me.RightAlign.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Far
            '
            'btnReplaceModules
            '
            Me.btnReplaceModules.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnReplaceModules.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnReplaceModules.AutoSize = True
            Me.btnReplaceModules.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnReplaceModules.Location = New System.Drawing.Point(89, 486)
            Me.btnReplaceModules.Name = "btnReplaceModules"
            Me.btnReplaceModules.Size = New System.Drawing.Size(160, 23)
            Me.btnReplaceModules.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnReplaceModules.TabIndex = 9
            Me.btnReplaceModules.Text = "Replace"
            '
            'btnAddToFitting
            '
            Me.btnAddToFitting.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnAddToFitting.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnAddToFitting.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnAddToFitting.Location = New System.Drawing.Point(3, 486)
            Me.btnAddToFitting.Name = "btnAddToFitting"
            Me.btnAddToFitting.Size = New System.Drawing.Size(80, 23)
            Me.btnAddToFitting.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnAddToFitting.TabIndex = 8
            Me.btnAddToFitting.Text = "Add To Fitting"
            '
            'frmMetaVariations
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(884, 512)
            Me.Controls.Add(Me.PanelEx1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "frmMetaVariations"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "HQF Meta Variations"
            Me.ctxItems.ResumeLayout(False)
            Me.PanelEx1.ResumeLayout(False)
            Me.PanelEx1.PerformLayout()
            CType(Me.adtComparisons, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents chkShowAllColumns As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents chkApplySkills As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents ctxItems As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents mnuModuleName As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuAddToExistingFitting As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuReplaceModule As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
        Friend WithEvents btnReplaceModules As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnAddToFitting As DevComponents.DotNetBar.ButtonX
        Friend WithEvents adtComparisons As DevComponents.AdvTree.AdvTree
        Friend WithEvents colItem As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colMeta As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents RightAlign As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuRemoveColumn As System.Windows.Forms.ToolStripMenuItem
    End Class
End NameSpace