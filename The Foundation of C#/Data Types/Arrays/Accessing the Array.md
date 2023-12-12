# Accessing and Saving values in Arrays

Let's look at how to work with specific items within the array. To refer to a specific item in an array, you could use the _indexer_ operator `[ ]`. For example, this code assigns a value to spot #0 in the `scores` array.

```c#
scores[0] = 99;
```

The number in the brackets is called the _index_; the code above stores the value 99 into `scores` at index 0. This index can be any `int` expression, not just a plain number. For example, you could also do this : 

```c#
scores[someVariable + 1] = SomeValue;
```

The code will save the `someValue` variable into the `scores` array at the index of `someVariable` + 1, e.g. if `someVariable` would be equal 2 then the index would be 3 as 2 + 1 = 3. For example we can create a loop that will increment the index by one position.

	Important fact: The C# starts indexes from 0 and not 1, so the first item from the list would be at the index number 0 and not 1.

The same way we can save other variables:

```c#
scores[1] = 95;
scores[2] =  90;
```

It is also possible to use the **indexer** to read the current value in an array at a specific index:

```c#
Console.WriteLine(scores[0]);

// This code will output 99, as the value in the scores array at the index 0 is 99.
```

## Accessing the values from the end

On occasion, you want to access items relative to the back of the array instead of the front, You can use the `^` operator to do it. The code below gets the last item in the `scores`:

```c#
int lastScore = scores[^1];
```

From the front you start with **0**, but from the back, you start from *1*.

## Accessing the array from the range of indexes

It is also possible to grab a copy of a section or range within an array with the range operator `..`:

```c#
int[] firstThreeScores = scores[0..3];
```

With arrays, this makes a copy. Making a change in `firstThreeScores` will not affect the original `scores` array. 

The first number on the range is the index to start at. The second number is the index to end at, but it is *not* included in the copy. `0..3` will grab the elements at indexes `0`, `1`, and `2`, but not at 3.

These numbers can be any `int` expression, and you can also use `^` to index from the back. For example, this code makes a copy of the array except for the first and last items:

```c#
int[] theMiddle = scores[1..^1];
```

If your endpoint is before your start point, your program will crash, so you'll want to ensure that this doesn't happen.

You can also leave off 
# Crossing Array Bounds

Attempting to access an index beyond what its size supports would lead to bad and even dangerous things. C# ensures that any attempt to reach beyond the beginning or end of an array is stopped before it can happen, creating an index out-of range error that will crash your program.

```c#
int[] scores = new int[5];
scores[100] = 1000;
```

`scores` has five items, and they are numbered trough 0 to 4. Those are the only safe numbers, and the attempt to access spot `#100` will fail. The same with negative indexes.

