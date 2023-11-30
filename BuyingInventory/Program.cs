// See https://aka.ms/new-console-template for more information

Console.WriteLine(@"The following items are available:
                  1  -  Rope
                  2  -  Torches
                  3  -  Climbing Equipment
                  4  -  Clean Water
                  5  -  Machete
                  6  -  Canoe
                  7  -  Food Supplies
                    
                  What number do you want to see the price of?
                  ");
Console.Write("The number: ");
sbyte theItem = sbyte.Parse(Console.ReadLine());

string response = theItem switch
{
    1 => "Rope: 10$",
    2 => "Torches: 15$",
    3 => "Climbing Equipment: 25$",
    4 => "Clean Water: 1$",
    5 => "Machete: 20$",
    6 => "Canoe: 200$",
    7 => "Food Supplies: 1$",
    _ => "We couldn't find the product.."
};

Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(response);