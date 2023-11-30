#ConditionalOperator #TernaryOperator #Ternary
# The Conditional Operator

The ternary operator allows for a compact syntax in the case of binary decisions. Like an [[The IF Statement|if...]] or [[The ELSE Statement|else..]] statement, it evaluates a single condition and executes one expression if the condition is true. It operates on three different expressions:

1. a condition to check a `bool` expression
2. The first `if` condition to be evaluated if true
3. The second `else` condition to be evaluated if false

The ternary operator should be always assigned to a variable, just like: `variable = condition expression ? expression if true : expression if false`. As you noticed to create a conditional expression the `?` and `:` symbol has been used.
The first a question mark symbol divides the area between conditional expression and true/false. And the double dot symbol divides area between true and false expressions. 
``
```c#
string textToDisplay = score > 50 ? "You Pass" : "Nope, Nope, Nope";
Console.WriteLine(textToDisplay);
```

If the `score` is bigger than 50 then assign a value `"You Pass"` to the variable `textToDisplay` if not then assign `"Nope, Nope, Nope"`. 
## Why Ternary?

One might wonder, "Why bother with ternary operators when we have the trusty `if-else` statements?" Well, the ternary operator shines in situations where brevity and clarity are paramount. It condenses simple conditional assignments into a single line, making the code more readable and reducing verbosity.

## Practical Example and Nesting

Let's illustrate the power of the ternary operator with a practical example. Consider a scenario where we want to determine a direction based on coordinates `x` and `y`. Here's how we can leverage the ternary operator:

```c#
string message = x < 0 ? (y > 0 ? "NW" : (y == 0 ? "W" : "SW"))
                        : (x == 0 ? (y > 0 ? "N" : (y == 0 ? "We are under the attack!" : "S"))
                                  : (x > 0 ? (y > 0 ? "NE" : (y == 0 ? "E" : "SE"))
                                          : "error"));

```

Nesting conditions within a single ternary operator is a technique that allows you to handle more complex scenarios where multiple conditions need to be evaluated. This approach maintains the concise nature of the ternary operator while accommodating additional layers of logic.

Let's break it down step by step:

1. **Outermost Condition (`x < 0`):** If `x` is less than 0, we move to the first set of expressions.
	
1. **First Nested Condition (`y > 0`):** If `y` is greater than 0, the message is "NW." If not, we move to the next nested condition.
    
3. **Second Nested Condition (`y == 0`):** If `y` is equal to 0, the message is "W." If not, the message is "SW."

The same structure repeats for the other cases (`x == 0` and `x > 0`), each with its set of nested conditions.

**Advantages of Nesting:**

- **Conciseness:** Despite the multiple conditions, the code remains concise and doesn't introduce the bulkiness of traditional `if-else` statements.
    
- **Readability:** Nesting allows you to maintain a clear structure, making it easier to follow the flow of logic.

**Considerations:**

- **Clarity vs. Complexity:** While nesting can enhance clarity, be cautious not to overcomplicate the logic. If the conditions become too complex, it might be more readable to use traditional `if-else` statements.
    
- **Error Handling:** Ensure that each nested condition contributes to the desired outcome, and handle potential errors appropriately.

### How to nest?

Let's create a fictional scenario where we want to determine a person's activity based on the time of day and weather conditions.

```c#
int hour = 14; // Assume it's 2:00 PM
bool isSunny = true;

string activity = hour < 12
    ? isSunny
        ? "Morning jog"
        : "Indoor activities"
    : hour < 18
        ? isSunny
            ? "Afternoon picnic"
            : "Visit the museum"
        : "Evening movie";

Console.WriteLine($"Recommended activity: {activity}");
```

The syntax for nested ternary operators involves multiple `?` and `:` to create a hierarchical structure:

```c#
condition1 ? expression_if_true1 : condition2 ? expression_if_true2 : expression_if_false2;
```

#### Rules for Nested Ternary Operators:

1. **Logical Structure:**

    - Each `?` starts a new ternary operator, and it is associated with the most recent `:` before it. This creates a logical hierarchy where the expressions are evaluated based on the preceding conditions.
2. **Evaluation Order:**
    
    - Ternary operators are evaluated from left to right. Each `?` is associated with the most recent `:` before it, creating a sequence of conditional checks.
3. **Simplifying Conditions:**
    
    - Nested ternary operators allow for concise expressions when dealing with multiple conditions. They can replace the need for separate `if-else` constructs, making the code more compact.

#### Example Explanation:

In the given example:

```c#
string activity = hour < 12 ? isSunny ? "Morning jog" : "Indoor activities" : hour < 18 ? isSunny ? "Afternoon picnic" : "Visit the museum" : "Evening movie"; // if the time is less than 12
```

- The outermost condition is `hour < 12`. If true, it evaluates the first set of expressions; otherwise, it moves to the next set of conditions.
    
- The first nested ternary operator (`isSunny ? "Morning jog" : "Indoor activities"`) is associated with the outermost `:`. If `isSunny` is true, it's "Morning jog"; otherwise, it's "Indoor activities."
    
- The second outermost condition (`hour < 18`) follows a similar structure. If true, it evaluates the next set of expressions; otherwise, it moves to the else part.
    
- The second nested ternary operator (`isSunny ? "Afternoon picnic" : "Visit the museum"`) is associated with the second `:`. If `isSunny` is true, it's "Afternoon picnic"; otherwise, it's "Visit the museum."
    
- The final `: "Evening movie"` is the else condition for the outermost ternary operator.

#### Why Multiple Question Marks:

The multiple question marks denote the beginning of each new ternary operator within the nested structure. Each `?` is associated with the conditions specified before it and determines which expression to evaluate based on those conditions.

In summary, the use of multiple question marks in nested ternary operators creates a compact and readable way to express conditional logic with multiple branches. Each `?` corresponds to a specific condition, and the associated expressions are evaluated based on the preceding conditions and `:` separators.
### Nesting for Clarity

The key to mastering ternary operators is understanding how to nest them effectively. The nested structure ensures that the correct value is assigned based on the conditions. Remember, readability is paramount, so don't shy away from nesting when it enhances clarity.
## When to Use Ternary Operators

While ternary operators are fantastic for concise and straightforward conditions, it's essential to use them judiciously. Complex conditions or scenarios requiring multiple statements are better suited for traditional `if-else` constructs.