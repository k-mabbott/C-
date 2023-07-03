// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// ---------------------------------------- Challenge 1
bool amProgrammer = true;
Console.WriteLine(amProgrammer);
// Had quotes around true
double Age = 27.9;
Console.WriteLine(Age);

// must be type double 
List<string> Names = new List<string>();
// 
Names.Add("Monica");
// must add to list 
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
//
MyDictionary.Add("Hello", "0");
//
MyDictionary.Add("Hi there", "0");
// can not add an int to a <string, string> dictionary
// This is a tricky one! Hint: look up what a char is in C#
string MyName = "MyName";
Console.WriteLine(MyName);
//if using single quotes must be a char eg. 'g' is one Char.
// ---------------------------------------- Challenge 2
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
//
for(int i = Numbers.Count-1; i >= 0; i--)
{
    Console.WriteLine(Numbers[i]);
}
// Must be .Count -1 because of 0 indexing
//---------------------------------------- Challenge 3
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in MoreNumbers)
{
    Console.WriteLine(i);
}
// for each is printing the number at each index already 
// ---------------------------------------- Challenge 4

List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
foreach(int num in EvenMoreNumbers)
{
    if(num % 3 == 0)
    {
        // num = 0;
        Console.WriteLine(num);
    }
}
// num is not its own variable only a representaion of what is at that position in the list. 
// you can not reassign num.
// Challenge 5

// What can we learn from this error message?
string MyString = "superduberawesome";
// MyString[7] = "p";
MyString = "superduperawesome";
Console.WriteLine(MyString);

// Challenge 6
// You can not reassign a single index of a string they are immutable. 
// Hint: some bugs don't come with error messages
Random rand = new Random();
int randomNum = rand.Next(12);
if(randomNum == 12)
{
    Console.WriteLine("Hello");
}
// the rand.Next(12) will output a random number between 0-11 and will
// never hit the console line.
