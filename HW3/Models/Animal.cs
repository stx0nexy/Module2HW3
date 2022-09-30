using System;

namespace HW3.Models
{
    public abstract class Animal : IComparable<Animal>
    {
        public string Name { get; protected set; }
        public int Weight { get; protected set; }

        public int CompareTo(Animal animal)
        {
            if (Weight >= animal.Weight)
            {
                if (Weight == animal.Weight)
                {
                    return 0;
                }
                return 1;
            }
            return -1;
        }
    }
}
