﻿using System;
using System.Runtime.Serialization;
using JamLib;

namespace WowJamMessages.MobileClientJSON
{
	[System.Runtime.Serialization.DataContract]
	[FlexJamStruct(Name = "MobileBountiesByWorldQuest", Version = 39869590u)]
	public class MobileBountiesByWorldQuest
	{
		[System.Runtime.Serialization.DataMember(Name = "bountyQuestID")]
		[FlexJamMember(ArrayDimensions = 1, Name = "bountyQuestID", Type = FlexJamType.Int32)]
		public int[] BountyQuestID { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "questID")]
		[FlexJamMember(Name = "questID", Type = FlexJamType.Int32)]
		public int QuestID { get; set; }
	}
}
