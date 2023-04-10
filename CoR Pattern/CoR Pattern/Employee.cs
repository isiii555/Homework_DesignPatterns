using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR_Pattern
{
    public abstract class Employee
    {
        protected Employee? NextApprover;

        public string Name;

        protected Employee(string name)
        {
            Name = name;
        }

        public void SetNextApprover(Employee employee)
        {
            NextApprover = employee;
        }
        public abstract void Process(Withdraw req);
    }
}
