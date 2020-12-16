using System;

namespace _3.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0.0;

            if (typeOfGroup == "Students")
            {
                if (day == "Friday") totalPrice = 8.45 * numberOfPeople;
                else if (day == "Saturday") totalPrice = 9.80 * numberOfPeople;
                else if (day == "Sunday") totalPrice = 10.46 * numberOfPeople;

                if (numberOfPeople >= 30) totalPrice = totalPrice - 15 / 100.0 * totalPrice;
            }
            else if (typeOfGroup == "Business")
            {
                if (day == "Friday")
                {
                    totalPrice = 10.90 * numberOfPeople;
                    if (numberOfPeople >= 100) totalPrice = totalPrice - 10 * 10.90;
                }
                else if (day == "Saturday")
                {
                    totalPrice = 15.60 * numberOfPeople;
                    if (numberOfPeople >= 100) totalPrice = totalPrice - 10 * 15.60;
                }
                else if (day == "Sunday")
                {
                    totalPrice = 16 * numberOfPeople;
                    if (numberOfPeople >= 100) totalPrice = totalPrice - 10 * 16;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                if (day == "Friday") totalPrice = 15 * numberOfPeople;
                else if (day == "Saturday") totalPrice = 20 * numberOfPeople;
                else if (day == "Sunday") totalPrice = 22.50 * numberOfPeople;

                if (numberOfPeople >= 10 && numberOfPeople <= 20) totalPrice = totalPrice - 5 / 100.0 * totalPrice;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
