using System;

namespace _10.Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            var lostGames = int.Parse(Console.ReadLine());
            var headsetPrice = double.Parse(Console.ReadLine());
            var mousePirce = double.Parse(Console.ReadLine());
            var keyboardPrice = double.Parse(Console.ReadLine());
            var displayPrice = double.Parse(Console.ReadLine());
            int trashedHeadsets = 0;
            int trashedMouses = 0;
            int trashedKeyboards = 0;
            int trashedDisplays = 0;

            for (int game = 1; game <= lostGames; game++)
            {
                if (game % 2 == 0) trashedHeadsets++;
                if (game % 3 == 0) trashedMouses++;
                if (game % 2 == 0 && game % 3 == 0) trashedKeyboards++;
            }
            trashedDisplays = trashedKeyboards / 2;
            double rageExpenses = trashedHeadsets * headsetPrice + trashedMouses * mousePirce + trashedKeyboards * keyboardPrice + trashedDisplays * displayPrice;
            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}
