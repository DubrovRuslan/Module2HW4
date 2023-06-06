using Module2HW4.Models.Enums;
using Module2HW4.Models;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Services.Abstractions;

namespace Module2HW4.Services
{
    public class FlyingHighBirdService : IFlyingHighBirdService
    {
        private readonly IAnimalsProvider _animalProvider;
        public FlyingHighBirdService(IAnimalsProvider animalProvider)
        {
            _animalProvider = animalProvider;
        }

        public void AddFlyingHighBird(string name, double weight, Habitat animalHabitat, int flightAltitudeWithoutKick)
        {
            var flyingHighBird = new FlyingHighBird
            {
                Name = name,
                Weight = weight,
                AnimalHabitat = animalHabitat,
                FlightAltitudeWithoutKick = flightAltitudeWithoutKick
            };
            _animalProvider.AddNewAnimal(flyingHighBird);
        }

        public Animal[] GetFlyingHighBirds()
        {
            return _animalProvider.GetAnimalByType(AnimalType.FlyingHighBird);
        }

        public int FlyingHighBirdsCount()
        {
            return GetFlyingHighBirds().Length;
        }
    }
}
