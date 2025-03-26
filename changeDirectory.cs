using System;
using System.IO;
using System.Linq;

namespace CSharpShell {
    public static class Demo {
        static void Main(string[] args) {
            Directory.SetCurrentDirectory("/storage/emulated/0/Documents");
            // Console.WriteLine($"pwd: {Environment.CurrentDirectory}");
            Console.WriteLine($"pwd: {Directory.GetCurrentDirectory()}");
        }
    }
}