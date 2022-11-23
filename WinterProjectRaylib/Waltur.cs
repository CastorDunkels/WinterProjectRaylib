using System;


public class Waltur : Dude
{
    private Texture2D spriteFace, spriteLeft, spriteRight, spriteBack;
    private float speed = 5f;

    public Waltur()
    {
        spriteLeft = Raylib.LoadTexture("WalterWhiteLeftSideView.png");
        spriteFace = Raylib.LoadTexture("WalterWhite.png");
        spriteRight = Raylib.LoadTexture("WalterWhiteRightSideView.png");
        spriteBack = Raylib.LoadTexture("WalterWhiteBackView.png");
        rect = new Rectangle(spawnPositionX, spawnPositionY, sprite.width, sprite.height);
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
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            sprite = spriteBack;
            rect.y -= speed;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            sprite = spriteFace;
            rect.y += speed;
        }
        else
        {
            sprite = spriteFace;
        }



    }


}
