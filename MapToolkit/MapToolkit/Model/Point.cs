namespace MapToolkit.Model
{
    public class Point
    {
        private int _value;
        private bool IsEmpty { get { return _value == 0; } }
        private bool IsMarked { get { return _value == -1; } }
        public bool IsEarth { get { return !(IsEmpty || IsMarked); } }

        public Point(int value)
        {
            _value = value;
        }

        private void Mark()
        {
            _value = -1;
        }

        public void MergeValue(Point[][] clonedMapStructure, int i, int j)
        {
            int indX = clonedMapStructure.Length;
            int indY = clonedMapStructure[0].Length;

            if (i < 0
                || i >= indX
                || j < 0
                || j >= indY
                || !clonedMapStructure[i][j].IsEarth
                )
            {
                return;
            }
            var currentPoint = clonedMapStructure[i][j];
            currentPoint.Mark();

            MergeLeftValue(clonedMapStructure, i, j);
            MergeDownValue(clonedMapStructure, i, j);
            MergeRightValue(clonedMapStructure, i, j);
            MergeUpValue(clonedMapStructure, i, j);
            MergeDiagonalUpValue(clonedMapStructure, i, j);
            MergeDiagonalDowValue(clonedMapStructure, i, j);
        }

        private void MergeDiagonalDowValue(Point[][] clonedMapStructure, int i, int j)
        {
            MergeValue(clonedMapStructure, i + 1, j - 1);
        }

        private void MergeDiagonalUpValue(Point[][] clonedMapStructure, int i, int j)
        {
            MergeValue(clonedMapStructure, i + 1, j + 1);
        }

        private void MergeUpValue(Point[][] clonedMapStructure, int i, int j)
        {
            MergeValue(clonedMapStructure, i - 1, j);
        }

        private void MergeRightValue(Point[][] clonedMapStructure, int i, int j)
        {
            MergeValue(clonedMapStructure, i, j + 1);
        }

        private void MergeLeftValue(Point[][] clonedMapStructure, int i, int j)
        {
            MergeValue(clonedMapStructure, i, j - 1);
        }

        private void MergeDownValue(Point[][] clonedMapStructure, int i, int j)
        {
            MergeValue(clonedMapStructure, i + 1, j);
        }
    }
}