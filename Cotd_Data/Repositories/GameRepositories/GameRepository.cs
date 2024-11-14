using Cotd_Data.Models.Cards;
using Cotd_Data.Models.GameInfos;
using Cotd_Data.Models.Games.Raids;
using Cotd_Data.Models.Games.Resources;

namespace Cotd_Data.Repositories.GameInfoRepositories;

public class GameRepository : BaseRepository<GameData>
{
	public GameRepository(string dataPath) : base(dataPath)
	{
	}

	public override GameData GetOne(string id)
	{
		var card = GetAll().FirstOrDefault(c => c.Id == id);
		return card ?? throw new KeyNotFoundException($"Card with ID {id} not found.");
	}

	public void UpdateGame(string id, string name, ResourceData resources, ICollection<string> unlockedCardIds, RaidData? ongoingRaid = null)
	{
		var datas = GetAll();
		GameData? game = datas.FirstOrDefault(c => c.Id == id) ?? throw new KeyNotFoundException($"Game with ID {id} not found.");

		game.Name = name;
		game.Resources = resources;
		game.UnlockedCardIds = unlockedCardIds;
		game.OngoingRaid = ongoingRaid;

		DataSaver<GameData>.Save(datas, dataPath);
	}
}
