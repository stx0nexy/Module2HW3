namespace HW3.Models
{
    class Mammals : Animal
    {
        public Mammals(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }
        public MammalSubclasses Subclass { get; set; }
    }
}
