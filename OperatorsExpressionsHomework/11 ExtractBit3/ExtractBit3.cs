using System;

class ExtractBit3
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint result = (n >> 3) & (uint)1;
        Console.WriteLine(result);
    }
}