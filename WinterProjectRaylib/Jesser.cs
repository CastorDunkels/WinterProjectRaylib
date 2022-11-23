public class Jesser : Dude
{
    public Jesser()
    {
        spawnPositionX = 100;
        sprite = Raylib.LoadTexture("JessePinkman.png");
        rect = new Rectangle(spawnPositionX, spawnPositionY, sprite.width, sprite.height);
    }

}
