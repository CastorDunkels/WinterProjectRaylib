global using Raylib_cs;
using System.Runtime.Intrinsics;
using System.Numerics;
const int screenHeight = 800;
const int screenWidth = 1000;


Raylib.InitWindow(screenWidth, screenHeight, "gam");
Raylib.SetTargetFPS(60);


World world = new World();
Waltur waltur = new Waltur(world);
Jesser jesse = new Jesser();
TheFly fly = new TheFly();
waltur.setJesse(jesse);

Camera2D cakera = new()
{
    target = new Vector2(),
    offset = new Vector2(Raylib.GetScreenWidth() / 2, Raylib.GetScreenHeight() / 2),
    zoom = 1.2f,
};

while (!Raylib.WindowShouldClose())
{
    cakera.target = new Vector2(waltur.rect.x + 35, waltur.rect.y - 100);


    waltur.Update();



    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BLACK);
    Raylib.BeginMode2D(cakera);
    Raylib.DrawLine((int)waltur.rect.x - screenWidth, screenHeight + 1, (int)waltur.rect.x + screenWidth, screenHeight + 1, Color.RED);
    jesse.drawSprite();
    fly.drawSprite();
    waltur.drawSprite();
    jesse.drawDialogue();


    Raylib.EndMode2D();
    Raylib.EndDrawing();
}