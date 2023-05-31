namespace Chinchiro;
internal class RollDice
{
    Random rnd = new();

    public void Roll_Dice()
    {
        int[] dice = { rnd.Next(1, 7), rnd.Next(1, 7), rnd.Next(1, 7) };
        foreach (int i in dice)
        {
            Console.Write(i);
        }

        int diceno = ChkNum(dice);

        if (diceno == 100)
        {
            Console.WriteLine($" Result is:ピンゾロ");
        }
        else if(diceno == 100)
        {
            Console.WriteLine($" Result is:ゾロ目");
        }
        else if (diceno != 0)
        {
            Console.WriteLine($" Result is:{diceno}");
        }
        else if (diceno == 0)
        {
            Console.WriteLine($" Result is:None");
        }

    }

    public static int ChkNum(int[] dice)
    {
        bool contains123 = dice.Contains(1) && dice.Contains(2) && dice.Contains(3);
        bool contains456 = dice.Contains(4) && dice.Contains(5) && dice.Contains(6);
        bool hasSameNumber = dice.Distinct().Count() == 1;

        int diceno;
        switch (dice[0])
        {
            case var a when a == dice[1] && a != dice[2]:
                diceno = dice[2];
                break;
            case var b when b == dice[2] && b != dice[1]:
                diceno = dice[1];
                break;
            case var c when c != dice[1] && dice[1] == dice[2]:
                diceno = dice[0];
                break;
            default:
                diceno = 0;
                break;
        }
        if (contains456)
        {
            diceno = 456;
        }
        else if (contains123)
        {
            diceno = 123;
        }
        else if (hasSameNumber)
        {
            diceno = 100;
        }

        return diceno;

    }

}