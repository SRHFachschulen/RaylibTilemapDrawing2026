//using Raylib_cs;

using System.Numerics;
using Raylib_cs;

namespace MeinTilemapDrawer;

class Program{
    static void Main(string[] args){
        Console.WriteLine("Hello, World!");
        Raylib.InitWindow(800, 600, "Tilemaps! :D");

        Camera2D camera = new Camera2D(){
            Target = Vector2.Zero,
            Offset = Vector2.Zero,
            Rotation = 0f,
            Zoom = 4f
        };


        Texture2D tileset = Raylib.LoadTexture("ldtk/tilemap_packed.png");

        FileStream fileStream = new FileStream("ldtk/project/Level_0.ldtkl", FileMode.Open);
        QuickType.Level theLevel = QuickType.Level.FromJson(new StreamReader(fileStream).ReadToEnd());

        while (!Raylib.WindowShouldClose()){
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);
            Raylib.BeginMode2D(camera);
            for (int iLayer = theLevel.LayerInstances.Count - 1; iLayer >= 0; iLayer--){
                var layer = theLevel.LayerInstances[iLayer];
                foreach (var autoTile in layer.AutoLayerTiles){
                    autoTile.Draw(tileset);
                }

                foreach (var gridTile in layer.GridTiles){
                    gridTile.Draw(tileset);
                }
            }

            Raylib.EndMode2D();
            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}