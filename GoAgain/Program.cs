// instructions ask the user to enter a number print the square of the number, ask the user if they want to go again.
// they can enter y or Y to go again, n or N to quit. 

bool keepGoing = true;

do
{
    Console.Write("Enter a number: ");
    double number = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"That number squared is {number * number}");


    // Ask the user if they want to go again 
    bool valid = false;
    do
    {
        Console.Write("Would you like to go again? (y/n)");
        string entry = Console.ReadLine().ToUpper();

        if (entry == "N" || entry == "NO")
        {
            valid = true;
            keepGoing = false;
        }
        else if (entry == "Y" || entry == "YES")
        {
            valid = true;
            keepGoing |= true;
        }
        else
        {
            Console.WriteLine("Invalid input");
        }

    } while (valid == false);

} while (keepGoing);
