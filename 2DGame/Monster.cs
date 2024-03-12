using System;
class Monster : GameObject
{
    public Monster()
    {
        Shape = 'M';
    }

    public Monster(int newX, int newY)
    {
        Shape = 'M';

        x = newX;
        y = newY;
    }

    ~Monster()
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