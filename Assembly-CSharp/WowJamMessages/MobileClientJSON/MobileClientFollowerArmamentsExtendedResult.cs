﻿using System;
using System.Runtime.Serialization;
using JamLib;

namespace WowJamMessages.MobileClientJSON
{
	[System.Runtime.Serialization.DataContract]
	[FlexJamMessage(Id = 4875, Name = "MobileClientFollowerArmamentsExtendedResult", Version = 39869590u)]
	public class MobileClientFollowerArmamentsExtendedResult
	{
		[System.Runtime.Serialization.DataMember(Name = "armament")]
		[FlexJamMember(ArrayDimensions = 1, Name = "armament", Type = FlexJamType.Struct)]
		public MobileFollowerArmamentExt[] Armament { get; set; }
	}
}
