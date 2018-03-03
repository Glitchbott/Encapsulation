using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class MyMathClass
    {
        public static readonly double PI = 3.14;
        // поле только для чтения
        public  readonly string Word ;
        public static readonly int x = 8;

        public MyMathClass()
        {
            Word = "banan";
        }

       
    }
}
