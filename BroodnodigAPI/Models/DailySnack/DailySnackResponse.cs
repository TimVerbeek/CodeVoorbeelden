﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DTO.DailySnack
{
    public class DailySnackResponse
    {
		[JsonPropertyName("id")]

		public Guid Id { get; set; }
		[JsonPropertyName("name")]

		public string Name { get; set; }
		[JsonPropertyName("date")]

		public DateTime Date { get; set; }

    }
}
