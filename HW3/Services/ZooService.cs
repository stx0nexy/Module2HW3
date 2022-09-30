using HW3.Models;
using System;

namespace HW3.Services
{
    class ZooService: IZooService
    {
        private Animal[] _animals;
        public ZooService()
        {
        }

        public string Name { get; set; }

        public bool Add(Animal item)
        {
            if (_animals == null)
            {
                _animals = new Animal[1];
                _animals[0] = item;
            }
            else
            {
                Array.Resize(ref _animals, _animals.Length + 1);
                _animals[_animals.Length - 1] = item;
            }

            return true;
        }

        public bool Sort()
        {
            if (_animals.Length <= 1)
            {
                return false;
            }

            Array.Sort(_animals);

            return true;
        }

        public Animal[] Get()
        {
            var animals = new Animal[_animals.Length];

            for (var i = 0; i < _animals.Length; i++)
            {
                animals[i] = _animals[i];
            }

            return animals;
        }

        public int GetWeight()
        {
            var sum = 0;

            for (var i = 0; i < _animals.Length; i++)
            {
                sum += _animals[i].Weight;
            }

            return sum;
        }

        public void Clean()
        {
            _animals = new Animal[0];
        }
    }
}
