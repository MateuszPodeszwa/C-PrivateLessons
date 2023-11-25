###### #introduction #csharp #basics #DOTNET
# The Console Class

C# language allows us to change and play with console basic styles and make it even more entertaining than GUI.
The Console class has many methods and provides a few of its own variables that will allow to change the window's look.

## WriteLine Method

Aside for well known `` Console.WriteLine(); `` another method called ``Write`` does all the same stuff as its bigger brother, but without jumping to the next line when it finishes. There are many uses for this, but the most popular is to being able to ask the user a question and letting them answer on the same line:

```c#
Console.Write("What is your age?: ");
string userAge = Console.ReadLine();
```

	What is your age?: __

## ReadKey Method

The ``Console.ReadKey();`` method does not wait the user to push enter before completing. it waits for only a single keypress, so if you want to do something like "*Press any key to continue..*" this method will be good to use.

```c#
Console.WriteLine("Press any key to continue...");
Console.ReadKey();
```

The further code will not be executed until an any keypress occur, therefore it may be used as a simple "pause" method. But unfortunately as user press the key, for example a letter 'a' this key will stay on the screen. But there is a way around this! C# allows for creating multiple methods which share the same name, and have different inputs. So the ReadKey method.

```c#
Console.ReadKey(true);
```

By passing the **true** argument into the method's bool input the method will output the bool value that won't be visible on the screen, as well as the selected key! Moreover, this method can be also used in `if` statements to check if the keystroke has occurred. 

## Changing Colours

Changing colour is not a method but a property that can be adjusted and configured, the `Console` class provides variables (*properties*) that store the colours it uses for displaying the text.

```c#
Console.BackgroundColor = ConsoleColor.Yellow; // Bacground
Console.ForegroundColor = ConsoleColor.Black; // Text
```

After assigning new values into these two variables: `BackgroundColor` and `ForegroundColor` the console will use black text on a yellow background.

Therefore based on above response we understand that:
- The `BackgroundColor` property will: change the background colour, we can use any colour as long as it is part of the `ConsoleColor` collection.
- The logic is the same as above, a `ForegroundColor` property will: change the text colour to Black.

## Clear Method

Sometimes you just need to clear out the screen, to do so there is a special clear method. There is how you can use it:

```c#
Console.Clear();
```

## Changing the window title

Console also has a `Title` property, which will change the text displayed in the console window's title bar. It's type is a string, although it also accept variables.

```c#
string windowTitle = "The Text";
Console.Title = windowTitle;

/* Alternativelly you can write the text instead of variable */

Console.Title = "The Text";
```

## Beep method

The beep method makes the 'beep' sound, the only sound the console can make is a retro 80's square wave (although, the sound depends on the operating system).

```c#
Console.Beep();
```

It is also possible to choose both: frequency and duration, the first value represents frequency and the second is duration measured in milliseconds (both must be type INT).

```c#
Console.Beep(440, 1000);
```

Unfortunately, the frequency and duration variables may not work on some operating systems resulting error.

```error 
Unhandled exception. System.PlatformNotSupportedException: Operation is not supported on this platform.
   at System.ConsolePal.Beep(Int32 frequency, Int32 duration)
   at System.Console.Beep(Int32 frequency, Int32 duration)
   ...
```

[Console 2.1 Escape Sequences]
