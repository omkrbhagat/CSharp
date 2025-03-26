using System;
using System.IO;
using System.Linq;

namespace ChangeDir {
    public class Program {
        static void Main(string[] args) {
            string path = @"/storage/emulated/0/Documents/";
            Directory.SetCurrentDirectory(path);
            // Console.WriteLine($"pwd: {Environment.CurrentDirectory}");
            Console.WriteLine($"pwd: {Directory.GetCurrentDirectory()}");
        }
    }
}