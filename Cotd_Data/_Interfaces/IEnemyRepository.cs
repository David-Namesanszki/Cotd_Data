using Cotd_Data.Models.Enemies;

namespace Cotd_Data._Interfaces;

public interface IEnemyRepository : IBaseRepository<EnemyData>
{
    void UpdateEnemy(string id, string image, IList<string> cardIds);
}