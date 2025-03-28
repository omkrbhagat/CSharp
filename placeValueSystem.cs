using System;

namespace PlaceValueSys
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] indianSys = {
                "Ones",
                "Tens",
                "Hundreds",
                "Thousands",
                "Ten Thousands",
                "Lakhs",
                "Ten Lakhs",
                "Crores",
                "Ten Crores",
                "Arab",
                "Ten Arab",
                "Kharab",
                "Ten Kharab",
                "Neel",
                "Ten Neel",
                "Padma",
                "Shankh"
            };
            
            string[] intlSys = {
                "Ones",
                "Tens",
                "Hundreds",
                "Thousands",
                "Ten Thousands",
                "Hundred Thousands",
                "Million",
                "Ten Million",
                "Hundred Billion",
                "Billion",
                "Ten Billion",
                "Hundred Billion",
                "Trillion",
                "Quadrillion",
                "Quintillion",
                "Sextillion",
                "Septillion",
                "Octillion",
                "Nonillion",
                "Decillion"
            };
            
            
            Console.Write("[{0}, ", indianSys[0]);
            for(short i = 1; i < indianSys.Length; i++)
            {
                if(i == indianSys.Length - 1)
                {
                    Console.Write("{0}]", indianSys[indianSys.Length - 1]);
                    break;
                }
                    
                Console.Write("{0}, ", indianSys[i]);
            }
                
        }
    }
}
