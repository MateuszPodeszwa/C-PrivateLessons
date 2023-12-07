#Loops #For #While #while/do #breaks #continue
# Loops Overview 

There are many different loops in C#, for example: [[The For Loops]] and [[The While Loops]] - the most commonly used. But what is a loop? A loop is a y repeated x amount of times until the condition is true or until the user press the button, you know the idea. 

	In the simplest terms, looping is an ability to go back and repeat the code.

Loop's condition can be any `bool` expression, and we're allowed to use things like `<, !=, &&` and `||` here as well.
## Variables declared in loops

Blocks used in a loop are still just blocks, like any other block, variables declared within the loop's block are inaccessible once you leave the block. You can declare a variable inside the body of a loop, but these variables will not be accessible outside the loop's body. Also declaring variable in a loop is a bad idea, imagine having a loop with 1000 iterations and each iteration will create one and the same variable, 1000th times - pretty useless.
The variable declared outside the loop's body can be accessed and even updated inside the loop, for example, imagine a loop that will add '1' to the variable x, after 100 times the variable x would has a value of 100, - a simple countdown timer for example.

## The `BREAK` and `CONTINUE`

The `break` and `continue` statements give you more control over how looping is handled.

A `break` statement forces the loops to terminate immediately without reevaluating the loop's condition. This lets us escape a loop we no longer want to keep running. The loop's condition is not reevaluated, so it means we can leave the loop while its condition is still technically `true`.

A `continue` statement will cause the loop to stop running the current iteration, and will begin the next iteration. You can think of `continue` as "skip the rest of this loop and continue to the next pass".

The following code illustrates each of these mechanics in a simple program that asks the user for a umber ad then makes some commentary on the number before going back to the start and doing it over again:

```c#
while (true) 
{
	Console.Write("Whink of a number and type it here: ");
	string input = Console.ReadLine();

	if (input == "quit" || input == "exit")
	{
		break;
	}

	int number = Convert.ToInt32(input);

	if (number == 12)
	{
		Console.WriteLine("I don't like this number, pick another one")
		continue;
	}

	Console.WriteLine($"Yes, I like {number}");
}
```


This loop's condition is `true` and would never finish without a `break`. But if the user types `"quit"` or `"exit"` then, the `break` statement is executed. This causes the flow of execution to escape the loop and carry on to the rest of the program.

If the user enters `12`, then that `continue` statement is reached. Instead of displaying the text about the number being good, it tells the user to pick another one. The flow of execution jumps to the loop's beginning, the condition is rechecked, and loop runs again.

Most loops don't need `break` and `continue` statements. But the nuanced control is sometimes helpful.


![[The While Loops]]
![[The For Loops]]
