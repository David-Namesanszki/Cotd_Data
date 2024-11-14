using Cotd_Data.Models.Cards;
using Cotd_Data.Models.GameInfos;

namespace Cotd_Data.Repositories.GameInfoRepositories
{
    public interface IGameRepository : IBaseRepository<GameData>
	{
		GameData GetOne(int id);
		void UpdateGameInfo(int id, string name, int heartwood, int barkOre, int bloodSap);
		void UnlockCard(int id, CardData card);
	}
}