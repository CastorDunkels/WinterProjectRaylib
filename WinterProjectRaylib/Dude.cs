using System;
using System.Text;

public class Dude
{
    public Rectangle rect;

    protected Texture2D sprite, spriteFace, spriteLeft, spriteRight, spriteBack, spriteGun, spriteDead;

    protected int startX, startY;

    protected int index;

    protected float gravity = 0;

    protected float jump = -8;

    private string dialogueText;

    private double stopTime;

    protected bool life = true;

    public Random generator = new Random();






    public void DrawSprite()
    {
        Raylib.DrawTexture(sprite, (int)rect.x, (int)rect.y, Color.WHITE);
    }
    public void DrawDialogue()
    {
        if (Raylib.GetTime() < stopTime)
        {
            Raylib.DrawText(dialogueText, (int)rect.x, (int)rect.y - 20, 10, Color.WHITE);
        }
    }

    protected void SetDialogue(string dialogue)
    {
        Raylib.GetTime();
        dialogueText = dialogue;
        stopTime = Raylib.GetTime() + 5;

    }

    public virtual void Talk()
    {

    }

    public bool CollidesWith(Rectangle otherRect)
    {
        return Raylib.CheckCollisionRecs(rect, otherRect);
    }

    public void Kill()
    {
        life = false;
        
    }
    public bool IsDead()
    {
        if(life == false)
        {
            return true;
        }
        else{
            return false;
        }
    }


}

