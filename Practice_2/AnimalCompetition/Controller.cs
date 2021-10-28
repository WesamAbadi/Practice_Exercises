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
            int numberOfPart = 0, sumOfScores = 0, maxScore = 0;
            string winner="";
            char input = 'Y';

            Random rand = new Random();
            behaviourPoint = rand.Next(randomLimit + 1);
            beautyPoint = rand.Next(randomLimit + 1);

            while (Char.ToUpper(input) == 'Y')
            {
                Console.WriteLine("ANIMAL NAME: ");
                name = Console.ReadLine();

                Console.WriteLine("BIRTH YEAR: ");
                Int32.TryParse(Console.ReadLine(), out birthYear);

                myAnimal = new Animal(name, birthYear);
                myAnimal.Scoring(behaviourPoint, beautyPoint);
                Console.WriteLine(myAnimal);
                numberOfPart++;
                sumOfScores += myAnimal.ScorePoints;
                if (myAnimal.ScorePoints > maxScore)
                {
                    maxScore = myAnimal.ScorePoints;
                    winner = myAnimal.Name;
                }


                Console.WriteLine("\n ANY OTHER ANIMAL? ");
                Char.TryParse(Console.ReadLine(), out input);
            }

            Console.WriteLine($"THE NUMBER OF ANIMALS IS: {numberOfPart} \nTHE SUM OF ALL SCORES IS: {sumOfScores}\nTHE MAXIMUM SCORE WAS: {maxScore} FOR THE ANIMAL '{winner}'");

            Console.ReadKey();
        }
    }
}
