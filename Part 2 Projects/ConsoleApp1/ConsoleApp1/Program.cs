//Random dice = new Random();
//int roll1 = dice.Next();
//int roll2 = dice.Next(101);
//int roll3 = dice.Next(50, 101);

//Console.WriteLine($"First roll: {roll1}");
//Console.WriteLine($"Second roll: {roll2}");
//Console.WriteLine($"Third roll: {roll3}");


//Create a math solution that returns the higher of two numbers
//create a method


//int firstValue = 800;
//int secondValue = 600;
//int largerValue;


//Console.WriteLine(System.Math.Max(firstValue, secondValue));







//string message = "The quick brown fox jumps over the lazy dog.";
//bool result = message.Contains("dog");
//Console.WriteLine(result);

//if (message.Contains("fox"))
//{
//    Console.WriteLine("What does the fox say?");
//}

//Random dice = new Random();

//int roll1 = dice.Next(1, 7);
//int roll2 = dice.Next(1, 7);
//int roll3 = dice.Next(1, 7);
//roll1 = 6;
//roll2 = 6;
//roll3 = 6;


//int total = roll1 + roll2 + roll3;

//Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
//{
//    if ((roll1 == roll2) && (roll2 == roll3))
//    {
//        Console.WriteLine("You rolled triples!  +6 bonus to total!");
//        total += 6;
//    }
//    else
//    {
//        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//        total += 2;
//    }
//}

//if (total >= 16)
//{
//    Console.WriteLine("You win a new car!");
//}
//else if (total >= 10)
//{
//    Console.WriteLine("You win a new laptop!");
//}
//else if (total == 7)
//{
//    Console.WriteLine("You win a trip for two!");
//}
//else
//{
//    Console.WriteLine("You win a kitten!");
//}




//Random random = new Random();
//int daysUntilExpiration = random.Next(12);
//int discountPercentage = 0;
//Console.WriteLine(daysUntilExpiration);



// if (daysUntilExpiration <= 0)
//{
//    Console.WriteLine("Your subscription has expired!");
//}
//else if (daysUntilExpiration <= 1)
//{
//    Console.WriteLine($"Your subscription expries within a day!\n Renew now and save 20% ");
//}
//else if (daysUntilExpiration <= 5)
//{
//    Console.WriteLine($"Your subscription expires in {0} days. \n Renew now and save 10%!", daysUntilExpiration);
//}
//else if (daysUntilExpiration < 10){
//    Console.WriteLine("Your subscription will expire soon. Renew now!");
//}
//else
//{
//    Console.WriteLine(" ");
//}


//Basics with Array:
//string[] fraudelentOrderIDS = new string[3];
//fraudelentOrderIDS[0] = "A123";
//fraudelentOrderIDS[1] = " B456";
//fraudelentOrderIDS[2] = "C789";
//fraudelentOrderIDS[3] = "D000";

//string[] fraudulentOrderIDS = { "A123", "B456", "C789" };
//Console.WriteLine($"First: {fraudulentOrderIDS[0]}");
//Console.WriteLine($"Second: {fraudulentOrderIDS[1]}");
//Console.WriteLine($"Third: {fraudulentOrderIDS[2]}");

//fraudulentOrderIDS[0] = "F000";
//Console.WriteLine($"Reassign first: {fraudulentOrderIDS[0]}");

//Console.WriteLine($"There are {fraudulentOrderIDS.Length} fraudulent orders to process.");

//string[] names = { "Rowena", "Robin", "Bao" };


// For Each
//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}

//int[] inventory = { 200, 450, 700, 175, 250 };
//int sum = 0;
//int bin = 0;
//foreach (int it in inventory)
//{
//    sum += it;
//    bin++; C
//    Console.WriteLine($"Bin{bin}= {it} items (running total@ {sum})");

//    //Console.WriteLine($"We have {it}");
//}
//Console.WriteLine($"We have {sum} items in inventory.");

//Code Challenge Fraudelent Case
//string[] arr = new string[8];

//string[] arr =  { "B123",
//"C234",
//"A345",
//"C15",
//"B177",
//"G3003",
//"C235",
//"B179"};



//foreach (string s in arr)
//{
//  if (s.StartsWith("B")){`    hite Space




//White Space
//Random dice = new Random();

//int roll1 = dice.Next(1, 7);
//int roll2 = dice.Next(1, 7);
//int roll3 = dice.Next(1, 7);

//int total = roll1 + roll2 + roll3;
//Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
//{
//    if ((roll1 == roll2) && (roll2 == roll3))
//    {
//        Console.WriteLine("You rolled triples!  +6 bonus to total!");
//        total += 6;
//    }
//    else
//    {
//        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//        total += 2;
//    }
//}



//Coding readabillity Challenge
string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");

/*
   the code reverses a message andcounts the number of times 
   a particular character appears, then prints the results
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";
char[] message = originalMessage.ToCharArray();
Array.Reverse(message);
int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);
Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");