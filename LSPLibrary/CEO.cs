using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
    public class CEO:BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal basAmount = 150M;
            Salary = basAmount *rank;
        }

      
        public void GenratePerformanceReview()
        {
            Console.WriteLine("I am reviewing a direct report's performance.");
        }

        public void FireSomeone()
        {
            Console.WriteLine("You are Fired");
        }
    }
}
