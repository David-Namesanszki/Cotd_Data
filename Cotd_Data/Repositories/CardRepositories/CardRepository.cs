using Cotd_Data.Models.Cards;
using Microsoft.EntityFrameworkCore;

namespace Cotd_Data.Repositories.CardRepositories;

public abstract class CardRepository<T> : BaseRepository<T>, ICardRepository<T> where T : CardData
{
	public CardRepository(string dataPath) : base(dataPath)
	{
	}
}
