﻿using System;
using System.Runtime.Serialization;
using JamLib;

namespace WowJamMessages.MobileClientJSON
{
	[System.Runtime.Serialization.DataContract]
	[FlexJamMessage(Id = 4845, Name = "MobileClientStartMissionResult", Version = 39869590u)]
	public class MobileClientStartMissionResult
	{
		[System.Runtime.Serialization.DataMember(Name = "garrMissionID")]
		[FlexJamMember(Name = "garrMissionID", Type = FlexJamType.Int32)]
		public int GarrMissionID { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "result")]
		[FlexJamMember(Name = "result", Type = FlexJamType.Int32)]
		public int Result { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "newDailyMissionCounter")]
		[FlexJamMember(Name = "newDailyMissionCounter", Type = FlexJamType.UInt16)]
		public ushort NewDailyMissionCounter { get; set; }
	}
}
