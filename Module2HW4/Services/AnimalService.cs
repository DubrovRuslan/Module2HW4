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

        public Animal[] GetFishes()
        {
            return _animalProvider.GetAnimalByType(AnimalType.Fish);
        }

        public Animal[] GetReptiles()
        {
            return _animalProvider.GetAnimalByType(AnimalType.Reptile);
        }

        public Animal[] GetFlyingHighBirds()
        {
            return _animalProvider.GetAnimalByType(AnimalType.FlyingHighBird);
        }

        public Animal[] GetRunningFarBirds()
        {
            return _animalProvider.GetAnimalByType(AnimalType.RunningFarBird);
        }

        public Animal[] GetPredators()
        {
            return _animalProvider.GetAnimalByType(AnimalType.Predator);
        }

        public Animal[] GetHerbivores()
        {
            return _animalProvider.GetAnimalByType(AnimalType.Herbivore);
        }

        public int FishesCount()
        {
            return GetFishes().Length;
        }

        public int ReptilesCount()
        {
            return GetReptiles().Length;
        }

        public int FlyingHighBirdsCount()
        {
            return GetFlyingHighBirds().Length;
        }

        public int RunningFarBirdsCount()
        {
            return GetRunningFarBirds().Length;
        }

        public int PredatorsCount()
        {
            return GetPredators().Length;
        }

        public int HerbivoresCount()
        {
            return GetHerbivores().Length;
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
