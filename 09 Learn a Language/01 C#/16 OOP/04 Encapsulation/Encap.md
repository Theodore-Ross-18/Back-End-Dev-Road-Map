# OOP: 01 Encapsulation

## C# Properties (Get and Set)

> Properties and Encapsulation

> Before we start to explain properties, you should have a basic understanding of `"Encapsulation"`.

> The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:

> - declare fields/variables as `private`

> - provide `public` `get` and `set` methods, through properties, to access and update the value of a `private` field

## Properties

> You learned from the previous chapter that private variables can only be accessed within the same class (an outside class has no access to it). However, sometimes we need to access them - and it can be done with properties.

A property is like a combination of a variable and a method, and it has two methods: a get and a set method:

Example
```
class Person
{
  private string name; // field

  public string Name   // property
  {
    get { return name; }   // get method
    set { name = value; }  // set method
  }
}
```

Example explained

> - The `Name` property is associated with the `name` field. It is a good practice to use the same name for both the property and the private field, but with an uppercase first letter.

> - The `get` method returns the value of the variable `name`.

> - The `set` method assigns a `value` to the `name` variable. The `value` keyword represents the value we assign to the property.

Now we can use the Name property to access and update the private field of the Person class:

Example 
```
class Person
{
  private string name; // field
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
    myObj.Name = "Liam";
    Console.WriteLine(myObj.Name);
  }
}
```

The output will be:
```
Liam
```

## Automatic Properties (Short Hand)

> C# also provides a way to use short-hand / automatic properties, where you do not have to define the field for the property, and you only have to write `get;` and `set;` inside the property.

> The following example will produce the same result as the example above. The only difference is that there is less code:

Example

Using automatic properties:
```
class Person
{
  public string Name  // property
  { get; set; }
}

class Program
{
  static void Main(string[] args)
  {
    Person myObj = new Person();
    myObj.Name = "Liam";
    Console.WriteLine(myObj.Name);
  }
}
```

The output will be:
```
Liam
```

## Why Encapsulation?

- Better control of class members (reduce the possibility of yourself (or others) to mess up the code)

- Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)

- Flexible: the programmer can change one part of the code without affecting other parts

- Increased security of data