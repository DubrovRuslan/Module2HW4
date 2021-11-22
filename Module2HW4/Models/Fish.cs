using Module2HW4.Models.Enums;

namespace Module2HW4.Models
{
    public class Fish : Animal
    {
        public WaterType HabitatWaterType { get; set; }
        public int HabitatDepth { get; set; }
        public override AnimalType CurrentAnimalType { get; } = AnimalType.Fish;
    }
}
