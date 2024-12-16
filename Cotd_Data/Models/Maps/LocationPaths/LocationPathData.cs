using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Maps.LocationPaths;

public class LocationPathData : EntityData
{
    [JsonPropertyName("daysToTravel")]
    public int DaysToTravel { get; set; } = 0;

    [JsonPropertyName("from")]
    public string FromId { get; set; } = string.Empty;

    [JsonPropertyName("to")]
    public string ToId { get; set; } = string.Empty;

	public override string ToString()
	{
		return $"{nameof(LocationPathData)}: " +
			   $"{nameof(Id)}={Id}, " +
			   $"{nameof(DaysToTravel)}={DaysToTravel}, " +
			   $"{nameof(FromId)}={FromId}, " +
			   $"{nameof(ToId)}={ToId}";
	}
}
