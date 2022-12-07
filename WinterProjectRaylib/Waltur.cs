using System;


public class Waltur : Dude
{
    private Texture2D spriteFace, spriteLeft, spriteRight, spriteBack, spriteGun;
    private float speed = 5f;

    private float playerY = Dude.ground;

    public float playerX = 20;

    private bool InAir = false;

    private bool OnGround = false;

    public Waltur()
    {
        spriteLeft = Raylib.LoadTexture("WalterWhiteLeftSideView.png");
        spriteFace = Raylib.LoadTexture("WalterWhite.png");
        spriteRight = Raylib.LoadTexture("WalterWhiteRightSideView.png");
        spriteBack = Raylib.LoadTexture("WalterWhiteBackView.png");
        spriteGun = Raylib.LoadTexture("WalterWhiteGun.png");
        rect = new Rectangle(playerX, playerY, sprite.width, sprite.height);

    }
    Jesser jesse = new();
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
            if (InAir)
            {
                acceleration = 0.25f;
            }
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            sprite = spriteFace;
            if (InAir)
            {
                acceleration = 1f;
            }
        }
        else
        {
            acceleration = 0.3f;
        }

        if (rect.y > 698)
        {
            rect.y = 700;
            gravity = 0;
            OnGround = true;
            InAir = false;
        }
        else if (rect.y <= 698)
        {
            rect.y += gravity;
            gravity += acceleration;
            InAir = true;
            OnGround = false;
        }

        if (rect.x <= jesse.placeX + 90 && rect.x >= jesse.placeX - 90 )
        {
            sprite = spriteGun;
            Raylib.DrawText(jesse.text, jesse.placeX-40, jesse.placeY-50, 20, Color.PINK);
        }
        else
        {

        }


    }


}
