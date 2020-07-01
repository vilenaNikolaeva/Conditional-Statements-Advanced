using System;

namespace On_Time_For_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());

            int totalTimeExam = examHour * 60 + examMin;
            int totalTimeArrival = arrivalHour * 60 + arrivalMin;
            int resultFromTotal = totalTimeExam - totalTimeArrival;


            if (resultFromTotal >= 0 && resultFromTotal <= 30)
            {
                Console.WriteLine("On Time");
                if (resultFromTotal != 0)
                {
                    Console.WriteLine($"{resultFromTotal} minutes before the start");
                }
            }
            // .....................................................................
            else if (resultFromTotal > 30)
            {
                Console.WriteLine("Early");
                int hours = resultFromTotal / 60;
                int minutes = resultFromTotal % 60;
                string minutesStr = "0";

                if (minutes < 10)
                {
                    minutesStr += minutes;
                }
                else
                {
                    minutesStr = minutes.ToString();
                }

                if (hours > 0)
                {
                    Console.WriteLine($"{hours}:{minutesStr} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{minutesStr} minutes before the start");
                }
            }
            //.............................................................................
            else if (totalTimeArrival > totalTimeExam)
            {
                Console.WriteLine("Late");
                int hours = Math.Abs(resultFromTotal / 60);
                int minutes = Math.Abs(resultFromTotal % 60);
                string minutesStr = "0";
                if (minutes < 10)
                {
                    minutesStr += minutes;
                }
                else
                {
                    minutesStr = minutes.ToString();
                }

                if (hours > 0)
                {
                    Console.WriteLine($"{hours}:{minutesStr} hours after the start");
                }
                else
                {

                    Console.WriteLine($"{minutes} minutes after the start");
                }
            }
        }
    }
}
