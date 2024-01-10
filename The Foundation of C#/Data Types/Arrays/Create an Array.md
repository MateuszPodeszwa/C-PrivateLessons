---
tags:
  - Data_Types
  - Arrays
---
# How to create arrays?

To create empty array the first and most important is to think about the array size, and a name that will briefly describe what is the purpose of selected array. And the array can be created by using following code:

```c#
int[] scores;
```

1. The square brackets **[ ]** indicate that this variable contains an array of many values rather that just a single one. Square brackets are a common sight when working with arrays.

2. Each array contains only elements of a specific type. The above was an array of **int**s, indicated by `int[]`. You could also call it an int array. It is very similar to creating a variable, the first you provide the type, and after the variable's (array's) name.

## Defining the array

After declaring an array variable, the next step is to construct a new array to hold our items, this is just like a declaring a variable, we can declare a variable but it can be empty if we not provide any data into it. The same with arrays, the `scores` is just empty integer array. To do so we can use:

```c#
int[] scores = new int[10];
```

The `new` keyword creates new things in your program. For the built-in types like `int` and `bool`, the C# language has simple syntax for creating new values: literals like 3, true and "hello". 

1. The `new` struct makes the computer to allocate required amount of memory for the arrays to store the values.

2. The `int[]` - the one that is after the equal `[ = ]` symbol must be the same as the type of declared array for example, we cannot assign string values into the int array the code below won't work:

```c#
int[] scores = new string[10];
```

3. The number of `10` in `int[10]` informs compiler that the array will hold exactly 10 values, if we try to save 11th - the compiler will produce an error. Therefore, this is important to make sure that the array will have enough space to hold all the data.

### Another way to create arrays with predefined values

Above way it just one of the many available methods of creating arrays, if you know what values you want your array to hold initially, you can use this alternative:

```c#
int scores = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
```

Each value is listed, separated by commas, and enclosed in curly braces. This scheme is called _collection initialiser syntax_. The number of items and the length you have listed mist match each other, but if you list all of items, you can also skip stating the length in the first place:

```c#
int[] scores = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
```

If the type of values listed is clear enough for the compiler to infer the type, you don't even need to specify the type when defining an array:

```c#
int[] scores = new {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
```

We could have made this array any size we want, but once an array has been constructed, it can no longer change size. You cannot extend or shrink it. The contents of `scores` cannot be resized. However, we can use `new` a second time to create a second array with more items. We could update `scores` with this new array:

```c#
scores = new int[20];
```

This is a brand new array using new memory for its contents. The `scores` variable switches to use this new memory instead of the old one. That means any data we may have put in the original 10-item array is still over there, not in this new s20-item array. If we wanted that data in the new array, we would need to copy it over.

To save and access the values in the array see: [[Accessing the Array]]
## Default Values

If you're telling the computer to create an array called `newArray` with enough space to store 100 integers. The cool part is, you don't have to manually fill in each of these 100 slots with values.

```c#
int[] newArray = new int[100];
```

If you don't explicitly assign values to every slot, the compiler steps in. It automatically puts default values like null, false, or 0 (depending on the type of the array) in the empty slots. This can save you the hassle of initialising each element one by one.