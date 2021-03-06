﻿using System;
using System.Runtime.Serialization;
using JamLib;

namespace WowJamMessages
{
	[System.Runtime.Serialization.DataContract]
	[FlexJamStruct(Name = "JamGarrisonMobileMission", Version = 28333852u)]
	public class JamGarrisonMobileMission
	{
		[System.Runtime.Serialization.DataMember(Name = "offerTime")]
		[FlexJamMember(Name = "offerTime", Type = FlexJamType.Int64)]
		public long OfferTime { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "travelDuration")]
		[FlexJamMember(Name = "travelDuration", Type = FlexJamType.Int64)]
		public long TravelDuration { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "missionRecID")]
		[FlexJamMember(Name = "missionRecID", Type = FlexJamType.Int32)]
		public int MissionRecID { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "missionState")]
		[FlexJamMember(Name = "missionState", Type = FlexJamType.Int32)]
		public int MissionState { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "encounter")]
		[FlexJamMember(ArrayDimensions = 1, Name = "encounter", Type = FlexJamType.Struct)]
		public JamGarrisonEncounter[] Encounter { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "reward")]
		[FlexJamMember(ArrayDimensions = 1, Name = "reward", Type = FlexJamType.Struct)]
		public JamGarrisonMissionReward[] Reward { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "startTime")]
		[FlexJamMember(Name = "startTime", Type = FlexJamType.Int64)]
		public long StartTime { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "dbID")]
		[FlexJamMember(Name = "dbID", Type = FlexJamType.UInt64)]
		public ulong DbID { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "offerDuration")]
		[FlexJamMember(Name = "offerDuration", Type = FlexJamType.Int64)]
		public long OfferDuration { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "overmaxReward")]
		[FlexJamMember(ArrayDimensions = 1, Name = "overmaxReward", Type = FlexJamType.Struct)]
		public JamGarrisonMissionReward[] OvermaxReward { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "missionDuration")]
		[FlexJamMember(Name = "missionDuration", Type = FlexJamType.Int64)]
		public long MissionDuration { get; set; }
	}
}
