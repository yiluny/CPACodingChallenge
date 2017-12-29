using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace CPACodingChallenge.Models
{
    public class ProgramResult
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }
    }
}