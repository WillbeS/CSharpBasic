using System;

class BitSifting
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        byte n = byte.Parse(Console.ReadLine());
        byte count = 0;

        for (int i = 0; i < n; i++)
        {
            ulong sieve = ulong.Parse(Console.ReadLine());
            number = number & (~sieve);
        }
        for (int i = 0; i < 64; i++)
        {
            int bit = (int)((number >> i) & (ulong)1);
            if (bit == 1)
            {
                count++;
            }
           
        }
        Console.WriteLine(count);
    }
}