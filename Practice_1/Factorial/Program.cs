using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Write the Num");
            int input = Int32.Parse(Console.ReadLine());
            int result = 1;

            if (input < 0)
                Console.WriteLine("NEM JO");

            else if (input == 0)
                Console.WriteLine($"FACTORIAL IS {result} ");

            else
            {
                Console.WriteLine("Write the N ");
                int n = Int32.Parse(Console.ReadLine());

                result = calculate(input, n);
                Console.WriteLine($"FACTORIAL IS {result} ");
            }

            Console.ReadKey();
        }


        private static int calculate(int input, int n)
        {
            int result = 1;
            for (int i = input; i > input - n; i--)
            {
                result *= i;

            }

            return result;
        }

        //make a list that stores inputs, calculate the Fa. of these.
    }
}
    
