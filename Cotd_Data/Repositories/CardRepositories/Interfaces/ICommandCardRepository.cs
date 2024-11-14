using Cotd_Data.Models.Cards;

namespace Cotd_Data.Repositories.CardRepositories.Interfaces;

public interface ICommandCardRepository : ICardRepository<CommandCardData>
{
	void UpdateCard(string id, string name, string description, string image, int envoyCost);
}