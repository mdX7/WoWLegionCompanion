﻿using System;
using System.Runtime.Serialization;
using JamLib;

namespace WowJamMessages.MobileClientJSON
{
	[System.Runtime.Serialization.DataContract]
	[FlexJamStruct(Name = "MobileWorldQuestBounty", Version = 39869590u)]
	public class MobileWorldQuestBounty
	{
		[System.Runtime.Serialization.DataMember(Name = "item")]
		[FlexJamMember(ArrayDimensions = 1, Name = "item", Type = FlexJamType.Struct)]
		public MobileWorldQuestReward[] Item { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "endTime")]
		[FlexJamMember(Name = "endTime", Type = FlexJamType.Int32)]
		public int EndTime { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "numNeeded")]
		[FlexJamMember(Name = "numNeeded", Type = FlexJamType.Int32)]
		public int NumNeeded { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "experience")]
		[FlexJamMember(Name = "experience", Type = FlexJamType.Int32)]
		public int Experience { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "questID")]
		[FlexJamMember(Name = "questID", Type = FlexJamType.Int32)]
		public int QuestID { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "iconFileDataID")]
		[FlexJamMember(Name = "iconFileDataID", Type = FlexJamType.Int32)]
		public int IconFileDataID { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "numCompleted")]
		[FlexJamMember(Name = "numCompleted", Type = FlexJamType.Int32)]
		public int NumCompleted { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "money")]
		[FlexJamMember(Name = "money", Type = FlexJamType.Int32)]
		public int Money { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "startTime")]
		[FlexJamMember(Name = "startTime", Type = FlexJamType.Int32)]
		public int StartTime { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "currency")]
		[FlexJamMember(ArrayDimensions = 1, Name = "currency", Type = FlexJamType.Struct)]
		public MobileWorldQuestReward[] Currency { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "faction")]
		[FlexJamMember(ArrayDimensions = 1, Name = "faction", Type = FlexJamType.Struct)]
		public MobileWorldQuestReward[] Faction { get; set; }
	}
}
