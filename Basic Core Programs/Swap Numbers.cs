using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class Swap_Numbers
    {
        public void SwapTwoNumbers()
        {
            Console.WriteLine("Enter Number1 :");
            int Number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number2 :");
            int Number2=Convert.ToInt32(Console.ReadLine());
            int Number3 = 0;
            Number3 = Number2;
            Number2 = Number1;
            Number1= Number3;
            Console.WriteLine("Swaped Numbers are Number1:" + Number1 + " Number2: " + Number2);
        }
    }
}
