using Cotd_Data.Models.Cards;
using Cotd_Data.Models.Games.Raids;
using Cotd_Data.Models.Games.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Cotd_Data.Models.GameInfos;

public class GameData
{
	[JsonPropertyName("id")]
	public string Id { get; set; } = Guid.NewGuid().ToString();
	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;
	[JsonPropertyName("resources")]
	public ResourceData Resources { get; set; } = new ResourceData();
	[JsonPropertyName("unlockedCards")]
	public ICollection<string> UnlockedCardIds { get; set; } = [];
	[JsonPropertyName("unlockedCaptains")]
	public ICollection<string> UnlockedCaptainIds { get; set; } = [];
	[JsonPropertyName("ongoingRaid")]
	public RaidData? OngoingRaid { get; set; } = null;
}
