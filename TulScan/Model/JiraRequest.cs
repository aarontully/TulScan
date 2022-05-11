using Newtonsoft.Json;

namespace TulScan.Model
{
    public class Project
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Issuetype
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class customfield_10201
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class customfield_10203
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Fields
    {
        [JsonProperty("project")]
        public Project Project { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("issuetype")]
        public Issuetype Issuetype { get; set; }

        [JsonProperty("customfield_10217")]
        public string WarrantyDate { get; set; }

        [JsonProperty("customfield_10216")]
        public string SupportContractDetails { get; set; }

        [JsonProperty("customfield_10215")]
        public string AssetSupplier { get; set; }

        [JsonProperty("customfield_10212")]
        public string SerialNumber { get; set; }

        [JsonProperty("customfield_10201")]
        public customfield_10201 Location { get; set; }

        [JsonProperty("customfield_10202")]
        public string DetailedLocation { get; set; }

        [JsonProperty("customfield_10203")]
        public customfield_10203 HardwareType { get; set; }

        [JsonProperty("customfield_10209")]
        public string ManafactureBrand { get; set; }

        [JsonProperty("customfield_10210")]
        public string Model { get; set; }
    }

    public class JiraRequest
    {
        [JsonProperty("fields")]
        public Fields Fields { get; set; }
    }
}
