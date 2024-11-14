using Cotd_Data.Models.Games.Raids.Maps.LocationPaths;
using Cotd_Data.Models.Games.Raids.Maps.Locations;
using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Games.Raids.Maps;

public class MapData
{
    [JsonPropertyName("locationPaths")]
    public List<LocationPathData> LocationPaths { get; set; } = [];
    [JsonPropertyName("locations")]
    public List<LocationData> Locations { get; set; } = [];
}
