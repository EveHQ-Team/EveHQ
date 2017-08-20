'==============================================================================
'
' EveHQ - An Eve-Online™ character assistance application
' Copyright © 2005-2015  EveHQ Development Team
'
' This file is part of EveHQ.
'
' The source code for EveHQ is free and you may redistribute 
' it and/or modify it under the terms of the MIT License. 
'
' Refer to the NOTICES file in the root folder of EVEHQ source
' project for details of 3rd party components that are covered
' under their own, separate licenses.
'
' EveHQ is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the MIT 
' license below for details.
'
' ------------------------------------------------------------------------------
'
' The MIT License (MIT)
'
' Copyright © 2005-2015  EveHQ Development Team
'
' Permission is hereby granted, free of charge, to any person obtaining a copy
' of this software and associated documentation files (the "Software"), to deal
' in the Software without restriction, including without limitation the rights
' to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
' copies of the Software, and to permit persons to whom the Software is
' furnished to do so, subject to the following conditions:
'
' The above copyright notice and this permission notice shall be included in
' all copies or substantial portions of the Software.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
' IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
' FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
' AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
' LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
' OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
' THE SOFTWARE.
'
' ==============================================================================

Imports EveHQ.Core
Imports EveHQ.EveData

Namespace Classes
	Public Class Locations
		Public Shared Function GetLocationFromID(locationId As Long) As AssetLocation
			If locationId >= 66014933 Then
				Return GetStructureLocation(locationId)
			End If
			
			If locationId >= 66000000 Then
				If locationId < 66014933 Then
					locationId = locationId - 6000001
				Else
					locationId = locationId - 6000000
				End If
			End If

			If CDbl(locationId) >= 61000000 And CDbl(locationId) <= 61999999 Then
				Return GetOutpostLocation(locationId)
			Else
				If locationId < 60000000 Then
					Return GetSolarSystemLocation(locationId)
				Else
					Return GetStationLocation(locationId)
				End If
			End If
		End Function

		Private Shared Function GetStationLocation(locationId As Long) As AssetLocation
			Dim result = New AssetLocation()

			If StaticData.Stations.ContainsKey(locationId) Then
				Dim newLocation = StaticData.Stations(locationId)
				result.ContainerName = newLocation.StationName
				result.ContainerId = newLocation.StationId
				result.SolarSystem = StaticData.SolarSystems(newLocation.SystemId)
			Else
				result.ContainerName = $"Unknown station {locationId}"
			End If

			Return result
		End Function

		Private Shared Function GetSolarSystemLocation(locationId As Long) As AssetLocation
			Dim result = New AssetLocation()

			If StaticData.SolarSystems.ContainsKey(CInt(locationId)) Then
				Dim newSystem As SolarSystem = StaticData.SolarSystems(CInt(locationId))
				result.ContainerName = newSystem.Name
				result.ContainerId = newSystem.Id
				result.SolarSystem = newSystem
			Else
				result.ContainerName = $"Unknown System {locationId}"
				result.ContainerId = locationId
				result.SolarSystem = Nothing
			End If

			Return result
		End Function

		Private Shared Function GetOutpostLocation(locationId As Long) As AssetLocation
			Dim result = New AssetLocation()

			If StaticData.Stations.ContainsKey(locationId) = True Then
				' Known Outpost
				Dim newLocation = StaticData.Stations(locationId)
				result.ContainerName = newLocation.StationName
				result.ContainerId = newLocation.StationId
				result.SolarSystem = StaticData.SolarSystems(newLocation.SystemId)
			Else
				' Unknown outpost!
				result.ContainerName = $"Unknown Outpost {locationId}"
				result.ContainerId = locationId
				result.SolarSystem = Nothing
			End If

			Return result
		End Function

		Private Shared Function GetStructureLocation(locationId As Long) As AssetLocation
			Dim result = New AssetLocation()
			Dim structureNameTask = HQ.ApiProvider.StructureName.GetStructureNameAsync(locationId)
			structureNameTask.Wait()
			If structureNameTask.Result.IsSuccess Then
				' Citadel or Engineering Complex
				Dim eveStructure As EveStructure = structureNameTask.Result.ResultData
				result.ContainerName = $"{eveStructure.StructureName} ({eveStructure.StructureTypeName})"
				result.ContainerId = locationId
				result.SolarSystem = StaticData.SolarSystems(eveStructure.SystemId)
			Else
				' Unknown system/station!
				result.ContainerName = $"Unknown Location {locationId} (Wreck?)"
				result.ContainerId = locationId
				result.SolarSystem = Nothing
			End If

			Return result
		End Function
	End Class
End Namespace