---
tags:
---
---
# Console.WriteLine Introduction

This method is particularly useful as you want to make an output from your console application. The `WriteLine` method lives inside the [[Console Methods|Console Class]]. 

> [!info] What is a `Console.WriteLine()` Method?
> WriteLine is a console method that makes it possible to printout the message on the console. The `writeline` can be only used for console application.

As you know, the size of text matters, therefore `WriteLine` must be <mark style="background: #FF5582A6;">WriteLine</mark> and not "writeline" or "Writeline" etc. 
## How to use WriteLine Method?

> [!example] 1 - The `System.Console.WriteLine`
> When creating a console output in C#, the most basic approach involves specifying the <mark style="background: #FF5582A6;">namespace</mark>, followed by the <mark style="background: #FFB8EBA6;">class</mark>, and then the <mark style="background: #CACFD9A6;">method</mark> of the function you wish to implement.
> 
> **So, why can this be bothersome?** 
> Take a look at this declaration! It consists of too many phrases. While writing it once might be tolerable, doing so repeatedly, whether it's tens, hundreds, or even thousands of times, becomes tedious.

Imagine you want to write a piece of code that does the following: It asks the user for input, and if the input is more than 0, the console will show a message. Don't worry if you don't understand the details for now; the code will involve some features you might not be familiar with yet.

```c#
// ...
if (userInput => 0) // if condition
	System.Console.WriteLine("Wow, the number is positive!!");
```

The crucial part here is `System.Console.WriteLine`. In this code, we're telling the computer to check something called <mark style="background: #FF5582A6;">System</mark>, then move to <mark style="background: #FFB8EBA6;">Console</mark>, and finally, use the <mark style="background: #FFB86CA6;">WriteLine</mark> method. But what does it all signify?

 1.  **Namespace:** `System` - The `Console` class is part of the `System namespace`[^1] in C#, which provides fundamental classes and base classes for the .NET Framework.
 
 2. **Class:** `Console` - The `Console`[^2] class provides methods to interact with the console window, including reading and writing text.
 
3. **Method:** `WriteLine` - The `WriteLine` method[^3] is used to write a line of text to the console. It automatically appends a newline character (`\n`)[^4] at the end of the text, causing the next output to appear on a new line.
### But how's this all works?

To display text, numbers, or symbols, you need to enclose them within parentheses and quotation marks. It looks like this:

```csharp
...("Your message will be printed.") // Correct format
```

As you can see, you should put your message between quotation marks, and you can type anything there, **including emojis!**

>[!info] **Printing Variables**
>
>As you progress in C#, you'll discover that you can print variables and perform mathematical calculations inside the `WriteLine` method. However, for now, let's focus on the basics.

## Different Approaches

C# is a sophisticated language designed for intricate tasks, yet its complexity often leads to simplifying various operations. Recall when I discussed the potential tedium of using the complete `System.Console.WriteLine` line?
Well, there's a solution to enhance user-friendliness. Think of it as a 'shortcut' or alias. Instead of specifying the full `System.Console`, you can craft a more succinct and readable version.
### The Console.WriteLine Method

>[!example] **1 - Using the `Console.WriteLine` Method**
>
>This is the most widely used approach for displaying messages on the console. Both forms are correct. The rationale behind this is that the `Console` class is part of the `System` namespace, making the `System.Console.WriteLine` fully qualified name equivalent to `Console.WriteLine`.

`Console.WriteLine` is a native feature of C# itself, not an IDE shortcut. Feel free to use it in any C# projects. However, note that this feature may not work out of the box.

In many cases, when you create a new C# solution, the project might already include the <mark style="background: #FF5582A6;">using System</mark> directive, but this isn't always guaranteed.

If you find yourself stuck after typing `Console.WriteLine();` and encountering an error, don't worry. All you need to do is include the `using System` directive. What's that? You don't need to know, at least for now.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}
```

>[!warning] **Understanding Directives**
>The keyword `System` must begin with an uppercase letter, and the directive must be at the very top of the code. In C#, the `using` directive is employed to incorporate a namespace into your program. Notably, the `using System;` directive is one of the most frequently used directives.

You can utilise the following code snippet to generate a simple output without explicitly including the namespace:

```csharp
// ...
Console.WriteLine("Nice");
// ...
```

This way, you can write `Console.WriteLine("Nice");` without specifying the full namespace.

---
### The WriteLine() Method

 > [!example] 2 - Using the `WriteLine` way
  In C#, starting from C# 6.0, you can use the `using static` directive to import static members of a type into your code, allowing you to use those members without specifying the type name.

You don't have to understand it now, the most important is that you know something like this is possible!
 
 **Here's an example using "`using static System.Console;`":**
 
```c#
using static System.Console;

class Program
{
    static void Main()
    {
        WriteLine("Hello, World!");
    }
}

```

In this example, the `using static System.Console;` directive allows you to use `WriteLine` directly without the `Console` prefix. The `WriteLine("Hello, World!");` statement is equivalent to `System.Console.WriteLine("Hello, World!");`.
This feature is convenient for shortening code when you frequently use static members of a particular class. However, it's important to use it judiciously, as it might reduce code readability if overused.

---
# Console.Write Method

Aside for well known `` Console.WriteLine(); `` another method called [[Write Method]] does all the same stuff as its bigger brother, but without jumping to the next line when it finishes. There are many uses for this, but the most popular is to being able to ask the user a question and letting them answer on the same line:

```c#
Console.Write("What is your age?: ");
string userAge = Console.ReadLine();
```

>[!question]- Try to  Guess the Output
>The output is
>```c#
>What is your age?: __
>```
>Instead of:
>```c#
>What is your age?:
>__
>```

To see more check out the [[Write Method|Write Note!]].

---
[^1]: **Namespace** - Namespaces are used in C# **to keep one set of names separated from another**. This is done to organise the classes so that they are easy to handle. If there are two classes with the same names in different namespaces, they do not conflict with one another.
[^2]: **Class** - A class is a data structure that may contain data members (constants and fields), function members (methods, properties, events, indexers, operators, instance constructors, finalisers, and static constructors), and nested types.
[^3]: **Method** - A method is a block of code which only runs when it is called. You can pass data, known as parameters, into a method. **Methods are used to perform certain actions, and they are also known as functions**.
[^4]: **(\n)** - A special syntax that moves the console text to the next line, works like `Enter` in text editing programs.
