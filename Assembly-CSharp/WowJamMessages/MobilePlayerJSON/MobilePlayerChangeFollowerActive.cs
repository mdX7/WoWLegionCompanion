﻿using System;
using System.Runtime.Serialization;
using JamLib;

namespace WowJamMessages.MobilePlayerJSON
{
	[System.Runtime.Serialization.DataContract]
	[FlexJamMessage(Id = 4806, Name = "MobilePlayerChangeFollowerActive", Version = 38820897u)]
	public class MobilePlayerChangeFollowerActive
	{
		[System.Runtime.Serialization.DataMember(Name = "setInactive")]
		[FlexJamMember(Name = "setInactive", Type = FlexJamType.Bool)]
		public bool SetInactive { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "garrFollowerID")]
		[FlexJamMember(Name = "garrFollowerID", Type = FlexJamType.Int32)]
		public int GarrFollowerID { get; set; }
	}
}
