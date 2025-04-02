using System;
using System.Threading;

namespace ClassConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            for(short i = 1; i <= 10; i++)
            {
                if(i > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Thread.Sleep(500);
                    Console.WriteLine($"Num: {i}");
                    continue;
                }
                
                Thread.Sleep(500);
                Console.WriteLine($"Num: {i}");
            }
            
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
