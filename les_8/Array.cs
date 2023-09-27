using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace les_8
{
    internal class Array<T> where T : struct
    {
        public int Size { get; set; }
        private T[] _arr;
        public Array(int size)
        {
            _arr = new T[size];
            Size = size;
        }
        public T this[int i]
        {
            get { return _arr[i]; }

            set { _arr[i] = value; }
        }
        public static Array<T> operator +(Array<T> a, Array<T> b)
        {
            Array<T> result = new Array<T>(a.Size);

            for (int i = 0; i < a.Size; ++i)
            {
                result[i] = (dynamic)a[i] + b[i];
            }

            return result;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < Size; ++i)
            {
                sb.Append(this[i]);
                sb.Append(" ");
            }

            return sb.ToString();
        }
    }
}
