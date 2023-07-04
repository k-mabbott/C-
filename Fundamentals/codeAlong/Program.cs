// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// ---------------------------------TRY PARSE---------------------

Console.WriteLine("Type a number, then hit enter: ");
string NumberInput = Console.ReadLine();
// TryParse takes 2 parameters: the item to be parsed and a variable
// you would like to output (out) to if it is successful
if(Int32.TryParse(NumberInput, out int j))
{
    // Notice how we used j instead of NumberInput
    Console.WriteLine($"The integer was {j}");
    Console.WriteLine(10 + j);
}

// ---------------------------------CONVERT---------------------

// string aNumber = "7";
// int converted = Convert.ToInt32(aNumber);
// Console.WriteLine(14 + converted); // should print 21
// string aDecimal = "3.14";
// double convertDec = Convert.ToDouble(aDecimal);
// Console.WriteLine(1.8 + convertDec); // should print 4.94





