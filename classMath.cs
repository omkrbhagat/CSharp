using System;
using System.Linq;

namespace ClassMath
{
    public class Program
    {
        static void Main(string[] args)
        {
            float num1 = 25.6382f;
            float num2 = 76.48f;
            
            Console.WriteLine($"E: {Math.E}");
            Console.WriteLine($"Pi: {Math.PI}");
            Console.WriteLine($"Tau: {Math.Tau}\n");
            
            Console.WriteLine($"Absolute value of -21: {Math.Abs(-21)}");
            Console.WriteLine($"Min: {Math.Min(num1, num2)}");
            Console.WriteLine($"Max: {Math.Max(num1, num2)}\n");
            
            Console.WriteLine($"Ceil value of 25.1: {Math.Ceiling(25.1)}");
            Console.WriteLine($"Floor value of 25.1: {Math.Floor(25.1)}\n");
            
            Console.WriteLine($"Power of 5: {Math.Pow(5, 3)}");
            Console.WriteLine($"Square root of 81: {Math.Sqrt(81)}");
            Console.WriteLine($"Round off: {Math.Round(num1, 3)}");
            Console.WriteLine($"Exponent: {Math.Exp(2)}");
        }
    }
}
