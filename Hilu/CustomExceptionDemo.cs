using System;
using System.Security.Policy;
//custom exception means generating own erro. to create own error:
//1. create error class by inheriting super class exception
//2. create constructor that will call super class constructor with
//error msg by using base keyword
//3. use throw clause to throw own error

namespace Hilu
{
    //when age is less than 16 throw error
    class AgeError : Exception
    {
        public AgeError(string msg):base(msg) { }
    }
     class CustomExceptionDemo
    {
        public void sendAge(int age)
        {
            if (age <= 16)
            {
                throw new AgeError("age should be greater than 16");
            }
            else
            {
                Console.WriteLine("welcome");
            }
        }
    }
}
