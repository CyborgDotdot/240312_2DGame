﻿using System;
class Wall : GameObject
{
    //public Wall()
    //{
    //    Shape = '*';
    //}
    public Wall(int newX = 0, int newY = 0)
    {
        Shape = '*';

        x = newX;
        y = newY;
    }

    ~Wall()
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