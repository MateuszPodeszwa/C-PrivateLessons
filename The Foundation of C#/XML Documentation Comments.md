[[Methods Introduction|Methods]] are an excellent tool for building reusable code. Some code is meant to be used by many people, even worldwide, `Console` and `Convert`  are examples of that. People have written tools to dig through C# source code to automatically harvest comments connected to methods and other elements to generate documentation about their use. To allow these tools to be automatic, comments must be  written in a specific format so that the tools can find and interpret them. This is the problem XML Documentation Comments solve.

The simplest way to start using XML Documentation Comments is to go to the line immediately before a method and type three forward slashes: `///`. When you type `///`, visual studio or other IDE you use will expand that into several comments lines that serve as template for documentation comment, allowing you to fill in the details. For example, I have added a simple XML documentation comment to the `Count` method:

```c#
/// <summary>
/// Counts to the given numebr, starting at 1 and including the number provided.
/// </summary>

void Count(int number) 
{
	// The code
}
```

These documentation comments build on XML, which is why you see things written the wat they are.