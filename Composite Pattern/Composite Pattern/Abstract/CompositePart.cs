using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern.Abstract
{
    public abstract class CompositePart : Part
    {
        public List<Part> Parts = new();
        public CompositePart(string brand,double price) : base(brand,price)
        {
        }
        public void AddPart(Part part)
        {
            Parts.Add(part);
        }

        public void RemovePart(Part part)
        {
            Parts.Remove(part);
        }

        public override double GetPrice()
        {
            Console.WriteLine($"{_brand} : {_price}");
            double sumPrice = 0;
            foreach (var part in Parts)
            {
                Console.Write("\t");
                Console.WriteLine($"{part.GetBrand()} : {part.GetPrice()}");
            }
            Console.WriteLine($"SUMMARY : {sumPrice}");
            return sumPrice;
        }
    }
}
