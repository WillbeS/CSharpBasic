using System;

class BitsUp
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int numberN;
        int stepCounter = 0;
        int mask;
        int index;
        string output = "";

        for (int i = 0; i < number; i++)
        {
            numberN = int.Parse(Console.ReadLine());
 
            for (int j = 0; j < number * 8; j++)
            {
                if (1 + stepCounter * step < 8*(i + 1))
                {
                    index = (1 + stepCounter * step) - i * 8;
                    mask = 1 << 7 - index;
                    numberN = numberN | mask;
                    stepCounter++;
                }
                else
                {
                    break;
                }
                
            }
            //Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(8, '0'));
            output += numberN;
            if (i < number - 1) output += "\n";
            
        }
        Console.WriteLine(output);
    }
}