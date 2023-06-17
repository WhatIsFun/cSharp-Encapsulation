using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_PropertiesAndEncapsulation
{
    internal class Employee
    {
        public int id;
        public string name;
        public string position;
        public decimal salary;

        public Employee(int id, string name, string position, decimal salary)
        {
            this.id = id;
            this.name = name;
            this.position = position;
            this.salary = salary;
        }

        public void UpdatePosition(string newPosition)
        {
            position = newPosition;
        }
        public void UpdateSalary(decimal newSalary)
        {
            salary = newSalary;
        }
        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public string GetPosition()
        {
            return position;
        }

        public decimal GetSalary()
        {
            return salary;
        }
    }
}
