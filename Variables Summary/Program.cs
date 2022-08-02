Console.WriteLine("Integers");

int x = 10;
x = x * 2;
x++;
Console.WriteLine(x); // we should see 21
Console.WriteLine();
Console.WriteLine("Strings");

string product = "Monitor";
product = product.ToUpper();
Console.WriteLine(product);
Console.WriteLine();
Console.WriteLine("Doubles"); 

double first = 2.5;
double pi = Math.PI;
Console.WriteLine(first);
Console.WriteLine(pi);
double mult = first * pi;
Console.WriteLine(mult);
Console.WriteLine();
Console.WriteLine("Decimals");

decimal charge = 10.25m;
decimal perc = charge / 3;
Console.WriteLine(perc);

Console.WriteLine();
Console.WriteLine("Boolean");

bool finished = false;
Console.WriteLine(finished);

bool another = !finished;
Console.WriteLine(another);

Console.WriteLine();
Console.WriteLine("Expressions that are true or false");

int q = 20;

bool test1 = (q > 10); // q is greater than 10. True or False? Don't ask a question ask a different question 
Console.WriteLine(test1);

// Let's just print a couple out directly 

Console.WriteLine(q > 30); // expect to see false 
Console.WriteLine(q == 20); // true
Console.WriteLine(q != 20); // false

Console.WriteLine( !(q !=20) ); //true 

// adding in "and" "or"

int j = 10;
int k = 11;

Console.WriteLine((j ==10) && (k == 11)); // should be true 
Console.WriteLine((j == 10) && (k == 12)); // should be false
Console.WriteLine((j == 10) || (k == 23)); // should be true 
