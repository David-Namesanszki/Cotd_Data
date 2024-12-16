using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Captains;

public class CaptainData : EntityData
{
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
	public IList<string> CardIds { get; set; } = [];

	public override string ToString()
	{
		string cardsSummary = CardIds != null && CardIds.Count > 0
			? $"[{string.Join(", ", CardIds)}]"
			: "[]";

		return $"{nameof(CaptainData)}: " +
			   $"{nameof(Id)}={Id}, " +
		       $"{nameof(Name)}={Name}, " +
		       $"{nameof(Image)}={Image}, " +
		       $"{nameof(Health)}={Health}, " +
		       $"{nameof(Power)}={Power}, " +
		       $"{nameof(Armor)}={Armor}, " +
		       $"{nameof(CardIds)}={cardsSummary}";
	}
}
