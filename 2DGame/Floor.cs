using System;
class Floor : GameObject
{
    public Floor()
    {
        Shape = ' ';
    }

    public Floor(int newX, int newY)
    {
        Shape = ' ';

        x = newX;
        y = newY;
    }

    ~Floor()
    {

    }

    public override void Start()
    {

    }

    public override void Update()
    {

    }

    public override void Render()
    {
        //base.Render();
    }
}
