using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects.Foods
{
    public class FoodDollar : Food
    {
        private const char FoodSymbol = '$';
        private const int Points = 2;
        private const ConsoleColor Color = ConsoleColor.Green;
        public FoodDollar(Wall wall) 
            : base(wall, FoodSymbol, Points, Color)
        {
        }
    }
}
