Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmShipEditorBonus
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
            Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
            Me.lblBonusDescription = New DevComponents.DotNetBar.LabelX()
            Me.chkUseActiveShip = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.btnAccept = New DevComponents.DotNetBar.ButtonX()
            Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
            Me.txtDescription = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.btnDelete = New DevComponents.DotNetBar.ButtonX()
            Me.btnClear = New DevComponents.DotNetBar.ButtonX()
            Me.lvwItems = New DevComponents.DotNetBar.Controls.ListViewEx()
            Me.colItem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.btnAddItem = New DevComponents.DotNetBar.ButtonX()
            Me.lblAffectedID = New DevComponents.DotNetBar.LabelX()
            Me.cboItems = New DevComponents.DotNetBar.Controls.ComboTree()
            Me.cboEffectType = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblAffectedType = New DevComponents.DotNetBar.LabelX()
            Me.diValue = New DevComponents.Editors.DoubleInput()
            Me.lblValue = New DevComponents.DotNetBar.LabelX()
            Me.chkOverloaded = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.chkActive = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.chkInactive = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.chkOffline = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.lblStatus = New DevComponents.DotNetBar.LabelX()
            Me.cboStackEffect = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblStackType = New DevComponents.DotNetBar.LabelX()
            Me.cboCalcType = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblCalcType = New DevComponents.DotNetBar.LabelX()
            Me.cboAttribute = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.AffectedAtt = New DevComponents.DotNetBar.LabelX()
            Me.cboSkill = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.radSkillBonus = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.radRole = New DevComponents.DotNetBar.Controls.CheckBoxX()
            Me.lblShipID = New DevComponents.DotNetBar.LabelX()
            Me.PanelEx1.SuspendLayout()
            CType(Me.diValue, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'PanelEx1
            '
            Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
            Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.PanelEx1.Controls.Add(Me.lblBonusDescription)
            Me.PanelEx1.Controls.Add(Me.chkUseActiveShip)
            Me.PanelEx1.Controls.Add(Me.btnAccept)
            Me.PanelEx1.Controls.Add(Me.btnCancel)
            Me.PanelEx1.Controls.Add(Me.txtDescription)
            Me.PanelEx1.Controls.Add(Me.btnDelete)
            Me.PanelEx1.Controls.Add(Me.btnClear)
            Me.PanelEx1.Controls.Add(Me.lvwItems)
            Me.PanelEx1.Controls.Add(Me.btnAddItem)
            Me.PanelEx1.Controls.Add(Me.lblAffectedID)
            Me.PanelEx1.Controls.Add(Me.cboItems)
            Me.PanelEx1.Controls.Add(Me.cboEffectType)
            Me.PanelEx1.Controls.Add(Me.lblAffectedType)
            Me.PanelEx1.Controls.Add(Me.diValue)
            Me.PanelEx1.Controls.Add(Me.lblValue)
            Me.PanelEx1.Controls.Add(Me.chkOverloaded)
            Me.PanelEx1.Controls.Add(Me.chkActive)
            Me.PanelEx1.Controls.Add(Me.chkInactive)
            Me.PanelEx1.Controls.Add(Me.chkOffline)
            Me.PanelEx1.Controls.Add(Me.lblStatus)
            Me.PanelEx1.Controls.Add(Me.cboStackEffect)
            Me.PanelEx1.Controls.Add(Me.lblStackType)
            Me.PanelEx1.Controls.Add(Me.cboCalcType)
            Me.PanelEx1.Controls.Add(Me.lblCalcType)
            Me.PanelEx1.Controls.Add(Me.cboAttribute)
            Me.PanelEx1.Controls.Add(Me.AffectedAtt)
            Me.PanelEx1.Controls.Add(Me.cboSkill)
            Me.PanelEx1.Controls.Add(Me.radSkillBonus)
            Me.PanelEx1.Controls.Add(Me.radRole)
            Me.PanelEx1.Controls.Add(Me.lblShipID)
            Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
            Me.PanelEx1.Name = "PanelEx1"
            Me.PanelEx1.Size = New System.Drawing.Size(484, 601)
            Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.PanelEx1.Style.GradientAngle = 90
            Me.PanelEx1.TabIndex = 0
            '
            'lblBonusDescription
            '
            Me.lblBonusDescription.AutoSize = True
            '
            '
            '
            Me.lblBonusDescription.BackgroundStyle.Class = ""
            Me.lblBonusDescription.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblBonusDescription.Location = New System.Drawing.Point(13, 35)
            Me.lblBonusDescription.Name = "lblBonusDescription"
            Me.lblBonusDescription.Size = New System.Drawing.Size(94, 16)
            Me.lblBonusDescription.TabIndex = 30
            Me.lblBonusDescription.Text = "Bonus Description:"
            '
            'chkUseActiveShip
            '
            Me.chkUseActiveShip.AutoSize = True
            '
            '
            '
            Me.chkUseActiveShip.BackgroundStyle.Class = ""
            Me.chkUseActiveShip.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkUseActiveShip.Location = New System.Drawing.Point(118, 356)
            Me.chkUseActiveShip.Name = "chkUseActiveShip"
            Me.chkUseActiveShip.Size = New System.Drawing.Size(186, 16)
            Me.chkUseActiveShip.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkUseActiveShip.TabIndex = 29
            Me.chkUseActiveShip.Text = "Use Active Ship as Affected Item?"
            '
            'btnAccept
            '
            Me.btnAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnAccept.Location = New System.Drawing.Point(316, 572)
            Me.btnAccept.Name = "btnAccept"
            Me.btnAccept.Size = New System.Drawing.Size(75, 23)
            Me.btnAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnAccept.TabIndex = 28
            Me.btnAccept.Text = "Accept"
            '
            'btnCancel
            '
            Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(397, 572)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnCancel.TabIndex = 27
            Me.btnCancel.Text = "Cancel"
            '
            'txtDescription
            '
            Me.txtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                              Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtDescription.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.txtDescription.Border.Class = "TextBoxBorder"
            Me.txtDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.txtDescription.Location = New System.Drawing.Point(12, 52)
            Me.txtDescription.Multiline = True
            Me.txtDescription.Name = "txtDescription"
            Me.txtDescription.ReadOnly = True
            Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtDescription.Size = New System.Drawing.Size(459, 86)
            Me.txtDescription.TabIndex = 26
            '
            'btnDelete
            '
            Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnDelete.Enabled = False
            Me.btnDelete.Location = New System.Drawing.Point(427, 518)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New System.Drawing.Size(45, 21)
            Me.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnDelete.TabIndex = 25
            Me.btnDelete.Text = "Delete"
            '
            'btnClear
            '
            Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnClear.Location = New System.Drawing.Point(427, 545)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(45, 21)
            Me.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnClear.TabIndex = 24
            Me.btnClear.Text = "Clear"
            '
            'lvwItems
            '
            Me.lvwItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.lvwItems.Border.Class = "ListViewBorder"
            Me.lvwItems.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lvwItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colItem})
            Me.lvwItems.FullRowSelect = True
            Me.lvwItems.GridLines = True
            Me.lvwItems.Location = New System.Drawing.Point(12, 432)
            Me.lvwItems.Name = "lvwItems"
            Me.lvwItems.Size = New System.Drawing.Size(409, 134)
            Me.lvwItems.TabIndex = 23
            Me.lvwItems.UseCompatibleStateImageBehavior = False
            Me.lvwItems.View = System.Windows.Forms.View.Details
            '
            'colItem
            '
            Me.colItem.Text = "Item Name"
            Me.colItem.Width = 380
            '
            'btnAddItem
            '
            Me.btnAddItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnAddItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnAddItem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnAddItem.Enabled = False
            Me.btnAddItem.Location = New System.Drawing.Point(427, 405)
            Me.btnAddItem.Name = "btnAddItem"
            Me.btnAddItem.Size = New System.Drawing.Size(45, 21)
            Me.btnAddItem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnAddItem.TabIndex = 22
            Me.btnAddItem.Text = "Add"
            '
            'lblAffectedID
            '
            Me.lblAffectedID.AutoSize = True
            '
            '
            '
            Me.lblAffectedID.BackgroundStyle.Class = ""
            Me.lblAffectedID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblAffectedID.Location = New System.Drawing.Point(13, 410)
            Me.lblAffectedID.Name = "lblAffectedID"
            Me.lblAffectedID.Size = New System.Drawing.Size(73, 16)
            Me.lblAffectedID.TabIndex = 21
            Me.lblAffectedID.Text = "Affected Item:"
            '
            'cboItems
            '
            Me.cboItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboItems.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.cboItems.BackgroundStyle.Class = "TextBoxBorder"
            Me.cboItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.cboItems.ButtonDropDown.Visible = True
            Me.cboItems.Enabled = False
            
            Me.cboItems.Location = New System.Drawing.Point(118, 405)
            Me.cboItems.Name = "cboItems"
            Me.cboItems.Size = New System.Drawing.Size(303, 21)
            Me.cboItems.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboItems.TabIndex = 20
            '
            'cboEffectType
            '
            Me.cboEffectType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                             Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboEffectType.DisplayMember = "Text"
            Me.cboEffectType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboEffectType.FormattingEnabled = True
            Me.cboEffectType.ItemHeight = 15
            Me.cboEffectType.Location = New System.Drawing.Point(118, 378)
            Me.cboEffectType.Name = "cboEffectType"
            Me.cboEffectType.Size = New System.Drawing.Size(354, 21)
            Me.cboEffectType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboEffectType.TabIndex = 18
            '
            'lblAffectedType
            '
            Me.lblAffectedType.AutoSize = True
            '
            '
            '
            Me.lblAffectedType.BackgroundStyle.Class = ""
            Me.lblAffectedType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblAffectedType.Location = New System.Drawing.Point(13, 383)
            Me.lblAffectedType.Name = "lblAffectedType"
            Me.lblAffectedType.Size = New System.Drawing.Size(74, 16)
            Me.lblAffectedType.TabIndex = 17
            Me.lblAffectedType.Text = "Affected Type:"
            '
            'diValue
            '
            Me.diValue.AllowEmptyState = False
            '
            '
            '
            Me.diValue.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.diValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.diValue.ButtonFreeText.Checked = True
            Me.diValue.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.diValue.DisplayFormat = "G"
            Me.diValue.FreeTextEntryMode = True
            Me.diValue.Increment = 1.0R
            Me.diValue.Location = New System.Drawing.Point(118, 329)
            Me.diValue.Name = "diValue"
            Me.diValue.ShowUpDown = True
            Me.diValue.Size = New System.Drawing.Size(121, 21)
            Me.diValue.TabIndex = 16
            '
            'lblValue
            '
            Me.lblValue.AutoSize = True
            '
            '
            '
            Me.lblValue.BackgroundStyle.Class = ""
            Me.lblValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblValue.Location = New System.Drawing.Point(13, 334)
            Me.lblValue.Name = "lblValue"
            Me.lblValue.Size = New System.Drawing.Size(33, 16)
            Me.lblValue.TabIndex = 15
            Me.lblValue.Text = "Value:"
            '
            'chkOverloaded
            '
            Me.chkOverloaded.AutoSize = True
            '
            '
            '
            Me.chkOverloaded.BackgroundStyle.Class = ""
            Me.chkOverloaded.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkOverloaded.Checked = True
            Me.chkOverloaded.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkOverloaded.CheckValue = "Y"
            Me.chkOverloaded.Location = New System.Drawing.Point(303, 307)
            Me.chkOverloaded.Name = "chkOverloaded"
            Me.chkOverloaded.Size = New System.Drawing.Size(78, 16)
            Me.chkOverloaded.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkOverloaded.TabIndex = 14
            Me.chkOverloaded.Tag = "8"
            Me.chkOverloaded.Text = "Overloaded"
            '
            'chkActive
            '
            Me.chkActive.AutoSize = True
            '
            '
            '
            Me.chkActive.BackgroundStyle.Class = ""
            Me.chkActive.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkActive.Checked = True
            Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkActive.CheckValue = "Y"
            Me.chkActive.Location = New System.Drawing.Point(245, 307)
            Me.chkActive.Name = "chkActive"
            Me.chkActive.Size = New System.Drawing.Size(52, 16)
            Me.chkActive.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkActive.TabIndex = 13
            Me.chkActive.Tag = "4"
            Me.chkActive.Text = "Active"
            '
            'chkInactive
            '
            Me.chkInactive.AutoSize = True
            '
            '
            '
            Me.chkInactive.BackgroundStyle.Class = ""
            Me.chkInactive.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkInactive.Checked = True
            Me.chkInactive.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkInactive.CheckValue = "Y"
            Me.chkInactive.Location = New System.Drawing.Point(178, 307)
            Me.chkInactive.Name = "chkInactive"
            Me.chkInactive.Size = New System.Drawing.Size(61, 16)
            Me.chkInactive.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkInactive.TabIndex = 12
            Me.chkInactive.Tag = "2"
            Me.chkInactive.Text = "Inactive"
            '
            'chkOffline
            '
            Me.chkOffline.AutoSize = True
            '
            '
            '
            Me.chkOffline.BackgroundStyle.Class = ""
            Me.chkOffline.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.chkOffline.Checked = True
            Me.chkOffline.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkOffline.CheckValue = "Y"
            Me.chkOffline.Location = New System.Drawing.Point(118, 307)
            Me.chkOffline.Name = "chkOffline"
            Me.chkOffline.Size = New System.Drawing.Size(54, 16)
            Me.chkOffline.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.chkOffline.TabIndex = 11
            Me.chkOffline.Tag = "1"
            Me.chkOffline.Text = "Offline"
            '
            'lblStatus
            '
            Me.lblStatus.AutoSize = True
            '
            '
            '
            Me.lblStatus.BackgroundStyle.Class = ""
            Me.lblStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblStatus.Location = New System.Drawing.Point(13, 307)
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.Size = New System.Drawing.Size(84, 16)
            Me.lblStatus.TabIndex = 10
            Me.lblStatus.Text = "Affect on Status:"
            '
            'cboStackEffect
            '
            Me.cboStackEffect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                              Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboStackEffect.DisplayMember = "Text"
            Me.cboStackEffect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboStackEffect.FormattingEnabled = True
            Me.cboStackEffect.ItemHeight = 15
            Me.cboStackEffect.Location = New System.Drawing.Point(118, 247)
            Me.cboStackEffect.Name = "cboStackEffect"
            Me.cboStackEffect.Size = New System.Drawing.Size(354, 21)
            Me.cboStackEffect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboStackEffect.TabIndex = 9
            '
            'lblStackType
            '
            Me.lblStackType.AutoSize = True
            '
            '
            '
            Me.lblStackType.BackgroundStyle.Class = ""
            Me.lblStackType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblStackType.Location = New System.Drawing.Point(13, 252)
            Me.lblStackType.Name = "lblStackType"
            Me.lblStackType.Size = New System.Drawing.Size(74, 16)
            Me.lblStackType.TabIndex = 8
            Me.lblStackType.Text = "Stacking Type:"
            '
            'cboCalcType
            '
            Me.cboCalcType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                           Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboCalcType.DisplayMember = "Text"
            Me.cboCalcType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboCalcType.FormattingEnabled = True
            Me.cboCalcType.ItemHeight = 15
            Me.cboCalcType.Location = New System.Drawing.Point(118, 273)
            Me.cboCalcType.Name = "cboCalcType"
            Me.cboCalcType.Size = New System.Drawing.Size(354, 21)
            Me.cboCalcType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboCalcType.TabIndex = 7
            '
            'lblCalcType
            '
            Me.lblCalcType.AutoSize = True
            '
            '
            '
            Me.lblCalcType.BackgroundStyle.Class = ""
            Me.lblCalcType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblCalcType.Location = New System.Drawing.Point(13, 278)
            Me.lblCalcType.Name = "lblCalcType"
            Me.lblCalcType.Size = New System.Drawing.Size(86, 16)
            Me.lblCalcType.TabIndex = 6
            Me.lblCalcType.Text = "Calculation Type:"
            '
            'cboAttribute
            '
            Me.cboAttribute.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboAttribute.DisplayMember = "Text"
            Me.cboAttribute.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboAttribute.FormattingEnabled = True
            Me.cboAttribute.ItemHeight = 15
            Me.cboAttribute.Location = New System.Drawing.Point(118, 221)
            Me.cboAttribute.Name = "cboAttribute"
            Me.cboAttribute.Size = New System.Drawing.Size(354, 21)
            Me.cboAttribute.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboAttribute.TabIndex = 5
            '
            'AffectedAtt
            '
            Me.AffectedAtt.AutoSize = True
            '
            '
            '
            Me.AffectedAtt.BackgroundStyle.Class = ""
            Me.AffectedAtt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.AffectedAtt.Location = New System.Drawing.Point(13, 226)
            Me.AffectedAtt.Name = "AffectedAtt"
            Me.AffectedAtt.Size = New System.Drawing.Size(93, 16)
            Me.AffectedAtt.TabIndex = 4
            Me.AffectedAtt.Text = "Attribute to Affect:"
            '
            'cboSkill
            '
            Me.cboSkill.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboSkill.DisplayMember = "Text"
            Me.cboSkill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboSkill.Enabled = False
            Me.cboSkill.FormattingEnabled = True
            Me.cboSkill.ItemHeight = 15
            Me.cboSkill.Location = New System.Drawing.Point(118, 186)
            Me.cboSkill.Name = "cboSkill"
            Me.cboSkill.Size = New System.Drawing.Size(354, 21)
            Me.cboSkill.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboSkill.TabIndex = 3
            '
            'radSkillBonus
            '
            '
            '
            '
            Me.radSkillBonus.BackgroundStyle.Class = ""
            Me.radSkillBonus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.radSkillBonus.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
            Me.radSkillBonus.Location = New System.Drawing.Point(12, 183)
            Me.radSkillBonus.Name = "radSkillBonus"
            Me.radSkillBonus.Size = New System.Drawing.Size(100, 23)
            Me.radSkillBonus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.radSkillBonus.TabIndex = 2
            Me.radSkillBonus.Text = "Skill Bonus"
            '
            'radRole
            '
            '
            '
            '
            Me.radRole.BackgroundStyle.Class = ""
            Me.radRole.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.radRole.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
            Me.radRole.Checked = True
            Me.radRole.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radRole.CheckValue = "Y"
            Me.radRole.Location = New System.Drawing.Point(12, 154)
            Me.radRole.Name = "radRole"
            Me.radRole.Size = New System.Drawing.Size(100, 23)
            Me.radRole.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.radRole.TabIndex = 1
            Me.radRole.Text = "Ship Role"
            '
            'lblShipID
            '
            Me.lblShipID.AutoSize = True
            '
            '
            '
            Me.lblShipID.BackgroundStyle.Class = ""
            Me.lblShipID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblShipID.Location = New System.Drawing.Point(13, 13)
            Me.lblShipID.Name = "lblShipID"
            Me.lblShipID.Size = New System.Drawing.Size(39, 16)
            Me.lblShipID.TabIndex = 0
            Me.lblShipID.Text = "ShipID:"
            '
            'frmShipEditorBonus
            '
            Me.AcceptButton = Me.btnAccept
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(484, 601)
            Me.Controls.Add(Me.PanelEx1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmShipEditorBonus"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Edit Ship Bonus"
            Me.PanelEx1.ResumeLayout(False)
            Me.PanelEx1.PerformLayout()
            CType(Me.diValue, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
        Friend WithEvents lblShipID As DevComponents.DotNetBar.LabelX
        Friend WithEvents cboSkill As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents radSkillBonus As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents radRole As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents AffectedAtt As DevComponents.DotNetBar.LabelX
        Friend WithEvents chkOverloaded As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents chkActive As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents chkInactive As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents chkOffline As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents lblStatus As DevComponents.DotNetBar.LabelX
        Friend WithEvents cboStackEffect As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblStackType As DevComponents.DotNetBar.LabelX
        Friend WithEvents cboCalcType As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblCalcType As DevComponents.DotNetBar.LabelX
        Friend WithEvents cboAttribute As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents diValue As DevComponents.Editors.DoubleInput
        Friend WithEvents lblValue As DevComponents.DotNetBar.LabelX
        Friend WithEvents cboEffectType As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblAffectedType As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblAffectedID As DevComponents.DotNetBar.LabelX
        Friend WithEvents cboItems As DevComponents.DotNetBar.Controls.ComboTree
        Friend WithEvents lvwItems As DevComponents.DotNetBar.Controls.ListViewEx
        Friend WithEvents colItem As System.Windows.Forms.ColumnHeader
        Friend WithEvents btnAddItem As DevComponents.DotNetBar.ButtonX
        Friend WithEvents txtDescription As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnClear As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnAccept As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
        Friend WithEvents chkUseActiveShip As DevComponents.DotNetBar.Controls.CheckBoxX
        Friend WithEvents lblBonusDescription As DevComponents.DotNetBar.LabelX
    End Class
End NameSpace