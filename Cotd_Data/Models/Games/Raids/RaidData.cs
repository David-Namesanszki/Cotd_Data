using Cotd_Data.Models.Captains;
using Cotd_Data.Models.Maps;
using Cotd_Data.ValueObjects;
using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Games.Raids;

public class RaidData : EntityData
{
	[JsonPropertyName("currentLocation")]
	public string CurrentLocationId { get; set; } = string.Empty;

	[JsonPropertyName("map")]
	public MapData Map { get; set; } = new MapData();

    [JsonPropertyName("loot")]
	public Loot Loot { get; set; } = new Loot();

	[JsonPropertyName("deck")]
	public IList<string> CardIds { get; set; } = [];

	[JsonPropertyName("captain")]
	public CaptainData Captain { get; set; } = new CaptainData();

	public override string ToString()
	{
		return $"{nameof(RaidData)}: " +
			   $"{nameof(Id)}={Id}, " +
			   $"{nameof(CurrentLocationId)}={CurrentLocationId}, " +
			   $"{nameof(Map)}={Map}, " +
			   $"{nameof(Loot)}={Loot}, " +
			   $"{nameof(CardIds)}=[{string.Join(", ", CardIds)}], " +
			   $"{nameof(Captain)}={Captain}";
	}
}
