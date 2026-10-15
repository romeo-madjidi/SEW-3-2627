using System;

abstract class Character : IMoveable
{
    public IntegerPosition position = new IntegerPosition();

    public string Name
    {
        get;
        set;
    }

    public abstract void Move();

    public abstract void Show();

    public bool TargetInWorld(int x, int y)
    {
        if(x >= 0 && x < World.WIDTH && y >= 0 && y < World.HEIGHT)
        {
            return true;
        }
        return false;
    }

    public Character(string name)
    {
        Name = name;
    }
}