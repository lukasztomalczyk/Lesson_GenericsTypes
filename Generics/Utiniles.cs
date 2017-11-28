using System;

namespace Generics
{
    class Utiniles<T> where T : IComparable
    {
        public int Max(int a, int b)
        {
            return a > 0 ? a : b;
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}