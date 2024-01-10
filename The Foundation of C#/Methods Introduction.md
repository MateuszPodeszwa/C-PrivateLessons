---
tags:
  - Methods
---

>[!tip] Quick Speedrun!
>	1. Methods let you name and reuse a chunk of code:
>	`void CountToTone() { ... }`
>	
>	2. Parameters allow a method to work with different data each time it is called:
>	`void CountTo(int amount) { ... }`
>	
>	3. Two methods can have the same name (an overload) if their parameters are different.
>	
>	5. Some simple methods can be defined with an expression body:
>	`int GetNumber() => 2`
>	
>	6. Recursion is when a method calls itself. 

# Defining a Method

To make a new method, we need to understand where and how to make a method. The following code illustrates one way to do it:

```c#
Console.WriteLine("Hello, World!");

void CountToTen()
{
	for (int current = 1; current <= 10; current++)
		Console.WriteLine(current);
}
```

The line that says `void CountToTen()`, the curly braces, and everything inside them defines a new `CountToTen` method.

For the moment, let's focus on that `void CountToTen()` line. This line **declares** or creates a method and establishes how to use it. **CountToTen** is the method's name. Like variables, you have a lot of flexibility on naming your methods, but most C# programmers will use **UpperCamelCase** for all methods names.

The `void` part, before the name, is the method's *return type*. Which means that the **void** methods will not return any values, or differently: the method does not produce a result.

Every method declaration includes a set of parentheses containing information for the method to use. **CountToTen** doesn't need any information to do its job, so we've left the parentheses empty for now. For example, the method do not take any value to count to ten, it just does its job.

After the declaration is the method's body, containing all the code that should run when called. In this case, the body is the curly braces and all statements in between. You can include any C# code inside methods.

## Local Functions

Our









