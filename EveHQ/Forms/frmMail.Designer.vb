Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmMail
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
            Me.btnMarkAllNoticesRead = New DevComponents.DotNetBar.ButtonX()
            Me.panelMails = New DevComponents.DotNetBar.PanelEx()
            Me.btnCopyEvemail = New DevComponents.DotNetBar.ButtonX()
            Me.pnlMail = New DevComponents.DotNetBar.PanelEx()
            Me.txtMail = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.adtMails = New DevComponents.AdvTree.AdvTree()
            Me.Node1 = New DevComponents.AdvTree.Node()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me.btnMarkAllMailsRead = New DevComponents.DotNetBar.ButtonX()
            Me.lblPilot = New DevComponents.DotNetBar.LabelX()
            Me.lblDownloadMailStatus = New DevComponents.DotNetBar.LabelX()
            Me.cboPilots = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.btnGetEveIDs = New DevComponents.DotNetBar.ButtonX()
            Me.btnDownloadMail = New DevComponents.DotNetBar.ButtonX()
            Me.panelMails.SuspendLayout()
            Me.pnlMail.SuspendLayout()
            CType(Me.adtMails, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnMarkAllNoticesRead
            '
            Me.btnMarkAllNoticesRead.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnMarkAllNoticesRead.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnMarkAllNoticesRead.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnMarkAllNoticesRead.Location = New System.Drawing.Point(1087, 5)
            Me.btnMarkAllNoticesRead.Name = "btnMarkAllNoticesRead"
            Me.btnMarkAllNoticesRead.Size = New System.Drawing.Size(125, 23)
            Me.btnMarkAllNoticesRead.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnMarkAllNoticesRead.TabIndex = 58
            Me.btnMarkAllNoticesRead.Text = "Mark All Notices Read"
            '
            'panelMails
            '
            Me.panelMails.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelMails.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelMails.Controls.Add(Me.btnCopyEvemail)
            Me.panelMails.Controls.Add(Me.pnlMail)
            Me.panelMails.Controls.Add(Me.adtMails)
            Me.panelMails.Controls.Add(Me.btnMarkAllNoticesRead)
            Me.panelMails.Controls.Add(Me.btnMarkAllMailsRead)
            Me.panelMails.Controls.Add(Me.lblPilot)
            Me.panelMails.Controls.Add(Me.lblDownloadMailStatus)
            Me.panelMails.Controls.Add(Me.cboPilots)
            Me.panelMails.Controls.Add(Me.btnGetEveIDs)
            Me.panelMails.Controls.Add(Me.btnDownloadMail)
            Me.panelMails.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelMails.Location = New System.Drawing.Point(0, 0)
            Me.panelMails.Name = "panelMails"
            Me.panelMails.Size = New System.Drawing.Size(1224, 796)
            Me.panelMails.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelMails.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.panelMails.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.panelMails.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelMails.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.panelMails.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelMails.Style.GradientAngle = 90
            Me.panelMails.TabIndex = 54
            '
            'btnCopyEvemail
            '
            Me.btnCopyEvemail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnCopyEvemail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnCopyEvemail.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnCopyEvemail.Enabled = False
            Me.btnCopyEvemail.Location = New System.Drawing.Point(335, 770)
            Me.btnCopyEvemail.Name = "btnCopyEvemail"
            Me.btnCopyEvemail.Size = New System.Drawing.Size(100, 23)
            Me.btnCopyEvemail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnCopyEvemail.TabIndex = 61
            Me.btnCopyEvemail.Text = "Copy Mail"
            '
            'pnlMail
            '
            Me.pnlMail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                        Or System.Windows.Forms.AnchorStyles.Left) _
                                       Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlMail.CanvasColor = System.Drawing.SystemColors.Control
            Me.pnlMail.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.pnlMail.Controls.Add(Me.txtMail)
            Me.pnlMail.Location = New System.Drawing.Point(335, 36)
            Me.pnlMail.Name = "pnlMail"
            Me.pnlMail.Size = New System.Drawing.Size(886, 728)
            Me.pnlMail.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.pnlMail.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.pnlMail.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
            Me.pnlMail.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.pnlMail.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.pnlMail.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.pnlMail.Style.GradientAngle = 90
            Me.pnlMail.TabIndex = 60
            '
            'txtMail
            '
            '
            '
            '
            Me.txtMail.Border.Class = "TextBoxBorder"
            Me.txtMail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.txtMail.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtMail.Location = New System.Drawing.Point(0, 0)
            Me.txtMail.Multiline = True
            Me.txtMail.Name = "txtMail"
            Me.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtMail.Size = New System.Drawing.Size(886, 728)
            Me.txtMail.TabIndex = 0
            Me.txtMail.Text = "txtMail"
            '
            'adtMails
            '
            Me.adtMails.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtMails.AllowDrop = True
            Me.adtMails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.adtMails.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtMails.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtMails.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtMails.DragDropEnabled = False
            Me.adtMails.DragDropNodeCopyEnabled = False
            
            Me.adtMails.Location = New System.Drawing.Point(6, 36)
            Me.adtMails.MultiSelect = True
            Me.adtMails.Name = "adtMails"
            Me.adtMails.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node1})
            Me.adtMails.NodesConnector = Me.NodeConnector1
            Me.adtMails.NodeStyle = Me.ElementStyle1
            Me.adtMails.PathSeparator = ";"
            Me.adtMails.Size = New System.Drawing.Size(323, 757)
            Me.adtMails.Styles.Add(Me.ElementStyle1)
            Me.adtMails.TabIndex = 59
            Me.adtMails.Text = "AdvTree1"
            Me.adtMails.View = DevComponents.AdvTree.eView.Tile
            '
            'Node1
            '
            Me.Node1.Expanded = True
            Me.Node1.Name = "Node1"
            Me.Node1.Text = "Node1"
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
            'btnMarkAllMailsRead
            '
            Me.btnMarkAllMailsRead.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnMarkAllMailsRead.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnMarkAllMailsRead.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnMarkAllMailsRead.Location = New System.Drawing.Point(956, 5)
            Me.btnMarkAllMailsRead.Name = "btnMarkAllMailsRead"
            Me.btnMarkAllMailsRead.Size = New System.Drawing.Size(125, 23)
            Me.btnMarkAllMailsRead.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnMarkAllMailsRead.TabIndex = 57
            Me.btnMarkAllMailsRead.Text = "Mark All Mails Read"
            '
            'lblPilot
            '
            Me.lblPilot.AutoSize = True
            '
            '
            '
            Me.lblPilot.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblPilot.Location = New System.Drawing.Point(15, 10)
            Me.lblPilot.Name = "lblPilot"
            Me.lblPilot.Size = New System.Drawing.Size(27, 16)
            Me.lblPilot.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.lblPilot.TabIndex = 56
            Me.lblPilot.Text = "Pilot:"
            '
            'lblDownloadMailStatus
            '
            Me.lblDownloadMailStatus.AutoSize = True
            '
            '
            '
            Me.lblDownloadMailStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lblDownloadMailStatus.Location = New System.Drawing.Point(335, 9)
            Me.lblDownloadMailStatus.Name = "lblDownloadMailStatus"
            Me.lblDownloadMailStatus.Size = New System.Drawing.Size(158, 16)
            Me.lblDownloadMailStatus.TabIndex = 50
            Me.lblDownloadMailStatus.Text = "Mail Status: <Awaiting Update>"
            '
            'cboPilots
            '
            Me.cboPilots.DisplayMember = "Text"
            Me.cboPilots.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
            Me.cboPilots.DropDownHeight = 250
            Me.cboPilots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboPilots.FormattingEnabled = True
            Me.cboPilots.IntegralHeight = False
            Me.cboPilots.ItemHeight = 15
            Me.cboPilots.Location = New System.Drawing.Point(48, 9)
            Me.cboPilots.Name = "cboPilots"
            Me.cboPilots.Size = New System.Drawing.Size(175, 21)
            Me.cboPilots.Sorted = True
            Me.cboPilots.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboPilots.TabIndex = 43
            '
            'btnGetEveIDs
            '
            Me.btnGetEveIDs.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnGetEveIDs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnGetEveIDs.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnGetEveIDs.Location = New System.Drawing.Point(850, 5)
            Me.btnGetEveIDs.Name = "btnGetEveIDs"
            Me.btnGetEveIDs.Size = New System.Drawing.Size(100, 23)
            Me.btnGetEveIDs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnGetEveIDs.TabIndex = 53
            Me.btnGetEveIDs.Text = "Get Eve IDs"
            '
            'btnDownloadMail
            '
            Me.btnDownloadMail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnDownloadMail.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnDownloadMail.Location = New System.Drawing.Point(229, 7)
            Me.btnDownloadMail.Name = "btnDownloadMail"
            Me.btnDownloadMail.Size = New System.Drawing.Size(100, 23)
            Me.btnDownloadMail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnDownloadMail.TabIndex = 52
            Me.btnDownloadMail.Text = "Download Mail"
            '
            'frmMail
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1224, 796)
            Me.Controls.Add(Me.panelMails)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "frmMail"
            Me.Text = "EveHQ Mail Viewer"
            Me.panelMails.ResumeLayout(False)
            Me.panelMails.PerformLayout()
            Me.pnlMail.ResumeLayout(False)
            CType(Me.adtMails, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents panelMails As DevComponents.DotNetBar.PanelEx
        Friend WithEvents btnDownloadMail As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnGetEveIDs As DevComponents.DotNetBar.ButtonX
        Friend WithEvents cboPilots As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents lblDownloadMailStatus As DevComponents.DotNetBar.LabelX
        Friend WithEvents lblPilot As DevComponents.DotNetBar.LabelX
        Friend WithEvents btnMarkAllNoticesRead As DevComponents.DotNetBar.ButtonX
        Friend WithEvents btnMarkAllMailsRead As DevComponents.DotNetBar.ButtonX
        Friend WithEvents adtMails As DevComponents.AdvTree.AdvTree
        Friend WithEvents Node1 As DevComponents.AdvTree.Node
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents pnlMail As DevComponents.DotNetBar.PanelEx
        Friend WithEvents btnCopyEvemail As DevComponents.DotNetBar.ButtonX
        Friend WithEvents txtMail As DevComponents.DotNetBar.Controls.TextBoxX
    End Class
End NameSpace