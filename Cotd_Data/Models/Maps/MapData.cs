using Cotd_Data.Models.Maps.LocationPaths;
using Cotd_Data.Models.Maps.Locations;
using System.Reflection;
using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Maps;

public class MapData : EntityData
{
    [JsonPropertyName("locationPaths")]
    public IList<LocationPathData> LocationPaths { get; set; } = [];

    [JsonPropertyName("locations")]
    public IList<LocationData> Locations { get; set; } = [];

	[JsonPropertyName("currentLocation")]
	public string CurrentLocationId { get; set; } = string.Empty;

    public override string ToString()
	{
		string locationPathsSummary = LocationPaths != null && LocationPaths.Count > 0
			? $"[{string.Join(", ", LocationPaths.Select(path => path.ToString()))}]"
			: "[]";

		string locationsSummary = Locations != null && Locations.Count > 0
			? $"[{string.Join(", ", Locations.Select(location => location.ToString()))}]"
			: "[]";

		return $"{nameof(MapData)}: " +
			   $"{nameof(Id)}={Id}, " +
			   $"{nameof(CurrentLocationId)}={CurrentLocationId}, " +
			   $"{nameof(LocationPaths)}={locationPathsSummary}, " +
			   $"{nameof(Locations)}={locationsSummary}";
	}
}
