using System;
//exception is any abnormal condition that disturb normal flow of program
//when exception occur then program will directly stop so to handle such 
//exception, exception handling is used
//keyword used in exception handling:
//1. try: used to surround a code from which exception can be generated
//2. catch: used to handle error generated from try block
//3. throw: used to throw own exception (custom exception) from any line of code
//4. finally: always executed block whether exception occur or not

namespace Hilu
{
     class ExceptionHandlingDemo
    {
        //taking input from user and dividing it by 0 for try catch
        public void setData()
        {
            Console.WriteLine("enter first number");
           int x1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int y1 = Int32.Parse(Console.ReadLine());
            try
            {
                int res = x1 / y1;//if y1=0 then error occur
                Console.WriteLine("div is " + res);
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine("denominator shouldnot be 0 " + d);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR OCCUR "+e);
            }
            finally
            {
                Console.WriteLine("always executed");
            }
            Console.WriteLine("out of try catch block");
        }
    }
}
