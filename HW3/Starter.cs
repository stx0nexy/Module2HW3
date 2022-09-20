using HW3.Extensions;
using HW3.Models;
using HW3.Services;
using System;

namespace HW3
{
    class Starter
    {
        private readonly ZooService _zooService;
        public Starter()
        {
            _zooService = new ZooService() { Name = "Zoo" };
        }
        public void Run()
        {
            Animal[] animals = new Animal[3];
            animals[0] = new AnimalCell("Tiger", 50, TypeHabitat.soil, MammalSubclasses.Theria, "medium");
            animals[1] = new AnimalCell("Lion", 90, TypeHabitat.soil, MammalSubclasses.Theria, "big");
            animals[2] = new AnimalCell("Delphin", 150, TypeHabitat.water, MammalSubclasses.Theria, "small");
            _zooService.Add(animals[0]);
            _zooService.Add(animals[1]);
            _zooService.Add(animals[2]);

            Console.WriteLine($"{_zooService.Name} contains {_zooService.GetWeight()} kg of animals");

            _zooService.Sort();

            Animal[] animals1 = _zooService.Get().Find(50);
            Animal[] animals2 = _zooService.Get().Find(MammalSubclasses.Theria);
        }

    }
}
