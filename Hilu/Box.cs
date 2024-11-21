using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilu
{
    class Box
    {
        private int length, breadth, height;
        //property
        public int Length
        {
            set { length = value; }
            get { return length; }
        }

        public int Breadth
        {
            set { breadth = value; }
            get { return breadth; }
        }

        public int Height
        {
            set { height = value; }
            get { return height; }

        }
    }
}
