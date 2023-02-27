using DesignPatterns.Iterator;

var collection = new AnAwesomeCollectionOfThings<string>();

collection.Add("Mark Twain");
collection.Add("Alan Turing");
collection.Add("John Byers");
collection.Add("Melvin Frohike");
collection.Add("Richard Langly");

Console.WriteLine($"There are {collection.Count} items currently in the collection");

var iterator = collection.GetIterator();

while (iterator.HasMoreItems())
{
    Console.WriteLine(iterator.Next());
}