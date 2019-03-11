namespace MapToolkit.Model
{
    public class Map : IComputeContinent
    {
        private readonly int[][] _structure;

        public Map(int[][] mapStructure)
        {
            _structure = mapStructure;
        }

        public int ComputeContinent()
        {
            return 0;
        }
    }
}
