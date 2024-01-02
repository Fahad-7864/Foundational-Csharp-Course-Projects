//Console.WriteLine("");
//Console.WriteLine("Floating point types:");
//Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
//Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
//Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");


//int[] data;
//data = new int[3];

//int[] data = new int[3];


//string data tyoe does not need to include the new
//string shortenedString = "Hello World!";
//Console.WriteLine(shortenedString);
//he new operator is used
//to allocate memory on the heap
//for a reference type.


/*
 * int for most whole numbers
    decimal for numbers representing money
    bool for true or false values
    string for alphanumeric value
 * byte: working with encoded data that comes from other computer systems or using different character sets.
    double: working with geometric or scientific purposes. double is used frequently when building games involving motion.
    System.DateTime for a specific date and time value.
    System.TimeSpan for a span of years / months / days / hours / minutes / seconds / millisecond
 * 
 * */



//Casting and Converting
//int first = 2;
//string second = "4";
//string result = first + second;
//Console.WriteLine(result);

//int myInt = 3;
//Console.WriteLine($"int: {myInt}");

//decimal myDecimal = myInt;
//Console.WriteLine($"decimal: {myDecimal}");


//decimal myDecimal = 3.14m;
//Console.WriteLine($"decimal: {myDecimal}");

//int myInt = (int)myDecimal;
//Console.WriteLine($"int: {myInt}");

//decimal myDecimal = 1.23456789m;
//float myFloat = (float)myDecimal;

//Console.WriteLine($"Decimal: {myDecimal}");
//Console.WriteLine($"Float  : {myFloat}");

//Int to String
//int first = 5;
//int second = 7;
//string message = first.ToString() + second.ToString();
//Console.WriteLine(message);

////String to Int
//string first = "5";
//string second = "7";
//int sum = int.Parse(first) + int.Parse(second);
//Console.WriteLine(sum);


//Using the Convert Method
//string value1 = "5";
//string value2 = "7";
//int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
//Console.WriteLine(result);


//Compare casting and converting a decimal into an int
//int value = (int)1.5m; // casting truncates
//Console.WriteLine(value);

//int value2 = Convert.ToInt32(1.5m); // converting rounds up
//Console.WriteLine(value2);

// Looking at the TryParse Method()

//string value = "bad";
//int result = 0;
//if (int.TryParse(value, out result))
//{
//    Console.WriteLine($"Measurement: {result}");
//}
//else
//{
//    Console.WriteLine("Unable to report the measurement.");
//}

//if (result > 0)
//    Console.WriteLine($"Measurement (w/ offset): {50 + result}");


//int sum = int.Parse(first) + int.Parse(second);

//Coding Challenge
//string[] values = { "12.3", "45", "ABC", "11", "DEF" };

//decimal total = 0m;
//string message = "";

//foreach (var value in values)
//{
//    decimal number; // stores the TryParse "out" value
//    if (decimal.TryParse(value, out number))
//    {
//        total += number;
//    }
//    else
//    {
//        message += value;
//    }
//}

//Console.WriteLine($"Message: {message}");
//Console.WriteLine($"Total: {total}");


//int value1 = 12;
//decimal value2 = 6.2m;
//float value3 = 4.3f;

//int result1 = value1 / (int)value2;

//// Your code here to set result1
//// Hint: You need to round the result to nearest integer (don't just truncate)
//Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

//decimal result2 = (decimal) value2 / (decimal) value3;

//Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

//float result3 = (float)value3 / (float)value1;

//Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");