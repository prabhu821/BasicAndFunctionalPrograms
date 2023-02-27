namespace BasicAndFunctionalPrograms;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Basic and Functional Programs");
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\nEnter your choice \n1.Even or Odd \n2.Factors \n3.Flip Coin \n4.Harmonic Number \n5.Largest Number " +
                "\n6.Leap Year \n7.Power of Two \n8.Quotient And Remainder \n9.Swap Two Numbers \n10.Exit");
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
                case 4:
                    HarmonicNumber harmonic = new HarmonicNumber();
                    harmonic.Harmonic();
                    break;
                case 5:
                    LargestNumber largestNumber = new LargestNumber();
                    largestNumber.LargeNumber();
                    break;
                case 6:
                    LeapYear leapYear = new LeapYear();
                    leapYear.Year();
                    break;
                case 7:
                    PowerOfTwo power = new PowerOfTwo();
                    power.Power();
                    break;
                case 8:
                    QuotientAndRemainder quotientAndRemainder = new QuotientAndRemainder();
                    quotientAndRemainder.FindValue();
                    break;
                case 9:
                    SwapTwoNumbers swapNumber = new SwapTwoNumbers();
                    swapNumber.Swap();
                    break;
                default:
                    flag = false;
                    break;
            }
        }
    }
}