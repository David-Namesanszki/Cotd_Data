using Cotd_Data.Models.Cards;

namespace Cotd_Data.Repositories.CardRepositories.Interfaces
{
    public interface IConstructionCardRepository : IBaseRepository<ConstructionCardData>
	{
        ConstructionCardData GetOne(int id);
        void UpdateCard(int id, string name, string description, string image, int envoyCost, int turnsToBuild, int armor, int power);
    }
}