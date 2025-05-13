



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


List<int> scores = [230,890,789,237];


//scores.Add(240);

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









































































































