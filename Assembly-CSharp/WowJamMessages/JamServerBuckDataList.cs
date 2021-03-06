﻿using System;
using System.Runtime.Serialization;
using JamLib;

namespace WowJamMessages
{
	[System.Runtime.Serialization.DataContract]
	[FlexJamStruct(Name = "JamServerBuckDataList", Version = 28333852u)]
	public class JamServerBuckDataList
	{
		[System.Runtime.Serialization.DataMember(Name = "mpID")]
		[FlexJamMember(Name = "mpID", Type = FlexJamType.UInt32)]
		public uint MpID { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "entries")]
		[FlexJamMember(ArrayDimensions = 1, Name = "entries", Type = FlexJamType.Struct)]
		public JamServerBuckDataEntry[] Entries { get; set; }
	}
}
