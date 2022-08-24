using System;
using System.Collections.Generic;

namespace Laborator_14___Exercitiu
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ManagementSystem hrSystem = ManagementSystem.getInstance;
                hrSystem.AddEmployee(new Employee("Mihai", 25000, "Development"));
                hrSystem.AddEmployee(new Employee("Ana", 45000, "Logistics"));
                hrSystem.AddEmployee(new Employee("Bogdan", 75000, "Logistics"));
                hrSystem.AddEmployee(new Employee("Rares", 125000, "Maintenance"));
                hrSystem.AddEmployee(new Employee("Alex", 250000, "Testing"));
                hrSystem.AddEmployee(new Employee("Madalina", 250000, "Development"));
                hrSystem.AddEmployee(new Employee("Tomas", 250000, "Testing"));
                hrSystem.AddEmployee(new Employee("Alexandra", 250000, "Testing"));
                hrSystem.RemoveEmployee();

                hrSystem.RemoveEmployee();

                hrSystem.GetNoOfWellPayedEmployees(2000);
                hrSystem.GetEmployeesByDepartment("Logistics");
                hrSystem.GetMaxSalary();
                hrSystem.GetMaxSalaryDepartment("Testing");
                hrSystem.GetTotalCost();
                hrSystem.GetCostForDepartment("Development");
                hrSystem.IncreaseSalary(Guid.NewGuid(), 53);
                hrSystem.IncreaseSalaryDepartment("Logistics", 35);
            }
            catch (NullException n)
            {
                Console.WriteLine(n);
            }
            catch (InvalidAccountException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
