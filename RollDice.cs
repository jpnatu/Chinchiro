namespace Chinchiro;
internal class RollDice
{
    Random rnd = new();

    public int Roll_Dice()
    {
        //乱数を振る
        int[] dice = { rnd.Next(1, 7), rnd.Next(1, 7), rnd.Next(1, 7) };
        foreach (int i in dice)
        {
            Console.Write(i);
        }
        //ChkNumで出目をチェック
        int diceno = ChkNum(dice);

        switch (diceno)
        {
            case 111:
                Console.WriteLine($" Result is:ピンゾロ");
                break;
            case 100:
                Console.WriteLine($" Result is:ゾロ目");
                break;
            case 123:
                Console.WriteLine($" Result is:ヒフミ");
                break;
            case 456:
                Console.WriteLine($" Result is:シゴロ");
                break;
            case 0:
                Console.WriteLine($" Result is:None");
                break;
            default: 
                Console.WriteLine($" Result is:{diceno}");
                break;
        }
        return diceno;
    }

    public static int ChkNum(int[] dice)
    {
        //役の判定
        bool contains123 = dice.Contains(1) && dice.Contains(2) && dice.Contains(3);
        bool contains456 = dice.Contains(4) && dice.Contains(5) && dice.Contains(6);
        bool contains111 = dice[0] == 1 && dice [1] == 1 && dice [2] == 1;
        bool hasSameNumber = dice.Distinct().Count() == 1;

        int diceno;
        //出目の判定
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
        else if (contains111)
        {
            diceno = 111;
        }
        else if (hasSameNumber)
        {
            diceno = 100;
        }
        return diceno;
    }

}