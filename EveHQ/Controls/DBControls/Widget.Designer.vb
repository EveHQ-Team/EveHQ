Namespace Controls.DBControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Widget
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
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
            Me.pbConfig = New System.Windows.Forms.PictureBox()
            Me.lblHeader = New DevComponents.DotNetBar.LabelX()
            Me.AGPContent = New DevComponents.DotNetBar.PanelEx()
            Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
            Me.ctxHeader = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.RemoveWidgetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.pbConfig, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.AGPContent.SuspendLayout()
            Me.ctxHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pbConfig
            '
            Me.pbConfig.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pbConfig.BackColor = System.Drawing.Color.DimGray
            Me.pbConfig.Image = Global.EveHQ.My.Resources.Resources.Info32
            Me.pbConfig.Location = New System.Drawing.Point(272, 8)
            Me.pbConfig.Name = "pbConfig"
            Me.pbConfig.Size = New System.Drawing.Size(20, 20)
            Me.pbConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.SuperTooltip1.SetSuperTooltip(Me.pbConfig, New DevComponents.DotNetBar.SuperTooltipInfo("Widget Configuration", "", "Double-click the icon to open the configuration form for this widget.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Yellow))
            Me.pbConfig.TabIndex = 14
            Me.pbConfig.TabStop = False
            '
            'lblHeader
            '
            Me.lblHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                         Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblHeader.BackColor = System.Drawing.Color.DimGray
            '
            '
            '
            Me.lblHeader.BackgroundStyle.Class = ""
            Me.lblHeader.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblHeader.ContextMenuStrip = Me.ctxHeader
            Me.lblHeader.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.lblHeader.Image = Global.EveHQ.My.Resources.Resources.Database32
            Me.lblHeader.Location = New System.Drawing.Point(6, 6)
            Me.lblHeader.Name = "lblHeader"
            Me.lblHeader.Size = New System.Drawing.Size(288, 23)
            Me.lblHeader.TabIndex = 1
            Me.lblHeader.Text = "Base Widget"
            '
            'AGPContent
            '
            Me.AGPContent.CanvasColor = System.Drawing.SystemColors.Control
            Me.AGPContent.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.AGPContent.Controls.Add(Me.pbConfig)
            Me.AGPContent.Controls.Add(Me.lblHeader)
            Me.AGPContent.Dock = System.Windows.Forms.DockStyle.Fill
            Me.AGPContent.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AGPContent.Location = New System.Drawing.Point(0, 0)
            Me.AGPContent.Name = "AGPContent"
            Me.AGPContent.Size = New System.Drawing.Size(300, 220)
            Me.AGPContent.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.AGPContent.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.AGPContent.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.AGPContent.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.AGPContent.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.AGPContent.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.AGPContent.Style.GradientAngle = 90
            Me.AGPContent.TabIndex = 1
            '
            'SuperTooltip1
            '
            
            '
            'ctxHeader
            '
            Me.ctxHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ctxHeader.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveWidgetToolStripMenuItem})
            Me.ctxHeader.Name = "ctxHeader"
            Me.ctxHeader.Size = New System.Drawing.Size(153, 48)
            '
            'RemoveWidgetToolStripMenuItem
            '
            Me.RemoveWidgetToolStripMenuItem.Name = "RemoveWidgetToolStripMenuItem"
            Me.RemoveWidgetToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
            Me.RemoveWidgetToolStripMenuItem.Text = "Remove Widget"
            '
            'Widget
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.AGPContent)
            Me.DoubleBuffered = True
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.MinimumSize = New System.Drawing.Size(190, 150)
            Me.Name = "Widget"
            Me.Size = New System.Drawing.Size(300, 220)
            CType(Me.pbConfig, System.ComponentModel.ISupportInitialize).EndInit()
            Me.AGPContent.ResumeLayout(False)
            Me.ctxHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Protected Friend WithEvents lblHeader As DevComponents.DotNetBar.LabelX
        Protected Friend WithEvents AGPContent As DevComponents.DotNetBar.PanelEx
        Protected Friend WithEvents pbConfig As System.Windows.Forms.PictureBox
        Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
        Friend WithEvents ctxHeader As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents RemoveWidgetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    End Class
End NameSpace