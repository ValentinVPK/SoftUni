using System;

namespace _9.Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var moneyAmount = double.Parse(Console.ReadLine());
            var numberOfStudents = int.Parse(Console.ReadLine());
            var pricePerLightsaber = double.Parse(Console.ReadLine());
            var pricePerRobe = double.Parse(Console.ReadLine());
            var pricePerBelt = double.Parse(Console.ReadLine());

            double finalPrice = Math.Ceiling((numberOfStudents + 10 / 100.0 * numberOfStudents)) * pricePerLightsaber + numberOfStudents * pricePerRobe + (numberOfStudents - numberOfStudents / 6) * pricePerBelt;

            if (finalPrice <= moneyAmount)
            {
                Console.WriteLine($"The money is enough - it would cost {finalPrice:f2}lv.");
            }
            else
            {
                double moneyNeeded = finalPrice - moneyAmount;
                Console.WriteLine($"Ivan Cho will need {moneyNeeded:f2}lv more.");
            }
        }
    }
}
