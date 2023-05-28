namespace Chinchiro;

public class Program
{
    Random rnd = new Random();

    void Roll_Dice()
    {
        var diceno = 0;
        int[] dice = {rnd.Next(1, 7), rnd.Next(1, 7), rnd.Next(1, 7)};
        foreach (int i in dice)
        {
            
            Console.Write(i);

            if (dice[0] != dice[1] && dice[0] != dice[2])
            {
                diceno = dice[0];
            }
            else if (dice[1] != dice[0] && dice[1] != dice[2])
            {
                diceno = dice[1];
            }
            else if (dice[2] != dice[0] && dice[2] != dice[1])
            {
                diceno = dice[2];
            }

        }

    }

    //メインループ
    public static void Main(string[] args)
    {
        Program chinchiro = new Program();
    
        while (true)
        {
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                chinchiro.Roll_Dice();
            }

        }

    }
}
