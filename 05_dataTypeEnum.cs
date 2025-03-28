using System;
using System.Linq;

namespace DataTypeEnum
{
    /*
        • An `enum` is a special "class" that represents a group of constants
        (unchangeable/read-only variables). `enum` is a short for "enumerations",
        which means "specifically listed".
        • To create an `enum`, use the `enum` keyword (instead of `class` or `interface`)
        & seperate the enum items with a comma.
        • By default, the first item of an enum has the value 0. The second has the
        value 1, and so on.
        • You can also assign your own enum values, and the next items will update their
        numbers accordingly.
        
        Note:
        • You cannot define an enum directly inside a method (like `Main`).
        An enum is a type, and types must be declared at the namespace or class
        level.
        • When you define a type inside another type, like a class, it becomes nested type.
        So if Days is inside the Program, it's nested. The '+' symbol is used in the fully
        qualified name to denote a nested type.
        • But when the enum is defined in thr top-level namespace, it's not nested inside
        any other type, so its full name is just the namespace plus the type name.
        If you define a type in the top-level namespace without explicitly specifying a
        namspace, it goes into the global namespace.
        
    */
    enum Level
    {
        Low=100,
        Medium=200,
        High // 201
    }
    
    public class DataTypeEnum
    {
        static void Main(string[] args)
        {
            /*
                To get the integer value from an item, you must
                explicitly convert the item to an `int`.
            */
            DayOfWeek day = DayOfWeek.Saturday;
            Console.WriteLine($"{day.GetType()}: {(int)day}");
            
            // You can access enum items with the dot syntax:
            Level myStatus = Level.High;
            
            // enums are often used in switch statements to check for corresponding values
            switch(myStatus)
            {
                case Level.Low:
                    Console.WriteLine($"Low Level: {(int)Level.Low}");
                    Console.WriteLine($"Type: {myStatus.GetType()}");
                    break;
                case Level.Medium:
                    Console.WriteLine($"Medium Level: {(int)Level.Medium}");
                    Console.WriteLine($"Type: {myStatus.GetType()}");
                    break;
                case Level.High:
                    Console.WriteLine($"High Level: {(int)Level.High}");
                    Console.WriteLine($"Type: {myStatus.GetType()}");
                    break;
            }
        }
    }
}

/*
    Why & when to use enums?
    Use enums when you have values that you know aren't
    going to change, like month days, days, color, deck of cards, etc.
*/