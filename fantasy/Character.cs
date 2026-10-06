using System;

abstract class Character : IMoveable
{
    protected int x;
    protected int y;
    private string name = "leer";

    static protected Random random = new Random();

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
}