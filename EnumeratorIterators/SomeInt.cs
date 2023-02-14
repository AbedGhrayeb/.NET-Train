using System.Collections;

namespace EnumeratorIterators
{
    internal class SomeInt : IEnumerable
    {
        int[] _values;
        public SomeInt(int n1, int n2, int n3, int n4, int n5)
        {
            _values = new int[] { n1, n2, n3, n4, n5 };
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in _values)
            {
                yield return item;
            }
        }
    }
}
