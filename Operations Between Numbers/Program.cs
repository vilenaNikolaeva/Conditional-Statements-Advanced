using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            double calculation = 0;
            string even = "even";
            string odd = "odd";


            if (symbol == "+")
            {
                calculation = N1 + N2;
            }
            else if (symbol == "-")
            {
                calculation = N1 - N2;
            }
            else if (symbol == "*")
            {
                calculation = N1 * N2;
            }
            else if (symbol == "/" && N2 != 0)
            {
                calculation = N1 / N2;
            }
            else if (symbol == "%" && N2 != 0)
            {
                calculation = N1 % N2;
            }

            //............................
            if (symbol == "+" || symbol == "-" || symbol == "*")
            {
                if ((int)calculation % 2 == 0)
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {calculation} - {even}");
                }
                else if ((int)calculation % 2 == 1)
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {calculation} - {odd}");
                }
                else
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {calculation} - {odd}");
                }
            }
            else if (symbol == "/")
            {
                if (N2 != 0)
                {
                    Console.WriteLine($"{N1} / {N2} = {calculation:F2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }
            else if (symbol == "%")
            {
                if (N2 != 0)
                {
                    Console.WriteLine($"{N1} % {N2} = {calculation}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }
        }
    }
}
