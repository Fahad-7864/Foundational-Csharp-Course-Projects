//string[] pallets = { "B14", "A11", "B12", "A13" };


////to sort out an array
//Console.WriteLine("Sorted...");
//Array.Sort(pallets);
//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}

////to reverse an array
//Console.WriteLine("");
//Console.WriteLine("Reversed...");
//Array.Reverse(pallets);
//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}


//Clear an Array
//string[] pallets = { "B14", "A11", "B12", "A13" };
//Console.WriteLine("");


//Console.WriteLine($"Before: {pallets[0].ToLower()}");
//Array.Clear(pallets, 0, 2);
//Console.WriteLine($"After: {pallets[0].ToLower()}");

//Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}

//resize an array to add more elements

//string[] pallets = { "B14", "A11", "B12", "A13" };
//Console.WriteLine("");

//Array.Clear(pallets, 0, 2);
//Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}

//Console.WriteLine("");
//Array.Resize(ref pallets, 6);
//Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

//pallets[4] = "C01";
//pallets[5] = "C02";

//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}

//Console.WriteLine("");
//Array.Resize(ref pallets, 3);
//Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}


//Split and Join methods
//string value = "abc123";
//char[] valueArray = value.ToCharArray();
//Array.Reverse(valueArray);
////string result = new string(valueArray);
//string result = String.Join(",", valueArray);

//Console.WriteLine(result);

//string[] items = result.Split(',');
//foreach (string item in items)
//{
//    Console.WriteLine(item);
//}


//string pangram = "The quick brown fox jumps over the lazy dog";
//Console.WriteLine(pangram);
//char[] chars= pangram.ToCharArray();
//Array.Reverse(chars);
//string result = new string(chars);

//Console.WriteLine(chars);


//string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
//string[] items = orderStream.Split(',');
//Array.Sort(items);

//foreach (var item in items)
//{
//    if (item.Length == 4)
//    {
//        Console.WriteLine(item);
//    }
//    else
//    {
//        Console.WriteLine(item + "\t- Error");
//    }
//}


// string formatting
//string first = "Hello";
//string second = "World";
//string result = string.Format("{0} {1}!", first, second);
//Console.WriteLine(result);

//Console.WriteLine("{1} {0}!", first, second);
//Console.WriteLine("{0} {0} {0}!", first, second);

//decimal price = 123.45m;
//int discount = 50;
//Console.WriteLine($"Price: {price:C} (Save {discount:C})");


//decimal measurement = 123456.78912m;
//Console.WriteLine($"Measurement: {measurement:N} units");
//Console.WriteLine($"Measurement: {measurement:N4} units");

//decimal tax = .36785m;
//Console.WriteLine($"Tax rate: {tax:P2}");


//decimal price = 67.55m;
//decimal salePrice = 59.99m;

//string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

//yourDiscount += $"A discount of {((price - salePrice) / price):P2}!"; 
//Console.WriteLine(yourDiscount);


//int invoiceNumber = 1201;
//decimal productShares = 25.4568m;
//decimal subtotal = 2750.00m;
//decimal taxPercentage = .15825m;
//decimal total = 3185.19m;

//Console.WriteLine($"Invoice Number: {invoiceNumber}");
//Console.WriteLine($"   Shares: {productShares:N1} Product");
//Console.WriteLine($"     Sub Total: {subtotal:C}");
//Console.WriteLine($"           Tax: {taxPercentage:P2}");
//Console.WriteLine($"     Total Billed: {total:C}");


//string first = "Hello";
//string second = "World";
//string result = string.Format("{0} {1}!", first, second);
//Console.WriteLine(result);

//string input = "Pad this";
//Console.WriteLine(input.PadLeft(12, '-'));
//Console.WriteLine(input.PadRight(12, '-'));

//string paymentId = "769C";
//string payeeName = "Mr. Stephen Ortega";
//string paymentAmount = "$5,000.00";

//var formattedLine = paymentId.PadRight(6);
//formattedLine += payeeName.PadRight(24);
//formattedLine += paymentAmount.PadLeft(10);

//Console.WriteLine("1234567890123456789012345678901234567890");
//Console.WriteLine(formattedLine);


//string customerName = "Ms. Barros";

//string currentProduct = "Magic Yield";
//int currentShares = 2975000;
//decimal currentReturn = 0.1275m;
//decimal currentProfit = 55000000.0m;

//string newProduct = "Glorious Future";
//decimal newReturn = 0.13125m;
//decimal newProfit = 63000000.0m;

//Console.WriteLine($"Dear {customerName},");
//Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
//Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
//Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

//Console.WriteLine("Here's a quick comparison:\n");

//string comparisonMessage = "";

//comparisonMessage = currentProduct.PadRight(20);
//comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
//comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

//comparisonMessage += "\n";
//comparisonMessage += newProduct.PadRight(20);
//comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
//comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

//Console.WriteLine(comparisonMessage);


//string message = "Find what is (inside the parentheses)";

//int openingPosition = message.IndexOf('(');
//int closingPosition = message.IndexOf(')');

//Console.WriteLine(openingPosition);
//Console.WriteLine(closingPosition);

//string message = "Find what is (inside the parentheses)";

//int openingPosition = message.IndexOf('(');
//int closingPosition = message.IndexOf(')');

//// Console.WriteLine(openingPosition);
//// Console.WriteLine(closingPosition);
//openingPosition += 1;

//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition, length));


//string message = "What is the value <span>between the tags</span>?";

//const string openSpan = "<span>";
//const string closeSpan = "</span>";

//int openingPosition = message.IndexOf(openSpan);
//int closingPosition = message.IndexOf(closeSpan);

//openingPosition += openSpan.Length;
//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition, length));

// retrieve the last occurence of a sub string

//string message = "(What if) I am (only interested) in the last (set of parentheses)?";
//int openingPosition = message.LastIndexOf('(');

//openingPosition += 1;
//int closingPosition = message.LastIndexOf(')');
//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition, length));


//string message = "(What if) there are (more than) one (set of parentheses)?";
//while (true)
//{
//    int openingPosition = message.IndexOf('(');
//    if (openingPosition == -1) break;

//    openingPosition += 1;
//    int closingPosition = message.IndexOf(')');
//    int length = closingPosition - openingPosition;
//    Console.WriteLine(message.Substring(openingPosition, length));

//    // Note the overload of the Substring to return only the remaining 
//    // unprocessed message:
//    message = message.Substring(closingPosition + 1);
//}




//string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

//// The IndexOfAny() helper method requires a char array of characters. 
//// You want to look for:

//char[] openSymbols = { '[', '{', '(' };

//// You'll use a slightly different technique for iterating through 
//// the characters in the string. This time, use the closing 
//// position of the previous iteration as the starting index for the 
////next open symbol. So, you need to initialize the closingPosition 
//// variable to zero:

//int closingPosition = 0;

//while (true)
//{
//    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//    if (openingPosition == -1) break;

//    string currentSymbol = message.Substring(openingPosition, 1);

//    // Now  find the matching closing symbol
//    char matchingSymbol = ' ';

//    switch (currentSymbol)
//    {
//        case "[":
//            matchingSymbol = ']';
//            break;
//        case "{":
//            matchingSymbol = '}';
//            break;
//        case "(":
//            matchingSymbol = ')';
//            break;
//    }

//    // To find the closingPosition, use an overload of the IndexOf method to specify 
//    // that the search for the matchingSymbol should start at the openingPosition in the string. 

//    openingPosition += 1;
//    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//    // Finally, use the techniques you've already learned to display the sub-string:

//    int length = closingPosition - openingPosition;
//    Console.WriteLine(message.Substring(openingPosition, length));
//}


//remove and replace
//string data = "12345John Smith          5000  3  ";
//string updatedData = data.Remove(5, 20);
//Console.WriteLine(updatedData);


//string message = "This--is--ex-amp-le--da-ta";
//message = message.Replace("--", " ");
//message = message.Replace("-", "");
//Console.WriteLine(message);


const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";


// Extract the "quantity"
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
int quantityEnd = input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);