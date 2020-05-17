using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class Record
    {
        [JsonProperty("c")]
        public string Challenge { get;set; }

        [JsonProperty("d")]
        public DateTime Date { get;set; }

        [JsonProperty("s")]
        public double Score { get;set; }
    }
}
