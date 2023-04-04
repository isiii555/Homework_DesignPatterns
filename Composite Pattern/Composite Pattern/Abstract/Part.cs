using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern.Abstract
{
    public abstract class Part
    {
        protected string _brand;

        protected double _price;

        public Part(string brand,double price) {
            _brand = brand;
            _price = price;
        }

        public string GetBrand() => _brand;
        public virtual double GetPrice() => _price;
    }
}
