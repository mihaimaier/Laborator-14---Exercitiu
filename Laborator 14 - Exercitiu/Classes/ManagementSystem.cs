using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laborator_14___Exercitiu
{
    public sealed class ManagementSystem
    {
        public Guid Id { get; private set; }
        public double Salary { get; }
        public string Department { get; }

        public List<Employee> employees = new List<Employee>();
        private static ManagementSystem instance = null;
        public static ManagementSystem getInstance
        {
            get
            {
                if (instance == null)
                    instance = new ManagementSystem();
                return instance;
            }
        }
        private ManagementSystem()
        {
        }
        public void AddEmployee(Employee employeeAdd)
        {
            if(employeeAdd == null)
            {
                throw new NullException();
            }
            employees.Add(employeeAdd);
            
        }
        public void RemoveEmployee()
        {
            if (employees.Exists(s => s.Id == Id))
            {
                Employee s = null;
                employees.Remove(s);
            }
        }
        public void GetNoOfWellPayedEmployees(double amount)
        {
            var employeesPaidWell = employees.FindAll(s => s.Salary > amount);
            employeesPaidWell.ForEach(s => Console.WriteLine(s));
        }
        public void GetEmployeesByDepartment(string department)
        {
            if(department == null)
            {
                throw new NullException();
            }
            var employeesDepartment = employees.FindAll(s => s.Department == department);
            employeesDepartment.ForEach(s => Console.WriteLine(s));

        }
        public void GetMaxSalary()
        {
            var maxSalary = employees.Max(s => s.Salary);
            var maxSalaryItem = employees.Where(s1 => s1.Salary == maxSalary);
            Console.WriteLine(maxSalaryItem);
        }
        public void GetMaxSalaryDepartment(string department)
        {
            if (department == null)
            {
                throw new NullException();
            }
            var maxSalary = employees.Max(s => s.Salary);
            var maxSalaryItem = employees.Where(s1 => s1.Salary == maxSalary);
            var maxSalaryDepartment = employees.Find(s3 => s3.Department == department);
            Console.WriteLine($"The employee from department {maxSalaryDepartment} has the highest salary of {maxSalaryItem}.");
        }
        public void GetTotalCost()
        {
            double total = employees.Sum(s => s.Salary);
            Console.WriteLine($"The total cost is: {total}.");
        }
        public void GetCostForDepartment(string department)
        {
            if (department == null)
            {
                throw new NullException();
            }
            double total = employees.Sum(s1 => s1.Salary);
            employees.ForEach(s =>
            {
                if (s.Department == department)
                {
                    Console.WriteLine(total);
                }
            });
        }
        public void IncreaseSalary(Guid Id, double percentage)
        {
            if (employees.Contains(Id))
            {
                throw new InvalidAccountException();
            }
            double additionalSalary = Salary * (percentage / 100);
            double salaryFinal = Salary + additionalSalary;
            var employeesId = employees.FindAll(s => s.Id == Id);
            employeesId.ForEach(s => Console.WriteLine(salaryFinal));
        }
        public void IncreaseSalaryDepartment(string department, double percentage)
        {
            if (department == null)
            {
                throw new NullException();
            }
            double additionalSalary = Salary * (percentage / 100);
            double salaryFinal = Salary + additionalSalary;
            employees.FindAll(s => s.Department == department);
            employees.ForEach(s => Console.WriteLine(salaryFinal));
        }
    }
}