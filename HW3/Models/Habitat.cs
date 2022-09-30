namespace HW3.Models
{
    class Habitat: Mammals
    {
        public TypeHabitat HabitatRegion { get; protected set; }

        public Habitat(string name, int weight, MammalSubclasses mammal, TypeHabitat habitat) : base(name, weight)
        {
            HabitatRegion = habitat;
        }

        public void ChangeHabitat(TypeHabitat habitat)
        {
            HabitatRegion = habitat;
        }
    }
}
