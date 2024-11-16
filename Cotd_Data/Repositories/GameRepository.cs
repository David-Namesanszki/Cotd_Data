using Cotd_Data._Interfaces;
using Cotd_Data.Models.GameInfos;
using Cotd_Data.Models.Games.Raids;
using Cotd_Data.Models.Games.Resources;

namespace Cotd_Data.Repositories;

public class GameRepository : BaseRepository<GameData>, IGameRepository
{
    public GameRepository(string dataPath) : base(dataPath)
    {
    }

    public override GameData GetOne(string id)
    {
        var card = GetAll().FirstOrDefault(c => c.Id == id);
        return card ?? throw new KeyNotFoundException($"Game with ID {id} not found.");
    }

    public override void Update(GameData entity)
    {
        UpdateGame(
            entity.Id,
            entity.Name,
            entity.Resources,
            entity.UnlockedCardIds,
            entity.UnlockedCaptainIds,
            entity.OngoingRaid);
    }

    public void UpdateGame(string id, string name, ResourceData resources, IList<string> unlockedCardIds, IList<string> unlockedCaptainIds, RaidData? ongoingRaid = null)
    {
        var datas = GetAll();
        GameData? game = datas.FirstOrDefault(c => c.Id == id) ?? throw new KeyNotFoundException($"Game with ID {id} not found.");

        game.Name = name;
        game.Resources = resources;
        game.UnlockedCardIds = unlockedCardIds;
        game.OngoingRaid = ongoingRaid;
        game.UnlockedCaptainIds = unlockedCaptainIds;

        DataSaver<GameData>.Save(datas, dataPath);
    }
}
