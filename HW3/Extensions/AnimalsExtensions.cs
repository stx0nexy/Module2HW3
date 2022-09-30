using HW3.Models;
using System;

namespace HW3.Extensions
{
    public static class AnimalsExtensions
    {
        public static Animal[] Find(this Animal[] items, int weight)
        {
            Animal[] animal = new Animal[0];

            for (var i = 0; i < items.Length; i++)
            {
                if (items[i].Weight == weight)
                {
                    if (animal.Length == 0)
                    {
                        animal = new Animal[1];
                        animal[0] = items[i];
                    }
                    else
                    {
                        Array.Resize(ref animal, animal.Length + 1);
                        animal[animal.Length - 1] = items[i];
                    }
                }
            }

            return animal;
        }
        public static Animal[] Find(this Animal[] items, MammalSubclasses mammalSubclasses)
        {
            Animal[] animals = new Animal[0];

            for (var i = 0; i < items.Length; i++)
            {
                var animal = items[i] as Mammals;

                if (animal != null && animal.Subclass == mammalSubclasses)
                {
                    if (animals.Length == 0)
                    {
                        animals = new Animal[1];
                        animals[0] = items[i];
                    }
                    else
                    {
                        Array.Resize(ref animals, animals.Length + 1);
                        animals[animals.Length - 1] = items[i];
                    }
                }
            }

            return animals;
        }
    }
}
