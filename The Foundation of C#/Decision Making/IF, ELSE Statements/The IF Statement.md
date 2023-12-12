#DecisionMaking 

An `if` statements will add some logic into the code allowing you to make complex decision making statements.
Let's say we need to determine a letter grade, based on a numeric score. Our grading scale is that:

- an A is 90+,
- a B is 80 to 89,
- a C is 70 to 79,
- a D is 60 to 69, and
- an F is anything else.

Just by writing it down it is easy to see how we could apply these elements, we clearly see each score maximum and minimum, based on this information we can apply this into the code. But it is not everything, because we can't just say to the program "hey! make me this!", we need to apply some logic into it. For example,

# An IF statement

We need to input the score and convert it into `int`, we need to define a variable to store the score as well as variable that store the letter grade.

As you can see, it is not that simple as just writing a simple `if` statement.  We don't have tools to decide to do one thing or another, depending on decision criteria. We need those tools to solve this problem. The `if` statement is the primary tools for doing this. 

```c#
string input = Console.ReadLine();
int score = Convert.ToInt32(input);

if (score == 100)
	Console.WriteLine("A+! Perfect Score!");
```

The `if` statement checks if the condition inside the parenthesis is true, if it is true, it will execute tho code inside of it, if not it will skip the content. Above program will run differently based on what score is typed, if the score is 100, it would display that "A+!."... text. Otherwise, it will display nothing at all.

An `if` statement is constructed using the keyword `if`, followed by a set of parenthesis containing an expression whose type is **bool**. The expression inside of the parenthesis is called an _if statement condition_.

The `'=='` operator indicates the _equality_. Or in another terms, it determines if the things on either side are equal, evaluating to **true** if they are and **false** if they are not. Based on this logic, the condition will be true only if `score == 100` (when score will be equal to 100). 

## Block statement

The simples `if` statement allows us to run a single statement conditionally. What if we need to do many statements?

We could just stick a copy of the `if` statement in front of each statement we want to protect, but there is a better way. C# has a concept called a _block statement_. A block statement allows you to lump many conditions or lines of codes together and run then use them anywhere that a single statement is valid. A block statement is made by enclosing the statements in curly braces:

```c#
{
	Console.WriteLine();
	Console.WriteLine();
}
```

An `if` statement can be applied to block statements just like a single statement.

```c#
if (score == 100)
{
	Console.WriteLine("A+!");
	Console.WriteLine("Perfect Score!");
}
```

Remember!
Only the next line of an `if` statement it guarded, the code below does not work as you would expect from the indentation:

```c#
if (score == 100)
	Console.WriteLine("A+!");
	Console.WriteLine("Perfect Score!!"); // BUG!
```

The perfect score text runs every single time. If you keep making this mistake, consider always using block statements to avoid this type of bug from the get-go.

## Block, Variables, and Scope

One thing that may be surprising about block statements is that they get their own variables. Variables created within a block cannot be used outside of the block. For example, this code won't compile:

```c#
string input = Console.ReadLine();
int score = Convert.ToInt32(input);

if (score == 100)
{
	char grade = 'A';
}

Console.WriteLine(grade); // Compiles error
```

The variable `grade` no longer exists, once you get to [[Console 2.0 Methods#WriteLine Method|Console.WriteLine]] on the last line. The `input` and `score` variables live directly in out main method, but the `grade` variable lives in the `if` block. We can use `grade` within `if` block. And, importantly, we can reach outward and use `input` and `score` as well. And therefore the identifier `grade` is only valid in the `if` block. 

If ew want to use grade outside of the method, we must declare it outside of the block:

```c#
string input = Console.ReadLine();
int score = Convert.ToInt32(input);
char grade = '?';

if (score == 100)
{
	grade = 'A';
}

Console.WriteLine(grade);
```

To make the `if` more useful, you can use the `else` statement.

![[The ELSE Statement]]

What is worth to note is that `if` statement allows yo to use any of [[Relational Operators|C# Operators]] as well as [[Relational Operators#Using a bool type in decision making|Bool data type]]. 

# Nesting IF Statements

An `if` statement is just another statement, therefore it can be nested. That means you can put an `if` inside of another `if`. Doing so is called _nesting_, for example:

```c#
if (x = true)
{
	if (x - 1 = false)
	{
		Console.WriteLine("false");
	}
	else
	{
		Console.WriteLine("true");
	}
}
else
{
	Console.WriteLine("Try again");
}
```

The logic of this nested if statements doesn't change, it still works as single if. The above code check if `x = true` if it is then checks if `x - 1 = false` if true then it prints out `false`. If not it will execute the `else` condition.
