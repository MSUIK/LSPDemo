using LSPLibrary;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager accountingVP = new Manager();
            accountingVP.FirstName = "Sufyan";
            accountingVP.LastName = "Iqbal";
            accountingVP.CalculatePerHourRate(4);

            Employee emp = new Manager();
            emp.FirstName = "Tim";
            emp.LastName = "Corey";
            emp.AssignMAnager(accountingVP);
            emp.CalculatePerHourRate(2);


            Console.WriteLine($" { emp.FirstName}'s salary is ${emp.Salary }/houre");
            Console.ReadLine();
        } 
    }
}
