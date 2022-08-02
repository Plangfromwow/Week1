Console.WriteLine("Please type a number:");

//int entry = Convert.ToInt32(Console.ReadLine());
string entry = Console.ReadLine();
int n = int.Parse(entry);

if (n > 50)
{
    Console.WriteLine($"yes, {n} is greater than 50");
    Console.WriteLine($"n is {n}");
}
else
{
    Console.WriteLine("This number is not bigger than 50");
}


// checking if number is between 3 and 10 exclusive

if ((n > 3) && (n < 10))
{
    Console.WriteLine("Yes, n is between 3 and 10");
}
else
{
    Console.WriteLine("No, n is not between 3 and 10");
}

// checking if number is between 3 and 10 inclusive

if ((n >= 3) && (n <= 10))
{
    Console.WriteLine("Yes, n is between 2 and 11");
}
else
{
    Console.WriteLine("No, n is not between 2 and 11");
}

