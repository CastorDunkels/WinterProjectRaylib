using System;


public class Waltur : Dude
{
    private Texture2D spriteFace, spriteLeft, spriteRight, spriteBack, spriteGun;
    private float speed = 5f;

    private float playerY = Dude.ground;

    public float playerX = 20;

    private bool OnGround;

    bool action;

    public Waltur()
    {
        theWalter = this;
        spriteLeft = Raylib.LoadTexture("WalterWhiteLeftSideView.png");
        spriteFace = Raylib.LoadTexture("WalterWhite.png");
        spriteRight = Raylib.LoadTexture("WalterWhiteRightSideView.png");
        spriteBack = Raylib.LoadTexture("WalterWhiteBackView.png");
        spriteGun = Raylib.LoadTexture("WalterWhiteGun.png");
        sprite = spriteFace;
        rect = new Rectangle(playerX, playerY, sprite.width, sprite.height);

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

        if (rect.y > 698)
        {
            rect.y = 700;
            gravity = 0;
            OnGround = true;
        }
        else if (rect.y <= 698)
        {
            rect.y += gravity;
            gravity += acceleration;
            OnGround = false;
        }

        /*if (theJesser.CollidesWith(rect) && Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
        {
            sprite = spriteGun;
            theJesser.JesseTalk();
        }
        else
        {

        }*/
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
        {
            action = true;
            if (action)
            {
                theJesser.JesseTalk();
            }
        }
        else{
            action = false;
        }



        if (theJesser.CollidesWith(rect) && action)
        {
            sprite = spriteGun;
            Raylib.DrawText(theJesser.text, theJesser.placeX - 40, theJesser.placeY - 50, 20, Color.PINK);
        }
    }


}
