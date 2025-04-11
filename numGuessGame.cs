using System;

namespace NumGuess
{
    public class Program 
    {         
        static void Main(string[] args)
        {
            var rand = new Random();
            bool playAgain = false;
            
            do {
                bool State = true;
                // instead of declaring in `Main`, Count declare here
                // otherwise, Count will not reset
                int Count = 1;
                int guessNum = rand.Next(1, 11);
                Console.Write("Enter a number (1 to 10): ");
                
                while (State)
                {
                    /*
                        int usrNum = int.Parse(Console.ReadLine());
                        above line gives warning, because ReadLine() can return `null`
                        (if the input stream ends, like when pressing `Ctrl + Z` in the terminal,
                        but `int.Parse()` does not accept `null`.
                        
                        Use the non-forgiving operator (!) (if 100% sure input won't be null)
                        int usrNum = int.Parse(Console.ReadLine()!); // tells compiler this won't be `null`
                        Risk: Crashes if ReadLine() returns `null`
                        
                        Provide a default value: Use ?? to replace `null` with a fallback string.
                        int usrNum = int.Parse(Console.ReadLine() ?? "0");
                        Risk: Still fails if input is non-numeric (e.g., "abc")
                    */

                    if (int.TryParse(Console.ReadLine(), out int usrNum))
                    {
                        if (usrNum == guessNum)
                        {
                            Console.WriteLine($"You Win!!!\nTotal Attempts: {Count}");
                            State = false;
                        }
                        else if (usrNum > guessNum)
                        {
                            Console.Write("Too High\nEnter again: ");
                        }
                        else if (usrNum < guessNum)
                        {
                            Console.Write("Too Low\nEnter again: ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }

                    // Uncomment below code if you don't use TryParse method
                    /*
                    int usrNum = int.Parse(Console.ReadLine()!);
                    // int usrNum = int.Parse(Console.ReadLine() ?? "0");

                    if (usrNum == guessNum)
                    {
                        Console.WriteLine($"You Win!!!\nTotal Attempts: {Count}");
                        State = false;
                    }
                    else if (usrNum > guessNum)
                    {
                        Console.Write("Too High\nEnter again: ");
                    }
                    else if (usrNum < guessNum)
                    {
                        Console.Write("Too Low\nEnter again: ");
                    }
                    */

                    Count++;
                }
                
                Console.Write("Do you want to play again (Y/n): ");

                /*
                    string response = Console.ReadLine().Trim().ToUpper();
                    above line gives warning: "Derefrence of a possibly null reference."
                    Console.ReadLine() can return `null` (e.g., if input is redirected from
                    a file that ends, or if the user sends an EOF signal like `Ctrl + Z`). Calling
                    `.Trim()` or `.ToUpper()` on null would throw a `NullReferenceException`.

                    Use the Nulll-Conditional Operator (?.) + Default value
                    string response = Console.ReadLine()?.Trim().ToUpper() ?? "";
                    • `?.` skips Trim()/ToUpper() if ReadLine() is `null`.
                    • `?? ""` provides a fallback empty string insead of `null`.

                    Explicit null check:
                    string? input = Console.ReadLine();
                    string response = (input != null) ? input.Trim().ToUpper() : "";

                    Throw an exception if `null`
                    string response = Console.ReadLine()?.Trim().ToUpper() ?? throw new InvalidOperationException("Input cannot be null.");

                    Best Practice:
                    • Use `?.` + `??` for most cases (avoid NullRefrenceException).
                    • Use Try-style patterns (like TryParse)vfor parsing user input.
                */
                // string response = Console.ReadLine().Trim().ToUpper();
                // string response = Console.ReadLine()?.Trim().ToUpper() ?? throw new InvalidOperationException("Input cannot be null.");
                string response = Console.ReadLine()?.Trim().ToUpper() ?? "";

                /*
                    1) Comparison operation (response == "Y"):
                    • The == operator checks if the left side equals the right side.
                    • This comparison returns a boolean value (true or false).
                    2) Assignment (playAgain = ...):
                    • The result of the comparison gets assigned to the playAgain variable.
                    • This is equivalent to writing:
                        if (response == "Y")
                            playAgain = true;
                        else
                            playAgain = false;
                */
                playAgain = response == "Y";
                
            } while (playAgain);
        }
    }
}
