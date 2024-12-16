using Cotd_Data.Models.Cards.Effects;
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

[JsonPolymorphic]
[JsonDerivedType(typeof(CommandCardData), nameof(CommandCardData))]
[JsonDerivedType(typeof(UnitCardData), nameof(UnitCardData))]
public abstract class CardData : EntityData
{
	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;

	[JsonPropertyName("description")]
	public string Description { get; set; } = string.Empty;

	[JsonPropertyName("cardType")]
	public CardTypes CardType { get; set; } = CardTypes.Undefined;

	[JsonPropertyName("image")]
	public string Image { get; set; } = string.Empty;

	[JsonPropertyName("envoyCost")]
	public int EnvoyCost { get; set; } = 0;

	[JsonPropertyName("effects")]
	public IList<EffectData> Effects { get; set; } = [];

	public override string ToString()
	{
		string effectsSummary = Effects != null && Effects.Count > 0
			? $"[{string.Join(", ", Effects.Select(effect => effect.ToString()))}]"
			: "[]";

		return $"{nameof(CardData)}: " +
			   $"{nameof(Id)}={Id}, " +
			   $"{nameof(Name)}={Name}, " +
			   $"{nameof(Description)}={Description}, " +
			   $"{nameof(CardType)}={CardType}, " +
			   $"{nameof(Image)}={Image}, " +
			   $"{nameof(EnvoyCost)}={EnvoyCost}, " +
			   $"{nameof(Effects)}={effectsSummary}";
	}
}
