using System;
using System.IO;

namespace ClassFile
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? path = null;
            if (OperatingSystem.IsAndroid())
            {
                path = "/storage/emulated/0/Documents/";
            } else if (OperatingSystem.IsWindows())
            {
                path = Environment.GetEnvironmentVariable("USERPROFILE");
                path += @"\Desktop\";
            } else
            {
                throw new NotImplementedException("OS not supported");
            }

            Directory.SetCurrentDirectory(path);
            Console.Write("Enter content: ");
            /*
                string content = Console.ReadLine();
                This generates the warning: "Converting null literal or possible
                null value to non - nullable type."
                To resolve the warning, you can handle the potential null value
                returned by Console.ReadLine() by using the null-coalescing operator (??)
                to provide a default value if Console.ReadLine() returns null.
            */
            string content = Console.ReadLine() ?? string.Empty;
            
            try
            {
                // FileStream fs = File.Create("fileName.txt");
                File.WriteAllText("fileName.txt", content);
                Console.Write("File created with given content.");
            } catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }
    }
}
