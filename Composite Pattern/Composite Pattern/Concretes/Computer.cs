using Composite_Pattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern.Concretes
{
    public class Computer : CompositePart
    {
        public Computer(string brand, double price = 0) : base(brand, price)
        {

        }

        public override double GetPrice()
        {
            Console.WriteLine($"{_brand}");
            double sumPrice = 0;
            foreach (var part in Parts)
            {
                Console.Write("\t");
                Console.WriteLine($"{part.GetBrand()} : {part.GetPrice()}");
                sumPrice += part.GetPrice();
            }
            Console.WriteLine($"SUMMARY : {sumPrice}");
            return sumPrice;
        }
    }
}
