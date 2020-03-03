using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
    public class Manager:Employee,IManaged
    {
        

        public override void CalculatePerHourRate(int rank)
        {
            decimal basAmount = 19.75M;
            Salary = basAmount + (rank * 4);
        }

        public void GenratePerformanceReview()
        {
            Console.WriteLine("I am reviewing a direct report's performance.");
        }
    }
}
