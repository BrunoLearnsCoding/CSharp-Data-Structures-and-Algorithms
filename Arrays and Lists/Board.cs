

using System.Data;

namespace Arrays_and_Lists;

public class Board {
    private TerrainTypes[,] _board;
    public Board()
    {
        _board = GetPopulatedBoard();
    }

    private TerrainTypes[,] GetPopulatedBoard()
    {
        TerrainTypes[,] board = {
            { TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Sand, TerrainTypes.Sand, TerrainTypes.Sand},
            { TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Sand, TerrainTypes.Sand, TerrainTypes.Sand},
            { TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Wall, TerrainTypes.Sand, TerrainTypes.Sand, TerrainTypes.Sand},
            { TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Sand, TerrainTypes.Wall, TerrainTypes.Sand, TerrainTypes.Sand, TerrainTypes.Sand},
            { TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Sand, TerrainTypes.Sand, TerrainTypes.Sand, TerrainTypes.Wall, TerrainTypes.Sand, TerrainTypes.Sand, TerrainTypes.Sand},
            { TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Water, TerrainTypes.Sand, TerrainTypes.Sand, TerrainTypes.Sand, TerrainTypes.Wall, TerrainTypes.Sand, TerrainTypes.Sand, TerrainTypes.Sand},
            { TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Wall, TerrainTypes.Grass, TerrainTypes.Sand, TerrainTypes.Sand},
            { TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Wall, TerrainTypes.Wall, TerrainTypes.Wall, TerrainTypes.Wall, TerrainTypes.Grass, TerrainTypes.Sand, TerrainTypes.Sand},
            { TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Sand, TerrainTypes.Sand},
            { TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Grass, TerrainTypes.Sand, TerrainTypes.Sand},
        };
        return board;
    }

    public TerrainTypes this[int row, int column] {
        get { return _board[row,column]; }
    }
}
