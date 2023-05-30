namespace Chinchiro;

public class Program
{

    public static void Main(string[] args)
    {
        RollDice rollDice = new RollDice();
    
        while (true)
        {
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                rollDice.Roll_Dice();
            }
        }

    }

}
