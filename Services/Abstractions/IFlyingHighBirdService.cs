using Module2HW4.Models;
using Module2HW4.Models.Enums;

namespace Module2HW4.Services.Abstractions
{
    public interface IFlyingHighBirdService
    {
        public void AddFlyingHighBird(string name, double weight, Habitat animalHabitat, int flightAltitudeWithoutKick);
        public Animal[] GetFlyingHighBirds();
        public int FlyingHighBirdsCount();
    }
}
