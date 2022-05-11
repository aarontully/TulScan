using Newtonsoft.Json;

namespace TulScan.Model
{
    public class JiraResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }
    }
}
