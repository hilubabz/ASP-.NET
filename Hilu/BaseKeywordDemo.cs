using System;
//constructor of superclass (parent) cannot be called from 
//subclass's object. so to call superclass constructor "base" 
//keyword is used
//uses of base keyword:
//1. to call superclass constructor
//2. method overriding

namespace Hilu
{
     class Calculation
    {
        private int x1;
        private int y1;
        //default constructor of parent
        public Calculation()
        {
            Console.WriteLine("default cons of super class");
        }
        //parameterized constructor
        public Calculation(int x1,int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }
        public void calcSum()
        {
            Console.WriteLine("sum is "+(x1+y1));
        }
    }
    //child class
    class Solution : Calculation
    {
        private int x2;
        private int y2;
        //default constructor of child class
        public Solution()
        {
            Console.WriteLine("default const of sub class");
        }
        public Solution(int x2, int y2,int x1,int y1):base(x1,y1)
        {
            this.x2 = x2;
            this.y2 = y2;
        }
        public void calcDiff()
        {
            Console.WriteLine("diff is "+(x2-y2));
        }
    }
}
