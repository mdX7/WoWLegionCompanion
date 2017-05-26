﻿using System;
using System.Runtime.Serialization;
using JamLib;

namespace WowJamMessages
{
	[System.Runtime.Serialization.DataContract]
	[FlexJamStruct(Name = "JamPlayerGuidLookupData", Version = 28333852u)]
	public class JamPlayerGuidLookupData
	{
		public JamPlayerGuidLookupData()
		{
			this.DeclinedNames = new string[5];
		}

		[FlexJamMember(Name = "level", Type = FlexJamType.UInt8)]
		[System.Runtime.Serialization.DataMember(Name = "level")]
		public byte Level { get; set; }

		[FlexJamMember(Name = "wowAccount", Type = FlexJamType.WowGuid)]
		[System.Runtime.Serialization.DataMember(Name = "wowAccount")]
		public string WowAccount { get; set; }

		[FlexJamMember(ArrayDimensions = 1, Name = "declinedNames", Type = FlexJamType.String)]
		[System.Runtime.Serialization.DataMember(Name = "declinedNames")]
		public string[] DeclinedNames { get; set; }

		[FlexJamMember(Name = "guidActual", Type = FlexJamType.WowGuid)]
		[System.Runtime.Serialization.DataMember(Name = "guidActual")]
		public string GuidActual { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "virtualRealmAddress")]
		[FlexJamMember(Name = "virtualRealmAddress", Type = FlexJamType.UInt32)]
		public uint VirtualRealmAddress { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "race")]
		[FlexJamMember(Name = "race", Type = FlexJamType.UInt8)]
		public byte Race { get; set; }

		[FlexJamMember(Name = "name", Type = FlexJamType.String)]
		[System.Runtime.Serialization.DataMember(Name = "name")]
		public string Name { get; set; }

		[FlexJamMember(Name = "classID", Type = FlexJamType.UInt8)]
		[System.Runtime.Serialization.DataMember(Name = "classID")]
		public byte ClassID { get; set; }

		[FlexJamMember(Name = "sex", Type = FlexJamType.UInt8)]
		[System.Runtime.Serialization.DataMember(Name = "sex")]
		public byte Sex { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "isDeleted")]
		[FlexJamMember(Name = "isDeleted", Type = FlexJamType.Bool)]
		public bool IsDeleted { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "bnetAccount")]
		[FlexJamMember(Name = "bnetAccount", Type = FlexJamType.WowGuid)]
		public string BnetAccount { get; set; }
	}
}
