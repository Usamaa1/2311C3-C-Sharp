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

## 🧩 1. Class & Object

> **Class** = Blueprint
> **Object** = Real thing made from blueprint

### Real-life Example:
- Class: "Car"
- Object: "My Honda City"

### Code:
```csharp
class Car
{
    public string Model;
    public void Drive() => Console.WriteLine($"{Model} is driving");
}

var myCar = new Car { Model = "Honda City" };
myCar.Drive();
```

---

## 🧱 2. Encapsulation

> Wrapping data and methods into a single unit and restricting access using **access modifiers**.

### Real-life Example:
- Medicine in capsule = safe, cannot access inner chemicals directly

### Code:
```csharp
class BankAccount
{
    private double balance;

    public void Deposit(double amount)
    {
        if (amount > 0) balance += amount;
    }

    public double GetBalance() => balance;
}

var acc = new BankAccount();
acc.Deposit(1000);
Console.WriteLine(acc.GetBalance());
```

---

## 👨‍👩‍👧 3. Inheritance

> One class can inherit features of another.

### Real-life Example:
- Child inherits from parent

### Code:
```csharp
class Animal
{
    public void Eat() => Console.WriteLine("Eating...");
}

class Dog : Animal
{
    public void Bark() => Console.WriteLine("Barking...");
}

var dog = new Dog();
dog.Eat();
dog.Bark();
```

---

## 🎭 4. Polymorphism

> Same name, different behavior

### Types:
- Compile-time (Method Overloading)
- Runtime (Method Overriding)

### Real-life Example:
- "Draw" can mean drawing a line, circle, or square

### Code:
```csharp
class Shape
{
    public virtual void Draw() => Console.WriteLine("Drawing shape");
}

class Circle : Shape
{
    public override void Draw() => Console.WriteLine("Drawing Circle");
}

Shape s = new Circle();
s.Draw(); // Output: Drawing Circle
```

---

## 🧪 5. Abstraction

> Hiding complex logic and showing only important parts

### Real-life Example:
- TV Remote: You know buttons, not the wiring

### Code:
```csharp
abstract class Payment
{
    public abstract void Pay();
}

class CreditCard : Payment
{
    public override void Pay() => Console.WriteLine("Paid with Credit Card");
}

Payment payment = new CreditCard();
payment.Pay();
```

---

## ✅ Summary Table

| Concept        | Meaning                             | Example                         |
|----------------|-------------------------------------|----------------------------------|
| Class/Object   | Blueprint and instance              | `Car myCar = new Car();`        |
| Encapsulation  | Hide data using private             | `private double balance;`       |
| Inheritance    | One class from another              | `class Dog : Animal`            |
| Polymorphism   | Many forms                          | `Draw()` in `Circle`, `Square`  |
| Abstraction    | Hide complexity, show purpose       | `abstract class`, `interface`   |

Would you like hands-on activities or a quiz for OOP next?





