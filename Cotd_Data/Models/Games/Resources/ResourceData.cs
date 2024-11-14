using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Games.Resources;

public class ResourceData
{
	[JsonPropertyName("heartwoodAmount")]
	public int HeartwoodAmount { get; set; } = 0;
	[JsonPropertyName("barkOreAmount")]
	public int BarkOreAmount { get; set; } = 0;
	[JsonPropertyName("bloodSapAmount")]
	public int BloodSapAmount { get; set; } = 0;

	public override string ToString()
	{
		return $"ResourceData: HeartwoodAmount = {HeartwoodAmount}, BarkOreAmount = {BarkOreAmount}, BloodSapAmount = {BloodSapAmount}";
	}
}
