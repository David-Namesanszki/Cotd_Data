using Cotd_Data.Models.Cards;
using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Games.Decks;

public class DeckData
{
	[JsonPropertyName("id")]
	public string Id { get; set; } = string.Empty;
    [JsonPropertyName("cards")]
	public List<CardData> Cards { get; set; } = [];
}
