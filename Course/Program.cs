using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;
using Course.Entties;

namespace Course {
    public class Program {
        public static void Main(string[] args) {
            Console.Write("Enter Department's Name: ");
            string? deptName = Console.ReadLine();

            Console.WriteLine("Enter Worker Data: ");

            Console.Write("Name: ");
            string? name = Console.ReadLine();

            Console.WriteLine("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.Write("Date (DD/MM/YY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");

            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            System.Console.WriteLine("Name: " + worker.Name);
            System.Console.WriteLine("Department: " + worker.Department.Name);
            System.Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}