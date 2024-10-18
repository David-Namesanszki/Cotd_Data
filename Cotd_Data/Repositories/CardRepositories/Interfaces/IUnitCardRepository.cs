using Cotd_Data.Models.Cards;

namespace Cotd_Data.Repositories.CardRepositories.Interfaces
{
    public interface IUnitCardRepository : IBaseRepository<UnitCardData>
	{
        void UpdateCard(int id, string name, string description, string image, int envoyCost, int turnsToFormation, int health, int armor, int power, in UnitTypes type);
    }
}