using System;

class BitExchange
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint newN = n;
        uint mask;
        uint bit;
        int index1;
        int index2;

        //3, 4, 5, 24, 25, 26


        for (int i = 0; i < 6; i++)
        {
            if (i < 3)
            {
                index1 = 3 + i;
                index2 = 24 + i;
            }
            else
            {
                index1 = 24 + (i - 3);
                index2 = 3 + (i - 3);
            }
            bit = (n >> index1) & (uint)1; //take the bit at index1
            mask = (uint)1 << (index2); //set mask to position index2

            //change the value of 24 with the one at 4
            if (bit == 1)
            {
                newN = newN | mask; //set it to 1 
            }
            else
            {
                newN = newN & ~mask; //set it to 0
            }   
        }
        Console.WriteLine(newN);
    }
}