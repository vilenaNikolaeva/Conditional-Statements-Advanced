using System;

namespace New_Home
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double numOfFlawers = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double price = 0.0;


            if (type == "Roses")
            {
                price = numOfFlawers * 5;
                if (numOfFlawers > 80)
                {
                    price -= price * 0.10;
                }
            }
            else if (type == "Dahlias")
            {
                price = numOfFlawers * 3.80;

                if (numOfFlawers > 90)
                {
                    price -= price * 0.15;
                }
            }
            else if (type == "Tulips")
            {
                price = numOfFlawers * 2.80;

                if (numOfFlawers > 80)
                {
                    price -= price * 0.15;
                }
            }
            else if (type == "Narcissus")
            {
                price = numOfFlawers * 3;

                if (numOfFlawers < 120)
                {
                    price += price * 0.15;
                }
            }
            else if (type == "Gladiolus")
            {
                price = numOfFlawers * 2.50;

                if (numOfFlawers < 80)
                {
                    price += price * 0.20;
                }
            }

            if (budget >= price)
            {
                double leftMoney = budget - price;
                Console.WriteLine($"Hey, you have a great garden with {numOfFlawers} {type} and {leftMoney:F2} leva left.");
            }
            else
            {
                double moneyUNeed = price - budget;
                Console.WriteLine($"Not enough money, you need {moneyUNeed:F2} leva more.");
            }

        }
    }
}
