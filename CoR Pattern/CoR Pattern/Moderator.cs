using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR_Pattern
{
    public class Moderator : Employee
    {
        public Moderator(string name) : base(name)
        {

        }

        public override void Process(Withdraw req)
        {
            if(req.Amount < 400)
                Console.WriteLine($"Request accepted by : {Name}\nTransaction id : {req.Id}\nTransaction amount : {req.Amount}");
            else
            {
                Console.WriteLine($"Request sent to {NextApprover?.Name}");
                NextApprover?.Process(req);
            }
        }
    }
}
