using System;
class Player : GameObject
{
    public Player()
    {
        Shape = 'P';
    }

    public Player(int newX, int newY)
    {
        Shape = 'P';

        x = newX;
        y = newY;
    }

    ~Player()
    {

    }

    public bool isRunning = true;
    public override void Start()
    {

    }

    public override void Update()
    {
        if (Input.GetButton("Up"))
        {
            y--;
        }
        else if (Input.GetButton("Down"))
        {
            y++;
        }
        else if (Input.GetButton("Left"))
        {
            x--;
        }
        else if (Input.GetButton("Right"))
        {
            x++;
        }
        else if (Input.GetButton("Quit"))
        {

        }
        else if (Input.GetButton("Attack"))
        {

        }

        x = Math.Clamp(x, 0, 80);
        y = Math.Clamp(y, 0, 80);
    }
    //public override void Render()
    //{
    //    base.Render();
    //}
}