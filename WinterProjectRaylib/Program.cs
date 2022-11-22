global using Raylib_cs;
const int screenHeight = 800;
const int screenWidth = 1000;

Raylib.InitWindow(screenWidth, screenHeight, "gam");
Raylib.SetTargetFPS(60);



Waltur waltur = new Waltur();

while(!Raylib.WindowShouldClose())
{
    //logik
    waltur.Update();


    //grafik
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.GRAY);
    waltur.Draw();




    Raylib.EndDrawing();
}