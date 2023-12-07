/*
   1. Build a program that will allow a user, the pilot, to enter a number.
   2. If the number is above 100 or less than 0, keep asking.
   3. Clear the screen once the program has collected a good number.
   4. Indicate whether the user guessed too high, too low, or guessed right.
   5. Loop until they get it right, then end the program.
 */

namespace The_Prototype;

class The_Prototype
{
    static void Main(string[] args)
    {
        // Setting up some variables
        int userInput = 0;
        int userGuess = 0;
        
        // Setting up some aesthetically pleasing properties.
        Console.Title = "The Prototype";
        Console.ForegroundColor = ConsoleColor.White;
        
        do
        {
            Console.Write("User 1, enter a number between 0 and 100: ");
            userInput = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
            do
            {
                Console.Write("User 2, enter a number to guess: ");
                userGuess = Convert.ToInt32(Console.ReadLine());
                
                Console.Clear();
                if (userGuess > userInput)
                {
                    Console.WriteLine("Too high: " + userGuess); continue;
                }
                if (userGuess < userInput)
                {
                    Console.WriteLine("Too low: " + userGuess);
                    continue;
                }
                break;
            } while (userGuess != userInput);
            
        } while (userInput > 100 || userInput < 0);
        
        Console.WriteLine("Guessed right");
            
    }
}