using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Program> leap = new List<Program>(); 
            int input1;
            int input2;
            bool isLeap;
            Console.WriteLine("WRITE THE YEAR : ");
            int.TryParse(Console.ReadLine(), out input1);
            int.TryParse(Console.ReadLine(), out input2);
            if (input1 > 0 && input2 > 0)
            {
                Claculate(input1, input2);
                Console.ReadKey();
            }

        }

        private static void Claculate(int start, int end)
        {
            
            int  leapCount=0;

            for (; start < end; start++)
            {
                if (start % 4 == 0 && start % 100 == 0 && start %400==0)
                {
                    leapCount ++;
                    Console.WriteLine($"{start} is Leap");
                }
                if (start % 4 == 0 && start % 100 != 0)
                {
                    leapCount++;
                    Console.WriteLine($"{start} is Leap");
                }
                else
                {
                    
                   // Console.WriteLine($"{start} is NOT Leap");
                }

                

            }
            Console.WriteLine($"WE HAVE {leapCount} LEAP YEARS IN THAT INTERVAL");
        }
    }
}
