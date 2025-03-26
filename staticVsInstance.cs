/*
    When executed, the Main method:
    i) Creates an instance of the Program class (myProgram).
    ii) Calls the Print method on this instance.
    
    Why use an instance?
    The Print method is not static, so it requires an object
    of the Program class to be called. Since Main is static,
    it cannot directly call non-static methods without an
    instance.
    
    Key Concept :
    Static Vs. Instance methods: Ststic methods (like Main)
    can't directly call instance methods without first creating
    an object of the class.
*/

using System;

class Program {
    static void Main(string[] args) {
        Program myProgram = new Program();
        myProgram.Print();
    }
        
        void Print() {
            Console.WriteLine("Hello from Main");
        }
}
