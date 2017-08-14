Imports System.Windows.Forms
Imports EveHQ.EveData

Namespace Global.EveHQ.Plugins.Prism.UpwellStructures

    Public Class frmUpwellStructure

        Private _FavoriteStructure As UpwellStructure

        ''' <summary>
        ''' Init a Structure Preference Window with empty structure
        ''' </summary>
        Public Sub New()

            Me.New(New UpwellStructure())

        End Sub

        ''' <summary>
        ''' Init a Structure Preference Window
        ''' </summary>
        ''' <param name="structPref">The Structure to which preference should be attached</param>
        Public Sub New(structPref As UpwellStructure)

            InitializeComponent()

            Me._FavoriteStructure = structPref

            ' Debug
            Me._FavoriteStructure.Location = StaticData.SolarSystems(30000142)
            Me._FavoriteStructure.ItemType = StaticData.Types(35827)

            ' Bind Structure Name
            Me.tfStructName.DataBindings.Add("Text", Me._FavoriteStructure, "Name", False, DataSourceUpdateMode.OnPropertyChanged)

            ' Init and Bing Structure Type
            Me.cbxStructType.DataSource = Me.GetPossibleTypes()
            Me.cbxStructType.DisplayMember = "Name"
            Me.cbxStructType.DataBindings.Add("SelectedItem", Me._FavoriteStructure, "ItemType")

            ' Init and Bind Location List
            Me.cbxStructLocation.DataSource = Me.GetPossibleLocations()
            Me.cbxStructLocation.DisplayMember = "Name"
            Me.cbxStructLocation.DataBindings.Add("SelectedItem", Me._FavoriteStructure, "Location")

            ' Init Bonus Binding
            Me.cbxStructProdBonus_Group_1.DisplayMember = "Name"
            Me.cbxStructProdBonus_Group_2.DisplayMember = "Name"
            Me.cbxStructProdBonus_Group_3.DisplayMember = "Name"

            Me.cbxStructScieBonus_Group_1.DisplayMember = "Name"
            Me.cbxStructScieBonus_Group_2.DisplayMember = "Name"
            Me.cbxStructScieBonus_Group_3.DisplayMember = "Name"

            CheckMandatoryFields()

        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        ''' <summary>
        ''' A list of possible EveType for Structure Type
        ''' </summary>
        ''' <returns></returns>
        Private Function GetPossibleTypes() As List(Of EveType)

            Dim possibleTypes = From type In StaticData.Types().Values
                                Where type.Category = 65 ' Structures
                                Where type.Published = True
                                Order By type.Name

            Return possibleTypes.ToList()

        End Function

        ''' <summary>
        ''' A list of possible SolarSystems for Structure Location
        ''' </summary>
        ''' <returns></returns>
        Private Function GetPossibleLocations() As List(Of SolarSystem)

            Dim possibleLocations = From solarSystem In StaticData.SolarSystems.Values
                                    Order By solarSystem.Name
                                    Select solarSystem

            Return possibleLocations.ToList()

        End Function

        Private Function GetPossibleBonuses() As List(Of Bonus)

            ' Fetch RigSize attribute related to the current structure in order to determine which set should be load
            Dim rigSize As Double = (From attribute In StaticData.GetAttributeDataForItem(Me._FavoriteStructure.ItemType.Id).Values
                                     Where attribute.Id = 1547
                                     Select attribute.Value).FirstOrDefault()

            Select Case rigSize
                Case 2
                    Return Me.GetMediumBonusSets()
                Case 3
                    Return Me.GetLargeBonusSets()
                Case 4
                    Return Me.GetXLargeBonusSets()
            End Select

            Return New List(Of Bonus)

        End Function

        Private Function GetMediumBonusSets() As List(Of Bonus)

            Dim bonusSets As List(Of Bonus) = New List(Of Bonus)

            Dim bonus As Bonus = New Bonus("Ammunition, Charges, Scripts (T1)", 0.02D, 0.2D, 0, JobType.Manufacturing)
            ' ME
            bonus.MaterialEfficiencyModificators.Add(SolarSystemSecurityRange.Low, 1.9D)
            bonus.MaterialEfficiencyModificators.Add(SolarSystemSecurityRange.Null, 2.1D)
            ' TE
            bonus.TimeEfficiencyModificators.Add(SolarSystemSecurityRange.Low, 1.9D)
            bonus.TimeEfficiencyModificators.Add(SolarSystemSecurityRange.Null, 2.1D)

            bonusSets.Add(bonus.ApplyToCharges())

            bonus = New Bonus("Ammunition, Charges, Scripts (T2)", 0.02D, 0.24D, JobType.Manufacturing)
            ' ME
            bonus.MaterialEfficiencyModificators.Add(SolarSystemSecurityRange.Low, 1.9D)
            bonus.MaterialEfficiencyModificators.Add(SolarSystemSecurityRange.Null, 2.1D)
            ' TE
            bonus.TimeEfficiencyModificators.Add(SolarSystemSecurityRange.Low, 1.9D)
            bonus.TimeEfficiencyModificators.Add(SolarSystemSecurityRange.Null, 2.1D)

            bonusSets.Add(bonus.ApplyToCharges())

            bonus = New Bonus("Drones, Fighters (T1)", 0.02D, 0.2D, 0, JobType.Manufacturing)
            ' ME
            bonus.MaterialEfficiencyModificators.Add(SolarSystemSecurityRange.Low, 1.9D)
            bonus.MaterialEfficiencyModificators.Add(SolarSystemSecurityRange.Null, 2.1D)
            ' TE
            bonus.TimeEfficiencyModificators.Add(SolarSystemSecurityRange.Low, 1.9D)
            bonus.TimeEfficiencyModificators.Add(SolarSystemSecurityRange.Null, 2.1D)

            bonusSets.Add(bonus.ApplyToDrones())

            bonus = New Bonus("Drones, Fighters (T2)", 0.024D, 0.24D, 0, JobType.Manufacturing)
            ' ME
            bonus.MaterialEfficiencyModificators.Add(SolarSystemSecurityRange.Low, 1.9D)
            bonus.MaterialEfficiencyModificators.Add(SolarSystemSecurityRange.Null, 2.1D)
            ' TE
            bonus.TimeEfficiencyModificators.Add(SolarSystemSecurityRange.Low, 1.9D)
            bonus.TimeEfficiencyModificators.Add(SolarSystemSecurityRange.Null, 2.1D)

            bonusSets.Add(bonus.ApplyToDrones())

            bonus = New Bonus("Frigates, Destroyers, Shuttles (T1)", 0.02D, 0.2D, 0, JobType.Manufacturing)
            ' ME
            bonus.MaterialEfficiencyModificators.Add(SolarSystemSecurityRange.Low, 1.9D)
            bonus.MaterialEfficiencyModificators.Add(SolarSystemSecurityRange.Null, 2.1D)
            ' TE
            bonus.TimeEfficiencyModificators.Add(SolarSystemSecurityRange.Low, 1.9D)
            bonus.TimeEfficiencyModificators.Add(SolarSystemSecurityRange.Null, 2.1D)

            bonusSets.Add(bonus.ApplyToT1SmallShips())

            bonus = New Bonus("Frigates, Destroyers, Shuttles (T2)", 0.024D, 0.24D, 0, JobType.Manufacturing)
            ' ME
            bonus.MaterialEfficiencyModificators.Add(SolarSystemSecurityRange.Low, 1.9D)
            bonus.MaterialEfficiencyModificators.Add(SolarSystemSecurityRange.Null, 2.1D)
            ' TE
            bonus.TimeEfficiencyModificators.Add(SolarSystemSecurityRange.Low, 1.9D)
            bonus.TimeEfficiencyModificators.Add(SolarSystemSecurityRange.Null, 2.1D)

            bonusSets.Add(bonus.ApplyToT1SmallShips())

            bonus = New Bonus("Cruisers, Battlecruisers, Industrial Ships, Mining Barges (T1)", 0.02D, 0.2D, 0, JobType.Manufacturing)
            ' ME
            bonus.MaterialEfficiencyModificators.Add(SolarSystemSecurityRange.Low, 1.9D)
            bonus.MaterialEfficiencyModificators.Add(SolarSystemSecurityRange.Null, 2.1D)
            ' TE
            bonus.TimeEfficiencyModificators.Add(SolarSystemSecurityRange.Low, 1.9D)
            bonus.TimeEfficiencyModificators.Add(SolarSystemSecurityRange.Null, 2.1D)

            bonusSets.Add(bonus.ApplyToT1MediumShips())

            bonus = New Bonus("Cruisers, Battlecruisers, Industrial Ships, Mining Barges (T2)", 0.024D, 0.24D, 0, JobType.Manufacturing)
            ' ME
            bonus.MaterialEfficiencyModificators.Add(SolarSystemSecurityRange.Low, 1.9D)
            bonus.MaterialEfficiencyModificators.Add(SolarSystemSecurityRange.Null, 2.1D)
            ' TE
            bonus.TimeEfficiencyModificators.Add(SolarSystemSecurityRange.Low, 1.9D)
            bonus.TimeEfficiencyModificators.Add(SolarSystemSecurityRange.Null, 2.1D)

            bonusSets.Add(bonus.ApplyToT1MediumShips())

            Return bonusSets

        End Function

        Private Function GetLargeBonusSets() As List(Of Bonus)

            Dim bonusSets As List(Of Bonus) = New List(Of Bonus)

            Return bonusSets

        End Function

        Private Function GetXLargeBonusSets() As List(Of Bonus)

            Dim bonusSets As List(Of Bonus) = New List(Of Bonus)

            Return bonusSets

        End Function

        ''' <summary>
        ''' Ensure that all required field are filled before enabling bonus grids
        ''' </summary>
        Private Sub CheckMandatoryFields()

            Me.cbxStructProdBonus_Group_1.Enabled = False
            Me.cbxStructProdBonus_Group_2.Enabled = False
            Me.cbxStructProdBonus_Group_3.Enabled = False

            Me.cbxStructScieBonus_Group_1.Enabled = False
            Me.cbxStructScieBonus_Group_2.Enabled = False
            Me.cbxStructScieBonus_Group_3.Enabled = False

            If Not String.IsNullOrEmpty(Me._FavoriteStructure.Name) And Me._FavoriteStructure.Location IsNot Nothing And Me._FavoriteStructure.ItemType IsNot Nothing Then

                Me.cbxStructProdBonus_Group_1.Enabled = True
                Me.cbxStructProdBonus_Group_2.Enabled = True
                Me.cbxStructProdBonus_Group_3.Enabled = True

                Me.cbxStructScieBonus_Group_1.Enabled = True
                Me.cbxStructScieBonus_Group_2.Enabled = True
                Me.cbxStructScieBonus_Group_3.Enabled = True

            End If

            Me.Update()

        End Sub

        Private Sub tfStructName_Validated(sender As Object, e As EventArgs) Handles tfStructName.Validated

            Me.CheckMandatoryFields()

        End Sub

        Private Sub cbxStructType_Validated(sender As Object, e As EventArgs) Handles cbxStructType.Validated

            If Me._FavoriteStructure.Location IsNot Nothing Then

                Me.cbxStructProdBonus_Group_1.DataSource = Me.GetPossibleBonuses()
                Me.cbxStructProdBonus_Group_2.DataSource = Me.GetPossibleBonuses()
                Me.cbxStructProdBonus_Group_3.DataSource = Me.GetPossibleBonuses()

            End If

        End Sub

        Private Sub cbxStructLocation_Validated(sender As Object, e As EventArgs) Handles cbxStructLocation.Validated

            If Me._FavoriteStructure.ItemType IsNot Nothing Then

                Me.cbxStructProdBonus_Group_1.DataSource = Me.GetPossibleBonuses()
                Me.cbxStructProdBonus_Group_2.DataSource = Me.GetPossibleBonuses()
                Me.cbxStructProdBonus_Group_3.DataSource = Me.GetPossibleBonuses()

            End If

        End Sub
    End Class

End Namespace
