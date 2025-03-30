using System;
using System.Collections.Generic;

namespace ListDataType
{
    public class ListsType
    {
        static void Main(string[] args)
        {
            /*
                `List<string>[]` does not contain a
                definition for `Add` & no accessible
            */
            // var names = new List<string> [];
            // var names = new List<string> ();
            // var names = new List<string> {};
            var names = new List<string> {"Ruth", "Rich"};
            names.Add("Katie");
            names.Add("Maximus");
            names.Add("Lexi");
            
            foreach(var name in names)
            {
                Console.WriteLine($"Name: {name}");
            }
            Console.Write("\n");
            
            foreach(var name in names[2..4])
            {
                Console.WriteLine($"{name}");
            }
            Console.Write("\n");
            
            Console.WriteLine($"Last Name: {names[^1]}");
            Console.WriteLine($"Second Last: {names[^2]}");
        }
    }
}