using System;
/*
    Data Types in C# is mainly divided into 3 categories:
    • Value Data Types
    • Reference Data Types
    • Pointer Data Types
*/

namespace DataTypes
{
    /*
        • An `enum` is a special data type used for defining named constant values.
        • In C#, you cannot define an enum directly inside a method (like `Main`).
        • An enum is a type, and types must be declared at the namespace or class
        level.
        • Methods in C# can only contain executable code (statements, expressions,
        etc), not type declarations (like enum, class, struct, etc). Types must
        be declared at higher scope (class or namespace level).
        If defined at namespace level: `DataTypes.Days`.
        If defined at class level: `DataTypes.Program+Days`.
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
    
    public class Program
    {
        static void Main(string[] args)
        {

            /*
                Value Data Types:
                Value Data Types will directly store the variable value in memory &
                it'll also accept both signed & unsigned literals. The derived class
                for these data types are `System.ValueType`.
                
                We have mainly 2 types of value data types in C#:
                • Predefined Data Types: Char, Integer, Float, Double, Boolean, etc.
                • User-defined Data Types: such as Enumerations, Structure, etc.
            */

            /*
                Signed & Unsigned Integral Types:
                There are 8 integral types which provide support for 8-bit, 16-bit,
                32-bit, 64-bit values in signed or unsigned form.
            */

            byte myByte = 255;
            Console.WriteLine($"TypeOf {myByte}: {myByte.GetType()}");
            Console.WriteLine($"Size: {sizeof(byte)}");
            Console.WriteLine($"Range: {byte.MinValue} to {byte.MaxValue}\n");

            sbyte mySByte = 127;
            Console.WriteLine($"TypeOf {mySByte}: {mySByte.GetType()}");
            Console.WriteLine($"Size: {sizeof(sbyte)}");
            Console.WriteLine($"Range: {sbyte.MinValue} to {sbyte.MaxValue}\n");

            short myShort = 32767;
            Console.WriteLine($"TypeOf {myShort}: {myShort.GetType()}");
            Console.WriteLine($"Size: {sizeof(short)}");
            Console.WriteLine($"Range: {short.MinValue} to {short.MaxValue}\n");
            

            ushort myUShort = 65535;
            Console.WriteLine($"TypeOf {myUShort}: {myUShort.GetType()}");
            Console.WriteLine($"Size: {sizeof(ushort)}");
            Console.WriteLine($"Range: {ushort.MinValue} to {ushort.MaxValue}\n");

            int myInt = 2147483647; // 2 billion
            Console.WriteLine($"TypeOf {myInt}: {myInt.GetType()}");
            Console.WriteLine($"Size: {sizeof(int)}");
            Console.WriteLine($"Range: {int.MinValue} to {int.MaxValue}\n");

            uint myUInt = 4000000000;
            Console.WriteLine($"TypeOf {myUInt}: {myUInt.GetType()}");
            Console.WriteLine($"Size: {sizeof(uint)}");
            Console.WriteLine($"Range: {uint.MinValue} to {uint.MaxValue}\n");

            long myLong = 1000000L;
            Console.WriteLine($"TypeOf {myLong}: {myLong.GetType()}");
            Console.WriteLine($"Size: {sizeof(long)}");
            Console.WriteLine($"Range: {long.MinValue} to {long.MaxValue}\n");

            ulong myULong = 3624573;
            Console.WriteLine($"TypeOf {myULong}: {myULong.GetType()}");
            Console.WriteLine($"Size: {sizeof(ulong)}");
            Console.WriteLine($"Range: {ulong.MinValue} to {ulong.MaxValue}\n");

            /*
                32-bit single-precision floating point type.
                It has 7 digit precision. To initialize a `float` variable,
                use the suffix `f` or `F`. If the suffix will not use then
                it is treated as `double`.
            */
            float myFloatNum = 3.56f;
            Console.WriteLine($"TypeOf {myFloatNum}: {myFloatNum.GetType()}");
            Console.WriteLine($"Size: {sizeof(float)}");
            Console.WriteLine($"Range: {float.MinValue} to {float.MaxValue}\n");

            /*
                64-bit double-precision floating point type.
                It has 15-16 digit precision. To initialize a `double` variable,
                use the suffix `d` or `D`. But it is not mandatory to use suffix
                because by default floating data types are the double type.
            */
            double myDoubleNum = 5.99;
            Console.WriteLine($"TypeOf {myDoubleNum}: {myDoubleNum.GetType()}");
            Console.WriteLine($"Size: {sizeof(double)}");
            Console.WriteLine($"Range: {double.MinValue} to {double.MaxValue}\n");

            /*
                The `decimal` type is a 128-bit data type suitable for financial &
                monetary calculations. It has 28-29 digit precision. To initialize
                a `decimal` variable used the suffix `m` or `M`.
            */
            decimal myDec = 300.5m;
            Console.WriteLine($"TypeOf {myDec}: {myDec.GetType()}");
            Console.WriteLine($"Size: {sizeof(decimal)}");
            Console.WriteLine($"Range: {decimal.MinValue} to {decimal.MaxValue}\n");

            /*
                A floating point number can also be a scientific number
                with an `e` to indicate power of 10.
            */
            float sciFloat = 35e3F;
            Console.WriteLine($"Scientific notation for 35e3F single precision value: {sciFloat}");

            double sciDouble = 25e5D;
            Console.WriteLine($"Scientific notation for 25e5D double precision value: {sciDouble}\n");

            /*
                Character Types:
                The character types represents a UTF-16 code unit or represents
                the 16-bit Unicode character.
            */
            char myChar = 'A';
            Console.WriteLine($"TypeOf {myChar}: {myChar.GetType()}");
            Console.WriteLine($"Size: {sizeof(char)}");
            Console.WriteLine($"Range: {(int)char.MinValue} to {(int)char.MaxValue}\n");

            /*
                Boolean Types:
                It has to be assigned either true or false value. Values of type bool
                are not converted implicitly or explicitly (with casts) to any other type.
            */
            bool myBool = true;
            Console.WriteLine($"TypeOf myBool: {myBool.GetType()}");
            Console.WriteLine($"Size: {sizeof(bool)}\n");

            /*
                You can add the `const` keyword in front of the variable type.
                Note: you can't declare a constant variable without assigning the value.
            */
            const float Pi = 3.14F;
            
            Days myEnum = Days.Wednesday;
            Console.WriteLine($"TypeOf myEnum: {myEnum.GetType()}");
            Console.WriteLine($"Value: {(int)myEnum}\n");
        }
    }
}
