# C# Access Modifiers

> Access Modifiers

> By now, you are quite familiar with the public keyword that appears in many of our examples:

```
public string color;
```

> The public keyword is an access modifier, which is used to set the access level/visibility for classes, fields, methods and properties.

C# has the following access modifiers:

| Modifier | Description |
| -------- | ------- |
|  `public` |  The code is accessible for all classes  |
| `private` | The code is only accessible within the same class |
|  `protected` | The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter |
| `internal` | The code is only accessible within its own assembly, but not from another assembly. You will learn more about this in a later chapter |

> There's also two combinations: `protected internal` and `private protected.`

> For now, lets focus on public and private modifiers.

## Private Modifier

> If you declare a field with a private access modifier, it can only be accessed within the same class:

Example
```
class Car
{
  private string model = "Mustang";

  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.model);
  }
}
```
The output will be:
```
Mustang
```

If you try to access it outside the class, an error will occur:

Example: Error
```
class Car
{
  private string model = "Mustang";
}

class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.model);
  }
}
```
The output will be:
```
'Car.model' is inaccessible due to its protection level
The field 'Car.model' is assigned but its value is never used
```

## Public Modifier

> If you declare a field with a public access modifier, it is accessible for all classes:

Example
```
class Car
{
  public string model = "Mustang";
}

class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.model);
  }
}
```

The output will be:
```
Mustang
```

### Why Access Modifiers?

> To control the visibility of class members (the security level of each individual class and class member).

> To achieve "`Encapsulation"` - which is the process of making sure that "sensitive" data is hidden from users. This is done by declaring fields as private. You will learn more about this in the next chapter.

> `Note:` By default, all members of a class are private if you don't specify an access modifier:

Example
```
class Car
{
  string model;  // private
  string year;   // private
}
```