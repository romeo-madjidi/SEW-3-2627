using System;

class Program
{
    static void Main(string[] args)
    {
        Wizard merlin = new Wizard("Merlin");
        Dragon ouroboros = new Dragon("Ouroboros");
        Butterfly zitronenfalter = new Butterfly();
        do
        {
            Console.Clear();
            merlin.Move();
            ouroboros.Move();
            zitronenfalter.Move();
            merlin.Show();
            ouroboros.Show();
            zitronenfalter.Show();
        }while(Console.ReadKey().Key != ConsoleKey.Escape);
    }
}