// The compiler defines symbols like NET6_0, ... automatically.
#if !(NET6_0 || NET7_0 || NET8_0)
    /*
        #error is a preprocessor directive that generates a
        compile-time error with a custom message.
    */
    #error This code requires .NET 8 or older
#endif

using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
