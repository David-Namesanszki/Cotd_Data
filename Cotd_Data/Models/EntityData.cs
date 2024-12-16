using System.Text.Json.Serialization;

namespace Cotd_Data.Models;

public abstract class EntityData
{
	[JsonPropertyName("id")]
	public string Id { get; set; } = string.Empty;

	public override string ToString()
	{
		return $"{nameof(EntityData)}: {nameof(Id)}={Id}";
	}
}
