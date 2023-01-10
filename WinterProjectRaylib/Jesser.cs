using System.Net.Mime;
using System.Diagnostics;
using System.Text;

public class Jesser : Dude
{
    public int placeX = 200;
    public int placeY = Dude.ground;
    public string text;

    private int index;


    public Jesser()
    {
        theJesser = this;

        sprite = Raylib.LoadTexture("JessePinkman.png");
        rect = new Rectangle(placeX, placeY, sprite.width, sprite.height);
        
    }

    public void JesseTalk()
    {
        Random rnd = new();
        List<string> JesseInteracts = new List<string>() { "Mr. White, what's the problem?", "Mr. White, we have to cook", "Mr. White, why don't you just sit down", "Mr. White, what are you doing? " };
        index = rnd.Next(JesseInteracts.Count);
        text = JesseInteracts[index];
        byte[] bytes = Encoding.ASCII.GetBytes(text);
    }

}