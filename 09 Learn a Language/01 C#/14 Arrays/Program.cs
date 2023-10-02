
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
int[] myNum = {10, 20, 30, 40};

Console.WriteLine(cars);
Console.WriteLine(myNum);


// Change an Array Element
cars[0] = "Opel";

// Access the Elements of an Array
Console.WriteLine(cars[0]);

// Array Length

Console.WriteLine(cars.Length);

// Other Ways to Create an Array

string[] fav = new string[5] {"\nCarbonara", "Dragon Fruit", "Chao Fan", "Meat Balls", "Blueberry\n"};

// Looping through an array
for (int i = 0; i < fav.Length; i++)
{
    Console.WriteLine(fav[i]);
}

Console.WriteLine(fav);
Console.WriteLine(fav.Length);

// Foreach loop
string[] music = {"\nCheery Wine", "Wings", "Oh Honey", "My Girl\n"};
foreach (string i in music)
{
    Console.WriteLine(i);
}

// Sort an Array

// Sort a string
string[] BirthDate = {"\nJanuary", "18th" , "2004\n"};
Array.Sort(BirthDate);
foreach (string i in BirthDate)
{
  Console.WriteLine(i);
}

// Sort an int
int[] myNumbers = {5, 1, 8, 9};
Array.Sort(myNumbers);
foreach (int i in myNumbers)
{
  Console.WriteLine(i);
  Console.WriteLine("");
}

// Multidimensional Arrays

// Two-Dimensional Arrays

int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

// Access Elements of a 2D Array

Console.WriteLine(numbers[0, 2]);  // Outputs 2


// Change Elements of a 2D Array

numbers[0, 0] = 5;
Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1

// Loop Through a 2D Array

foreach (int i in numbers)
{
  Console.WriteLine(i);
} 

for (int i = 0; i < numbers.GetLength(0); i++) 
{ 
  for (int j = 0; j < numbers.GetLength(1); j++) 
  { 
    Console.WriteLine(numbers[i, j]); 
  } 
}  


