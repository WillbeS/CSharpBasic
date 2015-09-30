using System;

class Volleyball
{
    static void Main()
    {
        string leap = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int hometownW = int.Parse(Console.ReadLine());

        double normalWPlays = (48 - hometownW) * 3 / (double)4;
        double holidayPlays = holidays * 2 / (double)3;

        double totalPlays = normalWPlays + holidayPlays + hometownW;
        if (leap == "leap") totalPlays += totalPlays * 15 / (double)100;

        Console.WriteLine((int)totalPlays);
    }
}