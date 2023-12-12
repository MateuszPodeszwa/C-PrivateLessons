namespace The_Laws_of_Freach
{
    class Program
    {
        static void Main(string[] args)
        {
            uint arrayLength = 7;                   // User input, the length of main array
            var possibleLargest = int.MaxValue;     // For the minimum value in the array calculation
            var possibleSmallest = int.MinValue;    // For the maximum value in the array calculation

            Console.WriteLine("Hello!! FEED ME");
            Console.Write("How many values do you want to enter: ");
        
            arrayLength = Convert.ToUInt32(Console.ReadLine());
            var userInput = new int[arrayLength]; // Main array holding numbers
            // Declaring the array based on user input, enter index
            Console.Clear();
    
            // User input array value for each index
            for (var x = 0; x < arrayLength; x++)
            {
                Console.WriteLine($"Please enter the {x + 1}/{arrayLength} value: ");
                var arrayInput = Convert.ToInt32(Console.ReadLine());

                // Breaks the program if the user enter value below min or max int
                if (arrayInput is < int.MaxValue and > int.MinValue)
                    userInput[x] = arrayInput;
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The value can't be less than 0");
                    break;
                }
            
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
            }
            // Calculate the largest number
            foreach (var t in userInput)
                if (t < possibleLargest)
                    possibleLargest = t;
        
            var theLowest = possibleLargest;
        
            // Calculate the smallest value
            foreach (var t in userInput)
                if (t > possibleSmallest)
                    possibleSmallest = t;

            var theHighest = possibleSmallest;
            var average = userInput.Sum(); // For the average number in the array calculation

            // Print the results
            Console.WriteLine($"The average value in the array is: {average /= userInput.Length}");
            Console.WriteLine($"The highest value in the array is: {theHighest}");
            Console.WriteLine($"The lowest value in the array is: {theLowest}");

            Array.Sort(userInput);
            Console.WriteLine();
            foreach (var v in userInput)
                Console.WriteLine(v);
        }
    }
}