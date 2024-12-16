using System.ComponentModel.DataAnnotations.Schema;

namespace Cotd_Data.Models.Cards;

public class WeatherCardData : CardData
{
	public override string ToString()
	{
		return $"{nameof(DreamCardData)}: {base.ToString()}";
	}
}
