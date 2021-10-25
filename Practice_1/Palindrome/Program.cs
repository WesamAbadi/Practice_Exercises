using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            char answer;
            bool more = true;
            bool isPalindrome;
            int input;
            

            while (more)
            {
                Console.WriteLine("INSERT THE NUM");
                int.TryParse(Console.ReadLine(), out input);
                isPalindrome = Claculator(input);

                if (isPalindrome)
                    Console.WriteLine("THE NUMBER IS Palindrome ");
                else
                    Console.WriteLine("THE NUMBER IS NOT Palindrome ");

                Console.WriteLine("Do you want to repeat? (Y/N)");
                answer = char.ToUpper( char.Parse ( Console.ReadLine()));
                
                if (answer != 'Y'){
                    more = false;
                }
            }
        }

        private static bool Claculator(int input)
        {
            List<int> digits = new List<int>();
            for(int i =0; i<3; i++)
            {
                digits.Add(input%10);
                input /= 10;
            }

            if (digits[0] == digits[2])
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
