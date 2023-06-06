using Module2HW4.Models;
using Module2HW4.Models.Enums;

namespace Module2HW4.Services.Abstractions
{
    public interface IReptileService
    {
        public void AddReptile(string name, double weight, Habitat animalHabitat, bool shell, bool scales);
        public Animal[] GetReptiles();
        public int ReptilesCount();
    }
}
