using System;

class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double perimeter = (width + height) * 2;
        double area = width * height;

        Console.WriteLine("Perimeter = " + perimeter);
        Console.WriteLine("Area = " + area);
    }
}
