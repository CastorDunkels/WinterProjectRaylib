using System;
using System.Text;

public class Dude
{
    public Rectangle rect;

    protected Texture2D sprite, spriteFace, spriteLeft, spriteRight, spriteBack, spriteGun;

    public const int ground = 700;

    protected float gravity = 0;

    protected float jump = -8;

    private string dialogueText;

    private double stopTime;



    public void drawSprite()
    {
        Raylib.DrawTexture(sprite, (int)rect.x, (int)rect.y, Color.WHITE);
    }
    public void drawDialogue()
    {
        if (Raylib.GetTime() < stopTime)
        {
            Raylib.DrawText(dialogueText, (int)rect.x, (int)rect.y-20, 10, Color.WHITE);
        }
    }

    protected void setDialogue(string dialogue)
    {
        Raylib.GetTime();
        dialogueText = dialogue;
        stopTime = Raylib.GetTime() + 5;

    }
    private void endDialogue(double stopTime)
    {

    }
    public virtual void talk()
    {

    }

    public bool CollidesWith(Rectangle otherRect)
    {
        return Raylib.CheckCollisionRecs(rect, otherRect);
    }


}
