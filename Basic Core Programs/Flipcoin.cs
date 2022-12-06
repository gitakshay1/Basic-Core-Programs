using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class FlipCoin
    {
        double Percentage_of_Heads = 0, Percentage_of_Tails = 0;
        double Head_Count = 0, Tail_Count = 0;
        
        public void checkFlipCoin()
        {
            Console.WriteLine("Enter the number of times coin have to flip :");
            int numCount=Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<numCount; i++)
            {
                Random Randjob= new Random();
                int RandNum=Randjob.Next(0,2);
                if(RandNum<0.5)
                {
                    Tail_Count++;

                }
                else
                {
                    Head_Count++;
                }
            }
            Percentage_of_Tails = Tail_Count / numCount * 100;
            Percentage_of_Heads= Head_Count/ numCount * 100;
            Console.WriteLine("Percentage of tails is " + Percentage_of_Tails + "\nPercentage of Heads is " + Percentage_of_Heads);
        }

         
    }
}
