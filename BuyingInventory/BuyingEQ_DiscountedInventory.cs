// See https://aka.ms/new-console-template for more information
// Part 2 of the task "Discounted Inventory"

Console.Write("Your Name: "); string userName = Console.ReadLine();

int discountNumber = 50;

// Calculating 50% discount if user = Mateusz
double? discount = userName == "Mateusz" ? (double)discountNumber : null;
Console.Clear();

// Setting the prices to each item
decimal rope = 10;
decimal torches = 15;
decimal climbingEquipment = 25;
decimal cleanWater = 1;
decimal machete = 20;
decimal canoe = 200;
decimal foodSupplies = 1;

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
Console.Write("The number: "); sbyte theItem = sbyte.Parse(Console.ReadLine());

// It could be done better, much better, but I didn't want to change the program's structure
// If the discount is null, provide regular price. If not then display price discount% off
string response = theItem switch
{
    1 => $"Rope: {(discount != null ? rope * (decimal)(discount / 100) : rope)}$",
    2 => $"Torches: {(discount != null ? torches * (decimal)(discount / 100) : torches)}$",
    3 => $"Torches: {(discount != null ? climbingEquipment * (decimal)(discount / 100) : climbingEquipment)}$",
    4 => $"Clean Water: {(discount != null ? cleanWater * ((decimal)discount / 100) : cleanWater)}$",
    5 => $"Machete: {(discount != null ? machete * ((decimal)discount / 100) : machete)}$",
    6 => $"Canoe: {(discount != null ? canoe * ((decimal)discount / 100) : canoe)}$",
    7 => $"Food Supplies: {(discount != null ? foodSupplies * ((decimal)discount / 100) : foodSupplies)}$",
    _ => $"We couldn't find the product.."
};

Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(response);