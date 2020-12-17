using System;
using System.Collections.Generic;

namespace VtoraZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            string material = string.Empty;
            Dictionary<string, int> materials = new Dictionary<string, int>();

            while((material = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (materials.ContainsKey(material))
                {
                    materials[material] += quantity;
                }
                else
                {
                    materials.Add(material, quantity);
                }
            }

            foreach(var materialAndQuantity in materials)
            {
                Console.WriteLine($"{materialAndQuantity.Key} -> {materialAndQuantity.Value}");
            }
        }
    }
}
