using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class EvenOdd
    {
        public void CheckEvenOdd()
        {
            Console.WriteLine("Enter The Number");
            int Number=Convert.ToInt32(Console.ReadLine()); 
            if(Number%2 == 0 )
            {
                Console.WriteLine(Number + " is Even Number");
            }
            else
            {
                Console.WriteLine(Number+" is Odd Number");
            }
        }
    }
}
