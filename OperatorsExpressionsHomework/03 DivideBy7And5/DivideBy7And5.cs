using System;

class DivideBy7And5
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool result = false;

        if (number != 0 && number % 7 == 0 && number % 5 == 0) result = true;

        Console.WriteLine(result);
    }
}
