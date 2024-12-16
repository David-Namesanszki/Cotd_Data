using Cotd_Data.Models.Boards;
using Cotd_Data.Models.Boards.BoardTiles;

namespace Cotd_Data._Interfaces
{
    public interface IBoardRepository
    {
        BoardData GetOne(string id);
        void Update(BoardData entity);
        void UpdateBoard(string id, string name, IList<BoardTileData> tiles);
    }
}