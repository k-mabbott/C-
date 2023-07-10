// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

// Use LINQ to find the first eruption that is in Chile 
// and print the result.

// Eruption? FirstInChile = eruptions.FirstOrDefault(e => e.Location == "Chile");
// Console.WriteLine(FirstInChile);

// Find the first eruption from the "Hawaiian Is" location and print it. 
// If none is found, print "No Hawaiian Is Eruption found."

// Eruption FirstInHawaii = eruptions.FirstOrDefault(e => e.Location == "Hawaiian Is")!;
// // if (FirstInHawaii == null)
// // {
// //     Console.WriteLine("No Hawaiian Is Eruption found.");
// // }
// // else
// // {
// //     Console.WriteLine(FirstInHawaii);
// // }
// Console.WriteLine(FirstInHawaii != null ? FirstInHawaii : "No Hawaiian Is Eruption found.");



// Find the first eruption from the "Greenland" location and print it. 
// If none is found, print "No Greenland Eruption found."

// Eruption FirstInGreenland = eruptions.FirstOrDefault(e => e.Location == "Greenland")!;
// if (FirstInGreenland == null)
// {
//     Console.WriteLine("No Greenland Eruption found.");
// }
// else
// {
//     Console.WriteLine(FirstInGreenland);
// }

// Find the first eruption that is after the year 1900 AND in "New Zealand", 
// then print it.

// Eruption FirstInNz1900 = eruptions.FirstOrDefault(e => e.Location == "New Zealand" && e.Year > 1900)!;
// Console.WriteLine(FirstInNz1900);

// Find all eruptions where the volcano's elevation is over 2000m and 
// print them.

// IEnumerable<Eruption> HighElevations = eruptions.Where(e => e.ElevationInMeters > 2000 );
// PrintEach(HighElevations, "All Volcano's over 2000m");

// Find all eruptions where the volcano's name starts with "L" and print them. 
// Also print the number of eruptions found.

// IEnumerable<Eruption> StartsWithL = eruptions.Where(e => e.Volcano[0] == 'L' ||  e.Volcano[0] == 'l' );
// PrintEach(StartsWithL, "All Volcano's that start with the letter 'L'");

// Find the highest elevation, and print only that integer (Hint: Look up 
// how to use LINQ to find the max!)

// int Highest = eruptions.Max(e => e.ElevationInMeters);
// Console.WriteLine(Highest);

// Use the highest elevation variable to find and print the name of the 
// Volcano with that elevation.

// Eruption HighestName = eruptions.FirstOrDefault(e => e.ElevationInMeters == Highest)!;
// Console.WriteLine(HighestName.Volcano);

// Print all Volcano names alphabetically.

// List<Eruption> Alphabetically = eruptions.OrderBy(e => e.Volcano).ToList();
// PrintEach(Alphabetically, "Volcano's in alphabetical order");

// Print the sum of all the elevations of the volcanoes combined.

// int AllElevations = eruptions.Sum(e => e.ElevationInMeters);
// Console.WriteLine(AllElevations);


// Print whether any volcanoes erupted in the year 2000 (Hint: look up 
// the Any query)

// bool Year2000 = eruptions.Any(e => e.Year == 2008);
// Console.WriteLine(Year2000);

// Find all stratovolcanoes and print just the first three (Hint: look 
// up Take)

// IEnumerable<Eruption> FirstThree = eruptions.Where(e => e.Type == "Stratovolcano").Take(3);
// PrintEach(FirstThree, "First 3 Volcano's with the type of Stratovolcano");

// Print all the eruptions that happened before the year 1000 CE 
// alphabetically according to Volcano name.

IEnumerable<Eruption> Before1000 = eruptions.Where(e => e.Year < 1000);
PrintEach(Before1000, "Eruptions that happened before the year 1000 CE");

// Redo the last query, but this time use LINQ to only select the 
// volcano's name so that only the names are printed.

List<string> Before1000Names = eruptions.Where(e => e.Year < 1000).Select(e => e.Volcano).ToList();

foreach(string n in Before1000Names)
{
    Console.WriteLine(n);
}



// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}



