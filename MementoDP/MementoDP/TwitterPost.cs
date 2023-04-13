using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDP
{
    public class TwitterPost
    {

        public string? Topic { get; set; }

        public int LetterCount { get; set; }

        public TwitterPostMementoTaker MementoTakerUndo;

        public TwitterPostMementoTaker MementoTakerRedo;
        public TwitterPost(TwitterPostMementoTaker mementoTakerUndo, TwitterPostMementoTaker mementoTakerRedo)
        {
            MementoTakerUndo = mementoTakerUndo;
            MementoTakerRedo = mementoTakerRedo;
        }
        
        public void Save()
        {
            MementoTakerUndo.SetMemento(new TwitterPostMemento(Topic, LetterCount));
        }

        public void Undo()
        {
            Console.WriteLine("Undo");
            MementoTakerRedo.SetMemento(new TwitterPostMemento(Topic, LetterCount));
            var mementoResult = MementoTakerUndo.GetMemento();
            this.Topic = mementoResult.Topic;
            this.LetterCount = mementoResult.LetterCount;
        }

        public void Redo()
        {
            Console.WriteLine("Redo");
            MementoTakerUndo.SetMemento(new TwitterPostMemento(Topic, LetterCount));
            var mementoResult = MementoTakerRedo.GetMemento();
            this.Topic = mementoResult.Topic;
            this.LetterCount = mementoResult.LetterCount;
        }

        public override string ToString()
        {
            return $"Post topic : {Topic},Letter count : {LetterCount}";
        }
    }
}
