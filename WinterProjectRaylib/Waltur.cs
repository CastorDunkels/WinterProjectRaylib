using System.Diagnostics;
using System;


public class Waltur : Dude
{
    private float speed = 5f;

    private bool OnGround;

    private bool action;

    private Jesser theJesser;

    private TheFly theFly;

    private World theWorld;

    public Waltur(World world)
    {
        theWorld = world;
        startX = 100;
        startY = 700;
        spriteLeft = Raylib.LoadTexture("WalterWhiteLeftSideView.png");
        spriteFace = Raylib.LoadTexture("WalterWhite.png");
        spriteRight = Raylib.LoadTexture("WalterWhiteRightSideView.png");
        spriteBack = Raylib.LoadTexture("WalterWhiteBackView.png");
        spriteGun = Raylib.LoadTexture("WalterWhiteGun.png");
        sprite = spriteFace;
        rect = new Rectangle(startX, startY, sprite.width, sprite.height);

    }
    
    public void setJesse(Jesser jesse)
    {
        theJesser = jesse;
    }
    public void setFly(TheFly fly)
    {
        theFly = fly;
    }
    public override void Talk()
    {
        Random rnd = new();
        List<string> winDialogue = new List<string>() { "You did it!!!", "The fly has been eradicated.", "You finally did it!?" };
        index = rnd.Next(winDialogue.Count);
        SetDialogue(winDialogue[index]);
    }
    
    public void update()
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

        if (rect.y > theWorld.GetGround() - 2)
        {
            rect.y = theWorld.GetGround();
            gravity = 0;
            OnGround = true;
        }
        else
        {
            rect.y += gravity;
            gravity += theWorld.GetGravity();
            OnGround = false;
        }
        if (rect.x >= theWorld.GetWall())
        {
            rect.x = theWorld.GetWall();
        }


        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
        {
            action = true;
        }
        else
        {
            action = false;
        }

        if (action && theJesser.CollidesWith(rect))
        {
            theJesser.Talk();
        }
        if (!theFly.IsDead()){

            if (theFly.CollidesWith(rect))
            {
                sprite = spriteGun;
                if (action)
                {   
                    theFly.Swat();
                    if (theFly.IsDead())
                    {
                        Talk();
                    }
                }
            }
        }
    }


}
