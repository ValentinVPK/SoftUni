using System;
using System.Collections.Generic;
using System.Linq;

namespace TretaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>(){
                {"fragments", 0 },
                {"shards", 0 },
                {"motes", 0 }
            };
            bool legendaryItemObtained = false;
            while (legendaryItemObtained == false)
            {
                string[] materials = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < materials.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        string currentMaterial = materials[i + 1].ToLower();
                        int quantity = int.Parse(materials[i]);
                        switch (currentMaterial)
                        {
                            case "shards":
                                keyMaterials[currentMaterial] += quantity;
                                if (keyMaterials[currentMaterial] >= 250)
                                {
                                    legendaryItemObtained = true;
                                    Console.WriteLine("Shadowmourne obtained!");
                                    keyMaterials[currentMaterial] -= 250;
                                }
                                break;
                            case "fragments":
                                keyMaterials[currentMaterial] += quantity;
                                if (keyMaterials[currentMaterial] >= 250)
                                {
                                    legendaryItemObtained = true;
                                    Console.WriteLine("Valanyr obtained!");
                                    keyMaterials[currentMaterial] -= 250;
                                }
                                break;
                            case "motes":
                                keyMaterials[currentMaterial] += quantity;
                                if (keyMaterials[currentMaterial] >= 250)
                                {
                                    legendaryItemObtained = true;
                                    Console.WriteLine("Dragonwrath obtained!");
                                    keyMaterials[currentMaterial] -= 250;
                                }
                                break;
                            default:
                                if (junk.ContainsKey(currentMaterial)) junk[currentMaterial] += quantity;
                                else junk.Add(currentMaterial, quantity);
                                break;
                        }

                        if (legendaryItemObtained) break;
                    }
                }
            }

            foreach(var material in keyMaterials.OrderByDescending(m => m.Value).ThenBy(m => m.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach(var material in junk)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}
