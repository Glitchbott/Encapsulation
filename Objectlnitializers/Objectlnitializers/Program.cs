using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectlnitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            
            firstPoint.DisplayStats();

            Point anotherPoint = new Point(20,20,"red");
            anotherPoint.DisplayStats();

            Point finalPoint = new Point();
            finalPoint.DisplayStats();
            Console.ReadLine();
        }
    }
}
