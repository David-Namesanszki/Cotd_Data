using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Enemies;

public class EnemyData : EntityData
{
	[JsonPropertyName("splashArt")]
	public string Image { get; set; } = string.Empty;
	[JsonPropertyName("cards")]
	public IList<string> CardIds { get; set; } = [];

	public override string ToString()
	{
		return $"{nameof(EnemyData)}: " +
			   $"{nameof(Id)}={Id}, " +
			   $"{nameof(Image)}={Image}, " +
			   $"{nameof(CardIds)}=[{string.Join(", ", CardIds)}]";
	}
}
