using System;
using System.Collections.Generic;
using System.Text;

namespace _3.ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> bagOfProducts;

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.bagOfProducts = new List<Product>();
        }
        public string Name 
        {
            get
            {
                return this.name;
            }
            private set
            {
                if(value == null || value == " " || value == "  ")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public double Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> BagOfProducts
        {
            get
            {
                return this.bagOfProducts.AsReadOnly();
            }
        }

        public void AddProduct(Product product)
        {
            if(this.money < product.Cost)
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} bought {product.Name}");
                bagOfProducts.Add(product);
                this.money -= product.Cost;
            }
        }
    }
}
