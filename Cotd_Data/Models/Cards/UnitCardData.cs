using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Cards;

public enum UnitTypes
{
    Melee,
    Ranged,
    Support
}

public class UnitCardData : CardData
{
	[JsonPropertyName("turnsToFormation")]
	public int TurnsToFormation { get; set; } = 0;
	[JsonPropertyName("health")]
	public int Health { get; set; } = 0;
	[JsonPropertyName("power")]
	public int Power { get; set; } = 0;
	[JsonPropertyName("armor")]
	public int Armor { get; set; } = 0;
	[JsonPropertyName("unitType")]
	public UnitTypes UnitType { get; set; } = UnitTypes.Melee;

	public override string ToString()
	{
		return $"{base.ToString()}, " + 
			   $"{nameof(TurnsToFormation)}={TurnsToFormation}, " +
			   $"{nameof(Health)}={Health}, " + 
			   $"{nameof(Power)}={Power}, " +
			   $"{nameof(Armor)}={Armor}, " + 
			   $"{nameof(UnitType)}={UnitType}";
	}
}
