using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_14___Exercitiu
{
   public class Employee
    {
        private string name;
        private Guid id;
        private double salary;
        private string department;

        public string Name { get; private set; }
        public Guid Id { get; set; }
        public double Salary { get; set; }
        public string Department { get; }


        public Employee(string Name, double Salary, string Department)
        {
            this.name = Name;
            this.id = Guid.NewGuid();
            this.salary = Salary;
            this.department = Department;
        }

        public override string ToString()
        {
            return $"Name: {this.name} \n Id: {this.id} \n Salary: {this.salary} \n Department: {this.department}";
        }
    }
}
