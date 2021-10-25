using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int fNumber;
            int input;
            Console.WriteLine("WRITE THE NUMBER ");
            int.TryParse(Console.ReadLine(), out input);

            if (input > 0)
                Calculator(input);
            else
                Console.WriteLine("ERROR");

            Console.ReadKey();
        }

        private static void Calculator(int input)
        {
            int start = 0;
            int result = 0;

            for (int i = 1; i <= input; i++)
            {
                result = i + start;
                start++;
                Console.Write(result + ", ");
            }
            //Console.WriteLine(result);
        }
    }
}
