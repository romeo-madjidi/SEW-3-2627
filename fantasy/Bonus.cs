using System;

abstract class Bonus : IShowable
{
    public IntegerPosition position = new IntegerPosition();
    private int value;
    public int Value
    {
        get { return value; }
        set { value = value; }
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