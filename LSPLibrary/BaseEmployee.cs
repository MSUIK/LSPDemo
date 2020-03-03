using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
    public abstract class BaseEmployee:IEmployee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public object Salary { get; set; }
       


        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;
            Salary = baseAmount + (rank * 2);
        }

        
        
    }
}
