using System;
using System.IO;

namespace InputOutput
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
                To output values or print text in C#,
                you can use the `WriteLine` method.
            */
            Console.WriteLine("Hello, World!");

            /*
                There is also a `Write` method, which
                is similar to `WriteLine`. The only
                difference is that it doesn't insert a
                new line at the end of the output.
            */
            Console.Write("I'm learning C#\n");
            Console.Write("It is Awesome\n");
            
            /*
                The `Console.ReadLine()` method returns a `string`.
                Therefore, you cannot get information from another
                data type, such as `int`. The following line will
                cause an error:
                int age = Console.ReadLine();
                Error: Cannot implicitly convert type `int` to `string`.
            */
            
            Console.Write("Enter age: ");
            // You can convert any type explicitly, by using one of the `Convert.To` methods.
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your age is " + age);
            } catch (Exception e)
            {
                // how to print on a stderr
                Console.WriteLine("Error: " + e + ", Enter correct age.");
            }
            
            /*
                Note: If you enter wrong input (e. g. text in a numerical input), you will
                get an exception/error message (like `System.FormatException`: Input string
                was not in a correct format).
            */
        }
    }
}
