Namespace Global.EveHQ.Plugins.Prism.UpwellStructures

    Public Class BonusFilter

        Private _marketGroupId As Integer
        Private _technologyLevel As Integer

        ''' <summary>
        ''' The Market Group ID to which filter is related
        ''' </summary>
        ''' <returns></returns>
        Public Property MarketGroupId() As Integer
            Get
                Return _marketGroupId
            End Get
            Set(ByVal value As Integer)
                _marketGroupId = value
            End Set
        End Property

        ''' <summary>
        ''' The Technology Level to which filter should be applied
        ''' </summary>
        ''' <returns></returns>
        Public Property TechnologyLevel() As Integer
            Get
                Return _technologyLevel
            End Get
            Set(ByVal value As Integer)
                _technologyLevel = value
            End Set
        End Property

        Public Sub New(marketGroupId As Integer, technologyLevel As Integer)

            Me._marketGroupId = marketGroupId
            Me._technologyLevel = technologyLevel

        End Sub

    End Class

End Namespace
