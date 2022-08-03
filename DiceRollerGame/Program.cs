// creating a new random method? No clue what this is

//My advice:
//First ask the user for the number of sides and then generate two dice of that size and print them both out. Get that part working before moving on to the next.
//Then add an if statement checking if the size is 6, and then do all the if statements for the scoring given in the lab
//Then only after all the above is done, add in the "would you like to go again" part.

// Welcome message and defining the random generator operator? 
Random ran = new Random();
bool keepgoing = true;
Console.WriteLine("Welcome to the GC Casino!");


do
{
    // Asking user for number and creating space
    Console.WriteLine();
    Console.Write("Please Seclect what size dice you'd like: ");
    int userDice = Convert.ToInt32(Console.ReadLine());

    // Creating dice variables and rolling the dice
    //int diceOne = ran.Next(1, (userDice + 1));
    //int diceTwo = ran.Next(1, (userDice + 1));

    int diceOne = 4;
    int diceTwo = 8;

    Console.WriteLine($"The first dice landed on: {diceOne}");
    Console.WriteLine($"The second dice landed on: {diceTwo}");


    // if statement for if the user uses a 6 sided die to output some things
    if (userDice == 6)
    {
        if (diceOne == 1 && diceTwo == 1)
        {
            Console.WriteLine("Snake Eyes!");
        }
        else if ((diceTwo == 1 && diceOne == 2) || (diceTwo == 2 && diceOne == 1))
        {
            Console.WriteLine("Ace Deuce!");
        }
        else if (diceOne == 6 && diceTwo == 6)
        {
            Console.WriteLine("Box Cars!");
        }
        else if ((diceOne + diceTwo) == 7 || (diceOne + diceTwo) == 11)
        {
            Console.WriteLine("YOU WIN");
        }
        else if ((diceOne + diceTwo) == 2 || (diceOne + diceTwo) == 3 || (diceOne + diceTwo) == 12)
        {
            Console.WriteLine("CRAPS");
        }
    }

    // trying switch to see for rolling d20's 

    if (userDice == 20)
    {
        if (diceOne == 1 && diceTwo == 1)
        {
            Console.WriteLine("UNLUCKY");
        }
        else if (diceOne == 20 && diceTwo == 20)
        {
            Console.WriteLine("NOICE");
        }
    }


    // loop to see if user wants to play again
    bool valid = true;
    do
    {
        Console.Write("Would you like to roll again? (Y/N): ");
        string question = Console.ReadLine().ToUpper();

        if (question == "N" || question == "NO")
        {
            keepgoing = false;
            valid = true;
        }
        else if (question == "Y" || question == "YES")
        {
            keepgoing = true;
            valid = true;
        }
        else
        {
            Console.WriteLine("Invalid input");
            valid = false;
        }

    } while (valid == false);

} while (keepgoing);
Console.WriteLine();
Console.WriteLine("Thanks for playing!");