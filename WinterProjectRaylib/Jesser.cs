using System.Net.Mime;
using System.Diagnostics;
using System.Text;

public class Jesser : Dude
{
    private int index;

    public Jesser()
    {
        startX = 200;
        startY = 700;
        sprite = Raylib.LoadTexture("JessePinkman.png");
        spriteGun = Raylib.LoadTexture("JesseGun.jpg");
        rect = new Rectangle(startX, startY, sprite.width, sprite.height);
        
    }

    public override void talk()
    {
        Random rnd = new();
        List<string> JesseInteracts = new List<string>() { "Mr. White, what's the problem?", "Mr. White, we have to cook", "Mr. White, why don't you just sit down", "Mr. White, what are you doing? " };
        index = rnd.Next(JesseInteracts.Count);
        setDialogue(JesseInteracts[index]);
    }

}