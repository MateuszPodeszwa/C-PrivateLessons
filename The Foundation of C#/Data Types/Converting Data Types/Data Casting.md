# Convert different data types. Explore data types casting and conversion.

There are multiple techniques to perform a data type transformation. The method heavily depends on:

- Is it possible, depending on the value, that is attempted to convert the value’s data type would throw an exception at run time?
- Is it possible, depending on the value, that attempting to change the value’s data type result in a loss of information?

There may be many reasons why a programmer may convert data types, one if them is to perform and print calculations. It is impossible to execute mathematical calculations as strings of text, and it is also impossible to print calculations as an integer, as Console. WriteLine method only accepts strings. Therefore, a conversion must be performed.

## Implicit Conversion

```c#
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");
```
```markdown
Int: 3
Decimal: 3
```

Since any int value can easily fit inside of a decimal, the compiler performs the conversion. The key to this example is this line of code:

```c#
decimal myDecimal = myInt;
```

**Implicit Conversion** is also referred as a __Widening Conversion__ – the type a conversion that allows to move the value from smaller data type _(the type that could hold less information like INT)_ to the data type that holds more information, for example long or double; this means that the conversion is lossless, and all the original data is preserved.

## Explicit Conversion

```c#
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");
```

Performing a so-called **casting** requires to surround a data type _(to what you want to convert to)_ in to brackets, then place it next to the variable that will be converted (example: (int)myDecimal). This example means that myDecimal variable that is decimal data type will be casted to integer data type.

The output:

```md
decimal: 3.14
int: 3
```

The key to this example is:

```c#
int myInt = (int)myDecimal;
```

The variable **myDecimal** holds a value that has precision after the decimal point. By adding the casting instruction **(int),** it is allowing the C# compiler to convert data types even if it means losing some of the data. As integer cannot have any decimal point, it will be just cut off.

**Narrowing Conversion** – This term describes the transition between data types of bigger value to smaller value and in the consequence the converted data may be lost.  
For example,
	integer => byte or float => integer.

Every narrowing conversion requires to use **casting** technique, cast is an instruction to the C# compiler that allows for loss conversion.

-  **Implicit Casting** (automatically) - converting a smaller type to a larger type size  
	**char -> int -> long -> float -> double.**

-  **Explicit Casting** (manually) - converting a larger type to a smaller size type  
	double -> float -> long -> int -> char.

If you want perform calculation in smaller types such as bytes, it is possible by implicitly converting byte to int just to calculate them. For example,

```c#
Short a = 2;
Short b = 3;

Short total = (short)(a + b);
```

As it is known it is impossible to do math in other type than int, therefore the short as it is smaller value will be automatically converted to int just to perform a calculation, but you forcing it to convert it back to short by casting it.

The same if you want divide two integers and heve leftover behind the dot like 2.3 but you don’t want use any convert class, because of int being smaller than double you can use

```c#
Double x = (double)(10 / 20);
```

Following the same logic, you can force 10 and 20 which might be a int variables to divide and cast it as a double so you will get a number after the dot.
Please mention as you use implicit casting on a math statement, the mathematical operation must be in the brackets ().