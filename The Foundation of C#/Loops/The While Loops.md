#While #Loop #do/while

# The While Loop

The `while` loops are the most easiest to understand, `while` loops are very straight forward as they are easy to decode. 

	A while loop repeats code over and over for as long as the the given condition eveluates to true.

The structure closely resembles an [[The IF Statement|if statement]]:

```c#
while ( condition )
{
	//This code will be executed
}
```

A `while` loop can be placed as a single statement or as a block statement, although the rules are the same as with [[The IF Statement|if statement]].

```c#
while (true)
	// This code will execute
```

The true in the parenthesis means that the condition is true and therefore it will loop forever, so called infinite loop.

## How computer handles a while loop?

Before the loop can evaluate the condition, it must be initialised (_it is worth mentioning that the loop's condition must be **bool** type_). To do it we can declare a variable and access some value to it `int x = 1`. When the `while` loop is reached, its expression is evaluated. If it is `false` it won't be executed at all. 

```c#
int x = 1;

while (x <= 5)
{
	Console.WriteLine(x);
	x++;
}
```

In the above program the loop check if the `x` value is less or equal to 5. If it is, it will print out the current `x`'s value on the screen ,and will [[Relational Operators#^70f526|increment]] the `x` by one until it no longer pass the condition.

Here are a few crucial subtleties of `while` loops keep in mind:

1. If the loop's condition is `false` initially, the loop's body will not run at all.
2. The loop's condition is only evaluated when we check it at the start of each cycle. If the condition changes in the middle of executing the loop's body, it does not immediately leave the loop.
3. It is entirely possible to build a loop whose condition never becomes `false`. For example, if we forgot the `x++` in the above loop, it would run over and over with no escape. This is called an _infinite loop_. It is occasionally done on purpose but usually represents a bug. If your program seems like it has gotten stuck, check to see if there is any infinite loop working in the background. 

This code asks the user to enter a number between 0 and 10, it keeps asking until the number is in the allowed range.

```c#
int playersNumber = -1;

while (playersNumber < 0 || playersNumber > 10)
{
	Console.Write("Enter a numbert between 0 and 10");
	string player response = Console.ReadLine();
	playersNumber = COnvert.ToInt32(playerResponse);
}
```

This code initialises `playersNumber` to `-1` to make the `while` loop run at least once, as one of the loop's condition is "as long as the player is below 0", therefore it would also work if the `playersNumber` was initialised to `11`. If we had initialised it to `0` or any number in the range ( 0 - 10 ) then the loop would't run at all. ]

# The do / while loop

The second loop type is a slight variation on a `while` loop. A `do/while` loop evaluates its condition at the end of the loop instead of the beginning. This ensures the loop runs at least once. The following code is the `do/while` version of the previous sample.

```c#
int playersNumber;

do
{
	Console.Write("Enter a number between 0 and 10: ");
	string playerResponse = Console.ReadLine();
	playersNumber = Convert.ToInt32(playerResponse);
}
while (playersNumber < 0 || playersNumber > 10)
```

The beginning of the loop is marked with a `do`. The `while` and its condition come after the loop's body. Don't forget the semicolon at the end of the line; it is necessary. Because this loop's body always at least once, we no longer need to initialise the variable to `-1`. `playersNumber` will be initialised inside the loop to whatever the player chooses.