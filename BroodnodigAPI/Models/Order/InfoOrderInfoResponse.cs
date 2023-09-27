using System.Text.Json.Serialization;

namespace DTO.Order
{
    public class InfoOrderInfoResponse
    {
        [JsonPropertyName("id")]

        public Guid Id { get; set; }
        [JsonPropertyName("date")]

        public DateTime Date { get; set; }
        [JsonPropertyName("hasdailysnack")]

        public bool HasDailySnack { get; set; }
        [JsonPropertyName("email")]

        public string Email { get; set; }
        [JsonPropertyName("opmerkingen")]

        public string Opmerkingen { get; set; }
        [JsonPropertyName("alergien")]

        public string Alergien { get; set; }
        [JsonPropertyName("aanwezig")]

        public bool Aanwezig { get; set; }
    }
}
