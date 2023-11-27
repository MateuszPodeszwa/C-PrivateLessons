###### #introduction #csharp #basics #DOTNET
# What is a 'type'?
<br>C# provides a standard set of built-in types. These represent **integers, floating point values, Boolean expressions, text characters, decimal values, and other types of data**. There are also built-in string and object types. These types are available for you to use in any C# program.

## Table of available types:

<table align="center"; width="100%">
    <thead>
        <tr>
            <th>Data Type</th>
            <th>Description</th>
            <th>.NET Type</th>
            <th>Memory Size</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th>bool</th>
            <td>Boolean</td>
            <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.boolean">System.Boolean</a></td>
            <td>1 byte</td>
        </tr>
        <tr>
            <th>byte</th>
            <td>Byte</td>
            <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.byte">System.Byte</a></td>
            <td>1 byte</td>
        </tr>
        <tr>
            <th>sbyte</th>
            <td>Short Byte</td>
            <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.sbyte">System.SByte</a></td>
            <td>1 byte</td>
        </tr>
        <tr>
            <th>char</th>
            <td>Character</td>
            <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.char">System.Char</a></td>
            <td>2 bytes</td>
        </tr>
        <tr>
            <th>decimal</th>
            <td>Decimal</td>
            <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.decimal">System.Decimal</a></td>
            <td>16 bytes</td>
        </tr>
        <tr>
            <th>double</th>
            <td>Double</td>
            <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double">System.Double</a></td>
            <td>8 bytes</td>
        </tr>
        <tr>
            <th>float</th>
            <td>Float</td>
            <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.single">System.Single</a></td>
            <td>4 bytes</td>
        </tr>
        <tr>
            <th>int</th>
            <td>Integer</td>
            <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.int32">System.Int32</a></td>
            <td>4 bytes</td>
        </tr>
        <tr>
            <th>uint</th>
            <td>Unsigned Integer</td>
            <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.uint32">System.UInt32</a></td>
            <td>4 bytes</td>
        </tr>
        <tr>
            <th>nint</th>
            <td>Native Integer</td>
            <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.intptr">System.IntPtr</a></td>
            <td>4 or 8 bytes</td>
        </tr>
        <tr>
            <th>unint</th>
            <td>Unsigned Native Integer</td>
            <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.uintptr">System.UIntPtr</a></td>
            <td>4 or 8 bytes</td>
        </tr>
        <tr>
            <th>long</th>
            <td>Long</td>
            <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.int64">System.Int64</a></td>
            <td>8 bytes</td>
        </tr>
        <tr>
            <th>ulong</th>
            <td>Unsigned Long</td>
            <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.uint64">System.UInt64</a></td>
            <td>8 bytes</td>
        </tr>
        <tr>
            <th>short</th>
            <td>Short</td>
            <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.int16">System.Int16</a></td>
            <td>2 bytes</td>
        </tr>
        <tr>
            <th>ushort</th>
            <td>Unsigned Short</td>
            <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.uint16">System.UInt16</a></td>
            <td>2 bytes</td>
        </tr>
    </tbody>
</table>

## Examples of usage:

```c#
using System;

class Program
{
    static void Main()
    {
        // Examples of selected data types
        bool isOpen = true;
        byte age = 45;
        sbyte temperature = 58;
        char grade = 'A';
        decimal numberOfAtoms = 1493867940.23M;
        double weightOfHippos = 243906.12;
        float heightOfGiraffe = 908.32F;
        int seaLevel = -24;
        uint year = 2023U;
        nint pagesInBook = 412;
        nuint milestoneNewYork = 2597;
        long circumferenceOfEarth = 25000L;
        ulong depthOfOcean = 28000UL;
        short tableHeight = 4;
        ushort treeBranches = 33;

        // Displaying the values
        Console.WriteLine($"Is Open: {isOpen}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Temperature: {temperature}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Number of Atoms: {numberOfAtoms}");
        Console.WriteLine($"Weight of Hippos: {weightOfHippos}");
        Console.WriteLine($"Height of Giraffe: {heightOfGiraffe}");
        Console.WriteLine($"Sea Level: {seaLevel}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Pages in Book: {pagesInBook}");
        Console.WriteLine($"Milestone New York: {milestoneNewYork}");
        Console.WriteLine($"Circumference of Earth: {circumferenceOfEarth}");
        Console.WriteLine($"Depth of Ocean: {depthOfOcean}");
        Console.WriteLine($"Table Height: {tableHeight}");
        Console.WriteLine($"Tree Branches: {treeBranches}");
    }
}
```

	This C# program declares variables of different data types and prints their  values to the console.

In the C# programming language, **all arithmetic expressions are done on INTs** (INTEGER). This means that bytes would have to be promoted to an int type to perform any calculations you may perform on them (which is done by predefined conversion methods). The C# data types cover a large area of programming domain. Data types valves the kinds of values that can be stored in each variable. For example, INT can only store numbers from certain range, the same long, byte and string. And therefore, it is possible to perform, often complex calculations on a variable, as it is known what kind of data it stores - resulting in more organised code much less data type related errors.

Choosing the right data type is critical in C#, so it is vital to understand not only why but…

# What is a data type?

Data and data type lays close to each other but they are not the same thing. **Data is a value itself, but data type is a way that programming language defines how much memory to save for the value.** There are many data types in the C# to be used for different purposes. The data types can be distinguished in two main categories:

- **Value**, variables of value types directly contain their data.
- **Reference** **types**, variables in this type of store references to their data (objects) that is their point to data values stored somewhere else.
- 
## Integral Types

An integral type is **a simple value type that represents whole numbers with no fraction** just like INTEGER (INT) e.g., _-5, - 7, 0, 32, 1, 5_ etc. We can distinguish two main categories of integral types:

1.     **Signed**, capable of representing negative and positive integers.
2.     **Unsigned**, capable of representing only non-negative integers.

**To check the maximum and minimum value of a datatype** that it can access we can use C#
- _MinValue_, and
- _MaxValue_ for example, **float.MaxValue**.

<hr width="30%" align="center">

Because floating-point types can hold large numbers with precision, their values can be represented using "**E notation**", which is a form of scientific notation that means "*times 10 raised to the power of.*"

So, a value like **5E+2** would be the value **500** because it's the equivalent of

	5 * 10^2, or 5 x 102.

The **x** symbol is not one on a keyboard so for decades, scientists have written a number like **6.022x1023 as 6.022e23**, where the **e** stands for “**exponent**”.

When humans write a long number like **1,000,000,000**, we often use a separator like comma to make interpreting the number easier. While we can’t use the comma for than in C#, there is an alternative: the underscore character.

```c#
Int bigNumber = 1_000_000_000;
```

It is very often a fact that C# programmer operates on **aliases**, the simple value types like INT are just a shortened name of a value type defined in the .NET Class Library as **System.Int32**.

## Binary and hexadecimal literals

So far the integer literals we have written have all been written using base 10, the normal 10-digit system humans typically use. But in the programming world, it is occasionally easier to write out the number using either **base2** (*binary*) or **base 16** (*hexadecimal*).

To write a **binary** literal, start your number with a ``0b.`` For example: ``0b00001101``
For **hexadecimals**, start number with ``0x.`` Just like: ``0xFF00FF``

## Double, float, decimal

Creating variables of those types is the same as any other type, but it gets more interesting. If a number literal contains a decimal point, it becomes a double literal instead of an integer literal. Appending an f or F onto the end makes it a float. Appending an m or M onto makes it into a decimal literal.

- **Double** number = ``3.23``.
- **Float** number = ``3.23f``;
- **Decimal** number = ``3.23m``;

The double and float types (*but not decimal*) also define a value for positive and negative infinity called **PositiveInfinity** and **NegativeInfinity**. Many computers use the infinity symbol used also in math, but some of the older systems may use the 8 number to represent the infinity symbol.

Double and float also define a value called **NAN** or **Not a number**, *NaN* is used when a computation results  in an impossible value, such as division by 0.

Sometimes you may encounter a U or UL at the end of **ulong**, **long**, ushort **etc**. types. A "U" signifies that it is **unsigned** and must be either **unit** or **ulong**. A "L" indicates that the literal must be a **long** or a **ulong**, depending on the size. A "UL" indicates that it must be a **ulong**. These suffixes can be uppercase or lowercase ab dub either order. However, avoid using a lowercase l because it may look like a 1.

## Reference Types

Reference type include:

- Arrays,
- Classes, and
- Strings.

Reference types are different from value types, regarding the way values are stored when the application is executing. Usually, a **value type variable** stores its data directly in an area of storage called `stack` - a specific memory allocated to the code that is currently running on the CPU. When the stack frame has finished executing values in the stack are removed.

**A reference type variable** stores its values in a separate memory region called the `heap` - a memory area that is shared across many applications running on the operating system simultaneously.

The .NET Runtime communicates with the OS to determine what memory addresses are available and requests an address where it can store the value. The .NET Runtime stores the value, and then returns the memory address to the variable. When the code uses the variable, the .NET Runtime seamlessly pokes up the address stored in the variable and gets the value that is stored there.

### Define a reference type, array!

To define a reference type variable in C# we can use arrays (with are many from available choices):

```c#
Int[] data;
```

At this point data is not a variable, well not defined one. It is much like a reference or rather a memory address of a value in the **heap**.
Because it is not pointing to a memory address, it is called a null reference.

To define a variable and assign a value you can use.

```c#
Int[] data;
Data = new int[3];
```

The new keyword informs .NET Runtime to create an instance of INT array, and then coordinate with the operating system to store the array sized for three int values in memory (`Int[3]` – _the array will be 3 int values length as array size must be assigned before array can be defined_).

The .NET Runtime compiles and returns a memory address of the new INT array. Finally, the memory address is stored in the variable data and the INT array’s elements default to the value 0 because it is the default of an INT.

The coding is about simplifying and compressing algorithms, therefore as two lines may look like not too much code it is always better to keep it in single line.

It is possible to do both, to do so, declare a variable and create a new Instance of the int array.

```c#
Int[] data = new int[3];
```

### The string data type

The string data type is also a reference type, it may seem confusing as there is no new operator used when declaring a string. This is purely a convenience afforded by the designers of C#.

Because the string data type is used so frequently you can use this format.

```c#
String shortenedString = “hello world”;
```

Behind the scenes a new instance of ``System.String`` is created and initialised.

# How do you choose the right data type?

If we are talking about text the answer is just one a string. But what about numeric data types? Your choice of a data type can help to set the boundaries for the size of the data you might store in that variable.

For example, if you know a particular variable should only store a number between 1 and 10,000 otherwise it is outside of the boundaries of what would be expected, you will likely avoid `byte` and `sbyte` since their ranges are too low. You wouldn’t also need `int`, `long`, `uint` and `ulong` because they can store more data that is necessary. Likewise, you would probably skip `float`, `double`, and `decimal` if you didn’t need fractional values. You might narrow it down to **short** and `ushort` of which both may be workable.

If you are confident that a negative value would have no meaning in your application you might choose `ushort` _(positive unsigned integer, 0 to 65,535)_. Now any value assigned to a variable `ushort` outside of the boundary of 0 to 65,535 would throw an exception, thereby subtly helping you enforce a degree of sanity checking in your application. 

## How to choose the correct data type?

	** Fit the data, and not to optimise performance **.

-  **Choose data type based on the input and output I/O -** In the example of designing an application that calculates of a span of years between to dates. Since the application is a business application, you might determine that you only need a range from 1960 to 2200.
You might think to try work with `byte` since it can represent numbers between 0 and 255. But, when you look at the built-in methods on the `System.TimeSpan` and `System.DateTime` classes, you realise they mostly accept values of type double and int. If you choose `sbyte` you will constantly be casting back and forth between `sbyte` and double or int. In this case, it might make more sense to choose int if you don’t need sub second precision, and double if you do need sub second precision.

-  **Choose data types based on impact to the system** - sometimes, you must consider how the information will be consumed by other applications or other systems like a database. For example, SQL Server's type system is different from C#'s type system. As a result, some mapping between the two must happen before you can save data into that database. If your application's purpose is to interface with a database, then you would likely need to consider how the data is stored and how much data is stored. The choice of a larger data type might impact the amount (and cost) of the physical storage required to store all the data your application will generate.

-  **Stick to the basics**, the best way is to keep everything simple to avoid issues. The normal program should include types such as `int`, `decimal`, `bool`, `string`.