using System;
using System.IO;

namespace Compiletime
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? path;
            /*
                For compile-time branching, use SDK-defined (Xamarin or .NET MAUI)
                symbols OR define custom symbols in `.csproj` file.
                `<DefineConstants Condition="'$(OS)' == 'Windows'">WINDOWS</DefineConstants>`
                
                this won't work reliably for defining an ANDROID symbol in C# project.
                `<DefineConstants Condition="'$(ANDROID_ROOT)' == '/system'">ANDROID</DefineConstants>`
            */
            #if WINDOWS
                string? user = Environment.GetEnvironmentVariable("USERPROFILE");
                path = @$"{user}\Desktop\";
            #else
                path = "/storage/emulated/0/Documents/";
            #endif
            
            Directory.SetCurrentDirectory(path);
            Console.Write($"pwd: {Directory.GetCurrentDirectory()}");
        }
    }
}