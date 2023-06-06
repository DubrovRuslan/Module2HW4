using Module2HW4.Models.Enums;
using Module2HW4.Models;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Services.Abstractions;

namespace Module2HW4.Services
{
    public class ReptileService : IReptileService
    {
        private readonly IAnimalsProvider _animalProvider;
        public ReptileService(IAnimalsProvider animalProvider)
        {
            _animalProvider = animalProvider;
        }

        public void AddReptile(string name, double weight, Habitat animalHabitat, bool shell, bool scales)
        {
            var reptile = new Reptile
            {
                Name = name,
                Weight = weight,
                AnimalHabitat = animalHabitat,
                Shell = shell,
                Scales = scales
            };
            _animalProvider.AddNewAnimal(reptile);
        }

        public Animal[] GetReptiles()
        {
            return _animalProvider.GetAnimalByType(AnimalType.Reptile);
        }

        public int ReptilesCount()
        {
            return GetReptiles().Length;
        }
    }
}
