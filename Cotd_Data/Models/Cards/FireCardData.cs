using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Cards;

public class FireCardData : CardData
{
	[JsonPropertyName("fireCost")]
	public int FireCost { get; set; } = 0;

	public override string ToString()
	{
		return $"{base.ToString()}, FireCost = {FireCost}";
	}
}
