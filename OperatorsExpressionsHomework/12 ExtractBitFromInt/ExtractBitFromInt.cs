using System;

class ExtractBitFromInt
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int result = (n >> p) & 1;

        Console.WriteLine(result);
    }
}