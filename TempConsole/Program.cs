using TempLibrary;

var collection = new MyCollection<int>();

for (int i = 0; i < 500; i++)
{
    collection.Add(i);
    Console.WriteLine(collection[i]);
}

Console.WriteLine(collection.Lenght);

for (int i = 300; i < collection.Lenght; i++)
{
    collection.RemoveAt(i);
}
Console.WriteLine(collection.Lenght);
