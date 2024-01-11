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
		1. Main (the starting point method)
			1. CountToTen - the method
				1. For loop
					1. current - the variable

---

Until now, we have only seen methods that live directly in a class. For example [[WriteLine Method]] lives in **Console**, and **Main** lives in **Program**. This map shows that methods can also be defined inside other methods. 

>[!warning] Difference between **Method** and **Function** / **Local Function**
>Formally, any reusable, callable code block is a **function**, a function is also a method if it is a member of a class. So technically, **Main** is a method, but **CountToTen** is not. Functions that are defined inside of other functions are known as *local functions*. So **CountToTen** is a local function, but **Main** is not. 

A local function can live anywhere within its containing method. You could put them at the top, above your other statements, at the bottom, after your statements, or somewhere in the middle - the compiler **don't care** where they go. The compiler extracts them and gives them slightly different names behind the scenes, so it doesn't care about the ordering. Since they can go anywhere, use it as your advantage.

# Calling a Method

Our code above defined a **CountToTen** method but didn't put it to use. Let's fix that. We've called methods before, like `Console.WriteLine`, so the syntax should be familiar.

```c#
CountToTen();

void CountToTen() 
{
	for (int current = 1; current <= 10; current++)
		Console.WriteLine(current);
}
```

The most notable difference is that we didn't put a class name first, as we have done with `Console.WriteLine()`. Since **CountToTen** lives in our main method, we can refer to it without any qualifiers from anywhere in the main method.

The code runs by reading the `CountToTen()` and then the compiler remembers when it occurred, then it goes inside the referred method, and executes the code inside it. After the compiler execute the method's code, the flow of execution flows back where it encounter the method. Just like:

1. Execute the code above `CountToTen()`.
2. Meet the `CountToTen()` method and goes inside of it.
3. Execute any code found inside of `CountToTen()` method.
4. Back to the original code, start from the place you stopped.

Notably, just because the definition of **CountToTen** lives at the end of the method does not mean it will get called then. Only an actual method call will cause the method to run. A definition alone is not sufficient for that. We can, of course, call our new method more than once. Reusing code is a key reason for methods in the first place:

```c#
CountToTen();
// ( ... ) Some Code
CountToTen();
```

## Methods and Their Own Variables

Methods gets their own set of variables to work with. This gives them their own sandbox to play in without interfering with the data of another method. Multiple methods can each use the same variable name, and they won't interfere with each other. 

```c#
int current = Convert.ToInt32(Console.ReadLine());
CountToTen();
CountToTwenty();

void CountToTen()
{
	for (int current = 1; current <= 10; current++)
		Console.WriteLine(current);
}

void CountToTen()
{
	for (int current = 1; current <= 20; current++)
		Console.WriteLine(current);
}
```

`CountToTen()` and `CountToTwenty()` methods, as well as the `Main()` method - each have a `current` variable, but the three variables are distinct. Each has its own memory location for the variable and will not affect the others. This separation allows you to work on one method at a time without worrying about what's happening in other methods. You don't need to keep the workings of the entire program in your head at once.

But as you know local function actually can access other variables or data in the current function that it is nested.

```c#
string text = "some data";

void DisplayText()
{
Console.WriteLine(text); // NOT SAFE!!
}
```

Because the scope of `text` variable is the main method, and because that encompasses the `DisplayText` method, `DisplayText` can reach up to the main method and use its `text` variable. There is a place for this, but it depends of the purpose of the program. Usually programmers want's to keep everything separately, just in case to avoid bugs. Obviously, even if they are separated, there is a way to share variables between methods.

If you are worried about that, or if you want ensure that the method will be separated and won't access any out-of-scope variables, you can use `static` keyword at the front of your method definition.

>[!info] What is `static` keyword?
>With `static` on your method, if you use a variable in the containing method, the compiler will give you an error. If you are worried about accidental use of variable from outside the method, you might consider using **static** as a safety precaution.
>
>```c#
>static void CountToTen() {  ...   }
>```

# Passing Data to a Method
