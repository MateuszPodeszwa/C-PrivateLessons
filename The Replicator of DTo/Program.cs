/*
 * The Story:
 * While searching an abandoned storage building containing strange code artifacts, you uncover the ancient
 * Replicator of D'To. This can replicate the contents of any int array into another array.
 * But it appears broken and needs a Programmer to reforge the magic that allows it to replicate once again.
 *
 * Objectives:
 * 1. Make a program that creates an array of length 5.
 * 2. Ask the user for five numbers and put them in the array.
 * 3. Make a second array of length 5.
 * 4. Use a loop to copy the values out of the original array and into the new one.
 * 5. Display the contents of both arrays one at a time to illustrate that the Replicator of T'To works.
 * 
 */

using System.Threading.Channels;

namespace The_Replicator_of_DTo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello User!");
        int[] firstArray = new int[5];
        int[] secondArray = new int[5];
        
        for (int x = 0; x < firstArray.Length; x++)
        {
            Console.Write($"Provide the {x + 1} number: ");
            string userInput = Console.ReadLine();
            firstArray[x] = Convert.ToInt32(userInput);
            Console.Clear();
        }

        Array.Copy(firstArray, secondArray, firstArray.Length);
        
        Console.Clear();
        Console.WriteLine(@"Replicator Output: ");
        
        for (int i = 0; i < firstArray.Length; i++)
            Console.WriteLine($@"{firstArray[i]}    :   {secondArray[i]}"); 
    }
}