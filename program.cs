



//bool a = true;
//bool b = true;
//bool c = false;
//bool d = false;


////Console.WriteLine(d || c);
//Console.WriteLine(!a && !c);



//int a = 10;
//int b = 20;

//Console.WriteLine(a <= b && a != b);
//Console.WriteLine(a <= b || a != b);
//Console.WriteLine(!(a <= b) || a != b);

//string a = "";
//do
//{
//    Console.WriteLine("Please write your name");

//    a = Console.ReadLine();

//} while (a == "");

//Console.WriteLine("Hello, " + a);





//Console.WriteLine("Please Enter your Age");
//String userAge = Console.ReadLine();

//if(int.Parse(userAge) > 18)
//{
//    Console.WriteLine("You are Eligible for vote");
//}
//else if (int.Parse(userAge) == 18)
//{
//   Console.WriteLine("Are you married");
//   Console.WriteLine("If yes Press 'Y', if no press 'N'");
//   String userMarriageStatus = Console.ReadLine();
//   String capitalUserMarriageStatus =  userMarriageStatus.ToUpper();

//    if(capitalUserMarriageStatus == "Y")
//    {
//        Console.WriteLine("Congratulation You are eligible for vote");
//    }
//    else if(capitalUserMarriageStatus == "N")
//    {
//        Console.WriteLine("Sorry you are not eligible for vote");
//    }
//    else
//    {
//        Console.WriteLine("Please give your answer in 'Y' or 'N'");
//    }



//}
//else
//{
//    Console.WriteLine("You are not elgible for vote");
//}




// LOOPS

// i = 1 + 1  //2 //i++
// i = i + 3 //4 //i+=3


//For
//for (int i = 1; i <= 100; i++)
//{
//    Console.WriteLine(i);
//}
//reverse counting
//for (int i = 100; i >= 1; i--)
//{
//    Console.WriteLine(i);
//}

//even
//for (int i = 2; i <= 100; i += 2)
//{
//    Console.WriteLine(i);
//}
//odd
//for (int i = 1; i <= 100; i += 2)
//{
//    Console.WriteLine(i);
//}
//5 table
//for (int i = 5; i <= 50; i += 5)
//{
//    Console.WriteLine(i);
//}


//for (int i = 0; i <= 40; i++)
//{
//    if( i%2 == 0)
//    {
//        Console.WriteLine("This is Even Number: "+i);
//    }
//    else
//    {
//        Console.WriteLine("This is Odd Number: " + i);
//    }
//}



// 2 x 1 = 2
// 2 x 2 = 4
// 2 x 3 = 6





//int[] scores = [200,300, 400, 500];
//int[] scores = new int[5];

//scores[0] = 343;
//scores[1] = 546;
//scores[2] = 6565;
//scores[3] = 345;
//scores[4] = 34534;
//scores[5] = 378;



//Console.WriteLine(scores[3]);

//for (int i = 0; i < scores.Length; i++)
//{
//    Console.WriteLine(scores[i]);
//}

//foreach (var item in scores)
//{
//    Console.WriteLine(item);
//}


// **************** ARRAY METHODS ********************
//int[] scores = new int[5];
//int[] scores = { 200, 300, 900, 400, 500 };
//string[] scores = {"200", "300", "900", "400", "500"};

//Array.Sort(scores);
//Array.Reverse(scores);
//Array.Clear(scores,0,3);

//Console.WriteLine(Array.IndexOf(scores, 900));

//scores[Array.IndexOf(scores, 900)] = 45654654;



//foreach (var item in scores)
//{
//    Console.WriteLine(item);
//}




//int[,] scores =
//{
//    { 434,545,656},
//    {44,667,878 }
//};

//for (int i = 0; i < scores.Length; i++)
//{
//    Console.WriteLine(scores[i]);

//}

//Console.WriteLine(scores[0,2]);


//foreach (var item in scores)
//{
//    Console.WriteLine(item);
//}


//List<int> scores = [230, 890,789,237];


//scores.Add("240");

//Console.WriteLine(scores[0]);
//Console.WriteLine(scores[1]);
//Console.WriteLine(scores[2]);
//Console.WriteLine(scores[3]);


//scores.Sort();
//scores.Reverse();
//scores.Remove(789);
//scores.RemoveAt(1);
//scores.RemoveAll( x => x > 400);
//scores.Clear();
//Console.WriteLine(scores.Contains(23));
//Console.WriteLine(scores.Count);
//scores.Insert(2, 500);
//var myScrores =scores.ToArray();
//Console.WriteLine(scores.Find(x => x > 400));

//Console.WriteLine(scores.IndexOf(237));

//Console.WriteLine(scores);
//Console.WriteLine(myScrores);

//foreach (var item in scores)
//{
//    Console.WriteLine(item);
//}

//var marks = new Dictionary<string, int>
//{
//    { "Amit", 85 },
//    { "Sara", 92 }
//};

//marks["John"] = 78;

//foreach (var kvp in marks)
//    {
//    Console.WriteLine($"{kvp.Key} scored {kvp.Value}");
//}


//var emails = new HashSet<string>();
//emails.Add("a@domain.com");
//emails.Add("b@domain.com");
//emails.Add("a@domain.com");


//Console.WriteLine(emails.Count);


//foreach (var email in emails)
//{
//    Console.WriteLine(email);
//}

//FIRST IN FIRST OUT (FIFO)
//var queue = new Queue<string>();
//queue.Enqueue("Customer1");
//queue.Enqueue("Customer2");
//queue.Enqueue("Customer3");

//Console.WriteLine("Items before Dequeue:");
//Console.WriteLine(queue.Dequeue());
//Console.WriteLine(queue.Dequeue());

//Console.WriteLine("Items after Dequeue:");

//foreach (var item in queue)
//{
//    Console.WriteLine(item);
//}



//LAST IN FIRST OUT (LIFO)

//var actions = new Stack<string>();
//actions.Push("Open File");
//actions.Push("Edit Text");

//Console.WriteLine("Items before Pop:");
//Console.WriteLine(actions.Pop());

//Console.WriteLine("Items after Pop:");

//foreach (var item in actions)
//{
//    Console.WriteLine(item);
//}




//using System.Collections;

//ArrayList list = new ArrayList();
//list.Add(10);
//list.Add("Hello");

////int x = (int)list[0];
////int y = (int)list[1]; // Runtime error

//foreach (var i in list)
//{
//    Console.WriteLine(i);
//}


// Class (Blueprint)


//Car mehran = new();

//mehran.brand = "Suzuki";

//mehran.speed = 100;

//mehran.drive();

//Car dala = new Car { brand= "Toyota Hilux", speed=120};

//dala.drive();

//Car civic = new();

//Console.WriteLine(civic.brand);
//Console.WriteLine(civic.speed);

//List<int> h = new() { 1,2,3,4,5};


//Console.WriteLine(h);


//public class Car
//{
//    //public string? brand;
//    public string brand = "Default brand";
//    public int speed;

//    public void drive()
//    {
//        Console.WriteLine($"Driving {brand} at {speed} km/h");
//    }
//}



// Encapsulation

//BankAccount amjadAccount = new();
////amjadAccount.balance = 200;

//amjadAccount.Deposit(780);

//Console.WriteLine(amjadAccount.GetBalance());

//BankAccount arifAccount = new();

//Console.WriteLine(arifAccount.GetBalance());


//public class BankAccount
//{
//    private double balance = 0;

//    public void Deposit(double amount)
//    {
//        if (amount > 0) balance += amount;
//    }

//    public double GetBalance()
//    {
//        return balance;
//    }
//}





//Dog dog = new();
//dog.Eat(); // from Animal
//dog.Bark();

//Cat tom = new();

//tom.Name = "Tom";
//tom.age = 2;
//tom.breed = "French";
//tom.color = "White";

//tom.Eat();
//tom.animalInfo();
////tom.Bark();

//public class Animal
//{
//    public string Name;
//    public int age;
//    public string breed;
//    public string color;
//    public void Eat() => Console.WriteLine("Eating");

//    //public void animalInfo() => Console.WriteLine("The {0} age is: {1} whose breed is: {2} and color is: {3}",Name,age,breed,color);
//    public void animalInfo() => Console.WriteLine($"The {Name} age is: {age} whose breed is: {breed} and color is: {color}");

//}

//public class Dog : Animal
//{
//    public void Bark() => Console.WriteLine("Barking");
//}

//public class Cat: Dog
//{

//}



// ACCESS MODIFIER

// PRIVATE, PROTECTED, PUBLIC


//string userCompanyName = Console.ReadLine();
//string userModel = Console.ReadLine();
//string userColor = Console.ReadLine();
//string userRam = Console.ReadLine();
//string userStorage = Console.ReadLine();
//string userScreenSize = Console.ReadLine();





//Mobile samsung = new()
//{
//    companyName = userCompanyName,
//    model = userModel,
//    color = userColor,
//    ram = userRam,
//    storage = userStorage,
//    screenSize = userScreenSize
//};


//Mobile samsung = new()
//{
//    companyName = "Infinix",
//    model = "Smart 8",
//    color = "Sky Blue",
//    ram = "8GB",
//    storage = "128GB",
//    launchingDate = "23-09-2024",
//    screenSize = "1080 x 1920",
//    //imeiNumber = "43895949359439"
//};
//samsung.mobileSpecification();


//Infinix smart8 = new()
//{
//    model = "Smart 8",
//    color = "Sky Blue",
//    ram = "8GB",
//    storage = "128GB",
//    launchingDate = "23-09-2024",
//    screenSize = "1080 x 1920",

//};

//smart8.changeCompanyName("Infinix");
//smart8.mobileSpecification();



//class Mobile
//{
//    public string companyName;
//    public string model;
//    public string color;
//    public string ram;
//    public string storage;
//    public string launchingDate;
//    public string screenSize;
//    //private string imeiNumber;
//    protected string imeiNumber;


//    public void mobileSpecification() => Console.WriteLine($"Company Name: {companyName}, Model: {model}, color: {color}, Ram: {ram}, Storage: {storage}, Realease on: {launchingDate}, Screen Resolution: {screenSize}, IMEI Number: {imeiNumber}");
//}



//class Infinix : Mobile
//{

//    public void changeCompanyName( string name)
//    {
//        companyName = name;
//    }

//    public void changeImei(string imei)
//    {
//        imeiNumber = imei;
//    }

//}



// POLYMORPHISM


// POLY --> MANY

// MORPHISM --> FORMS



//Animal an = new Animal(); an.Speak();
//Cat tom = new Cat(); tom.Speak();
//Dog tommy = new Dog(); tommy.Speak();

//public class Animal
//{
//    public virtual void Speak() => Console.WriteLine("Animal sound");
//}

//public class Cat : Animal
//{
//    public override void Speak() => Console.WriteLine("Meow");
//}

//public class Dog : Animal
//{
//    public override void Speak() => Console.WriteLine("Woof");
//}






//Animal an = new Animal(); an.Speak("Hipopotamus");
//Cat tom = new Cat(); tom.Speak("Tom", "2");
//Dog tommy = new Dog(); tommy.Speak("Tommy","4","Italian");

//public class Animal
//{
//    public void Speak(string name) => Console.WriteLine($"{name} sound unknown");
//}

//public class Cat : Animal
//{
//    public void Speak(string name, string age) => Console.WriteLine($"{name} sound:  Meow whose age is: {age}");
//}

//public class Dog : Animal
//{
//    public void Speak(string name, string age, string breed) => Console.WriteLine($"{name} sound:  Woof whose age is: {age} and breed is : {breed}");
//}



// ABSTRACTION

//Bike vehicle = new();
//vehicle.Start();
//public abstract class Vehicle
//{

//    public string Name;
//    public string modelName;
//    public string modelVersion;
//    public string airBags;
//    public virtual void Start() { } // only method signature

//    //public abstract void Start() => Console.WriteLine("Bike Started");
//    //public abstract void VehicleInfo();
//}

//public class Bike : Vehicle
//{
//    //public override void Start() => Console.WriteLine("Bike started");
//}



//public interface IVehicle
//{


//    public void Start();
//}


//public class Bike : IVehicle
//{

//    public void Start()
//    {
//        Console.WriteLine("");
//    }
//}


MeezanBank amirAccount = new();

amirAccount.bankBalance = 23000;

Console.WriteLine("Write deposited amount: ");
int depositedAmount = int.Parse(Console.ReadLine());

amirAccount.deposit(depositedAmount);


amirAccount.taxDeposit(230);

Console.WriteLine($"Meezan Bank of Amir: {amirAccount.bankBalance}");


AlfalahBank amirAccount2 = new();

amirAccount2.bankBalance = 10000;
amirAccount2.deposit(100);


Console.WriteLine($"Alfalah Bank of Amir: {amirAccount2.bankBalance}");


// ABSTRACTION

//public abstract class BankAccount
//{
//    public string accountHolderName;
//    public string accountNumber;
//    public string accountType;
//    public string pinCode;
//    public int bankBalance;


//    public virtual void deposit(int amount) { }

//    public virtual void withdraw(int amount) { }


//}



//public class MeezanBank : BankAccount
//{
//    public override void deposit(int amount)
//    {
//        bankBalance += amount;
//    }

//    public void withdraw(int amount)
//    {
//        bankBalance -= amount;
//    }


//}

//public class AlfalahBank : BankAccount
//{

//}


// INTERFACES

// public interface IBankAccount
// {
//     public void deposit(int amount);

//     public void withdraw(int amount);

// }


// public interface IGovtBankTax
// {
//     public void taxDeposit(int taxAmount);
// }


// public class MeezanBank : IBankAccount, IGovtBankTax
// {
//     public string accountHolderName;
//     public string accountNumber;
//     public string accountType;
//     public string pinCode;
//     public int bankBalance;


//     public void deposit(int amount)
//     {

//         bankBalance += amount;

 
// }


//     public void taxDeposit(int taxAmount)
//     {
//         if(bankBalance >= 50000)
//         {
//             bankBalance -= taxAmount;
//         }
//     }

//     public void withdraw(int amount)
//     {
//         bankBalance -= amount;
//     }


// }

// public class AlfalahBank : IBankAccount
// {
//     public string accountHolderName;
//     public string accountNumber;
//     public string accountType;
//     public string pinCode;
//     public int bankBalance;
//     public void deposit(int amount)
//     {

//         bankBalance += amount;
//     }
//     public void withdraw(int amount)
//     {
//         bankBalance -= amount;
//     }
// }






// MeezanBank liaqatAccount = new ("Liaqat Ali Khan",234324324324,40000);
// //liaqatAccount.accountHolderName = "Liaqat Ali Khan";

// //liaqatAccount.bankBalance = 20000;
// //liaqatAccount.accountNumber = 743583782878432;
// //liaqatAccount.pinCode = 3432;


// Console.WriteLine($"{liaqatAccount.accountHolderName}, {liaqatAccount.accountNumber}, {liaqatAccount.bankBalance}, {liaqatAccount.pinCode}");





// public class BankAccount
// {
//     public string accountHolderName;
//     public double accountNumber;
//     public int bankBalance;
//     public int pinCode;

//     public BankAccount(string accountHolderName, double accountNumber, int bankBalance)
//     {
//         this.accountHolderName = accountHolderName;
//         this.accountNumber = accountNumber;
//         this.bankBalance = bankBalance;

//     }

//     public BankAccount(string accountHolderName, double accountNumber, int bankBalance, int pinCode)
//     {
//         this.accountHolderName = accountHolderName;
//         this.accountNumber = accountNumber;
//         this.bankBalance = bankBalance;
//         this.pinCode = pinCode;
//     }


//     public void deposit(int amount)
//     {
//         bankBalance += amount;
//     }

//     public void withdraw(int amount)
//     {
//         bankBalance -= amount;
//     }
// }


// public class MeezanBank : BankAccount
// {
//     public MeezanBank(string accountHolderName, double accountNumber, int bankBalance, int pinCode) : base(accountHolderName, accountNumber, bankBalance, pinCode)
//     {
//     }
//     public MeezanBank(string accountHolderName, double accountNumber, int bankBalance): base
//         (accountHolderName, accountNumber, bankBalance)
//     { }
// }



//BankAccount azeemAccount = new();

//BankAccount.deposit(299);

//Console.WriteLine(BankAccount.bankBalance);



//public static class BankAccount
//{
//    public static string accountHolderName = "Azeem";
//    public static int bankBalance = 100;

//    public static void deposit(int amount)
//    {
//        bankBalance += amount;
//    }
//}










//Student amir = new();
//amir.StudentAge = 200;
//amir.studentName = "Amir";
//amir.studentClass = "Matric";

//Console.WriteLine($"{amir.studentName}, {amir.studentClass}, {amir.StudentAge}");



//public class Student
//{
//    public string studentName;
//    private int studentAge;
//    public string studentClass;

//    public int StudentAge
//    {
//        get { return studentAge; }
//        set
//        {
//            if (value <= 20)
//            {
//                studentAge = value;
//            }
//            else
//            {
//                throw new Exception("Kindly enter valid age between 1 to 20");
//            }

//        }
//    }




//}


//Circle circle = new();
//circle.Radius = 23;
////circle.Area = 23;
//Console.WriteLine(circle.Area);
//public class Circle
//{
//    public double Radius { get; set; }

//    public double Area
//    {
//        get { return Math.PI * Radius * Radius; }
//    }
//}


//Car mehran = new("2024") { Year= 2023};
////mehran.Year = 2023;
////mehran.Model = 2022;
///onsole.WriteLine($"{mehran.Model}, {mehran.Year}");
//public class Car
//{
//    public string Model { get; init; }
//    public int Year { get; init; }
//    public Car(string model)
//    {
//        Model = model;
//    }
//}



Book book1 = new() { publishedYear= 2023};
//book1.publishedYear = 2023;
book1.bookName = "Tale of the Nine Tailed";
Console.WriteLine($"{book1.bookName}, {book1.publishedYear}");

public record Book
{
    public int publishedYear { get; init; }
    public string bookName { get; set; }
}
































































































































