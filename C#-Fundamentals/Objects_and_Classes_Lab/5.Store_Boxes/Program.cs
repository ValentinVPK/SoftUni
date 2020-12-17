using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Globalization;

namespace _5.Store_Boxes
{
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForABox { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            List<Box> boxes = new List<Box>();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] data = command.Split();

                int serialNumber = int.Parse(data[0]);
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                double itemPrice = double.Parse(data[3], CultureInfo.InvariantCulture);

                Box newBox = new Box();
                newBox.Item.Name = itemName;
                newBox.Item.Price = itemPrice;
                newBox.SerialNumber = serialNumber;
                newBox.ItemQuantity = itemQuantity;
                newBox.PriceForABox = itemQuantity * itemPrice;

                boxes.Add(newBox);
            }

            List<Box> sortedList = boxes.OrderBy(o => o.PriceForABox).ToList();
            sortedList.Reverse();

            foreach (Box box in sortedList)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }
}
