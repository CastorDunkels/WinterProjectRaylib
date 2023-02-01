using System.Xml.Serialization;
using System;

public class World
{
    public float GetGravity()
    {
        return 0.3f;
    }
    public float GetGround()
    {
        return 700;
    }
    public float GetWall()
    {
        return 1000;
        
    }

    public void DrawWorld()
    {
        Raylib.DrawLine(0, 0, 0, 800, Color.RED);
        Raylib.DrawLine(0, 800, 1075, 800, Color.RED);
        Raylib.DrawLine(1075, 0, 1075, 800, Color.RED);

    }
}
