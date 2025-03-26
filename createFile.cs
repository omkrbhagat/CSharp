using System;
using System.IO;

namespace CreateFile {
    public class Program {
        static void Main(string[] args) {
            string path = @"/storage/emulated/0/src/SRC C#/";
            try {
                FileStream fs = File.Create("fileName.txt");
            } catch(Exception ex) {
                Console.WriteLine($"Error: {ex}");
            }
        }
    }
}
