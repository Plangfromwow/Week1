// For Loop 

for (int i = 0; i < 10; i++) //fizz buzz 
{
    Console.WriteLine(i);
}

Console.WriteLine();
for (int i = 0; i <= 10; i+=2)
{
    Console.WriteLine(i);
}

Console.WriteLine();
for (int i =21; i >= 0; i =i - 3)
{
    Console.WriteLine(i);
}


Console.WriteLine("All Done!");

Console.WriteLine();
// while loop 
int w = 1;

while (w < 5)
{
    Console.WriteLine("Inside while loop");
    Console.WriteLine(w);
    w++;
}

//example of a break statement inside a while
Console.WriteLine();
int w2 = 10;

while (w2 >= 0)
{
    Console.WriteLine(w2);
    w2--;

    if (w2 == 6)
    {
        Console.WriteLine("Left loop because found 6");
        break;
    }
}


Console.WriteLine("onto do while loops");
Console.WriteLine();

// while loops condition is tested before each itteration, do while they are tested at the end 
int w3 = 0;
do
{
    w3++;
    Console.WriteLine(w3);
    
} while (w3 < 10 );

Console.WriteLine("All done with while loops, now for nested for loops");


