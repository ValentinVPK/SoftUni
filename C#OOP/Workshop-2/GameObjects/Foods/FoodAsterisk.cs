﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects.Foods
{
    public class FoodAsterisk : Food
    {
        private const char FoodSymbol = '*';
        private const int Points = 1;
        private const ConsoleColor Color = ConsoleColor.Red;
        public FoodAsterisk(Wall wall) 
            : base(wall, FoodSymbol, Points, Color)
        {
        }
    }
}
