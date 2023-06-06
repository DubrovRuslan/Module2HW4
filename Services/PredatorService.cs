using Module2HW4.Models.Enums;
using Module2HW4.Models;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Services.Abstractions;

namespace Module2HW4.Services
{
    public class PredatorService : IPredatorService
    {
        private readonly IAnimalsProvider _animalProvider;
        public PredatorService(IAnimalsProvider animalProvider)
        {
            _animalProvider = animalProvider;
        }

        public void AddPredator(string name, double weight, Habitat animalHabitat, string[] victims)
        {
            var predator = new Predator
            {
                Name = name,
                Weight = weight,
                AnimalHabitat = animalHabitat,
                Victims = victims
            };
            _animalProvider.AddNewAnimal(predator);
        }

        public Animal[] GetPredators()
        {
            return _animalProvider.GetAnimalByType(AnimalType.Predator);
        }

        public int PredatorsCount()
        {
            return GetPredators().Length;
        }
    }
}
