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
                    int usrNum = int.Parse(Console.ReadLine());
                    
                    if (usrNum == guessNum) {
                        Console.WriteLine($"You Win!!!\nTotal Attempts: {Count}");
                        State = false;
                    } else if (usrNum > guessNum) {
                        Console.Write("Too High\nEnter again: ");
                    } else if (usrNum < guessNum) {
                        Console.Write("Too Low\nEnter again: ");
                    }
                    
                    Count++;
                }
                
                Console.Write("Do you want to play again (Y/n): ");
                string response = Console.ReadLine().Trim().ToUpper();
                
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
