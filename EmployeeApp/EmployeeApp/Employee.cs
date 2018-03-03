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
        private int empAge;
        private string empSSN;

        //Конструкторы
        public Employee() {}
        public Employee(string name, int id , float pay)
        
            : this(name, 0, id, pay, "") { }
        
        public Employee(string name, int id, int age, float pay, string ssn)
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
            empSSN = ssn;
            
        }
        // метод
        public void GiveBones(float amount)
        {
            Pay += amount;
        }
        public string Name
        {
            get { return empName; }
            set
            { 
            if (value.Length > 15)
            
                Console.WriteLine("Error! Non must be less than 16 characters");
            
            else
            
                empName = value;
            }
            
        }
        // свойства
        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name : {0} ", empName);
            Console.WriteLine("ID : {0} ", empID);
            Console.WriteLine("Pay : {0} ", currPay);
            Console.WriteLine("Age : {0} ", empAge);
            Console.WriteLine("SSN : {0} ", empAge);
        }
    }
}
