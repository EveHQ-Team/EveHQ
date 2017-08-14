Imports EveHQ.EveData

Namespace Global.EveHQ.Plugins.Prism.UpwellStructures

    ''' <summary>
    ''' A Structure Definition
    ''' </summary>
    Public Class UpwellStructure

        Private _name As String
        Private _itemType As EveType
        Private _location As SolarSystem
        Private _bonuses As List(Of Bonus)

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
        Public Property ItemType() As EveType
            Get
                Return _itemType
            End Get
            Set(ByVal value As EveType)
                _itemType = value
            End Set
        End Property

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
        Public ReadOnly Property ManufacturingBonuses As List(Of Bonus)
            Get
                Return _bonuses.Where(Function(b) Not b.IsScienceBonus).ToList()
            End Get
        End Property

        ''' <summary>
        ''' A list of bonuses which will be applied to the structure for science jobs (Invention, ME/TE Research, Copy)
        ''' </summary>
        Public ReadOnly Property ScienceBonuses As List(Of Bonus)
            Get
                Return _bonuses.Where(Function(b) b.IsScienceBonus).ToList()
            End Get
        End Property

        Public Sub New()

            Me.Name = ""
            Me._bonuses = New List(Of Bonus)

        End Sub

    End Class

End Namespace
