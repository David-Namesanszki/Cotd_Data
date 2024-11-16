using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Enemies;

public class EnemyData
{
	[JsonPropertyName("id")]
	public string Id { get; set; } = string.Empty;
	[JsonPropertyName("splashArt")]
	public string Image { get; set; } = string.Empty;
	[JsonPropertyName("cards")]
	public IList<string> CardIds { get; set; } = [];

	public override string ToString()
	{
		string cardsString = string.Join(", ", CardIds);
		return $"EnemyData: Id = {Id}, Image = {Image}, Cards = [{cardsString}]";
	}
}
