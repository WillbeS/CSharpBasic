using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long oddSum = 0;
        long evenSum = 0;

        for (int i = 0; i < 2 * n; i++)
        {
            if (i % 2 == 0)
            {
                oddSum += int.Parse(Console.ReadLine());
            }
            else
            {
                evenSum += int.Parse(Console.ReadLine());
            }
        }
        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes, sum={0}", oddSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(oddSum - evenSum));
        }
    }
}