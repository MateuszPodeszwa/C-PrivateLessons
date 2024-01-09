using System.Drawing;
using Figgle;

namespace CSharp_Projects_SimpleShoppingBag;

class Program
{
    static void Main(string[] args)
    {
        string[,] shoppingListArray =
        {
            { "4,99", "Bread" },        // 0,0 - 0,1
            { "1,99", "Milk" },         // 1,0 - 1,1
            { "0,99", "Egg" },          // 2,0 - 2,1
            { "2,99", "Apple" },        // 3,0 - 3,1
            { "3,99", "Cheese" },       // 4,0 - 4,1
            { "0,99", "Butter" },       // 5,0 - 5,1
            { "1,99", "Orange" },       // 6,0 - 6,1
            { "2,99", "Banana" },       // 7,0 - 7,1
            { "1,99", "Pineapple" },    // 8,0 - 8,1
            { "0,99", "Tomato" },       // 9,0 - 9,1
            { "1,99", "Potato" },       // 10,0 - 10,1
            { "1,99", "Carrot" },       // 11,0 - 11,1
            { "1,99", "Cucumber" },     // 12,0 - 12,1
            { "1,99", "Onion" },        // 13,0 - 13,1
            { "1,99", "Garlic" },       // 14,0 - 14,1
            { "1,99", "Ginger" },       // 15,0 - 15,1
            { "1,99", "Lemon" },        // 16,0 - 16,1
            { "1,99", "Lime" },         // 17,0 - 17,1
            { "1,99", "Peach" },        // 18,0 - 18,1
            { "1,99", "Pear" },         // 19,0 - 19,1
            { "1,99", "Strawberry" },   // 20,0 - 20,1
            { "1,99", "Raspberry" },    // 21,0 - 21,1
            { "1,99", "Blueberry" },    // 22,0 - 22,1
            { "1,99", "Blackberry" },   // 23,0 - 23,1
            { "1,99", "Cherry" },       // 24,0 - 24,1
            { "1,99", "Grape" },        // 25,0 - 25,1
        };
        
        var userShoppingList = new string[shoppingListArray.GetLength(0), 2];
        CopyArrays(shoppingListArray, userShoppingList);
        DisplayMenu(shoppingListArray, userShoppingList);
    }

    private static void CopyArrays(string[,] one, string[,] two)
    {
        for (var element = 0; element < two.GetLength(0); element++)
        {
            two[element, 0] = element.ToString();
            two[element, 1] = 0.ToString();
        }
    }

    private static void DisplayMenu(string[,] theMenu, string[,] userMenu)
    {
        ConsoleKeyInfo keyInfo;
        var selectedIndex = 0;
        var currentIndex = 0;

        do
        {
            Console.Clear();
            PrintOutTheMenu();
            keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Enter) AddItemToBasket();
            if (keyInfo.Key == ConsoleKey.Backspace) RemoveItemFromBasket();
            GetArrowKeyInput();
        } while (keyInfo.Key != ConsoleKey.Escape);

        return;

        void PrintOutTheMenu()
        {
            bool isSelected;
            bool inTheBasket;
            
            for (var x = 0; x < theMenu.GetLength(0); x++)
            {
                currentIndex = x;
                inTheBasket = CheckIfInBasket();
                isSelected = CheckIfSelected();
                
                if ((inTheBasket && isSelected) || (!inTheBasket && isSelected))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[ x ] > ");
                    Console.Write(theMenu[x, 1]);
                    Console.WriteLine();
                    Console.ResetColor();
                }
                
                switch (inTheBasket)
                {
                    case true when !isSelected:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[ " + userMenu[x, 1] + " ]");
                        Console.ResetColor();
                        Console.Write(" > ");
                        Console.Write(theMenu[x, 1]);
                        Console.WriteLine();
                        break;
                    
                    case false when !isSelected:
                        Console.Write("[ - ] > ");
                        Console.Write(theMenu[x, 1]);
                        Console.WriteLine();
                        break;
                }
            }
        }

        bool CheckIfInBasket()
        {
            var quantity = Convert.ToInt32(userMenu[currentIndex, 1]);
            return quantity > 0 ? true : false;
        }

        bool CheckIfSelected() => selectedIndex == currentIndex ? true : false;

        void AddItemToBasket()
        {
            var quantity = Convert.ToInt32(userMenu[selectedIndex, 1]);
            quantity++;
            userMenu[selectedIndex, 1] = quantity.ToString();

            Console.WriteLine("Added " + theMenu[selectedIndex, 1] + " / " + userMenu[selectedIndex, 1] + " to basket.");
            Thread.Sleep(300);
        }
        
        void RemoveItemFromBasket()
        {
            var quantity = Convert.ToInt32(userMenu[selectedIndex, 1]);
            if (quantity > 0)
            {
                quantity--;
                userMenu[selectedIndex, 1] = quantity.ToString();  
                
                Console.WriteLine("Removed " + theMenu[selectedIndex, 1] + " / " + userMenu[selectedIndex, 1] + " from basket.");
                Thread.Sleep(300);
            }
            else
            {
                Console.WriteLine("Item not in basket.");
                Thread.Sleep(300);
            }
        }

        void GetArrowKeyInput()
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    selectedIndex--;
                    break;
                case ConsoleKey.DownArrow:
                    selectedIndex++;
                    break;
            }

            if (selectedIndex > theMenu.GetLength(0) - 1)
                selectedIndex = 0;
            if (selectedIndex < 0)
                selectedIndex = theMenu.GetLength(0) - 1;
        }
    }
}