using System;

class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char symbol = '-';
        int count = n/2;

        for (int i = 0; i < n; i++)
        {
            Console.Write(new String(symbol, Math.Abs(count)));
            Console.Write("*");

            if (i > 0 && i < n - 1)
            {
                Console.Write(new String(symbol, n - Math.Abs(2 * count) - 2));
                Console.Write("*");
            }
            Console.WriteLine(new String(symbol, Math.Abs(count)));

            count--;
        }
    }
}