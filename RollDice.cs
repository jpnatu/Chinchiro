namespace Chinchiro;
internal class RollDice
{
    Random rnd = new Random();

    public void Roll_Dice()
    {
        int[] dice = { rnd.Next(1, 7), rnd.Next(1, 7), rnd.Next(1, 7) };
        foreach (int i in dice)
        {
            Console.Write(i);

            int diceno;
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

}