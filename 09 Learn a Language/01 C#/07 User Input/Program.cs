// User Input

// Type your username and press enter
Console.Write("Enter username: ");

// Create a string variable and get user input from the keyboard and store it in the variable
string userName = Console.ReadLine();

// Print the value of the variable (userName), which will display the input value
Console.WriteLine("Username is: " + userName);

// Error
// Console.WriteLine("Enter your age:");
// int age = Console.ReadLine();
// Console.WriteLine("Your age is: " + age);


// Use a method
Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is: " + age);