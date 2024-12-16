using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Cards;

public class ConstructionCardData : CardData
{
	[JsonPropertyName("armor")]
	public int Armor { get; set; } = 0;
	[JsonPropertyName("power")]
	public int Power { get; set; } = 0;
	[JsonPropertyName("turnsToBuild")]
	public int TurnsToBuild { get; set; } = 0;

	public override string ToString()
	{
		return $"{base.ToString()}, " +
			   $"{nameof(Armor)}={Armor}, "+
			   $"{nameof(Power)}={Power}, " +
			   $"{nameof(TurnsToBuild)}={TurnsToBuild}";
	}
}
