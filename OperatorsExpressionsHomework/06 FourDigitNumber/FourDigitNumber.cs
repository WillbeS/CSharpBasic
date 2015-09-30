using System;

class FourDigitNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] digits = new int[4];
        int sum = 0;
        string reversed = "";

        for (int i = 0; i < 4; i++)
        {
            int n = (number /(int) Math.Pow(10, i)) % 10;

            reversed += n;
            sum += n; 

            digits[i] = n;

        }
        Console.WriteLine("Sum of digits - " + sum);
        Console.WriteLine("Reversed - " + reversed);
        Console.WriteLine("Last digit in front - " + (number % 10) + (number / 10));
        Console.WriteLine("Second and third digits exchanged - " + digits[3] + digits[1] +
            digits[2] + digits[0]);
    }
}