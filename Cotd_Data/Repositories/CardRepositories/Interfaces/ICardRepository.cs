using Cotd_Data.Models;

namespace Cotd_Data.Repositories.CardRepositories;

public interface ICardRepository<T> : IBaseRepository<T> where T : CardData
{
	void UnlockCard(int id);
	void UpdateCard(int id, string name, string description, string image, int envoyCost);
}