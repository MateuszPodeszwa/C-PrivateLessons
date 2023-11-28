#EscapeSequences #StringConcatenation #StringInterpolation #VerbatimLiterals
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

In this example, the `$` symbol allows you to reference the **projectName** variable inside the braces, while the `@` symbol allows you to use the unescaped `\` character. This approach may be the best for styling both, the code as well as the console output, it also works very well with [[Console 2.2 Alignment & Formatting]] allowing to further format and style the text.

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

