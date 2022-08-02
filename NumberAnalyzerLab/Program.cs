// Greeting
Console.WriteLine("Hello! Welcome to the Number Analyzer!");

// asking for name 
Console.WriteLine("What is your name?");
string userName = Console.ReadLine();

string playagain = "y";
while (playagain == "y")
{
    // asking for input 
    Console.WriteLine($"Hi {userName}! Please choose a number:");
    double input = Convert.ToDouble(Console.ReadLine());
    if (input >= 1 && input <= 100)
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
        Console.WriteLine($"Your number is Odd and Less than 60 {userName}");
    }
    else if ((input % 2 != 0) && (input > 60))
    {
        Console.WriteLine($"Your number is Odd and Greater than 60 {userName}");
    }
    else if ((input % 2 == 0) && (input > 60))
    {
        Console.WriteLine($"Your number is Even and Greater than 60 {userName}");
    }
    else if ((input % 2 == 0) && (input >= 26) && (input <= 60))
    {
        Console.WriteLine($"Your number is Even and between 26 and 60 {userName}");
    }
    else if((input % 2 == 0) && (input < 25)) {
        Console.WriteLine($"Your number is Even and less than 25. {userName}");
    }
    else
    {
        Console.WriteLine($"Your number is Odd and between 26 and 60 {userName}");
    }
    Console.WriteLine();
    Console.WriteLine($"Would you like to play again {userName}? y = Yes, n=No");
    playagain = Console.ReadLine();
}