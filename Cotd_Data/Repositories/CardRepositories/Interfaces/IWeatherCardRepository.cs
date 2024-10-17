using Cotd_Data.Models.Cards;

namespace Cotd_Data.Repositories.CardRepositories.Interfaces
{
    public interface IWeatherCardRepository : IBaseRepository<WeatherCardData>
	{
        WeatherCardData GetOne(int id);
        void UpdateCard(int id, string name, string description, string image, int envoyCost);
    }
}