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

### 1.Class
Classes is a building block in software applications in OO language like C#.

**Anatomy of Class**

All are called data member or class member.
- Data (represented by field)
- Behavior (represented by methods)

**Object** is the class instance.

```c#
// class example
public class Persone 
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

