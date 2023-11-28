The counterpart to `if` is an `else` statement. An `else` statement allows you to specify an alternative statement to run if the `if` statement's condition is **false**. 

```c#
string input = Console.ReadLine();
int score = Convert.ToInt32(input);

if (score == 100)
{
	Console.WriteLine("A+");
}
else 
{
	Console.WriteLine("Try Again!");
}
```

When this code runs, if the score is exactly 100, the statement after the `if` executes. In all other cases, the statement after the `else` executes. You can also wrap an `else` around the block statement.

In addition to `else statement` there also is a [[The ELSE IF Statement]].
