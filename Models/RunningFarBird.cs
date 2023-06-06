using Module2HW4.Models.Enums;

namespace Module2HW4.Models
{
    public class RunningFarBird : Bird
    {
        public int DepthOfPenetrationOfHeadIntoSand { get; set; }
        public override AnimalType CurrentAnimalType { get; } = AnimalType.RunningFarBird;
    }
}
