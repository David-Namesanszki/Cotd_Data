using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Maps.Locations;

public class AltarData : LocationData
{
    [JsonPropertyName("cardChoices")]
    public IList<string> CardChoiceIds { get; set; } = [];

	public override string ToString()
	{
		string cardChoicesSummary = CardChoiceIds != null && CardChoiceIds.Count > 0
			? $"[{string.Join(", ", CardChoiceIds)}]"
			: "[]";

		return $"{base.ToString()}" + 
			   $"{nameof(AltarData)}: " +
			   $"{nameof(Id)}={Id}, " +
			   $"{nameof(CardChoiceIds)}={cardChoicesSummary}";
	}
}
