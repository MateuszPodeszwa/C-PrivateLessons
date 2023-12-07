#Loops #For

# The FOR Loops

The third loop type is the `for` loop. Let's return to the first example in this level: counting to 5. The [[The While Loops|while]] loop solution was this:

```c#
int x = 1;

while (x <= 5)
{
	Console.WriteLine(x);
	x++;
}
```

Out of all this code, there is only one line that does an actual work: the `Console.WriteLine` statement. The rest is loop management:

- The first line declares and initialises `x`.
- The second marks the start of the loop and defines the loop's condition.
- The fifth line moves to the next item.

This loop management overhead can be a distraction from the main purpose of the code. A `for` loop lets you pack loop management code into a single line. It is structured like this:

```c#
for (initialisation statement; condition to evaluate; updating action)
{
	// Code to execute
}
```

If we rewrite this code as a `for` loop, we end up with the following:

```c#
for (int x = 1; x <= 5; x++)
	Console.WriteLine(x);
```

The `for` loop's parentheses contain the loop management code as three statements, separated by semicolons. The first part, `int x = 1`, does any one-time setup needed to get the loop started. This nearly always involves declaring a variable and initialising it to its starting value. 

The second part is the condition to evaluate every time through the loop. A `for` loop is more like a `while` loop than a `do/while` loop - if its condition is `false` initially, the `for` loop's body will not run at all.

The final part defines how to change the variable used in the loop's condition.

	while most for loops use all three statements, any of them can be left out if nothing needs to be done. You will even occasionally encounter a loop that looks like 
	
	for (; ; ;) { . . . }
		
	to indicate a for loop with no condition and will loop forever, though the while (true) loop may be better.

