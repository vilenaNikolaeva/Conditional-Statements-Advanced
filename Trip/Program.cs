using System;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = string.Empty;
            string place = string.Empty;
            double moneySpend = 0;

            if (season == "summer")
            {
                if (budget <= 100)
                {
                    moneySpend = budget * 0.3;
                    destination = "Bulgaria";
                    place = "Camp";
                }
                else if (budget > 100 && budget <= 1000)
                {
                    moneySpend = budget * 0.4;
                    destination = "Balkans";
                    place = "Camp";
                }
                else
                {
                    moneySpend = budget * 0.9;
                    destination = "Europe";
                    place = "Hotel";
                }
            }
            else if (season == "winter")
            {
                place = "Hotel";
                if (budget <= 100)
                {
                    moneySpend = budget * 0.7;
                    destination = "Bulgaria";

                }
                else if (budget > 100 && budget <= 1000)
                {
                    moneySpend = budget * 0.8;
                    destination = "Balkans";

                }
                else
                {
                    moneySpend = budget * 0.9;
                    destination = "Europe";

                }
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {moneySpend:F2}");
        }
    }
    }
}
