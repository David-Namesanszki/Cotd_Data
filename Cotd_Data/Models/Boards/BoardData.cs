using Cotd_Data.Models.Boards.BoardTiles;
using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Boards;

public class BoardData : EntityData
{
	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;

	[JsonPropertyName("tiles")]
	public IList<BoardTileData> BoardTiles { get; set; } = [];

	public override string ToString()
	{
		string tilesSummary = BoardTiles != null && BoardTiles.Count > 0
			? $"[{string.Join(", ", BoardTiles.Select(tile => tile.ToString()))}]"
			: "[]";

		return $"{nameof(BoardData)}: " +
			   $"{nameof(Id)}={Id}, " +
			   $"{nameof(Name)}={Name}, " +
			   $"{nameof(BoardTiles)}={tilesSummary}";
	}
}
