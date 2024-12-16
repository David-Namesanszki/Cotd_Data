using Cotd_Data.Models.Cards;

namespace Cotd_Data.Models.Maps.Locations;

public class EndLocationData : LocationData
{
	public override string ToString()
	{
		return $"{nameof(EndLocationData)}: {base.ToString()}";
	}
}
