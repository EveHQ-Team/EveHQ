Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmShipComparison
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
            Me.lblPilot = New System.Windows.Forms.Label()
            Me.lblDamageProfile = New System.Windows.Forms.Label()
            Me.btnCopy = New DevComponents.DotNetBar.ButtonX()
            Me.cboPilots = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.cboProfiles = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.adtShips = New DevComponents.AdvTree.AdvTree()
            Me.colFitting = New DevComponents.AdvTree.ColumnHeader()
            Me.colEHP = New DevComponents.AdvTree.ColumnHeader()
            Me.colTank = New DevComponents.AdvTree.ColumnHeader()
            Me.colCap = New DevComponents.AdvTree.ColumnHeader()
            Me.colVolley = New DevComponents.AdvTree.ColumnHeader()
            Me.colDPS = New DevComponents.AdvTree.ColumnHeader()
            Me.colSEM = New DevComponents.AdvTree.ColumnHeader()
            Me.colSEx = New DevComponents.AdvTree.ColumnHeader()
            Me.colSKi = New DevComponents.AdvTree.ColumnHeader()
            Me.colSTh = New DevComponents.AdvTree.ColumnHeader()
            Me.colAEM = New DevComponents.AdvTree.ColumnHeader()
            Me.colAEx = New DevComponents.AdvTree.ColumnHeader()
            Me.colAKi = New DevComponents.AdvTree.ColumnHeader()
            Me.colATh = New DevComponents.AdvTree.ColumnHeader()
            Me.Node1 = New DevComponents.AdvTree.Node()
            Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
            Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
            Me.STT = New DevComponents.DotNetBar.SuperTooltip()
            CType(Me.adtShips, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblPilot
            '
            Me.lblPilot.AutoSize = True
            Me.lblPilot.Location = New System.Drawing.Point(12, 15)
            Me.lblPilot.Name = "lblPilot"
            Me.lblPilot.Size = New System.Drawing.Size(31, 13)
            Me.lblPilot.TabIndex = 0
            Me.lblPilot.Text = "Pilot:"
            '
            'lblDamageProfile
            '
            Me.lblDamageProfile.AutoSize = True
            Me.lblDamageProfile.Location = New System.Drawing.Point(12, 42)
            Me.lblDamageProfile.Name = "lblDamageProfile"
            Me.lblDamageProfile.Size = New System.Drawing.Size(83, 13)
            Me.lblDamageProfile.TabIndex = 1
            Me.lblDamageProfile.Text = "Damage Profile:"
            '
            'btnCopy
            '
            Me.btnCopy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCopy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnCopy.Location = New System.Drawing.Point(784, 39)
            Me.btnCopy.Name = "btnCopy"
            Me.btnCopy.Size = New System.Drawing.Size(110, 23)
            Me.btnCopy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnCopy.TabIndex = 6
            Me.btnCopy.Text = "Copy To Clipboard"
            '
            'cboPilots
            '
            Me.cboPilots.DisplayMember = "Text"
            Me.cboPilots.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboPilots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboPilots.FormattingEnabled = True
            Me.cboPilots.ItemHeight = 15
            Me.cboPilots.Location = New System.Drawing.Point(100, 12)
            Me.cboPilots.Name = "cboPilots"
            Me.cboPilots.Size = New System.Drawing.Size(251, 21)
            Me.cboPilots.Sorted = True
            Me.cboPilots.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboPilots.TabIndex = 7
            '
            'cboProfiles
            '
            Me.cboProfiles.DisplayMember = "Text"
            Me.cboProfiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cboProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboProfiles.FormattingEnabled = True
            Me.cboProfiles.ItemHeight = 15
            Me.cboProfiles.Location = New System.Drawing.Point(100, 39)
            Me.cboProfiles.Name = "cboProfiles"
            Me.cboProfiles.Size = New System.Drawing.Size(251, 21)
            Me.cboProfiles.Sorted = True
            Me.cboProfiles.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cboProfiles.TabIndex = 8
            '
            'adtShips
            '
            Me.adtShips.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.adtShips.AllowDrop = True
            Me.adtShips.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                         Or System.Windows.Forms.AnchorStyles.Left) _
                                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.adtShips.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.adtShips.BackgroundStyle.Class = "TreeBorderKey"
            Me.adtShips.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.adtShips.Columns.Add(Me.colFitting)
            Me.adtShips.Columns.Add(Me.colEHP)
            Me.adtShips.Columns.Add(Me.colTank)
            Me.adtShips.Columns.Add(Me.colCap)
            Me.adtShips.Columns.Add(Me.colVolley)
            Me.adtShips.Columns.Add(Me.colDPS)
            Me.adtShips.Columns.Add(Me.colSEM)
            Me.adtShips.Columns.Add(Me.colSEx)
            Me.adtShips.Columns.Add(Me.colSKi)
            Me.adtShips.Columns.Add(Me.colSTh)
            Me.adtShips.Columns.Add(Me.colAEM)
            Me.adtShips.Columns.Add(Me.colAEx)
            Me.adtShips.Columns.Add(Me.colAKi)
            Me.adtShips.Columns.Add(Me.colATh)
            Me.adtShips.DragDropEnabled = False
            Me.adtShips.DragDropNodeCopyEnabled = False
            Me.adtShips.ExpandWidth = 0
            
            Me.adtShips.Location = New System.Drawing.Point(12, 68)
            Me.adtShips.Name = "adtShips"
            Me.adtShips.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node1})
            Me.adtShips.NodesConnector = Me.NodeConnector1
            Me.adtShips.NodeStyle = Me.ElementStyle1
            Me.adtShips.PathSeparator = ";"
            Me.adtShips.Size = New System.Drawing.Size(882, 494)
            Me.adtShips.Styles.Add(Me.ElementStyle1)
            Me.adtShips.TabIndex = 9
            Me.adtShips.Text = "AdvTree1"
            '
            'colFitting
            '
            Me.colFitting.DisplayIndex = 1
            Me.colFitting.Name = "colFitting"
            Me.colFitting.SortingEnabled = False
            Me.colFitting.Text = "Fitting Name"
            Me.colFitting.Width.Absolute = 150
            '
            'colEHP
            '
            Me.colEHP.DisplayIndex = 2
            Me.colEHP.Name = "colEHP"
            Me.colEHP.SortingEnabled = False
            Me.colEHP.Text = "EHP"
            Me.colEHP.Width.Absolute = 70
            '
            'colTank
            '
            Me.colTank.DisplayIndex = 3
            Me.colTank.Name = "colTank"
            Me.colTank.SortingEnabled = False
            Me.colTank.Text = "Tank"
            Me.colTank.Width.Absolute = 50
            '
            'colCap
            '
            Me.colCap.DisplayIndex = 4
            Me.colCap.Name = "colCap"
            Me.colCap.SortingEnabled = False
            Me.colCap.Text = "Capacitor"
            Me.colCap.Width.Absolute = 100
            '
            'colVolley
            '
            Me.colVolley.DisplayIndex = 5
            Me.colVolley.Name = "colVolley"
            Me.colVolley.SortingEnabled = False
            Me.colVolley.Text = "Volley"
            Me.colVolley.Width.Absolute = 50
            '
            'colDPS
            '
            Me.colDPS.DisplayIndex = 6
            Me.colDPS.Name = "colDPS"
            Me.colDPS.SortingEnabled = False
            Me.colDPS.Text = "DPS"
            Me.colDPS.Width.Absolute = 50
            '
            'colSEM
            '
            Me.colSEM.DisplayIndex = 7
            Me.colSEM.Name = "colSEM"
            Me.colSEM.SortingEnabled = False
            Me.colSEM.Text = "S EM"
            Me.colSEM.Width.Absolute = 40
            '
            'colSEx
            '
            Me.colSEx.DisplayIndex = 8
            Me.colSEx.Name = "colSEx"
            Me.colSEx.SortingEnabled = False
            Me.colSEx.Text = "S Ex"
            Me.colSEx.Width.Absolute = 40
            '
            'colSKi
            '
            Me.colSKi.DisplayIndex = 9
            Me.colSKi.Name = "colSKi"
            Me.colSKi.SortingEnabled = False
            Me.colSKi.Text = "S Ki"
            Me.colSKi.Width.Absolute = 40
            '
            'colSTh
            '
            Me.colSTh.DisplayIndex = 10
            Me.colSTh.Name = "colSTh"
            Me.colSTh.SortingEnabled = False
            Me.colSTh.Text = "S Th"
            Me.colSTh.Width.Absolute = 40
            '
            'colAEM
            '
            Me.colAEM.DisplayIndex = 11
            Me.colAEM.Name = "colAEM"
            Me.colAEM.SortingEnabled = False
            Me.colAEM.Text = "A EM"
            Me.colAEM.Width.Absolute = 40
            '
            'colAEx
            '
            Me.colAEx.DisplayIndex = 12
            Me.colAEx.Name = "colAEx"
            Me.colAEx.SortingEnabled = False
            Me.colAEx.Text = "A Ex"
            Me.colAEx.Width.Absolute = 40
            '
            'colAKi
            '
            Me.colAKi.DisplayIndex = 13
            Me.colAKi.Name = "colAKi"
            Me.colAKi.SortingEnabled = False
            Me.colAKi.Text = "A Ki"
            Me.colAKi.Width.Absolute = 40
            '
            'colATh
            '
            Me.colATh.DisplayIndex = 14
            Me.colATh.Name = "colATh"
            Me.colATh.SortingEnabled = False
            Me.colATh.Text = "A Th"
            Me.colATh.Width.Absolute = 40
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
            Me.ElementStyle1.Class = ""
            Me.ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ElementStyle1.Name = "ElementStyle1"
            Me.ElementStyle1.TextColor = System.Drawing.SystemColors.ControlText
            '
            'STT
            '
            
            Me.STT.PositionBelowControl = False
            '
            'frmShipComparison
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(906, 574)
            Me.Controls.Add(Me.adtShips)
            Me.Controls.Add(Me.cboProfiles)
            Me.Controls.Add(Me.cboPilots)
            Me.Controls.Add(Me.btnCopy)
            Me.Controls.Add(Me.lblDamageProfile)
            Me.Controls.Add(Me.lblPilot)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
            Me.Name = "frmShipComparison"
            Me.ShowIcon = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "HQF Ship Comparison"
            CType(Me.adtShips, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblPilot As System.Windows.Forms.Label
        Friend WithEvents lblDamageProfile As System.Windows.Forms.Label
        Friend WithEvents btnCopy As DevComponents.DotNetBar.ButtonX
        Friend WithEvents cboPilots As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents cboProfiles As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents adtShips As DevComponents.AdvTree.AdvTree
        Friend WithEvents Node1 As DevComponents.AdvTree.Node
        Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
        Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
        Friend WithEvents colFitting As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colEHP As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colTank As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colCap As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colVolley As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colDPS As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colSEM As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colSEx As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colSKi As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colSTh As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colAEM As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colAEx As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colAKi As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents colATh As DevComponents.AdvTree.ColumnHeader
        Friend WithEvents STT As DevComponents.DotNetBar.SuperTooltip
    End Class
End NameSpace