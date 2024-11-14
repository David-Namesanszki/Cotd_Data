using Cotd_Data.Models.Enemies;
using Cotd_Data.Models.Games.Resources;
using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Games.Raids.Maps.Locations;

public class BattleData : LocationData
{
    [JsonPropertyName("enemy")]
    public EnemyData Enemy { get; set; } = new EnemyData();
    [JsonPropertyName("loot")]
    public ResourceData Loot { get; set; } = new ResourceData();

   
}
