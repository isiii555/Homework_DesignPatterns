using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDP
{
    public class TwitterPostMementoTaker
    {
        public Stack<TwitterPostMemento> TwitterPostMementos = new();

        public TwitterPostMemento GetMemento() => TwitterPostMementos.Pop();

        public void SetMemento(TwitterPostMemento memento)
        {
            TwitterPostMementos.Push(memento);
        }
    }
}
