using System;

    class StringsObjects
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            
            object combined = hello + " " + world;

            string combinedString = (string) combined;

            Console.WriteLine(combinedString);
        }
    }

