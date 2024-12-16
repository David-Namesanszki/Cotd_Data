using Cotd_Data.ValueObjects;
using System.Text.Json.Serialization;

namespace Cotd_Data.Models.Boards.BoardTiles;

public enum TileTypes
{
    Unit,
    Construction,
    Effect,
    Undefined,
}

public enum TeamSides
{
    Red,
    Blue,
    Neutral,
    Undefined
}

public class BoardTileData : EntityData
{
    [JsonPropertyName("coords")]
    public CubeCoord Coords { get; set; } = new CubeCoord();

    [JsonPropertyName("tileType")]
    public TileTypes TileType { get; set; } = TileTypes.Undefined;

    [JsonPropertyName("teamSide")]
    public TeamSides TeamSide { get; set; } = TeamSides.Undefined;

	public override string ToString()
	{
		return $"{nameof(BoardTileData)}: " +
			   $"{nameof(Id)}={Id}, " +
			   $"{nameof(Coords)}={Coords}, " +
			   $"{nameof(TileType)}={TileType}, " +
			   $"{nameof(TeamSide)}={TeamSide}";
	}
}
