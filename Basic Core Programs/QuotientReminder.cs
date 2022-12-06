using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class QuotientReminder
    {
        public void ComputeQuotientReminder()
        {
            Console.WriteLine("Enter Number");
            int Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor");
            int Divisor = Convert.ToInt32(Console.ReadLine());
            int Quotient = Convert.ToInt32(Num / Divisor);
            int Reminder = Num % Divisor;
            Console.WriteLine("Quotient is " + Quotient + " Reminder is " + Reminder);
        }
    }
}
