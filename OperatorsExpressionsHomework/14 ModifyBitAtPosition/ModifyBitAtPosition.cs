using System;

class ModifyBitAtPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        byte p = byte.Parse(Console.ReadLine());
        byte v = byte.Parse(Console.ReadLine());
        int mask = 1 << p;
        int result;

        if (v == 1)
        {
            result = n | mask;
        }
        else
        {
            if (n == 1)
            {
                result = n ^ mask;
            }
            else
            {
                result = n & ~mask;
            }
            
        }

        Console.WriteLine(result);
    }
}