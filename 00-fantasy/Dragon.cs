using System;
using System.Security.Cryptography.X509Certificates;

class Dragon : Character
{
    public int FlightPower
    {
        get;
        set;
    }

    public Dragon(string name) : base(name)
    {
        FlightPower = 3;
    }

    public override void Move()
    {
        int randomMove = World.random.Next(0, 8);
        int dx = 0;
        int dy = 0;
        int randomDirection = World.random.Next(0,2);
        if(randomDirection == 0)
        {
            while(dx == 0)
            {
                dx = World.random.Next(-2, 3);
            }
        }
        else
        {
            while(dy == 0)
            {
                dy = World.random.Next(-2, 3);
            }
        }
        if(TargetInWorld(position.X+dx, position.Y+dy))
        {
            position.X += dx;
            position.Y += dy;
        }
    }

    public override void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(position.X, position.Y);
        Console.Write(Name);
    }
}