# Convert a string to an int using the Parse() helper method.

Most of the numeric data types have a **Parse()** method, which converts a string into the given data type. In this case, the **Parse()** method is used to convert two strings into int values, then add them together.

```c#
string first = "5";
string second = "7";

int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);
```
	Output: 12

What if either of the variables **first** or **second** are set to values that can't be converted to an int? An exception is thrown at runtime. The C# compiler and runtime expects you to plan and prevent "illegal" conversions. You can mitigate the runtime exception in several ways – this is one of the disadvantages of this method, what if the input is a Console.ReadLine() and you can’t control user input?

The easiest way to mitigate this situation is by using [[The TryParse Method|TryParse()]], which is a better version of the **Parse()** method.

The `Parse()` method converts whatever **string** **data** **type** it contains in the brackets to whatever data type is assigned (before the dot) to it. For example:

```c#
Int.Parse(first) //It will convert the “first” variable into INT data type.
```