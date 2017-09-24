Namespace Requisitions
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmAddRequisitionItem
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
            Me.panelReq = New DevComponents.DotNetBar.PanelEx
            Me.btnCancel = New DevComponents.DotNetBar.ButtonX
            Me.btnAccept = New DevComponents.DotNetBar.ButtonX
            Me.lblSource = New DevComponents.DotNetBar.LabelX
            Me.lblSourceLbl = New DevComponents.DotNetBar.LabelX
            Me.nudQuantity = New DevComponents.Editors.IntegerInput
            Me.cboItems = New DevComponents.DotNetBar.Controls.ComboBoxEx
            Me.lblItemQuantity = New DevComponents.DotNetBar.LabelX
            Me.lblItemName = New DevComponents.DotNetBar.LabelX
            Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter
            Me.panelReq.SuspendLayout()
            CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panelReq
            '
            Me.panelReq.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelReq.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelReq.Controls.Add(Me.btnCancel)
            Me.panelReq.Controls.Add(Me.btnAccept)
            Me.panelReq.Controls.Add(Me.lblSource)
            Me.panelReq.Controls.Add(Me.lblSourceLbl)
            Me.panelReq.Controls.Add(Me.nudQuantity)
            Me.panelReq.Controls.Add(Me.cboItems)
            Me.panelReq.Controls.Add(Me.lblItemQuantity)
            Me.panelReq.Controls.Add(Me.lblItemName)
            Me.panelReq.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelReq.Location = New System.Drawing.Point(0, 0)
            Me.panelReq.Name = "panelReq"
            Me.panelReq.Size = New System.Drawing.Size(359, 137)
            Me.panelReq.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelReq.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelReq.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelReq.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelReq.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelReq.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelReq.Style.GradientAngle = 90
            Me.panelReq.TabIndex = 0
            '
            'btnCancel
            '
            Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Highlighter1.SetHighlightOnFocus(Me.btnCancel, True)
            Me.btnCancel.Location = New System.Drawing.Point(272, 105)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnCancel.TabIndex = 3
            Me.btnCancel.Text = "Cancel"
            '
            'btnAccept
            '
            Me.btnAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.Highlighter1.SetHighlightOnFocus(Me.btnAccept, True)
            Me.btnAccept.Location = New System.Drawing.Point(191, 105)
            Me.btnAccept.Name = "btnAccept"
            Me.btnAccept.Size = New System.Drawing.Size(75, 23)
            Me.btnAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnAccept.TabIndex = 2
            Me.btnAccept.Text = "Accept"
            '
            'lblSource
            '
            '
            '
            '
            Me.lblSource.BackgroundStyle.Class = ""
            Me.lblSource.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblSource.Location = New System.Drawing.Point(93, 70)
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
            'nudQuantity
            '
            '
            '
            '
            Me.nudQuantity.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.nudQuantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.nudQuantity.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.Highlighter1.SetHighlightOnFocus(Me.nudQuantity, True)
            Me.nudQuantity.Location = New System.Drawing.Point(93, 44)
            Me.nudQuantity.MaxValue = 1000000000
            Me.nudQuantity.MinValue = 1
            Me.nudQuantity.Name = "nudQuantity"
            Me.nudQuantity.ShowUpDown = True
            Me.nudQuantity.Size = New System.Drawing.Size(117, 21)
            Me.nudQuantity.TabIndex = 1
            Me.nudQuantity.Value = 1
            '
            'cboItems
            '
            Me.cboItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cboItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cboItems.DisplayMember = "Text"
            Me.cboItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboItems.FormattingEnabled = True
            Me.Highlighter1.SetHighlightOnFocus(Me.cboItems, True)
            Me.cboItems.ItemHeight = 15
            Me.cboItems.Location = New System.Drawing.Point(93, 15)
            Me.cboItems.Name = "cboItems"
            Me.cboItems.Size = New System.Drawing.Size(254, 21)
            Me.cboItems.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboItems.TabIndex = 0
            Me.cboItems.WatermarkColor = System.Drawing.Color.Silver
            Me.cboItems.WatermarkFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboItems.WatermarkText = "Select an item..."
            '
            'lblItemQuantity
            '
            '
            '
            '
            Me.lblItemQuantity.BackgroundStyle.Class = ""
            Me.lblItemQuantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblItemQuantity.Location = New System.Drawing.Point(12, 41)
            Me.lblItemQuantity.Name = "lblItemQuantity"
            Me.lblItemQuantity.Size = New System.Drawing.Size(75, 23)
            Me.lblItemQuantity.TabIndex = 1
            Me.lblItemQuantity.Text = "Quantity:"
            '
            'lblItemName
            '
            '
            '
            '
            Me.lblItemName.BackgroundStyle.Class = ""
            Me.lblItemName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblItemName.Location = New System.Drawing.Point(12, 12)
            Me.lblItemName.Name = "lblItemName"
            Me.lblItemName.Size = New System.Drawing.Size(75, 23)
            Me.lblItemName.TabIndex = 0
            Me.lblItemName.Text = "Item Name:"
            '
            'Highlighter1
            '
            Me.Highlighter1.ContainerControl = Me
            Me.Highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Green
            
            '
            'frmAddRequisitionItem
            '
            Me.AcceptButton = Me.btnAccept
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(359, 137)
            Me.Controls.Add(Me.panelReq)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmAddRequisitionItem"
            Me.ShowIcon = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Add Requisition Item"
            Me.panelReq.ResumeLayout(False)
            CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents panelReq As DevComponents.DotNetBar.PanelEx
        Friend WithEvents lblItemQuantity As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblItemName As DevComponents.DotNetBar.LabelX
        Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
        Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
        Friend WithEvents btnAccept As DevComponents.DotNetBar.ButtonX
        Friend WithEvents lblSource As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblSourceLbl As DevComponents.DotNetBar.LabelX
        Friend WithEvents nudQuantity As DevComponents.Editors.IntegerInput
        Friend WithEvents cboItems As DevComponents.DotNetBar.Controls.ComboBoxEx
    End Class
End NameSpace