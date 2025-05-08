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
