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

Our definition of `CountToTen` above puts it inside of the main method. The code map below illustrates this arrangement:

1. Console Application
	1. Program
		1. Main
			1. CountToTen
				1. For loop
					1. current variable

---

Until now, we have only seen methods that live directly in a class. For example [[WriteLine Method]] lives in **Console**, and **Main** lives in **Program**. This map shows that methods can also be defined inside other methods. 

>[!warning] Difference between **Method** and **Function** / **Local Function**
>Formally, any reusable, callable code block is a **function**, a function is also a method if it is a member of a class. So technically, **Main** is a method, but **CountToTen** is not. Functions that are defined inside of other functions are known as *local functions*. So **CountToTen** is a local function, but **Main** is not. 

A local function can live anywhere within its containing method. You could put them at the top, above your other statements, at the bottom, after your statements, or somewhere in the middle - the compiler **don't care** where they go. The compiler extracts them and gives them slightly different names behind the scenes, so it doesn't care about the ordering. Since they can go anywhere, use it as your advantage.



