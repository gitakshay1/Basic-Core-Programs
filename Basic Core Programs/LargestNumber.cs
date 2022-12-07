using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class LargestNumber
    {
        public void NumberCoparison()
        {
            Console.WriteLine("Enter First Number :");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            int Number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number :");
            int Number3 = Convert.ToInt32(Console.ReadLine());
            if (Number1 > Number2 || Number1 > Number3)
            {
                Console.WriteLine(Number1 + " is Largest Number");
            }
            else if (Number2 > Number1 || Number2 > Number3)
            {
                Console.WriteLine(Number2 + " is Largest Number");
            }
            else
            {
                Console.WriteLine(Number3 + " is Largest Number");
            }
        }
    }
}
