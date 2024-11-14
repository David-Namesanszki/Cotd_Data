using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cotd_Data.Repositories.CardRepositories;

public class ConstructionCardRepository : CardRepository<ConstructionCardData>, IConstructionCardRepository
{

	public ConstructionCardRepository(string dataPath) : base(dataPath)
	{
	}

	public override ConstructionCardData GetOne(string id)
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
		int turnsToBuild,
		int armor,
		int power)
	{
		var datas = GetAll();

		ConstructionCardData? card = datas.FirstOrDefault(c => c.Id == id);

		if (card == null)
		{
			throw new KeyNotFoundException($"Card with ID {id} not found.");
		}

		card.Name = name;
		card.Description = description;
		card.Image = image;
		card.EnvoyCost = envoyCost;
		card.TurnsToBuild = turnsToBuild;
		card.Armor = armor;
		card.Power = power;

		DataSaver<ConstructionCardData>.Save(datas, dataPath);
	}
}
