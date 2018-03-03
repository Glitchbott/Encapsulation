using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectlnitializers
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Color;

        public Point(int xVal , int yVal , string color = " ")
        {
            X = xVal;
            Y = yVal;
            Color = color;
        }
        public Point() { }

        public void DisplayStats()
        {
            Console.WriteLine("{0}, {1} {2}", X, Y,Color);
        }
        

    }
}
