// Strings

// string greeting = "Hello";

// string greeting2 = "Nice to meet you!";

// String Length

string len = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("The length of the txt string is: " + len.Length);

// Other Methods

string greeting3 = "Hello World";
Console.WriteLine(greeting3.ToUpper());   // Outputs "HELLO WORLD"
Console.WriteLine(greeting3.ToLower());   // Outputs "hello world"

// String Concatenation

// string firstName = "Theodore ";
// string lastName = "Ross";
// string name = firstName + lastName;
// Console.WriteLine(name);

string firstName = "Theodore ";
string lastName = "Ross";
string name = string.Concat(firstName, lastName);
Console.WriteLine(name);

// Adding Numbers and Strings

int a = 10;
int b = 20;
int c = a + b;  // z will be 30 (an integer/number)

string d = "10";
string e = "20";
string f = d + e;  // z will be 1020 (a string)

// String Interpolation

string firstName2 = "Theodore";
string lastName2 = "Ross";
string name2 = $"My full name is: {firstName2} {lastName2}";
Console.WriteLine(name2);

// Access Strings

string myString = "Hello";
Console.WriteLine(myString[0]);  // Outputs "H"

string myString2 = "Hello";
Console.WriteLine(myString2[1]);  // Outputs "e"

string myString3 = "Hello";
Console.WriteLine(myString3.IndexOf("e"));  // Outputs "1"

// Full name
string name3 = "John Doe";

// Location of the letter D
int charPos = name3.IndexOf("D");

// Get last name
string lastName3 = name3.Substring(charPos);

// Print the result
Console.WriteLine(lastName3);

//  Special Characters

string txt = "We are the so-called \"Vikings\" from the north.";

string txt2 = "It\'s alright.";

string txt3 = "The character \\ is called backslash.";

Console.WriteLine(txt);
Console.WriteLine(txt2);
Console.WriteLine(txt3);