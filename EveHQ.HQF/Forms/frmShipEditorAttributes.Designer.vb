Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmShipEditorAttributes
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
            Me.btnAddBonus = New DevComponents.DotNetBar.ButtonX()
            Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
            Me.btnAccept = New DevComponents.DotNetBar.ButtonX()
            Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
            Me.picValidShipName = New DevComponents.DotNetBar.Controls.ReflectionImage()
            Me.btnEditBonus = New DevComponents.DotNetBar.ButtonX()
            Me.btnDeleteBonus = New DevComponents.DotNetBar.ButtonX()
            Me.btnClearBonuses = New DevComponents.DotNetBar.ButtonX()
            Me.picDescription = New DevComponents.DotNetBar.Controls.ReflectionImage()
            Me.tvwBonuses = New DevComponents.AdvTree.AdvTree()
            Me.colBShipID = New DevComponents.AdvTree.ColumnHeader()
            Me.colBAffectingType = New DevComponents.AdvTree.ColumnHeader()
            Me.colBAffectingID = New DevComponents.AdvTree.ColumnHeader()
            Me.colBAttribute = New DevComponents.AdvTree.ColumnHeader()
            Me.colBAffectedType = New DevComponents.AdvTree.ColumnHeader()
            Me.colBAffectedID = New DevComponents.AdvTree.ColumnHeader()
            Me.colBValue = New DevComponents.AdvTree.ColumnHeader()
            Me.colBBonusType = New DevComponents.AdvTree.ColumnHeader()
            Me.colBStacking = New DevComponents.AdvTree.ColumnHeader()
            Me.colBCalcType = New DevComponents.AdvTree.ColumnHeader()
            Me.colBStatus = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me.btnLockBonuses = New DevComponents.DotNetBar.ButtonX()
            Me.btnLockAttributes = New DevComponents.DotNetBar.ButtonX()
            Me.picShip = New DevComponents.DotNetBar.Controls.ReflectionImage()
            Me.lblShipID = New DevComponents.DotNetBar.LabelX()
            Me.txtShipName = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.lblShipName = New DevComponents.DotNetBar.LabelX()
            Me.chkAutoBonusDescription = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.txtDescription = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.lblBaseDescription = New DevComponents.DotNetBar.LabelX()
            Me.cboShipClass = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblShipClass = New DevComponents.DotNetBar.LabelX()
            Me.lblShipHull = New DevComponents.DotNetBar.LabelX()
            Me.apg1 = New DevComponents.DotNetBar.AdvPropertyGrid()
            Me.cboShipHull = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.sttBonus = New DevComponents.DotNetBar.SuperTooltip()
            Me.PanelEx1.SuspendLayout()
            CType(Me.tvwBonuses, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.apg1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnAddBonus
            '
            Me.btnAddBonus.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnAddBonus.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnAddBonus.Enabled = False
            Me.btnAddBonus.Location = New System.Drawing.Point(3, 420)
            Me.btnAddBonus.Name = "btnAddBonus"
            Me.btnAddBonus.Size = New System.Drawing.Size(75, 23)
            Me.btnAddBonus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnAddBonus.TabIndex = 15
            Me.btnAddBonus.Text = "Add Bonus"
            '
            'PanelEx1
            '
            Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
            Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.PanelEx1.Controls.Add(Me.btnAccept)
            Me.PanelEx1.Controls.Add(Me.btnCancel)
            Me.PanelEx1.Controls.Add(Me.picValidShipName)
            Me.PanelEx1.Controls.Add(Me.btnEditBonus)
            Me.PanelEx1.Controls.Add(Me.btnDeleteBonus)
            Me.PanelEx1.Controls.Add(Me.btnClearBonuses)
            Me.PanelEx1.Controls.Add(Me.picDescription)
            Me.PanelEx1.Controls.Add(Me.tvwBonuses)
            Me.PanelEx1.Controls.Add(Me.btnLockBonuses)
            Me.PanelEx1.Controls.Add(Me.btnLockAttributes)
            Me.PanelEx1.Controls.Add(Me.picShip)
            Me.PanelEx1.Controls.Add(Me.lblShipID)
            Me.PanelEx1.Controls.Add(Me.txtShipName)
            Me.PanelEx1.Controls.Add(Me.lblShipName)
            Me.PanelEx1.Controls.Add(Me.chkAutoBonusDescription)
            Me.PanelEx1.Controls.Add(Me.txtDescription)
            Me.PanelEx1.Controls.Add(Me.lblBaseDescription)
            Me.PanelEx1.Controls.Add(Me.cboShipClass)
            Me.PanelEx1.Controls.Add(Me.lblShipClass)
            Me.PanelEx1.Controls.Add(Me.lblShipHull)
            Me.PanelEx1.Controls.Add(Me.apg1)
            Me.PanelEx1.Controls.Add(Me.cboShipHull)
            Me.PanelEx1.Controls.Add(Me.btnAddBonus)
            Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
            Me.PanelEx1.Name = "PanelEx1"
            Me.PanelEx1.Size = New System.Drawing.Size(820, 703)
            Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.PanelEx1.Style.GradientAngle = 90
            Me.PanelEx1.TabIndex = 16
            '
            'btnAccept
            '
            Me.btnAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnAccept.Location = New System.Drawing.Point(661, 673)
            Me.btnAccept.Name = "btnAccept"
            Me.btnAccept.Size = New System.Drawing.Size(75, 23)
            Me.btnAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnAccept.TabIndex = 37
            Me.btnAccept.Text = "Accept"
            '
            'btnCancel
            '
            Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnCancel.Location = New System.Drawing.Point(742, 673)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnCancel.TabIndex = 36
            Me.btnCancel.Text = "Cancel"
            '
            'picValidShipName
            '
            '
            '
            '
            Me.picValidShipName.BackgroundStyle.Class = ""
            Me.picValidShipName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.picValidShipName.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.picValidShipName.Image = Global.EveHQ.HQF.My.Resources.Resources.cross_small
            Me.picValidShipName.Location = New System.Drawing.Point(350, 97)
            Me.picValidShipName.Name = "picValidShipName"
            Me.picValidShipName.ReflectionEnabled = False
            Me.picValidShipName.Size = New System.Drawing.Size(16, 16)
            Me.picValidShipName.TabIndex = 35
            '
            'btnEditBonus
            '
            Me.btnEditBonus.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnEditBonus.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnEditBonus.Enabled = False
            Me.btnEditBonus.Location = New System.Drawing.Point(246, 420)
            Me.btnEditBonus.Name = "btnEditBonus"
            Me.btnEditBonus.Size = New System.Drawing.Size(75, 23)
            Me.btnEditBonus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnEditBonus.TabIndex = 34
            Me.btnEditBonus.Text = "Edit Bonus"
            '
            'btnDeleteBonus
            '
            Me.btnDeleteBonus.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnDeleteBonus.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnDeleteBonus.Enabled = False
            Me.btnDeleteBonus.Location = New System.Drawing.Point(165, 420)
            Me.btnDeleteBonus.Name = "btnDeleteBonus"
            Me.btnDeleteBonus.Size = New System.Drawing.Size(75, 23)
            Me.btnDeleteBonus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnDeleteBonus.TabIndex = 33
            Me.btnDeleteBonus.Text = "Delete Bonus"
            '
            'btnClearBonuses
            '
            Me.btnClearBonuses.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnClearBonuses.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnClearBonuses.Enabled = False
            Me.btnClearBonuses.Location = New System.Drawing.Point(84, 420)
            Me.btnClearBonuses.Name = "btnClearBonuses"
            Me.btnClearBonuses.Size = New System.Drawing.Size(75, 23)
            Me.btnClearBonuses.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnClearBonuses.TabIndex = 32
            Me.btnClearBonuses.Text = "Clear Bonuses"
            '
            'picDescription
            '
            '
            '
            '
            Me.picDescription.BackgroundStyle.Class = ""
            Me.picDescription.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.picDescription.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.picDescription.Image = Global.EveHQ.HQF.My.Resources.Resources.imgInfo1
            Me.picDescription.Location = New System.Drawing.Point(350, 305)
            Me.picDescription.Name = "picDescription"
            Me.picDescription.Size = New System.Drawing.Size(36, 51)
            Me.picDescription.TabIndex = 31
            '
            'tvwBonuses
            '
            Me.tvwBonuses.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.tvwBonuses.AllowDrop = True
            Me.tvwBonuses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                          Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tvwBonuses.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.tvwBonuses.BackgroundStyle.Class = "TreeBorderKey"
            Me.tvwBonuses.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.tvwBonuses.Columns.Add(Me.colBShipID)
            Me.tvwBonuses.Columns.Add(Me.colBAffectingType)
            Me.tvwBonuses.Columns.Add(Me.colBAffectingID)
            Me.tvwBonuses.Columns.Add(Me.colBAttribute)
            Me.tvwBonuses.Columns.Add(Me.colBAffectedType)
            Me.tvwBonuses.Columns.Add(Me.colBAffectedID)
            Me.tvwBonuses.Columns.Add(Me.colBValue)
            Me.tvwBonuses.Columns.Add(Me.colBBonusType)
            Me.tvwBonuses.Columns.Add(Me.colBStacking)
            Me.tvwBonuses.Columns.Add(Me.colBCalcType)
            Me.tvwBonuses.Columns.Add(Me.colBStatus)
            Me.tvwBonuses.DragDropEnabled = False
            Me.tvwBonuses.Enabled = False
            Me.tvwBonuses.ExpandWidth = 0
            
            Me.tvwBonuses.Location = New System.Drawing.Point(3, 451)
            Me.tvwBonuses.MultiSelect = True
            Me.tvwBonuses.Name = "tvwBonuses"
            Me.tvwBonuses.NodesConnector = Me.NodeConnector1
            Me.tvwBonuses.NodeStyle = Me.ElementStyle1
            Me.tvwBonuses.PathSeparator = ";"
            Me.tvwBonuses.Size = New System.Drawing.Size(814, 216)
            Me.tvwBonuses.Styles.Add(Me.ElementStyle1)
            Me.tvwBonuses.TabIndex = 30
            Me.tvwBonuses.Text = "AdvTree1"
            '
            'colBShipID
            '
            Me.colBShipID.Name = "colBShipID"
            Me.colBShipID.SortingEnabled = False
            Me.colBShipID.Text = "Ship ID"
            Me.colBShipID.Width.Absolute = 60
            '
            'colBAffectingType
            '
            Me.colBAffectingType.Name = "colBAffectingType"
            Me.colBAffectingType.SortingEnabled = False
            Me.colBAffectingType.Text = "Affecting Type"
            Me.colBAffectingType.Width.Absolute = 80
            '
            'colBAffectingID
            '
            Me.colBAffectingID.Name = "colBAffectingID"
            Me.colBAffectingID.Text = "Affecting ID"
            Me.colBAffectingID.Width.Absolute = 75
            '
            'colBAttribute
            '
            Me.colBAttribute.Name = "colBAttribute"
            Me.colBAttribute.Text = "Attribute"
            Me.colBAttribute.Width.Absolute = 50
            '
            'colBAffectedType
            '
            Me.colBAffectedType.Name = "colBAffectedType"
            Me.colBAffectedType.Text = "Affected Type"
            Me.colBAffectedType.Width.Absolute = 80
            '
            'colBAffectedID
            '
            Me.colBAffectedID.Name = "colBAffectedID"
            Me.colBAffectedID.Text = "Affected ID"
            Me.colBAffectedID.Width.Absolute = 75
            '
            'colBValue
            '
            Me.colBValue.Name = "colBValue"
            Me.colBValue.Text = "Value"
            Me.colBValue.Width.Absolute = 50
            '
            'colBBonusType
            '
            Me.colBBonusType.Name = "colBBonusType"
            Me.colBBonusType.Text = "Bonus Type"
            Me.colBBonusType.Width.Absolute = 75
            '
            'colBStacking
            '
            Me.colBStacking.Name = "colBStacking"
            Me.colBStacking.Text = "Stacking"
            Me.colBStacking.Width.Absolute = 50
            '
            'colBCalcType
            '
            Me.colBCalcType.Name = "colBCalcType"
            Me.colBCalcType.Text = "Calc Type"
            Me.colBCalcType.Width.Absolute = 75
            '
            'colBStatus
            '
            Me.colBStatus.Name = "colBStatus"
            Me.colBStatus.SortingEnabled = False
            Me.colBStatus.Text = "Status"
            Me.colBStatus.Width.Absolute = 50
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
            'btnLockBonuses
            '
            Me.btnLockBonuses.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnLockBonuses.AutoCheckOnClick = True
            Me.btnLockBonuses.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnLockBonuses.Enabled = False
            Me.btnLockBonuses.Location = New System.Drawing.Point(416, 43)
            Me.btnLockBonuses.Name = "btnLockBonuses"
            Me.btnLockBonuses.Size = New System.Drawing.Size(60, 48)
            Me.btnLockBonuses.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.sttBonus.SetSuperTooltip(Me.btnLockBonuses, New DevComponents.DotNetBar.SuperTooltipInfo("", "Lock Bonuses", "This button will lock the bonuses from any changes made to the Ship Hull type. It" & _
                                                                                                                            " does not affect the ability to edit the Bonuses in the Editor.", Nothing, Global.EveHQ.HQF.My.Resources.Resources.imgInfo1, DevComponents.DotNetBar.eTooltipColor.Yellow, False, True, New System.Drawing.Size(0, 0)))
            Me.btnLockBonuses.TabIndex = 29
            Me.btnLockBonuses.Text = "Lock Bonuses"
            '
            'btnLockAttributes
            '
            Me.btnLockAttributes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnLockAttributes.AutoCheckOnClick = True
            Me.btnLockAttributes.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnLockAttributes.Enabled = False
            Me.btnLockAttributes.Location = New System.Drawing.Point(350, 43)
            Me.btnLockAttributes.Name = "btnLockAttributes"
            Me.btnLockAttributes.Size = New System.Drawing.Size(60, 48)
            Me.btnLockAttributes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.sttBonus.SetSuperTooltip(Me.btnLockAttributes, New DevComponents.DotNetBar.SuperTooltipInfo("", "Lock Attributes", "This button will lock the attributes from any changes made to the Ship Hull type." & _
                                                                                                                                  " It does not affect the ability to edit the Ship Properties in the Editor.", Nothing, Global.EveHQ.HQF.My.Resources.Resources.imgInfo1, DevComponents.DotNetBar.eTooltipColor.Yellow, False, True, New System.Drawing.Size(0, 0)))
            Me.btnLockAttributes.TabIndex = 28
            Me.btnLockAttributes.Text = "Lock Attributes"
            '
            'picShip
            '
            '
            '
            '
            Me.picShip.BackgroundStyle.Class = ""
            Me.picShip.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.picShip.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.picShip.Location = New System.Drawing.Point(350, 153)
            Me.picShip.Name = "picShip"
            Me.picShip.ReflectionEnabled = False
            Me.picShip.Size = New System.Drawing.Size(128, 128)
            Me.picShip.TabIndex = 27
            '
            'lblShipID
            '
            '
            '
            '
            Me.lblShipID.BackgroundStyle.Class = ""
            Me.lblShipID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblShipID.Location = New System.Drawing.Point(12, 12)
            Me.lblShipID.Name = "lblShipID"
            Me.lblShipID.Size = New System.Drawing.Size(332, 23)
            Me.lblShipID.TabIndex = 26
            Me.lblShipID.Text = "New Custom Ship ID:"
            '
            'txtShipName
            '
            '
            '
            '
            Me.txtShipName.Border.Class = "TextBoxBorder"
            Me.txtShipName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.txtShipName.Enabled = False
            Me.txtShipName.Location = New System.Drawing.Point(166, 97)
            Me.txtShipName.Name = "txtShipName"
            Me.txtShipName.Size = New System.Drawing.Size(178, 21)
            Me.txtShipName.TabIndex = 25
            '
            'lblShipName
            '
            '
            '
            '
            Me.lblShipName.BackgroundStyle.Class = ""
            Me.lblShipName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblShipName.Location = New System.Drawing.Point(12, 95)
            Me.lblShipName.Name = "lblShipName"
            Me.lblShipName.Size = New System.Drawing.Size(148, 23)
            Me.lblShipName.TabIndex = 24
            Me.lblShipName.Text = "Step 3: Enter Ship Name:"
            '
            'chkAutoBonusDescription
            '
            Me.chkAutoBonusDescription.AutoSize = True
            '
            '
            '
            Me.chkAutoBonusDescription.BackgroundStyle.Class = ""
            Me.chkAutoBonusDescription.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkAutoBonusDescription.Enabled = False
            Me.chkAutoBonusDescription.FocusCuesEnabled = False
            Me.chkAutoBonusDescription.Location = New System.Drawing.Point(12, 362)
            Me.chkAutoBonusDescription.Name = "chkAutoBonusDescription"
            Me.chkAutoBonusDescription.Size = New System.Drawing.Size(274, 16)
            Me.chkAutoBonusDescription.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.sttBonus.SetSuperTooltip(Me.chkAutoBonusDescription, New DevComponents.DotNetBar.SuperTooltipInfo("", "Automatically Add Bonus Info", "This option will automatically parse and add the bonus information to the end of " & _
                                                                                                                                                     "the base ship description.", Nothing, Global.EveHQ.HQF.My.Resources.Resources.imgInfo1, DevComponents.DotNetBar.eTooltipColor.Yellow, False, True, New System.Drawing.Size(0, 0)))
            Me.chkAutoBonusDescription.TabIndex = 22
            Me.chkAutoBonusDescription.Text = "Automatically Add Bonus Information to Description"
            '
            'txtDescription
            '
            '
            '
            '
            Me.txtDescription.Border.Class = "TextBoxBorder"
            Me.txtDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.txtDescription.Enabled = False
            Me.txtDescription.Location = New System.Drawing.Point(12, 153)
            Me.txtDescription.MaxLength = 1000
            Me.txtDescription.Multiline = True
            Me.txtDescription.Name = "txtDescription"
            Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtDescription.Size = New System.Drawing.Size(332, 203)
            Me.txtDescription.TabIndex = 21
            Me.txtDescription.WatermarkColor = System.Drawing.Color.Silver
            Me.txtDescription.WatermarkText = "You can write a description of the new ship here. This will be used for informati" & _
                                              "onal purposes only."
            '
            'lblBaseDescription
            '
            '
            '
            '
            Me.lblBaseDescription.BackgroundStyle.Class = ""
            Me.lblBaseDescription.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblBaseDescription.Location = New System.Drawing.Point(12, 124)
            Me.lblBaseDescription.Name = "lblBaseDescription"
            Me.lblBaseDescription.Size = New System.Drawing.Size(208, 23)
            Me.lblBaseDescription.TabIndex = 20
            Me.lblBaseDescription.Text = "Enter Base Ship Description:"
            '
            'cboShipClass
            '
            Me.cboShipClass.DisplayMember = "Text"
            Me.cboShipClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboShipClass.Enabled = False
            Me.cboShipClass.FormattingEnabled = True
            Me.cboShipClass.ItemHeight = 15
            Me.cboShipClass.Location = New System.Drawing.Point(166, 70)
            Me.cboShipClass.Name = "cboShipClass"
            Me.cboShipClass.Size = New System.Drawing.Size(178, 21)
            Me.cboShipClass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboShipClass.TabIndex = 19
            '
            'lblShipClass
            '
            '
            '
            '
            Me.lblShipClass.BackgroundStyle.Class = ""
            Me.lblShipClass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblShipClass.Location = New System.Drawing.Point(12, 68)
            Me.lblShipClass.Name = "lblShipClass"
            Me.lblShipClass.Size = New System.Drawing.Size(148, 23)
            Me.lblShipClass.TabIndex = 18
            Me.lblShipClass.Text = "Step 2: Select Ship Class:"
            '
            'lblShipHull
            '
            '
            '
            '
            Me.lblShipHull.BackgroundStyle.Class = ""
            Me.lblShipHull.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblShipHull.Location = New System.Drawing.Point(12, 41)
            Me.lblShipHull.Name = "lblShipHull"
            Me.lblShipHull.Size = New System.Drawing.Size(148, 23)
            Me.lblShipHull.TabIndex = 17
            Me.lblShipHull.Text = "Step 1: Select Ship Hull:"
            '
            'apg1
            '
            Me.apg1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.apg1.BackgroundImage = Global.EveHQ.HQF.My.Resources.Resources.imgSigRadius
            Me.apg1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.apg1.Enabled = False
            Me.apg1.GridLinesColor = System.Drawing.Color.WhiteSmoke
            Me.apg1.Location = New System.Drawing.Point(484, 3)
            Me.apg1.Name = "apg1"
            Me.apg1.Size = New System.Drawing.Size(333, 442)
            Me.apg1.TabIndex = 16
            Me.apg1.Text = "AdvPropertyGrid1"
            '
            'cboShipHull
            '
            Me.cboShipHull.DisplayMember = "Text"
            Me.cboShipHull.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboShipHull.FormattingEnabled = True
            Me.cboShipHull.ItemHeight = 15
            Me.cboShipHull.Location = New System.Drawing.Point(166, 43)
            Me.cboShipHull.Name = "cboShipHull"
            Me.cboShipHull.Size = New System.Drawing.Size(178, 21)
            Me.cboShipHull.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboShipHull.TabIndex = 0
            '
            'sttBonus
            '
            Me.sttBonus.DefaultFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            
            Me.sttBonus.PositionBelowControl = False
            '
            'frmShipEditorAttributes
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(820, 703)
            Me.Controls.Add(Me.PanelEx1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "frmShipEditorAttributes"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "HQF Ship Attribute Editor"
            Me.PanelEx1.ResumeLayout(False)
            Me.PanelEx1.PerformLayout()
            CType(Me.tvwBonuses, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.apg1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnAddBonus As DevComponents.DotNetBar.ButtonX
        Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
        Friend WithEvents cboShipHull As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents apg1 As DevComponents.DotNetBar.AdvPropertyGrid
        Friend WithEvents lblShipHull As DevComponents.DotNetBar.LabelX
        Friend WithEvents cboShipClass As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblShipClass As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblBaseDescription As DevComponents.DotNetBar.LabelX
        Friend WithEvents txtDescription As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents chkAutoBonusDescription As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents txtShipName As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents lblShipName As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblShipID As DevComponents.DotNetBar.LabelX
        Friend WithEvents picShip As DevComponents.DotNetBar.Controls.ReflectionImage
        Friend WithEvents btnLockAttributes As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnLockBonuses As DevComponents.DotNetBar.ButtonX
        Friend WithEvents tvwBonuses As DevComponents.AdvTree.AdvTree
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents colBShipID As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colBAffectingType As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colBAffectingID As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colBAttribute As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colBAffectedType As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colBAffectedID As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colBValue As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colBBonusType As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colBStacking As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colBCalcType As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colBStatus As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents sttBonus As DevComponents.DotNetBar.SuperTooltip
        Friend WithEvents picDescription As DevComponents.DotNetBar.Controls.ReflectionImage
        Friend WithEvents btnClearBonuses As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnDeleteBonus As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnEditBonus As DevComponents.DotNetBar.ButtonX
        Friend WithEvents picValidShipName As DevComponents.DotNetBar.Controls.ReflectionImage
        Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnAccept As DevComponents.DotNetBar.ButtonX
    End Class
End NameSpace