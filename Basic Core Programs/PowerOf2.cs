using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class PowerOf2
    {
        public void tableofpowrof2()
        {
            Console.WriteLine("Enter The power 0 to 30");
            int N = Convert.ToInt32(Console.ReadLine());
            if(0 <= N || N < 31)
            {
                for(int i=0; i<=N; i++)
                {
                    Console.WriteLine(Math.Pow(2, i));
                }
            }
            else
            {
                Console.WriteLine("Enter valid Power");
            }
        }
    }
}
