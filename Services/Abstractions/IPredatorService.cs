using Module2HW4.Models;
using Module2HW4.Models.Enums;

namespace Module2HW4.Services.Abstractions
{
    public interface IPredatorService
    {
        public void AddPredator(string name, double weight, Habitat animalHabitat, string[] victims);
        public Animal[] GetPredators();
        public int PredatorsCount();
    }
}
