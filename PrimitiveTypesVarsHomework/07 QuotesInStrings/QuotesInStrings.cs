using System;

    class QuotesInStrings
    {
        static void Main()
        {
            string quoteOne = "The \"use\" of quotations causes difficulties.";
            string quoteTwo = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine("{0}\n{1}", quoteOne, quoteTwo);
        }
    }

