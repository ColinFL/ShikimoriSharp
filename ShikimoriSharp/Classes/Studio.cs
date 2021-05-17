using Newtonsoft.Json;
using ShikimoriSharp.Bases;
using System;

namespace ShikimoriSharp.Classes
{
    public class Studio
    {
        [JsonProperty("id")] public long Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("filtered_name")] public string FilteredName { get; set; }
        [JsonProperty("real")] public bool? Real { get; set; }
        [JsonProperty("image")] public Uri Image { get; set; }
    }
}