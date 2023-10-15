// C# While Loop

int a = 0;
while (a < 5) 
{
  Console.WriteLine(a);
  a++;
}

// The Do/While Loop

int e = 0;
do 
{
  Console.WriteLine(e);
  e++;
}
while (e < 5);

// C# For Loop

for (int i = 0; i < 10; i++) 
{
  Console.WriteLine(i);
}

// Nested Loops

// Outer loop
for (int o = 1; o <= 2; o++) 
{
  Console.WriteLine("Outer: " + o);  // Executes 2 times

  // Inner loop
  for (int j = 1; j <= 3; j++) 
  {
    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
  }
}

// C# Foreach Loop

string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string t in cars) 
{
  Console.WriteLine(t);
}

// C# Break and Continue

for (int b = 0; b < 10; b++) 
{
  if (b == 4) 
  {
    break;
  }
  Console.WriteLine(b);
}

for (int c = 0; c < 10; c++) 
{
  if (c == 4) 
  {
    continue;
  }
  Console.WriteLine(c);
}

// Break and Continue in While Loop

int w = 0;
while (w < 10) 
{
  Console.WriteLine(w);
  w++;
  if (w == 4) 
  {
    break;
  }
}

int m = 0;
while (m < 10) 
{
  if (m == 4) 
  {
    m++;
    continue;
  }
  Console.WriteLine(m);
  m++;
}

