<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModifyPrices
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
        Me.panelPrices = New DevComponents.DotNetBar.PanelEx()
        Me.btnAccept = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.lblHowToEdit = New System.Windows.Forms.Label()
        Me.adtPrices = New DevComponents.AdvTree.AdvTree()
        Me.colItemName = New DevComponents.AdvTree.ColumnHeader()
        Me.colMarketPrice = New DevComponents.AdvTree.ColumnHeader()
        Me.colCustomPrice = New DevComponents.AdvTree.ColumnHeader()
        Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
        Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
        Me.panelPrices.SuspendLayout()
        CType(Me.adtPrices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelPrices
        '
        Me.panelPrices.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelPrices.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panelPrices.Controls.Add(Me.btnAccept)
        Me.panelPrices.Controls.Add(Me.btnCancel)
        Me.panelPrices.Controls.Add(Me.lblHowToEdit)
        Me.panelPrices.Controls.Add(Me.adtPrices)
        Me.panelPrices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelPrices.Location = New System.Drawing.Point(0, 0)
        Me.panelPrices.Name = "panelPrices"
        Me.panelPrices.Size = New System.Drawing.Size(644, 476)
        Me.panelPrices.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelPrices.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panelPrices.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panelPrices.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelPrices.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelPrices.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelPrices.Style.GradientAngle = 90
        Me.panelPrices.TabIndex = 0
        '
        'btnAccept
        '
        Me.btnAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAccept.Location = New System.Drawing.Point(566, 450)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAccept.TabIndex = 3
        Me.btnAccept.Text = "Accept"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Location = New System.Drawing.Point(485, 450)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        '
        'lblHowToEdit
        '
        Me.lblHowToEdit.AutoSize = True
        Me.lblHowToEdit.Location = New System.Drawing.Point(12, 9)
        Me.lblHowToEdit.Name = "lblHowToEdit"
        Me.lblHowToEdit.Size = New System.Drawing.Size(305, 13)
        Me.lblHowToEdit.TabIndex = 1
        Me.lblHowToEdit.Text = "Highlight a price and press F2 or double-click to edit the value."
        '
        'adtPrices
        '
        Me.adtPrices.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.adtPrices.AllowDrop = True
        Me.adtPrices.AllowUserToResizeColumns = False
        Me.adtPrices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.adtPrices.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.adtPrices.BackgroundStyle.Class = "TreeBorderKey"
        Me.adtPrices.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.adtPrices.CellEdit = True
        Me.adtPrices.Columns.Add(Me.colItemName)
        Me.adtPrices.Columns.Add(Me.colMarketPrice)
        Me.adtPrices.Columns.Add(Me.colCustomPrice)
        Me.adtPrices.DragDropEnabled = False
        Me.adtPrices.DragDropNodeCopyEnabled = False
        Me.adtPrices.ExpandWidth = 0
        Me.adtPrices.GridRowLines = True
        
        Me.adtPrices.Location = New System.Drawing.Point(3, 34)
        Me.adtPrices.Name = "adtPrices"
        Me.adtPrices.NodesConnector = Me.NodeConnector1
        Me.adtPrices.NodeStyle = Me.ElementStyle1
        Me.adtPrices.PathSeparator = ";"
        Me.adtPrices.SelectionPerCell = True
        Me.adtPrices.Size = New System.Drawing.Size(638, 410)
        Me.adtPrices.Styles.Add(Me.ElementStyle1)
        Me.adtPrices.TabIndex = 0
        Me.adtPrices.Text = "AdvTree1"
        '
        'colItemName
        '
        Me.colItemName.Editable = False
        Me.colItemName.Name = "colItemName"
        Me.colItemName.SortingEnabled = False
        Me.colItemName.Text = "Item Name"
        Me.colItemName.Width.Absolute = 300
        '
        'colMarketPrice
        '
        Me.colMarketPrice.EditorType = DevComponents.AdvTree.eCellEditorType.NumericDouble
        Me.colMarketPrice.Name = "colMarketPrice"
        Me.colMarketPrice.SortingEnabled = False
        Me.colMarketPrice.Text = "Market Price"
        Me.colMarketPrice.Width.Absolute = 150
        '
        'colCustomPrice
        '
        Me.colCustomPrice.EditorType = DevComponents.AdvTree.eCellEditorType.NumericDouble
        Me.colCustomPrice.Name = "colCustomPrice"
        Me.colCustomPrice.SortingEnabled = False
        Me.colCustomPrice.Text = "Custom Price"
        Me.colCustomPrice.Width.Absolute = 150
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
        'frmModifyPrices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 476)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelPrices)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmModifyPrices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modify Multiple Prices"
        Me.panelPrices.ResumeLayout(False)
        Me.panelPrices.PerformLayout()
        CType(Me.adtPrices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelPrices As DevComponents.DotNetBar.PanelEx
    Friend WithEvents adtPrices As DevComponents.AdvTree.AdvTree
    Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents colItemName As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents colMarketPrice As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents colCustomPrice As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents btnAccept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblHowToEdit As System.Windows.Forms.Label
End Class
