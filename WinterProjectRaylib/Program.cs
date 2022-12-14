global using Raylib_cs;
using System.Numerics;
const int screenHeight = 800;
const int screenWidth = 1000;


Raylib.InitWindow(screenWidth, screenHeight, "gam");
Raylib.SetTargetFPS(60);



Waltur waltur = new Waltur();
Jesser jesse = new Jesser();

while (!Raylib.WindowShouldClose())
{

    waltur.Update();


    
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BLACK);
    jesse.Draw();
    waltur.Draw();



    Raylib.EndDrawing();
}