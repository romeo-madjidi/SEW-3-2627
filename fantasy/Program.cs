using System;

class Program
{
    static void Main(string[] args)
    {
        while (Console.ReadKey().Key != ConsoleKey.Escape)
        {
        }
    }
}

class World
{
    public const int WIDTH = 20;
    public const int HEIGHT = 10;
}

abstract class Character
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

sealed class Wizard : Character
{
    public override void Move()
    {
        int randomMove = random.Next(0, 8);
        int dx = 0;
        int dy = 0;
        switch (randomMove)
        {
            case 0:
                dx--;
                dy--;
                break;
            case 1:
                dy--;
                break;
            case 2:
                dx++;
                dy--;
                break;
            case 3:
                dx++;
                break;
            case 4:
                dx++;
                dy++;
                break;
            case 5:
                dy++;
                break;
            case 6:
                dx--;
                dy++;
                break;
            case 7:
                dx--;
                break;
        }

        if(TargetInWorld(dx, dy))
        {
            x += dx;
            y += dy;
        }
    }
    public override void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(x, y);
        Console.Write("Merlin");
    }
}
