using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects.Foods
{
    public class FoodHash : Food
    {
        private const char FoodSymbol = '#';
        private const int Points = 3;
        private const ConsoleColor Color = ConsoleColor.Blue;
        public FoodHash(Wall wall) 
            : base(wall, FoodSymbol, Points, Color)
        {
        }
    }
}
