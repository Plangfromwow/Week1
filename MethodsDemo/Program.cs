
int first = TimesTwo(5);
Console.WriteLine(first);

int num = TimesTwo(10);
Console.WriteLine(num);

int second = SomeNumber();
Console.WriteLine(second);

double area = CircleArea(3);
Console.WriteLine(area);

double area2 = TriangleArea(3, 3);
Console.WriteLine(area2);

PrintArea(10);

// Variables num and result have a scope of this function only, cannot pull in variables outside the function to use inside either 
static int TimesTwo(int num)
{
    int result = num * 2;
    return result;
}

static int SomeNumber()
{
    return 20;
}

static double CircleArea(double radius)
{
    return Math.PI * (radius * radius);
}

static double TriangleArea(int height, int width)
{
    return (height * width) / 2.00; // add a .0 to 2 to force the calculation to be double
}

// in the eyes of the compiler, every function must return something. 
static void PrintArea (double radius)
{
    double area = CircleArea(radius);
    Console.WriteLine(area);
}

