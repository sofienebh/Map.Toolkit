using System;

namespace MapToolkit.Model
{
    public class Map : IComputeContinent
    {
        private readonly Point[][] _mapStructure;

        public Map(Point[][] mapStructure)
        {
            _mapStructure = mapStructure;
        }

        public int ComputeContinent()
        {
            Point[][] clonedMapStructure = (Point[][])_mapStructure?.Clone();

            if (clonedMapStructure == null || clonedMapStructure.Length == 0 || clonedMapStructure[0].Length == 0)
                return 0;

            int indX = clonedMapStructure.Length;
            int indY = clonedMapStructure[0].Length;
            int continentCount = 0;

            for (int i = 0; i < indX; i++)
            {
                for (int j = 0; j < indY; j++)
                {
                    var cuurentPoint = clonedMapStructure[i][j];
                    if (cuurentPoint.IsEarth)
                    {
                        continentCount++;
                        cuurentPoint.MergeValue(clonedMapStructure, i, j);
                    }
                }
            }

            return continentCount;
        }





    }
}
