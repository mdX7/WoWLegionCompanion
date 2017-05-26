﻿using System;
using System.Runtime.Serialization;
using JamLib;

namespace WowJamMessages.MobileClientJSON
{
	[System.Runtime.Serialization.DataContract]
	[FlexJamMessage(Id = 4878, Name = "MobileClientWorldQuestInactiveBountiesResult", Version = 39869590u)]
	public class MobileClientWorldQuestInactiveBountiesResult
	{
		[FlexJamMember(ArrayDimensions = 1, Name = "bounty", Type = FlexJamType.Struct)]
		[System.Runtime.Serialization.DataMember(Name = "bounty")]
		public MobileWorldQuestBounty[] Bounty { get; set; }
	}
}
