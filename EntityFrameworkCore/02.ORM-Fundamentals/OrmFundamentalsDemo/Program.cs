using OrmFundamentalsDemo.Models;
using System;
using System.Linq;

namespace OrmFundamentalsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new SoftUniContext();

            db.Towns.Add(new Town { Name = "Pernik" });
            db.SaveChanges();
            //Console.WriteLine(db.Employees.Count());

            foreach (var employee in db.Employees
                .Where(x => x.FirstName.StartsWith("N"))
                .OrderByDescending(x => x.Salary)
                .Select(x => new { x.FirstName, x.LastName, x.Salary })) 
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} => {employee.Salary}");
            }

            var departments = db.Employees.GroupBy(x => x.Department.Name)
                .Select(x => new { Name = x.Key, Count = x.Count() })
                .ToList();

            foreach (var department in departments)
            {
                Console.WriteLine($"{department.Name} => {department.Count}");
            }
        }
    }
}
