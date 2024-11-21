using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a class Rectangle having instance variable length and breadth both in double now create properties for it and calculate perimeter and area in main method
namespace Hilu
{
    internal class Rectangle
    {
        private double length, breadth;

        public double Length
        {
            set { length = value; }
            get { return length; }
        }

        public double Breadth
        {
            set { breadth = value; }
            get { return breadth; }
        }
    }
}
