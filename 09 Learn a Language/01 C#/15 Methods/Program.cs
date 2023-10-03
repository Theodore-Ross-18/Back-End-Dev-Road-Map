// C# Methods

class Program
{
    // Multiple Parameters
  static void MyMethod(string fname, int age) // Parameters
  {
    Console.WriteLine(fname + " Bermejo" + " is " + age);
  }
    // Call a Method
    static void Main(string[] args)
    {
        // A method can be called multiple times
        MyMethod("Theodore", 19);
        MyMethod("Anthea", 20);
        MyMethod("Andreo", 3);

    }

}

// C# Default Parameter Value

class Country 
{
    static void MyMethod2(string country = "Norway") 
    {
        Console.WriteLine(country);
    }

    static void Main(string[] args)
    {
        MyMethod2("Sweden");
        MyMethod2("India");
        MyMethod2(); // Norway
        MyMethod2("USA");
    }

}

C# Return Values

class Return {

    static int MyMethod3(int x, int y) 
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        int z = MyMethod3(5, 3);
        Console.WriteLine(z);
    }
}

// C# Named Arguments

class Child 
{
    static void MyMethod(string child1, string child2, string child3) 
    {
        Console.WriteLine("The youngest child is: " + child3);
    }

    static void Main(string[] args)
    {
        MyMethod(child3: "John", child1: "Liam", child2: "Liam");
    }
        // The youngest child is: John

}

// C# Method Overloading

class Overload
{
    static int PlusMethod(int x, int y)
    {
        return x + y;
    }

    static double PlusMethod(double x, double y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        int myNum1 = PlusMethod(8, 5);
        double myNum2 = PlusMethod(4.3, 6.26);
        Console.WriteLine("Int: " + myNum1);
        Console.WriteLine("Double: " + myNum2);
    }

}





