using System;

class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool isInside = false;

        if (Math.Abs(x * x + y * y) <= 4) isInside = true;
        Console.WriteLine(isInside);
    }
}