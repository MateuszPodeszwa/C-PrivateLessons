// See https://aka.ms/new-console-template for more information
/*
 * Ask user for the target row and column.
 * Compute the neighboring rows and columns of where to deploy the squad.
 * Change the window tite to be "Defense of Consolas".
 * Play a sound with Console.Beep when the results have been computed and displayed.
 * 
 */

using System.Runtime.InteropServices.JavaScript;

Console.Title = "Defense of Consolas"; // Set the console title

int row;            // user input row
int column;         // user input column
int positionOne;    // *
int positionTwo;    // * The calculation for
int positionThree;  // * the deploy position.
int positionFour;   // *

Console.Write("Row: "); // Asking user about row
row = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.Write("Column: "); // Asking user about column
column = Convert.ToInt32(Console.ReadLine());

Console.Clear(); 
positionOne = row - 1;        // *
positionTwo = row + 1;        // * Main Calculations
positionThree = column - 1;   // * Calculate the Deployement
positionFour = column + 1;    // *

Console.ForegroundColor = ConsoleColor.Green;
Console.Beep();

// Output the calculations
Console.WriteLine($@"The position of deployment is: 
                     Position 1: {positionOne}, {column}
                     Position 2: {positionTwo}, {column}
                     Position 3: {row}, {positionThree}
                     Position 4: {row}, {positionFour}");