﻿using System;
using System.Runtime.Serialization;
using JamLib;

namespace WowJamMessages
{
	[System.Runtime.Serialization.DataContract]
	[FlexJamStruct(Name = "AITriggerActionDebugInfo", Version = 28333852u)]
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

		[System.Runtime.Serialization.DataMember(Name = "note")]
		[FlexJamMember(Name = "note", Type = FlexJamType.String)]
		public string Note { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "typeName")]
		[FlexJamMember(Name = "typeName", Type = FlexJamType.String)]
		public string TypeName { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "triggerTime")]
		[FlexJamMember(Name = "triggerTime", Type = FlexJamType.UInt32)]
		public uint TriggerTime { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "type")]
		[FlexJamMember(Name = "type", Type = FlexJamType.Int32)]
		public int Type { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "triggerData")]
		[FlexJamMember(Name = "triggerData", Type = FlexJamType.Int32)]
		public int TriggerData { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "param")]
		[FlexJamMember(ArrayDimensions = 1, Name = "param", Type = FlexJamType.Int32)]
		public int[] Param { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "aiGroupActionSetName")]
		[FlexJamMember(Name = "aiGroupActionSetName", Type = FlexJamType.String)]
		public string AiGroupActionSetName { get; set; }
	}
}
