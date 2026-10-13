using System;

sealed class Wizard : Character
{
    private int magicPower = 0;
    public int MagicPower
    {
        get { return magicPower; }
    }
    public override void Move()
    {
        int randomMove = World.random.Next(0, 8);
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

        if(TargetInWorld(position.X+dx, position.Y+dy))
        {
            position.X += dx;
            position.Y += dy;
        }
    }
    public override void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(position.X, position.Y);
        Console.Write("Merlin");
    }
}
