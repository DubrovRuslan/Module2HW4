using Module2HW4.Models.Enums;

namespace Module2HW4.Models
{
    public class FlyingHighBird : Bird
    {
        public int FlightAltitudeWithoutKick { get; set; }
        public override AnimalType CurrentAnimalType { get; } = AnimalType.FlyingHighBird;
    }
}
