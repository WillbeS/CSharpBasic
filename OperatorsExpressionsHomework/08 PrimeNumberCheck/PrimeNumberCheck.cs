using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool prime = false;

        if (n == 2 || n == 3 || (n != 1 && n % 2 != 0 && n % 3 != 0)) prime = true;

        Console.WriteLine(prime);
    }
}