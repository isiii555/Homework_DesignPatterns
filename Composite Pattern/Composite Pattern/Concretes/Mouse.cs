using Composite_Pattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern.Concretes
{
    internal class Mouse : Part
    {
        public Mouse(string brand, double price) : base(brand, price)
        {
        }
    }
}
