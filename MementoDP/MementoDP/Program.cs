using MementoDP;

TwitterPost post = new(new TwitterPostMementoTaker(), new TwitterPostMementoTaker()) 
{
    Topic = "Environment",
    LetterCount = 50
};

post.Save();
Console.WriteLine(post);
post.LetterCount += 50;
post.Topic = "Nature";
Console.WriteLine(post);
post.Undo();
Console.WriteLine(post);
post.Redo();
Console.WriteLine(post);
post.Save();
post.LetterCount += 100;
Console.WriteLine(post);
post.Undo();
Console.WriteLine(post);
post.Redo();
Console.WriteLine(post);