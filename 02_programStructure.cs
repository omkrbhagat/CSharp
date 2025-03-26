// `using System` means that we can use classes from the System namespace.
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

/*
    `namespace` is used to organize your code,
    & it is a container for classes & other namespaces.
*/
namespace CSharpShell
{
    /*
        `class` is a container for data & methods,
        which brings functionality to your program.
        Every line of code that runs in C# must be
        inside a class.
    */
    public static class Program
    {
        /*
            Another thing that always appear in a C#
            program is the `Main` method. Any code
            inside its curly brackets will be executed.
        */
        public static void Main(string[] args)
        {
            /*
                `Console` is the class of the `System`
                namespace, which has a `WriteLine`
                method that is used to output/print
                text. If you omit the `using System`
                line, you would have to write
                `System.Console.WriteLine` to
                output/print text.
            */
            Console.WriteLine("Hello, World!");
        }
    }
}

/*
    Note:
    i) Every C# statement ends with a semicolon.
    ii) V# is case-sensitive; "MyClass" & "myclass"
    have different meaning.
    iii) Unlike Java, the name of the C# file does
    not have to match the class name, but they often
    do (for better organisation).
*/