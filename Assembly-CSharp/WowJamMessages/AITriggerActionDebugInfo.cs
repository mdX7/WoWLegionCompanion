﻿using System;
using System.Runtime.Serialization;
using JamLib;

namespace WowJamMessages
{
	[FlexJamStruct(Name = "AITriggerActionDebugInfo", Version = 28333852u)]
	[System.Runtime.Serialization.DataContract]
	public class AITriggerActionDebugInfo
	{
		public AITriggerActionDebugInfo()
		{
			this.TypeName = string.Empty;
			this.Param = new int[2];
			this.TriggerDescription = string.Empty;
			this.Note = string.Empty;
			this.AiGroupActionSetName = string.Empty;
		}

		[System.Runtime.Serialization.DataMember(Name = "repeatCount")]
		[FlexJamMember(Name = "repeatCount", Type = FlexJamType.Int32)]
		public int RepeatCount { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "triggerDescription")]
		[FlexJamMember(Name = "triggerDescription", Type = FlexJamType.String)]
		public string TriggerDescription { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "aiGroupActionSetID")]
		[FlexJamMember(Name = "aiGroupActionSetID", Type = FlexJamType.Int32)]
		public int AiGroupActionSetID { get; set; }

		[FlexJamMember(Name = "note", Type = FlexJamType.String)]
		[System.Runtime.Serialization.DataMember(Name = "note")]
		public string Note { get; set; }

		[FlexJamMember(Name = "typeName", Type = FlexJamType.String)]
		[System.Runtime.Serialization.DataMember(Name = "typeName")]
		public string TypeName { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "triggerTime")]
		[FlexJamMember(Name = "triggerTime", Type = FlexJamType.UInt32)]
		public uint TriggerTime { get; set; }

		[FlexJamMember(Name = "type", Type = FlexJamType.Int32)]
		[System.Runtime.Serialization.DataMember(Name = "type")]
		public int Type { get; set; }

		[FlexJamMember(Name = "triggerData", Type = FlexJamType.Int32)]
		[System.Runtime.Serialization.DataMember(Name = "triggerData")]
		public int TriggerData { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "param")]
		[FlexJamMember(ArrayDimensions = 1, Name = "param", Type = FlexJamType.Int32)]
		public int[] Param { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "aiGroupActionSetName")]
		[FlexJamMember(Name = "aiGroupActionSetName", Type = FlexJamType.String)]
		public string AiGroupActionSetName { get; set; }
	}
}
