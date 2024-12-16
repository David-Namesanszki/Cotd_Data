using Cotd_Data.Models.GameInfos;
using Cotd_Data.Models.Games.Raids;
using Cotd_Data.ValueObjects;

namespace Cotd_Data._Interfaces
{
    public interface IGameRepository : IBaseRepository<GameData>
    {
        void UpdateGame(string id, string name, Loot resources, IList<string> unlockedCardIds, IList<string> unlockedCaptainIds, RaidData? ongoingRaid = null);
    }
}