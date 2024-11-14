using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cotd_Data.Repositories.CardRepositories;

public class UnitCardRepository : CardRepository<UnitCardData>, IUnitCardRepository
{
	public UnitCardRepository(string dataPath) : base(dataPath)
	{
	}

	public override UnitCardData GetOne(string id)
	{
		var card = this.GetAll().FirstOrDefault(c => c.Id == id);
		return card ?? throw new KeyNotFoundException($"Card with ID {id} not found.");
	}

	public void UpdateCard(
		string id,
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
		var datas = GetAll();

		UnitCardData? card = datas.FirstOrDefault(c => c.Id == id);

		if (card == null)
		{
			throw new KeyNotFoundException($"Card with ID {id} not found.");
		}

		card.Name = name;
		card.Description = description;
		card.Image = image;
		card.EnvoyCost = envoyCost;
		card.TurnsToFormation = turnsToFormation;
		card.Health = health;
		card.Armor = armor;
		card.Power = power;
		card.Type = type;

		DataSaver<UnitCardData>.Save(datas, dataPath);
	}
}
