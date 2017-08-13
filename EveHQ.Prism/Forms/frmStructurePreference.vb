Imports System.Windows.Forms
Imports EveHQ.EveData

Public Class frmStructurePreference

    Private _StructurePreference As StructurePreference
    Private _Initialized As Boolean

    ''' <summary>
    ''' Init a Structure Preference Window with empty structure
    ''' </summary>
    Public Sub New()

        Me.New(New StructurePreference())

    End Sub

    ''' <summary>
    ''' Init a Structure Preference Window
    ''' </summary>
    ''' <param name="structPref">The Structure to which preference should be attached</param>
    Public Sub New(structPref As StructurePreference)

        InitializeComponent()

        Me._StructurePreference = structPref

        ' Debug
        Me._StructurePreference.Location = StaticData.SolarSystems(30000142)
        Me._StructurePreference.Type = StaticData.Types(35827)

        ' Bind Structure Name
        Me.tfStructName.DataBindings.Add("Text", Me._StructurePreference, "Name")

        ' Init and Bing Structure Type
        Me.cbxStructType.DataSource = Me._StructurePreference.GetPossibleTypes()
        Me.cbxStructType.DisplayMember = "Name"
        Me.cbxStructType.DataBindings.Add("SelectedItem", Me._StructurePreference, "Type")

        ' Init and Bind Location List
        Me.cbxStructLocation.DataSource = (From solarSystem In StaticData.SolarSystems.Values
                                           Order By solarSystem.Name
                                           Select solarSystem).ToList()
        Me.cbxStructLocation.DisplayMember = "Name"
        Me.cbxStructLocation.DataBindings.Add("SelectedItem", Me._StructurePreference, "Location")

        Me._Initialized = True

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub
End Class