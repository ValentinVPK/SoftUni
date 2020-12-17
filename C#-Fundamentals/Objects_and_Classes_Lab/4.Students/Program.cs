using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace _4.Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] studentInformation = command.Split();
                string firstName = studentInformation[0];
                string lastName = studentInformation[1];
                int age = int.Parse(studentInformation[2]);
                string city = studentInformation[3];
                if (IsStudentExisting(listOfStudents, firstName, lastName))
                {
                    Student student = GetExistingStudent(listOfStudents, firstName, lastName);
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = city;
                }
                else
                {
                    Student newStudent = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        City = city
                    };

                    listOfStudents.Add(newStudent);
                }
            }
            string inputCity = Console.ReadLine();
            foreach (Student student in listOfStudents)
            {
                if (student.City == inputCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
        static bool IsStudentExisting(List<Student> listOfStudents, string firstName, string lastName)
        {
            foreach (Student student in listOfStudents)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

        static Student GetExistingStudent(List<Student> listOfStudents, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in listOfStudents)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }
    }
}
