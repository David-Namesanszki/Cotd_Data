using Cotd_Data.Models.Cards;

namespace Cotd_Data.Repositories.CardRepositories.Interfaces;

public interface IConstructionCardRepository : ICardRepository<ConstructionCardData>
{
	void UpdateCard(string id, string name, string description, string image, int envoyCost, int turnsToBuild, int armor, int power);
}