using Cotd_Data._Interfaces;
using Cotd_Data.Models.Cards;

namespace Cotd_Data.Repositories;

public class CardRepository : BaseRepository<CardData>, ICardRepository
{
    public CardRepository(string dataPath) : base(dataPath)
    {
    }

    public override CardData GetOne(string id)
    {
        var card = GetAll().FirstOrDefault(c => c.Id == id);
        return card ?? throw new KeyNotFoundException($"Card with ID {id} not found.");

    }

    public override void Update(CardData entity)
    {
        var datas = GetAll();

        CardData? card = datas.FirstOrDefault(c => c.Id == entity.Id) ?? throw new KeyNotFoundException($"Card with ID {entity.Id} not found.");

		foreach (var propInfo in entity.GetType().GetProperties())
		{
			if (propInfo.CanWrite) // Ensure the property is writable
			{
				propInfo.SetValue(card, propInfo.GetValue(entity));
			}
		}

		DataSaver<CardData>.Save(datas, dataPath);
    }
}
