using System;
using Module2HW4.Models;
using Module2HW4.Models.Enums;

namespace Module2HW4.Helpers
{
    public static class AnimalExtension
    {
        public static Animal GetAnimalByType(this Animal animal, AnimalType type)
        {
            Animal result = null;
            if (animal.CurrentAnimalType == type)
            {
                result = animal;
            }

            return result;
        }

        public static Animal FindByName(this Animal animal, string name)
        {
            if (animal == null)
            {
                return null;
            }

            if (animal.Name.Contains(name))
            {
                return animal;
            }

            return null;
        }

        public static Animal FindByWeight(this Animal animal, double minWeight, double maxWeight)
        {
            if (animal == null)
            {
                return null;
            }

            if (animal.Weight >= minWeight && animal.Weight <= maxWeight)
            {
                return animal;
            }

            return null;
        }

        public static Animal FindByHeadPenetrationDepth(this Animal animal, double headPenetrationDepth)
        {
            var runningFarBird = animal as RunningFarBird;
            if (runningFarBird == null)
            {
                return null;
            }

            if (runningFarBird.DepthOfPenetrationOfHeadIntoSand >= headPenetrationDepth)
            {
                return runningFarBird;
            }

            return null;
        }
    }
}
