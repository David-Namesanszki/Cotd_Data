using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cotd_Data.Repositories.CardRepositories;

public class DreamCardRepository : CardRepository<DreamCardData>, IDreamCardRepository
{
	public DreamCardRepository(DbContext ctx) : base(ctx)
	{
	}

	public override DreamCardData GetOne(int id)
	{
		var card = this.GetAll().FirstOrDefault(c => c.Id == id);
		return card ?? throw new KeyNotFoundException($"Card with ID {id} not found.");
	}
}
