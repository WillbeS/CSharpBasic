using System;

    class JoroFootballPlayer
    {
        static void Main(string[] args)
        {
            //variables
            byte totalWeekends = 52;
            float normalWeekendPlays;
            float holidayPlays;
            float totalPlayDays;

            //get input
            string yearType = Console.ReadLine();
            byte holidays = Convert.ToByte(Console.ReadLine());
            byte hometown = Convert.ToByte(Console.ReadLine());



            //calculate the pay days
            normalWeekendPlays = (totalWeekends - hometown) * ((float)2 / 3); //plays in 2/3 of the normal weekends
            holidayPlays = (holidays * (float)1 / 2); //plays in 1/2 of the holidays
            totalPlayDays = normalWeekendPlays + holidayPlays + hometown;

            if (yearType == "t") totalPlayDays += 3;

            Console.WriteLine((int)totalPlayDays);
    }
}
