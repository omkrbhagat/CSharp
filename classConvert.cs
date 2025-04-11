using System;

namespace ClassConvert
{
    public class Program 
    {         
        static void Main(string[] args)
        {
            double MyDouble_1 = 123.02;
            int MyInt_1 = Convert.ToInt32(MyDouble_1);
            Console.WriteLine($"Num: {MyInt_1}");
            
            int MyInt_2 = 144;
            double MyDouble_2 = Convert.ToDouble(MyInt_2);
            Console.WriteLine($"Double: {MyDouble_2}");
            
            char MyChar_1 = '@';
            string MyStr_1 = Convert.ToString(MyChar_1);
            Console.WriteLine($"Str: {MyStr_1}");
            
            string MyStr_2 = "O"; // string must be exactly one character long
            char MyChar_2 = Convert.ToChar(MyStr_2);
            Console.WriteLine($"Char: {MyChar_2}");
            
            Console.WriteLine($"SizeOf: {sizeof(int)}");
        }
    }
}
