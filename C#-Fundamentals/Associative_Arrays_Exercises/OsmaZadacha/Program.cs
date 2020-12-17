using System;
using System.Collections.Generic;
using System.Linq;

namespace OsmaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            SortedDictionary<string, List<string>> companies = new SortedDictionary<string, List<string>>();

            while((command = Console.ReadLine()) != "End")
            {
                string[] companyAndId = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = companyAndId[0];
                string employeeId = companyAndId[1];

                if (companies.ContainsKey(companyName))
                {
                    if(companies[companyName].Contains(employeeId) == false)
                    {
                        companies[companyName].Add(employeeId);
                    }
                }
                else
                {
                    companies.Add(companyName, new List<string>());
                    companies[companyName].Add(employeeId);
                }
            }

            foreach(var company in companies)
            {
                Console.WriteLine(company.Key);
                foreach(string id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
