﻿using System;
using System.Runtime.Serialization;
using JamLib;

namespace WowJamMessages
{
	[System.Runtime.Serialization.DataContract]
	[FlexJamStruct(Name = "JamShipmentData", Version = 28333852u)]
	public class JamShipmentData
	{
		public JamShipmentData()
		{
			this.ResetPending = false;
		}

		[System.Runtime.Serialization.DataMember(Name = "shipment")]
		[FlexJamMember(ArrayDimensions = 1, Name = "shipment", Type = FlexJamType.Struct)]
		public JamCharacterShipment[] Shipment { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "resetPending")]
		[FlexJamMember(Name = "resetPending", Type = FlexJamType.Bool)]
		public bool ResetPending { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "pendingShipment")]
		[FlexJamMember(ArrayDimensions = 1, Name = "pendingShipment", Type = FlexJamType.Int32)]
		public int[] PendingShipment { get; set; }
	}
}
