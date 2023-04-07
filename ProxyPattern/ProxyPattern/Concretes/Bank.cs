using ProxyPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Concretes
{
    internal class Bank : IBank
    {
        public void SendMoney(double amount)
        {
            Console.WriteLine($"Transaction successfully finished : {amount}");
        }
    }
}
