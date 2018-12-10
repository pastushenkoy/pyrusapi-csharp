﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace PyrusApiClient
{
	public class FormRegisterResponse : ResponseBase
	{
		[JsonProperty("tasks")]
		public List<Task> Tasks { get; set; }

		public string Csv { get; set; }
	}
}
