// Проект: EveHQ.EveData
// Имя файла: Structure.cs
// GUID файла: 676820CA-4C35-40A8-B0F9-A61B6FE27941
// Автор: Mike Eshva (mike@eshva.ru)
// Дата создания: 13.08.2017

#region Usings

using System;
using ProtoBuf;

#endregion


namespace EveHQ.EveData
{
	[ProtoContract, Serializable]
	public class EveStructure
	{
		[ProtoMember(1)]
		public long StructureId { get; set; }

		[ProtoMember(2)]
		public string StructureName { get; set; }

		[ProtoMember(3)]
		public int StructureTypeId { get; set; }

		[ProtoMember(4)]
		public string StructureTypeName { get; set; }

		[ProtoMember(5)]
		public bool IsPublic { get; set; }

		[ProtoMember(6)]
		public int RegionId { get; set; }

		[ProtoMember(7)]
		public string RegionName { get; set; }

		[ProtoMember(8)]
		public int SystemId { get; set; }

		[ProtoMember(9)]
		public string SystemName { get; set; }
	}
}