﻿using System;
using System.Runtime.Serialization;
using JamLib;

namespace WowJamMessages
{
	[System.Runtime.Serialization.DataContract]
	[FlexJamStruct(Name = "JamCliPetitionInfo", Version = 28333852u)]
	public class JamCliPetitionInfo
	{
		public JamCliPetitionInfo()
		{
			this.M_choicetext = new string[10];
		}

		[System.Runtime.Serialization.DataMember(Name = "m_allowedMinLevel")]
		[FlexJamMember(Name = "m_allowedMinLevel", Type = FlexJamType.Int32)]
		public int M_allowedMinLevel { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "m_allowedClasses")]
		[FlexJamMember(Name = "m_allowedClasses", Type = FlexJamType.Int32)]
		public int M_allowedClasses { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "m_allowedGender")]
		[FlexJamMember(Name = "m_allowedGender", Type = FlexJamType.Int16)]
		public short M_allowedGender { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "m_deadLine")]
		[FlexJamMember(Name = "m_deadLine", Type = FlexJamType.Int32)]
		public int M_deadLine { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "m_maxSignatures")]
		[FlexJamMember(Name = "m_maxSignatures", Type = FlexJamType.Int32)]
		public int M_maxSignatures { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "m_title")]
		[FlexJamMember(Name = "m_title", Type = FlexJamType.String)]
		public string M_title { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "m_muid")]
		[FlexJamMember(Name = "m_muid", Type = FlexJamType.UInt32)]
		public uint M_muid { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "m_petitioner")]
		[FlexJamMember(Name = "m_petitioner", Type = FlexJamType.WowGuid)]
		public string M_petitioner { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "m_bodyText")]
		[FlexJamMember(Name = "m_bodyText", Type = FlexJamType.String)]
		public string M_bodyText { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "m_allowedMaxLevel")]
		[FlexJamMember(Name = "m_allowedMaxLevel", Type = FlexJamType.Int32)]
		public int M_allowedMaxLevel { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "m_minSignatures")]
		[FlexJamMember(Name = "m_minSignatures", Type = FlexJamType.Int32)]
		public int M_minSignatures { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "m_staticType")]
		[FlexJamMember(Name = "m_staticType", Type = FlexJamType.Int32)]
		public int M_staticType { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "m_numChoices")]
		[FlexJamMember(Name = "m_numChoices", Type = FlexJamType.Int32)]
		public int M_numChoices { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "m_issueDate")]
		[FlexJamMember(Name = "m_issueDate", Type = FlexJamType.Int32)]
		public int M_issueDate { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "m_allowedRaces")]
		[FlexJamMember(Name = "m_allowedRaces", Type = FlexJamType.Int32)]
		public int M_allowedRaces { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "m_petitionID")]
		[FlexJamMember(Name = "m_petitionID", Type = FlexJamType.Int32)]
		public int M_petitionID { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "m_allowedGuildID")]
		[FlexJamMember(Name = "m_allowedGuildID", Type = FlexJamType.Int32)]
		public int M_allowedGuildID { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "m_choicetext")]
		[FlexJamMember(ArrayDimensions = 1, Name = "m_choicetext", Type = FlexJamType.String)]
		public string[] M_choicetext { get; set; }
	}
}
