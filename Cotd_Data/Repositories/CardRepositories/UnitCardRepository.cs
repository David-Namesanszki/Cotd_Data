using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cotd_Data.Repositories.CardRepositories;

public class UnitCardRepository(DbContext ctx) : BaseRepository<UnitCardData>(ctx), IUnitCardRepository
{
	public override UnitCardData GetOne(int id)
	{
		var card = this.GetAll().FirstOrDefault(c => c.Id == id);
		return card ?? throw new KeyNotFoundException($"Card with ID {id} not found.");
	}

	public void UpdateCard(
		int id,
		string name,
		string description,
		string image,
		int envoyCost,
		int turnsToFormation,
		int health,
		int armor,
		int power,
		in UnitTypes type)
	{
		UnitCardData card = this.GetOne(id);

		card.Name = name;
		card.Description = description;
		card.Image = image;
		card.EnvoyCost = envoyCost;
		card.TurnsToFormation = turnsToFormation;
		card.Health = health;
		card.Armor = armor;
		card.Power = power;
		card.Type = type;

		Ctx.SaveChanges();
	}
}
