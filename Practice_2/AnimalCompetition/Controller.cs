using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCompetition
{
    class Controller
    {
        internal static void Strat()
        {

            Animal.currentYear = 2021;
            Animal.ageLimit = 10;
            Event();
        }

        private static void Event()
        {
            Animal myAnimal;
            string name;
            int birthYear, behaviourPoint, beautyPoint;
            int randomLimit = 10;


            Random rand = new Random();

            behaviourPoint = rand.Next(randomLimit + 1);
            beautyPoint = rand.Next(randomLimit + 1);


            Console.WriteLine("NAME: ");
            name = Console.ReadLine();

            Console.WriteLine("BIRTH YEAR: ");
            Int32.TryParse(Console.ReadLine(), out birthYear);

            myAnimal = new Animal(name, birthYear);
            myAnimal.Scoring(behaviourPoint, beautyPoint);
            Console.WriteLine(myAnimal);

            Console.ReadKey();
        }
    }
}
