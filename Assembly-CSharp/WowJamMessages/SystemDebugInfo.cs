﻿using System;
using System.Runtime.Serialization;
using JamLib;

namespace WowJamMessages
{
	[System.Runtime.Serialization.DataContract]
	[FlexJamStruct(Name = "SystemDebugInfo", Version = 28333852u)]
	public class SystemDebugInfo
	{
		public SystemDebugInfo()
		{
			this.RequestParameter = string.Empty;
		}

		[System.Runtime.Serialization.DataMember(Name = "name")]
		[FlexJamMember(Name = "name", Type = FlexJamType.String)]
		public string Name { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "attributeDescriptions")]
		[FlexJamMember(ArrayDimensions = 1, Name = "attributeDescriptions", Type = FlexJamType.Struct)]
		public DebugAttributeDescription[] AttributeDescriptions { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "updateTime")]
		[FlexJamMember(Name = "updateTime", Type = FlexJamType.Int32)]
		public int UpdateTime { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "attributes")]
		[FlexJamMember(ArrayDimensions = 1, Name = "attributes", Type = FlexJamType.Struct)]
		public DebugAttribute[] Attributes { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "requestParameter")]
		[FlexJamMember(Name = "requestParameter", Type = FlexJamType.String)]
		public string RequestParameter { get; set; }
	}
}
