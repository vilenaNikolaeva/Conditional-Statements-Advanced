using System;

namespace Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();

            string outFit = string.Empty;
            string shoes = string.Empty;
            bool chilly = degrees >= 10 && degrees <= 18;
            bool warm = degrees > 18 && degrees <= 24;
            bool hot = degrees >= 25;


            if (timeOfTheDay == "Morning")
            {
                if (chilly)
                {
                    outFit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (warm)
                {
                    outFit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (hot)
                {
                    outFit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (timeOfTheDay == "Afternoon")
            {
                if (chilly)
                {
                    outFit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (warm)
                {
                    outFit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (hot)
                {
                    outFit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else if (timeOfTheDay == "Evening")
            {
                outFit = "Shirt";
                shoes = "Moccasins";
            }

            Console.WriteLine($"It's {degrees} degrees, get your {outFit} and {shoes}.");
        }
    }
}
