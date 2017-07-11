using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyTreeSalary
{
    public class Employee
    {
        public Employee(string name)
        {
            this.Name = name;
            this.Salary = 1;
            this.Subordinates = new List<Employee>();
        }

        public List<Employee> Subordinates { get; private set; }

        public string Name { get; set; }

        public int Salary { get; set; }
        
    }
}
