// See https://aka.ms/new-console-template for more information
int numericalRange;

Console.WriteLine("Hello user, this program will ask you to enter a numerical grade and it will display the corresponding letter grade.");
Console.Write("\n\nPlease enter the numerical grade: ");
numericalRange = Convert.ToInt32(Console.ReadLine());

if(numericalRange >= 0 && numericalRange <= 39)
{
    Console.WriteLine("\n\nGrade = E");
}
else if(numericalRange >= 40 && numericalRange <= 49)
{
    Console.WriteLine("\n\nGrade = D");
}
else if (numericalRange >= 50 && numericalRange <= 56)
{
    Console.WriteLine("\n\nGrade = C");
}
else if (numericalRange >= 57 && numericalRange <= 63)
{
    Console.WriteLine("\n\nGrade = C+");
}
else if (numericalRange >= 64 && numericalRange <= 70)
{
    Console.WriteLine("\n\nGrade = B");
}
else if (numericalRange >= 71 && numericalRange <= 77)
{
    Console.WriteLine("\n\nGrade = B+");
}
else if (numericalRange >= 78 && numericalRange <= 84)
{
    Console.WriteLine("\n\nGrade = A");
}
else if (numericalRange >= 85 && numericalRange <= 100)
{
    Console.WriteLine("\n\nGrade = A+");
}