using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            double incomePremiere = rows * column * 12;
            double incomeNormal = rows * column * 7.50;
            double incomeDiscount = rows * column * 5.00;


            if (type == "Premiere")
            {
                Console.WriteLine(incomePremiere);
            }
            else if (type == "Normal")
            {
                Console.WriteLine(incomeNormal);
            }
            else if (type == "Discount")
            {
                Console.WriteLine(incomeDiscount);
            }
        }
    }
}
