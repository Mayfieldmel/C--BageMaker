using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        async static Task Main(string[] args) // entry point
        {
            // get employees
            List<Employee> employees = GetEmployees();
            // print employee
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
            await Util.MakeBadges(employees);
        }
        static List<Employee> GetEmployees()
        {
            // create and initialize employee list
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                // Prompt user
                Console.WriteLine("Please enter a first name: (leave empty to exit: )");
                // read input 
                string firstName = Console.ReadLine() ?? "";
                // exit loop
                if (firstName == "")
                {
                    break;
                }

                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine() ?? "";
                Console.Write("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine() ?? "");
                Console.Write("Enter Photo URL: ");
                string photoUrl = Console.ReadLine() ?? "";

                // Employee Class Instance
                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                // add current employee to list
                employees.Add(currentEmployee);
            }
            // return list of strings
            return employees;
        }
    }
}


