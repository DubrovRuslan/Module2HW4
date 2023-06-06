using Module2HW4.Models.Enums;

namespace Module2HW4.Models
{
    public class Predator : Mammal
    {
        public string[] Victims { get; set; }
        public override AnimalType CurrentAnimalType { get; } = AnimalType.Predator;
    }
}
