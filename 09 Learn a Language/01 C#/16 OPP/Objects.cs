// Class-name: Objects
class Objects
{
    static void Main(string[] args)
  {
    // Object-name: Ford
    Car Ford = new Car();
    // Ford.classname = "Car";
    // Ford.objectname = "Ford";

    // Object Output (Console)
    // Console.WriteLine($"Class: {Ford.classname}");
    // Console.WriteLine($"Object: {Ford.objectname}");
    Console.WriteLine($"Model: {Ford.model}");
    Console.WriteLine($"Color: {Ford.color}");
    Console.WriteLine($"Year: {Ford.year}");
    Console.WriteLine($"Max-Speed: {Ford.maxSpeed}");
    Ford.fullThrottle(); // Call the Method

    // Object-name: Opel
    Car Opel = new Car();
    // Opel.classname = "Car";
    // Opel.objectname = "Opel";
    Opel.model = "Astra";
    Opel.color = "White";
    Opel.year = 2005;

    // Object Output (Console)
    // Console.WriteLine($"Class: {Opel.classname}");
    // Console.WriteLine($"Object: {Opel.objectname}");
    Console.WriteLine($"Model: {Opel.model}");
    Console.WriteLine($"Color: {Opel.color}");
    Console.WriteLine($"Year: {Opel.year}\n");

    // Constructor
    Console.WriteLine($"Owner: {Ford.owner}");

  }

}
