using System;

class CheckBitAtPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        bool isOne = false;

        if ((n >> p & 1) == 1) isOne = true;

        Console.WriteLine(isOne);
    }
}