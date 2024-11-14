using Cotd_Data.Models.Games.Resources;
using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Games.Raids.Maps.Locations;

public class HarvestingSiteData : LocationData
{
    [JsonPropertyName("loot")]
    public ResourceData Loot { get; set; } = new ResourceData();

    [JsonPropertyName("daysToHarvest")]
    public int DaysToHarvest { get; set; } = 0;

    public override string ToString()
    {
        return $"{base.ToString()}, Loot = {Loot}, DaysToHarvest = {DaysToHarvest}";
    }
}
