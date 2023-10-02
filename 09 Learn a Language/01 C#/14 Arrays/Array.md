# C# Arrays

> Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.

To declare an array, define the variable type with square brackets:

```
string[] cars;
```

> We have now declared a variable that holds an array of strings.

To insert values to it, we can use an array literal - place the values in a comma-separated list, inside curly braces:

```
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
```

To create an array of integers, you could write:

```
int[] myNum = {10, 20, 30, 40};
```

## Access the Elements of an Array

> You access an array element by referring to the index number.

This statement accesses the value of the first element in cars:

```
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars[0]);

// Outputs Volvo
```

> `Note:` Array indexes start with 0: `[0]` is the first element. `[1]` is the second element, etc.

## Change an Array Element

To change the value of a specific element, refer to the index number:

Example 1
```
cars[0] = "Opel";
```

Example 2
```
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
cars[0] = "Opel";
Console.WriteLine(cars[0]);

// Now outputs Opel instead of Volvo
```

## Array Length

To find out how many elements an array has, use the Length property:

Example
```
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars.Length);

// Outputs 4
```

## Other Ways to Create an Array

> If you are familiar with C#, you might have seen arrays created with the new keyword, and perhaps you have seen arrays with a specified size as well. In C#, there are different ways to create an array:

```
// Create an array of four elements, and add values later
string[] cars = new string[4];

// Create an array of four elements and add values right away 
string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements without specifying the size 
string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements, omitting the new keyword, and without specifying the size
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
```

> `Note:` If you declare an array and initialize it later, you have to use the new keyword:

```
// Declare an array
string[] cars;

// Add values, using new
cars = new string[] {"Volvo", "BMW", "Ford"};

// Add values without using new (this will cause an error)
cars = {"Volvo", "BMW", "Ford"};
```

## C# Loop Through an Array

> You can loop through the array elements with the for loop, and use the Length property to specify how many times the loop should run.

The following example outputs all elements in the cars array:

```
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
for (int i = 0; i < cars.Length; i++) 
{
  Console.WriteLine(cars[i]);
}
```

## The foreach Loop

> There is also a foreach loop, which is used exclusively to loop through elements in an array:

Syntax
```
foreach (type variableName in arrayName) 
{
  // code block to be executed
}
```

The following example outputs all elements in the cars array, using a foreach loop:

Example
```
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars) 
{
  Console.WriteLine(i);
}
```

> The example above can be read like this: for each string element (called i - as in index) in cars, print out the value of i.

> If you compare the for loop and foreach loop, you will see that the foreach method is easier to write, it does not require a counter (using the Length property), and it is more readable.

## C# Sort Arrays

> There are many array methods available, for example Sort(), which sorts an array alphabetically or in an ascending order:

Example (String)
```
// Sort a string
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Array.Sort(cars);
foreach (string i in cars)
{
  Console.WriteLine(i);
}
```
Example (Integer)
```
// Sort an int
int[] myNumbers = {5, 1, 8, 9};
Array.Sort(myNumbers);
foreach (int i in myNumbers)
{
  Console.WriteLine(i);
}
```

## System.Linq Namespace

> Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace:

Example
```
using System;
using System.Linq;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] myNumbers = {5, 1, 8, 9};
      Console.WriteLine(myNumbers.Max());  // returns the largest value
      Console.WriteLine(myNumbers.Min());  // returns the smallest value
      Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
    }
  }
}
```

## C# Multidimensional Arrays

> In the previous chapter, you learned about arrays, which is also known as single dimension arrays.

> These are great, and something you will use a lot while programming in C#. 

> However, if you want to store data as a tabular form, like a table with rows and columns, you need to get familiar with multidimensional arrays.

> A multidimensional array is basically an array of arrays.

> Arrays can have any number of dimensions. The most common are two-dimensional arrays (2D).

## Two-Dimensional Arrays

To create a 2D array, add each array within its own set of curly braces, and insert a comma (,) inside the square brackets:

```
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
```

> `Good to know:` The single comma `[,]` specifies that the array is two-dimensional. A three-dimensional array would have two commas: int`[,,]`.

> `numbers` is now an array with two arrays as its elements. The first array element contains three elements: 1, 4 and 2, while the second array element contains 3, 6 and 8. To visualize it, think of the array as a table with rows and columns:

[Table](https://www.w3schools.com/c/col-row.png)

## Access Elements of a 2D Array

> To access an element of a two-dimensional array, you must specify two indexes: one for the array, and one for the element inside that array. 

> Or better yet, with the table visualization in mind; one for the row and one for the column (see example below).

This statement accesses the value of the element in the first row (0) and third column (2) of the numbers array:

Example
```
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
Console.WriteLine(numbers[0, 2]);  // Outputs 2
```

> `Remember that:` Array indexes start with 0: `[0]` is the first element. `[1]` is the second element, etc.

## Change Elements of a 2D Array

> You can also change the value of an element.

The following example will change the value of the element in the first row (0) and first column (0):

Example
```
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
numbers[0, 0] = 5;  // Change value to 5
Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1
```

## Loop Through a 2D Array

> You can easily loop through the elements of a two-dimensional array with a foreach loop:

Example
```
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

foreach (int i in numbers)
{
  Console.WriteLine(i);
} 
```

> You can also use a for loop. For multidimensional arrays, you need one loop for each of the array's dimensions.

Also note that we have to use GetLength() instead of Length to specify how many times the loop should run:

Example
```
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

for (int i = 0; i < numbers.GetLength(0); i++) 
{ 
  for (int j = 0; j < numbers.GetLength(1); j++) 
  { 
    Console.WriteLine(numbers[i, j]); 
  } 
}  
```











