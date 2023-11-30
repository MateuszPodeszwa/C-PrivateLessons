Switches are an alternative to multi-part [[The IF Statement|if statements]]. Most `if` statements are simple: a single `if`, and `if/else` etc... But sometimes, they end up with long chains with many possible paths, especially when you nesting them. C# has a _switch_ concept, it servers the purpose of more readable `if` statement - just like a railroad with many paths. Every switch contains two properties:

1. Switch statement
2. Switch expression

# Switch Statements

To illustrate the mechanics of a switch, consider a menu system where a user picks the number from 1 - 4 of the menu item they want to activate. Just like this:

```markdown
Please pick the menu item:

1. - Home Page
2. - Contact Us
3. - Our Company
4. - About Me

Thanks!
```

It could be done by use of just `if` and `elseif` statements, but it would looks horrible as well as it wouldn't be too readable for other follows programmers. Therefore we can use a switch statement:

```c#
switch (choice)
{
	case 1:
		//Case 1 Content
		Console.WriteLine("Home Page");
	break;
	
	case 2:
		//Case 2 Content
		Console.WriteLine("Contact Us");
	break;
	
	case 3:
		//Case 3 Content
		Console.WriteLine("Our Company");
	break;
	
	case 4:
		//Case 4 Content
		Console.WriteLine("About Me");
	break;
	
	default:
		//The Default Content
		Console.WriteLine("I don't understand");
	break;
}
```

It starts with the `switch` keyword, a set of parenthesis enclose the value that decisions are based on, and curly braces denote the beginning and end of the `switch` block. For an example, if the variable `choice` were set to `'2'` then the switch statement will execute the case where its value is `'2'`.  The basic template of switch statement looks like:

```c#
switch (switch_statement)
{
	case case_expression:
	// Some code
	break;

	default:
	//default scenario if no conditions are met
	break;
}
```

Each 'arm' (case) must end with a `break` statement, The `break` signals the flow of execution should stop where it is and resume after the switch.
The `default` keyword provides a catch-all if nothing else was a match. If the user entered a different value than intended (for example, a letter E where all cases were listening form numbers), the default will be the one to be executed. Having a `default` arm is optional and not required, but it is good to have it just for the purpose of error handling. 

## Multiple cases for the same arm

While most of cases in a switch statement are independent of each other, C# does allow you to include multiple `case` statements for any given arm:

```c#
case 1:
case 2:
	Console.WriteLine("Thant's a good choice!");
	break;
```

In this case, if the value was `1` or `2`, the statements in this arm will be executed.

## Switch expressions

Switches also come in an expression format as well, in expression form, each arm is an expression, and the whole switch is also an expression.

```c#
string response;

response = choice switch
{
	1 => "Option 1",
	2 => "Option 2",
	3 => "Option 3",
	4 => "Option 4",
	_ => "Default Option"
};

Console.WriteLine(response);
```

You are creating a new string `string response` and you assigning to this string a value of switch expression 'string response = choice switch'. The `choice` variable is a user-input-kind of variable, and the switch checks if the choice is equal to 1, 2, 3, 4 etc.. and then assigns the expression to the `response` variable.

1. The switch target comes before the `switch` keyword instead of after.
2. The "case" can hold only one expression
3. Each expression must be separated with comma
4. Instead of `case` keyword there is a `'=>'`, which separates the arm's condition from its expression.
5. The `default` keyword is gone, instead there is `_` wildcard.


