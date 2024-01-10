---
tags: []
---

While [[Console 2.1 Escape Sequences|string interpolation]] is powerful, it is only the beginning. Two other features make string interpolation even better: **alignment** and **formatting**
# Alignment

Alignment lets user to display a string with a specific preferred width. Blank space is added before the value to reach the desired width if needed. Alignment is useful if you stricture text in a the desired width in the curly braces your expression to evaluate. 

```c#
string name1 = Console.ReadLine();
string name2 = Console.ReadLine();

Console.WriteLine($"#1: {name1, 20}");
Console.WriteLine($"#2: {name2, 20}");
```
The result will produce:
```markdown
#1:          Steve
#2:          Captain America
```

Above code reserves 20 characters for each name's display. If the length is less than 20, it adds whitespace before it to achieve the desired width.
If you want the whitespace to be after the word, use a negative number.

```c#
Console.WriteLine($"{name1, -20} - 1");
Console.WriteLine($"{name2, -20} - 2");
```
This has the following output:
```markdown
Steve                  - 1
Capitan America        - 2
```

There are two notable limitations to preferred widths. First, there is no convenient way to centre the text. Second, if the text you are writing is longer than the preferred width, it won't truncate your text, but just keep writing the characters, which will mess up your columns. You could write code to do either, but there is no special syntax to do it automatically.

# Formatting

Formatting allows user to provide hints or guidelines about how user may want to display data. Formatting is a deep subject.

Let's take an simple example, imagine a huge number - something like Fibonacci sequence or the $\pi$ number. Using the `Math.PI` the output will look like:

	3.141592653589(...)

But what if we want only the first 3, or 4 digits? Of course we could use a function to do it but there is a much simpler way!. To format something, after the expression, put a colon and then a format string, This also comes after the preferred width if you use both. This displays 3.142. It even rounds.

```c#
Cosnole.WriteLine($"{Math.PI:0.000}")
```

Any '0' in the format indicates that there must be a number to appear there even if the number isn't strictly necessary. For example, using a format string of `000.000` with the number `42` will display `042.000`.
In contrast, a `#` will leave a place for a digit but will not display a non-significant 0.

```c#
Console.Writeline($"{42:#.##}"); // Displays 42
Console.WriteLine($"{42.1234:#.##}"); // Displays 42.12
```

You can also use the `%` symbol to make a number be represented as a percent instead of a fractional value.

```c#
Console.WriteLine($"{4 / 9:0.0%}");
// Displays 44.4%
```

Several shortcut formats exist. For example, using a simple `P` for the format is equivalent to `0.00%`, and `P1` is equal to `0.0%`. 
