// Initial welcome
Console.WriteLine("Learn your squared and cubes!");

bool loop = true;
do
{
    // Asking for integer
    // 2467 is the highest it can go
    Console.WriteLine();
    Console.Write("Enter an Integer between 1 and 2467:");
    int num = Convert.ToInt32(Console.ReadLine());

    // Verify valid number has been chosen
    while (num! < 0 || num! > 2467)
    {
        Console.WriteLine("Must be a number between 1 and 2467.");
        Console.Write("Enter an Integer between 1 and 2467:");
        num = Convert.ToInt32(Console.ReadLine());
    }

    // creating the table
    Console.Write("Number\tSquared\tCubed");
    Console.WriteLine();
    Console.WriteLine("======\t======\t======");

    for (int i = 0; i <= num; i++)
    {
        Console.Write($"{i}\t{i * i}\t{i * i * i}");
        Console.WriteLine();
    }

    // would you like to play again prompt
    bool valid = true;
    do
    {
        Console.WriteLine("Would you like to see another table? (Y/N)");
        string question = Console.ReadLine().ToUpper();

        if (question == "N" || question == "NO")
        {
            loop = false;
            valid = true;
        }
        else if (question == "Y" || question == "YES")
        {
            loop = true;
            valid = true;
        }
        else
        {
            Console.WriteLine("Invalid input");
            valid = false;
        }

    } while (valid == false);


} while (loop);