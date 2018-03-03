using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        private string empName;
        private int empID;
        private float currPay;

        public Employee()
         {}
        //Конструктор
        public Employee(string name, int id, float pay)
        {
            empName = name;
            empID = id;
            currPay = pay;
        }
        //Методы
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }
        public string GetName()
        {
            return empName;
        }
        public void SetName(string name)
        {
            if (name.Length > 15)
            {
                Console.WriteLine("Error! Non must be less than 16 characters");
            }
            else
            {
                empName = name;
            }
            
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name : {0} ", empName);
            Console.WriteLine("ID : {0} ", empID);
            Console.WriteLine("Pay : {0} ", currPay);
        }
    }
}
