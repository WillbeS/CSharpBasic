using System;

    class NullValues
    {
        static void Main()
        {
            int? intNull = null;
            double? doubleNull = null;
            Console.WriteLine("{0}\n{1}", intNull, doubleNull);

            intNull += null;
            doubleNull += 15.34;
            Console.WriteLine("{0}\n{1}", intNull, doubleNull);

            Console.WriteLine(intNull + doubleNull);
            doubleNull = 12.001;
            Console.WriteLine(intNull + doubleNull);
            Console.WriteLine(doubleNull);
        }
    }

