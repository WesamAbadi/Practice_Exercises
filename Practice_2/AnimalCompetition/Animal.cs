using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCompetition
{
    class Animal
    {
        private string name;
        private int birthYear, behaviourPoint, beautyPoint, scorePoints;

        public static int currentYear, ageLimit;
        public Animal(string myName, int myBirthYear)
        {
            this.name = myName;
            this.birthYear = myBirthYear;
        }

        public override string ToString()
        {
            return $"The animal {name} who was born in {birthYear} has a score of {scorePoints}";
        }

        internal void Scoring(int behave, int beauty)
        {
            this.behaviourPoint = behave;
            this.beautyPoint = beauty;

            if (Age() < ageLimit)
                scorePoints = Age() * behave + ((ageLimit - Age() * beauty));
            else
                scorePoints = 0;

        }
        private int Age()
        {
            return currentYear - birthYear;
        }



        public string Name { get { return name; } }
        public int ScorePoints { get { return scorePoints; } }
        public int CurrentYear { get { return currentYear;} set {currentYear=value ;} }

    }
}
