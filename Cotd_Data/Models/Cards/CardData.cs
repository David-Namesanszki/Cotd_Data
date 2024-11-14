using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Cards;

public enum CardTypes
{
	CommandCard,
	ConstructionCard,
	DreamCard,
	FireCard,
	UnitCard,
	WeatherCard,
	Undefined,
}

public abstract class CardData
{
	[JsonPropertyName("id")]
	public string Id { get; set; } = string.Empty;
	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;

	[JsonPropertyName("description")]
	public string Description { get; set; } = string.Empty;
	[JsonPropertyName("type")]
	public CardTypes CardType { get; set; } = CardTypes.Undefined;

	[JsonPropertyName("image")]
	public string Image { get; set; } = string.Empty;

	[JsonPropertyName("envoyCost")]
	public int EnvoyCost { get; set; } = 0;

	public override string ToString()
	{
		return $"CardData: Id = {Id}, Name = {Name}, Description = {Description}, Image = {Image}, EnvoyCost = {EnvoyCost}";
	}
}
