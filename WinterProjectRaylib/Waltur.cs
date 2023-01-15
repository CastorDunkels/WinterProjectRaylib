using System;


public class Waltur : Dude
{
    private float speed = 5f;

    private float playerY = Dude.ground;

    private float playerX = 20;

    private bool OnGround;

    bool action;
    private Jesser theJesser;

    public World theWorld;

    public Waltur(World world)
    {
        theWorld = world;
        spriteLeft = Raylib.LoadTexture("WalterWhiteLeftSideView.png");
        spriteFace = Raylib.LoadTexture("WalterWhite.png");
        spriteRight = Raylib.LoadTexture("WalterWhiteRightSideView.png");
        spriteBack = Raylib.LoadTexture("WalterWhiteBackView.png");
        spriteGun = Raylib.LoadTexture("WalterWhiteGun.png");
        sprite = spriteFace;
        rect = new Rectangle(playerX, playerY, sprite.width, sprite.height);

    }
    public void setJesse(Jesser jesse)
    {
        theJesser = jesse;
    }
    public void Update()
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
            sprite = spriteRight;
            rect.x += speed;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            sprite = spriteLeft;
            rect.x -= speed;
        }
        else
        {
            sprite = spriteFace;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
        {
            if (OnGround)
            {
                rect.y -= 2;
                gravity = jump;

            }
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            sprite = spriteBack;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            sprite = spriteFace;
        }

        if (rect.y > theWorld.getGround() - 2)
        {
            rect.y = theWorld.getGround();
            gravity = 0;
            OnGround = true;
        }
        else if (rect.y <= theWorld.getGround() - 2)
        {
            rect.y += gravity;
            gravity += theWorld.getGravity();
            OnGround = false;
        }

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
        {
            action = true;
            if (action)
            {
                theJesser.talk();
            }
        }
        else{
            action = false;
        }


    }


}
