﻿using System;
using System.Runtime.Serialization;
using JamLib;

namespace WowJamMessages.MobileClientJSON
{
	[System.Runtime.Serialization.DataContract]
	[FlexJamMessage(Id = 4863, Name = "MobileClientCompleteShipmentResult", Version = 39869590u)]
	public class MobileClientCompleteShipmentResult
	{
		[System.Runtime.Serialization.DataMember(Name = "shipmentID")]
		[FlexJamMember(Name = "shipmentID", Type = FlexJamType.UInt64)]
		public ulong ShipmentID { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "result")]
		[FlexJamMember(Name = "result", Type = FlexJamType.Int32)]
		public int Result { get; set; }
	}
}
