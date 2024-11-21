using System;
using System.Runtime.InteropServices;
//create a class number with three integer instance variable x, y and z. the class wll have one constructor to initialize
//instance variable and method getMax() that returns largest number among three getPrime() method that prints prime number from
//x to y. now create an object of number class and demonstrate the above scenario


namespace Hilu
{
    internal class Number
    {
        private int x, y, z;

        public Number(int x, int y, int z)
        {
            this.x = x; this.y = y; this.z = z;
        }
    public void getMax()
        {
            if(x>y && x>z)
                Console.WriteLine(x+" is the greatest number");
            else if(y>x && y > z)
            {
                Console.WriteLine(y+" is the greatest number");
            }
            else
                Console.WriteLine(z+" is the greatest number");
        }

    public void getPrime()
        {
            int num = x;
            if (x > y)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            else
            {
                while (num <= y)
                {
                    int count = 0;
                    if (num == 1)
                    {
                        count = 1;
                    }
                    for(int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                            count = 1;
                    }
                    if (count != 1)
                    {
                        Console.WriteLine(num);
                    }
                    num++;
                }
            }
        }
    }
}
