﻿using System;
using System.Runtime.Serialization;
using JamLib;

namespace WowJamMessages
{
	[System.Runtime.Serialization.DataContract]
	[FlexJamStruct(Name = "JamBattlePayProductGroup", Version = 28333852u)]
	public class JamBattlePayProductGroup
	{
		[System.Runtime.Serialization.DataMember(Name = "iconFileDataID")]
		[FlexJamMember(Name = "iconFileDataID", Type = FlexJamType.Int32)]
		public int IconFileDataID { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "name")]
		[FlexJamMember(Name = "name", Type = FlexJamType.String)]
		public string Name { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "displayType")]
		[FlexJamMember(Name = "displayType", Type = FlexJamType.UInt8)]
		public byte DisplayType { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "ordering")]
		[FlexJamMember(Name = "ordering", Type = FlexJamType.Int32)]
		public int Ordering { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "groupID")]
		[FlexJamMember(Name = "groupID", Type = FlexJamType.UInt32)]
		public uint GroupID { get; set; }
	}
}
