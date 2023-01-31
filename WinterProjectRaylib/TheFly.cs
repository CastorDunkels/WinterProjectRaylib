using System;

public class TheFly : Dude
{
    public TheFly()
    {
        startX = 700;
        startY = 700;
        sprite = Raylib.LoadTexture("Fly.png");
        spriteDead = Raylib.LoadTexture("kiryu.png");
        rect = new Rectangle(startX, startY, sprite.width, sprite.height);

    }

    public void swat()
    {
        int killProbability = generator.Next(0, 100000000);
        if (killProbability == 7331)
        {
            kill();
            rect.x = 500;
            rect.y = 600;
        }
        else{   
            dodge();
        }
    }
    public void dodge()
    {
        rect.x = generator.Next(0, 1000);
        rect.y = generator.Next(600, 700);
    }

    public void update()
    {
        if (life == false)
        {
            sprite = spriteDead;
        }
    }
}
