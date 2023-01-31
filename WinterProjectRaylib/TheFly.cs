using System;

public class TheFly : Dude
{
    public TheFly()
    {
        startX = 700;
        startY = 700;
        sprite = Raylib.LoadTexture("Fly.png");
        rect = new Rectangle(startX, startY, sprite.width, sprite.height);

    }
    public void update()
    {
        if (life)
        {
            
        }
    }
}
