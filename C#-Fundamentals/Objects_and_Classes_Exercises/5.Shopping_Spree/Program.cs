using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _5.Shopping_Spree
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public double Money { get; set; }
            public List<Product> BagOfProducts { get; set; }

            public Person(string name, double money)
            {
                Name = name;
                Money = money;
                BagOfProducts = new List<Product>();
            }

            public void BuyingProduct(Product product)
            {
                if (product.Price <= Money)
                {
                    BagOfProducts.Add(product);
                    Money -= product.Price;
                    Console.WriteLine($"{Name} bought {product.Name}");
                }
                else
                {
                    Console.WriteLine($"{Name} can't afford {product.Name}");
                }
            }
        }

        class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }

            public Product(string name, double price)
            {
                Name = name;
                Price = price;
            }
        }
        static void Main(string[] args)
        {
            List<Person> listOfPeople = new List<Person>();
            List<Product> listOfProducts = new List<Product>();
            string[] allPeople = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (string person in allPeople)
            {
                string[] nameAndMoney = person.Split("=", StringSplitOptions.RemoveEmptyEntries);
                Person currentPerson = new Person(nameAndMoney[0], double.Parse(nameAndMoney[1]));
                listOfPeople.Add(currentPerson);
            }

            string[] allProducts = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (string product in allProducts)
            {
                string[] nameAndPrice = product.Split("=", StringSplitOptions.RemoveEmptyEntries);
                Product currentProduct = new Product(nameAndPrice[0], double.Parse(nameAndPrice[1]));
                listOfProducts.Add(currentProduct);
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] PersonAndProduct = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string personName = PersonAndProduct[0];
                string productName = PersonAndProduct[1];

                int personIndex = listOfPeople.FindIndex(x => x.Name == personName);
                int productIndex = listOfProducts.FindIndex(x => x.Name == productName);
                listOfPeople[personIndex].BuyingProduct(listOfProducts[productIndex]);
            }

            foreach (Person person in listOfPeople)
            {
                if (person.BagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine(person.Name + " - " + string.Join(", ", person.BagOfProducts.Select(x => x.Name)));
                }
            }
        }
    }
}
