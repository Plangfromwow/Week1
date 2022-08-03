//// pass by reference 

////double first = 3.5;
////double second = 4.5;
////double area = rectangleArea(ref first, ref second);
////Console.WriteLine($"Rectangle {first} by {second} has area {area}");
////
////static double rectangleArea(ref double length, ref double width)
////{
////    double result = length * width;
////    length = 100;
////    width = 100;
////    return length * width;
////}



// Out Parameter 

double result;
bool worked = Divide(10, 2, out result);
Console.WriteLine(worked);
Console.WriteLine(result);

static bool Divide(double num1 , double num2, out double result)
{
    // check if num2 is 0 and if it is don't do it 
    if (num2 == 0.0)
    {
        result = 0;
        return false;
    }
    else
    {
        result = num1 / num2;
        return true;
    }
}