// // See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Fundamentals 3");


// Practice creating functions and writing logic by completing the following prompts:

// 1. Iterate and print values

// Given a List of strings, iterate through the List and print out all the values. 
// Bonus: How many different ways can you find to print out the contents of a List? 
// (There are at least 3! Check Google!)

List<string> StringList = new List<string>() { "One thing", "Another thing", "Yet another thing", "Last thing" };

static void PrintList(List<string> MyList)
{
    foreach (string item in MyList)
    {
        Console.WriteLine(item);
    }
    // int i = 0;
    // while(i < MyList.Count)
    // {
    //     Console.WriteLine(MyList[i]);
    //     i++;
    // }
    // for (int i = 0; i < MyList.Count; i++)
    // {
    //     Console.WriteLine(MyList[i]);
    // }
}
PrintList(StringList);

// 2. Print Sum

// Given a List of integers, calculate and print the sum of the values.

List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };

static int SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    foreach (int num in IntList)
    {
        sum += num;
    }
    Console.WriteLine(sum);
    return sum;
}

SumOfNumbers(TestIntList);


// 3. Find Max

// Given a List of integers, find and return the largest value in the List.

List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };

static int FindMax(List<int> IntList)
{
    int max = IntList[0];
    for (int i = 1; i < IntList.Count; i++)
    {
        if (IntList[i] > max)
        {
            max = IntList[i];
        }
    }
    return max;
}
// You should get back 17 in this example
Console.WriteLine(FindMax(TestIntList2));



// 4. Square the Values

// Given a List of integers, return the List with all the values squared.

static List<int> SquareValues(List<int> IntList)
{
    for (int i = 0; i < IntList.Count; i++)
    {
        IntList[i] = IntList[i] * IntList[i];
    }
    foreach (int num in IntList)
    {
        Console.WriteLine(num);
    }
    return IntList;
}
List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };
// You should get back [1,4,9,16,25], think about how you will show that this worked
SquareValues(TestIntList3);



// 5. Replace Negative Numbers with 0

// Given an array of integers, return the array with all values below 0 replaced with 0.

static int[] NonNegatives(int[] IntArray)
{
    for (int i = 0; i < IntArray.Length; i++)
    {
        if (IntArray[i] < 0 )
        {
            IntArray[i] = 0;
        }
    }
    foreach (int num in IntArray)
    {
        Console.WriteLine(num);
    }
    return IntArray;
}
int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
// You should get back [0,2,3,0,5], think about how you will show that this worked
NonNegatives(TestIntArray);



// 6. Print Dictionary

// Given a dictionary, print the contents of the said dictionary.

Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");

static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    foreach(KeyValuePair<string, string> heroStat in MyDictionary)
    {
        Console.WriteLine($"{heroStat.Key} - {heroStat.Value}");
    }
}

PrintDictionary(TestDict);

// 7. Find Key

// Given a search term, return true or false whether the given term is a key in a dictionary. 
// (Hint: figuring this one out may require some research!)

static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
        foreach(KeyValuePair<string, string> heroStat in MyDictionary)
    {
        if (heroStat.Key == SearchTerm)
        {
            return true;
        }
    }
    return false;
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));



// 8. Generate a Dictionary

// Given a List of names and a List of integers, create a dictionary where the key is a name from 
// the List of names and the value is a number from the List of numbers. Assume that the two Lists will 
// be of the same length. Don't forget to print your results to make sure it worked.


// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string, int> Result = new Dictionary<string, int> ();

    for (int i = 0; i < Names.Count; i++)
    {
        Result.Add(Names[i] , Numbers[i]); 
    }
    return Result;
}

List<string> People = new List<string>() {"Julie", "Harold", "James", "Monica"};
List<int> JustNums = new List<int>() {6,12,7,10};

Dictionary<string, int> WeMadeIt = new Dictionary<string, int> ();
WeMadeIt = GenerateDictionary(People, JustNums);
foreach(KeyValuePair<string, int> dict in WeMadeIt)
{
    Console.WriteLine($"{dict.Key} - {dict.Value}");
}



// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here



