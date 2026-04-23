//using Raylib_cs;

using Raylib_cs;

namespace MeinTilemapDrawer;

class Program{
    static void Main(string[] args){
        Console.WriteLine("Hello, World!");
        Raylib.InitWindow(640,480,"Tilemaps! :D");
        while (!Raylib.WindowShouldClose()){
            Raylib.BeginDrawing();
            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }
}