Imports EveHQ.EveData

''' <summary>
''' A Structure Bonus Definition
''' </summary>
Public Class StructureBonus

    Private _group As String
    Private _materialEfficiency As Decimal
    Private _timeEfficiency As Decimal
    Private _costEfficiency As Decimal
    Private _scienceBonus As Boolean

    ''' <summary>
    ''' The Group to which the Bonus should be Applied
    ''' </summary>
    Public Property Group As String
        Get
            Return _group
        End Get
        Set(value As String)
            _group = value
        End Set
    End Property

    ''' <summary>
    ''' The Material Efficiency Rate provided Bonus
    ''' </summary>
    Public Property MaterialEfficiency As Decimal
        Get
            Return _materialEfficiency
        End Get
        Set(value As Decimal)
            _materialEfficiency = value
        End Set
    End Property

    ''' <summary>
    ''' The Time Efficiency Rate provided Bonus
    ''' </summary>
    Public Property TimeEfficiency As Decimal
        Get
            Return _timeEfficiency
        End Get
        Set(value As Decimal)
            _timeEfficiency = value
        End Set
    End Property

    ''' <summary>
    ''' The Cost Efficiency Rate provided Bonus
    ''' </summary>
    Public Property CostEfficiency As Decimal
        Get
            Return _costEfficiency
        End Get
        Set(value As Decimal)
            _costEfficiency = value
        End Set
    End Property

    ''' <summary>
    ''' Determine if the Bonus should be applied to a Science job or a production job
    ''' </summary>
    Public Property IsScienceBonus As Boolean
        Get
            Return _scienceBonus
        End Get
        Set(value As Boolean)
            _scienceBonus = value
        End Set
    End Property

    Private _appliesToMarketGroups As Dictionary(Of Integer, Integer)

    ''' <summary>
    ''' Determine to which Item Market Group ID the bonus is applied
    ''' http://content.eveonline.com/www/newssystem/media/70592/1/EngineeringRigsv2.jpg
    ''' 
    ''' Key indicate item market group ID
    ''' Value indicate tech level, 0 mean no restriction
    ''' </summary>
    Public ReadOnly Property AppliesToMarketGroups() As Dictionary(Of Integer, Integer)
        Get
            Return _appliesToMarketGroups
        End Get
    End Property

    ''' <summary>
    ''' Search in the bonus array if we found the EveType Market Group ID for the associated Tech Level
    ''' </summary>
    ''' <param name="type">The EveType which should be checked</param>
    ''' <returns></returns>
    Public Function IsAppliedTo(type As EveType) As Boolean

        Return (From group In Me._appliesToMarketGroups
                Where group.Key = type.MarketGroupId
                Where StaticData.GetAttributeDataForItem(type.Id).  ' Fetch item attributes and check tech level (422)
                    Where(Function(a) a.Key.Equals(422)).
                    First().
                    Value.
                    Value = group.Value).
        Any()

    End Function

    ''' <summary>
    ''' Seeds bonus array with T1/Faction Frigates, Destroyers and Shuttles
    ''' </summary>
    Public Sub ApplyToT1SmallShips()

        Dim marketGroups As Integer() =
            New Integer() {
            61, 64, 72, 77, 1365, 1366, 1616, 1619, ' Frigates
            393, 394, 395, 396, 1618, 1631,         ' Shuttles
            465, 466, 467, 468, 2350,               ' Destroyers
            1619, 1816, 1817, 1818, 1819            ' Rookie Ships
        }

        Me.Apply(marketGroups, 1)

    End Sub

    ''' <summary>
    ''' Seeds bonus array with T2 Frigates and Destroyers
    ''' </summary>
    Public Sub ApplyToT2SmallShips()

        Dim marketGroups As Integer() =
            New Integer() {
            400, 401, 402, 403, 1932,   ' Interceptor
            421, 422, 423, 424,         ' Covert Ops / Stealth Bomber
            433, 434, 435, 436,         ' Assault Frigate
            826, 829, 832, 835,         ' Interdictors
            1066, 1067, 1068, 1069,     ' Electronic Attack Ship
            1924,                       ' Expedition Frigate
            2126, 2131, 2132, 2133,     ' Command Destroyer
            2147, 2148, 2149, 2150      ' Logistics Frigate
        }

        Me.Apply(marketGroups, 2)

    End Sub

    ''' <summary>
    ''' Seeds bonus array with T3 Destroyers
    ''' </summary>
    Public Sub ApplyToT3SmallShips()

        Dim marketGroups As Integer() =
            New Integer() {
            1952, 1953, 2021, 2034     ' Tactical Destroyer
        }

        Me.Apply(marketGroups, 3)

    End Sub

    ''' <summary>
    ''' Seeds bonus array with T1/Faction Cruisers, Battlecruisers, Industrial Ships and Mining Barges
    ''' </summary>
    Public Sub ApplyToT1MediumShips()

        Dim marketGroups As Integer() =
            New Integer() {
            73, 74, 75, 76, 1370, 1371, 1699, ' Cruisers
            82, 83, 84, 85, 1390, 1614,       ' Industrial Ships
            470, 471, 472, 473, 1698, 1704,   ' Attack Battlecruiser / Combat Battlecruisers
            494                               ' Mining Barges
        }

        Me.Apply(marketGroups, 1)

    End Sub

    ''' <summary>
    ''' Seeds bonus array with T2 Cruisers, Battlecruisers, Haulers and Exhumers
    ''' </summary>
    Public Sub ApplyToT2MediumShips()

        Dim marketGroups As Integer() =
            New Integer() {
            438, 439, 440, 441,       ' Logistics
            449, 450, 451, 452,       ' Havy Assault Cruisers
            630, 631, 632, 633,       ' Blockade Runners / Deep Space Transports
            825, 828, 831, 834,       ' Command Ships
            827, 830, 833, 836, 1837, ' Force Recon Ships
            874,                      ' Exhumers
            1071, 1072, 1073, 1074    ' Heavy Interdiction Cruisers
        }

        Me.Apply(marketGroups, 2)

    End Sub

    ''' <summary>
    ''' Seeds bonus array with T3 Cruisers and subsystems
    ''' </summary>
    Public Sub ApplyToT3MediumShips()

        Dim marketGroups As Integer() =
            New Integer() {
            1122, 1123, 1124, 1125, ' Core SubSystems
            1126, 1127, 1128, 1129, ' Defensive SubSystems
            1130, 1131, 1132, 1133, ' Offensive SubSystems
            1134, 1135, 1136, 1137, ' Propulsion SubSystems
            1139, 1140, 1141, 1142  ' Strategic Cruisers
        }

        Me.Apply(marketGroups, 3)

    End Sub

    ''' <summary>
    ''' Seeds bonus array with specifieds marketGroups for specified tech level
    ''' </summary>
    ''' <param name="marketGroups">The market groups with which bonus array should be seeded</param>
    ''' <param name="techLevel">The tech level for which bonus will be seeded</param>
    Private Sub Apply(marketGroups As Integer(), techLevel As Integer)
        For Each marketGroup As Integer In marketGroups

            If Not Me._appliesToMarketGroups.ContainsKey(marketGroup) Then
                Me._appliesToMarketGroups.Add(marketGroup, techLevel)
            End If

        Next
    End Sub

End Class
