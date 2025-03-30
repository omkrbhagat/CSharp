using System;

namespace Casting
{
    public class TypeConversion
    {
        static void Main(string[] args)
        {
            /*
                Type Casting is when you assign a value of one data
                type to another type. If the data types are compatible,
                then C# does Automatic Type Conversion. If not
                comparable, then they need to be converted explicitly
                which is known as Explicit Type Conversion.
                
                Type Casting:
                • Implicit Type Conversion (Type Safe)
                • Explicit Type Conversion (Manual Conversion)
                
                The implicit type casting is done automatically when we
                try to convert small data into larger data types.
                byte -> short -> char -> int -> long -> float -> double
                
                In C#, the numeric data types are compatible with each
                other but no automatic conversion is supported from numeric
                type to `char` or `boolean`. Also, `char` & `boolean` are not
                compatible with each other.
            */
            
            int myNum = 57;
            long myLong = myNum;
            Console.WriteLine($"Int value: {myNum}");
            Console.WriteLine($"Long value: {myLong}");
            float myFloat = myLong;
            Console.WriteLine($"Float value: {myFloat}");
            
            double myDouble = 765.12;
            // Compilation error, try to convert large data type into small type.
            // int myInt = myDouble;
            
            /*
                Implicit is not the solution for such kind of problem where we want
                to convert a large data type into a small data type.
                
                Explicitly type casting is the process of converting a value of one
                data type to another data type that is not implicitly compatible.
                This is necessary when there's a potential for data loss or when the
                compiler cannot implicitly perform the conversion.
            */
            
            int num = (int) myDouble;
            Console.WriteLine($"value of num: {num}");
        }
    }
}