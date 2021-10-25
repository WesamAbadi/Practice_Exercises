using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int end = 0;
            bool result;
            Console.WriteLine("WRITE THE START : ");
            int.TryParse(Console.ReadLine(), out start);

            Console.WriteLine("WRITE THE END : ");
            int.TryParse(Console.ReadLine(), out end);

            if (start > 0 && end > 0)
            {
                for (; start <= end; start++)
                {
                    result = PrimeNum(start);
                    // Console.WriteLine("THE resylt is " + result);
                    if (result)
                        Console.WriteLine($"{start} is Prime");
                    else
                        Console.WriteLine($"{start} is NOT Prime");
                }

            }
            Console.ReadKey();
        }

        private static bool PrimeNum(int start)
        {

            bool result = true;


            for (int j = 2; j <= Math.Sqrt(start); j++)
            {
                if (start % j == 0)
                {
                    result = false;
                    //Console.WriteLine($"{start} is not Prime");

                }
                else if (start % j != 0)
                {
                    result = true;
                    //Console.WriteLine($"{start} is Prime");
                }
            }


            return result;
        }
    }
}
