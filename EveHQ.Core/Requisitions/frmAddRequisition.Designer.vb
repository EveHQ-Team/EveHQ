Namespace Requisitions
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmAddRequisition
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
            Me.panelReq = New DevComponents.DotNetBar.PanelEx()
            Me.lvwOrders = New DevComponents.DotNetBar.Controls.ListViewEx()
            Me.colItemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colItemQuantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.lblMultiplier = New DevComponents.DotNetBar.LabelX()
            Me.nudMultiplier = New DevComponents.Editors.IntegerInput()
            Me.cboReqName = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
            Me.btnAccept = New DevComponents.DotNetBar.ButtonX()
            Me.lblSource = New DevComponents.DotNetBar.LabelX()
            Me.lblSourceLbl = New DevComponents.DotNetBar.LabelX()
            Me.cboRequestor = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblRequestor = New DevComponents.DotNetBar.LabelX()
            Me.lblReqName = New DevComponents.DotNetBar.LabelX()
            Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
            Me.panelReq.SuspendLayout()
            CType(Me.nudMultiplier, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panelReq
            '
            Me.panelReq.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelReq.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelReq.Controls.Add(Me.lvwOrders)
            Me.panelReq.Controls.Add(Me.lblMultiplier)
            Me.panelReq.Controls.Add(Me.nudMultiplier)
            Me.panelReq.Controls.Add(Me.cboReqName)
            Me.panelReq.Controls.Add(Me.btnCancel)
            Me.panelReq.Controls.Add(Me.btnAccept)
            Me.panelReq.Controls.Add(Me.lblSource)
            Me.panelReq.Controls.Add(Me.lblSourceLbl)
            Me.panelReq.Controls.Add(Me.cboRequestor)
            Me.panelReq.Controls.Add(Me.lblRequestor)
            Me.panelReq.Controls.Add(Me.lblReqName)
            Me.panelReq.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelReq.Location = New System.Drawing.Point(0, 0)
            Me.panelReq.Name = "panelReq"
            Me.panelReq.Size = New System.Drawing.Size(359, 476)
            Me.panelReq.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelReq.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelReq.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelReq.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelReq.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelReq.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelReq.Style.GradientAngle = 90
            Me.panelReq.TabIndex = 0
            '
            'lvwOrders
            '
            '
            '
            '
            Me.lvwOrders.Border.Class = "ListViewBorder"
            Me.lvwOrders.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lvwOrders.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colItemName, Me.colItemQuantity})
            Me.lvwOrders.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lvwOrders.FullRowSelect = True
            Me.lvwOrders.GridLines = True
            Me.lvwOrders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
            Me.lvwOrders.Location = New System.Drawing.Point(0, 166)
            Me.lvwOrders.Name = "lvwOrders"
            Me.lvwOrders.Size = New System.Drawing.Size(359, 310)
            Me.lvwOrders.TabIndex = 5
            Me.lvwOrders.UseCompatibleStateImageBehavior = False
            Me.lvwOrders.View = System.Windows.Forms.View.Details
            '
            'colItemName
            '
            Me.colItemName.Text = "Item"
            Me.colItemName.Width = 230
            '
            'colItemQuantity
            '
            Me.colItemQuantity.Text = "Qty"
            Me.colItemQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.colItemQuantity.Width = 100
            '
            'lblMultiplier
            '
            '
            '
            '
            Me.lblMultiplier.BackgroundStyle.Class = ""
            Me.lblMultiplier.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblMultiplier.Location = New System.Drawing.Point(12, 99)
            Me.lblMultiplier.Name = "lblMultiplier"
            Me.lblMultiplier.Size = New System.Drawing.Size(75, 23)
            Me.lblMultiplier.TabIndex = 8
            Me.lblMultiplier.Text = "Multiplier:"
            '
            'nudMultiplier
            '
            '
            '
            '
            Me.nudMultiplier.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.nudMultiplier.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.nudMultiplier.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.Highlighter1.SetHighlightOnFocus(Me.nudMultiplier, True)
            Me.nudMultiplier.Location = New System.Drawing.Point(118, 99)
            Me.nudMultiplier.MaxValue = 100000
            Me.nudMultiplier.MinValue = 1
            Me.nudMultiplier.Name = "nudMultiplier"
            Me.nudMultiplier.ShowUpDown = True
            Me.nudMultiplier.Size = New System.Drawing.Size(88, 21)
            Me.nudMultiplier.TabIndex = 2
            Me.nudMultiplier.Value = 1
            '
            'cboReqName
            '
            Me.cboReqName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cboReqName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cboReqName.DisplayMember = "Text"
            Me.cboReqName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboReqName.FormattingEnabled = True
            Me.Highlighter1.SetHighlightOnFocus(Me.cboReqName, True)
            Me.cboReqName.ItemHeight = 15
            Me.cboReqName.Location = New System.Drawing.Point(118, 14)
            Me.cboReqName.Name = "cboReqName"
            Me.cboReqName.Size = New System.Drawing.Size(229, 21)
            Me.cboReqName.Sorted = True
            Me.cboReqName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboReqName.TabIndex = 0
            Me.cboReqName.WatermarkColor = System.Drawing.Color.Silver
            Me.cboReqName.WatermarkFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboReqName.WatermarkText = "Select or enter a requisition name..."
            '
            'btnCancel
            '
            Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Highlighter1.SetHighlightOnFocus(Me.btnCancel, True)
            Me.btnCancel.Location = New System.Drawing.Point(272, 137)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnCancel.TabIndex = 4
            Me.btnCancel.Text = "Cancel"
            '
            'btnAccept
            '
            Me.btnAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.Highlighter1.SetHighlightOnFocus(Me.btnAccept, True)
            Me.btnAccept.Location = New System.Drawing.Point(191, 137)
            Me.btnAccept.Name = "btnAccept"
            Me.btnAccept.Size = New System.Drawing.Size(75, 23)
            Me.btnAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnAccept.TabIndex = 3
            Me.btnAccept.Text = "Accept"
            '
            'lblSource
            '
            '
            '
            '
            Me.lblSource.BackgroundStyle.Class = ""
            Me.lblSource.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblSource.Location = New System.Drawing.Point(118, 70)
            Me.lblSource.Name = "lblSource"
            Me.lblSource.Size = New System.Drawing.Size(75, 23)
            Me.lblSource.TabIndex = 5
            Me.lblSource.Text = "<Unknown>"
            '
            'lblSourceLbl
            '
            '
            '
            '
            Me.lblSourceLbl.BackgroundStyle.Class = ""
            Me.lblSourceLbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblSourceLbl.Location = New System.Drawing.Point(12, 70)
            Me.lblSourceLbl.Name = "lblSourceLbl"
            Me.lblSourceLbl.Size = New System.Drawing.Size(75, 23)
            Me.lblSourceLbl.TabIndex = 4
            Me.lblSourceLbl.Text = "Source:"
            '
            'cboRequestor
            '
            Me.cboRequestor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cboRequestor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cboRequestor.DisplayMember = "Text"
            Me.cboRequestor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboRequestor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboRequestor.FormattingEnabled = True
            Me.Highlighter1.SetHighlightOnFocus(Me.cboRequestor, True)
            Me.cboRequestor.ItemHeight = 15
            Me.cboRequestor.Location = New System.Drawing.Point(118, 43)
            Me.cboRequestor.Name = "cboRequestor"
            Me.cboRequestor.Size = New System.Drawing.Size(229, 21)
            Me.cboRequestor.Sorted = True
            Me.cboRequestor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboRequestor.TabIndex = 1
            Me.cboRequestor.WatermarkColor = System.Drawing.Color.Silver
            Me.cboRequestor.WatermarkFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboRequestor.WatermarkText = "Select a requestor..."
            '
            'lblRequestor
            '
            '
            '
            '
            Me.lblRequestor.BackgroundStyle.Class = ""
            Me.lblRequestor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblRequestor.Location = New System.Drawing.Point(12, 41)
            Me.lblRequestor.Name = "lblRequestor"
            Me.lblRequestor.Size = New System.Drawing.Size(75, 23)
            Me.lblRequestor.TabIndex = 1
            Me.lblRequestor.Text = "Requestor:"
            '
            'lblReqName
            '
            '
            '
            '
            Me.lblReqName.BackgroundStyle.Class = ""
            Me.lblReqName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblReqName.Location = New System.Drawing.Point(12, 12)
            Me.lblReqName.Name = "lblReqName"
            Me.lblReqName.Size = New System.Drawing.Size(100, 23)
            Me.lblReqName.TabIndex = 0
            Me.lblReqName.Text = "Requisition Name:"
            '
            'Highlighter1
            '
            Me.Highlighter1.ContainerControl = Me
            Me.Highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Green
            
            '
            'frmAddRequisition
            '
            Me.AcceptButton = Me.btnAccept
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(359, 476)
            Me.Controls.Add(Me.panelReq)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmAddRequisition"
            Me.ShowIcon = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Add New Requisition"
            Me.panelReq.ResumeLayout(False)
            CType(Me.nudMultiplier, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents panelReq As DevComponents.DotNetBar.PanelEx
        Friend WithEvents lblRequestor As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblReqName As DevComponents.DotNetBar.LabelX
        Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
        Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
        Friend WithEvents btnAccept As DevComponents.DotNetBar.ButtonX
        Friend WithEvents lblSource As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblSourceLbl As DevComponents.DotNetBar.LabelX
        Friend WithEvents cboRequestor As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lvwOrders As DevComponents.DotNetBar.Controls.ListViewEx
        Friend WithEvents colItemName As System.Windows.Forms.ColumnHeader
        Friend WithEvents colItemQuantity As System.Windows.Forms.ColumnHeader
        Friend WithEvents cboReqName As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblMultiplier As DevComponents.DotNetBar.LabelX
        Friend WithEvents nudMultiplier As DevComponents.Editors.IntegerInput
    End Class
End Namespace