using System;
using System.Text;

    class AsciiTable
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            for (int i = 33; i <= 255; i++)
            {
                Console.WriteLine("{0}: {1}", i, (char)i);

            }


        }
    }

