using Cotd_Data.Models.Cards;
using Cotd_Data.Models.Games.Decks;
using Cotd_Data.Models.Games.Raids.Maps;
using Cotd_Data.Models.Games.Raids.Maps.LocationPaths;
using Cotd_Data.Models.Games.Raids.Maps.Locations;
using Cotd_Data.Models.Games.Resources;
using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Games.Raids;

public class RaidData
{
	[JsonPropertyName("currentLocation")]
	public string CurrentLocationId { get; set; } = string.Empty;
	[JsonPropertyName("map")]
	public MapData Map { get; set; } = new MapData();
    [JsonPropertyName("loot")]
	public ResourceData Loot { get; set; } = new ResourceData();
	[JsonPropertyName("deck")]
	public DeckData Deck { get; set; } = new DeckData();
}
