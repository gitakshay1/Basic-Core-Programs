using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class LeapYear
    {
        public void checkLeapYear()
        {
            Console.WriteLine("Enter Year :");
            int Year = Convert.ToInt32(Console.ReadLine());
            if(Year % 100 == 0 || Year % 400 == 0)
            {
                Console.WriteLine(Year + "is Leap Year");
            }
            else if(Year % 4 == 0)
            {
                Console.WriteLine(Year + "is Leap Year");
            }
            else
            {
                Console.WriteLine(Year + "is not Leap Year");
            }
        }
    }
}
