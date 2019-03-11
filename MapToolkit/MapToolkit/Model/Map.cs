namespace MapToolkit.Model
{
    public class Map : IComputeContinent
    {
        private readonly int[][] _mapStructure;

        public Map(int[][] mapStructure)
        {
            _mapStructure = mapStructure;
        }

        public int ComputeContinent()
        {
            if (_mapStructure == null || _mapStructure.Length == 0 || _mapStructure[0].Length == 0)
                return 0;

            int indX = _mapStructure.Length;
            int indY = _mapStructure[0].Length;
            int continentCount = 0;
            for (int i = 0; i < indX; i++)
            {
                for (int j = 0; j < indY; j++)
                {
                   if(_mapStructure[i][j]==1)
                    {
                        continentCount++;
                    }
                }
            }

            return continentCount;
        }
    }
}
