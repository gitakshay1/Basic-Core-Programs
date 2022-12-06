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
                Console.WriteLine("1 Flip Coin \n2 Leap Year \n3 Table of Power of 2 \n4 Harmonic Number" +
                    "\n5 Prime Factors \n6 Quotient Reminder");
                int Option=Convert.ToInt32(Console.ReadLine());
                switch(Option)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.checkFlipCoin();
                        break;
                    case 2:
                        LeapYear leapYear= new LeapYear();
                        leapYear.checkLeapYear();
                        break; 
                    case 3:
                        PowerOf2 powerof2= new PowerOf2();
                        powerof2.tableofpowrof2();
                        break;
                    case 4:
                        Harmonic_Number harmonivalue= new Harmonic_Number();
                        harmonivalue.NthHarmonicNumber();
                        break; 
                    case 5:
                        Factors factors= new Factors();
                        factors.Prime_Factors();
                        break;
                    case 6:
                        QuotientReminder quotientReminder= new QuotientReminder();
                        quotientReminder.ComputeQuotientReminder();
                        break;
                    default:
                        Console.WriteLine("Enter Valid Number");
                        break;
                }
            }
        }
    }
}
