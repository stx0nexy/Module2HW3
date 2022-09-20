using HW3.Models;

namespace HW3.Services
{
    public interface IZooService
    {
        bool Add(Animal item);
        bool Sort();
        Animal[] Get();
        int GetWeight();
        void Clean();
    }
}
