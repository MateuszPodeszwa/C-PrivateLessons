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

# Returning and Passing Values

In this chapter you will learn that methods can share and take values from the code. 
## Passing Data to a Method

If a method needs data to do its job, it can define special variables called **parameters** to hold this data. Calling a method initialise these variables. Passing variables into a method is especially useful if a method is static and needs to work on user input, or other data from other method. Also, parameters give more flexibility. Based on above example, we can replace both `CountToTen` and `CountToTwenty` methods with a single method `Count`.

```c#
void Count(int numberToCountTo)
{
	for (int current 1; current <= numberToCountTo; current++)
	{
		Console.WriteLine(current);
	}
}
```

We initialise variable `numberToCountTo` that can be accessed and modified only inside the method's body.  We can use this parameter like any other variable, as you can see it don't have to be defined inside the method, but instead it is defined between parenthesis, after the method's name.

The calling method automatically initialises them as the call begins by placing those values, inside parenthesis.

```c#
Count(10);
Count(20);
```

The value that the calling method provides in a method call is an *argument*. The first line calls the method and sends the number (value) **10** to the `numberToCountTo` variable inside `Count` method. The second line does exactly the same, but the value is 20. You could also instead of raw data, enter a variable. For example:

```c#
int number = 10;
Count(number);
```

Above code works exactly the same, the variable's value (10) is passed into the `Count` method and then it is initialised as a `numberToCountTo`. So it would be truth if I'd say that:

	number = 20 = numberToCountTu

The only difference is that, the integer variable `number` is not accessible inside the method's body. (assuming that the method is static).

### What're benefits?

With this code, our program will count to 10 and then count to 20 afterward. This `Count` method lets us count to virtually any possible number.

We have seen this mechanic before. `Console.WriteLine` method has a value parameter. We can call this method with `'Hello World'` inside, as a value to pass to.

**Our `Count` method illustrates the key benefits of methods**:
1. **We can compartmentalise**: When we write our `Count` method, we can forget the rest of the code and focus on the narrow task of counting. Once `Count` has been created and works, we no longer need to think about how it does its job. We've brought a new high-level command into existence.
2. **We add organisation to the code**: Giving chunk of code a name and separating it from the rest of the code that uses it makes it easier to understand and manage.
3. **We can reuse it**: We can call the method as many times as we want, instead of copying and pasting the same code all over again.

### Multiple Parameters?

A method can have as many parameters as necessary, and in the matter of fact, these parameters can be different. They can be mix of any possible types such as `int`, `string`, `float`, `arrays` and many more. You could create a method that takes integer array as a input and sort it, and then prints out the results. 

Multiple parameters are defined by listing them in the parentheses, separated by commas:

```c#
void CountBetween(int start, int end)
{
	for (int current = start; current <= end; current++)
	{
		Console.WriteLine(current);
	}
}
```

Calling a method that needs multiple parameters is done by putting the values in the corresponding spots in the parentheses, separated by commas:

```c#
CountBetween(20, 30);
```

>[!warning] Keep the order!
>It is important to note that during the call of a method with multiple parameters, the order of the parameters must be kept! For example if the method defines three different parameters such as:
>```c#
>void Example(int a, int b, int c) { ... }
>```
>The call would looks like:
>```c#
>Example(a, b, c);
>```
>Where a, b, c could have different names, such as variable1, variable2 and variable3. But the order would be  a, b, c and not b, c, a or c, b, a.

>[!info]- Quick Reminder - Copied Values in Method Calls
>Assigning the value in one variable to another variable will copy contents of that variable. To illustrate it:
>```c#
>int a = 3;
>int b = a;
>b = b + 2
>```
>The answer will be `5`. This same behaviour holds for a method-call as well:
>```c#
>int number = 10;
>Count(number);
>``` 
>When `Count` is invoked, the value currently in `number` is evaluated and copied into `Count` parameter.

## Returning a value from a Method

Until now, we acknowledged that parameters let us send data over to the called method. Even if the method is **static**. But, what if our method do not produce anything else, but a simple bool, string, int etc.. value? We don't want to make the method to `Console.WriteLine` we just want to return a single value. In this case we can use something called **return method** or *non-void method*. 

>[!summary] A return value type of method?
>A return value allows a method to produce a result when it completes. We have seen return values in the past. For example, we are using the return values of the two methods below:
>```c#
>string input = Console.ReadLine();
>int number = Convert.ToInt32(input);
>```

To make a method return a value, we must do two things. First, we indicate the data type that will be returned, and second, we must state what value is returned.

```c#
int ReadNumber()
{
	string input = Console.ReadLine();
	int number = Convert.ToInt32(input);
	return number;
}
```

Instead of `void` return type of method, this method indicates that it returns an **int** upon completion. We cab then use the returned value when calling `ReadNumber`, as we have done in the past.

```c#
Console.Write("How high should I count to?: ");
int chosenNumber = ReadNumber();
Count(chosenNumber);

void Count(int numberToCountTo)
{
	for (int current = start; current <= end; current++)
	{
		Console.WriteLine(current);
	}
}

int ReadNumber()
{
	string input = Console.ReadLine();
	int number = Convert.ToInt32(input);
	return number;
}
```

### Returning Early

>[!info] Return keyword can be used the same as with IF and LOOP statements.
> It is possible to include multiple `return` keywords in one method, but at the end of the method's execution: only one return is allowed to actually return a value. 

Whenever a `return` statement is reached, the flow of execution will leave the method immediately, regardless of whatever it is the last line in the method or not. While `return` statements can go anywhere in a method, all pathways musts specify the returned value. By listing a non-void return type, you promise to produce a result. You have to deliver on that promise no matter what `if` statements and loops you encounter.

```c#
int Count()
{
	int countNumber = 0;
	// Some Code
	return countNumber;
}
```

`void` methods do not return any values, however even **void** methods can still use `return` keyword only to stop execution of the code.

```c#
void Count(int numberToCountTo)
{
	return; 
	// This code is never executed.
	for (int current = start; current <= end; current++)
	{
		Console.WriteLine(current);
	}
}
```

In C# you cannot return multiple values at one time, but there are many ways that can work around it.

# Method Overloading

Each method you create should het a unique name that describes what it does. However, sometimes you have two methods that do the same job, just with different parameters. It is commonly described as a **method overloading**.

>[!info] Method Overloading
>Two methods can have the same name only if the parameters of the copied method are distinct from the original method.

A great example is `Console.WriteLine` method, which has many overloads. That is what allows the following to work:

```c#
Console.WriteLine("Some Text");
Console.WriteLine(53);
```

The code will produce *Some Text* and *53* the number. There is simply a overload for integer and string version of `Console.WriteLine` method - this is why there is no error message.

You don't have to worry about compiler, which method it will read. Because it will figure it out based on the parameters provided. It is complex topic and I will not focus on it right now, it is called *overload resolution*.

>[!info]- Many `WriteLine` Overloads
>`Console.WriteLine` has many different overloads such as:
>	- Bool
>	- int
>	- float
>	- string
>And many, many more... The total is about 18.

Unfortunately, local functions, don't allow overloads.

# Simplifying Methods

Methods are great, they make the code to appear cleaner and more reusable. But as you delve deeper into the coding realm you will discover that many methods can even make the code more confusing and to appear longer. It is happening when you enclose a simple expressions into methods such as:

```c#
int DoubleAddOne(int value)
{
	return value * 2 + 1;
}
```

This is a simple one line expression! So why it have to take so much space? It makes the code more reusable but it also make it crazy-long. Especially when you introduce even more simple methods.

But there is a solution to this madness. If you want you can represent a method with a single expression, there is another way to write it:

```c#
int DoubleAddOne(int value) => value * 2 + 1;
```

Instead of curly braces and a `return` statement, this format uses the arrow operator `'=>'` and the expression to evaluate, followed by a semicolon. The two above versions of `DoubleAddOne` method are the same and do the same job. The only difference is in the size it takes in your code editor.

The first version has a *block body*, when the second has a *expression body*. The `'=>'` is used to indicate that an expression is coming next. We saw it with [[Switches|Switch]] expressions, and we will see it again soon.

>[!warning] Expression body limitations!
>You can only use *expression body* if the whole method can be represented in a single expression. If you need a statement or many statements, you must use block body.

