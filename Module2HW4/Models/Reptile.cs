using Module2HW4.Models.Enums;

namespace Module2HW4.Models
{
    public class Reptile : Animal
    {
        public bool Shell { get; set; }
        public bool Scales { get; set; }
        public override AnimalType CurrentAnimalType { get; } = AnimalType.Reptile;
    }
}
