namespace MapToolkit.Model
{
    public class Point
    {
        private int _value;
        public Point(int value)
        {
            _value = value;
        }
        public bool IsEmpty { get { return _value == 0; } }
        public bool IsMarked { get { return _value == -1; } }
        public bool IsEmptyOrMarked { get { return IsEmpty || IsMarked; } }

        public void Mark()
        {
            _value = -1;
        }


    }
}