using System;
namespace Basic_Core_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool Flag=true;
            while(Flag)
            {
                Console.WriteLine("1 Flip Coin");
                int Option=Convert.ToInt32(Console.ReadLine());
                switch(Option)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.checkFlipCoin();
                        break;
                    default:
                        Console.WriteLine("Enter Valid Number");
                        break;
                }
            }
        }
    }
}
