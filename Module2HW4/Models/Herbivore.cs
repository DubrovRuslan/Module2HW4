using Module2HW4.Models.Enums;

namespace Module2HW4.Models
{
    public class Herbivore : Mammal
    {
        public string[] PlantSpecies { get; set; }
        public override AnimalType CurrentAnimalType { get; } = AnimalType.Herbivore;
    }
}
