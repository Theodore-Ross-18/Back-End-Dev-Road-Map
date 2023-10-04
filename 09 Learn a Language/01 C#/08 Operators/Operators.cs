// Operators

// int sum1 = 100 + 50;        // 150 (100 + 50)
// int sum2 = sum1 + 250;      // 400 (150 + 250)
// int sum3 = sum2 + sum2;     // 800 (400 + 400)

// Console.WriteLine(sum1);
// Console.WriteLine(sum2);
// Console.WriteLine(sum3);

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 5;
      int y = 3;
      Console.WriteLine(x++ + y--);  
     }
  }
}
