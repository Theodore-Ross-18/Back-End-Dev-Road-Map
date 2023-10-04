// OOP 

// Class-name: Car
class Car 
{
  // Class Members
  // public string classname;
  // public string objectname;
  public string owner;
  public string model = "Mustang"; // Field
  public string color = "Black"; // Field
  public int year = 1969; // Field
  public int maxSpeed = 200; // Field
  public void fullThrottle() // Method
  {
    Console.WriteLine("The car is going as fast as it can!\n");
  }
  // Constructor
  public Car() {
    owner = "Theodore Ross";
  }

}