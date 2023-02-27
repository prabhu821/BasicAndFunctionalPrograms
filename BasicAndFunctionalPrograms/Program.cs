namespace BasicAndFunctionalPrograms;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Basic and Functional Programs");
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\nEnter your choice \n1.Even or Odd \n2.Factors \n3.Flip Coin \n4.Exit");
            Console.WriteLine("Enter option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    EvenOrOdd evenorOdd = new EvenOrOdd();
                    evenorOdd.EvenOdd();
                    break;
                case 2:
                    Factors factor = new Factors();
                    factor.Factor();
                    break;
                case 3:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.Coin();
                    break;
                default:
                    flag = false;
                    break;
            }
        }
    }
}