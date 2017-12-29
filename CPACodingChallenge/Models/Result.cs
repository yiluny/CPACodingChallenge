using System.ComponentModel;
using Newtonsoft.Json;

namespace CPACodingChallenge.Models
{
    public class Result
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("grade")]
        public string Grade { get; set; }

        public string Subject { get; set; }
    }
}