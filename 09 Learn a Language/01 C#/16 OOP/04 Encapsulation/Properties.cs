// C# Properties (Get and Set)

class Person
{
  private string name = ""; // field
  public string Name   // property
  {
    get { return name; }
    set { name = value; }
  }
}

class Program
{
  static void Main(string[] args)
  {
    Person myObj = new Person();
    myObj.Name = "Theodore";
    Console.WriteLine(myObj.Name);
  }
}