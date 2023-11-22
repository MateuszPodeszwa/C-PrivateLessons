// See https://aka.ms/new-console-template for more information

/*
 *
 * Create a program that lets the user enter the number of chocolate eggs gathered that day.
 * Using / and %, compute how many eggs each sister should get and how many are left over for the duckbear.
 * Answer this question: What are three total egg counts where the duckbear gets more than each sister does?
 * 
 */

 // Declaring variables
 int numberofEgs;
 int noofSisters = 4;
 int sisterGet;
 int duckbearGet;
 
 // Input for numberofEgs
 Console.Write("Enter the number of eggs: ");
 numberofEgs = Int32.Parse(Console.ReadLine());

 if (numberofEgs < 1)                               // *
 {                                                  // Checks if
     Console.WriteLine("Provide positive number");  // the inputnumber is
     return;                                        // positive, / output error.
 }                                                  // *

 sisterGet = numberofEgs / Convert.ToInt32(noofSisters);
 duckbearGet = numberofEgs % Convert.ToInt32(noofSisters);
 Console.WriteLine($"Each sister({noofSisters}) will get {sisterGet}, and duckbear will get {duckbearGet}");