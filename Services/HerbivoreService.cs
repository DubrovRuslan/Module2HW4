using Module2HW4.Models.Enums;
using Module2HW4.Models;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Services.Abstractions;

namespace Module2HW4.Services
{
    public class HerbivoreService : IHerbivoreService
    {
        private readonly IAnimalsProvider _animalProvider;
        public HerbivoreService(IAnimalsProvider animalProvider)
        {
            _animalProvider = animalProvider;
        }

        public void AddHerbivore(string name, double weight, Habitat animalHabitat, string[] plantSpecies)
        {
            var herbivore = new Herbivore
            {
                Name = name,
                Weight = weight,
                AnimalHabitat = animalHabitat,
                PlantSpecies = plantSpecies
            };
            _animalProvider.AddNewAnimal(herbivore);
        }

        public Animal[] GetHerbivores()
        {
            return _animalProvider.GetAnimalByType(AnimalType.Herbivore);
        }

        public int HerbivoresCount()
        {
            return GetHerbivores().Length;
        }
    }
}
