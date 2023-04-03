using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Abstract
{
    public abstract class Dialog
    {
        public virtual void Render()
        {
            Console.WriteLine("Rendered");
        }

        public abstract IButton CreateButton();
    }
}
