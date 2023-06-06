using Module2HW4.Models;
using Module2HW4.Models.Enums;

namespace Module2HW4.Services.Abstractions
{
    public interface IRunningFarBirdService
    {
        public void AddRunningFarBird(string name, double weight, Habitat animalHabitat, int depthOfPenetrationOfHeadIntoSand);
        public Animal[] GetRunningFarBirds();
        public int RunningFarBirdsCount();
    }
}
