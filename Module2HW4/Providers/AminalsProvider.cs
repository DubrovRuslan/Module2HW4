using Module2HW4.Helpers;
using Module2HW4.Models;
using Module2HW4.Models.Enums;
using Module2HW4.Providers.Abstractions;

namespace Module2HW4.Providers
{
    public class AminalsProvider : IAnimalsProvider
    {
        private Animal[] _animals;
        public Animal[] GetAnimals()
        {
            return _animals;
        }

        public Animal[] GetAnimalByType(AnimalType type)
        {
            Animal[] result = null;
            foreach (var animal in _animals)
            {
                ArrayHelper.AddElementToArray(ref result, animal.GetAnimalByType(type));
            }

            return result;
        }

        public void AddNewAnimal(Animal animal)
        {
            ArrayHelper.AddElementToArray(ref _animals, animal);
        }
    }
}
