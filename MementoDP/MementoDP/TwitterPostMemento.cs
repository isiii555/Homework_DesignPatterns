using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDP
{
    public class TwitterPostMemento
    {
        public TwitterPostMemento(string topic, int letterCount)
        {
            Topic = topic;
            LetterCount = letterCount;
        }

        public string Topic { get; set; }

        public int LetterCount { get; set; }

    }
}
