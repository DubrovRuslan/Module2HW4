using Module2HW4.Models.Enums;
using Module2HW4.Models;

namespace Module2HW4.Services.Abstractions
{
    public interface IHerbivoreService
    {
        public void AddHerbivore(string name, double weight, Habitat animalHabitat, string[] plantSpecies);
        public Animal[] GetHerbivores();
        public int HerbivoresCount();
    }
}
