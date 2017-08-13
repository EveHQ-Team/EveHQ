Imports EveHQ.EveData

''' <summary>
''' A Structure Definition
''' </summary>
Public Class StructurePreference

    ''' <summary>
    ''' The Name of the Structure
    ''' </summary>
    Private _name As String

    ''' <summary>
    ''' The Name of the Structure
    ''' </summary>
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    ''' <summary>
    ''' The Type of the Structure
    ''' </summary>
    Private _type As EveType

    ''' <summary>
    ''' The Type of the Structure
    ''' </summary>
    Public Property Type() As EveType
        Get
            Return _type
        End Get
        Set(ByVal value As EveType)
            _type = value
        End Set
    End Property

    ''' <summary>
    ''' The Solar System where the Structure is located
    ''' </summary>
    Private _location As SolarSystem

    ''' <summary>
    ''' The Solar System where the Structure is located
    ''' </summary>
    Public Property Location() As SolarSystem
        Get
            Return _location
        End Get
        Set(value As SolarSystem)
            _location = value
        End Set
    End Property

    ''' <summary>
    ''' A list of bonuses which will be applied to the structure for manufacturing jobs
    ''' </summary>
    Private _manufacturingBonuses As List(Of StructureBonus)

    ''' <summary>
    ''' A list of bonuses which will be applied to the structure for manufacturing jobs
    ''' </summary>
    Public Property ManufacturingBonuses As List(Of StructureBonus)
        Get
            Return _manufacturingBonuses
        End Get
        Set(value As List(Of StructureBonus))
            _manufacturingBonuses = value
        End Set
    End Property

    ''' <summary>
    ''' A list of bonuses which will be applied to the structure for science jobs (Invention, ME/TE Research, Copy)
    ''' </summary>
    Private _scienceBonuses As List(Of StructureBonus)

    Public Property ScienceBonuses As List(Of StructureBonus)
        Get
            Return _scienceBonuses
        End Get
        Set(value As List(Of StructureBonus))
            _scienceBonuses = value
        End Set
    End Property

    Public Sub New()

        Me.Name = ""
        Me._manufacturingBonuses = New List(Of StructureBonus)
        Me._scienceBonuses = New List(Of StructureBonus)

    End Sub

    ''' <summary>
    ''' A list of possible EveType for Structure Type
    ''' </summary>
    ''' <returns></returns>
    Public Function GetPossibleTypes() As List(Of EveType)

        Dim possibleTypes = From type In StaticData.Types().Values
                            Where type.Category = 65
                            Where type.Published = True
                            Order By type.Name

        Return possibleTypes.ToList()

    End Function

End Class
