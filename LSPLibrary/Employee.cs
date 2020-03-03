using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
    public class Employee : BaseEmployee, IManaged
    {
 
        public IEmployee Manager { get; set; } = null;


       

        public  void AssignMAnager(IEmployee manager)
        {
            Manager = manager;

        }
    }
}
