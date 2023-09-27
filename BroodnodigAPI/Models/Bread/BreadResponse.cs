using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DTO.Bread
{
    public class BreadResponse
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
		[JsonPropertyName("name")]

		public string Name { get; set; }
		[JsonPropertyName("type")]

		public string Type { get; set; }
		[JsonPropertyName("inventory")]

		public int Inventory { get; set; }
    }
}
