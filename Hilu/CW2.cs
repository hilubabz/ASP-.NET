using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a class Vehicle having instance variable reg(int), name(string), brand(string), and two method to set and return
//value of instance variable, Create another calss Car that inherits Vehicle having instance variable milaege and methods
//to set and return the value of instance variable. Now create any two object of Car and display deatail of car that have 
//greater milage
namespace Hilu
{
    class Vehicle
    {
        private int reg;
        private string name;
        private string brand;

        public void setVehicle(int reg, string name, string brand)
        {
            this.reg = reg; 
            this.name = name;
            this.brand = brand;
        }

        public void displayVehicle()
        {
            Console.WriteLine("Reg is "+reg+" name is "+name+" brand is "+brand);
        }
    }

    class Car : Vehicle
    {
        private int milaege;

        public void setCar(int milaege)
        {
           this.milaege = milaege;
        }
        public int Milaege
        {
            get { return milaege; }
        }
        public void displayCar()
        {
            Console.WriteLine("milaege is " + milaege);
        }
    }
}
