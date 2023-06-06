using Module2HW4.Models;
using Module2HW4.Models.Enums;

namespace Module2HW4.Services.Abstractions
{
    public interface IFishService
    {
        public void AddFish(string name, double weight, Habitat animalHabitat, WaterType habitatWaterType);
        public Animal[] GetFishes();
        public int FishesCount();
    }
}
