using System.Numerics;
using Raylib_cs;

namespace QuickType;

public partial class Tile{
    public void Draw(Texture2D tex, int TileSize){
        bool flipX = (F & 1) != 0;
        bool flipY = (F & 2) != 0;
        Rectangle source = new(Src[0], Src[1], flipX?-TileSize:TileSize, flipY?-TileSize:TileSize);
        Rectangle dest = new(Px[0], Px[1], TileSize, TileSize);
        Raylib.DrawTexturePro(tex, source,dest, Vector2.Zero, 0, Color.White);
    }
}
