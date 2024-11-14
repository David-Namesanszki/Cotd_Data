using Cotd_Data.Models.Games.Raids.Maps.Locations;
using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Games.Raids.Maps.LocationPaths;

public class LocationPathData
{
    [JsonPropertyName("daysToTravel")]
    public int DaysToTravel { get; set; } = 0;
    [JsonPropertyName("from")]
    public string FromId { get; set; } = string.Empty;
    [JsonPropertyName("to")]
    public string ToId { get; set; } = string.Empty;
}
