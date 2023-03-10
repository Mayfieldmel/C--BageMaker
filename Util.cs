
// Import correct packages
using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using SkiaSharp;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
    class Util
    {
        // Add List parameter to method
        public static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
            }
        }

        public static void MakeCSV(List<Employee> employees)
        {
            // Check to see if folder exists
            if (!Directory.Exists("data"))
            {
                // If not, create it
                Directory.CreateDirectory("data");
            }
            // write to CSV file (employees.csv)
            using (StreamWriter file = new StreamWriter("data/employees.csv"))
            {
                file.WriteLine("ID,Name,PhotoUrl");

                // Loop over employees
                for (int i = 0; i < employees.Count; i++)
                {
                    string template = "{0},{1},{2}";
                    file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
                }
            }
        }

        async public static Tasks MakeBadges(List<Employee> employees)
        {
            // Create image
            SKImage newImage = SKImage.FromEncodedData(File.OpenRead("badge.png"));
            SKData data = newImage.Encode();
            data.SaveTo(File.OpenWrite("data/employeeBadge.png"));
            // instance of HttpClient is disposed after code in the block has run
            using(HttpClient client = new HttpClient())
            {
                for (int i = 0; i < employees.Count; i++) 
                {

                }
            }
        }
    }
}