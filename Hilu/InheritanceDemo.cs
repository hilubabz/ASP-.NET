using System;
//inheritance is as process of inheriting properties of one class
//by another class. such class that inherits another class is sub class
//(derive) and such class that gets inherited by other is super class
//(parent, base). sub class can use all the properties of super class except
//private variable and constructor. 
//1. single level: one parent class is inherited by one or more child class
//2. multi level: second class inherit first class and such second class
//inturns gets inherited by third class. (grandparent-parent-child relation)4
//3. multiple: here one child can inherit multiple parent class which is not
//possible using class but possible using interface
namespace Hilu
{
    //parent class (super or base)
     class Person
    {
        private int age;
        private string name;
        private string address;
        //method to set instance varible
        public void setPerson(int age,string name, string address)
        {
            this.age = age;
            this.name = name;
            this.address = address;
        }
        public void displayPerson()
        {
            Console.WriteLine("age is "+age+" name is "+name+" address is "+
                address);
        }
    }
    //child class: (derive or sub)
    //to inherit a class colon ":" symbol is used
    class Student : Person
    {
        private string faculty;
        private string grade;

        //method
        public void setStd(string faculty, string grade)
        {
            this.faculty = faculty;
            this.grade = grade;
        }
        public void displayStudent()
        {
            Console.WriteLine("faculty is "+faculty+" grade is "+grade);
        }
    }
    //multilevel inheritance
    class PrimaryStudent : Student
    {
        private int sleepTime;
        //method
        public void setPrimary(int sleepTime)
        {
            this.sleepTime = sleepTime;
        }

        
        public void displayPrimary()
        {
            Console.WriteLine("sleep time is "+sleepTime);
        }
    }
}
