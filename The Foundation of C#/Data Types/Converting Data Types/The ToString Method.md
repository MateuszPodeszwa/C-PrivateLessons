Every data type variable has a `ToString()` method. What the `ToString()` method does depends on how it's implemented on a given type. However, on most primitives, it performs a widening conversion.

```c#
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();

Console.WriteLine(message);
```
```
Output: 57
```

``ToString()`` method converts anything into string data type so it could be printed and displayed, as WriteLine command only accepts strings data types. To convert int to sting place a `.ToString()` after the variable name just like in the example above.

