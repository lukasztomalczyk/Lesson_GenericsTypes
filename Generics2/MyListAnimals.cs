namespace Generics2
{
    internal class MyListAnimals<T> where T : Animal
    {
        private T[] AnimalsList;
        private int _count;
        public MyListAnimals()
        {
            _count = 0;
            AnimalsList = new T[5];
        }

        public void Add(T value)
        {
            if(_count>=5) return;
            AnimalsList[_count] = value;
            _count++;
        }

        public void ShowContent()
        {
            for (int i = 0; i < AnimalsList.Length; i++)
            {
                System.Console.WriteLine(AnimalsList[i].Name);
            }
        }
    }
}