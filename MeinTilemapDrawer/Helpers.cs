using System.Numerics;
using Raylib_cs;

namespace QuickType;

public partial class Tile{
    public void Draw(Texture2D tex, int TileSize){
        Rectangle source = new(Src[0], Src[1], TileSize, TileSize);
        Rectangle dest = new(Px[0], Px[1], TileSize, TileSize);
        Raylib.DrawTexturePro(tex, source,dest, Vector2.Zero, 0, Color.White);
    }
}