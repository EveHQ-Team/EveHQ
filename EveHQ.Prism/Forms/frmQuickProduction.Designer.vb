Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmQuickProduction
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
            Me.pnlQIC = New DevComponents.DotNetBar.PanelEx()
            Me.adtResources = New DevComponents.AdvTree.AdvTree()
            Me.colMaterial = New DevComponents.AdvTree.ColumnHeader()
            Me.colQty = New DevComponents.AdvTree.ColumnHeader()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me.nudCopyRuns = New DevComponents.Editors.IntegerInput()
            Me.nudPELevel = New DevComponents.Editors.IntegerInput()
            Me.lblNewMELbl = New System.Windows.Forms.Label()
            Me.nudMELevel = New DevComponents.Editors.IntegerInput()
            Me.lblNewPELbl = New System.Windows.Forms.Label()
            Me.lblRunsPerCopy = New System.Windows.Forms.Label()
            Me.cboBPs = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.pnlQIC.SuspendLayout()
            CType(Me.adtResources, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCopyRuns, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudPELevel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudMELevel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlQIC
            '
            Me.pnlQIC.CanvasColor = System.Drawing.SystemColors.Control
            Me.pnlQIC.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.pnlQIC.Controls.Add(Me.adtResources)
            Me.pnlQIC.Controls.Add(Me.nudCopyRuns)
            Me.pnlQIC.Controls.Add(Me.nudPELevel)
            Me.pnlQIC.Controls.Add(Me.lblNewMELbl)
            Me.pnlQIC.Controls.Add(Me.nudMELevel)
            Me.pnlQIC.Controls.Add(Me.lblNewPELbl)
            Me.pnlQIC.Controls.Add(Me.lblRunsPerCopy)
            Me.pnlQIC.Controls.Add(Me.cboBPs)
            Me.pnlQIC.DisabledBackColor = System.Drawing.Color.Empty
            Me.pnlQIC.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlQIC.Location = New System.Drawing.Point(0, 0)
            Me.pnlQIC.Name = "pnlQIC"
            Me.pnlQIC.Size = New System.Drawing.Size(417, 352)
            Me.pnlQIC.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.pnlQIC.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.pnlQIC.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.pnlQIC.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.pnlQIC.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.pnlQIC.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.pnlQIC.Style.GradientAngle = 90
            Me.pnlQIC.TabIndex = 0
            '
            'adtResources
            '
            Me.adtResources.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtResources.AllowDrop = True
            Me.adtResources.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.adtResources.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtResources.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtResources.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtResources.Columns.Add(Me.colMaterial)
            Me.adtResources.Columns.Add(Me.colQty)
            Me.adtResources.ExpandWidth = 0
            
            Me.adtResources.Location = New System.Drawing.Point(12, 66)
            Me.adtResources.Name = "adtResources"
            Me.adtResources.NodesConnector = Me.NodeConnector1
            Me.adtResources.NodeStyle = Me.ElementStyle1
            Me.adtResources.PathSeparator = ";"
            Me.adtResources.Size = New System.Drawing.Size(392, 274)
            Me.adtResources.Styles.Add(Me.ElementStyle1)
            Me.adtResources.TabIndex = 43
            Me.adtResources.Text = "AdvTree1"
            '
            'colMaterial
            '
            Me.colMaterial.Name = "colMaterial"
            Me.colMaterial.SortingEnabled = False
            Me.colMaterial.Text = "Material"
            Me.colMaterial.Width.Absolute = 250
            '
            'colQty
            '
            Me.colQty.Name = "colQty"
            Me.colQty.SortingEnabled = False
            Me.colQty.Text = "Quantity"
            Me.colQty.Width.Absolute = 100
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
            'nudCopyRuns
            '
            '
            '
            '
            Me.nudCopyRuns.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.nudCopyRuns.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.nudCopyRuns.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.nudCopyRuns.Location = New System.Drawing.Point(324, 39)
            Me.nudCopyRuns.MaxValue = 1500
            Me.nudCopyRuns.MinValue = 1
            Me.nudCopyRuns.Name = "nudCopyRuns"
            Me.nudCopyRuns.ShowUpDown = True
            Me.nudCopyRuns.Size = New System.Drawing.Size(80, 21)
            Me.nudCopyRuns.TabIndex = 42
            Me.nudCopyRuns.Value = 1
            '
            'nudPELevel
            '
            '
            '
            '
            Me.nudPELevel.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.nudPELevel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.nudPELevel.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.nudPELevel.Location = New System.Drawing.Point(171, 39)
            Me.nudPELevel.MaxValue = 20
            Me.nudPELevel.MinValue = 0
            Me.nudPELevel.Name = "nudPELevel"
            Me.nudPELevel.ShowUpDown = True
            Me.nudPELevel.Size = New System.Drawing.Size(80, 21)
            Me.nudPELevel.TabIndex = 41
            '
            'lblNewMELbl
            '
            Me.lblNewMELbl.AutoSize = True
            Me.lblNewMELbl.BackColor = System.Drawing.Color.Transparent
            Me.lblNewMELbl.Location = New System.Drawing.Point(14, 43)
            Me.lblNewMELbl.Name = "lblNewMELbl"
            Me.lblNewMELbl.Size = New System.Drawing.Size(25, 13)
            Me.lblNewMELbl.TabIndex = 37
            Me.lblNewMELbl.Text = "ME:"
            '
            'nudMELevel
            '
            '
            '
            '
            Me.nudMELevel.BackgroundStyle.Class = "DateTimeInputBackground"
            Me.nudMELevel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.nudMELevel.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
            Me.nudMELevel.Location = New System.Drawing.Point(45, 39)
            Me.nudMELevel.MaxValue = 10
            Me.nudMELevel.MinValue = 0
            Me.nudMELevel.Name = "nudMELevel"
            Me.nudMELevel.ShowUpDown = True
            Me.nudMELevel.Size = New System.Drawing.Size(80, 21)
            Me.nudMELevel.TabIndex = 40
            '
            'lblNewPELbl
            '
            Me.lblNewPELbl.AutoSize = True
            Me.lblNewPELbl.BackColor = System.Drawing.Color.Transparent
            Me.lblNewPELbl.Location = New System.Drawing.Point(142, 43)
            Me.lblNewPELbl.Name = "lblNewPELbl"
            Me.lblNewPELbl.Size = New System.Drawing.Size(23, 13)
            Me.lblNewPELbl.TabIndex = 38
            Me.lblNewPELbl.Text = "TE:"
            '
            'lblRunsPerCopy
            '
            Me.lblRunsPerCopy.AutoSize = True
            Me.lblRunsPerCopy.BackColor = System.Drawing.Color.Transparent
            Me.lblRunsPerCopy.Location = New System.Drawing.Point(273, 43)
            Me.lblRunsPerCopy.Name = "lblRunsPerCopy"
            Me.lblRunsPerCopy.Size = New System.Drawing.Size(35, 13)
            Me.lblRunsPerCopy.TabIndex = 39
            Me.lblRunsPerCopy.Text = "Runs:"
            '
            'cboBPs
            '
            Me.cboBPs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cboBPs.DisplayMember = "Text"
            Me.cboBPs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboBPs.FormattingEnabled = True
            Me.cboBPs.ItemHeight = 15
            Me.cboBPs.Location = New System.Drawing.Point(12, 12)
            Me.cboBPs.Name = "cboBPs"
            Me.cboBPs.Size = New System.Drawing.Size(392, 21)
            Me.cboBPs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboBPs.TabIndex = 22
            '
            'FrmQuickProduction
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(417, 352)
            Me.Controls.Add(Me.pnlQIC)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmQuickProduction"
            Me.ShowIcon = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Quick Production"
            Me.pnlQIC.ResumeLayout(False)
            Me.pnlQIC.PerformLayout()
            CType(Me.adtResources, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCopyRuns, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudPELevel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudMELevel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlQIC As DevComponents.DotNetBar.PanelEx
        Friend WithEvents cboBPs As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents nudCopyRuns As DevComponents.Editors.IntegerInput
        Friend WithEvents nudPELevel As DevComponents.Editors.IntegerInput
        Friend WithEvents lblNewMELbl As System.Windows.Forms.Label
        Friend WithEvents nudMELevel As DevComponents.Editors.IntegerInput
        Friend WithEvents lblNewPELbl As System.Windows.Forms.Label
        Friend WithEvents lblRunsPerCopy As System.Windows.Forms.Label
        Friend WithEvents adtResources As DevComponents.AdvTree.AdvTree
        Friend WithEvents colMaterial As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colQty As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
    End Class
End NameSpace