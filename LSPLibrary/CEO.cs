using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
    public class CEO:Employee
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal basAmount = 150M;
            Salary = basAmount *rank;
        }

        public override void AssignMAnager(Employee manager)
        {
            throw new InvalidOperationException("The Ceo has no manager");
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
