Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmShipSelection
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
            Me.adtCriteria = New DevComponents.AdvTree.AdvTree()
            Me.colLogic = New DevComponents.AdvTree.ColumnHeader()
            Me.colPropertyName = New DevComponents.AdvTree.ColumnHeader()
            Me.colCondition = New DevComponents.AdvTree.ColumnHeader()
            Me.colValue = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me.btnAddCriteria = New DevComponents.DotNetBar.ButtonX()
            Me.btnUpdateShips = New DevComponents.DotNetBar.ButtonX()
            Me.adtPropertyShips = New DevComponents.AdvTree.AdvTree()
            Me.colShipName = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector2 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle2 = New DevComponents.DotNetBar.ElementStyle()
            Me.btnRemoveCriteria = New DevComponents.DotNetBar.ButtonX()
            Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
            Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
            Me.tiProperties = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
            Me.lblSearchTags = New DevComponents.DotNetBar.LabelX()
            Me.gpTagCloud = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.lblTagCloud = New DevComponents.DotNetBar.LabelX()
            Me.txtTagSearch = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.adtTagResults = New DevComponents.AdvTree.AdvTree()
            Me.colShip = New DevComponents.AdvTree.ColumnHeader()
            Me.colFittingName = New DevComponents.AdvTree.ColumnHeader()
            Me.colRating = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector3 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle3 = New DevComponents.DotNetBar.ElementStyle()
            Me.tiTags = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.ctxShips = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.mnuCreateNewFitting = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuPreviewShip = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.adtCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.adtPropertyShips, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControl1.SuspendLayout()
            Me.TabControlPanel2.SuspendLayout()
            Me.TabControlPanel1.SuspendLayout()
            Me.gpTagCloud.SuspendLayout()
            CType(Me.adtTagResults, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ctxShips.SuspendLayout()
            Me.SuspendLayout()
            '
            'adtCriteria
            '
            Me.adtCriteria.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtCriteria.AllowDrop = True
            Me.adtCriteria.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtCriteria.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtCriteria.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtCriteria.Columns.Add(Me.colLogic)
            Me.adtCriteria.Columns.Add(Me.colPropertyName)
            Me.adtCriteria.Columns.Add(Me.colCondition)
            Me.adtCriteria.Columns.Add(Me.colValue)
            Me.adtCriteria.ExpandWidth = 0
            
            Me.adtCriteria.Location = New System.Drawing.Point(4, 4)
            Me.adtCriteria.Name = "adtCriteria"
            Me.adtCriteria.NodesConnector = Me.NodeConnector1
            Me.adtCriteria.NodeStyle = Me.ElementStyle1
            Me.adtCriteria.PathSeparator = ";"
            Me.adtCriteria.Size = New System.Drawing.Size(564, 155)
            Me.adtCriteria.Styles.Add(Me.ElementStyle1)
            Me.adtCriteria.TabIndex = 0
            Me.adtCriteria.Text = "AdvTree1"
            '
            'colLogic
            '
            Me.colLogic.DisplayIndex = 1
            Me.colLogic.Name = "colLogic"
            Me.colLogic.Text = "Logic"
            Me.colLogic.Width.Absolute = 75
            '
            'colPropertyName
            '
            Me.colPropertyName.DisplayIndex = 2
            Me.colPropertyName.Name = "colPropertyName"
            Me.colPropertyName.Text = "Ship Property"
            Me.colPropertyName.Width.Absolute = 150
            '
            'colCondition
            '
            Me.colCondition.DisplayIndex = 3
            Me.colCondition.Name = "colCondition"
            Me.colCondition.Text = "Condition"
            Me.colCondition.Width.Absolute = 200
            '
            'colValue
            '
            Me.colValue.DisplayIndex = 4
            Me.colValue.Name = "colValue"
            Me.colValue.Text = "Value"
            Me.colValue.Width.Absolute = 100
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
            'btnAddCriteria
            '
            Me.btnAddCriteria.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnAddCriteria.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnAddCriteria.Location = New System.Drawing.Point(574, 24)
            Me.btnAddCriteria.Name = "btnAddCriteria"
            Me.btnAddCriteria.Size = New System.Drawing.Size(100, 23)
            Me.btnAddCriteria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnAddCriteria.TabIndex = 1
            Me.btnAddCriteria.Text = "Add Criteria"
            '
            'btnUpdateShips
            '
            Me.btnUpdateShips.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnUpdateShips.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnUpdateShips.Location = New System.Drawing.Point(574, 136)
            Me.btnUpdateShips.Name = "btnUpdateShips"
            Me.btnUpdateShips.Size = New System.Drawing.Size(100, 23)
            Me.btnUpdateShips.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnUpdateShips.TabIndex = 2
            Me.btnUpdateShips.Text = "Update Ships"
            '
            'adtPropertyShips
            '
            Me.adtPropertyShips.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtPropertyShips.AllowDrop = True
            Me.adtPropertyShips.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtPropertyShips.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtPropertyShips.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtPropertyShips.Columns.Add(Me.colShipName)
            Me.adtPropertyShips.ExpandWidth = 0
            
            Me.adtPropertyShips.Location = New System.Drawing.Point(4, 165)
            Me.adtPropertyShips.Name = "adtPropertyShips"
            Me.adtPropertyShips.NodesConnector = Me.NodeConnector2
            Me.adtPropertyShips.NodeStyle = Me.ElementStyle2
            Me.adtPropertyShips.PathSeparator = ";"
            Me.adtPropertyShips.Size = New System.Drawing.Size(670, 285)
            Me.adtPropertyShips.Styles.Add(Me.ElementStyle2)
            Me.adtPropertyShips.TabIndex = 3
            Me.adtPropertyShips.Text = "AdvTree1"
            '
            'colShipName
            '
            Me.colShipName.DisplayIndex = 1
            Me.colShipName.Name = "colShipName"
            Me.colShipName.Text = "Ship Name"
            Me.colShipName.Width.Absolute = 250
            '
            'NodeConnector2
            '
            Me.NodeConnector2.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle2
            '
            Me.ElementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle2.Name = "ElementStyle2"
            Me.ElementStyle2.TextColor = System.Drawing.SystemColors.ControlText
            '
            'btnRemoveCriteria
            '
            Me.btnRemoveCriteria.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnRemoveCriteria.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnRemoveCriteria.Enabled = False
            Me.btnRemoveCriteria.Location = New System.Drawing.Point(574, 53)
            Me.btnRemoveCriteria.Name = "btnRemoveCriteria"
            Me.btnRemoveCriteria.Size = New System.Drawing.Size(100, 23)
            Me.btnRemoveCriteria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnRemoveCriteria.TabIndex = 4
            Me.btnRemoveCriteria.Text = "Remove Criteria"
            '
            'TabControl1
            '
            Me.TabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(125, Byte), Integer))
            Me.TabControl1.CanReorderTabs = True
            Me.TabControl1.Controls.Add(Me.TabControlPanel2)
            Me.TabControl1.Controls.Add(Me.TabControlPanel1)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 0)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.TabControl1.SelectedTabIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(683, 479)
            Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
            Me.TabControl1.TabIndex = 5
            Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
            Me.TabControl1.Tabs.Add(Me.tiTags)
            Me.TabControl1.Tabs.Add(Me.tiProperties)
            Me.TabControl1.Text = "TabControl1"
            '
            'TabControlPanel2
            '
            Me.TabControlPanel2.Controls.Add(Me.adtCriteria)
            Me.TabControlPanel2.Controls.Add(Me.btnRemoveCriteria)
            Me.TabControlPanel2.Controls.Add(Me.btnAddCriteria)
            Me.TabControlPanel2.Controls.Add(Me.adtPropertyShips)
            Me.TabControlPanel2.Controls.Add(Me.btnUpdateShips)
            Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel2.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel2.Name = "TabControlPanel2"
            Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel2.Size = New System.Drawing.Size(683, 456)
            Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                                                          Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel2.Style.GradientAngle = 90
            Me.TabControlPanel2.TabIndex = 2
            Me.TabControlPanel2.TabItem = Me.tiProperties
            '
            'tiProperties
            '
            Me.tiProperties.AttachedControl = Me.TabControlPanel2
            Me.tiProperties.Name = "tiProperties"
            Me.tiProperties.Text = "Ship Properties"
            '
            'TabControlPanel1
            '
            Me.TabControlPanel1.Controls.Add(Me.lblSearchTags)
            Me.TabControlPanel1.Controls.Add(Me.gpTagCloud)
            Me.TabControlPanel1.Controls.Add(Me.txtTagSearch)
            Me.TabControlPanel1.Controls.Add(Me.adtTagResults)
            Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel1.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel1.Name = "TabControlPanel1"
            Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel1.Size = New System.Drawing.Size(683, 456)
            Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                                                          Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel1.Style.GradientAngle = 90
            Me.TabControlPanel1.TabIndex = 1
            Me.TabControlPanel1.TabItem = Me.tiTags
            '
            'lblSearchTags
            '
            Me.lblSearchTags.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblSearchTags.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblSearchTags.Location = New System.Drawing.Point(10, 131)
            Me.lblSearchTags.Name = "lblSearchTags"
            Me.lblSearchTags.Size = New System.Drawing.Size(75, 23)
            Me.lblSearchTags.TabIndex = 7
            Me.lblSearchTags.Text = "Search Tags:"
            '
            'gpTagCloud
            '
            Me.gpTagCloud.CanvasColor = System.Drawing.SystemColors.Control
            Me.gpTagCloud.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.gpTagCloud.Controls.Add(Me.lblTagCloud)
            Me.gpTagCloud.Location = New System.Drawing.Point(4, 5)
            Me.gpTagCloud.Name = "gpTagCloud"
            Me.gpTagCloud.Size = New System.Drawing.Size(675, 120)
            '
            '
            '
            Me.gpTagCloud.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.gpTagCloud.Style.BackColorGradientAngle = 90
            Me.gpTagCloud.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.gpTagCloud.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpTagCloud.Style.BorderBottomWidth = 1
            Me.gpTagCloud.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.gpTagCloud.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpTagCloud.Style.BorderLeftWidth = 1
            Me.gpTagCloud.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpTagCloud.Style.BorderRightWidth = 1
            Me.gpTagCloud.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpTagCloud.Style.BorderTopWidth = 1
            Me.gpTagCloud.Style.CornerDiameter = 4
            Me.gpTagCloud.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.gpTagCloud.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.gpTagCloud.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.gpTagCloud.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.gpTagCloud.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.gpTagCloud.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.gpTagCloud.TabIndex = 6
            Me.gpTagCloud.Text = "Tag Cloud"
            '
            'lblTagCloud
            '
            Me.lblTagCloud.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                            Or System.Windows.Forms.AnchorStyles.Left) _
                                           Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblTagCloud.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblTagCloud.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblTagCloud.Location = New System.Drawing.Point(3, 3)
            Me.lblTagCloud.Name = "lblTagCloud"
            Me.lblTagCloud.Size = New System.Drawing.Size(663, 92)
            Me.lblTagCloud.TabIndex = 0
            Me.lblTagCloud.Text = "LabelX1"
            '
            'txtTagSearch
            '
            Me.txtTagSearch.BackColor = System.Drawing.SystemColors.Control
            '
            '
            '
            Me.txtTagSearch.Border.Class = "TextBoxBorder"
            Me.txtTagSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.txtTagSearch.ForeColor = System.Drawing.SystemColors.ControlText
            Me.txtTagSearch.Location = New System.Drawing.Point(91, 134)
            Me.txtTagSearch.Name = "txtTagSearch"
            Me.txtTagSearch.PreventEnterBeep = True
            Me.txtTagSearch.Size = New System.Drawing.Size(284, 21)
            Me.txtTagSearch.TabIndex = 5
            '
            'adtTagResults
            '
            Me.adtTagResults.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtTagResults.AllowDrop = True
            Me.adtTagResults.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtTagResults.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtTagResults.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtTagResults.Columns.Add(Me.colShip)
            Me.adtTagResults.Columns.Add(Me.colFittingName)
            Me.adtTagResults.Columns.Add(Me.colRating)
            Me.adtTagResults.ExpandWidth = 0
            
            Me.adtTagResults.Location = New System.Drawing.Point(4, 167)
            Me.adtTagResults.Name = "adtTagResults"
            Me.adtTagResults.NodesConnector = Me.NodeConnector3
            Me.adtTagResults.NodeStyle = Me.ElementStyle3
            Me.adtTagResults.PathSeparator = ";"
            Me.adtTagResults.Size = New System.Drawing.Size(670, 285)
            Me.adtTagResults.Styles.Add(Me.ElementStyle3)
            Me.adtTagResults.TabIndex = 4
            Me.adtTagResults.Text = "AdvTree1"
            '
            'colShip
            '
            Me.colShip.DisplayIndex = 1
            Me.colShip.Name = "colShip"
            Me.colShip.Text = "Ship Name"
            Me.colShip.Width.Absolute = 150
            '
            'colFittingName
            '
            Me.colFittingName.DisplayIndex = 2
            Me.colFittingName.Name = "colFittingName"
            Me.colFittingName.Text = "Fitting Name"
            Me.colFittingName.Width.Absolute = 250
            '
            'colRating
            '
            Me.colRating.DisplayIndex = 3
            Me.colRating.Name = "colRating"
            Me.colRating.StretchToFill = True
            Me.colRating.Text = "Your Rating"
            Me.colRating.Width.Absolute = 150
            '
            'NodeConnector3
            '
            Me.NodeConnector3.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle3
            '
            Me.ElementStyle3.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle3.Name = "ElementStyle3"
            Me.ElementStyle3.TextColor = System.Drawing.SystemColors.ControlText
            '
            'tiTags
            '
            Me.tiTags.AttachedControl = Me.TabControlPanel1
            Me.tiTags.Name = "tiTags"
            Me.tiTags.Text = "Tags"
            '
            'ctxShips
            '
            Me.ctxShips.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCreateNewFitting, Me.ToolStripMenuItem1, Me.mnuPreviewShip})
            Me.ctxShips.Name = "ctxShips"
            Me.ctxShips.Size = New System.Drawing.Size(180, 54)
            '
            'mnuCreateNewFitting
            '
            Me.mnuCreateNewFitting.Name = "mnuCreateNewFitting"
            Me.mnuCreateNewFitting.Size = New System.Drawing.Size(179, 22)
            Me.mnuCreateNewFitting.Text = "Create New Fitting"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(176, 6)
            '
            'mnuPreviewShip
            '
            Me.mnuPreviewShip.Name = "mnuPreviewShip"
            Me.mnuPreviewShip.Size = New System.Drawing.Size(179, 22)
            Me.mnuPreviewShip.Text = "Preview Ship Details"
            '
            'frmShipSelection
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(683, 479)
            Me.Controls.Add(Me.TabControl1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmShipSelection"
            Me.ShowIcon = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "HQF Ship Selector"
            CType(Me.adtCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.adtPropertyShips, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControl1.ResumeLayout(False)
            Me.TabControlPanel2.ResumeLayout(False)
            Me.TabControlPanel1.ResumeLayout(False)
            Me.gpTagCloud.ResumeLayout(False)
            CType(Me.adtTagResults, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ctxShips.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents adtCriteria As DevComponents.AdvTree.AdvTree
        Friend WithEvents colPropertyName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colCondition As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colValue As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents btnAddCriteria As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnUpdateShips As DevComponents.DotNetBar.ButtonX
        Friend WithEvents adtPropertyShips As DevComponents.AdvTree.AdvTree
        Friend WithEvents colShipName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector2 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle2 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents colLogic As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents btnRemoveCriteria As DevComponents.DotNetBar.ButtonX
        Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
        Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tiProperties As DevComponents.DotNetBar.TabItem
        Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tiTags As DevComponents.DotNetBar.TabItem
        Friend WithEvents txtTagSearch As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents adtTagResults As DevComponents.AdvTree.AdvTree
        Friend WithEvents colShip As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector3 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle3 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents gpTagCloud As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents lblTagCloud As DevComponents.DotNetBar.LabelX
        Friend WithEvents colFittingName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents lblSearchTags As DevComponents.DotNetBar.LabelX
        Friend WithEvents colRating As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents ctxShips As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents mnuCreateNewFitting As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuPreviewShip As System.Windows.Forms.ToolStripMenuItem
    End Class
End NameSpace