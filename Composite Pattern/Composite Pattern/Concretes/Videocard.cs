using Composite_Pattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern.Concretes
{
    public class Videocard : Part
    {
        public Videocard(string brand, double price) : base(brand, price)
        {
        }
    }
}
