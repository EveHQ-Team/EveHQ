Namespace Requisitions
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmEditRequisition
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
            Me.adtOrders = New DevComponents.AdvTree.AdvTree()
            Me.colItemName = New DevComponents.AdvTree.ColumnHeader()
            Me.colItemQuantity = New DevComponents.AdvTree.ColumnHeader()
            Me.colItemOriginator = New DevComponents.AdvTree.ColumnHeader()
            Me.colItemDate = New DevComponents.AdvTree.ColumnHeader()
            Me.Node1 = New DevComponents.AdvTree.Node()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me.panelReq = New DevComponents.DotNetBar.PanelEx()
            Me.lblMultiplier = New DevComponents.DotNetBar.LabelX()
            Me.nudMultiplier = New DevComponents.Editors.IntegerInput()
            Me.btnRemoveItem = New DevComponents.DotNetBar.ButtonX()
            Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
            Me.btnRevert = New DevComponents.DotNetBar.ButtonX()
            Me.btnConfirm = New DevComponents.DotNetBar.ButtonX()
            Me.btnAddItem = New DevComponents.DotNetBar.ButtonX()
            Me.cboRequestor = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.lblRequestor = New DevComponents.DotNetBar.LabelX()
            Me.txtReqName = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.lblReqName = New DevComponents.DotNetBar.LabelX()
            CType(Me.adtOrders, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelReq.SuspendLayout()
            CType(Me.nudMultiplier, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'adtOrders
            '
            Me.adtOrders.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtOrders.AllowDrop = True
            Me.adtOrders.AlternateRowColor = System.Drawing.Color.Honeydew
            Me.adtOrders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                          Or System.Windows.Forms.AnchorStyles.Left) _
                                         Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.adtOrders.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtOrders.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtOrders.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtOrders.Columns.Add(Me.colItemName)
            Me.adtOrders.Columns.Add(Me.colItemQuantity)
            Me.adtOrders.Columns.Add(Me.colItemOriginator)
            Me.adtOrders.Columns.Add(Me.colItemDate)
            
            Me.adtOrders.Location = New System.Drawing.Point(0, 119)
            Me.adtOrders.MultiSelect = True
            Me.adtOrders.Name = "adtOrders"
            Me.adtOrders.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node1})
            Me.adtOrders.NodesConnector = Me.NodeConnector1
            Me.adtOrders.NodeStyle = Me.ElementStyle1
            Me.adtOrders.PathSeparator = ";"
            Me.adtOrders.Size = New System.Drawing.Size(817, 362)
            Me.adtOrders.Styles.Add(Me.ElementStyle1)
            Me.adtOrders.TabIndex = 0
            Me.adtOrders.Text = "AdvTree1"
            '
            'colItemName
            '
            Me.colItemName.Name = "colItemName"
            Me.colItemName.SortingEnabled = False
            Me.colItemName.Text = "Item Name"
            Me.colItemName.Width.Absolute = 350
            '
            'colItemQuantity
            '
            Me.colItemQuantity.Name = "colItemQuantity"
            Me.colItemQuantity.SortingEnabled = False
            Me.colItemQuantity.Text = "Quantity"
            Me.colItemQuantity.Width.Absolute = 100
            '
            'colItemOriginator
            '
            Me.colItemOriginator.Name = "colItemOriginator"
            Me.colItemOriginator.SortingEnabled = False
            Me.colItemOriginator.Text = "Originator"
            Me.colItemOriginator.Width.Absolute = 150
            '
            'colItemDate
            '
            Me.colItemDate.Name = "colItemDate"
            Me.colItemDate.SortingEnabled = False
            Me.colItemDate.Text = "Date Created"
            Me.colItemDate.Width.Absolute = 150
            '
            'Node1
            '
            Me.Node1.Name = "Node1"
            Me.Node1.Text = "Node1"
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
            'panelReq
            '
            Me.panelReq.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelReq.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelReq.Controls.Add(Me.lblMultiplier)
            Me.panelReq.Controls.Add(Me.nudMultiplier)
            Me.panelReq.Controls.Add(Me.adtOrders)
            Me.panelReq.Controls.Add(Me.btnRemoveItem)
            Me.panelReq.Controls.Add(Me.btnCancel)
            Me.panelReq.Controls.Add(Me.btnRevert)
            Me.panelReq.Controls.Add(Me.btnConfirm)
            Me.panelReq.Controls.Add(Me.btnAddItem)
            Me.panelReq.Controls.Add(Me.cboRequestor)
            Me.panelReq.Controls.Add(Me.lblRequestor)
            Me.panelReq.Controls.Add(Me.txtReqName)
            Me.panelReq.Controls.Add(Me.lblReqName)
            Me.panelReq.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelReq.Location = New System.Drawing.Point(0, 0)
            Me.panelReq.Name = "panelReq"
            Me.panelReq.Size = New System.Drawing.Size(817, 512)
            Me.panelReq.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelReq.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelReq.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelReq.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelReq.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelReq.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelReq.Style.GradientAngle = 90
            Me.panelReq.TabIndex = 1
            '
            'lblMultiplier
            '
            Me.lblMultiplier.AutoSize = True
            '
            '
            '
            Me.lblMultiplier.BackgroundStyle.Class = ""
            Me.lblMultiplier.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblMultiplier.Location = New System.Drawing.Point(395, 88)
            Me.lblMultiplier.Name = "lblMultiplier"
            Me.lblMultiplier.Size = New System.Drawing.Size(51, 16)
            Me.lblMultiplier.TabIndex = 10
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
            Me.nudMultiplier.Location = New System.Drawing.Point(452, 83)
            Me.nudMultiplier.MaxValue = 100000
            Me.nudMultiplier.MinValue = 1
            Me.nudMultiplier.Name = "nudMultiplier"
            Me.nudMultiplier.ShowUpDown = True
            Me.nudMultiplier.Size = New System.Drawing.Size(88, 21)
            Me.nudMultiplier.TabIndex = 9
            Me.nudMultiplier.Value = 1
            '
            'btnRemoveItem
            '
            Me.btnRemoveItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnRemoveItem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnRemoveItem.Location = New System.Drawing.Point(706, 83)
            Me.btnRemoveItem.Name = "btnRemoveItem"
            Me.btnRemoveItem.Size = New System.Drawing.Size(99, 23)
            Me.btnRemoveItem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnRemoveItem.TabIndex = 8
            Me.btnRemoveItem.Text = "Remove Item"
            '
            'btnCancel
            '
            Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnCancel.Location = New System.Drawing.Point(714, 485)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(100, 23)
            Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnCancel.TabIndex = 7
            Me.btnCancel.Text = "Cancel"
            '
            'btnRevert
            '
            Me.btnRevert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnRevert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnRevert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnRevert.Location = New System.Drawing.Point(3, 485)
            Me.btnRevert.Name = "btnRevert"
            Me.btnRevert.Size = New System.Drawing.Size(100, 23)
            Me.btnRevert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnRevert.TabIndex = 6
            Me.btnRevert.Text = "Revert Changes"
            '
            'btnConfirm
            '
            Me.btnConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnConfirm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnConfirm.Location = New System.Drawing.Point(608, 485)
            Me.btnConfirm.Name = "btnConfirm"
            Me.btnConfirm.Size = New System.Drawing.Size(100, 23)
            Me.btnConfirm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnConfirm.TabIndex = 5
            Me.btnConfirm.Text = "Save Requisition"
            '
            'btnAddItem
            '
            Me.btnAddItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnAddItem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnAddItem.Location = New System.Drawing.Point(706, 54)
            Me.btnAddItem.Name = "btnAddItem"
            Me.btnAddItem.Size = New System.Drawing.Size(99, 23)
            Me.btnAddItem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnAddItem.TabIndex = 4
            Me.btnAddItem.Text = "Add Item"
            '
            'cboRequestor
            '
            Me.cboRequestor.DisplayMember = "Text"
            Me.cboRequestor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboRequestor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboRequestor.FormattingEnabled = True
            Me.cboRequestor.ItemHeight = 15
            Me.cboRequestor.Location = New System.Drawing.Point(12, 83)
            Me.cboRequestor.Name = "cboRequestor"
            Me.cboRequestor.Size = New System.Drawing.Size(258, 21)
            Me.cboRequestor.Sorted = True
            Me.cboRequestor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboRequestor.TabIndex = 3
            Me.cboRequestor.WatermarkColor = System.Drawing.Color.Silver
            Me.cboRequestor.WatermarkFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboRequestor.WatermarkText = "Select Requestor..."
            '
            'lblRequestor
            '
            Me.lblRequestor.AutoSize = True
            '
            '
            '
            Me.lblRequestor.BackgroundStyle.Class = ""
            Me.lblRequestor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblRequestor.Location = New System.Drawing.Point(12, 61)
            Me.lblRequestor.Name = "lblRequestor"
            Me.lblRequestor.Size = New System.Drawing.Size(56, 16)
            Me.lblRequestor.TabIndex = 2
            Me.lblRequestor.Text = "Requestor:"
            '
            'txtReqName
            '
            '
            '
            '
            Me.txtReqName.Border.Class = "TextBoxBorder"
            Me.txtReqName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.txtReqName.Location = New System.Drawing.Point(12, 34)
            Me.txtReqName.Name = "txtReqName"
            Me.txtReqName.Size = New System.Drawing.Size(258, 21)
            Me.txtReqName.TabIndex = 1
            Me.txtReqName.WatermarkColor = System.Drawing.Color.Silver
            Me.txtReqName.WatermarkFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtReqName.WatermarkText = "Enter Requsition Name..."
            '
            'lblReqName
            '
            Me.lblReqName.AutoSize = True
            '
            '
            '
            Me.lblReqName.BackgroundStyle.Class = ""
            Me.lblReqName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblReqName.Location = New System.Drawing.Point(12, 12)
            Me.lblReqName.Name = "lblReqName"
            Me.lblReqName.Size = New System.Drawing.Size(91, 16)
            Me.lblReqName.TabIndex = 0
            Me.lblReqName.Text = "Requisition Name:"
            '
            'frmEditRequisition
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(817, 512)
            Me.Controls.Add(Me.panelReq)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Name = "frmEditRequisition"
            Me.ShowIcon = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Edit Requisition"
            CType(Me.adtOrders, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelReq.ResumeLayout(False)
            Me.panelReq.PerformLayout()
            CType(Me.nudMultiplier, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents adtOrders As DevComponents.AdvTree.AdvTree
        Friend WithEvents colItemName As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colItemQuantity As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colItemOriginator As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents Node1 As DevComponents.AdvTree.Node
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents panelReq As DevComponents.DotNetBar.PanelEx
        Friend WithEvents txtReqName As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents lblReqName As DevComponents.DotNetBar.LabelX
        Friend WithEvents cboRequestor As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblRequestor As DevComponents.DotNetBar.LabelX
        Friend WithEvents btnAddItem As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnRemoveItem As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnRevert As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnConfirm As DevComponents.DotNetBar.ButtonX
        Friend WithEvents colItemDate As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents lblMultiplier As DevComponents.DotNetBar.LabelX
        Friend WithEvents nudMultiplier As DevComponents.Editors.IntegerInput
    End Class
End NameSpace