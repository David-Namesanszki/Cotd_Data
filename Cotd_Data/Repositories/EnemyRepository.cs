using Cotd_Data._Interfaces;
using Cotd_Data.Models.Captains;
using Cotd_Data.Models.Enemies;

namespace Cotd_Data.Repositories;

public class EnemyRepository : BaseRepository<EnemyData>, IEnemyRepository
{
    public EnemyRepository(string dataPath) : base(dataPath)
    {
    }

    public override EnemyData GetOne(string id)
    {
        var captain = GetAll().FirstOrDefault(c => c.Id == id);
        return captain ?? throw new KeyNotFoundException($"Enemy with ID {id} not found.");
    }

    public override void Update(EnemyData entity)
    {
        UpdateEnemy(entity.Id, entity.Image, entity.CardIds);
    }

    public void UpdateEnemy(string id, string image, IList<string> cardIds)
    {
        var datas = GetAll();

        EnemyData? enemy = datas.FirstOrDefault(c => c.Id == id);

        if (enemy == null)
        {
            throw new KeyNotFoundException($"Enemy with ID {id} not found.");
        }

        enemy.Image = image;
        enemy.CardIds = cardIds;

        DataSaver<EnemyData>.Save(datas, dataPath);
    }
}
