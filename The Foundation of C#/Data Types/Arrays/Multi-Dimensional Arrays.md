# What is what?

**A two-dimensional array** can be defined as a 2D square with a grid structure. As we know it from the math field, the grid structure square is nothing else than a chart or graph with X and Y.
For example, the chest board has two values 1-9 and A-H. But the 2D array is exactly the same as the 1D array, despite having two values. The two-dimensional array can be declared depending on the language used.

**A multi-dimensional array** can be represented as a three, four, five, or seven-dimensional array; the point is you can create as many dimensions as you want just by analogically extending the code. One of the significant drawbacks of multi-dimensional arrays is the increased power consumption; as the number of dimensions increases, so too will the amount of memory space required. A three-dimensional array can be considered a 3D square, which means a cube. In a 3-D array, it is possible to move not only on the X and Y axes but also on Z. Excellent example of a 3D array can be a rubric cube.

# The array of arrays

But that's not everything, imagine you have following matrix of numbers:

```markdown
[ 1 	2 ]
[ 3 	3 ]
[ 5 	6 ]
```

You could present this structure and the content with something like this:

```c#
int[][] matrix = new int[3][]

matrix[0] = new int[] { 1, 2 };
matrix[1] = new int[] { 3, 3 };
matrix[2] = new int[] { 5, 6 };

Console.WriteLine(matrix[0][1]); // Prints number 2
```

The setup for an array of arrays is ugly because each array within the main array must be initialised independently. Arrays of arrays are most often used when each of the smaller arrays needs to be a different size. This sometimes referred to as a _jagged array_.

