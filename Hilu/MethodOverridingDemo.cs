using System;
//method overriding is a condition in which superclas and subclass have 
//same method with same signature (same name, same return type, same parameter)
//two keyword are used in method overriding
//1.virtual keyword: used to denote overriden method of superclass
//2.override keyword: used to denote oveeriden method of sub class
//when overriden method is called from sub class object then subclass version
//of overriden method is called so to call super class version of overriden
//method base keyword should be used
//method overriding is used to achieve dynamic polymorphism
namespace Hilu
{
     class Solve
    {
        public virtual void calc1()
        {
            Console.WriteLine("def method of superclass");
        }
        public virtual void calc2(int x,int y)
        {
            Console.WriteLine("sum is "+(x+y));
        }
    }
    class Answer : Solve
    {
        public override void calc1()
        {
            base.calc1();//calls superclass calc1()
            Console.WriteLine("def method of subclass");
           
        }
        public override void calc2(int x, int y)
        {
            base.calc2(x,y);
            Console.WriteLine("diff is " + (x - y));
        }
    }
}
