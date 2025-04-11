using System;

namespace ClassRandom
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
            
            Console.WriteLine("Type: " + random.GetType());
            // Console.WriteLine($"Number: {random.Next(1, 11)}");
            // Console.WriteLine($"Number: {random.Next(11)}");
            
            int index = random.Next(names.Length + 1);
            Console.WriteLine("Employee of the month: " + names[index]);
            
            // Generates a random string
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random rand = new Random();
            char[] stringChars = new char[10];
            for (int i = 0; i < stringChars.Length; i++) {
                stringChars[i] = characters[rand.Next(characters.Length)];
            }
            
            string randomString = new string(stringChars);
            Console.WriteLine("Random string: " + randomString);
        }
    }
}