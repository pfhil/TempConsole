namespace TempLibrary
{
    public class MyCollection<T>
    {
        private T[] Collection;
        public uint Lenght { get; private set; } = 0;

        public MyCollection(uint lenght = 10)
        {
            Collection = new T[lenght];
        }

        public void Add(T item)
        {
            if (Lenght == Collection.Length)
            {
                var newCollection = new T[(int)(Collection.Length * 1.5)];
                Collection.CopyTo(newCollection, 0);
                Collection = newCollection;
            }
            Collection[Lenght++] = item;
        }

        public void RemoveAt(int index)
        {
            if (index >= Lenght || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Lenght--;
            for (int i = index; i < Lenght; i++)
            {
                Collection[i] = Collection[i+1];
            }
        }

        public T this[int index]
        {
            get { return Collection[index]; }
            set { Collection[index] = value; }
        }
    }
}