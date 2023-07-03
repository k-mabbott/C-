// See https://aka.ms/new-console-template for more information);

Random rand = new Random();

// Create a loop that prints all values from 1-255.

for (int i = 1; i < 256; i++)
{
    Console.WriteLine($"the number is {i}");
}


// Create a new loop that generates 5 random numbers between 10 and 20.

for (int i = 1; i < 6 ; i++)
{
    Console.WriteLine(rand.Next(10,21));
}

// Modify the previous loop to add the random values together and print the sum after the 
// loop finishes.

int sum = 0;
for (int i = 1; i < 6 ; i++)
{
    sum = sum + rand.Next(10,21);
}
Console.WriteLine(sum);

// Create a new loop that prints all values from 1 to 100 that are divisible by 3 OR 5, but 
// NOT both.

for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        continue;
    }
    else if (i % 3 == 0 || i % 5 == 0)
    {
        Console.WriteLine(i);
    }
}

// Modify the previous loop to print "Fizz" for multiples of 3 and "Buzz" for multiples of 5.

for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        continue;
    }
    else if (i % 3 == 0 )
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
}

// Modify the previous loop once more to now also print "FizzBuzz" for numbers that are 
// multiples of both 3 and 5.

for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0 )
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
}

// (Optional) If you used for loops for your solutions, try doing the same with while loops. 
// Vice versa if you used while loops!

// int i = 1;

// Create a loop that prints all values from 1-255.

// while ( i < 256)
// {
//     Console.WriteLine($"the number is {i}");
//     i++;
// }


// Create a new loop that generates 5 random numbers between 10 and 20.

// while ( i < 6 )
// {
//     Console.WriteLine(rand.Next(10,21));
//     i++;
// }

// Modify the previous loop to add the random values together and print the sum after the 
// loop finishes.

// int sum = 0;
// while ( i < 6 )
// {
//     sum = sum + rand.Next(10,21);
//     i++;
// }
// Console.WriteLine(sum);

// Create a new loop that prints all values from 1 to 100 that are divisible by 3 OR 5, but 
// NOT both.

// while ( i < 101)
// {
//     if (i % 3 == 0 && i % 5 == 0)
//     {
//         i++;
//         continue;
//     }
//     else if (i % 3 == 0 || i % 5 == 0)
//     {
//         Console.WriteLine(i);
//     }
//     i++;
// }

// Modify the previous loop to print "Fizz" for multiples of 3 and "Buzz" for multiples of 5.

// while (i < 101)
// {
//     if (i % 3 == 0 && i % 5 == 0)
//     {
//         i++;
//         continue;
//     }
//     else if (i % 3 == 0 )
//     {
//         Console.WriteLine("Fizz");
//     }
//     else if (i % 5 == 0)
//     {
//         Console.WriteLine("Buzz");
//     }
//     i++;
// }

// Modify the previous loop once more to now also print "FizzBuzz" for numbers that are 
// multiples of both 3 and 5.

// while ( i < 101)
// {
//     if (i % 3 == 0 && i % 5 == 0)
//     {
//         Console.WriteLine("FizzBuzz");
//     }
//     else if (i % 3 == 0 )
//     {
//         Console.WriteLine("Fizz");
//     }
//     else if (i % 5 == 0)
//     {
//         Console.WriteLine("Buzz");
//     }
//     i++;
// }