using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class Factors
    {
        public void Prime_Factors() 
        {
            Console.WriteLine("Enter number");
            int N = Convert.ToInt32(Console.ReadLine());
            int j = N;
            Console.WriteLine("Prime Factor of Number" + N + "are:\n");
            for(int i=2; i*i<=N/2; i++)
            {
               if(j%i==0)
                {
                    Console.WriteLine(i);
                     j = j / i;
                }
               for(int k=3;k*k<=j/2; k++)
                {
                    if (j%k==0)
                    {
                        Console.WriteLine(k);
                        j= j / k;
                    }
                }
               

            }
            Console.WriteLine(j);
        }
    }
}
