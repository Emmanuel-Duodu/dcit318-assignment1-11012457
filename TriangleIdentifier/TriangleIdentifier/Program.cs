using System;

class TriangleTypeIdentifier
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of side 1:");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side 2:");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side 3:");
        double side3 = Convert.ToDouble(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("The triangle is Equilateral.");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("The triangle is Isosceles.");
        }
        else
        {
            Console.WriteLine("The triangle is Scalene.");
        }
    }
}