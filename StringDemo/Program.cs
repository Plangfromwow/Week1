string name = "George";

Console.WriteLine(name);
// every object has methods that we can do, we are asking it to do things. 
string uppername = name.ToUpper(); // strings are immutable 

Console.WriteLine(uppername);

// Print out letters of name
Console.WriteLine(name[0]);
Console.WriteLine(name[1]);
Console.WriteLine(name[2]);
Console.WriteLine(name[3]);
Console.WriteLine(name[4]);
Console.WriteLine(name[5]);



Console.WriteLine(name.ToLower());

// more than strings in here 

// Floating point types (doubles, floats, pain)  

double pi = 3.1415926;
Console.WriteLine(pi);
double pi2 = pi * 2;
Console.WriteLine(pi2);

Console.WriteLine(Math.Sqrt(pi));

// we don't use float much anymore. Put f at the end for it to read it. WE NEVER USE FLOAT WHEN WORKING WITH MONEY  
float n = 3.1359226f;

float x = 10;

x = x / 3;
Console.WriteLine(x);
Console.WriteLine(x+x+x);

decimal amount = 95.95m;
Console.WriteLine(amount);
amount = amount * 2;
Console.WriteLine(amount);

bool passed = true;
Console.WriteLine(passed);
passed = false;
Console.WriteLine(passed);
// ! means *not* and it flips the boolean 
passed = !passed;
Console.WriteLine(passed);