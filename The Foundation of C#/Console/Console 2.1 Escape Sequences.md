#f
# Difference between WriteLine and Write.

```c#
Console.WriteLine("Hello World!");
```

The Console part is called a class. Classes "own" methods; or you could say that methods live inside of a class. To visit the method, you must know which class it's in. For now, think of a class as a way to represent an object. In this case, all of the methods that operate on your output console are defined inside of the Console class.

There's also a dot (or period) that separates the class name Console and the method name `WriteLine()`. The period is the member access operator. In other words, the dot is how you "navigate" from the class to one of its methods.

The `WriteLine()` part is called a method. You can always spot a method because it has a set of parentheses after it. Each method has one job. The `WriteLine()` method's job is to write a line of data to the output console. The data that's printed is sent in between the opening and closing parenthesis as an input parameter. Some methods need input parameters, while others don't. But if you want to invoke a method, you must always use the parentheses after the method's name. The parentheses are known as the method invocation operator.

To print an entire message to the output console, you need to use the first technique, `Console.WriteLine()`. At the end of the line, it adds a line feed similar to how to create a new line of text by pressing Enter or Return.

To print to the output console, but without adding a line feed at the end, you need to use the second technique, `Console.Write()`. So, the next call to `Console.Write()` prints another message to the same line.

# Escape character sequences.

At times, inserting quotes within a string in C# can cause errors as the language might interpret quotes **“”** as the end of the string, resulting in an error. To prevent this issue, an escape character was introduced. By combining quotes with these symbols, we can signal to the compiler that the quotes are part of the string sequence and not its conclusion.

To achieve this, we before starting and before an ending quote inside a string sequence add an escape character symbol `\` to instruct the compiler that these are part of the text.

```c#
string exampleString = "Sometimes, we need to include \"quotes\" within a string.";
```

Escape sequences can do other things using specific characters. **\n** is used to create a new line.
# String Concatenation

Sometimes, there is a need for connecting different strings and variables together into one big concatenation. To do so, we can use a `+` symbol. The connection symbol should join two strings or variables together, just like an arithmetic operation.

```c#
string nameVar = “String 1” + “String 2”;
```
	String 1 String 2

**It can be also used to connect variables with strings,**
```c#
int age = 19;

// Remember to convert int to string in order to print it.
string userAge = “The user age is: ” + age.ToString();
```

As long as the described way is correct it may seem to be a bit laborious. Therefore, C# has a feature that will allow to avoid repeatedly inserting the `+` symbol.

# String Interpolation

String interpolation provides a more readable and convenient syntax to create formatted strings. It allows us to insert variable values and expressions in the middle of a string so that we don’t have to worry about punctuation or spaces.

```c#
int id = 100

// We can use an expression with a string interpolation.
string multipliedNumber = $"The multiplied ID is {id * 10}.";

Console.WriteLine(multipliedNumber);

// This code would output "The multiplied ID is 1000."
```


# Combine verbatim literals and string interpolation.

Suppose you need to use a verbatim literal in your template. You can use both the verbatim literal prefix symbol `@` and the string interpolation `$` symbol together.

```c#
string projectName = "First-Project";

Console.WriteLine($@"C:\Output\{**projectName**}\Data");
```
```
C:\Output\First-Project\Data
```

In this example, the `$` symbol allows you to reference the **projectName** variable inside the braces, while the `@` symbol allows you to use the unescaped `\` character.

<table align="center"; width="100%">
    <thead>
	    It completes set of escape sequences is as follows:
	
        <tr>
            <th>Sequence Symbol</th>
            <th>Description</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th> \' </th>
            <td>Single quote, needed for character literals</td>
        </tr>
         <tr>
            <th> \" </th>
            <td>double quote, needed for string literals</td>
        </tr>
         <tr>
            <th> \\</th>
            <td>backslash</td>
        </tr>
         <tr>
            <th>\n</th>
            <td>New line</td>
        </tr>
         <tr>
            <th>\r</th>
            <td>Carriage return</td>
        </tr>
         <tr>
            <th>\t</th>
            <td>Horizontal tab</td>
        </tr>
         <tr>
            <th>\v</th>
            <td>Vertical tab</td>
        </tr>
         <tr>
            <th> \uxxxx</th>
            <td>Unicode escape sequence for character with hex value xxxx</td>
        </tr>
        <tr>
            <th>\Uxxxxxxxx</th>
            <td>Unicode escape sequence for character with hex value xxxxxxxx (for generating surrogates)</td>
        </tr>
    </tbody>
</table>

