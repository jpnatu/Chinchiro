namespace Chinchiro;

public class Program
{

    public static void Main(string[] args)
    {
        RollDice rollDice = new();
        PlayerLogic playerlogic = new PlayerLogic();

        while (true)
        {
            playerlogic.PlayerMod();
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                int num = rollDice.Roll_Dice();
                //if (num == 0)
                //{
                //    Console.WriteLine("目なし");
                //}
                //else
                //{
                //    Console.WriteLine(num);
                //}
            }
        }

    }

}
