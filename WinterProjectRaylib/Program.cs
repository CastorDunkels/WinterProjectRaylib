global using Raylib_cs;
global
using System.Numerics;
const int screenHeight = 800;
const int screenWidth = 1000;

Raylib.InitWindow(screenWidth, screenHeight, "gam");
Raylib.SetTargetFPS(60);



Waltur waltur = new Waltur();
Jesser jesse = new Jesser();

while (!Raylib.WindowShouldClose())
{
    //logik
    waltur.Update();


    //grafik
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.GRAY);
    jesse.Draw();
    waltur.Draw();



    Raylib.EndDrawing();
}