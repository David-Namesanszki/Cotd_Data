using Cotd_Data.Models.Enemies;
using Cotd_Data.ValueObjects;
using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Maps.Locations;

public class BattleData : LocationData
{
    [JsonPropertyName("enemy")]
    public EnemyData Enemy { get; set; } = new EnemyData();

    [JsonPropertyName("loot")]
    public Loot Loot { get; set; } = new Loot();

	public override string ToString()
	{
		string enemySummary = Enemy != null ? Enemy.ToString() : "None";

		return $"{base.ToString()}" +
			   $"{nameof(BattleData)}: " +
			   $"{nameof(Id)}={Id}, " +
			   $"{nameof(Enemy)}={enemySummary}, " +
			   $"{nameof(Loot)}={Loot}";
	}
}
