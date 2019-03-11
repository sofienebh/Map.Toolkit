using System;

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
            int[][] clonedMapStructure = (int[][])_mapStructure?.Clone();

            if (clonedMapStructure == null || clonedMapStructure.Length == 0 || clonedMapStructure[0].Length == 0)
                return 0;

            int indX = clonedMapStructure.Length;
            int indY = clonedMapStructure[0].Length;
            int continentCount = 0;
            for (int i = 0; i < indX; i++)
            {
                for (int j = 0; j < indY; j++)
                {
                    if (clonedMapStructure[i][j] == 1)
                    {
                        continentCount++;
                        MergeLeftValue(clonedMapStructure, i, j);
                        MergeDownValue(clonedMapStructure, i, j);
                    }
                }
            }

            return continentCount;
        }

        private void MergeLeftValue(int[][] clonedMapStructure, int i, int j)
        {
            int indX = clonedMapStructure.Length;
            int indY = clonedMapStructure[0].Length;

            if (j + 1 >= indY)
            {
                return;
            }

            if (clonedMapStructure[i][j + 1] == 1)
            {
                clonedMapStructure[i][j + 1] = -1;
            }
        }

        private void MergeDownValue(int[][] clonedMapStructure, int i, int j)
        {
            int indX = clonedMapStructure.Length;
            int indY = clonedMapStructure[0].Length;

            if (i + 1 >= indX)
            {
                return;
            }

            if (clonedMapStructure[i + 1][j] == 1)
            {
                clonedMapStructure[i + 1][j] = -1;
            }
        }
    }
}
