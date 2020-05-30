# OOPFundamentals
Repository for tracking OOP fundamentals course on Pluralsight

## Object Oriented Programming (OOP)
OOP is an important topics this days, So, This repo is for writing important notes about this topic for future usage.
This topic is mainly from 2 courses, One from Udemy [csharp-intermediate-classes-interfaces-and-oop](https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/),
and the other from Pluralsight [Object-Oriented Programming Fundamentals in C#](https://app.pluralsight.com/library/courses/object-oriented-programming-fundamentals-csharp/table-of-contents).

#### Let's Start :point_down:

### Principles of OOP:

- **Encapsulation:** It's about hiding data and  implementation details.
- **Abstraction:** It's about hiding unnecessary implementation details.
- **Inheritance:** It's about relationships and subclasses between objects, allowing developers to reuse a common logic while still maintaining a unique hierarchy.
- **Polymorphism:** Objects can take on more than one form depending on the context. The program will determine which meaning or usage is necessary for each execution of that object, cutting down the need to duplicate code.


The first item to discuss here is Classes

### 1. Class
Classes is a building block in software applications in OO language like C#.

**Anatomy of Class**

All are called data member or class member.
- Data (represented by field)
- Behavior (represented by methods)

**Object** is the class instance.

```c#
// class example
public class Person
{
    // field member
    public string Name;
    
    // method member
    public void Introduce()
    {
        Console.WriteLine("Hello, My name is " + Name);
    }
    
    // static member
    // static members can be accessed from class itself not from object instance
    public static int PesonsCount = 0;
}

public static void Main(string[] args)
{
    Person person = new Person();
    // OR
    var person = new Person();
    // Access members
    person.Name = "Musta";
    person.Introduce();
}
```

**Constructor** is a method that is called when an instance of class is created 
**to** put an object in an early state and initialize some class fields.

```c#
public class Person
{
    // field member
    public string Name;
    // field member
    public int Id;

    // default/parameter-less constructor
    public Person()
    {
    }
    // constructor overlaoding
    // constructor initilize Name field
    public Person(string name)
    {
        this.Name = name;
    }
    // constructor overlaoding
    // constructor initilize Name field and Id field
    public Person(int id, string name)
        : this(name) // call constructor that initialize name field
    {
        this.Id = id;
    }
}

public static void Main(string[] args)
{
    Person person = new Person("Musta");
    // OR
    var person = new Person(1, "Mustafa");
    // Access members
    person.Name = "Musta";
}
```
**NOTES**
 - Constructor must be the same name of the class.
 - Constructor doesn't have any return type.
 - If you didn't create default/parameter-less constructor the C# compiler creates one for you.






