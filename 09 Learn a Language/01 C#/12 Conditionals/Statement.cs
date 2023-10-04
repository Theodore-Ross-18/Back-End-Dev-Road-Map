// The if Statement

if (20 > 18) 
{
  Console.WriteLine("20 is greater than 18");
}

int x = 20;
int y = 18;
if (x > y) 
{
  Console.WriteLine("x is greater than y");
}

// The else Statement

int time = 20;
if (time < 18) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}

// The else if Statement

int time2 = 22;
if (time2 < 10) 
{
  Console.WriteLine("Good morning.");
} 
else if (time2 < 20) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}

// Short Hand If...Else (Ternary Operator)

int time3 = 20;
string result = (time3 < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);

// C# Switch

int day = 7;
switch (day) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
}

// Default Keyword


int day2 = 4;
switch (day2) 
{
  case 6:
    Console.WriteLine("Today is Saturday.");
    break;
  case 7:
    Console.WriteLine("Today is Sunday.");
    break;
  default:
    Console.WriteLine("Looking forward to the Weekend.");
    break;
}