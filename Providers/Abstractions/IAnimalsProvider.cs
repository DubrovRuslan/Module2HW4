using Module2HW4.Models;
using Module2HW4.Models.Enums;

namespace Module2HW4.Providers.Abstractions
{
    public interface IAnimalsProvider
    {
        public Animal[] GetAnimals();
        public Animal[] GetAnimalByType(AnimalType type);
        public void AddNewAnimal(Animal animal);
    }
}
