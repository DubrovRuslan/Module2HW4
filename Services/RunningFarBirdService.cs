using Module2HW4.Models.Enums;
using Module2HW4.Models;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Services.Abstractions;

namespace Module2HW4.Services
{
    public class RunningFarBirdService : IRunningFarBirdService
    {
        private readonly IAnimalsProvider _animalProvider;
        public RunningFarBirdService(IAnimalsProvider animalProvider)
        {
            _animalProvider = animalProvider;
        }

        public void AddRunningFarBird(string name, double weight, Habitat animalHabitat, int depthOfPenetrationOfHeadIntoSand)
        {
            var runningFarBird = new RunningFarBird
            {
                Name = name,
                Weight = weight,
                AnimalHabitat = animalHabitat,
                DepthOfPenetrationOfHeadIntoSand = depthOfPenetrationOfHeadIntoSand
            };
            _animalProvider.AddNewAnimal(runningFarBird);
        }

        public Animal[] GetRunningFarBirds()
        {
            return _animalProvider.GetAnimalByType(AnimalType.RunningFarBird);
        }

        public int RunningFarBirdsCount()
        {
            return GetRunningFarBirds().Length;
        }
    }
}
