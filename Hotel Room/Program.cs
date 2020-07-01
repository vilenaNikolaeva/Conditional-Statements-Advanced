using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double numNights = double.Parse(Console.ReadLine());

            double totalPriceStudio = 0;
            double totalPriceApartment = 0;

            if (month == "May" || month == "October")
            {
                if (numNights > 7 && numNights <= 14)
                {
                    totalPriceStudio = numNights * (50 - (50 * 0.05));
                    totalPriceApartment = numNights * 65.00;
                }
                else if (numNights > 14)
                {
                    totalPriceStudio = numNights * (50 - (50 * 0.3));
                    totalPriceApartment = numNights * (65 - (65 * 0.1));
                }
                else
                {
                    totalPriceStudio = numNights * 50;
                    totalPriceApartment = numNights * 65;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (numNights <= 14)
                {
                    totalPriceStudio = numNights * 75.20;
                    totalPriceApartment = numNights * 68.70;
                }
                else
                {
                    totalPriceStudio = numNights * (75.20 - (75.20 * 0.2));
                    totalPriceApartment = numNights * (68.70 - (68.70 * 0.10));
                }
            }
            else if (month == "July" || month == "August")
            {
                totalPriceStudio = (numNights * 76.00);

                if (numNights <= 14)
                {
                    totalPriceApartment = numNights * 77.00;
                }
                else
                {
                    totalPriceApartment = numNights * (77.00 - (77.00 * 0.10));
                }
            }
            Console.WriteLine($"Apartment: {totalPriceApartment:F2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");
        }
    }
}
