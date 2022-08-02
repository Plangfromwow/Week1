// switch demo 

int n = 1;

if (n == 0)
{
    Console.WriteLine("Zero");
}
else if (n == 1)
{
    Console.WriteLine("One");
}
else if (n == 2)
{
    Console.WriteLine("2");
}
else
{
    Console.WriteLine("I don't know");
}

switch (n)
{
    case 0:
        Console.WriteLine("Zero");
        break;
    case 1:
        Console.WriteLine("1");
        break;
    case 2: 
        Console.WriteLine("2");
        break;
    case >= 10:
        Console.WriteLine("Greater than 10");
        break;
    case < 0:
        Console.WriteLine("Do the thing");
        break ;
    default: Console.WriteLine("I don't know");
        break;
}

