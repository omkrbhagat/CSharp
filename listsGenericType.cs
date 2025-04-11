using System;
using System.Collections.Generic;

namespace ListDataType
{
    public class ListsType
    {
        static void Main(string[] args)
        {
            /*
                var names = new List<string>[];
                OR
                List<string> names = new List<string>[];
                This declares an array of `List<string>` objects (not a single
                `List<string>`). So, names is an empty array that can hold
                `List<string>` instances.
                
                var names = new List<string>();
                OR
                List<string> names = new List<string>();
                This creates a new instance of `List<string>` using the default
                constructor. names is an empty list (no elements), initialized
                with the default capacity.
                
                var names = new List<string> {};
                OR
                List<string> names = new List<string> {};
                This uses a collection initializer to create a `List<string>` (with
                optional elements inside {}). names is an empty list equivalent to
                new `List<string>()`.
                
                Key Takeaways:
                `List<string>()` is more explicit for empty lists.
                `List<string> { ... }` is better when initializing with elements.
            */
            var names = new List<string> {"Ruth", "Rich"};
            Console.WriteLine($"List<string> Type: {names.GetType()}\n");
            names.Add("Katie");
            names.Add("Maximus");
            names.Add("Lexi");
            
            Console.WriteLine("Elements:");
            foreach(var name in names)
            {
                Console.WriteLine($"Name: {name}");
            }
            Console.WriteLine("\nMiddle range elements: ");
            
            foreach(var name in names[2..4])
            {
                Console.WriteLine($"{name}");
            }
            Console.Write("\n");
            
            // Mono didn't support the below syntax :
            // Console.WriteLine($"Last Name: {names[^1]}");
            // Console.WriteLine($"Second Last: {names[^2]}");
            Console.WriteLine($"Last Name: {names[names.Count - 1]}");
            Console.WriteLine($"Second Last: {names[names.Count - 2]}\n");
            
            /*
                Arrays have `.Length` because they're fixed-size, while `List<T>`
                is a dynamic collection, so it uses `.Count` to get the number
                of elements.
            */
            
            var shapes = new List<object> {
                new {Figure = "Circle",
                    Radius = 5
                },
                new {Figure = "Square",
                    Side = 4
                },
                new {Figure = "Rectangle",
                    Width = 6,
                    Height = 4
                }
            };
            
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
