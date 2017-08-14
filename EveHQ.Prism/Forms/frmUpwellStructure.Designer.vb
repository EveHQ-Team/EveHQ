Namespace Global.EveHQ.Plugins.Prism.UpwellStructures

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmUpwellStructure
        Inherits System.Windows.Forms.Form

        'Form remplace la méthode Dispose pour nettoyer la liste des composants.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Requise par le Concepteur Windows Form
        Private components As System.ComponentModel.IContainer

        'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
        'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
        'Ne la modifiez pas à l'aide de l'éditeur de code.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.pnlStructDefinition = New System.Windows.Forms.Panel()
            Me.cbxStructLocation = New System.Windows.Forms.ComboBox()
            Me.cbxStructType = New System.Windows.Forms.ComboBox()
            Me.tfStructName = New System.Windows.Forms.TextBox()
            Me.lblStructLocation = New System.Windows.Forms.Label()
            Me.lblStructType = New System.Windows.Forms.Label()
            Me.lblStructName = New System.Windows.Forms.Label()
            Me.gpxStructProdBonuses = New System.Windows.Forms.GroupBox()
            Me.lblStructProdBonus_TimEff = New System.Windows.Forms.Label()
            Me.lblStructProdBonus_MatEff = New System.Windows.Forms.Label()
            Me.cbxStructProdBonus_TimEff_3 = New System.Windows.Forms.ComboBox()
            Me.cbxStructProdBonus_TimEff_2 = New System.Windows.Forms.ComboBox()
            Me.cbxStructProdBonus_TimEff_1 = New System.Windows.Forms.ComboBox()
            Me.cbxStructProdBonus_MatEff_3 = New System.Windows.Forms.ComboBox()
            Me.cbxStructProdBonus_MatEff_2 = New System.Windows.Forms.ComboBox()
            Me.cbxStructProdBonus_MatEff_1 = New System.Windows.Forms.ComboBox()
            Me.cbxStructProdBonus_Group_3 = New System.Windows.Forms.ComboBox()
            Me.lblItemGroup = New System.Windows.Forms.Label()
            Me.cbxStructProdBonus_Group_2 = New System.Windows.Forms.ComboBox()
            Me.cbxStructProdBonus_Group_1 = New System.Windows.Forms.ComboBox()
            Me.gpxStructScienceBonuses = New System.Windows.Forms.GroupBox()
            Me.lblStructScieBonus_TimEff = New System.Windows.Forms.Label()
            Me.cbxStructScieBonus_Group_1 = New System.Windows.Forms.ComboBox()
            Me.lblStructScieBonus_CosEff = New System.Windows.Forms.Label()
            Me.cbxStructScieBonus_Group_2 = New System.Windows.Forms.ComboBox()
            Me.cbxStructScieBonus_TimEff_3 = New System.Windows.Forms.ComboBox()
            Me.lblScienceJobType = New System.Windows.Forms.Label()
            Me.cbxStructScieBonus_TimEff_2 = New System.Windows.Forms.ComboBox()
            Me.cbxStructScieBonus_Group_3 = New System.Windows.Forms.ComboBox()
            Me.cbxStructScieBonus_TimEff_1 = New System.Windows.Forms.ComboBox()
            Me.cbxStructScieBonus_CosEff_1 = New System.Windows.Forms.ComboBox()
            Me.cbxStructScieBonus_CosEff_3 = New System.Windows.Forms.ComboBox()
            Me.cbxStructScieBonus_CosEff_2 = New System.Windows.Forms.ComboBox()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.pnlStructDefinition.SuspendLayout()
            Me.gpxStructProdBonuses.SuspendLayout()
            Me.gpxStructScienceBonuses.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlStructDefinition
            '
            Me.pnlStructDefinition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlStructDefinition.Controls.Add(Me.cbxStructLocation)
            Me.pnlStructDefinition.Controls.Add(Me.cbxStructType)
            Me.pnlStructDefinition.Controls.Add(Me.tfStructName)
            Me.pnlStructDefinition.Controls.Add(Me.lblStructLocation)
            Me.pnlStructDefinition.Controls.Add(Me.lblStructType)
            Me.pnlStructDefinition.Controls.Add(Me.lblStructName)
            Me.pnlStructDefinition.Location = New System.Drawing.Point(12, 12)
            Me.pnlStructDefinition.Name = "pnlStructDefinition"
            Me.pnlStructDefinition.Size = New System.Drawing.Size(290, 78)
            Me.pnlStructDefinition.TabIndex = 0
            '
            'cbxStructLocation
            '
            Me.cbxStructLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbxStructLocation.FormattingEnabled = True
            Me.cbxStructLocation.Location = New System.Drawing.Point(89, 52)
            Me.cbxStructLocation.Name = "cbxStructLocation"
            Me.cbxStructLocation.Size = New System.Drawing.Size(198, 21)
            Me.cbxStructLocation.TabIndex = 1
            '
            'cbxStructType
            '
            Me.cbxStructType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbxStructType.FormattingEnabled = True
            Me.cbxStructType.Location = New System.Drawing.Point(89, 27)
            Me.cbxStructType.Name = "cbxStructType"
            Me.cbxStructType.Size = New System.Drawing.Size(198, 21)
            Me.cbxStructType.TabIndex = 1
            '
            'tfStructName
            '
            Me.tfStructName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tfStructName.Location = New System.Drawing.Point(89, 2)
            Me.tfStructName.Name = "tfStructName"
            Me.tfStructName.Size = New System.Drawing.Size(198, 20)
            Me.tfStructName.TabIndex = 1
            '
            'lblStructLocation
            '
            Me.lblStructLocation.AutoSize = True
            Me.lblStructLocation.Location = New System.Drawing.Point(3, 55)
            Me.lblStructLocation.Name = "lblStructLocation"
            Me.lblStructLocation.Size = New System.Drawing.Size(54, 13)
            Me.lblStructLocation.TabIndex = 1
            Me.lblStructLocation.Text = "Location :"
            '
            'lblStructType
            '
            Me.lblStructType.AutoSize = True
            Me.lblStructType.Location = New System.Drawing.Point(3, 30)
            Me.lblStructType.Name = "lblStructType"
            Me.lblStructType.Size = New System.Drawing.Size(37, 13)
            Me.lblStructType.TabIndex = 1
            Me.lblStructType.Text = "Type :"
            '
            'lblStructName
            '
            Me.lblStructName.AutoSize = True
            Me.lblStructName.Location = New System.Drawing.Point(3, 5)
            Me.lblStructName.Name = "lblStructName"
            Me.lblStructName.Size = New System.Drawing.Size(41, 13)
            Me.lblStructName.TabIndex = 1
            Me.lblStructName.Text = "Name :"
            '
            'gpxStructProdBonuses
            '
            Me.gpxStructProdBonuses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gpxStructProdBonuses.Controls.Add(Me.lblStructProdBonus_TimEff)
            Me.gpxStructProdBonuses.Controls.Add(Me.lblStructProdBonus_MatEff)
            Me.gpxStructProdBonuses.Controls.Add(Me.cbxStructProdBonus_TimEff_3)
            Me.gpxStructProdBonuses.Controls.Add(Me.cbxStructProdBonus_TimEff_2)
            Me.gpxStructProdBonuses.Controls.Add(Me.cbxStructProdBonus_TimEff_1)
            Me.gpxStructProdBonuses.Controls.Add(Me.cbxStructProdBonus_MatEff_3)
            Me.gpxStructProdBonuses.Controls.Add(Me.cbxStructProdBonus_MatEff_2)
            Me.gpxStructProdBonuses.Controls.Add(Me.cbxStructProdBonus_MatEff_1)
            Me.gpxStructProdBonuses.Controls.Add(Me.cbxStructProdBonus_Group_3)
            Me.gpxStructProdBonuses.Controls.Add(Me.lblItemGroup)
            Me.gpxStructProdBonuses.Controls.Add(Me.cbxStructProdBonus_Group_2)
            Me.gpxStructProdBonuses.Controls.Add(Me.cbxStructProdBonus_Group_1)
            Me.gpxStructProdBonuses.Location = New System.Drawing.Point(12, 96)
            Me.gpxStructProdBonuses.Name = "gpxStructProdBonuses"
            Me.gpxStructProdBonuses.Size = New System.Drawing.Size(290, 121)
            Me.gpxStructProdBonuses.TabIndex = 1
            Me.gpxStructProdBonuses.TabStop = False
            Me.gpxStructProdBonuses.Text = "Manufacturing Jobs Bonuses from Rigs"
            '
            'lblStructProdBonus_TimEff
            '
            Me.lblStructProdBonus_TimEff.AutoSize = True
            Me.lblStructProdBonus_TimEff.Location = New System.Drawing.Point(219, 18)
            Me.lblStructProdBonus_TimEff.Name = "lblStructProdBonus_TimEff"
            Me.lblStructProdBonus_TimEff.Size = New System.Drawing.Size(54, 13)
            Me.lblStructProdBonus_TimEff.TabIndex = 0
            Me.lblStructProdBonus_TimEff.Text = "TE Bonus"
            '
            'lblStructProdBonus_MatEff
            '
            Me.lblStructProdBonus_MatEff.AutoSize = True
            Me.lblStructProdBonus_MatEff.Location = New System.Drawing.Point(157, 18)
            Me.lblStructProdBonus_MatEff.Name = "lblStructProdBonus_MatEff"
            Me.lblStructProdBonus_MatEff.Size = New System.Drawing.Size(56, 13)
            Me.lblStructProdBonus_MatEff.TabIndex = 0
            Me.lblStructProdBonus_MatEff.Text = "ME Bonus"
            '
            'cbxStructProdBonus_TimEff_3
            '
            Me.cbxStructProdBonus_TimEff_3.Enabled = False
            Me.cbxStructProdBonus_TimEff_3.FormattingEnabled = True
            Me.cbxStructProdBonus_TimEff_3.Location = New System.Drawing.Point(222, 90)
            Me.cbxStructProdBonus_TimEff_3.Name = "cbxStructProdBonus_TimEff_3"
            Me.cbxStructProdBonus_TimEff_3.Size = New System.Drawing.Size(56, 21)
            Me.cbxStructProdBonus_TimEff_3.TabIndex = 10
            '
            'cbxStructProdBonus_TimEff_2
            '
            Me.cbxStructProdBonus_TimEff_2.Enabled = False
            Me.cbxStructProdBonus_TimEff_2.FormattingEnabled = True
            Me.cbxStructProdBonus_TimEff_2.Location = New System.Drawing.Point(222, 65)
            Me.cbxStructProdBonus_TimEff_2.Name = "cbxStructProdBonus_TimEff_2"
            Me.cbxStructProdBonus_TimEff_2.Size = New System.Drawing.Size(56, 21)
            Me.cbxStructProdBonus_TimEff_2.TabIndex = 9
            '
            'cbxStructProdBonus_TimEff_1
            '
            Me.cbxStructProdBonus_TimEff_1.Enabled = False
            Me.cbxStructProdBonus_TimEff_1.FormattingEnabled = True
            Me.cbxStructProdBonus_TimEff_1.Location = New System.Drawing.Point(222, 38)
            Me.cbxStructProdBonus_TimEff_1.Name = "cbxStructProdBonus_TimEff_1"
            Me.cbxStructProdBonus_TimEff_1.Size = New System.Drawing.Size(56, 21)
            Me.cbxStructProdBonus_TimEff_1.TabIndex = 8
            '
            'cbxStructProdBonus_MatEff_3
            '
            Me.cbxStructProdBonus_MatEff_3.Enabled = False
            Me.cbxStructProdBonus_MatEff_3.FormattingEnabled = True
            Me.cbxStructProdBonus_MatEff_3.Location = New System.Drawing.Point(160, 90)
            Me.cbxStructProdBonus_MatEff_3.Name = "cbxStructProdBonus_MatEff_3"
            Me.cbxStructProdBonus_MatEff_3.Size = New System.Drawing.Size(56, 21)
            Me.cbxStructProdBonus_MatEff_3.TabIndex = 7
            '
            'cbxStructProdBonus_MatEff_2
            '
            Me.cbxStructProdBonus_MatEff_2.Enabled = False
            Me.cbxStructProdBonus_MatEff_2.FormattingEnabled = True
            Me.cbxStructProdBonus_MatEff_2.Location = New System.Drawing.Point(160, 65)
            Me.cbxStructProdBonus_MatEff_2.Name = "cbxStructProdBonus_MatEff_2"
            Me.cbxStructProdBonus_MatEff_2.Size = New System.Drawing.Size(56, 21)
            Me.cbxStructProdBonus_MatEff_2.TabIndex = 6
            '
            'cbxStructProdBonus_MatEff_1
            '
            Me.cbxStructProdBonus_MatEff_1.Enabled = False
            Me.cbxStructProdBonus_MatEff_1.FormattingEnabled = True
            Me.cbxStructProdBonus_MatEff_1.Location = New System.Drawing.Point(160, 38)
            Me.cbxStructProdBonus_MatEff_1.Name = "cbxStructProdBonus_MatEff_1"
            Me.cbxStructProdBonus_MatEff_1.Size = New System.Drawing.Size(56, 21)
            Me.cbxStructProdBonus_MatEff_1.TabIndex = 5
            '
            'cbxStructProdBonus_Group_3
            '
            Me.cbxStructProdBonus_Group_3.Enabled = False
            Me.cbxStructProdBonus_Group_3.FormattingEnabled = True
            Me.cbxStructProdBonus_Group_3.Location = New System.Drawing.Point(6, 90)
            Me.cbxStructProdBonus_Group_3.Name = "cbxStructProdBonus_Group_3"
            Me.cbxStructProdBonus_Group_3.Size = New System.Drawing.Size(148, 21)
            Me.cbxStructProdBonus_Group_3.TabIndex = 4
            '
            'lblItemGroup
            '
            Me.lblItemGroup.AutoSize = True
            Me.lblItemGroup.Location = New System.Drawing.Point(3, 18)
            Me.lblItemGroup.Name = "lblItemGroup"
            Me.lblItemGroup.Size = New System.Drawing.Size(64, 13)
            Me.lblItemGroup.TabIndex = 3
            Me.lblItemGroup.Text = "Items Group"
            '
            'cbxStructProdBonus_Group_2
            '
            Me.cbxStructProdBonus_Group_2.Enabled = False
            Me.cbxStructProdBonus_Group_2.FormattingEnabled = True
            Me.cbxStructProdBonus_Group_2.Location = New System.Drawing.Point(6, 65)
            Me.cbxStructProdBonus_Group_2.Name = "cbxStructProdBonus_Group_2"
            Me.cbxStructProdBonus_Group_2.Size = New System.Drawing.Size(148, 21)
            Me.cbxStructProdBonus_Group_2.TabIndex = 1
            '
            'cbxStructProdBonus_Group_1
            '
            Me.cbxStructProdBonus_Group_1.Enabled = False
            Me.cbxStructProdBonus_Group_1.FormattingEnabled = True
            Me.cbxStructProdBonus_Group_1.Location = New System.Drawing.Point(6, 38)
            Me.cbxStructProdBonus_Group_1.Name = "cbxStructProdBonus_Group_1"
            Me.cbxStructProdBonus_Group_1.Size = New System.Drawing.Size(148, 21)
            Me.cbxStructProdBonus_Group_1.TabIndex = 0
            '
            'gpxStructScienceBonuses
            '
            Me.gpxStructScienceBonuses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gpxStructScienceBonuses.Controls.Add(Me.lblStructScieBonus_TimEff)
            Me.gpxStructScienceBonuses.Controls.Add(Me.cbxStructScieBonus_Group_1)
            Me.gpxStructScienceBonuses.Controls.Add(Me.lblStructScieBonus_CosEff)
            Me.gpxStructScienceBonuses.Controls.Add(Me.cbxStructScieBonus_Group_2)
            Me.gpxStructScienceBonuses.Controls.Add(Me.cbxStructScieBonus_TimEff_3)
            Me.gpxStructScienceBonuses.Controls.Add(Me.lblScienceJobType)
            Me.gpxStructScienceBonuses.Controls.Add(Me.cbxStructScieBonus_TimEff_2)
            Me.gpxStructScienceBonuses.Controls.Add(Me.cbxStructScieBonus_Group_3)
            Me.gpxStructScienceBonuses.Controls.Add(Me.cbxStructScieBonus_TimEff_1)
            Me.gpxStructScienceBonuses.Controls.Add(Me.cbxStructScieBonus_CosEff_1)
            Me.gpxStructScienceBonuses.Controls.Add(Me.cbxStructScieBonus_CosEff_3)
            Me.gpxStructScienceBonuses.Controls.Add(Me.cbxStructScieBonus_CosEff_2)
            Me.gpxStructScienceBonuses.Location = New System.Drawing.Point(12, 223)
            Me.gpxStructScienceBonuses.Name = "gpxStructScienceBonuses"
            Me.gpxStructScienceBonuses.Size = New System.Drawing.Size(290, 121)
            Me.gpxStructScienceBonuses.TabIndex = 2
            Me.gpxStructScienceBonuses.TabStop = False
            Me.gpxStructScienceBonuses.Text = "Science Jobs Bonuses from Rigs"
            '
            'lblStructScieBonus_TimEff
            '
            Me.lblStructScieBonus_TimEff.AutoSize = True
            Me.lblStructScieBonus_TimEff.Location = New System.Drawing.Point(219, 19)
            Me.lblStructScieBonus_TimEff.Name = "lblStructScieBonus_TimEff"
            Me.lblStructScieBonus_TimEff.Size = New System.Drawing.Size(54, 13)
            Me.lblStructScieBonus_TimEff.TabIndex = 11
            Me.lblStructScieBonus_TimEff.Text = "TE Bonus"
            '
            'cbxStructScieBonus_Group_1
            '
            Me.cbxStructScieBonus_Group_1.Enabled = False
            Me.cbxStructScieBonus_Group_1.FormattingEnabled = True
            Me.cbxStructScieBonus_Group_1.Location = New System.Drawing.Point(6, 39)
            Me.cbxStructScieBonus_Group_1.Name = "cbxStructScieBonus_Group_1"
            Me.cbxStructScieBonus_Group_1.Size = New System.Drawing.Size(148, 21)
            Me.cbxStructScieBonus_Group_1.TabIndex = 13
            '
            'lblStructScieBonus_CosEff
            '
            Me.lblStructScieBonus_CosEff.AutoSize = True
            Me.lblStructScieBonus_CosEff.Location = New System.Drawing.Point(157, 19)
            Me.lblStructScieBonus_CosEff.Name = "lblStructScieBonus_CosEff"
            Me.lblStructScieBonus_CosEff.Size = New System.Drawing.Size(54, 13)
            Me.lblStructScieBonus_CosEff.TabIndex = 12
            Me.lblStructScieBonus_CosEff.Text = "CE Bonus"
            '
            'cbxStructScieBonus_Group_2
            '
            Me.cbxStructScieBonus_Group_2.Enabled = False
            Me.cbxStructScieBonus_Group_2.FormattingEnabled = True
            Me.cbxStructScieBonus_Group_2.Location = New System.Drawing.Point(6, 66)
            Me.cbxStructScieBonus_Group_2.Name = "cbxStructScieBonus_Group_2"
            Me.cbxStructScieBonus_Group_2.Size = New System.Drawing.Size(148, 21)
            Me.cbxStructScieBonus_Group_2.TabIndex = 14
            '
            'cbxStructScieBonus_TimEff_3
            '
            Me.cbxStructScieBonus_TimEff_3.Enabled = False
            Me.cbxStructScieBonus_TimEff_3.FormattingEnabled = True
            Me.cbxStructScieBonus_TimEff_3.Location = New System.Drawing.Point(222, 91)
            Me.cbxStructScieBonus_TimEff_3.Name = "cbxStructScieBonus_TimEff_3"
            Me.cbxStructScieBonus_TimEff_3.Size = New System.Drawing.Size(56, 21)
            Me.cbxStructScieBonus_TimEff_3.TabIndex = 22
            '
            'lblScienceJobType
            '
            Me.lblScienceJobType.AutoSize = True
            Me.lblScienceJobType.Location = New System.Drawing.Point(3, 19)
            Me.lblScienceJobType.Name = "lblScienceJobType"
            Me.lblScienceJobType.Size = New System.Drawing.Size(98, 13)
            Me.lblScienceJobType.TabIndex = 15
            Me.lblScienceJobType.Text = "Science Jobs Type"
            '
            'cbxStructScieBonus_TimEff_2
            '
            Me.cbxStructScieBonus_TimEff_2.Enabled = False
            Me.cbxStructScieBonus_TimEff_2.FormattingEnabled = True
            Me.cbxStructScieBonus_TimEff_2.Location = New System.Drawing.Point(222, 66)
            Me.cbxStructScieBonus_TimEff_2.Name = "cbxStructScieBonus_TimEff_2"
            Me.cbxStructScieBonus_TimEff_2.Size = New System.Drawing.Size(56, 21)
            Me.cbxStructScieBonus_TimEff_2.TabIndex = 21
            '
            'cbxStructScieBonus_Group_3
            '
            Me.cbxStructScieBonus_Group_3.Enabled = False
            Me.cbxStructScieBonus_Group_3.FormattingEnabled = True
            Me.cbxStructScieBonus_Group_3.Location = New System.Drawing.Point(6, 91)
            Me.cbxStructScieBonus_Group_3.Name = "cbxStructScieBonus_Group_3"
            Me.cbxStructScieBonus_Group_3.Size = New System.Drawing.Size(148, 21)
            Me.cbxStructScieBonus_Group_3.TabIndex = 16
            '
            'cbxStructScieBonus_TimEff_1
            '
            Me.cbxStructScieBonus_TimEff_1.Enabled = False
            Me.cbxStructScieBonus_TimEff_1.FormattingEnabled = True
            Me.cbxStructScieBonus_TimEff_1.Location = New System.Drawing.Point(222, 39)
            Me.cbxStructScieBonus_TimEff_1.Name = "cbxStructScieBonus_TimEff_1"
            Me.cbxStructScieBonus_TimEff_1.Size = New System.Drawing.Size(56, 21)
            Me.cbxStructScieBonus_TimEff_1.TabIndex = 20
            '
            'cbxStructScieBonus_CosEff_1
            '
            Me.cbxStructScieBonus_CosEff_1.Enabled = False
            Me.cbxStructScieBonus_CosEff_1.FormattingEnabled = True
            Me.cbxStructScieBonus_CosEff_1.Location = New System.Drawing.Point(160, 39)
            Me.cbxStructScieBonus_CosEff_1.Name = "cbxStructScieBonus_CosEff_1"
            Me.cbxStructScieBonus_CosEff_1.Size = New System.Drawing.Size(56, 21)
            Me.cbxStructScieBonus_CosEff_1.TabIndex = 17
            '
            'cbxStructScieBonus_CosEff_3
            '
            Me.cbxStructScieBonus_CosEff_3.Enabled = False
            Me.cbxStructScieBonus_CosEff_3.FormattingEnabled = True
            Me.cbxStructScieBonus_CosEff_3.Location = New System.Drawing.Point(160, 91)
            Me.cbxStructScieBonus_CosEff_3.Name = "cbxStructScieBonus_CosEff_3"
            Me.cbxStructScieBonus_CosEff_3.Size = New System.Drawing.Size(56, 21)
            Me.cbxStructScieBonus_CosEff_3.TabIndex = 19
            '
            'cbxStructScieBonus_CosEff_2
            '
            Me.cbxStructScieBonus_CosEff_2.Enabled = False
            Me.cbxStructScieBonus_CosEff_2.FormattingEnabled = True
            Me.cbxStructScieBonus_CosEff_2.Location = New System.Drawing.Point(160, 66)
            Me.cbxStructScieBonus_CosEff_2.Name = "cbxStructScieBonus_CosEff_2"
            Me.cbxStructScieBonus_CosEff_2.Size = New System.Drawing.Size(56, 21)
            Me.cbxStructScieBonus_CosEff_2.TabIndex = 18
            '
            'btnCancel
            '
            Me.btnCancel.Location = New System.Drawing.Point(227, 350)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.TabIndex = 3
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = True
            '
            'btnSave
            '
            Me.btnSave.Location = New System.Drawing.Point(146, 350)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(75, 23)
            Me.btnSave.TabIndex = 4
            Me.btnSave.Text = "Save"
            Me.btnSave.UseVisualStyleBackColor = True
            '
            'frmFavoriteStructure
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(314, 379)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.gpxStructScienceBonuses)
            Me.Controls.Add(Me.gpxStructProdBonuses)
            Me.Controls.Add(Me.pnlStructDefinition)
            Me.Name = "frmFavoriteStructure"
            Me.Text = "Favorite Structure"
            Me.pnlStructDefinition.ResumeLayout(False)
            Me.pnlStructDefinition.PerformLayout()
            Me.gpxStructProdBonuses.ResumeLayout(False)
            Me.gpxStructProdBonuses.PerformLayout()
            Me.gpxStructScienceBonuses.ResumeLayout(False)
            Me.gpxStructScienceBonuses.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlStructDefinition As Windows.Forms.Panel
        Friend WithEvents cbxStructLocation As Windows.Forms.ComboBox
        Friend WithEvents cbxStructType As Windows.Forms.ComboBox
        Friend WithEvents tfStructName As Windows.Forms.TextBox
        Friend WithEvents lblStructLocation As Windows.Forms.Label
        Friend WithEvents lblStructType As Windows.Forms.Label
        Friend WithEvents lblStructName As Windows.Forms.Label
        Friend WithEvents gpxStructProdBonuses As Windows.Forms.GroupBox
        Friend WithEvents gpxStructScienceBonuses As Windows.Forms.GroupBox
        Friend WithEvents cbxStructProdBonus_MatEff_1 As Windows.Forms.ComboBox
        Friend WithEvents cbxStructProdBonus_Group_3 As Windows.Forms.ComboBox
        Friend WithEvents lblItemGroup As Windows.Forms.Label
        Friend WithEvents cbxStructProdBonus_Group_2 As Windows.Forms.ComboBox
        Friend WithEvents cbxStructProdBonus_Group_1 As Windows.Forms.ComboBox
        Friend WithEvents cbxStructProdBonus_TimEff_3 As Windows.Forms.ComboBox
        Friend WithEvents cbxStructProdBonus_TimEff_2 As Windows.Forms.ComboBox
        Friend WithEvents cbxStructProdBonus_TimEff_1 As Windows.Forms.ComboBox
        Friend WithEvents cbxStructProdBonus_MatEff_3 As Windows.Forms.ComboBox
        Friend WithEvents cbxStructProdBonus_MatEff_2 As Windows.Forms.ComboBox
        Friend WithEvents lblStructProdBonus_TimEff As Windows.Forms.Label
        Friend WithEvents lblStructProdBonus_MatEff As Windows.Forms.Label
        Friend WithEvents lblStructScieBonus_TimEff As Windows.Forms.Label
        Friend WithEvents cbxStructScieBonus_Group_1 As Windows.Forms.ComboBox
        Friend WithEvents lblStructScieBonus_CosEff As Windows.Forms.Label
        Friend WithEvents cbxStructScieBonus_Group_2 As Windows.Forms.ComboBox
        Friend WithEvents cbxStructScieBonus_TimEff_3 As Windows.Forms.ComboBox
        Friend WithEvents lblScienceJobType As Windows.Forms.Label
        Friend WithEvents cbxStructScieBonus_TimEff_2 As Windows.Forms.ComboBox
        Friend WithEvents cbxStructScieBonus_Group_3 As Windows.Forms.ComboBox
        Friend WithEvents cbxStructScieBonus_TimEff_1 As Windows.Forms.ComboBox
        Friend WithEvents cbxStructScieBonus_CosEff_1 As Windows.Forms.ComboBox
        Friend WithEvents cbxStructScieBonus_CosEff_3 As Windows.Forms.ComboBox
        Friend WithEvents cbxStructScieBonus_CosEff_2 As Windows.Forms.ComboBox
        Friend WithEvents btnCancel As Windows.Forms.Button
        Friend WithEvents btnSave As Windows.Forms.Button
    End Class

End Namespace
