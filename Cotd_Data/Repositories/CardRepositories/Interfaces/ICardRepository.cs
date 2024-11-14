using Cotd_Data.Models.Cards;

namespace Cotd_Data.Repositories.CardRepositories;

public interface ICardRepository<T> : IBaseRepository<T> where T : CardData
{
}