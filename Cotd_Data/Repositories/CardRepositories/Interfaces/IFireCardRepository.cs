using Cotd_Data.Models.Cards;

namespace Cotd_Data.Repositories.CardRepositories.Interfaces
{
    public interface IFireCardRepository : IBaseRepository<FireCardData>
	{
        FireCardData GetOne(int id);
        void UpdateCard(int id, string name, string description, string image, int envoyCost, int fireCost);
    }
}