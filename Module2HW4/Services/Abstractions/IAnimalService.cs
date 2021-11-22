using Module2HW4.Models;
using Module2HW4.Models.Enums;

namespace Module2HW4.Services.Abstractions
{
    public interface IAnimalService
    {
        public void AddFish(string name, double weight, Habitat animalHabitat, WaterType habitatWaterType);
        public void AddReptile(string name, double weight, Habitat animalHabitat, bool shell, bool scales);
        public void AddFlyingHighBird(string name, double weight, Habitat animalHabitat, int flightAltitudeWithoutKick);
        public void AddRunningFarBird(string name, double weight, Habitat animalHabitat, int depthOfPenetrationOfHeadIntoSand);
        public void AddPredator(string name, double weight, Habitat animalHabitat, string[] victims);
        public void AddHerbivore(string name, double weight, Habitat animalHabitat, string[] plantSpecies);
        public Animal[] GetFishes();
        public Animal[] GetReptiles();
        public Animal[] GetFlyingHighBirds();
        public Animal[] GetRunningFarBirds();
        public Animal[] GetPredators();
        public Animal[] GetHerbivores();
        public int FishesCount();
        public int ReptilesCount();
        public int FlyingHighBirdsCount();
        public int RunningFarBirdsCount();
        public int PredatorsCount();
        public int HerbivoresCount();
        public void SortAniAnimalByName();
        public Animal[] FindAnimalsByName(string name);
        public Animal[] FindAnimalsByWeight(double minWeight, double maxWeight);
        public Animal[] FindAnimalsByHeadPenetrationDepth(double headPenetrationDepth);
    }
}
