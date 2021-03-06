﻿using System;
using System.Runtime.Serialization;
using JamLib;

namespace WowJamMessages
{
	[System.Runtime.Serialization.DataContract]
	[FlexJamStruct(Name = "GameObjectDebugInfo", Version = 28333852u)]
	public class GameObjectDebugInfo
	{
		[System.Runtime.Serialization.DataMember(Name = "health")]
		[FlexJamMember(Name = "health", Type = FlexJamType.Float)]
		public float Health { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "state")]
		[FlexJamMember(Name = "state", Type = FlexJamType.Int32)]
		public int State { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "flags")]
		[FlexJamMember(Name = "flags", Type = FlexJamType.UInt32)]
		public uint Flags { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "gameObjectType")]
		[FlexJamMember(Name = "gameObjectType", Type = FlexJamType.Int32)]
		public int GameObjectType { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "debugName")]
		[FlexJamMember(Name = "debugName", Type = FlexJamType.String)]
		public string DebugName { get; set; }
	}
}
