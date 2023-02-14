namespace EnumeratorIterators
{
    internal class Temp:IComparable
    {
        private int _value;
        public Temp(int value)
        {
            _value = value;
        }
        public int Value => _value ;

        public int CompareTo(object? obj)
        {
            if (obj == null) return 1 ;
            var temp=obj as Temp;
            if (temp == null) throw new ArgumentNullException();
            
            return this.Value.CompareTo(temp.Value);
        }
    }
}
