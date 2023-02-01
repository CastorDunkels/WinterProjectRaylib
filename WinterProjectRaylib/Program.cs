global using Raylib_cs;
global using System.Numerics;

int screenHeight = Raylib.GetScreenHeight();
int screenWidth = Raylib.GetScreenWidth();


Raylib.InitWindow(screenWidth, screenHeight, "gam");
Raylib.SetTargetFPS(60);


World world = new World();
Waltur waltur = new Waltur(world);
Jesser jesse = new Jesser();
TheFly fly = new TheFly();
Camera camera = new Camera(waltur);
waltur.setJesse(jesse);
waltur.setFly(fly);

while (!Raylib.WindowShouldClose())
{


    waltur.update();
    camera.update();
    fly.update();



    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BLACK);
    Raylib.BeginMode2D(camera.GetCamera2D());
    jesse.DrawSprite();
    fly.DrawSprite();
    waltur.DrawSprite();
    jesse.DrawDialogue();
    waltur.DrawDialogue();
    world.DrawWorld();


    Raylib.EndMode2D();
    Raylib.EndDrawing();
}