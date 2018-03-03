using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun With Encapsulation*****\n");
            Employee Marvin = new Employee("Marvin", 256 , 30000);
            Marvin.DisplayStats();
            Marvin.Name = "Marv";
            Console.WriteLine("Employee is namde {0}*\n", Marvin.Name);

            Employee joe = new Employee("Joe",2,2,2);
            Console.WriteLine("Employee is namde {0}*", joe.Name);
            joe.DisplayStats();
            joe.Age++;
            Console.ReadLine();


        }
    }
}
