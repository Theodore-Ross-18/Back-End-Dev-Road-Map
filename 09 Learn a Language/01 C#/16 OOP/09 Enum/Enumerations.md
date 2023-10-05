# C# Enum

> Enums

> An enum is a special "class" that represents a group of `constants` (unchangeable/read-only variables).

To create an enum, use the enum keyword (instead of class or interface), and separate the enum items with a comma:

Example
```
enum Level 
{
  Low,
  Medium,
  High
}
```

You can access enum items with the dot syntax:

```
Level myVar = Level.Medium;
Console.WriteLine(myVar);
```

> Enum is short for "enumerations", which means "specifically listed".

## Enum inside a Class

> You can also have an `enum` inside a class:

Example
```
class Program
{
  enum Level
  {
    Low,
    Medium,
    High
  }
  static void Main(string[] args)
  {
    Level myVar = Level.Medium;
    Console.WriteLine(myVar);
  }
}
```
The output will be:
```
Medium
```

## Enum Values

> By default, the first item of an enum has the value 0. The second has the value 1, and so on.

> To get the integer value from an item, you must explicitly convert the item to an `int`:

Example
```
enum Months
{
  January,    // 0
  February,   // 1
  March,      // 2
  April,      // 3
  May,        // 4
  June,       // 5
  July        // 6
}

static void Main(string[] args)
{
  int myNum = (int) Months.April;
  Console.WriteLine(myNum);
}
```

The output will be:
```
3
```

You can also assign your own enum values, and the next items will update their numbers accordingly:

Example
```
enum Months
{
  January,    // 0
  February,   // 1
  March=6,    // 6
  April,      // 7
  May,        // 8
  June,       // 9
  July        // 10
}

static void Main(string[] args)
{
  int myNum = (int) Months.April;
  Console.WriteLine(myNum);
}
```

The output will be:
```
7
```

## Enum in a Switch Statement

> Enums are often used in `switch` statements to check for corresponding values:

Example
```
enum Level 
{
  Low,
  Medium,
  High
}

static void Main(string[] args) 
{
  Level myVar = Level.Medium;
  switch(myVar) 
  {
    case Level.Low:
      Console.WriteLine("Low level");
      break;
    case Level.Medium:
       Console.WriteLine("Medium level");
      break;
    case Level.High:
      Console.WriteLine("High level");
      break;
  }
}
```
The output will be:
```
Medium level
```

## Why And When To Use Enums?

> Use enums when you have values that you know aren't going to change, like month days, days, colors, deck of cards, etc.


