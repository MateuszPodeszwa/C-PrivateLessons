#ConditionalOperator
# The Conditional Operator

The ternary operator allows for a compact syntax in the case of binary decisions. Like an [[The IF Statement|if...]] or [[The ELSE Statement|else..]] statement, it evaluates a single condition and executes one expression if the condition is true. It operates on three different expressions:

1. a condition to check a `bool` expression
2. The first `if` condition to be evaluated if true
3. The second `else` condition to be evaluated if false

The ternary operator should be always assigned to a variable, just like: `variable = condition expression ? expression if true : expression if false`. As you noticed to create a conditional expression the `?` and `:` symbol has been used.
The first a question mark symbol divides the area between conditional expression and true/false. And the double dot symbol divides area between true and false expressions. 

```c#
string textToDisplay = score > 50 ? "You Pass" : "Nope, Nope, Nope";
Console.WriteLine(textToDisplay);
```

If the `score` is bigger than 50 then assign a value `"You Pass"` to the variable `textToDisplay` if not then assign `"Nope, Nope, Nope"`. 