# Arrays, Collections, and Generics in C# (C# 9+)

## 🧠 Real-Life Analogies

| Concept          | Real-life Analogy                             |
|------------------|-----------------------------------------------|
| Array            | Row of mailboxes (fixed size, numbered slots) |
| List             | Shopping list (can grow/shrink)               |
| Dictionary       | Phonebook (key-value pairs)                   |
| HashSet          | Guest list (no duplicates allowed)            |
| Queue            | Bank queue (FIFO)                             |
| Stack            | Plates stack (LIFO)                           |

---

## 📚 Arrays in C#

### ✅ Declare & Initialize
```csharp
int[] scores = new int[5];
string[] cities = { "Pune", "Mumbai", "Delhi", "Nagpur" };
var students = new string[] { "Amit", "Sara", "John" };
```

### ✅ Access Elements
```csharp
Console.WriteLine(cities[1]); // Output: Mumbai
cities[2] = "Hyderabad";
```

### ✅ Loop Through Array
```csharp
foreach (var city in cities)
    Console.WriteLine(city);

for (int i = 0; i < cities.Length; i++)
    Console.WriteLine($"{i}: {cities[i]}");
```

### ✅ Common Methods (Array class)
```csharp
int[] numbers = { 5, 2, 9, 1, 3 };

Array.Sort(numbers);
Array.Reverse(numbers);
int index = Array.IndexOf(numbers, 5);
Array.Clear(numbers, 0, 2);
```

---

## 🎒 Collections

### ✅ List<T> – Shopping Cart
```csharp
var cart = new List<string> { "Apple", "Banana" };
cart.Add("Mango");
cart.Remove("Banana");
Console.WriteLine(cart.Count);

foreach (var item in cart)
    Console.WriteLine(item);
```

### ✅ Dictionary<TKey, TValue> – Student Marks
```csharp
var marks = new Dictionary<string, int>
{
    { "Amit", 85 },
    { "Sara", 92 }
};

marks["John"] = 78;

foreach (var kvp in marks)
    Console.WriteLine($"{kvp.Key} scored {kvp.Value}");
```

### ✅ HashSet<T> – Unique Emails
```csharp
var emails = new HashSet<string>();
emails.Add("a@domain.com");
emails.Add("b@domain.com");
emails.Add("a@domain.com");

Console.WriteLine(emails.Count); // 2
```

### ✅ Queue<T> – Bank Queue
```csharp
var queue = new Queue<string>();
queue.Enqueue("Customer1");
queue.Enqueue("Customer2");

Console.WriteLine(queue.Dequeue());
```

### ✅ Stack<T> – Undo Operations
```csharp
var actions = new Stack<string>();
actions.Push("Open File");
actions.Push("Edit Text");

Console.WriteLine(actions.Pop());
```

---

## 🧪 Practice Tasks

| Task                         | Description                                       |
|------------------------------|---------------------------------------------------|
| Temperatures in array        | Store 5 and calculate average                    |
| List shopping                | Add/remove items dynamically                     |
| Student report               | Use Dictionary<string, int>                      |
| Print queue simulation       | Use Queue<T>                                     |
| Page navigation              | Use Stack<T>                                     |
| Unique visitor names         | Use HashSet<string>                              |

---

## 🟢 Generic vs Non-Generic

### 🔴 Non-Generic Example
```csharp
ArrayList list = new ArrayList();
list.Add(10);
list.Add("Hello");

int x = (int)list[0];
int y = (int)list[1]; // Runtime error
```

### ✅ Generic Example
```csharp
List<int> numbers = new List<int>();
numbers.Add(10);
numbers.Add(20);
// numbers.Add("Hello"); // Compile-time error

int x = numbers[0];
```

### ✅ Generic Method
```csharp
public void Print<T>(T value)
{
    Console.WriteLine($"Value: {value}");
}

Print(10);
Print("Hello");
Print(3.14);
```

---

## 📦 Collections Comparison Table

| Collection Type       | Non-Generic    | Generic                     |
|------------------------|----------------|------------------------------|
| List                  | ArrayList      | List<T>                      |
| Dictionary            | Hashtable      | Dictionary<TKey, TValue>     |
| Stack                 | Stack          | Stack<T>                     |
| Queue                 | Queue          | Queue<T>                     |

---

## ✅ Summary: Generics vs Non-Generics

| Feature               | Non-Generic           | Generic                        |
|------------------------|-----------------------|--------------------------------|
| Type Safety            | ❌ No (runtime errors) | ✅ Yes (compile-time checking) |
| Performance            | Slower (boxing)       | Faster                         |
| Flexibility            | Fixed object type     | Any type (`T`)                 |
| Code Reusability       | Limited               | High (with `<T>`)              |



---

# 👶 Object-Oriented Programming (OOP) Concepts in C# (C# 9+)

## 🔹 1. Class and Object

**Real-life Example**: A *Class* is like a *blueprint* of a house. An *Object* is the actual house built from that blueprint.

```csharp
// Class (Blueprint)
public class Car
{
    public string Brand;
    public int Speed;

    public void Drive()
    {
        Console.WriteLine($"Driving {Brand} at {Speed} km/h");
    }
}

// Object (Real car)
var myCar = new Car { Brand = "Toyota", Speed = 80 };
myCar.Drive();
```

---

## 🔹 2. Encapsulation (Hiding Data)

**Real-life Example**: A TV remote hides the complex circuit inside. You only use buttons.

```csharp
public class BankAccount
{
    private double balance = 0;

    public void Deposit(double amount)
    {
        if (amount > 0) balance += amount;
    }

    public double GetBalance()
    {
        return balance;
    }
}
```

---

## 🔹 3. Inheritance (Is-a Relationship)

**Real-life Example**: A *Dog* is an *Animal*.

```csharp
public class Animal
{
    public void Eat() => Console.WriteLine("Eating");
}

public class Dog : Animal
{
    public void Bark() => Console.WriteLine("Barking");
}

Dog dog = new Dog();
dog.Eat(); // from Animal
dog.Bark();
```

---

## 🔹 4. Polymorphism (Many Forms)

**Real-life Example**: A remote control can operate TV, AC, or Music Player — same remote, different behavior.

```csharp
public class Animal
{
    public virtual void Speak() => Console.WriteLine("Animal sound");
}

public class Cat : Animal
{
    public override void Speak() => Console.WriteLine("Meow");
}

public class Dog : Animal
{
    public override void Speak() => Console.WriteLine("Woof");
}

Animal myPet = new Cat();
myPet.Speak(); // Meow
```

---

## 🔹 5. Abstraction (Only Essential Info)

**Real-life Example**: You drive a car without knowing how the engine works internally.

```csharp
public abstract class Vehicle
{
    public abstract void Start(); // only method signature
}

public class Bike : Vehicle
{
    public override void Start() => Console.WriteLine("Bike started");
}

Vehicle vehicle = new Bike();
vehicle.Start();
```

---

## 🔹 6. Interface (Contract)

**Real-life Example**: A *USB* interface — any device (mouse, keyboard) can implement it.

```csharp
public interface IAnimal
{
    void MakeSound();
}

public class Cow : IAnimal
{
    public void MakeSound() => Console.WriteLine("Moo");
}

IAnimal animal = new Cow();
animal.MakeSound();
```

👉 Interfaces define *what* a class must do, not *how*.

---

## 🔹 7. Static Classes and Members

**Real-life Example**: A *Calculator* that you don’t need to create an object for.

```csharp
public static class Calculator
{
    public static int Add(int a, int b) => a + b;
}

int result = Calculator.Add(5, 3);
```

---

## 🔹 8. Constructor (Object Initialization)

```csharp
public class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }
}

Person p = new Person("Alice");
```

---

## 🔹 9. Assemblies (DLL and EXE)

**Simple Explanation**:
- Assemblies are the *output files* your code is compiled into.
- `.exe`: Executable
- `.dll`: Class library

**Real-life Example**: Think of an assembly like a *book*. Your code is the *content*, and the compiler turns it into a book.

---

## 🔹 10. Namespaces

**Real-life Example**: Like folders for organizing files.

```csharp
namespace MyProject.Models
{
    public class Student
    {
        public string Name;
    }
}
```

---

## 🔹 11. Generics vs Non-Generics

**Real-life Example**: A *lunchbox* (Generic) that works for any type of food.

```csharp
// Generic list
List<int> numbers = new List<int>();
numbers.Add(1);

// Non-Generic (old style)
ArrayList list = new ArrayList();
list.Add(1); // allows any type (unsafe)
```

👉 Generics = *type-safe*, *faster*, and *better*. Always prefer `List<T>` over `ArrayList`.

---

## 🔹 12. Collections

```csharp
List<string> fruits = new List<string> { "Apple", "Banana" };
Dictionary<string, int> stock = new Dictionary<string, int>
{
    { "Apple", 10 },
    { "Banana", 5 }
};
```

**When to Use:**
- `List<T>`: Ordered list
- `Dictionary<K,V>`: Key-value pairs
- `HashSet<T>`: Unique values
- `Queue<T>`: First In First Out (FIFO)
- `Stack<T>`: Last In First Out (LIFO)

---

## ✅ Summary Table

| Concept        | Real-life Example           |
|----------------|-----------------------------|
| Class & Object | Blueprint & real object     |
| Encapsulation  | TV Remote                   |
| Inheritance    | Dog is an Animal            |
| Polymorphism   | Universal Remote            |
| Abstraction    | Driving a car               |
| Interface      | USB Interface               |
| Static Class   | Calculator                  |
| Constructor    | Making a new person         |
| Generics       | Lunchbox for any food       |
| Assembly       | Compiled book of your code  |
| Namespace      | Folders                     |


# C# 9: Getters, Setters, and `init` Properties (Immutability)

This guide explains the use of **getters**, **setters**, and the **`init` accessor** introduced in **C# 9**, with real-world examples and comparisons.

---

## ✅ Traditional Getter and Setter

```csharp
public class Student
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}
```

**Usage:**

```csharp
var student = new Student();
student.Name = "Alice";
Console.WriteLine(student.Name); // Output: Alice
```

---

## ✅ Auto-Implemented Properties (C# 9 Compatible)

```csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}
```

**Usage:**

```csharp
var product = new Product { Id = 101, Name = "Laptop" };
Console.WriteLine($"ID: {product.Id}, Name: {product.Name}");
```

---

## ✅ Read-Only Property (Only Getter)

```csharp
public class Circle
{
    public double Radius { get; set; }

    public double Area
    {
        get { return Math.PI * Radius * Radius; }
    }
}
```

**Usage:**

```csharp
var circle = new Circle { Radius = 5 };
Console.WriteLine($"Area: {circle.Area}");
```

---

## ✅ Getters and Setters with Logic

```csharp
public class Employee
{
    private int salary;

    public int Salary
    {
        get { return salary; }
        set
        {
            if (value >= 0)
                salary = value;
            else
                throw new ArgumentException("Salary cannot be negative");
        }
    }
}
```

**Usage:**

```csharp
var emp = new Employee();
emp.Salary = 50000;
Console.WriteLine(emp.Salary);
```

---

## 🆕 C# 9 Feature: `init` Accessor

### ✅ What is Immutable?

**Immutable** means:

> ❌ *Cannot be changed after creation.*

Once a property is set, it **cannot be modified** later.

---

### ✅ What is `init`?

`init` is a new accessor introduced in **C# 9**.
It allows setting a property **only once during object creation**.

```csharp
public class Person
{
    public string Name { get; init; }
}
```

**Usage:**

```csharp
var p = new Person { Name = "Alice" }; // ✅ Allowed
// p.Name = "Bob"; // ❌ Compile-time error
```

---

## ✅ Example with Constructor and `init`

```csharp
public class Car
{
    public string Model { get; init; }
    public int Year { get; init; }

    public Car(string model)
    {
        Model = model;
    }
}
```

**Usage:**

```csharp
var car = new Car("Toyota") { Year = 2021 };
Console.WriteLine($"Model: {car.Model}, Year: {car.Year}");
```

---

## 🟨 Difference Between `set` and `init`

| Feature               | `set`        | `init`            |
| --------------------- | ------------ | ----------------- |
| Can modify later      | ✅ Yes        | ❌ No              |
| Set during init       | ✅ Yes        | ✅ Yes             |
| Supports immutability | ❌ No         | ✅ Yes             |
| Use case              | Mutable data | Immutable objects |

---

## ✅ Bonus: `record` Type + `init`

```csharp
public record Book
{
    public string Title { get; init; }
    public string Author { get; init; }
}
```

**Usage:**

```csharp
var book = new Book { Title = "1984", Author = "George Orwell" };
// book.Title = "Animal Farm"; // ❌ Not allowed
```

---

## 📌 Summary

* Use `get`/`set` for **mutable** properties.
* Use `init` for **immutable** properties set only during initialization.
* `init` helps create **safe, predictable, thread-safe** code.
* Combine `init` with `record` types for **concise, immutable models** in C# 9.






