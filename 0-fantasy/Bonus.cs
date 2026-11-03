using System;

abstract class Bonus : IShowable
{
    public IntegerPosition position = new IntegerPosition();
    public int Value
    {
        get;
        set;
    }

    public Bonus()
    {
        position.X = World.random.Next(0, World.WIDTH);
        position.Y = World.random.Next(0, World.HEIGHT);
    }

    public virtual void Show(){
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(position.X, position.Y);
        Console.Write("B");
    }
}