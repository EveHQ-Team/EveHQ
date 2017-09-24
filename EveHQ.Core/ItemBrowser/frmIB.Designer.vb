Namespace ItemBrowser
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmIB
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIB))
            Me.barStatus = New DevComponents.DotNetBar.Bar()
            Me.lblStatus = New DevComponents.DotNetBar.LabelItem()
            Me.lblDBLocation = New DevComponents.DotNetBar.LabelItem()
            Me.lblID = New DevComponents.DotNetBar.LabelItem()
            Me.pnlIB = New DevComponents.DotNetBar.PanelEx()
            Me.tcIB = New DevComponents.DotNetBar.TabControl()
            Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel()
            Me.lblDescription = New DevComponents.DotNetBar.LabelX()
            Me.tiDescription = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel15 = New DevComponents.DotNetBar.TabControlPanel()
            Me.lblTraits = New DevComponents.DotNetBar.LabelX()
            Me.tiTraits = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel12 = New DevComponents.DotNetBar.TabControlPanel()
            Me.adtComponents = New DevComponents.AdvTree.AdvTree()
            Me.colComponentName = New DevComponents.AdvTree.ColumnHeader()
            Me.colComponentQuantity = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector9 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle11 = New DevComponents.DotNetBar.ElementStyle()
            Me.tiComponent = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel11 = New DevComponents.DotNetBar.TabControlPanel()
            Me.adtMaterials = New DevComponents.AdvTree.AdvTree()
            Me.colMaterialName = New DevComponents.AdvTree.ColumnHeader()
            Me.colMaterialQuantity = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector8 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle10 = New DevComponents.DotNetBar.ElementStyle()
            Me.tiMaterials = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel5 = New DevComponents.DotNetBar.TabControlPanel()
            Me.adtAttributes = New DevComponents.AdvTree.AdvTree()
            Me.colAttributeName = New DevComponents.AdvTree.ColumnHeader()
            Me.colAttributeValue = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector4 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle4 = New DevComponents.DotNetBar.ElementStyle()
            Me.tiAttributes = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel9 = New DevComponents.DotNetBar.TabControlPanel()
            Me.adtCerts = New DevComponents.AdvTree.AdvTree()
            Me.colCertificateName = New DevComponents.AdvTree.ColumnHeader()
            Me.colCertificateGrade = New DevComponents.AdvTree.ColumnHeader()
            Me.ElementStyle7 = New DevComponents.DotNetBar.ElementStyle()
            Me.ElementStyle8 = New DevComponents.DotNetBar.ElementStyle()
            Me.tiCertificates = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel10 = New DevComponents.DotNetBar.TabControlPanel()
            Me.adtVariations = New DevComponents.AdvTree.AdvTree()
            Me.NodeConnector7 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle9 = New DevComponents.DotNetBar.ElementStyle()
            Me.tiVariations = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel6 = New DevComponents.DotNetBar.TabControlPanel()
            Me.adtEffects = New DevComponents.AdvTree.AdvTree()
            Me.colEffectName = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector5 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle5 = New DevComponents.DotNetBar.ElementStyle()
            Me.tiEffects = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel8 = New DevComponents.DotNetBar.TabControlPanel()
            Me.tiSkills = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel7 = New DevComponents.DotNetBar.TabControlPanel()
            Me.adtFitting = New DevComponents.AdvTree.AdvTree()
            Me.colFittingAttribute = New DevComponents.AdvTree.ColumnHeader()
            Me.colFittingValue = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector6 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle6 = New DevComponents.DotNetBar.ElementStyle()
            Me.tiFitting = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.pnlInfo = New DevComponents.DotNetBar.PanelEx()
            Me.btnAddSkills = New DevComponents.DotNetBar.ButtonX()
            Me.btnRequisition = New DevComponents.DotNetBar.ButtonX()
            Me.cboPilots = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.btnNavForward = New DevComponents.DotNetBar.ButtonX()
            Me.btnNavBack = New DevComponents.DotNetBar.ButtonX()
            Me.btnNavRecent = New DevComponents.DotNetBar.ButtonX()
            Me.lblItemName = New DevComponents.DotNetBar.LabelX()
            Me.lblUsableTime = New DevComponents.DotNetBar.LabelX()
            Me.picItem = New System.Windows.Forms.PictureBox()
            Me.tabBrowser = New DevComponents.DotNetBar.TabControl()
            Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
            Me.lblSearchCount = New DevComponents.DotNetBar.LabelX()
            Me.lblSearch = New DevComponents.DotNetBar.LabelX()
            Me.txtSearch = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.adtSearch = New DevComponents.AdvTree.AdvTree()
            Me.colSearchItemName = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me.tabSearch = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
            Me.adtBrowse = New DevComponents.AdvTree.AdvTree()
            Me.colBrowserHeading = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector10 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle12 = New DevComponents.DotNetBar.ElementStyle()
            Me.tabBrowse = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
            Me.lblAttSearchCount = New DevComponents.DotNetBar.LabelX()
            Me.lblAttSearch = New DevComponents.DotNetBar.LabelX()
            Me.cboAttSearch = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.adtAttSearch = New DevComponents.AdvTree.AdvTree()
            Me.colAttSearchItemName = New DevComponents.AdvTree.ColumnHeader()
            Me.colAttSearchValue = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector2 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle2 = New DevComponents.DotNetBar.ElementStyle()
            Me.tabAttSearch = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel35 = New DevComponents.DotNetBar.TabControlPanel()
            Me.lblEffectSearchCount = New DevComponents.DotNetBar.LabelX()
            Me.lblEffectSearch = New DevComponents.DotNetBar.LabelX()
            Me.cboEffectSearch = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.adtEffectSearch = New DevComponents.AdvTree.AdvTree()
            Me.colEffectSearchItemName = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector3 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle3 = New DevComponents.DotNetBar.ElementStyle()
            Me.tabEffectSearch = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.STTItem = New DevComponents.DotNetBar.SuperTooltip()
            Me.adtSkills = New EveHQ.Core.ItemBrowser.IBSkillTree()
            Me.tabCategories = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel13 = New DevComponents.DotNetBar.TabControlPanel()
            Me.adtCategories = New DevComponents.AdvTree.AdvTree()
            Me.colCategoryID = New DevComponents.AdvTree.ColumnHeader()
            Me.colCategoryName = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector11 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle13 = New DevComponents.DotNetBar.ElementStyle()
            Me.tabGroups = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabControlPanel14 = New DevComponents.DotNetBar.TabControlPanel()
            Me.adtGroups = New DevComponents.AdvTree.AdvTree()
            Me.ColumnHeader1 = New DevComponents.AdvTree.ColumnHeader()
            Me.ColumnHeader2 = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector12 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle14 = New DevComponents.DotNetBar.ElementStyle()
            CType(Me.barStatus, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlIB.SuspendLayout()
            CType(Me.tcIB, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tcIB.SuspendLayout()
            Me.TabControlPanel4.SuspendLayout()
            Me.TabControlPanel12.SuspendLayout()
            CType(Me.adtComponents, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControlPanel11.SuspendLayout()
            CType(Me.adtMaterials, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControlPanel5.SuspendLayout()
            CType(Me.adtAttributes, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControlPanel9.SuspendLayout()
            CType(Me.adtCerts, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControlPanel10.SuspendLayout()
            CType(Me.adtVariations, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControlPanel6.SuspendLayout()
            CType(Me.adtEffects, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControlPanel8.SuspendLayout()
            Me.TabControlPanel7.SuspendLayout()
            CType(Me.adtFitting, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlInfo.SuspendLayout()
            CType(Me.picItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabBrowser, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabBrowser.SuspendLayout()
            Me.TabControlPanel2.SuspendLayout()
            CType(Me.adtSearch, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControlPanel1.SuspendLayout()
            CType(Me.adtBrowse, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControlPanel3.SuspendLayout()
            CType(Me.adtAttSearch, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControlPanel35.SuspendLayout()
            CType(Me.adtEffectSearch, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControlPanel13.SuspendLayout()
            CType(Me.adtCategories, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControlPanel14.SuspendLayout()
            CType(Me.adtGroups, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControlPanel15.SuspendLayout()
            Me.SuspendLayout()
            '
            'barStatus
            '
            Me.barStatus.AccessibleDescription = "DotNetBar Bar (barStatus)"
            Me.barStatus.AccessibleName = "DotNetBar Bar"
            Me.barStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar
            Me.barStatus.BarType = DevComponents.DotNetBar.eBarType.StatusBar
            Me.barStatus.CanAutoHide = False
            Me.barStatus.CanCustomize = False
            Me.barStatus.CanReorderTabs = False
            Me.barStatus.CanUndock = False
            Me.barStatus.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barStatus.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle
            Me.barStatus.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.lblStatus, Me.lblDBLocation, Me.lblID})
            Me.barStatus.Location = New System.Drawing.Point(0, 689)
            Me.barStatus.Name = "barStatus"
            Me.barStatus.Size = New System.Drawing.Size(1062, 22)
            Me.barStatus.Stretch = True
            Me.barStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.barStatus.TabIndex = 51
            Me.barStatus.TabStop = False
            '
            'lblStatus
            '
            Me.lblStatus.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.PaddingBottom = 1
            Me.lblStatus.PaddingLeft = 3
            Me.lblStatus.PaddingRight = 3
            Me.lblStatus.PaddingTop = 1
            Me.lblStatus.Text = "Awaiting Query..."
            Me.lblStatus.Width = 250
            '
            'lblDBLocation
            '
            Me.lblDBLocation.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.lblDBLocation.Name = "lblDBLocation"
            Me.lblDBLocation.PaddingBottom = 1
            Me.lblDBLocation.PaddingLeft = 3
            Me.lblDBLocation.PaddingRight = 3
            Me.lblDBLocation.PaddingTop = 1
            Me.lblDBLocation.Stretch = True
            Me.lblDBLocation.Text = "DB Location:"
            Me.lblDBLocation.TextAlignment = System.Drawing.StringAlignment.Center
            '
            'lblID
            '
            Me.lblID.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.lblID.Name = "lblID"
            Me.lblID.PaddingBottom = 1
            Me.lblID.PaddingLeft = 3
            Me.lblID.PaddingRight = 3
            Me.lblID.PaddingTop = 1
            Me.lblID.Text = "ID:"
            Me.lblID.Width = 150
            '
            'pnlIB
            '
            Me.pnlIB.CanvasColor = System.Drawing.SystemColors.Control
            Me.pnlIB.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.pnlIB.Controls.Add(Me.tcIB)
            Me.pnlIB.Controls.Add(Me.pnlInfo)
            Me.pnlIB.Controls.Add(Me.tabBrowser)
            Me.pnlIB.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlIB.Location = New System.Drawing.Point(0, 0)
            Me.pnlIB.Name = "pnlIB"
            Me.pnlIB.Size = New System.Drawing.Size(1062, 689)
            Me.pnlIB.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.pnlIB.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.pnlIB.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.pnlIB.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.pnlIB.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.pnlIB.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.pnlIB.Style.GradientAngle = 90
            Me.pnlIB.TabIndex = 52
            '
            'tcIB
            '
            Me.tcIB.BackColor = System.Drawing.Color.Transparent
            Me.tcIB.CanReorderTabs = True
            Me.tcIB.ColorScheme.TabBackground = System.Drawing.Color.Transparent
            Me.tcIB.ColorScheme.TabBackground2 = System.Drawing.Color.Transparent
            Me.tcIB.ColorScheme.TabItemBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(226, Byte), Integer)), 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(199, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(223, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), 1.0!)})
            Me.tcIB.ColorScheme.TabItemHotBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(235, Byte), Integer)), 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(168, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(89, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(141, Byte), Integer)), 1.0!)})
            Me.tcIB.ColorScheme.TabItemSelectedBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.White, 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer)), 1.0!)})
            Me.tcIB.Controls.Add(Me.TabControlPanel15)
            Me.tcIB.Controls.Add(Me.TabControlPanel4)
            Me.tcIB.Controls.Add(Me.TabControlPanel9)
            Me.tcIB.Controls.Add(Me.TabControlPanel12)
            Me.tcIB.Controls.Add(Me.TabControlPanel11)
            Me.tcIB.Controls.Add(Me.TabControlPanel10)
            Me.tcIB.Controls.Add(Me.TabControlPanel8)
            Me.tcIB.Controls.Add(Me.TabControlPanel6)
            Me.tcIB.Controls.Add(Me.TabControlPanel7)
            Me.tcIB.Controls.Add(Me.TabControlPanel5)
            Me.tcIB.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcIB.Location = New System.Drawing.Point(361, 74)
            Me.tcIB.Name = "tcIB"
            Me.tcIB.SelectedTabFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.tcIB.SelectedTabIndex = 0
            Me.tcIB.Size = New System.Drawing.Size(701, 615)
            Me.tcIB.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
            Me.tcIB.TabIndex = 48
            Me.tcIB.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
            Me.tcIB.Tabs.Add(Me.tiTraits)
            Me.tcIB.Tabs.Add(Me.tiDescription)
            Me.tcIB.Tabs.Add(Me.tiAttributes)
            Me.tcIB.Tabs.Add(Me.tiFitting)
            Me.tcIB.Tabs.Add(Me.tiEffects)
            Me.tcIB.Tabs.Add(Me.tiSkills)
            Me.tcIB.Tabs.Add(Me.tiCertificates)
            Me.tcIB.Tabs.Add(Me.tiVariations)
            Me.tcIB.Tabs.Add(Me.tiMaterials)
            Me.tcIB.Tabs.Add(Me.tiComponent)
            '
            'TabControlPanel15
            '
            Me.TabControlPanel15.Controls.Add(Me.lblTraits)
            Me.TabControlPanel15.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel15.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel15.Name = "TabControlPanel15"
            Me.TabControlPanel15.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel15.Size = New System.Drawing.Size(701, 592)
            Me.TabControlPanel15.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel15.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel15.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel15.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel15.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel15.Style.GradientAngle = 90
            Me.TabControlPanel15.TabIndex = 15
            Me.TabControlPanel15.TabItem = Me.tiTraits
            '
            'lblTraits
            '
            Me.lblTraits.BackColor = System.Drawing.Color.Transparent
            Me.lblTraits.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblTraits.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblTraits.Location = New System.Drawing.Point(1, 1)
            Me.lblTraits.Name = "lblTraits"
            Me.lblTraits.PaddingBottom = 5
            Me.lblTraits.PaddingLeft = 5
            Me.lblTraits.PaddingRight = 5
            Me.lblTraits.PaddingTop = 5
            Me.lblTraits.Size = New System.Drawing.Size(699, 590)
            Me.lblTraits.TabIndex = 0
            Me.lblTraits.TextLineAlignment = System.Drawing.StringAlignment.Near
            Me.lblTraits.WordWrap = True
            '
            'tiTraits
            '
            Me.tiTraits.AttachedControl = Me.TabControlPanel15
            Me.tiTraits.Name = "tiTraits"
            Me.tiTraits.Text = "Traits"
            '
            'TabControlPanel4
            '
            Me.TabControlPanel4.Controls.Add(Me.lblDescription)
            Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel4.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel4.Name = "TabControlPanel4"
            Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel4.Size = New System.Drawing.Size(701, 592)
            Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel4.Style.GradientAngle = 90
            Me.TabControlPanel4.TabIndex = 1
            Me.TabControlPanel4.TabItem = Me.tiDescription
            '
            'lblDescription
            '
            Me.lblDescription.BackColor = System.Drawing.Color.Transparent
            Me.lblDescription.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblDescription.Location = New System.Drawing.Point(1, 1)
            Me.lblDescription.Name = "lblDescription"
            Me.lblDescription.PaddingBottom = 5
            Me.lblDescription.PaddingLeft = 5
            Me.lblDescription.PaddingRight = 5
            Me.lblDescription.PaddingTop = 5
            Me.lblDescription.Size = New System.Drawing.Size(699, 590)
            Me.lblDescription.TabIndex = 0
            Me.lblDescription.TextLineAlignment = System.Drawing.StringAlignment.Near
            Me.lblDescription.WordWrap = True
            '
            'tiDescription
            '
            Me.tiDescription.AttachedControl = Me.TabControlPanel4
            Me.tiDescription.Name = "tiDescription"
            Me.tiDescription.Text = "Description"
            '
            'TabControlPanel12
            '
            Me.TabControlPanel12.Controls.Add(Me.adtComponents)
            Me.TabControlPanel12.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel12.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel12.Name = "TabControlPanel12"
            Me.TabControlPanel12.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel12.Size = New System.Drawing.Size(701, 592)
            Me.TabControlPanel12.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel12.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel12.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel12.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel12.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel12.Style.GradientAngle = 90
            Me.TabControlPanel12.TabIndex = 9
            Me.TabControlPanel12.TabItem = Me.tiComponent
            '
            'adtComponents
            '
            Me.adtComponents.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtComponents.AllowDrop = True
            Me.adtComponents.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtComponents.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtComponents.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtComponents.Columns.Add(Me.colComponentName)
            Me.adtComponents.Columns.Add(Me.colComponentQuantity)
            Me.adtComponents.Dock = System.Windows.Forms.DockStyle.Fill
            Me.adtComponents.DragDropEnabled = False
            Me.adtComponents.DragDropNodeCopyEnabled = False
            Me.adtComponents.ExpandWidth = 0
            
            Me.adtComponents.Location = New System.Drawing.Point(1, 1)
            Me.adtComponents.Name = "adtComponents"
            Me.adtComponents.NodesConnector = Me.NodeConnector9
            Me.adtComponents.NodeStyle = Me.ElementStyle11
            Me.adtComponents.PathSeparator = ";"
            Me.adtComponents.Size = New System.Drawing.Size(699, 590)
            Me.adtComponents.Styles.Add(Me.ElementStyle11)
            Me.adtComponents.TabIndex = 2
            '
            'colComponentName
            '
            Me.colComponentName.DisplayIndex = 1
            Me.colComponentName.Name = "colComponentName"
            Me.colComponentName.SortingEnabled = False
            Me.colComponentName.Text = "Component Name"
            Me.colComponentName.Width.Absolute = 300
            '
            'colComponentQuantity
            '
            Me.colComponentQuantity.DisplayIndex = 2
            Me.colComponentQuantity.Name = "colComponentQuantity"
            Me.colComponentQuantity.SortingEnabled = False
            Me.colComponentQuantity.Text = "Quantity"
            Me.colComponentQuantity.Width.Absolute = 150
            '
            'NodeConnector9
            '
            Me.NodeConnector9.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle11
            '
            Me.ElementStyle11.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle11.Name = "ElementStyle11"
            Me.ElementStyle11.TextColor = System.Drawing.SystemColors.ControlText
            '
            'tiComponent
            '
            Me.tiComponent.AttachedControl = Me.TabControlPanel12
            Me.tiComponent.Name = "tiComponent"
            Me.tiComponent.Text = "Component"
            '
            'TabControlPanel11
            '
            Me.TabControlPanel11.Controls.Add(Me.adtMaterials)
            Me.TabControlPanel11.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel11.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel11.Name = "TabControlPanel11"
            Me.TabControlPanel11.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel11.Size = New System.Drawing.Size(701, 592)
            Me.TabControlPanel11.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel11.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel11.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel11.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel11.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel11.Style.GradientAngle = 90
            Me.TabControlPanel11.TabIndex = 8
            Me.TabControlPanel11.TabItem = Me.tiMaterials
            '
            'adtMaterials
            '
            Me.adtMaterials.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtMaterials.AllowDrop = True
            Me.adtMaterials.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtMaterials.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtMaterials.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtMaterials.Columns.Add(Me.colMaterialName)
            Me.adtMaterials.Columns.Add(Me.colMaterialQuantity)
            Me.adtMaterials.Dock = System.Windows.Forms.DockStyle.Fill
            Me.adtMaterials.DragDropEnabled = False
            Me.adtMaterials.DragDropNodeCopyEnabled = False
            Me.adtMaterials.ExpandWidth = 0
            
            Me.adtMaterials.Location = New System.Drawing.Point(1, 1)
            Me.adtMaterials.Name = "adtMaterials"
            Me.adtMaterials.NodesConnector = Me.NodeConnector8
            Me.adtMaterials.NodeStyle = Me.ElementStyle10
            Me.adtMaterials.PathSeparator = ";"
            Me.adtMaterials.Size = New System.Drawing.Size(699, 590)
            Me.adtMaterials.Styles.Add(Me.ElementStyle10)
            Me.adtMaterials.TabIndex = 1
            '
            'colMaterialName
            '
            Me.colMaterialName.DisplayIndex = 1
            Me.colMaterialName.Name = "colMaterialName"
            Me.colMaterialName.SortingEnabled = False
            Me.colMaterialName.Text = "Material Name"
            Me.colMaterialName.Width.Absolute = 300
            '
            'colMaterialQuantity
            '
            Me.colMaterialQuantity.DisplayIndex = 2
            Me.colMaterialQuantity.Name = "colMaterialQuantity"
            Me.colMaterialQuantity.SortingEnabled = False
            Me.colMaterialQuantity.Text = "Quantity"
            Me.colMaterialQuantity.Width.Absolute = 150
            '
            'NodeConnector8
            '
            Me.NodeConnector8.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle10
            '
            Me.ElementStyle10.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle10.Name = "ElementStyle10"
            Me.ElementStyle10.TextColor = System.Drawing.SystemColors.ControlText
            '
            'tiMaterials
            '
            Me.tiMaterials.AttachedControl = Me.TabControlPanel11
            Me.tiMaterials.Name = "tiMaterials"
            Me.tiMaterials.Text = "Materials"
            '
            'TabControlPanel5
            '
            Me.TabControlPanel5.Controls.Add(Me.adtAttributes)
            Me.TabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel5.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel5.Name = "TabControlPanel5"
            Me.TabControlPanel5.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel5.Size = New System.Drawing.Size(701, 592)
            Me.TabControlPanel5.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel5.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel5.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel5.Style.GradientAngle = 90
            Me.TabControlPanel5.TabIndex = 2
            Me.TabControlPanel5.TabItem = Me.tiAttributes
            '
            'adtAttributes
            '
            Me.adtAttributes.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtAttributes.AllowDrop = True
            Me.adtAttributes.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtAttributes.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtAttributes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtAttributes.Columns.Add(Me.colAttributeName)
            Me.adtAttributes.Columns.Add(Me.colAttributeValue)
            Me.adtAttributes.Dock = System.Windows.Forms.DockStyle.Fill
            Me.adtAttributes.DragDropEnabled = False
            Me.adtAttributes.DragDropNodeCopyEnabled = False
            Me.adtAttributes.ExpandWidth = 0
            
            Me.adtAttributes.Location = New System.Drawing.Point(1, 1)
            Me.adtAttributes.Name = "adtAttributes"
            Me.adtAttributes.NodesConnector = Me.NodeConnector4
            Me.adtAttributes.NodeStyle = Me.ElementStyle4
            Me.adtAttributes.PathSeparator = ";"
            Me.adtAttributes.Size = New System.Drawing.Size(699, 590)
            Me.adtAttributes.Styles.Add(Me.ElementStyle4)
            Me.adtAttributes.TabIndex = 0
            Me.adtAttributes.Text = "AdvTree1"
            '
            'colAttributeName
            '
            Me.colAttributeName.DisplayIndex = 1
            Me.colAttributeName.Name = "colAttributeName"
            Me.colAttributeName.SortingEnabled = False
            Me.colAttributeName.Text = "Attribute Name"
            Me.colAttributeName.Width.Absolute = 250
            '
            'colAttributeValue
            '
            Me.colAttributeValue.DisplayIndex = 2
            Me.colAttributeValue.Name = "colAttributeValue"
            Me.colAttributeValue.SortingEnabled = False
            Me.colAttributeValue.Text = "Value"
            Me.colAttributeValue.Width.Absolute = 250
            '
            'NodeConnector4
            '
            Me.NodeConnector4.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle4
            '
            Me.ElementStyle4.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle4.Name = "ElementStyle4"
            Me.ElementStyle4.TextColor = System.Drawing.SystemColors.ControlText
            '
            'tiAttributes
            '
            Me.tiAttributes.AttachedControl = Me.TabControlPanel5
            Me.tiAttributes.Name = "tiAttributes"
            Me.tiAttributes.Text = "Attributes"
            '
            'TabControlPanel9
            '
            Me.TabControlPanel9.Controls.Add(Me.adtCerts)
            Me.TabControlPanel9.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel9.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel9.Name = "TabControlPanel9"
            Me.TabControlPanel9.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel9.Size = New System.Drawing.Size(701, 592)
            Me.TabControlPanel9.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel9.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel9.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel9.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel9.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel9.Style.GradientAngle = 90
            Me.TabControlPanel9.TabIndex = 6
            Me.TabControlPanel9.TabItem = Me.tiCertificates
            '
            'adtCerts
            '
            Me.adtCerts.AllowDrop = True
            Me.adtCerts.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtCerts.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtCerts.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtCerts.Columns.Add(Me.colCertificateName)
            Me.adtCerts.Columns.Add(Me.colCertificateGrade)
            Me.adtCerts.Dock = System.Windows.Forms.DockStyle.Fill
            Me.adtCerts.DragDropEnabled = False
            Me.adtCerts.DragDropNodeCopyEnabled = False
            Me.adtCerts.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle
            Me.adtCerts.ExpandWidth = 8
            Me.adtCerts.KeyboardSearchEnabled = False
            
            Me.adtCerts.Location = New System.Drawing.Point(1, 1)
            Me.adtCerts.Name = "adtCerts"
            Me.adtCerts.NodeSpacing = 1
            Me.adtCerts.NodeStyle = Me.ElementStyle7
            Me.adtCerts.PathSeparator = ";"
            Me.adtCerts.Size = New System.Drawing.Size(699, 590)
            Me.adtCerts.Styles.Add(Me.ElementStyle7)
            Me.adtCerts.Styles.Add(Me.ElementStyle8)
            Me.adtCerts.TabIndex = 40
            '
            'colCertificateName
            '
            Me.colCertificateName.DisplayIndex = 1
            Me.colCertificateName.Name = "colCertificateName"
            Me.colCertificateName.SortingEnabled = False
            Me.colCertificateName.Text = "Recommended Certificate"
            Me.colCertificateName.Width.Absolute = 400
            '
            'colCertificateGrade
            '
            Me.colCertificateGrade.DisplayIndex = 2
            Me.colCertificateGrade.EditorType = DevComponents.AdvTree.eCellEditorType.Custom
            Me.colCertificateGrade.Name = "colCertificateGrade"
            Me.colCertificateGrade.SortingEnabled = False
            Me.colCertificateGrade.Text = "Grade"
            Me.colCertificateGrade.Width.Absolute = 120
            '
            'ElementStyle7
            '
            Me.ElementStyle7.BackColorGradientAngle = 45
            Me.ElementStyle7.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
            Me.ElementStyle7.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle7.Name = "ElementStyle7"
            Me.ElementStyle7.TextColor = System.Drawing.Color.Black
            '
            'ElementStyle8
            '
            Me.ElementStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
            Me.ElementStyle8.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.ElementStyle8.BackColorGradientAngle = 90
            Me.ElementStyle8.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
            Me.ElementStyle8.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.ElementStyle8.BorderBottomWidth = 1
            Me.ElementStyle8.BorderColor = System.Drawing.Color.DarkGray
            Me.ElementStyle8.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.ElementStyle8.BorderLeftWidth = 1
            Me.ElementStyle8.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.ElementStyle8.BorderRightWidth = 1
            Me.ElementStyle8.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.ElementStyle8.BorderTopWidth = 1
            Me.ElementStyle8.CornerDiameter = 4
            Me.ElementStyle8.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle8.Description = "Gray"
            Me.ElementStyle8.Name = "ElementStyle8"
            Me.ElementStyle8.PaddingBottom = 1
            Me.ElementStyle8.PaddingLeft = 1
            Me.ElementStyle8.PaddingRight = 1
            Me.ElementStyle8.PaddingTop = 1
            Me.ElementStyle8.TextColor = System.Drawing.Color.White
            '
            'tiCertificates
            '
            Me.tiCertificates.AttachedControl = Me.TabControlPanel9
            Me.tiCertificates.Name = "tiCertificates"
            Me.tiCertificates.Text = "Certificates"
            '
            'TabControlPanel10
            '
            Me.TabControlPanel10.Controls.Add(Me.adtVariations)
            Me.TabControlPanel10.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel10.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel10.Name = "TabControlPanel10"
            Me.TabControlPanel10.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel10.Size = New System.Drawing.Size(701, 592)
            Me.TabControlPanel10.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel10.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel10.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel10.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel10.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel10.Style.GradientAngle = 90
            Me.TabControlPanel10.TabIndex = 7
            Me.TabControlPanel10.TabItem = Me.tiVariations
            '
            'adtVariations
            '
            Me.adtVariations.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtVariations.AllowDrop = True
            Me.adtVariations.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtVariations.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtVariations.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtVariations.Dock = System.Windows.Forms.DockStyle.Fill
            Me.adtVariations.DragDropEnabled = False
            Me.adtVariations.DragDropNodeCopyEnabled = False
            Me.adtVariations.ExpandWidth = 0
            
            Me.adtVariations.Location = New System.Drawing.Point(1, 1)
            Me.adtVariations.Name = "adtVariations"
            Me.adtVariations.NodesConnector = Me.NodeConnector7
            Me.adtVariations.NodeStyle = Me.ElementStyle9
            Me.adtVariations.PathSeparator = ";"
            Me.adtVariations.Size = New System.Drawing.Size(699, 590)
            Me.adtVariations.Styles.Add(Me.ElementStyle9)
            Me.adtVariations.TabIndex = 2
            Me.adtVariations.Text = "AdvTree1"
            '
            'NodeConnector7
            '
            Me.NodeConnector7.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle9
            '
            Me.ElementStyle9.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle9.Name = "ElementStyle9"
            Me.ElementStyle9.TextColor = System.Drawing.SystemColors.ControlText
            '
            'tiVariations
            '
            Me.tiVariations.AttachedControl = Me.TabControlPanel10
            Me.tiVariations.Name = "tiVariations"
            Me.tiVariations.Text = "Meta Variations"
            '
            'TabControlPanel6
            '
            Me.TabControlPanel6.Controls.Add(Me.adtEffects)
            Me.TabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel6.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel6.Name = "TabControlPanel6"
            Me.TabControlPanel6.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel6.Size = New System.Drawing.Size(701, 592)
            Me.TabControlPanel6.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel6.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel6.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel6.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel6.Style.GradientAngle = 90
            Me.TabControlPanel6.TabIndex = 3
            Me.TabControlPanel6.TabItem = Me.tiEffects
            '
            'adtEffects
            '
            Me.adtEffects.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtEffects.AllowDrop = True
            Me.adtEffects.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtEffects.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtEffects.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtEffects.Columns.Add(Me.colEffectName)
            Me.adtEffects.Dock = System.Windows.Forms.DockStyle.Fill
            Me.adtEffects.DragDropEnabled = False
            Me.adtEffects.DragDropNodeCopyEnabled = False
            Me.adtEffects.ExpandWidth = 0
            
            Me.adtEffects.Location = New System.Drawing.Point(1, 1)
            Me.adtEffects.Name = "adtEffects"
            Me.adtEffects.NodesConnector = Me.NodeConnector5
            Me.adtEffects.NodeStyle = Me.ElementStyle5
            Me.adtEffects.PathSeparator = ";"
            Me.adtEffects.Size = New System.Drawing.Size(699, 590)
            Me.adtEffects.Styles.Add(Me.ElementStyle5)
            Me.adtEffects.TabIndex = 1
            Me.adtEffects.Text = "AdvTree1"
            '
            'colEffectName
            '
            Me.colEffectName.DisplayIndex = 1
            Me.colEffectName.Name = "colEffectName"
            Me.colEffectName.SortingEnabled = False
            Me.colEffectName.Text = "Effect Name"
            Me.colEffectName.Width.Absolute = 450
            '
            'NodeConnector5
            '
            Me.NodeConnector5.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle5
            '
            Me.ElementStyle5.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle5.Name = "ElementStyle5"
            Me.ElementStyle5.TextColor = System.Drawing.SystemColors.ControlText
            '
            'tiEffects
            '
            Me.tiEffects.AttachedControl = Me.TabControlPanel6
            Me.tiEffects.Name = "tiEffects"
            Me.tiEffects.Text = "Effects"
            '
            'TabControlPanel8
            '
            Me.TabControlPanel8.Controls.Add(Me.adtSkills)
            Me.TabControlPanel8.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel8.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel8.Name = "TabControlPanel8"
            Me.TabControlPanel8.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel8.Size = New System.Drawing.Size(701, 592)
            Me.TabControlPanel8.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel8.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel8.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel8.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel8.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel8.Style.GradientAngle = 90
            Me.TabControlPanel8.TabIndex = 5
            Me.TabControlPanel8.TabItem = Me.tiSkills
            '
            'tiSkills
            '
            Me.tiSkills.AttachedControl = Me.TabControlPanel8
            Me.tiSkills.Name = "tiSkills"
            Me.tiSkills.Text = "Skills"
            '
            'TabControlPanel7
            '
            Me.TabControlPanel7.Controls.Add(Me.adtFitting)
            Me.TabControlPanel7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel7.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel7.Name = "TabControlPanel7"
            Me.TabControlPanel7.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel7.Size = New System.Drawing.Size(701, 592)
            Me.TabControlPanel7.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel7.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel7.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel7.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel7.Style.GradientAngle = 90
            Me.TabControlPanel7.TabIndex = 4
            Me.TabControlPanel7.TabItem = Me.tiFitting
            '
            'adtFitting
            '
            Me.adtFitting.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtFitting.AllowDrop = True
            Me.adtFitting.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtFitting.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtFitting.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtFitting.Columns.Add(Me.colFittingAttribute)
            Me.adtFitting.Columns.Add(Me.colFittingValue)
            Me.adtFitting.Dock = System.Windows.Forms.DockStyle.Fill
            Me.adtFitting.DragDropEnabled = False
            Me.adtFitting.DragDropNodeCopyEnabled = False
            Me.adtFitting.ExpandWidth = 0
            
            Me.adtFitting.Location = New System.Drawing.Point(1, 1)
            Me.adtFitting.Name = "adtFitting"
            Me.adtFitting.NodesConnector = Me.NodeConnector6
            Me.adtFitting.NodeStyle = Me.ElementStyle6
            Me.adtFitting.PathSeparator = ";"
            Me.adtFitting.Size = New System.Drawing.Size(699, 590)
            Me.adtFitting.Styles.Add(Me.ElementStyle6)
            Me.adtFitting.TabIndex = 1
            Me.adtFitting.Text = "AdvTree1"
            '
            'colFittingAttribute
            '
            Me.colFittingAttribute.DisplayIndex = 1
            Me.colFittingAttribute.Name = "colFittingAttribute"
            Me.colFittingAttribute.SortingEnabled = False
            Me.colFittingAttribute.Text = "Attribute Name"
            Me.colFittingAttribute.Width.Absolute = 250
            '
            'colFittingValue
            '
            Me.colFittingValue.DisplayIndex = 2
            Me.colFittingValue.Name = "colFittingValue"
            Me.colFittingValue.SortingEnabled = False
            Me.colFittingValue.Text = "Value"
            Me.colFittingValue.Width.Absolute = 250
            '
            'NodeConnector6
            '
            Me.NodeConnector6.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle6
            '
            Me.ElementStyle6.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle6.Name = "ElementStyle6"
            Me.ElementStyle6.TextColor = System.Drawing.SystemColors.ControlText
            '
            'tiFitting
            '
            Me.tiFitting.AttachedControl = Me.TabControlPanel7
            Me.tiFitting.Name = "tiFitting"
            Me.tiFitting.Text = "Fitting"
            '
            'pnlInfo
            '
            Me.pnlInfo.CanvasColor = System.Drawing.SystemColors.Control
            Me.pnlInfo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.pnlInfo.Controls.Add(Me.btnAddSkills)
            Me.pnlInfo.Controls.Add(Me.btnRequisition)
            Me.pnlInfo.Controls.Add(Me.cboPilots)
            Me.pnlInfo.Controls.Add(Me.btnNavForward)
            Me.pnlInfo.Controls.Add(Me.btnNavBack)
            Me.pnlInfo.Controls.Add(Me.btnNavRecent)
            Me.pnlInfo.Controls.Add(Me.lblItemName)
            Me.pnlInfo.Controls.Add(Me.lblUsableTime)
            Me.pnlInfo.Controls.Add(Me.picItem)
            Me.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlInfo.Location = New System.Drawing.Point(361, 0)
            Me.pnlInfo.Name = "pnlInfo"
            Me.pnlInfo.Size = New System.Drawing.Size(701, 74)
            Me.pnlInfo.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.pnlInfo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.pnlInfo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.pnlInfo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.pnlInfo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.pnlInfo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.pnlInfo.Style.GradientAngle = 90
            Me.pnlInfo.TabIndex = 49
            '
            'btnAddSkills
            '
            Me.btnAddSkills.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnAddSkills.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnAddSkills.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnAddSkills.Enabled = False
            Me.btnAddSkills.Location = New System.Drawing.Point(365, 27)
            Me.btnAddSkills.Name = "btnAddSkills"
            Me.btnAddSkills.Size = New System.Drawing.Size(60, 21)
            Me.btnAddSkills.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnAddSkills.TabIndex = 55
            Me.btnAddSkills.Text = "Add Skills"
            '
            'btnRequisition
            '
            Me.btnRequisition.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnRequisition.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnRequisition.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnRequisition.Enabled = False
            Me.btnRequisition.Location = New System.Drawing.Point(431, 27)
            Me.btnRequisition.Name = "btnRequisition"
            Me.btnRequisition.Size = New System.Drawing.Size(60, 21)
            Me.btnRequisition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnRequisition.TabIndex = 54
            Me.btnRequisition.Text = "Requisition"
            '
            'cboPilots
            '
            Me.cboPilots.DisplayMember = "Text"
            Me.cboPilots.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboPilots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboPilots.FormattingEnabled = True
            Me.cboPilots.ItemHeight = 15
            Me.cboPilots.Location = New System.Drawing.Point(73, 27)
            Me.cboPilots.Name = "cboPilots"
            Me.cboPilots.Size = New System.Drawing.Size(161, 21)
            Me.cboPilots.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboPilots.TabIndex = 53
            '
            'btnNavForward
            '
            Me.btnNavForward.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnNavForward.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnNavForward.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnNavForward.Enabled = False
            Me.btnNavForward.Location = New System.Drawing.Point(563, 27)
            Me.btnNavForward.Name = "btnNavForward"
            Me.btnNavForward.Size = New System.Drawing.Size(60, 21)
            Me.btnNavForward.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnNavForward.TabIndex = 52
            Me.btnNavForward.Text = "Forward"
            '
            'btnNavBack
            '
            Me.btnNavBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnNavBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnNavBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnNavBack.Enabled = False
            Me.btnNavBack.Location = New System.Drawing.Point(497, 27)
            Me.btnNavBack.Name = "btnNavBack"
            Me.btnNavBack.Size = New System.Drawing.Size(60, 21)
            Me.btnNavBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnNavBack.TabIndex = 51
            Me.btnNavBack.Text = "Back"
            '
            'btnNavRecent
            '
            Me.btnNavRecent.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnNavRecent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnNavRecent.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnNavRecent.Enabled = False
            Me.btnNavRecent.Location = New System.Drawing.Point(629, 27)
            Me.btnNavRecent.Name = "btnNavRecent"
            Me.btnNavRecent.Size = New System.Drawing.Size(60, 21)
            Me.btnNavRecent.SplitButton = True
            Me.btnNavRecent.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnNavRecent.TabIndex = 50
            Me.btnNavRecent.Text = "Recent"
            '
            'lblItemName
            '
            Me.lblItemName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.lblItemName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblItemName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblItemName.Location = New System.Drawing.Point(73, 3)
            Me.lblItemName.Name = "lblItemName"
            Me.lblItemName.Size = New System.Drawing.Size(616, 23)
            Me.lblItemName.TabIndex = 49
            '
            'lblUsableTime
            '
            '
            '
            '
            Me.lblUsableTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblUsableTime.Location = New System.Drawing.Point(73, 48)
            Me.lblUsableTime.Name = "lblUsableTime"
            Me.lblUsableTime.Size = New System.Drawing.Size(616, 23)
            Me.lblUsableTime.TabIndex = 48
            Me.lblUsableTime.Text = "Usable Time: n/a"
            '
            'picItem
            '
            Me.picItem.Location = New System.Drawing.Point(3, 3)
            Me.picItem.Name = "picItem"
            Me.picItem.Size = New System.Drawing.Size(64, 64)
            Me.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picItem.TabIndex = 46
            Me.picItem.TabStop = False
            '
            'tabBrowser
            '
            Me.tabBrowser.BackColor = System.Drawing.Color.Transparent
            Me.tabBrowser.CanReorderTabs = True
            Me.tabBrowser.ColorScheme.TabBackground = System.Drawing.Color.Transparent
            Me.tabBrowser.ColorScheme.TabBackground2 = System.Drawing.Color.Transparent
            Me.tabBrowser.ColorScheme.TabItemBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(226, Byte), Integer)), 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(199, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(223, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), 1.0!)})
            Me.tabBrowser.ColorScheme.TabItemHotBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(235, Byte), Integer)), 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(168, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(89, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(141, Byte), Integer)), 1.0!)})
            Me.tabBrowser.ColorScheme.TabItemSelectedBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.White, 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer)), 1.0!)})
            Me.tabBrowser.Controls.Add(Me.TabControlPanel14)
            Me.tabBrowser.Controls.Add(Me.TabControlPanel13)
            Me.tabBrowser.Controls.Add(Me.TabControlPanel35)
            Me.tabBrowser.Controls.Add(Me.TabControlPanel3)
            Me.tabBrowser.Controls.Add(Me.TabControlPanel2)
            Me.tabBrowser.Controls.Add(Me.TabControlPanel1)
            Me.tabBrowser.Dock = System.Windows.Forms.DockStyle.Left
            Me.tabBrowser.Location = New System.Drawing.Point(0, 0)
            Me.tabBrowser.Name = "tabBrowser"
            Me.tabBrowser.SelectedTabFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.tabBrowser.SelectedTabIndex = 0
            Me.tabBrowser.Size = New System.Drawing.Size(361, 689)
            Me.tabBrowser.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
            Me.tabBrowser.TabIndex = 45
            Me.tabBrowser.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
            Me.tabBrowser.Tabs.Add(Me.tabSearch)
            Me.tabBrowser.Tabs.Add(Me.tabBrowse)
            Me.tabBrowser.Tabs.Add(Me.tabAttSearch)
            Me.tabBrowser.Tabs.Add(Me.tabEffectSearch)
            Me.tabBrowser.Tabs.Add(Me.tabCategories)
            Me.tabBrowser.Tabs.Add(Me.tabGroups)
            Me.tabBrowser.Text = "TabControl2"
            '
            'TabControlPanel2
            '
            Me.TabControlPanel2.Controls.Add(Me.lblSearchCount)
            Me.TabControlPanel2.Controls.Add(Me.lblSearch)
            Me.TabControlPanel2.Controls.Add(Me.txtSearch)
            Me.TabControlPanel2.Controls.Add(Me.adtSearch)
            Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel2.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel2.Name = "TabControlPanel2"
            Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel2.Size = New System.Drawing.Size(361, 666)
            Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel2.Style.GradientAngle = 90
            Me.TabControlPanel2.TabIndex = 2
            Me.TabControlPanel2.TabItem = Me.tabSearch
            '
            'lblSearchCount
            '
            Me.lblSearchCount.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblSearchCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblSearchCount.Location = New System.Drawing.Point(206, 4)
            Me.lblSearchCount.Name = "lblSearchCount"
            Me.lblSearchCount.Size = New System.Drawing.Size(150, 16)
            Me.lblSearchCount.TabIndex = 8
            Me.lblSearchCount.Text = "0 Items Found"
            Me.lblSearchCount.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'lblSearch
            '
            Me.lblSearch.AutoSize = True
            Me.lblSearch.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblSearch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblSearch.Location = New System.Drawing.Point(4, 4)
            Me.lblSearch.Name = "lblSearch"
            Me.lblSearch.Size = New System.Drawing.Size(70, 16)
            Me.lblSearch.TabIndex = 7
            Me.lblSearch.Text = "Search Items:"
            '
            'txtSearch
            '
            '
            '
            '
            Me.txtSearch.Border.Class = "TextBoxBorder"
            Me.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.txtSearch.Location = New System.Drawing.Point(4, 21)
            Me.txtSearch.Name = "txtSearch"
            Me.txtSearch.Size = New System.Drawing.Size(352, 21)
            Me.txtSearch.TabIndex = 6
            '
            'adtSearch
            '
            Me.adtSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtSearch.AllowDrop = True
            Me.adtSearch.AlternateRowColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.adtSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.adtSearch.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtSearch.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtSearch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtSearch.Columns.Add(Me.colSearchItemName)
            Me.adtSearch.DragDropEnabled = False
            Me.adtSearch.DragDropNodeCopyEnabled = False
            Me.adtSearch.ExpandWidth = 0
            
            Me.adtSearch.Location = New System.Drawing.Point(4, 46)
            Me.adtSearch.Name = "adtSearch"
            Me.adtSearch.NodesConnector = Me.NodeConnector1
            Me.adtSearch.NodeStyle = Me.ElementStyle1
            Me.adtSearch.PathSeparator = ";"
            Me.adtSearch.Size = New System.Drawing.Size(352, 616)
            Me.adtSearch.Styles.Add(Me.ElementStyle1)
            Me.adtSearch.TabIndex = 5
            Me.adtSearch.Text = "AdvTree1"
            '
            'colSearchItemName
            '
            Me.colSearchItemName.DisplayIndex = 1
            Me.colSearchItemName.Name = "colSearchItemName"
            Me.colSearchItemName.SortingEnabled = False
            Me.colSearchItemName.Text = "Item Name"
            Me.colSearchItemName.Width.Absolute = 325
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
            'tabSearch
            '
            Me.tabSearch.AttachedControl = Me.TabControlPanel2
            Me.tabSearch.Name = "tabSearch"
            Me.tabSearch.Text = "Search"
            '
            'TabControlPanel1
            '
            Me.TabControlPanel1.Controls.Add(Me.adtBrowse)
            Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel1.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel1.Name = "TabControlPanel1"
            Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel1.Size = New System.Drawing.Size(361, 666)
            Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel1.Style.GradientAngle = 90
            Me.TabControlPanel1.TabIndex = 1
            Me.TabControlPanel1.TabItem = Me.tabBrowse
            '
            'adtBrowse
            '
            Me.adtBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtBrowse.AllowDrop = True
            Me.adtBrowse.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtBrowse.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtBrowse.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtBrowse.Columns.Add(Me.colBrowserHeading)
            Me.adtBrowse.Dock = System.Windows.Forms.DockStyle.Fill
            Me.adtBrowse.DragDropEnabled = False
            Me.adtBrowse.DragDropNodeCopyEnabled = False
            
            Me.adtBrowse.Location = New System.Drawing.Point(1, 1)
            Me.adtBrowse.Name = "adtBrowse"
            Me.adtBrowse.NodesConnector = Me.NodeConnector10
            Me.adtBrowse.NodeStyle = Me.ElementStyle12
            Me.adtBrowse.PathSeparator = ";"
            Me.adtBrowse.Size = New System.Drawing.Size(359, 664)
            Me.adtBrowse.Styles.Add(Me.ElementStyle12)
            Me.adtBrowse.TabIndex = 6
            '
            'colBrowserHeading
            '
            Me.colBrowserHeading.DisplayIndex = 1
            Me.colBrowserHeading.Name = "colBrowserHeading"
            Me.colBrowserHeading.SortingEnabled = False
            Me.colBrowserHeading.Text = "Category / Group"
            Me.colBrowserHeading.Width.Absolute = 325
            '
            'NodeConnector10
            '
            Me.NodeConnector10.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle12
            '
            Me.ElementStyle12.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle12.Name = "ElementStyle12"
            Me.ElementStyle12.TextColor = System.Drawing.SystemColors.ControlText
            '
            'tabBrowse
            '
            Me.tabBrowse.AttachedControl = Me.TabControlPanel1
            Me.tabBrowse.Name = "tabBrowse"
            Me.tabBrowse.Text = "Browse"
            '
            'TabControlPanel3
            '
            Me.TabControlPanel3.Controls.Add(Me.lblAttSearchCount)
            Me.TabControlPanel3.Controls.Add(Me.lblAttSearch)
            Me.TabControlPanel3.Controls.Add(Me.cboAttSearch)
            Me.TabControlPanel3.Controls.Add(Me.adtAttSearch)
            Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel3.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel3.Name = "TabControlPanel3"
            Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel3.Size = New System.Drawing.Size(361, 666)
            Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel3.Style.GradientAngle = 90
            Me.TabControlPanel3.TabIndex = 3
            Me.TabControlPanel3.TabItem = Me.tabAttSearch
            '
            'lblAttSearchCount
            '
            Me.lblAttSearchCount.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblAttSearchCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblAttSearchCount.Location = New System.Drawing.Point(206, 4)
            Me.lblAttSearchCount.Name = "lblAttSearchCount"
            Me.lblAttSearchCount.Size = New System.Drawing.Size(150, 16)
            Me.lblAttSearchCount.TabIndex = 20
            Me.lblAttSearchCount.Text = "0 Items Found"
            Me.lblAttSearchCount.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'lblAttSearch
            '
            Me.lblAttSearch.AutoSize = True
            Me.lblAttSearch.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblAttSearch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblAttSearch.Location = New System.Drawing.Point(4, 4)
            Me.lblAttSearch.Name = "lblAttSearch"
            Me.lblAttSearch.Size = New System.Drawing.Size(90, 16)
            Me.lblAttSearch.TabIndex = 19
            Me.lblAttSearch.Text = "Search Attributes:"
            '
            'cboAttSearch
            '
            Me.cboAttSearch.DisplayMember = "Text"
            Me.cboAttSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboAttSearch.FormattingEnabled = True
            Me.cboAttSearch.ItemHeight = 15
            Me.cboAttSearch.Location = New System.Drawing.Point(4, 21)
            Me.cboAttSearch.Name = "cboAttSearch"
            Me.cboAttSearch.Size = New System.Drawing.Size(352, 21)
            Me.cboAttSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboAttSearch.TabIndex = 12
            '
            'adtAttSearch
            '
            Me.adtAttSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtAttSearch.AllowDrop = True
            Me.adtAttSearch.AlternateRowColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.adtAttSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.adtAttSearch.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtAttSearch.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtAttSearch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtAttSearch.Columns.Add(Me.colAttSearchItemName)
            Me.adtAttSearch.Columns.Add(Me.colAttSearchValue)
            Me.adtAttSearch.DragDropEnabled = False
            Me.adtAttSearch.DragDropNodeCopyEnabled = False
            Me.adtAttSearch.ExpandWidth = 0
            
            Me.adtAttSearch.Location = New System.Drawing.Point(4, 46)
            Me.adtAttSearch.Name = "adtAttSearch"
            Me.adtAttSearch.NodesConnector = Me.NodeConnector2
            Me.adtAttSearch.NodeStyle = Me.ElementStyle2
            Me.adtAttSearch.PathSeparator = ";"
            Me.adtAttSearch.Size = New System.Drawing.Size(352, 616)
            Me.adtAttSearch.Styles.Add(Me.ElementStyle2)
            Me.adtAttSearch.TabIndex = 11
            Me.adtAttSearch.Text = "AdvTree1"
            '
            'colAttSearchItemName
            '
            Me.colAttSearchItemName.DisplayIndex = 1
            Me.colAttSearchItemName.Name = "colAttSearchItemName"
            Me.colAttSearchItemName.SortingEnabled = False
            Me.colAttSearchItemName.Text = "Item Name"
            Me.colAttSearchItemName.Width.Absolute = 275
            '
            'colAttSearchValue
            '
            Me.colAttSearchValue.DisplayIndex = 2
            Me.colAttSearchValue.Name = "colAttSearchValue"
            Me.colAttSearchValue.SortingEnabled = False
            Me.colAttSearchValue.Text = "Value"
            Me.colAttSearchValue.Width.Absolute = 50
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
            'tabAttSearch
            '
            Me.tabAttSearch.AttachedControl = Me.TabControlPanel3
            Me.tabAttSearch.Name = "tabAttSearch"
            Me.tabAttSearch.Text = "Attributes"
            '
            'TabControlPanel35
            '
            Me.TabControlPanel35.Controls.Add(Me.lblEffectSearchCount)
            Me.TabControlPanel35.Controls.Add(Me.lblEffectSearch)
            Me.TabControlPanel35.Controls.Add(Me.cboEffectSearch)
            Me.TabControlPanel35.Controls.Add(Me.adtEffectSearch)
            Me.TabControlPanel35.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel35.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel35.Name = "TabControlPanel35"
            Me.TabControlPanel35.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel35.Size = New System.Drawing.Size(361, 666)
            Me.TabControlPanel35.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel35.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel35.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel35.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel35.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel35.Style.GradientAngle = 90
            Me.TabControlPanel35.TabIndex = 4
            Me.TabControlPanel35.TabItem = Me.tabEffectSearch
            '
            'lblEffectSearchCount
            '
            Me.lblEffectSearchCount.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblEffectSearchCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblEffectSearchCount.Location = New System.Drawing.Point(206, 4)
            Me.lblEffectSearchCount.Name = "lblEffectSearchCount"
            Me.lblEffectSearchCount.Size = New System.Drawing.Size(150, 16)
            Me.lblEffectSearchCount.TabIndex = 18
            Me.lblEffectSearchCount.Text = "0 Items Found"
            Me.lblEffectSearchCount.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'lblEffectSearch
            '
            Me.lblEffectSearch.AutoSize = True
            Me.lblEffectSearch.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lblEffectSearch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblEffectSearch.Location = New System.Drawing.Point(4, 4)
            Me.lblEffectSearch.Name = "lblEffectSearch"
            Me.lblEffectSearch.Size = New System.Drawing.Size(75, 16)
            Me.lblEffectSearch.TabIndex = 17
            Me.lblEffectSearch.Text = "Search Effects:"
            '
            'cboEffectSearch
            '
            Me.cboEffectSearch.DisplayMember = "Text"
            Me.cboEffectSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboEffectSearch.FormattingEnabled = True
            Me.cboEffectSearch.ItemHeight = 15
            Me.cboEffectSearch.Location = New System.Drawing.Point(4, 21)
            Me.cboEffectSearch.Name = "cboEffectSearch"
            Me.cboEffectSearch.Size = New System.Drawing.Size(352, 21)
            Me.cboEffectSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboEffectSearch.TabIndex = 16
            '
            'adtEffectSearch
            '
            Me.adtEffectSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtEffectSearch.AllowDrop = True
            Me.adtEffectSearch.AlternateRowColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.adtEffectSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.adtEffectSearch.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtEffectSearch.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtEffectSearch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtEffectSearch.Columns.Add(Me.colEffectSearchItemName)
            Me.adtEffectSearch.DragDropEnabled = False
            Me.adtEffectSearch.DragDropNodeCopyEnabled = False
            Me.adtEffectSearch.ExpandWidth = 0
            
            Me.adtEffectSearch.Location = New System.Drawing.Point(4, 46)
            Me.adtEffectSearch.Name = "adtEffectSearch"
            Me.adtEffectSearch.NodesConnector = Me.NodeConnector3
            Me.adtEffectSearch.NodeStyle = Me.ElementStyle3
            Me.adtEffectSearch.PathSeparator = ";"
            Me.adtEffectSearch.Size = New System.Drawing.Size(352, 616)
            Me.adtEffectSearch.Styles.Add(Me.ElementStyle3)
            Me.adtEffectSearch.TabIndex = 15
            Me.adtEffectSearch.Text = "AdvTree1"
            '
            'colEffectSearchItemName
            '
            Me.colEffectSearchItemName.DisplayIndex = 1
            Me.colEffectSearchItemName.Name = "colEffectSearchItemName"
            Me.colEffectSearchItemName.SortingEnabled = False
            Me.colEffectSearchItemName.Text = "Item Name"
            Me.colEffectSearchItemName.Width.Absolute = 325
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
            'tabEffectSearch
            '
            Me.tabEffectSearch.AttachedControl = Me.TabControlPanel35
            Me.tabEffectSearch.Name = "tabEffectSearch"
            Me.tabEffectSearch.Text = "Effects"
            '
            'STTItem
            '
            
            Me.STTItem.MinimumTooltipSize = New System.Drawing.Size(200, 24)
            Me.STTItem.PositionBelowControl = False
            '
            'adtSkills
            '
            Me.adtSkills.Dock = System.Windows.Forms.DockStyle.Fill
            Me.adtSkills.ItemIsUsable = False
            Me.adtSkills.ItemUsableTime = CType(0, Long)
            Me.adtSkills.Location = New System.Drawing.Point(1, 1)
            Me.adtSkills.Name = "adtSkills"
            Me.adtSkills.RequiredSkills = New Dictionary(Of String, Integer)()
            Me.adtSkills.Size = New System.Drawing.Size(699, 590)
            Me.adtSkills.TabIndex = 0
            '
            'tabCategories
            '
            Me.tabCategories.AttachedControl = Me.TabControlPanel13
            Me.tabCategories.Name = "tabCategories"
            Me.tabCategories.Text = "Categories"
            '
            'TabControlPanel13
            '
            Me.TabControlPanel13.Controls.Add(Me.adtCategories)
            Me.TabControlPanel13.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel13.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel13.Name = "TabControlPanel13"
            Me.TabControlPanel13.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel13.Size = New System.Drawing.Size(361, 666)
            Me.TabControlPanel13.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel13.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel13.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel13.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel13.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel13.Style.GradientAngle = 90
            Me.TabControlPanel13.TabIndex = 5
            Me.TabControlPanel13.TabItem = Me.tabCategories
            '
            'adtCategories
            '
            Me.adtCategories.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtCategories.AllowDrop = True
            Me.adtCategories.AlternateRowColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.adtCategories.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtCategories.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtCategories.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtCategories.Columns.Add(Me.colCategoryID)
            Me.adtCategories.Columns.Add(Me.colCategoryName)
            Me.adtCategories.Dock = System.Windows.Forms.DockStyle.Fill
            Me.adtCategories.DragDropEnabled = False
            Me.adtCategories.DragDropNodeCopyEnabled = False
            Me.adtCategories.ExpandWidth = 0
            
            Me.adtCategories.Location = New System.Drawing.Point(1, 1)
            Me.adtCategories.Name = "adtCategories"
            Me.adtCategories.NodesConnector = Me.NodeConnector11
            Me.adtCategories.NodeStyle = Me.ElementStyle13
            Me.adtCategories.PathSeparator = ";"
            Me.adtCategories.Size = New System.Drawing.Size(359, 664)
            Me.adtCategories.Styles.Add(Me.ElementStyle13)
            Me.adtCategories.TabIndex = 12
            Me.adtCategories.Text = "AdvTree1"
            '
            'colCategoryID
            '
            Me.colCategoryID.DisplayIndex = 1
            Me.colCategoryID.Name = "colCategoryID"
            Me.colCategoryID.SortingEnabled = False
            Me.colCategoryID.Text = "ID"
            Me.colCategoryID.Width.Absolute = 50
            '
            'colCategoryName
            '
            Me.colCategoryName.DisplayIndex = 2
            Me.colCategoryName.Name = "colCategoryName"
            Me.colCategoryName.SortingEnabled = False
            Me.colCategoryName.Text = "Name"
            Me.colCategoryName.Width.Absolute = 275
            '
            'NodeConnector11
            '
            Me.NodeConnector11.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle13
            '
            Me.ElementStyle13.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle13.Name = "ElementStyle13"
            Me.ElementStyle13.TextColor = System.Drawing.SystemColors.ControlText
            '
            'tabGroups
            '
            Me.tabGroups.AttachedControl = Me.TabControlPanel14
            Me.tabGroups.Name = "tabGroups"
            Me.tabGroups.Text = "Groups"
            '
            'TabControlPanel14
            '
            Me.TabControlPanel14.Controls.Add(Me.adtGroups)
            Me.TabControlPanel14.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlPanel14.Location = New System.Drawing.Point(0, 23)
            Me.TabControlPanel14.Name = "TabControlPanel14"
            Me.TabControlPanel14.Padding = New System.Windows.Forms.Padding(1)
            Me.TabControlPanel14.Size = New System.Drawing.Size(361, 666)
            Me.TabControlPanel14.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabControlPanel14.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.TabControlPanel14.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.TabControlPanel14.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.TabControlPanel14.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
            Me.TabControlPanel14.Style.GradientAngle = 90
            Me.TabControlPanel14.TabIndex = 6
            Me.TabControlPanel14.TabItem = Me.tabGroups
            '
            'adtGroups
            '
            Me.adtGroups.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtGroups.AllowDrop = True
            Me.adtGroups.AlternateRowColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.adtGroups.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtGroups.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtGroups.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtGroups.Columns.Add(Me.ColumnHeader1)
            Me.adtGroups.Columns.Add(Me.ColumnHeader2)
            Me.adtGroups.Dock = System.Windows.Forms.DockStyle.Fill
            Me.adtGroups.DragDropEnabled = False
            Me.adtGroups.DragDropNodeCopyEnabled = False
            Me.adtGroups.ExpandWidth = 0
            
            Me.adtGroups.Location = New System.Drawing.Point(1, 1)
            Me.adtGroups.Name = "adtGroups"
            Me.adtGroups.NodesConnector = Me.NodeConnector12
            Me.adtGroups.NodeStyle = Me.ElementStyle14
            Me.adtGroups.PathSeparator = ";"
            Me.adtGroups.Size = New System.Drawing.Size(359, 664)
            Me.adtGroups.Styles.Add(Me.ElementStyle14)
            Me.adtGroups.TabIndex = 13
            Me.adtGroups.Text = "AdvTree1"
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.DisplayIndex = 1
            Me.ColumnHeader1.Name = "ColumnHeader1"
            Me.ColumnHeader1.SortingEnabled = False
            Me.ColumnHeader1.Text = "ID"
            Me.ColumnHeader1.Width.Absolute = 50
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.DisplayIndex = 2
            Me.ColumnHeader2.Name = "ColumnHeader2"
            Me.ColumnHeader2.SortingEnabled = False
            Me.ColumnHeader2.Text = "Name"
            Me.ColumnHeader2.Width.Absolute = 275
            '
            'NodeConnector12
            '
            Me.NodeConnector12.LineColor = System.Drawing.SystemColors.ControlText
            '
            'ElementStyle14
            '
            Me.ElementStyle14.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle14.Name = "ElementStyle14"
            Me.ElementStyle14.TextColor = System.Drawing.SystemColors.ControlText
            '
            'FrmIB
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1062, 711)
            Me.Controls.Add(Me.pnlIB)
            Me.Controls.Add(Me.barStatus)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmIB"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "EveHQ Item Browser"
            CType(Me.barStatus, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlIB.ResumeLayout(False)
            CType(Me.tcIB, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tcIB.ResumeLayout(False)
            Me.TabControlPanel4.ResumeLayout(False)
            Me.TabControlPanel12.ResumeLayout(False)
            CType(Me.adtComponents, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControlPanel11.ResumeLayout(False)
            CType(Me.adtMaterials, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControlPanel5.ResumeLayout(False)
            CType(Me.adtAttributes, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControlPanel9.ResumeLayout(False)
            CType(Me.adtCerts, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControlPanel10.ResumeLayout(False)
            CType(Me.adtVariations, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControlPanel6.ResumeLayout(False)
            CType(Me.adtEffects, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControlPanel8.ResumeLayout(False)
            Me.TabControlPanel7.ResumeLayout(False)
            CType(Me.adtFitting, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlInfo.ResumeLayout(False)
            CType(Me.picItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabBrowser, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabBrowser.ResumeLayout(False)
            Me.TabControlPanel2.ResumeLayout(False)
            Me.TabControlPanel2.PerformLayout()
            CType(Me.adtSearch, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControlPanel1.ResumeLayout(False)
            CType(Me.adtBrowse, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControlPanel3.ResumeLayout(False)
            Me.TabControlPanel3.PerformLayout()
            CType(Me.adtAttSearch, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControlPanel35.ResumeLayout(False)
            Me.TabControlPanel35.PerformLayout()
            CType(Me.adtEffectSearch, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControlPanel13.ResumeLayout(False)
            CType(Me.adtCategories, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControlPanel14.ResumeLayout(False)
            CType(Me.adtGroups, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControlPanel15.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents barStatus As DevComponents.DotNetBar.Bar
        Friend WithEvents lblStatus As DevComponents.DotNetBar.LabelItem
        Friend WithEvents lblDBLocation As DevComponents.DotNetBar.LabelItem
        Friend WithEvents lblID As DevComponents.DotNetBar.LabelItem
        Friend WithEvents pnlIB As DevComponents.DotNetBar.PanelEx
        Friend WithEvents tabBrowser As DevComponents.DotNetBar.TabControl
        Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tabSearch As DevComponents.DotNetBar.TabItem
        Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tabBrowse As DevComponents.DotNetBar.TabItem
        Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tabAttSearch As DevComponents.DotNetBar.TabItem
        Friend WithEvents TabControlPanel35 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tabEffectSearch As DevComponents.DotNetBar.TabItem
        Friend WithEvents adtSearch As DevComponents.AdvTree.AdvTree
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents colSearchItemName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents lblSearchCount As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblSearch As DevComponents.DotNetBar.LabelX
        Friend WithEvents txtSearch As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents adtEffectSearch As DevComponents.AdvTree.AdvTree
        Friend WithEvents colEffectSearchItemName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector3 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle3 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents adtAttSearch As DevComponents.AdvTree.AdvTree
        Friend WithEvents colAttSearchItemName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector2 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle2 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents cboEffectSearch As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents cboAttSearch As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblEffectSearchCount As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblEffectSearch As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblAttSearchCount As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblAttSearch As DevComponents.DotNetBar.LabelX
        Friend WithEvents colAttSearchValue As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents STTItem As DevComponents.DotNetBar.SuperTooltip
        Friend WithEvents picItem As System.Windows.Forms.PictureBox
        Friend WithEvents tcIB As DevComponents.DotNetBar.TabControl
        Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tiDescription As DevComponents.DotNetBar.TabItem
        Friend WithEvents pnlInfo As DevComponents.DotNetBar.PanelEx
        Friend WithEvents lblDescription As DevComponents.DotNetBar.LabelX
        Friend WithEvents TabControlPanel5 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tiAttributes As DevComponents.DotNetBar.TabItem
        Friend WithEvents adtAttributes As DevComponents.AdvTree.AdvTree
        Friend WithEvents colAttributeName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colAttributeValue As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector4 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle4 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents TabControlPanel6 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents adtEffects As DevComponents.AdvTree.AdvTree
        Friend WithEvents colEffectName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector5 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle5 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents tiEffects As DevComponents.DotNetBar.TabItem
        Friend WithEvents TabControlPanel7 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tiFitting As DevComponents.DotNetBar.TabItem
        Friend WithEvents adtFitting As DevComponents.AdvTree.AdvTree
        Friend WithEvents colFittingAttribute As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colFittingValue As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector6 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle6 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents TabControlPanel8 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents adtSkills As IBSkillTree
        Friend WithEvents tiSkills As DevComponents.DotNetBar.TabItem
        Friend WithEvents lblUsableTime As DevComponents.DotNetBar.LabelX
        Friend WithEvents TabControlPanel9 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tiCertificates As DevComponents.DotNetBar.TabItem
        Friend WithEvents adtCerts As DevComponents.AdvTree.AdvTree
        Friend WithEvents colCertificateName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colCertificateGrade As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents ElementStyle7 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents ElementStyle8 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents lblItemName As DevComponents.DotNetBar.LabelX
        Friend WithEvents TabControlPanel10 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tiVariations As DevComponents.DotNetBar.TabItem
        Friend WithEvents adtVariations As DevComponents.AdvTree.AdvTree
        Friend WithEvents NodeConnector7 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle9 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents TabControlPanel11 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tiMaterials As DevComponents.DotNetBar.TabItem
        Friend WithEvents adtMaterials As DevComponents.AdvTree.AdvTree
        Friend WithEvents colMaterialName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colMaterialQuantity As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector8 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle10 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents TabControlPanel12 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents adtComponents As DevComponents.AdvTree.AdvTree
        Friend WithEvents colComponentName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colComponentQuantity As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector9 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle11 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents tiComponent As DevComponents.DotNetBar.TabItem
        Friend WithEvents adtBrowse As DevComponents.AdvTree.AdvTree
        Friend WithEvents colBrowserHeading As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector10 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle12 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents btnNavRecent As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnNavForward As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnNavBack As DevComponents.DotNetBar.ButtonX
        Friend WithEvents cboPilots As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents btnRequisition As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnAddSkills As DevComponents.DotNetBar.ButtonX
        Friend WithEvents TabControlPanel13 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents adtCategories As DevComponents.AdvTree.AdvTree
        Friend WithEvents colCategoryID As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colCategoryName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector11 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle13 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents tabCategories As DevComponents.DotNetBar.TabItem
        Friend WithEvents TabControlPanel14 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents adtGroups As DevComponents.AdvTree.AdvTree
        Friend WithEvents ColumnHeader1 As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents ColumnHeader2 As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector12 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle14 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents tabGroups As DevComponents.DotNetBar.TabItem
        Friend WithEvents TabControlPanel15 As DevComponents.DotNetBar.TabControlPanel
        Friend WithEvents tiTraits As DevComponents.DotNetBar.TabItem
        Friend WithEvents lblTraits As DevComponents.DotNetBar.LabelX
    End Class
End NameSpace