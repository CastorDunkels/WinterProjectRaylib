using System.Diagnostics;
using System.Text;

public class Jesser : Dude
{
    public int placeX = 200;
    public int placeY = Dude.ground;

    public string text = "Yo mr White, what's the problem yo?";
    public Jesser()
    {
        sprite = Raylib.LoadTexture("JessePinkman.png");
        rect = new Rectangle(placeX, placeY, sprite.width, sprite.height);
        byte[] bytes = Encoding.ASCII.GetBytes(text);
    }


}