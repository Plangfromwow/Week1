// welcome message
Console.WriteLine("Welcome to Jacob's Room Detail Generator!");
// requesting input 
Console.WriteLine("Please enter the Length of your room:");
double Length = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the Width of your room:");
double Width = Convert.ToDouble(Console.ReadLine());

//Calculations 
double Height = 6;
double Area = Length * Width;
double Perimiter = (Length + Width) *2 ;
double Volume = Length * Width * 6;
double SurfaceArea = 2 * ((Length * Width)+(Length*Height)+(Height*Width));//SA=2(lw+lh+hw)

// Output to console 
Console.WriteLine();
Console.WriteLine($"The Area of your room is: {Area}ft!");
Console.WriteLine($"The Perimiter of your room is: {Perimiter}ft!");
Console.WriteLine($"The Volume of your room is: {Volume}ft! (Assuming your room is 6ft tall)");
Console.WriteLine($"The Surface Area of your room is: {SurfaceArea}ft! (Assuming your room is 6ft tall)");
Console.WriteLine();

// Check to see how big the room is 
if (Area <= 250)
{
    Console.WriteLine("Your room is pretty small!");
}
else if (Area > 250 && Area < 650)
{
    Console.WriteLine("You have a medium room!");
}
else
{
    Console.WriteLine("You have a big room!");
}

Console.WriteLine("Thank you for using my Room Detail Generator!");