using System;

public class Dude
{
    //position
    protected Rectangle rect;

    //sprite
    protected Texture2D sprite;

    protected int spawnPositionX = 20;
    protected int spawnPositionY = 700;

    public void Draw()
    {
        Raylib.DrawTexture(sprite, (int)rect.x, (int)rect.y, Color.WHITE);
    }


}
