using Module2HW4.Models;
using Module2HW4.Models.Enums;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Services.Abstractions;

namespace Module2HW4.Services
{
    public class FishService : IFishService
    {
        private readonly IAnimalsProvider _animalProvider;
        public FishService(IAnimalsProvider animalProvider)
        {
            _animalProvider = animalProvider;
        }

        public void AddFish(string name, double weight, Habitat animalHabitat, WaterType habitatWaterType)
        {
            var fish = new Fish
            {
                Name = name,
                Weight = weight,
                AnimalHabitat = animalHabitat,
                HabitatWaterType = habitatWaterType
            };
            _animalProvider.AddNewAnimal(fish);
        }

        public int FishesCount()
        {
            return GetFishes().Length;
        }

        public Animal[] GetFishes()
        {
            return _animalProvider.GetAnimalByType(AnimalType.Fish);
        }
    }
}
