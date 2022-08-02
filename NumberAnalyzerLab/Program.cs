// Greeting
Console.WriteLine("Hello! Welcome to the Number Analyzer!");

string playagain = "y";
while (playagain == "y")
{
    // asking for input 
    Console.WriteLine($"Hi! Please choose a number:");
    double input = Convert.ToDouble(Console.ReadLine());
    if (input >= 0 && input <= 100)
    {
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Please input a valid number between 1 and 100");
        input = Convert.ToDouble(Console.ReadLine());
    }
    
    Console.WriteLine();


    // if else for the output 
    if ((input % 2 != 0) && (input < 60))
    {
        Console.WriteLine($"Your number is Odd and Less than 60");
    }
    else if ((input % 2 != 0) && (input > 60))
    {
        Console.WriteLine($"Your number is Odd and Greater than 60");
    }
    else if ((input % 2 == 0) && (input > 60))
    {
        Console.WriteLine($"Your number is Even and Greater than 60");
    }
    else if ((input % 2 == 0) && (input >= 26) && (input <= 60))
    {
        Console.WriteLine($"Your number is Even and between 26 and 60");
    }
    else if((input % 2 == 0) && (input < 25)) {
        Console.WriteLine($"Your number is Even and less than 25.");
    }
    else
    {
        Console.WriteLine($"Your number is Odd and between 26 and 60");
    }
    Console.WriteLine();
    Console.WriteLine($"Would you like to play again? y = Yes, n=No");
    playagain = Console.ReadLine().ToLower();
}