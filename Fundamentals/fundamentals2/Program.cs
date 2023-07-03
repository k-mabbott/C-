// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Directions

// Complete the following exercises:
// Three Basic Arrays

//     Create an integer array with the values 0 through 9 inside.
//     Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
//     Create a boolean array of length 10. Then fill it with alternating true/false 
// values, starting with true. (Tip: do this using logic! Do not hard-code the values in!)

int[] numArr = new int[10] {0,1,2,3,4,5,6,7,8,9}; 
string[] stringArr = new string[4] {"Tim", "Martin", "Nikki", "Sara"};
bool[] boolArr = new bool [10];

for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0) 
    {
        boolArr[i] = true;
    } else 
    {
        boolArr[i] = false;
    }
}

// foreach (var item in boolArr)
// {
//     Console.WriteLine(item);
// }


// List of Flavors

//     Create a string List of ice cream flavors that holds at least 5 different flavors. 
// (Feel free to add more than 5!)
//     Output the length of the List after you added the flavors.
//     Output the third flavor in the List.
//     Now remove the third flavor using its index location.
//     Output the length of the List again. It should now be one fewer.

List<string> iceCream = new List<string>() {"Tonight Dough", "Mint Chocolate Chip"};
iceCream.Add("Cookies & Cream");
iceCream.Add("Vanilla");
iceCream.Add("Rocky Road");
Console.WriteLine(iceCream.Count);
Console.WriteLine(iceCream[2]);
iceCream.RemoveAt(2);
Console.WriteLine(iceCream.Count);

// User Dictionary

//     Create a dictionary that will store string keys and string values.
//     Add key/value pairs to the dictionary where:
//         Each key is a name from your names array (this can be done by hand or using logic)
//         Each value is a randomly selected flavor from your flavors List (remember Random from 
// earlier?)
//     Loop through the dictionary and print out each user's name and their associated ice cream 
// flavor.

Dictionary<string, string> user = new Dictionary<string, string>();

Random rand = new Random();

foreach (string name in stringArr)
{
    int idx = rand.Next(4);
    user.Add(name, iceCream[idx]);
}

foreach (KeyValuePair<string, string> entry in user)
{
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}