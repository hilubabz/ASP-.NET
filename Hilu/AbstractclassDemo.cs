using System;
//such class whose object cannot be created and declared using 
//abstract keyword. it is used to hide complex detail of class
//its object cannot be created
//it can have instance variable, method and cosntrctor
//it can have abstract method: such method which is declared only 
//but not initialize (no body part)
//normal class should inherit abstract class and such normal class
//have to provide body part of all the abtract method

namespace Hilu
{
    abstract class Question
    {
        //it can have instance variable
        private int x;
        private int y;
        //it can have constructor
        public Question(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //normal method
        public void displaySum()
        {
            Console.WriteLine("sum is " + (x + y));
        }
        //it can have abstract method
        public abstract void displayDiff(int x, int y);
        public abstract void displayMulti(int x, int y);
    }
    //abstract class should be used by normal class
    class Ans1 : Question
    {
        private int x1;
        private int y1;
        public Ans1(int x1, int y1):base(x1,y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }   
        //normal method
        public void displayDiv()
        {
            Console.WriteLine("div is "+(x1/y1));
        }
        //providing body of abstract method
        public override void displayDiff(int x, int y)
        {
            Console.WriteLine("diff is "+(x-y));
        }
        public override void displayMulti(int x, int y)
        {
            Console.WriteLine("multi is "+(x*y));
        }
    }
}
