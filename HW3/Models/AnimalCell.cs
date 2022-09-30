namespace HW3.Models
{
    class AnimalCell: Habitat
    {
        public string CellSize { get; protected set; }
        public AnimalCell(string Name, int weight, TypeHabitat habitat, MammalSubclasses mammal, string cellSize): base(Name, weight, mammal, habitat)
        {
            CellSize = cellSize;
        }
        
    }
}
