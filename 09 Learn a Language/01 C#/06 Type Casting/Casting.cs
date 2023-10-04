// Type Casting

// Implicit Casting
int myInt = 9;
double myDouble = myInt;       // Automatic casting: int to double

Console.WriteLine(myInt);      // Outputs 9
Console.WriteLine(myDouble);   // Outputs 9

// Explicit Casting
double myDouble2 = 9.78;
int myInt2 = (int) myDouble;    // Manual casting: double to int

Console.WriteLine(myDouble2);   // Outputs 9.78
Console.WriteLine(myInt2);      // Outputs 9

// Type Conversion Methods

int myInt3 = 10;
double myDouble3 = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt3));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt3));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble3));  // convert double to int
Console.WriteLine(Convert.ToString(myBool));   // convert bool to string