using System;

namespace RandNumGen
{
    public class Program
    {
        static void Main(string[] args)
        {
            // var random = new Random();
            // Random random = new Random();
            Random random = new();
            
            string[] names = {"Julie", "Mathew", "Venessa", "Spencer",
            "Cole", "John", "Romie", "Scott", "Natasha", "Blake"
            };
            
            Console.WriteLine($"Type: {random.GetType()}");
            // Console.WriteLine($"Number: {random.Next(1, 11)}");
            // Console.WriteLine($"Number: {random.Next(11)}");
            
            int index = random.Next(names.Length);
            Console.WriteLine($"Employee of the month: {names[index]}");
        }
    }
}