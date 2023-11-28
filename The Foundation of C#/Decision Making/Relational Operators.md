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
    <td>Modulus</td>
    <td align="center">%</td>
    <td>Returns the remainder of one number divided by another. For an example, the modulus of 20 and 5 is 0 because the quotient (results of division) is a whole number. But the modulus of 56 / 12 is 8 because the quotient is 4,83 not a whole number</td>
  </tr>
</tbody>
</table>

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

The above code make also a good use of relational operators such as `>=` _equal or bigger than_ in a bool expression, if the condition is meet than the bool turns `true`. The above code is not only smaller but also easier to understand.