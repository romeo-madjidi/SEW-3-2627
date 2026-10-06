using System;

class Dragon : Character
{
    private int flightPower;
    public int FlightPower
    {
        get { return flightPower; }
    }

        public override void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(x, y);
        Console.Write("Drache");
    }
}