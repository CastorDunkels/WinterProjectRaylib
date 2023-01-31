using System;
public class Camera
{

    private Waltur theWaltur;

    private Camera2D camera2D;
    public Camera(Waltur waltur)
    {
        theWaltur = waltur;
        camera2D = new()
        {
            target = new Vector2(),
            offset = new Vector2(Raylib.GetScreenWidth() / 2, Raylib.GetScreenHeight() / 2),
            zoom = 1.2f,
        };
    }
    public Camera2D getCamera2D()
    {
        return camera2D;
    }

    public void update()
    {
        camera2D.target = new Vector2(theWaltur.rect.x + 35, theWaltur.rect.y - 100);
    }

}
