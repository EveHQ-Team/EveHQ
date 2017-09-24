Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmShipEditor
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmShipEditor))
            Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
            Me.gpShips = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.btnClearShips = New DevComponents.DotNetBar.ButtonX()
            Me.adtShips = New DevComponents.AdvTree.AdvTree()
            Me.colCustomShipName = New DevComponents.AdvTree.ColumnHeader()
            Me.colCustomShipHull = New DevComponents.AdvTree.ColumnHeader()
            Me.colCustomShipClass = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector2 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle2 = New DevComponents.DotNetBar.ElementStyle()
            Me.btnAddShip = New DevComponents.DotNetBar.ButtonX()
            Me.btnDeleteShip = New DevComponents.DotNetBar.ButtonX()
            Me.btnEditShip = New DevComponents.DotNetBar.ButtonX()
            Me.gpShipClasses = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.btnClear = New DevComponents.DotNetBar.ButtonX()
            Me.adtShipClasses = New DevComponents.AdvTree.AdvTree()
            Me.colCustomShipClassName = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me.btnAddClass = New DevComponents.DotNetBar.ButtonX()
            Me.btnDelete = New DevComponents.DotNetBar.ButtonX()
            Me.btnEdit = New DevComponents.DotNetBar.ButtonX()
            Me.sttHelp = New DevComponents.DotNetBar.SuperTooltip()
            Me.sttInfo = New DevComponents.DotNetBar.SuperTooltip()
            Me.PanelEx1.SuspendLayout()
            Me.gpShips.SuspendLayout()
            CType(Me.adtShips, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gpShipClasses.SuspendLayout()
            CType(Me.adtShipClasses, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'PanelEx1
            '
            Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
            Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.PanelEx1.Controls.Add(Me.gpShips)
            Me.PanelEx1.Controls.Add(Me.gpShipClasses)
            Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
            Me.PanelEx1.Name = "PanelEx1"
            Me.PanelEx1.Size = New System.Drawing.Size(873, 716)
            Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.PanelEx1.Style.GradientAngle = 90
            Me.PanelEx1.TabIndex = 0
            '
            'gpShips
            '
            Me.gpShips.CanvasColor = System.Drawing.SystemColors.Control
            Me.gpShips.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.gpShips.Controls.Add(Me.btnClearShips)
            Me.gpShips.Controls.Add(Me.adtShips)
            Me.gpShips.Controls.Add(Me.btnAddShip)
            Me.gpShips.Controls.Add(Me.btnDeleteShip)
            Me.gpShips.Controls.Add(Me.btnEditShip)
            Me.gpShips.IsShadowEnabled = True
            Me.gpShips.Location = New System.Drawing.Point(259, 12)
            Me.gpShips.Name = "gpShips"
            Me.gpShips.Size = New System.Drawing.Size(602, 697)
            '
            '
            '
            Me.gpShips.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.gpShips.Style.BackColorGradientAngle = 90
            Me.gpShips.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.gpShips.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpShips.Style.BorderBottomWidth = 1
            Me.gpShips.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.gpShips.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpShips.Style.BorderLeftWidth = 1
            Me.gpShips.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpShips.Style.BorderRightWidth = 1
            Me.gpShips.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpShips.Style.BorderTopWidth = 1
            Me.gpShips.Style.Class = ""
            Me.gpShips.Style.CornerDiameter = 4
            Me.gpShips.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.gpShips.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.gpShips.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.gpShips.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.gpShips.StyleMouseDown.Class = ""
            Me.gpShips.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.gpShips.StyleMouseOver.Class = ""
            Me.gpShips.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.gpShips.TabIndex = 1
            Me.gpShips.Text = "Custom Ships"
            '
            'btnClearShips
            '
            Me.btnClearShips.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnClearShips.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnClearShips.Location = New System.Drawing.Point(182, 6)
            Me.btnClearShips.Name = "btnClearShips"
            Me.btnClearShips.Size = New System.Drawing.Size(50, 23)
            Me.btnClearShips.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.sttHelp.SetSuperTooltip(Me.btnClearShips, New DevComponents.DotNetBar.SuperTooltipInfo("Clear all Ship Classes", "", "Deletes all custom ships within the list.<br /><br />" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<b>USE WITH CAUTION!</b><b" & _
                                                                                                                                    "r /><br />", Global.EveHQ.HQF.My.Resources.Resources.imgInfo1, Nothing, DevComponents.DotNetBar.eTooltipColor.Yellow))
            Me.btnClearShips.TabIndex = 7
            Me.btnClearShips.Text = "Clear"
            '
            'adtShips
            '
            Me.adtShips.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtShips.AllowDrop = True
            Me.adtShips.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtShips.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtShips.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtShips.Columns.Add(Me.colCustomShipName)
            Me.adtShips.Columns.Add(Me.colCustomShipHull)
            Me.adtShips.Columns.Add(Me.colCustomShipClass)
            Me.adtShips.ExpandWidth = 0
            
            Me.adtShips.Location = New System.Drawing.Point(3, 32)
            Me.adtShips.Name = "adtShips"
            Me.adtShips.NodesConnector = Me.NodeConnector2
            Me.adtShips.NodeStyle = Me.ElementStyle2
            Me.adtShips.PathSeparator = ";"
            Me.adtShips.Size = New System.Drawing.Size(590, 640)
            Me.adtShips.Styles.Add(Me.ElementStyle2)
            Me.adtShips.TabIndex = 1
            Me.adtShips.Text = "AdvTree1"
            '
            'colCustomShipName
            '
            Me.colCustomShipName.Name = "colCustomShipName"
            Me.colCustomShipName.SortingEnabled = False
            Me.colCustomShipName.Text = "Custom Ship Name"
            Me.colCustomShipName.Width.Absolute = 200
            '
            'colCustomShipHull
            '
            Me.colCustomShipHull.Name = "colCustomShipHull"
            Me.colCustomShipHull.SortingEnabled = False
            Me.colCustomShipHull.Text = "Ship Hull Type"
            Me.colCustomShipHull.Width.Absolute = 175
            '
            'colCustomShipClass
            '
            Me.colCustomShipClass.Name = "colCustomShipClass"
            Me.colCustomShipClass.SortingEnabled = False
            Me.colCustomShipClass.Text = "Ship Class"
            Me.colCustomShipClass.Width.Absolute = 175
            '
            'NodeConnector2
            '
            Me.NodeConnector2.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle2
            '
            Me.ElementStyle2.Class = ""
            Me.ElementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle2.Name = "ElementStyle2"
            Me.ElementStyle2.TextColor = System.Drawing.SystemColors.ControlText
            '
            'btnAddShip
            '
            Me.btnAddShip.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnAddShip.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnAddShip.Location = New System.Drawing.Point(3, 6)
            Me.btnAddShip.Name = "btnAddShip"
            Me.btnAddShip.Size = New System.Drawing.Size(50, 23)
            Me.btnAddShip.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.sttHelp.SetSuperTooltip(Me.btnAddShip, New DevComponents.DotNetBar.SuperTooltipInfo("Add a New Ship", "", "Adds a new custom ship, allowing alteration of attributes and bonuses.", Global.EveHQ.HQF.My.Resources.Resources.imgInfo1, Nothing, DevComponents.DotNetBar.eTooltipColor.Yellow))
            Me.btnAddShip.TabIndex = 2
            Me.btnAddShip.Text = "Add"
            '
            'btnDeleteShip
            '
            Me.btnDeleteShip.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnDeleteShip.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnDeleteShip.Enabled = False
            Me.btnDeleteShip.Location = New System.Drawing.Point(115, 6)
            Me.btnDeleteShip.Name = "btnDeleteShip"
            Me.btnDeleteShip.Size = New System.Drawing.Size(50, 23)
            Me.btnDeleteShip.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.sttHelp.SetSuperTooltip(Me.btnDeleteShip, New DevComponents.DotNetBar.SuperTooltipInfo("Delete a Ship Class", "", "Removes a custom ship from the list.", Global.EveHQ.HQF.My.Resources.Resources.imgInfo1, Nothing, DevComponents.DotNetBar.eTooltipColor.Yellow))
            Me.btnDeleteShip.TabIndex = 6
            Me.btnDeleteShip.Text = "Delete"
            '
            'btnEditShip
            '
            Me.btnEditShip.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnEditShip.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnEditShip.Enabled = False
            Me.btnEditShip.Location = New System.Drawing.Point(59, 6)
            Me.btnEditShip.Name = "btnEditShip"
            Me.btnEditShip.Size = New System.Drawing.Size(50, 23)
            Me.btnEditShip.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.sttHelp.SetSuperTooltip(Me.btnEditShip, New DevComponents.DotNetBar.SuperTooltipInfo("Edit a Ship", "", "Allows the editing of an existing custom ship.", Global.EveHQ.HQF.My.Resources.Resources.imgInfo1, Nothing, DevComponents.DotNetBar.eTooltipColor.Yellow))
            Me.btnEditShip.TabIndex = 5
            Me.btnEditShip.Text = "Edit"
            '
            'gpShipClasses
            '
            Me.gpShipClasses.CanvasColor = System.Drawing.SystemColors.Control
            Me.gpShipClasses.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.gpShipClasses.Controls.Add(Me.btnClear)
            Me.gpShipClasses.Controls.Add(Me.adtShipClasses)
            Me.gpShipClasses.Controls.Add(Me.btnAddClass)
            Me.gpShipClasses.Controls.Add(Me.btnDelete)
            Me.gpShipClasses.Controls.Add(Me.btnEdit)
            Me.gpShipClasses.IsShadowEnabled = True
            Me.gpShipClasses.Location = New System.Drawing.Point(12, 12)
            Me.gpShipClasses.Name = "gpShipClasses"
            Me.gpShipClasses.Size = New System.Drawing.Size(241, 697)
            '
            '
            '
            Me.gpShipClasses.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.gpShipClasses.Style.BackColorGradientAngle = 90
            Me.gpShipClasses.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.gpShipClasses.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpShipClasses.Style.BorderBottomWidth = 1
            Me.gpShipClasses.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.gpShipClasses.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpShipClasses.Style.BorderLeftWidth = 1
            Me.gpShipClasses.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpShipClasses.Style.BorderRightWidth = 1
            Me.gpShipClasses.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpShipClasses.Style.BorderTopWidth = 1
            Me.gpShipClasses.Style.Class = ""
            Me.gpShipClasses.Style.CornerDiameter = 4
            Me.gpShipClasses.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.gpShipClasses.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.gpShipClasses.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.gpShipClasses.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.gpShipClasses.StyleMouseDown.Class = ""
            Me.gpShipClasses.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.gpShipClasses.StyleMouseOver.Class = ""
            Me.gpShipClasses.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.gpShipClasses.TabIndex = 0
            Me.gpShipClasses.Text = "Custom Ship Classes"
            '
            'btnClear
            '
            Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnClear.Location = New System.Drawing.Point(182, 6)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(50, 23)
            Me.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.sttHelp.SetSuperTooltip(Me.btnClear, New DevComponents.DotNetBar.SuperTooltipInfo("Clear all Ship Classes", "", resources.GetString("btnClear.SuperTooltip"), Global.EveHQ.HQF.My.Resources.Resources.imgInfo1, Nothing, DevComponents.DotNetBar.eTooltipColor.Yellow))
            Me.btnClear.TabIndex = 4
            Me.btnClear.Text = "Clear"
            '
            'adtShipClasses
            '
            Me.adtShipClasses.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtShipClasses.AllowDrop = True
            Me.adtShipClasses.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtShipClasses.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtShipClasses.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtShipClasses.Columns.Add(Me.colCustomShipClassName)
            Me.adtShipClasses.ExpandWidth = 0
            
            Me.adtShipClasses.Location = New System.Drawing.Point(3, 32)
            Me.adtShipClasses.Name = "adtShipClasses"
            Me.adtShipClasses.NodesConnector = Me.NodeConnector1
            Me.adtShipClasses.NodeStyle = Me.ElementStyle1
            Me.adtShipClasses.PathSeparator = ";"
            Me.adtShipClasses.Size = New System.Drawing.Size(229, 640)
            Me.adtShipClasses.Styles.Add(Me.ElementStyle1)
            Me.adtShipClasses.TabIndex = 0
            Me.adtShipClasses.Text = "AdvTree1"
            '
            'colCustomShipClassName
            '
            Me.colCustomShipClassName.Name = "colCustomShipClassName"
            Me.colCustomShipClassName.SortingEnabled = False
            Me.colCustomShipClassName.Text = "Custom Ship Class Name"
            Me.colCustomShipClassName.Width.Absolute = 200
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
            'btnAddClass
            '
            Me.btnAddClass.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnAddClass.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnAddClass.Location = New System.Drawing.Point(3, 6)
            Me.btnAddClass.Name = "btnAddClass"
            Me.btnAddClass.Size = New System.Drawing.Size(50, 23)
            Me.btnAddClass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.sttHelp.SetSuperTooltip(Me.btnAddClass, New DevComponents.DotNetBar.SuperTooltipInfo("Add a New Ship Class", "", "Adds a new custom ship class to the list of classes allowed in the ship editor.", Global.EveHQ.HQF.My.Resources.Resources.imgInfo1, Nothing, DevComponents.DotNetBar.eTooltipColor.Yellow))
            Me.btnAddClass.TabIndex = 1
            Me.btnAddClass.Text = "Add"
            '
            'btnDelete
            '
            Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnDelete.Enabled = False
            Me.btnDelete.Location = New System.Drawing.Point(115, 6)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New System.Drawing.Size(50, 23)
            Me.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.sttHelp.SetSuperTooltip(Me.btnDelete, New DevComponents.DotNetBar.SuperTooltipInfo("Delete a Ship Class", "", "Removes a ship class from the list." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Warning: removing a ship class that has be" & _
                                                                                                                             "en used by new custom ships will result in those ships reverting to the base cla" & _
                                                                                                                             "ss of the original hull.", Global.EveHQ.HQF.My.Resources.Resources.imgInfo1, Nothing, DevComponents.DotNetBar.eTooltipColor.Yellow))
            Me.btnDelete.TabIndex = 3
            Me.btnDelete.Text = "Delete"
            '
            'btnEdit
            '
            Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnEdit.Enabled = False
            Me.btnEdit.Location = New System.Drawing.Point(59, 6)
            Me.btnEdit.Name = "btnEdit"
            Me.btnEdit.Size = New System.Drawing.Size(50, 23)
            Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.sttHelp.SetSuperTooltip(Me.btnEdit, New DevComponents.DotNetBar.SuperTooltipInfo("Edit a Ship Class", "", "Allows the editing of an existing ship class to alter the name and/or description" & _
                                                                                                                         ".", Global.EveHQ.HQF.My.Resources.Resources.imgInfo1, Nothing, DevComponents.DotNetBar.eTooltipColor.Yellow))
            Me.btnEdit.TabIndex = 2
            Me.btnEdit.Text = "Edit"
            '
            'sttHelp
            '
            
            Me.sttHelp.PositionBelowControl = False
            '
            'sttInfo
            '
            
            Me.sttInfo.PositionBelowControl = False
            '
            'frmShipEditor
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(873, 716)
            Me.Controls.Add(Me.PanelEx1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "frmShipEditor"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "HQF Ship Editor"
            Me.PanelEx1.ResumeLayout(False)
            Me.gpShips.ResumeLayout(False)
            CType(Me.adtShips, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gpShipClasses.ResumeLayout(False)
            CType(Me.adtShipClasses, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
        Friend WithEvents gpShipClasses As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents adtShipClasses As DevComponents.AdvTree.AdvTree
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents colCustomShipClassName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents btnClear As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnAddClass As DevComponents.DotNetBar.ButtonX
        Friend WithEvents sttHelp As DevComponents.DotNetBar.SuperTooltip
        Friend WithEvents sttInfo As DevComponents.DotNetBar.SuperTooltip
        Friend WithEvents gpShips As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents btnClearShips As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnDeleteShip As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnEditShip As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnAddShip As DevComponents.DotNetBar.ButtonX
        Friend WithEvents adtShips As DevComponents.AdvTree.AdvTree
        Friend WithEvents colCustomShipName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector2 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle2 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents colCustomShipHull As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colCustomShipClass As DevComponents.AdvTree.ColumnHeader
    End Class
End NameSpace