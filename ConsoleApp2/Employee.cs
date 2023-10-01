using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Employee
    {
        private string lastName;
        private string firstName;

        public Employee(string lastName, string firstName)
        {
        this.lastName = lastName;
        this.firstName = firstName;
        }
      
        public void CalculateSalaryAndTax(string position, int experience) 
        {
        double baseSalary = 0;
            double tax = 0;

            switch (position) 
            {
                case "Manager":
                    baseSalary = 50000; break;
                case "Developer":
                    baseSalary = 60000; break;
                case "Designer":
                    baseSalary = 55000; break;
                default:
                    Console.WriteLine("Невідома посада");
                    return;
            }
            if (experience >= 0) 
            {
                tax = baseSalary * 0.15;
            }
            else 
            {
                tax = baseSalary * 0.20;
            }
            Console.WriteLine("Інформація про співробітника:");
            Console.WriteLine("lastName");
            Console.WriteLine("firstName");
            Console.WriteLine("position");
            Console.WriteLine("baseSalary:C");
            Console.WriteLine("tax:C");
        }
       
    }
}
