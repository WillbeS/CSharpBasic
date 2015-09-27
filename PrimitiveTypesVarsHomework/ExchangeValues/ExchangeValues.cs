using System;

    class ExchangeValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before:\n a = {0}\n b = {1}", a, b);

           //Exchange values
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After:\n a = {0}\n b = {1}", a, b);
        }
    }

