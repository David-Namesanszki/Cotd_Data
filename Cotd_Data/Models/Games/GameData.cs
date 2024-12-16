using Cotd_Data.Models.Games.Raids;
using Cotd_Data.ValueObjects;
using System.Text.Json.Serialization;

namespace Cotd_Data.Models.GameInfos;

public class GameData : EntityData
{
	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;
	[JsonPropertyName("resources")]
	public Loot Resources { get; set; } = new Loot();
	[JsonPropertyName("playerXP")]
	public int PlayerXP { get; set; } = 0;
    [JsonPropertyName("unlockedCards")]
	public IList<string> UnlockedCardIds { get; set; } = [];
	[JsonPropertyName("unlockedCaptains")]
	public IList<string> UnlockedCaptainIds { get; set; } = [];
	[JsonPropertyName("ongoingRaid")]
	public RaidData? OngoingRaid { get; set; } = null;

	public override string ToString()
	{
		string ongoingRaidSummary = OngoingRaid != null ? OngoingRaid.ToString() : "None";

		return $"{nameof(GameData)}: " +
			   $"{nameof(Id)}={Id}, " +
			   $"{nameof(Name)}={Name}, " +
			   $"{nameof(Resources)}={Resources}, " +
			   $"{nameof(PlayerXP)}={PlayerXP}, " +
			   $"{nameof(UnlockedCardIds)}=[{string.Join(", ", UnlockedCardIds)}], " +
			   $"{nameof(UnlockedCaptainIds)}=[{string.Join(", ", UnlockedCaptainIds)}], " +
			   $"{nameof(OngoingRaid)}={ongoingRaidSummary}";
	}
}
