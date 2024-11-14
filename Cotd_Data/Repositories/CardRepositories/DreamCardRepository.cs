using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cotd_Data.Repositories.CardRepositories;

public class DreamCardRepository : CardRepository<DreamCardData>, IDreamCardRepository
{
	public DreamCardRepository(string dataPath) : base(dataPath)
	{
	}

	public override DreamCardData GetOne(string id)
	{
		var card = this.GetAll().FirstOrDefault(c => c.Id == id);
		return card ?? throw new KeyNotFoundException($"Card with ID {id} not found.");
	}

	public void UpdateCard(string id, string name, string description, string image, int envoyCost)
	{
		var datas = GetAll();

		DreamCardData? card = datas.FirstOrDefault(c => c.Id == id);

		if (card == null)
		{
			throw new KeyNotFoundException($"Card with ID {id} not found.");
		}

		card.Name = name;
		card.Description = description;
		card.Image = image;
		card.EnvoyCost = envoyCost;

		DataSaver<DreamCardData>.Save(datas, dataPath);
	}
}
