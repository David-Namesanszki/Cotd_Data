using Cotd_Data.Models.Cards;
using Cotd_Data.Models.Games.Decks;
using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Captains;

public class CaptainData
{
	[JsonPropertyName("id")]
	public string Id { get; set; } = string.Empty;

	[JsonPropertyName("image")]
	public string Image { get; set; } = string.Empty;

	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;

	[JsonPropertyName("health")]
	public int Health { get; set; } = 0;
	[JsonPropertyName("power")]
	public int Power { get; set; } = 0;
	[JsonPropertyName("armor")]
	public int Armor { get; set; } = 0;
	[JsonPropertyName("cards")]
	public DeckData Deck { get; set; } = new DeckData();

	public override string ToString()
	{
		return $"CaptainData: Id = {Id}, Image = {Image}, Name = {Name}, Health = {Health}, Power = {Power}, Armor = {Armor}";
	}
}
