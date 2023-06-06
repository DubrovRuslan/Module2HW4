using Module2HW4.Models;
using Module2HW4.Models.Enums;

namespace Module2HW4.Services.Abstractions
{
    public interface IAnimalService
    {
        public void SortAniAnimalByName();
        public Animal[] FindAnimalsByName(string name);
        public Animal[] FindAnimalsByWeight(double minWeight, double maxWeight);
        public Animal[] FindAnimalsByHeadPenetrationDepth(double headPenetrationDepth);
    }
}
