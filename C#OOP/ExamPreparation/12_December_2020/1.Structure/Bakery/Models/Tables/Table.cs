﻿using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;
using Bakery.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.Tables
{
    public abstract class Table : ITable
    {
        private List<IBakedFood> foodOrders;
        private List<IDrink> drinkOrders;
        private int capacity;
        private int numberOfPeople;

        public Table(int tableNumber, int capacity, decimal pricePerPerson)
        {
            foodOrders = new List<IBakedFood>();
            drinkOrders = new List<IDrink>();

            this.TableNumber = tableNumber;
            this.Capacity = capacity;
            this.PricePerPerson = pricePerPerson;
        }

        public int TableNumber { get; private set; }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidTableCapacity);
                }
                this.capacity = value;
            }
        }

        public int NumberOfPeople 
        {
                get
            {
                    return this.numberOfPeople;
                }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidNumberOfPeople);
                }
                this.numberOfPeople = value;
            }
        }

        public decimal PricePerPerson { get; private set; }

        public bool IsReserved { get; private set; }

        public decimal Price
        {
            get
            {
                return PricePerPerson * NumberOfPeople;
            }
        }


        public void Clear()
        {
            foodOrders.Clear();
            drinkOrders.Clear();
            this.IsReserved = false;
            this.numberOfPeople = 0;
        }

        public decimal GetBill()
        {
            decimal bill = 0;
            foreach(var food in foodOrders)
            {
                bill += food.Price;
            }

            foreach(var drink in drinkOrders)
            {
                bill += drink.Price;
            }

            return bill;
        }

        public string GetFreeTableInfo()
        {
            return $"Table: {this.TableNumber}\r\n" +
            $"Type: {this.GetType().Name}\r\n" +
            $"Capacity: {this.Capacity}\r\n" +
            $"Price per Person: {this.PricePerPerson}";

        }

        public void OrderDrink(IDrink drink)
        {
            this.drinkOrders.Add(drink);
        }

        public void OrderFood(IBakedFood food)
        {
            this.foodOrders.Add(food);
        }

        public void Reserve(int numberOfPeople)
        {
            this.IsReserved = true;
            this.NumberOfPeople = numberOfPeople;
        }
    }
}
