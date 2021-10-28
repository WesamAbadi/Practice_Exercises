using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeStructure
{
    class Program
    {
        struct Employee
        {

            public string empName;
            public int hoursNum, hourlyRate;
            private static int wage;



            public Employee(string name, int hours, int rate)
            {
                List<string> myEmployees = new List<string>();

                this.empName = name;
                this.hoursNum = hours;
                this.hourlyRate = rate;

                Claculator(hours, rate);

                myEmployees.Add(Resultttt());
            }

            public string Resultttt()
            {
                return ($"NAME : {this.empName}\n HOURS NUMBER :{+this.hoursNum}\n HOURLY RATE : {+this.hourlyRate}\n HIS WAGE : {+Claculator(hoursNum, hourlyRate)}");
            }

            public int Claculator(int hours, int rate) => hours * rate;
            public override string ToString() => ($"NAME : {this.empName}\n HOURS NUMBER :{+this.hoursNum}\n HOURLY RATE : {+this.hourlyRate}\n HIS WAGE : {+Claculator(hoursNum, hourlyRate)}");



            public static int Wage
            {
                get { return wage; }
                set { wage = value; }
            }
        }

        static void Main(string[] args)
        {

            List<Employee> myEmployees = new List<Employee>();
            char answer = 'Y';
            int numOf = 0;
            while (answer == 'Y')
            {

                Console.WriteLine("NAME : ");
                string empName = Console.ReadLine();
                Console.WriteLine("NUMBER OF HOURS :");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("WHAT'S THE HOURLY RATE?");
                int hourRate = int.Parse(Console.ReadLine());
                int wage = 1;
                Employee.Wage = wage;

                
                myEmployees.Add(new Employee(empName, hours, hourRate));

                Console.WriteLine("ANY MORE EMPLOYEES?");
                answer = char.ToUpper(char.Parse(Console.ReadLine()));
                numOf++;
            }

            for (int i = 0; i < numOf; i++)
            {
               // Console.WriteLine(myEmployees[i]); it's better to do this insted but that's the excersise

                Console.WriteLine(myEmployees[i].Resultttt());
            }



            Console.ReadKey();
        }


    }
}
