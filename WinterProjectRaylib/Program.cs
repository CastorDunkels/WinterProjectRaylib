global using Raylib_cs;
global using System.Numerics;

const int screenHeight = 800;
const int screenWidth = 1000;


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
    Raylib.BeginMode2D(camera.getCamera2D());
    Raylib.DrawLine((int)waltur.rect.x - screenWidth, screenHeight + 1, (int)waltur.rect.x + screenWidth, screenHeight + 1, Color.RED);
    Raylib.DrawLine(1075, 0, 1075, 800, Color.RED);
    jesse.drawSprite();
    fly.drawSprite();
    waltur.drawSprite();
    jesse.drawDialogue();
    waltur.drawDialogue();


    Raylib.EndMode2D();
    Raylib.EndDrawing();
}