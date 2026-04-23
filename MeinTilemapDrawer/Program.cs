//using Raylib_cs;

using Raylib_cs;

namespace MeinTilemapDrawer;

class Program{
    static void Main(string[] args){
        Console.WriteLine("Hello, World!");
        Raylib.InitWindow(640,480,"Tilemaps! :D");
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.White);
        Raylib.DrawText("Loading...", 10, 10, 80, Color.Black);
        Raylib.EndDrawing();
        FileStream fs = new("ldtk/project/Level_0.ldtkl", FileMode.Open);
        
        while (!Raylib.WindowShouldClose()){
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);
            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }
}