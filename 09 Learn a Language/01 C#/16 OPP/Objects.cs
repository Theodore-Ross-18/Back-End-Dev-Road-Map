class Objects
{
    static void Main(string[] args)
  {
    Car Ford = new Car();

    Console.WriteLine($"Model: {Ford.model}");
    Console.WriteLine($"Color: {Ford.color}");
    Console.WriteLine($"Year: {Ford.year}");
    Console.WriteLine($"Max-Speed: {Ford.maxSpeed}");
    Ford.fullThrottle();
  }

}
