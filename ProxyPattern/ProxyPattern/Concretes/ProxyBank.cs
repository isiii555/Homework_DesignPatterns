using ProxyPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Concretes
{
    internal class ProxyBank : IBank
    {
        private Bank bank;

        public ProxyBank(string name, string password)
        {
            Name = name;
            Password = password;
        }

        private string Name { get; set; }

        private string Password { get; set; }

        public bool CheckAcess()
        {
            if (Name == "islam" && Password == "islam123")
            {

                return true;
            }
            return false;
        }

        public void SendMoney(double amount)
        {
            if (CheckAcess())
            {
                bank = new();
                bank.SendMoney(amount);
                return;
            }
            Console.WriteLine("Your username or password is invalid");
        }
    }
}
