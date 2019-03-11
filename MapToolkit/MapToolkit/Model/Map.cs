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
                        MergeValue(clonedMapStructure, i, j);
                    }
                }
            }

            return continentCount;
        }

        private void MergeValue(int[][] clonedMapStructure, int i, int j)
        {
            int indX = clonedMapStructure.Length;
            int indY = clonedMapStructure[0].Length;
            if (i < 0
                || i >= indX
                || j < 0
                || j >= indY
                || clonedMapStructure[i][j] != 1
                )
            {
                return;
            }

            MarkAsMerged(clonedMapStructure, i, j);

            MergeLeftValue(clonedMapStructure, i, j);
            MergeDownValue(clonedMapStructure, i, j);
            MergeRightValue(clonedMapStructure, i, j);
            MergeUpValue(clonedMapStructure, i, j);
            MergeDiagonalUpValue(clonedMapStructure, i, j);
            MergeDiagonalDowValue(clonedMapStructure, i, j);
        }

        private void MergeDiagonalDowValue(int[][] clonedMapStructure, int i, int j)
        {
            MergeValue(clonedMapStructure, i + 1, j - 1);
        }

        private void MergeDiagonalUpValue(int[][] clonedMapStructure, int i, int j)
        {
            MergeValue(clonedMapStructure, i + 1, j + 1);
        }

        private void MergeUpValue(int[][] clonedMapStructure, int i, int j)
        {
            MergeValue(clonedMapStructure, i - 1, j);
        }

        private void MergeRightValue(int[][] clonedMapStructure, int i, int j)
        {
            MergeValue(clonedMapStructure, i, j + 1);
        }

        private void MergeLeftValue(int[][] clonedMapStructure, int i, int j)
        {
            MergeValue(clonedMapStructure, i, j - 1);
        }

        private void MergeDownValue(int[][] clonedMapStructure, int i, int j)
        {
            MergeValue(clonedMapStructure, i + 1, j);
        }

        private static void MarkAsMerged(int[][] clonedMapStructure, int i, int j)
        {
            clonedMapStructure[i][j] = -1;
        }
    }
}
