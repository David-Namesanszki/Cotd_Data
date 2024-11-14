using Cotd_Data.Models.Games.Raids.Maps.LocationPaths;
using System.Numerics;
using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Games.Raids.Maps.Locations;

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

public class LocationData
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [JsonPropertyName("coordinates")]
    public Vector2 Coordinates { get; set; } = new Vector2();

	[JsonPropertyName("locationType")]
	public LocationTypes LocationType { get; set; } = LocationTypes.Undefined;

    [JsonPropertyName("visited")]
    public bool Visited { get; set; } = false;
	public List<LocationPathData> LocationPaths { get; set; } = [];

	public override string ToString()
    {
        return $"LocationData: Id = {Id}, Coordinates = ({Coordinates.X}, {Coordinates.Y}), Visited = {Visited}";
    }
}
