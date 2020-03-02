using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
    public class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public object Salary { get; set; }
        public Employee Manager { get; set; } = null;


        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;
            Salary = baseAmount + (rank * 2);
        }

        public virtual void AssignMAnager(Employee manager)
        {
            Manager = manager;

        }
    }
}
