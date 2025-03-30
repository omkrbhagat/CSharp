using System;

namespace ExceptionHandle
{
    /*
        When an error occurs, C# will normally stop & generate
        an error message. The technical term for this is: C#
        will throw an exception (throw an error).
    */
    
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                    The try statement allows you to define a
                    block of code to be tested for errors while
                    it is being executed. This will generate an
                    error, because `myNumbers[10]` does not exist.
                */
                int[] myNumbers = {1, 2, 3};
                Console.WriteLine(myNumbers[10]);
            } catch(Exception e)
            {
                /*
                    The catch statement allows you to define a
                    block of code to be executed, if an error
                    occurs in the try block. We use the variable
                    `e` inside the catch block together with the
                    built-in `Message` property, which outputs a
                    message that describes the exception. You can
                    also output your own error message.
                */
                Console.WriteLine(e.Message);
            } finally
            {
                /*
                    The finally statement lets you execute code,
                    after try..catch, regardless of the result.
                */
                Console.WriteLine("The try..catch is finished");
            }
            
            /*
                The throw statement allows you to create a custom
                error. The throw statement is used together with
                an exception class. There are many exception
                classes available in C#.
            */
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            if(age < 20)
            {
                throw new ArithmeticException("Age must be at least 20 years old");
            } else
            {
                Console.WriteLine("Access granted");
            }
            
            /*
                `FormatException`,
                `FileNotFoundException`,
                `IndexOutOfRangeException`,
                `TimeOutException`
            */
        }
    }
}
