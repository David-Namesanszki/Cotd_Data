using Cotd_Data.Models;
using Cotd_Data.Models.Cards;
using Microsoft.EntityFrameworkCore;

namespace Cotd_Data.Repositories.CardRepositories;

public abstract class CardRepository<T> : BaseRepository<T>, ICardRepository<T> where T : CardData
{
	public CardRepository(DbContext ctx) : base(ctx)
	{
	}

	public void UnlockCard(int id)
	{
		CardData cardData = GetOne(id);

		cardData.IsUnlocked = true;

		Ctx.SaveChanges();
	}

	public void UpdateCard(int id, string name, string description, string image, int envoyCost)
	{
		CardData card = GetOne(id);

		card.Name = name;
		card.Description = description;
		card.Image = image;
		card.EnvoyCost = envoyCost;

		Ctx.SaveChanges();
	}
}
