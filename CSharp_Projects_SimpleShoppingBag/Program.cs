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
            { "0,99", "Tomato" }        // 9,0 - 9,1
        };

        string[,] userShoppingList = shoppingListArray;
        CopyArrays(shoppingListArray, userShoppingList);
        DisplayMenu(shoppingListArray, userShoppingList);
    }

    static void CopyArrays(string[,] one, string[,] two)
    {
        for (var element = 0; element < one.GetLength(0); element++)
        {
            two[element, 0] = element.ToString();
            two[element, 1] = 0.ToString();
        }
    }

    static void DisplayMenu(string[,] theMenu, string[,] userMenu)
    {
        ConsoleKeyInfo keyInfo;
        int selectedIndex = 0;
        int currentIndex = 0;

        do
        {
            keyInfo = Console.ReadKey();

            GetArrowKeyInput();
            PrintOutTheMenu();

            if (keyInfo.Key == ConsoleKey.Enter)
                AddItemToBasket();
            
        } while (keyInfo.Key != ConsoleKey.Enter);

        void PrintOutTheMenu()
        {
            for (var x = 0; x < theMenu.GetLength(0); x++)
            {
                bool inTheBasket = CheckIfSelected();
                bool isSelected = CheckIfSelected();

                if (inTheBasket && isSelected)
                {
                    Console.Write("[x] > ");
                    Console.Write(theMenu[x, 1]);
                    Console.WriteLine();
                }
                if (inTheBasket && !isSelected)
                {
                    Console.Write("[ " + userMenu[x, 1] + " ] > ");
                    Console.Write(theMenu[x, 1]);
                    Console.WriteLine();
                }
                if (!inTheBasket && isSelected)
                {
                    Console.Write("[x] > ");
                    Console.Write(theMenu[x, 1]);
                    Console.WriteLine();
                }
            }
        }

        bool CheckIfSelected()
        {
            bool indexPosition = selectedIndex == currentIndex ? true : false;
            if (indexPosition && Convert.ToInt32(userMenu[currentIndex, 1]) > 0)
                return true;
            return false;
        }
        
        void AddItemToBasket()
        {
            var quantity = Convert.ToInt32(userMenu[currentIndex, 1]);
            quantity++;
            userMenu[currentIndex, 1] = quantity.ToString();
        }

        void GetArrowKeyInput()
        {
            if (keyInfo.Key == ConsoleKey.UpArrow)
                selectedIndex--;
            if (keyInfo.Key == ConsoleKey.DownArrow)
                selectedIndex++;

            if (selectedIndex > theMenu.GetLength(0) - 1)
                selectedIndex = 0;
            if (selectedIndex < 0)
                selectedIndex = theMenu.GetLength(0) - 1;
        }
    }
}