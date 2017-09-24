Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmBackupEveHQ
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBackupEveHQ))
            Me.btnRestore = New System.Windows.Forms.Button()
            Me.lvwBackups = New DevComponents.DotNetBar.Controls.ListViewEx()
            Me.BackupData = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.btnScan = New System.Windows.Forms.Button()
            Me.RadAutoBackup = New System.Windows.Forms.RadioButton()
            Me.lblBackupWarningDays = New System.Windows.Forms.Label()
            Me.nudBackupWarning = New System.Windows.Forms.NumericUpDown()
            Me.lblBackupWarning = New System.Windows.Forms.Label()
            Me.radPromptBackup = New System.Windows.Forms.RadioButton()
            Me.radManualBackup = New System.Windows.Forms.RadioButton()
            Me.btnResetBackup = New System.Windows.Forms.Button()
            Me.btnBackup = New System.Windows.Forms.Button()
            Me.lblNextBackupLbl = New System.Windows.Forms.Label()
            Me.lblLastBackup = New System.Windows.Forms.Label()
            Me.lblNextBackup = New System.Windows.Forms.Label()
            Me.lblLastBackupLbl = New System.Windows.Forms.Label()
            Me.lblStartFormat = New System.Windows.Forms.Label()
            Me.dtpStart = New System.Windows.Forms.DateTimePicker()
            Me.lblBackupStart = New System.Windows.Forms.Label()
            Me.lblBackupDays = New System.Windows.Forms.Label()
            Me.nudDays = New System.Windows.Forms.NumericUpDown()
            Me.lblBackupFreq = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.gpEveHQBackup = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.chkBackupBeforeUpdate = New System.Windows.Forms.CheckBox()
            Me.gpEveHQRestore = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
            CType(Me.nudBackupWarning, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudDays, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gpEveHQBackup.SuspendLayout()
            Me.gpEveHQRestore.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnRestore
            '
            Me.btnRestore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnRestore.Enabled = False
            Me.btnRestore.Location = New System.Drawing.Point(12, 388)
            Me.btnRestore.Name = "btnRestore"
            Me.btnRestore.Size = New System.Drawing.Size(92, 23)
            Me.btnRestore.TabIndex = 14
            Me.btnRestore.Text = "Restore Now!"
            Me.ToolTip1.SetToolTip(Me.btnRestore, "Restores a selected backup directory")
            Me.btnRestore.UseVisualStyleBackColor = True
            '
            'lvwBackups
            '
            Me.lvwBackups.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                           Or System.Windows.Forms.AnchorStyles.Left) _
                                          Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.lvwBackups.Border.Class = "ListViewBorder"
            Me.lvwBackups.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lvwBackups.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.BackupData})
            Me.lvwBackups.FullRowSelect = True
            Me.lvwBackups.GridLines = True
            Me.lvwBackups.Location = New System.Drawing.Point(12, 55)
            Me.lvwBackups.Name = "lvwBackups"
            Me.lvwBackups.Size = New System.Drawing.Size(1219, 327)
            Me.lvwBackups.TabIndex = 13
            Me.lvwBackups.UseCompatibleStateImageBehavior = False
            Me.lvwBackups.View = System.Windows.Forms.View.Details
            '
            'BackupData
            '
            Me.BackupData.Text = "Backup Details"
            Me.BackupData.Width = 500
            '
            'btnScan
            '
            Me.btnScan.Location = New System.Drawing.Point(12, 13)
            Me.btnScan.Name = "btnScan"
            Me.btnScan.Size = New System.Drawing.Size(137, 23)
            Me.btnScan.TabIndex = 12
            Me.btnScan.Text = "Scan Backup Directory"
            Me.ToolTip1.SetToolTip(Me.btnScan, "Scans the EveHQ Backup location for directories")
            Me.btnScan.UseVisualStyleBackColor = True
            '
            'RadAutoBackup
            '
            Me.RadAutoBackup.AutoSize = True
            Me.RadAutoBackup.BackColor = System.Drawing.Color.Transparent
            Me.RadAutoBackup.Location = New System.Drawing.Point(15, 118)
            Me.RadAutoBackup.Name = "RadAutoBackup"
            Me.RadAutoBackup.Size = New System.Drawing.Size(139, 17)
            Me.RadAutoBackup.TabIndex = 19
            Me.RadAutoBackup.Text = "Automatic Backup Mode"
            Me.ToolTip1.SetToolTip(Me.RadAutoBackup, "Will automatically backup the EveHQ settings periodically according to the freque" & _
                                                     "ncy selected")
            Me.RadAutoBackup.UseVisualStyleBackColor = False
            '
            'lblBackupWarningDays
            '
            Me.lblBackupWarningDays.AutoSize = True
            Me.lblBackupWarningDays.BackColor = System.Drawing.Color.Transparent
            Me.lblBackupWarningDays.Enabled = False
            Me.lblBackupWarningDays.Location = New System.Drawing.Point(199, 89)
            Me.lblBackupWarningDays.Name = "lblBackupWarningDays"
            Me.lblBackupWarningDays.Size = New System.Drawing.Size(39, 13)
            Me.lblBackupWarningDays.TabIndex = 18
            Me.lblBackupWarningDays.Text = "(Days)"
            '
            'nudBackupWarning
            '
            Me.nudBackupWarning.Enabled = False
            Me.nudBackupWarning.Location = New System.Drawing.Point(157, 87)
            Me.nudBackupWarning.Maximum = New Decimal(New Integer() {28, 0, 0, 0})
            Me.nudBackupWarning.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudBackupWarning.Name = "nudBackupWarning"
            Me.nudBackupWarning.Size = New System.Drawing.Size(36, 21)
            Me.nudBackupWarning.TabIndex = 17
            Me.nudBackupWarning.Tag = "1"
            Me.nudBackupWarning.Value = New Decimal(New Integer() {7, 0, 0, 0})
            '
            'lblBackupWarning
            '
            Me.lblBackupWarning.AutoSize = True
            Me.lblBackupWarning.BackColor = System.Drawing.Color.Transparent
            Me.lblBackupWarning.Enabled = False
            Me.lblBackupWarning.Location = New System.Drawing.Point(46, 89)
            Me.lblBackupWarning.Name = "lblBackupWarning"
            Me.lblBackupWarning.Size = New System.Drawing.Size(105, 13)
            Me.lblBackupWarning.TabIndex = 16
            Me.lblBackupWarning.Text = "Warning Frequency:"
            '
            'radPromptBackup
            '
            Me.radPromptBackup.AutoSize = True
            Me.radPromptBackup.BackColor = System.Drawing.Color.Transparent
            Me.radPromptBackup.Location = New System.Drawing.Point(15, 64)
            Me.radPromptBackup.Name = "radPromptBackup"
            Me.radPromptBackup.Size = New System.Drawing.Size(131, 17)
            Me.radPromptBackup.TabIndex = 15
            Me.radPromptBackup.Text = "Backup Warning Mode"
            Me.ToolTip1.SetToolTip(Me.radPromptBackup, "Will prompt the user to backup the settings if a backup has not been made for at " & _
                                                       "least the number of days specified in the ""Warning Frequency""")
            Me.radPromptBackup.UseVisualStyleBackColor = False
            '
            'radManualBackup
            '
            Me.radManualBackup.AutoSize = True
            Me.radManualBackup.BackColor = System.Drawing.Color.Transparent
            Me.radManualBackup.Location = New System.Drawing.Point(15, 39)
            Me.radManualBackup.Name = "radManualBackup"
            Me.radManualBackup.Size = New System.Drawing.Size(125, 17)
            Me.radManualBackup.TabIndex = 14
            Me.radManualBackup.Text = "Manual Backup Mode"
            Me.ToolTip1.SetToolTip(Me.radManualBackup, "Does not prompt or perform any automatic backups of EveHQ settings")
            Me.radManualBackup.UseVisualStyleBackColor = False
            '
            'btnResetBackup
            '
            Me.btnResetBackup.Location = New System.Drawing.Point(396, 33)
            Me.btnResetBackup.Name = "btnResetBackup"
            Me.btnResetBackup.Size = New System.Drawing.Size(125, 23)
            Me.btnResetBackup.TabIndex = 13
            Me.btnResetBackup.Text = "Reset Last Backup"
            Me.ToolTip1.SetToolTip(Me.btnResetBackup, "Reset the last backup date")
            Me.btnResetBackup.UseVisualStyleBackColor = True
            '
            'btnBackup
            '
            Me.btnBackup.Location = New System.Drawing.Point(396, 5)
            Me.btnBackup.Name = "btnBackup"
            Me.btnBackup.Size = New System.Drawing.Size(125, 23)
            Me.SuperTooltip1.SetSuperTooltip(Me.btnBackup, New DevComponents.DotNetBar.SuperTooltipInfo("", "Backup EveHQ Settings", "Backs up all EveHQ Settings from the core application and the plug-ins, including" & _
                                                                                                                                     " the custom database.", Nothing, Global.EveHQ.My.Resources.Resources.Info32, DevComponents.DotNetBar.eTooltipColor.Yellow))
            Me.btnBackup.TabIndex = 12
            Me.btnBackup.Text = "Backup All Settings"
            Me.ToolTip1.SetToolTip(Me.btnBackup, "Backup the EveHQ settings now")
            Me.btnBackup.UseVisualStyleBackColor = True
            '
            'lblNextBackupLbl
            '
            Me.lblNextBackupLbl.AutoSize = True
            Me.lblNextBackupLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblNextBackupLbl.Enabled = False
            Me.lblNextBackupLbl.Location = New System.Drawing.Point(51, 204)
            Me.lblNextBackupLbl.Name = "lblNextBackupLbl"
            Me.lblNextBackupLbl.Size = New System.Drawing.Size(71, 13)
            Me.lblNextBackupLbl.TabIndex = 11
            Me.lblNextBackupLbl.Text = "Next Backup:"
            '
            'lblLastBackup
            '
            Me.lblLastBackup.AutoSize = True
            Me.lblLastBackup.BackColor = System.Drawing.Color.Transparent
            Me.lblLastBackup.Location = New System.Drawing.Point(135, 10)
            Me.lblLastBackup.Name = "lblLastBackup"
            Me.lblLastBackup.Size = New System.Drawing.Size(66, 13)
            Me.lblLastBackup.TabIndex = 10
            Me.lblLastBackup.Text = "<unknown>"
            '
            'lblNextBackup
            '
            Me.lblNextBackup.AutoSize = True
            Me.lblNextBackup.BackColor = System.Drawing.Color.Transparent
            Me.lblNextBackup.Enabled = False
            Me.lblNextBackup.Location = New System.Drawing.Point(154, 204)
            Me.lblNextBackup.Name = "lblNextBackup"
            Me.lblNextBackup.Size = New System.Drawing.Size(66, 13)
            Me.lblNextBackup.TabIndex = 9
            Me.lblNextBackup.Text = "<unknown>"
            '
            'lblLastBackupLbl
            '
            Me.lblLastBackupLbl.AutoSize = True
            Me.lblLastBackupLbl.BackColor = System.Drawing.Color.Transparent
            Me.lblLastBackupLbl.Location = New System.Drawing.Point(12, 10)
            Me.lblLastBackupLbl.Name = "lblLastBackupLbl"
            Me.lblLastBackupLbl.Size = New System.Drawing.Size(117, 13)
            Me.lblLastBackupLbl.TabIndex = 8
            Me.lblLastBackupLbl.Text = "Last Recorded Backup:"
            '
            'lblStartFormat
            '
            Me.lblStartFormat.AutoSize = True
            Me.lblStartFormat.BackColor = System.Drawing.Color.Transparent
            Me.lblStartFormat.Enabled = False
            Me.lblStartFormat.Location = New System.Drawing.Point(292, 176)
            Me.lblStartFormat.Name = "lblStartFormat"
            Me.lblStartFormat.Size = New System.Drawing.Size(164, 13)
            Me.lblStartFormat.TabIndex = 7
            Me.lblStartFormat.Text = "(in ""dd/mm/yyyy hh:mm"" format)"
            '
            'dtpStart
            '
            Me.dtpStart.CustomFormat = "dd/MM/yyyy HH:mm"
            Me.dtpStart.Enabled = False
            Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpStart.Location = New System.Drawing.Point(157, 171)
            Me.dtpStart.Name = "dtpStart"
            Me.dtpStart.ShowUpDown = True
            Me.dtpStart.Size = New System.Drawing.Size(129, 21)
            Me.dtpStart.TabIndex = 6
            Me.dtpStart.Tag = "1"
            Me.dtpStart.Value = New Date(2006, 3, 10, 0, 0, 0, 0)
            '
            'lblBackupStart
            '
            Me.lblBackupStart.AutoSize = True
            Me.lblBackupStart.BackColor = System.Drawing.Color.Transparent
            Me.lblBackupStart.Enabled = False
            Me.lblBackupStart.Location = New System.Drawing.Point(51, 176)
            Me.lblBackupStart.Name = "lblBackupStart"
            Me.lblBackupStart.Size = New System.Drawing.Size(87, 13)
            Me.lblBackupStart.TabIndex = 4
            Me.lblBackupStart.Text = "Start Date/Time:"
            '
            'lblBackupDays
            '
            Me.lblBackupDays.AutoSize = True
            Me.lblBackupDays.BackColor = System.Drawing.Color.Transparent
            Me.lblBackupDays.Enabled = False
            Me.lblBackupDays.Location = New System.Drawing.Point(199, 146)
            Me.lblBackupDays.Name = "lblBackupDays"
            Me.lblBackupDays.Size = New System.Drawing.Size(39, 13)
            Me.lblBackupDays.TabIndex = 3
            Me.lblBackupDays.Text = "(Days)"
            '
            'nudDays
            '
            Me.nudDays.Enabled = False
            Me.nudDays.Location = New System.Drawing.Point(157, 144)
            Me.nudDays.Maximum = New Decimal(New Integer() {28, 0, 0, 0})
            Me.nudDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudDays.Name = "nudDays"
            Me.nudDays.Size = New System.Drawing.Size(36, 21)
            Me.nudDays.TabIndex = 2
            Me.nudDays.Tag = "1"
            Me.nudDays.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'lblBackupFreq
            '
            Me.lblBackupFreq.AutoSize = True
            Me.lblBackupFreq.BackColor = System.Drawing.Color.Transparent
            Me.lblBackupFreq.Enabled = False
            Me.lblBackupFreq.Location = New System.Drawing.Point(51, 146)
            Me.lblBackupFreq.Name = "lblBackupFreq"
            Me.lblBackupFreq.Size = New System.Drawing.Size(99, 13)
            Me.lblBackupFreq.TabIndex = 1
            Me.lblBackupFreq.Text = "Backup Frequency:"
            '
            'gpEveHQBackup
            '
            Me.gpEveHQBackup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                                             Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gpEveHQBackup.CanvasColor = System.Drawing.SystemColors.Control
            Me.gpEveHQBackup.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.gpEveHQBackup.Controls.Add(Me.chkBackupBeforeUpdate)
            Me.gpEveHQBackup.Controls.Add(Me.RadAutoBackup)
            Me.gpEveHQBackup.Controls.Add(Me.lblLastBackupLbl)
            Me.gpEveHQBackup.Controls.Add(Me.lblBackupWarningDays)
            Me.gpEveHQBackup.Controls.Add(Me.lblBackupFreq)
            Me.gpEveHQBackup.Controls.Add(Me.nudBackupWarning)
            Me.gpEveHQBackup.Controls.Add(Me.nudDays)
            Me.gpEveHQBackup.Controls.Add(Me.lblBackupWarning)
            Me.gpEveHQBackup.Controls.Add(Me.lblBackupDays)
            Me.gpEveHQBackup.Controls.Add(Me.radPromptBackup)
            Me.gpEveHQBackup.Controls.Add(Me.lblBackupStart)
            Me.gpEveHQBackup.Controls.Add(Me.radManualBackup)
            Me.gpEveHQBackup.Controls.Add(Me.dtpStart)
            Me.gpEveHQBackup.Controls.Add(Me.btnResetBackup)
            Me.gpEveHQBackup.Controls.Add(Me.lblStartFormat)
            Me.gpEveHQBackup.Controls.Add(Me.btnBackup)
            Me.gpEveHQBackup.Controls.Add(Me.lblNextBackup)
            Me.gpEveHQBackup.Controls.Add(Me.lblNextBackupLbl)
            Me.gpEveHQBackup.Controls.Add(Me.lblLastBackup)
            Me.gpEveHQBackup.Location = New System.Drawing.Point(13, 12)
            Me.gpEveHQBackup.Name = "gpEveHQBackup"
            Me.gpEveHQBackup.Size = New System.Drawing.Size(1240, 282)
            '
            '
            '
            Me.gpEveHQBackup.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.gpEveHQBackup.Style.BackColorGradientAngle = 90
            Me.gpEveHQBackup.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.gpEveHQBackup.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpEveHQBackup.Style.BorderBottomWidth = 1
            Me.gpEveHQBackup.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.gpEveHQBackup.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpEveHQBackup.Style.BorderLeftWidth = 1
            Me.gpEveHQBackup.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpEveHQBackup.Style.BorderRightWidth = 1
            Me.gpEveHQBackup.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpEveHQBackup.Style.BorderTopWidth = 1
            Me.gpEveHQBackup.Style.CornerDiameter = 4
            Me.gpEveHQBackup.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.gpEveHQBackup.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.gpEveHQBackup.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.gpEveHQBackup.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.gpEveHQBackup.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.gpEveHQBackup.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.gpEveHQBackup.TabIndex = 4
            Me.gpEveHQBackup.Text = "EveHQ Settings Backup"
            '
            'chkBackupBeforeUpdate
            '
            Me.chkBackupBeforeUpdate.AutoSize = True
            Me.chkBackupBeforeUpdate.BackColor = System.Drawing.Color.Transparent
            Me.chkBackupBeforeUpdate.Location = New System.Drawing.Point(15, 235)
            Me.chkBackupBeforeUpdate.Name = "chkBackupBeforeUpdate"
            Me.chkBackupBeforeUpdate.Size = New System.Drawing.Size(264, 17)
            Me.chkBackupBeforeUpdate.TabIndex = 20
            Me.chkBackupBeforeUpdate.Text = "Always Perform a Backup Before Updating EveHQ"
            Me.chkBackupBeforeUpdate.UseVisualStyleBackColor = False
            '
            'gpEveHQRestore
            '
            Me.gpEveHQRestore.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                               Or System.Windows.Forms.AnchorStyles.Left) _
                                              Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gpEveHQRestore.CanvasColor = System.Drawing.SystemColors.Control
            Me.gpEveHQRestore.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.gpEveHQRestore.Controls.Add(Me.btnRestore)
            Me.gpEveHQRestore.Controls.Add(Me.btnScan)
            Me.gpEveHQRestore.Controls.Add(Me.lvwBackups)
            Me.gpEveHQRestore.Location = New System.Drawing.Point(13, 300)
            Me.gpEveHQRestore.Name = "gpEveHQRestore"
            Me.gpEveHQRestore.Size = New System.Drawing.Size(1240, 440)
            '
            '
            '
            Me.gpEveHQRestore.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.gpEveHQRestore.Style.BackColorGradientAngle = 90
            Me.gpEveHQRestore.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.gpEveHQRestore.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpEveHQRestore.Style.BorderBottomWidth = 1
            Me.gpEveHQRestore.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.gpEveHQRestore.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpEveHQRestore.Style.BorderLeftWidth = 1
            Me.gpEveHQRestore.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpEveHQRestore.Style.BorderRightWidth = 1
            Me.gpEveHQRestore.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.gpEveHQRestore.Style.BorderTopWidth = 1
            Me.gpEveHQRestore.Style.CornerDiameter = 4
            Me.gpEveHQRestore.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.gpEveHQRestore.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.gpEveHQRestore.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.gpEveHQRestore.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.gpEveHQRestore.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.gpEveHQRestore.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.gpEveHQRestore.TabIndex = 5
            Me.gpEveHQRestore.Text = "EveHQ Settings Restore"
            '
            'SuperTooltip1
            '
            
            '
            'frmBackupEveHQ
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1265, 747)
            Me.Controls.Add(Me.gpEveHQRestore)
            Me.Controls.Add(Me.gpEveHQBackup)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "frmBackupEveHQ"
            Me.Text = "EveHQ Settings Backup"
            CType(Me.nudBackupWarning, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudDays, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gpEveHQBackup.ResumeLayout(False)
            Me.gpEveHQBackup.PerformLayout()
            Me.gpEveHQRestore.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnRestore As System.Windows.Forms.Button
        Friend WithEvents lvwBackups As DevComponents.DotNetBar.Controls.ListViewEx
        Friend WithEvents BackupData As System.Windows.Forms.ColumnHeader
        Friend WithEvents btnScan As System.Windows.Forms.Button
        Friend WithEvents btnResetBackup As System.Windows.Forms.Button
        Friend WithEvents btnBackup As System.Windows.Forms.Button
        Friend WithEvents lblNextBackupLbl As System.Windows.Forms.Label
        Friend WithEvents lblLastBackup As System.Windows.Forms.Label
        Friend WithEvents lblNextBackup As System.Windows.Forms.Label
        Friend WithEvents lblLastBackupLbl As System.Windows.Forms.Label
        Friend WithEvents lblStartFormat As System.Windows.Forms.Label
        Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblBackupStart As System.Windows.Forms.Label
        Friend WithEvents lblBackupDays As System.Windows.Forms.Label
        Friend WithEvents nudDays As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblBackupFreq As System.Windows.Forms.Label
        Friend WithEvents RadAutoBackup As System.Windows.Forms.RadioButton
        Friend WithEvents lblBackupWarningDays As System.Windows.Forms.Label
        Friend WithEvents nudBackupWarning As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblBackupWarning As System.Windows.Forms.Label
        Friend WithEvents radPromptBackup As System.Windows.Forms.RadioButton
        Friend WithEvents radManualBackup As System.Windows.Forms.RadioButton
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents gpEveHQBackup As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents gpEveHQRestore As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents chkBackupBeforeUpdate As System.Windows.Forms.CheckBox
        Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    End Class
End NameSpace