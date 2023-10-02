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





