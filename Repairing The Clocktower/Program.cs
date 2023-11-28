// See https://aka.ms/new-console-template for more information
/*
 * Take a number as input from the console
 * Display "Tick" if number is even
 * Display "Tock" if number is odd
 */

// Declare variables
int number = 0;
bool evenoddCalc;

Console.Write("The number: ");
number = Int32.Parse(Console.ReadLine()); // Convert the user input to the number which is int type
evenoddCalc = number % 2 == 0; // Calculating if number is even

// If number is even then say tick
if (evenoddCalc) Console.WriteLine("Tick");
else Console.WriteLine("Tock");