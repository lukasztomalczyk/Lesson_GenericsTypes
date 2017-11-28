using System;

namespace Generics2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListaAnimals = new MyListAnimals<Animal>();
                ListaAnimals.Add(new Animal() {Age = 1, Name = "Anita"});
                ListaAnimals.Add(new Animal() {Age = 12, Name = "Kejti"});

                ListaAnimals.ShowContent();

        }
    }
}
