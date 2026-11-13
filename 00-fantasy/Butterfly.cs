using System;
using System.ComponentModel;

class Butterfly : Bonus, IMoveable
{
    public Butterfly()
    {
        Value = 3;
    }
    public void Move()
    {
        int randomJump = World.random.Next(0, 4);
        int dx = 0;
        int dy = 0;

        switch (randomJump)
        {
            case 0: dx = 2; dy = -2; break;
            case 1: dx = -2; dy = -2; break;
            case 2: dx = -2; dy = -2; break;
            case 3: dx = 2; dy = 2; break;
        }
        position.X += dx;
        position.Y += dy;
        if(position.X >= World.WIDTH) position.X -= World.WIDTH;
        if(position.Y >= World.HEIGHT) position.Y -= World.HEIGHT;
        if(position.X < 0) position.X = World.WIDTH-1;
        if(position.Y < 0) position.Y = World.HEIGHT-1;
    }

    public override void Show()
    {
        base.Show();
    }
}