using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _1.Company_Roster
{
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }

    class Department
    {
        public Department(string departmentName)
        {
            Employees = new List<Employee>();
            DepartmentName = departmentName;
        }
        public List<Employee> Employees { get; set; }
        public string DepartmentName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());
            List<Employee> listOfEmployees = new List<Employee>();
            List<Department> listOfDepartments = new List<Department>();

            // Putting all of the employees into their deparments:
            for (int i = 1; i <= numberOfEmployees; i++)
            {
                string[] employeeInformation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string employeeName = employeeInformation[0];
                double employeeSalary = double.Parse(employeeInformation[1], CultureInfo.InvariantCulture);
                string departmentName = employeeInformation[2];

                if (!listOfDepartments.Any(item => item.DepartmentName == departmentName))
                {
                    Department currentDepartment = new Department(departmentName);
                    Employee currentEmployee = new Employee(employeeName, employeeSalary);
                    currentDepartment.Employees.Add(currentEmployee);
                    listOfDepartments.Add(currentDepartment);
                }
                else
                {
                    int existingDepartmentIndex = listOfDepartments.FindIndex(item => item.DepartmentName == departmentName);
                    Employee currentEmployee = new Employee(employeeName, employeeSalary);
                    listOfDepartments[existingDepartmentIndex].Employees.Add(currentEmployee);
                }
            }

            // Finding the highestAverageSalary:

            double highestAverageSalary = 0;
            int deparmentIndex = -1;
            foreach (Department department in listOfDepartments)
            {
                double totalSalarySum = 0;
                double currentAverageSalary = 0;
                foreach (Employee employee in department.Employees)
                {
                    totalSalarySum += employee.Salary;
                }

                currentAverageSalary = totalSalarySum / department.Employees.Count;
                if (currentAverageSalary >= highestAverageSalary)
                {
                    highestAverageSalary = currentAverageSalary;
                    deparmentIndex = listOfDepartments.IndexOf(department);
                }
            }

            // Sorting the employees list in printing the result:
            List<Employee> sortedEmployeesList = listOfDepartments[deparmentIndex].Employees.OrderByDescending(x => x.Salary).ToList();
            Console.WriteLine($"Highest Average Salary: {listOfDepartments[deparmentIndex].DepartmentName}");
            foreach (Employee employee in sortedEmployeesList)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }
}
