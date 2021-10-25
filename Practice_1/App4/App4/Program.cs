using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class Program
    {//
        static void Main(string[] args)
        {
            Console.WriteLine("What's your grade ? ");
            int input = int.Parse(Console.ReadLine());
            int grade = 0;


            ranger(input, grade);
            Console.ReadKey();

        }

        private static void ranger(int input, int grade)
        {
            switch (input)
            {
                case int n when n > 0 && n <= 50:
                    grade = 1;
                    break;

                case int n when n > 51 && n <= 65:
                    grade = 2;
                    break;

                case int n when n > 66 && n <= 75:
                    grade = 3;
                    break;

                case int n when n > 76 && n <= 85:
                    grade = 4;
                    break;

                case int n when n > 86 && n <= 100:
                    grade = 5;
                    break;
            }
            Console.WriteLine($"THE GRADE IS {grade}!");
        }

    }
}

