



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





Console.WriteLine("Please Enter your Age");
String userAge = Console.ReadLine();

if(int.Parse(userAge) > 18)
{
    Console.WriteLine("You are Eligible for vote");
}
else if (int.Parse(userAge) == 18)
{
   Console.WriteLine("Are you married");
   Console.WriteLine("If yes Press 'Y', if no press 'N'");
   String userMarriageStatus = Console.ReadLine();
   String capitalUserMarriageStatus =  userMarriageStatus.ToUpper();

    if(capitalUserMarriageStatus == "Y")
    {
        Console.WriteLine("Congratulation You are eligible for vote");
    }
    else if(capitalUserMarriageStatus == "N")
    {
        Console.WriteLine("Sorry you are not eligible for vote");
    }
    else
    {
        Console.WriteLine("Please give your answer in 'Y' or 'N'");
    }
}
else
{
    Console.WriteLine("You are not elgible for vote");
}





























