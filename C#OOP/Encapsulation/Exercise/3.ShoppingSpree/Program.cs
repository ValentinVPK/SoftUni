using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peopleTokens = Console.ReadLine().Split(new char[] { ';', '=' });
            string[] productsTokens = Console.ReadLine().Split(new char[] { ';', '=' });

            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            try
            {
                for (int i = 0; i < peopleTokens.Length - 1; i+= 2)
                {
                    people.Add(new Person(peopleTokens[i], double.Parse(peopleTokens[i + 1])));
                }

                for(int i = 0; i < productsTokens.Length - 1; i+= 2)
                {
                    products.Add(new Product(productsTokens[i], double.Parse(productsTokens[i + 1])));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }


            string input = string.Empty;

            while((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var currPerson = people.Find(p => p.Name == tokens[0]);
                var currProduct = products.Find(p => p.Name == tokens[1]);

                currPerson.AddProduct(currProduct);
            }

            foreach(var person in people)
            {
                if(person.BagOfProducts.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts)}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
}
