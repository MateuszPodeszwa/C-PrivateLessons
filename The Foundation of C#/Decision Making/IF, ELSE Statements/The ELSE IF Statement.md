#IF #ELSEIF #ELS

While `if`  and `else` let us choose from one of two options, the combination of both can create third and fourth options, an `else if` condition gives you a second statement to check after the initial `if` condition and before the initial `else`. 

```c#
if (score == 100)
{
Console.WriteLine("A+");
}
else if (score == 99)
{
Console.WriteLine("A-");
}
else
{
Console.WriteLine("Try Again!");
}
```

The above code will only run one of the four pathways - the one chosen will be the first from top to bottom, whose condition is true, or if non are true, then the statement under the final else is the one that runs.

And like [[The IF Statement|if statement]], [[The ELSE Statement|else statement]], and `else if` can contain a block with multiple statements if needed. The else as well as if else conditions are optional; just like how you can have a simple if that executes code only if the condition is true, you can have an `if` followed by several `else if` statements without a final `else`.