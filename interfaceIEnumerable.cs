using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

/*
    `IEnumerable` is an interface in C# representing a collection of elements
    that can be enumerated. It provides a method to retrive an enumerator for
    a collection. The `IEnumerable` interface is defined in the `System.Collections`
    namespace.
    
    Essential things about `IEnumerable`:
    • Enumeration: The primary purpose of `IEnumerable` is to provide a way to
    enumerate (loop through) a collection of elements. The interface defines
    a single method, `GetEnumerator()`, which returns an `IEnumerator` object
    that allows you to iterate over the collection.
    • Lazy Evaluation: `IEnumerable` supports lazy evaluation, which means
    that the collection elements are not computed until they're actually
    needed. This can improve performance by avoiding unnecessary computations.
    • LINQ: In C#, `IEnumerable` is an integral part of the LINQ (Language-
    Integrated Query) System. Many LINQ operators, such as `Where`, `Select` &
    `OrderBy` operate on `IEnumerable` objects.
    • Extension Methods: The `IEnumerable` interface includes a set of extension
    methods that make it easier to work with collections in C#. These methods include
    `ToList()`, `ToArray()`, `Count()`, `First()`, `Last()` and many others.
    
    `IEnumerator`: This interface provides methods to iterate over a collection,
    allowing forward-only cursor movement through the collection.
    
    `IEnumerator` provides the mechanics for iteration with three members:
    • `Current`: Gets the current item in the collection.
    • `MoveNext()`: Advances to the next item. Returns false if the end of the collection
    is needed.
    • `Reset()`: Resets the enumerator to its initial position.
*/

namespace IEnumerableExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a List of strings
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Cherry");
            fruits.Add("Date");
            fruits.Add("Elderberry");
            
            /*
                Here we demonstrate three different ways to iterate over the elements
                of the collection:
                • Using a foreach loop: We use a foreach loop to iterate over the fruits
                list & print each element to the console.
                • Using an `IEnumerator` object: We create an `IEnumerator` object by
                calling the `GetEnumerator()` method on the fruits list & then use a
                while loop to iterate over the elements of the collection & print each
                one to the console.
                • Using LINQ: We use LINQ to query the fruits list & create a new
                `IEnumerable<string>` object called `query` that contains only the fruits
                with more than 5 characters in their name. We then use a foreach loop to
                iterate over the elements of the query & print each one to the console.
            */

            // Iterate over the List using a foreach loop
            foreach (string fruit in fruits)
            {
                if(fruits[fruits.Count-1] == fruit)
                {
                    Console.WriteLine($"{fruit}\n");
                    break;
                }
                Console.WriteLine(fruit);
            }

            // Iterate over the List using an IEnumerator object
            // IEnumerator enumerator = fruits.GetEnumerator(); // This also works
            IEnumerator<string> enumerator = fruits.GetEnumerator(); // but this is recommended
            while (enumerator.MoveNext())
            {
                if(fruits[fruits.Count-1] == enumerator.Current)
                {
                    Console.WriteLine($"{enumerator.Current}\n");
                    break;
                }
                Console.WriteLine(enumerator.Current);
            }

            // Use LINQ to query the List
            IEnumerable<string> query = fruits.Where(fruit => fruit.Length > 5);
            foreach (string fruit in query)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}