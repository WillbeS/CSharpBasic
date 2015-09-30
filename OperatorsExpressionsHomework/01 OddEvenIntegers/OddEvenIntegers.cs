using System;

    class OddEvenIntegers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool odd = false;

            if (Math.Abs(number % 2) == 1) odd = true;

            Console.WriteLine(odd);
        }
    }

