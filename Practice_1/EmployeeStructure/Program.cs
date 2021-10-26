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
            public int hoursNum, hourlyRate, wage ;
            


            public Employee(string name, int hours, int rate, int wage)
            {
                List<string> myEmployees = new List<string>();
                
                this.empName = name;
                this.hoursNum = hours;
                this.hourlyRate = rate;
                this.wage = wage;
                Claculator(hours, rate);
                Result();
                myEmployees.Add(Resultttt());
            }

            public string Resultttt()
            {
                return ($"NAME : {this.empName}\n HOURS NUMBER :{+this.hoursNum}\n HOURLY RATE : {+this.hourlyRate}\n HIS WAGE : {+Claculator(hoursNum, hourlyRate)}");
            }

            public int Claculator(int hours, int rate) => hours * rate;
            public void Result() => Console.WriteLine($"NAME : {this.empName}\n HOURS NUMBER :{+this.hoursNum}\n HOURLY RATE : {+this.hourlyRate}\n HIS WAGE : {+ Claculator(hoursNum, hourlyRate)}");

        }

        static void Main(string[] args)
        {
            //List<Employee> myEmployees = new List<Employee>();
            char answer = 'Y';
            while (answer == 'Y')
            {

            Console.WriteLine("NAME : ");
            string empName = Console.ReadLine();
            Console.WriteLine("NUMBER OF HOURS :");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("WHAT'S THE HOURLY RATE?");
            int hourRate = int.Parse(Console.ReadLine());
            int wage = 0;

            Employee EMP = new Employee(empName,hours,hourRate, wage);
              //myEmployees.Add(new Employee(empName,hours,hourRate, wage));

                Console.WriteLine("ANY MORE EMPLOYEES?");
            answer = char.ToUpper(char.Parse( Console.ReadLine()));
            }
            
            

            Console.ReadKey();
        }
        

    }
}
