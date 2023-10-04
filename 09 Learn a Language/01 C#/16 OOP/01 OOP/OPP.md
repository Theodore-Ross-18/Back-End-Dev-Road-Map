# C# OOP

### What is OOP?

> OOP stands for `Object-Oriented Programming.`

> Procedural programming is about writing procedures or methods that perform operations on the data, while object-oriented programming is about creating objects that contain both data and methods.

Object-oriented programming has several advantages over procedural programming:

> - OOP is faster and easier to execute
> - OOP provides a clear structure for the programs
> - OOP helps to keep the C# code DRY "Don't Repeat Yourself", and makes the code easier to maintain, modify and debug
> - OOP makes it possible to create full reusable applications with less code and shorter development time

> `Tip:` Tip: The "Don't Repeat Yourself" (DRY) principle is about reducing the repetition of code. You should extract out the codes that are common for the application, and place them at a single place and reuse them instead of repeating it.

## C# - What are Classes and Objects?

> Classes and objects are the two main aspects of object-oriented programming.

Look at the following illustration to see the difference between class and objects:

| Class    | Objects |
| -------- | ------- |
|  Fruit | Apple    |
|  | Banana |
|    | Mango |

Another Example

| Class    | Objects |
| -------- | ------- |
|  Car | Volvo    |
|  | Audi |
|    | Toyota |

> So, a class is a template for objects, and an object is an instance of a class.

> When the individual objects are created, they inherit all the variables and methods from the class.

## C# Classes and Objects

> You learned from the previous chapter that C# is an object-oriented programming language.

> Everything in C# is associated with classes and objects, along with its attributes and methods.

> For example: in real life, a car is an object.

> The car has attributes, such as weight and color, and methods, such as drive and brake.

> A Class is like an object constructor, or a "blueprint" for creating objects.

## Create a Class

To create a class, use the class keyword:

```
class Car 
{
  string color = "red";
}
```

> When a variable is declared directly in a class, it is often referred to as a field (or attribute).

It is not required, but it is a good practice to start with an uppercase first letter when naming classes. Also, it is common that the name of the C# file and the class matches, as it makes our code organized. However it is not required (like in Java).

## Create an Object

> An object is created from a class. We have already created the class named Car, so now we can use this to create objects.

To create an object of Car, specify the class name, followed by the object name, and use the keyword new:

Example

Create an object called "myObj" and use it to print the value of color:
```
class Car 
{
  string color = "red";

  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.color);
  }
}
```

> `Note:` we use the dot syntax (.) to access variables/fields inside a class (myObj.color).

## C# Multiple Classes and Objects

> Multiple Objects

You can create multiple objects of one class:

Example

Create two objects of Car:

```
class Car
{
  string color = "red";
  static void Main(string[] args)
  {
    Car myObj1 = new Car();
    Car myObj2 = new Car();
    Console.WriteLine(myObj1.color);
    Console.WriteLine(myObj2.color);
  }
}
```

> Using Multiple Classes

You can also create an object of a class and access it in another class.

> This is often used for better organization of classes (one class has all the fields and methods, while the other class holds the Main() method (code to be executed)).

- prog2.cs

```
class Car 
{
  public string color = "red";
}
```

- prog.cs
```
class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.color);
  }
}
```

> Did you notice the public keyword? It is called an access modifier, which specifies that the color variable/field of Car is accessible for other classes as well, such as Program.

## C# Class Members

> Class Members

> Fields and methods inside classes are often referred to as "Class Members":

Example

Create a Car class with three class members: two fields and one method.
```
// The class
class MyClass
{
  // Class members
  string color = "red";        // field
  int maxSpeed = 200;          // field
  public void fullThrottle()   // method
  {
    Console.WriteLine("The car is going as fast as it can!");
  }
}
```

## Fields

> In the previous chapter, you learned that variables inside a class are called fields, and that you can access them by creating an object of the class, and by using the dot syntax (.).

The following example will create an object of the Car class, with the name myObj. Then we print the value of the fields color and maxSpeed:

Example
```
class Car 
{
  string color = "red";
  int maxSpeed = 200;

  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.color);
    Console.WriteLine(myObj.maxSpeed);
  }
}
```

You can also leave the fields blank, and modify them when creating the object:

Example
```
class Car 
{
  string color;
  int maxSpeed;

  static void Main(string[] args)
  {
    Car myObj = new Car();
    myObj.color = "red";
    myObj.maxSpeed = 200;
    Console.WriteLine(myObj.color);
    Console.WriteLine(myObj.maxSpeed);
  }
}
```

This is especially useful when creating multiple objects of one class:

Example
```
class Car 
{
  string model;
  string color;
  int year;

  static void Main(string[] args)
  {
    Car Ford = new Car();
    Ford.model = "Mustang";
    Ford.color = "red";
    Ford.year = 1969;

    Car Opel = new Car();
    Opel.model = "Astra";
    Opel.color = "white";
    Opel.year = 2005;

    Console.WriteLine(Ford.model);
    Console.WriteLine(Opel.model);
  }
}
```

## Object Methods

> You learned from the C# Methods chapter that methods are used to perform certain actions.

> Methods normally belong to a class, and they define how an object of a class behaves.

> Just like with fields, you can access methods with the dot syntax. However, note that the method must be public. And remember that we use the name of the method followed by two parentheses () and a semicolon ; to call (execute) the method:

Example
```
class Car 
{
  string color;                 // field
  int maxSpeed;                 // field
  public void fullThrottle()    // method
  {
    Console.WriteLine("The car is going as fast as it can!"); 
  }

  static void Main(string[] args)
  {
    Car myObj = new Car();
    myObj.fullThrottle();  // Call the method
  }
}
```

Why did we declare the method as public, and not static, like in the examples from the C# Methods Chapter?

> The reason is simple: a static method can be accessed without creating an object of the class, while public methods can only be accessed by objects.

## Use Multiple Classes

> Remember from the last chapter, that we can use multiple classes for better organization (one for fields and methods, and another one for execution). This is recommended:

prog2.cs
```
class Car 
{
  public string model;
  public string color;
  public int year;
  public void fullThrottle()
  {
    Console.WriteLine("The car is going as fast as it can!"); 
  }
}
```

prog.cs
```
class Program
{
  static void Main(string[] args)
  {
    Car Ford = new Car();
    Ford.model = "Mustang";
    Ford.color = "red";
    Ford.year = 1969;

    Car Opel = new Car();
    Opel.model = "Astra";
    Opel.color = "white";
    Opel.year = 2005;

    Console.WriteLine(Ford.model);
    Console.WriteLine(Opel.model);
  }
}
```

> The public keyword is called an access modifier, which specifies that the fields of Car are accessible for other classes as well, such as Program.