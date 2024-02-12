using System.Security.Cryptography;

namespace Arrays_and_Lists;

public static class TerrainTypesExtensions {
    public static char GetChar(this TerrainTypes terrain) {
        return terrain switch {
            TerrainTypes.Grass => '\u201c',
            TerrainTypes.Water => '\u2248',
            TerrainTypes.Sand => '\u25cb',
            _ => '\u25cf'
        };
    }

    public static ConsoleColor GetColor(this TerrainTypes terrain) {
        return terrain switch {
            TerrainTypes.Grass => ConsoleColor.Green,
            TerrainTypes.Water => ConsoleColor.Blue,
            TerrainTypes.Sand => ConsoleColor.Yellow,
            _ => ConsoleColor.DarkGray
        };
    }


}
