namespace Chinchiro;

public class Program
{
    Random rnd = new Random();

    void Roll_Dice()
    {
        int[] dice = new int[] {/*rnd.Next(1, 7), rnd.Next(1, 7), rnd.Next(1, 7)*/1,2,3};
        Console.WriteLine(dice);
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
