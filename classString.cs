using System;
using System.Linq;

/*
    • In C#, strings are sequences of characters used to store & manipulate text data.
    • A `string` in C#, is actually an object, which contain properties & methods that can
    perform certain operations on strings.
    • Strings are immutable, meaning once created, their content cannot be changed.
    • Accessing individual characters or substrings in C# is straightforward with indexing
    & the `Substring()` method.
    • C# also provides built-in support for regular expressions to perform complex text
    pattern matching & manipulation.
    • Strings allow sequential access to individual characters, making it possible to iterate
    over each character in a `string`.
    • Strings have a property called `Length` that returns the number of characters in the string.
*/

namespace ClassString
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
                • In C#, the terms `string` & `System.String` are often used interchangeably
                to refer to the same data type. It's primarily a matter of personal
                preference & coding style.
                • There are various ways to create a `string`:
            */
            
            // i) From Literal: Simplest way to create a `string`.
            string fullName = "Omkar Haribhau Bhagat";
            Console.WriteLine("Type: {0}\nBaseType: {1}",fullName.GetType(), fullName.GetType().BaseType);
            Console.WriteLine("Upper: {0}",fullName.ToUpper());
            
            // ii) Using Concatenation: Combine multiple strings usign concatenation operator (+).
            // allows you to combine different strings or variables to dynamically build a string
            // that meets you specific requirements.
            string firstName = "John", lastName = "Doe";
            string concatStr = firstName + " " + lastName;
            Console.WriteLine("Concated: {0}", concatStr);
            
            // iii) Using a Constructor: Create a string using the `String` class constructor. The
            // constructor takes a character array or another string as a parameter.
            char[] charArr = {'H', 'e', 'l', 'l', 'o'};
            string constructedStr = new string(charArr);
            Console.WriteLine("Constructed: {0}", constructedStr);
            
            // iv) Using a Property or a Method: C# provides various properties & methods to create
            // strings dynamically. e.g. `String.Join()` method to concatenate an array of string
            // into a single string.
            string[] words = {"Hello", "World"};
            string joinedStr = String.Join(" ", words);
            Console.WriteLine("Joined: {0}", joinedStr);
            
            // v) Using formatting: use the `String.Format()` method or string interpolation denoted
            // by '$' symbol.
            short age = 23;
            Console.WriteLine($"Interpolated: {firstName} is {age} years old.");
        }
    }
}