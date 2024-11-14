using Cotd_Data.Models.Cards;

namespace Cotd_Data.Repositories.CardRepositories.Interfaces;

public interface IWeatherCardRepository : ICardRepository<WeatherCardData>
{
	void UpdateCard(string id, string name, string description, string image, int envoyCost);
}