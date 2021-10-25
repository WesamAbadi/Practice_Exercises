using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("INSERT A NUMBER BRO");
            int input = int.Parse(Console.ReadLine());




            By2(input);
            By5(input);
            Console.ReadKey();



        }

        private static void By5(int x)
        {
            if (x % 5 == 0)
            {
                Console.Write("And is divisible by 5");
            }
            else
            {
                Console.Write("And is not divisible by 5");
            }
        }

        private static void By2(int y)
        {
            if (y % 2 == 0)
            {
                Console.Write("The number is Even ");
            }
            else
            {
                Console.Write("The number is ODD ");

            }

        }
    }

}
