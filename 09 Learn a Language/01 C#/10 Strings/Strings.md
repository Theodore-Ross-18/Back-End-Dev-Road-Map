# C# Strings

> Strings are used for storing text.

> A string variable contains a collection of characters surrounded by double quotes:

```
string greeting = "Hello";
```

> A string variable can contain many words, if you want:

```
string greeting2 = "Nice to meet you!";
```

## String Length

> A string in C# is actually an object, which contain properties and methods that can perform certain operations on strings. For example, the length of a string can be found with the Length property:

```
string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("The length of the txt string is: " + txt.Length);
```

## Other Methods

> There are many string methods available, for example ToUpper() and ToLower(), which returns a copy of the string converted to uppercase or lowercase:

```
string txt = "Hello World";
Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
Console.WriteLine(txt.ToLower());   // Outputs "hello world"
```

## C# String Concatenation

> The + operator can be used between strings to combine them.

> This is called concatenation:

```
string firstName = "John ";
string lastName = "Doe";
string name = firstName + lastName;
Console.WriteLine(name);
```

> `Note:` that we have added a space after "John" to create a space between firstName and lastName on print.

> You can also use the string.Concat() method to concatenate two strings:

```
string firstName = "John ";
string lastName = "Doe";
string name = string.Concat(firstName, lastName);
Console.WriteLine(name);
```

## Adding Numbers and Strings

Remainder
> - C# uses the + operator for both addition and concatenation.

> - Numbers are added. Strings are concatenated.

> If you add two numbers, the result will be a number:

```
int x = 10;
int y = 20;
int z = x + y;  // z will be 30 (an integer/number)
```

> If you add two strings, the result will be a string concatenation:

```
string x = "10";
string y = "20";
string z = x + y;  // z will be 1020 (a string)
```

## C# String Interpolation

> Another option of string concatenation, is string interpolation, which substitutes values of variables into placeholders in a string. Note that you do not have to worry about spaces, like with concatenation:

```
string firstName = "John";
string lastName = "Doe";
string name = $"My full name is: {firstName} {lastName}";
Console.WriteLine(name);
```

> Also note that you have to use the dollar sign `($)` when using the string interpolation method.

> String interpolation was introduced in C# version 6.

## C# Access Strings

> You can access the characters in a string by referring to its index number inside square brackets [].

> This example prints the first character in myString:

```
string myString = "Hello";
Console.WriteLine(myString[0]);  // Outputs "H"
```

> `Note:` String indexes start with 0: `[0]` is the first character. `[1]` is the second character, etc.

> This example prints the second character (1) in myString:

```
string myString = "Hello";
Console.WriteLine(myString[1]);  // Outputs "e"
```

> You can also find the index position of a specific character in a string, by using the IndexOf() method:

```
string myString = "Hello";
Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"
```

> Another useful method is Substring(), which extracts the characters from a string, starting from the specified character position/index, and returns a new string. This method is often used together with IndexOf() to get the specific character position:

```
// Full name
string name = "John Doe";

// Location of the letter D
int charPos = name.IndexOf("D");

// Get last name
string lastName = name.Substring(charPos);

// Print the result
Console.WriteLine(lastName);
```

## C# Special Characters

> Strings - Special Characters

> Because strings must be written within quotes, C# will misunderstand this string, and generate an error:

```
string txt = "We are the so-called "Vikings" from the north.";
```

> The solution to avoid this problem, is to use the backslash escape character.

> The backslash (\) escape character turns special characters into string characters:

| Escape Character    | Result |
| -------- | ------- |
| \' (Single Quote)  | '   |
| \" (Double Quote) |  "   |
| \\ (Backslash)    | \  |

> The sequence \"  inserts a double quote in a string:

```
string txt = "We are the so-called \"Vikings\" from the north.";
```

> The sequence \'  inserts a single quote in a string:

```
string txt = "It\'s alright.";
```

> The sequence \\  inserts a single backslash in a string:

```
string txt = "The character \\ is called backslash.";
```

> Other useful escape characters in C# are:


| Code    | Result |
| -------- | ------- |
| \n  | New Line |
| \t |  Tab |
| \b    | 	Backspace |