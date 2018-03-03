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

            Marvin.SetName("Marv");
            Console.WriteLine("Employee is namde {0}*", Marvin.GetName());
            Console.ReadLine();

        }
    }
}
