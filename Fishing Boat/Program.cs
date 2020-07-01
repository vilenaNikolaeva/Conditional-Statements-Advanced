using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            double groupBudget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double numFisherMan = double.Parse(Console.ReadLine());

            double curentPrice = 0;
            double totalPrice = 0;

            if (season == "Spring")
            {
                if (numFisherMan <= 6)
                {
                    curentPrice = 3000 - (3000 * 0.1);
                }
                else if (numFisherMan >= 7 && numFisherMan <= 11)
                {
                    curentPrice = 3000 - (3000 * 0.15);
                }
                else if (numFisherMan >= 12)
                {
                    curentPrice = 3000 - (3000 * 0.25);
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                if (numFisherMan <= 6)
                {
                    curentPrice = 4200 - (4200 * 0.1);
                }
                else if (numFisherMan >= 7 && numFisherMan <= 11)
                {
                    curentPrice = 4200 - (4200 * 0.15);
                }
                else if (numFisherMan >= 12)
                {
                    curentPrice = 4200 - (4200 * 0.25);
                }
            }
            else if (season == "Winter")
            {
                if (numFisherMan <= 6)
                {
                    curentPrice = 2600 - (2600 * 0.1);
                }
                else if (numFisherMan >= 7 && numFisherMan <= 11)
                {
                    curentPrice = 2600 - (2600 * 0.15);
                }
                else if (numFisherMan >= 12)
                {
                    curentPrice = 2600 - (2600 * 0.25);
                }
            }

            if (numFisherMan % 2 == 0 && season != "Autumn")
            {

                totalPrice = curentPrice - (curentPrice * 0.5);
            }
            else
            {

                totalPrice = curentPrice;
            }

            if (totalPrice <= groupBudget)
            {
                double leftMoney = groupBudget - totalPrice;
                Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
            }
            else
            {
                double moneyUNeed = groupBudget - totalPrice;
                Console.WriteLine($"Not enough money! You need {moneyUNeed:F2} leva.");
            }
        }
    }
}
