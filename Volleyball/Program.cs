using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekends = int.Parse(Console.ReadLine());


            double weekendsInYear = 48;
            double weekendsInSofiq = weekendsInYear - weekends;
            double saturdayGameDay = weekendsInSofiq * (3.0 / 4);
            double playingHolidays = holidays * (2.0 / 3);
            double weekndInYear = saturdayGameDay + playingHolidays + weekends;

            if (year == "leap")
            {
                double leapYear = weekndInYear * 0.15;
                double totalGameinYear = leapYear + weekndInYear;
                Console.WriteLine(Math.Floor(totalGameinYear));
            }
            else if (year == "normal")
            {
                Console.WriteLine(Math.Floor(weekndInYear));
            }

        }
    }
}
