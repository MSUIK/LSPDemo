using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
   public  interface IManaged:IEmployee
    {
        IEmployee Manager { get; set; }
        void AssignMAnager(IEmployee manager);
    }
}
