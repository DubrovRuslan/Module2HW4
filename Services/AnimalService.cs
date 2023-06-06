using Module2HW4.Helpers;
using Module2HW4.Models;
using Module2HW4.Models.Enums;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Services.Abstractions;

namespace Module2HW4.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalsProvider _animalProvider;
        public AnimalService(IAnimalsProvider animalProvider)
        {
            _animalProvider = animalProvider;
        }

        public void SortAniAnimalByName()
        {
            var animals = _animalProvider.GetAnimals();
            System.Array.Sort(animals, new AnimalNameComparer());
        }

        public Animal[] FindAnimalsByName(string name)
        {
            var animals = _animalProvider.GetAnimals();
            Animal[] result = null;
            foreach (var animal in animals)
            {
                ArrayHelper.AddElementToArray(ref result, animal.FindByName(name));
            }

            return result;
        }

        public Animal[] FindAnimalsByWeight(double minWeight, double maxWeight)
        {
            var animals = _animalProvider.GetAnimals();
            Animal[] result = null;
            foreach (var animal in animals)
            {
                ArrayHelper.AddElementToArray(ref result, animal.FindByWeight(minWeight, maxWeight));
            }

            return result;
        }

        public Animal[] FindAnimalsByHeadPenetrationDepth(double headPenetrationDepth)
        {
            var animals = _animalProvider.GetAnimals();
            Animal[] result = null;
            foreach (var animal in animals)
            {
                ArrayHelper.AddElementToArray(ref result, animal.FindByHeadPenetrationDepth(headPenetrationDepth));
            }

            return result;
        }
    }
}
