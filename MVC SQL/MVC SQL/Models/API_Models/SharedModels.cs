using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SQL.Models
{
    public class MetaDataModel
    {
        [JsonProperty("1. Information")]
        public string information { get; set; }

        [JsonProperty("2. Symbol")]
        public string symbol { get; set; }

        [JsonProperty("3. Last Refreshed")]
        public string lastRefreshed { get; set; }

        [JsonProperty("4. Time Zone")]
        public string timeZone { get; set; }
    }
}
