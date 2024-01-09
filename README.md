# Simple Shopping Bag

This is a simple console application for managing a shopping list. Users can navigate through a list of items, add them to their basket, and remove them. The application displays the menu, indicating selected and basket items.

## Usage

1. Run the application.
2. Use the arrow keys to navigate the menu.
3. Press `Enter` to add the selected item to the basket.
4. Press `Backspace` to remove the selected item from the basket.
5. Press `Escape` to exit the application.

## Code Structure

### `Program` Class
- `Main`: Entry point of the application. Initializes the shopping list and user's shopping list, then displays the menu.

### `CopyArrays` Method
- Copies values from one array to another, initializing the user's shopping list.

### `DisplayMenu` Method
- Handles menu display, user input, and basket management.
- `PrintOutTheMenu`: Displays the menu with appropriate formatting.
- `CheckIfInBasket`: Checks if the selected item is in the basket.
- `CheckIfSelected`: Checks if the current item is selected.
- `AddItemToBasket`: Adds the selected item to the basket.
- `RemoveItemFromBasket`: Removes the selected item from the basket.
- `GetArrowKeyInput`: Handles arrow key input for navigation.

## How to Run

1. Ensure you have the necessary dependencies installed.
2. Compile and run the program.
3. Follow the on-screen instructions to interact with the shopping list.

## Dependencies

- `System.Drawing`: Used for console color formatting.
- `Figgle`: Used for ASCII art in the console.

## Note

- The application uses the `Figgle` library to display ASCII art in the console. Ensure the library is referenced in your project.

## References

- [Figgle Library](https://www.nuget.org/packages/Figgle/)

Feel free to enhance or modify the code as needed. Happy coding!
