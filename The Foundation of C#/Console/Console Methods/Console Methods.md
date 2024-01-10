---
tags: []
---
# The Console Class

C# language allows us to change and play with console basic styles and make it even more entertaining than GUI.
The Console class has many methods and provides a few of its own variables that will allow to change the window's look.

%%
HOW TO NAVIGATE?

You can use the CANVAS diagram below this comment to see the structure and order you should read the notes. It is not necessary because notes have multiple links and annotation to more complex definitions.

%%

![[How to learn.canvas|How to learn]]
## WriteLine Method
## Write Method
## ReadKey Method
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

This is one of the ways to improve aesthetics of the console view, another approach can be to style the text [[Console 2.1 Escape Sequences]].

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

