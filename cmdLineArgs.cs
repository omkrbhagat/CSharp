using System;
using System.IO;

namespace CMDLineArgs {
    public static class Program {
	    static void Main(string[] args) {
		    // string pathh = @"/home/omkar/Documents/fileName.txt";
            // Console.WriteLine(pathh);
            string path = Environment.GetCommandLineArgs()[0];
            Console.WriteLine($"fileName: {Path.GetFileName(path)}");
            Console.WriteLine($"fileName (without .ext): {Path.GetFileNameWithoutExtension(path)}");
        
            if(args.Length > 0) {
                for(short i = 0; i < args.Length; i++) {
                    Console.WriteLine($"Arg {i}: {args[i]}");
                }
            }else {
                Console.WriteLine("No arguments provided");
            }
	    }
    }
}

/*
    Key Takeaways :
    i) `args[]` in C# contains only user-provided arguments,
    not the program name.
    ii) Use `Environment.GetCommandLineArgs()` or Process
    related classes to get the executable name.
    iii) If you run the program without any arguments, accessing
    `args[0]` will throw an `IndexOutOfRangeException`.
    iv) Always check `args.Length` before accessing elements to
    avoid exceptions.
    v) `Path.GetFileName()`: gets filename with extension (like basename)
    in Unix.
    vi) `Path.GetFileNameWithoutExtension()`: strips thr extension.
*/
