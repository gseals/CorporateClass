using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass
{
    public class Company
    {
        // Some properties
        public string Name { get; }
        public DateTime CreatedOn { get; }
        // Create a private property for holding a collection of current employees
        private List<string> CurrentEmployees { get; set; }

        public List<Employee> Employee { get; set; }

        // Create a method that allows a caller to add an employee
        public void AddEmployee(string employee)
        {
            var newEmployee = employee;
            CurrentEmployees.Add(newEmployee);
        }

        // Create a method that allows a caller to remove an employee
        public void RemoveEmployee(string removedEmployee)
        {
            var formerEmployee = removedEmployee;
            CurrentEmployees.Remove(formerEmployee);
        }

        // Create a method that allows a caller to retrieve the list of employees
        public void AllEmployees()
        {
            foreach (var employee in CurrentEmployees)
                Console.WriteLine($"{employee} works for your company.");
        }

        /*
        Create a constructor method that accepts two arguments:
        1. The name of the company
        2. The date it was created
        The constructor will set the value of the public properties
        */
        public Company(string name, DateTime createdOn, Employee anotherEmployee)
        {
            Name = name;
            CreatedOn = createdOn;
            Employee = new List<Employee> {anotherEmployee};
        }

    }
}
