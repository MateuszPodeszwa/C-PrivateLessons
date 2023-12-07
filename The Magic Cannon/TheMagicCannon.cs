namespace The_Magic_Cannon;

class TheMagicCannon
{
    static void Main(string[] args)
    {
        /*
         1. Write a program that will loop through the values between 1 and 100 and display what kind of blast the
            crew should expect. (the % operator may be used).
         2. Change the colour of the output based on the type of blast.
            (For example, red for fire, yellow for electric, blue for electric and fire).
         3. Every third turn of a crank, the fire gem activates, and the cannon produces a fire blast.
            The electric gem activates every fifth turn, of the crank, and the cannon produces electric blast.
            When the two line up, it generates a potent combined blast.
         */

        for (int x = 1; x <= 100; x++)
        {
            if (x % 3 == 0 && x % 5 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Electric and Fire Blast");
            }
            else if (x % 3 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fire Blast");
            }
            else if (x % 5 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Electric Blast");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You are saved!");
            }
        }
    }
}