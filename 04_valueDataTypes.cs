using System;
/*
    Data Types in C# is mainly divided into 3 categories:
    • Value Data Types
    • Reference Data Types
    • Pointer Data Types
*/
namespace DataTypes
{
    public class Program
    {

        /*
            An `enum` is a special data type used for defining named constant values.
            In C#, you cannot define an enum directly inside a method (like `Main`).
            An enum is a type, and types must be declared at the namespace or class
            level.
            Methods in C# can only contain executable code (statements, expressions,
            etc), not type declarations (like enum, class, struct, etc). Types must
            be declared at higher scope (class or namespace level).
        */
        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {

            /*
                Value Data Types:
                Value Data Types will directly store the variable value in memory &
                it'll also accept both signed & unsigned literals. The derived class
                for these data types are `System.ValueType`.
                
                We have mainly 2 types of value data types in C#:
                • Predefined Data Types: Char, Integer, Float, Boolean, etc.
                • User-defined Data Types: such as Enumerations, Structure, etc.
            */

            /*
                Signed & Unsigned Integral Types:
                There are 8 integral types which provide support for 8-bit, 16-bit,
                32-bit, 64-bit values in signed or unsigned form.
            */

            byte myByte = 255;
            Console.WriteLine($"{myByte.GetType()}: {myByte}");
            Console.WriteLine($"Size: {byte.MinValue} to {byte.MaxValue}\n");

            sbyte mySByte = 127;
            Console.WriteLine($"{mySByte.GetType()}: {mySByte}");
            Console.WriteLine($"Size: {sbyte.MinValue} to {sbyte.MaxValue}\n");

            short myShort = 32767;
            Console.WriteLine($"{myShort.GetType()}: {myShort}");
            Console.WriteLine($"Size: {short.MinValue} to {short.MaxValue}\n");
            

            ushort myUShort = 65535;
            Console.WriteLine($"{myUShort.GetType()}: {myUShort}");
            Console.WriteLine($"Size: {ushort.MinValue} to {ushort.MaxValue}\n");

            int myInt = 2147483647; // 2 billion
            Console.WriteLine($"{myInt.GetType()}: {myInt}");
            Console.WriteLine($"Size: {int.MinValue} to {int.MaxValue}\n");

            uint myUInt = 4000000000;
            Console.WriteLine($"{myUInt.GetType()}: {myUInt}");
            Console.WriteLine($"Size: {uint.MinValue} to {uint.MaxValue}\n");

            long myLong = 1000000L;
            Console.WriteLine($"{myLong.GetType()}: {myLong}");
            Console.WriteLine($"Size: {long.MinValue} to {long.MaxValue}\n");

            ulong myULong = 3624573;
            Console.WriteLine($"{myULong.GetType()}: {myULong}");
            Console.WriteLine($"Size: {ulong.MinValue} to {ulong.MaxValue}\n");

            /*
                32-bit single-precision floating point type.
                It has 7 digit precision. To initialize a `float` variable,
                use the suffix `f` or `F`. If the suffix will not use then
                it is treated as `double`.
            */
            float myFloatNum = 3.56f;
            Console.WriteLine($"{myFloatNum.GetType()}: {myFloatNum}");
            Console.WriteLine($"Size: {float.MinValue} to {float.MaxValue}\n");

            /*
                64-bit double-precision floating point type.
                It has 15-16 digit precision. To initialize a `double` variable,
                use the suffix `d` or `D`. But it is not mandatory to use suffix
                because by default floating data types are the double type.
            */
            double myDoubleNum = 5.99;
            Console.WriteLine($"{myDoubleNum.GetType()}: {myDoubleNum}");
            Console.WriteLine($"Size: {double.MinValue} to {double.MaxValue}\n");

            /*
                The `decimal` type is a 128-bit data type suitable for financial &
                monetary calculations. It has 28-29 digit precision. To initialize
                a `decimal` variable used the suffix `m` or `M`.
            */
            decimal myDec = 300.5m;
            Console.WriteLine($"{myDec.GetType()}: {myDec}");
            Console.WriteLine($"Size: {decimal.MinValue} to {decimal.MaxValue}\n");

            /*
                A floating point number can also be a scientific number
                with an `e` to indicate power of 10.
            */
            float sciFloat = 35e3F;
            Console.WriteLine($"{sciFloat.GetType()}: {sciFloat}");

            double sciDouble = 25e5D;
            Console.WriteLine($"{sciDouble.GetType()}: {sciDouble}");

            /*
                Character Types:
                The character types represents a UTF-16 code unit or represents
                the 16-bit Unicode character.
            */
            char myChar = 'A';
            Console.WriteLine($"{myChar.GetType()}: {myChar}");

            /*
                Boolean Types:
                It has to be assigned either true or false value. Values of type bool
                are not converted implicitly or explicitly (with casts) to any other type.
            */
            bool myBool = true;
            Console.WriteLine($"{myBool.GetType()}: {myBool}");

            // You can add the `const` keyword in front of the variable type.
            const float Pi = 3.14F;
            Console.WriteLine($"{Pi.GetType()}: {Pi}");
            // Note: you can't declare a constant variable without assigning the value.
            
            Days myEnum = Days.Wednesday;
            Console.WriteLine($"{myEnum.GetType()}: {(int)myEnum}\n");
        }
    }
}
