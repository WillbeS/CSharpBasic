using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        long longN = long.Parse(Console.ReadLine());
        uint n = (uint)longN;
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        uint newN = n;
        uint mask;
        uint bit;
        int index1;
        int index2;

        if (longN > uint.MaxValue || p + k > 32 || q + k > 32)
        {
            Console.WriteLine("Out of range");
            return;
        }
        
        if (Math.Max(p, q) <= Math.Min(p, q) + k - 1)
        {
            Console.WriteLine("Overlapping");
            return;
        }

        for (int i = 0; i < 2 * k; i++)
        {
            if (i < k)
            {
                index1 = p + i;
                index2 = q + i;
            }
            else
            {
                index1 = q + (i - k);
                index2 = p + (i - k);
            }

            bit = (n >> index1) & (uint)1; //take the bit at index1
            mask = (uint)1 << (index2); //set mask to position index2

            //Console.WriteLine("i = {0}, bit at index {1} = {3}, index2 = {2}", i, index1, index2, bit);
            //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

            //change the value of 24 with the one at 4
            if (bit == 1)
            {
                newN = newN | mask; //set it to 1 
                //Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
            }
            else
            {
                newN = newN & ~mask; //set it to 0
                //Console.WriteLine(Convert.ToString(~mask, 2).PadLeft(32, '0'));
            }
            //Console.WriteLine(Convert.ToString(newN, 2).PadLeft(32, '0'));
        }
        Console.WriteLine(newN);
    }
}