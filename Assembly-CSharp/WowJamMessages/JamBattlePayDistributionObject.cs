﻿using System;
using System.Runtime.Serialization;
using JamLib;

namespace WowJamMessages
{
	[System.Runtime.Serialization.DataContract]
	[FlexJamStruct(Name = "JamBattlePayDistributionObject", Version = 28333852u)]
	public class JamBattlePayDistributionObject
	{
		[System.Runtime.Serialization.DataMember(Name = "revoked")]
		[FlexJamMember(Name = "revoked", Type = FlexJamType.Bool)]
		public bool Revoked { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "deliverableID")]
		[FlexJamMember(Name = "deliverableID", Type = FlexJamType.UInt32)]
		public uint DeliverableID { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "targetPlayer")]
		[FlexJamMember(Name = "targetPlayer", Type = FlexJamType.WowGuid)]
		public string TargetPlayer { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "deliverable")]
		[FlexJamMember(Optional = true, Name = "deliverable", Type = FlexJamType.Struct)]
		public JamBattlePayDeliverable[] Deliverable { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "purchaseID")]
		[FlexJamMember(Name = "purchaseID", Type = FlexJamType.UInt64)]
		public ulong PurchaseID { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "status")]
		[FlexJamMember(Name = "status", Type = FlexJamType.UInt32)]
		public uint Status { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "targetNativeRealm")]
		[FlexJamMember(Name = "targetNativeRealm", Type = FlexJamType.UInt32)]
		public uint TargetNativeRealm { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "distributionID")]
		[FlexJamMember(Name = "distributionID", Type = FlexJamType.UInt64)]
		public ulong DistributionID { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "targetVirtualRealm")]
		[FlexJamMember(Name = "targetVirtualRealm", Type = FlexJamType.UInt32)]
		public uint TargetVirtualRealm { get; set; }
	}
}
