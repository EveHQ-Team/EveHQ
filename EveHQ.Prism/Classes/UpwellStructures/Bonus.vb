Imports EveHQ.EveData
Imports EveHQ.Prism.BPCalc

Namespace Global.EveHQ.Plugins.Prism.UpwellStructures

    ''' <summary>
    ''' A Structure Bonus Definition
    ''' </summary>
    Public Class Bonus

        Private _name As String
        Private _materialEfficiency As Decimal
        Private _materialEfficiencyModificators As Dictionary(Of SolarSystemSecurityRange, Decimal)
        Private _timeEfficiency As Decimal
        Private _timeEfficiencyModificators As Dictionary(Of SolarSystemSecurityRange, Decimal)
        Private _costEfficiency As Decimal
        Private _costEfficiencyModificators As Dictionary(Of SolarSystemSecurityRange, Decimal)
        Private _jobType As JobType
        Private _appliesToMarketGroups As HashSet(Of BonusFilter)

        ''' <summary>
        ''' The Group to which the Bonus should be Applied
        ''' </summary>
        Public Property Name As String
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value
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
        ''' The Material Efficiency Modificators according to System Security Level
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property MaterialEfficiencyModificators As Dictionary(Of SolarSystemSecurityRange, Decimal)
            Get
                Return _materialEfficiencyModificators
            End Get
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
        ''' The Time Efficiency Modificators according to System Security Level
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property TimeEfficiencyModificators As Dictionary(Of SolarSystemSecurityRange, Decimal)
            Get
                Return _timeEfficiencyModificators
            End Get
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
        ''' The Cost Efficiency Modificators according to System Security Level
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property CostEfficiencyModificators As Dictionary(Of SolarSystemSecurityRange, Decimal)
            Get
                Return _costEfficiencyModificators
            End Get
        End Property

        ''' <summary>
        ''' Determine to which job type the bonus should be applied
        ''' This property is binary wide and multiple jobtype can be assigned to the bonus
        ''' </summary>
        ''' <returns></returns>
        Public Property JobType() As JobType
            Get
                Return Me._jobType
            End Get
            Set(ByVal value As JobType)
                Me._jobType = value
            End Set
        End Property

        ''' <summary>
        ''' Determine if the Bonus should be applied to a Science job or a production job
        ''' </summary>
        Public ReadOnly Property IsScienceBonus As Boolean
            Get
                Return ((JobType.Copying Or JobType.Invention Or JobType.MaterialEfficiencyResearch Or JobType.TimeEfficiencyResearch) = Me._jobType)
            End Get
        End Property

        ''' <summary>
        ''' Determine to which Item Market Group ID the bonus is applied
        ''' http://content.eveonline.com/www/newssystem/media/70592/1/EngineeringRigsv2.jpg
        ''' </summary>
        Public ReadOnly Property AppliesToMarketGroups() As HashSet(Of BonusFilter)
            Get
                Return _appliesToMarketGroups
            End Get
        End Property

        ''' <summary>
        ''' Init a new Structure Bonus with the specified name
        ''' Set the JobType to All and ME, TE, CE to 0
        ''' </summary>
        ''' <param name="name">The name of the structure bonus</param>
        Public Sub New(name As String)
            Me.New(name, 0, 0, 0)
        End Sub

        Public Sub New(name As String, jobType As JobType)
            Me.New(name, 0, 0, 0, jobType)
        End Sub

        ''' <summary>
        ''' Init a new Structure Bonus with the specified name, ME, TE and CE
        ''' Set the JobType to All
        ''' </summary>
        ''' <param name="name"></param>
        ''' <param name="materialEfficiency"></param>
        ''' <param name="timeEfficiency"></param>
        ''' <param name="costEfficiency"></param>
        Public Sub New(name As String, materialEfficiency As Decimal, timeEfficiency As Decimal, costEfficiency As Decimal)
            Me.New(name, materialEfficiency, timeEfficiency, costEfficiency, (JobType.Copying And JobType.Invention And JobType.Manufacturing And JobType.MaterialEfficiencyResearch And JobType.TimeEfficiencyResearch))
        End Sub

        ''' <summary>
        ''' Init a new Structure Bonus with the specified name, ME, TE, CE and JobType
        ''' </summary>
        ''' <param name="name"></param>
        ''' <param name="materialEfficiency"></param>
        ''' <param name="timeEfficiency"></param>
        ''' <param name="costEfficiency"></param>
        ''' <param name="jobType"></param>
        Public Sub New(name As String, materialEfficiency As Decimal, timeEfficiency As Decimal, costEfficiency As Decimal, jobType As JobType)

            Me._appliesToMarketGroups = New HashSet(Of BonusFilter)
            Me._materialEfficiencyModificators = New Dictionary(Of SolarSystemSecurityRange, Decimal)
            Me._timeEfficiencyModificators = New Dictionary(Of SolarSystemSecurityRange, Decimal)
            Me._costEfficiencyModificators = New Dictionary(Of SolarSystemSecurityRange, Decimal)

            Me._name = name
            Me._materialEfficiency = materialEfficiency
            Me._timeEfficiency = timeEfficiency
            Me._costEfficiency = _costEfficiency
            Me._jobType = jobType

        End Sub

        ''' <summary>
        ''' Return the ME value for the specified Solar System
        ''' </summary>
        ''' <param name="solarSystem"></param>
        ''' <returns></returns>
        Public Function GetMaterialEfficiency(solarSystem As SolarSystem) As Decimal
            Select Case solarSystem.Security
                Case >= 5
                    Return Me.GetMaterialEfficiency(SolarSystemSecurityRange.High)
                Case > 0
                    Return Me.GetMaterialEfficiency(SolarSystemSecurityRange.Low)
                Case Else
                    Return Me.GetMaterialEfficiency(SolarSystemSecurityRange.Null)
            End Select
        End Function

        ''' <summary>
        ''' Return the ME value for the specified solar system security level
        ''' </summary>
        ''' <param name="security"></param>
        ''' <returns></returns>
        Public Function GetMaterialEfficiency(security As SolarSystemSecurityRange) As Decimal
            If Me._materialEfficiencyModificators.ContainsKey(security) Then
                Return Me._materialEfficiency * Me._materialEfficiencyModificators(security)
            End If

            Return Me._materialEfficiency
        End Function

        ''' <summary>
        ''' Return the TE value for the specified Solar System
        ''' </summary>
        ''' <param name="solarSystem"></param>
        ''' <returns></returns>
        Public Function GetTimeEfficiency(solarSystem As SolarSystem) As Decimal
            Select Case solarSystem.Security
                Case >= 5
                    Return Me.GetTimeEfficiency(SolarSystemSecurityRange.High)
                Case > 0
                    Return Me.GetTimeEfficiency(SolarSystemSecurityRange.Low)
                Case Else
                    Return Me.GetTimeEfficiency(SolarSystemSecurityRange.Null)
            End Select
        End Function

        ''' <summary>
        ''' Return the TE value for the specified solar system security level
        ''' </summary>
        ''' <param name="security"></param>
        ''' <returns></returns>
        Public Function GetTimeEfficiency(security As SolarSystemSecurityRange) As Decimal
            If Me._timeEfficiencyModificators.ContainsKey(security) Then
                Return Me._timeEfficiency * Me._timeEfficiencyModificators(security)
            End If

            Return Me._timeEfficiency
        End Function

        ''' <summary>
        ''' Return the CE value for the specified Solar System
        ''' </summary>
        ''' <param name="solarSystem"></param>
        ''' <returns></returns>
        Public Function GetCostEfficiency(solarSystem As SolarSystem) As Decimal
            Select Case solarSystem.Security
                Case >= 5
                    Return Me.GetCostEfficiency(SolarSystemSecurityRange.High)
                Case > 0
                    Return Me.GetCostEfficiency(SolarSystemSecurityRange.Low)
                Case Else
                    Return Me.GetCostEfficiency(SolarSystemSecurityRange.Null)
            End Select
        End Function

        ''' <summary>
        ''' Return the CE value for the specified solar system security level
        ''' </summary>
        ''' <param name="security"></param>
        ''' <returns></returns>
        Public Function GetCostEfficiency(security As SolarSystemSecurityRange) As Decimal
            If Me._costEfficiencyModificators.ContainsKey(security) Then
                Return Me._costEfficiency * Me._costEfficiencyModificators(security)
            End If

            Return Me._costEfficiency
        End Function

        ''' <summary>
        ''' Check if the structure bonus should be applied to the job
        ''' </summary>
        ''' <param name="job">The Job which should be checked</param>
        ''' <returns></returns>
        Public Function IsAppliedTo(job As Job) As Boolean

            ' Check if the job is an invention job, therefore, apply bitwise operation on the bonus job type
            If job.HasInventionJob Then

                Return ((Me._jobType And JobType.Invention) = JobType.Invention)

            End If

            ' Check if the job is an ME job, therefore, apply bitwise operation on the bonus job type
            If Not String.IsNullOrEmpty(job.OverridingME) Then

                Return ((Me._jobType And JobType.MaterialEfficiencyResearch) = JobType.MaterialEfficiencyResearch)

            End If

            ' Check if the job is a TE job, therefore, apply bitwise operation on the bonus job type
            If Not String.IsNullOrEmpty(job.OverridingPE) Then

                Return ((Me._jobType And JobType.TimeEfficiencyResearch) = JobType.TimeEfficiencyResearch)

            End If

            Return Me.IsAppliedTo(StaticData.Types(job.CurrentBlueprint.ProductId))

        End Function

        ''' <summary>
        ''' Search in the bonus array if we found the EveType Market Group ID for the associated Tech Level
        ''' </summary>
        ''' <param name="type">The EveType which should be checked</param>
        ''' <returns></returns>
        Public Function IsAppliedTo(type As EveType) As Boolean

            Dim techLevel As Double = StaticData.GetAttributeDataForItem(type.Id).  ' Fetch item attributes for tech level (422)
                      Values.
                      Where(Function(a) a.Id.Equals(422)).
                      Select(Function(a) a.Value).
                      FirstOrDefault()

            Return (From group In Me._appliesToMarketGroups
                    Where group.MarketGroupId = type.MarketGroupId
                    Where group.TechnologyLevel = techLevel Or group.TechnologyLevel = 0).Any()

        End Function

        ''' <summary>
        ''' Seeds bonus array with T1/Faction Frigates, Destroyers and Shuttles
        ''' </summary>
        Public Function ApplyToT1SmallShips() As Bonus

            Dim marketGroups As Integer() = (From marketGroup In StaticData.MarketGroups.Values
                                             Where (marketGroup.ParentGroupId = 5 Or marketGroup.ParentGroupId = 1362 Or
                                 marketGroup.ParentGroupId = 464 Or marketGroup.ParentGroupId = 391 Or
                                 marketGroup.ParentGroupId = 1815)
                                             Select marketGroup.Id).ToArray()

            Return Me.Apply(marketGroups, 1)

        End Function

        ''' <summary>
        ''' Seeds bonus array with T2 Frigates and Destroyers
        ''' </summary>
        Public Function ApplyToT2SmallShips() As Bonus

            Dim marketGroups As Integer() = (From marketGroup In StaticData.MarketGroups.Values
                                             Where (marketGroup.ParentGroupId = 432 Or marketGroup.ParentGroupId = 420 Or
                                 marketGroup.ParentGroupId = 1065 Or marketGroup.ParentGroupId = 399 Or
                                 marketGroup.ParentGroupId = 2146 Or marketGroup.ParentGroupId = 2125 Or
                                 marketGroup.ParentGroupId = 823)
                                             Select marketGroup.Id).ToArray()

            marketGroups = marketGroups.Union({1924}).ToArray()

            Return Me.Apply(marketGroups, 2)

        End Function

        ''' <summary>
        ''' Seeds bonus array with T3 Destroyers
        ''' </summary>
        Public Function ApplyToT3SmallShips() As Bonus

            Dim marketGroups As Integer() = (From marketGroup In StaticData.MarketGroups.Values
                                             Where marketGroup.ParentGroupId = 1951
                                             Select marketGroup.Id).ToArray()

            Return Me.Apply(marketGroups, 3)

        End Function

        ''' <summary>
        ''' Seeds bonus array with T1/Faction Cruisers, Battlecruisers, Industrial Ships and Mining Barges
        ''' </summary>
        Public Function ApplyToT1MediumShips() As Bonus

            Dim marketGroups As Integer() = (From marketGroup In StaticData.MarketGroups.Values
                                             Where (marketGroup.ParentGroupId = 6 Or marketGroup.ParentGroupId = 8 Or
                                 marketGroup.ParentGroupId = 1369 Or marketGroup.ParentGroupId = 469 Or
                                 marketGroup.ParentGroupId = 1703)
                                             Select marketGroup.Id).ToArray()

            marketGroups = marketGroups.Union({494}).ToArray()

            Return Me.Apply(marketGroups, 1)

        End Function

        ''' <summary>
        ''' Seeds bonus array with T2 Cruisers, Battlecruisers, Haulers and Exhumers
        ''' </summary>
        Public Function ApplyToT2MediumShips() As Bonus

            Dim marketGroups As Integer() = (From marketGroup In StaticData.MarketGroups.Values
                                             Where (marketGroup.ParentGroupId = 437 Or marketGroup.ParentGroupId = 448 Or
                                 marketGroup.ParentGroupId = 1070 Or marketGroup.ParentGroupId = 822 Or
                                 marketGroup.ParentGroupId = 824 Or marketGroup.ParentGroupId = 829)
                                             Select marketGroup.Id).ToArray()

            marketGroups = marketGroups.Union({874}).ToArray()

            Return Me.Apply(marketGroups, 2)

        End Function

        ''' <summary>
        ''' Seeds bonus array with T3 Cruisers and subsystems
        ''' </summary>
        Public Function ApplyToT3MediumShips() As Bonus

            Dim marketGroups As Integer() = (From marketGroup In StaticData.MarketGroups.Values
                                             Where (marketGroup.ParentGroupId = 1610 Or marketGroup.ParentGroupId = 1625 Or
                                 marketGroup.ParentGroupId = 1627 Or marketGroup.ParentGroupId = 1626 Or
                                 marketGroup.ParentGroupId = 1138)
                                             Select marketGroup.Id).ToArray()

            Return Me.Apply(marketGroups, 3)

        End Function

        ''' <summary>
        ''' Seeds bonus array with T1/Factions Battleships, Freighters and Industrial Command Ships
        ''' </summary>
        Public Function ApplyToT1LargeShips() As Bonus

            Dim marketGroups As Integer() = (From marketGroup In StaticData.MarketGroups.Values
                                             Where (marketGroup.ParentGroupId = 7 Or marketGroup.ParentGroupId = 1378 Or
                                 marketGroup.ParentGroupId = 766 Or marketGroup.ParentGroupId = 2335)
                                             Select marketGroup.Id).ToArray()

            Return Me.Apply(marketGroups, 1)

        End Function

        ''' <summary>
        ''' Seeds bonus array with T2 Battleships, Freighters
        ''' </summary>
        Public Function ApplyToT2LargeShips() As Bonus

            Dim marketGroups As Integer() = (From marketGroup In StaticData.MarketGroups.Values
                                             Where (marketGroup.ParentGroupId = 1075 Or marketGroup.ParentGroupId = 1089 Or
                                 marketGroup.ParentGroupId = 1080)
                                             Select marketGroup.Id).ToArray()

            Return Me.Apply(marketGroups, 2)

        End Function

        ''' <summary>
        ''' Seeds bonus array with T1/Faction Capitals
        ''' </summary>
        Public Function ApplyToT1CapitalShips() As Bonus

            Dim marketGroups As Integer() = (From marketGroup In StaticData.MarketGroups.Values
                                             Where (marketGroup.ParentGroupId = 817 Or marketGroup.ParentGroupId = 761 Or
                                 marketGroup.ParentGroupId = 2271)
                                             Select marketGroup.Id).ToArray()

            Return Me.Apply(marketGroups, 1)

        End Function

        ''' <summary>
        ''' Seeds bonus array with T1/Faction Super Capitals
        ''' </summary>
        Public Function ApplyToT1SuperCapitalShips() As Bonus

            Dim marketGroups As Integer() = (From marketGroup In StaticData.MarketGroups.Values
                                             Where marketGroup.ParentGroupId = 812 Or marketGroup.ParentGroupId = 817
                                             Select marketGroup.Id).ToArray()

            Return Me.Apply(marketGroups, 1)

        End Function

        ''' <summary>
        ''' Seeds bonus array with T1/T2/Faction Drones and Fighters
        ''' </summary>
        Public Function ApplyToDrones() As Bonus

            Dim marketGroups As Integer() = (From marketGroup In StaticData.MarketGroups.Values
                                             Where (marketGroup.ParentGroupId = 159 Or marketGroup.ParentGroupId = 2236)
                                             Select marketGroup.Id).ToArray()

            marketGroups = marketGroups.Union({158, 841, 842, 843, 1646}).ToArray()

            Return Me.Apply(marketGroups, 0)

        End Function

        ''' <summary>
        ''' Seeds bonus array with T1/T2/Faction Charges
        ''' </summary>
        Public Function ApplyToCharges() As Bonus

            Dim marketGroups As Integer() = (From marketGroup In StaticData.MarketGroups.Values
                                             Where (marketGroup.ParentGroupId = 2297 Or marketGroup.ParentGroupId = 852 Or
                                 marketGroup.ParentGroupId = 853 Or marketGroup.ParentGroupId = 994 Or
                                 marketGroup.ParentGroupId = 851 Or marketGroup.ParentGroupId = 848 Or
                                 marketGroup.ParentGroupId = 990 Or marketGroup.ParentGroupId = 849 Or
                                 marketGroup.ParentGroupId = 850 Or marketGroup.ParentGroupId = 115 Or
                                 marketGroup.ParentGroupId = 580 Or marketGroup.ParentGroupId = 968 Or
                                 marketGroup.ParentGroupId = 581 Or marketGroup.ParentGroupId = 117 Or
                                 marketGroup.ParentGroupId = 118 Or marketGroup.ParentGroupId = 387 Or
                                 marketGroup.ParentGroupId = 1316 Or marketGroup.ParentGroupId = 505 Or
                                 marketGroup.ParentGroupId = 120 Or marketGroup.ParentGroupId = 846 Or
                                 marketGroup.ParentGroupId = 847 Or marketGroup.ParentGroupId = 986 Or
                                 marketGroup.ParentGroupId = 845)
                                             Select marketGroup.Id).ToArray()

            marketGroups = marketGroups.Union({116, 2197, 2196, 1015, 139, 593, 1103, 1094, 2198}).ToArray()

            Return Me.Apply(marketGroups, 0)

        End Function

        ''' <summary>
        ''' Seeds bonus array with T1 Capital Construction Components
        ''' </summary>
        Public Function ApplyToT1CapConstComponents() As Bonus

            Dim marketGroups As Integer() = {781}

            Return Me.Apply(marketGroups, 0)

        End Function

        ''' <summary>
        ''' Seeds bonus array with T2 Capital Construction Components
        ''' </summary>
        Public Function ApplyToT2CapConstComponents() As Bonus

            Dim marketGroups As Integer() = (From marketGroup In StaticData.MarketGroups.Values
                                             Where marketGroup.ParentGroupId = 1883
                                             Select marketGroup.Id).ToArray()

            Return Me.Apply(marketGroups, 0)

        End Function

        ''' <summary>
        ''' Seeds bonus array with T2 Construction Components
        ''' </summary>
        Public Function ApplyToT2ConstComponents() As Bonus

            Dim marketGroups As Integer() = (From marketGroup In StaticData.MarketGroups.Values
                                             Where marketGroup.ParentGroupId = 65
                                             Select marketGroup.Id).ToArray()

            Return Me.Apply(marketGroups, 0)

        End Function

        ''' <summary>
        ''' Seeds bonus array with T3 Construction Components
        ''' </summary>
        Public Function ApplyToT3ConstComponents() As Bonus

            Dim marketGroups As Integer() = {1147}

            Return Me.Apply(marketGroups, 0)

        End Function

        ''' <summary>
        ''' Seeds bonus array with Structure Components
        ''' </summary>
        Public Function ApplyToStructureComponents() As Bonus

            Dim marketGroups As Integer() = (From marketGroup In StaticData.MarketGroups.Values
                                             Where marketGroup.ParentGroupId = 1021
                                             Select marketGroup.Id).ToArray()

            Return Me.Apply(marketGroups, 0)

        End Function

        ''' <summary>
        ''' Seeds bonus array with Structure Modifications
        ''' </summary>
        Public Function ApplyToStructureModifications() As Bonus

            Dim marketGroups As Integer() = (From marketGroup In StaticData.MarketGroups.Values
                                             Where (marketGroup.ParentGroupId = 2205 Or marketGroup.ParentGroupId = 2340 Or
                                 marketGroup.ParentGroupId = 2204)
                                             Select marketGroup.Id).ToArray()

            Return Me.Apply(marketGroups, 0)

        End Function

        ''' <summary>
        ''' Seeds bonus array with Structure Equipments
        ''' </summary>
        Public Function ApplyToStructureEquipments() As Bonus

            Dim marketGroups As Integer() = (From marketGroup In StaticData.MarketGroups.Values
                                             Where (marketGroup.ParentGroupId = 2206 Or marketGroup.ParentGroupId = 2207 Or
                                 marketGroup.ParentGroupId = 2208 Or marketGroup.ParentGroupId = 2210 Or
                                 marketGroup.ParentGroupId = 2209 Or marketGroup.ParentGroupId = 2227 Or
                                 marketGroup.ParentGroupId = 2226)
                                             Select marketGroup.Id).ToArray()

            Return Me.Apply(marketGroups, 0)

        End Function

        ''' <summary>
        ''' Seeds bonus array with Upwell Structure
        ''' </summary>
        Public Function ApplyToUpwellStructure() As Bonus

            Dim marketGroups As Integer() = (From marketGroup In StaticData.MarketGroups.Values
                                             Where (marketGroup.ParentGroupId = 2199 Or marketGroup.ParentGroupId = 2324)
                                             Select marketGroup.Id).ToArray()

            Return Me.Apply(marketGroups, 0)

        End Function

        ''' <summary>
        ''' Seeds bonus array with Starbase Structure
        ''' </summary>
        Public Function ApplyToStarbaseStructure() As Bonus

            Dim marketGroups As Integer() = (From marketGroup In StaticData.MarketGroups.Values
                                             Where (marketGroup.ParentGroupId = 1285 Or marketGroup.ParentGroupId = 2324 Or
                                 marketGroup.ParentGroupId = 1534)
                                             Select marketGroup.Id).ToArray()

            Return Me.Apply(marketGroups, 0)

        End Function

        ''' <summary>
        ''' Seeds bonus array with Fuel Blocks
        ''' </summary>
        Public Function ApplyToFuelBlocks() As Bonus

            Dim marketGroups As Integer() = {1870}

            Return Me.Apply(marketGroups, 0)

        End Function

        ''' <summary>
        ''' Seeds bonus array with Deployable Structure
        ''' </summary>
        Public Function ApplyToDeployableStructure() As Bonus

            Dim marketGroups As Integer() = (From marketGroup In StaticData.MarketGroups.Values
                                             Where (marketGroup.ParentGroupId = 404 Or marketGroup.ParentGroupId = 379)
                                             Select marketGroup.Id).ToArray()

            Return Me.Apply(marketGroups, 0)

        End Function

        ''' <summary>
        ''' Seeds bonus array with specifieds marketGroups for specified tech level
        ''' </summary>
        ''' <param name="marketGroups">The market groups with which bonus array should be seeded</param>
        ''' <param name="techLevel">The tech level for which bonus will be seeded</param>
        Private Function Apply(marketGroups As Integer(), techLevel As Integer) As Bonus

            For Each marketGroup As Integer In marketGroups

                Me._appliesToMarketGroups.Add(New BonusFilter(marketGroup, techLevel))

            Next

            Return Me

        End Function

    End Class

End Namespace
