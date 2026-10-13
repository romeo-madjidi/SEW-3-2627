using System;

class Program
{
    static void Main(string[] args)
    {
        Wizard merlin = new Wizard();
        Dragon ouroboros = new Dragon();
        while (Console.ReadKey().Key != ConsoleKey.Escape)
        {
            Console.Clear();
            merlin.Move();
            ouroboros.Move();
            merlin.Show();
            ouroboros.Show();
            Console.ReadKey();
        }
    }
}