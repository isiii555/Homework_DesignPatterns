using DesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Concretes
{
    public class HTMLButton : IButton
    {
        public void OnClick()
        {
            Console.WriteLine("HTMLButton");
        }

        public void Render()
        {
            Console.WriteLine("HTMLButton");
        }
    }
}
