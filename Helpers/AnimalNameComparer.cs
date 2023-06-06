using System.Collections.Generic;
using Module2HW4.Models;

namespace Module2HW4.Helpers
{
    public class AnimalNameComparer : IComparer<Animal>
    {
        public int Compare(Animal animal1, Animal animal2)
        {
            return string.Compare(animal1.Name, animal2.Name);
        }
    }
}
