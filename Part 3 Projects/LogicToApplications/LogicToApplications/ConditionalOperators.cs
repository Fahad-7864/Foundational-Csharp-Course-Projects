//Equality and inequality operators

//Console.WriteLine("a" == "a");
//Console.WriteLine("a" == "A");
//Console.WriteLine(1 == 2);

//string myValue = "a";
//Console.WriteLine(myValue == "a");


//string value1 = " a";
//string value2 = "A ";
//Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower())

//!= section
//Console.WriteLine("a"!= "a");
//Console.WriteLine("a" != "A");
//Console.WriteLine(1 != 2);

//string myValue = "a";
//Console.WriteLine(myValue != "a");

// > and < section
//Console.WriteLine(1 > 2);
//Console.WriteLine(1 < 2);
//Console.WriteLine(1 >= 1);
//Console.WriteLine(1 <= 1);

// the ! operator
//string pangram = "The quick brown fox jumps over the lazy dog";
////Console.WriteLine(pangram.Contains("fox"));
////Console.WriteLine(pangram.Contains("cow"));

//Console.WriteLine(pangram.Contains("fox") == false);
//Console.WriteLine(pangram.Contains("fox"));

////the ! operator is essentially saying does the pangram not contain fox or cow
//Console.WriteLine(!pangram.Contains("fox"));
//Console.WriteLine(!pangram.Contains("cow"));


//int a = 7;
//int b = 6;
//Console.WriteLine(a != b); // output: True
//string s1 = "Hello";
//string s2 = "Hello";
//Console.WriteLine(s1 != s2); // output: False


//? operator
//so what this does right it looks at the conditional statement so below
//there are two examples string category basically tells you that if
// the age is greater than or equal to 18 then the category is adult
//so the first part of the statement after the ? is used
// if the condition is fault then the second part of the condition is then used

//int saleAmount = 101;
//int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

//int age = 20;
//string category = age >= 18 ? "Adult" : "Minor";
//Console.WriteLine(category); // Outputs: Adult


//Code Challenge: Coin flip:


//Random rnd = new Random();
//int a= rnd.Next(1, 2);
//Console.WriteLine( a );
//Console.WriteLine($"The outcome is {(a >= 2 ? "Tails":"Heads")}");

//string permission = "Admin";
//int level = 1;

//if (permission.Contains("Admin") && level > 55) {
//    Console.WriteLine("Welcome Super admin");
//}
//else if (permission.Contains("Admin") && level  <= 55 && level !> 21)
//{
//    Console.WriteLine("Welcome, Admin user");
//}
//else if (permission.Contains("Manager") && level > 20)
//{
//    Console.WriteLine("contact an admin for acess");
//}
//else if (permission.Contains("Admin")&& level < 20)
//{
//    Console.WriteLine(" you do not have sufficent privelages");
//}
//else
//{
//    Console.WriteLine("you do not have sufficent privelages");
//}

//if (permission.Contains("Admin") && level > 0 ? "True" : "False") 

//Code Blocks

//bool flag = true;
//int value = 0;

//if (flag)
//{
//    value = 10;
//    Console.WriteLine($"Inside of code block: {value}");
//}
//Console.WriteLine($"Outside of code block: {value}");

//bool flag = true;
//if (flag) Console.WriteLine(flag);


//string name = "steve";
//if (name == "bob") Console.WriteLine("Found Bob");
//else if (name == "steve") Console.WriteLine("Found Steve");
//else Console.WriteLine("Found Chuck");

//string name = "steve";

//if (name == "bob")
//    Console.WriteLine("Found Bob");
//else if (name == "steve")
//    Console.WriteLine("Found Steve");
//else
//    Console.WriteLine("Found Chuck");




//int[] numbers = { 4, 8, 15, 16, 23, 42 };

//int total = 0;
//bool found = false;

//foreach (int number in numbers)
//{
//    total += number;

//    if (number == 42)
//    {
//        found = true;
//    }
//}

//if (found)
//{
//    Console.WriteLine("Set contains 42");
//}

//Console.WriteLine($"Total: {total}");


//Branch the flow of code using switch-case


//int employeeLevel = 100;
//string employeeName = "John Smith";

//string title = "";

//switch (employeeLevel)
//{
//    case 100:
//    case 200:
//    case 25:
//        title = "Senior Associate";
//        break;
//    case 300:
//        title = "Manager";
//        break;
//    case 400:
//        title = "Senior Manager";
//        break;
//    default:
//        title = "Associate";
//        break;
//}

//Console.WriteLine($"{employeeName}, {title}");

//Coding Challenge Convert to switch case statement

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
//string sku = "01-MN-L";

//string[] product = sku.Split('-');

//string type = "";
//string color = "";
//string size = "";


//switch (product[0])
//{
//    case "01":
//        type = "Sweat shirt";
//            break;
//    case "02":
//        type = "T-Shirt";
//        break;
//    case "03":
//        type = "Sweat pants";
//            break;
//    default:
//        type = "other";
//        break;
//}

//switch (product[1])
//{
//    case "BL":
//        color = "Black";
//        break;
//    case "MN":
//        color = "Maroon";
//                break;
//    default:
//        color= "White";
//        break;
//}


//switch (product[2])
//{
//    case "S":
//        size = "Small";
//        break;
//    case "M":
//        size = "Medium";
//        break;
//    case "L":
//        size = "Large";
//           break;
//    default:
//        size = "one size fits all";
//        break;
//}



//Console.WriteLine($"Product: {size} {color} {type}");


//For iteration Loops
using System;

//for (int i =0; i < 10; i++)
//{
//    global::System.Console.WriteLine(i);
//}

//for (int i= 10; i>=0; i--)
//{
//    global::System.Console.WriteLine(i);
//}

//for (int i =0; i<=35; i += 5)
//{
//    global::System.Console.WriteLine(i);
//}

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//    if (i == 7) break;
//}

//string[] names = { "Alex", "Eddie", "David", "Michael" };

//for (int i=0; i < names.Length; i++)
//{
//    global::System.Console.WriteLine(names[i]);
//    if (names[i] == "David") break;

//}

//limitations of the for each
//string[] names = { "Alex", "Eddie", "David", "Michael" };
//foreach (var name in names)
//{
//    // Can't do this:
//    if (name == "David") name = "Sammy";
//}

//string[] names = { "Alex", "Eddie", "David", "Michael" };
//for (int i = 0; i < names.Length; i++)
//    if (names[i] == "David") names[i] = "Sammy";

//foreach (var name in names) Console.WriteLine(name);



////Fizz Buzz Challenge
//for (int i = 0; i < 100; i++)
//{
//    if (i % 5 == 0 && i % 3 == 0)
//    {
//        Console.WriteLine($"{i} FizzBuzz");
//    }
//    else if (i % 3 == 0)
//    {
//        Console.WriteLine($"{i}: Fizz");
//    }
//    else if (i % 5 == 0)
//    {
//        Console.WriteLine($"{i} Buzz");
//    }
//    else { Console.WriteLine($"{i}");

//    }
//}


//Do while statements
//so the do while statement essentially executes code
//in the do section until the while loop is true!
//Random random = new Random();
//int current = random.Next(1, 11);

//do
//{
//    current = random.Next(1, 11);

//    if (current >= 8) continue;

//    Console.WriteLine(current);
//} while (current != 7);

///*
//while (current >= 3)
//{
//    Console.WriteLine(current);
//    current = random.Next(1, 11);
//}
//Console.WriteLine($"Last number: {current}");
//*/


//Coding Challenge game rules


//Random att = new Random();
//int rand = 0;
//rand = att.Next(1,10);
//var monsterhp= 10;
//var herohp = 10;
//do
//{
//    monsterhp -= rand;
//    Console.WriteLine($"Monster was damaged {monsterhp}");

//    if (monsterhp <= 0) continue;
//    herohp -= rand;
//    Console.WriteLine($"Hero was damaged {herohp}");
//}
//while (monsterhp ==0 && herohp == 0);

//Console.WriteLine(herohp > monsterhp ? "Hero wins!" : "Monster wins!");


////Managing user input
//string? readResult;
//bool validEntry = false;
//Console.WriteLine("Enter a string containing at least three characters:");
//do
//{
//    readResult = Console.ReadLine();
//    if (readResult != null)
//    {
//        if (readResult.Length >= 3)
//        {
//            validEntry = true;
//        }
//        else
//        {
//            Console.WriteLine("Your input is invalid, please try again.");
//        }
//    }
//} while (validEntry == false);
//// capture user input in a string variable named readResult





//string? readresult;
//int numericValue = 0;
//bool validNumber = false;
//Console.WriteLine("Enter an integer");
//do
//{
//    readresult = Console.ReadLine();
//    validNumber = int.TryParse(readresult, out numericValue);

//    if (readresult != null)
//    {
//        if (numericValue >= 5 && numericValue <= 10)
//        {
//         validNumber = true;
//        }
//        else
//        {
//            Console.WriteLine("Your input is invalid");
//        }
//    }

//}
//while (validNumber == false && numericValue>5 );


//string? readresult;
//bool validString = false;
//Console.WriteLine("Enter your role name (administrator, Manager, User");
//do
//{
//    readresult = Console.ReadLine();

//    if (readresult != null)
//    {
//        readresult = readresult.Trim();
//        if (readresult.Contains("Administrator")&&readresult.Contains("Manager") && readresult.Contains("User"))
//        {
//            Console.WriteLine("Your input is Valid!");
//            validString = true;
//        }
//        else
//        {
//            Console.WriteLine("Your input is invalid");
//        }
//    }

//}
//while (!validString );


int periodLocation = 0; 
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
Console.WriteLine(myStrings[1]);
string myString = "h.i.you.there.";
Console.WriteLine(myStrings.IndexOf(myStrings));

//for (int i=0; i<myStrings.index; i++)
//{
//    //Console.WriteLine(myStrings[0]);
//    //string myString = myStrings[i];
//    //Console.WriteLine(myString[i]);
//}