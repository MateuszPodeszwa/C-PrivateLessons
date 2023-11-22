# What is a 'type'?
<br>C# provides a standard set of built-in types. These represent **integers, floating point values, Boolean expressions, text characters, decimal values, and other types of data**. There are also built-in string and object types. These types are available for you to use in any C# program.

## Table of available types:

| **Data Type**       | **Description**             | .NET Type        | **Memory Size** |
| --------------- | ----------------------- | ---------------- | ----------- |
| **bool**            | **Boolean**                 | [**System.Boolean**](https://learn.microsoft.com/en-us/dotnet/api/system.boolean) | **1 byte**      |
| byte            | Byte                    | [System.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte)    | 1 byte      |
| sbyte           | Short Byte              | [System.SByte](https://learn.microsoft.com/en-us/dotnet/api/system.sbyte)   | 1 byte      |
| char            | Character               | [System.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char)    | 2 bytes     |
| decimal         | Decimal                 | [System.Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal) | 16 bytes    |
| **double**          | **Double**                  | [**System.Double**](https://learn.microsoft.com/en-us/dotnet/api/system.double)  | **8 bytes**     |
| float           | Float                   | [System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)  | 4 bytes     |
| **int**             | **Integer**                 | [**System.Int32**](https://learn.microsoft.com/en-us/dotnet/api/system.int32)   | **4 bytes**     |
| uint            | Unsigned Integer        | [System.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)  | 4 bytes     |
| nint            | Native Integer          | [System.IntPtr](https://learn.microsoft.com/en-us/dotnet/api/system.intptr)  | 4 or 8 bytes|
| unint           | Unsigned Native Integer | [System.UIntPtr](https://learn.microsoft.com/en-us/dotnet/api/system.uintptr) | 4 or 8 bytes|
| long            | Long                    | [System.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64)   | 8 bytes     |
| ulong           | Unsigned Long           | [System.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64)  | 8 bytes     |
| short           | Short                   | [System.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16)   | 2 bytes     |
| ushort          | Unsigned Short          | [System.UInt16](https://learn.microsoft.com/en-us/dotnet/api/system.uint16)  | 2 bytes     |                                                                               |                 |

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

	This C# program declares variables of different data types and prints their  
	values to the console.

In the C# programming language, **all arithmetic expressions are done on INTs** (INTEGER). This means that bytes would have to be promoted to an int type to perform any calculations you may perform on them (which is done by predefined conversion methods). The C# data types cover a large area of programming domain. Data types valves the kinds of values that can be stored in each variable. For example, INT can only store numbers from certain range, the same long, byte and string. And therefore, it is possible to perform, often complex calculations on a variable, as it is known what kind of data it stores - resulting in more organised code much less data type related errors.

Choosing the right data type is critical in C#, so it is vital to understand not only why but…
## What is a data type?

Data and data type lays close to each other but they are not the same thing. **Data is a value itself, but data type is a way that programming language defines how much memory to save for the value.** There are many data types in the C# to be used for different purposes. The data types can be distinguished in two main categories:

- **Value**, variables of value types directly contain their data.
- **Reference** **types**, variables in this type of store references to their data (objects) that is their point to data values stored somewhere else.

```mermaid
graph TD
A[Biology]
B[Chemistry]
A --> B
class A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z internal-link;
```


