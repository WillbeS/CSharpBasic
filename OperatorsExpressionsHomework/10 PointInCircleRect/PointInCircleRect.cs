using System;

class PointInCircleRect
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        string isInside = "no";

        if ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5 && y > 1) isInside = "yes";

        Console.WriteLine(isInside);
    }
}