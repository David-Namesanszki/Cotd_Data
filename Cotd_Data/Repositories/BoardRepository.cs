using Cotd_Data._Interfaces;
using Cotd_Data.Models.Boards;
using Cotd_Data.Models.Boards.BoardTiles;

namespace Cotd_Data.Repositories;

public class BoardRepository : BaseRepository<BoardData>, IBoardRepository
{
	public BoardRepository(string dataPath) : base(dataPath)
	{
	}

	public override BoardData GetOne(string id)
	{
		var board = GetAll().FirstOrDefault(c => c.Id == id);
		return board ?? throw new KeyNotFoundException($"Board with ID {id} not found.");
	}

	public override void Update(BoardData entity)
	{
		UpdateBoard(entity.Id, entity.Name, entity.BoardTiles);
	}

	public void UpdateBoard(string id, string name, IList<BoardTileData> boardTiles)
	{
		var datas = GetAll();

		BoardData? enemy = datas.FirstOrDefault(c => c.Id == id);

		if (enemy == null)
		{
			throw new KeyNotFoundException($"Board with ID {id} not found.");
		}

		enemy.Name = name;
		enemy.BoardTiles = boardTiles;

		DataSaver<BoardData>.Save(datas, dataPath);
	}
}
