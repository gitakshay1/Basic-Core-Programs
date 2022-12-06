using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class Harmonic_Number
    {
        public void NthHarmonicNumber()
        {
            Console.WriteLine("Enter Number");
            int N = Convert.ToInt32(Console.ReadLine());
            float Harmonic_Value = 0;
            for (float i=1; i <= N; i++)
            {
                Harmonic_Value = Harmonic_Value + 1 / i;
            }
            Console.WriteLine(N + " th Harmonic Value is " + Harmonic_Value);
        }
    }
}
