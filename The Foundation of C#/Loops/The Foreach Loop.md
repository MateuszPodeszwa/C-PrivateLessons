Foreach loop can be considered as a way simpler and straightforward version of [[The For Loops/for loops]]. 

A foreach loop in C# is used to iterate through the elements of a collection (such as an array or a list) without explicitly specifying the start and end points. It's a concise and convenient way to work with collections. Here's a simple tutorial:

```c#
foreach (var item in collection)
{
    // Code to be executed for each item in the collection
    // 'item' represents the current element in the iteration
}
```

- The type of the variable used in the foreach loop (`var` in the examples) is determined by the type of elements in the collection.

- The collection being iterated must implement the `IEnumerable` or `IEnumerable<T>` interface.

The foreach loops are often used with [[Arrays Introduction|arrays]], [[Lists Introduction|lists]], [[Stack Introduction|stacks]] etc.. 

```c#
int[] scores = new int[10];

foreach (int core in scores)
	Console.WriteLine(score);
```

To make a `foreach` loop, you use the `foreach` keyword. Inside a parentheses, you declare a variable that will hold each item in the array in turn. The `in` keyword separates the variable from the array to iterate over. The variable can be used inside the loop, as shown above.

The downside to a `foreach` loop is that you lose knowledge about which indexes you are at-something a `for` loop makes clear with the loop's variable. `fooreach` loop also runs significantly slower than a [[The For Loops|for loop]].s