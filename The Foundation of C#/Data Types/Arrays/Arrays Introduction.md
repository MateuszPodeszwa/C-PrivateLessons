---
tags:
  - Data_Types
  - Arrays
---
# What is an array?

Arrays is a collection of any values, let's take a example of a score storing system. Imagine we have 10 scores we need to store and display. To achieve this goal we can create 10 different variables and call them accordingly:

```c#
int score1 = 10;
int score2 = 4;
int score3 = 12;
int score4 = 2;

// and so on...
```

But there is much easier and better way to do it.

```
An array is like a big box that contains specified and organised spaces in which the data values are stored. It is called a *data structure*, that contains some organised values saved in strings or integers.
C# is a strict language meaning that arrays can only store one data type variables. For example integer array can store only int variables, string array can store only strings and so on.
```

Arrays can be considered as a big cabinet, the manufacturer responsible for production must know how many drawers are to be used and what size this furniture has to be. The same rule is applied in arrays. The array always contain data values (by default zeros). These data values are stored in every drawer in the cabinet. One drawer (block of memory) can contain only one value defined by the ID index. 

| 1             | 7       | 15      | 2       | 5       | 11      | 9       |
| :-----------: | :-----: | :-----: | :-----: | :-----: | :-----: | :----- :|
| Index 0       | Index 1 | Index 2 | Index 3 | Index 4 | Index 5 | Index 6 |

The above array has seven data values contained in memory blocks. Each block is organised by its index number. Arrays are characterised by having fixed space (e.g, in java). That means they have pre-set number of blocks assigned at the beginning by a creator, which cannot be changed.

Accordingly, in the cabinet example, there is no way to add more "drawers" to the cabinet. It is just physically impossible. For example. Shop wants to store information about product prices instead of declaring variables for each product, and the shop owner can create one array that will contain all product information.
The important thing to remember is that arrays always are declared by their index number which starts with 0, e.g. IND0, IND1, IND2 and so on. The only exception is Visual basic language which begins at 1.

As we know, arrays cannot be resized, it is characteristic of having fixed space. The only way to add more items to the existing array is to create a new one and all data of the old one is copied into it. Arrays use a block of memory to store information therefore the size of the created array must be known before creation.
For example,  if a number,  integer or floats and doubles typically needs 32 bits or 4 bytes of memory then the creation of an array of 10 integers would take a single block of 40 bytes of memory. Therefore, fixed-size arrays have always the same size of memory, even strings of text whether doubles or floats. Strings are stored as a reference to the memory location containing the string data and not the text itself. 

The next step is to [[Create an Array|create array]].
## Array's [[The .Length Property|.length property]]

Each array 'knows' how long it is, by referring to the array's **length** variable you can see how many items it contains.\

```c#
Console.WriteLine(scores.Length);
```

The word before the `.Length` is a variable name, in this case `scores`. This is especially useful when we don't know how big an array might be, or we are unsure. The code below asks the user for a length, creates an array of that size, then uses [[The For Loops|for loop]] to fill it with values:

```c#
// Asks user for a string input and then converts it into integer and saves to the variable.
int arrayLength = Convert.ToInt32(Console.ReadLine());
// Creates empty array with a inputed length.
int[] myArray = new int[arrayLength];

for (int index = 0 ; index < myArray.Length ; index++)
	myArray[index] = 1;
```

`for` loops are commonly used with arrays, especially [[The Foreach Loop]] which makes the calculations on arrays way easier.

