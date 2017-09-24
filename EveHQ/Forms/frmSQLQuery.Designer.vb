Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmSQLQuery
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSQLQuery))
            Me.lvwQueries = New DevComponents.DotNetBar.Controls.ListViewEx()
            Me.colQueryName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.panelText = New DevComponents.DotNetBar.PanelEx()
            Me.lblRowCount = New DevComponents.DotNetBar.LabelX()
            Me.lblQueryAmended = New DevComponents.DotNetBar.LabelX()
            Me.txtQuery = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.lblQueryText = New DevComponents.DotNetBar.LabelX()
            Me.ExpandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.dgvQuery = New System.Windows.Forms.DataGridView()
            Me.rmcSQLQuery = New DevComponents.DotNetBar.RibbonBarMergeContainer()
            Me.rbData = New DevComponents.DotNetBar.RibbonBar()
            Me.btnExportData = New DevComponents.DotNetBar.ButtonItem()
            Me.btnCopyData = New DevComponents.DotNetBar.ButtonItem()
            Me.rbQuery = New DevComponents.DotNetBar.RibbonBar()
            Me.btnExecute = New DevComponents.DotNetBar.ButtonItem()
            Me.btnSave = New DevComponents.DotNetBar.ButtonItem()
            Me.rbQueries = New DevComponents.DotNetBar.RibbonBar()
            Me.btnNew = New DevComponents.DotNetBar.ButtonItem()
            Me.btnRename = New DevComponents.DotNetBar.ButtonItem()
            Me.btnDelete = New DevComponents.DotNetBar.ButtonItem()
            Me.panelText.SuspendLayout()
            CType(Me.dgvQuery, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.rmcSQLQuery.SuspendLayout()
            Me.SuspendLayout()
            '
            'lvwQueries
            '
            '
            '
            '
            Me.lvwQueries.Border.Class = "ListViewBorder"
            Me.lvwQueries.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lvwQueries.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colQueryName})
            Me.lvwQueries.Dock = System.Windows.Forms.DockStyle.Left
            Me.lvwQueries.FullRowSelect = True
            Me.lvwQueries.GridLines = True
            Me.lvwQueries.Location = New System.Drawing.Point(0, 0)
            Me.lvwQueries.Name = "lvwQueries"
            Me.lvwQueries.Size = New System.Drawing.Size(227, 679)
            Me.lvwQueries.TabIndex = 0
            Me.lvwQueries.UseCompatibleStateImageBehavior = False
            Me.lvwQueries.View = System.Windows.Forms.View.Details
            '
            'colQueryName
            '
            Me.colQueryName.Text = "Saved Queries"
            Me.colQueryName.Width = 200
            '
            'panelText
            '
            Me.panelText.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelText.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelText.Controls.Add(Me.lblRowCount)
            Me.panelText.Controls.Add(Me.lblQueryAmended)
            Me.panelText.Controls.Add(Me.txtQuery)
            Me.panelText.Controls.Add(Me.lblQueryText)
            Me.panelText.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelText.Location = New System.Drawing.Point(227, 0)
            Me.panelText.Name = "panelText"
            Me.panelText.Size = New System.Drawing.Size(1081, 174)
            Me.panelText.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelText.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelText.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelText.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelText.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelText.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelText.Style.GradientAngle = 90
            Me.panelText.TabIndex = 1
            '
            'lblRowCount
            '
            Me.lblRowCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblRowCount.AutoSize = True
            '
            '
            '
            Me.lblRowCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblRowCount.Location = New System.Drawing.Point(6, 155)
            Me.lblRowCount.Name = "lblRowCount"
            Me.lblRowCount.Size = New System.Drawing.Size(92, 16)
            Me.lblRowCount.TabIndex = 10
            Me.lblRowCount.Text = "Record Count: n/a"
            '
            'lblQueryAmended
            '
            Me.lblQueryAmended.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblQueryAmended.AutoSize = True
            '
            '
            '
            Me.lblQueryAmended.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblQueryAmended.ForeColor = System.Drawing.Color.Red
            Me.lblQueryAmended.Location = New System.Drawing.Point(989, 12)
            Me.lblQueryAmended.Name = "lblQueryAmended"
            Me.lblQueryAmended.Size = New System.Drawing.Size(85, 16)
            Me.lblQueryAmended.TabIndex = 7
            Me.lblQueryAmended.Text = "Query Not Saved"
            Me.lblQueryAmended.Visible = False
            '
            'txtQuery
            '
            Me.txtQuery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.txtQuery.Border.Class = "TextBoxBorder"
            Me.txtQuery.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.txtQuery.Location = New System.Drawing.Point(6, 34)
            Me.txtQuery.Multiline = True
            Me.txtQuery.Name = "txtQuery"
            Me.txtQuery.Size = New System.Drawing.Size(1068, 118)
            Me.txtQuery.TabIndex = 1
            Me.txtQuery.WatermarkColor = System.Drawing.Color.Silver
            Me.txtQuery.WatermarkText = "Enter SQL to process here..."
            '
            'lblQueryText
            '
            Me.lblQueryText.AutoSize = True
            '
            '
            '
            Me.lblQueryText.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblQueryText.Location = New System.Drawing.Point(6, 10)
            Me.lblQueryText.Name = "lblQueryText"
            Me.lblQueryText.Size = New System.Drawing.Size(130, 16)
            Me.lblQueryText.TabIndex = 0
            Me.lblQueryText.Text = "SQL Query String: <new>"
            '
            'ExpandableSplitter1
            '
            Me.ExpandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.ExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandableSplitter1.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandableSplitter1.Expandable = False
            Me.ExpandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.ExpandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ExpandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ExpandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ExpandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer))
            Me.ExpandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.ExpandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.ExpandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.ExpandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.ExpandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ExpandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            Me.ExpandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ExpandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter1.Location = New System.Drawing.Point(227, 174)
            Me.ExpandableSplitter1.Name = "ExpandableSplitter1"
            Me.ExpandableSplitter1.Size = New System.Drawing.Size(1081, 6)
            Me.ExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.ExpandableSplitter1.TabIndex = 2
            Me.ExpandableSplitter1.TabStop = False
            '
            'dgvQuery
            '
            Me.dgvQuery.AllowUserToAddRows = False
            Me.dgvQuery.AllowUserToDeleteRows = False
            Me.dgvQuery.AllowUserToOrderColumns = True
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
            Me.dgvQuery.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvQuery.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvQuery.Location = New System.Drawing.Point(227, 180)
            Me.dgvQuery.Name = "dgvQuery"
            Me.dgvQuery.ReadOnly = True
            Me.dgvQuery.RowHeadersVisible = False
            Me.dgvQuery.Size = New System.Drawing.Size(1081, 499)
            Me.dgvQuery.TabIndex = 3
            '
            'rmcSQLQuery
            '
            Me.rmcSQLQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.rmcSQLQuery.Controls.Add(Me.rbData)
            Me.rmcSQLQuery.Controls.Add(Me.rbQuery)
            Me.rmcSQLQuery.Controls.Add(Me.rbQueries)
            Me.rmcSQLQuery.Location = New System.Drawing.Point(427, 264)
            Me.rmcSQLQuery.Name = "rmcSQLQuery"
            Me.rmcSQLQuery.RibbonTabText = "SQL Query"
            Me.rmcSQLQuery.Size = New System.Drawing.Size(762, 100)
            '
            '
            '
            Me.rmcSQLQuery.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.rmcSQLQuery.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.rmcSQLQuery.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.rmcSQLQuery.TabIndex = 4
            Me.rmcSQLQuery.Visible = False
            '
            'rbData
            '
            Me.rbData.AutoOverflowEnabled = True
            '
            '
            '
            Me.rbData.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.rbData.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.rbData.ContainerControlProcessDialogKey = True
            Me.rbData.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnExportData, Me.btnCopyData})
            
            Me.rbData.Location = New System.Drawing.Point(383, 0)
            Me.rbData.Name = "rbData"
            Me.rbData.Size = New System.Drawing.Size(144, 100)
            Me.rbData.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.rbData.TabIndex = 2
            Me.rbData.Text = "Data"
            '
            '
            '
            Me.rbData.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.rbData.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            'btnExportData
            '
            Me.btnExportData.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.btnExportData.Name = "btnExportData"
            Me.btnExportData.SubItemsExpandWidth = 14
            Me.btnExportData.Text = "Export Data"
            '
            'btnCopyData
            '
            Me.btnCopyData.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.btnCopyData.Name = "btnCopyData"
            Me.btnCopyData.SubItemsExpandWidth = 14
            Me.btnCopyData.Text = "Copy Data<br />to Clipboard"
            '
            'rbQuery
            '
            Me.rbQuery.AutoOverflowEnabled = True
            '
            '
            '
            Me.rbQuery.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.rbQuery.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.rbQuery.ContainerControlProcessDialogKey = True
            Me.rbQuery.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnExecute, Me.btnSave})
            
            Me.rbQuery.Location = New System.Drawing.Point(228, 0)
            Me.rbQuery.Name = "rbQuery"
            Me.rbQuery.Size = New System.Drawing.Size(153, 100)
            Me.rbQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.rbQuery.TabIndex = 1
            Me.rbQuery.Text = "Query"
            '
            '
            '
            Me.rbQuery.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.rbQuery.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            'btnExecute
            '
            Me.btnExecute.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.btnExecute.Name = "btnExecute"
            Me.btnExecute.SubItemsExpandWidth = 14
            Me.btnExecute.Text = "Execute Query"
            '
            'btnSave
            '
            Me.btnSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.btnSave.Name = "btnSave"
            Me.btnSave.SubItemsExpandWidth = 14
            Me.btnSave.Text = "Save Query"
            '
            'rbQueries
            '
            Me.rbQueries.AutoOverflowEnabled = True
            '
            '
            '
            Me.rbQueries.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.rbQueries.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.rbQueries.ContainerControlProcessDialogKey = True
            Me.rbQueries.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnNew, Me.btnRename, Me.btnDelete})
            
            Me.rbQueries.Location = New System.Drawing.Point(0, 0)
            Me.rbQueries.Name = "rbQueries"
            Me.rbQueries.Size = New System.Drawing.Size(226, 100)
            Me.rbQueries.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.rbQueries.TabIndex = 0
            Me.rbQueries.Text = "Queries"
            '
            '
            '
            Me.rbQueries.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.rbQueries.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            'btnNew
            '
            Me.btnNew.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.btnNew.Name = "btnNew"
            Me.btnNew.SubItemsExpandWidth = 14
            Me.btnNew.Text = "New Query"
            '
            'btnRename
            '
            Me.btnRename.Enabled = False
            Me.btnRename.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.btnRename.Name = "btnRename"
            Me.btnRename.SubItemsExpandWidth = 14
            Me.btnRename.Text = "Rename Query"
            '
            'btnDelete
            '
            Me.btnDelete.Enabled = False
            Me.btnDelete.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.SubItemsExpandWidth = 14
            Me.btnDelete.Text = "Delete Query"
            '
            'FrmSQLQuery
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1308, 679)
            Me.Controls.Add(Me.rmcSQLQuery)
            Me.Controls.Add(Me.dgvQuery)
            Me.Controls.Add(Me.ExpandableSplitter1)
            Me.Controls.Add(Me.panelText)
            Me.Controls.Add(Me.lvwQueries)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmSQLQuery"
            Me.Text = "EveHQ Database Query Tool"
            Me.panelText.ResumeLayout(False)
            Me.panelText.PerformLayout()
            CType(Me.dgvQuery, System.ComponentModel.ISupportInitialize).EndInit()
            Me.rmcSQLQuery.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lvwQueries As DevComponents.DotNetBar.Controls.ListViewEx
        Friend WithEvents colQueryName As System.Windows.Forms.ColumnHeader
        Friend WithEvents panelText As DevComponents.DotNetBar.PanelEx
        Friend WithEvents txtQuery As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents lblQueryText As DevComponents.DotNetBar.LabelX
        Friend WithEvents ExpandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
        Friend WithEvents dgvQuery As System.Windows.Forms.DataGridView
        Friend WithEvents lblQueryAmended As DevComponents.DotNetBar.LabelX
        Friend WithEvents rmcSQLQuery As DevComponents.DotNetBar.RibbonBarMergeContainer
        Friend WithEvents rbQueries As DevComponents.DotNetBar.RibbonBar
        Friend WithEvents btnNew As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents btnRename As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents rbData As DevComponents.DotNetBar.RibbonBar
        Friend WithEvents btnExportData As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents btnCopyData As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents rbQuery As DevComponents.DotNetBar.RibbonBar
        Friend WithEvents btnExecute As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents lblRowCount As DevComponents.DotNetBar.LabelX
    End Class
End NameSpace