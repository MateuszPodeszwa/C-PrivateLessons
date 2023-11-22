// See https://aka.ms/new-console-template for more information
/*
 * Objectives:
 *
 * Write a program that's lets you input the triangle's base size and height
 * Compute the area of triangle ∆
 * Write the results
 *
 */
 
// Getting user input information, to calculate TriangleArea
Console.Write("Input height: ");
// Saving space, converting user input string to double literal.
double triangleHeight = Convert.ToDouble(Console.ReadLine()); 
 
Console.Clear();
 
Console.Write("Input Base: ");
// Saving space, converting user input string to double literal.
double triangleBase = Convert.ToDouble(Console.ReadLine());
 
// Preventing outOfRange error, checks if input is not out of rage of min/max of double
if (triangleHeight < double.MinValue || triangleBase < double.MinValue)
{
    Console.Clear();
    Console.WriteLine($"Please enter a correct value, between {double.MaxValue} and {double.MinValue}");
    return;
}
 
double result = TriangleArea(triangleBase, triangleHeight); // Calling function to calculate area
 
Console.Clear();
Console.WriteLine($@"Assuming that your base = {triangleBase}, and height = {triangleHeight}
                   The triangle Area = {result}"); // This is end message
    
/*

 * Functions *

 */
 
double TriangleArea(double @base, double height)
{
    double resultX = (@base * height) / 2;
    return resultX; // Takes triangleHeight and triangleBase, returns the area
}