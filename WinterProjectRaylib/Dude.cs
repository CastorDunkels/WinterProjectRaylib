using System;

public class Dude
{
    //position
    public Rectangle rect;

    //sprite
    public Texture2D sprite;

    //movement
    public float speed = 5f;



    public Dude()
    {
    }

    public void Draw()
    {
        Raylib.DrawTexture(sprite, (int)rect.x, (int)rect.y, Color.WHITE);
    }


}
