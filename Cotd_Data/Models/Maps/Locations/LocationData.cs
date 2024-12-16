using Cotd_Data.Models.Maps.LocationPaths;
using Cotd_Data.ValueObjects;
using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Maps.Locations;

public enum LocationTypes
{
    Altar,
    Battle,
    HarvestingSite,
    RecruitmentCamp,
    Start,
    End,
    Undefined
}

public class LocationData : EntityData
{
    [JsonPropertyName("coordinates")]
    public CubeCoord Coordinates { get; set; } = new CubeCoord();

    [JsonPropertyName("locationType")]
    public LocationTypes LocationType { get; set; } = LocationTypes.Undefined;

    [JsonPropertyName("visited")]
    public bool Visited { get; set; } = false;

    [JsonPropertyName("locationPaths")]
    public List<LocationPathData> LocationPaths { get; set; } = [];

	public override string ToString()
	{
		string locationPathsSummary = LocationPaths != null && LocationPaths.Count > 0
			? $"[{string.Join(", ", LocationPaths.Select(path => path.ToString()))}]"
			: "[]";

		return $"{nameof(LocationData)}: " +
			   $"{nameof(Id)}={Id}, " +
			   $"{nameof(Coordinates)}={Coordinates}, " +
			   $"{nameof(LocationType)}={LocationType}, " +
			   $"{nameof(Visited)}={Visited}, " +
			   $"{nameof(LocationPaths)}={locationPathsSummary}";
	}
}
