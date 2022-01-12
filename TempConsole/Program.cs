using TempLibrary;

var collection = new List<int>();

for (int i = 0; i < 500; i++)
{
    collection.Add(i);
    Console.WriteLine(collection[i]);
}

Console.WriteLine(collection.Count);

for (int i = 300; i < collection.Count; i++)
{
    collection.RemoveAt(i);
}
Console.WriteLine(collection.Count);
