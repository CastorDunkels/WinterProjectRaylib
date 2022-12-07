using System;

public class Dude
{
    protected Rectangle rect;

    protected Texture2D sprite;

    public const int ground = 700;

    protected float acceleration = 0.3f;

    protected float gravity = 0;

    protected float jump = -8;



    public void Draw()
    {
        Raylib.DrawTexture(sprite, (int)rect.x, (int)rect.y, Color.WHITE);
    }


}
