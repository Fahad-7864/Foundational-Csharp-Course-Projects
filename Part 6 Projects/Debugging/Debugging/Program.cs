//string[] students = new string[] { "Sophia", "Nicolas", "Zahirah", "Jeong" };

//int studentCount = students.Length;

//Console.WriteLine("The final name is: " + students[studentCount]);



///* 
//This code uses a names array and corresponding methods to display
//greeting messages
//*/

//string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

//string messageText = "";

//foreach (string name in names)
//{
//    if (name == "Sophia")
//        messageText = SophiaMessage();
//    else if (name == "Andrew")
//        messageText = AndrewMessage();
//    else if (name == "AllGreetings")
//        messageText = SophiaMessage();
//    messageText = messageText + "\n\r" + AndrewMessage();

//    Console.WriteLine(messageText + "\n\r");
//}

//bool pauseCode = true;
//while (pauseCode == true) ;

//static string SophiaMessage()
//{
//    return "Hello, my name is Sophia.";
//}

//static string AndrewMessage()
//{
//    return "Hi, my name is Andrew. Good to meet you.";
//}



//int productCount = 2000;
//string[,] products = new string[productCount, 2];

//LoadProducts(products, productCount);

//for (int i = 0; i < productCount; i++)
//{
//    string result;
//    result = Process1(products, i);

//    if (result != "obsolete")
//    {
//        result = Process2(products, i);
//    }
//}

//bool pauseCode = true;
//while (pauseCode == true) ;


//static void LoadProducts(string[,] products, int productCount)
//{
//    Random rand = new Random();

//    for (int i = 0; i < productCount; i++)
//    {
//        int num1 = rand.Next(1, 10000) + 10000;
//        int num2 = rand.Next(1, 101);

//        string prodID = num1.ToString();

//        if (num2 < 91)
//        {
//            products[i, 1] = "existing";
//        }
//        else if (num2 == 91)
//        {
//            products[i, 1] = "new";
//            prodID = prodID + "-n";
//        }
//        else
//        {
//            products[i, 1] = "obsolete";
//            prodID = prodID + "-0";
//        }

//        products[i, 0] = prodID;
//    }
//}


//static string Process1(string[,] products, int item)
//{
//    Console.WriteLine($"Process1 message - working on {products[item, 1]} product");

//    return products[item, 1];
//}

//static string Process2(string[,] products, int item)
//{
//    Console.WriteLine($"Process2 message - working on product ID #: {products[item, 0]}");
//    if (products[item, 1] == "new")
//        Process3(products, item);

//    return "continue";
//}

//static void Process3(string[,] products, int item)
//{
//    Console.WriteLine($"Process3 message - processing product information for 'new' product");
//}





//string? readResult;
//int startIndex = 0;
//bool goodEntry = false;

//int[] numbers = { 1, 2, 3, 4, 5 };

//// Display the array to the console.
//Console.Clear();
//Console.Write("\n\rThe 'numbers' array contains: { ");
//foreach (int number in numbers)
//{
//    Console.Write($"{number} ");
//}

//// To calculate a sum of array elements, 
////  prompt the user for the starting element number.
//Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
//while (goodEntry == false)
//{
//    readResult = Console.ReadLine();
//    goodEntry = int.TryParse(readResult, out startIndex);

//    if (startIndex > 5)
//    {
//        goodEntry = false;
//        Console.WriteLine("\n\rEnter an integer value between 1 and 5");
//    }
//}

//// Display the sum and then pause.
//Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex)}");

//Console.WriteLine("press Enter to exit");
//readResult = Console.ReadLine();

//// This method returns the sum of elements n through 5
//static int SumValues(int[] numbers, int n)
//{
//    int sum = 0;
//    for (int i = n; i < numbers.Length; i++)
//    {
//        sum += numbers[i];
//    }
//    return sum;
//}



//bool exit = false;
//var rand = new Random();
//int num1 = 5;
//int num2 = 5;

//do
//{
//    num1 = rand.Next(1, 11);
//    num2 = num1 + rand.Next(1, 51);

//} while (exit == false);


////Implement a simple try-catch


//double float1 = 3000.0;
//double float2 = 0.0;
//int number1 = 3000;
//int number2 = 0;

//Console.WriteLine(float1 / float2);
//Console.WriteLine(number1 / number2);
//Console.WriteLine("Exit program");


//try
//{
//    Process1();
//}
//catch
//{
//    Console.WriteLine("An exception has occurred");
//}

//Console.WriteLine("Exit program");

//static void Process1()
//{
//    WriteMessage();
//}

//static void WriteMessage()
//{
//    double float1 = 3000.0;
//    double float2 = 0.0;
//    int number1 = 3000;
//    int number2 = 0;

//    Console.WriteLine(float1 / float2);
//    Console.WriteLine(number1 / number2);
//}



//try
//{
//    Process1();
//}
//catch
//{
//    Console.WriteLine("An exception has occurred");
//}

//Console.WriteLine("Exit program");

//static void Process1()
//{
//    try
//    {
//        WriteMessage();
//    }
//    catch
//    {
//        Console.WriteLine("Exception caught in Process1");
//    }

//}

//static void WriteMessage()
//{
//    double float1 = 3000.0;
//    double float2 = 0.0;
//    int number1 = 3000;
//    int number2 = 0;

//    Console.WriteLine(float1 / float2);
//    Console.WriteLine(number1 / number2);
//}




////Trying to catch specific exceptions.
//try
//{
//    Process1();
//}
//catch
//{
//    Console.WriteLine("An exception has occurred");
//}

//Console.WriteLine("Exit program");

//static void Process1()
//{
//    try
//    {
//        WriteMessage();
//    }
//    catch
//    {
//        Console.WriteLine("Exception caught in Process1");
//    }
//}

//static void WriteMessage()
//{
//    double float1 = 3000.0;
//    double float2 = 0.0;
//    int number1 = 3000;
//    int number2 = 0;

//    Console.WriteLine(float1 / float2);
//    Console.WriteLine(number1 / number2);
//}

//static void Process1()
//{
//    try
//    {
//        WriteMessage();
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
//    }
//}


//static void Process1()
//{
//    try
//    {
//        WriteMessage();
//    }
//    catch (DivideByZeroException ex)
//    {
//        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
//    }
//}


//static void WriteMessage()
//{
//    double float1 = 3000.0;
//    double float2 = 0.0;
//    int number1 = 3000;
//    int number2 = 0;
//    byte smallNumber;

//    Console.WriteLine(float1 / float2);
//    // Console.WriteLine(number1 / number2);
//    checked
//    {
//        smallNumber = (byte)number1;
//    }
//}



//static void WriteMessage()
//{
//    double float1 = 3000.0;
//    double float2 = 0.0;
//    int number1 = 3000;
//    int number2 = 0;
//    byte smallNumber;

//    Console.WriteLine(float1 / float2);
//    Console.WriteLine(number1 / number2);
//    checked
//    {
//        smallNumber = (byte)number1;
//    }
//}


//static void WriteMessage()
//{
//    double float1 = 3000.0;
//    double float2 = 0.0;
//    int number1 = 3000;
//    int number2 = 0;
//    byte smallNumber;

//    try
//    {
//        Console.WriteLine(float1 / float2);
//        Console.WriteLine(number1 / number2);
//    }
//    catch (DivideByZeroException ex)
//    {
//        Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
//    }
//    checked
//    {
//        smallNumber = (byte)number1;
//    }
//}


//// Catch separate exception types in a code block
//// inputValues is used to store numeric values entered by a user
//string[] inputValues = new string[] { "three", "9999999999", "0", "2" };

//foreach (string inputValue in inputValues)
//{
//    int numValue = 0;
//    try
//    {
//        numValue = int.Parse(inputValue);
//    }
//    catch (FormatException)
//    {
//        Console.WriteLine("Invalid readResult. Please enter a valid number.");
//    }
//    catch (OverflowException)
//    {
//        Console.WriteLine("The number you entered is too large or too small.");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}



//checked
//{
//    try
//    {
//        int num1 = int.MaxValue;
//        int num2 = int.MaxValue;
//        int result = num1 + num2;
//        Console.WriteLine("Result: " + result);
//    }
//    catch (OverflowException ex)
//    {
//        Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
//    }
//}

//try
//{
//    string? str = null;
//    int length = str.Length;
//    Console.WriteLine("String Length: " + length);
//}
//catch (NullReferenceException ex)
//{
//    Console.WriteLine("Error: The reference is null. " + ex.Message);
//}

//try
//{
//    int[] numbers = new int[5];
//    numbers[5] = 10;
//    Console.WriteLine("Number at index 5: " + numbers[5]);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine("Error: Index out of range. " + ex.Message);
//}

//try
//{
//    int num3 = 10;
//    int num4 = 0;
//    int result2 = num3 / num4;
//    Console.WriteLine("Result: " + result2);
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
//}

//Console.WriteLine("Exiting program.");




//try
//{
//    OperatingProcedure1();
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//    Console.WriteLine("Exiting application.");
//}

//static void OperatingProcedure1()
//{
//    string[][] userEnteredValues = new string[][]
//    {
//        new string[] { "1", "two", "3"},
//        new string[] { "0", "1", "2"}
//    };

//    foreach (string[] userEntries in userEnteredValues)
//    {
//        try
//        {
//            BusinessProcess1(userEntries);
//        }
//        catch (Exception ex)
//        {
//            if (ex.StackTrace.Contains("BusinessProcess1"))
//            {
//                if (ex is FormatException)
//                {
//                    Console.WriteLine(ex.Message);
//                    Console.WriteLine("Corrective action taken in OperatingProcedure1");
//                }
//                else if (ex is DivideByZeroException)
//                {
//                    Console.WriteLine(ex.Message);
//                    Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

//                    // re-throw the original exception
//                    throw;
//                }
//                else
//                {
//                    // create a new exception object that wraps the original exception
//                    throw new ApplicationException("An error occurred - ", ex);
//                }
//            }
//        }

//    }
//}

//static void BusinessProcess1(String[] userEntries)
//{
//    int valueEntered;

//    foreach (string userValue in userEntries)
//    {
//        try
//        {
//            valueEntered = int.Parse(userValue);

//            checked
//            {
//                int calculatedValue = 4 / valueEntered;
//            }
//        }
//        catch (FormatException)
//        {
//            FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
//            throw invalidFormatException;
//        }
//        catch (DivideByZeroException)
//        {
//            DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
//            throw unexpectedDivideByZeroException;

//        }
//    }
//}



//// Prompt the user for the lower and upper bounds
//Console.Write("Enter the lower bound: ");
//int lowerBound = int.Parse(Console.ReadLine());

//Console.Write("Enter the upper bound: ");
//int upperBound = int.Parse(Console.ReadLine());

//decimal averageValue = 0;

//// Calculate the sum of the even numbers between the bounds
//averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

//// Display the value returned by AverageOfEvenNumbers in the console
//Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

//// Wait for user input
//Console.ReadLine();

//static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
//{
//    int sum = 0;
//    int count = 0;
//    decimal average = 0;

//    for (int i = lowerBound; i <= upperBound; i++)
//    {
//        if (i % 2 == 0)
//        {
//            sum += i;
//            count++;
//        }
//    }

//    average = (decimal)sum / count;

//    return average;
//}


//bool exit = false;

//do
//{
//    try
//    {
//        // Calculate the sum of the even numbers between the bounds
//        averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

//        // Display the result to the user
//        Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

//        exit = true;
//    }
//    catch (ArgumentOutOfRangeException ex)
//    {
//        Console.WriteLine("An error has occurred.");
//        Console.WriteLine(ex.Message);
//        Console.WriteLine($"The upper bound must be greater than {lowerBound}");
//        Console.Write($"Enter a new upper bound (or enter Exit to quit): ");
//        string? userResponse = Console.ReadLine();
//        if (userResponse.ToLower().Contains("exit"))
//        {
//            exit = true;
//        }
//        else
//        {
//            exit = false;
//            upperBound = int.Parse(userResponse);
//        }
//    }
//} while (exit == false);




//string[][] userEnteredValues = new string[][]
//{
//            new string[] { "1", "2", "3"},
//            new string[] { "1", "two", "3"},
//            new string[] { "0", "1", "2"}
//};

//string overallStatusMessage = "";

//overallStatusMessage = Workflow1(userEnteredValues);

//if (overallStatusMessage == "operating procedure complete")
//{
//    Console.WriteLine("'Workflow1' completed successfully.");
//}
//else
//{
//    Console.WriteLine("An error occurred during 'Workflow1'.");
//    Console.WriteLine(overallStatusMessage);
//}

//static string Workflow1(string[][] userEnteredValues)
//{
//    string operationStatusMessage = "good";
//    string processStatusMessage = "";

//    foreach (string[] userEntries in userEnteredValues)
//    {
//        processStatusMessage = Process1(userEntries);

//        if (processStatusMessage == "process complete")
//        {
//            Console.WriteLine("'Process1' completed successfully.");
//            Console.WriteLine();
//        }
//        else
//        {
//            Console.WriteLine("'Process1' encountered an issue, process aborted.");
//            Console.WriteLine(processStatusMessage);
//            Console.WriteLine();
//            operationStatusMessage = processStatusMessage;
//        }
//    }

//    if (operationStatusMessage == "good")
//    {
//        operationStatusMessage = "operating procedure complete";
//    }

//    return operationStatusMessage;
//}

//static string Process1(String[] userEntries)
//{
//    string processStatus = "clean";
//    string returnMessage = "";
//    int valueEntered;

//    foreach (string userValue in userEntries)
//    {
//        bool integerFormat = int.TryParse(userValue, out valueEntered);

//        if (integerFormat == true)
//        {
//            if (valueEntered != 0)
//            {
//                checked
//                {
//                    int calculatedValue = 4 / valueEntered;
//                }
//            }
//            else
//            {
//                returnMessage = "Invalid data. User input values must be non-zero values.";
//                processStatus = "error";
//            }
//        }
//        else
//        {
//            returnMessage = "Invalid data. User input values must be valid integers.";
//            processStatus = "error";
//        }
//    }

//    if (processStatus == "clean")
//    {
//        returnMessage = "process complete";
//    }

//    return returnMessage;
//}


////solution

//string[][] userEnteredValues = new string[][]
//{
//            new string[] { "1", "2", "3"},
//            new string[] { "1", "two", "3"},
//            new string[] { "0", "1", "2"}
//};

//try
//{
//    Workflow1(userEnteredValues);
//    Console.WriteLine("'Workflow1' completed successfully.");

//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("An error occurred during 'Workflow1'.");
//    Console.WriteLine(ex.Message);
//}

//static void Workflow1(string[][] userEnteredValues)
//{
//    foreach (string[] userEntries in userEnteredValues)
//    {
//        try
//        {
//            Process1(userEntries);
//            Console.WriteLine("'Process1' completed successfully.");
//            Console.WriteLine();
//        }
//        catch (FormatException ex)
//        {
//            Console.WriteLine("'Process1' encountered an issue, process aborted.");
//            Console.WriteLine(ex.Message);
//            Console.WriteLine();
//        }
//    }
//}

//static void Process1(String[] userEntries)
//{
//    int valueEntered;

//    foreach (string userValue in userEntries)
//    {
//        bool integerFormat = int.TryParse(userValue, out valueEntered);

//        if (integerFormat == true)
//        {
//            if (valueEntered != 0)
//            {
//                checked
//                {
//                    int calculatedValue = 4 / valueEntered;
//                }
//            }
//            else
//            {
//                throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
//            }
//        }
//        else
//        {
//            throw new FormatException("Invalid data. User input values must be valid integers.");
//        }
//    }
//}



///*
//This application manages transactions at a store check-out line. The
//check-out line has a cash register, and the register has a cash till
//that is prepared with a number of bills each morning. The till includes
//bills of four denominations: $1, $5, $10, and $20. The till is used
//to provide the customer with change during the transaction. The item 
//cost is a randomly generated number between 2 and 49. The customer 
//offers payment based on an algorithm that determines a number of bills
//in each denomination. 

//Each day, the cash till is loaded at the start of the day. As transactions
//occur, the cash till is managed in a method named MakeChange (customer 
//payments go in and the change returned to the customer comes out). A 
//separate "safety check" calculation that's used to verify the amount of
//money in the till is performed in the "main program". This safety check
//is used to ensure that logic in the MakeChange method is working as 
//expected.
//*/

//string? readResult = null;
//bool useTestData = true;

//Console.Clear();

//int[] cashTill = new int[] { 0, 0, 0, 0 };
//int registerCheckTillTotal = 0;

//// registerDailyStartingCash: $1 x 50, $5 x 20, $10 x 10, $20 x 5 => ($350 total)
//int[,] registerDailyStartingCash = new int[,] { { 1, 50 }, { 5, 20 }, { 10, 10 }, { 20, 5 } };

//int[] testData = new int[] { 6, 10, 17, 20, 31, 36, 40, 41 };
//int testCounter = 0;

//LoadTillEachMorning(registerDailyStartingCash, cashTill);

//registerCheckTillTotal = registerDailyStartingCash[0, 0] * registerDailyStartingCash[0, 1] + registerDailyStartingCash[1, 0] * registerDailyStartingCash[1, 1] + registerDailyStartingCash[2, 0] * registerDailyStartingCash[2, 1] + registerDailyStartingCash[3, 0] * registerDailyStartingCash[3, 1];

//// display the number of bills of each denomination currently in the till
//LogTillStatus(cashTill);

//// display a message showing the amount of cash in the till
//Console.WriteLine(TillAmountSummary(cashTill));

//// display the expected registerDailyStartingCash total
//Console.WriteLine($"Expected till value: {registerCheckTillTotal}\n\r");

//var valueGenerator = new Random((int)DateTime.Now.Ticks);

//int transactions = 10;

//if (useTestData)
//{
//    transactions = testData.Length;
//}

//while (transactions > 0)
//{
//    transactions -= 1;
//    int itemCost = valueGenerator.Next(2, 20);

//    if (useTestData)
//    {
//        itemCost = testData[testCounter];
//        testCounter += 1;
//    }

//    int paymentOnes = itemCost % 2;                 // value is 1 when itemCost is odd, value is 0 when itemCost is even
//    int paymentFives = (itemCost % 10 > 7) ? 1 : 0; // value is 1 when itemCost ends with 8 or 9, otherwise value is 0
//    int paymentTens = (itemCost % 20 > 13) ? 1 : 0; // value is 1 when 13 < itemCost < 20 OR 33 < itemCost < 40, otherwise value is 0
//    int paymentTwenties = (itemCost < 20) ? 1 : 2;  // value is 1 when itemCost < 20, otherwise value is 2

//    // display messages describing the current transaction
//    Console.WriteLine($"Customer is making a ${itemCost} purchase");
//    Console.WriteLine($"\t Using {paymentTwenties} twenty dollar bills");
//    Console.WriteLine($"\t Using {paymentTens} ten dollar bills");
//    Console.WriteLine($"\t Using {paymentFives} five dollar bills");
//    Console.WriteLine($"\t Using {paymentOnes} one dollar bills");

//    // MakeChange manages the transaction and updates the till 
//    string transactionMessage = MakeChange(itemCost, cashTill, paymentTwenties, paymentTens, paymentFives, paymentOnes);

//    // Backup Calculation - each transaction adds current "itemCost" to the till
//    if (transactionMessage == "transaction succeeded")
//    {
//        Console.WriteLine($"Transaction successfully completed.");
//        registerCheckTillTotal += itemCost;
//    }
//    else
//    {
//        Console.WriteLine($"Transaction unsuccessful: {transactionMessage}");
//    }

//    Console.WriteLine(TillAmountSummary(cashTill));
//    Console.WriteLine($"Expected till value: {registerCheckTillTotal}\n\r");
//    Console.WriteLine();
//}

//Console.WriteLine("Press the Enter key to exit");
//do
//{
//    readResult = Console.ReadLine();

//} while (readResult == null);

//static string MakeChange(int cost, int[] cashTill, int twenties, int tens = 0, int fives = 0, int ones = 0)
//{
//    string transactionMessage = "";

//    cashTill[3] += twenties;
//    cashTill[2] += tens;
//    cashTill[1] += fives;
//    cashTill[0] += ones;

//    int amountPaid = twenties * 20 + tens * 10 + fives * 5 + ones;
//    int changeNeeded = amountPaid - cost;

//    if (changeNeeded < 0)
//        transactionMessage = "Not enough money provided.";

//    Console.WriteLine("Cashier Returns:");

//    while ((changeNeeded > 19) && (cashTill[3] > 0))
//    {
//        cashTill[3]--;
//        changeNeeded -= 20;
//        Console.WriteLine("\t A twenty");
//    }

//    while ((changeNeeded > 9) && (cashTill[2] > 0))
//    {
//        cashTill[2]--;
//        changeNeeded -= 10;
//        Console.WriteLine("\t A ten");
//    }

//    while ((changeNeeded > 4) && (cashTill[1] > 0))
//    {
//        cashTill[2]--;
//        changeNeeded -= 5;
//        Console.WriteLine("\t A five");
//    }

//    while ((changeNeeded > 4) && (cashTill[1] > 0))
//    {
//        cashTill[1]--;
//        changeNeeded -= 5;
//        Console.WriteLine("\t A five");
//    }


//    if (changeNeeded > 0)
//        transactionMessage = "Can't make change. Do you have anything smaller?";

//    if (transactionMessage == "")
//        transactionMessage = "transaction succeeded";

//    return transactionMessage;
//}


////Challenge project:

///*
//This application manages transactions at a store check-out line. The
//check-out line has a cash register, and the register has a cash till
//that is prepared with a number of bills each morning. The till includes
//bills of four denominations: $1, $5, $10, and $20. The till is used
//to provide the customer with change during the transaction. The item 
//cost is a randomly generated number between 2 and 49. The customer 
//offers payment based on an algorithm that determines a number of bills
//in each denomination. 

//Each day, the cash till is loaded at the start of the day. As transactions
//occur, the cash till is managed in a method named MakeChange (customer 
//payments go in and the change returned to the customer comes out). A 
//separate "safety check" calculation that's used to verify the amount of
//money in the till is performed in the "main program". This safety check
//is used to ensure that logic in the MakeChange method is working as 
//expected.
//*/

//string? readResult = null;
//bool useTestData = false;

//Console.Clear();

//int[] cashTill = new int[] { 0, 0, 0, 0 };
//int registerCheckTillTotal = 0;

//// registerDailyStartingCash: $1 x 50, $5 x 20, $10 x 10, $20 x 5 => ($350 total)
//int[,] registerDailyStartingCash = new int[,] { { 1, 50 }, { 5, 20 }, { 10, 10 }, { 20, 5 } };

//int[] testData = new int[] { 6, 10, 17, 20, 31, 36, 40, 41 };
//int testCounter = 0;

//LoadTillEachMorning(registerDailyStartingCash, cashTill);

//registerCheckTillTotal = registerDailyStartingCash[0, 0] * registerDailyStartingCash[0, 1] + registerDailyStartingCash[1, 0] * registerDailyStartingCash[1, 1] + registerDailyStartingCash[2, 0] * registerDailyStartingCash[2, 1] + registerDailyStartingCash[3, 0] * registerDailyStartingCash[3, 1];

//// display the number of bills of each denomination currently in the till
//LogTillStatus(cashTill);

//// display a message showing the amount of cash in the till
//Console.WriteLine(TillAmountSummary(cashTill));

//// display the expected registerDailyStartingCash total
//Console.WriteLine($"Expected till value: {registerCheckTillTotal}");
//Console.WriteLine();

//var valueGenerator = new Random((int)DateTime.Now.Ticks);

//int transactions = 100;

//if (useTestData)
//{
//    transactions = testData.Length;
//}

//while (transactions > 0)
//{
//    transactions -= 1;
//    int itemCost = valueGenerator.Next(2, 50);

//    if (useTestData)
//    {
//        itemCost = testData[testCounter];
//        testCounter += 1;
//    }

//    int paymentOnes = itemCost % 2;                 // value is 1 when itemCost is odd, value is 0 when itemCost is even
//    int paymentFives = (itemCost % 10 > 7) ? 1 : 0; // value is 1 when itemCost ends with 8 or 9, otherwise value is 0
//    int paymentTens = (itemCost % 20 > 13) ? 1 : 0; // value is 1 when 13 < itemCost < 20 OR 33 < itemCost < 40, otherwise value is 0
//    int paymentTwenties = (itemCost < 20) ? 1 : 2;  // value is 1 when itemCost < 20, otherwise value is 2

//    // display messages describing the current transaction
//    Console.WriteLine($"Customer is making a ${itemCost} purchase");
//    Console.WriteLine($"\t Using {paymentTwenties} twenty dollar bills");
//    Console.WriteLine($"\t Using {paymentTens} ten dollar bills");
//    Console.WriteLine($"\t Using {paymentFives} five dollar bills");
//    Console.WriteLine($"\t Using {paymentOnes} one dollar bills");

//    try
//    {
//        // MakeChange manages the transaction and updates the till 
//        MakeChange(itemCost, cashTill, paymentTwenties, paymentTens, paymentFives, paymentOnes);

//        // Backup Calculation - each transaction adds current "itemCost" to the till
//        registerCheckTillTotal += itemCost;
//    }
//    catch (InvalidOperationException e)
//    {
//        Console.WriteLine($"Could not complete transaction: {e.Message}");
//    }

//    Console.WriteLine(TillAmountSummary(cashTill));
//    Console.WriteLine($"Expected till value: {registerCheckTillTotal}");
//    Console.WriteLine();
//}

//Console.WriteLine("Press the Enter key to exit");
//do
//{
//    readResult = Console.ReadLine();

//} while (readResult == null);


//static void LoadTillEachMorning(int[,] registerDailyStartingCash, int[] cashTill)
//{
//    cashTill[0] = registerDailyStartingCash[0, 1];
//    cashTill[1] = registerDailyStartingCash[1, 1];
//    cashTill[2] = registerDailyStartingCash[2, 1];
//    cashTill[3] = registerDailyStartingCash[3, 1];
//}


//static void MakeChange(int cost, int[] cashTill, int twenties, int tens = 0, int fives = 0, int ones = 0)
//{
//    int availableTwenties = cashTill[3] + twenties;
//    int availableTens = cashTill[2] + tens;
//    int availableFives = cashTill[1] + fives;
//    int availableOnes = cashTill[0] + ones;

//    int amountPaid = twenties * 20 + tens * 10 + fives * 5 + ones;
//    int changeNeeded = amountPaid - cost;

//    if (changeNeeded < 0)
//        throw new InvalidOperationException("InvalidOperationException: Not enough money provided to complete the transaction.");

//    Console.WriteLine("Cashier prepares the following change:");

//    while ((changeNeeded > 19) && (availableTwenties > 0))
//    {
//        availableTwenties--;
//        changeNeeded -= 20;
//        Console.WriteLine("\t A twenty");
//    }

//    while ((changeNeeded > 9) && (availableTens > 0))
//    {
//        availableTens--;
//        changeNeeded -= 10;
//        Console.WriteLine("\t A ten");
//    }

//    while ((changeNeeded > 4) && (availableFives > 0))
//    {
//        availableFives--;
//        changeNeeded -= 5;
//        Console.WriteLine("\t A five");
//    }

//    while ((changeNeeded > 0) && (availableOnes > 0))
//    {
//        availableOnes--;
//        changeNeeded -= 1;
//        Console.WriteLine("\t A one");
//    }

//    if (changeNeeded > 0)
//        throw new InvalidOperationException("InvalidOperationException: The till is unable to make change for the cash provided.");

//    cashTill[0] = availableOnes;
//    cashTill[1] = availableFives;
//    cashTill[2] = availableTens;
//    cashTill[3] = availableTwenties;

//}

//static void LogTillStatus(int[] cashTill)
//{
//    Console.WriteLine("The till currently has:");
//    Console.WriteLine($"{cashTill[3] * 20} in twenties");
//    Console.WriteLine($"{cashTill[2] * 10} in tens");
//    Console.WriteLine($"{cashTill[1] * 5} in fives");
//    Console.WriteLine($"{cashTill[0]} in ones");
//    Console.WriteLine();
//}

//static string TillAmountSummary(int[] cashTill)
//{
//    return $"The till has {cashTill[3] * 20 + cashTill[2] * 10 + cashTill[1] * 5 + cashTill[0]} dollars";

//}

