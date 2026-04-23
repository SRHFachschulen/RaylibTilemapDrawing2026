using System.Numerics;
using Raylib_cs;

namespace MeinTilemapDrawer;

class Program{
    static void Main(string[] args){
        Console.WriteLine("Hello, World!");
        Raylib.SetConfigFlags(ConfigFlags.ResizableWindow | ConfigFlags.UndecoratedWindow);
        Raylib.InitWindow(640, 480, "Tilemaps! :D");
        int und = 155 & 244;

        // Ladebildschirm zum Spaß
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.White);
        Raylib.DrawText("Loading...", 10, 10, 80, Color.Black);
        Raylib.EndDrawing();

        // Ende Ladebildschirm
        FileStream fs = new("ldtk/project/Level_0.ldtkl", FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        string jsonString = sr.ReadToEnd();
        QuickType.Level level = QuickType.Level.FromJson(jsonString);
        Texture2D Tileset = Raylib.LoadTexture("ldtk/tilemap_packed.png");
        while (!Raylib.WindowShouldClose()){
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);
            for (int iL = level.LayerInstances.Count - 1; iL >= 0; iL--){
                // Iteriere rückwärts durch Layer
                int TileSize = (int)level.LayerInstances[iL].GridSize;
                for (int iT = 0; iT < level.LayerInstances[iL].AutoLayerTiles.Count; iT++){
                    //Iteriere durch AutoLayerTiles
                    level.LayerInstances[iL].AutoLayerTiles[iT].Draw(Tileset, TileSize);
                }
            }

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}