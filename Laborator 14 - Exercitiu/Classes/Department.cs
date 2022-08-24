using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_14___Exercitiu
{
    class Departments
    {
        List<string> deparments = new List<string>(5) { "Development", "Testing", "HumanResources", "Maintenance", "Logistics" };

        public Departments(List<string> deparments)
        {
            this.deparments = deparments;
        }
    }
}