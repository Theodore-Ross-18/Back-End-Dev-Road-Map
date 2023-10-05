
// Interface
// interface IAnimal 
// {
//   void animalSound(); // interface method (does not have a body)
// }

// // Pig "implements" the IAnimal interface
// class Pig : IAnimal 
// {
//   public void animalSound() 
//   {
//     // The body of animalSound() is provided here
//     Console.WriteLine("The pig says: wee wee");
//   }
// }

// class Program 
// {
//   static void Main(string[] args) 
//   {
//     Pig myPig = new Pig();  // Create a Pig object
//     myPig.animalSound();
//   }
// }

interface IFirstInterface 
{
  void myMethod(); // interface method
}

interface ISecondInterface 
{
  void myOtherMethod(); // interface method
}

// Implement multiple interfaces
class DemoClass : IFirstInterface, ISecondInterface 
{
  public void myMethod() 
  {
    Console.WriteLine("Some text..");
  }
  public void myOtherMethod() 
  {
    Console.WriteLine("Some other text...");
  }
}

class Program 
{
  static void Main(string[] args)
  {
    DemoClass myObj = new DemoClass();
    myObj.myMethod();
    myObj.myOtherMethod();
  }
}