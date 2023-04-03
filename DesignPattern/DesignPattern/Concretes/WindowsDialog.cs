using DesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Concretes
{
    public class WindowsDialog : Dialog
    {
        public override void Render()
        {
            Console.WriteLine("WindowsDialog");
        }
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
