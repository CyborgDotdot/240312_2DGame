using System;
class Goal : GameObject
{
    public Goal()
    {
        Shape = 'G';
    }
    public Goal(int newX, int newY)
    {
        Shape = 'G';

        x = newX;
        y = newY;
    }

    ~Goal()
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
        base.Render();
    }
}