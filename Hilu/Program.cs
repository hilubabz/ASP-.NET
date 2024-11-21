using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hilu
{
    class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box();
            //setting and getting values aaba
            b1.Length = 20;//call set
            int len1 = b1.Length;//call get
            b1.Breadth = 15;
            int len2 = b1.Breadth;
            b1.Height = 14;
            int len3 = b1.Height;

            int vol = len1 * len2 * len3;
            Console.WriteLine("The volume is " + vol);
            //Console.ReadKey();//getch()
            Rectangle r1 = new Rectangle();
            r1.Length = 14;
            double l = r1.Length;
            r1.Breadth = 15;
            double b = r1.Breadth;
            Console.WriteLine("The area is " + (l * b) + " and the perimeter is " + (2 * (l + b)));


            Console.WriteLine("--example on inheritance--");
            //create object of child class
            Student st1 = new Student();
            //accessing parent (person) property
            st1.setPerson(13, "ram", "ktm");
            st1.displayPerson();
            //accessing own property
            st1.setStd("science", "A+");
            st1.displayStudent();
            //multilevel
            PrimaryStudent ps1 = new PrimaryStudent();
            //accessing grand parent (Person) property
            ps1.setPerson(5, "hari", "pkr");
            ps1.displayPerson();
            //accessing parent (Student) property
            ps1.setStd("kindergarden", "A+");
            ps1.displayStudent();
            //accesing own property
            ps1.setPrimary(5);
            ps1.displayPrimary();

            //cw2
            Car c1 = new Car();
            c1.setVehicle(101, "Waiwai", "Mercedes");
            c1.setCar(20);
            Car c2 = new Car();
            c2.setVehicle(102, "Manish", "Alto");
            c2.setCar(30);
            if (c1.Milaege > c2.Milaege)
            {
                c1.displayVehicle();
                c1.displayCar();
            }
            else
            {
                c2.displayVehicle();
                c2.displayCar();
            }


            Console.WriteLine("--eg on base keyword--");
            Solution sol1 = new Solution();
            Solution sol2 = new Solution(10, 5, 20, 30);
            sol2.calcSum();//parent method
            sol2.calcDiff();//solution method


            MthOvl a = new MthOvl();
            a.addTwo(10, 20);
            a.addThree(10, 20, 30);

            Console.WriteLine("method overriding");
            Answer a1 = new Answer();
            a1.calc1();
            a1.calc2(20, 30);
            Console.WriteLine("abstract class example");
            Ans1 an1 = new Ans1(40, 50);
            an1.displaySum();//normal method of abstract claass
            an1.displayDiv();//own method
            an1.displayDiff(50, 40);//abstract method 1
            an1.displayMulti(10, 5);//abstract method2

            //Console.WriteLine("--example on exception handling---");
            //ExceptionHandlingDemo ex1 = new ExceptionHandlingDemo();
            //ex1.setData();

            //Console.WriteLine("--custom exception example--");
            //CustomExceptionDemo ce1 = new CustomExceptionDemo();

            //ce1.sendAge(11);

            //Console.Write("check");


            Number n1 = new Number(1, 10, 9);
            n1.getMax();
            n1.getPrime();




        }
    }
}
