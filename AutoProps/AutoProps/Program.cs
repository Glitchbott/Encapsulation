using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun With Automatic  Properties****\n");

            Car Car = new Car();
            Car.petName = "Frank";
            Car.Speed = 55;
            Car.Color = "Blue";
            Console.WriteLine("Your car is named {0}? That s odd...", Car.petName);
            Car.DisplayStats();
            Console.ReadLine();
        }
    }
}
