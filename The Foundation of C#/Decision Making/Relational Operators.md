C# as a language supports various types of syntax operators, these operators allow to perform complex as well as shorten simple math calculations. Checking if two things are exactly the same by equality operator is undoubtedly useful, but it is not the only way to define a condition. It is one of many relational operators that check for some particular relation between values. 

For example the _inequality operator_ `!=` is just a opposite of `'=='` operator. Evaluating to `true` if the two variables are not equal and `false` if they are. So:

```c#
if (score != 0)
	Console.WriteLine("It could be worse!");
```

There are also the _greater than_ or _less than_ operators as many, many others. C# has the following arithmetic operators:

<table align="center"; width="100%">
<thead>
  <tr>
    <th align="left">Operation</th>
    <th  align="center">Operator</th>
    <th align="left">Description</th>
  </tr>
</thead>
<tbody>
  <tr>
    <td>Addition</td>
    <td align="center">+</td>
    <td>Returns the sum of two numbers</td>
  </tr>
  <tr>
    <td>Subtraction</td>
    <td align="center">-</td>
    <td>Returns the difference between two numbers</td>
  </tr>
  <tr>
    <td>Multiplication</td>
    <td align="center">*</td>
    <td>Returns the product of two numbers</td>
  </tr>
  <tr>
    <td>Division</td>
    <td align="center">/</td>
    <td>Returns the quotient of two numbers</td>
  </tr>
   <tr>
    <td>Greater than</td>
    <td align="center">></td>
    <td>Validate if the value us grater than  other value</td>
  </tr>
  <tr>
    <td>Less than</td>
    <td align="center"><</td>
    <td>Validate if the value us less than  other value</td>
  </tr>
   <tr>
    <td>Conditional OR</td>
    <td align="center">||</td>
    <td>If the first value is true then set the whole expression to true, if not check the second expression, if it is true then set whole expression to true.</td>
  </tr>
  <tr>
    <td>Bitwise AND</td>
    <td align="center">&</td>
    <td>`&` is the bitwise AND operator. For operands of integer types, it'll calculate the bitwise-AND of the operands and the result will be an integer type. For boolean operands, it'll compute the logical-and of operands. `&&` is the logical AND operator and doesn't work on integer types. For boolean types, where both of them can be applied, the difference is in the "short-circuiting" property of `&&`. If the first operand of `&&` evaluates to `false`, the second is not evaluated at all. This is not the case for `&`:</td>
  </tr>
  <tr>
    <td>Conditional AND</td>
    <td align="center">&&</td>
    <td>If the first expression is true then checks the second expression, if both are true then set the whole expression to true.</td>
  </tr>
  <tr>
    <td>The NOT Operator</td>
    <td align="center">!=</td>
    <td>Make true a false, if NOT 1 + 1 = 2 then it sets the value to false instead of true.</td>
  </tr>
  <tr>
    <td>Modulus</td>
    <td align="center">%</td>
    <td>Returns the remainder of one number divided by another. For an example, the modulus of 20 and 5 is 0 because the quotient (results of division) is a whole number. But the modulus of 56 / 12 is 8 because the quotient is 4,83 not a whole number</td>
  </tr>
</tbody>
</table>
# Unary Operators 

The ones above operate on two values. **C# also has two unary operators:**

-      **Increment**, `++`, which increments its single operand by one.
-      **Decrement**, `--`, which decrements its single operand by one.

Unlike the other arithmetic operators, the increment and decrement operators change the value of their operand as well as return a value.

```c#
int x = 5;

int y = x++; // x now equals 6, y equals 5
int z = --x; // x now equals 5, z equals 5
```

But what if you want to increment a value not by one as you would do with x++; but by 3 or more places? You could just simply write:

```c#
x = x + 3
```

but, in programming you are looking for an easiest and fastest way to execute the code, therefore there is a much shorter version of it:

```c#
x += 3
```

Which means that you will add **+ 3** into **x** and save the result into an x - just like in the code above. However, this technique also supports a large variety such as:

**1.**     **Addition**
**2.**     **Subtraction**
**3.**     **Multiplication**
**4.**     **Division**
**5.**     **Modulus**

The assignment operators of the form **op=**, where **op** is a binary arithmetic operator, is a shorthand. The expression **x = x op y**; can be shortened to **x op= y;.** This compound assignment also works with the logical operators **&, |** and **^.**

The **??=** operator assigns the value on the right to the variable on the left if the variable on the left is null.

On a computer there are two approaches to division, Mathematically, 5 / 2 is 2.5. If a, b, and result were all floating points types, that’s what would happened. This division style is called **floating-point division** because it is what you get.

The other option is **integer division**, when you divide with any of the integer types, fractional bits of the results are dropped. This is different from rounding; even 9 / 10 is 0.9, becomes a simple 0. The code above uses integers and so it uses integer division, 5 / 2 becomes 2 instead 2.5.
# Using a bool type in decision making

As it is known a [[Bool]] can hold only two possible values, true or false. But this is not the end of its capabilities, bool data type can be used in [[The IF Statement|IF statements]] allowing for creation even more complex statements - the conditions of an `if` and [[The ELSE IF Statement|else if]] do not just have to be one of these operators. You can use any `bool` expression. Just like in this example:

```c#
int score = 45; // This can change based on the user input
int pointNeedToPass = 100;

bool levelComplete;

if (score >= pointsNeetToComplete)
{
	levelComplete = true;
}
else
{
	levelComplete = false;
}

if (levelComplete) // It will indocate that the if statement will be true only if the bool is true.
{
	Console.WriteLine("You Pass!");
}
```

Using the basic bool principles it is possible to shorten this code to:

```c#
bool levelComplete = score >= pointsNeedToPass

if (levelComplete)
	Console.WriteLine("You Pass!");
```

The above code make also a good use of relational operators such as `>=` _equal or bigger than_ in a bool expression, if the condition is meet than the bool turns `true`. The above code is not only smaller but also easier to understand. But what if we connect logical operators with bool type? For example, the first of these is the `not` operator `!`. This operator takes a single thing as inout and produces the Boolean opposite: `true` becomes `false` and vice versa. 

```c#
bool levelComplete = score >= pointsNeedToPass;

if (!levelComplete)
	Console.WriteLine("Level Completed");
```

The if statement in the above code checks if the `levelComplete` variable is false. Normally it would check the variable `true`value, but because of the operator `not` it does the opposite. The other two operators are used more often together to create a complex if statements. The `and` operator `&&` and the `or` operator `||`. These two operators allow you to combine two `bool` expressions into a compound expression. 
- For `&&` the expression is true if both sub-expression are also true.
- For `||` the expression is true if one of the sub-expression is true, it is also true if both are true. It does not matter which one is, as long is it is, it will be true. One important fact: If the first expression is true, the compiler won't check the other sub-expression.

```c#
if (50 <= 0 && 20 <= 0)
	Console.WriteLine();
```

The code will execute `Console.WriteLine` only when both conditions `50 <= 0 && 20 <= 0)` will be true. It can be read as; "_if 50 is lower or equal to 0 AND 20 is lover and equal to 0 THEN DO writeline"_. The `||` is similar, but if either sub-expression is true, the whole expression is true. 

```c#
if (50 > 0 || armor > 0)
	Console.WriteLine();
```

This code can be read as: _"if 50 is more than 0 THEN writeline OR if armor is more than 0 THEN writeline"_. These expressions can be mixed together to create much complex one.