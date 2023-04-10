using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR_Pattern
{
    public class Withdraw
    {
        public Withdraw(int ıd, double amount)
        {
            Id = ıd;
            Amount = amount;
        }

        public int Id { get; set; }
        public double Amount { get; set; }

    }
}
