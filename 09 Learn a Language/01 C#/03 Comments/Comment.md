# C# Comments

> Comments can be used to explain C# code, and to make it more readable. It can also be used to prevent execution when testing alternative code.

## Single-line Comments

> - Single-line comments start with two forward slashes (`//`).

> Note: Any text between // and the end of the line is ignored by C# (will not be executed).

```
// This is a comment
Console.WriteLine("Hello World!");
```

```
Console.WriteLine("Hello World!");  // This is a comment
```

## C# Multi-line Comments

> - Multi-line comments start with `/*` and ends with `*/`

> Note: Any text between /* and */ will be ignored by C#.

```
/* The code below will print the words Hello World
to the screen, and it is amazing */

Console.WriteLine("Hello World!"); 
```