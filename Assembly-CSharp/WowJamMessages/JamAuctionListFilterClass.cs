﻿using System;
using System.Runtime.Serialization;
using JamLib;

namespace WowJamMessages
{
	[System.Runtime.Serialization.DataContract]
	[FlexJamStruct(Name = "JamAuctionListFilterClass", Version = 28333852u)]
	public class JamAuctionListFilterClass
	{
		[System.Runtime.Serialization.DataMember(Name = "itemClass")]
		[FlexJamMember(Name = "itemClass", Type = FlexJamType.Int32)]
		public int ItemClass { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "subClasses")]
		[FlexJamMember(ArrayDimensions = 1, Name = "subClasses", Type = FlexJamType.Struct)]
		public JamAuctionListFilterSubClass[] SubClasses { get; set; }
	}
}
