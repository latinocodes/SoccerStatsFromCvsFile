using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SoccerStats
{
    public class SentimentResponse
    {
        // This is use to refer to the property names on the Json
        // response
        [JsonProperty(PropertyName = "documents")]
        public List<Sentiment> Sentiments { get; set; }

    }

    public class Sentiment
    {
        // This is use to refer to the property names on the Json
        // response
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }


        [JsonProperty(PropertyName = "score")]
        public string Score { get; set; }
    }
}
