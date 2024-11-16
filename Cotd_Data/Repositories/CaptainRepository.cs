using Cotd_Data._Interfaces;
using Cotd_Data.Models.Captains;

namespace Cotd_Data.Repositories;

public class CaptainRepository : BaseRepository<CaptainData>, ICaptainRepository
{
    public CaptainRepository(string dataPath) : base(dataPath)
    {
    }

    public override CaptainData GetOne(string id)
    {
        var captain = GetAll().FirstOrDefault(c => c.Id == id);
        return captain ?? throw new KeyNotFoundException($"Captain with ID {id} not found.");
    }

    public override void Update(CaptainData entity)
    {
        UpdateCaptain(
            entity.Id,
            entity.Name,
            entity.Health,
            entity.Power,
            entity.Armor,
            entity.Image,
            entity.CardIds);
    }

    public void UpdateCaptain(string id, string name, int health, int power, int armor, string image, IList<string> cardIds)
    {
        var datas = GetAll();

        CaptainData? captain = datas.FirstOrDefault(c => c.Id == id);

        if (captain == null)
        {
            throw new KeyNotFoundException($"Captain with ID {id} not found.");
        }

        captain.Name = name;
        captain.Armor = armor;
        captain.Image = image;
        captain.Health = health;
        captain.Power = power;
        captain.CardIds = cardIds;

        DataSaver<CaptainData>.Save(datas, dataPath);
    }
}
