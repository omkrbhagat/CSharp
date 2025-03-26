using System;
using Dystem.IO;
using System.Linq;

namespace CSharpShell;

public class Demo {
    static void Main(string[] args) {
        Directory.SetCurrentDirectory("/storage/emulated/0/Documents");
        Console.WriteLine($"pwd: {Environment.CurrentDirectory}");
    }
}
