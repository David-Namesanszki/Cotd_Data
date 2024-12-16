using Cotd_Data.ValueObjects;
using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Maps.Locations;

public class HarvestingSiteData : LocationData
{
    [JsonPropertyName("loot")]
    public Loot Loot { get; set; } = new Loot();

    [JsonPropertyName("daysToHarvest")]
    public int DaysToHarvest { get; set; } = 0;

	public override string ToString()
	{
		return $"{base.ToString()}, " +
			   $"{nameof(HarvestingSiteData)}: " +
			   $"{nameof(Id)}={Id}, " +
			   $"{nameof(Loot)}={Loot}, " +
			   $"{nameof(DaysToHarvest)}={DaysToHarvest}";
	}
}
