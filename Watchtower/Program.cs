// See https://aka.ms/new-console-template for more information
// Project objectives can be see in the repo's README.md file

// Declare variables
int xValue = 0;
int yValue = 0;
string error = "Some error message";

// Ask the user > input
Console.Write("X Value: ");
xValue = int.Parse(Console.ReadLine());
Console.Clear();

Console.Write("Y Value: ");
yValue = int.Parse(Console.ReadLine());
Console.Clear();

// Main Calculations
string CalculateEnemyPosition(int x, int y)
{
    string message = "No coordinates...";

    if (x < 0)
        message = y > 0 ? "NW" : (y == 0 ? "W" : "SW");
    
    else if (x == 0)
        message = y > 0 ? "N" : (y == 0 ? "We are under the attack!" : "S");
    
    else if (x > 0)
        message = y > 0 ? "NE" : (y == 0 ? "E" : "SE");
    
    else message = "error";
    /*
     Possible answer, don't recommend - hard to read
     
     message = x < 0 ? (y > 0 ? "NW" : (y == 0 ? "W" : "SW"))
         : (x == 0 ? (y > 0 ? "N" : (y == 0 ? "We are under the attack!" : "S"))
             : (x > 0 ? (y > 0 ? "NE" : (y == 0 ? "E" : "SE"))
                 : "error")); */

    return message;
}

// Output Message
Console.WriteLine(CalculateEnemyPosition(xValue, yValue));

