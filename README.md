# OOPFundamentals
Repository for tracking OOP fundamentals course on Pluralsight

## Object Oriented Programming (OOP)
OOP is an important topics this days, So, This repo is for writing important notes about this topic for future usage.
This topic is mainly from 2 courses, One from Udemy [csharp-intermediate-classes-interfaces-and-oop](https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/),
and the other from Pluralsight [Object-Oriented Programming Fundamentals in C#](https://app.pluralsight.com/library/courses/object-oriented-programming-fundamentals-csharp/table-of-contents).

#### Let's Start :point_down:

### Principles of OOP:

- **Encapsulation:** It's about hiding data/information hiding and collect information and behaviors in one place.
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
}
```
**NOTES**
 - Constructor must be the same name of the class.
 - Constructor doesn't have any return type.
 - If you didn't create default/parameter-less constructor the C# compiler creates one for you.

**Object Initializer** is another way to initialize an object, syntax for quickly initialize object without call its constructors
**to** avoid creating multiple constructors. 

```c#
public class Person
{
    // field member
    public string Name;
    // field member
    public int Id;
}

public static void Main(string[] args)
{
    Person person = new Person 
    {
        Name = "Musta"
    };
    // OR
    var person = new Person
    {
        Id = 1,
        Name = "Mustafa"
    };
}
```

**Method** is a class function/behavior

- Method Signature
    - Method Name
    - Number and Type of parameter
- Method Overloading
    - A Method with the same name and but different signatures
```c#
class Point
{
    public void Move(int x, int y) {}
    public void Move(Point newLocation) {}
    public void Move(Point newLocation, int speed) {}
}
```
- Parameters
```c#
class Calculator
{
    // bad way for overloading
    public int Add(int n1, int n2) {}
    public int Add(int n1, int n2, int n3) {}
    public int Add(int n1, int n2, int n3, int n4) {}
    
    // good way
    public int Add(params int[] number) {}
}
// ...
var result = calculator.Add(1, 3, 4 ,5);
```
- `Ref` modifier
    - A way to pass parameters by reference to a method.
- `Out` modifier
    - A wat to return more than one return type by passing a pre-initialised parameter to the function and pass the value to the same parameter.
    
**Field** is a variable declared in the class level to store data about the class.
- `readonly` field insures that the fields is initialized only once.
    - In constructors
    - In declaration
```c#
class Person
{
    public readonly string Name = "Musta";
    // OR
    public Person()
    {
        this.Name = "Mustafa";
    } 
    // --------------- 
    public void ChangeName()
    {
        // error
        this.Name = "Other Name";
    }
}
```

**Access Modifiers** is a keywords that control the accessibility level of that class or field 
**to** create safety in our program
- **Property** is class member that encapsulate gitter and setter for accessing field.
- `public` access from anywhere
- `private` access only from inside the class
    - getter and setter
    ```c#
    class Person
    {
        private string _name;
        // property
        public string Name
        {
            get { return _name; }
            set { _name = value; }  
        }
        // the same
        public string Name { get; set; }
        // also you can use private for setter or getter to access it in the class only
        public string Name { get; private set; }
    }
    ```
- `protected` access only from the class and its derived classes
    ```c#
    class Person
    {
        protected int CalculateRating()
        {
        }
    }
    var person = new Person();
    // not accessable
    persone.CalculateRating();
    ```
- `internal` access only from the same assembly _for classes only_
    ```c#
  internal class RateCalculator
  {
  }
  // in same assembly valid
  var calculator = new RateCalculator();
  // in other assembly error
  var calculator = new RateCalculator();
    ```
- `protected internal` access from the same assembly or any derived class
    ```c#
    class Person
    {
        protected internal int CalculateRating()
        {
        }
    }
    ```

**Indexer** is away to access class member by `[]` list operator
```c#
class HttpCookie
{
    // you can use any return type and any type for the key
    public string this[string key]
    {
        get {...}
        set {...}
    }
}
```

### 2. Inheritance

**Relationship between classes**
- **Inheritance** is a relationship between two classes that allows one class to inherit code form other, shortly is **_Is-A_** relationship.
    - Benefits
        1. Code reuse
        2. Polymorphic behavior
    - Problems
        1. Tight Coupling
        2. Large Hierarchy
        3. Fragility
    ```c#
    public class PresentationObject
    {
        // common shared code
        public int Height { get; set; }
        public int Width { get; set; }
    
        public void Copy()
        {
            Console.WriteLine("Object copied");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object duplicated");
        }
    }
    
    public class Text : PresentationObject
    {
        // code specific for text
        public int FontSize { get; set; }
        public string FontName { get; set; }
        
        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added link " + url);
        }
    }
    ```
- **Composition** is a relationship between two classes that allows one class to contain the other, shortly is **_Has-A_** relationship.
    - Benefits
        1. Code reuse
        2. Flexibility
        3. Loos-Coupling
```c#
public class Logger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

public class Installer
{
    private Logger _logger;

    public Installer(Logger logger)
    {
        _logger = logger;
    }
    public void Install()
    {
        _logger.Log("installing...");
    }
}
public static void Main(string[] args)
{
    var logger = new Logger();
    var installer = new Installer(logger);
    installer.Install();
}
```

**Constructors in Inheritance**
```c#
public class Vehicle
{
    private string _registrationNumber;
    public Vehicle(string registrationNumber)
    {
        _registrationNumber = registrationNumber;
    }
}
public class Car : Vehicle
{
    public Car(string registrationNumber)
        : base(registrationNumber) // call parent class constructor
    {
        // initialize field in Car class
    }
}
```

**Up-casting vs Down-casting**
- **Up-casting** is converting derived class to base class
- **Down-casting** is converting base class to derived class
```c#
// up casting
Circle circle = new Circle();
Shape shape = circle; // base class reference
Circle anotherCircle = (Circle)shape; // cassting required
Car car = (Car)shape; // throws InvalidCastExceptoin
```
- `is` and `as` keywords
```c#
Car car = (Car)obj; // may throw InvalidCastExceptoin
// safe way
Car car = obj as Car; // if obj is a car it will cast the obj, else car will be null
if(car != null) {}
// another safe way
if(obj is Car) // check if obj is a car
{
    Car car = (Car)obj;
}
```

**Boxing vs Unboxing**
- C# types are divided into two categories: value types and reference types.
- Value types (eg int, char, bool, all primitive types and struct) are stored in the stack.
  They have a short life time and as soon as they go out of scope are removed from memory.
- Reference types (eg. all classes) are stored in the heap.
- Every object can be implicitly cast to a base class reference.
- The object class is the parent of all classes in .NET Framework.
- **Boxing** happens when a value type instance is converted to an object reference.
- **Unboxing** is the opposite: when an object reference is converted to a value type.
```c#
// Boxing
object obj = 1;

// Unboxing
int i = (int)obj;
```



